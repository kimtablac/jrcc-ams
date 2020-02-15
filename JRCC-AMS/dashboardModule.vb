Imports MySql.Data.MySqlClient
Module dashboardModule
    Dim cnString As String = "server=" & formConnectionToServer.txtbxDbHost.Text & ";" & "user=" & formConnectionToServer.txtbxDbUsername.Text & ";" & "database=" & formConnectionToServer.txtbxDbName.Text & ";" & "port=" & formConnectionToServer.txtbxDbPort.Text & ";" & "password=" & formConnectionToServer.txtbxDbPass.Text & ";" & "SslMode=none;"
    Public Sub countSubject()
        dashboard.lblTotalSubjects.Text = dashboard.dgvSubjects.Rows.Count - 1
    End Sub
    Public Sub countTotalSubjectData()
        Dim con As New MySqlConnection(cnString)
        con.Open()
        Dim cmd As New MySqlCommand("SELECT COUNT(*) FROM subjects ", con)
        Dim i As Integer = cmd.ExecuteScalar()
        cmd = Nothing
        con.Close()
        dashboard.lblTotalSubjects.Text = i
    End Sub
End Module
