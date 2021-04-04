<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.birthday = New System.Windows.Forms.DateTimePicker()
        Me.reg_input_password = New System.Windows.Forms.TextBox()
        Me.login_lbl_pswd = New System.Windows.Forms.Label()
        Me.reg_input_user = New System.Windows.Forms.TextBox()
        Me.login_lbl_user = New System.Windows.Forms.Label()
        Me.reg_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.reg_sir = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Register_Register = New System.Windows.Forms.Button()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "วันเกิด"
        '
        'birthday
        '
        Me.birthday.Location = New System.Drawing.Point(89, 64)
        Me.birthday.Name = "birthday"
        Me.birthday.Size = New System.Drawing.Size(268, 20)
        Me.birthday.TabIndex = 8
        '
        'reg_input_password
        '
        Me.reg_input_password.Location = New System.Drawing.Point(89, 38)
        Me.reg_input_password.Name = "reg_input_password"
        Me.reg_input_password.Size = New System.Drawing.Size(268, 20)
        Me.reg_input_password.TabIndex = 13
        '
        'login_lbl_pswd
        '
        Me.login_lbl_pswd.AutoSize = True
        Me.login_lbl_pswd.Location = New System.Drawing.Point(11, 41)
        Me.login_lbl_pswd.Name = "login_lbl_pswd"
        Me.login_lbl_pswd.Size = New System.Drawing.Size(46, 13)
        Me.login_lbl_pswd.TabIndex = 12
        Me.login_lbl_pswd.Text = "รหัสผ่าน"
        '
        'reg_input_user
        '
        Me.reg_input_user.Location = New System.Drawing.Point(89, 12)
        Me.reg_input_user.Name = "reg_input_user"
        Me.reg_input_user.Size = New System.Drawing.Size(268, 20)
        Me.reg_input_user.TabIndex = 11
        '
        'login_lbl_user
        '
        Me.login_lbl_user.AutoSize = True
        Me.login_lbl_user.Location = New System.Drawing.Point(11, 15)
        Me.login_lbl_user.Name = "login_lbl_user"
        Me.login_lbl_user.Size = New System.Drawing.Size(40, 13)
        Me.login_lbl_user.TabIndex = 10
        Me.login_lbl_user.Text = "ชื่อผู้ใช้"
        '
        'reg_name
        '
        Me.reg_name.Location = New System.Drawing.Point(89, 90)
        Me.reg_name.Name = "reg_name"
        Me.reg_name.Size = New System.Drawing.Size(268, 20)
        Me.reg_name.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "ชื่อ"
        '
        'reg_sir
        '
        Me.reg_sir.Location = New System.Drawing.Point(89, 116)
        Me.reg_sir.Name = "reg_sir"
        Me.reg_sir.Size = New System.Drawing.Size(268, 20)
        Me.reg_sir.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "นามสกุล"
        '
        'Register_Register
        '
        Me.Register_Register.Location = New System.Drawing.Point(14, 165)
        Me.Register_Register.Name = "Register_Register"
        Me.Register_Register.Size = New System.Drawing.Size(345, 23)
        Me.Register_Register.TabIndex = 18
        Me.Register_Register.Text = "Register"
        Me.Register_Register.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Enabled = False
        Me.CheckBox5.Location = New System.Drawing.Point(89, 142)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(117, 17)
        Me.CheckBox5.TabIndex = 23
        Me.CheckBox5.Text = "ผู้สูงอายุ (60ปีขึ้นไป)"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 204)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.Register_Register)
        Me.Controls.Add(Me.reg_sir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.reg_name)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.reg_input_password)
        Me.Controls.Add(Me.login_lbl_pswd)
        Me.Controls.Add(Me.reg_input_user)
        Me.Controls.Add(Me.login_lbl_user)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.birthday)
        Me.MaximumSize = New System.Drawing.Size(387, 243)
        Me.MinimumSize = New System.Drawing.Size(387, 243)
        Me.Name = "register"
        Me.Text = "ลงทะเบียน"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents birthday As DateTimePicker
    Friend WithEvents reg_input_password As TextBox
    Friend WithEvents login_lbl_pswd As Label
    Friend WithEvents reg_input_user As TextBox
    Friend WithEvents login_lbl_user As Label
    Friend WithEvents reg_name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents reg_sir As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Register_Register As Button
    Friend WithEvents CheckBox5 As CheckBox
End Class
