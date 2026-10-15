<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_updateStaff_A200321
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
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grd_staff = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_prodcapacity
        '
        Me.lbl_prodcapacity.AutoSize = True
        Me.lbl_prodcapacity.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prodcapacity.Location = New System.Drawing.Point(667, 420)
        Me.lbl_prodcapacity.Name = "lbl_prodcapacity"
        Me.lbl_prodcapacity.Size = New System.Drawing.Size(79, 19)
        Me.lbl_prodcapacity.TabIndex = 66
        Me.lbl_prodcapacity.Text = "POSITION"
        '
        'txt_staffposition
        '
        Me.txt_staffposition.Location = New System.Drawing.Point(670, 447)
        Me.txt_staffposition.Name = "txt_staffposition"
        Me.txt_staffposition.Size = New System.Drawing.Size(152, 22)
        Me.txt_staffposition.TabIndex = 65
        '
        'lbl_prodwarranty
        '
        Me.lbl_prodwarranty.AutoSize = True
        Me.lbl_prodwarranty.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prodwarranty.Location = New System.Drawing.Point(493, 420)
        Me.lbl_prodwarranty.Name = "lbl_prodwarranty"
        Me.lbl_prodwarranty.Size = New System.Drawing.Size(39, 19)
        Me.lbl_prodwarranty.TabIndex = 64
        Me.lbl_prodwarranty.Text = "AGE"
        '
        'txt_staffage
        '
        Me.txt_staffage.Location = New System.Drawing.Point(496, 447)
        Me.txt_staffage.Name = "txt_staffage"
        Me.txt_staffage.Size = New System.Drawing.Size(144, 22)
        Me.txt_staffage.TabIndex = 63
        '
        'lbl_proddevice
        '
        Me.lbl_proddevice.AutoSize = True
        Me.lbl_proddevice.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_proddevice.Location = New System.Drawing.Point(330, 420)
        Me.lbl_proddevice.Name = "lbl_proddevice"
        Me.lbl_proddevice.Size = New System.Drawing.Size(54, 19)
        Me.lbl_proddevice.TabIndex = 62
        Me.lbl_proddevice.Text = "NAME"
        '
        'txt_staffname
        '
        Me.txt_staffname.Location = New System.Drawing.Point(333, 447)
        Me.txt_staffname.Name = "txt_staffname"
        Me.txt_staffname.Size = New System.Drawing.Size(131, 22)
        Me.txt_staffname.TabIndex = 61
        '
        'lbl_produc
        '
        Me.lbl_produc.AutoSize = True
        Me.lbl_produc.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_produc.Location = New System.Drawing.Point(154, 420)
        Me.lbl_produc.Name = "lbl_produc"
        Me.lbl_produc.Size = New System.Drawing.Size(73, 19)
        Me.lbl_produc.TabIndex = 60
        Me.lbl_produc.Text = "STAFF ID"
        '
        'txt_staffid
        '
        Me.txt_staffid.Location = New System.Drawing.Point(157, 447)
        Me.txt_staffid.Name = "txt_staffid"
        Me.txt_staffid.ReadOnly = True
        Me.txt_staffid.Size = New System.Drawing.Size(147, 22)
        Me.txt_staffid.TabIndex = 59
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
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_title.Font = New System.Drawing.Font("Tahoma", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(408, 73)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(222, 34)
        Me.lbl_title.TabIndex = 58
        Me.lbl_title.Text = "UPDATE STAFF"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Sienna
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(8, 503)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1025, 59)
        Me.Panel2.TabIndex = 55
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
        Me.Panel1.Location = New System.Drawing.Point(12, 113)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(138, 384)
        Me.Panel1.TabIndex = 54
        '
        'grd_staff
        '
        Me.grd_staff.AllowUserToAddRows = False
        Me.grd_staff.AllowUserToDeleteRows = False
        Me.grd_staff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_staff.BackgroundColor = System.Drawing.SystemColors.Control
        Me.grd_staff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_staff.Location = New System.Drawing.Point(156, 113)
        Me.grd_staff.Name = "grd_staff"
        Me.grd_staff.ReadOnly = True
        Me.grd_staff.RowHeadersWidth = 51
        Me.grd_staff.RowTemplate.Height = 24
        Me.grd_staff.Size = New System.Drawing.Size(859, 254)
        Me.grd_staff.TabIndex = 56
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.prj_ByteBlast_A200321.My.Resources.Resources.logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(-19, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(301, 110)
        Me.PictureBox1.TabIndex = 53
        Me.PictureBox1.TabStop = False
        '
        'btn_del
        '
        Me.btn_del.BackColor = System.Drawing.Color.LightCoral
        Me.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_del.Location = New System.Drawing.Point(860, 449)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(125, 48)
        Me.btn_del.TabIndex = 68
        Me.btn_del.Text = "DELETE"
        Me.btn_del.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.MintCream
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_update.Location = New System.Drawing.Point(860, 391)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(125, 48)
        Me.btn_update.TabIndex = 67
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'frm_updateStaff_A200321
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 558)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.lbl_prodcapacity)
        Me.Controls.Add(Me.txt_staffposition)
        Me.Controls.Add(Me.lbl_prodwarranty)
        Me.Controls.Add(Me.txt_staffage)
        Me.Controls.Add(Me.lbl_proddevice)
        Me.Controls.Add(Me.txt_staffname)
        Me.Controls.Add(Me.lbl_produc)
        Me.Controls.Add(Me.txt_staffid)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grd_staff)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frm_updateStaff_A200321"
        Me.Text = "UPDATE STAFF - BYTE  BLAST SHOP"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.grd_staff, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents lbl_title As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents grd_staff As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_del As Button
    Friend WithEvents btn_update As Button
End Class
