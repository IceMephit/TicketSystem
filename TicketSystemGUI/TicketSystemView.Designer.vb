<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TicketSystemView
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
        Me.rbOpen = New System.Windows.Forms.RadioButton()
        Me.rbT2O = New System.Windows.Forms.RadioButton()
        Me.rbT1O = New System.Windows.Forms.RadioButton()
        Me.rbT3O = New System.Windows.Forms.RadioButton()
        Me.rbClosed = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'rbOpen
        '
        Me.rbOpen.AutoSize = True
        Me.rbOpen.Location = New System.Drawing.Point(21, 20)
        Me.rbOpen.Name = "rbOpen"
        Me.rbOpen.Size = New System.Drawing.Size(160, 22)
        Me.rbOpen.TabIndex = 0
        Me.rbOpen.TabStop = True
        Me.rbOpen.Text = "All Open Tickets"
        Me.rbOpen.UseVisualStyleBackColor = True
        '
        'rbT2O
        '
        Me.rbT2O.AutoSize = True
        Me.rbT2O.Location = New System.Drawing.Point(376, 20)
        Me.rbT2O.Name = "rbT2O"
        Me.rbT2O.Size = New System.Drawing.Size(122, 22)
        Me.rbT2O.TabIndex = 1
        Me.rbT2O.TabStop = True
        Me.rbT2O.Text = "Open Tier 2"
        Me.rbT2O.UseVisualStyleBackColor = True
        '
        'rbT1O
        '
        Me.rbT1O.AutoSize = True
        Me.rbT1O.Location = New System.Drawing.Point(206, 20)
        Me.rbT1O.Name = "rbT1O"
        Me.rbT1O.Size = New System.Drawing.Size(122, 22)
        Me.rbT1O.TabIndex = 2
        Me.rbT1O.TabStop = True
        Me.rbT1O.Text = "Open Tier 1"
        Me.rbT1O.UseVisualStyleBackColor = True
        '
        'rbT3O
        '
        Me.rbT3O.AutoSize = True
        Me.rbT3O.Location = New System.Drawing.Point(538, 20)
        Me.rbT3O.Name = "rbT3O"
        Me.rbT3O.Size = New System.Drawing.Size(122, 22)
        Me.rbT3O.TabIndex = 3
        Me.rbT3O.TabStop = True
        Me.rbT3O.Text = "Open Tier 3"
        Me.rbT3O.UseVisualStyleBackColor = True
        '
        'rbClosed
        '
        Me.rbClosed.AutoSize = True
        Me.rbClosed.Location = New System.Drawing.Point(697, 20)
        Me.rbClosed.Name = "rbClosed"
        Me.rbClosed.Size = New System.Drawing.Size(172, 22)
        Me.rbClosed.TabIndex = 4
        Me.rbClosed.TabStop = True
        Me.rbClosed.Text = "All Closed Tickets"
        Me.rbClosed.UseVisualStyleBackColor = True
        '
        'TicketSystemView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(926, 335)
        Me.Controls.Add(Me.rbClosed)
        Me.Controls.Add(Me.rbT3O)
        Me.Controls.Add(Me.rbT1O)
        Me.Controls.Add(Me.rbT2O)
        Me.Controls.Add(Me.rbOpen)
        Me.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "TicketSystemView"
        Me.Text = "View Tickets"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbOpen As RadioButton
    Friend WithEvents rbT2O As RadioButton
    Friend WithEvents rbT1O As RadioButton
    Friend WithEvents rbT3O As RadioButton
    Friend WithEvents rbClosed As RadioButton
End Class
