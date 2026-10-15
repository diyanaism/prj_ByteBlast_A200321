<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_updateproduct_A200321
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.grd_product = New System.Windows.Forms.DataGridView()
        Me.lbl_prodcapacity = New System.Windows.Forms.Label()
        Me.txt_prodcapacity = New System.Windows.Forms.TextBox()
        Me.lbl_prodwarranty = New System.Windows.Forms.Label()
        Me.txt_prodwarranty = New System.Windows.Forms.TextBox()
        Me.lbl_proddevice = New System.Windows.Forms.Label()
        Me.txt_proddevice = New System.Windows.Forms.TextBox()
        Me.lbl_produc = New System.Windows.Forms.Label()
        Me.txt_produc = New System.Windows.Forms.TextBox()
        Me.lbl_prodtype = New System.Windows.Forms.Label()
        Me.txt_prodtype = New System.Windows.Forms.TextBox()
        Me.lbl_prodprice = New System.Windows.Forms.Label()
        Me.txt_prodprice = New System.Windows.Forms.TextBox()
        Me.lbl_productnm = New System.Windows.Forms.Label()
        Me.txt_prodname = New System.Windows.Forms.TextBox()
        Me.lbl_productID = New System.Windows.Forms.Label()
        Me.txt_prodid = New System.Windows.Forms.TextBox()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.prj_ByteBlast_A200321.My.Resources.Resources.logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(-32, -7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(301, 110)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_back)
        Me.Panel1.Controls.Add(Me.btn_exit)
        Me.Panel1.Location = New System.Drawing.Point(12, 109)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(138, 384)
        Me.Panel1.TabIndex = 8
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
        Me.btn_exit.Location = New System.Drawing.Point(21, 319)
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
        Me.Panel2.Location = New System.Drawing.Point(1, 499)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1085, 59)
        Me.Panel2.TabIndex = 9
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.prj_ByteBlast_A200321.My.Resources.Resources.footer
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(423, 19)
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
        Me.lbl_title.Location = New System.Drawing.Point(436, 69)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(347, 34)
        Me.lbl_title.TabIndex = 15
        Me.lbl_title.Text = "UPDATE PRODUCT LIST"
        '
        'grd_product
        '
        Me.grd_product.AllowUserToAddRows = False
        Me.grd_product.AllowUserToDeleteRows = False
        Me.grd_product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_product.BackgroundColor = System.Drawing.SystemColors.Control
        Me.grd_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_product.Location = New System.Drawing.Point(156, 109)
        Me.grd_product.Name = "grd_product"
        Me.grd_product.ReadOnly = True
        Me.grd_product.RowHeadersWidth = 51
        Me.grd_product.RowTemplate.Height = 24
        Me.grd_product.Size = New System.Drawing.Size(914, 196)
        Me.grd_product.TabIndex = 16
        '
        'lbl_prodcapacity
        '
        Me.lbl_prodcapacity.AutoSize = True
        Me.lbl_prodcapacity.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prodcapacity.Location = New System.Drawing.Point(707, 428)
        Me.lbl_prodcapacity.Name = "lbl_prodcapacity"
        Me.lbl_prodcapacity.Size = New System.Drawing.Size(155, 19)
        Me.lbl_prodcapacity.TabIndex = 44
        Me.lbl_prodcapacity.Text = "PRODUCT CAPACITY"
        '
        'txt_prodcapacity
        '
        Me.txt_prodcapacity.Location = New System.Drawing.Point(710, 455)
        Me.txt_prodcapacity.Name = "txt_prodcapacity"
        Me.txt_prodcapacity.Size = New System.Drawing.Size(152, 22)
        Me.txt_prodcapacity.TabIndex = 43
        '
        'lbl_prodwarranty
        '
        Me.lbl_prodwarranty.AutoSize = True
        Me.lbl_prodwarranty.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prodwarranty.Location = New System.Drawing.Point(513, 428)
        Me.lbl_prodwarranty.Name = "lbl_prodwarranty"
        Me.lbl_prodwarranty.Size = New System.Drawing.Size(170, 19)
        Me.lbl_prodwarranty.TabIndex = 42
        Me.lbl_prodwarranty.Text = "PRODUCT WARRANTY"
        '
        'txt_prodwarranty
        '
        Me.txt_prodwarranty.Location = New System.Drawing.Point(516, 455)
        Me.txt_prodwarranty.Name = "txt_prodwarranty"
        Me.txt_prodwarranty.Size = New System.Drawing.Size(167, 22)
        Me.txt_prodwarranty.TabIndex = 41
        '
        'lbl_proddevice
        '
        Me.lbl_proddevice.AutoSize = True
        Me.lbl_proddevice.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_proddevice.Location = New System.Drawing.Point(350, 428)
        Me.lbl_proddevice.Name = "lbl_proddevice"
        Me.lbl_proddevice.Size = New System.Drawing.Size(134, 19)
        Me.lbl_proddevice.TabIndex = 40
        Me.lbl_proddevice.Text = "PRODUCT DEVICE"
        '
        'txt_proddevice
        '
        Me.txt_proddevice.Location = New System.Drawing.Point(353, 455)
        Me.txt_proddevice.Name = "txt_proddevice"
        Me.txt_proddevice.Size = New System.Drawing.Size(131, 22)
        Me.txt_proddevice.TabIndex = 39
        '
        'lbl_produc
        '
        Me.lbl_produc.AutoSize = True
        Me.lbl_produc.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_produc.Location = New System.Drawing.Point(174, 428)
        Me.lbl_produc.Name = "lbl_produc"
        Me.lbl_produc.Size = New System.Drawing.Size(150, 19)
        Me.lbl_produc.TabIndex = 38
        Me.lbl_produc.Text = "PRODUCT USE CASE"
        '
        'txt_produc
        '
        Me.txt_produc.Location = New System.Drawing.Point(177, 455)
        Me.txt_produc.Name = "txt_produc"
        Me.txt_produc.Size = New System.Drawing.Size(147, 22)
        Me.txt_produc.TabIndex = 37
        '
        'lbl_prodtype
        '
        Me.lbl_prodtype.AutoSize = True
        Me.lbl_prodtype.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prodtype.Location = New System.Drawing.Point(708, 331)
        Me.lbl_prodtype.Name = "lbl_prodtype"
        Me.lbl_prodtype.Size = New System.Drawing.Size(118, 19)
        Me.lbl_prodtype.TabIndex = 36
        Me.lbl_prodtype.Text = "PRODUCT TYPE"
        '
        'txt_prodtype
        '
        Me.txt_prodtype.Location = New System.Drawing.Point(711, 358)
        Me.txt_prodtype.Name = "txt_prodtype"
        Me.txt_prodtype.Size = New System.Drawing.Size(152, 22)
        Me.txt_prodtype.TabIndex = 35
        '
        'lbl_prodprice
        '
        Me.lbl_prodprice.AutoSize = True
        Me.lbl_prodprice.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prodprice.Location = New System.Drawing.Point(513, 331)
        Me.lbl_prodprice.Name = "lbl_prodprice"
        Me.lbl_prodprice.Size = New System.Drawing.Size(124, 19)
        Me.lbl_prodprice.TabIndex = 34
        Me.lbl_prodprice.Text = "PRODUCT PRICE"
        '
        'txt_prodprice
        '
        Me.txt_prodprice.Location = New System.Drawing.Point(516, 358)
        Me.txt_prodprice.Name = "txt_prodprice"
        Me.txt_prodprice.Size = New System.Drawing.Size(167, 22)
        Me.txt_prodprice.TabIndex = 33
        '
        'lbl_productnm
        '
        Me.lbl_productnm.AutoSize = True
        Me.lbl_productnm.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productnm.Location = New System.Drawing.Point(349, 331)
        Me.lbl_productnm.Name = "lbl_productnm"
        Me.lbl_productnm.Size = New System.Drawing.Size(128, 19)
        Me.lbl_productnm.TabIndex = 32
        Me.lbl_productnm.Text = "PRODUCT NAME"
        '
        'txt_prodname
        '
        Me.txt_prodname.Location = New System.Drawing.Point(352, 358)
        Me.txt_prodname.Name = "txt_prodname"
        Me.txt_prodname.Size = New System.Drawing.Size(125, 22)
        Me.txt_prodname.TabIndex = 31
        '
        'lbl_productID
        '
        Me.lbl_productID.AutoSize = True
        Me.lbl_productID.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productID.Location = New System.Drawing.Point(173, 331)
        Me.lbl_productID.Name = "lbl_productID"
        Me.lbl_productID.Size = New System.Drawing.Size(99, 19)
        Me.lbl_productID.TabIndex = 30
        Me.lbl_productID.Text = "PRODUCT ID"
        '
        'txt_prodid
        '
        Me.txt_prodid.Location = New System.Drawing.Point(176, 358)
        Me.txt_prodid.Name = "txt_prodid"
        Me.txt_prodid.ReadOnly = True
        Me.txt_prodid.Size = New System.Drawing.Size(148, 22)
        Me.txt_prodid.TabIndex = 29
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.MintCream
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_update.Location = New System.Drawing.Point(926, 331)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(125, 59)
        Me.btn_update.TabIndex = 45
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_del
        '
        Me.btn_del.BackColor = System.Drawing.Color.LightCoral
        Me.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_del.Location = New System.Drawing.Point(926, 418)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(125, 59)
        Me.btn_del.TabIndex = 46
        Me.btn_del.Text = "DELETE"
        Me.btn_del.UseVisualStyleBackColor = False
        '
        'frm_updateproduct_A200321
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 559)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.lbl_prodcapacity)
        Me.Controls.Add(Me.txt_prodcapacity)
        Me.Controls.Add(Me.lbl_prodwarranty)
        Me.Controls.Add(Me.txt_prodwarranty)
        Me.Controls.Add(Me.lbl_proddevice)
        Me.Controls.Add(Me.txt_proddevice)
        Me.Controls.Add(Me.lbl_produc)
        Me.Controls.Add(Me.txt_produc)
        Me.Controls.Add(Me.lbl_prodtype)
        Me.Controls.Add(Me.txt_prodtype)
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
        Me.Name = "frm_updateproduct_A200321"
        Me.Text = "UPDATE PRODUCTS - BYTE  BLAST SHOP"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_product, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents lbl_prodcapacity As Label
    Friend WithEvents txt_prodcapacity As TextBox
    Private WithEvents lbl_prodwarranty As Label
    Friend WithEvents txt_prodwarranty As TextBox
    Private WithEvents lbl_proddevice As Label
    Friend WithEvents txt_proddevice As TextBox
    Private WithEvents lbl_produc As Label
    Friend WithEvents txt_produc As TextBox
    Private WithEvents lbl_prodtype As Label
    Friend WithEvents txt_prodtype As TextBox
    Private WithEvents lbl_prodprice As Label
    Friend WithEvents txt_prodprice As TextBox
    Private WithEvents lbl_productnm As Label
    Friend WithEvents txt_prodname As TextBox
    Private WithEvents lbl_productID As Label
    Friend WithEvents txt_prodid As TextBox
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_del As Button
End Class
