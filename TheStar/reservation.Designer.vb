<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reservation
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lable_distance = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.label_org = New System.Windows.Forms.Label()
        Me.label_dest = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.label_class = New System.Windows.Forms.Label()
        Me.label_distance_price = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.label_air_price = New System.Windows.Forms.Label()
        Me.label_bed_price = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.label_senoir_discount = New System.Windows.Forms.Label()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.label_type_price = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lable_total = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(63, 122)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(152, 21)
        Me.ComboBox3.TabIndex = 4
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(63, 199)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(152, 21)
        Me.ComboBox4.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ประเภท"
        '
        'lable_distance
        '
        Me.lable_distance.AutoSize = True
        Me.lable_distance.Location = New System.Drawing.Point(9, 97)
        Me.lable_distance.Name = "lable_distance"
        Me.lable_distance.Size = New System.Drawing.Size(56, 13)
        Me.lable_distance.TabIndex = 8
        Me.lable_distance.Text = "ระยะทาง : "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 409)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(285, 89)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "ย้อนกลับ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'label_org
        '
        Me.label_org.AutoSize = True
        Me.label_org.Location = New System.Drawing.Point(9, 45)
        Me.label_org.Name = "label_org"
        Me.label_org.Size = New System.Drawing.Size(48, 13)
        Me.label_org.TabIndex = 10
        Me.label_org.Text = "ต้นทาง : "
        '
        'label_dest
        '
        Me.label_dest.AutoSize = True
        Me.label_dest.Location = New System.Drawing.Point(9, 69)
        Me.label_dest.Name = "label_dest"
        Me.label_dest.Size = New System.Drawing.Size(58, 13)
        Me.label_dest.TabIndex = 11
        Me.label_dest.Text = "ปลายทาง : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "ขบวน"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "ชนิดรถ"
        '
        'label_class
        '
        Me.label_class.AutoSize = True
        Me.label_class.Location = New System.Drawing.Point(9, 231)
        Me.label_class.Name = "label_class"
        Me.label_class.Size = New System.Drawing.Size(31, 13)
        Me.label_class.TabIndex = 14
        Me.label_class.Text = "ชั้น : "
        '
        'label_distance_price
        '
        Me.label_distance_price.AutoSize = True
        Me.label_distance_price.Location = New System.Drawing.Point(143, 231)
        Me.label_distance_price.Name = "label_distance_price"
        Me.label_distance_price.Size = New System.Drawing.Size(79, 13)
        Me.label_distance_price.TabIndex = 15
        Me.label_distance_price.Text = "ราคา          บาท"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Location = New System.Drawing.Point(12, 257)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(90, 17)
        Me.CheckBox1.TabIndex = 16
        Me.CheckBox1.Text = "รถปรับอากาศ"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'label_air_price
        '
        Me.label_air_price.AutoSize = True
        Me.label_air_price.Location = New System.Drawing.Point(143, 257)
        Me.label_air_price.Name = "label_air_price"
        Me.label_air_price.Size = New System.Drawing.Size(79, 13)
        Me.label_air_price.TabIndex = 17
        Me.label_air_price.Text = "ราคา          บาท"
        '
        'label_bed_price
        '
        Me.label_bed_price.AutoSize = True
        Me.label_bed_price.Location = New System.Drawing.Point(143, 280)
        Me.label_bed_price.Name = "label_bed_price"
        Me.label_bed_price.Size = New System.Drawing.Size(79, 13)
        Me.label_bed_price.TabIndex = 19
        Me.label_bed_price.Text = "ราคา          บาท"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Enabled = False
        Me.CheckBox2.Location = New System.Drawing.Point(12, 280)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(61, 17)
        Me.CheckBox2.TabIndex = 18
        Me.CheckBox2.Text = "รถนอน"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'label_senoir_discount
        '
        Me.label_senoir_discount.AutoSize = True
        Me.label_senoir_discount.Location = New System.Drawing.Point(143, 303)
        Me.label_senoir_discount.Name = "label_senoir_discount"
        Me.label_senoir_discount.Size = New System.Drawing.Size(79, 13)
        Me.label_senoir_discount.TabIndex = 21
        Me.label_senoir_discount.Text = "ราคา          บาท"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Enabled = False
        Me.CheckBox3.Location = New System.Drawing.Point(12, 303)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(62, 17)
        Me.CheckBox3.TabIndex = 20
        Me.CheckBox3.Text = "ผู้สูงอายุ"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'label_type_price
        '
        Me.label_type_price.AutoSize = True
        Me.label_type_price.Location = New System.Drawing.Point(143, 174)
        Me.label_type_price.Name = "label_type_price"
        Me.label_type_price.Size = New System.Drawing.Size(79, 13)
        Me.label_type_price.TabIndex = 22
        Me.label_type_price.Text = "ราคา          บาท"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(243, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(377, 262)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(335, 409)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(285, 89)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "ยืนยันการจองตั๋ว"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lable_total
        '
        Me.lable_total.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lable_total.AutoSize = True
        Me.lable_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.lable_total.Location = New System.Drawing.Point(330, 348)
        Me.lable_total.Name = "lable_total"
        Me.lable_total.Size = New System.Drawing.Size(279, 29)
        Me.lable_total.TabIndex = 25
        Me.lable_total.Text = "ยอดที่ต้องชำระ :                    "
        Me.lable_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'reservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 513)
        Me.ControlBox = False
        Me.Controls.Add(Me.lable_total)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.label_type_price)
        Me.Controls.Add(Me.label_senoir_discount)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.label_bed_price)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.label_air_price)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.label_distance_price)
        Me.Controls.Add(Me.label_class)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label_dest)
        Me.Controls.Add(Me.label_org)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lable_distance)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(648, 552)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(648, 552)
        Me.Name = "reservation"
        Me.Text = "จองตั๋ว"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lable_distance As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents label_org As Label
    Friend WithEvents label_dest As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents label_class As Label
    Friend WithEvents label_distance_price As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents label_air_price As Label
    Friend WithEvents label_bed_price As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents label_senoir_discount As Label
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents label_type_price As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents lable_total As Label
End Class
