Public Class frm_products_A200321
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_mainmenu_A200321.Show()
        Me.Hide()
    End Sub

    Private Sub frm_products_A200321_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Load product names into the list
            Dim mysql As String = "SELECT FLD_PRODUCT_NAME FROM TBL_PRODUCTS_A200321 ORDER BY FLD_PRODUCT_ID"

            Dim mytable As New DataTable
            Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

            myreader.Fill(mytable)

            ' Use BindingSource for data binding
            Dim bindingSource As New BindingSource()
            bindingSource.DataSource = mytable
            lst_productname.DataSource = bindingSource
            lst_productname.DisplayMember = "FLD_PRODUCT_NAME"

            ' Display details for the first product
            If mytable.Rows.Count > 0 Then
                refresh_text(lst_productname.Text)
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        ' Call the refresh_list function to update the product list based on the search
        refresh_list(txt_search.Text)
    End Sub

    Private Sub refresh_list(searchTerm As String)
        Try
            ' Load product names into the list based on the search term
            Dim mysql As String = $"SELECT FLD_PRODUCT_NAME FROM TBL_PRODUCTS_A200321 WHERE FLD_PRODUCT_NAME LIKE '%{searchTerm}%' ORDER BY FLD_PRODUCT_NAME"

            Dim mytable As New DataTable
            Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

            myreader.Fill(mytable)

            ' Use BindingSource for data binding
            Dim bindingSource As New BindingSource()
            bindingSource.DataSource = mytable
            lst_productname.DataSource = bindingSource
            lst_productname.DisplayMember = "FLD_PRODUCT_NAME"

            ' Display details for the first product in the updated list
            If mytable.Rows.Count > 0 Then
                refresh_text(lst_productname.Text)
            Else
                ' Clear details if no products match the search term
                ClearProductDetails()
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub refresh_text(productName As String)
        Try
            ' Fetch product details by name
            Dim mysql As String = $"SELECT * FROM TBL_PRODUCTS_A200321 where FLD_PRODUCT_NAME like '%" & productName & "%'"

            Dim mytable As New DataTable
            Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

            myreader.Fill(mytable)

            ' Display details if the product is found
            If mytable.Rows.Count > 0 Then
                Dim productId As Integer = Convert.ToInt32(mytable.Rows(0).Item("FLD_PRODUCT_ID"))

                txt_prodname.Text = mytable.Rows(0).Item("FLD_PRODUCT_NAME")
                txt_prodprice.Text = mytable.Rows(0).Item("FLD_PRICE")
                txt_prodcapacity.Text = mytable.Rows(0).Item("FLD_CAPACITY")
                txt_produc.Text = mytable.Rows(0).Item("FLD_USECASE")
                txt_device.Text = mytable.Rows(0).Item("FLD_DEVICE")
                txt_prodwarranty.Text = mytable.Rows(0).Item("FLD_WARRANTY")
                txt_prodtype.Text = mytable.Rows(0).Item("FLD_TYPE")

                ' Load product image from the "pictures" folder using the product ID
                Dim imagePath As String = $"pictures\{productId}.png"
                If System.IO.File.Exists(imagePath) Then
                    pic_product.BackgroundImage = Image.FromFile(imagePath)
                Else
                    pic_product.BackgroundImage = Nothing
                End If
            Else
                ' Clear details if the product is not found
                ClearProductDetails()
            End If
        Catch ex As Exception
            MessageBox.Show("Error refreshing product details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub ClearProductDetails()
        ' Clear all product details
        txt_prodname.Text = ""
        txt_prodprice.Text = ""
        txt_prodcapacity.Text = ""
        txt_produc.Text = ""
        txt_device.Text = ""
        txt_prodwarranty.Text = ""
        txt_prodtype.Text = ""
        pic_product.BackgroundImage = Nothing
    End Sub

    Private Sub lst_productname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_productname.SelectedIndexChanged
        ' Update details when the selected product changes
        refresh_text(lst_productname.Text)
    End Sub

    Private Sub pic_product_Click(sender As Object, e As EventArgs) Handles pic_product.Click

    End Sub

    Private Sub btnInsert_update_Click(sender As Object, e As EventArgs) Handles btnInsert_update.Click
        frm_insertupdateProducts_A200321.Show()
        Me.Hide()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        frm_updateproduct_A200321.Show()
        Me.Hide()
    End Sub
End Class
