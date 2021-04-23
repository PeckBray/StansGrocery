<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StansGroceryForm
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SearchToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.FilterComboBox = New System.Windows.Forms.ComboBox()
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.DisplayGroupBox = New System.Windows.Forms.GroupBox()
        Me.FilterByCategoryRadioButton = New System.Windows.Forms.RadioButton()
        Me.FilterByAisleRadioButton = New System.Windows.Forms.RadioButton()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.DisplayGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem1, Me.ExitToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(110, 48)
        '
        'SearchToolStripMenuItem1
        '
        Me.SearchToolStripMenuItem1.Name = "SearchToolStripMenuItem1"
        Me.SearchToolStripMenuItem1.Size = New System.Drawing.Size(109, 22)
        Me.SearchToolStripMenuItem1.Text = "Search"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(109, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(12, 73)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(572, 20)
        Me.SearchTextBox.TabIndex = 2
        '
        'FilterComboBox
        '
        Me.FilterComboBox.FormattingEnabled = True
        Me.FilterComboBox.Location = New System.Drawing.Point(56, 129)
        Me.FilterComboBox.Name = "FilterComboBox"
        Me.FilterComboBox.Size = New System.Drawing.Size(206, 21)
        Me.FilterComboBox.TabIndex = 3
        '
        'DisplayListBox
        '
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.Location = New System.Drawing.Point(326, 124)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(388, 212)
        Me.DisplayListBox.TabIndex = 4
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(617, 67)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(127, 30)
        Me.SearchButton.TabIndex = 5
        Me.SearchButton.Text = "&Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'DisplayLabel
        '
        Me.DisplayLabel.AutoSize = True
        Me.DisplayLabel.Location = New System.Drawing.Point(323, 106)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(39, 13)
        Me.DisplayLabel.TabIndex = 6
        Me.DisplayLabel.Text = "Label1"
        '
        'DisplayGroupBox
        '
        Me.DisplayGroupBox.Controls.Add(Me.FilterByCategoryRadioButton)
        Me.DisplayGroupBox.Controls.Add(Me.FilterByAisleRadioButton)
        Me.DisplayGroupBox.Location = New System.Drawing.Point(56, 186)
        Me.DisplayGroupBox.Name = "DisplayGroupBox"
        Me.DisplayGroupBox.Size = New System.Drawing.Size(200, 100)
        Me.DisplayGroupBox.TabIndex = 7
        Me.DisplayGroupBox.TabStop = False
        Me.DisplayGroupBox.Text = "GroupBox1"
        '
        'FilterByCategoryRadioButton
        '
        Me.FilterByCategoryRadioButton.AutoSize = True
        Me.FilterByCategoryRadioButton.Location = New System.Drawing.Point(3, 50)
        Me.FilterByCategoryRadioButton.Name = "FilterByCategoryRadioButton"
        Me.FilterByCategoryRadioButton.Size = New System.Drawing.Size(107, 17)
        Me.FilterByCategoryRadioButton.TabIndex = 1
        Me.FilterByCategoryRadioButton.Text = "Filter By Category"
        Me.FilterByCategoryRadioButton.UseVisualStyleBackColor = True
        '
        'FilterByAisleRadioButton
        '
        Me.FilterByAisleRadioButton.AutoSize = True
        Me.FilterByAisleRadioButton.Location = New System.Drawing.Point(3, 16)
        Me.FilterByAisleRadioButton.Name = "FilterByAisleRadioButton"
        Me.FilterByAisleRadioButton.Size = New System.Drawing.Size(87, 17)
        Me.FilterByAisleRadioButton.TabIndex = 0
        Me.FilterByAisleRadioButton.Text = "Filter By Aisle"
        Me.FilterByAisleRadioButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'StansGroceryForm
        '
        Me.AcceptButton = Me.SearchButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DisplayGroupBox)
        Me.Controls.Add(Me.DisplayLabel)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.DisplayListBox)
        Me.Controls.Add(Me.FilterComboBox)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "StansGroceryForm"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.DisplayGroupBox.ResumeLayout(False)
        Me.DisplayGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SearchToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents FilterComboBox As ComboBox
    Friend WithEvents DisplayListBox As ListBox
    Friend WithEvents SearchButton As Button
    Friend WithEvents DisplayLabel As Label
    Friend WithEvents DisplayGroupBox As GroupBox
    Friend WithEvents FilterByCategoryRadioButton As RadioButton
    Friend WithEvents FilterByAisleRadioButton As RadioButton
    Friend WithEvents OpenFileDialog As OpenFileDialog
End Class
