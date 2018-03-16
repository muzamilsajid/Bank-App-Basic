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
            conn.Close()
        End Try
    End Function

    Public Function Transfer()
        Dim VarTransfer As Double
        Try
            VarTransfer = frmTransfer.txtAmount.Text
            If Val(frmUserTransactions.lblClosingBalance.Text) - Val(VarTransfer) < 0 Then
                MsgBox("Insufficient Funds")
            Else
                conn.Open()
                cmd.CommandText = "insert into tbltransactions(UserName,bankname,debit,entrydate) values('" & TransferUser & "','" & TransferBank & "','" & VarTransfer & "','" & System.DateTime.Now & "')"
                cmd.ExecuteNonQuery()
                cmd.CommandText = "insert into tbltransactions(UserName,bankname,credit,entrydate) values('" & CurrentUser & "','" & CurrentBank & "','" & VarTransfer & "','" & System.DateTime.Now & "')"
                cmd.ExecuteNonQuery()
                conn.Close()
                MsgBox("Funds Transfferd Successfully")
                Call DisplayAllTransactions()
                Call Balance()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Function

    Public Function Balance()
        Dim OpBalance As Double
        Dim TotalDebit As Double
        Dim TotalCredit As Double

        OpBalance = 0
        TotalDebit = 0
        TotalCredit = 0

        Try
            'Initial Balance
            conn.Open()
            com = "select initialbalance from tblusers where username='" & CurrentUser & "' and bankname='" & CurrentBank & "'"
            cmd = New OleDbCommand(com, conn)
            Dim DR As OleDbDataReader = cmd.ExecuteReader()
            While DR.Read()
                OpBalance = DR("InitialBalance")
            End While
            conn.Close()

            'Sumation of Debit
            conn.Open()
            com = "select sum(debit) as dt from tbltransactions where username='" & CurrentUser & "' and bankname='" & CurrentBank & "'"
            cmd = New OleDbCommand(com, conn)
            DR = cmd.ExecuteReader()
            While DR.Read()
                TotalDebit = DR("dt")
            End While
            conn.Close()

            'Sumation of Credit
            conn.Open()
            com = "select sum(Credit) as Cr from tbltransactions where username='" & CurrentUser & "' and bankname='" & CurrentBank & "'"
            cmd = New OleDbCommand(com, conn)
            DR = cmd.ExecuteReader()
            While DR.Read()
                TotalCredit = DR("Cr")
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
        frmUserTransactions.lblClosingBalance.Text = OpBalance + TotalDebit - TotalCredit
        frmUserTransactions.lblInitialBalance.Text = OpBalance
    End Function

End Module
