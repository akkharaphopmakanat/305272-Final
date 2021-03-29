Public Class reservation
    Public km As Single
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
        Dim reserve_train = ComboBox3.Text
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
            Dim train_class = check_train_class(ComboBox4.Text)(0)
            Dim train_bed = check_train_class(ComboBox4.Text)(1)
            Dim train_air = check_train_class(ComboBox4.Text)(2)
            Dim fee_class, fee_bed, fee_air As Single
            If train_class = 1 Then
                fee_class = 0.92
            ElseIf train_class = 2 Then
                fee_class = 0.44
            ElseIf train_class = 3 Then
                fee_class = 0.21
            End If
            If fee_bed = 1 Then
                fee_bed = 500
            Else
                fee_bed = 0
            End If
            If train_air = 1 Then
                If km > 0 AndAlso km <= 300 Then
                    fee_air = 60
                ElseIf km > 300 AndAlso km <= 500 Then
                    fee_air = 70
                ElseIf km > 500 Then
                    fee_air = 110
                Else
                    fee_air = 0
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        main.Enabled = True
        Me.Close()
    End Sub
End Class