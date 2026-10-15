<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_order_A200321
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
        Me.btn_makeorder = New System.Windows.Forms.Button()
        Me.btn_orderdetails = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.grd_orderitem = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grd_orderitem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_makeorder)
        Me.Panel1.Controls.Add(Me.btn_orderdetails)
        Me.Panel1.Controls.Add(Me.btn_back)
        Me.Panel1.Controls.Add(Me.btn_exit)
        Me.Panel1.Location = New System.Drawing.Point(12, 121)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(138, 377)
        Me.Panel1.TabIndex = 9
        '
        'btn_makeorder
        '
        Me.btn_makeorder.BackColor = System.Drawing.Color.MistyRose
        Me.btn_makeorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_makeorder.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_makeorder.Location = New System.Drawing.Point(21, 118)
        Me.btn_makeorder.Name = "btn_makeorder"
        Me.btn_makeorder.Size = New System.Drawing.Size(104, 58)
        Me.btn_makeorder.TabIndex = 12
        Me.btn_makeorder.Text = "MAKE ORDER"
        Me.btn_makeorder.UseVisualStyleBackColor = False
        '
        'btn_orderdetails
        '
        Me.btn_orderdetails.BackColor = System.Drawing.Color.MistyRose
        Me.btn_orderdetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_orderdetails.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_orderdetails.Location = New System.Drawing.Point(21, 223)
        Me.btn_orderdetails.Name = "btn_orderdetails"
        Me.btn_orderdetails.Size = New System.Drawing.Size(104, 58)
        Me.btn_orderdetails.TabIndex = 11
        Me.btn_orderdetails.Text = "INVOICE"
        Me.btn_orderdetails.UseVisualStyleBackColor = False
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
        Me.Panel2.Location = New System.Drawing.Point(0, 495)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1054, 59)
        Me.Panel2.TabIndex = 11
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.prj_ByteBlast_A200321.My.Resources.Resources.footer
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(423, 23)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(242, 24)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'grd_orderitem
        '
        Me.grd_orderitem.AllowUserToAddRows = False
        Me.grd_orderitem.AllowUserToDeleteRows = False
        Me.grd_orderitem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grd_orderitem.BackgroundColor = System.Drawing.SystemColors.Control
        Me.grd_orderitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_orderitem.Location = New System.Drawing.Point(156, 121)
        Me.grd_orderitem.Name = "grd_orderitem"
        Me.grd_orderitem.ReadOnly = True
        Me.grd_orderitem.RowHeadersWidth = 51
        Me.grd_orderitem.RowTemplate.Height = 24
        Me.grd_orderitem.Size = New System.Drawing.Size(860, 368)
        Me.grd_orderitem.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.prj_ByteBlast_A200321.My.Resources.Resources.logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(-14, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(301, 110)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'frm_order_A200321
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 558)
        Me.Controls.Add(Me.grd_orderitem)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_order_A200321"
        Me.Text = "ORDER - BYTE BLAST SHOP"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grd_orderitem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents grd_orderitem As DataGridView
    Friend WithEvents btn_orderdetails As Button
    Friend WithEvents btn_makeorder As Button
End Class
