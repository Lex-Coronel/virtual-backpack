﻿Public Class planner
    Private listFlDay As New List(Of FlowLayoutPanel)

    Private Sub planner_Load(sender As Object, e As EventArgs)
        GenerateDayPanel(30)
    End Sub

    Private Sub GenerateDayPanel(ByVal totalDays As Integer)
        flDays.Controls.Clear()
        listFlDay.Clear()

        For i As Integer = 1 To totalDays
            Dim fl As New FlowLayoutPanel
            fl.Name = $"flDay{i}"
            fl.Size = New Size(93, 90)
            fl.BackColor = Color.White
            fl.BorderStyle = BorderStyle.FixedSingle
            flDays.Controls.Add(fl)
        Next
    End Sub

    Private Sub minBtn_Click(sender As Object, e As EventArgs) Handles minBtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub
End Class