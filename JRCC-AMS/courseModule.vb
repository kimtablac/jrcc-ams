Imports MySql.Data.MySqlClient
Imports System.Data.Sql
Imports System
Imports System.Data
Module courseModule
    Dim connectionString As String = "server=" & formConnectionToServer.txtbxDbHost.Text & ";" & "user=" & formConnectionToServer.txtbxDbUsername.Text & ";" & "database=" & formConnectionToServer.txtbxDbName.Text & ";" & "port=" & formConnectionToServer.txtbxDbPort.Text & ";" & "password=" & formConnectionToServer.txtbxDbPass.Text & ";" & "SslMode=none;"
    Dim SQLConnection As MySqlConnection = New MySqlConnection
    Dim oDt_sched As New DataTable()
    Public Sub btnCourseSave()
        If dashboard.txtbxCourseCode.Text = String.Empty Or dashboard.txtbxCourseName.Text = String.Empty Then
            MessageBox.Show("Please fill in the blank", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dashboard.txtbxSubjectCode.Focus()
        Else
            Using SQLConnection As New MySqlConnection(connectionString)
                Using sqlCommand As New MySqlCommand()
                    With sqlCommand
                        .CommandText = "INSERT INTO course (date_created, code, course, description) values (@d_created, @cde, @crse, @descpt)"
                        .Connection = SQLConnection
                        .CommandType = CommandType.Text
                        .Parameters.AddWithValue("@cde", dashboard.txtbxCourseCode.Text)
                        .Parameters.AddWithValue("@crse", dashboard.txtbxCourseName.Text)
                        .Parameters.AddWithValue("@descpt", dashboard.txtbxSubjectDescription.Text)
                        .Parameters.AddWithValue("@d_created", dashboard.lblMDY.Text)

                        'clear text after hitting the save button
                        dashboard.txtbxCourseCode.Clear()
                        dashboard.txtbxCourseName.Clear()
                        dashboard.txtbxCourseDescription.Clear()
                        'hide show and enable insert button
                        dashboard.btnCancelCourse.Visible = False
                        dashboard.btnCourseSave.Visible = False
                        dashboard.btnInsertCourse.Visible = True
                        dashboard.btnEditCourse.Visible = True
                        dashboard.btnDeleteCourse.Visible = True
                        '
                        'disabled textbox course
                        dashboard.txtbxCourseCode.Enabled = False
                        dashboard.txtbxCourseName.Enabled = False
                        dashboard.txtbxCourseDescription.Enabled = False
                        'reload datagridview
                        courseDataList()
                        'refresh datagridview
                        dashboard.dgvCourse.Refresh()
                        dashboard.dgvCourse.Enabled = True
                        dashboard.dgvCourse.ForeColor = Color.Black 'Changing the first row, provided it exists.

                    End With
                    Try
                        SQLConnection.Open()
                        sqlCommand.ExecuteNonQuery()

                    Catch ex As MySqlException
                        MessageBox.Show(ex.Message.ToString(), "AMS - Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        'hide group box and enable insert button
                        dashboard.btnCancelCourse.Visible = True
                        dashboard.btnCourseSave.Visible = True
                        dashboard.btnInsertCourse.Enabled = True
                        'hide btn cancel and save
                        dashboard.btnCancelCourse.Visible = False
                        dashboard.btnCourseSave.Visible = False
                    Finally
                        SQLConnection.Close()
                    End Try
                End Using

            End Using
        End If
    End Sub
    'course populate combox of course
    Public Sub CourseData()
        Dim conn As New MySqlConnection(connectionString)
        Dim strSQL As String = "SELECT course FROM course"
        Dim da As New MySqlDataAdapter(strSQL, conn)
        Dim ds As New DataSet
        da.Fill(ds, "course")
        With dashboard.cmbxCourse
            '  .Items.Add("Select")
            .DataSource = ds.Tables("course")
            .DisplayMember = "course"
            .ValueMember = "course"
            '.SelectedIndex = 0

        End With

        dashboard.dgvCourse.RefreshEdit()
        dashboard.dgvCourse.Update()
    End Sub
    'datagridview of course
    Public Sub courseDataList()
        Dim connection As New MySqlConnection("server=" & formConnectionToServer.txtbxDbHost.Text & ";" & "user=" & formConnectionToServer.txtbxDbUsername.Text & ";" & "database=" & formConnectionToServer.txtbxDbName.Text & ";" & "port=" & formConnectionToServer.txtbxDbPort.Text & ";" & "password=" & formConnectionToServer.txtbxDbPass.Text & ";" & "SslMode=none;")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT code,course,description FROM course", connection)
        adapter.Fill(table)
        dashboard.dgvCourse.DataSource = table
        dashboard.dgvCourse.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dashboard.dgvCourse.AllowUserToResizeColumns = False
    End Sub
    'refresh datagridview
    Public Sub refreshDataCourse()
        Dim connection As New MySqlConnection("server=" & formConnectionToServer.txtbxDbHost.Text & ";" & "user=" & formConnectionToServer.txtbxDbUsername.Text & ";" & "database=" & formConnectionToServer.txtbxDbName.Text & ";" & "port=" & formConnectionToServer.txtbxDbPort.Text & ";" & "password=" & formConnectionToServer.txtbxDbPass.Text & ";" & "SslMode=none;")
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT code,course,description FROM course", connection)
        Dim ds As New DataSet
        adapter.Fill(table)
        dashboard.dgvCourse.DataSource = table
    End Sub
End Module
