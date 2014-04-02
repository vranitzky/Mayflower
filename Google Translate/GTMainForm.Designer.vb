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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.SourceCombo = New System.Windows.Forms.ComboBox()
        Me.TargetCombo = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SourceText = New System.Windows.Forms.RichTextBox()
        Me.TargetText = New System.Windows.Forms.RichTextBox()
        Me.ServerSays = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.APIKey = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.SourceText, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TargetText, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ServerSays, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(767, 473)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Location = New System.Drawing.Point(4, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Language Pair:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.SourceCombo, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TargetCombo, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Button1, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(99, 40)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(668, 34)
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
        Me.SourceCombo.Size = New System.Drawing.Size(220, 23)
        Me.SourceCombo.TabIndex = 1
        '
        'TargetCombo
        '
        Me.TargetCombo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TargetCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TargetCombo.FormattingEnabled = True
        Me.TargetCombo.Location = New System.Drawing.Point(342, 6)
        Me.TargetCombo.Margin = New System.Windows.Forms.Padding(4, 6, 4, 4)
        Me.TargetCombo.MinimumSize = New System.Drawing.Size(116, 0)
        Me.TargetCombo.Name = "TargetCombo"
        Me.TargetCombo.Size = New System.Drawing.Size(220, 23)
        Me.TargetCombo.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.Location = New System.Drawing.Point(576, 4)
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
        Me.Label3.Location = New System.Drawing.Point(289, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 34)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Target:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SourceText
        '
        Me.SourceText.DetectUrls = False
        Me.SourceText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SourceText.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SourceText.Location = New System.Drawing.Point(103, 78)
        Me.SourceText.Margin = New System.Windows.Forms.Padding(4)
        Me.SourceText.Name = "SourceText"
        Me.SourceText.Size = New System.Drawing.Size(660, 178)
        Me.SourceText.TabIndex = 11
        Me.SourceText.Text = ""
        '
        'TargetText
        '
        Me.TargetText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TargetText.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TargetText.Location = New System.Drawing.Point(103, 264)
        Me.TargetText.Margin = New System.Windows.Forms.Padding(4)
        Me.TargetText.Name = "TargetText"
        Me.TargetText.ReadOnly = True
        Me.TargetText.Size = New System.Drawing.Size(660, 178)
        Me.TargetText.TabIndex = 12
        Me.TargetText.Text = ""
        '
        'ServerSays
        '
        Me.ServerSays.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ServerSays.Location = New System.Drawing.Point(102, 449)
        Me.ServerSays.Name = "ServerSays"
        Me.ServerSays.ReadOnly = True
        Me.ServerSays.Size = New System.Drawing.Size(662, 21)
        Me.ServerSays.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(3, 446)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 27)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Server says:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.APIKey, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(102, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(662, 34)
        Me.TableLayoutPanel3.TabIndex = 15
        '
        'APIKey
        '
        Me.APIKey.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.BeGlobalTest.My.MySettings.Default, "APIKey", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.APIKey.Dock = System.Windows.Forms.DockStyle.Fill
        Me.APIKey.Location = New System.Drawing.Point(61, 4)
        Me.APIKey.Margin = New System.Windows.Forms.Padding(4)
        Me.APIKey.Name = "APIKey"
        Me.APIKey.Size = New System.Drawing.Size(597, 21)
        Me.APIKey.TabIndex = 4
        Me.APIKey.Text = Global.BeGlobalTest.My.MySettings.Default.APIKey
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 34)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "API Key:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 40)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Quality:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(3, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 186)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Source:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(3, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 186)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Target"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GTMainForm
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 473)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "GTMainForm"
        Me.Text = "SDL BeGlobal Test"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents APIKey As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents SourceCombo As System.Windows.Forms.ComboBox
    Friend WithEvents TargetCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SourceText As System.Windows.Forms.RichTextBox
    Friend WithEvents TargetText As System.Windows.Forms.RichTextBox
    Friend WithEvents ServerSays As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
