<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formConnectionToServer
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
        Me.panelHeader = New System.Windows.Forms.Panel()
        Me.lblHeaderText = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.panelBody = New System.Windows.Forms.Panel()
        Me.lblJRCC = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtbxPassword = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtbxUsername = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.panelServerConnection = New System.Windows.Forms.Panel()
        Me.txtbxDbName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtbxDbPass = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtbxDbUsername = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtbxDbPort = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtbxDbHost = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.lblSchoolName = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.panelHeader.SuspendLayout()
        Me.panelBody.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.panelServerConnection.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelHeader
        '
        Me.panelHeader.Controls.Add(Me.lblHeaderText)
        Me.panelHeader.Controls.Add(Me.GroupBox2)
        Me.panelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelHeader.Location = New System.Drawing.Point(0, 0)
        Me.panelHeader.Name = "panelHeader"
        Me.panelHeader.Size = New System.Drawing.Size(479, 40)
        Me.panelHeader.TabIndex = 0
        '
        'lblHeaderText
        '
        Me.lblHeaderText.AutoSize = True
        Me.lblHeaderText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaderText.Location = New System.Drawing.Point(8, 13)
        Me.lblHeaderText.Name = "lblHeaderText"
        Me.lblHeaderText.Size = New System.Drawing.Size(167, 20)
        Me.lblHeaderText.TabIndex = 0
        Me.lblHeaderText.Text = "_Server Connection"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(4, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(471, 37)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'panelBody
        '
        Me.panelBody.Controls.Add(Me.lblJRCC)
        Me.panelBody.Controls.Add(Me.btnLogin)
        Me.panelBody.Controls.Add(Me.btnBack)
        Me.panelBody.Controls.Add(Me.txtbxPassword)
        Me.panelBody.Controls.Add(Me.Label9)
        Me.panelBody.Controls.Add(Me.txtbxUsername)
        Me.panelBody.Controls.Add(Me.GroupBox3)
        Me.panelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelBody.Location = New System.Drawing.Point(0, 40)
        Me.panelBody.Name = "panelBody"
        Me.panelBody.Size = New System.Drawing.Size(479, 449)
        Me.panelBody.TabIndex = 1
        '
        'lblJRCC
        '
        Me.lblJRCC.AutoSize = True
        Me.lblJRCC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblJRCC.Location = New System.Drawing.Point(174, 421)
        Me.lblJRCC.Name = "lblJRCC"
        Me.lblJRCC.Size = New System.Drawing.Size(151, 13)
        Me.lblJRCC.TabIndex = 20
        Me.lblJRCC.Text = "Jesus Reigns Christian College"
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(110, 313)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(273, 33)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(110, 352)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(273, 33)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtbxPassword
        '
        Me.txtbxPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxPassword.Location = New System.Drawing.Point(107, 265)
        Me.txtbxPassword.Multiline = True
        Me.txtbxPassword.Name = "txtbxPassword"
        Me.txtbxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbxPassword.Size = New System.Drawing.Size(276, 30)
        Me.txtbxPassword.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(104, 204)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(187, 17)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Username and Password"
        '
        'txtbxUsername
        '
        Me.txtbxUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxUsername.Location = New System.Drawing.Point(107, 231)
        Me.txtbxUsername.Multiline = True
        Me.txtbxUsername.Name = "txtbxUsername"
        Me.txtbxUsername.Size = New System.Drawing.Size(276, 30)
        Me.txtbxUsername.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Location = New System.Drawing.Point(4, -4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(471, 450)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(43, 169)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(387, 241)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Login"
        '
        'panelServerConnection
        '
        Me.panelServerConnection.Controls.Add(Me.txtbxDbName)
        Me.panelServerConnection.Controls.Add(Me.Label8)
        Me.panelServerConnection.Controls.Add(Me.txtbxDbPass)
        Me.panelServerConnection.Controls.Add(Me.Label7)
        Me.panelServerConnection.Controls.Add(Me.txtbxDbUsername)
        Me.panelServerConnection.Controls.Add(Me.Label6)
        Me.panelServerConnection.Controls.Add(Me.txtbxDbPort)
        Me.panelServerConnection.Controls.Add(Me.Label5)
        Me.panelServerConnection.Controls.Add(Me.txtbxDbHost)
        Me.panelServerConnection.Controls.Add(Me.Label4)
        Me.panelServerConnection.Controls.Add(Me.Label3)
        Me.panelServerConnection.Controls.Add(Me.Label2)
        Me.panelServerConnection.Controls.Add(Me.Button2)
        Me.panelServerConnection.Controls.Add(Me.btnConnect)
        Me.panelServerConnection.Controls.Add(Me.lblSchoolName)
        Me.panelServerConnection.Controls.Add(Me.GroupBox1)
        Me.panelServerConnection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelServerConnection.Location = New System.Drawing.Point(0, 40)
        Me.panelServerConnection.Name = "panelServerConnection"
        Me.panelServerConnection.Size = New System.Drawing.Size(479, 449)
        Me.panelServerConnection.TabIndex = 0
        '
        'txtbxDbName
        '
        Me.txtbxDbName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxDbName.Location = New System.Drawing.Point(12, 293)
        Me.txtbxDbName.Multiline = True
        Me.txtbxDbName.Name = "txtbxDbName"
        Me.txtbxDbName.Size = New System.Drawing.Size(238, 30)
        Me.txtbxDbName.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 273)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Database Name"
        '
        'txtbxDbPass
        '
        Me.txtbxDbPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxDbPass.Location = New System.Drawing.Point(12, 231)
        Me.txtbxDbPass.Multiline = True
        Me.txtbxDbPass.Name = "txtbxDbPass"
        Me.txtbxDbPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbxDbPass.Size = New System.Drawing.Size(238, 30)
        Me.txtbxDbPass.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 211)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Password"
        '
        'txtbxDbUsername
        '
        Me.txtbxDbUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxDbUsername.Location = New System.Drawing.Point(12, 174)
        Me.txtbxDbUsername.Multiline = True
        Me.txtbxDbUsername.Name = "txtbxDbUsername"
        Me.txtbxDbUsername.Size = New System.Drawing.Size(238, 30)
        Me.txtbxDbUsername.TabIndex = 2
        Me.txtbxDbUsername.Text = "root"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Username"
        '
        'txtbxDbPort
        '
        Me.txtbxDbPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxDbPort.Location = New System.Drawing.Point(267, 114)
        Me.txtbxDbPort.Multiline = True
        Me.txtbxDbPort.Name = "txtbxDbPort"
        Me.txtbxDbPort.Size = New System.Drawing.Size(82, 30)
        Me.txtbxDbPort.TabIndex = 1
        Me.txtbxDbPort.Text = "3306"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(264, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Port"
        '
        'txtbxDbHost
        '
        Me.txtbxDbHost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxDbHost.Location = New System.Drawing.Point(12, 114)
        Me.txtbxDbHost.Multiline = True
        Me.txtbxDbHost.Name = "txtbxDbHost"
        Me.txtbxDbHost.Size = New System.Drawing.Size(238, 30)
        Me.txtbxDbHost.TabIndex = 0
        Me.txtbxDbHost.Text = "localhost"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Host"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(404, 39)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Please fill in needed information to connect to the server. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If you forgot or if" &
    " the information has been changed, please seek assistance from the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "server maint" &
    "enance." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Network Access Grant" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(330, 361)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 33)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnConnect
        '
        Me.btnConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnect.Location = New System.Drawing.Point(330, 322)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(136, 33)
        Me.btnConnect.TabIndex = 5
        Me.btnConnect.Text = "Connect "
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'lblSchoolName
        '
        Me.lblSchoolName.AutoSize = True
        Me.lblSchoolName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSchoolName.Location = New System.Drawing.Point(174, 421)
        Me.lblSchoolName.Name = "lblSchoolName"
        Me.lblSchoolName.Size = New System.Drawing.Size(151, 13)
        Me.lblSchoolName.TabIndex = 7
        Me.lblSchoolName.Text = "Jesus Reigns Christian College"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(4, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(471, 446)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'formConnectionToServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 489)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelServerConnection)
        Me.Controls.Add(Me.panelBody)
        Me.Controls.Add(Me.panelHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "formConnectionToServer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.panelHeader.ResumeLayout(False)
        Me.panelHeader.PerformLayout()
        Me.panelBody.ResumeLayout(False)
        Me.panelBody.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.panelServerConnection.ResumeLayout(False)
        Me.panelServerConnection.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelHeader As Panel
    Friend WithEvents panelBody As Panel
    Friend WithEvents panelServerConnection As Panel
    Friend WithEvents lblHeaderText As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnConnect As Button
    Friend WithEvents lblSchoolName As Label
    Friend WithEvents txtbxDbName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtbxDbPass As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtbxDbUsername As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtbxDbPort As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbxDbHost As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblJRCC As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents txtbxPassword As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtbxUsername As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
End Class
