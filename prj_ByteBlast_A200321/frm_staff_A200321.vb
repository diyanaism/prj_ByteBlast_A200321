Public Class frm_staff_A200321
    Private current_code As String
    Private Shared myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\A200321_ByteBlast\prj_ByteBlast_A200321\prj_ByteBlast_A200321\bin\Debug\DB_ByteBlast_A200321.accdb"
    Private Shared myadapter As OleDb.OleDbDataAdapter


    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_A200321.Show()
        Me.Hide()
    End Sub

    Private Sub frm_staff_A200321_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStaffData() ' Load data into the DataGridView

        grd_staff.Columns(0).HeaderText = "STAFF ID"
        grd_staff.Columns(1).HeaderText = "NAME"
        grd_staff.Columns(2).HeaderText = "AGE"
        grd_staff.Columns(3).HeaderText = "POSITION"
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub btn_stafforder_Click(sender As Object, e As EventArgs)
        frm_staffOrder_A200321.Show()
        Me.Hide()
    End Sub

    Private Sub btnInsert_update_Click(sender As Object, e As EventArgs) Handles btnInsert_update.Click
        frm_insertstaff_A200321.Show()
        Me.Hide()
        ' Call refresh and get updated data after insert
        RefreshAndGetData()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        frm_updateStaff_A200321.Show()
        Me.Hide()
        ' Call refresh and get updated data after delete
        RefreshAndGetData()
    End Sub

    ' Function to load data into the DataGridView
    Private Sub LoadStaffData()
        ' Use the shared OleDbDataAdapter
        If myadapter Is Nothing Then
            myadapter = New OleDb.OleDbDataAdapter()
        End If

        Dim mysql As String = "SELECT * FROM TBL_STAFF_A200321"

        Dim mydatatable As New DataTable

        ' Set the OleDbDataAdapter's connection string and select command
        myadapter.SelectCommand = New OleDb.OleDbCommand(mysql, New OleDb.OleDbConnection(myconnection))

        ' Fill the DataTable using the adapter
        myadapter.Fill(mydatatable)

        grd_staff.DataSource = mydatatable

        grd_staff.Columns(0).HeaderText = "STAFF ID"
        grd_staff.Columns(1).HeaderText = "NAME"
        grd_staff.Columns(2).HeaderText = "AGE"
        grd_staff.Columns(3).HeaderText = "POSITION"
    End Sub

    ' Function to refresh and get updated data into the DataGridView
    Private Sub RefreshAndGetData()
        LoadStaffData()
        refresh_grid()
    End Sub

    Private Sub refresh_grid()
        ' Use the shared OleDbDataAdapter
        If myadapter Is Nothing Then
            myadapter = New OleDb.OleDbDataAdapter()
        End If

        Dim mysql As String = "SELECT * FROM TBL_STAFF_A200321"

        Dim mydatatable As New DataTable

        ' Set the OleDbDataAdapter's connection string and select command
        myadapter.SelectCommand = New OleDb.OleDbCommand(mysql, New OleDb.OleDbConnection(myconnection))

        ' Fill the DataTable using the adapter
        myadapter.Fill(mydatatable)

        grd_staff.DataSource = mydatatable
    End Sub


End Class
