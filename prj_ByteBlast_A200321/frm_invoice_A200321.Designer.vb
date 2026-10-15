<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_invoice_A200321
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
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_custName = New System.Windows.Forms.TextBox()
        Me.txt_custID = New System.Windows.Forms.TextBox()
        Me.txt_staffName = New System.Windows.Forms.TextBox()
        Me.txt_staffID = New System.Windows.Forms.TextBox()
        Me.lbl_orderDt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lst_orderID = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grd_invoice = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.grd_invoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_subtotal
        '
        Me.txt_subtotal.Location = New System.Drawing.Point(1096, 512)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.ReadOnly = True
        Me.txt_subtotal.Size = New System.Drawing.Size(175, 22)
        Me.txt_subtotal.TabIndex = 114
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1092, 480)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 19)
        Me.Label4.TabIndex = 113
        Me.Label4.Text = "SUBTOTAL: "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(179, 471)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 19)
        Me.Label11.TabIndex = 112
        Me.Label11.Text = "STAFF ID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(179, 509)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 19)
        Me.Label10.TabIndex = 111
        Me.Label10.Text = "STAFF NAME"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(556, 473)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 19)
        Me.Label9.TabIndex = 110
        Me.Label9.Text = "CUSTOMER ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(556, 513)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 19)
        Me.Label8.TabIndex = 109
        Me.Label8.Text = "CUSTOMER NAME"
        '
        'txt_custName
        '
        Me.txt_custName.Location = New System.Drawing.Point(704, 510)
        Me.txt_custName.Name = "txt_custName"
        Me.txt_custName.ReadOnly = True
        Me.txt_custName.Size = New System.Drawing.Size(185, 22)
        Me.txt_custName.TabIndex = 108
        '
        'txt_custID
        '
        Me.txt_custID.Location = New System.Drawing.Point(704, 470)
        Me.txt_custID.Name = "txt_custID"
        Me.txt_custID.ReadOnly = True
        Me.txt_custID.Size = New System.Drawing.Size(185, 22)
        Me.txt_custID.TabIndex = 107
        '
        'txt_staffName
        '
        Me.txt_staffName.Location = New System.Drawing.Point(327, 510)
        Me.txt_staffName.Name = "txt_staffName"
        Me.txt_staffName.ReadOnly = True
        Me.txt_staffName.Size = New System.Drawing.Size(185, 22)
        Me.txt_staffName.TabIndex = 106
        '
        'txt_staffID
        '
        Me.txt_staffID.Location = New System.Drawing.Point(327, 465)
        Me.txt_staffID.Name = "txt_staffID"
        Me.txt_staffID.ReadOnly = True
        Me.txt_staffID.Size = New System.Drawing.Size(185, 22)
        Me.txt_staffID.TabIndex = 105
        '
        'lbl_orderDt
        '
        Me.lbl_orderDt.Location = New System.Drawing.Point(1084, 170)
        Me.lbl_orderDt.Name = "lbl_orderDt"
        Me.lbl_orderDt.ReadOnly = True
        Me.lbl_orderDt.Size = New System.Drawing.Size(220, 22)
        Me.lbl_orderDt.TabIndex = 104
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(926, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 19)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "DATE"
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.MistyRose
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(21, 14)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(104, 58)
        Me.btn_back.TabIndex = 9
        Me.btn_back.Text = "MAIN MENU"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.Maroon
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.Location = New System.Drawing.Point(21, 436)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(104, 49)
        Me.btn_exit.TabIndex = 8
        Me.btn_exit.Text = "EXIT"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_title.Font = New System.Drawing.Font("Tahoma", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(580, 67)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(319, 34)
        Me.lbl_title.TabIndex = 90
        Me.lbl_title.Text = "BYTE BLAST INVOICE"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Sienna
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(18, 626)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1305, 68)
        Me.Panel2.TabIndex = 89
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.prj_ByteBlast_A200321.My.Resources.Resources.footer
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(559, 23)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(242, 24)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btn_back)
        Me.Panel1.Controls.Add(Me.btn_exit)
        Me.Panel1.Location = New System.Drawing.Point(18, 120)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(138, 500)
        Me.Panel1.TabIndex = 88
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MistyRose
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(17, 221)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 58)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lst_orderID
        '
        Me.lst_orderID.FormattingEnabled = True
        Me.lst_orderID.ItemHeight = 16
        Me.lst_orderID.Location = New System.Drawing.Point(162, 120)
        Me.lst_orderID.Name = "lst_orderID"
        Me.lst_orderID.Size = New System.Drawing.Size(139, 116)
        Me.lst_orderID.TabIndex = 121
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(652, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 51)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "Phone: 013-44776654" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Email: byteBlast@gmail.com" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cyberjaya, Selangor, MY"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grd_invoice
        '
        Me.grd_invoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_invoice.Location = New System.Drawing.Point(162, 242)
        Me.grd_invoice.Name = "grd_invoice"
        Me.grd_invoice.RowHeadersWidth = 51
        Me.grd_invoice.RowTemplate.Height = 24
        Me.grd_invoice.Size = New System.Drawing.Size(1142, 203)
        Me.grd_invoice.TabIndex = 123
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(607, 588)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(230, 17)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "THANK YOU FOR CHOOSING US! "
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.prj_ByteBlast_A200321.My.Resources.Resources.logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(-6, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(301, 110)
        Me.PictureBox1.TabIndex = 87
        Me.PictureBox1.TabStop = False
        '
        'frm_invoice_A200321
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1316, 698)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grd_invoice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lst_orderID)
        Me.Controls.Add(Me.txt_subtotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_custName)
        Me.Controls.Add(Me.txt_custID)
        Me.Controls.Add(Me.txt_staffName)
        Me.Controls.Add(Me.txt_staffID)
        Me.Controls.Add(Me.lbl_orderDt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frm_invoice_A200321"
        Me.Text = "INVOICE - BYTE BLAST SHOP"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.grd_invoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_subtotal As TextBox
    Private WithEvents Label4 As Label
    Private WithEvents Label11 As Label
    Private WithEvents Label10 As Label
    Private WithEvents Label9 As Label
    Private WithEvents Label8 As Label
    Friend WithEvents txt_custName As TextBox
    Friend WithEvents txt_custID As TextBox
    Friend WithEvents txt_staffName As TextBox
    Friend WithEvents txt_staffID As TextBox
    Friend WithEvents lbl_orderDt As TextBox
    Private WithEvents Label3 As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lst_orderID As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grd_invoice As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
