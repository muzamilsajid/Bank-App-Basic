Imports System.Data.OleDb

Public Module AccountCreationVar
    Public AccountExists As Boolean = True
End Module
Public Class Account_Creation
    Private Sub cmdAddUser_Click(sender As Object, e As EventArgs) Handles cmdAddUser.Click
        Try
            If txtUser.Text = "" Or cmbBankName.Text = "" Or txtPass.Text = "" Then
                MsgBox("Can Not Leave UserName or Bank Name or Password Empty!!")
                Exit Sub
            End If

            Call DoesAccountExist()
            If AccountExists = False Then
                conn.Open()
                cmd.CommandText = "insert into tblusers(UserName,bankname,pass) values('" & txtUser.Text & "','" & cmbBankName.Text & "','" & txtPass.Text & "'"
                cmd.ExecuteNonQuery()
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Account_Creation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            com = "select * from tblbankname"
            'Adpt = New OleDbDataAdapter(com, conn)
            conn.Open()
            ds.Clear()
            Adpt.SelectCommand = New OleDbCommand(com, conn)
            Adpt.Fill(dt)

            Dim r As DataRow
            cmbBankName.Items.Clear()
            For Each r In dt.Rows
                cmbBankName.Items.Add(r(1).ToString())
            Next
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub

    Public Function DoesAccountExist()
        Try
            conn.Open()
            com = "select * from tblusers where username='" & txtUser.Text & "' and bankname='" & cmbBankName.Text & "'"
            cmd = New OleDbCommand(com, conn)
            Dim DR As OleDbDataReader = cmd.ExecuteReader()
            If DR.HasRows Then
                AccountExists = True
                MsgBox("Account Exists")
            Else
                AccountExists = False
                MsgBox("Account Created")
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Function
End Class