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
        Me.tsmSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsmClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnFileBrowser = New System.Windows.Forms.Button()
        Me.lblFileLocation = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBGImage = New System.Windows.Forms.Button()
        Me.lblBGImage = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbxAutoStart = New System.Windows.Forms.CheckBox()
        Me.lblContrast = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.trbContrast = New System.Windows.Forms.TrackBar()
        Me.cbxInverted = New System.Windows.Forms.CheckBox()
        Me.cbxBacklight = New System.Windows.Forms.CheckBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.sysMenu.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.GroupBox3.SuspendLayout
        CType(Me.trbContrast, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout
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
        Me.sysMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmSettings, Me.ToolStripSeparator1, Me.tsmClose})
        Me.sysMenu.Name = "sysMenu"
        Me.sysMenu.Size = New System.Drawing.Size(161, 74)
        '
        'tsmSettings
        '
        Me.tsmSettings.Name = "tsmSettings"
        Me.tsmSettings.Size = New System.Drawing.Size(160, 32)
        Me.tsmSettings.Text = "Settings..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(157, 6)
        '
        'tsmClose
        '
        Me.tsmClose.Name = "tsmClose"
        Me.tsmClose.Size = New System.Drawing.Size(160, 32)
        Me.tsmClose.Text = "Exit"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(18, 294)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Playground"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnFileBrowser
        '
        Me.btnFileBrowser.Location = New System.Drawing.Point(394, 17)
        Me.btnFileBrowser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnFileBrowser.Name = "btnFileBrowser"
        Me.btnFileBrowser.Size = New System.Drawing.Size(112, 35)
        Me.btnFileBrowser.TabIndex = 2
        Me.btnFileBrowser.Text = "Browse..."
        Me.btnFileBrowser.UseVisualStyleBackColor = True
        '
        'lblFileLocation
        '
        Me.lblFileLocation.AutoSize = True
        Me.lblFileLocation.Location = New System.Drawing.Point(9, 25)
        Me.lblFileLocation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFileLocation.Name = "lblFileLocation"
        Me.lblFileLocation.Size = New System.Drawing.Size(21, 20)
        Me.lblFileLocation.TabIndex = 3
        Me.lblFileLocation.Text = "..."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblFileLocation)
        Me.GroupBox1.Controls.Add(Me.btnFileBrowser)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 18)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(516, 62)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "File Location"
        '
        'btnBGImage
        '
        Me.btnBGImage.Enabled = False
        Me.btnBGImage.Location = New System.Drawing.Point(394, 28)
        Me.btnBGImage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBGImage.Name = "btnBGImage"
        Me.btnBGImage.Size = New System.Drawing.Size(112, 35)
        Me.btnBGImage.TabIndex = 5
        Me.btnBGImage.Text = "Change..."
        Me.btnBGImage.UseVisualStyleBackColor = True
        '
        'lblBGImage
        '
        Me.lblBGImage.AutoSize = True
        Me.lblBGImage.Enabled = False
        Me.lblBGImage.Location = New System.Drawing.Point(9, 35)
        Me.lblBGImage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBGImage.Name = "lblBGImage"
        Me.lblBGImage.Size = New System.Drawing.Size(138, 20)
        Me.lblBGImage.TabIndex = 6
        Me.lblBGImage.Text = ".\Background.bmp"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBGImage)
        Me.GroupBox2.Controls.Add(Me.lblBGImage)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(18, 89)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(516, 72)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Background Image (Must be 128x64 Monochrome .bmp)"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbxAutoStart)
        Me.GroupBox3.Controls.Add(Me.lblContrast)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.trbContrast)
        Me.GroupBox3.Controls.Add(Me.cbxInverted)
        Me.GroupBox3.Controls.Add(Me.cbxBacklight)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 171)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Size = New System.Drawing.Size(516, 115)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Additional Settings"
        '
        'cbxAutoStart
        '
        Me.cbxAutoStart.AutoSize = True
        Me.cbxAutoStart.Enabled = False
        Me.cbxAutoStart.Location = New System.Drawing.Point(120, 68)
        Me.cbxAutoStart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxAutoStart.Name = "cbxAutoStart"
        Me.cbxAutoStart.Size = New System.Drawing.Size(195, 24)
        Me.cbxAutoStart.TabIndex = 5
        Me.cbxAutoStart.Text = "Auto Start /w Windows"
        Me.cbxAutoStart.UseVisualStyleBackColor = True
        '
        'lblContrast
        '
        Me.lblContrast.AutoSize = True
        Me.lblContrast.Location = New System.Drawing.Point(416, 69)
        Me.lblContrast.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblContrast.Name = "lblContrast"
        Me.lblContrast.Size = New System.Drawing.Size(27, 20)
        Me.lblContrast.TabIndex = 4
        Me.lblContrast.Text = "15"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(333, 69)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Contrast:"
        '
        'trbContrast
        '
        Me.trbContrast.Location = New System.Drawing.Point(320, 20)
        Me.trbContrast.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.trbContrast.Maximum = 25
        Me.trbContrast.Minimum = 5
        Me.trbContrast.Name = "trbContrast"
        Me.trbContrast.Size = New System.Drawing.Size(154, 69)
        Me.trbContrast.TabIndex = 2
        Me.trbContrast.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.trbContrast.Value = 15
        '
        'cbxInverted
        '
        Me.cbxInverted.AutoSize = True
        Me.cbxInverted.Location = New System.Drawing.Point(14, 68)
        Me.cbxInverted.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxInverted.Name = "cbxInverted"
        Me.cbxInverted.Size = New System.Drawing.Size(93, 24)
        Me.cbxInverted.TabIndex = 1
        Me.cbxInverted.Text = "Inverted"
        Me.cbxInverted.UseVisualStyleBackColor = True
        '
        'cbxBacklight
        '
        Me.cbxBacklight.AutoSize = True
        Me.cbxBacklight.Checked = True
        Me.cbxBacklight.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbxBacklight.Location = New System.Drawing.Point(14, 31)
        Me.cbxBacklight.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxBacklight.Name = "cbxBacklight"
        Me.cbxBacklight.Size = New System.Drawing.Size(151, 24)
        Me.cbxBacklight.TabIndex = 0
        Me.cbxBacklight.Text = "Backlight On/Off"
        Me.cbxBacklight.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(422, 294)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 35)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 572)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FrmMain"
        Me.Text = "frmMain"
        Me.sysMenu.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout
        CType(Me.trbContrast, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ofDialog As OpenFileDialog
    Friend WithEvents sysTrayIcon As NotifyIcon
    Friend WithEvents sysMenu As ContextMenuStrip
    Friend WithEvents Button1 As Button
    Friend WithEvents tsmSettings As ToolStripMenuItem
    Friend WithEvents btnFileBrowser As Button
    Friend WithEvents lblFileLocation As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBGImage As Button
    Friend WithEvents lblBGImage As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbxInverted As CheckBox
    Friend WithEvents cbxBacklight As CheckBox
    Friend WithEvents lblContrast As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents trbContrast As TrackBar
    Friend WithEvents cbxAutoStart As CheckBox
    Friend WithEvents btnSave As Button
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsmClose As ToolStripMenuItem
End Class
