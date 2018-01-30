Public Class Form5

    Dim a As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Me.Dispose()
        'Do While a > 0
        'a = System.Runtime.InteropServices.Marshal.ReleaseComObject(Form2.AxWindowsMediaPlayer1)
        'Loop
        'Me.Close
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ow = 1 Then
            Dim d As New System.IO.DirectoryInfo(sp)
            Dim f, g, h, j, k, l, m, n As System.IO.FileInfo
            Form3.ListBox1.Items.Clear()
            For Each f In d.GetFiles("*.mp3", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(f.Name)
            Next
            For Each g In d.GetFiles("*.wma", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(g.Name)
            Next
            For Each h In d.GetFiles("*.ape", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(h.Name)
            Next
            For Each j In d.GetFiles("*.aac", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(j.Name)
            Next
            For Each k In d.GetFiles("*.wav", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(k.Name)
            Next
            For Each l In d.GetFiles("*.flac", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(l.Name)
            Next
            For Each m In d.GetFiles("*.ogg", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(m.Name)
            Next
            For Each n In d.GetFiles("*.mid", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(n.Name)
            Next

            nums = Form3.ListBox1.Items.Count

            Form3.ButtonFolder.Visible = False
            Form3.ButtonDefault.Visible = False

            Form3.Button4.Visible = False
        End If

        If ow = 0 Then
            sp = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)

            Dim d As New System.IO.DirectoryInfo(sp)
            Dim f, g, h, j, k, l, m As System.IO.FileInfo
            Form3.ListBox1.Items.Clear()
            For Each f In d.GetFiles("*.mp3", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(f.Name)
            Next
            For Each g In d.GetFiles("*.wma", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(g.Name)
            Next
            For Each h In d.GetFiles("*.ape", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(h.Name)
            Next
            For Each j In d.GetFiles("*.aac", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(j.Name)
            Next
            For Each k In d.GetFiles("*.wav", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(k.Name)
            Next
            For Each l In d.GetFiles("*.flac", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(l.Name)
            Next
            For Each m In d.GetFiles("*.ogg", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(m.Name)
            Next
            For Each n In d.GetFiles("*.mid", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(n.Name)
            Next


            Form3.ListBox1.ClearSelected()

            nums = Form3.ListBox1.Items.Count

            Form3.ButtonFolder.Visible = False
            Form3.ButtonDefault.Visible = False

            Form3.Button4.Visible = False
        End If

        Form3.Text = sn

        If Form2.AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            Form3.Button1.Text = "Pause"
            Form3.ToolStripMenuPlay.Visible = False
            Form3.ToolStripMenuPause.Visible = True
        ElseIf Form2.AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPaused Then
            Form3.Button1.Text = "Play"
            Form3.ToolStripMenuPlay.Visible = True
            Form3.ToolStripMenuPause.Visible = False
        End If

        Form3.Button3.Enabled = True

        Form3.ListBox1.Hide()

        Form3.Button1.Enabled = True
        Form3.Button2.Enabled = True
        Form3.Button5.Enabled = True

        Form3.Button3.SetBounds(12, 72, 81, 48)
        Form3.ButtonList.SetBounds(99, 72, 67, 48)
        Form3.Button5.SetBounds(172, 72, 75, 48)

        Form3.SetBounds(Form3.Location.X, Form3.Location.Y, 269, 170)

        Form3.ButtonList.Enabled = True
        Form3.Visible = True
        Form3.Enabled = False
        Form3.Visible = False
        Form3.Visible = False
        Form3.Label1.Visible = False

        tt = 0


        Form3.NotifyIcon1.Visible = True
        Form3.Enabled = True
        Form3.Hide()
        Me.Hide()
    End Sub

    Private Sub Form5_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If ow = 1 Then
            Dim d As New System.IO.DirectoryInfo(sp)
            Dim f, g, h, j, k, l, m As System.IO.FileInfo
            Form3.ListBox1.Items.Clear()
            For Each f In d.GetFiles("*.mp3", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(f.Name)
            Next
            For Each g In d.GetFiles("*.wma", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(g.Name)
            Next
            For Each h In d.GetFiles("*.ape", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(h.Name)
            Next
            For Each j In d.GetFiles("*.aac", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(j.Name)
            Next
            For Each k In d.GetFiles("*.wav", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(k.Name)
            Next
            For Each l In d.GetFiles("*.flac", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(l.Name)
            Next
            For Each m In d.GetFiles("*.ogg", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(m.Name)
            Next
            For Each n In d.GetFiles("*.mid", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(n.Name)
            Next


            nums = Form3.ListBox1.Items.Count

            Form3.ButtonFolder.Visible = False
            Form3.ButtonDefault.Visible = False

            Form3.Button4.Visible = False
        End If

        If ow = 0 Then
            sp = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)

            Dim d As New System.IO.DirectoryInfo(sp)
            Dim f, g, h, j, k, l, m As System.IO.FileInfo
            Form3.ListBox1.Items.Clear()
            For Each f In d.GetFiles("*.mp3", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(f.Name)
            Next
            For Each g In d.GetFiles("*.wma", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(g.Name)
            Next
            For Each h In d.GetFiles("*.ape", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(h.Name)
            Next
            For Each j In d.GetFiles("*.aac", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(j.Name)
            Next
            For Each k In d.GetFiles("*.wav", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(k.Name)
            Next
            For Each l In d.GetFiles("*.flac", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(l.Name)
            Next
            For Each m In d.GetFiles("*.ogg", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(m.Name)
            Next
            For Each n In d.GetFiles("*.mid", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(n.Name)
            Next


            Form3.ListBox1.ClearSelected()

            nums = Form3.ListBox1.Items.Count

            Form3.ButtonFolder.Visible = False
            Form3.ButtonDefault.Visible = False

            Form3.Button4.Visible = False
        End If

        Form3.Text = sn

        If Form2.AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            Form3.Button1.Text = "Pause"
            Form3.ToolStripMenuPlay.Visible = False
            Form3.ToolStripMenuPause.Visible = True
        ElseIf Form2.AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPaused Then
            Form3.Button1.Text = "Play"
            Form3.ToolStripMenuPlay.Visible = True
            Form3.ToolStripMenuPause.Visible = False
        End If

        Form3.Button3.Enabled = True

        Form3.ListBox1.Hide()

        Form3.Button1.Enabled = True
        Form3.Button2.Enabled = True
        Form3.Button5.Enabled = True

        Form3.Button3.SetBounds(12, 72, 81, 48)
        Form3.ButtonList.SetBounds(99, 72, 67, 48)
        Form3.Button5.SetBounds(172, 72, 75, 48)

        Form3.SetBounds(Form3.Location.X, Form3.Location.Y, 269, 170)

        Form3.ButtonList.Enabled = True
        Form3.Visible = True
        Form3.Enabled = False
        Form3.Visible = False
        Form3.Visible = False
        Form3.Label1.Visible = False

        tt = 0


        Form3.NotifyIcon1.Visible = False
        Form3.Enabled = True
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_DoubleClick(sender As Object, e As EventArgs) Handles Label1.DoubleClick
        If ow = 1 Then
            Dim d As New System.IO.DirectoryInfo(sp)
            Dim f, g, h, j, k, l, m As System.IO.FileInfo
            Form3.ListBox1.Items.Clear()
            For Each f In d.GetFiles("*.mp3", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(f.Name)
            Next
            For Each g In d.GetFiles("*.wma", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(g.Name)
            Next
            For Each h In d.GetFiles("*.ape", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(h.Name)
            Next
            For Each j In d.GetFiles("*.aac", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(j.Name)
            Next
            For Each k In d.GetFiles("*.wav", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(k.Name)
            Next
            For Each l In d.GetFiles("*.flac", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(l.Name)
            Next
            For Each m In d.GetFiles("*.ogg", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(m.Name)
            Next
            For Each n In d.GetFiles("*.mid", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(n.Name)
            Next


            nums = Form3.ListBox1.Items.Count

            Form3.ButtonFolder.Visible = False
            Form3.ButtonDefault.Visible = False

            Form3.Button4.Visible = False
        End If

        If ow = 0 Then
            sp = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)

            Dim d As New System.IO.DirectoryInfo(sp)
            Dim f, g, h, j, k, l, m As System.IO.FileInfo
            Form3.ListBox1.Items.Clear()
            For Each f In d.GetFiles("*.mp3", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(f.Name)
            Next
            For Each g In d.GetFiles("*.wma", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(g.Name)
            Next
            For Each h In d.GetFiles("*.ape", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(h.Name)
            Next
            For Each j In d.GetFiles("*.aac", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(j.Name)
            Next
            For Each k In d.GetFiles("*.wav", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(k.Name)
            Next
            For Each l In d.GetFiles("*.flac", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(l.Name)
            Next
            For Each m In d.GetFiles("*.ogg", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(m.Name)
            Next
            For Each n In d.GetFiles("*.mid", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(n.Name)
            Next


            Form3.ListBox1.ClearSelected()

            nums = Form3.ListBox1.Items.Count

            Form3.ButtonFolder.Visible = False
            Form3.ButtonDefault.Visible = False

            Form3.Button4.Visible = False
        End If

        Form3.Text = sn

        If Form2.AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            Form3.Button1.Text = "Pause"
            Form3.ToolStripMenuPlay.Visible = False
            Form3.ToolStripMenuPause.Visible = True
        ElseIf Form2.AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPaused Then
            Form3.Button1.Text = "Play"
            Form3.ToolStripMenuPlay.Visible = True
            Form3.ToolStripMenuPause.Visible = False
        End If

        Form3.Button3.Enabled = True

        Form3.ListBox1.Hide()

        Form3.Button1.Enabled = True
        Form3.Button2.Enabled = True
        Form3.Button5.Enabled = True

        Form3.Button3.SetBounds(12, 72, 81, 48)
        Form3.ButtonList.SetBounds(99, 72, 67, 48)
        Form3.Button5.SetBounds(172, 72, 75, 48)

        Form3.SetBounds(Form3.Location.X, Form3.Location.Y, 269, 170)

        Form3.ButtonList.Enabled = True
        Form3.Visible = True
        Form3.Enabled = False
        Form3.Visible = False
        Form3.Visible = False
        Form3.Label1.Visible = False

        tt = 0

        Form3.NotifyIcon1.Visible = False
        Form3.Enabled = True
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If ow = 1 Then
            Dim d As New System.IO.DirectoryInfo(sp)
            Dim f, g, h, j, k, l, m As System.IO.FileInfo
            Form3.ListBox1.Items.Clear()
            For Each f In d.GetFiles("*.mp3", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(f.Name)
            Next
            For Each g In d.GetFiles("*.wma", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(g.Name)
            Next
            For Each h In d.GetFiles("*.ape", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(h.Name)
            Next
            For Each j In d.GetFiles("*.aac", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(j.Name)
            Next
            For Each k In d.GetFiles("*.wav", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(k.Name)
            Next
            For Each l In d.GetFiles("*.flac", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(l.Name)
            Next
            For Each m In d.GetFiles("*.ogg", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(m.Name)
            Next
            For Each n In d.GetFiles("*.mid", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(n.Name)
            Next


            nums = Form3.ListBox1.Items.Count

            Form3.ButtonFolder.Visible = False
            Form3.ButtonDefault.Visible = False

            Form3.Button4.Visible = False
        End If

        If ow = 0 Then
            sp = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)

            Dim d As New System.IO.DirectoryInfo(sp)
            Dim f, g, h, j, k, l, m As System.IO.FileInfo
            Form3.ListBox1.Items.Clear()
            For Each f In d.GetFiles("*.mp3", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(f.Name)
            Next
            For Each g In d.GetFiles("*.wma", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(g.Name)
            Next
            For Each h In d.GetFiles("*.ape", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(h.Name)
            Next
            For Each j In d.GetFiles("*.aac", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(j.Name)
            Next
            For Each k In d.GetFiles("*.wav", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(k.Name)
            Next
            For Each l In d.GetFiles("*.flac", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(l.Name)
            Next
            For Each m In d.GetFiles("*.ogg", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(m.Name)
            Next
            For Each n In d.GetFiles("*.mid", IO.SearchOption.TopDirectoryOnly)
                Form3.ListBox1.Items.Add(n.Name)
            Next


            Form3.ListBox1.ClearSelected()

            nums = Form3.ListBox1.Items.Count

            Form3.ButtonFolder.Visible = False
            Form3.ButtonDefault.Visible = False

            Form3.Button4.Visible = False
        End If

        Form3.Text = sn

        If Form2.AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            Form3.Button1.Text = "Pause"
            Form3.ToolStripMenuPlay.Visible = False
            Form3.ToolStripMenuPause.Visible = True
        ElseIf Form2.AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPaused Then
            Form3.Button1.Text = "Play"
            Form3.ToolStripMenuPlay.Visible = True
            Form3.ToolStripMenuPause.Visible = False
        End If

        Form3.Button3.Enabled = True

        Form3.ListBox1.Hide()

        Form3.Button1.Enabled = True
        Form3.Button2.Enabled = True
        Form3.Button5.Enabled = True

        Form3.Button3.SetBounds(12, 72, 81, 48)
        Form3.ButtonList.SetBounds(99, 72, 67, 48)
        Form3.Button5.SetBounds(172, 72, 75, 48)

        Form3.SetBounds(Form3.Location.X, Form3.Location.Y, 269, 170)

        Form3.ButtonList.Enabled = True
        Form3.Visible = True
        Form3.Enabled = False
        Form3.Visible = False
        Form3.Visible = False
        Form3.Label1.Visible = False

        tt = 0

        Form3.NotifyIcon1.Visible = False
        Form3.Enabled = True
        Form3.Show()
        Me.Hide()
    End Sub
End Class