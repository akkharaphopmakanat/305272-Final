<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
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
        Me.btn_login = New System.Windows.Forms.Button()
        Me.ComboBox_Origin = New System.Windows.Forms.ComboBox()
        Me.lbl_origin = New System.Windows.Forms.Label()
        Me.lbl_destination = New System.Windows.Forms.Label()
        Me.ComboBox_Destination = New System.Windows.Forms.ComboBox()
        Me.btn_checktrain = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ขบวน = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ประเภท = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ต้นทางออก = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ปลายทางถึง = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ที่นั่งว่าง = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data_TimeTable = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Data_Train_Type = New System.Windows.Forms.DataGridView()
        Me.Data_User = New System.Windows.Forms.DataGridView()
        Me.Data_reserved = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data_TimeTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data_Train_Type, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data_User, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Data_reserved, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_login
        '
        Me.btn_login.Location = New System.Drawing.Point(12, 601)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(240, 23)
        Me.btn_login.TabIndex = 0
        Me.btn_login.Text = "เข้าสู่ระบบ"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'ComboBox_Origin
        '
        Me.ComboBox_Origin.FormattingEnabled = True
        Me.ComboBox_Origin.Location = New System.Drawing.Point(87, 12)
        Me.ComboBox_Origin.Name = "ComboBox_Origin"
        Me.ComboBox_Origin.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox_Origin.TabIndex = 1
        '
        'lbl_origin
        '
        Me.lbl_origin.AutoSize = True
        Me.lbl_origin.Location = New System.Drawing.Point(12, 15)
        Me.lbl_origin.Name = "lbl_origin"
        Me.lbl_origin.Size = New System.Drawing.Size(39, 13)
        Me.lbl_origin.TabIndex = 5
        Me.lbl_origin.Text = "ต้นทาง"
        '
        'lbl_destination
        '
        Me.lbl_destination.AutoSize = True
        Me.lbl_destination.Location = New System.Drawing.Point(12, 49)
        Me.lbl_destination.Name = "lbl_destination"
        Me.lbl_destination.Size = New System.Drawing.Size(49, 13)
        Me.lbl_destination.TabIndex = 6
        Me.lbl_destination.Text = "ปลายทาง"
        '
        'ComboBox_Destination
        '
        Me.ComboBox_Destination.FormattingEnabled = True
        Me.ComboBox_Destination.Location = New System.Drawing.Point(87, 46)
        Me.ComboBox_Destination.Name = "ComboBox_Destination"
        Me.ComboBox_Destination.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox_Destination.TabIndex = 7
        '
        'btn_checktrain
        '
        Me.btn_checktrain.Location = New System.Drawing.Point(293, 12)
        Me.btn_checktrain.Name = "btn_checktrain"
        Me.btn_checktrain.Size = New System.Drawing.Size(263, 38)
        Me.btn_checktrain.TabIndex = 8
        Me.btn_checktrain.Text = "ตรวจสอบ"
        Me.btn_checktrain.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ขบวน, Me.ประเภท, Me.ต้นทางออก, Me.ปลายทางถึง, Me.ที่นั่งว่าง})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 143)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(544, 412)
        Me.DataGridView1.TabIndex = 9
        '
        'ขบวน
        '
        Me.ขบวน.HeaderText = "ขบวน"
        Me.ขบวน.Name = "ขบวน"
        Me.ขบวน.ReadOnly = True
        '
        'ประเภท
        '
        Me.ประเภท.HeaderText = "ประเภท"
        Me.ประเภท.Name = "ประเภท"
        Me.ประเภท.ReadOnly = True
        '
        'ต้นทางออก
        '
        Me.ต้นทางออก.HeaderText = "ต้นทางออก"
        Me.ต้นทางออก.Name = "ต้นทางออก"
        Me.ต้นทางออก.ReadOnly = True
        '
        'ปลายทางถึง
        '
        Me.ปลายทางถึง.HeaderText = "ปลายทางถึง"
        Me.ปลายทางถึง.Name = "ปลายทางถึง"
        Me.ปลายทางถึง.ReadOnly = True
        '
        'ที่นั่งว่าง
        '
        Me.ที่นั่งว่าง.HeaderText = "ที่นั่งว่าง"
        Me.ที่นั่งว่าง.Name = "ที่นั่งว่าง"
        Me.ที่นั่งว่าง.ReadOnly = True
        '
        'Data_TimeTable
        '
        Me.Data_TimeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Data_TimeTable.Location = New System.Drawing.Point(304, 193)
        Me.Data_TimeTable.Name = "Data_TimeTable"
        Me.Data_TimeTable.Size = New System.Drawing.Size(240, 150)
        Me.Data_TimeTable.TabIndex = 11
        Me.Data_TimeTable.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(87, 79)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "วันที่เดินทาง"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(293, 56)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(263, 45)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "จองตั๋ว"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Data_Train_Type
        '
        Me.Data_Train_Type.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Data_Train_Type.Location = New System.Drawing.Point(304, 349)
        Me.Data_Train_Type.Name = "Data_Train_Type"
        Me.Data_Train_Type.Size = New System.Drawing.Size(240, 150)
        Me.Data_Train_Type.TabIndex = 15
        Me.Data_Train_Type.Visible = False
        '
        'Data_User
        '
        Me.Data_User.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Data_User.Location = New System.Drawing.Point(47, 349)
        Me.Data_User.Name = "Data_User"
        Me.Data_User.Size = New System.Drawing.Size(240, 150)
        Me.Data_User.TabIndex = 16
        Me.Data_User.Visible = False
        '
        'Data_reserved
        '
        Me.Data_reserved.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Data_reserved.Location = New System.Drawing.Point(47, 193)
        Me.Data_reserved.Name = "Data_reserved"
        Me.Data_reserved.Size = New System.Drawing.Size(240, 150)
        Me.Data_reserved.TabIndex = 17
        Me.Data_reserved.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 585)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "กรุณาเข้าสู่ระบบเพื่อจองตั๋ว"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 636)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Data_reserved)
        Me.Controls.Add(Me.Data_User)
        Me.Controls.Add(Me.Data_Train_Type)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Data_TimeTable)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_checktrain)
        Me.Controls.Add(Me.ComboBox_Destination)
        Me.Controls.Add(Me.lbl_destination)
        Me.Controls.Add(Me.lbl_origin)
        Me.Controls.Add(Me.ComboBox_Origin)
        Me.Controls.Add(Me.btn_login)
        Me.Name = "main"
        Me.Text = "The Star Ticket"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_TimeTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_Train_Type, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_User, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Data_reserved, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_login As Button
    Friend WithEvents ComboBox_Origin As ComboBox
    Friend WithEvents lbl_origin As Label
    Friend WithEvents lbl_destination As Label
    Friend WithEvents ComboBox_Destination As ComboBox
    Friend WithEvents btn_checktrain As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Data_TimeTable As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ขบวน As DataGridViewTextBoxColumn
    Friend WithEvents ประเภท As DataGridViewTextBoxColumn
    Friend WithEvents ต้นทางออก As DataGridViewTextBoxColumn
    Friend WithEvents ปลายทางถึง As DataGridViewTextBoxColumn
    Friend WithEvents ที่นั่งว่าง As DataGridViewTextBoxColumn
    Friend WithEvents Data_Train_Type As DataGridView
    Friend WithEvents Data_User As DataGridView
    Friend WithEvents Data_reserved As DataGridView
    Friend WithEvents Label2 As Label
End Class
