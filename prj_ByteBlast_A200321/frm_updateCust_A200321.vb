Imports System.Data.OleDb

Public Class frm_updateCust_A200321

    ' Declare a variable to store the selected customer ID as a string
    Private selectedCustID As String = ""

    ' Declare a variable to store the current product code
    Private current_code As String

    ' Event handler for cell click in the DataGridView
    Private Sub grd_cust_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_cust.CellClick
        ' Check if a valid cell is clicked (not header or empty row)
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Get the selected customer ID from the DataGridView
            selectedCustID = grd_cust.Rows(e.RowIndex).Cells("FLD_CUSTOMER_ID").Value.ToString()

            ' Display all details of the selected customer in the textboxes
            DisplayCustomerDetails(selectedCustID)
        End If
    End Sub

    Private Sub get_current_code()
        If grd_cust.Rows.Count > 0 Then
            Dim current_Row As Integer = grd_cust.CurrentRow.Index

            current_code = grd_cust(0, current_Row).Value.ToString()

            ' Display the current code in the corresponding textbox
            txt_custid.Text = current_code
        End If
    End Sub

    Private Sub DisplayCustomerDetails(custID As String)
        Try
            ' Fetch all customer details by ID
            Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A200321 WHERE FLD_CUSTOMER_ID = '" & custID & "'"

            Dim mytable As New DataTable

            Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

            myreader.Fill(mytable)
            ' Check if there are rows in the DataTable
            If mytable.Rows.Count > 0 Then
                ' Check if the column "FLD_STAFF_AGE" exists in the DataTable
                If mytable.Columns.Contains("FLD_CUSTOMER_NAME") Then
                    ' Display the details in the textboxes
                    txt_custid.Text = mytable.Rows(0)("FLD_CUSTOMER_ID").ToString()
                    txt_custname.Text = mytable.Rows(0)("FLD_CUSTOMER_NAME").ToString()
                    txt_address.Text = mytable.Rows(0)("FLD_CUSTOMER_ADDRESS").ToString()
                    txt_email.Text = mytable.Rows(0)("FLD_CUSTOMER_EMAIL").ToString()
                    txt_phoneno.Text = mytable.Rows(0)("FLD_CUSTOMER_PHONE").ToString()

                    'MessageBox.Show("Selected Customer ID: " & custID)
                Else
                    MessageBox.Show("Column 'FLD_STAFF_AGE' does not exist in the DataTable.")
                End If
            Else
                MessageBox.Show("No data found for Customer ID: " & custID)
            End If


        Catch ex As Exception
            MessageBox.Show("Error displaying customer details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadProductData()
        Try
            ' Add your code to retrieve data from the database and bind it to the DataGridView (grd_cust)
            ' Example: grd_cust.DataSource = YourDataTable
            Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A200321"

            Dim mydatatable As New DataTable
            Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

            myreader.Fill(mydatatable)

            grd_cust.DataSource = mydatatable
        Catch ex As Exception
            MessageBox.Show("Error loading customer data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' Function to update customer details in the database
    Private Sub UpdateCust(custID As String)
        Try
            ' Add your code to update the customer details in the database based on the values
            ' entered in the textboxes
            ' Example: UpdateCustomerInDatabase(custID, txt_custname.Text, txt_address.Text, ...)
            'Dim query As String = "UPDATE TBL_CUSTOMER_A200321 SET FLD_CUSTOMER_ID= '" & txt_custid.Text & "', FLD_CUSTOMER_NAME = '" & txt_custname.Text & "', FLD_CUSTOMER_ADDRESS = '" & txt_address.Text & "' , FLD_CUSTOMER_EMAIL = '" & txt_email.Text & "' , FLD_PHONE_NO = '" & txt_phoneno.Text & "', WHERE FLD_CUSTOMER_ID = " & custID
            Dim query As String = "UPDATE TBL_CUSTOMER_A200321 SET FLD_CUSTOMER_ID= '" & txt_custid.Text & "', FLD_CUSTOMER_NAME = '" & txt_custname.Text & "', FLD_CUSTOMER_ADDRESS = '" & txt_address.Text & "' , FLD_CUSTOMER_EMAIL = '" & txt_email.Text & "' , FLD_CUSTOMER_PHONE = '" & txt_phoneno.Text & "' WHERE FLD_CUSTOMER_ID = '" & custID & "'"

            'run_sql_command("UPDATE TBL_STAFF_A200321 SET FLD_STAFF_ID= '" & txt_staffid.Text & "', FLD_STAFF_NAME = '" & txt_staffname.Text & "', FLD_STAFF_AGE = '" & txt_staffage.Text & "' , FLD_STAFF_POSITION = '" & txt_staffposition.Text & "' ,  WHERE FLD_STAFF_ID = " & productID)

            Using myconnection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_ByteBlast_A200321.accdb;Persist Security Info=False;")
                myconnection.Open()

                Using cmd As New OleDb.OleDbCommand(query, myconnection)
                    ' Assign values to parameters with appropriate data types
                    cmd.Parameters.Add("FLD_CUSTOMER_ID", OleDbType.VarChar).Value = txt_custid.Text
                    cmd.Parameters.Add("FLD_CUSTOMER_NAME", OleDbType.VarChar).Value = txt_custname.Text
                    cmd.Parameters.Add("FLD_CUSTOMER_ADDRESS", OleDbType.VarChar).Value = txt_address.Text
                    cmd.Parameters.Add("FLD_CUSTOMER_EMAIL", OleDbType.VarChar).Value = txt_email.Text
                    cmd.Parameters.Add("FLD_PHONE_NO", OleDbType.VarChar).Value = txt_phoneno.Text
                    cmd.Parameters.Add("Original_FLD_CUSTOMER_ID", OleDbType.VarChar).Value = custID ' Original_FLD_CUSTOMER_ID is the parameter for WHERE clause

                    ' Execute the query
                    cmd.ExecuteNonQuery()

                End Using
            End Using

            Beep()
            MsgBox($"You have successfully updated the customer with ID ""{txt_custid.Text}"".")

            ' Refresh the grid, clear fields, and get the current code
            refresh_grid()
            clear_fields()
            get_current_code()
        Catch ex As Exception
            MessageBox.Show($"Error updating customer details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    ' Function to delete a customer from the database
    Private Sub DeleteCustomer(custID As String)
        Try
            ' Add your code to delete the customer from the database based on the customer ID
            ' Example: DeleteCustomerFromDatabase(custID)
            Dim delete_confirmation = MsgBox($"Are you sure you would like to delete the customer with ID ""{txt_custid.Text}""?", MsgBoxStyle.YesNo)

            run_sql_command($"DELETE FROM TBL_CUSTOMER_A200321 WHERE FLD_CUSTOMER_ID= '{custID}'")

            If delete_confirmation = MsgBoxResult.Yes Then
                Beep()
                MsgBox($"The customer with ID ""{txt_custid.Text}"" has been successfully deleted.")

                ' Refresh the grid, clear fields, and get the current code
                refresh_grid()
                clear_fields()
                get_current_code()
            End If
        Catch ex As Exception
            MessageBox.Show($"Error deleting customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' Function to refresh the DataGridView with updated data
    Private Sub refresh_grid()
        Dim mysql As String = "SELECT * FROM TBL_CUSTOMER_A200321"
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
        myreader.Fill(mydatatable)
        grd_cust.DataSource = mydatatable
    End Sub

    ' Function to clear the textboxes
    Private Sub clear_fields()
        txt_custid.Clear()
        txt_custname.Clear()
        txt_address.Clear()
        txt_email.Clear()
        txt_phoneno.Clear()
    End Sub

    Private Sub ClearCustomerDetails()
        ' Clear all customer details
        txt_custid.Text = ""
        txt_custname.Text = ""
        txt_address.Text = ""
        txt_email.Text = ""
        txt_phoneno.Text = ""
    End Sub

    Private Sub frm_updateCust_A200321_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_grid()
        Try
            grd_cust.DataSource = run_sql_query("SELECT * FROM TBL_CUSTOMER_A200321")

            grd_cust.Columns(0).HeaderText = "CUSTOMER ID"
            grd_cust.Columns(1).HeaderText = "CUSTOMER NO"
            grd_cust.Columns(2).HeaderText = "ADDRESS"
            grd_cust.Columns(3).HeaderText = "EMAIL"
            grd_cust.Columns(4).HeaderText = "TELEPHONE NO"

            LoadProductData()
            get_current_code()

        Catch ex As Exception
            MessageBox.Show("Error loading customer: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub RefreshText(custID As String)
        Try
            ' Fetch customer details by ID
            Dim mysql As String = $"SELECT * FROM TBL_CUSTOMER_A200321 WHERE FLD_CUSTOMER_ID = '{custID}'"

            Dim mytable As New DataTable
            Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

            myreader.Fill(mytable)

            ' Display details if the customer is found
            If mytable.Rows.Count > 0 Then
                txt_custid.Text = mytable.Rows(0).Item("FLD_CUSTOMER_ID")
                txt_custname.Text = mytable.Rows(0).Item("FLD_CUSTOMER_NAME")
                txt_address.Text = mytable.Rows(0).Item("FLD_CUSTOMER_ADDRESS")
                txt_email.Text = mytable.Rows(0).Item("FLD_CUSTOMER_EMAIL")
                txt_phoneno.Text = mytable.Rows(0).Item("FLD_CUSTOMER_PHONE")
            Else
                ' Clear details if the customer is not found
                ClearCustomerDetails()
            End If
        Catch ex As Exception
            MessageBox.Show("Error refreshing customer details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_customer_A200321.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        refresh_grid()
        ' Check if a product is selected
        If Not String.IsNullOrEmpty(selectedCustID) Then
            ' Update the product details in the database using the values from the textboxes
            UpdateCust(selectedCustID)
        Else
            MessageBox.Show("Please select a product to update.")
        End If

    End Sub



    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        refresh_grid()
        ' Check if a customer is selected
        If Not String.IsNullOrEmpty(selectedCustID) Then
            ' Prompt the user for confirmation before deleting
            If MessageBox.Show("Are you sure you want to delete this customer?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                ' Delete the selected customer from the database
                DeleteCustomer(selectedCustID)

                ' Clear the textboxes after deletion
                clear_fields()

                ' Reload data into the DataGridView
                LoadProductData()

                ' Get the current code from the selected row
                get_current_code()
            End If
        Else
            MessageBox.Show("Please select a customer to delete.")
        End If
    End Sub

End Class
