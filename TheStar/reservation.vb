Public Class reservation
    Public km As Single
    Dim total As Integer
    Dim fee_type As Single
    Dim reserve_train
    Function check_train_class(input)
        Select Case input
            Case "บนอ.ป."
                Return {1, 1, 1}
            Case "บนท.ป."
                Return {2, 1, 1}
            Case "บนท."
                Return {2, 1, 0}
            Case "บชท.ป."
                Return {2, 0, 1}
            Case "บชท."
                Return {2, 0, 0}
            Case "บชส.ป."
                Return {3, 0, 1}
            Case "บชส."
                Return {3, 0, 0}
            Case "กซข.ป."
                Return {2, 0, 1}
            Case "กซข."
                Return {3, 0, 0}
            Case "กซม.ป."
                Return {2, 0, 1}
            Case Else
                Return {0, 0, 0}
        End Select
    End Function
    Private Sub reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For i = 0 To main.DataGridView1.Rows.Count - 2
            ComboBox3.Items.Add(main.DataGridView1.Rows(i).Cells(0).Value)
        Next
        For i = 0 To main.Data_Train_Type.Rows.Count - 2

        Next

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        reserve_train = ComboBox3.Text
        Dim reserve_train_index As Integer
        ComboBox4.Text = Nothing
        ComboBox4.Items.Clear()
        Console.WriteLine(reserve_train)
        For i = 0 To main.Data_Train_Type.Rows.Count - 1
            If main.Data_Train_Type.Rows(i).Cells(0).Value = reserve_train Then
                Console.WriteLine(main.Data_Train_Type.Rows(i).Cells(0).Value)
                reserve_train_index = i
            End If
            Console.WriteLine(main.Data_Train_Type.Columns.Count)
        Next
        Label1.Text = "ประเภท : " + main.Data_Train_Type.Rows(reserve_train_index).Cells(1).Value

        Select Case main.Data_Train_Type.Rows(reserve_train_index).Cells(1).Value.ToString
            Case "ด่วนพิเศษ", "ด่วนพิเศษดีเซลราง"
                fee_type = 170
            Case "ด่วน"
                fee_type = 150
            Case "เร็ว"
                If km >= 0 AndAlso km <= 50 Then
                    fee_type = 20
                ElseIf km > 50 AndAlso km <= 150 Then
                    fee_type = 30
                ElseIf km > 150 AndAlso km <= 300 Then
                    fee_type = 50
                ElseIf km > 300 Then
                    fee_type = 110
                End If
            Case "ธรรมดา", "ชานเมือง", "ท้องถิ่น"
                fee_type = 0
        End Select
        label_type_price.Text = "ราคา " + fee_type.ToString + " บาท"
        For i = 0 To main.Data_Train_Type.Columns.Count - 1
            Console.WriteLine(main.Data_Train_Type.Rows(reserve_train_index).Cells(i).Value)
            If Integer.TryParse(main.Data_Train_Type.Rows(reserve_train_index).Cells(i).Value, vbNull) Then
                If i >= 5 And main.Data_Train_Type.Rows(reserve_train_index).Cells(i).Value <> 0 Then
                    ComboBox4.Items.Add(main.Data_Train_Type.Columns(i).Name)
                End If
            End If
        Next
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        If ComboBox4.Text <> Nothing Then
            Try
                PictureBox1.Image = Image.FromFile(My.Computer.FileSystem.CurrentDirectory + "\img\" + ComboBox4.Text + ".jpg")
            Catch ex As Exception
            End Try
            Dim train_class = check_train_class(ComboBox4.Text)(0)
            Dim train_bed = check_train_class(ComboBox4.Text)(1)
            Dim train_air = check_train_class(ComboBox4.Text)(2)
            Dim fee_class, fee_bed, fee_air As Single
            If train_class = 1 Then
                fee_class = 98 / 92.25
            ElseIf train_class = 2 Then
                fee_class = 45 / 92.25
            ElseIf train_class = 3 Then
                fee_class = 20 / 92.25
            End If
            If train_bed = 1 Then
                fee_bed = 500
                CheckBox2.Checked = True
            Else
                fee_bed = 0
                CheckBox2.Checked = False
            End If
            label_bed_price.Text = "ราคา " + fee_bed.ToString + " บาท"
            If train_air = 1 Then
                If km > 0 AndAlso km <= 300 Then
                    fee_air = 60
                    CheckBox1.Checked = True
                ElseIf km > 300 AndAlso km <= 500 Then
                    fee_air = 70
                    CheckBox1.Checked = True
                ElseIf km > 500 Then
                    fee_air = 110
                    CheckBox1.Checked = True
                Else
                    fee_air = 0
                    CheckBox1.Checked = False
                End If
                label_air_price.Text = "ราคา " + fee_air.ToString + " บาท"
            End If
            If main.Passenger.GetAge() > 60 Then
                total = (km * fee_class) / 2 + fee_bed + fee_air + fee_type
                CheckBox3.Checked = True
                label_senoir_discount.Text = "ราคา " + (-(km * fee_class) / 2).ToString + " บาท"
            Else
                total = (km * fee_class) + fee_bed + fee_air + fee_type
                CheckBox3.Checked = False
                label_senoir_discount.Text = "ราคา " + 0.ToString + " บาท"
            End If
            label_class.Text = "ชั้น : " + train_class.ToString
            label_distance_price.Text = "ราคา " + (km * fee_class).ToString + " บาท"
            lable_total.Text = "ยอดที่ต้องชำระ " + total.ToString + " บาท"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        main.Enabled = True
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox4.Text = Nothing Then
            MsgBox("กรุณาเลือกชั้นขบวนรถ")
        End If
        If Not System.IO.File.Exists(My.Computer.FileSystem.CurrentDirectory + "\bin\reserved.csv") Then
            MsgBox("ไม่พบไฟล์ reserved.csv กำลังสร้างไฟล์ใหม่")
            System.IO.File.Create(My.Computer.FileSystem.CurrentDirectory + "\bin\reserved.csv")
        Else
            IO.File.AppendAllText("bin\userdata.csv", DateTimePicker1.Value + "," + main.Passenger.Name.ToString + "," + main.Passenger.Sirname + "," + main.Passenger.Origin + "," + main.Passenger.Destination + "," + reserve_train + "," + ComboBox4.Text + "," + total + "," + vbNewLine)
        End If
    End Sub
End Class