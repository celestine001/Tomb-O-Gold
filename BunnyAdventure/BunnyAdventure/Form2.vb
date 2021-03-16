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

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Carrot1.Left -= 5
        Snake1.Left -= 5
        Snake2.Left -= 5
    End Sub
    'Sub PlayLoopingBackgroundSoundFile()
    '  My.Computer.Audio.Play(My.Resources.TallGrass.wav, AudioPlayMode.BackgroundLoop)
    ' End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim collisionC As Boolean
        Dim collisionS As Boolean
        Dim Score As Integer = 0
        Dim collected As Boolean
        For Each PictureBox In Me.Controls

            If PictureBox1.Bounds.IntersectsWith(Carrot1.Bounds) Then
                collisionC = True
                collected = True
            Else : collisionC = False
            End If

            If collected = True Then
                Score = Score + 1

                Label1.Text = "Score: " + Score.ToString
                Carrot1.Hide()

            Else : collected = False
            End If

            If PictureBox1.Bounds.IntersectsWith(Snake1.Bounds) Or PictureBox1.Bounds.IntersectsWith(Snake2.Bounds) Then
                collisionS = True

            End If
            If Score = 16 Then
                Me.Close()
                Form5.Show()
            End If
            If collisionS = True Then
                Me.Close()
                Form5.Show()
            End If
        Next

        If Carrot1.Location.X < -60 Or collected = True Then
            Carrot1.Left += 1230
            Carrot1.Top += 110
            Carrot1.Show()

        End If
        If Carrot1.Location.Y > 300 Then
            Carrot1.Top += 50
            Carrot1.Show()

        End If
        If Carrot1.Location.Y < 10 Then
            Carrot1.Top -= 60
            Carrot1.Show()

        End If
        If Snake1.Location.X < -60 Then
            Snake1.Left += 1230
            Snake1.Top -= 50
        End If
        If Snake1.Location.Y > 300 Then
            Snake1.Top += 120

        End If
        If Snake1.Location.Y < 60 Then
            Snake1.Top -= 50

        End If
        If Snake2.Location.Y > 300 Then
            Snake2.Top += 120

        End If
        If Snake2.Location.Y < 60 Then
            Snake2.Top -= 50

        End If
        If Snake2.Location.X < -60 Then
            Snake2.Left += 1230
            Snake2.Top += 50
        End If
    End Sub
End Class