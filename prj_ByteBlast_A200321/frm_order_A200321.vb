Public Class frm_order_A200321
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_A200321.Show()
        Me.Hide()

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub frm_order_A200321_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\A200321_ByteBlast\prj_ByteBlast_A200321\prj_ByteBlast_A200321\bin\Debug\DB_ByteBlast_A200321.accdb;Persist Security Info=False;"

        Dim mysql As String = "SELECT * FROM TBL_ORDER_A200321"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_orderitem.DataSource = mydatatable

        grd_orderitem.Columns(0).HeaderText = "ORDER ID"
        grd_orderitem.Columns(1).HeaderText = "CUST ID"
        grd_orderitem.Columns(2).HeaderText = "CUST NAME"
        grd_orderitem.Columns(3).HeaderText = "STAFF ID"
        grd_orderitem.Columns(4).HeaderText = "STAFF NAME"

    End Sub

    Private Sub btn_orderdetails_Click(sender As Object, e As EventArgs) Handles btn_orderdetails.Click
        'frm_orderItem_A200321.Show()
        frm_invoice_A200321.Show()
        Me.Hide()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub grd_order_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_orderitem.CellContentClick

    End Sub

    Private Sub btn_makeorder_Click(sender As Object, e As EventArgs) Handles btn_makeorder.Click
        frm_makeorder_A200321.Show()
        Me.Hide()
    End Sub
End Class