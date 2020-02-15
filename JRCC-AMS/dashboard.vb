
Public Class dashboard
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grbxDefaultViewStudent.Show()
        grbxAddStudent.Hide()

        'show active button
        hoverDashboard.Visible = False
        hoverAttendance.Visible = False
        hoverStudents.Visible = False
        hoverTeachers.Visible = False
        hoverSubjects.Visible = False
        hoverReports.Visible = False
        hoverAMS.Visible = False
        hoverActivity.Visible = False
        hoverSettings.Visible = False
        'view active button
        hoverAddStudents.Visible = False
        hoverEditStudents.Visible = False
        hoverDeleteStudents.Visible = False
        hoverViewStudents.Visible = False
        'Subject and course tools
        btnCancelSubject.Visible = False
        btnSubjectSave.Visible = False

        btnCancelCourse.Visible = False
        btnCourseSave.Visible = False
        'enable button
        btnInsertSubject.Enabled = True
        btnEditSubject.Enabled = True
        btnDeleteSubject.Enabled = True

        btnInsertCourse.Enabled = True
        btnEditCourse.Enabled = True
        btnDeleteCourse.Enabled = True
        'disabled textbox subject and course
        txtbxSubjectCode.Enabled = False
        txtbxSubjectName.Enabled = False
        txtbxSubjectDescription.Enabled = False

        txtbxCourseCode.Enabled = False
        txtbxCourseName.Enabled = False
        txtbxCourseDescription.Enabled = False
        'label date today
        Me.lblMDY.Text = DateTime.Now.ToLongDateString()

        courseModule.CourseData()
        courseModule.courseDataList()

        subjectDataList()
        refreshDataSubject()
        'Dashboard Module
        'countSubject()
        countTotalSubjectData()

        '--------------------------------------------- Student Module ---------------------------------------------

        grbAMSInfo.Hide()
        grbPersonalInfo.Show()
        grbStudentInformation.Hide()

    End Sub
    Private Sub btnMenuDashboard_Click(sender As Object, e As EventArgs) Handles btnMenuDashboard.Click
        panelDashboard.Show()
        panelMenuAttendance.Hide()
        panelMenuStudents.Hide()
        panelMenuTeachers.Hide()
        panelMenuSubjects.Hide()
        panelMenuReports.Hide()
        panelAccountProfile.Hide()
        panelMenuActivity.Hide()
        panelMenuSettings.Hide()
        'show active button
        hoverDashboard.Visible = True
        hoverAttendance.Visible = False
        hoverStudents.Visible = False
        hoverTeachers.Visible = False
        hoverSubjects.Visible = False
        hoverReports.Visible = False
        hoverAMS.Visible = False
        hoverActivity.Visible = False
        hoverSettings.Visible = False

    End Sub
    Private Sub btnMenuAttendance_Click(sender As Object, e As EventArgs) Handles btnMenuAttendance.Click
        panelDashboard.Hide()
        panelMenuAttendance.Show()
        panelMenuStudents.Hide()
        panelMenuTeachers.Hide()
        panelMenuSubjects.Hide()
        panelMenuReports.Hide()
        panelAccountProfile.Hide()
        panelMenuActivity.Hide()
        panelMenuSettings.Hide()
        'show active button
        hoverDashboard.Visible = False
        hoverAttendance.Visible = True
        hoverStudents.Visible = False
        hoverTeachers.Visible = False
        hoverSubjects.Visible = False
        hoverReports.Visible = False
        hoverAMS.Visible = False
        hoverActivity.Visible = False
        hoverSettings.Visible = False
    End Sub
    Private Sub btnMenuStudents_Click(sender As Object, e As EventArgs) Handles btnMenuStudents.Click
        panelDashboard.Hide()
        panelMenuAttendance.Hide()
        panelMenuStudents.Show()
        panelMenuTeachers.Hide()
        panelMenuSubjects.Hide()
        panelMenuReports.Hide()
        panelAccountProfile.Hide()
        panelMenuActivity.Hide()
        panelMenuSettings.Hide()
        'show active button
        hoverDashboard.Visible = False
        hoverAttendance.Visible = False
        hoverStudents.Visible = True
        hoverTeachers.Visible = False
        hoverSubjects.Visible = False
        hoverReports.Visible = False
        hoverAMS.Visible = False
        hoverActivity.Visible = False
        hoverSettings.Visible = False
        'refresh data of the combo box course
        CourseData()
        'clear combo box default text
        cmbxCourse.Text = ""
    End Sub
    Private Sub btnMenuTeachers_Click(sender As Object, e As EventArgs) Handles btnMenuTeachers.Click
        panelDashboard.Hide()
        panelMenuAttendance.Hide()
        panelMenuStudents.Hide()
        panelMenuTeachers.Show()
        panelMenuSubjects.Hide()
        panelMenuReports.Hide()
        panelAccountProfile.Hide()
        panelMenuActivity.Hide()
        panelMenuSettings.Hide()
        'show active button
        hoverDashboard.Visible = False
        hoverAttendance.Visible = False
        hoverStudents.Visible = False
        hoverTeachers.Visible = True
        hoverSubjects.Visible = False
        hoverReports.Visible = False
        hoverAMS.Visible = False
        hoverActivity.Visible = False
        hoverSettings.Visible = False
    End Sub
    Private Sub btnMenuSubjects_Click(sender As Object, e As EventArgs) Handles btnMenuSubjects.Click
        panelDashboard.Hide()
        panelMenuAttendance.Hide()
        panelMenuStudents.Hide()
        panelMenuTeachers.Hide()
        panelMenuSubjects.Show()
        panelMenuReports.Hide()
        panelAccountProfile.Hide()
        panelMenuActivity.Hide()
        panelMenuSettings.Hide()
        'show active button
        hoverDashboard.Visible = False
        hoverAttendance.Visible = False
        hoverStudents.Visible = False
        hoverTeachers.Visible = False
        hoverSubjects.Visible = True
        hoverReports.Visible = False
        hoverAMS.Visible = False
        hoverActivity.Visible = False
        hoverSettings.Visible = False
    End Sub
    Private Sub btnMenuAMS_Click(sender As Object, e As EventArgs) Handles btnMenuAMS.Click
        panelDashboard.Show()
        panelMenuAttendance.Hide()
        panelMenuStudents.Hide()
        panelMenuTeachers.Hide()
        panelMenuSubjects.Hide()
        panelMenuReports.Hide()
        panelAccountProfile.Hide()
        panelMenuActivity.Hide()
        panelMenuSettings.Hide()
        'show active button
        hoverDashboard.Visible = False
        hoverAttendance.Visible = False
        hoverStudents.Visible = False
        hoverTeachers.Visible = False
        hoverSubjects.Visible = False
        hoverReports.Visible = False
        hoverAMS.Visible = True
        hoverActivity.Visible = False
        hoverSettings.Visible = False
    End Sub

    Private Sub btnMenuReports_Click(sender As Object, e As EventArgs) Handles btnMenuReports.Click
        panelDashboard.Hide()
        panelMenuAttendance.Hide()
        panelMenuStudents.Hide()
        panelMenuTeachers.Hide()
        panelMenuSubjects.Hide()
        panelMenuReports.Show()
        panelAccountProfile.Hide()
        panelMenuActivity.Hide()
        panelMenuSettings.Hide()
        'show active button
        hoverDashboard.Visible = False
        hoverAttendance.Visible = False
        hoverStudents.Visible = False
        hoverTeachers.Visible = False
        hoverSubjects.Visible = False
        hoverReports.Visible = True
        hoverAMS.Visible = False
        hoverActivity.Visible = False
        hoverSettings.Visible = False
    End Sub
    Private Sub ProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfileToolStripMenuItem.Click
        panelDashboard.Hide()
        panelMenuAttendance.Hide()
        panelMenuStudents.Hide()
        panelMenuTeachers.Hide()
        panelMenuSubjects.Hide()
        panelMenuReports.Show()
        panelAccountProfile.Show()
        panelMenuActivity.Hide()
    End Sub
    Private Sub timerRGB_Tick(sender As Object, e As EventArgs) Handles timerRGB.Tick
        txtbxR.Text = Convert.ToString(trackbarR.Value)
        txtbxG.Text = Convert.ToString(trackbarG.Value)
        txtbxB.Text = Convert.ToString(trackbarB.Value)

        Dim red As Integer
        Dim green As Integer
        Dim blue As Integer
        red = Convert.ToInt32(txtbxR.Text)
        green = Convert.ToInt32(txtbxG.Text)
        blue = Convert.ToInt32(txtbxB.Text)

        panelAccountProfile.ForeColor = Color.FromArgb(red, green, blue)
        panelDashboard.ForeColor = Color.FromArgb(red, green, blue)
        panelHeader.ForeColor = Color.FromArgb(red, green, blue)
        panelMenuAttendance.ForeColor = Color.FromArgb(red, green, blue)
        panelMenuStudents.ForeColor = Color.FromArgb(red, green, blue)
        panelMenuTeachers.ForeColor = Color.FromArgb(red, green, blue)
        panelMenuReports.ForeColor = Color.FromArgb(red, green, blue)
        panelSideMenu.ForeColor = Color.FromArgb(red, green, blue)
        panelSideMenu.ForeColor = Color.FromArgb(red, green, blue)
        menustrip.ForeColor = Color.FromArgb(red, green, blue)
        ''active buttons    
        'hoverDashboard.BackColor = Color.FromArgb(red, green, blue)
        'hoverAttendance.BackColor = Color.FromArgb(red, green, blue)
        'hoverStudents.BackColor = Color.FromArgb(red, green, blue)
        'hoverTeachers.BackColor = Color.FromArgb(red, green, blue)
        'hoverSubjects.BackColor = Color.FromArgb(red, green, blue)
        'hoverReports.BackColor = Color.FromArgb(red, green, blue)
        'hoverAMS.BackColor = Color.FromArgb(red, green, blue)
        'hoverActivity.BackColor = Color.FromArgb(red, green, blue)
        'hoverSettings.BackColor = Color.FromArgb(red, green, blue)
        ''add student active button
        'hoverAddStudents.BackColor = Color.FromArgb(red, green, blue)
        'hoverEditStudents.BackColor = Color.FromArgb(red, green, blue)
        'hoverDeleteStudents.BackColor = Color.FromArgb(red, green, blue)
        'hoverViewStudents.BackColor = Color.FromArgb(red, green, blue)

    End Sub
    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        'Disabled grbxDefaultViewStudent onclick
        grbxAddStudent.Show()
        grbxDefaultViewStudent.Hide()
        'Disabled tools button add onclick
        btnAddStudent.Enabled = False
        btnEditStudent.Enabled = False
        btnDeleteStudent.Enabled = False
        btnViewStudent.Enabled = False
        'view active button
        hoverAddStudents.Visible = True
        hoverEditStudents.Visible = False
        hoverDeleteStudents.Visible = False
        hoverViewStudents.Visible = False
        'change panel text
        lblStudentPanel.Text = "Add Student"

    End Sub
    Private Sub btnCancelAddStudent_Click(sender As Object, e As EventArgs) Handles btnCancelAddStudent.Click
        'Disabled grbxAddStudent onclick
        grbxDefaultViewStudent.Show()
        grbxAddStudent.Hide()
        'Enabled tools button cancel click
        btnAddStudent.Enabled = True
        btnEditStudent.Enabled = True
        btnDeleteStudent.Enabled = True
        btnViewStudent.Enabled = True
        'tools hide active button
        hoverAddStudents.Visible = False
        hoverEditStudents.Visible = False
        hoverDeleteStudents.Visible = False
        hoverViewStudents.Visible = False
        'change panel text
        lblStudentPanel.Text = "Students"
    End Sub
    Private Sub btnMenuSettings_Click(sender As Object, e As EventArgs) Handles btnMenuSettings.Click
        panelDashboard.Hide()
        panelMenuAttendance.Hide()
        panelMenuStudents.Hide()
        panelMenuTeachers.Hide()
        panelMenuSubjects.Hide()
        panelMenuReports.Hide()
        panelAccountProfile.Hide()
        panelMenuActivity.Hide()
        panelMenuSettings.Show()
        'show active button
        hoverDashboard.Visible = False
        hoverAttendance.Visible = False
        hoverStudents.Visible = False
        hoverTeachers.Visible = False
        hoverSubjects.Visible = False
        hoverReports.Visible = False
        hoverAMS.Visible = False
        hoverActivity.Visible = False
        hoverSettings.Visible = True
    End Sub

    Private Sub btnMenuActivity_Click(sender As Object, e As EventArgs) Handles btnMenuActivity.Click
        panelDashboard.Hide()
        panelMenuAttendance.Hide()
        panelMenuStudents.Hide()
        panelMenuTeachers.Hide()
        panelMenuSubjects.Hide()
        panelMenuReports.Hide()
        panelAccountProfile.Hide()
        panelMenuActivity.Hide()
        panelMenuSettings.Hide()
        panelMenuActivity.Show()
        'show active button
        hoverDashboard.Visible = False
        hoverAttendance.Visible = False
        hoverStudents.Visible = False
        hoverTeachers.Visible = False
        hoverSubjects.Visible = False
        hoverReports.Visible = False
        hoverAMS.Visible = False
        hoverActivity.Visible = True
        hoverSettings.Visible = False
    End Sub

    Private Sub btnInsertSubject_Click(sender As Object, e As EventArgs) Handles btnInsertSubject.Click
        'clear textbox text
        txtbxSubjectCode.Clear()
        txtbxSubjectName.Clear()
        txtbxSubjectDescription.Clear()
        'enable textbox
        txtbxSubjectCode.Enabled = True
        txtbxSubjectName.Enabled = True
        txtbxSubjectDescription.Enabled = True
        'show save and cancel button
        btnCancelSubject.Visible = True
        btnSubjectSave.Visible = True
        'disabled edit and delete button
        btnInsertSubject.Visible = False
        btnEditSubject.Visible = False
        btnDeleteSubject.Visible = False
        'read only
        dgvSubjects.Enabled = False
        dgvSubjects.ForeColor = Color.Gray 'Changing the first row, provided it exists.
    End Sub

    Private Sub btnInsertCourse_Click(sender As Object, e As EventArgs) Handles btnInsertCourse.Click
        'clear textbox text
        txtbxCourseCode.Clear()
        txtbxCourseName.Clear()
        txtbxCourseDescription.Clear()
        'show save and cancel button
        btnCancelCourse.Visible = True
        btnCourseSave.Visible = True
        'disabled edit and delete button
        btnInsertCourse.Visible = False
        btnEditCourse.Visible = False
        btnDeleteCourse.Visible = False
        'enable textbox
        txtbxCourseCode.Enabled = True
        txtbxCourseName.Enabled = True
        txtbxCourseDescription.Enabled = True
        'read only
        dgvCourse.Enabled = False
        dgvCourse.ForeColor = Color.Gray 'Changing the first row, provided it exists.
    End Sub

    Private Sub btnCancelSubject_Click(sender As Object, e As EventArgs) Handles btnCancelSubject.Click
        'hide save and cancel button
        btnCancelSubject.Visible = False
        btnSubjectSave.Visible = False
        'visible true insert edit and delete button
        btnInsertSubject.Visible = True
        btnEditSubject.Visible = True
        btnDeleteSubject.Visible = True

        btnInsertSubject.Enabled = True
        btnEditSubject.Enabled = True
        btnDeleteSubject.Enabled = True
        'disabled textbox
        txtbxSubjectCode.Enabled = False
        txtbxSubjectName.Enabled = False
        txtbxSubjectDescription.Enabled = False
        'false read only
        dgvSubjects.Enabled = True
        dgvSubjects.ForeColor = Color.Black 'Changing the first row, provided it exists.

    End Sub

    Private Sub btnCancelCourse_Click(sender As Object, e As EventArgs) Handles btnCancelCourse.Click
        'hide save and cancel button
        btnCancelCourse.Visible = False
        btnCourseSave.Visible = False
        'visible true insert edit and delete button
        btnInsertCourse.Visible = True
        btnEditCourse.Visible = True
        btnDeleteCourse.Visible = True
        'disabled textbox
        txtbxCourseCode.Enabled = False
        txtbxCourseName.Enabled = False
        txtbxCourseDescription.Enabled = False
        'false read only
        dgvCourse.Enabled = True
        dgvCourse.ForeColor = Color.Black 'Changing the first row, provided it exists.

    End Sub
    Private Sub btnSubjectSave_Click(sender As Object, e As EventArgs) Handles btnSubjectSave.Click
        subjectModule.btnSaveSubject()
        dashboardModule.countSubject()
        dashboardModule.countTotalSubjectData()
    End Sub
    'subject keydown event
    Private Sub txtbxSubjectCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbxSubjectCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtbxSubjectName.Focus()

        End If
    End Sub

    Private Sub txtbxSubjectName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbxSubjectName.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtbxSubjectDescription.Focus()
        End If
    End Sub
    Private Sub txtbxSubjectDescription_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbxSubjectDescription.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnSubjectSave.Focus()
        End If
    End Sub
    'Course save button
    Private Sub btnCourseSave_Click(sender As Object, e As EventArgs) Handles btnCourseSave.Click
        courseModule.btnCourseSave()
    End Sub
    'course keydown event
    Private Sub txtbxCourseCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbxCourseCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtbxCourseName.Focus()
        End If
    End Sub

    Private Sub txtbxCourseName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbxCourseName.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtbxCourseDescription.Focus()
        End If
    End Sub

    Private Sub txtbxCourseDescription_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbxCourseDescription.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnCourseSave.Focus()
        End If
    End Sub
    Private Sub btnSaveAddStudentInfo_Click(sender As Object, e As EventArgs) Handles btnSaveAddStudentInfo.Click
        'sub data
        studentModule.SaveStudentData()
        'change panel text
        lblStudentPanel.Text = "Students"
        grbxDefaultViewStudent.Show()
        grbxAddStudent.Hide()
        'enable tools
        btnAddStudent.Enabled = True
        btnEditStudent.Enabled = True
        btnDeleteStudent.Enabled = True
        btnViewStudent.Enabled = True
        'view active button
        hoverAddStudents.Visible = False
        hoverEditStudents.Visible = False
        hoverDeleteStudents.Visible = False
        hoverViewStudents.Visible = False
    End Sub
    'datagridview event
    Private Sub dgvCourse_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCourse.CellClick
        Dim i As Integer
        i = dgvCourse.CurrentRow.Index
        Me.txtbxCourseCode.Text = dgvCourse.Item(0, i).Value
        Me.txtbxCourseName.Text = dgvCourse.Item(1, i).Value
        Me.txtbxCourseDescription.Text = dgvCourse.Item(2, i).Value

    End Sub
    Private Sub dgvSubjects_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSubjects.CellClick
        Dim i As Integer
        i = dgvSubjects.CurrentRow.Index
        Me.txtbxSubjectCode.Text = dgvSubjects.Item(0, i).Value
        Me.txtbxSubjectName.Text = dgvSubjects.Item(1, i).Value
        Me.txtbxSubjectDescription.Text = dgvSubjects.Item(2, i).Value
    End Sub

    Private Sub dgvCourse_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvCourse.KeyDown
        Dim i As Integer
        i = dgvCourse.CurrentRow.Index
        Me.txtbxCourseCode.Text = dgvCourse.Item(0, i).Value
        Me.txtbxCourseName.Text = dgvCourse.Item(1, i).Value
        Me.txtbxCourseDescription.Text = dgvCourse.Item(2, i).Value
    End Sub
    Private Sub dgvSubjects_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvSubjects.KeyDown
        Dim i As Integer
        i = dgvSubjects.CurrentRow.Index
        Me.txtbxSubjectCode.Text = dgvSubjects.Item(0, i).Value
        Me.txtbxSubjectName.Text = dgvSubjects.Item(1, i).Value
        Me.txtbxSubjectDescription.Text = dgvSubjects.Item(2, i).Value

    End Sub
    'Refresh Module
    Private Sub btnRefreshCourse_Click(sender As Object, e As EventArgs) Handles btnRefreshCourse.Click
        courseModule.refreshDataCourse()
    End Sub

    Private Sub btnRefreshSubject_Click(sender As Object, e As EventArgs) Handles btnRefreshSubject.Click
        subjectModule.refreshDataSubject()
        dashboardModule.countSubject()
    End Sub

    Private Sub btnNextToAMSInfo_MouseClick(sender As Object, e As MouseEventArgs) Handles btnNextToStudInfo.MouseClick, btnNextToAMSInfo.MouseClick
        If sender Is btnNextToAMSInfo Then
            grbAMSInfo.Show()
            grbPersonalInfo.Hide()
            grbStudentInformation.Hide()

        ElseIf sender Is btnNextToStudInfo Then
            grbAMSInfo.Hide()
            grbPersonalInfo.Hide()
            grbStudentInformation.Show()
        End If
    End Sub

    Private Sub btnBackToAMSInfo_MouseClick(sender As Object, e As MouseEventArgs) Handles btnBackToPInformation.MouseClick, btnBackToAMSInfo.MouseClick
        If sender Is btnBackToAMSInfo Then
            grbAMSInfo.Show()
            grbPersonalInfo.Hide()
            grbStudentInformation.Hide()
        ElseIf sender Is btnBackToPInformation Then
            grbAMSInfo.Hide()
            grbPersonalInfo.Show()
            grbStudentInformation.Hide()
        End If
    End Sub

End Class