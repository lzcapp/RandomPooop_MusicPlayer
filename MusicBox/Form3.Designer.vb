<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ButtonList = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuPlay = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuPause = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuMain = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ButtonDefault = New System.Windows.Forms.Button()
        Me.ButtonFolder = New System.Windows.Forms.Button()
        Me.ButtonReload = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(16, 16)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 64)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Pause"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.Location = New System.Drawing.Point(164, 16)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(165, 64)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Random! Next"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button3.Location = New System.Drawing.Point(16, 309)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 64)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "About"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ButtonList
        '
        Me.ButtonList.Enabled = False
        Me.ButtonList.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ButtonList.Location = New System.Drawing.Point(139, 309)
        Me.ButtonList.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonList.Name = "ButtonList"
        Me.ButtonList.Size = New System.Drawing.Size(89, 64)
        Me.ButtonList.TabIndex = 3
        Me.ButtonList.Text = "List"
        Me.ButtonList.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Random! Pooop - Double Click to Open"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.ToolStripMenuPlay, Me.ToolStripMenuPause, Me.ToolStripMenuItem2, Me.ToolStripMenuMain, Me.ToolStripMenuExit, Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(226, 172)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(225, 24)
        '
        'ToolStripMenuPlay
        '
        Me.ToolStripMenuPlay.Name = "ToolStripMenuPlay"
        Me.ToolStripMenuPlay.Size = New System.Drawing.Size(225, 24)
        Me.ToolStripMenuPlay.Text = "Play"
        Me.ToolStripMenuPlay.Visible = False
        '
        'ToolStripMenuPause
        '
        Me.ToolStripMenuPause.Name = "ToolStripMenuPause"
        Me.ToolStripMenuPause.Size = New System.Drawing.Size(225, 24)
        Me.ToolStripMenuPause.Text = "Pause"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(225, 24)
        Me.ToolStripMenuItem2.Text = "Random! Next"
        '
        'ToolStripMenuMain
        '
        Me.ToolStripMenuMain.Name = "ToolStripMenuMain"
        Me.ToolStripMenuMain.Size = New System.Drawing.Size(225, 24)
        Me.ToolStripMenuMain.Text = "Open Main Program"
        '
        'ToolStripMenuExit
        '
        Me.ToolStripMenuExit.Name = "ToolStripMenuExit"
        Me.ToolStripMenuExit.Size = New System.Drawing.Size(225, 24)
        Me.ToolStripMenuExit.Text = "Exit"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(225, 24)
        Me.ToolStripMenuItem1.Text = "Close Menu"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.SystemColors.Control
        Me.ListBox1.Font = New System.Drawing.Font("宋体", 10.0!)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.ItemHeight = 17
        Me.ListBox1.Location = New System.Drawing.Point(16, 87)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(312, 208)
        Me.ListBox1.TabIndex = 6
        '
        'ButtonDefault
        '
        Me.ButtonDefault.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ButtonDefault.Location = New System.Drawing.Point(164, 17)
        Me.ButtonDefault.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonDefault.Name = "ButtonDefault"
        Me.ButtonDefault.Size = New System.Drawing.Size(165, 64)
        Me.ButtonDefault.TabIndex = 13
        Me.ButtonDefault.Text = "Default"
        Me.ButtonDefault.UseVisualStyleBackColor = True
        '
        'ButtonFolder
        '
        Me.ButtonFolder.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ButtonFolder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonFolder.Location = New System.Drawing.Point(16, 17)
        Me.ButtonFolder.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonFolder.Name = "ButtonFolder"
        Me.ButtonFolder.Size = New System.Drawing.Size(140, 64)
        Me.ButtonFolder.TabIndex = 12
        Me.ButtonFolder.Text = "Folder?"
        Me.ButtonFolder.UseVisualStyleBackColor = True
        '
        'ButtonReload
        '
        Me.ButtonReload.Enabled = False
        Me.ButtonReload.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonReload.Location = New System.Drawing.Point(164, 16)
        Me.ButtonReload.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonReload.Name = "ButtonReload"
        Me.ButtonReload.Size = New System.Drawing.Size(165, 64)
        Me.ButtonReload.TabIndex = 14
        Me.ButtonReload.Text = "Reload"
        Me.ButtonReload.UseVisualStyleBackColor = True
        Me.ButtonReload.Visible = False
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button5.Location = New System.Drawing.Point(239, 309)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(89, 64)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Hide"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 148)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "↑↑↑Choose the Folders First!↑↑↑"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button4.Location = New System.Drawing.Point(164, 17)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(165, 64)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Random!"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(65, -6)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(213, 192)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Label2"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 395)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonFolder)
        Me.Controls.Add(Me.ButtonDefault)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ButtonList)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonReload)
        Me.Controls.Add(Me.Button5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(300, 250)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(353, 442)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(353, 144)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Random! Pooop"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ButtonList As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ButtonDefault As System.Windows.Forms.Button
    Friend WithEvents ButtonFolder As System.Windows.Forms.Button
    Friend WithEvents ButtonReload As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuPlay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuMain As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuPause As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
End Class
