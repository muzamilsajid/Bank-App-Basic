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
        Me.SuspendLayout()
        '
        'cmbBankName
        '
        Me.cmbBankName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBankName.FormattingEnabled = True
        Me.cmbBankName.Location = New System.Drawing.Point(15, 77)
        Me.cmbBankName.Name = "cmbBankName"
        Me.cmbBankName.Size = New System.Drawing.Size(131, 21)
        Me.cmbBankName.TabIndex = 11
        '
        'cmdAddUser
        '
        Me.cmdAddUser.Location = New System.Drawing.Point(16, 113)
        Me.cmdAddUser.Name = "cmdAddUser"
        Me.cmdAddUser.Size = New System.Drawing.Size(130, 23)
        Me.cmdAddUser.TabIndex = 10
        Me.cmdAddUser.Text = "Create Account"
        Me.cmdAddUser.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "UserName"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(15, 25)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(132, 20)
        Me.txtUser.TabIndex = 8
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(15, 51)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(132, 20)
        Me.txtPass.TabIndex = 12
        '
        'Account_Creation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(156, 148)
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
End Class
