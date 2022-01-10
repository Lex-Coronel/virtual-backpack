Imports System.Data.SqlClient
Public Class login
    Dim Conn As SqlConnection
    Dim COMMAND As SqlCommand
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Database
        Conn = New SqlConnection()

        'Change userid and password
        '///////////////////////////////////////////////////////////////////////////////////
        Conn.ConnectionString =
            "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\Documents\virtualbackpackdb.mdf;Integrated Security=True;Connect Timeout=30"
        '//////////////////////////////////////////////////////////////////////////////////
        Dim READER As SqlDataReader
        Dim Query As String
        Dim count As Integer
        Try
            Conn.Open()
            'Database name and Table name
            '//////////////////////////////////////////////////
            Query = " SELECT * FROM accounts"
            '//////////////////////////////////////////////////
            COMMAND = New SqlCommand(Query, Conn)
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
            Conn.Dispose()

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
        Conn = New SqlConnection()
        'Change userid and password
        '///////////////////////////////////////////////////////////////////////////////////
        Conn.ConnectionString =
            "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\Documents\virtualbackpackdb.mdf;Integrated Security=True;Connect Timeout=30"
        '//////////////////////////////////////////////////////////////////////////////////
        Dim READER As SqlDataReader
        Dim Query As String
        Dim count As Integer
        Try
            Conn.Open()
            Query = " SELECT * FROM accounts where username='" & userTb.Text & "'and password='" & passwordTb.Text & "'"
            COMMAND = New SqlCommand(Query, Conn)
            READER = COMMAND.ExecuteReader
            Dim user As String
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
            Conn.Dispose()

        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles register.Click
        Me.Hide()
        registration.Show()
    End Sub
End Class