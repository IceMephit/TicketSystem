<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicketSystemLogin
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
        Me.lbLoginText = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lbPassword = New System.Windows.Forms.Label()
        Me.lbUserName = New System.Windows.Forms.Label()
        Me.txtbPassword = New System.Windows.Forms.TextBox()
        Me.txtbUserName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbLoginText
        '
        Me.lbLoginText.AutoSize = True
        Me.lbLoginText.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLoginText.Location = New System.Drawing.Point(131, 20)
        Me.lbLoginText.Name = "lbLoginText"
        Me.lbLoginText.Size = New System.Drawing.Size(226, 18)
        Me.lbLoginText.TabIndex = 14
        Me.lbLoginText.Text = "Login to use this program."
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(275, 123)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(83, 28)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(134, 123)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(74, 28)
        Me.btnLogin.TabIndex = 12
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lbPassword
        '
        Me.lbPassword.AutoSize = True
        Me.lbPassword.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPassword.Location = New System.Drawing.Point(43, 93)
        Me.lbPassword.Name = "lbPassword"
        Me.lbPassword.Size = New System.Drawing.Size(85, 18)
        Me.lbPassword.TabIndex = 11
        Me.lbPassword.Text = "Password"
        '
        'lbUserName
        '
        Me.lbUserName.AutoSize = True
        Me.lbUserName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUserName.Location = New System.Drawing.Point(30, 60)
        Me.lbUserName.Name = "lbUserName"
        Me.lbUserName.Size = New System.Drawing.Size(98, 18)
        Me.lbUserName.TabIndex = 10
        Me.lbUserName.Text = "User Name"
        '
        'txtbPassword
        '
        Me.txtbPassword.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbPassword.Location = New System.Drawing.Point(134, 90)
        Me.txtbPassword.Name = "txtbPassword"
        Me.txtbPassword.Size = New System.Drawing.Size(224, 27)
        Me.txtbPassword.TabIndex = 9
        Me.txtbPassword.UseSystemPasswordChar = True
        '
        'txtbUserName
        '
        Me.txtbUserName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbUserName.Location = New System.Drawing.Point(134, 57)
        Me.txtbUserName.Name = "txtbUserName"
        Me.txtbUserName.Size = New System.Drawing.Size(224, 27)
        Me.txtbUserName.TabIndex = 15
        Me.txtbUserName.UseSystemPasswordChar = True
        '
        'TicketSystemLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(388, 171)
        Me.Controls.Add(Me.txtbUserName)
        Me.Controls.Add(Me.lbLoginText)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lbPassword)
        Me.Controls.Add(Me.lbUserName)
        Me.Controls.Add(Me.txtbPassword)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "TicketSystemLogin"
        Me.Text = "Ticket System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbLoginText As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents lbPassword As Label
    Friend WithEvents lbUserName As Label
    Friend WithEvents txtbPassword As TextBox
    Friend WithEvents txtbUserName As TextBox
End Class
