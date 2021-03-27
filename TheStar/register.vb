Public Class register

    Private Sub Reg_Register_Click(sender As Object, e As EventArgs) Handles Register_Register.Click
        If login.userExist(reg_input_user.Text) Then
            MsgBox("ขออภัย มีชื่อผู้ใช้นี้ในระบบอยู่แล้ว")
        Else
            main.Passenger.Register(reg_input_user.Text, reg_input_password.Text, reg_name.Text, reg_sir.Text, birthday.Value)
            IO.File.AppendAllText("userdata.csv", reg_input_user.Text + "," + reg_input_password.Text + "," + reg_name.Text + "," + reg_sir.Text + "," + birthday.Value + vbNewLine)
        End If
    End Sub

    Private Sub register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub birthday_ValueChanged(sender As Object, e As EventArgs) Handles birthday.ValueChanged
        If DateDiff(DateInterval.Year, birthday.Value, Today) - 1 >= 60 Then
            CheckBox5.Checked = True
        Else
            CheckBox5.Checked = False
        End If
    End Sub
End Class