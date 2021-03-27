Public Class admin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Data_TimeTable.Columns.Clear()
        For Each Col As DataGridViewColumn In main.Data_TimeTable.Columns
            Data_TimeTable.Columns.Add(DirectCast(Col.Clone, DataGridViewColumn))
        Next
        For rowIndex As Integer = 0 To (main.Data_TimeTable.Rows.Count - 1)
            Data_TimeTable.Rows.Add(main.Data_TimeTable.Rows(rowIndex).Cells.Cast(Of DataGridViewCell).Select(Function(c) c.Value).ToArray)
        Next
    End Sub
End Class