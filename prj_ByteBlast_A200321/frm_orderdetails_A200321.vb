Public Class frm_orderdetails_A200321

    Private Sub frm_orderdetails_A200321_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display received data in textboxes
        txt_orderID.Text = OrderID
        txt_staffID.Text = staffID
        txt_staffName.Text = StaffName
        txt_custID.Text = CustID
        txt_custName.Text = CustomerName

        ' Load data into the DataGridView (grd_product)
        LoadProductData()

        ' Display current date in txt_date
        txt_date.Text = DateTime.Now.ToString("yyyy-MM-dd")
    End Sub

    Private Sub LoadProductData()
        Dim myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\A200321_ByteBlast\prj_ByteBlast_A200321\prj_ByteBlast_A200321\bin\Debug\DB_ByteBlast_A200321.accdb;"
        Dim mysql As String = "SELECT * FROM TBL_PRODUCTS_A200321 ORDER BY FLD_PRODUCT_ID"
        Dim mydatatable As New DataTable

        Try
            Using myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
                myreader.Fill(mydatatable)
            End Using

            grd_product.DataSource = mydatatable

            grd_product.Columns(0).HeaderText = "PRODUCT ID"
            grd_product.Columns(1).HeaderText = "PRODUCT NAME"
            ' Add more lines for other columns as needed
        Catch ex As Exception
            'MessageBox.Show("Error loading product data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txt_orderID_TextChanged(sender As Object, e As EventArgs) Handles txt_orderID.TextChanged

    End Sub

    Private _orderID As String

    Public Property OrderID As String
        Get
            Return _orderID
        End Get
        Set(value As String)
            _orderID = value
        End Set
    End Property

    Private _staffID As String

    Public Property staffID As String
        Get
            Return _staffID
        End Get
        Set(value As String)
            _staffID = value
        End Set
    End Property

    Private _StaffName As String

    Public Property StaffName As String
        Get
            Return _StaffName
        End Get
        Set(value As String)
            _StaffName = value
        End Set
    End Property

    Private _CustID As String

    Public Property CustID As String
        Get
            Return _CustID
        End Get
        Set(value As String)
            _CustID = value
        End Set
    End Property

    Private _CustomerName As String

    Public Property CustomerName As String
        Get
            Return _CustomerName
        End Get
        Set(value As String)
            _CustomerName = value
        End Set
    End Property

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_makeorder_A200321.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub grd_product_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_product.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < grd_product.Rows.Count Then
            ' Get data from the selected row
            Dim prodID As String = grd_product.Rows(e.RowIndex).Cells("FLD_PRODUCT_ID").Value.ToString()
            Dim prodName As String = grd_product.Rows(e.RowIndex).Cells("FLD_PRODUCT_NAME").Value.ToString()
            Dim prodPrice As String = grd_product.Rows(e.RowIndex).Cells("FLD_PRICE").Value.ToString()
            Dim prodWarranty As String = grd_product.Rows(e.RowIndex).Cells("FLD_WARRANTY").Value.ToString()

            ' Display data in the textboxes
            txt_prodid.Text = prodID
            txt_prodname.Text = prodName
            txt_prodprice.Text = prodPrice
            txt_prodwarranty.Text = prodWarranty
        End If
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        ClearProductDetails()
    End Sub

    Private Sub txt_qty_TextChanged(sender As Object, e As EventArgs) Handles txt_qty.TextChanged
        ' Check if the quantity and price are valid numeric values
        If IsNumeric(txt_qty.Text) AndAlso IsNumeric(txt_prodprice.Text) Then
            ' Calculate subtotal (quantity * price) and display in txt_subtotal
            Dim quantity As Integer = Integer.Parse(txt_qty.Text)
            Dim price As Decimal = Decimal.Parse(txt_prodprice.Text)
            Dim subtotal As Decimal = quantity * price

            txt_subtotal.Text = subtotal.ToString("0.00")
        Else
            ' If either quantity or price is not a valid numeric value, clear the subtotal
            txt_subtotal.Text = ""
        End If
    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        ' Check if all required fields are filled
        If ValidateFields() Then
            ' Insert the order item into TBL_ORDERITEM_A200321
            InsertOrderItem()

            ' Display the order items in grd_order
            LoadOrderItems()
        Else
            MessageBox.Show("Please fill in all the details before inserting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function ValidateFields() As Boolean
        ' Validate that all required fields are filled
        Return Not String.IsNullOrWhiteSpace(txt_prodid.Text) AndAlso
               Not String.IsNullOrWhiteSpace(txt_prodname.Text) AndAlso
               Not String.IsNullOrWhiteSpace(txt_qty.Text) AndAlso
               Not String.IsNullOrWhiteSpace(txt_prodprice.Text) AndAlso
               Not String.IsNullOrWhiteSpace(txt_subtotal.Text)
    End Function

    Private Sub InsertOrderItem()
        Try
            ' Establish connection string
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\A200321_ByteBlast\prj_ByteBlast_A200321\prj_ByteBlast_A200321\bin\Debug\DB_ByteBlast_A200321.accdb;Persist Security Info=False;"

            ' Create connection
            Using connection As New OleDb.OleDbConnection(connectionString)
                ' Open the connection
                connection.Open()

                ' SQL INSERT statement with parameterized query
                Dim sql As String = "INSERT INTO TBL_ORDERITEM_A200321 (FLD_ORDERITEM_ORDERID, FLD_ORDERITEM_PRODID, FLD_ORDERITEM_PRODNAME, FLD_ORDERITEM_PRODPRICE, FLD_ORDERITEM_WARRANTY, FLD_ORDERITEM_QTY, FLD_ORDERITEM_STAFFID, FLD_ORDERITEM_STAFFNAME, FLD_ORDERITEM_CUSTID, FLD_ORDERITEM_CUSTNAME, FLD_ORDERITEM_DATE) VALUES (@OrderID, @ProductID, @ProdName, @ProdPrice, @Warranty, @Quantity, @StaffID, @StaffNm, @CustID, @CustNm, @Date)"

                ' Create command
                Using command As New OleDb.OleDbCommand(sql, connection)
                    ' Add parameters
                    command.Parameters.AddWithValue("@OrderID", txt_orderID.Text)
                    command.Parameters.AddWithValue("@ProductID", txt_prodid.Text)
                    command.Parameters.AddWithValue("@ProdName", txt_prodname.Text)  ' <-- Corrected parameter name
                    command.Parameters.AddWithValue("@ProdPrice", Convert.ToDecimal(txt_prodprice.Text))
                    command.Parameters.AddWithValue("@Warranty", txt_prodwarranty.Text)
                    command.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txt_qty.Text))

                    command.Parameters.AddWithValue("@StaffID", txt_staffID.Text)
                    command.Parameters.AddWithValue("@StaffNm", txt_staffName.Text)
                    command.Parameters.AddWithValue("@CustID", txt_custID.Text)
                    command.Parameters.AddWithValue("@CustNm", txt_custName.Text)

                    command.Parameters.AddWithValue("@Date", txt_date.Text)

                    ' Execute the SQL command
                    command.ExecuteNonQuery()

                    MessageBox.Show("Order item inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As Exception
            ' Handle exceptions
            MessageBox.Show("Error inserting order item: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadOrderItems()
        Try
            ' Establish connection string
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\A200321_ByteBlast\prj_ByteBlast_A200321\prj_ByteBlast_A200321\bin\Debug\DB_ByteBlast_A200321.accdb;Persist Security Info=False;"

            ' Create connection
            Using connection As New OleDb.OleDbConnection(connectionString)
                ' Open the connection
                connection.Open()

                ' SQL SELECT statement
                Dim sql As String = "SELECT * FROM TBL_ORDERITEM_A200321 WHERE OrderID = '" & txt_orderID.Text & "'"

                ' Create data adapter
                Using adapter As New OleDb.OleDbDataAdapter(sql, connection)
                    ' Create a DataTable to store the result
                    Dim dataTable As New DataTable()

                    ' Fill the DataTable with data from the adapter
                    adapter.Fill(dataTable)

                    ' Set the DataTable as the DataSource for grd_order
                    grd_order.DataSource = dataTable
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading order items: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click
        ' Check if all required fields are filled
        If ValidateFields() Then
            ' Insert the order item into TBL_ORDERITEM_A200321
            InsertOrderItem()

            ' Display the order items in grd_order
            LoadOrderItems()

            ' Generate and display the increased order ID
            txt_orderID.Text = GenerateOrderID(txt_orderID.Text)

            ' Clear product details
            ClearProductDetails()
        Else
            MessageBox.Show("Please fill in all the details before inserting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function GenerateOrderID(existingOrderID As String) As String
        If Not String.IsNullOrEmpty(existingOrderID) Then
            ' Extract the numeric part from the existingOrderID
            Dim numericPart As Integer
            If Integer.TryParse(existingOrderID.Substring(1), numericPart) Then
                ' Increment and format the order ID
                Dim newOrderID As String = "O" & (numericPart + 1).ToString("00")
                Return newOrderID
            End If
        End If

        ' Default case if the existingOrderID is not valid
        Return "O01"
    End Function

    Private Sub ClearProductDetails()
        txt_prodid.Text = ""
        txt_prodname.Text = ""
        txt_prodprice.Text = ""
        txt_prodwarranty.Text = ""
        txt_qty.Text = ""
        txt_subtotal.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_order_A200321.Show()
        Me.Hide()
    End Sub
End Class