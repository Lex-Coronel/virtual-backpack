Public Class calculator
    Dim assign_input As Double = 0
    Dim operation As String
    Dim found_expression As Boolean = False


    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Guna2GradientCircleButton18_Click(sender As Object, e As EventArgs) Handles Guna2GradientCircleButton18.Click
        Label2.Text = "0"
        Equation.Text = "0"
    End Sub

    Private Sub operation_click(sender As Object, e As EventArgs) Handles Div.Click, Multi.Click, Minus.Click, Plus.Click
        Dim b As Guna.UI2.WinForms.Guna2GradientCircleButton = sender
        If (assign_input <> 0) Then
            Equal.PerformClick()
            found_expression = True
            operation = b.Text
            Equation.Text = assign_input & " " & operation
        Else
            operation = b.Text
            assign_input = Double.Parse(Label2.Text)
            found_expression = True
            Equation.Text = assign_input & " " & operation
        End If
    End Sub

    Private Sub Equal_Click(sender As Object, e As EventArgs) Handles Equal.Click
        Equation.Text = ""
        Select Case operation
            Case "+"
                Label2.Text = (assign_input + Double.Parse(Label2.Text)).ToString()
            Case "-"
                Label2.Text = (assign_input - Double.Parse(Label2.Text)).ToString()
            Case "x"
                Label2.Text = (assign_input * Double.Parse(Label2.Text)).ToString()
            Case "/"
                Label2.Text = (assign_input / Double.Parse(Label2.Text)).ToString()
        End Select
        assign_input = Double.Parse(Label2.Text)
        operation = ""

    End Sub

    Private Sub Guna2GradientCircleButton16_Click(sender As Object, e As EventArgs) Handles Guna2GradientCircleButton16.Click
        Dim a As Double
        a = Convert.ToDouble(Label2.Text) * Convert.ToDouble(0.01)
        Label2.Text = System.Convert.ToString(a)
    End Sub

    Private Sub Guna2GradientCircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientCircleButton1.Click
        'Backspace
        If Label2.Text.Length > 0 Then
            Label2.Text = Label2.Text.Remove(Label2.Text.Length - 1, 1)
        End If

        If (Label2.Text = "") Then
            Label2.Text = "0"
        End If
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Me.Close()
    End Sub

    Private Sub Num_click(sender As Object, e As EventArgs) Handles Guna2GradientCircleButton9.Click, Guna2GradientCircleButton8.Click, Guna2GradientCircleButton7.Click, Guna2GradientCircleButton6.Click, Guna2GradientCircleButton5.Click, Guna2GradientCircleButton4.Click, Guna2GradientCircleButton3.Click, Guna2GradientCircleButton2.Click, Guna2GradientCircleButton19.Click, Guna2GradientCircleButton17.Click, Guna2GradientCircleButton11.Click, Guna2GradientCircleButton10.Click
        Dim b As Guna.UI2.WinForms.Guna2GradientCircleButton = sender
        If ((Label2.Text = "0") Or (found_expression)) Then

            Label2.Text = b.Text
            found_expression = False
        ElseIf (b.Text = ".") Then
            If (Not Label2.Text.Contains(".")) Then
                Label2.Text = Label2.Text + b.Text
            End If
        Else
            Label2.Text = Label2.Text + b.Text

        End If
    End Sub
End Class