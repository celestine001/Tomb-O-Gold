Public Class Form2
    Private Sub HowTo_Click(sender As Object, e As EventArgs) Handles HowTo.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Quit_Click(sender As Object, e As EventArgs) Handles Quit.Click
        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnW.Click
        PictureBox1.Top -= 5
    End Sub

    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        PictureBox1.Top -= -5
    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        PictureBox1.Left -= 5
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        PictureBox1.Left -= -5
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.LocationChanged
        If PictureBox2.Left >= Me.Width Then
            PictureBox2.Left = 0 - PictureBox2.Width
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox2.Left -= -5
        PictureBox3.Left -= -5
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.LocationChanged
        If PictureBox3.Left >= Me.Width Then
            PictureBox3.Left = 0 - PictureBox3.Width
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class