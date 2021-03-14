Public Class Form1
    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub HowTo_Click(sender As Object, e As EventArgs) Handles HowTo.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub Quit_Click(sender As Object, e As EventArgs) Handles Quit.Click
        Application.Exit()
    End Sub
End Class
