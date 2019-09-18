Imports System.Management
Imports Velleman.Kits
Imports System.IO


Public Class Form1
    Private Delegate Sub startDelegate()

    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)
    Private Sub Form1_Load() Handles Me.Load
        Start()

    End Sub

    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        '21 chars(l), 32 chars(s), 6 lines(l), 8 lines(s)


        Dim lineY As Integer

        Dim lines() As String
        Dim reader As New StreamReader("D:\Desktop\fooNow.txt")

        lines = reader.ReadToEnd.Split(Environment.NewLine)
        Display.ClearAll()
        For Each line As String In lines
            'Do what you want with the line
            Debug.WriteLine(line)
            Display.DrawText(line, K8101.TextSize.Small, 0, lineY, 128)
            lineY += 10
        Next
        reader.Close()





    End Sub

    Private Sub Start()

        Connect()

        Display.Backlight(255)


    End Sub

    Private Sub Connect()

        Try
            Display.Connect()
        Catch ex As Exception

            MsgBox("No device detected! Click OK to exit the application.", vbExclamation, "No Device")
            Me.Close()

        End Try

    End Sub
End Class
