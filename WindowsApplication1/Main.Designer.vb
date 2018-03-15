<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cmdCreateAccount = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmdBankNames = New System.Windows.Forms.Button()
        Me.cmdUsers = New System.Windows.Forms.Button()
        Me.cmdLogin = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCreateAccount
        '
        Me.cmdCreateAccount.Location = New System.Drawing.Point(13, 82)
        Me.cmdCreateAccount.Name = "cmdCreateAccount"
        Me.cmdCreateAccount.Size = New System.Drawing.Size(127, 32)
        Me.cmdCreateAccount.TabIndex = 0
        Me.cmdCreateAccount.Text = "Create Account"
        Me.cmdCreateAccount.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(146, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(347, 458)
        Me.DataGridView1.TabIndex = 1
        '
        'cmdBankNames
        '
        Me.cmdBankNames.Location = New System.Drawing.Point(12, 8)
        Me.cmdBankNames.Name = "cmdBankNames"
        Me.cmdBankNames.Size = New System.Drawing.Size(128, 28)
        Me.cmdBankNames.TabIndex = 2
        Me.cmdBankNames.Text = "All Banks"
        Me.cmdBankNames.UseVisualStyleBackColor = True
        '
        'cmdUsers
        '
        Me.cmdUsers.Location = New System.Drawing.Point(13, 42)
        Me.cmdUsers.Name = "cmdUsers"
        Me.cmdUsers.Size = New System.Drawing.Size(126, 34)
        Me.cmdUsers.TabIndex = 3
        Me.cmdUsers.Text = "All Users"
        Me.cmdUsers.UseVisualStyleBackColor = True
        '
        'cmdLogin
        '
        Me.cmdLogin.Location = New System.Drawing.Point(13, 121)
        Me.cmdLogin.Name = "cmdLogin"
        Me.cmdLogin.Size = New System.Drawing.Size(126, 37)
        Me.cmdLogin.TabIndex = 4
        Me.cmdLogin.Text = "Login"
        Me.cmdLogin.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 476)
        Me.Controls.Add(Me.cmdLogin)
        Me.Controls.Add(Me.cmdUsers)
        Me.Controls.Add(Me.cmdBankNames)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmdCreateAccount)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdCreateAccount As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cmdBankNames As Button
    Friend WithEvents cmdUsers As Button
    Friend WithEvents cmdLogin As Button
End Class
