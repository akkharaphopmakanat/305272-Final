Public Class reservation
    Private Sub reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For i = 0 To main.DataGridView1.Rows.Count - 2
            Console.WriteLine(main.DataGridView1.Rows(i).Cells(0).Value)
            ComboBox1.Items.Add(main.DataGridView1.Rows(i).Cells(0).Value)

        Next
    End Sub
End Class