Imports System.Text
Public Class Passenger
    Public Name, Sirname, Username, Password, UserType, Origin, Destination, Direction As String
    Public Age, Discount As Integer
    Public Birthday As Date
    Public Sub Register(Username, Password, Name, Sirname, Birthday)
        Me.Username = Username
        Me.Password = Password
        Me.Name = Name
        Me.Sirname = Sirname
        Me.Birthday = Birthday
        Me.Age = DateDiff(DateInterval.Year, Me.Birthday, Today) - 1
    End Sub

    Public Function GetAge()
        Return Me.Age
    End Function

    Public Sub Login(Username, Password)
        If main.btn_login.Text = "เข้าสู่ระบบ" Then
            Dim complete = False
            For i = 0 To main.Data_User.Rows.Count - 1
                If Username = main.Data_User.Rows(i).Cells(0).Value AndAlso Password = main.Data_User.Rows(i).Cells(1).Value Then
                    Me.Username = main.Data_User.Rows(i).Cells(0).Value
                    Me.Name = main.Data_User.Rows(i).Cells(2).Value
                    Me.Sirname = main.Data_User.Rows(i).Cells(3).Value
                    Me.Birthday = main.Data_User.Rows(i).Cells(4).Value
                    complete = True
                    MsgBox("ยินดีต้อนรับ " + Me.Name + " " + Me.Sirname)
                    main.btn_login.Text = "ออกจากระบบ"
                    main.Label2.Text = Me.Name + " " + Me.Sirname

                    Exit For
                End If
            Next
            If complete = False Then
                MsgBox("ขออภัยรหัสผิดพลาด หรือ ไม่พบผู้ใช้ในระบบ")
            End If
        Else
            main.Label2.Text = "กรุณาเข้าสู่ระบบเพื่อจองตั๋ว"
            main.btn_login.Text = "เข้าสู่ระบบ"
            Me.Username = Nothing
            Me.Name = Nothing
            Me.Sirname = Nothing
            Me.Birthday = Nothing
        End If
    End Sub
    Public Sub Logout()
    End Sub
End Class

Class Train
    Public ID, Capacity As Integer
    Public Origin, Destination, Type As String
    Public StopList As List(Of String)
End Class
