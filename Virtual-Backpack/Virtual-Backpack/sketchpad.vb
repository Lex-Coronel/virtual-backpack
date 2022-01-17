Public Class sketchpad
    Private Sub minBtn_Click(sender As Object, e As EventArgs) Handles minBtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Me.Hide()
        planner.Show()
    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        Me.Hide()
        homepage.Show()
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Me.Hide()
        notepad.Show()
    End Sub
End Class