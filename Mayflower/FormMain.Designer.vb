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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim MySettings1 As Mayflower.My.MySettings = New Mayflower.My.MySettings()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Dim MySettings2 As Mayflower.My.MySettings = New Mayflower.My.MySettings()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabFreelancers = New System.Windows.Forms.TabPage()
        Me.RestrictByService = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBoxServices = New System.Windows.Forms.ComboBox()
        Me.DataTableServiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet2 = New Mayflower.DataSet2()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.RestrictByDomain = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTools = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBoxDomains = New System.Windows.Forms.ComboBox()
        Me.DataTableDomainsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBoxTools = New System.Windows.Forms.ComboBox()
        Me.LabelRecordsFound = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RestrictByTargetLang = New System.Windows.Forms.CheckBox()
        Me.RestrictBySourceLang = New System.Windows.Forms.CheckBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SOURCELANGDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TARGETLANG1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TARGETLANG2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CURRENCYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COUNTRYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERVICEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APPROVALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingSourceFreelancers = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxTargetLang = New System.Windows.Forms.ComboBox()
        Me.BindingSourceTargetLang = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxSourceLang = New System.Windows.Forms.ComboBox()
        Me.BindingSourceSourceLang = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabDetails = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.LASTJOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERVICEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LASTPROJECTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROJECTMANAGERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabSettings = New System.Windows.Forms.TabPage()
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
        Me.TADetails = New Mayflower.DataSet2TableAdapters.TADetails()
        Me.TabControl1.SuspendLayout()
        Me.TabFreelancers.SuspendLayout()
        CType(Me.DataTableServiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTableDomainsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceFreelancers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceTargetLang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceSourceLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabDetails.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSettings.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BindingSourceCatTools, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabFreelancers)
        Me.TabControl1.Controls.Add(Me.TabDetails)
        Me.TabControl1.Controls.Add(Me.TabSettings)
        Me.TabControl1.Location = New System.Drawing.Point(1, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1415, 720)
        Me.TabControl1.TabIndex = 0
        '
        'TabFreelancers
        '
        Me.TabFreelancers.Controls.Add(Me.RestrictByService)
        Me.TabFreelancers.Controls.Add(Me.Label12)
        Me.TabFreelancers.Controls.Add(Me.ComboBoxServices)
        Me.TabFreelancers.Controls.Add(Me.Label11)
        Me.TabFreelancers.Controls.Add(Me.RestrictByDomain)
        Me.TabFreelancers.Controls.Add(Me.CheckBoxTools)
        Me.TabFreelancers.Controls.Add(Me.Label10)
        Me.TabFreelancers.Controls.Add(Me.ComboBoxDomains)
        Me.TabFreelancers.Controls.Add(Me.Label9)
        Me.TabFreelancers.Controls.Add(Me.ComboBoxTools)
        Me.TabFreelancers.Controls.Add(Me.LabelRecordsFound)
        Me.TabFreelancers.Controls.Add(Me.Label4)
        Me.TabFreelancers.Controls.Add(Me.RestrictByTargetLang)
        Me.TabFreelancers.Controls.Add(Me.RestrictBySourceLang)
        Me.TabFreelancers.Controls.Add(Me.DataGridView1)
        Me.TabFreelancers.Controls.Add(Me.Label2)
        Me.TabFreelancers.Controls.Add(Me.ComboBoxTargetLang)
        Me.TabFreelancers.Controls.Add(Me.Label1)
        Me.TabFreelancers.Controls.Add(Me.ComboBoxSourceLang)
        Me.TabFreelancers.Location = New System.Drawing.Point(4, 22)
        Me.TabFreelancers.Name = "TabFreelancers"
        Me.TabFreelancers.Padding = New System.Windows.Forms.Padding(3)
        Me.TabFreelancers.Size = New System.Drawing.Size(1407, 694)
        Me.TabFreelancers.TabIndex = 0
        Me.TabFreelancers.Text = "Freelancers"
        Me.TabFreelancers.UseVisualStyleBackColor = True
        '
        'RestrictByService
        '
        Me.RestrictByService.AutoSize = True
        Me.RestrictByService.Checked = True
        Me.RestrictByService.CheckState = System.Windows.Forms.CheckState.Checked
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
        Me.ComboBoxServices.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBoxServices.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxServices.DataSource = Me.DataTableServiceBindingSource
        Me.ComboBoxServices.DisplayMember = "SERVICE"
        Me.ComboBoxServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxServices.FormattingEnabled = True
        Me.ComboBoxServices.Location = New System.Drawing.Point(351, 76)
        Me.ComboBoxServices.Name = "ComboBoxServices"
        Me.ComboBoxServices.Size = New System.Drawing.Size(444, 21)
        Me.ComboBoxServices.TabIndex = 16
        '
        'DataTableServiceBindingSource
        '
        Me.DataTableServiceBindingSource.DataMember = "DataTableService"
        Me.DataTableServiceBindingSource.DataSource = Me.DataSet2
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.EnforceConstraints = False
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.RestrictByDomain.Checked = True
        Me.RestrictByDomain.CheckState = System.Windows.Forms.CheckState.Checked
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
        Me.ComboBoxDomains.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBoxDomains.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxDomains.DataSource = Me.DataTableDomainsBindingSource
        Me.ComboBoxDomains.DisplayMember = "DOMAINS"
        Me.ComboBoxDomains.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
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
        Me.ComboBoxTools.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.ComboBoxTools.BackColor = System.Drawing.SystemColors.Window
        Me.ComboBoxTools.Cursor = System.Windows.Forms.Cursors.Help
        Me.ComboBoxTools.Enabled = False
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
        Me.RestrictBySourceLang.Location = New System.Drawing.Point(249, 25)
        Me.RestrictBySourceLang.Name = "RestrictBySourceLang"
        Me.RestrictBySourceLang.Size = New System.Drawing.Size(15, 14)
        Me.RestrictBySourceLang.TabIndex = 5
        Me.RestrictBySourceLang.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NAMEDataGridViewTextBoxColumn, Me.SOURCELANGDataGridViewTextBoxColumn, Me.TARGETLANG1DataGridViewTextBoxColumn, Me.TARGETLANG2DataGridViewTextBoxColumn, Me.RATEDataGridViewTextBoxColumn, Me.CURRENCYDataGridViewTextBoxColumn, Me.COUNTRYDataGridViewTextBoxColumn, Me.RoleDataGridViewTextBoxColumn, Me.SERVICEDataGridViewTextBoxColumn, Me.APPROVALDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BindingSourceFreelancers
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(3, 117)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(827, 320)
        Me.DataGridView1.TabIndex = 4
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NAMEDataGridViewTextBoxColumn
        '
        Me.NAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME"
        Me.NAMEDataGridViewTextBoxColumn.HeaderText = "NAME"
        Me.NAMEDataGridViewTextBoxColumn.Name = "NAMEDataGridViewTextBoxColumn"
        Me.NAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SOURCELANGDataGridViewTextBoxColumn
        '
        Me.SOURCELANGDataGridViewTextBoxColumn.DataPropertyName = "SOURCELANG"
        Me.SOURCELANGDataGridViewTextBoxColumn.HeaderText = "SOURCELANG"
        Me.SOURCELANGDataGridViewTextBoxColumn.Name = "SOURCELANGDataGridViewTextBoxColumn"
        Me.SOURCELANGDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TARGETLANG1DataGridViewTextBoxColumn
        '
        Me.TARGETLANG1DataGridViewTextBoxColumn.DataPropertyName = "TARGETLANG1"
        Me.TARGETLANG1DataGridViewTextBoxColumn.HeaderText = "TARGETLANG1"
        Me.TARGETLANG1DataGridViewTextBoxColumn.Name = "TARGETLANG1DataGridViewTextBoxColumn"
        Me.TARGETLANG1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'TARGETLANG2DataGridViewTextBoxColumn
        '
        Me.TARGETLANG2DataGridViewTextBoxColumn.DataPropertyName = "TARGETLANG2"
        Me.TARGETLANG2DataGridViewTextBoxColumn.HeaderText = "TARGETLANG2"
        Me.TARGETLANG2DataGridViewTextBoxColumn.Name = "TARGETLANG2DataGridViewTextBoxColumn"
        Me.TARGETLANG2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'RATEDataGridViewTextBoxColumn
        '
        Me.RATEDataGridViewTextBoxColumn.DataPropertyName = "RATE"
        Me.RATEDataGridViewTextBoxColumn.HeaderText = "RATE"
        Me.RATEDataGridViewTextBoxColumn.Name = "RATEDataGridViewTextBoxColumn"
        Me.RATEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CURRENCYDataGridViewTextBoxColumn
        '
        Me.CURRENCYDataGridViewTextBoxColumn.DataPropertyName = "CURRENCY"
        Me.CURRENCYDataGridViewTextBoxColumn.HeaderText = "CURRENCY"
        Me.CURRENCYDataGridViewTextBoxColumn.Name = "CURRENCYDataGridViewTextBoxColumn"
        Me.CURRENCYDataGridViewTextBoxColumn.ReadOnly = True
        '
        'COUNTRYDataGridViewTextBoxColumn
        '
        Me.COUNTRYDataGridViewTextBoxColumn.DataPropertyName = "COUNTRY"
        Me.COUNTRYDataGridViewTextBoxColumn.HeaderText = "COUNTRY"
        Me.COUNTRYDataGridViewTextBoxColumn.Name = "COUNTRYDataGridViewTextBoxColumn"
        Me.COUNTRYDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RoleDataGridViewTextBoxColumn
        '
        Me.RoleDataGridViewTextBoxColumn.DataPropertyName = "Role"
        Me.RoleDataGridViewTextBoxColumn.HeaderText = "Role"
        Me.RoleDataGridViewTextBoxColumn.Name = "RoleDataGridViewTextBoxColumn"
        Me.RoleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SERVICEDataGridViewTextBoxColumn
        '
        Me.SERVICEDataGridViewTextBoxColumn.DataPropertyName = "SERVICE"
        Me.SERVICEDataGridViewTextBoxColumn.HeaderText = "SERVICE"
        Me.SERVICEDataGridViewTextBoxColumn.Name = "SERVICEDataGridViewTextBoxColumn"
        Me.SERVICEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'APPROVALDataGridViewTextBoxColumn
        '
        Me.APPROVALDataGridViewTextBoxColumn.DataPropertyName = "APPROVAL"
        Me.APPROVALDataGridViewTextBoxColumn.HeaderText = "APPROVAL"
        Me.APPROVALDataGridViewTextBoxColumn.Name = "APPROVALDataGridViewTextBoxColumn"
        Me.APPROVALDataGridViewTextBoxColumn.ReadOnly = True
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
        Me.ComboBoxTargetLang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBoxTargetLang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxTargetLang.DataSource = Me.BindingSourceTargetLang
        Me.ComboBoxTargetLang.DisplayMember = "TARGETLANG"
        Me.ComboBoxTargetLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
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
        Me.ComboBoxSourceLang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBoxSourceLang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxSourceLang.DataSource = Me.BindingSourceSourceLang
        Me.ComboBoxSourceLang.DisplayMember = "SOURCELANG"
        Me.ComboBoxSourceLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
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
        'TabDetails
        '
        Me.TabDetails.Controls.Add(Me.TableLayoutPanel1)
        Me.TabDetails.Controls.Add(Me.DataGridView2)
        Me.TabDetails.Location = New System.Drawing.Point(4, 22)
        Me.TabDetails.Name = "TabDetails"
        Me.TabDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDetails.Size = New System.Drawing.Size(1407, 694)
        Me.TabDetails.TabIndex = 2
        Me.TabDetails.Text = "Details"
        Me.TabDetails.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label14, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label16, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label17, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label18, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label19, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label20, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label21, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label22, 1, 4)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(8, 7)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Label13"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Label14"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Label15"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 60)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 13)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Label16"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 80)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 13)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Label17"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(103, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 13)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "Label18"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(103, 20)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(45, 13)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Label19"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(103, 40)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(45, 13)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "Label20"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(103, 60)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(45, 13)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "Label21"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(103, 80)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(45, 13)
        Me.Label22.TabIndex = 9
        Me.Label22.Text = "Label22"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LASTJOBDataGridViewTextBoxColumn, Me.SERVICEDataGridViewTextBoxColumn1, Me.LASTPROJECTDataGridViewTextBoxColumn, Me.CLIENTDataGridViewTextBoxColumn, Me.PROJECTMANAGERDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn8})
        Me.DataGridView2.DataSource = Me.DTDetailsBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView2.Location = New System.Drawing.Point(3, 184)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView2.Size = New System.Drawing.Size(826, 253)
        Me.DataGridView2.TabIndex = 1
        '
        'LASTJOBDataGridViewTextBoxColumn
        '
        Me.LASTJOBDataGridViewTextBoxColumn.DataPropertyName = "LASTJOB"
        Me.LASTJOBDataGridViewTextBoxColumn.HeaderText = "LASTJOB"
        Me.LASTJOBDataGridViewTextBoxColumn.Name = "LASTJOBDataGridViewTextBoxColumn"
        Me.LASTJOBDataGridViewTextBoxColumn.ReadOnly = True
        Me.LASTJOBDataGridViewTextBoxColumn.Width = 79
        '
        'SERVICEDataGridViewTextBoxColumn1
        '
        Me.SERVICEDataGridViewTextBoxColumn1.DataPropertyName = "SERVICE"
        Me.SERVICEDataGridViewTextBoxColumn1.HeaderText = "SERVICE"
        Me.SERVICEDataGridViewTextBoxColumn1.Name = "SERVICEDataGridViewTextBoxColumn1"
        Me.SERVICEDataGridViewTextBoxColumn1.ReadOnly = True
        Me.SERVICEDataGridViewTextBoxColumn1.Width = 78
        '
        'LASTPROJECTDataGridViewTextBoxColumn
        '
        Me.LASTPROJECTDataGridViewTextBoxColumn.DataPropertyName = "LASTPROJECT"
        Me.LASTPROJECTDataGridViewTextBoxColumn.HeaderText = "LASTPROJECT"
        Me.LASTPROJECTDataGridViewTextBoxColumn.Name = "LASTPROJECTDataGridViewTextBoxColumn"
        Me.LASTPROJECTDataGridViewTextBoxColumn.ReadOnly = True
        Me.LASTPROJECTDataGridViewTextBoxColumn.Width = 108
        '
        'CLIENTDataGridViewTextBoxColumn
        '
        Me.CLIENTDataGridViewTextBoxColumn.DataPropertyName = "CLIENT"
        Me.CLIENTDataGridViewTextBoxColumn.HeaderText = "CLIENT"
        Me.CLIENTDataGridViewTextBoxColumn.Name = "CLIENTDataGridViewTextBoxColumn"
        Me.CLIENTDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIENTDataGridViewTextBoxColumn.Width = 70
        '
        'PROJECTMANAGERDataGridViewTextBoxColumn
        '
        Me.PROJECTMANAGERDataGridViewTextBoxColumn.DataPropertyName = "PROJECTMANAGER"
        Me.PROJECTMANAGERDataGridViewTextBoxColumn.HeaderText = "PROJECTMANAGER"
        Me.PROJECTMANAGERDataGridViewTextBoxColumn.Name = "PROJECTMANAGERDataGridViewTextBoxColumn"
        Me.PROJECTMANAGERDataGridViewTextBoxColumn.ReadOnly = True
        Me.PROJECTMANAGERDataGridViewTextBoxColumn.Width = 135
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CURR_NAME"
        Me.DataGridViewTextBoxColumn8.HeaderText = "CURR_NAME"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DTDetailsBindingSource
        '
        Me.DTDetailsBindingSource.DataMember = "DTDetails"
        Me.DTDetailsBindingSource.DataSource = Me.DataSet2
        '
        'TabSettings
        '
        Me.TabSettings.BackColor = System.Drawing.Color.IndianRed
        Me.TabSettings.Controls.Add(Me.GroupBox1)
        Me.TabSettings.Location = New System.Drawing.Point(4, 22)
        Me.TabSettings.Name = "TabSettings"
        Me.TabSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSettings.Size = New System.Drawing.Size(1407, 694)
        Me.TabSettings.TabIndex = 1
        Me.TabSettings.Text = "Settings"
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
        Me.GroupBox1.Size = New System.Drawing.Size(1401, 688)
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
        Me.RichTextBoxConnectionString.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Mayflower.My.MySettings.Default, "ProjetexDB", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.RichTextBoxConnectionString.Location = New System.Drawing.Point(95, 179)
        Me.RichTextBoxConnectionString.Name = "RichTextBoxConnectionString"
        Me.RichTextBoxConnectionString.ReadOnly = True
        Me.RichTextBoxConnectionString.Size = New System.Drawing.Size(301, 151)
        Me.RichTextBoxConnectionString.TabIndex = 16
        Me.RichTextBoxConnectionString.Text = Global.Mayflower.My.MySettings.Default.ProjetexDB
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
        MySettings1.DBAddress = "192.168.0.56"
        MySettings1.DBFile = "c:\projetex9\projetex server\database\projetex.fdb"
        MySettings1.DBPassword = "pwww"
        MySettings1.DBPort = "3050"
        MySettings1.MainFormSize = ""
        MySettings1.MainFormWindowState = System.Windows.Forms.FormWindowState.Normal
        MySettings1.ProjetexDB = resources.GetString("MySettings1.ProjetexDB")
        'MySettings1.ProjetexDB2 = Nothing
        MySettings1.SettingsKey = ""
        MySettings1.test = New System.Drawing.Size(837, 462)
        MySettings1.test2 = "character set=UTF8;data source=192.168.56.101;initial catalog=""C:\Projetex9\Proje" & _
    "tex Server\Database\Projetex.fdb"";user id=ODBC;password=pwww;role=PROJETEX_ODBC"
        MySettings1.WindowLocation = New System.Drawing.Point(50, 50)
        Me.TextBoxPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", MySettings1, "DBPassword", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxPassword.Location = New System.Drawing.Point(95, 97)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(301, 20)
        Me.TextBoxPassword.TabIndex = 9
        Me.TextBoxPassword.Text = MySettings1.DBPassword
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
        Me.TextBoxDatabase.DataBindings.Add(New System.Windows.Forms.Binding("Text", MySettings1, "DBFile", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxDatabase.Location = New System.Drawing.Point(95, 71)
        Me.TextBoxDatabase.Name = "TextBoxDatabase"
        Me.TextBoxDatabase.Size = New System.Drawing.Size(301, 20)
        Me.TextBoxDatabase.TabIndex = 7
        Me.TextBoxDatabase.Text = MySettings1.DBFile
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
        Me.TextBoxServerPort.DataBindings.Add(New System.Windows.Forms.Binding("Text", MySettings1, "DBPort", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxServerPort.Location = New System.Drawing.Point(95, 45)
        Me.TextBoxServerPort.Name = "TextBoxServerPort"
        Me.TextBoxServerPort.Size = New System.Drawing.Size(301, 20)
        Me.TextBoxServerPort.TabIndex = 5
        Me.TextBoxServerPort.Text = MySettings1.DBPort
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
        Me.ShapeContainer1.Size = New System.Drawing.Size(1395, 669)
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
        Me.FbConnection1.ConnectionString = resources.GetString("FbConnection1.ConnectionString")
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
        'TADetails
        '
        Me.TADetails.ClearBeforeFill = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = MySettings1.test
        Me.Controls.Add(Me.TabControl1)
        MySettings2.DBAddress = "192.168.0.56"
        MySettings2.DBFile = "c:\projetex9\projetex server\database\projetex.fdb"
        MySettings2.DBPassword = "pwww"
        MySettings2.DBPort = "3050"
        MySettings2.MainFormSize = ""
        MySettings2.MainFormWindowState = System.Windows.Forms.FormWindowState.Normal
        MySettings2.ProjetexDB = resources.GetString("MySettings2.ProjetexDB")
        '
        MySettings2.SettingsKey = ""
        MySettings2.test = New System.Drawing.Size(837, 462)
        MySettings2.test2 = "character set=UTF8;data source=192.168.56.101;initial catalog=""C:\Projetex9\Proje" & _
    "tex Server\Database\Projetex.fdb"";user id=ODBC;password=pwww;role=PROJETEX_ODBC"
        MySettings2.WindowLocation = New System.Drawing.Point(50, 50)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", MySettings2, "WindowLocation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("WindowState", MySettings2, "MainFormWindowState", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DataBindings.Add(New System.Windows.Forms.Binding("ClientSize", MySettings2, "test", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Location = MySettings1.WindowLocation
        Me.MinimumSize = New System.Drawing.Size(850, 300)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Mayflower: Projetex Lookup Tool"
        Me.WindowState = MySettings1.MainFormWindowState
        Me.TabControl1.ResumeLayout(False)
        Me.TabFreelancers.ResumeLayout(False)
        Me.TabFreelancers.PerformLayout()
        CType(Me.DataTableServiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTableDomainsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceFreelancers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceTargetLang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceSourceLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabDetails.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSettings.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BindingSourceCatTools, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabFreelancers As System.Windows.Forms.TabPage
    Friend WithEvents TabSettings As System.Windows.Forms.TabPage
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
    Friend WithEvents DataTableServiceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ServiceTableAdapter As Mayflower.DataSet2TableAdapters.ServiceTableAdapter
    Friend WithEvents FbCommand1 As FirebirdSql.Data.FirebirdClient.FbCommand
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SOURCELANGDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TARGETLANG1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TARGETLANG2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CURRENCYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COUNTRYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SERVICEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents APPROVALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabDetails As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DTDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TADetails As Mayflower.DataSet2TableAdapters.TADetails
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents LASTJOBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SERVICEDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LASTPROJECTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIENTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROJECTMANAGERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
