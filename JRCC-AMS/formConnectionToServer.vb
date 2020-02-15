Imports MySql.Data.MySqlClient
Public Class formConnectionToServer
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" & txtbxDbHost.Text & ";" & "user=" & txtbxDbUsername.Text & ";" & "database=" & txtbxDbName.Text & ";" & "port=" & txtbxDbPort.Text & ";" & "password=" & txtbxDbPass.Text & ";" & "SslMode=none;"
        Try
            MysqlConn.Open()
            MessageBox.Show("Connection Successful", "_Server Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MysqlConn.Close()
            lblHeaderText.Text = "_Login "
            panelBody.Show()
            panelServerConnection.Hide()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        lblHeaderText.Text = "_Server Connection"
        panelBody.Hide()
        panelServerConnection.Show()
    End Sub
    Private Sub btnCheck_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=" & txtbxDbHost.Text & ";" & "user=" & txtbxDbUsername.Text & ";" & "database=" & txtbxDbName.Text & ";" & "port=" & txtbxDbPort.Text & ";" & "password=" & txtbxDbPass.Text & ";" & "SslMode=none;"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from user where username='" & txtbxUsername.Text & "' and password='" & txtbxPassword.Text & "' "
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0
            While READER.Read
                count = count + 1

            End While

            If count = 1 Then
                dashboard.Show()
                Me.Hide()
            ElseIf count > 1 Then
                MessageBox.Show("Username and password are Duplicate")
            Else
                MessageBox.Show("Username and password are not correct")

            End If


            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Private Sub txtbxUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbxUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtbxPassword.Focus()
        End If
    End Sub

    Private Sub txtbxPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbxPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnLogin.Focus()
        End If
    End Sub

    Private Sub txtbxDbHost_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbxDbHost.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtbxDbPort.Focus()
        End If
    End Sub

    Private Sub txtbxDbPort_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbxDbPort.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtbxDbUsername.Focus()
        End If
    End Sub

    Private Sub txtbxDbUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbxDbUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtbxDbPass.Focus()
        End If
    End Sub

    Private Sub txtbxDbPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbxDbPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtbxDbName.Focus()
        End If
    End Sub

    Private Sub txtbxDbName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbxDbName.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnLogin.Focus()
        End If
    End Sub
End Class
