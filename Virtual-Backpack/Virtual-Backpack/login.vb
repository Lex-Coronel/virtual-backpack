Imports MySql.Data.MySqlClient
Public Class login
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Database
        MysqlConn = New MySqlConnection()

        'Change userid and password
        '///////////////////////////////////////////////////////////////////////////////////
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=Cpecoronel12;database=virtualbackpack"
        '//////////////////////////////////////////////////////////////////////////////////
        Dim READER As MySqlDataReader
        Dim Query As String
        Dim count As Integer
        Try
            MysqlConn.Open()
            'Database name and Table name
            '//////////////////////////////////////////////////
            Query = " SELECT * FROM virtualbackpack.accounts"
            '//////////////////////////////////////////////////
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                count += 1
            End While

            If count = 1 Then
                register.Visible = False

                registertb.Visible = False

            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2PictureBox1_Click_1(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub



    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs)


    End Sub
    Private Sub loginBtn_Click_1(sender As Object, e As EventArgs) Handles loginBtn.Click
        MysqlConn = New MySqlConnection()
        'Change userid and password
        '///////////////////////////////////////////////////////////////////////////////////
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=Cpecoronel12;database=virtualbackpack"
        '//////////////////////////////////////////////////////////////////////////////////
        Dim READER As MySqlDataReader
        Dim Query As String
        Dim count As Integer
        Try
            MysqlConn.Open()
            Query = " SELECT * FROM virtualbackpack.accounts where username='" & userTb.Text & "'and password='" & passwordTb.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                count += 1

            End While

            If count = 1 Then
                Me.Hide()
                homepage.Show()
                userTb.Text = ""
                passwordTb.Text = ""


            Else
                MessageBox.Show("Incorrect Username or Password")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles register.Click
        Me.Hide()
        registration.Show()
    End Sub

    Private Sub Guna2CirclePictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub
End Class