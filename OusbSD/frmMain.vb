Imports System.IO
Imports Velleman.Kits.K8101

Public Class FrmMain

    Dim Display As Object


    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display = New Velleman.Kits.K8101
        Start()

    End Sub

    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        SendText()
    End Sub

    Private Sub Start()
        Connect()

        Display.Backlight(255)
        Display.Contrast(15)
    End Sub

    Private Sub Connect()
        Try
            Display.Connect()
        Catch ex As Exception
            MsgBox("No device detected! Click OK to exit the application.", vbExclamation, "No Device")
            Me.Close()
        End Try
    End Sub

    Private Sub SendText()
        'Screen can hold [in text] 21 chars(l), 32 chars(s), 6 lines(l), 8 lines(s)


        Dim lineStartY As Integer = 4 'Sets the base location of the text

        Dim lines() As String
        Dim textFile As New StreamReader("D:\Desktop\fooNow.txt") 'Location of the foobar (maybe others) plugin txt file, will need to ensure it is a variable and saved
        Dim lineNumber As Integer = 0 'Reset line number to 0, need to check for the lines after the first to avoid "ë" showing up at the beginning of each line
        Dim charCount As Integer 'Will use to determine where that tag should go vertically
        lines = textFile.ReadToEnd.Split(Environment.NewLine) 'Read the file into lines
        Display.ClearAll() 'Clear the screen
        Display.DrawImage("D:\Documents\Visual Studio 2019\Projects\OusbSD\Background.bmp") 'First, set the background. This will need to change into the program location folder (easy enough to change at release)
        For Each line As String In lines
            charCount = line.Length 'Count the characters of that line/uses in if statement

            If charCount >= 48 Then             'Make the maximum characters 48, so they do not overlap eachother.
                line = line.Substring(0, 48)
            End If

            If lineNumber = 0 Then
                Debug.WriteLine(line)

                If charCount <= 24 Then 'If the tag will fit on one line, centre it vertically
                    lineStartY += 4
                    Display.DrawText(line, K8101.TextSize.Small, 26, lineStartY, 128)
                    lineStartY -= 4 'Makr sure to put the base location back to default, so it can be added to
                Else Display.DrawText(line, K8101.TextSize.Small, 26, lineStartY, 128) 'If it's a two line tag, dont add any vertical pixels so the two lines fit
                End If

            Else Debug.WriteLine(line.Remove(0, 1)) 'Same as above, but removing the ë on subsequent lines
                If charCount <= 24 Then
                    lineStartY += 4
                    Display.DrawText(line.Remove(0, 1), K8101.TextSize.Small, 26, lineStartY, 128)
                    lineStartY -= 4
                Else Display.DrawText(line.Remove(0, 1), K8101.TextSize.Small, 26, lineStartY, 128)
                End If
            End If

            lineStartY += 20 'Add 20 as that lines up with the next tag line
            lineNumber += 1 'Ensure it is only removing ë from after the first line (0 start)

        Next
        textFile.Close()

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Display.ClearAll()
    End Sub
End Class