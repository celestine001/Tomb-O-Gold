Public Class Form6
    Private Sub Contiune_Click(sender As Object, e As EventArgs) Handles Contiune.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
End Class