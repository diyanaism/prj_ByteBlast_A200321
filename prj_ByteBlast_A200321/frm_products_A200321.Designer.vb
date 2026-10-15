<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_products_A200321
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btnInsert_update = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.pic_product = New System.Windows.Forms.PictureBox()
        Me.lst_productname = New System.Windows.Forms.ListBox()
        Me.lbl_prodcapacity = New System.Windows.Forms.Label()
        Me.txt_prodcapacity = New System.Windows.Forms.TextBox()
        Me.lbl_prodwarranty = New System.Windows.Forms.Label()
        Me.txt_prodwarranty = New System.Windows.Forms.TextBox()
        Me.lbl_proddevice = New System.Windows.Forms.Label()
        Me.txt_device = New System.Windows.Forms.TextBox()
        Me.lbl_produc = New System.Windows.Forms.Label()
        Me.txt_produc = New System.Windows.Forms.TextBox()
        Me.lbl_prodtype = New System.Windows.Forms.Label()
        Me.txt_prodtype = New System.Windows.Forms.TextBox()
        Me.lbl_prodprice = New System.Windows.Forms.Label()
        Me.txt_prodprice = New System.Windows.Forms.TextBox()
        Me.lbl_productnm = New System.Windows.Forms.Label()
        Me.txt_prodname = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Sienna
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(-11, 503)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1067, 59)
        Me.Panel2.TabIndex = 4
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_delete)
        Me.Panel1.Controls.Add(Me.btnInsert_update)
        Me.Panel1.Controls.Add(Me.btn_back)
        Me.Panel1.Controls.Add(Me.btn_exit)
        Me.Panel1.Location = New System.Drawing.Point(4, 113)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(147, 384)
        Me.Panel1.TabIndex = 6
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.OrangeRed
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(8, 213)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(123, 58)
        Me.btn_delete.TabIndex = 11
        Me.btn_delete.Text = "UPDATE PRODUCT"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btnInsert_update
        '
        Me.btnInsert_update.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnInsert_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInsert_update.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsert_update.Location = New System.Drawing.Point(8, 111)
        Me.btnInsert_update.Name = "btnInsert_update"
        Me.btnInsert_update.Size = New System.Drawing.Size(123, 58)
        Me.btnInsert_update.TabIndex = 10
        Me.btnInsert_update.Text = "INSERT PRODUCT"
        Me.btnInsert_update.UseVisualStyleBackColor = False
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.MistyRose
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(8, 14)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(123, 58)
        Me.btn_back.TabIndex = 9
        Me.btn_back.Text = "MAIN MENU"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.Maroon
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.Location = New System.Drawing.Point(8, 319)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(123, 49)
        Me.btn_exit.TabIndex = 8
        Me.btn_exit.Text = "EXIT"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.prj_ByteBlast_A200321.My.Resources.Resources.logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(-26, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(301, 110)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(489, 113)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(416, 22)
        Me.txt_search.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(253, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Input product name to search"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_title.Font = New System.Drawing.Font("Tahoma", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(463, 61)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(226, 34)
        Me.lbl_title.TabIndex = 15
        Me.lbl_title.Text = "PRODUCT LIST"
        '
        'pic_product
        '
        Me.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_product.Location = New System.Drawing.Point(799, 296)
        Me.pic_product.Name = "pic_product"
        Me.pic_product.Size = New System.Drawing.Size(245, 201)
        Me.pic_product.TabIndex = 16
        Me.pic_product.TabStop = False
        '
        'lst_productname
        '
        Me.lst_productname.FormattingEnabled = True
        Me.lst_productname.ItemHeight = 16
        Me.lst_productname.Location = New System.Drawing.Point(157, 142)
        Me.lst_productname.Name = "lst_productname"
        Me.lst_productname.Size = New System.Drawing.Size(887, 148)
        Me.lst_productname.TabIndex = 17
        '
        'lbl_prodcapacity
        '
        Me.lbl_prodcapacity.AutoSize = True
        Me.lbl_prodcapacity.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prodcapacity.Location = New System.Drawing.Point(616, 319)
        Me.lbl_prodcapacity.Name = "lbl_prodcapacity"
        Me.lbl_prodcapacity.Size = New System.Drawing.Size(81, 19)
        Me.lbl_prodcapacity.TabIndex = 60
        Me.lbl_prodcapacity.Text = "CAPACITY"
        '
        'txt_prodcapacity
        '
        Me.txt_prodcapacity.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_prodcapacity.Location = New System.Drawing.Point(619, 346)
        Me.txt_prodcapacity.Name = "txt_prodcapacity"
        Me.txt_prodcapacity.ReadOnly = True
        Me.txt_prodcapacity.Size = New System.Drawing.Size(125, 22)
        Me.txt_prodcapacity.TabIndex = 59
        '
        'lbl_prodwarranty
        '
        Me.lbl_prodwarranty.AutoSize = True
        Me.lbl_prodwarranty.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prodwarranty.Location = New System.Drawing.Point(485, 420)
        Me.lbl_prodwarranty.Name = "lbl_prodwarranty"
        Me.lbl_prodwarranty.Size = New System.Drawing.Size(96, 19)
        Me.lbl_prodwarranty.TabIndex = 58
        Me.lbl_prodwarranty.Text = "WARRANTY"
        '
        'txt_prodwarranty
        '
        Me.txt_prodwarranty.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_prodwarranty.Location = New System.Drawing.Point(488, 447)
        Me.txt_prodwarranty.Name = "txt_prodwarranty"
        Me.txt_prodwarranty.ReadOnly = True
        Me.txt_prodwarranty.Size = New System.Drawing.Size(100, 22)
        Me.txt_prodwarranty.TabIndex = 57
        '
        'lbl_proddevice
        '
        Me.lbl_proddevice.AutoSize = True
        Me.lbl_proddevice.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_proddevice.Location = New System.Drawing.Point(325, 420)
        Me.lbl_proddevice.Name = "lbl_proddevice"
        Me.lbl_proddevice.Size = New System.Drawing.Size(60, 19)
        Me.lbl_proddevice.TabIndex = 56
        Me.lbl_proddevice.Text = "DEVICE"
        '
        'txt_device
        '
        Me.txt_device.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_device.Location = New System.Drawing.Point(328, 447)
        Me.txt_device.Name = "txt_device"
        Me.txt_device.ReadOnly = True
        Me.txt_device.Size = New System.Drawing.Size(118, 22)
        Me.txt_device.TabIndex = 55
        '
        'lbl_produc
        '
        Me.lbl_produc.AutoSize = True
        Me.lbl_produc.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_produc.Location = New System.Drawing.Point(152, 420)
        Me.lbl_produc.Name = "lbl_produc"
        Me.lbl_produc.Size = New System.Drawing.Size(76, 19)
        Me.lbl_produc.TabIndex = 54
        Me.lbl_produc.Text = "USE CASE"
        '
        'txt_produc
        '
        Me.txt_produc.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_produc.Location = New System.Drawing.Point(155, 447)
        Me.txt_produc.Name = "txt_produc"
        Me.txt_produc.ReadOnly = True
        Me.txt_produc.Size = New System.Drawing.Size(126, 22)
        Me.txt_produc.TabIndex = 53
        '
        'lbl_prodtype
        '
        Me.lbl_prodtype.AutoSize = True
        Me.lbl_prodtype.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prodtype.Location = New System.Drawing.Point(616, 420)
        Me.lbl_prodtype.Name = "lbl_prodtype"
        Me.lbl_prodtype.Size = New System.Drawing.Size(44, 19)
        Me.lbl_prodtype.TabIndex = 52
        Me.lbl_prodtype.Text = "TYPE"
        '
        'txt_prodtype
        '
        Me.txt_prodtype.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_prodtype.Location = New System.Drawing.Point(619, 447)
        Me.txt_prodtype.Name = "txt_prodtype"
        Me.txt_prodtype.ReadOnly = True
        Me.txt_prodtype.Size = New System.Drawing.Size(125, 22)
        Me.txt_prodtype.TabIndex = 51
        '
        'lbl_prodprice
        '
        Me.lbl_prodprice.AutoSize = True
        Me.lbl_prodprice.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prodprice.Location = New System.Drawing.Point(486, 319)
        Me.lbl_prodprice.Name = "lbl_prodprice"
        Me.lbl_prodprice.Size = New System.Drawing.Size(88, 19)
        Me.lbl_prodprice.TabIndex = 50
        Me.lbl_prodprice.Text = "PRICE (RM)"
        '
        'txt_prodprice
        '
        Me.txt_prodprice.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_prodprice.Location = New System.Drawing.Point(489, 346)
        Me.txt_prodprice.Name = "txt_prodprice"
        Me.txt_prodprice.ReadOnly = True
        Me.txt_prodprice.Size = New System.Drawing.Size(99, 22)
        Me.txt_prodprice.TabIndex = 49
        '
        'lbl_productnm
        '
        Me.lbl_productnm.AutoSize = True
        Me.lbl_productnm.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_productnm.Location = New System.Drawing.Point(153, 319)
        Me.lbl_productnm.Name = "lbl_productnm"
        Me.lbl_productnm.Size = New System.Drawing.Size(54, 19)
        Me.lbl_productnm.TabIndex = 48
        Me.lbl_productnm.Text = "NAME"
        '
        'txt_prodname
        '
        Me.txt_prodname.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_prodname.Location = New System.Drawing.Point(156, 346)
        Me.txt_prodname.Name = "txt_prodname"
        Me.txt_prodname.ReadOnly = True
        Me.txt_prodname.Size = New System.Drawing.Size(308, 22)
        Me.txt_prodname.TabIndex = 47
        '
        'frm_products_A200321
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 558)
        Me.Controls.Add(Me.lbl_prodcapacity)
        Me.Controls.Add(Me.txt_prodcapacity)
        Me.Controls.Add(Me.lbl_prodwarranty)
        Me.Controls.Add(Me.txt_prodwarranty)
        Me.Controls.Add(Me.lbl_proddevice)
        Me.Controls.Add(Me.txt_device)
        Me.Controls.Add(Me.lbl_produc)
        Me.Controls.Add(Me.txt_produc)
        Me.Controls.Add(Me.lbl_prodtype)
        Me.Controls.Add(Me.txt_prodtype)
        Me.Controls.Add(Me.lbl_prodprice)
        Me.Controls.Add(Me.txt_prodprice)
        Me.Controls.Add(Me.lbl_productnm)
        Me.Controls.Add(Me.txt_prodname)
        Me.Controls.Add(Me.lst_productname)
        Me.Controls.Add(Me.pic_product)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frm_products_A200321"
        Me.Text = "BYTE BLAST - PRODUCT LIST"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btnInsert_update As Button
    Friend WithEvents txt_search As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_title As Label
    Friend WithEvents pic_product As PictureBox
    Friend WithEvents lst_productname As ListBox
    Private WithEvents lbl_prodcapacity As Label
    Friend WithEvents txt_prodcapacity As TextBox
    Private WithEvents lbl_prodwarranty As Label
    Friend WithEvents txt_prodwarranty As TextBox
    Private WithEvents lbl_proddevice As Label
    Friend WithEvents txt_device As TextBox
    Private WithEvents lbl_produc As Label
    Friend WithEvents txt_produc As TextBox
    Private WithEvents lbl_prodtype As Label
    Friend WithEvents txt_prodtype As TextBox
    Private WithEvents lbl_prodprice As Label
    Friend WithEvents txt_prodprice As TextBox
    Private WithEvents lbl_productnm As Label
    Friend WithEvents txt_prodname As TextBox
End Class
