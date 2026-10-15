Imports System.IO

Public Class frm_insertupdateProducts_A200321
    Dim myconnection2 As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_ByteBlast_A200321.accdb;Persist Security Info=False;")

    ' Create an instance of OpenFileDialog
    Dim openFileDialog As New OpenFileDialog()

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl_productnm.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txt_prodname.TextChanged

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_products_A200321.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub frm_insertupdateProducts_A200321_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        grd_product.DataSource = run_sql_query("SELECT * FROM TBL_PRODUCTS_A200321")

        txt_prodid.Text = generate_matric()

    End Sub

    Private Function generate_matric() As Integer
        Dim lastmatric As Integer = Convert.ToInt32(run_sql_query("Select MAX(FLD_PRODUCT_ID) As LASTMATRIC from TBL_PRODUCTS_A200321").Rows(0).Item("LASTMATRIC"))

        'MsgBox(lastmatric)

        Dim newmatric As Integer = lastmatric + 1

        Return newmatric
    End Function

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Dim productId As Integer

        ' Validate Product ID input
        If Not Integer.TryParse(txt_prodid.Text, productId) Then
            MsgBox("Please enter a valid integer for Product ID.", MsgBoxStyle.Exclamation)
            Return
        End If

        ' Validate Product Price input
        Dim productPrice As Decimal
        If Not Decimal.TryParse(txt_prodprice.Text, productPrice) Then
            MsgBox("Please enter a valid decimal number for Product Price.", MsgBoxStyle.Exclamation)
            Return
        End If

        If Not IsProductIdUnique(productId) Then
            MsgBox("Product ID already exists. Please generate a new one.")
            Return
        End If

        Dim mysql As String = "INSERT INTO TBL_PRODUCTS_A200321 VALUES (@id, @name, @price, @type, @uc, @device, @warranty, @capacity)"
        Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

        Try
            mywriter.Parameters.AddWithValue("@id", productId)
            mywriter.Parameters.AddWithValue("@name", txt_prodname.Text)
            mywriter.Parameters.AddWithValue("@price", productPrice)
            mywriter.Parameters.AddWithValue("@type", txt_prodtype.Text)
            mywriter.Parameters.AddWithValue("@uc", txt_produc.Text)
            mywriter.Parameters.AddWithValue("@device", txt_device.Text)
            mywriter.Parameters.AddWithValue("@warranty", txt_prodwarranty.Text)
            mywriter.Parameters.AddWithValue("@capacity", txt_prodcapacity.Text)

            myconnection2.Open()
            mywriter.ExecuteNonQuery()

            ' Notify the user of successful insertion
            MsgBox("Product details successfully inserted!", MsgBoxStyle.Information)

        Catch ex As Exception
            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
        Finally
            If myconnection2.State = ConnectionState.Open Then
                myconnection2.Close()
            End If

            ' Check if a file is selected
            If openFileDialog.FileName <> "" Then
                ' Get the selected file path
                Dim imagePath As String = openFileDialog.FileName

                ' Save the image path to the database or handle it as needed
                ' For example, you might want to store the path in a column like FLD_PRODUCT_IMAGE_PATH

                ' Display a message or perform any other action as needed
                MsgBox("Product picture selected: " & imagePath, MsgBoxStyle.Information)

            End If

        End Try


    End Sub

    Private Function IsProductIdUnique(productId As Integer) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM TBL_PRODUCTS_A200321 WHERE FLD_PRODUCT_ID = @id"
        Dim cmd As New OleDb.OleDbCommand(query, myconnection2)

        Try
            cmd.Parameters.AddWithValue("@id", productId) ' Assuming FLD_PRODUCT_ID is an integer
            myconnection2.Open()
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count = 0
        Catch ex As Exception
            Beep()
            MsgBox("Error checking for duplicate Product ID: " & ex.Message)
            Return False
        Finally
            If myconnection2.State = ConnectionState.Open Then
                myconnection2.Close()
            End If
        End Try
    End Function

    ' Handle the Click event of the button to select a product picture
    Private Sub btn_addpic_Click(sender As Object, e As EventArgs) Handles btn_addpic.Click
        ' Set the properties of the OpenFileDialog
        With openFileDialog
            .Title = "Select Product Picture"
            .Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*"
            .FilterIndex = 1
            .RestoreDirectory = True
        End With

        ' Show the OpenFileDialog
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Display the selected file name
            lbl_selected_picture.Text = Path.GetFileName(openFileDialog.FileName)
        End If
    End Sub

End Class