<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_makeorder_A200321
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
        Me.grd_staffList = New System.Windows.Forms.DataGridView()
        Me.txt_orderID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grd_custList = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_staffID = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txt_custName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_custID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_staffName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_order = New System.Windows.Forms.Button()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_staffList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_custList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btn_back)
        Me.Panel1.Controls.Add(Me.btn_exit)
        Me.Panel1.Location = New System.Drawing.Point(3, 114)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(138, 377)
        Me.Panel1.TabIndex = 12
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
        Me.Panel2.Location = New System.Drawing.Point(3, 497)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1147, 59)
        Me.Panel2.TabIndex = 13
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.prj_ByteBlast_A200321.My.Resources.Resources.footer
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(473, 24)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(242, 24)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'grd_staffList
        '
        Me.grd_staffList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_staffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_staffList.Location = New System.Drawing.Point(147, 141)
        Me.grd_staffList.Name = "grd_staffList"
        Me.grd_staffList.ReadOnly = True
        Me.grd_staffList.RowHeadersWidth = 51
        Me.grd_staffList.RowTemplate.Height = 24
        Me.grd_staffList.Size = New System.Drawing.Size(585, 150)
        Me.grd_staffList.TabIndex = 14
        '
        'txt_orderID
        '
        Me.txt_orderID.Location = New System.Drawing.Point(287, 10)
        Me.txt_orderID.Name = "txt_orderID"
        Me.txt_orderID.ReadOnly = True
        Me.txt_orderID.Size = New System.Drawing.Size(94, 22)
        Me.txt_orderID.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(186, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Order ID:"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_title.Font = New System.Drawing.Font("Tahoma", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(402, 50)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(389, 34)
        Me.lbl_title.TabIndex = 18
        Me.lbl_title.Text = "BYTE BLAST PLACE ORDER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(147, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "1. Select Staff"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(144, 309)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "2. Select Customer"
        '
        'grd_custList
        '
        Me.grd_custList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_custList.Location = New System.Drawing.Point(147, 332)
        Me.grd_custList.Name = "grd_custList"
        Me.grd_custList.RowHeadersWidth = 51
        Me.grd_custList.RowTemplate.Height = 24
        Me.grd_custList.Size = New System.Drawing.Size(585, 150)
        Me.grd_custList.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 17)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Staff ID"
        '
        'txt_staffID
        '
        Me.txt_staffID.Location = New System.Drawing.Point(130, 92)
        Me.txt_staffID.Name = "txt_staffID"
        Me.txt_staffID.ReadOnly = True
        Me.txt_staffID.Size = New System.Drawing.Size(251, 22)
        Me.txt_staffID.TabIndex = 23
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txt_custName)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.txt_custID)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.txt_staffName)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txt_staffID)
        Me.Panel3.Controls.Add(Me.txt_orderID)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(738, 118)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(396, 310)
        Me.Panel3.TabIndex = 24
        '
        'txt_custName
        '
        Me.txt_custName.Location = New System.Drawing.Point(130, 259)
        Me.txt_custName.Name = "txt_custName"
        Me.txt_custName.ReadOnly = True
        Me.txt_custName.Size = New System.Drawing.Size(261, 22)
        Me.txt_custName.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 264)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 17)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Customer Name"
        '
        'txt_custID
        '
        Me.txt_custID.Location = New System.Drawing.Point(130, 209)
        Me.txt_custID.Name = "txt_custID"
        Me.txt_custID.ReadOnly = True
        Me.txt_custID.Size = New System.Drawing.Size(251, 22)
        Me.txt_custID.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 17)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Customer ID"
        '
        'txt_staffName
        '
        Me.txt_staffName.Location = New System.Drawing.Point(130, 151)
        Me.txt_staffName.Name = "txt_staffName"
        Me.txt_staffName.ReadOnly = True
        Me.txt_staffName.Size = New System.Drawing.Size(251, 22)
        Me.txt_staffName.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 17)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Staff Name"
        '
        'btn_order
        '
        Me.btn_order.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btn_order.Location = New System.Drawing.Point(959, 439)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(175, 43)
        Me.btn_order.TabIndex = 25
        Me.btn_order.Text = "SELECT PRODUCT"
        Me.btn_order.UseVisualStyleBackColor = False
        '
        'btn_reset
        '
        Me.btn_reset.BackColor = System.Drawing.Color.Red
        Me.btn_reset.Location = New System.Drawing.Point(738, 439)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(110, 43)
        Me.btn_reset.TabIndex = 26
        Me.btn_reset.Text = "RESET"
        Me.btn_reset.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.prj_ByteBlast_A200321.My.Resources.Resources.logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(-25, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(301, 110)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MistyRose
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(21, 154)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 58)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "ORDER PAGE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frm_makeorder_A200321
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1146, 557)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.btn_order)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grd_custList)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.grd_staffList)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frm_makeorder_A200321"
        Me.Text = "PLACE ORDER - BYTE BLAST SHOP"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_staffList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_custList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
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
    Friend WithEvents grd_staffList As DataGridView
    Friend WithEvents txt_orderID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_title As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents grd_custList As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_staffID As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_custName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_custID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_staffName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_order As Button
    Friend WithEvents btn_reset As Button
    Friend WithEvents Button1 As Button
End Class
