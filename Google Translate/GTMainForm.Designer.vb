<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GTMainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GTMainForm))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.SourceCombo = New System.Windows.Forms.ComboBox()
        Me.TargetCombo = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.APIKey = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.SourceText = New TXTextControl.TextControl()
        Me.TargetText = New TXTextControl.TextControl()
        Me.ButtonClearSource = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonLoad = New System.Windows.Forms.Button()
        Me.LabelFileName = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(3, 300)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 208)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Target"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(3, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 208)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Source:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.SourceCombo, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TargetCombo, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Button1, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(99, 29)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(768, 34)
        Me.TableLayoutPanel2.TabIndex = 6
        '
        'SourceCombo
        '
        Me.SourceCombo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SourceCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SourceCombo.FormattingEnabled = True
        Me.SourceCombo.Location = New System.Drawing.Point(61, 6)
        Me.SourceCombo.Margin = New System.Windows.Forms.Padding(4, 6, 4, 4)
        Me.SourceCombo.MinimumSize = New System.Drawing.Size(116, 0)
        Me.SourceCombo.Name = "SourceCombo"
        Me.SourceCombo.Size = New System.Drawing.Size(264, 23)
        Me.SourceCombo.TabIndex = 1
        '
        'TargetCombo
        '
        Me.TargetCombo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TargetCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TargetCombo.FormattingEnabled = True
        Me.TargetCombo.Location = New System.Drawing.Point(386, 6)
        Me.TargetCombo.Margin = New System.Windows.Forms.Padding(4, 6, 4, 4)
        Me.TargetCombo.MinimumSize = New System.Drawing.Size(116, 0)
        Me.TargetCombo.Name = "TargetCombo"
        Me.TargetCombo.Size = New System.Drawing.Size(264, 23)
        Me.TargetCombo.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.Location = New System.Drawing.Point(676, 4)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 26)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Go"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.Location = New System.Drawing.Point(4, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 34)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Source:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label3.Location = New System.Drawing.Point(333, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 34)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Target:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Location = New System.Drawing.Point(4, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Language Pair:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 29)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "API Key:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'APIKey
        '
        Me.APIKey.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.BeGlobalTest.My.MySettings.Default, "APIKey", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.APIKey.Dock = System.Windows.Forms.DockStyle.Fill
        Me.APIKey.Location = New System.Drawing.Point(103, 4)
        Me.APIKey.Margin = New System.Windows.Forms.Padding(4)
        Me.APIKey.Name = "APIKey"
        Me.APIKey.Size = New System.Drawing.Size(760, 21)
        Me.APIKey.TabIndex = 20
        Me.APIKey.Text = Global.BeGlobalTest.My.MySettings.Default.APIKey
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.APIKey, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.SourceText, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TargetText, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonClearSource, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Button3, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(866, 537)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'SourceText
        '
        Me.SourceText.AllowDrag = True
        Me.SourceText.AllowDrop = True
        Me.SourceText.BorderStyle = TXTextControl.BorderStyle.FixedSingle
        Me.SourceText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SourceText.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.SourceText.Location = New System.Drawing.Point(102, 66)
        Me.SourceText.Name = "SourceText"
        Me.SourceText.Size = New System.Drawing.Size(762, 202)
        Me.SourceText.TabIndex = 21
        Me.SourceText.ViewMode = TXTextControl.ViewMode.SimpleControl
        '
        'TargetText
        '
        Me.TargetText.BorderStyle = TXTextControl.BorderStyle.FixedSingle
        Me.TargetText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TargetText.EditMode = TXTextControl.EditMode.ReadAndSelect
        Me.TargetText.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.TargetText.Location = New System.Drawing.Point(102, 303)
        Me.TargetText.Name = "TargetText"
        Me.TableLayoutPanel1.SetRowSpan(Me.TargetText, 2)
        Me.TargetText.Size = New System.Drawing.Size(762, 231)
        Me.TargetText.TabIndex = 22
        Me.TargetText.ViewMode = TXTextControl.ViewMode.Normal
        '
        'ButtonClearSource
        '
        Me.ButtonClearSource.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonClearSource.Location = New System.Drawing.Point(3, 274)
        Me.ButtonClearSource.Name = "ButtonClearSource"
        Me.ButtonClearSource.Size = New System.Drawing.Size(93, 23)
        Me.ButtonClearSource.TabIndex = 23
        Me.ButtonClearSource.Text = "Clear"
        Me.ButtonClearSource.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button3.Location = New System.Drawing.Point(3, 511)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 23)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Clear"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.ButtonLoad, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.LabelFileName, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(99, 271)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(768, 29)
        Me.TableLayoutPanel3.TabIndex = 25
        '
        'ButtonLoad
        '
        Me.ButtonLoad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonLoad.Location = New System.Drawing.Point(3, 3)
        Me.ButtonLoad.Name = "ButtonLoad"
        Me.ButtonLoad.Size = New System.Drawing.Size(74, 23)
        Me.ButtonLoad.TabIndex = 0
        Me.ButtonLoad.Text = "Load File"
        Me.ButtonLoad.UseVisualStyleBackColor = True
        '
        'LabelFileName
        '
        Me.LabelFileName.AutoSize = True
        Me.LabelFileName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelFileName.Location = New System.Drawing.Point(83, 0)
        Me.LabelFileName.Name = "LabelFileName"
        Me.LabelFileName.Size = New System.Drawing.Size(682, 29)
        Me.LabelFileName.TabIndex = 1
        Me.LabelFileName.Text = "No File Loaded"
        Me.LabelFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Text files (*.txt)|*.txt|HTML files (*.htm;*.html)|*.htm;*.html"
        '
        'GTMainForm
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 537)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "GTMainForm"
        Me.Text = "Google Translate Interface"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents SourceCombo As System.Windows.Forms.ComboBox
    Friend WithEvents TargetCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents APIKey As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents SourceText As TXTextControl.TextControl
    Friend WithEvents TargetText As TXTextControl.TextControl
    Friend WithEvents ButtonClearSource As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ButtonLoad As System.Windows.Forms.Button
    Friend WithEvents LabelFileName As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
