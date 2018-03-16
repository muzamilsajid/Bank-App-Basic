Imports System.Data
Imports System.Data.OleDb

Public Class frmTransfer
    Private Sub Form2_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'LoggedIn = False
        frmUserTransactions.Show()
    End Sub

    Private Sub cmdTransfer_Click(sender As Object, e As EventArgs) Handles cmdTransfer.Click
        Try
            If txtUserName.Text = "" Or cmbBankName.Text = "" Or Val(txtAmount.Text) <= 0 Then
                MsgBox("Can Not leave UserName or Bank Empty or Amount <= 0")
                Exit Sub
            Else
                conn.Open()
                com = "select * from tblusers where username='" & txtUserName.Text & "' and bankname='" & cmbBankName.Text & "'"
                cmd = New OleDbCommand(com, conn)
                Dim DR As OleDbDataReader = cmd.ExecuteReader()
                If DR.HasRows Then
                    conn.Close()
                    TransferUser = txtUserName.Text
                    TransferBank = cmbBankName.Text
                    Call Transfer()
                Else
                    MsgBox("Account Not Found")
                End If
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class