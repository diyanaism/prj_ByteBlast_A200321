Public Class frm_orderItem_A200321
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_A200321.Show()
        Me.Hide()


    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub frm_orderItem_A200321_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\A200321_ByteBlast\prj_ByteBlast_A200321\prj_ByteBlast_A200321\bin\Debug\DB_ByteBlast_A200321.accdb;Persist Security Info=False;"

        Dim mysql As String = "SELECT * FROM TBL_ORDERITEM_A200321"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_orderItem.DataSource = mydatatable

        grd_orderItem.Columns(0).HeaderText = "ORDER-ITEM ID"
        grd_orderItem.Columns(1).HeaderText = "ORDER ID"
        grd_orderItem.Columns(2).HeaderText = "PRODUCT ID"
        grd_orderItem.Columns(3).HeaderText = "QUANTITY"

    End Sub
End Class