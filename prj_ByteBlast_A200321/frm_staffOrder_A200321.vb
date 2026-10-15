Public Class frm_staffOrder_A200321
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_A200321.Show()
        Me.Hide()

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End

    End Sub

    Private Sub frm_staffOrder_A200321_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\A200321_ByteBlast\prj_ByteBlast_A200321\prj_ByteBlast_A200321\bin\Debug\DB_ByteBlast_A200321.accdb;Persist Security Info=False;"

        Dim mysql As String = "SELECT * FROM TBL_STAFFORDER_A200321"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grid_stafforder.DataSource = mydatatable

        grid_stafforder.Columns(0).HeaderText = "STAFF-ORDER ID"
        grid_stafforder.Columns(1).HeaderText = "STAFF ID"
        grid_stafforder.Columns(2).HeaderText = "ORDER ID"
        grid_stafforder.Columns(3).HeaderText = "PROCESS DATE"
    End Sub
End Class