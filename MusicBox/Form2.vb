Public Class Form2

    Dim rndn As Long

    Private Sub AxWindowsMediaPlayer1_StatusChange(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer1.StatusChange
        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsStopped Then
            i = CInt(Format(((nums - 1) * Rnd())))

            sn = Form3.ListBox1.Items(i)

            AxWindowsMediaPlayer1.URL = sp & "\" & sn


            Form3.Text = sn
            Form3.ToolStripMenuItem3.Text = sn
            Form3.NotifyIcon1.Text = sn '& " - Double Click to Open"

            'AxWindowsMediaPlayer1.Ctlcontrols.play()
        End If

        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub
End Class