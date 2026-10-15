Public Class frm_updateStaff_A200321

    Private Shared myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\A200321_ByteBlast\prj_ByteBlast_A200321\prj_ByteBlast_A200321\bin\Debug\DB_ByteBlast_A200321.accdb"
    Private Shared myadapter As OleDb.OleDbDataAdapter

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_staff_A200321.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    ' Declare a variable to store the selected staff ID
    Private selectedStaffID As String = ""


    ' Declare a variable to store the current product code
    Private current_code As String

    ' Event handler for the form load event
    Private Sub frm_updateStaff_A200321_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data into the DataGridView
        LoadProductData()
        ' Get the current code from the selected row
        get_current_code()
        grd_staff.Columns(0).HeaderText = "STAFF ID"
        grd_staff.Columns(1).HeaderText = "NAME"
        grd_staff.Columns(2).HeaderText = "AGE"
        grd_staff.Columns(3).HeaderText = "POSITION"

    End Sub

    ' Event handler for DataGridView cell click event
    Private Sub grd_staff_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_staff.CellClick
        ' Check if a valid cell is clicked (not header or empty row)
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Get the selected staff ID from the DataGridView
            selectedStaffID = grd_staff.Rows(e.RowIndex).Cells("FLD_STAFF_ID").Value.ToString()

            ' Display the details of the selected staff in the textboxes
            DisplayStaffDetails(selectedStaffID)
        End If
    End Sub

    Private Sub DisplayStaffDetails(staffID As String)
        Dim mysql As String = "SELECT * FROM TBL_STAFF_A200321 WHERE FLD_STAFF_ID = '" & staffID & "'"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        ' Check if there are rows in the DataTable
        If mydatatable.Rows.Count > 0 Then
            ' Check if the column "FLD_STAFF_AGE" exists in the DataTable
            If mydatatable.Columns.Contains("FLD_STAFF_AGE") Then
                ' Display the details in the textboxes
                txt_staffid.Text = mydatatable.Rows(0)("FLD_STAFF_ID").ToString()
                txt_staffname.Text = mydatatable.Rows(0)("FLD_STAFF_NAME").ToString()
                txt_staffage.Text = mydatatable.Rows(0)("FLD_STAFF_AGE").ToString()
                txt_staffposition.Text = mydatatable.Rows(0)("FLD_STAFF_POSITION").ToString()
                MessageBox.Show("Selected Staff ID: " & staffID)
            Else
                MessageBox.Show("Column 'FLD_STAFF_AGE' does not exist in the DataTable.")
            End If
        Else
            MessageBox.Show("No data found for Staff ID: " & staffID)
        End If

        ' Display column names in the DataTable
        For Each col As DataColumn In mydatatable.Columns
            Console.WriteLine(col.ColumnName)
        Next

        ' Check if the column exists before accessing it
        If mydatatable.Columns.Contains("FLD_STAFF_AGE") Then
            ' Access the column
            txt_staffage.Text = mydatatable.Rows(0)("FLD_STAFF_AGE").ToString()
        Else
            MessageBox.Show("Column 'FLD_STAFF_AGE' does not exist in the DataTable.")
        End If

    End Sub



    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        refresh_grid()
        ' Check if a product is selected
        If Not String.IsNullOrEmpty(selectedStaffID) Then
            ' Update the product details in the database using the values from the textboxes
            UpdateProduct(selectedStaffID)
        Else
            MessageBox.Show("Please select a product to update.")
        End If
    End Sub


    ' Event handler for delete button click event
    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        If Not String.IsNullOrEmpty(selectedStaffID) Then
            If MessageBox.Show("Are you sure you want to delete this staff?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                ' Use String type for staffID
                Dim staffID As String = selectedStaffID

                ' Add your code to delete the staff from the database
                DeleteStaff(staffID)
            End If
        Else
            MessageBox.Show("Please select a staff to delete.")
        End If
    End Sub

    Private Sub DeleteStaff(staffID As String)
        ' Add your code to delete the staff from the database based on the staff ID
        ' Example: DeleteStaffFromDatabase(staffID)
        run_sql_command("DELETE FROM TBL_STAFF_A200321 WHERE FLD_STAFF_ID= '" & staffID & "'")

        Beep()
        MsgBox("The staff with ID """ & staffID & """ has been successfully deleted.")

        ' Refresh the grid, clear fields, and get the current code
        refresh_grid()
        clear_fields()
        get_current_code()
    End Sub

    ' Function to load data into the DataGridView
    Private Sub LoadProductData()
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


    ' Function to update product details in the database
    Private Sub UpdateProduct(staffID As String)

        ' Example: UpdateProductInDatabase(staffID, txt_staffname.Text, txt_staffage.Text, txt_staffposition.Text)
        run_sql_command("UPDATE TBL_STAFF_A200321 SET FLD_STAFF_ID= '" & txt_staffid.Text & "', FLD_STAFF_NAME = '" & txt_staffname.Text & "', FLD_STAFF_AGE = '" & txt_staffage.Text & "' , FLD_STAFF_POSITION = '" & txt_staffposition.Text & "' WHERE FLD_STAFF_ID = '" & staffID & "'")

        Beep()
        MsgBox("You have successfully updated the staff with ID """ & txt_staffid.Text & """.")

        ' Refresh the grid, clear fields, and get the current code
        refresh_grid()
        clear_fields()
        get_current_code()
    End Sub

    ' Function to delete a product from the database
    Private Sub DeleteProduct(productID As Integer)
        ' Add your code to delete the product from the database based on the product ID
        ' Example: DeleteProductFromDatabase(productID)
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the product with ID """ & txt_staffid.Text & """?", MsgBoxStyle.YesNo)

        run_sql_command("DELETE FROM TBL_STAFF_A200321 WHERE FLD_STAFF_ID= " & productID)

        If delete_confirmation = MsgBoxResult.Yes Then
            Beep()
            MsgBox("The staff with ID """ & txt_staffid.Text & """ has been successfully deleted.")

            ' Refresh the grid, clear fields, and get the current code
            refresh_grid()
            clear_fields()
            get_current_code()
        End If
    End Sub

    ' Function to clear the textboxes
    Private Sub clear_fields()
        txt_staffid.Clear()
        txt_staffname.Clear()
        txt_staffage.Clear()
        txt_staffposition.Clear()
    End Sub

    Private Sub get_current_code()
        If grd_staff.Rows.Count > 0 Then
            Dim current_Row As Integer = grd_staff.CurrentRow.Index

            current_code = grd_staff(0, current_Row).Value.ToString()

            ' Display the current code in the corresponding textbox
            txt_staffid.Text = current_code
        End If
    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_STAFF_A200321"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_staff.DataSource = mydatatable

    End Sub



End Class