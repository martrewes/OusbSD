Imports System.IO
Imports Velleman.Kits.K8101

Public Class FrmMain

    Dim Display As Object


    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display = New Velleman.Kits.K8101
        Start()
    End Sub

    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        '21 chars(l), 32 chars(s), 6 lines(l), 8 lines(s)


        Dim lineStartY As Integer = 4

        Dim lines() As String
        Dim textFile As New StreamReader("D:\Desktop\fooNow.txt")
        Dim lineNumber As Integer = 0
        Dim charCount As Integer
        lines = textFile.ReadToEnd.Split(Environment.NewLine)
        Display.ClearAll()
        Display.DrawImage("D:\Documents\Visual Studio 2019\Projects\OusbSD\Background.bmp")
        For Each line As String In lines
            charCount = line.Length
            'Do what you want with the line
            If lineNumber = 0 Then
                Debug.WriteLine(line)

                If charCount <= 24 Then
                    lineStartY += 4
                    Display.DrawText(line, K8101.TextSize.Small, 26, lineStartY, 128)
                    lineStartY -= 4
                Else Display.DrawText(line, K8101.TextSize.Small, 26, lineStartY, 128)
                End If

            Else Debug.WriteLine(line.Remove(0, 1))
                If charCount <= 24 Then
                    lineStartY += 4
                    Display.DrawText(line.Remove(0, 1), K8101.TextSize.Small, 26, lineStartY, 128)
                    lineStartY -= 4
                Else Display.DrawText(line.Remove(0, 1), K8101.TextSize.Small, 26, lineStartY, 128)
                End If
            End If

            lineStartY += 20
            lineNumber += 1

        Next
        textFile.Close()

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

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Display.ClearAll()
    End Sub
End Class