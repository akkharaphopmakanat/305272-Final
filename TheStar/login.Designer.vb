<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Me.Login_Login = New System.Windows.Forms.Button()
        Me.login_lbl_user = New System.Windows.Forms.Label()
        Me.Login_Register = New System.Windows.Forms.Button()
        Me.login_input_user = New System.Windows.Forms.TextBox()
        Me.login_input_password = New System.Windows.Forms.TextBox()
        Me.login_lbl_pswd = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Login_Login
        '
        Me.Login_Login.Location = New System.Drawing.Point(190, 164)
        Me.Login_Login.Name = "Login_Login"
        Me.Login_Login.Size = New System.Drawing.Size(165, 23)
        Me.Login_Login.TabIndex = 0
        Me.Login_Login.Text = "เข้าสู่ระบบ"
        Me.Login_Login.UseVisualStyleBackColor = True
        '
        'login_lbl_user
        '
        Me.login_lbl_user.AutoSize = True
        Me.login_lbl_user.Location = New System.Drawing.Point(13, 13)
        Me.login_lbl_user.Name = "login_lbl_user"
        Me.login_lbl_user.Size = New System.Drawing.Size(40, 13)
        Me.login_lbl_user.TabIndex = 1
        Me.login_lbl_user.Text = "ชื่อผู้ใช้"
        '
        'Login_Register
        '
        Me.Login_Register.Location = New System.Drawing.Point(12, 164)
        Me.Login_Register.Name = "Login_Register"
        Me.Login_Register.Size = New System.Drawing.Size(165, 23)
        Me.Login_Register.TabIndex = 2
        Me.Login_Register.Text = "ลงทะเบียน"
        Me.Login_Register.UseVisualStyleBackColor = True
        '
        'login_input_user
        '
        Me.login_input_user.Location = New System.Drawing.Point(91, 10)
        Me.login_input_user.Name = "login_input_user"
        Me.login_input_user.Size = New System.Drawing.Size(268, 20)
        Me.login_input_user.TabIndex = 3
        '
        'login_input_password
        '
        Me.login_input_password.Location = New System.Drawing.Point(91, 36)
        Me.login_input_password.Name = "login_input_password"
        Me.login_input_password.Size = New System.Drawing.Size(268, 20)
        Me.login_input_password.TabIndex = 5
        '
        'login_lbl_pswd
        '
        Me.login_lbl_pswd.AutoSize = True
        Me.login_lbl_pswd.Location = New System.Drawing.Point(13, 39)
        Me.login_lbl_pswd.Name = "login_lbl_pswd"
        Me.login_lbl_pswd.Size = New System.Drawing.Size(46, 13)
        Me.login_lbl_pswd.TabIndex = 4
        Me.login_lbl_pswd.Text = "รหัสผ่าน"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 198)
        Me.Controls.Add(Me.login_input_password)
        Me.Controls.Add(Me.login_lbl_pswd)
        Me.Controls.Add(Me.login_input_user)
        Me.Controls.Add(Me.Login_Register)
        Me.Controls.Add(Me.login_lbl_user)
        Me.Controls.Add(Me.Login_Login)
        Me.Name = "login"
        Me.Text = "เข้าสู่ระบบ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Login_Login As Button
    Friend WithEvents login_lbl_user As Label
    Friend WithEvents Login_Register As Button
    Friend WithEvents login_input_user As TextBox
    Friend WithEvents login_input_password As TextBox
    Friend WithEvents login_lbl_pswd As Label
End Class
