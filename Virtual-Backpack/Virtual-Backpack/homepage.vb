Public Class homepage


    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Me.Hide()
        notepad.Show()
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Me.Hide()
        planner.Show()
    End Sub

    Private Sub Guna2GradientButton5_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton5.Click
        Me.Hide()
        sketchpad.Show()
    End Sub

    Private Sub Guna2CirclePictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click

    End Sub
End Class