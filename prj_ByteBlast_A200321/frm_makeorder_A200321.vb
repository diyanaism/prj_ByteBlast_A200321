Public Class frm_makeorder_A200321
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_order_A200321.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    ' Function to load data into the DataGridView
    Private Sub LoadStaffData()
        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\A200321_ByteBlast\prj_ByteBlast_A200321\prj_ByteBlast_A200321\bin\Debug\DB_ByteBlast_A200321.accdb;Persist Security Info=False;"

        Dim mysql As String = "SELECT * FROM TBL_STAFF_A200321"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_staffList.DataSource = mydatatable

        grd_staffList.Columns(0).HeaderText = "STAFF ID"
        grd_staffList.Columns(1).HeaderText = "NAME"
        grd_staffList.Columns(2).HeaderText = "AGE"
        grd_staffList.Columns(3).HeaderText = "POSITION"

    End Sub

    Private Sub LoadCustData()
        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\A200321_ByteBlast\prj_ByteBlast_A200321\prj_ByteBlast_A200321\bin\Debug\DB_ByteBlast_A200321.accdb;Persist Security Info=False;"

        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A200321 ORDER BY FLD_CUSTOMER_ID"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_custList.DataSource = mydatatable

        grd_custList.Columns(0).HeaderText = "CUSTOMER ID"
        grd_custList.Columns(1).HeaderText = "NAME"
        grd_custList.Columns(2).HeaderText = "ADDRESS"
        grd_custList.Columns(3).HeaderText = "EMAIL"
        grd_custList.Columns(4).HeaderText = "TELEPHONE NO"

    End Sub

    ' Function to refresh and get updated data into the DataGridView
    Private Sub RefreshAndGetData()
        LoadStaffData()

        LoadCustData()
    End Sub

    'Private Function GenerateOrderID() As String
    '    Dim queryResult As DataTable = run_sql_query("SELECT MAX(FLD_ORDER_ID) AS LASTMATRIC FROM TBL_ORDER_A200321")

    '    If queryResult.Rows.Count > 0 AndAlso Not IsDBNull(queryResult.Rows(0).Item("LASTMATRIC")) Then
    '        Dim lastmatric As String = queryResult.Rows(0).Item("LASTMATRIC").ToString()

    '        ' Check if lastmatric has the expected format
    '        If lastmatric.Length > 1 AndAlso lastmatric(0) = "O" Then
    '            ' Extract the numeric part, increment, and format
    '            Dim numericPart As Integer
    '            If Integer.TryParse(lastmatric.Substring(1), numericPart) Then
    '                Dim newmatric As String = "O" & (numericPart + 1).ToString("00")
    '                Return newmatric
    '            End If
    '        End If
    '    End If

    '    ' Default case if there are no existing order IDs or unexpected data
    '    Return "O01"
    'End Function

    Private Function GenerateOrderID() As String
        Try
            Dim queryResult As DataTable = run_sql_query("SELECT MAX(FLD_ORDER_ID) AS LASTORDERID FROM TBL_ORDER_A200321")

            If queryResult.Rows.Count > 0 AndAlso Not IsDBNull(queryResult.Rows(0).Item("LASTORDERID")) Then
                Dim lastOrderID As String = queryResult.Rows(0).Item("LASTORDERID").ToString()

                ' Debug: Print the retrieved lastOrderID
                Console.WriteLine("Last Order ID from database: " & lastOrderID)

                If lastOrderID.Length > 1 AndAlso lastOrderID(0) = "O" Then
                    Dim numericPart As Integer
                    If Integer.TryParse(lastOrderID.Substring(1), numericPart) Then
                        ' Debug: Print the extracted numeric part
                        Console.WriteLine("Extracted Numeric Part: " & numericPart)

                        Dim newOrderID As String = "O" & (numericPart + 1).ToString("00")

                        ' Debug: Print the newOrderID
                        Console.WriteLine("Generated Order ID: " & newOrderID)

                        Return newOrderID
                    End If
                End If
            End If

            ' Default case if there are no existing order IDs or unexpected data
            Return "O01"
        Catch ex As Exception
            MessageBox.Show("Error generating order ID: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "O01" ' Default case in case of an exception
        End Try
    End Function



    Private Sub frm_makeorder_A200321_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_orderID.Text = GenerateOrderID()

        LoadStaffData() ' Load data into the DataGridView

        LoadCustData()
    End Sub

    Private Sub grd_staffList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_staffList.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < grd_staffList.Rows.Count Then
            ' Get data from the selected row
            Dim staffID As String = grd_staffList.Rows(e.RowIndex).Cells("FLD_STAFF_ID").Value.ToString()
            Dim staffName As String = grd_staffList.Rows(e.RowIndex).Cells("FLD_STAFF_NAME").Value.ToString()

            ' Display data in the textboxes
            txt_staffID.Text = staffID
            txt_staffName.Text = staffName
        End If
    End Sub

    Private Sub grd_custList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_custList.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < grd_custList.Rows.Count Then
            ' Get data from the selected row
            Dim custID As String = grd_custList.Rows(e.RowIndex).Cells("FLD_CUSTOMER_ID").Value.ToString()
            Dim custName As String = grd_custList.Rows(e.RowIndex).Cells("FLD_CUSTOMER_NAME").Value.ToString()

            ' Display data in the textboxes
            txt_custID.Text = custID
            txt_custName.Text = custName
        End If
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        ' Reset the text properties of the textboxes
        txt_staffID.Text = ""
        txt_staffName.Text = ""
        txt_custID.Text = ""
        txt_custName.Text = ""
    End Sub



    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        ' Check if order details are selected
        If Not String.IsNullOrEmpty(txt_orderID.Text) AndAlso Not String.IsNullOrEmpty(txt_staffID.Text) AndAlso Not String.IsNullOrEmpty(txt_custID.Text) Then
            ' Insert order details into TBL_ORDER_A200321
            InsertOrderDetails()

            ' Create a new instance of the next form
            Dim nextForm As New frm_orderdetails_A200321()

            ' Pass the necessary details to the next form
            nextForm.OrderID = txt_orderID.Text
            nextForm.staffID = txt_staffID.Text
            nextForm.StaffName = txt_staffName.Text
            nextForm.CustID = txt_custID.Text
            nextForm.CustomerName = txt_custName.Text

            ' Show the next form
            nextForm.Show()

            ' Hide the current form
            Me.Hide()
        Else
            ' Display an error message if details are not selected
            MessageBox.Show("Please select order details before proceeding.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub InsertOrderDetails()
        ' Insert order details into TBL_ORDER_A200321
        Try
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\A200321_ByteBlast\prj_ByteBlast_A200321\prj_ByteBlast_A200321\bin\Debug\DB_ByteBlast_A200321.accdb;Persist Security Info=False;"

            Using connection As New OleDb.OleDbConnection(connectionString)
                connection.Open()

                Dim sql As String = "INSERT INTO TBL_ORDER_A200321 (FLD_ORDER_ID, FLD_ORDER_STAFFID, FLD_ORDER_STAFFNM, FLD_ORDER_CUSTID, FLD_ORDER_CUSTNM) VALUES (@OrderID, @StaffID, @StaffNM, @CustID, @CustNM)"

                Using command As New OleDb.OleDbCommand(sql, connection)
                    command.Parameters.AddWithValue("@OrderID", txt_orderID.Text)
                    command.Parameters.AddWithValue("@StaffID", txt_staffID.Text)
                    command.Parameters.AddWithValue("@StaffNM", txt_staffName.Text)
                    command.Parameters.AddWithValue("@CustID", txt_custID.Text)
                    command.Parameters.AddWithValue("@CustNM", txt_custName.Text)

                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error inserting order details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_order_A200321.Show()
        Me.Hide()

    End Sub
End Class

