<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panelHeader = New System.Windows.Forms.Panel()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.lblTitleSystem = New System.Windows.Forms.Label()
        Me.panelSideMenu = New System.Windows.Forms.Panel()
        Me.hoverSettings = New System.Windows.Forms.Panel()
        Me.hoverActivity = New System.Windows.Forms.Panel()
        Me.hoverReports = New System.Windows.Forms.Panel()
        Me.hoverAMS = New System.Windows.Forms.Panel()
        Me.hoverSubjects = New System.Windows.Forms.Panel()
        Me.hoverTeachers = New System.Windows.Forms.Panel()
        Me.hoverStudents = New System.Windows.Forms.Panel()
        Me.hoverAttendance = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnMenuAMS = New System.Windows.Forms.Button()
        Me.btnMenuTeachers = New System.Windows.Forms.Button()
        Me.btnMenuStudents = New System.Windows.Forms.Button()
        Me.btnMenuAttendance = New System.Windows.Forms.Button()
        Me.btnMenuDashboard = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.hoverDashboard = New System.Windows.Forms.Panel()
        Me.btnMenuActivity = New System.Windows.Forms.Button()
        Me.menustrip = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeachersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AMSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnMenuSubjects = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnMenuReports = New System.Windows.Forms.Button()
        Me.btnMenuSettings = New System.Windows.Forms.Button()
        Me.panelDashboard = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox31 = New System.Windows.Forms.GroupBox()
        Me.lblMDY = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.dgvAMS = New System.Windows.Forms.DataGridView()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.lblAMSActiveDisplay = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblSubjectActiveDisplay = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.lblServerStatusDisplay = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTotalSubjects = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTotalStudents = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblTotalTeachers = New System.Windows.Forms.Label()
        Me.lblPanelDashboard = New System.Windows.Forms.Label()
        Me.panelMenuAttendance = New System.Windows.Forms.Panel()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.lblPanelAttendance = New System.Windows.Forms.Label()
        Me.panelMenuReports = New System.Windows.Forms.Panel()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.lblPanelReports = New System.Windows.Forms.Label()
        Me.panelMenuActivity = New System.Windows.Forms.Panel()
        Me.panelMenuTeachers = New System.Windows.Forms.Panel()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.lblPanelTeachers = New System.Windows.Forms.Label()
        Me.panelMenuSettings = New System.Windows.Forms.Panel()
        Me.lblSettings = New System.Windows.Forms.Label()
        Me.panelMenuStudents = New System.Windows.Forms.Panel()
        Me.grbStudenInfoContainer = New System.Windows.Forms.GroupBox()
        Me.grbStudenTools = New System.Windows.Forms.GroupBox()
        Me.hoverViewStudents = New System.Windows.Forms.Panel()
        Me.hoverDeleteStudents = New System.Windows.Forms.Panel()
        Me.hoverEditStudents = New System.Windows.Forms.Panel()
        Me.hoverAddStudents = New System.Windows.Forms.Panel()
        Me.btnViewStudent = New System.Windows.Forms.Button()
        Me.btnDeleteStudent = New System.Windows.Forms.Button()
        Me.btnEditStudent = New System.Windows.Forms.Button()
        Me.btnAddStudent = New System.Windows.Forms.Button()
        Me.grbxAddStudent = New System.Windows.Forms.GroupBox()
        Me.grbPersonalInfo = New System.Windows.Forms.GroupBox()
        Me.btnNextToAMSInfo = New System.Windows.Forms.Button()
        Me.cmbxGender = New System.Windows.Forms.ComboBox()
        Me.txtbxEmail = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtbxPhone = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtbxLname = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtbxMname = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtbxFname = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.grbStudentInformation = New System.Windows.Forms.GroupBox()
        Me.btnBackToAMSInfo = New System.Windows.Forms.Button()
        Me.GroupBox23 = New System.Windows.Forms.GroupBox()
        Me.lblStudentYr = New System.Windows.Forms.Label()
        Me.btnImportImage = New System.Windows.Forms.Button()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.GroupBox27 = New System.Windows.Forms.GroupBox()
        Me.lblStudentId = New System.Windows.Forms.Label()
        Me.GroupBox26 = New System.Windows.Forms.GroupBox()
        Me.lblStudentName = New System.Windows.Forms.Label()
        Me.grbAMSInfo = New System.Windows.Forms.GroupBox()
        Me.btnBackToPInformation = New System.Windows.Forms.Button()
        Me.btnNextToStudInfo = New System.Windows.Forms.Button()
        Me.cmbYr_lvl = New System.Windows.Forms.ComboBox()
        Me.cmbxCourse = New System.Windows.Forms.ComboBox()
        Me.GroupBox24 = New System.Windows.Forms.GroupBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtbxStud_ID = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.btnSaveAddStudentInfo = New System.Windows.Forms.Button()
        Me.btnCancelAddStudent = New System.Windows.Forms.Button()
        Me.grbxDefaultViewStudent = New System.Windows.Forms.GroupBox()
        Me.GroupBox32 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox20 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lblStudentPanel = New System.Windows.Forms.Label()
        Me.panelMenuSubjects = New System.Windows.Forms.Panel()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.GroupBox30 = New System.Windows.Forms.GroupBox()
        Me.btnCourseSave = New System.Windows.Forms.Button()
        Me.btnCancelCourse = New System.Windows.Forms.Button()
        Me.btnDeleteCourse = New System.Windows.Forms.Button()
        Me.btnEditCourse = New System.Windows.Forms.Button()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtbxCourseDescription = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtbxCourseName = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.btnInsertCourse = New System.Windows.Forms.Button()
        Me.txtbxCourseCode = New System.Windows.Forms.TextBox()
        Me.GroupBox33 = New System.Windows.Forms.GroupBox()
        Me.dgvCourse = New System.Windows.Forms.DataGridView()
        Me.btnRefreshCourse = New System.Windows.Forms.Button()
        Me.GroupBox28 = New System.Windows.Forms.GroupBox()
        Me.btnSubjectSave = New System.Windows.Forms.Button()
        Me.btnCancelSubject = New System.Windows.Forms.Button()
        Me.GroupBox34 = New System.Windows.Forms.GroupBox()
        Me.dgvSubjects = New System.Windows.Forms.DataGridView()
        Me.btnRefreshSubject = New System.Windows.Forms.Button()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.btnDeleteSubject = New System.Windows.Forms.Button()
        Me.txtbxSubjectDescription = New System.Windows.Forms.TextBox()
        Me.btnEditSubject = New System.Windows.Forms.Button()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtbxSubjectName = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.btnInsertSubject = New System.Windows.Forms.Button()
        Me.txtbxSubjectCode = New System.Windows.Forms.TextBox()
        Me.lblPanelSubjects = New System.Windows.Forms.Label()
        Me.panelAccountProfile = New System.Windows.Forms.Panel()
        Me.grpbxProfile = New System.Windows.Forms.GroupBox()
        Me.GroupBox29 = New System.Windows.Forms.GroupBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox18 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.trackbarR = New System.Windows.Forms.TrackBar()
        Me.trackbarG = New System.Windows.Forms.TrackBar()
        Me.trackbarB = New System.Windows.Forms.TrackBar()
        Me.txtbxR = New System.Windows.Forms.TextBox()
        Me.txtbxG = New System.Windows.Forms.TextBox()
        Me.txtbxB = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtbxDbPass = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.timerRGB = New System.Windows.Forms.Timer(Me.components)
        Me.panelHeader.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.panelSideMenu.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.menustrip.SuspendLayout()
        Me.panelDashboard.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox31.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.dgvAMS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelMenuAttendance.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.panelMenuReports.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.panelMenuTeachers.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.panelMenuSettings.SuspendLayout()
        Me.panelMenuStudents.SuspendLayout()
        Me.grbStudenInfoContainer.SuspendLayout()
        Me.grbStudenTools.SuspendLayout()
        Me.grbxAddStudent.SuspendLayout()
        Me.grbPersonalInfo.SuspendLayout()
        Me.grbStudentInformation.SuspendLayout()
        Me.GroupBox23.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox27.SuspendLayout()
        Me.GroupBox26.SuspendLayout()
        Me.grbAMSInfo.SuspendLayout()
        Me.GroupBox24.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbxDefaultViewStudent.SuspendLayout()
        Me.GroupBox32.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox20.SuspendLayout()
        Me.panelMenuSubjects.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox30.SuspendLayout()
        Me.GroupBox33.SuspendLayout()
        CType(Me.dgvCourse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox28.SuspendLayout()
        Me.GroupBox34.SuspendLayout()
        CType(Me.dgvSubjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelAccountProfile.SuspendLayout()
        Me.grpbxProfile.SuspendLayout()
        Me.GroupBox29.SuspendLayout()
        Me.GroupBox18.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.trackbarR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackbarG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackbarB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox17.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelHeader
        '
        Me.panelHeader.BackColor = System.Drawing.Color.Transparent
        Me.panelHeader.Controls.Add(Me.GroupBox10)
        Me.panelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelHeader.Location = New System.Drawing.Point(0, 0)
        Me.panelHeader.Name = "panelHeader"
        Me.panelHeader.Size = New System.Drawing.Size(1398, 56)
        Me.panelHeader.TabIndex = 3
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.lblTitleSystem)
        Me.GroupBox10.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(1378, 56)
        Me.GroupBox10.TabIndex = 0
        Me.GroupBox10.TabStop = False
        '
        'lblTitleSystem
        '
        Me.lblTitleSystem.AutoSize = True
        Me.lblTitleSystem.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblTitleSystem.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleSystem.Location = New System.Drawing.Point(3, 16)
        Me.lblTitleSystem.Name = "lblTitleSystem"
        Me.lblTitleSystem.Size = New System.Drawing.Size(99, 20)
        Me.lblTitleSystem.TabIndex = 0
        Me.lblTitleSystem.Text = "JRCC-AMS"
        '
        'panelSideMenu
        '
        Me.panelSideMenu.Controls.Add(Me.hoverSettings)
        Me.panelSideMenu.Controls.Add(Me.hoverActivity)
        Me.panelSideMenu.Controls.Add(Me.hoverReports)
        Me.panelSideMenu.Controls.Add(Me.hoverAMS)
        Me.panelSideMenu.Controls.Add(Me.hoverSubjects)
        Me.panelSideMenu.Controls.Add(Me.hoverTeachers)
        Me.panelSideMenu.Controls.Add(Me.hoverStudents)
        Me.panelSideMenu.Controls.Add(Me.hoverAttendance)
        Me.panelSideMenu.Controls.Add(Me.btnLogout)
        Me.panelSideMenu.Controls.Add(Me.btnMenuAMS)
        Me.panelSideMenu.Controls.Add(Me.btnMenuTeachers)
        Me.panelSideMenu.Controls.Add(Me.btnMenuStudents)
        Me.panelSideMenu.Controls.Add(Me.btnMenuAttendance)
        Me.panelSideMenu.Controls.Add(Me.btnMenuDashboard)
        Me.panelSideMenu.Controls.Add(Me.GroupBox2)
        Me.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelSideMenu.Location = New System.Drawing.Point(0, 56)
        Me.panelSideMenu.Name = "panelSideMenu"
        Me.panelSideMenu.Size = New System.Drawing.Size(229, 742)
        Me.panelSideMenu.TabIndex = 0
        '
        'hoverSettings
        '
        Me.hoverSettings.BackColor = System.Drawing.Color.Green
        Me.hoverSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.hoverSettings.Location = New System.Drawing.Point(8, 604)
        Me.hoverSettings.Name = "hoverSettings"
        Me.hoverSettings.Size = New System.Drawing.Size(10, 40)
        Me.hoverSettings.TabIndex = 40
        '
        'hoverActivity
        '
        Me.hoverActivity.BackColor = System.Drawing.Color.Green
        Me.hoverActivity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.hoverActivity.Location = New System.Drawing.Point(8, 558)
        Me.hoverActivity.Name = "hoverActivity"
        Me.hoverActivity.Size = New System.Drawing.Size(10, 40)
        Me.hoverActivity.TabIndex = 39
        '
        'hoverReports
        '
        Me.hoverReports.BackColor = System.Drawing.Color.Green
        Me.hoverReports.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.hoverReports.Location = New System.Drawing.Point(8, 512)
        Me.hoverReports.Name = "hoverReports"
        Me.hoverReports.Size = New System.Drawing.Size(10, 40)
        Me.hoverReports.TabIndex = 38
        '
        'hoverAMS
        '
        Me.hoverAMS.BackColor = System.Drawing.Color.Green
        Me.hoverAMS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.hoverAMS.Location = New System.Drawing.Point(8, 466)
        Me.hoverAMS.Name = "hoverAMS"
        Me.hoverAMS.Size = New System.Drawing.Size(10, 40)
        Me.hoverAMS.TabIndex = 37
        '
        'hoverSubjects
        '
        Me.hoverSubjects.BackColor = System.Drawing.Color.Green
        Me.hoverSubjects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.hoverSubjects.Location = New System.Drawing.Point(8, 420)
        Me.hoverSubjects.Name = "hoverSubjects"
        Me.hoverSubjects.Size = New System.Drawing.Size(10, 40)
        Me.hoverSubjects.TabIndex = 36
        '
        'hoverTeachers
        '
        Me.hoverTeachers.BackColor = System.Drawing.Color.Green
        Me.hoverTeachers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.hoverTeachers.Location = New System.Drawing.Point(8, 374)
        Me.hoverTeachers.Name = "hoverTeachers"
        Me.hoverTeachers.Size = New System.Drawing.Size(10, 40)
        Me.hoverTeachers.TabIndex = 35
        '
        'hoverStudents
        '
        Me.hoverStudents.BackColor = System.Drawing.Color.Green
        Me.hoverStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.hoverStudents.Location = New System.Drawing.Point(8, 328)
        Me.hoverStudents.Name = "hoverStudents"
        Me.hoverStudents.Size = New System.Drawing.Size(10, 40)
        Me.hoverStudents.TabIndex = 34
        '
        'hoverAttendance
        '
        Me.hoverAttendance.BackColor = System.Drawing.Color.Green
        Me.hoverAttendance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.hoverAttendance.Location = New System.Drawing.Point(8, 282)
        Me.hoverAttendance.Name = "hoverAttendance"
        Me.hoverAttendance.Size = New System.Drawing.Size(10, 40)
        Me.hoverAttendance.TabIndex = 33
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(25, 650)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(176, 40)
        Me.btnLogout.TabIndex = 8
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnMenuAMS
        '
        Me.btnMenuAMS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenuAMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuAMS.Location = New System.Drawing.Point(25, 466)
        Me.btnMenuAMS.Name = "btnMenuAMS"
        Me.btnMenuAMS.Size = New System.Drawing.Size(176, 40)
        Me.btnMenuAMS.TabIndex = 6
        Me.btnMenuAMS.Text = "AMS"
        Me.btnMenuAMS.UseVisualStyleBackColor = True
        '
        'btnMenuTeachers
        '
        Me.btnMenuTeachers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenuTeachers.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuTeachers.Image = Global.JRCC_AMS.My.Resources.Resources.teacher__2_
        Me.btnMenuTeachers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuTeachers.Location = New System.Drawing.Point(25, 374)
        Me.btnMenuTeachers.Name = "btnMenuTeachers"
        Me.btnMenuTeachers.Size = New System.Drawing.Size(176, 40)
        Me.btnMenuTeachers.TabIndex = 5
        Me.btnMenuTeachers.Text = "Teachers"
        Me.btnMenuTeachers.UseVisualStyleBackColor = True
        '
        'btnMenuStudents
        '
        Me.btnMenuStudents.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenuStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuStudents.Image = Global.JRCC_AMS.My.Resources.Resources.student__3_
        Me.btnMenuStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuStudents.Location = New System.Drawing.Point(25, 328)
        Me.btnMenuStudents.Name = "btnMenuStudents"
        Me.btnMenuStudents.Size = New System.Drawing.Size(176, 40)
        Me.btnMenuStudents.TabIndex = 4
        Me.btnMenuStudents.Text = "Students"
        Me.btnMenuStudents.UseVisualStyleBackColor = True
        '
        'btnMenuAttendance
        '
        Me.btnMenuAttendance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenuAttendance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuAttendance.Image = Global.JRCC_AMS.My.Resources.Resources.notepad__1_
        Me.btnMenuAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuAttendance.Location = New System.Drawing.Point(25, 282)
        Me.btnMenuAttendance.Name = "btnMenuAttendance"
        Me.btnMenuAttendance.Size = New System.Drawing.Size(176, 40)
        Me.btnMenuAttendance.TabIndex = 3
        Me.btnMenuAttendance.Text = "Attendance"
        Me.btnMenuAttendance.UseVisualStyleBackColor = True
        '
        'btnMenuDashboard
        '
        Me.btnMenuDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenuDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuDashboard.Image = Global.JRCC_AMS.My.Resources.Resources.dashboard
        Me.btnMenuDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuDashboard.Location = New System.Drawing.Point(25, 236)
        Me.btnMenuDashboard.Name = "btnMenuDashboard"
        Me.btnMenuDashboard.Size = New System.Drawing.Size(176, 40)
        Me.btnMenuDashboard.TabIndex = 2
        Me.btnMenuDashboard.Text = "Dashboard"
        Me.btnMenuDashboard.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.hoverDashboard)
        Me.GroupBox2.Controls.Add(Me.btnMenuActivity)
        Me.GroupBox2.Controls.Add(Me.menustrip)
        Me.GroupBox2.Controls.Add(Me.btnMenuSubjects)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnMenuReports)
        Me.GroupBox2.Controls.Add(Me.btnMenuSettings)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(215, 715)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(3, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(209, 146)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'hoverDashboard
        '
        Me.hoverDashboard.BackColor = System.Drawing.Color.Green
        Me.hoverDashboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.hoverDashboard.Location = New System.Drawing.Point(0, 230)
        Me.hoverDashboard.Name = "hoverDashboard"
        Me.hoverDashboard.Size = New System.Drawing.Size(10, 40)
        Me.hoverDashboard.TabIndex = 32
        '
        'btnMenuActivity
        '
        Me.btnMenuActivity.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenuActivity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuActivity.Location = New System.Drawing.Point(17, 552)
        Me.btnMenuActivity.Name = "btnMenuActivity"
        Me.btnMenuActivity.Size = New System.Drawing.Size(176, 40)
        Me.btnMenuActivity.TabIndex = 0
        Me.btnMenuActivity.Text = "Activity"
        Me.btnMenuActivity.UseVisualStyleBackColor = True
        '
        'menustrip
        '
        Me.menustrip.BackColor = System.Drawing.Color.Transparent
        Me.menustrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.menustrip.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.menustrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.menustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.ProfileToolStripMenuItem})
        Me.menustrip.Location = New System.Drawing.Point(3, 33)
        Me.menustrip.Name = "menustrip"
        Me.menustrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.menustrip.Size = New System.Drawing.Size(209, 27)
        Me.menustrip.TabIndex = 0
        Me.menustrip.Text = "menustripHeader"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DashboardToolStripMenuItem, Me.AttendanceToolStripMenuItem, Me.StudentsToolStripMenuItem, Me.TeachersToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.AMSToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.BackupToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.LogoutToolStripMenuItem1})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(57, 23)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'DashboardToolStripMenuItem
        '
        Me.DashboardToolStripMenuItem.Image = Global.JRCC_AMS.My.Resources.Resources.dashboard__1_
        Me.DashboardToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        Me.DashboardToolStripMenuItem.Size = New System.Drawing.Size(148, 24)
        Me.DashboardToolStripMenuItem.Text = "Dashboard"
        '
        'AttendanceToolStripMenuItem
        '
        Me.AttendanceToolStripMenuItem.Image = Global.JRCC_AMS.My.Resources.Resources.notepad__2_
        Me.AttendanceToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AttendanceToolStripMenuItem.Name = "AttendanceToolStripMenuItem"
        Me.AttendanceToolStripMenuItem.Size = New System.Drawing.Size(148, 24)
        Me.AttendanceToolStripMenuItem.Text = "Attendance"
        '
        'StudentsToolStripMenuItem
        '
        Me.StudentsToolStripMenuItem.Image = Global.JRCC_AMS.My.Resources.Resources.student__2_
        Me.StudentsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StudentsToolStripMenuItem.Name = "StudentsToolStripMenuItem"
        Me.StudentsToolStripMenuItem.Size = New System.Drawing.Size(148, 24)
        Me.StudentsToolStripMenuItem.Text = "Students"
        '
        'TeachersToolStripMenuItem
        '
        Me.TeachersToolStripMenuItem.Image = Global.JRCC_AMS.My.Resources.Resources.teacher__2_
        Me.TeachersToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TeachersToolStripMenuItem.Name = "TeachersToolStripMenuItem"
        Me.TeachersToolStripMenuItem.Size = New System.Drawing.Size(148, 24)
        Me.TeachersToolStripMenuItem.Text = "Teachers"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Image = Global.JRCC_AMS.My.Resources.Resources.open_book__2_
        Me.ReportsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(148, 24)
        Me.ReportsToolStripMenuItem.Text = "Subjects"
        '
        'AMSToolStripMenuItem
        '
        Me.AMSToolStripMenuItem.Name = "AMSToolStripMenuItem"
        Me.AMSToolStripMenuItem.Size = New System.Drawing.Size(148, 24)
        Me.AMSToolStripMenuItem.Text = "AMS"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(148, 24)
        Me.SettingsToolStripMenuItem.Text = "Reports"
        '
        'BackupToolStripMenuItem
        '
        Me.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem"
        Me.BackupToolStripMenuItem.Size = New System.Drawing.Size(148, 24)
        Me.BackupToolStripMenuItem.Text = "Activity"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = Global.JRCC_AMS.My.Resources.Resources.ui__1_
        Me.LogoutToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(148, 24)
        Me.LogoutToolStripMenuItem.Text = "Settings"
        '
        'LogoutToolStripMenuItem1
        '
        Me.LogoutToolStripMenuItem1.Name = "LogoutToolStripMenuItem1"
        Me.LogoutToolStripMenuItem1.Size = New System.Drawing.Size(148, 24)
        Me.LogoutToolStripMenuItem1.Text = "Logout"
        '
        'ProfileToolStripMenuItem
        '
        Me.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        Me.ProfileToolStripMenuItem.Size = New System.Drawing.Size(59, 23)
        Me.ProfileToolStripMenuItem.Text = "Profile"
        '
        'btnMenuSubjects
        '
        Me.btnMenuSubjects.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenuSubjects.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuSubjects.Image = Global.JRCC_AMS.My.Resources.Resources.open_book__1_
        Me.btnMenuSubjects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuSubjects.Location = New System.Drawing.Point(17, 414)
        Me.btnMenuSubjects.Name = "btnMenuSubjects"
        Me.btnMenuSubjects.Size = New System.Drawing.Size(176, 40)
        Me.btnMenuSubjects.TabIndex = 4
        Me.btnMenuSubjects.Text = "Subjects"
        Me.btnMenuSubjects.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ADMIN"
        '
        'btnMenuReports
        '
        Me.btnMenuReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenuReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuReports.Location = New System.Drawing.Point(17, 506)
        Me.btnMenuReports.Name = "btnMenuReports"
        Me.btnMenuReports.Size = New System.Drawing.Size(176, 40)
        Me.btnMenuReports.TabIndex = 5
        Me.btnMenuReports.Text = "Reports"
        Me.btnMenuReports.UseVisualStyleBackColor = True
        '
        'btnMenuSettings
        '
        Me.btnMenuSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenuSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuSettings.Image = Global.JRCC_AMS.My.Resources.Resources.ui
        Me.btnMenuSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuSettings.Location = New System.Drawing.Point(17, 598)
        Me.btnMenuSettings.Name = "btnMenuSettings"
        Me.btnMenuSettings.Size = New System.Drawing.Size(176, 40)
        Me.btnMenuSettings.TabIndex = 1
        Me.btnMenuSettings.Text = "Settings"
        Me.btnMenuSettings.UseVisualStyleBackColor = True
        '
        'panelDashboard
        '
        Me.panelDashboard.Controls.Add(Me.GroupBox3)
        Me.panelDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDashboard.Location = New System.Drawing.Point(229, 56)
        Me.panelDashboard.Name = "panelDashboard"
        Me.panelDashboard.Size = New System.Drawing.Size(1169, 742)
        Me.panelDashboard.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox31)
        Me.GroupBox3.Controls.Add(Me.GroupBox9)
        Me.GroupBox3.Controls.Add(Me.GroupBox8)
        Me.GroupBox3.Controls.Add(Me.GroupBox7)
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.lblPanelDashboard)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1154, 715)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'GroupBox31
        '
        Me.GroupBox31.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox31.Controls.Add(Me.lblMDY)
        Me.GroupBox31.Location = New System.Drawing.Point(725, 142)
        Me.GroupBox31.Name = "GroupBox31"
        Me.GroupBox31.Size = New System.Drawing.Size(426, 59)
        Me.GroupBox31.TabIndex = 7
        Me.GroupBox31.TabStop = False
        '
        'lblMDY
        '
        Me.lblMDY.AutoSize = True
        Me.lblMDY.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblMDY.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMDY.Location = New System.Drawing.Point(371, 16)
        Me.lblMDY.Name = "lblMDY"
        Me.lblMDY.Size = New System.Drawing.Size(52, 26)
        Me.lblMDY.TabIndex = 0
        Me.lblMDY.Text = "-----"
        Me.lblMDY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.dgvAMS)
        Me.GroupBox9.Location = New System.Drawing.Point(18, 331)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(616, 353)
        Me.GroupBox9.TabIndex = 0
        Me.GroupBox9.TabStop = False
        '
        'dgvAMS
        '
        Me.dgvAMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAMS.Location = New System.Drawing.Point(21, 19)
        Me.dgvAMS.Name = "dgvAMS"
        Me.dgvAMS.Size = New System.Drawing.Size(575, 318)
        Me.dgvAMS.TabIndex = 0
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.lblAMSActiveDisplay)
        Me.GroupBox8.Controls.Add(Me.Label13)
        Me.GroupBox8.Controls.Add(Me.lblSubjectActiveDisplay)
        Me.GroupBox8.Controls.Add(Me.Label12)
        Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox8.Location = New System.Drawing.Point(3, 88)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(1148, 50)
        Me.GroupBox8.TabIndex = 0
        Me.GroupBox8.TabStop = False
        '
        'lblAMSActiveDisplay
        '
        Me.lblAMSActiveDisplay.AutoSize = True
        Me.lblAMSActiveDisplay.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblAMSActiveDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAMSActiveDisplay.Location = New System.Drawing.Point(148, 16)
        Me.lblAMSActiveDisplay.Name = "lblAMSActiveDisplay"
        Me.lblAMSActiveDisplay.Size = New System.Drawing.Size(33, 17)
        Me.lblAMSActiveDisplay.TabIndex = 1
        Me.lblAMSActiveDisplay.Text = "-----"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(103, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 17)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "AMS:"
        '
        'lblSubjectActiveDisplay
        '
        Me.lblSubjectActiveDisplay.AutoSize = True
        Me.lblSubjectActiveDisplay.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblSubjectActiveDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjectActiveDisplay.Location = New System.Drawing.Point(70, 16)
        Me.lblSubjectActiveDisplay.Name = "lblSubjectActiveDisplay"
        Me.lblSubjectActiveDisplay.Size = New System.Drawing.Size(33, 17)
        Me.lblSubjectActiveDisplay.TabIndex = 2
        Me.lblSubjectActiveDisplay.Text = "-----"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 17)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Subject:"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.lblServerStatusDisplay)
        Me.GroupBox7.Controls.Add(Me.Label9)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox7.Location = New System.Drawing.Point(3, 45)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(1148, 43)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        '
        'lblServerStatusDisplay
        '
        Me.lblServerStatusDisplay.AutoSize = True
        Me.lblServerStatusDisplay.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblServerStatusDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServerStatusDisplay.Location = New System.Drawing.Point(115, 16)
        Me.lblServerStatusDisplay.Name = "lblServerStatusDisplay"
        Me.lblServerStatusDisplay.Size = New System.Drawing.Size(33, 17)
        Me.lblServerStatusDisplay.TabIndex = 0
        Me.lblServerStatusDisplay.Text = "-----"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 17)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Server Status:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.PictureBox3)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.lblTotalSubjects)
        Me.GroupBox6.Location = New System.Drawing.Point(448, 149)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(189, 146)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox3.Image = Global.JRCC_AMS.My.Resources.Resources.open_book
        Me.PictureBox3.Location = New System.Drawing.Point(3, 16)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(31, 127)
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(43, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 17)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Subjects"
        '
        'lblTotalSubjects
        '
        Me.lblTotalSubjects.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotalSubjects.AutoSize = True
        Me.lblTotalSubjects.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSubjects.Location = New System.Drawing.Point(61, 57)
        Me.lblTotalSubjects.Name = "lblTotalSubjects"
        Me.lblTotalSubjects.Size = New System.Drawing.Size(43, 46)
        Me.lblTotalSubjects.TabIndex = 0
        Me.lblTotalSubjects.Text = "0"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.PictureBox2)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.lblTotalStudents)
        Me.GroupBox5.Location = New System.Drawing.Point(234, 149)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(189, 146)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = Global.JRCC_AMS.My.Resources.Resources.student
        Me.PictureBox2.Location = New System.Drawing.Point(3, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 127)
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(43, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Students"
        '
        'lblTotalStudents
        '
        Me.lblTotalStudents.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotalStudents.AutoSize = True
        Me.lblTotalStudents.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalStudents.Location = New System.Drawing.Point(53, 57)
        Me.lblTotalStudents.Name = "lblTotalStudents"
        Me.lblTotalStudents.Size = New System.Drawing.Size(43, 46)
        Me.lblTotalStudents.TabIndex = 0
        Me.lblTotalStudents.Text = "0"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.PictureBox1)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.lblTotalTeachers)
        Me.GroupBox4.Location = New System.Drawing.Point(21, 149)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(189, 146)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.JRCC_AMS.My.Resources.Resources.teacher__3_
        Me.PictureBox1.Location = New System.Drawing.Point(3, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 127)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(43, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Teachers"
        '
        'lblTotalTeachers
        '
        Me.lblTotalTeachers.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotalTeachers.AutoSize = True
        Me.lblTotalTeachers.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTeachers.Location = New System.Drawing.Point(67, 57)
        Me.lblTotalTeachers.Name = "lblTotalTeachers"
        Me.lblTotalTeachers.Size = New System.Drawing.Size(43, 46)
        Me.lblTotalTeachers.TabIndex = 1
        Me.lblTotalTeachers.Text = "0"
        '
        'lblPanelDashboard
        '
        Me.lblPanelDashboard.AutoSize = True
        Me.lblPanelDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPanelDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPanelDashboard.Location = New System.Drawing.Point(3, 16)
        Me.lblPanelDashboard.Name = "lblPanelDashboard"
        Me.lblPanelDashboard.Size = New System.Drawing.Size(131, 29)
        Me.lblPanelDashboard.TabIndex = 6
        Me.lblPanelDashboard.Text = "Dashboard"
        '
        'panelMenuAttendance
        '
        Me.panelMenuAttendance.Controls.Add(Me.GroupBox11)
        Me.panelMenuAttendance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMenuAttendance.Location = New System.Drawing.Point(229, 56)
        Me.panelMenuAttendance.Name = "panelMenuAttendance"
        Me.panelMenuAttendance.Size = New System.Drawing.Size(1169, 742)
        Me.panelMenuAttendance.TabIndex = 3
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.lblPanelAttendance)
        Me.GroupBox11.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(1154, 715)
        Me.GroupBox11.TabIndex = 4
        Me.GroupBox11.TabStop = False
        '
        'lblPanelAttendance
        '
        Me.lblPanelAttendance.AutoSize = True
        Me.lblPanelAttendance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPanelAttendance.Location = New System.Drawing.Point(8, 17)
        Me.lblPanelAttendance.Name = "lblPanelAttendance"
        Me.lblPanelAttendance.Size = New System.Drawing.Size(133, 29)
        Me.lblPanelAttendance.TabIndex = 3
        Me.lblPanelAttendance.Text = "Attendance"
        '
        'panelMenuReports
        '
        Me.panelMenuReports.Controls.Add(Me.GroupBox12)
        Me.panelMenuReports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMenuReports.Location = New System.Drawing.Point(229, 56)
        Me.panelMenuReports.Name = "panelMenuReports"
        Me.panelMenuReports.Size = New System.Drawing.Size(1169, 742)
        Me.panelMenuReports.TabIndex = 4
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.lblPanelReports)
        Me.GroupBox12.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(1154, 715)
        Me.GroupBox12.TabIndex = 5
        Me.GroupBox12.TabStop = False
        '
        'lblPanelReports
        '
        Me.lblPanelReports.AutoSize = True
        Me.lblPanelReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPanelReports.Location = New System.Drawing.Point(8, 17)
        Me.lblPanelReports.Name = "lblPanelReports"
        Me.lblPanelReports.Size = New System.Drawing.Size(98, 29)
        Me.lblPanelReports.TabIndex = 3
        Me.lblPanelReports.Text = "Reports"
        '
        'panelMenuActivity
        '
        Me.panelMenuActivity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMenuActivity.Location = New System.Drawing.Point(229, 56)
        Me.panelMenuActivity.Name = "panelMenuActivity"
        Me.panelMenuActivity.Size = New System.Drawing.Size(1169, 742)
        Me.panelMenuActivity.TabIndex = 5
        '
        'panelMenuTeachers
        '
        Me.panelMenuTeachers.Controls.Add(Me.GroupBox14)
        Me.panelMenuTeachers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMenuTeachers.Location = New System.Drawing.Point(229, 56)
        Me.panelMenuTeachers.Name = "panelMenuTeachers"
        Me.panelMenuTeachers.Size = New System.Drawing.Size(1169, 742)
        Me.panelMenuTeachers.TabIndex = 6
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.lblPanelTeachers)
        Me.GroupBox14.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(1154, 715)
        Me.GroupBox14.TabIndex = 7
        Me.GroupBox14.TabStop = False
        '
        'lblPanelTeachers
        '
        Me.lblPanelTeachers.AutoSize = True
        Me.lblPanelTeachers.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPanelTeachers.Location = New System.Drawing.Point(8, 17)
        Me.lblPanelTeachers.Name = "lblPanelTeachers"
        Me.lblPanelTeachers.Size = New System.Drawing.Size(115, 29)
        Me.lblPanelTeachers.TabIndex = 3
        Me.lblPanelTeachers.Text = "Teachers"
        '
        'panelMenuSettings
        '
        Me.panelMenuSettings.Controls.Add(Me.lblSettings)
        Me.panelMenuSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMenuSettings.Location = New System.Drawing.Point(229, 56)
        Me.panelMenuSettings.Name = "panelMenuSettings"
        Me.panelMenuSettings.Size = New System.Drawing.Size(1169, 742)
        Me.panelMenuSettings.TabIndex = 7
        '
        'lblSettings
        '
        Me.lblSettings.AutoSize = True
        Me.lblSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettings.Location = New System.Drawing.Point(14, 11)
        Me.lblSettings.Name = "lblSettings"
        Me.lblSettings.Size = New System.Drawing.Size(140, 39)
        Me.lblSettings.TabIndex = 0
        Me.lblSettings.Text = "Settings"
        '
        'panelMenuStudents
        '
        Me.panelMenuStudents.Controls.Add(Me.grbStudenInfoContainer)
        Me.panelMenuStudents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMenuStudents.Location = New System.Drawing.Point(229, 56)
        Me.panelMenuStudents.Name = "panelMenuStudents"
        Me.panelMenuStudents.Size = New System.Drawing.Size(1169, 742)
        Me.panelMenuStudents.TabIndex = 7
        '
        'grbStudenInfoContainer
        '
        Me.grbStudenInfoContainer.Controls.Add(Me.grbStudenTools)
        Me.grbStudenInfoContainer.Controls.Add(Me.grbxAddStudent)
        Me.grbStudenInfoContainer.Controls.Add(Me.grbxDefaultViewStudent)
        Me.grbStudenInfoContainer.Controls.Add(Me.lblStudentPanel)
        Me.grbStudenInfoContainer.Location = New System.Drawing.Point(3, 6)
        Me.grbStudenInfoContainer.Name = "grbStudenInfoContainer"
        Me.grbStudenInfoContainer.Size = New System.Drawing.Size(1154, 715)
        Me.grbStudenInfoContainer.TabIndex = 8
        Me.grbStudenInfoContainer.TabStop = False
        '
        'grbStudenTools
        '
        Me.grbStudenTools.Controls.Add(Me.hoverViewStudents)
        Me.grbStudenTools.Controls.Add(Me.hoverDeleteStudents)
        Me.grbStudenTools.Controls.Add(Me.hoverEditStudents)
        Me.grbStudenTools.Controls.Add(Me.hoverAddStudents)
        Me.grbStudenTools.Controls.Add(Me.btnViewStudent)
        Me.grbStudenTools.Controls.Add(Me.btnDeleteStudent)
        Me.grbStudenTools.Controls.Add(Me.btnEditStudent)
        Me.grbStudenTools.Controls.Add(Me.btnAddStudent)
        Me.grbStudenTools.Location = New System.Drawing.Point(478, 19)
        Me.grbStudenTools.Name = "grbStudenTools"
        Me.grbStudenTools.Size = New System.Drawing.Size(659, 115)
        Me.grbStudenTools.TabIndex = 7
        Me.grbStudenTools.TabStop = False
        Me.grbStudenTools.Text = "Tools"
        '
        'hoverViewStudents
        '
        Me.hoverViewStudents.BackColor = System.Drawing.Color.Green
        Me.hoverViewStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.hoverViewStudents.Location = New System.Drawing.Point(508, 97)
        Me.hoverViewStudents.Name = "hoverViewStudents"
        Me.hoverViewStudents.Size = New System.Drawing.Size(136, 7)
        Me.hoverViewStudents.TabIndex = 36
        '
        'hoverDeleteStudents
        '
        Me.hoverDeleteStudents.BackColor = System.Drawing.Color.Green
        Me.hoverDeleteStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.hoverDeleteStudents.Location = New System.Drawing.Point(351, 97)
        Me.hoverDeleteStudents.Name = "hoverDeleteStudents"
        Me.hoverDeleteStudents.Size = New System.Drawing.Size(143, 6)
        Me.hoverDeleteStudents.TabIndex = 35
        '
        'hoverEditStudents
        '
        Me.hoverEditStudents.BackColor = System.Drawing.Color.Green
        Me.hoverEditStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.hoverEditStudents.Location = New System.Drawing.Point(192, 97)
        Me.hoverEditStudents.Name = "hoverEditStudents"
        Me.hoverEditStudents.Size = New System.Drawing.Size(143, 6)
        Me.hoverEditStudents.TabIndex = 34
        '
        'hoverAddStudents
        '
        Me.hoverAddStudents.BackColor = System.Drawing.Color.Green
        Me.hoverAddStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.hoverAddStudents.Location = New System.Drawing.Point(30, 97)
        Me.hoverAddStudents.Name = "hoverAddStudents"
        Me.hoverAddStudents.Size = New System.Drawing.Size(143, 6)
        Me.hoverAddStudents.TabIndex = 33
        '
        'btnViewStudent
        '
        Me.btnViewStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewStudent.Image = Global.JRCC_AMS.My.Resources.Resources.look
        Me.btnViewStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewStudent.Location = New System.Drawing.Point(508, 33)
        Me.btnViewStudent.Name = "btnViewStudent"
        Me.btnViewStudent.Size = New System.Drawing.Size(136, 61)
        Me.btnViewStudent.TabIndex = 7
        Me.btnViewStudent.Text = "View"
        Me.btnViewStudent.UseVisualStyleBackColor = True
        '
        'btnDeleteStudent
        '
        Me.btnDeleteStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteStudent.Image = Global.JRCC_AMS.My.Resources.Resources.delete
        Me.btnDeleteStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteStudent.Location = New System.Drawing.Point(351, 33)
        Me.btnDeleteStudent.Name = "btnDeleteStudent"
        Me.btnDeleteStudent.Size = New System.Drawing.Size(143, 61)
        Me.btnDeleteStudent.TabIndex = 6
        Me.btnDeleteStudent.Text = "Delete"
        Me.btnDeleteStudent.UseVisualStyleBackColor = True
        '
        'btnEditStudent
        '
        Me.btnEditStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditStudent.Image = Global.JRCC_AMS.My.Resources.Resources.note
        Me.btnEditStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditStudent.Location = New System.Drawing.Point(189, 34)
        Me.btnEditStudent.Name = "btnEditStudent"
        Me.btnEditStudent.Size = New System.Drawing.Size(146, 60)
        Me.btnEditStudent.TabIndex = 5
        Me.btnEditStudent.Text = "Edit"
        Me.btnEditStudent.UseVisualStyleBackColor = True
        '
        'btnAddStudent
        '
        Me.btnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStudent.Image = Global.JRCC_AMS.My.Resources.Resources.student__4_
        Me.btnAddStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddStudent.Location = New System.Drawing.Point(30, 34)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(143, 61)
        Me.btnAddStudent.TabIndex = 4
        Me.btnAddStudent.Text = "Add"
        Me.btnAddStudent.UseVisualStyleBackColor = True
        '
        'grbxAddStudent
        '
        Me.grbxAddStudent.Controls.Add(Me.grbPersonalInfo)
        Me.grbxAddStudent.Controls.Add(Me.grbStudentInformation)
        Me.grbxAddStudent.Controls.Add(Me.grbAMSInfo)
        Me.grbxAddStudent.Controls.Add(Me.btnSaveAddStudentInfo)
        Me.grbxAddStudent.Controls.Add(Me.btnCancelAddStudent)
        Me.grbxAddStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbxAddStudent.Location = New System.Drawing.Point(13, 158)
        Me.grbxAddStudent.Name = "grbxAddStudent"
        Me.grbxAddStudent.Size = New System.Drawing.Size(1124, 541)
        Me.grbxAddStudent.TabIndex = 13
        Me.grbxAddStudent.TabStop = False
        '
        'grbPersonalInfo
        '
        Me.grbPersonalInfo.Controls.Add(Me.btnNextToAMSInfo)
        Me.grbPersonalInfo.Controls.Add(Me.cmbxGender)
        Me.grbPersonalInfo.Controls.Add(Me.txtbxEmail)
        Me.grbPersonalInfo.Controls.Add(Me.Label23)
        Me.grbPersonalInfo.Controls.Add(Me.txtbxPhone)
        Me.grbPersonalInfo.Controls.Add(Me.Label22)
        Me.grbPersonalInfo.Controls.Add(Me.Label21)
        Me.grbPersonalInfo.Controls.Add(Me.txtbxLname)
        Me.grbPersonalInfo.Controls.Add(Me.Label20)
        Me.grbPersonalInfo.Controls.Add(Me.txtbxMname)
        Me.grbPersonalInfo.Controls.Add(Me.Label19)
        Me.grbPersonalInfo.Controls.Add(Me.txtbxFname)
        Me.grbPersonalInfo.Controls.Add(Me.Label18)
        Me.grbPersonalInfo.Location = New System.Drawing.Point(26, 30)
        Me.grbPersonalInfo.Name = "grbPersonalInfo"
        Me.grbPersonalInfo.Size = New System.Drawing.Size(481, 247)
        Me.grbPersonalInfo.TabIndex = 1
        Me.grbPersonalInfo.TabStop = False
        Me.grbPersonalInfo.Text = "Personal Information"
        '
        'btnNextToAMSInfo
        '
        Me.btnNextToAMSInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNextToAMSInfo.Image = Global.JRCC_AMS.My.Resources.Resources.next__1_
        Me.btnNextToAMSInfo.Location = New System.Drawing.Point(382, 205)
        Me.btnNextToAMSInfo.Name = "btnNextToAMSInfo"
        Me.btnNextToAMSInfo.Size = New System.Drawing.Size(87, 31)
        Me.btnNextToAMSInfo.TabIndex = 14
        Me.btnNextToAMSInfo.UseVisualStyleBackColor = True
        '
        'cmbxGender
        '
        Me.cmbxGender.FormattingEnabled = True
        Me.cmbxGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbxGender.Location = New System.Drawing.Point(19, 205)
        Me.cmbxGender.Name = "cmbxGender"
        Me.cmbxGender.Size = New System.Drawing.Size(182, 24)
        Me.cmbxGender.TabIndex = 13
        '
        'txtbxEmail
        '
        Me.txtbxEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxEmail.Location = New System.Drawing.Point(238, 96)
        Me.txtbxEmail.Name = "txtbxEmail"
        Me.txtbxEmail.Size = New System.Drawing.Size(184, 23)
        Me.txtbxEmail.TabIndex = 12
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(235, 78)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(47, 17)
        Me.Label23.TabIndex = 11
        Me.Label23.Text = "E-mail"
        '
        'txtbxPhone
        '
        Me.txtbxPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxPhone.Location = New System.Drawing.Point(238, 42)
        Me.txtbxPhone.Name = "txtbxPhone"
        Me.txtbxPhone.Size = New System.Drawing.Size(184, 23)
        Me.txtbxPhone.TabIndex = 10
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(235, 24)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(49, 17)
        Me.Label22.TabIndex = 9
        Me.Label22.Text = "Phone"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(14, 182)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(56, 17)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "Gender"
        '
        'txtbxLname
        '
        Me.txtbxLname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxLname.Location = New System.Drawing.Point(17, 149)
        Me.txtbxLname.Name = "txtbxLname"
        Me.txtbxLname.Size = New System.Drawing.Size(184, 23)
        Me.txtbxLname.TabIndex = 6
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(14, 131)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(76, 17)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "Last Name"
        '
        'txtbxMname
        '
        Me.txtbxMname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxMname.Location = New System.Drawing.Point(17, 96)
        Me.txtbxMname.Name = "txtbxMname"
        Me.txtbxMname.Size = New System.Drawing.Size(184, 23)
        Me.txtbxMname.TabIndex = 4
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(14, 78)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(90, 17)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "Middle Name"
        '
        'txtbxFname
        '
        Me.txtbxFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxFname.Location = New System.Drawing.Point(16, 44)
        Me.txtbxFname.Name = "txtbxFname"
        Me.txtbxFname.Size = New System.Drawing.Size(184, 23)
        Me.txtbxFname.TabIndex = 2
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(13, 26)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(76, 17)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "First Name"
        '
        'grbStudentInformation
        '
        Me.grbStudentInformation.Controls.Add(Me.btnBackToAMSInfo)
        Me.grbStudentInformation.Controls.Add(Me.GroupBox23)
        Me.grbStudentInformation.Controls.Add(Me.btnImportImage)
        Me.grbStudentInformation.Controls.Add(Me.PictureBox6)
        Me.grbStudentInformation.Controls.Add(Me.GroupBox27)
        Me.grbStudentInformation.Controls.Add(Me.GroupBox26)
        Me.grbStudentInformation.Location = New System.Drawing.Point(26, 282)
        Me.grbStudentInformation.Name = "grbStudentInformation"
        Me.grbStudentInformation.Size = New System.Drawing.Size(481, 247)
        Me.grbStudentInformation.TabIndex = 31
        Me.grbStudentInformation.TabStop = False
        '
        'btnBackToAMSInfo
        '
        Me.btnBackToAMSInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBackToAMSInfo.Image = Global.JRCC_AMS.My.Resources.Resources.back
        Me.btnBackToAMSInfo.Location = New System.Drawing.Point(382, 205)
        Me.btnBackToAMSInfo.Name = "btnBackToAMSInfo"
        Me.btnBackToAMSInfo.Size = New System.Drawing.Size(87, 31)
        Me.btnBackToAMSInfo.TabIndex = 32
        Me.btnBackToAMSInfo.UseVisualStyleBackColor = True
        '
        'GroupBox23
        '
        Me.GroupBox23.Controls.Add(Me.lblStudentYr)
        Me.GroupBox23.Location = New System.Drawing.Point(208, 133)
        Me.GroupBox23.Name = "GroupBox23"
        Me.GroupBox23.Size = New System.Drawing.Size(247, 44)
        Me.GroupBox23.TabIndex = 7
        Me.GroupBox23.TabStop = False
        '
        'lblStudentYr
        '
        Me.lblStudentYr.AutoSize = True
        Me.lblStudentYr.Enabled = False
        Me.lblStudentYr.Location = New System.Drawing.Point(11, 15)
        Me.lblStudentYr.Name = "lblStudentYr"
        Me.lblStudentYr.Size = New System.Drawing.Size(33, 17)
        Me.lblStudentYr.TabIndex = 1
        Me.lblStudentYr.Text = "-----"
        '
        'btnImportImage
        '
        Me.btnImportImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportImage.Location = New System.Drawing.Point(23, 185)
        Me.btnImportImage.Name = "btnImportImage"
        Me.btnImportImage.Size = New System.Drawing.Size(177, 32)
        Me.btnImportImage.TabIndex = 31
        Me.btnImportImage.Text = "Import"
        Me.btnImportImage.UseVisualStyleBackColor = True
        '
        'PictureBox6
        '
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox6.Location = New System.Drawing.Point(22, 52)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(178, 127)
        Me.PictureBox6.TabIndex = 1
        Me.PictureBox6.TabStop = False
        '
        'GroupBox27
        '
        Me.GroupBox27.Controls.Add(Me.lblStudentId)
        Me.GroupBox27.Location = New System.Drawing.Point(208, 88)
        Me.GroupBox27.Name = "GroupBox27"
        Me.GroupBox27.Size = New System.Drawing.Size(247, 44)
        Me.GroupBox27.TabIndex = 6
        Me.GroupBox27.TabStop = False
        '
        'lblStudentId
        '
        Me.lblStudentId.AutoSize = True
        Me.lblStudentId.Enabled = False
        Me.lblStudentId.Location = New System.Drawing.Point(11, 15)
        Me.lblStudentId.Name = "lblStudentId"
        Me.lblStudentId.Size = New System.Drawing.Size(33, 17)
        Me.lblStudentId.TabIndex = 1
        Me.lblStudentId.Text = "-----"
        '
        'GroupBox26
        '
        Me.GroupBox26.Controls.Add(Me.lblStudentName)
        Me.GroupBox26.Location = New System.Drawing.Point(208, 43)
        Me.GroupBox26.Name = "GroupBox26"
        Me.GroupBox26.Size = New System.Drawing.Size(247, 44)
        Me.GroupBox26.TabIndex = 5
        Me.GroupBox26.TabStop = False
        '
        'lblStudentName
        '
        Me.lblStudentName.AutoSize = True
        Me.lblStudentName.Enabled = False
        Me.lblStudentName.Location = New System.Drawing.Point(11, 18)
        Me.lblStudentName.Name = "lblStudentName"
        Me.lblStudentName.Size = New System.Drawing.Size(33, 17)
        Me.lblStudentName.TabIndex = 0
        Me.lblStudentName.Text = "-----"
        '
        'grbAMSInfo
        '
        Me.grbAMSInfo.Controls.Add(Me.btnBackToPInformation)
        Me.grbAMSInfo.Controls.Add(Me.btnNextToStudInfo)
        Me.grbAMSInfo.Controls.Add(Me.cmbYr_lvl)
        Me.grbAMSInfo.Controls.Add(Me.cmbxCourse)
        Me.grbAMSInfo.Controls.Add(Me.GroupBox24)
        Me.grbAMSInfo.Controls.Add(Me.Label26)
        Me.grbAMSInfo.Controls.Add(Me.Label25)
        Me.grbAMSInfo.Controls.Add(Me.txtbxStud_ID)
        Me.grbAMSInfo.Controls.Add(Me.Label24)
        Me.grbAMSInfo.Location = New System.Drawing.Point(540, 34)
        Me.grbAMSInfo.Name = "grbAMSInfo"
        Me.grbAMSInfo.Size = New System.Drawing.Size(481, 247)
        Me.grbAMSInfo.TabIndex = 2
        Me.grbAMSInfo.TabStop = False
        Me.grbAMSInfo.Text = "A.M.S Information"
        '
        'btnBackToPInformation
        '
        Me.btnBackToPInformation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBackToPInformation.Image = Global.JRCC_AMS.My.Resources.Resources.back
        Me.btnBackToPInformation.Location = New System.Drawing.Point(297, 205)
        Me.btnBackToPInformation.Name = "btnBackToPInformation"
        Me.btnBackToPInformation.Size = New System.Drawing.Size(82, 32)
        Me.btnBackToPInformation.TabIndex = 33
        Me.btnBackToPInformation.UseVisualStyleBackColor = True
        '
        'btnNextToStudInfo
        '
        Me.btnNextToStudInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNextToStudInfo.Image = Global.JRCC_AMS.My.Resources.Resources.next__1_
        Me.btnNextToStudInfo.Location = New System.Drawing.Point(388, 204)
        Me.btnNextToStudInfo.Name = "btnNextToStudInfo"
        Me.btnNextToStudInfo.Size = New System.Drawing.Size(87, 31)
        Me.btnNextToStudInfo.TabIndex = 15
        Me.btnNextToStudInfo.UseVisualStyleBackColor = True
        '
        'cmbYr_lvl
        '
        Me.cmbYr_lvl.FormattingEnabled = True
        Me.cmbYr_lvl.Location = New System.Drawing.Point(14, 141)
        Me.cmbYr_lvl.Name = "cmbYr_lvl"
        Me.cmbYr_lvl.Size = New System.Drawing.Size(182, 24)
        Me.cmbYr_lvl.TabIndex = 20
        '
        'cmbxCourse
        '
        Me.cmbxCourse.FormattingEnabled = True
        Me.cmbxCourse.Location = New System.Drawing.Point(16, 94)
        Me.cmbxCourse.Name = "cmbxCourse"
        Me.cmbxCourse.Size = New System.Drawing.Size(182, 24)
        Me.cmbxCourse.TabIndex = 14
        '
        'GroupBox24
        '
        Me.GroupBox24.Controls.Add(Me.PictureBox5)
        Me.GroupBox24.Location = New System.Drawing.Point(254, 22)
        Me.GroupBox24.Name = "GroupBox24"
        Me.GroupBox24.Size = New System.Drawing.Size(196, 176)
        Me.GroupBox24.TabIndex = 19
        Me.GroupBox24.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New System.Drawing.Point(17, 26)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(161, 134)
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(16, 120)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(64, 17)
        Me.Label26.TabIndex = 17
        Me.Label26.Text = "Yr. Level"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(16, 74)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(53, 17)
        Me.Label25.TabIndex = 15
        Me.Label25.Text = "Course"
        '
        'txtbxStud_ID
        '
        Me.txtbxStud_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxStud_ID.Location = New System.Drawing.Point(16, 48)
        Me.txtbxStud_ID.Name = "txtbxStud_ID"
        Me.txtbxStud_ID.Size = New System.Drawing.Size(184, 23)
        Me.txtbxStud_ID.TabIndex = 14
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(16, 30)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(74, 17)
        Me.Label24.TabIndex = 13
        Me.Label24.Text = "Student ID"
        '
        'btnSaveAddStudentInfo
        '
        Me.btnSaveAddStudentInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveAddStudentInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveAddStudentInfo.Location = New System.Drawing.Point(995, 486)
        Me.btnSaveAddStudentInfo.Name = "btnSaveAddStudentInfo"
        Me.btnSaveAddStudentInfo.Size = New System.Drawing.Size(122, 40)
        Me.btnSaveAddStudentInfo.TabIndex = 4
        Me.btnSaveAddStudentInfo.Text = "Save"
        Me.btnSaveAddStudentInfo.UseVisualStyleBackColor = True
        '
        'btnCancelAddStudent
        '
        Me.btnCancelAddStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelAddStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelAddStudent.Location = New System.Drawing.Point(867, 486)
        Me.btnCancelAddStudent.Name = "btnCancelAddStudent"
        Me.btnCancelAddStudent.Size = New System.Drawing.Size(122, 40)
        Me.btnCancelAddStudent.TabIndex = 0
        Me.btnCancelAddStudent.Text = "Cancel"
        Me.btnCancelAddStudent.UseVisualStyleBackColor = True
        '
        'grbxDefaultViewStudent
        '
        Me.grbxDefaultViewStudent.Controls.Add(Me.GroupBox32)
        Me.grbxDefaultViewStudent.Controls.Add(Me.DataGridView1)
        Me.grbxDefaultViewStudent.Controls.Add(Me.GroupBox20)
        Me.grbxDefaultViewStudent.Location = New System.Drawing.Point(13, 158)
        Me.grbxDefaultViewStudent.Name = "grbxDefaultViewStudent"
        Me.grbxDefaultViewStudent.Size = New System.Drawing.Size(1124, 541)
        Me.grbxDefaultViewStudent.TabIndex = 14
        Me.grbxDefaultViewStudent.TabStop = False
        '
        'GroupBox32
        '
        Me.GroupBox32.Controls.Add(Me.Label17)
        Me.GroupBox32.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox32.Location = New System.Drawing.Point(1053, 10)
        Me.GroupBox32.Name = "GroupBox32"
        Me.GroupBox32.Size = New System.Drawing.Size(56, 46)
        Me.GroupBox32.TabIndex = 14
        Me.GroupBox32.TabStop = False
        '
        'Label17
        '
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label17.Location = New System.Drawing.Point(3, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 24)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = "-----"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(11, 78)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1098, 448)
        Me.DataGridView1.TabIndex = 12
        '
        'GroupBox20
        '
        Me.GroupBox20.Controls.Add(Me.Label16)
        Me.GroupBox20.Controls.Add(Me.TextBox3)
        Me.GroupBox20.Location = New System.Drawing.Point(11, 19)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Size = New System.Drawing.Size(280, 53)
        Me.GroupBox20.TabIndex = 11
        Me.GroupBox20.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(9, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 17)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Search:"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(64, 19)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(198, 23)
        Me.TextBox3.TabIndex = 10
        '
        'lblStudentPanel
        '
        Me.lblStudentPanel.AutoSize = True
        Me.lblStudentPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentPanel.Location = New System.Drawing.Point(8, 17)
        Me.lblStudentPanel.Name = "lblStudentPanel"
        Me.lblStudentPanel.Size = New System.Drawing.Size(107, 29)
        Me.lblStudentPanel.TabIndex = 12
        Me.lblStudentPanel.Text = "Students"
        '
        'panelMenuSubjects
        '
        Me.panelMenuSubjects.Controls.Add(Me.GroupBox13)
        Me.panelMenuSubjects.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMenuSubjects.Location = New System.Drawing.Point(229, 56)
        Me.panelMenuSubjects.Name = "panelMenuSubjects"
        Me.panelMenuSubjects.Size = New System.Drawing.Size(1169, 742)
        Me.panelMenuSubjects.TabIndex = 8
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.GroupBox30)
        Me.GroupBox13.Controls.Add(Me.GroupBox28)
        Me.GroupBox13.Controls.Add(Me.lblPanelSubjects)
        Me.GroupBox13.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(1154, 715)
        Me.GroupBox13.TabIndex = 6
        Me.GroupBox13.TabStop = False
        '
        'GroupBox30
        '
        Me.GroupBox30.Controls.Add(Me.btnCourseSave)
        Me.GroupBox30.Controls.Add(Me.btnCancelCourse)
        Me.GroupBox30.Controls.Add(Me.btnDeleteCourse)
        Me.GroupBox30.Controls.Add(Me.btnEditCourse)
        Me.GroupBox30.Controls.Add(Me.Label30)
        Me.GroupBox30.Controls.Add(Me.txtbxCourseDescription)
        Me.GroupBox30.Controls.Add(Me.Label29)
        Me.GroupBox30.Controls.Add(Me.txtbxCourseName)
        Me.GroupBox30.Controls.Add(Me.Label28)
        Me.GroupBox30.Controls.Add(Me.btnInsertCourse)
        Me.GroupBox30.Controls.Add(Me.txtbxCourseCode)
        Me.GroupBox30.Controls.Add(Me.GroupBox33)
        Me.GroupBox30.Location = New System.Drawing.Point(589, 313)
        Me.GroupBox30.Name = "GroupBox30"
        Me.GroupBox30.Size = New System.Drawing.Size(557, 380)
        Me.GroupBox30.TabIndex = 12
        Me.GroupBox30.TabStop = False
        Me.GroupBox30.Text = "Course"
        '
        'btnCourseSave
        '
        Me.btnCourseSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCourseSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCourseSave.Location = New System.Drawing.Point(451, 151)
        Me.btnCourseSave.Name = "btnCourseSave"
        Me.btnCourseSave.Size = New System.Drawing.Size(90, 24)
        Me.btnCourseSave.TabIndex = 33
        Me.btnCourseSave.Text = "Save"
        Me.btnCourseSave.UseVisualStyleBackColor = True
        '
        'btnCancelCourse
        '
        Me.btnCancelCourse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelCourse.Location = New System.Drawing.Point(451, 121)
        Me.btnCancelCourse.Name = "btnCancelCourse"
        Me.btnCancelCourse.Size = New System.Drawing.Size(90, 24)
        Me.btnCancelCourse.TabIndex = 34
        Me.btnCancelCourse.Text = "Cancel"
        Me.btnCancelCourse.UseVisualStyleBackColor = True
        '
        'btnDeleteCourse
        '
        Me.btnDeleteCourse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteCourse.Location = New System.Drawing.Point(421, 94)
        Me.btnDeleteCourse.Name = "btnDeleteCourse"
        Me.btnDeleteCourse.Size = New System.Drawing.Size(120, 32)
        Me.btnDeleteCourse.TabIndex = 15
        Me.btnDeleteCourse.Text = "Delete"
        Me.btnDeleteCourse.UseVisualStyleBackColor = True
        '
        'btnEditCourse
        '
        Me.btnEditCourse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditCourse.Location = New System.Drawing.Point(421, 59)
        Me.btnEditCourse.Name = "btnEditCourse"
        Me.btnEditCourse.Size = New System.Drawing.Size(120, 32)
        Me.btnEditCourse.TabIndex = 14
        Me.btnEditCourse.Text = "Edit"
        Me.btnEditCourse.UseVisualStyleBackColor = True
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(21, 104)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(72, 15)
        Me.Label30.TabIndex = 12
        Me.Label30.Text = "Description:"
        '
        'txtbxCourseDescription
        '
        Me.txtbxCourseDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxCourseDescription.Location = New System.Drawing.Point(110, 99)
        Me.txtbxCourseDescription.Multiline = True
        Me.txtbxCourseDescription.Name = "txtbxCourseDescription"
        Me.txtbxCourseDescription.Size = New System.Drawing.Size(265, 76)
        Me.txtbxCourseDescription.TabIndex = 2
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(21, 65)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(49, 15)
        Me.Label29.TabIndex = 10
        Me.Label29.Text = "Course:"
        '
        'txtbxCourseName
        '
        Me.txtbxCourseName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbxCourseName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxCourseName.Location = New System.Drawing.Point(110, 60)
        Me.txtbxCourseName.Multiline = True
        Me.txtbxCourseName.Name = "txtbxCourseName"
        Me.txtbxCourseName.Size = New System.Drawing.Size(265, 30)
        Me.txtbxCourseName.TabIndex = 1
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(21, 29)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(39, 15)
        Me.Label28.TabIndex = 7
        Me.Label28.Text = "Code:"
        '
        'btnInsertCourse
        '
        Me.btnInsertCourse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInsertCourse.Location = New System.Drawing.Point(421, 23)
        Me.btnInsertCourse.Name = "btnInsertCourse"
        Me.btnInsertCourse.Size = New System.Drawing.Size(120, 32)
        Me.btnInsertCourse.TabIndex = 8
        Me.btnInsertCourse.Text = "Insert"
        Me.btnInsertCourse.UseVisualStyleBackColor = True
        '
        'txtbxCourseCode
        '
        Me.txtbxCourseCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbxCourseCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxCourseCode.Location = New System.Drawing.Point(110, 24)
        Me.txtbxCourseCode.Multiline = True
        Me.txtbxCourseCode.Name = "txtbxCourseCode"
        Me.txtbxCourseCode.Size = New System.Drawing.Size(265, 30)
        Me.txtbxCourseCode.TabIndex = 0
        '
        'GroupBox33
        '
        Me.GroupBox33.Controls.Add(Me.dgvCourse)
        Me.GroupBox33.Controls.Add(Me.btnRefreshCourse)
        Me.GroupBox33.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox33.Location = New System.Drawing.Point(3, 177)
        Me.GroupBox33.Name = "GroupBox33"
        Me.GroupBox33.Size = New System.Drawing.Size(551, 200)
        Me.GroupBox33.TabIndex = 37
        Me.GroupBox33.TabStop = False
        '
        'dgvCourse
        '
        Me.dgvCourse.AllowUserToAddRows = False
        Me.dgvCourse.AllowUserToDeleteRows = False
        Me.dgvCourse.AllowUserToResizeColumns = False
        Me.dgvCourse.AllowUserToResizeRows = False
        Me.dgvCourse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCourse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.dgvCourse.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgvCourse.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCourse.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvCourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCourse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvCourse.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvCourse.Location = New System.Drawing.Point(3, 43)
        Me.dgvCourse.Name = "dgvCourse"
        Me.dgvCourse.ReadOnly = True
        Me.dgvCourse.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgvCourse.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCourse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvCourse.Size = New System.Drawing.Size(545, 154)
        Me.dgvCourse.StandardTab = True
        Me.dgvCourse.TabIndex = 9
        '
        'btnRefreshCourse
        '
        Me.btnRefreshCourse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefreshCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshCourse.Location = New System.Drawing.Point(458, 14)
        Me.btnRefreshCourse.Name = "btnRefreshCourse"
        Me.btnRefreshCourse.Size = New System.Drawing.Size(90, 24)
        Me.btnRefreshCourse.TabIndex = 35
        Me.btnRefreshCourse.Text = "Refresh"
        Me.btnRefreshCourse.UseVisualStyleBackColor = True
        '
        'GroupBox28
        '
        Me.GroupBox28.Controls.Add(Me.btnSubjectSave)
        Me.GroupBox28.Controls.Add(Me.btnCancelSubject)
        Me.GroupBox28.Controls.Add(Me.GroupBox34)
        Me.GroupBox28.Controls.Add(Me.Label31)
        Me.GroupBox28.Controls.Add(Me.btnDeleteSubject)
        Me.GroupBox28.Controls.Add(Me.txtbxSubjectDescription)
        Me.GroupBox28.Controls.Add(Me.btnEditSubject)
        Me.GroupBox28.Controls.Add(Me.Label32)
        Me.GroupBox28.Controls.Add(Me.txtbxSubjectName)
        Me.GroupBox28.Controls.Add(Me.Label33)
        Me.GroupBox28.Controls.Add(Me.btnInsertSubject)
        Me.GroupBox28.Controls.Add(Me.txtbxSubjectCode)
        Me.GroupBox28.Location = New System.Drawing.Point(18, 140)
        Me.GroupBox28.Name = "GroupBox28"
        Me.GroupBox28.Size = New System.Drawing.Size(565, 553)
        Me.GroupBox28.TabIndex = 4
        Me.GroupBox28.TabStop = False
        Me.GroupBox28.Text = "Subject"
        '
        'btnSubjectSave
        '
        Me.btnSubjectSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubjectSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubjectSave.Location = New System.Drawing.Point(442, 160)
        Me.btnSubjectSave.Name = "btnSubjectSave"
        Me.btnSubjectSave.Size = New System.Drawing.Size(90, 24)
        Me.btnSubjectSave.TabIndex = 33
        Me.btnSubjectSave.Text = "Save"
        Me.btnSubjectSave.UseVisualStyleBackColor = True
        '
        'btnCancelSubject
        '
        Me.btnCancelSubject.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelSubject.Location = New System.Drawing.Point(441, 130)
        Me.btnCancelSubject.Name = "btnCancelSubject"
        Me.btnCancelSubject.Size = New System.Drawing.Size(90, 24)
        Me.btnCancelSubject.TabIndex = 34
        Me.btnCancelSubject.Text = "Cancel"
        Me.btnCancelSubject.UseVisualStyleBackColor = True
        '
        'GroupBox34
        '
        Me.GroupBox34.Controls.Add(Me.dgvSubjects)
        Me.GroupBox34.Controls.Add(Me.btnRefreshSubject)
        Me.GroupBox34.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox34.Location = New System.Drawing.Point(3, 181)
        Me.GroupBox34.Name = "GroupBox34"
        Me.GroupBox34.Size = New System.Drawing.Size(559, 369)
        Me.GroupBox34.TabIndex = 39
        Me.GroupBox34.TabStop = False
        '
        'dgvSubjects
        '
        Me.dgvSubjects.AllowUserToAddRows = False
        Me.dgvSubjects.AllowUserToDeleteRows = False
        Me.dgvSubjects.AllowUserToResizeColumns = False
        Me.dgvSubjects.AllowUserToResizeRows = False
        Me.dgvSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSubjects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.dgvSubjects.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgvSubjects.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSubjects.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSubjects.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgvSubjects.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvSubjects.Location = New System.Drawing.Point(3, 40)
        Me.dgvSubjects.Name = "dgvSubjects"
        Me.dgvSubjects.ReadOnly = True
        Me.dgvSubjects.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgvSubjects.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvSubjects.Size = New System.Drawing.Size(553, 326)
        Me.dgvSubjects.StandardTab = True
        Me.dgvSubjects.TabIndex = 14
        '
        'btnRefreshSubject
        '
        Me.btnRefreshSubject.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefreshSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshSubject.Location = New System.Drawing.Point(457, 12)
        Me.btnRefreshSubject.Name = "btnRefreshSubject"
        Me.btnRefreshSubject.Size = New System.Drawing.Size(90, 24)
        Me.btnRefreshSubject.TabIndex = 38
        Me.btnRefreshSubject.Text = "Refresh"
        Me.btnRefreshSubject.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(14, 103)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(72, 15)
        Me.Label31.TabIndex = 20
        Me.Label31.Text = "Description:"
        '
        'btnDeleteSubject
        '
        Me.btnDeleteSubject.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteSubject.Location = New System.Drawing.Point(412, 96)
        Me.btnDeleteSubject.Name = "btnDeleteSubject"
        Me.btnDeleteSubject.Size = New System.Drawing.Size(120, 32)
        Me.btnDeleteSubject.TabIndex = 32
        Me.btnDeleteSubject.Text = "Delete"
        Me.btnDeleteSubject.UseVisualStyleBackColor = True
        '
        'txtbxSubjectDescription
        '
        Me.txtbxSubjectDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxSubjectDescription.Location = New System.Drawing.Point(103, 98)
        Me.txtbxSubjectDescription.Multiline = True
        Me.txtbxSubjectDescription.Name = "txtbxSubjectDescription"
        Me.txtbxSubjectDescription.Size = New System.Drawing.Size(265, 86)
        Me.txtbxSubjectDescription.TabIndex = 2
        '
        'btnEditSubject
        '
        Me.btnEditSubject.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditSubject.Location = New System.Drawing.Point(412, 61)
        Me.btnEditSubject.Name = "btnEditSubject"
        Me.btnEditSubject.Size = New System.Drawing.Size(120, 32)
        Me.btnEditSubject.TabIndex = 31
        Me.btnEditSubject.Text = "Edit"
        Me.btnEditSubject.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(14, 64)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(51, 15)
        Me.Label32.TabIndex = 18
        Me.Label32.Text = "Subject:"
        '
        'txtbxSubjectName
        '
        Me.txtbxSubjectName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxSubjectName.Location = New System.Drawing.Point(103, 59)
        Me.txtbxSubjectName.Multiline = True
        Me.txtbxSubjectName.Name = "txtbxSubjectName"
        Me.txtbxSubjectName.Size = New System.Drawing.Size(265, 30)
        Me.txtbxSubjectName.TabIndex = 1
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(14, 28)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(39, 15)
        Me.Label33.TabIndex = 16
        Me.Label33.Text = "Code:"
        '
        'btnInsertSubject
        '
        Me.btnInsertSubject.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInsertSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertSubject.Location = New System.Drawing.Point(412, 25)
        Me.btnInsertSubject.Name = "btnInsertSubject"
        Me.btnInsertSubject.Size = New System.Drawing.Size(120, 32)
        Me.btnInsertSubject.TabIndex = 30
        Me.btnInsertSubject.Text = "Insert"
        Me.btnInsertSubject.UseVisualStyleBackColor = True
        '
        'txtbxSubjectCode
        '
        Me.txtbxSubjectCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtbxSubjectCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxSubjectCode.Location = New System.Drawing.Point(103, 23)
        Me.txtbxSubjectCode.Multiline = True
        Me.txtbxSubjectCode.Name = "txtbxSubjectCode"
        Me.txtbxSubjectCode.Size = New System.Drawing.Size(265, 30)
        Me.txtbxSubjectCode.TabIndex = 0
        '
        'lblPanelSubjects
        '
        Me.lblPanelSubjects.AutoSize = True
        Me.lblPanelSubjects.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPanelSubjects.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPanelSubjects.Location = New System.Drawing.Point(3, 16)
        Me.lblPanelSubjects.Name = "lblPanelSubjects"
        Me.lblPanelSubjects.Size = New System.Drawing.Size(224, 29)
        Me.lblPanelSubjects.TabIndex = 3
        Me.lblPanelSubjects.Text = "Subject and Course"
        '
        'panelAccountProfile
        '
        Me.panelAccountProfile.Controls.Add(Me.grpbxProfile)
        Me.panelAccountProfile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelAccountProfile.Location = New System.Drawing.Point(229, 56)
        Me.panelAccountProfile.Name = "panelAccountProfile"
        Me.panelAccountProfile.Size = New System.Drawing.Size(1169, 742)
        Me.panelAccountProfile.TabIndex = 9
        '
        'grpbxProfile
        '
        Me.grpbxProfile.Controls.Add(Me.GroupBox29)
        Me.grpbxProfile.Controls.Add(Me.Label15)
        Me.grpbxProfile.Controls.Add(Me.GroupBox18)
        Me.grpbxProfile.Controls.Add(Me.GroupBox17)
        Me.grpbxProfile.Controls.Add(Me.Button1)
        Me.grpbxProfile.Controls.Add(Me.GroupBox16)
        Me.grpbxProfile.Controls.Add(Me.Label1)
        Me.grpbxProfile.Location = New System.Drawing.Point(3, 6)
        Me.grpbxProfile.Name = "grpbxProfile"
        Me.grpbxProfile.Size = New System.Drawing.Size(1154, 715)
        Me.grpbxProfile.TabIndex = 8
        Me.grpbxProfile.TabStop = False
        '
        'GroupBox29
        '
        Me.GroupBox29.Controls.Add(Me.Label27)
        Me.GroupBox29.Controls.Add(Me.Button2)
        Me.GroupBox29.Controls.Add(Me.TextBox4)
        Me.GroupBox29.Location = New System.Drawing.Point(21, 69)
        Me.GroupBox29.Name = "GroupBox29"
        Me.GroupBox29.Size = New System.Drawing.Size(430, 74)
        Me.GroupBox29.TabIndex = 11
        Me.GroupBox29.TabStop = False
        Me.GroupBox29.Text = "Tools"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(12, 32)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(59, 17)
        Me.Label27.TabIndex = 7
        Me.Label27.Text = "Subject:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(330, 27)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 27)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Insert"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(79, 27)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox4.Size = New System.Drawing.Size(238, 30)
        Me.TextBox4.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(21, 422)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 17)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Font Color"
        '
        'GroupBox18
        '
        Me.GroupBox18.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox18.Location = New System.Drawing.Point(21, 442)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(331, 138)
        Me.GroupBox18.TabIndex = 9
        Me.GroupBox18.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.54137!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.87809!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.58053!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label14, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.trackbarR, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.trackbarG, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.trackbarB, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtbxR, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtbxG, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtbxB, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(325, 119)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(277, 78)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 41)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "B"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(277, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 39)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "G"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'trackbarR
        '
        Me.trackbarR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.trackbarR.Location = New System.Drawing.Point(3, 3)
        Me.trackbarR.Maximum = 255
        Me.trackbarR.Name = "trackbarR"
        Me.trackbarR.Size = New System.Drawing.Size(158, 33)
        Me.trackbarR.TabIndex = 0
        Me.trackbarR.TickFrequency = 10
        '
        'trackbarG
        '
        Me.trackbarG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.trackbarG.Location = New System.Drawing.Point(3, 42)
        Me.trackbarG.Maximum = 255
        Me.trackbarG.Name = "trackbarG"
        Me.trackbarG.Size = New System.Drawing.Size(158, 33)
        Me.trackbarG.TabIndex = 1
        Me.trackbarG.TickFrequency = 10
        '
        'trackbarB
        '
        Me.trackbarB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.trackbarB.Location = New System.Drawing.Point(3, 81)
        Me.trackbarB.Maximum = 255
        Me.trackbarB.Name = "trackbarB"
        Me.trackbarB.Size = New System.Drawing.Size(158, 35)
        Me.trackbarB.TabIndex = 2
        Me.trackbarB.TickFrequency = 10
        '
        'txtbxR
        '
        Me.txtbxR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbxR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxR.Location = New System.Drawing.Point(167, 3)
        Me.txtbxR.Multiline = True
        Me.txtbxR.Name = "txtbxR"
        Me.txtbxR.Size = New System.Drawing.Size(104, 33)
        Me.txtbxR.TabIndex = 3
        Me.txtbxR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbxG
        '
        Me.txtbxG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbxG.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxG.Location = New System.Drawing.Point(167, 42)
        Me.txtbxG.Multiline = True
        Me.txtbxG.Name = "txtbxG"
        Me.txtbxG.Size = New System.Drawing.Size(104, 33)
        Me.txtbxG.TabIndex = 4
        Me.txtbxG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtbxB
        '
        Me.txtbxB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtbxB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxB.Location = New System.Drawing.Point(167, 81)
        Me.txtbxB.Multiline = True
        Me.txtbxB.Name = "txtbxB"
        Me.txtbxB.Size = New System.Drawing.Size(104, 35)
        Me.txtbxB.TabIndex = 5
        Me.txtbxB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(277, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 39)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "R"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.TextBox2)
        Me.GroupBox17.Controls.Add(Me.TextBox1)
        Me.GroupBox17.Controls.Add(Me.txtbxDbPass)
        Me.GroupBox17.Controls.Add(Me.Label5)
        Me.GroupBox17.Controls.Add(Me.Label4)
        Me.GroupBox17.Controls.Add(Me.Label2)
        Me.GroupBox17.Location = New System.Drawing.Point(24, 156)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(283, 238)
        Me.GroupBox17.TabIndex = 8
        Me.GroupBox17.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(21, 163)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox2.Size = New System.Drawing.Size(238, 30)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(21, 103)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.Size = New System.Drawing.Size(238, 30)
        Me.TextBox1.TabIndex = 5
        '
        'txtbxDbPass
        '
        Me.txtbxDbPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxDbPass.Location = New System.Drawing.Point(21, 48)
        Me.txtbxDbPass.Multiline = True
        Me.txtbxDbPass.Name = "txtbxDbPass"
        Me.txtbxDbPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbxDbPass.Size = New System.Drawing.Size(238, 30)
        Me.txtbxDbPass.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Re-type Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Username"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(954, 168)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(189, 33)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Import"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.PictureBox4)
        Me.GroupBox16.Location = New System.Drawing.Point(954, 16)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(189, 146)
        Me.GroupBox16.TabIndex = 4
        Me.GroupBox16.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(6, 15)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(177, 121)
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Profile"
        '
        'timerRGB
        '
        Me.timerRGB.Enabled = True
        Me.timerRGB.Interval = 1
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1398, 798)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelMenuStudents)
        Me.Controls.Add(Me.panelMenuSubjects)
        Me.Controls.Add(Me.panelDashboard)
        Me.Controls.Add(Me.panelAccountProfile)
        Me.Controls.Add(Me.panelMenuAttendance)
        Me.Controls.Add(Me.panelMenuTeachers)
        Me.Controls.Add(Me.panelMenuReports)
        Me.Controls.Add(Me.panelMenuSettings)
        Me.Controls.Add(Me.panelMenuActivity)
        Me.Controls.Add(Me.panelSideMenu)
        Me.Controls.Add(Me.panelHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ImeMode = System.Windows.Forms.ImeMode.HangulFull
        Me.MainMenuStrip = Me.menustrip
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dashboard"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.panelHeader.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.panelSideMenu.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.menustrip.ResumeLayout(False)
        Me.menustrip.PerformLayout()
        Me.panelDashboard.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox31.ResumeLayout(False)
        Me.GroupBox31.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.dgvAMS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelMenuAttendance.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.panelMenuReports.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.panelMenuTeachers.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.panelMenuSettings.ResumeLayout(False)
        Me.panelMenuSettings.PerformLayout()
        Me.panelMenuStudents.ResumeLayout(False)
        Me.grbStudenInfoContainer.ResumeLayout(False)
        Me.grbStudenInfoContainer.PerformLayout()
        Me.grbStudenTools.ResumeLayout(False)
        Me.grbxAddStudent.ResumeLayout(False)
        Me.grbPersonalInfo.ResumeLayout(False)
        Me.grbPersonalInfo.PerformLayout()
        Me.grbStudentInformation.ResumeLayout(False)
        Me.GroupBox23.ResumeLayout(False)
        Me.GroupBox23.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox27.ResumeLayout(False)
        Me.GroupBox27.PerformLayout()
        Me.GroupBox26.ResumeLayout(False)
        Me.GroupBox26.PerformLayout()
        Me.grbAMSInfo.ResumeLayout(False)
        Me.grbAMSInfo.PerformLayout()
        Me.GroupBox24.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbxDefaultViewStudent.ResumeLayout(False)
        Me.GroupBox32.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox20.ResumeLayout(False)
        Me.GroupBox20.PerformLayout()
        Me.panelMenuSubjects.ResumeLayout(False)
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox30.ResumeLayout(False)
        Me.GroupBox30.PerformLayout()
        Me.GroupBox33.ResumeLayout(False)
        CType(Me.dgvCourse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox28.ResumeLayout(False)
        Me.GroupBox28.PerformLayout()
        Me.GroupBox34.ResumeLayout(False)
        CType(Me.dgvSubjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelAccountProfile.ResumeLayout(False)
        Me.grpbxProfile.ResumeLayout(False)
        Me.grpbxProfile.PerformLayout()
        Me.GroupBox29.ResumeLayout(False)
        Me.GroupBox29.PerformLayout()
        Me.GroupBox18.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.trackbarR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackbarG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackbarB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox17.PerformLayout()
        Me.GroupBox16.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelHeader As Panel
    Friend WithEvents panelSideMenu As Panel
    Friend WithEvents lblTitleSystem As Label
    Friend WithEvents btnMenuAMS As Button
    Friend WithEvents btnMenuReports As Button
    Friend WithEvents btnMenuTeachers As Button
    Friend WithEvents btnMenuStudents As Button
    Friend WithEvents btnMenuAttendance As Button
    Friend WithEvents btnMenuDashboard As Button
    Friend WithEvents panelDashboard As Panel
    Friend WithEvents panelMenuAttendance As Panel
    Friend WithEvents panelMenuReports As Panel
    Friend WithEvents btnMenuSettings As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents panelMenuActivity As Panel
    Friend WithEvents panelMenuTeachers As Panel
    Friend WithEvents panelMenuSettings As Panel
    Friend WithEvents btnMenuActivity As Button
    Friend WithEvents btnMenuSubjects As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents lblPanelDashboard As Label
    Friend WithEvents lblSettings As Label
    Friend WithEvents panelMenuStudents As Panel
    Friend WithEvents panelMenuSubjects As Panel
    Friend WithEvents menustrip As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DashboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AttendanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TeachersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AMSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTotalSubjects As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTotalStudents As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lblTotalTeachers As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents lblServerStatusDisplay As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents lblAMSActiveDisplay As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblSubjectActiveDisplay As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents dgvAMS As DataGridView
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents lblPanelAttendance As Label
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents lblPanelReports As Label
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents lblPanelTeachers As Label
    Friend WithEvents grbStudenInfoContainer As GroupBox
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents lblPanelSubjects As Label
    Friend WithEvents panelAccountProfile As Panel
    Friend WithEvents grpbxProfile As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox16 As GroupBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents GroupBox17 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txtbxDbPass As TextBox
    Friend WithEvents GroupBox18 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents trackbarR As TrackBar
    Friend WithEvents trackbarG As TrackBar
    Friend WithEvents trackbarB As TrackBar
    Friend WithEvents txtbxR As TextBox
    Friend WithEvents txtbxG As TextBox
    Friend WithEvents txtbxB As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents timerRGB As Timer
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents grbStudenTools As GroupBox
    Friend WithEvents btnDeleteStudent As Button
    Friend WithEvents btnEditStudent As Button
    Friend WithEvents btnAddStudent As Button
    Friend WithEvents btnViewStudent As Button
    Friend WithEvents GroupBox20 As GroupBox
    Friend WithEvents lblStudentPanel As Label
    Friend WithEvents grbxAddStudent As GroupBox
    Friend WithEvents grbxDefaultViewStudent As GroupBox
    Friend WithEvents btnCancelAddStudent As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents grbAMSInfo As GroupBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents txtbxStud_ID As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents grbPersonalInfo As GroupBox
    Friend WithEvents txtbxEmail As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtbxPhone As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtbxLname As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtbxMname As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtbxFname As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents btnSaveAddStudentInfo As Button
    Friend WithEvents GroupBox24 As GroupBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents grbStudentInformation As GroupBox
    Friend WithEvents GroupBox27 As GroupBox
    Friend WithEvents lblStudentId As Label
    Friend WithEvents GroupBox26 As GroupBox
    Friend WithEvents lblStudentName As Label
    Friend WithEvents btnImportImage As Button
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents GroupBox23 As GroupBox
    Friend WithEvents lblStudentYr As Label
    Friend WithEvents GroupBox28 As GroupBox
    Friend WithEvents btnInsertSubject As Button
    Friend WithEvents hoverDashboard As Panel
    Friend WithEvents hoverSettings As Panel
    Friend WithEvents hoverActivity As Panel
    Friend WithEvents hoverReports As Panel
    Friend WithEvents hoverAMS As Panel
    Friend WithEvents hoverSubjects As Panel
    Friend WithEvents hoverTeachers As Panel
    Friend WithEvents hoverStudents As Panel
    Friend WithEvents hoverAttendance As Panel
    Friend WithEvents hoverViewStudents As Panel
    Friend WithEvents hoverDeleteStudents As Panel
    Friend WithEvents hoverEditStudents As Panel
    Friend WithEvents hoverAddStudents As Panel
    Friend WithEvents cmbxGender As ComboBox
    Friend WithEvents cmbYr_lvl As ComboBox
    Friend WithEvents cmbxCourse As ComboBox
    Friend WithEvents GroupBox30 As GroupBox
    Friend WithEvents Label28 As Label
    Friend WithEvents btnInsertCourse As Button
    Friend WithEvents txtbxCourseCode As TextBox
    Friend WithEvents GroupBox29 As GroupBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents txtbxCourseDescription As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txtbxCourseName As TextBox
    Friend WithEvents dgvCourse As DataGridView
    Friend WithEvents dgvSubjects As DataGridView
    Friend WithEvents btnDeleteCourse As Button
    Friend WithEvents btnEditCourse As Button
    Friend WithEvents Label31 As Label
    Friend WithEvents btnDeleteSubject As Button
    Friend WithEvents txtbxSubjectDescription As TextBox
    Friend WithEvents btnEditSubject As Button
    Friend WithEvents Label32 As Label
    Friend WithEvents txtbxSubjectName As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents txtbxSubjectCode As TextBox
    Friend WithEvents btnCancelSubject As Button
    Friend WithEvents btnSubjectSave As Button
    Friend WithEvents btnCancelCourse As Button
    Friend WithEvents btnCourseSave As Button
    Friend WithEvents GroupBox31 As GroupBox
    Friend WithEvents lblMDY As Label
    Friend WithEvents GroupBox32 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox33 As GroupBox
    Friend WithEvents btnRefreshCourse As Button
    Friend WithEvents GroupBox34 As GroupBox
    Friend WithEvents btnRefreshSubject As Button
    Friend WithEvents btnNextToAMSInfo As Button
    Friend WithEvents btnNextToStudInfo As Button
    Friend WithEvents btnBackToAMSInfo As Button
    Friend WithEvents btnBackToPInformation As Button
End Class
