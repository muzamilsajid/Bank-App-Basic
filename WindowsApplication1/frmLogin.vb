Imports System.Data
Imports System.Data.OleDb

Public Class frmLogin

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        com = "select * from tblbankname"
        'Adpt = New OleDbDataAdapter(com, conn)
        Try
            conn.Open()
            'ds.Clear()
            dt.Clear()
            Adpt.SelectCommand = New OleDbCommand(com, conn)
            Adpt.Fill(dt)

            Dim r As DataRow
            For Each r In dt.Rows
                cmbBankName.Items.Add(r(1).ToString())
            Next
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try

    End Sub

    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        Try
            If txtUserName.Text = "" Or cmbBankName.Text = "" Or txtPass.Text = "" Then
                MsgBox("Can Not Leave UserName or Bank Name or Password Empty!!")
                Exit Sub
            End If

            Call CanUserLogin()
            If LoggedIn = True Then
                CurrentUser = txtUserName.Text
                CurrentBank = cmbBankName.Text
                frmUserTransactions.Show()
                Call DisplayAllTransactions()
                txtUserName.Text = ""
                txtPass.Text = ""
                Me.Hide()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Public Function CanUserLogin()
        Try
            conn.Open()
            com = "select * from tblusers where username='" & txtUserName.Text & "' and bankname='" & cmbBankName.Text & "' and [pass]='" & txtPass.Text & "'"
            cmd = New OleDbCommand(com, conn)
            Dim DR As OleDbDataReader = cmd.ExecuteReader()
            If DR.HasRows Then
                LoggedIn = True
                Me.Text = "User Transactions = " & txtUserName.Text
            Else
                LoggedIn = False
                MsgBox("Wrong Credentials")
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try

    End Function

    Private Sub Form2_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Main.Show()
    End Sub
End Class