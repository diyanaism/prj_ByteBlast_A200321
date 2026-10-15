<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertCust_A200321
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
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.txt_custname = New System.Windows.Forms.TextBox()
        Me.lbl_prodtype = New System.Windows.Forms.Label()
        Me.txt_phoneno = New System.Windows.Forms.TextBox()
        Me.lbl_prodprice = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.lbl_address = New System.Windows.Forms.Label()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.lbl_custID = New System.Windows.Forms.Label()
        Me.txt_custid = New System.Windows.Forms.TextBox()
        Me.grd_cust = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_insert = New System.Windows.Forms.Button()
        CType(Me.grd_cust, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(185, 431)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(54, 19)
        Me.lbl_name.TabIndex = 61
        Me.lbl_name.Text = "NAME"
        '
        'txt_custname
        '
        Me.txt_custname.Location = New System.Drawing.Point(188, 458)
        Me.txt_custname.Name = "txt_custname"
        Me.txt_custname.Size = New System.Drawing.Size(147, 22)
        Me.txt_custname.TabIndex = 60
        '
        'lbl_prodtype
        '
        Me.lbl_prodtype.AutoSize = True
        Me.lbl_prodtype.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prodtype.Location = New System.Drawing.Point(674, 431)
        Me.lbl_prodtype.Name = "lbl_prodtype"
        Me.lbl_prodtype.Size = New System.Drawing.Size(88, 19)
        Me.lbl_prodtype.TabIndex = 59
        Me.lbl_prodtype.Text = "PHONE NO"
        '
        'txt_phoneno
        '
        Me.txt_phoneno.Location = New System.Drawing.Point(677, 458)
        Me.txt_phoneno.Name = "txt_phoneno"
        Me.txt_phoneno.Size = New System.Drawing.Size(152, 22)
        Me.txt_phoneno.TabIndex = 58
        '
        'lbl_prodprice
        '
        Me.lbl_prodprice.AutoSize = True
        Me.lbl_prodprice.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prodprice.Location = New System.Drawing.Point(373, 431)
        Me.lbl_prodprice.Name = "lbl_prodprice"
        Me.lbl_prodprice.Size = New System.Drawing.Size(55, 19)
        Me.lbl_prodprice.TabIndex = 57
        Me.lbl_prodprice.Text = "EMAIL"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(376, 458)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(196, 22)
        Me.txt_email.TabIndex = 56
        '
        'lbl_address
        '
        Me.lbl_address.AutoSize = True
        Me.lbl_address.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_address.Location = New System.Drawing.Point(372, 336)
        Me.lbl_address.Name = "lbl_address"
        Me.lbl_address.Size = New System.Drawing.Size(76, 19)
        Me.lbl_address.TabIndex = 55
        Me.lbl_address.Text = "ADDRESS"
        '
        'txt_address
        '
        Me.txt_address.Location = New System.Drawing.Point(375, 361)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(498, 22)
        Me.txt_address.TabIndex = 54
        '
        'lbl_custID
        '
        Me.lbl_custID.AutoSize = True
        Me.lbl_custID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_custID.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_custID.Location = New System.Drawing.Point(184, 334)
        Me.lbl_custID.Name = "lbl_custID"
        Me.lbl_custID.Size = New System.Drawing.Size(109, 19)
        Me.lbl_custID.TabIndex = 53
        Me.lbl_custID.Text = "CUSTOMER ID"
        '
        'txt_custid
        '
        Me.txt_custid.Location = New System.Drawing.Point(187, 361)
        Me.txt_custid.Name = "txt_custid"
        Me.txt_custid.ReadOnly = True
        Me.txt_custid.Size = New System.Drawing.Size(148, 22)
        Me.txt_custid.TabIndex = 52
        '
        'grd_cust
        '
        Me.grd_cust.AllowUserToAddRows = False
        Me.grd_cust.AllowUserToDeleteRows = False
        Me.grd_cust.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_cust.BackgroundColor = System.Drawing.SystemColors.Control
        Me.grd_cust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_cust.Location = New System.Drawing.Point(167, 112)
        Me.grd_cust.Name = "grd_cust"
        Me.grd_cust.ReadOnly = True
        Me.grd_cust.RowHeadersWidth = 51
        Me.grd_cust.RowTemplate.Height = 24
        Me.grd_cust.Size = New System.Drawing.Size(914, 196)
        Me.grd_cust.TabIndex = 51
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_back)
        Me.Panel1.Controls.Add(Me.btn_exit)
        Me.Panel1.Location = New System.Drawing.Point(23, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(138, 384)
        Me.Panel1.TabIndex = 48
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
        Me.Panel2.Location = New System.Drawing.Point(12, 502)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1085, 59)
        Me.Panel2.TabIndex = 49
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
        Me.lbl_title.Location = New System.Drawing.Point(429, 72)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(366, 34)
        Me.lbl_title.TabIndex = 50
        Me.lbl_title.Text = "INSERT NEW CUSTOMER"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.prj_ByteBlast_A200321.My.Resources.Resources.logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(-21, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(301, 110)
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.LightPink
        Me.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_insert.Location = New System.Drawing.Point(929, 391)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(125, 59)
        Me.btn_insert.TabIndex = 62
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'frm_insertCust_A200321
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1076, 556)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.txt_custname)
        Me.Controls.Add(Me.lbl_prodtype)
        Me.Controls.Add(Me.txt_phoneno)
        Me.Controls.Add(Me.lbl_prodprice)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.lbl_address)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.lbl_custID)
        Me.Controls.Add(Me.txt_custid)
        Me.Controls.Add(Me.grd_cust)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frm_insertCust_A200321"
        Me.Text = "INSERT CUSTOMER - BYTE  BLAST SHOP"
        CType(Me.grd_cust, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lbl_name As Label
    Friend WithEvents txt_custname As TextBox
    Private WithEvents lbl_prodtype As Label
    Friend WithEvents txt_phoneno As TextBox
    Private WithEvents lbl_prodprice As Label
    Friend WithEvents txt_email As TextBox
    Private WithEvents lbl_address As Label
    Friend WithEvents txt_address As TextBox
    Private WithEvents lbl_custID As Label
    Friend WithEvents txt_custid As TextBox
    Friend WithEvents grd_cust As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_insert As Button
End Class
