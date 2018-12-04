<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicketSystemCreate
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
        Me.lbCreate = New System.Windows.Forms.Label()
        Me.Tier1 = New System.Windows.Forms.RadioButton()
        Me.Tier2 = New System.Windows.Forms.RadioButton()
        Me.Tier3 = New System.Windows.Forms.RadioButton()
        Me.lbT1 = New System.Windows.Forms.Label()
        Me.lbT2 = New System.Windows.Forms.Label()
        Me.lbT3 = New System.Windows.Forms.Label()
        Me.lbDescription = New System.Windows.Forms.Label()
        Me.txtDescIssue = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbCreate
        '
        Me.lbCreate.AutoSize = True
        Me.lbCreate.Location = New System.Drawing.Point(12, 9)
        Me.lbCreate.Name = "lbCreate"
        Me.lbCreate.Size = New System.Drawing.Size(361, 18)
        Me.lbCreate.TabIndex = 0
        Me.lbCreate.Text = "Select the Tier which represents the issue."
        '
        'Tier1
        '
        Me.Tier1.AutoSize = True
        Me.Tier1.Location = New System.Drawing.Point(15, 41)
        Me.Tier1.Name = "Tier1"
        Me.Tier1.Size = New System.Drawing.Size(73, 22)
        Me.Tier1.TabIndex = 1
        Me.Tier1.TabStop = True
        Me.Tier1.Text = "Tier 1"
        Me.Tier1.UseVisualStyleBackColor = True
        '
        'Tier2
        '
        Me.Tier2.AutoSize = True
        Me.Tier2.Location = New System.Drawing.Point(15, 74)
        Me.Tier2.Name = "Tier2"
        Me.Tier2.Size = New System.Drawing.Size(73, 22)
        Me.Tier2.TabIndex = 2
        Me.Tier2.TabStop = True
        Me.Tier2.Text = "Tier 2"
        Me.Tier2.UseVisualStyleBackColor = True
        '
        'Tier3
        '
        Me.Tier3.AutoSize = True
        Me.Tier3.Location = New System.Drawing.Point(15, 106)
        Me.Tier3.Name = "Tier3"
        Me.Tier3.Size = New System.Drawing.Size(73, 22)
        Me.Tier3.TabIndex = 3
        Me.Tier3.TabStop = True
        Me.Tier3.Text = "Tier 3"
        Me.Tier3.UseVisualStyleBackColor = True
        '
        'lbT1
        '
        Me.lbT1.AutoSize = True
        Me.lbT1.Location = New System.Drawing.Point(91, 45)
        Me.lbT1.Name = "lbT1"
        Me.lbT1.Size = New System.Drawing.Size(343, 18)
        Me.lbT1.TabIndex = 4
        Me.lbT1.Text = "Default/General Help, use this if unsure."
        '
        'lbT2
        '
        Me.lbT2.AutoSize = True
        Me.lbT2.Location = New System.Drawing.Point(91, 78)
        Me.lbT2.Name = "lbT2"
        Me.lbT2.Size = New System.Drawing.Size(205, 18)
        Me.lbT2.TabIndex = 5
        Me.lbT2.Text = "Software Install/Update"
        '
        'lbT3
        '
        Me.lbT3.AutoSize = True
        Me.lbT3.Location = New System.Drawing.Point(91, 110)
        Me.lbT3.Name = "lbT3"
        Me.lbT3.Size = New System.Drawing.Size(78, 18)
        Me.lbT3.TabIndex = 6
        Me.lbT3.Text = "Ordering"
        '
        'lbDescription
        '
        Me.lbDescription.AutoSize = True
        Me.lbDescription.Location = New System.Drawing.Point(20, 161)
        Me.lbDescription.Name = "lbDescription"
        Me.lbDescription.Size = New System.Drawing.Size(167, 18)
        Me.lbDescription.TabIndex = 7
        Me.lbDescription.Text = "Describe the issue:"
        '
        'txtDescIssue
        '
        Me.txtDescIssue.Location = New System.Drawing.Point(23, 182)
        Me.txtDescIssue.Multiline = True
        Me.txtDescIssue.Name = "txtDescIssue"
        Me.txtDescIssue.Size = New System.Drawing.Size(399, 124)
        Me.txtDescIssue.TabIndex = 8
        '
        'TicketSystemCreate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(456, 318)
        Me.Controls.Add(Me.txtDescIssue)
        Me.Controls.Add(Me.lbDescription)
        Me.Controls.Add(Me.lbT3)
        Me.Controls.Add(Me.lbT2)
        Me.Controls.Add(Me.lbT1)
        Me.Controls.Add(Me.Tier3)
        Me.Controls.Add(Me.Tier2)
        Me.Controls.Add(Me.Tier1)
        Me.Controls.Add(Me.lbCreate)
        Me.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "TicketSystemCreate"
        Me.Text = "Create Ticket"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbCreate As Label
    Friend WithEvents Tier1 As RadioButton
    Friend WithEvents Tier2 As RadioButton
    Friend WithEvents Tier3 As RadioButton
    Friend WithEvents lbT1 As Label
    Friend WithEvents lbT2 As Label
    Friend WithEvents lbT3 As Label
    Friend WithEvents lbDescription As Label
    Friend WithEvents txtDescIssue As TextBox
End Class
