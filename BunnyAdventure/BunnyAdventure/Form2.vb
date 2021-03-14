Public Class Form2
    Private Sub HowTo_Click(sender As Object, e As EventArgs) Handles HowTo.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Quit_Click(sender As Object, e As EventArgs) Handles Quit.Click
        Application.Exit()
    End Sub
End Class