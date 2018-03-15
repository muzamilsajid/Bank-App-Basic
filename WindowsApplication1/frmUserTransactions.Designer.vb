<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUserTransactions
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmdDeposit = New System.Windows.Forms.Button()
        Me.cmdWithDraw = New System.Windows.Forms.Button()
        Me.lblClosingBalance = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 7)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(782, 362)
        Me.DataGridView1.TabIndex = 0
        '
        'cmdDeposit
        '
        Me.cmdDeposit.Location = New System.Drawing.Point(12, 373)
        Me.cmdDeposit.Name = "cmdDeposit"
        Me.cmdDeposit.Size = New System.Drawing.Size(139, 26)
        Me.cmdDeposit.TabIndex = 1
        Me.cmdDeposit.Text = "Deposit"
        Me.cmdDeposit.UseVisualStyleBackColor = True
        '
        'cmdWithDraw
        '
        Me.cmdWithDraw.Location = New System.Drawing.Point(157, 375)
        Me.cmdWithDraw.Name = "cmdWithDraw"
        Me.cmdWithDraw.Size = New System.Drawing.Size(139, 24)
        Me.cmdWithDraw.TabIndex = 2
        Me.cmdWithDraw.Text = "WithDraw"
        Me.cmdWithDraw.UseVisualStyleBackColor = True
        '
        'lblClosingBalance
        '
        Me.lblClosingBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClosingBalance.Location = New System.Drawing.Point(613, 372)
        Me.lblClosingBalance.Name = "lblClosingBalance"
        Me.lblClosingBalance.Size = New System.Drawing.Size(181, 20)
        Me.lblClosingBalance.TabIndex = 3
        Me.lblClosingBalance.Text = "0"
        Me.lblClosingBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(524, 376)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Closing Balance"
        '
        'frmUserTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 402)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblClosingBalance)
        Me.Controls.Add(Me.cmdWithDraw)
        Me.Controls.Add(Me.cmdDeposit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmUserTransactions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmUserTransactions"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cmdDeposit As Button
    Friend WithEvents cmdWithDraw As Button
    Friend WithEvents lblClosingBalance As Label
    Friend WithEvents Label2 As Label
End Class
