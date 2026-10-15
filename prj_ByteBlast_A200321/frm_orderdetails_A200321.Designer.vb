<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_orderdetails_A200321
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.grd_product = New System.Windows.Forms.DataGridView()
        Me.lbl_prodwarranty = New System.Windows.Forms.Label()
        Me.txt_prodwarranty = New System.Windows.Forms.TextBox()
        Me.lbl_prodprice = New System.Windows.Forms.Label()
        Me.txt_prodprice = New System.Windows.Forms.TextBox()
        Me.lbl_productnm = New System.Windows.Forms.Label()
        Me.txt_prodname = New System.Windows.Forms.TextBox()
        Me.lbl_productID = New System.Windows.Forms.Label()
        Me.txt_prodid = New System.Windows.Forms.TextBox()
        Me.txt_orderID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_date = New System.Windows.Forms.TextBox()
        Me.txt_custName = New System.Windows.Forms.TextBox()
        Me.txt_custID = New System.Windows.Forms.TextBox()
        Me.txt_staffName = New System.Windows.Forms.TextBox()
        Me.txt_staffID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.grd_order = New System.Windows.Forms.DataGridView()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btn_back)
        Me.Panel1.Controls.Add(Me.btn_exit)
        Me.Panel1.Location = New System.Drawing.Point(2, 109)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(138, 500)
        Me.Panel1.TabIndex = 13
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
        Me.btn_back.Text = "BACK"
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Sienna
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(2, 615)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1305, 68)
        Me.Panel2.TabIndex = 14
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
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_title.Font = New System.Drawing.Font("Tahoma", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(507, 59)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(389, 34)
        Me.lbl_title.TabIndex = 19
        Me.lbl_title.Text = "BYTE BLAST PLACE ORDER"
        '
        'grd_product
        '
        Me.grd_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_product.Location = New System.Drawing.Point(146, 109)
        Me.grd_product.Name = "grd_product"
        Me.grd_product.RowHeadersWidth = 51
        Me.grd_product.RowTemplate.Height = 24
        Me.grd_product.Size = New System.Drawing.Size(1141, 120)
        Me.grd_product.TabIndex = 20
        '
        'lbl_prodwarranty
        '
        Me.lbl_prodwarranty.AutoSize = True
        Me.lbl_prodwarranty.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prodwarranty.Location = New System.Drawing.Point(146, 401)
        Me.lbl_prodwarranty.Name = "lbl_prodwarranty"
        Me.lbl_prodwarranty.Size = New System.Drawing.Size(170, 19)
        Me.lbl_prodwarranty.TabIndex = 58
        Me.lbl_prodwarranty.Text = "PRODUCT WARRANTY"
        '
        'txt_prodwarranty
        '
        Me.txt_prodwarranty.Location = New System.Drawing.Point(327, 398)
        Me.txt_prodwarranty.Name = "txt_prodwarranty"
        Me.txt_prodwarranty.Size = New System.Drawing.Size(185, 22)
        Me.txt_prodwarranty.TabIndex = 57
        '
        'lbl_prodprice
        '
        Me.lbl_prodprice.AutoSize = True
        Me.lbl_prodprice.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prodprice.Location = New System.Drawing.Point(146, 359)
        Me.lbl_prodprice.Name = "lbl_prodprice"
        Me.lbl_prodprice.Size = New System.Drawing.Size(124, 19)
        Me.lbl_prodprice.TabIndex = 50
        Me.lbl_prodprice.Text = "PRODUCT PRICE"
        '
        'txt_prodprice
        '
        Me.txt_prodprice.Location = New System.Drawing.Point(292, 358)
        Me.txt_prodprice.Name = "txt_prodprice"
        Me.txt_prodprice.Size = New System.Drawing.Size(220, 22)
        Me.txt_prodprice.TabIndex = 49
        '
        'lbl_productnm
        '
        Me.lbl_productnm.AutoSize = True
        Me.lbl_productnm.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productnm.Location = New System.Drawing.Point(146, 317)
        Me.lbl_productnm.Name = "lbl_productnm"
        Me.lbl_productnm.Size = New System.Drawing.Size(128, 19)
        Me.lbl_productnm.TabIndex = 48
        Me.lbl_productnm.Text = "PRODUCT NAME"
        '
        'txt_prodname
        '
        Me.txt_prodname.Location = New System.Drawing.Point(292, 317)
        Me.txt_prodname.Name = "txt_prodname"
        Me.txt_prodname.Size = New System.Drawing.Size(220, 22)
        Me.txt_prodname.TabIndex = 47
        '
        'lbl_productID
        '
        Me.lbl_productID.AutoSize = True
        Me.lbl_productID.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productID.Location = New System.Drawing.Point(146, 276)
        Me.lbl_productID.Name = "lbl_productID"
        Me.lbl_productID.Size = New System.Drawing.Size(99, 19)
        Me.lbl_productID.TabIndex = 46
        Me.lbl_productID.Text = "PRODUCT ID"
        '
        'txt_prodid
        '
        Me.txt_prodid.Location = New System.Drawing.Point(292, 277)
        Me.txt_prodid.Name = "txt_prodid"
        Me.txt_prodid.ReadOnly = True
        Me.txt_prodid.Size = New System.Drawing.Size(213, 22)
        Me.txt_prodid.TabIndex = 45
        '
        'txt_orderID
        '
        Me.txt_orderID.Location = New System.Drawing.Point(292, 239)
        Me.txt_orderID.Name = "txt_orderID"
        Me.txt_orderID.ReadOnly = True
        Me.txt_orderID.Size = New System.Drawing.Size(213, 22)
        Me.txt_orderID.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(146, 239)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 19)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "ORDER ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(526, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 19)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "QUANTITY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(909, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 19)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "DATE"
        '
        'txt_date
        '
        Me.txt_date.Location = New System.Drawing.Point(1067, 238)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.ReadOnly = True
        Me.txt_date.Size = New System.Drawing.Size(220, 22)
        Me.txt_date.TabIndex = 66
        '
        'txt_custName
        '
        Me.txt_custName.Location = New System.Drawing.Point(674, 399)
        Me.txt_custName.Name = "txt_custName"
        Me.txt_custName.ReadOnly = True
        Me.txt_custName.Size = New System.Drawing.Size(185, 22)
        Me.txt_custName.TabIndex = 74
        '
        'txt_custID
        '
        Me.txt_custID.Location = New System.Drawing.Point(674, 359)
        Me.txt_custID.Name = "txt_custID"
        Me.txt_custID.ReadOnly = True
        Me.txt_custID.Size = New System.Drawing.Size(185, 22)
        Me.txt_custID.TabIndex = 72
        '
        'txt_staffName
        '
        Me.txt_staffName.Location = New System.Drawing.Point(674, 320)
        Me.txt_staffName.Name = "txt_staffName"
        Me.txt_staffName.ReadOnly = True
        Me.txt_staffName.Size = New System.Drawing.Size(185, 22)
        Me.txt_staffName.TabIndex = 70
        '
        'txt_staffID
        '
        Me.txt_staffID.Location = New System.Drawing.Point(674, 275)
        Me.txt_staffID.Name = "txt_staffID"
        Me.txt_staffID.ReadOnly = True
        Me.txt_staffID.Size = New System.Drawing.Size(185, 22)
        Me.txt_staffID.TabIndex = 68
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(526, 362)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 19)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "CUSTOMER ID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(526, 319)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 19)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "STAFF NAME"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(526, 281)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 19)
        Me.Label11.TabIndex = 78
        Me.Label11.Text = "STAFF ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(526, 402)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 19)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "CUSTOMER NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(909, 288)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 19)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "SUBTOTAL (RM): "
        '
        'txt_subtotal
        '
        Me.txt_subtotal.Location = New System.Drawing.Point(913, 320)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.ReadOnly = True
        Me.txt_subtotal.Size = New System.Drawing.Size(175, 22)
        Me.txt_subtotal.TabIndex = 80
        '
        'btn_reset
        '
        Me.btn_reset.Location = New System.Drawing.Point(1148, 293)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(139, 48)
        Me.btn_reset.TabIndex = 81
        Me.btn_reset.Text = "RESET"
        Me.btn_reset.UseVisualStyleBackColor = True
        '
        'btn_insert
        '
        Me.btn_insert.Location = New System.Drawing.Point(1148, 359)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(139, 48)
        Me.btn_insert.TabIndex = 82
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'txt_qty
        '
        Me.txt_qty.Location = New System.Drawing.Point(674, 239)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(185, 22)
        Me.txt_qty.TabIndex = 83
        '
        'grd_order
        '
        Me.grd_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_order.Location = New System.Drawing.Point(146, 437)
        Me.grd_order.Name = "grd_order"
        Me.grd_order.RowHeadersWidth = 51
        Me.grd_order.RowTemplate.Height = 24
        Me.grd_order.Size = New System.Drawing.Size(1141, 126)
        Me.grd_order.TabIndex = 84
        '
        'btn_confirm
        '
        Me.btn_confirm.Location = New System.Drawing.Point(720, 569)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(139, 36)
        Me.btn_confirm.TabIndex = 86
        Me.btn_confirm.Text = "CONFIRM"
        Me.btn_confirm.UseVisualStyleBackColor = True
        '
        'btn_remove
        '
        Me.btn_remove.Location = New System.Drawing.Point(545, 569)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(139, 36)
        Me.btn_remove.TabIndex = 85
        Me.btn_remove.Text = "REMOVE"
        Me.btn_remove.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.prj_ByteBlast_A200321.My.Resources.Resources.logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(-22, -7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(301, 110)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MistyRose
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(17, 221)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 58)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "ORDER PAGE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frm_orderdetails_A200321
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1299, 674)
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.btn_remove)
        Me.Controls.Add(Me.grd_order)
        Me.Controls.Add(Me.txt_qty)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.btn_reset)
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
        Me.Controls.Add(Me.txt_date)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_orderID)
        Me.Controls.Add(Me.lbl_prodwarranty)
        Me.Controls.Add(Me.txt_prodwarranty)
        Me.Controls.Add(Me.lbl_prodprice)
        Me.Controls.Add(Me.txt_prodprice)
        Me.Controls.Add(Me.lbl_productnm)
        Me.Controls.Add(Me.txt_prodname)
        Me.Controls.Add(Me.lbl_productID)
        Me.Controls.Add(Me.txt_prodid)
        Me.Controls.Add(Me.grd_product)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frm_orderdetails_A200321"
        Me.Text = "PLACE ORDER - BYTE BLAST SHOP"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents grd_product As DataGridView
    Private WithEvents lbl_prodwarranty As Label
    Friend WithEvents txt_prodwarranty As TextBox
    Private WithEvents lbl_prodprice As Label
    Friend WithEvents txt_prodprice As TextBox
    Private WithEvents lbl_productnm As Label
    Friend WithEvents txt_prodname As TextBox
    Private WithEvents lbl_productID As Label
    Friend WithEvents txt_prodid As TextBox
    Friend WithEvents txt_orderID As TextBox
    Private WithEvents Label1 As Label
    Private WithEvents Label2 As Label
    Private WithEvents Label3 As Label
    Friend WithEvents txt_date As TextBox
    Friend WithEvents txt_custName As TextBox
    Friend WithEvents txt_custID As TextBox
    Friend WithEvents txt_staffName As TextBox
    Friend WithEvents txt_staffID As TextBox
    Private WithEvents Label9 As Label
    Private WithEvents Label10 As Label
    Private WithEvents Label11 As Label
    Private WithEvents Label8 As Label
    Private WithEvents Label4 As Label
    Friend WithEvents txt_subtotal As TextBox
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents txt_qty As TextBox
    Friend WithEvents grd_order As DataGridView
    Friend WithEvents btn_confirm As Button
    Friend WithEvents btn_remove As Button
    Friend WithEvents Button1 As Button
End Class
