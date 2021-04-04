<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class check
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.วันที่ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ชื่อ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.นามสกุล = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ต้นทาง = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ปลายทาง = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ขบวน = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ชั้น = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ราคา = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 490)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(285, 89)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "ย้อนกลับ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.วันที่, Me.ชื่อ, Me.นามสกุล, Me.ต้นทาง, Me.ปลายทาง, Me.ขบวน, Me.ชั้น, Me.ราคา})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(845, 455)
        Me.DataGridView1.TabIndex = 11
        '
        'วันที่
        '
        Me.วันที่.HeaderText = "วันที่"
        Me.วันที่.Name = "วันที่"
        '
        'ชื่อ
        '
        Me.ชื่อ.HeaderText = "ชื่อ"
        Me.ชื่อ.Name = "ชื่อ"
        '
        'นามสกุล
        '
        Me.นามสกุล.HeaderText = "นามสกุล"
        Me.นามสกุล.Name = "นามสกุล"
        '
        'ต้นทาง
        '
        Me.ต้นทาง.HeaderText = "ต้นทาง"
        Me.ต้นทาง.Name = "ต้นทาง"
        '
        'ปลายทาง
        '
        Me.ปลายทาง.HeaderText = "ปลายทาง"
        Me.ปลายทาง.Name = "ปลายทาง"
        '
        'ขบวน
        '
        Me.ขบวน.HeaderText = "ขบวน"
        Me.ขบวน.Name = "ขบวน"
        '
        'ชั้น
        '
        Me.ชั้น.HeaderText = "ชั้น"
        Me.ชั้น.Name = "ชั้น"
        '
        'ราคา
        '
        Me.ราคา.HeaderText = "ราคา"
        Me.ราคา.Name = "ราคา"
        '
        'check
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 591)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(885, 630)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(885, 630)
        Me.Name = "check"
        Me.Text = "ประวัติการจอง"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents วันที่ As DataGridViewTextBoxColumn
    Friend WithEvents ชื่อ As DataGridViewTextBoxColumn
    Friend WithEvents นามสกุล As DataGridViewTextBoxColumn
    Friend WithEvents ต้นทาง As DataGridViewTextBoxColumn
    Friend WithEvents ปลายทาง As DataGridViewTextBoxColumn
    Friend WithEvents ขบวน As DataGridViewTextBoxColumn
    Friend WithEvents ชั้น As DataGridViewTextBoxColumn
    Friend WithEvents ราคา As DataGridViewTextBoxColumn
End Class
