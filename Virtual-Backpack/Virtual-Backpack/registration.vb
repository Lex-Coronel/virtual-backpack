Imports MySql.Data.MySqlClient
Public Class registration
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        MysqlConn = New MySqlConnection()
        'Change userid and password
        '///////////////////////////////////////////////////////////////////////////////////
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=crimsonfangs13;database=virtualbackpack"
        '//////////////////////////////////////////////////////////////////////////////////
        Dim READER As MySqlDataReader
        If passwordTb.Text = confirmTB.Text Then
            Try
                MysqlConn.Open()
                Dim Query As String
                'Database name,Table name and Column name
                '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                Query = "INSERT INTO virtualbackpack.accounts(username,password) VALUES ('" & userTb.Text & "','" & passwordTb.Text & "')"
                '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader
                MessageBox.Show("Account Successfully Created!")

                MysqlConn.Close()


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                Me.Hide()
                login.Show()
                MysqlConn.Dispose()

            End Try
        Else
            MessageBox.Show("Password does not match.")
        End If

    End Sub
End Class