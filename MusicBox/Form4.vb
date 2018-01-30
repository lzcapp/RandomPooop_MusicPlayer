Public Class Form4

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form3.Enabled = True
        Form3.Show()
        Form3.Focus()
    End Sub

    Private Sub Form4_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form3.Enabled = True
        Form3.Show()
        Form3.Focus()
    End Sub
End Class