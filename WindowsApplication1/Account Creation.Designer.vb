<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Account_Creation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmbBankName = New System.Windows.Forms.ComboBox()
        Me.cmdAddUser = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtInitialBalance = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbBankName
        '
        Me.cmbBankName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBankName.FormattingEnabled = True
        Me.cmbBankName.Location = New System.Drawing.Point(86, 70)
        Me.cmbBankName.Name = "cmbBankName"
        Me.cmbBankName.Size = New System.Drawing.Size(131, 21)
        Me.cmbBankName.TabIndex = 2
        '
        'cmdAddUser
        '
        Me.cmdAddUser.Location = New System.Drawing.Point(86, 123)
        Me.cmdAddUser.Name = "cmdAddUser"
        Me.cmdAddUser.Size = New System.Drawing.Size(130, 23)
        Me.cmdAddUser.TabIndex = 4
        Me.cmdAddUser.Text = "Create Account"
        Me.cmdAddUser.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "UserName"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(86, 18)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(132, 20)
        Me.txtUser.TabIndex = 0
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(86, 44)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(132, 20)
        Me.txtPass.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Bank:"
        '
        'txtInitialBalance
        '
        Me.txtInitialBalance.Location = New System.Drawing.Point(86, 97)
        Me.txtInitialBalance.Name = "txtInitialBalance"
        Me.txtInitialBalance.Size = New System.Drawing.Size(132, 20)
        Me.txtInitialBalance.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Initial Deposit:"
        '
        'Account_Creation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(227, 154)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtInitialBalance)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.cmbBankName)
        Me.Controls.Add(Me.cmdAddUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUser)
        Me.Name = "Account_Creation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account_Creation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbBankName As ComboBox
    Friend WithEvents cmdAddUser As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtInitialBalance As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
