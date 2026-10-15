<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_insertstaff_A200321
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
        Me.lbl_prodcapacity = New System.Windows.Forms.Label()
        Me.txt_staffposition = New System.Windows.Forms.TextBox()
        Me.lbl_prodwarranty = New System.Windows.Forms.Label()
        Me.txt_staffage = New System.Windows.Forms.TextBox()
        Me.lbl_proddevice = New System.Windows.Forms.Label()
        Me.txt_staffname = New System.Windows.Forms.TextBox()
        Me.lbl_produc = New System.Windows.Forms.Label()
        Me.txt_staffid = New System.Windows.Forms.TextBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.grd_staff = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_prodcapacity
        '
        Me.lbl_prodcapacity.AutoSize = True
        Me.lbl_prodcapacity.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prodcapacity.Location = New System.Drawing.Point(654, 419)
        Me.lbl_prodcapacity.Name = "lbl_prodcapacity"
        Me.lbl_prodcapacity.Size = New System.Drawing.Size(79, 19)
        Me.lbl_prodcapacity.TabIndex = 52
        Me.lbl_prodcapacity.Text = "POSITION"
        '
        'txt_staffposition
        '
        Me.txt_staffposition.Location = New System.Drawing.Point(657, 446)
        Me.txt_staffposition.Name = "txt_staffposition"
        Me.txt_staffposition.Size = New System.Drawing.Size(152, 22)
        Me.txt_staffposition.TabIndex = 51
        '
        'lbl_prodwarranty
        '
        Me.lbl_prodwarranty.AutoSize = True
        Me.lbl_prodwarranty.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prodwarranty.Location = New System.Drawing.Point(480, 419)
        Me.lbl_prodwarranty.Name = "lbl_prodwarranty"
        Me.lbl_prodwarranty.Size = New System.Drawing.Size(39, 19)
        Me.lbl_prodwarranty.TabIndex = 50
        Me.lbl_prodwarranty.Text = "AGE"
        '
        'txt_staffage
        '
        Me.txt_staffage.Location = New System.Drawing.Point(483, 446)
        Me.txt_staffage.Name = "txt_staffage"
        Me.txt_staffage.Size = New System.Drawing.Size(144, 22)
        Me.txt_staffage.TabIndex = 49
        '
        'lbl_proddevice
        '
        Me.lbl_proddevice.AutoSize = True
        Me.lbl_proddevice.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_proddevice.Location = New System.Drawing.Point(317, 419)
        Me.lbl_proddevice.Name = "lbl_proddevice"
        Me.lbl_proddevice.Size = New System.Drawing.Size(54, 19)
        Me.lbl_proddevice.TabIndex = 48
        Me.lbl_proddevice.Text = "NAME"
        '
        'txt_staffname
        '
        Me.txt_staffname.Location = New System.Drawing.Point(320, 446)
        Me.txt_staffname.Name = "txt_staffname"
        Me.txt_staffname.Size = New System.Drawing.Size(131, 22)
        Me.txt_staffname.TabIndex = 47
        '
        'lbl_produc
        '
        Me.lbl_produc.AutoSize = True
        Me.lbl_produc.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_produc.Location = New System.Drawing.Point(141, 419)
        Me.lbl_produc.Name = "lbl_produc"
        Me.lbl_produc.Size = New System.Drawing.Size(73, 19)
        Me.lbl_produc.TabIndex = 46
        Me.lbl_produc.Text = "STAFF ID"
        '
        'txt_staffid
        '
        Me.txt_staffid.Location = New System.Drawing.Point(144, 446)
        Me.txt_staffid.Name = "txt_staffid"
        Me.txt_staffid.ReadOnly = True
        Me.txt_staffid.Size = New System.Drawing.Size(147, 22)
        Me.txt_staffid.TabIndex = 45
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_title.Font = New System.Drawing.Font("Tahoma", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(395, 72)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(217, 34)
        Me.lbl_title.TabIndex = 38
        Me.lbl_title.Text = "INSERT STAFF"
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.LightPink
        Me.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_insert.Location = New System.Drawing.Point(852, 409)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(125, 59)
        Me.btn_insert.TabIndex = 35
        Me.btn_insert.Text = "INSERT"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'grd_staff
        '
        Me.grd_staff.AllowUserToAddRows = False
        Me.grd_staff.AllowUserToDeleteRows = False
        Me.grd_staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_staff.BackgroundColor = System.Drawing.SystemColors.Control
        Me.grd_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_staff.Location = New System.Drawing.Point(143, 112)
        Me.grd_staff.Name = "grd_staff"
        Me.grd_staff.ReadOnly = True
        Me.grd_staff.RowHeadersWidth = 51
        Me.grd_staff.RowTemplate.Height = 24
        Me.grd_staff.Size = New System.Drawing.Size(859, 254)
        Me.grd_staff.TabIndex = 34
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Sienna
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(-5, 502)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1025, 59)
        Me.Panel2.TabIndex = 33
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
        Me.Panel1.Controls.Add(Me.btn_back)
        Me.Panel1.Controls.Add(Me.btn_exit)
        Me.Panel1.Location = New System.Drawing.Point(-1, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(138, 384)
        Me.Panel1.TabIndex = 32
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
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.prj_ByteBlast_A200321.My.Resources.Resources.logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(-32, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(301, 110)
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'frm_insertstaff_A200321
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 556)
        Me.Controls.Add(Me.lbl_prodcapacity)
        Me.Controls.Add(Me.txt_staffposition)
        Me.Controls.Add(Me.lbl_prodwarranty)
        Me.Controls.Add(Me.txt_staffage)
        Me.Controls.Add(Me.lbl_proddevice)
        Me.Controls.Add(Me.txt_staffname)
        Me.Controls.Add(Me.lbl_produc)
        Me.Controls.Add(Me.txt_staffid)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.grd_staff)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frm_insertstaff_A200321"
        Me.Text = "INSERT STAFF - BYTE  BLAST SHOP"
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lbl_prodcapacity As Label
    Friend WithEvents txt_staffposition As TextBox
    Private WithEvents lbl_prodwarranty As Label
    Friend WithEvents txt_staffage As TextBox
    Private WithEvents lbl_proddevice As Label
    Friend WithEvents txt_staffname As TextBox
    Private WithEvents lbl_produc As Label
    Friend WithEvents txt_staffid As TextBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_insert As Button
    Friend WithEvents grd_staff As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
