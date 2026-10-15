Public Class frm_updateproduct_A200321

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_products_A200321.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    ' Declare a variable to store the selected product ID
    Private selectedProductID As Integer = -1

    ' Declare a variable to store the current product code
    Private current_code As String

    ' Event handler for the form load event
    Private Sub frm_updateproduct_A200321_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data into the DataGridView
        LoadProductData()
        ' Get the current code from the selected row
        get_current_code()
    End Sub

    ' Event handler for DataGridView cell click event
    Private Sub grd_product_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_product.CellClick
        ' Check if a valid cell is clicked (not header or empty row)
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Get the selected product ID from the DataGridView
            selectedProductID = Convert.ToInt32(grd_product.Rows(e.RowIndex).Cells("FLD_PRODUCT_ID").Value)

            ' Display the details of the selected product in the textboxes
            DisplayProductDetails(selectedProductID)
        End If
    End Sub

    ' Event handler for update button click event
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        ' Check if a product is selected
        If selectedProductID <> -1 Then
            ' Update the product details in the database using the values from the textboxes
            UpdateProduct(selectedProductID)
        Else
            MessageBox.Show("Please select a product to update.")
        End If
    End Sub

    ' Event handler for delete button click event
    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        ' Check if a product is selected
        If selectedProductID <> -1 Then
            ' Prompt the user for confirmation before deleting
            If MessageBox.Show("Are you sure you want to delete this product?", "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                ' Delete the selected product from the database
                DeleteProduct(selectedProductID)

                ' Clear the textboxes after deletion
                clear_fields()

                ' Reload data into the DataGridView
                LoadProductData()

                ' Get the current code from the selected row
                get_current_code()
            End If
        Else
            MessageBox.Show("Please select a product to delete.")
        End If
    End Sub

' Function to load data into the DataGridView
    Private Sub LoadProductData()
        ' Add your code to retrieve data from the database and bind it to the DataGridView (grd_product)
        ' Example: grd_product.DataSource = YourDataTable
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A200321 ORDER BY FLD_PRODUCT_ID"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_product.DataSource = mydatatable
    End Sub

        ' Function to display product details in textboxes based on the selected product ID
        Private Sub DisplayProductDetails(productID As Integer)
            ' Add your code to retrieve details of the selected product from the database
            ' and display them in the respective textboxes
            ' Example: Dim productDetails As DataTable = GetProductDetails(productID)
            '          PopulateTextBoxes(productDetails)

            Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A200321 WHERE FLD_PRODUCT_ID = " & productID

            Dim mydatatable As New DataTable

            Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

            myreader.Fill(mydatatable)

            ' Display the details in the textboxes
            txt_prodid.Text = mydatatable.Rows(0)("FLD_PRODUCT_ID").ToString()
            txt_prodname.Text = mydatatable.Rows(0)("FLD_PRODUCT_NAME").ToString()
            txt_prodprice.Text = mydatatable.Rows(0)("FLD_PRICE").ToString()
            txt_prodtype.Text = mydatatable.Rows(0)("FLD_TYPE").ToString()
            txt_produc.Text = mydatatable.Rows(0)("FLD_USECASE").ToString()
            txt_proddevice.Text = mydatatable.Rows(0)("FLD_DEVICE").ToString()
            txt_prodwarranty.Text = mydatatable.Rows(0)("FLD_WARRANTY").ToString()
            txt_prodcapacity.Text = mydatatable.Rows(0)("FLD_CAPACITY").ToString()
        End Sub

' Function to update product details in the database
    Private Sub UpdateProduct(productID As Integer)
        ' Add your code to update the product details in the database based on the values
        ' entered in the textboxes
        ' Example: UpdateProductInDatabase(productID, txt_prodname.Text, txt_prodprice.Text, ...)
        run_sql_command("UPDATE TBL_PRODUCTS_A200321 SET FLD_PRODUCT_ID= '" & txt_prodid.Text & "', FLD_PRODUCT_NAME = '" & txt_prodname.Text & "', FLD_PRICE = '" & txt_prodprice.Text & "' , FLD_TYPE = '" & txt_prodtype.Text & "' , FLD_USECASE = '" & txt_produc.Text & "' , FLD_DEVICE = '" & txt_proddevice.Text & "' , FLD_WARRANTY = '" & txt_prodwarranty.Text & "' , FLD_CAPACITY = '" & txt_prodcapacity.Text & "' WHERE FLD_PRODUCT_ID = " & productID)

        Beep()
        MsgBox("You have successfully updated the product with ID """ & txt_prodid.Text & """.")

        ' Refresh the grid, clear fields, and get the current code
        refresh_grid()
        clear_fields()
        get_current_code()
    End Sub

' Function to delete a product from the database
    Private Sub DeleteProduct(productID As Integer)
        ' Add your code to delete the product from the database based on the product ID
        ' Example: DeleteProductFromDatabase(productID)
        Dim delete_confirmation = MsgBox("Are you sure you would like to delete the product with ID """ & txt_prodid.Text & """?", MsgBoxStyle.YesNo)

        run_sql_command("DELETE FROM TBL_PRODUCTS_A200321 WHERE FLD_PRODUCT_ID= " & productID)

        If delete_confirmation = MsgBoxResult.Yes Then
            Beep()
            MsgBox("The product with ID """ & txt_prodid.Text & """ has been successfully deleted.")

            ' Refresh the grid, clear fields, and get the current code
            refresh_grid()
            clear_fields()
            get_current_code()
        End If
    End Sub

    ' Function to clear the textboxes
    Private Sub clear_fields()
        txt_prodid.Clear()
        txt_prodname.Clear()
        txt_prodprice.Clear()
        txt_prodtype.Clear()
        txt_produc.Clear()
        txt_proddevice.Clear()
        txt_prodwarranty.Clear()
        txt_prodcapacity.Clear()
    End Sub

    Private Sub get_current_code()
        If grd_product.Rows.Count > 0 Then
            Dim current_Row As Integer = grd_product.CurrentRow.Index

            current_code = grd_product(0, current_Row).Value.ToString()

            ' Display the current code in the corresponding textbox
            txt_prodid.Text = current_code
        End If
    End Sub

    Private Sub refresh_grid()

        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A200321"

        Dim mydatatable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        myreader.Fill(mydatatable)

        grd_product.DataSource = mydatatable

    End Sub
End Class