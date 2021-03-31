Public Class login
    Function userExist(username)
        Dim isAvail As Boolean = False
        For i = 0 To main.Data_User.Rows.Count - 1
            If main.Data_User.Rows(i).Cells(0).Value = username Then
                isAvail = True
                Exit For
            End If
        Next
        Return isAvail
    End Function
    Private Sub Login_Register_Click(sender As Object, e As EventArgs) Handles Login_Register.Click
        register.Show()
    End Sub

    Private Sub Login_Login_Click(sender As Object, e As EventArgs) Handles Login_Login.Click
        If login_input_user.Text = Nothing AndAlso login_input_password.Text = Nothing Then
            MsgBox("กรุณากรอกข้อมูลชื่อผู้ใช้ และ รหัสผ่านให้ครบถ้วน")
        Else
            main.Passenger.Login(login_input_user.Text, login_input_password.Text)
            main.Enabled = True
            Me.Close()
        End If
    End Sub
End Class