Module mod_globals_A200321
    Public username As String

    Public myconnection As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_ByteBlast_A200321.accdb;Persist Security Info=False;"

    Public myconnection2 As New OleDb.OleDbConnection(myconnection)

    Public Sub run_sql_command(thissql As String)

        Dim mywriter As New OleDb.OleDbCommand(thissql, myconnection2)

        Try

            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()

        Catch ex As Exception

            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)

            mywriter.Connection.Close()

        End Try

    End Sub

    Public Function run_sql_query(mysql As String) As DataTable

        Dim mytable As New DataTable

        Dim myreader As New OleDb.OleDbDataAdapter(mysql, myconnection)

        Try

            myreader.Fill(mytable)

        Catch ex As Exception

            Beep()
            MsgBox("There is an error:" & vbCrLf & vbCrLf & ex.Message)

        End Try

        Return mytable

    End Function

End Module
