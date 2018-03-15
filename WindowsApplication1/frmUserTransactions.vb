Imports System.Data
Imports System.Data.OleDb

Public Class frmUserTransactions

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
        lblClosingBalance.Text = OpBalance + TotalDebit - TotalCredit
    End Function

    Private Sub cmdDeposit_Click(sender As Object, e As EventArgs) Handles cmdDeposit.Click
        Dim VarDebit As Double
        Try

            If LoggedIn = True Then
                VarDebit = InputBox("Enter Deposit Amount")
                conn.Open()
                cmd.CommandText = "insert into tbltransactions(UserName,bankname,debit,entrydate) values('" & CurrentUser & "','" & CurrentBank & "','" & VarDebit & "','" & System.DateTime.Now & "')"
                cmd.ExecuteNonQuery()
                conn.Close()
                Call DisplayAllTransactions()
                Call Balance()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try

    End Sub

    Private Sub frmUserTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Balance()
        Me.Text = "Transactions For - " & CurrentUser & " IN " & CurrentBank
    End Sub

    Private Sub Form2_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        LoggedIn = False
        Main.Show()
    End Sub

    Private Sub cmdWithDraw_Click(sender As Object, e As EventArgs) Handles cmdWithDraw.Click
        Dim VarCredit As Double
        Try

            If LoggedIn = True Then
                VarCredit = InputBox("Enter Deposit Amount")
                If Val(lblClosingBalance.Text) - Val(VarCredit) < 0 Then
                    MsgBox("Insufficient Funds")
                    Exit Sub
                Else
                    conn.Open()
                    cmd.CommandText = "insert into tbltransactions(UserName,bankname,credit,entrydate) values('" & CurrentUser & "','" & CurrentBank & "','" & VarCredit & "','" & System.DateTime.Now & "')"
                    cmd.ExecuteNonQuery()
                    conn.Close()
                    Call DisplayAllTransactions()
                    Call Balance()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class