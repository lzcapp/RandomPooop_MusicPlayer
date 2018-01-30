Imports System.IO

Public Class Form3
    Dim AppPath As String = Directory.GetCurrentDirectory()
    Dim Path As String = AppPath & "\settings.txt"
    Dim ss As Integer


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Form2.AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            Form2.AxWindowsMediaPlayer1.Ctlcontrols.pause()
            Button1.Text = "Play"
            ToolStripMenuPlay.Visible = True
            ToolStripMenuPause.Visible = False
        ElseIf Form2.AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPaused Then
            Form2.AxWindowsMediaPlayer1.Ctlcontrols.play()
            Button1.Text = "Pause"
            ToolStripMenuPlay.Visible = False
            ToolStripMenuPause.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'RaiseEvent Load(Form1)

        i = CInt(Format(((nums - 1) * Rnd())))

        sn = ListBox1.Items(i)
        Form2.AxWindowsMediaPlayer1.URL = sp & "\" & sn
        Form2.AxWindowsMediaPlayer1.Ctlcontrols.play()

        Me.Text = sn
        NotifyIcon1.Text = sn '& " - Double Click to Open"
        ToolStripMenuItem3.Text = sn

        Button1.Text = "Pause"
        ToolStripMenuPlay.Visible = False
        ToolStripMenuPause.Visible = True
    End Sub

    Private Sub ButtonList_Click(sender As Object, e As EventArgs) Handles ButtonList.Click, ButtonList.Click
        ListBox1.Show()

        Button3.SetBounds(12, 247, 81, 48)
        ButtonList.SetBounds(99, 247, 67, 48)
        Button5.SetBounds(172, 247, 75, 48)
        Me.SetBounds(Me.Location.X, Me.Location.Y, 269, 343)

        ButtonList.Enabled = False
        ButtonList.Visible = False
        ButtonHide.Enabled = True
        ButtonHide.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form4.Show()
        Me.Enabled = False
    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Form5.Show()
        Me.Enabled = False
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.MaximumSize.Width = 275
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Me.NotifyIcon1.Visible = True
    End Sub

    Private Sub NotifyIcon1_BalloonTipClicked(sender As Object, e As EventArgs)
        Me.Show()
        NotifyIcon1.Visible = False
    End Sub

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            'ContextMenuStrip1.SetBounds(e.X, e.Y, ContextMenuStrip1.Size.Width, ContextMenuStrip1.Size.Height)
            ContextMenuStrip1.Show()
        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick_1(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        NotifyIcon1.Visible = False
    End Sub

    Private Sub ButtonDefault_Click(sender As Object, e As EventArgs) Handles ButtonDefault.Click
        'If File.Exists(Path) = True Then
        'Dim fs As New FileStream(Path, FileMode.Open)
        'Dim sr As New StreamReader(fs)
        'fw = sr.ReadToEnd.ToString
        'sr.Close()
        'fs.Close()
        'End If

        sp = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)

        Dim d As New System.IO.DirectoryInfo(sp)
        Dim f, g, h, j, k, l, m As System.IO.FileInfo
        ListBox1.Items.Clear()
        For Each f In d.GetFiles("*.mp3", IO.SearchOption.TopDirectoryOnly)
            ListBox1.Items.Add(f.Name)
        Next
        For Each g In d.GetFiles("*.wma", IO.SearchOption.TopDirectoryOnly)
            ListBox1.Items.Add(g.Name)
        Next
        For Each h In d.GetFiles("*.ape", IO.SearchOption.TopDirectoryOnly)
            ListBox1.Items.Add(h.Name)
        Next
        For Each j In d.GetFiles("*.aac", IO.SearchOption.TopDirectoryOnly)
            ListBox1.Items.Add(j.Name)
        Next
        For Each k In d.GetFiles("*.wav", IO.SearchOption.TopDirectoryOnly)
            ListBox1.Items.Add(k.Name)
        Next
        For Each l In d.GetFiles("*.flac", IO.SearchOption.TopDirectoryOnly)
            ListBox1.Items.Add(l.Name)
        Next
        For Each m In d.GetFiles("*.ogg", IO.SearchOption.TopDirectoryOnly)
            ListBox1.Items.Add(m.Name)
        Next
        For Each n In d.GetFiles("*.mid", IO.SearchOption.TopDirectoryOnly)
            ListBox1.Items.Add(n.Name)
        Next


        ListBox1.ClearSelected()

        nums = ListBox1.Items.Count

        Label1.Visible = False

        ButtonFolder.Visible = False
        ButtonDefault.Visible = False

        Button4.Visible = True

        ow = 0
    End Sub

    Private Sub ButtonFolder_Click(sender As Object, e As EventArgs) Handles ButtonFolder.Click
        FolderBrowserDialog1.ShowDialog()
        sp = FolderBrowserDialog1.SelectedPath

        If sp <> "" Then
            Dim d As New System.IO.DirectoryInfo(sp)
            Dim f, g, h, j, k, l, m As System.IO.FileInfo
            ListBox1.Items.Clear()
            For Each f In d.GetFiles("*.mp3", IO.SearchOption.TopDirectoryOnly)
                ListBox1.Items.Add(f.Name)
            Next
            For Each g In d.GetFiles("*.wma", IO.SearchOption.TopDirectoryOnly)
                ListBox1.Items.Add(g.Name)
            Next
            For Each h In d.GetFiles("*.ape", IO.SearchOption.TopDirectoryOnly)
                ListBox1.Items.Add(h.Name)
            Next
            For Each j In d.GetFiles("*.aac", IO.SearchOption.TopDirectoryOnly)
                ListBox1.Items.Add(j.Name)
            Next
            For Each k In d.GetFiles("*.wav", IO.SearchOption.TopDirectoryOnly)
                ListBox1.Items.Add(k.Name)
            Next
            For Each l In d.GetFiles("*.flac", IO.SearchOption.TopDirectoryOnly)
                ListBox1.Items.Add(l.Name)
            Next
            For Each m In d.GetFiles("*.ogg", IO.SearchOption.TopDirectoryOnly)
                ListBox1.Items.Add(m.Name)
            Next
            For Each n In d.GetFiles("*.mid", IO.SearchOption.TopDirectoryOnly)
                ListBox1.Items.Add(n.Name)
            Next


            ListBox1.ClearSelected()

            nums = ListBox1.Items.Count

            ButtonFolder.Visible = False
            ButtonDefault.Visible = False

            Label1.Visible = False

            Button4.Visible = True

            ow = 1
        End If
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        i = ListBox1.SelectedIndex

        sn = ListBox1.Items(i)
        Form2.AxWindowsMediaPlayer1.URL = sp & "\" & sn

        Button3.Enabled = True

        ListBox1.Hide()

        Button1.Enabled = True
        Button2.Enabled = True
        Button5.Enabled = True

        Button3.SetBounds(12, 72, 81, 48)
        ButtonList.SetBounds(99, 72, 67, 48)
        Button5.SetBounds(172, 72, 75, 48)

        Me.SetBounds(Me.Location.X, Me.Location.Y, 269, 170)

        ButtonList.Enabled = True
        ButtonList.Visible = True
        ButtonHide.Enabled = False
        ButtonHide.Visible = False
        Button4.Visible = False

        tt = 0

        Me.Text = sn
        NotifyIcon1.Text = sn '& " - Double Click to Open"
        ToolStripMenuItem3.Text = sn

        Button1.Text = "Pause"
        ToolStripMenuPlay.Visible = False
        ToolStripMenuPause.Visible = True
    End Sub

    Private Sub ButtonHide_Click(sender As Object, e As EventArgs) Handles ButtonHide.Click
        ListBox1.Hide()

        Button3.SetBounds(12, 72, 81, 48)
        ButtonList.SetBounds(99, 72, 67, 48)
        Button5.SetBounds(172, 72, 75, 48)

        Me.SetBounds(Me.Location.X, Me.Location.Y, 269, 170)

        ButtonList.Enabled = True
        ButtonList.Visible = True
        ButtonHide.Enabled = False
        ButtonHide.Visible = False

        Label1.Visible = False
    End Sub

    Private Sub ToolStripMenuPlay_Click(sender As Object, e As EventArgs) Handles ToolStripMenuPlay.Click
        Form2.AxWindowsMediaPlayer1.Ctlcontrols.play()
        ToolStripMenuPause.Visible = True
        ToolStripMenuPlay.Visible = False
        Button1.Text = "Pause"
    End Sub

    Private Sub ToolStripMenuPause_Click(sender As Object, e As EventArgs) Handles ToolStripMenuPause.Click
        Form2.AxWindowsMediaPlayer1.Ctlcontrols.pause()
        ToolStripMenuPause.Visible = False
        ToolStripMenuPlay.Visible = True
        Button1.Text = "Play"
    End Sub

    Private Sub ToolStripMenuMain_Click(sender As Object, e As EventArgs) Handles ToolStripMenuMain.Click
        Me.Show()
        NotifyIcon1.Visible = False
    End Sub

    Private Sub ToolStripMenuExit_Click(sender As Object, e As EventArgs) Handles ToolStripMenuExit.Click
        Form5.Show()
        Me.Enabled = False
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        i = CInt(Format(((nums - 1) * Rnd())))

        sn = ListBox1.Items(i)
        Form2.AxWindowsMediaPlayer1.URL = sp & "\" & sn
        Form2.AxWindowsMediaPlayer1.Ctlcontrols.play()

        Me.Text = sn
        NotifyIcon1.Text = sn '& " - Double Click to Open"
        ToolStripMenuItem3.Text = sn

        Button1.Text = "Pause"
        ToolStripMenuPlay.Visible = False
        ToolStripMenuPause.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        i = CInt(Format(((nums - 1) * Rnd())))

        sn = ListBox1.Items(i)
        Form2.AxWindowsMediaPlayer1.URL = sp & "\" & sn
        Form2.AxWindowsMediaPlayer1.Ctlcontrols.play()

        Me.Text = sn
        NotifyIcon1.Text = sn '& " - Double Click to Open"
        ToolStripMenuItem3.Text = sn

        Button1.Text = "Pause"
        ToolStripMenuPlay.Visible = False
        ToolStripMenuPause.Visible = True

        Button3.Enabled = True

        ListBox1.Hide()

        Button1.Enabled = True
        Button2.Enabled = True
        Button5.Enabled = True

        Button3.SetBounds(12, 72, 81, 48)
        ButtonList.SetBounds(99, 72, 67, 48)
        Button5.SetBounds(172, 72, 75, 48)

        Me.SetBounds(Me.Location.X, Me.Location.Y, 269, 170)

        ButtonList.Enabled = True
        ButtonList.Visible = True
        ButtonHide.Enabled = False
        ButtonHide.Visible = False

        tt = 0

        Me.Text = sn
        NotifyIcon1.Text = sn '& " - Double Click to Open"
        ToolStripMenuItem3.Text = sn

        Button4.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = Form2.AxWindowsMediaPlayer1.status
    End Sub
End Class