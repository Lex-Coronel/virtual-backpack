Public Class notepad
    Private Sub SacToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SacToolStripMenuItem.Click

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles calculatorBtn.Click
        calculator.Show()
    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        Me.Hide()
        homepage.Show()
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        Me.Hide()
        daily_planner.Show()
    End Sub

    Private Sub Guna2GradientButton5_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton5.Click
        Me.Hide()
        sketchpad.Show()
    End Sub
End Class