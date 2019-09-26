Imports System.IO
Imports Velleman.Kits.K8101
Imports System.Runtime.InteropServices


Public Class FrmMain
    'Declare global variables
    Dim displayScreen As Object
    Dim lastUpdate As DateTime
    Dim fileNameFull As String
    Dim fileName As String
    Dim filePath As String
    Dim backgroungIMG As String
    Dim displayContrast As Integer
    Dim displayBacklight As Integer
    Dim displayInverted As Boolean
    Dim shouldClose As Integer = 0
    Dim hasConnected As Boolean = False




    ' This is used to allow the button on the display to pause the playing audio, regardless of player if it supports MediaKeys
    ' https://www.dreamincode.net/forums/topic/339272-how-can-i-use-sendkeyssend-to-send-the-play-song-signal/
    Private Const KEYEVENTF_KEYDOWN As UInteger = &H0
    Private Const KEYEVENTF_KEYUP As UInteger = &H2
    <DllImport("user32.dll", EntryPoint:="keybd_event")>
    Public Shared Sub keybd_event(ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As UInteger, ByVal dwExtraInfo As UInteger)
    End Sub



    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.setFirstTime = True Then
            MsgBox("Please select your text file. For information on how to configure this application, please see http://www.github.com/martrewes/OusbSD", MessageBoxIcon.Exclamation, "First time run...")
            If ofDialog.ShowDialog() = DialogResult.OK Then
                fileNameFull = ofDialog.FileName
                filePath = Path.GetDirectoryName(fileNameFull)
                fileName = Path.GetFileName(fileNameFull)
                My.Settings.setFileNameFull = fileNameFull
                lblFileLocation.Text = fileNameFull
                My.Settings.setFileName = fileName
                My.Settings.setFilePath = filePath
                My.Settings.setInverted = False
                My.Settings.Save()
            Else shouldClose += 1
            End If



        End If
        If shouldClose = 1 Then
            Me.Close()
        Else
            'Set up variables from settings, start the file watcher, connect to the device and send the initial song info
            My.Settings.setFirstTime = False
            displayScreen = New Velleman.Kits.K8101
            fileNameFull = My.Settings.setFileNameFull
            fileName = Path.GetFileName(My.Settings.setFileNameFull)
            filePath = Path.GetDirectoryName(My.Settings.setFileNameFull)
            backgroungIMG = My.Settings.setBGImg
            displayContrast = My.Settings.setContrast
            displayBacklight = My.Settings.setBacklight
            displayInverted = My.Settings.setInverted
            lblFileLocation.Text = My.Settings.setFileNameFull


            Start()

            Dim SongChange As New FileSystemWatcher(filePath)
            SongChange.Filter = fileName
            SongChange.EnableRaisingEvents = True
            AddHandler SongChange.Changed, AddressOf SongChange_Changed
            If hasConnected = True Then SendText()
            Me.WindowState = FormWindowState.Minimized
        End If

    End Sub

    Private Sub Start()
        Connect()
        displayScreen.Backlight(255)
        displayScreen.Contrast(20)
        displayScreen.Invert(displayInverted)
    End Sub

    Private Sub Connect()
        Try
            displayScreen.Connect()
            hasConnected = True
        Catch ex As Exception
            MsgBox("No device detected! Click OK to exit the application and insert the device.", vbExclamation, "No Device")
            Me.Close()
        End Try
    End Sub

    Private Sub Disconnect()

        Try
            displayScreen.Disconnect()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub SendText()
        'Screen can hold [in text] 21 chars(l), 32 chars(s), 6 lines(l), 8 lines(s)
        Dim lineStartY As Integer = 4  'Sets the base location of the text
        Dim lineStartX As Integer = 26 'Made variable so can change location if background changes
        Dim lines() As String
        Dim textFile As New StreamReader(fileNameFull) 'Location of the foobar (maybe others) plugin txt file, will need to ensure it is a variable and saved
        Dim lineNumber As Integer = 0 'Reset line number to 0, need to check for the lines after the first to avoid "ë" showing up at the beginning of each line
        Dim charCount As Integer 'Will use to determine where that tag should go vertically
        lines = textFile.ReadToEnd.Split(Environment.NewLine) 'Read the file into lines
        displayScreen.ClearAll() 'Clear the screen
        displayScreen.DrawImage(backgroungIMG) 'First, set the background. This will need to change into the program location folder (easy enough to change at release)
        For Each line As String In lines
            charCount = line.Length 'Count the characters of that line/uses in if statement

            If charCount >= 48 Then             'Make the maximum characters 48, so they do not overlap eachother.
                line = line.Substring(0, 48)
            End If

            If lineNumber = 0 Then
                Debug.WriteLine(line)

                If charCount <= 26 Then 'If the tag will fit on one line, centre it vertically (bast on image included)
                    lineStartY += 4
                    displayScreen.DrawText(line, K8101.TextSize.Small, lineStartX, lineStartY, 128)
                    lineStartY -= 4 'Makr sure to put the base location back to default, so it can be added to
                Else displayScreen.DrawText(line, K8101.TextSize.Small, lineStartX, lineStartY, 128) 'If it's a two line tag, dont add any vertical pixels so the two lines fit
                End If

            Else Debug.WriteLine(line.Remove(0, 1)) 'Same as above, but removing the ë on subsequent lines
                If charCount <= 26 Then
                    lineStartY += 4
                    displayScreen.DrawText(line.Remove(0, 1), K8101.TextSize.Small, lineStartX, lineStartY, 128)
                    lineStartY -= 4
                Else displayScreen.DrawText(line.Remove(0, 1), K8101.TextSize.Small, lineStartX, lineStartY, 128)
                End If
            End If

            lineStartY += 20 'Add 20 as that lines up with the next tag line
            lineNumber += 1 'Ensure it is only removing ë from after the first line (0 start)

        Next
        textFile.Close()

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs)
        displayScreen.ClearAll()
    End Sub

    Private Sub SongChange_Changed(ByVal sender As Object, ByVal e As FileSystemEventArgs)
        Threading.Thread.Sleep(500) 'Had to put a delay of .5 seconds so the file doesn't appear as in use
        If DateTime.Now.Subtract(lastUpdate).TotalMilliseconds < 1000 Then Return 'Catches from running twice, without it will push two updates in quick succession
        lastUpdate = DateTime.Now
        SendText()
    End Sub

    Private Sub FrmMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            sysTrayIcon.Visible = True
            sysTrayIcon.Icon = Me.Icon
            sysTrayIcon.BalloonTipIcon = ToolTipIcon.Info
            sysTrayIcon.BalloonTipTitle = "OusbSD is running from the System Tray"
            sysTrayIcon.BalloonTipText = "Please double-click the icon for configuration"
            sysTrayIcon.ShowBalloonTip(1000)
            'Me.Hide()
            ShowInTaskbar = False
        End If
    End Sub

    Private Sub SysTrayIcon_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles sysTrayIcon.DoubleClick
        'Me.Show()
        ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        sysTrayIcon.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '   keybd_event(CByte(Keys.MediaPlayPause), 0, KEYEVENTF_KEYDOWN, 0)
        '   keybd_event(CByte(Keys.MediaPlayPause), 0, KEYEVENTF_KEYUP, 0)
        '   MsgBox("Did it pause?")
        displayScreen.Backlight(1)
        displayScreen.Contrast(10)
        Label2.Text = cbxInverted.CheckState
    End Sub

    Public Sub ShowSettings(sender As Object, e As EventArgs) Handles tsmSettings.Click
        ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        sysTrayIcon.Visible = False
    End Sub

    Private Sub TrbContrast_Scroll(sender As Object, e As EventArgs) Handles trbContrast.Scroll
        lblContrast.Text = trbContrast.Value
    End Sub

    Private Sub FrmMain_Close(sender As Object, e As EventArgs) Handles Me.Closing
        Me.Hide()
        GoodbyeMessage()
        Disconnect()
    End Sub
    'Screen can hold [in text] 21 chars(l), 32 chars(s), 6 lines(l), 8 lines(s)

    Private Sub GoodbyeMessage()
        If hasConnected = True Then
            displayScreen.ClearAll()
            displayScreen.DrawText("+-------------------+", K8101.TextSize.Large, 0, 0, 128)
            displayScreen.DrawText("| BBB  Y   Y  EEE   |", K8101.TextSize.Large, 0, 8, 128)
            displayScreen.DrawText("| B  B  Y Y   E  E  |", K8101.TextSize.Large, 0, 16, 128)
            displayScreen.DrawText("| B B    Y    E E   |", K8101.TextSize.Large, 0, 24, 128)
            displayScreen.DrawText("| BBBB   Y    EE    |", K8101.TextSize.Large, 0, 32, 128)
            displayScreen.DrawText("| B  B   Y    E     |", K8101.TextSize.Large, 0, 40, 128)
            displayScreen.DrawText("| BBB    Y    EEEE  |", K8101.TextSize.Large, 0, 48, 128)
            displayScreen.DrawText("+-------------------+", K8101.TextSize.Large, 0, 56, 128)
            Threading.Thread.Sleep(5000)
            displayScreen.ClearAll()
        End If

    End Sub

    Private Sub TsmClose_Click(sender As Object, e As EventArgs) Handles tsmClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.setFileNameFull = lblFileLocation.Text
        My.Settings.setFilePath = Path.GetDirectoryName(lblFileLocation.Text)
        My.Settings.setFileName = Path.GetFileName(lblFileLocation.Text)
        My.Settings.setBGImg = lblBGImage.Text
        My.Settings.setInverted = cbxInverted.CheckState
        My.Settings.setContrast = trbContrast.Value
        My.Settings.setBacklight = cbxBacklight.CheckState
        My.Settings.Save()
        MsgBox("Application needs to restart to apply settings", 48)
        Application.Restart()
    End Sub

    Private Sub BtnFileBrowser_Click(sender As Object, e As EventArgs) Handles btnFileBrowser.Click
        If ofDialog.ShowDialog() = DialogResult.OK Then
            lblFileLocation.Text = ofDialog.FileName
        End If
    End Sub
End Class