Public Class frm_customer_A200321

    ' Declare a variable to store the current product code
    Private current_code As String

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_A200321.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub frm_customer_A200321_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()

        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\A200321_ByteBlast\prj_ByteBlast_A200321\prj_ByteBlast_A200321\bin\Debug\DB_ByteBlast_A200321.accdb;Persist Security Info=False;"

        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A200321"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        grd_cust.DataSource = run_sql_query("SELECT * FROM TBL_CUSTOMER_A200321")

        myreader.Fill(mydatatable)

        grd_cust.DataSource = mydatatable

        grd_cust.Columns(0).HeaderText = "CUSTOMER ID"
        grd_cust.Columns(1).HeaderText = "CUSTOMER NO"
        grd_cust.Columns(2).HeaderText = "ADDRESS"
        grd_cust.Columns(3).HeaderText = "EMAIL"
        grd_cust.Columns(4).HeaderText = "TELEPHONE NO"


    End Sub




    Private Sub btnInsert_update_Click(sender As Object, e As EventArgs) Handles btnInsert_update.Click
        frm_insertCust_A200321.Show()
        Me.Hide()
        refresh_grid()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        frm_updateCust_A200321.Show()
        Me.Hide()
        refresh_grid()
    End Sub

    Private Sub grd_cust_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_cust.CellContentClick

    End Sub

    Private Sub refresh_grid()
        Dim mysql As String = "select * FROM TBL_CUSTOMER_A200321"

        Dim mytable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mytable)

        grd_cust.DataSource = mytable

        'rename the column name
        grd_cust.Columns(0).HeaderText = "ID"
        grd_cust.Columns(1).HeaderText = "NAME"
        grd_cust.Columns(2).HeaderText = "ADDRESS"
        grd_cust.Columns(3).HeaderText = "EMAIL"
        grd_cust.Columns(4).HeaderText = "PHONE NO"

    End Sub

    'Private Sub btn_orderItem_Click(sender As Object, e As EventArgs) Handles btn_orderItem.Click
    '    frm_orderItem_A200321.Show()
    '    Me.Hide()

    'End Sub
End Class