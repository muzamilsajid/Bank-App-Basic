Imports System.Data
Imports System.Data.OleDb

Public Class frmUserTransactions

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

    Private Sub cmdTransfer_Click(sender As Object, e As EventArgs) Handles cmdTransfer.Click
        frmTransfer.Show()
    End Sub
End Class