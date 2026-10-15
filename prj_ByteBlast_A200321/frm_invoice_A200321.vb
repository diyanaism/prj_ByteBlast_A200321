Public Class frm_invoice_A200321
    ' Assuming myconnection is declared at the class level
    Private myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\A200321_ByteBlast\prj_ByteBlast_A200321\prj_ByteBlast_A200321\bin\Debug\DB_ByteBlast_A200321.accdb;Persist Security Info=False;"

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_A200321.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub frm_invoice_A200321_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOrderIDs()
    End Sub

    Private Sub LoadOrderIDs()
        ' Load distinct order IDs into lst_orderID
        Dim mysql As String = "SELECT DISTINCT FLD_ORDER_ID FROM TBL_ORDER_A200321"
        Dim orderTable As New DataTable

        Try
            Using myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)
                myreader.Fill(orderTable)
            End Using

            ' Populate lst_orderID
            lst_orderID.DataSource = orderTable
            lst_orderID.DisplayMember = "FLD_ORDER_ID"
        Catch ex As Exception
            MessageBox.Show("Error loading order IDs: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lst_orderID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_orderID.SelectedIndexChanged
        ' Display details in grd_invoice and textboxes based on the selected order ID
        Dim selectedOrderID As String = lst_orderID.Text
        LoadOrderDetails(selectedOrderID)
    End Sub

    Private Sub LoadOrderDetails(orderID As String)
        Try
            ' Load product details from TBL_ORDERITEM_A200321 based on the selected order ID
            Dim mysqlOrderItem As String = "SELECT FLD_ORDERITEM_PRODNAME, FLD_ORDERITEM_PRODPRICE, FLD_ORDERITEM_QTY FROM TBL_ORDERITEM_A200321 WHERE FLD_ORDERITEM_ORDERID = @OrderID"

            Using myreaderOrderItem As New OleDb.OleDbDataAdapter(mysqlOrderItem, myconnection)
                ' Clear previous data
                grd_invoice.DataSource = Nothing

                ' Add parameter for OrderID
                myreaderOrderItem.SelectCommand.Parameters.AddWithValue("@OrderID", orderID)

                ' Fill the DataGridView with product details
                Dim orderItemTable As New DataTable()
                myreaderOrderItem.Fill(orderItemTable)

                ' Set the DataTable as the DataSource for grd_invoice
                grd_invoice.DataSource = orderItemTable
            End Using


            ' Load order details from TBL_ORDER_A200321 based on the selected order ID
            'Dim mysqlOrder As String = "SELECT FLD_STAFF_ID, FLD_STAFF_NAME, FLD_CUST_ID, FLD_CUST_NAME FROM TBL_ORDER_A200321 WHERE FLD_ORDER_ID = @OrderID"

            'Using myreaderOrder As New OleDb.OleDbDataAdapter(mysqlOrder, myconnection)
            '    ' Add parameter for OrderID
            '    myreaderOrder.SelectCommand.Parameters.AddWithValue("@OrderID", orderID)

            '    ' Fill a DataTable with order details
            '    Dim orderTable As New DataTable()
            '    myreaderOrder.Fill(orderTable)

            '    ' Display staff and customer details in textboxes
            '    If orderTable.Rows.Count > 0 Then
            '        txt_staffID.Text = orderTable.Rows(0).Item("FLD_STAFF_ID").ToString()
            '        txt_staffName.Text = orderTable.Rows(0).Item("FLD_STAFF_NAME").ToString()
            '        txt_custID.Text = orderTable.Rows(0).Item("FLD_CUST_ID").ToString()
            '        txt_custName.Text = orderTable.Rows(0).Item("FLD_CUST_NAME").ToString()
            '    Else
            '        ' Clear textboxes if no data is found
            '        txt_staffID.Text = ""
            '        txt_staffName.Text = ""
            '        txt_custID.Text = ""
            '        txt_custName.Text = ""
            '    End If
            'End Using

            ' Calculate and display subtotal
            CalculateAndDisplaySubtotal()

            ' Set lbl_orderDt.Text with the current date
            lbl_orderDt.Text = DateTime.Now.ToString("yyyy-MM-dd")
        Catch ex As Exception
            MessageBox.Show("Error loading order details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CalculateAndDisplaySubtotal()
        ' Calculate subtotal based on the data in grd_invoice
        Dim subtotal As Decimal = 0

        For Each row As DataGridViewRow In grd_invoice.Rows
            Dim quantity As Integer = Convert.ToInt32(row.Cells("FLD_ORDERITEM_QTY").Value)
            Dim price As Decimal = Convert.ToDecimal(row.Cells("FLD_ORDERITEM_PRODPRICE").Value)
            subtotal += quantity * price
        Next

        ' Display subtotal in txt_subtotal
        txt_subtotal.Text = subtotal.ToString("0.00")
    End Sub

    Private Sub lbl_orderDt_TextChanged(sender As Object, e As EventArgs) Handles lbl_orderDt.TextChanged
        Dim currentDate As Date = DateTime.Now.Date
        MessageBox.Show("Current Date: " & currentDate.ToString("yyyy-MM-dd"))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_order_A200321.Show()
        Me.Hide()
    End Sub

    Private Sub grd_invoice_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grd_invoice.CellContentClick

    End Sub
End Class
