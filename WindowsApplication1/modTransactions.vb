Imports System.Data
Imports System.Data.OleDb
Module modTransactions
    Public Function DisplayAllTransactions()
        Try
            com = "select * from tbltransactions where username='" & CurrentUser & "' and bankname='" & CurrentBank & "'"
            Adpt = New OleDbDataAdapter(com, conn)
            conn.Open()
            ds.Clear()
            frmUserTransactions.DataGridView1.DataSource = Nothing
            Adpt.Fill(ds, "Tbltransactions")
            frmUserTransactions.DataGridView1.DataSource = ds.Tables("tbltransactions")
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Function Transfer()
        Dim VarDebit As Double
        Try
            VarDebit = InputBox("Enter Deposit Amount")
            conn.Open()
            cmd.CommandText = "insert into tbltransactions(UserName,bankname,debit,entrydate) values('" & CurrentUser & "','" & CurrentBank & "','" & VarDebit & "','" & System.DateTime.Now & "')"
            cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Function

End Module
