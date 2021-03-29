Imports Microsoft.VisualBasic.FileIO.TextFieldParser
Imports System.IO
Imports System.Data.Sql
Public Class main
    Public Passenger As New Passenger
    Dim stn_th, stn_en, stn_km As New List(Of String)
    Dim Dindex, Oindex As Integer
    Dim o_stop, d_stop, train_between As New List(Of String)
    Function initStation()
        If Not System.IO.File.Exists(My.Computer.FileSystem.CurrentDirectory + "\bin\data.csv") Then
            MsgBox("ไม่พบไฟล์ข้อมูล data.csv")
            Application.Exit()
        End If
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
    End Function
    Function initTrain()
        If Not System.IO.File.Exists(My.Computer.FileSystem.CurrentDirectory + "\bin\stop.csv") Then
            MsgBox("ไม่พบไฟล์ข้อมูล stop.csv")
            Application.Exit()
        End If
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
    End Function
    Function initTrainType()
        If Not System.IO.File.Exists(My.Computer.FileSystem.CurrentDirectory + "\bin\type.csv") Then
            MsgBox("ไม่พบไฟล์ข้อมูล type.csv")
            Application.Exit()
        End If
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
    End Function
    Function initUserData()
        If Not System.IO.File.Exists(My.Computer.FileSystem.CurrentDirectory + "\bin\userdata.csv") Then
            MsgBox("ไม่พบไฟล์ข้อมูล userdata.csv")
            Application.Exit()
        End If
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
    End Function
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initStation()
        initTrain()
        initTrainType()
        initUserData()
    End Sub
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If Passenger.Name Is Nothing Then
            login.Show()
        Else
            Passenger.Login(0, 0)
        End If
    End Sub
    Private Sub ComboBox_Origin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Origin.SelectedIndexChanged
        Passenger.Origin = ComboBox_Origin.Text
        reservation.ComboBox1.Text = ComboBox_Origin.Text
        reservation.ComboBox2.Text = ComboBox_Destination.Text
        Oindex = stn_th.IndexOf(Passenger.Origin)
        If ComboBox_Destination.Text <> Nothing Then
            reservation.km = Math.Abs(Data_TimeTable.Rows(Oindex).Cells(2).Value - Data_TimeTable.Rows(Dindex).Cells(2).Value)
            reservation.Label3.Text = reservation.km
            showTrain()
        End If
    End Sub
    Private Sub ComboBox_Destination_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Destination.SelectedIndexChanged
        Passenger.Destination = ComboBox_Destination.Text
        reservation.ComboBox1.Text = ComboBox_Origin.Text
        reservation.ComboBox2.Text = ComboBox_Destination.Text
        Dindex = stn_th.IndexOf(Passenger.Destination)
        If ComboBox_Origin.Text <> Nothing Then
            reservation.km = Math.Abs(Data_TimeTable.Rows(Oindex).Cells(2).Value - Data_TimeTable.Rows(Dindex).Cells(2).Value)
            reservation.Label3.Text = reservation.km
            showTrain()
        End If
    End Sub
    Function showTrain()
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
    End Function
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
    Private Sub btn_checktrain_Click(sender As Object, e As EventArgs) Handles btn_checktrain.Click
        'Dim message = String.Join(Environment.NewLine, train_between.ToArray())
        'MessageBox.Show("ขบวนที่จอด " + Passenger.Origin + Passenger.Destination + vbCrLf + message)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Enabled = False
        reservation.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        admin.Show()
    End Sub
End Class
