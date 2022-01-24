Imports MySql.Data.MySqlClient
Public Class planner_manager
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Public planID As Integer = 0

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub minBtn_Click(sender As Object, e As EventArgs) Handles minBtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        MysqlConn = New MySqlConnection()

        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=sachiiuu;database=virtualbackpack"

        Dim READER As MySqlDataReader
        Try
            If planID = 0 Then
                MysqlConn.Open()
                Dim Query As String

                Query = "INSERT INTO planner(plannerdate, plannertask, plannertime) VALUES ('" + plannerdate.Value.Date.ToShortDateString() + "','" + taskTb.Text + "', '" + plannertime.Text + "')"
                COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader
                MessageBox.Show("Task Successfully Saved!")

                MysqlConn.Close()
            Else
                MysqlConn.Open()
                Dim Query As String

                Query = "UPDATE planner SET plannerdate = '" & plannerdate.Value.Date.ToShortDateString() & "', plannertask = '" & taskTb.Text & "', plannertime = '" & plannertime.Text & "' WHERE plannerID = " & planID & ""
                COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader
                MessageBox.Show("Task Successfully Updated!")
                MysqlConn.Close()

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Me.Hide()
            planner.Show()
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click

        MysqlConn = New MySqlConnection()

        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=sachiiuu;database=virtualbackpack"

        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String

            Query = "DELETE FROM planner WHERE plannerID = " & planID & ""
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            MessageBox.Show("Task Successfully Deleted!")

            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Me.Hide()
            planner.Show()
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub planner_manager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        deleteBtn.Visible = planID <> 0
    End Sub
End Class