<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ofDialog = New System.Windows.Forms.OpenFileDialog()
        Me.sysTrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.sysMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmFileLocation = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.sysMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'ofDialog
        '
        Me.ofDialog.AddExtension = False
        Me.ofDialog.FileName = ".txt"
        Me.ofDialog.Filter = """Text Files (*.txt)|*.txt|All Files|*.*"""
        Me.ofDialog.InitialDirectory = "%PROFILEDIR%"
        '
        'sysTrayIcon
        '
        Me.sysTrayIcon.ContextMenuStrip = Me.sysMenu
        Me.sysTrayIcon.Text = "Notify Icon"
        Me.sysTrayIcon.Visible = True
        '
        'sysMenu
        '
        Me.sysMenu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.sysMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmFileLocation})
        Me.sysMenu.Name = "sysMenu"
        Me.sysMenu.Size = New System.Drawing.Size(241, 69)
        '
        'tsmFileLocation
        '
        Me.tsmFileLocation.Name = "tsmFileLocation"
        Me.tsmFileLocation.Size = New System.Drawing.Size(240, 32)
        Me.tsmFileLocation.Text = "Text File Location..."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(135, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 97)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FrmMain"
        Me.Text = "frmMain"
        Me.sysMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ofDialog As OpenFileDialog
    Friend WithEvents sysTrayIcon As NotifyIcon
    Friend WithEvents sysMenu As ContextMenuStrip
    Friend WithEvents Button1 As Button
    Friend WithEvents tsmFileLocation As ToolStripMenuItem
End Class
