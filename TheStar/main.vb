Imports Microsoft.VisualBasic.FileIO.TextFieldParser
Imports System.IO
Imports System.Data.Sql
Public Class main
    Public Passenger As New Passenger
    Dim stn_th, stn_en, stn_km As New List(Of String)
    Dim Dindex, Oindex As Integer
    Dim o_stop, d_stop, train_between As New List(Of String)
    Sub subtrackReserved()
        Try
            Dim filepath = My.Computer.FileSystem.CurrentDirectory + "\bin\reserved.csv"
            Dim dt As DataTable = New DataTable()
            Dim lines As String() = System.IO.File.ReadAllLines(filepath)
            If lines.Length > 0 Then
                Dim firstLine As String = lines(0)
                Dim headerLabels As String() = firstLine.Split(","c)
                For Each headerWord As String In headerLabels
                    dt.Columns.Add(New DataColumn(headerWord))
                Next
                For i As Integer = 1 To lines.Length - 1
                    Dim dataWords As String() = lines(i).Split(","c)
                    Dim dr As DataRow = dt.NewRow()
                    Dim columnIndex As Integer = 0
                    For Each headerWord As String In headerLabels
                        dr(headerWord) = dataWords(Math.Min(System.Threading.Interlocked.Increment(columnIndex), columnIndex - 1))
                    Next
                    dt.Rows.Add(dr)
                Next
            End If
            If dt.Rows.Count > 0 Then
                Data_reserved.DataSource = dt
            End If
        Catch ex As Exception
            MsgBox("ไม่พบไฟล์ข้อมูล reserved.csv")
            Application.Exit()
        End Try

        Dim resDate As Date = DateTimePicker1.Value

        For i = 0 To Data_reserved.Rows.Count - 1
            If Data_reserved.Rows(i).Cells(0).Value = DateTimePicker1.Value.Date Then
                For j = 0 To DataGridView1.Rows.Count - 1
                    If Data_reserved.Rows(i).Cells(5).Value = DataGridView1.Rows(j).Cells(0).Value Then
                        DataGridView1.Rows(j).Cells(4).Value -= 1
                    End If
                Next
            End If
        Next
    End Sub
    Sub initStation()
        Try
            Dim MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(My.Computer.FileSystem.CurrentDirectory + "\bin\data.csv")
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            Dim currentRow As String()
            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()
                    Dim currentField As String
                    Dim i = 0
                    For Each currentField In currentRow
                        If i = 3 Then
                            i = 0
                        End If
                        If i = 0 Then
                            ComboBox_Origin.Items.Add(currentField)
                            ComboBox_Destination.Items.Add(currentField)
                            stn_th.Add(currentField)
                        End If
                        If i = 1 Then
                            stn_en.Add(currentField)
                        End If
                        If i = 2 Then
                            stn_km.Add(currentField)
                        End If
                        i = i + 1
                    Next
                Catch ex As Microsoft.VisualBasic.FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message & "is not valid and will be skipped.")
                End Try
            End While
        Catch ex As Exception
            MsgBox("ไม่พบไฟล์ข้อมูลa data.csv")
            Application.Exit()
        End Try

    End Sub
    Sub initTrain()
        Try
            Dim filepath = My.Computer.FileSystem.CurrentDirectory + "\bin\stop.csv"
            Dim dt As DataTable = New DataTable()
            Dim lines As String() = System.IO.File.ReadAllLines(filepath)
            If lines.Length > 0 Then
                Dim firstLine As String = lines(0)
                Dim headerLabels As String() = firstLine.Split(","c)
                For Each headerWord As String In headerLabels
                    dt.Columns.Add(New DataColumn(headerWord))
                Next
                For i As Integer = 1 To lines.Length - 1
                    Dim dataWords As String() = lines(i).Split(","c)
                    Dim dr As DataRow = dt.NewRow()
                    Dim columnIndex As Integer = 0
                    For Each headerWord As String In headerLabels
                        dr(headerWord) = dataWords(Math.Min(System.Threading.Interlocked.Increment(columnIndex), columnIndex - 1))
                    Next
                    dt.Rows.Add(dr)
                Next
            End If
            If dt.Rows.Count > 0 Then
                Data_TimeTable.DataSource = dt
            End If
        Catch ex As Exception
            MsgBox("ไม่พบไฟล์ข้อมูล stop.csv")
            Application.Exit()
        End Try
    End Sub
    Sub initTrainType()
        Try
            Dim filepath = My.Computer.FileSystem.CurrentDirectory + "\bin\type.csv"
            Dim dt As DataTable = New DataTable()
            Dim lines As String() = System.IO.File.ReadAllLines(filepath)
            If lines.Length > 0 Then
                Dim firstLine As String = lines(0)
                Dim headerLabels As String() = firstLine.Split(","c)
                For Each headerWord As String In headerLabels
                    dt.Columns.Add(New DataColumn(headerWord))
                Next
                For i As Integer = 1 To lines.Length - 1
                    Dim dataWords As String() = lines(i).Split(","c)
                    Dim dr As DataRow = dt.NewRow()
                    Dim columnIndex As Integer = 0

                    For Each headerWord As String In headerLabels
                        dr(headerWord) = dataWords(Math.Min(System.Threading.Interlocked.Increment(columnIndex), columnIndex - 1))
                    Next
                    dt.Rows.Add(dr)
                Next
            End If
            If dt.Rows.Count > 0 Then
                Data_Train_Type.DataSource = dt
            End If
        Catch ex As Exception
            MsgBox("ไม่พบไฟล์ข้อมูล type.csv")
                Application.Exit()
        End Try
    End Sub
    Sub initUserData()
        Try
            Dim filepath = My.Computer.FileSystem.CurrentDirectory + "\bin\userdata.csv"
            Dim dt As DataTable = New DataTable()
            Dim lines As String() = System.IO.File.ReadAllLines(filepath)
            If lines.Length > 0 Then
                Dim firstLine As String = lines(0)
                Dim headerLabels As String() = firstLine.Split(","c)
                For Each headerWord As String In headerLabels
                    dt.Columns.Add(New DataColumn(headerWord))
                Next
                For i As Integer = 1 To lines.Length - 1
                    Dim dataWords As String() = lines(i).Split(","c)
                    Dim dr As DataRow = dt.NewRow()
                    Dim columnIndex As Integer = 0
                    For Each headerWord As String In headerLabels
                        dr(headerWord) = dataWords(Math.Min(System.Threading.Interlocked.Increment(columnIndex), columnIndex - 1))
                    Next
                    dt.Rows.Add(dr)
                Next
            End If
            If dt.Rows.Count > 0 Then
                Data_User.DataSource = dt
            End If
        Catch ex As Exception
            MsgBox("ไม่พบไฟล์ข้อมูล userdata.csv")
            Application.Exit()
        End Try
    End Sub
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initStation()
        initTrain()
        initTrainType()
        initUserData()
    End Sub
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If Passenger.Name Is Nothing Then
            Me.Enabled = False
            login.Show()
        Else
            Passenger.Login(Nothing, Nothing)
        End If
    End Sub
    Private Sub ComboBox_Origin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Origin.SelectedIndexChanged
        Passenger.Origin = ComboBox_Origin.Text
        reservation.label_org.Text = "ต้นทาง : " + ComboBox_Origin.Text
        reservation.label_dest.Text = "ปลายทาง : " + ComboBox_Destination.Text
        Oindex = stn_th.IndexOf(Passenger.Origin)
        If ComboBox_Destination.Text <> Nothing Then
            reservation.km = Math.Abs(Data_TimeTable.Rows(Oindex).Cells(2).Value - Data_TimeTable.Rows(Dindex).Cells(2).Value)
            reservation.lable_distance.Text = "ระยะทาง : " + reservation.km.ToString
            showTrain()
        End If
        subtrackReserved()
    End Sub
    Private Sub ComboBox_Destination_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Destination.SelectedIndexChanged
        Passenger.Destination = ComboBox_Destination.Text
        reservation.label_org.Text = "ต้นทาง : " + ComboBox_Origin.Text
        reservation.label_dest.Text = "ปลายทาง : " + ComboBox_Destination.Text
        Dindex = stn_th.IndexOf(Passenger.Destination)
        If ComboBox_Origin.Text <> Nothing Then
            reservation.km = Math.Abs(Data_TimeTable.Rows(Oindex).Cells(2).Value - Data_TimeTable.Rows(Dindex).Cells(2).Value)
            reservation.lable_distance.Text = "ระยะทาง : " + reservation.km.ToString
            showTrain()
        End If
        subtrackReserved()
    End Sub
    Sub showTrain()
        train_between.Clear()
        If Oindex > Dindex Then
            Passenger.Direction = "Down"
        ElseIf Dindex > Oindex Then
            Passenger.Direction = "Up"
        ElseIf Dindex = Oindex Then
            Passenger.Direction = Nothing
        End If
        d_stop.Clear()
        o_stop.Clear()
        DataGridView1.Rows.Clear()
        If Passenger.Origin = Passenger.Destination Then
            MsgBox("ขออภัยไม่มีขบวนรถเดินระหว่างสถานีที่ท่านเลือก", 48)
        End If
        For i = 3 To Data_TimeTable.ColumnCount - 1
            If Data_TimeTable.Rows(Oindex).Cells(i).Value <> "-" Then
                If Passenger.Direction = "Up" AndAlso Data_TimeTable.Columns(i).Name Mod 2 = 1 Then
                    o_stop.Add(Data_TimeTable.Columns(i).Name)
                End If
                If Passenger.Direction = "Down" AndAlso Data_TimeTable.Columns(i).Name Mod 2 = 0 Then
                    o_stop.Add(Data_TimeTable.Columns(i).Name)
                End If
            End If
        Next
        For i = 3 To Data_TimeTable.ColumnCount - 1
            If Data_TimeTable.Rows(Dindex).Cells(i).Value <> "-" Then
                If Passenger.Direction = "Up" AndAlso Data_TimeTable.Columns(i).Name Mod 2 = 1 Then
                    d_stop.Add(Data_TimeTable.Columns(i).Name)
                End If
                If Passenger.Direction = "Down" AndAlso Data_TimeTable.Columns(i).Name Mod 2 = 0 Then
                    d_stop.Add(Data_TimeTable.Columns(i).Name)
                End If
            End If
        Next
        For Each i In o_stop
            For Each j In d_stop
                If j = i Then
                    train_between.Add(j)
                    DataGridView1.Rows.Add(j)
                End If
            Next
        Next
        For i = 0 To DataGridView1.Rows.Count - 2
            Dim trn_get As String = DataGridView1.Rows(i).Cells(0).Value
            DataGridView1.Rows(i).Cells(1).Value = getTrainType(trn_get, 1)
            DataGridView1.Rows(i).Cells(2).Value = getTrainTime(ComboBox_Origin.Text, trn_get)
            DataGridView1.Rows(i).Cells(3).Value = getTrainTime(ComboBox_Destination.Text, trn_get)
            DataGridView1.Rows(i).Cells(4).Value = getTrainType(trn_get, 4)
        Next
    End Sub
    Dim dttTrnIndex As Integer


    Function getTrainType(train, col)
        For i = 0 To Data_Train_Type.Rows.Count - 1
            If Data_Train_Type.Rows(i).Cells(0).Value = train Then
                dttTrnIndex = i
                Exit For
            End If
        Next
        Console.WriteLine(dttTrnIndex)
        Return Data_Train_Type.Rows(dttTrnIndex).Cells(col).Value
    End Function
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        reservation.DateTimePicker1.Value = Me.DateTimePicker1.Value
        subtrackReserved()
    End Sub
    Dim gtdStnIndex, gtdTrnIndex As Integer
    Function getTrainTime(stn, train)
        For i = 0 To Data_TimeTable.Rows.Count - 1
            If Data_TimeTable.Rows(i).Cells(0).Value = stn Then
                gtdStnIndex = i
                Exit For
            End If
        Next
        For i = 0 To Data_TimeTable.Columns.Count - 1
            If Data_TimeTable.Columns(i).Name = train Then
                gtdTrnIndex = i
                Exit For
            End If
        Next
        Return Data_TimeTable.Rows(gtdStnIndex).Cells(gtdTrnIndex).Value
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Passenger.Name Is Nothing Then
            Me.Enabled = False
            login.Show()
        Else
            Me.Enabled = False
            reservation.Show()
        End If
    End Sub
    Private Sub btn_checktrain_Click(sender As Object, e As EventArgs) Handles btn_checktrain.Click
        If Passenger.Name Is Nothing Then
            MsgBox("กรุณาเข้าสู่ระบบ")
        Else

            Try
                Try
                    Dim filepath = My.Computer.FileSystem.CurrentDirectory + "\bin\reserved.csv"
                    Dim dt As DataTable = New DataTable()
                    Dim lines As String() = System.IO.File.ReadAllLines(filepath)
                    If lines.Length > 0 Then
                        Dim firstLine As String = lines(0)
                        Dim headerLabels As String() = firstLine.Split(","c)
                        For Each headerWord As String In headerLabels
                            dt.Columns.Add(New DataColumn(headerWord))
                        Next
                        For i As Integer = 1 To lines.Length - 1
                            Dim dataWords As String() = lines(i).Split(","c)
                            Dim dr As DataRow = dt.NewRow()
                            Dim columnIndex As Integer = 0
                            For Each headerWord As String In headerLabels
                                dr(headerWord) = dataWords(Math.Min(System.Threading.Interlocked.Increment(columnIndex), columnIndex - 1))
                            Next
                            dt.Rows.Add(dr)
                        Next
                    End If
                    If dt.Rows.Count > 0 Then
                        Data_reserved.DataSource = dt
                    End If
                Catch ex As Exception
                    MsgBox("ไม่พบไฟล์ข้อมูล reserved.csv")
                    Application.Exit()
                End Try


                Dim destrow = 0
                For i = 0 To Data_reserved.Rows.Count - 1
                    If Data_reserved.Rows(i).Cells(1).Value = Passenger.Name AndAlso Data_reserved.Rows(i).Cells(2).Value = Passenger.Sirname Then
                        check.DataGridView1.Rows.Add()
                        For j = 0 To 7
                            check.DataGridView1.Rows(destrow).Cells(j).Value = Data_reserved.Rows(i).Cells(j).Value
                        Next
                        destrow += 1
                    End If
                Next
            Catch ex As Exception
            End Try
            check.Show()
        End If
    End Sub

End Class
