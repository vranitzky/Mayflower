<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.RestrictByService = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBoxServices = New System.Windows.Forms.ComboBox()
        Me.DataTableServiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet21 = New Mayflower.DataSet2()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.RestrictByDomain = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTools = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBoxDomains = New System.Windows.Forms.ComboBox()
        Me.DataTableDomainsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet2 = New Mayflower.DataSet2()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBoxTools = New System.Windows.Forms.ComboBox()
        Me.LabelRecordsFound = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RestrictByTargetLang = New System.Windows.Forms.CheckBox()
        Me.RestrictBySourceLang = New System.Windows.Forms.CheckBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RESIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RESCODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SOURCELANGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TARGETLANG1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TARGETLANG2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CURRNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CURRDESCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COUNNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COUNFLAGDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.BindingSourceFreelancers = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxTargetLang = New System.Windows.Forms.ComboBox()
        Me.BindingSourceTargetLang = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxSourceLang = New System.Windows.Forms.ComboBox()
        Me.BindingSourceSourceLang = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ButtonTestDBSettings = New System.Windows.Forms.Button()
        Me.RichTextBoxConnectionString = New System.Windows.Forms.RichTextBox()
        Me.ButtonApplyDBSettings = New System.Windows.Forms.Button()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxDatabase = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxServerPort = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxServerAddress = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.StatusLed = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.FbConnection1 = New FirebirdSql.Data.FirebirdClient.FbConnection()
        Me.BindingSourceCatTools = New System.Windows.Forms.BindingSource(Me.components)
        Me.FreelancersTableAdapter = New Mayflower.DataSet2TableAdapters.FreelancersTableAdapter()
        Me.SourceLangTableAdapter = New Mayflower.DataSet2TableAdapters.SourceLangTableAdapter()
        Me.TargetLangTableAdapter = New Mayflower.DataSet2TableAdapters.TargetLangTableAdapter()
        Me.CatToolsTableAdapter = New Mayflower.DataSet2TableAdapters.CatToolsTableAdapter()
        Me.DomainsTableAdapter = New Mayflower.DataSet2TableAdapters.DomainsTableAdapter()
        Me.ServiceTableAdapter = New Mayflower.DataSet2TableAdapters.ServiceTableAdapter()
        Me.FbCommand1 = New FirebirdSql.Data.FirebirdClient.FbCommand()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataTableServiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTableDomainsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceFreelancers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceTargetLang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceSourceLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BindingSourceCatTools, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabPage1.Controls.Add(Me.RestrictByService)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.ComboBoxServices)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.RestrictByDomain)
        Me.TabPage1.Controls.Add(Me.CheckBoxTools)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.ComboBoxDomains)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.ComboBoxTools)
        Me.TabPage1.Controls.Add(Me.LabelRecordsFound)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.RestrictByTargetLang)
        Me.TabPage1.Controls.Add(Me.RestrictBySourceLang)
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
        Me.TabPage1.Text = "Freelancers"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'RestrictByService
        '
        Me.RestrictByService.AutoSize = True
        Me.RestrictByService.Location = New System.Drawing.Point(801, 79)
        Me.RestrictByService.Name = "RestrictByService"
        Me.RestrictByService.Size = New System.Drawing.Size(15, 14)
        Me.RestrictByService.TabIndex = 18
        Me.RestrictByService.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(299, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Service"
        '
        'ComboBoxServices
        '
        Me.ComboBoxServices.DataSource = Me.DataTableServiceBindingSource
        Me.ComboBoxServices.DisplayMember = "SERVICE"
        Me.ComboBoxServices.FormattingEnabled = True
        Me.ComboBoxServices.Location = New System.Drawing.Point(351, 76)
        Me.ComboBoxServices.Name = "ComboBoxServices"
        Me.ComboBoxServices.Size = New System.Drawing.Size(444, 21)
        Me.ComboBoxServices.TabIndex = 16
        '
        'DataTableServiceBindingSource
        '
        Me.DataTableServiceBindingSource.DataMember = "DataTableService"
        Me.DataTableServiceBindingSource.DataSource = Me.DataSet21
        '
        'DataSet21
        '
        Me.DataSet21.DataSetName = "DataSet2"
        Me.DataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(767, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Restrict?"
        '
        'RestrictByDomain
        '
        Me.RestrictByDomain.AutoSize = True
        Me.RestrictByDomain.Location = New System.Drawing.Point(801, 52)
        Me.RestrictByDomain.Name = "RestrictByDomain"
        Me.RestrictByDomain.Size = New System.Drawing.Size(15, 14)
        Me.RestrictByDomain.TabIndex = 14
        Me.RestrictByDomain.UseVisualStyleBackColor = True
        '
        'CheckBoxTools
        '
        Me.CheckBoxTools.AutoSize = True
        Me.CheckBoxTools.Enabled = False
        Me.CheckBoxTools.Location = New System.Drawing.Point(801, 25)
        Me.CheckBoxTools.Name = "CheckBoxTools"
        Me.CheckBoxTools.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxTools.TabIndex = 13
        Me.CheckBoxTools.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(299, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Domain:"
        '
        'ComboBoxDomains
        '
        Me.ComboBoxDomains.DataSource = Me.DataTableDomainsBindingSource
        Me.ComboBoxDomains.DisplayMember = "DOMAINS"
        Me.ComboBoxDomains.FormattingEnabled = True
        Me.ComboBoxDomains.Location = New System.Drawing.Point(351, 49)
        Me.ComboBoxDomains.Name = "ComboBoxDomains"
        Me.ComboBoxDomains.Size = New System.Drawing.Size(444, 21)
        Me.ComboBoxDomains.TabIndex = 11
        '
        'DataTableDomainsBindingSource
        '
        Me.DataTableDomainsBindingSource.DataMember = "DataTableDomains"
        Me.DataTableDomainsBindingSource.DataSource = Me.DataSet2
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(299, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Tools:"
        '
        'ComboBoxTools
        '
        Me.ComboBoxTools.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ComboBoxTools.FormattingEnabled = True
        Me.ComboBoxTools.Location = New System.Drawing.Point(351, 22)
        Me.ComboBoxTools.Name = "ComboBoxTools"
        Me.ComboBoxTools.Size = New System.Drawing.Size(444, 21)
        Me.ComboBoxTools.TabIndex = 9
        '
        'LabelRecordsFound
        '
        Me.LabelRecordsFound.AutoSize = True
        Me.LabelRecordsFound.Location = New System.Drawing.Point(24, 98)
        Me.LabelRecordsFound.Name = "LabelRecordsFound"
        Me.LabelRecordsFound.Size = New System.Drawing.Size(39, 13)
        Me.LabelRecordsFound.TabIndex = 8
        Me.LabelRecordsFound.Text = "Label9"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(215, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Restrict?"
        '
        'RestrictByTargetLang
        '
        Me.RestrictByTargetLang.AutoSize = True
        Me.RestrictByTargetLang.Checked = True
        Me.RestrictByTargetLang.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RestrictByTargetLang.Enabled = False
        Me.RestrictByTargetLang.Location = New System.Drawing.Point(249, 52)
        Me.RestrictByTargetLang.Name = "RestrictByTargetLang"
        Me.RestrictByTargetLang.Size = New System.Drawing.Size(15, 14)
        Me.RestrictByTargetLang.TabIndex = 6
        Me.RestrictByTargetLang.UseVisualStyleBackColor = True
        '
        'RestrictBySourceLang
        '
        Me.RestrictBySourceLang.AutoSize = True
        Me.RestrictBySourceLang.Checked = True
        Me.RestrictBySourceLang.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RestrictBySourceLang.Enabled = False
        Me.RestrictBySourceLang.Location = New System.Drawing.Point(249, 25)
        Me.RestrictBySourceLang.Name = "RestrictBySourceLang"
        Me.RestrictBySourceLang.Size = New System.Drawing.Size(15, 14)
        Me.RestrictBySourceLang.TabIndex = 5
        Me.RestrictBySourceLang.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RESIDDataGridViewTextBoxColumn, Me.RESNAMEDataGridViewTextBoxColumn, Me.RESCODEDataGridViewTextBoxColumn, Me.SOURCELANGDataGridViewTextBoxColumn, Me.TARGETLANG1DataGridViewTextBoxColumn, Me.TARGETLANG2DataGridViewTextBoxColumn, Me.CURRNAMEDataGridViewTextBoxColumn, Me.CURRDESCDataGridViewTextBoxColumn, Me.COUNNAMEDataGridViewTextBoxColumn, Me.COUNFLAGDataGridViewImageColumn})
        Me.DataGridView1.DataSource = Me.BindingSourceFreelancers
        Me.DataGridView1.Location = New System.Drawing.Point(3, 117)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(848, 373)
        Me.DataGridView1.TabIndex = 4
        '
        'RESIDDataGridViewTextBoxColumn
        '
        Me.RESIDDataGridViewTextBoxColumn.DataPropertyName = "RES_ID"
        Me.RESIDDataGridViewTextBoxColumn.HeaderText = "RES_ID"
        Me.RESIDDataGridViewTextBoxColumn.Name = "RESIDDataGridViewTextBoxColumn"
        '
        'RESNAMEDataGridViewTextBoxColumn
        '
        Me.RESNAMEDataGridViewTextBoxColumn.DataPropertyName = "RES_NAME"
        Me.RESNAMEDataGridViewTextBoxColumn.HeaderText = "RES_NAME"
        Me.RESNAMEDataGridViewTextBoxColumn.Name = "RESNAMEDataGridViewTextBoxColumn"
        '
        'RESCODEDataGridViewTextBoxColumn
        '
        Me.RESCODEDataGridViewTextBoxColumn.DataPropertyName = "RES_CODE"
        Me.RESCODEDataGridViewTextBoxColumn.HeaderText = "RES_CODE"
        Me.RESCODEDataGridViewTextBoxColumn.Name = "RESCODEDataGridViewTextBoxColumn"
        '
        'SOURCELANGDataGridViewTextBoxColumn
        '
        Me.SOURCELANGDataGridViewTextBoxColumn.DataPropertyName = "SOURCELANG"
        Me.SOURCELANGDataGridViewTextBoxColumn.HeaderText = "SOURCELANG"
        Me.SOURCELANGDataGridViewTextBoxColumn.Name = "SOURCELANGDataGridViewTextBoxColumn"
        '
        'TARGETLANG1DataGridViewTextBoxColumn
        '
        Me.TARGETLANG1DataGridViewTextBoxColumn.DataPropertyName = "TARGETLANG1"
        Me.TARGETLANG1DataGridViewTextBoxColumn.HeaderText = "TARGETLANG1"
        Me.TARGETLANG1DataGridViewTextBoxColumn.Name = "TARGETLANG1DataGridViewTextBoxColumn"
        '
        'TARGETLANG2DataGridViewTextBoxColumn
        '
        Me.TARGETLANG2DataGridViewTextBoxColumn.DataPropertyName = "TARGETLANG2"
        Me.TARGETLANG2DataGridViewTextBoxColumn.HeaderText = "TARGETLANG2"
        Me.TARGETLANG2DataGridViewTextBoxColumn.Name = "TARGETLANG2DataGridViewTextBoxColumn"
        '
        'CURRNAMEDataGridViewTextBoxColumn
        '
        Me.CURRNAMEDataGridViewTextBoxColumn.DataPropertyName = "CURR_NAME"
        Me.CURRNAMEDataGridViewTextBoxColumn.HeaderText = "CURR_NAME"
        Me.CURRNAMEDataGridViewTextBoxColumn.Name = "CURRNAMEDataGridViewTextBoxColumn"
        '
        'CURRDESCDataGridViewTextBoxColumn
        '
        Me.CURRDESCDataGridViewTextBoxColumn.DataPropertyName = "CURR_DESC"
        Me.CURRDESCDataGridViewTextBoxColumn.HeaderText = "CURR_DESC"
        Me.CURRDESCDataGridViewTextBoxColumn.Name = "CURRDESCDataGridViewTextBoxColumn"
        '
        'COUNNAMEDataGridViewTextBoxColumn
        '
        Me.COUNNAMEDataGridViewTextBoxColumn.DataPropertyName = "COUN_NAME"
        Me.COUNNAMEDataGridViewTextBoxColumn.HeaderText = "COUN_NAME"
        Me.COUNNAMEDataGridViewTextBoxColumn.Name = "COUNNAMEDataGridViewTextBoxColumn"
        '
        'COUNFLAGDataGridViewImageColumn
        '
        Me.COUNFLAGDataGridViewImageColumn.DataPropertyName = "COUN_FLAG"
        Me.COUNFLAGDataGridViewImageColumn.HeaderText = "COUN_FLAG"
        Me.COUNFLAGDataGridViewImageColumn.Name = "COUNFLAGDataGridViewImageColumn"
        '
        'BindingSourceFreelancers
        '
        Me.BindingSourceFreelancers.AllowNew = False
        Me.BindingSourceFreelancers.DataMember = "DataTableFreelancers"
        Me.BindingSourceFreelancers.DataSource = Me.DataSet2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Target Language:"
        '
        'ComboBoxTargetLang
        '
        Me.ComboBoxTargetLang.DataSource = Me.BindingSourceTargetLang
        Me.ComboBoxTargetLang.DisplayMember = "TARGETLANG"
        Me.ComboBoxTargetLang.FormattingEnabled = True
        Me.ComboBoxTargetLang.Location = New System.Drawing.Point(119, 49)
        Me.ComboBoxTargetLang.Name = "ComboBoxTargetLang"
        Me.ComboBoxTargetLang.Size = New System.Drawing.Size(124, 21)
        Me.ComboBoxTargetLang.TabIndex = 2
        '
        'BindingSourceTargetLang
        '
        Me.BindingSourceTargetLang.AllowNew = False
        Me.BindingSourceTargetLang.DataMember = "DataTableTargetLang"
        Me.BindingSourceTargetLang.DataSource = Me.DataSet2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Source Language:"
        '
        'ComboBoxSourceLang
        '
        Me.ComboBoxSourceLang.DataSource = Me.BindingSourceSourceLang
        Me.ComboBoxSourceLang.DisplayMember = "SOURCELANG"
        Me.ComboBoxSourceLang.FormattingEnabled = True
        Me.ComboBoxSourceLang.Location = New System.Drawing.Point(119, 22)
        Me.ComboBoxSourceLang.Name = "ComboBoxSourceLang"
        Me.ComboBoxSourceLang.Size = New System.Drawing.Size(124, 21)
        Me.ComboBoxSourceLang.TabIndex = 0
        '
        'BindingSourceSourceLang
        '
        Me.BindingSourceSourceLang.AllowNew = False
        Me.BindingSourceSourceLang.DataMember = "DataTableSourceLang"
        Me.BindingSourceSourceLang.DataSource = Me.DataSet2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(854, 493)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Settings"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.ButtonTestDBSettings)
        Me.GroupBox1.Controls.Add(Me.RichTextBoxConnectionString)
        Me.GroupBox1.Controls.Add(Me.ButtonApplyDBSettings)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBoxPassword)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBoxDatabase)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBoxServerPort)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxServerAddress)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.MinimumSize = New System.Drawing.Size(504, 369)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(848, 487)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Database"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Status"
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
        Me.TextBoxPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Mayflower.My.MySettings.Default, "DBPassword", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxPassword.Location = New System.Drawing.Point(95, 97)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(301, 20)
        Me.TextBoxPassword.TabIndex = 9
        Me.TextBoxPassword.Text = Global.Mayflower.My.MySettings.Default.DBPassword
        Me.TextBoxPassword.UseSystemPasswordChar = True
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
        Me.TextBoxDatabase.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Mayflower.My.MySettings.Default, "DBFile", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxDatabase.Location = New System.Drawing.Point(95, 71)
        Me.TextBoxDatabase.Name = "TextBoxDatabase"
        Me.TextBoxDatabase.Size = New System.Drawing.Size(301, 20)
        Me.TextBoxDatabase.TabIndex = 7
        Me.TextBoxDatabase.Text = Global.Mayflower.My.MySettings.Default.DBFile
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
        Me.TextBoxServerPort.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Mayflower.My.MySettings.Default, "DBPort", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxServerPort.Location = New System.Drawing.Point(95, 45)
        Me.TextBoxServerPort.Name = "TextBoxServerPort"
        Me.TextBoxServerPort.Size = New System.Drawing.Size(301, 20)
        Me.TextBoxServerPort.TabIndex = 5
        Me.TextBoxServerPort.Text = Global.Mayflower.My.MySettings.Default.DBPort
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
        Me.TextBoxServerAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Mayflower.My.MySettings.Default, "DBAddress", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxServerAddress.Location = New System.Drawing.Point(95, 19)
        Me.TextBoxServerAddress.Name = "TextBoxServerAddress"
        Me.TextBoxServerAddress.Size = New System.Drawing.Size(301, 20)
        Me.TextBoxServerAddress.TabIndex = 2
        Me.TextBoxServerAddress.Text = Global.Mayflower.My.MySettings.Default.DBAddress
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.StatusLed})
        Me.ShapeContainer1.Size = New System.Drawing.Size(842, 468)
        Me.ShapeContainer1.TabIndex = 20
        Me.ShapeContainer1.TabStop = False
        '
        'StatusLed
        '
        Me.StatusLed.BackColor = System.Drawing.Color.Gold
        Me.StatusLed.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.StatusLed.Location = New System.Drawing.Point(92, 104)
        Me.StatusLed.Name = "StatusLed"
        Me.StatusLed.Size = New System.Drawing.Size(25, 25)
        '
        'FbConnection1
        '
        Me.FbConnection1.ConnectionString = Global.Mayflower.My.MySettings.Default.ProjetexDB
        '
        'BindingSourceCatTools
        '
        Me.BindingSourceCatTools.AllowNew = False
        Me.BindingSourceCatTools.DataMember = "CatTools"
        Me.BindingSourceCatTools.DataSource = Me.DataSet2
        '
        'FreelancersTableAdapter
        '
        Me.FreelancersTableAdapter.ClearBeforeFill = True
        '
        'SourceLangTableAdapter
        '
        Me.SourceLangTableAdapter.ClearBeforeFill = True
        '
        'TargetLangTableAdapter
        '
        Me.TargetLangTableAdapter.ClearBeforeFill = True
        '
        'CatToolsTableAdapter
        '
        Me.CatToolsTableAdapter.ClearBeforeFill = True
        '
        'DomainsTableAdapter
        '
        Me.DomainsTableAdapter.ClearBeforeFill = True
        '
        'ServiceTableAdapter
        '
        Me.ServiceTableAdapter.ClearBeforeFill = True
        '
        'FbCommand1
        '
        Me.FbCommand1.CommandTimeout = 30
        Me.FbCommand1.Connection = Me.FbConnection1
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 520)
        Me.Controls.Add(Me.TabControl1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.Mayflower.My.MySettings.Default, "WindowLocation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("WindowState", Global.Mayflower.My.MySettings.Default, "MainFormWindowState", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Location = Global.Mayflower.My.MySettings.Default.WindowLocation
        Me.Name = "FormMain"
        Me.Text = "Mayflower: Projetex Lookup Tool"
        Me.WindowState = Global.Mayflower.My.MySettings.Default.MainFormWindowState
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataTableServiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTableDomainsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceFreelancers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceTargetLang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceSourceLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BindingSourceCatTools, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents RestrictByTargetLang As System.Windows.Forms.CheckBox
    Friend WithEvents RestrictBySourceLang As System.Windows.Forms.CheckBox
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
    Friend WithEvents ButtonApplyDBSettings As System.Windows.Forms.Button
    Friend WithEvents RichTextBoxConnectionString As System.Windows.Forms.RichTextBox
    Friend WithEvents ButtonTestDBSettings As System.Windows.Forms.Button
    Friend WithEvents DataTablePeopleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet2 As Mayflower.DataSet2
    Friend WithEvents DataTableFreelancersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FreelancersTableAdapter As Mayflower.DataSet2TableAdapters.FreelancersTableAdapter
    Friend WithEvents DataTableSourceLangBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents SourceLangTableAdapter As Mayflower.DataSet2TableAdapters.SourceLangTableAdapter
    Friend WithEvents BindingSourceFreelancers As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSourceSourceLang As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSourceTargetLang As System.Windows.Forms.BindingSource
    Friend WithEvents TargetLangTableAdapter As Mayflower.DataSet2TableAdapters.TargetLangTableAdapter
    Friend WithEvents FbConnection1 As FirebirdSql.Data.FirebirdClient.FbConnection
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents StatusLed As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LabelRecordsFound As System.Windows.Forms.Label
    Friend WithEvents ComboBoxTools As System.Windows.Forms.ComboBox
    Friend WithEvents BindingSourceCatTools As System.Windows.Forms.BindingSource
    Friend WithEvents CatToolsTableAdapter As Mayflower.DataSet2TableAdapters.CatToolsTableAdapter
    Friend WithEvents RESIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RESNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RESCODEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SOURCELANGDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TARGETLANG1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TARGETLANG2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CURRNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CURRDESCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COUNNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COUNFLAGDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxDomains As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents RestrictByDomain As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxTools As System.Windows.Forms.CheckBox
    Friend WithEvents DataTableDomainsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DomainsTableAdapter As Mayflower.DataSet2TableAdapters.DomainsTableAdapter
    Friend WithEvents RestrictByService As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxServices As System.Windows.Forms.ComboBox
    Friend WithEvents DataSet21 As Mayflower.DataSet2
    Friend WithEvents DataTableServiceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ServiceTableAdapter As Mayflower.DataSet2TableAdapters.ServiceTableAdapter
    Friend WithEvents FbCommand1 As FirebirdSql.Data.FirebirdClient.FbCommand

End Class
