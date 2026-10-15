Public Class frm_insertCust_A200321
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_customer_A200321.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub frm_insertCust_A200321_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        'Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\A200321_ByteBlast\prj_ByteBlast_A200321\prj_ByteBlast_A200321\bin\Debug\DB_ByteBlast_A200321.accdb;Persist Security Info=False;"

        'Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A200321"

        'Dim mydatatable As New DataTable

        'Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        'myreader.Fill(mydatatable)

        'grd_cust.DataSource = mydatatable

        'grd_cust.Columns(0).HeaderText = "CUSTOMER ID"
        'grd_cust.Columns(1).HeaderText = "CUSTOMER NO"
        'grd_cust.Columns(2).HeaderText = "ADDRESS"
        'grd_cust.Columns(3).HeaderText = "EMAIL"
        'grd_cust.Columns(4).HeaderText = "TELEPHONE NO"
        Dim mysql As String = "Select FLD_CUSTOMER_ID from TBL_CUSTOMER_200321 order by FLD_CUSTOMER_ID"

        Dim mytable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)


        grd_cust.DataSource = run_sql_query("SELECT * FROM TBL_CUSTOMER_A200321")



        txt_custid.Text = generate_matric()
    End Sub

    Private Function generate_matric() As String

        Dim lastmatric As String = run_sql_query("Select MAX(FLD_CUSTOMER_ID) As LASTMATRIC from TBL_CUSTOMER_A200321").Rows(0).Item("LASTMATRIC")

        'MsgBox(lastmatric)

        Dim newmatric As String = "C" & (CInt(Mid(lastmatric, 2)) + 1).ToString("0")

        Return newmatric

    End Function

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim mysql As String = "INSERT INTO TBL_CUSTOMER_A200321 VALUES (@id, @name, @address, @email, @phone)"
        'Dim mysql As String = "Insert into TBL_CUSTOMER_A200321 values ('" & txt_custid & "', '" & txt_custname & "', '" & txt_address & "', '" & txt_email & "', '" & txt_phoneno & "')"
        'Dim mysql As String = "INSERT INTO TBL_CUSTOMER_A200321 VALUES ('" & txt_custid.Text & " ', '" & txt_custname.Text & "', '" & txt_address & "', '" & txt_email & "', '" & txt_phoneno & "')"
        'Dim mysql As String = "insert into TBL_COURSES_A123456 values ('" & txt_code.Text & "', '" & txt_name.Text & "', " & cmb_credits.Text & ", '" & cmb_dept.Text & "')"

        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)


        '' Validate staff age input
        'Dim staffAge As Decimal
        'If Not Decimal.TryParse(txt_staffage.Text, staffAge) Then
        '    MsgBox("Please enter a valid decimal number for Staff Age.", MsgBoxStyle.Exclamation)
        '    Return
        'End If

        Try
            mywriter.Parameters.AddWithValue("@id", txt_custid.Text)
            mywriter.Parameters.AddWithValue("@name", txt_custname.Text)
            mywriter.Parameters.AddWithValue("@address", txt_address.Text)
            mywriter.Parameters.AddWithValue("@email", txt_email.Text)
            mywriter.Parameters.AddWithValue("@phone", txt_phoneno.Text)

            grd_cust.DataSource = run_sql_query("SELECT * FROM TBL_CUSTOMER_A200321")

            txt_custid.Text = generate_matric()
            txt_custname.Text = ""
            txt_address.Text = ""
            txt_email.Text = ""
            txt_phoneno.Text = ""
            'mywriter.Connection.Open()
            myconnection2.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()
            MsgBox("INSERT successful")

            refresh_grid()
            clear_fields()

            txt_custid.Text = ""
            txt_custname.Text = ""

        Catch ex As Exception

            Beep()
            MsgBox("There is an error in your INSERT command:" & vbCrLf & vbCrLf & ex.Message)

            'mywriter.Connection.Close()

        End Try

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

    Private Sub clear_fields()
        txt_custid.Text = ""
        txt_custname.Text = ""
        txt_address.Text = ""
        txt_email.Text = ""
        txt_phoneno.Text = ""

    End Sub

End Class