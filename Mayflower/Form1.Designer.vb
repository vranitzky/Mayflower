<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SOURCELANG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TARGETLANG1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SOURCELANGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TARGETLANG1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet2 = New Mayflower.DataSet2()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxTargetLang = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxSourceLang = New System.Windows.Forms.ComboBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonTestDBSettings = New System.Windows.Forms.Button()
        Me.RichTextBoxConnectionString = New System.Windows.Forms.RichTextBox()
        Me.ButtonSelectLib = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxDBLib = New System.Windows.Forms.TextBox()
        Me.ButtonApplyDBSettings = New System.Windows.Forms.Button()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxDatabase = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxServerPort = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxServerAddress = New System.Windows.Forms.TextBox()
        Me.OpenFileDialogSelectLib = New System.Windows.Forms.OpenFileDialog()
        Me.FreelancersTableAdapter = New Mayflower.DataSet2TableAdapters.FreelancersTableAdapter()
        Me.SourceLangTableAdapter = New Mayflower.DataSet2TableAdapters.SourceLangTableAdapter()
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TargetLangTableAdapter = New Mayflower.DataSet2TableAdapters.TargetLangTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(1, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(862, 519)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CheckBox2)
        Me.TabPage1.Controls.Add(Me.CheckBox1)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.ComboBoxTargetLang)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.ComboBoxSourceLang)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(854, 493)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Location = New System.Drawing.Point(249, 52)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox2.TabIndex = 6
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(249, 25)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SOURCELANG, Me.TARGETLANG1, Me.SOURCELANGDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.TARGETLANG1DataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewImageColumn1})
        Me.DataGridView1.DataSource = Me.BindingSource3
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(3, 117)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(848, 373)
        Me.DataGridView1.TabIndex = 4
        '
        'SOURCELANG
        '
        Me.SOURCELANG.DataPropertyName = "SOURCELANG"
        Me.SOURCELANG.HeaderText = "SOURCELANG"
        Me.SOURCELANG.Name = "SOURCELANG"
        '
        'TARGETLANG1
        '
        Me.TARGETLANG1.DataPropertyName = "TARGETLANG1"
        Me.TARGETLANG1.HeaderText = "TARGETLANG1"
        Me.TARGETLANG1.Name = "TARGETLANG1"
        '
        'SOURCELANGDataGridViewTextBoxColumn
        '
        Me.SOURCELANGDataGridViewTextBoxColumn.DataPropertyName = "SOURCELANG"
        Me.SOURCELANGDataGridViewTextBoxColumn.HeaderText = "SOURCELANG"
        Me.SOURCELANGDataGridViewTextBoxColumn.Name = "SOURCELANGDataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "RES_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "RES_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RES_NAME"
        Me.DataGridViewTextBoxColumn2.HeaderText = "RES_NAME"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'TARGETLANG1DataGridViewTextBoxColumn
        '
        Me.TARGETLANG1DataGridViewTextBoxColumn.DataPropertyName = "TARGETLANG1"
        Me.TARGETLANG1DataGridViewTextBoxColumn.HeaderText = "TARGETLANG1"
        Me.TARGETLANG1DataGridViewTextBoxColumn.Name = "TARGETLANG1DataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "RES_CODE"
        Me.DataGridViewTextBoxColumn3.HeaderText = "RES_CODE"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CURR_NAME"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CURR_NAME"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CURR_DESC"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CURR_DESC"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "COUN_NAME"
        Me.DataGridViewTextBoxColumn6.HeaderText = "COUN_NAME"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "COUN_FLAG"
        Me.DataGridViewImageColumn1.HeaderText = "COUN_FLAG"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'BindingSource3
        '
        Me.BindingSource3.DataMember = "DataTableFreelancers"
        Me.BindingSource3.DataSource = Me.DataSet2
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Target Language"
        '
        'ComboBoxTargetLang
        '
        Me.ComboBoxTargetLang.DataSource = Me.BindingSource2
        Me.ComboBoxTargetLang.DisplayMember = "TARGETLANG"
        Me.ComboBoxTargetLang.FormattingEnabled = True
        Me.ComboBoxTargetLang.Location = New System.Drawing.Point(131, 49)
        Me.ComboBoxTargetLang.Name = "ComboBoxTargetLang"
        Me.ComboBoxTargetLang.Size = New System.Drawing.Size(112, 21)
        Me.ComboBoxTargetLang.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Source Language"
        '
        'ComboBoxSourceLang
        '
        Me.ComboBoxSourceLang.DataSource = Me.BindingSource1
        Me.ComboBoxSourceLang.DisplayMember = "SOURCELANG"
        Me.ComboBoxSourceLang.FormattingEnabled = True
        Me.ComboBoxSourceLang.Location = New System.Drawing.Point(131, 22)
        Me.ComboBoxSourceLang.Name = "ComboBoxSourceLang"
        Me.ComboBoxSourceLang.Size = New System.Drawing.Size(112, 21)
        Me.ComboBoxSourceLang.TabIndex = 0
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "DataTableSourceLang"
        Me.BindingSource1.DataSource = Me.DataSet2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(854, 493)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ButtonTestDBSettings)
        Me.GroupBox1.Controls.Add(Me.RichTextBoxConnectionString)
        Me.GroupBox1.Controls.Add(Me.ButtonSelectLib)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextBoxDBLib)
        Me.GroupBox1.Controls.Add(Me.ButtonApplyDBSettings)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBoxPassword)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBoxDatabase)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBoxServerPort)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxServerAddress)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(620, 395)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Database"
        '
        'ButtonTestDBSettings
        '
        Me.ButtonTestDBSettings.Location = New System.Drawing.Point(95, 149)
        Me.ButtonTestDBSettings.Name = "ButtonTestDBSettings"
        Me.ButtonTestDBSettings.Size = New System.Drawing.Size(75, 23)
        Me.ButtonTestDBSettings.TabIndex = 18
        Me.ButtonTestDBSettings.Text = "Test"
        Me.ButtonTestDBSettings.UseVisualStyleBackColor = True
        '
        'RichTextBoxConnectionString
        '
        Me.RichTextBoxConnectionString.Location = New System.Drawing.Point(95, 179)
        Me.RichTextBoxConnectionString.Name = "RichTextBoxConnectionString"
        Me.RichTextBoxConnectionString.ReadOnly = True
        Me.RichTextBoxConnectionString.Size = New System.Drawing.Size(301, 151)
        Me.RichTextBoxConnectionString.TabIndex = 16
        Me.RichTextBoxConnectionString.Text = ""
        '
        'ButtonSelectLib
        '
        Me.ButtonSelectLib.Location = New System.Drawing.Point(402, 122)
        Me.ButtonSelectLib.Name = "ButtonSelectLib"
        Me.ButtonSelectLib.Size = New System.Drawing.Size(53, 20)
        Me.ButtonSelectLib.TabIndex = 15
        Me.ButtonSelectLib.Text = "Select"
        Me.ButtonSelectLib.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Library"
        '
        'TextBoxDBLib
        '
        Me.TextBoxDBLib.Location = New System.Drawing.Point(95, 123)
        Me.TextBoxDBLib.Name = "TextBoxDBLib"
        Me.TextBoxDBLib.Size = New System.Drawing.Size(301, 20)
        Me.TextBoxDBLib.TabIndex = 13
        Me.TextBoxDBLib.Text = "C:\Program Files (x86)\AIT\Firebird Server\bin\fbclient.dll"
        '
        'ButtonApplyDBSettings
        '
        Me.ButtonApplyDBSettings.Location = New System.Drawing.Point(176, 149)
        Me.ButtonApplyDBSettings.Name = "ButtonApplyDBSettings"
        Me.ButtonApplyDBSettings.Size = New System.Drawing.Size(75, 23)
        Me.ButtonApplyDBSettings.TabIndex = 12
        Me.ButtonApplyDBSettings.Text = "Apply"
        Me.ButtonApplyDBSettings.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(402, 99)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(53, 17)
        Me.CheckBox3.TabIndex = 11
        Me.CheckBox3.Text = "Show"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Password"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(95, 97)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassword.Size = New System.Drawing.Size(301, 20)
        Me.TextBoxPassword.TabIndex = 9
        Me.TextBoxPassword.Text = "password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Database"
        '
        'TextBoxDatabase
        '
        Me.TextBoxDatabase.Location = New System.Drawing.Point(95, 71)
        Me.TextBoxDatabase.Name = "TextBoxDatabase"
        Me.TextBoxDatabase.Size = New System.Drawing.Size(301, 20)
        Me.TextBoxDatabase.TabIndex = 7
        Me.TextBoxDatabase.Text = "c:\projetex9\projetex server\database\projetex.fdb"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Server Port"
        '
        'TextBoxServerPort
        '
        Me.TextBoxServerPort.Location = New System.Drawing.Point(95, 45)
        Me.TextBoxServerPort.Name = "TextBoxServerPort"
        Me.TextBoxServerPort.Size = New System.Drawing.Size(301, 20)
        Me.TextBoxServerPort.TabIndex = 5
        Me.TextBoxServerPort.Text = "3050"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 346)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1197, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Server Address"
        '
        'TextBoxServerAddress
        '
        Me.TextBoxServerAddress.Location = New System.Drawing.Point(95, 19)
        Me.TextBoxServerAddress.Name = "TextBoxServerAddress"
        Me.TextBoxServerAddress.Size = New System.Drawing.Size(301, 20)
        Me.TextBoxServerAddress.TabIndex = 2
        Me.TextBoxServerAddress.Text = "192.168.56.101"
        '
        'OpenFileDialogSelectLib
        '
        Me.OpenFileDialogSelectLib.FileName = "OpenFileDialog1"
        Me.OpenFileDialogSelectLib.Filter = "DLL Files|*.dll"
        '
        'FreelancersTableAdapter
        '
        Me.FreelancersTableAdapter.ClearBeforeFill = True
        '
        'SourceLangTableAdapter
        '
        Me.SourceLangTableAdapter.ClearBeforeFill = True
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "DataTableTargetLang"
        Me.BindingSource2.DataSource = Me.DataSet2
        '
        'TargetLangTableAdapter
        '
        Me.TargetLangTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 520)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ComboBoxSourceLang As System.Windows.Forms.ComboBox
    Friend WithEvents DataTableSourceLangBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxTargetLang As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataTableTargetLangBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RESIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RESNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RESCODEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CURRNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CURRDESCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COUNNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COUNFLAGDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents SOURCELANG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TARGETLANG1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxServerAddress As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDatabase As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxServerPort As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ButtonApplyDBSettings As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDBLib As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSelectLib As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialogSelectLib As System.Windows.Forms.OpenFileDialog
    Friend WithEvents RichTextBoxConnectionString As System.Windows.Forms.RichTextBox
    Friend WithEvents ButtonTestDBSettings As System.Windows.Forms.Button
    Friend WithEvents DataTablePeopleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet2 As Mayflower.DataSet2
    Friend WithEvents DataTableFreelancersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FreelancersTableAdapter As Mayflower.DataSet2TableAdapters.FreelancersTableAdapter
    Friend WithEvents DataTableSourceLangBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents SourceLangTableAdapter As Mayflower.DataSet2TableAdapters.SourceLangTableAdapter
    Friend WithEvents SOURCELANGDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TARGETLANG1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents BindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents TargetLangTableAdapter As Mayflower.DataSet2TableAdapters.TargetLangTableAdapter

End Class
