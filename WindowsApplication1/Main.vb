Imports System.Data.Common
Imports System.Data.OleDb

Public Module Variables
    Public str As String = "Provider=Microsoft.ACE.OLEDB.12.0;data source=e:\bank\bankdb.mdb"
    Public conn As OleDbConnection = New OleDbConnection(str)
    Public com As String = "SELECT * FROM tblbankname"
    Public Adpt As New OleDbDataAdapter(com, conn)
    Public cmd As New OleDbCommand
    Public ds As New DataSet
    Public dt As New DataTable
End Module
Public Class Main

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'conn.Open()
        cmd.Connection = conn
        'conn.Open()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdCreateAccount.Click

        Account_Creation.Show()

    End Sub

    Private Sub cmdBankNames_Click(sender As Object, e As EventArgs) Handles cmdBankNames.Click
        Call DisplayAllBanks()
    End Sub

    Private Sub cmdUsers_Click(sender As Object, e As EventArgs) Handles cmdUsers.Click
        Call DisplayAllUsers()
    End Sub

    Public Function DisplayAllBanks()
        Try
            com = "select * from tblbankname"
            Adpt = New OleDbDataAdapter(com, conn)
            conn.Open()
            ds.Clear()
            DataGridView1.DataSource = Nothing
            Adpt.Fill(ds, "Tblbankname")
            DataGridView1.DataSource = ds.Tables("Tblbankname")
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Function

    Public Function DisplayAllUsers()
        Try
            com = "select UserName,BankName from tblusers"
            Adpt = New OleDbDataAdapter(com, conn)
            conn.Open()
            ds.Clear()
            DataGridView1.DataSource = Nothing
            Adpt.Fill(ds, "Tblusers")
            DataGridView1.DataSource = ds.Tables("tblusers")
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Function

    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DisplayAllBanks()
    End Sub
End Class
