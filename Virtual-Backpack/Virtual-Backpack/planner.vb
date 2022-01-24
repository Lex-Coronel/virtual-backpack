Imports MySql.Data.MySqlClient
Public Class planner
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private listFlDay As New List(Of FlowLayoutPanel)
    Private currentDate As DateTime = DateTime.Today
    Private currentTime As DateTime = DateTime.Now
    Private Sub planner_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateDayPanel(42)
        DisplayCurrentDate()

    End Sub

    Private Sub AddNewTaskToFlDay(ByVal sender As Object, e As EventArgs)
        Dim day As Integer = CType(sender, FlowLayoutPanel).Tag
        If day <> 0 Then
            planner_manager.planID = 0
            planner_manager.plannerdate.Value = New Date(currentDate.Year, currentDate.Month, day)
            planner_manager.taskTb.Text = ""
            planner_manager.plannertime.Text = ""
            planner_manager.ShowDialog()
            DisplayCurrentDate()
        End If
    End Sub

    Private Sub TaskDetails(ByVal sender As Object, e As EventArgs)
        MysqlConn = New MySqlConnection()

        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=Cpecoronel12;database=virtualbackpack"

        Dim plannerID As Integer = CType(sender, LinkLabel).Tag
        Dim sql As String = $"select * from planner where plannerID = {plannerID}"
        Dim da As New MySqlDataAdapter(sql, MysqlConn)
        Dim ds As New DataSet
        da.Fill(ds, "result")

        Dim dt As DataTable = ds.Tables("result")

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            With planner_manager
                .planID = plannerID
                .plannerdate.Value = row("plannerdate")
                .taskTb.Text = row("plannertask")
                .plannertime.Text = row("plannertime")
                .ShowDialog()
            End With
            DisplayCurrentDate()
        End If

    End Sub


    Private Sub AddTaskToFlDay(ByVal startDayAtFlNumber As Integer)
        Dim startDate As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Dim endDate As DateTime = startDate.AddMonths(1).AddDays(-1)
        MysqlConn = New MySqlConnection()

        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=Cpecoronel12;database=virtualbackpack"

        Dim sql As String = $"select * from planner where plannerdate between '{startDate.ToShortDateString()}' and '{endDate.ToShortDateString()}'"

        Dim da As New MySqlDataAdapter(sql, MysqlConn)
        Dim ds As New DataSet
        da.Fill(ds, "result")

        Dim dt As DataTable = ds.Tables("result")

        For Each row As DataRow In dt.Rows
            Dim taskDay As DateTime = DateTime.Parse(row("plannerdate"))
            Dim link As New LinkLabel
            link.Tag = row("plannerID")
            link.Name = $"link{row("plannerID")}"
            link.Text = row("plannertask")
            link.Size = New Size(85, 15)
            AddHandler link.Click, AddressOf TaskDetails
            listFlDay((taskDay.Day - 1) + (startDayAtFlNumber - 1)).Controls.Add(link)
        Next

    End Sub

    Private Function GetFirstDayOfWeekOfCurrentDate() As Integer
        Dim firstDayOfMonth As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Return firstDayOfMonth.DayOfWeek + 1
    End Function

    Private Function GetTotalDaysOfCurrentDate() As Integer
        Dim firstDayOfCurrentDate As DateTime = New Date(currentDate.Year, currentDate.Month, 1)
        Return firstDayOfCurrentDate.AddMonths(1).AddDays(-1).Day
    End Function

    Private Sub DisplayCurrentDate()
        Label1.Text = currentDate.ToString("MMMM, yyyy")
        Dim firstDayAtFlNumber As Integer = GetFirstDayOfWeekOfCurrentDate()
        Dim totalDay As Integer = GetTotalDaysOfCurrentDate()
        AddLabelDaytoFlDay(firstDayAtFlNumber, totalDay)
        AddTaskToFlDay(firstDayAtFlNumber)
    End Sub

    Private Sub PrevMonth()
        currentDate = currentDate.AddMonths(-1)
        DisplayCurrentDate()
    End Sub

    Private Sub NextMonth()
        currentDate = currentDate.AddMonths(1)
        DisplayCurrentDate()
    End Sub

    Private Sub Today()
        currentDate = DateTime.Today
        DisplayCurrentDate()
    End Sub
    Private Sub GenerateDayPanel(ByVal totalDays As Integer)
        flDays.Controls.Clear()
        listFlDay.Clear()

        For i As Integer = 1 To totalDays
            Dim fl As New FlowLayoutPanel
            fl.Name = $"flDay{i}"
            fl.Size = New Size(93, 80)
            fl.BackColor = Color.White
            fl.BorderStyle = BorderStyle.FixedSingle
            fl.AutoScroll = True
            fl.Cursor = Cursors.Hand
            AddHandler fl.Click, AddressOf AddNewTaskToFlDay
            flDays.Controls.Add(fl)
            listFlDay.Add(fl)
        Next
    End Sub
    Private Sub AddLabelDaytoFlDay(ByVal startDayAtFlNumber As Integer, ByVal totalDaysInMonth As Integer)
        For Each fl As FlowLayoutPanel In listFlDay
            fl.Controls.Clear()
            fl.Tag = 0
            fl.BackColor = Color.White
        Next

        For i As Integer = 1 To totalDaysInMonth
            Dim lbl As New Label
            lbl.Name = $"lblDay{i}"
            lbl.AutoSize = False
            lbl.TextAlign = ContentAlignment.MiddleRight
            lbl.Size = New Size(85, 25)
            lbl.Text = i
            lbl.Font = New Font("Segoe UI Black", 9.75)
            listFlDay((i - 1) + (startDayAtFlNumber - 1)).Tag = i
            listFlDay((i - 1) + (startDayAtFlNumber - 1)).Controls.Add(lbl)

            If New Date(currentDate.Year, currentDate.Month, i) = Date.Today Then
                listFlDay((i - 1) + (startDayAtFlNumber - 1)).BackColor = Color.Orange
            End If
        Next
    End Sub

    Private Sub minBtn_Click(sender As Object, e As EventArgs) Handles minBtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub Guna2TileButton1_Click(sender As Object, e As EventArgs) Handles Guna2TileButton1.Click
        Today()
    End Sub

    Private Sub Guna2TileButton3_Click(sender As Object, e As EventArgs) Handles Guna2TileButton3.Click
        NextMonth()
    End Sub

    Private Sub Guna2TileButton2_Click(sender As Object, e As EventArgs) Handles Guna2TileButton2.Click
        PrevMonth()
    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton4.Click
        Me.Hide()
        homepage.Show()
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        Me.Hide()
        notepad.Show()
    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click

    End Sub

    Private Sub Guna2GradientButton5_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton5.Click
        Me.Hide()
        sketchpad.Show()
    End Sub

    Private Sub Guna2GradientButton6_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton6.Click
        Me.Hide()
        login.Show()
    End Sub

End Class