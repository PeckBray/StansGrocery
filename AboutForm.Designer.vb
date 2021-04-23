<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutForm))
        Me.AboutLabel = New System.Windows.Forms.Label()
        Me.DiscriptionLabel = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AboutLabel
        '
        Me.AboutLabel.AutoSize = True
        Me.AboutLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutLabel.Location = New System.Drawing.Point(3, 9)
        Me.AboutLabel.Name = "AboutLabel"
        Me.AboutLabel.Size = New System.Drawing.Size(272, 31)
        Me.AboutLabel.TabIndex = 0
        Me.AboutLabel.Text = "About This Program"
        '
        'DiscriptionLabel
        '
        Me.DiscriptionLabel.AutoSize = True
        Me.DiscriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscriptionLabel.Location = New System.Drawing.Point(9, 44)
        Me.DiscriptionLabel.Name = "DiscriptionLabel"
        Me.DiscriptionLabel.Size = New System.Drawing.Size(718, 90)
        Me.DiscriptionLabel.TabIndex = 1
        Me.DiscriptionLabel.Text = resources.GetString("DiscriptionLabel.Text")
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(687, 400)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(101, 38)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "&Close"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'AboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.DiscriptionLabel)
        Me.Controls.Add(Me.AboutLabel)
        Me.Name = "AboutForm"
        Me.Text = "About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AboutLabel As Label
    Friend WithEvents DiscriptionLabel As Label
    Friend WithEvents ExitButton As Button
End Class
