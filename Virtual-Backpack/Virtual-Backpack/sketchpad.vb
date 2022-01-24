Public Class sketchpad
    Dim draw As Boolean
    Dim drawColor As Color = Color.Black
    Dim drawSize As Integer = 6

    Dim bmp As Bitmap



    Private Sub sketchpad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sizeCb.SelectedIndex = 2

        bmp = New Bitmap(sketchpadbox.Width, sketchpadbox.Height)
        sketchpadbox.Image = bmp
    End Sub

    Private Sub Paintbrush(X As Integer, Y As Integer)
        Using g As Graphics = Graphics.FromImage(sketchpadbox.Image)
            g.FillRectangle(New SolidBrush(drawColor), New Rectangle(X, Y, drawSize, drawSize))

            sketchpadbox.Refresh()

        End Using
    End Sub
    Private Sub sketchpadbox_MouseDown(sender As Object, e As MouseEventArgs) Handles sketchpadbox.MouseDown
        draw = True

        Paintbrush(e.X, e.Y)

    End Sub
    Private Sub sketchpadbox_MouseMove(sender As Object, e As MouseEventArgs) Handles sketchpadbox.MouseMove
        If draw = True Then
            Paintbrush(e.X, e.Y)
        End If
    End Sub
    Private Sub sketchpadbox_MouseUp(sender As Object, e As MouseEventArgs) Handles sketchpadbox.MouseUp
        draw = False
    End Sub
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

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        bmp = New Bitmap(sketchpadbox.Width, sketchpadbox.Height)
        sketchpadbox.Image = bmp
    End Sub

    Private Sub sizeCb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sizeCb.SelectedIndexChanged
        drawSize = sizeCb.SelectedItem
    End Sub

    Private Sub blackBtn_Click(sender As Object, e As EventArgs) Handles blackBtn.Click
        drawColor = Color.Black
    End Sub

    Private Sub redBtn_Click(sender As Object, e As EventArgs) Handles redBtn.Click
        drawColor = Color.FromArgb(204, 0, 0)
    End Sub

    Private Sub orangeBtn_Click(sender As Object, e As EventArgs) Handles orangeBtn.Click
        drawColor = Color.FromArgb(237, 125, 49)
    End Sub

    Private Sub yellowBtn_Click(sender As Object, e As EventArgs) Handles yellowBtn.Click
        drawColor = Color.FromArgb(255, 204, 102)
    End Sub

    Private Sub greenBtn_Click(sender As Object, e As EventArgs) Handles greenBtn.Click
        drawColor = Color.FromArgb(112, 173, 71)
    End Sub

    Private Sub blueBtn_Click(sender As Object, e As EventArgs) Handles blueBtn.Click
        drawColor = Color.FromArgb(0, 112, 192)
    End Sub

    Private Sub purpleBtn_Click(sender As Object, e As EventArgs) Handles purpleBtn.Click
        drawColor = Color.FromArgb(153, 102, 255)
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        sketchpadbox.DrawToBitmap(bmp, New Rectangle(0, 0, sketchpadbox.Width, sketchpadbox.Height))
        SaveFileDialog1.ShowDialog()
        Try
            bmp.Save(SaveFileDialog1.FileName, Imaging.ImageFormat.Png)
            MessageBox.Show("Image saved Successfully!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Guna2GradientButton6_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton6.Click
        Me.Hide()
        login.Show()
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        drawColor = Color.White()
    End Sub
End Class