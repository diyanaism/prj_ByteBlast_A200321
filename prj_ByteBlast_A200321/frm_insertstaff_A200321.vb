Imports System.IO

Public Class frm_insertstaff_A200321
    ' ...

    Dim myconnection2 As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_ByteBlast_A200321.accdb;Persist Security Info=False;")

    ' Create an instance of OpenFileDialog
    Dim openFileDialog As New OpenFileDialog()

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        frm_staff_A200321.Show()
        Me.Hide()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub frm_insertupdateProducts_A200321_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
        txt_staffid.Text = generate_matric()

        grd_staff.Columns(0).HeaderText = "STAFF ID"
        grd_staff.Columns(1).HeaderText = "NAME"
        grd_staff.Columns(2).HeaderText = "AGE"
        grd_staff.Columns(3).HeaderText = "POSITION"
    End Sub

    Private Function generate_matric() As String
        Dim lastmatric As String = run_sql_query("Select MAX(FLD_STAFF_ID) As LASTMATRIC from TBL_STAFF_A200321").Rows(0).Item("LASTMATRIC")

        'MsgBox(lastmatric)

        Dim newmatric As String = "S" & (CInt(Mid(lastmatric, 2)) + 1).ToString("00")

        Return newmatric
    End Function

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click
        Try
            ' Validate staff age input
            Dim staffAge As Decimal
            If Not Decimal.TryParse(txt_staffage.Text, staffAge) Then
                MsgBox("Please enter a valid decimal number for Staff Age.", MsgBoxStyle.Exclamation)
                Return
            End If

            Dim mysql As String = "INSERT INTO TBL_STAFF_A200321 VALUES (@id, @name, @age, @position)"
            Dim mywriter As New OleDb.OleDbCommand(mysql, myconnection2)

            mywriter.Parameters.AddWithValue("@id", txt_staffid.Text)
            mywriter.Parameters.AddWithValue("@name", txt_staffname.Text)
            mywriter.Parameters.AddWithValue("@age", staffAge)
            mywriter.Parameters.AddWithValue("@position", txt_staffposition.Text)

            myconnection2.Open()
            mywriter.ExecuteNonQuery()

            ' Notify the user of successful insertion
            MsgBox("Staff details successfully inserted!", MsgBoxStyle.Information)

            ' Refresh the grid and generate a new matric after successful insertion
            RefreshGrid()
            txt_staffid.Text = generate_matric()
            txt_staffname.Text = ""
            txt_staffage.Text = ""
            txt_staffposition.Text = ""

        Catch ex As Exception
            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
        Finally
            If myconnection2.State = ConnectionState.Open Then
                myconnection2.Close()
            End If
        End Try
    End Sub

    Private Sub RefreshGrid()
        grd_staff.DataSource = run_sql_query("SELECT * FROM TBL_STAFF_A200321")
    End Sub

    ' ...
End Class
