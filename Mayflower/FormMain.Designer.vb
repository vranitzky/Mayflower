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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabFreelancers = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.RestrictByCountry = New System.Windows.Forms.CheckBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.ComboBoxCountry = New System.Windows.Forms.ComboBox()
        Me.COUNTRIESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet2DataSet = New Freelancers_Lookup.DataSet2DataSet()
        Me.RestrictByService = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.RestrictByDomain = New System.Windows.Forms.CheckBox()
        Me.RestrictByTools = New System.Windows.Forms.CheckBox()
        Me.TextBoxTools = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBoxServices = New System.Windows.Forms.ComboBox()
        Me.DataTableServiceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBoxDomains = New System.Windows.Forms.ComboBox()
        Me.DataTableDomainsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LabelRecordsFound = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RestrictByTargetLang = New System.Windows.Forms.CheckBox()
        Me.RestrictBySourceLang = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxTargetLang = New System.Windows.Forms.ComboBox()
        Me.BindingSourceTargetLang = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxSourceLang = New System.Windows.Forms.ComboBox()
        Me.BindingSourceSourceLang = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.EmailButton = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BindingSourceFreelancers = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabDetails = New System.Windows.Forms.TabPage()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.DTFreelancerInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBoxEmailAddress = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DetailsBoxName = New System.Windows.Forms.TextBox()
        Me.ButtonSendEmail = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.BindingSourceCatTools = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.RJOB_ASSIGNED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISCOMPLETED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROJ_CODE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LASTJOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SERVICEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROJECTMANAGERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RJOB_PRICE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RJOB_FEE_KIND = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabEmail = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label22a = New System.Windows.Forms.Label()
        Me.EmailBody = New TXTextControl.TextControl()
        Me.EmailSubject = New System.Windows.Forms.TextBox()
        Me.Label30a = New System.Windows.Forms.Label()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TemplatesButtonAdd = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TemplatesButtonRemove = New System.Windows.Forms.Button()
        Me.TemplatesCombo = New System.Windows.Forms.ComboBox()
        Me.TabSettings = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.EmailSettingsGroupBox = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.EmailButtonTest = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.EmailSettingsName = New System.Windows.Forms.TextBox()
        Me.EmailSettingsEmail = New System.Windows.Forms.TextBox()
        Me.EmailSettingsServer = New System.Windows.Forms.TextBox()
        Me.EmailSettingsPassword = New System.Windows.Forms.TextBox()
        Me.EmailSettingsPort = New System.Windows.Forms.TextBox()
        Me.EmailTestModeCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ButtonTestDBSettings = New System.Windows.Forms.Button()
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
        Me.DataSet2DataSet1 = New Freelancers_Lookup.DataSet2DataSet()
        Me.FbConnection1 = New FirebirdSql.Data.FirebirdClient.FbConnection()
        Me.FreelancersTableAdapter = New Freelancers_Lookup.DataSet2DataSetTableAdapters.FreelancersTableAdapter()
        Me.SourceLangTableAdapter = New Freelancers_Lookup.DataSet2DataSetTableAdapters.SourceLangTableAdapter()
        Me.TargetLangTableAdapter = New Freelancers_Lookup.DataSet2DataSetTableAdapters.TargetLangTableAdapter()
        Me.CatToolsTableAdapter = New Freelancers_Lookup.DataSet2DataSetTableAdapters.CatToolsTableAdapter()
        Me.DomainsTableAdapter = New Freelancers_Lookup.DataSet2DataSetTableAdapters.DomainsTableAdapter()
        Me.ServiceTableAdapter = New Freelancers_Lookup.DataSet2DataSetTableAdapters.ServiceTableAdapter()
        Me.FbCommand1 = New FirebirdSql.Data.FirebirdClient.FbCommand()
        Me.TADetails = New Freelancers_Lookup.DataSet2DataSetTableAdapters.TADetails()
        Me.FreelancerInfoTableAdapter = New Freelancers_Lookup.DataSet2DataSetTableAdapters.FreelancerInfoTableAdapter()
        Me.COUNTRIESTableAdapter = New Freelancers_Lookup.DataSet2DataSetTableAdapters.COUNTRIESTableAdapter()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabFreelancers.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.COUNTRIESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTableServiceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTableDomainsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceTargetLang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceSourceLang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSourceFreelancers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabDetails.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DTFreelancerInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.BindingSourceCatTools, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabEmail.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TabSettings.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.EmailSettingsGroupBox.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabFreelancers)
        Me.TabControl1.Controls.Add(Me.TabDetails)
        Me.TabControl1.Controls.Add(Me.TabEmail)
        Me.TabControl1.Controls.Add(Me.TabSettings)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(968, 533)
        Me.TabControl1.TabIndex = 0
        '
        'TabFreelancers
        '
        Me.TabFreelancers.Controls.Add(Me.SplitContainer1)
        Me.TabFreelancers.Location = New System.Drawing.Point(4, 24)
        Me.TabFreelancers.Name = "TabFreelancers"
        Me.TabFreelancers.Padding = New System.Windows.Forms.Padding(3)
        Me.TabFreelancers.Size = New System.Drawing.Size(960, 505)
        Me.TabFreelancers.TabIndex = 0
        Me.TabFreelancers.Text = "Freelancers"
        Me.TabFreelancers.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.RestrictByCountry)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label29)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ComboBoxCountry)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RestrictByService)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RestrictByDomain)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RestrictByTools)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxTools)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label12)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ComboBoxServices)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ComboBoxDomains)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelRecordsFound)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RestrictByTargetLang)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RestrictBySourceLang)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ComboBoxTargetLang)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ComboBoxSourceLang)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(954, 499)
        Me.SplitContainer1.SplitterDistance = 121
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 0
        '
        'RestrictByCountry
        '
        Me.RestrictByCountry.AutoSize = True
        Me.RestrictByCountry.Checked = True
        Me.RestrictByCountry.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RestrictByCountry.Location = New System.Drawing.Point(272, 91)
        Me.RestrictByCountry.Name = "RestrictByCountry"
        Me.RestrictByCountry.Size = New System.Drawing.Size(15, 14)
        Me.RestrictByCountry.TabIndex = 59
        Me.RestrictByCountry.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(63, 91)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(51, 15)
        Me.Label29.TabIndex = 58
        Me.Label29.Text = "Country:"
        '
        'ComboBoxCountry
        '
        Me.ComboBoxCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBoxCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxCountry.DataSource = Me.COUNTRIESBindingSource
        Me.ComboBoxCountry.DisplayMember = "COUNTRY"
        Me.ComboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCountry.FormattingEnabled = True
        Me.ComboBoxCountry.Location = New System.Drawing.Point(120, 88)
        Me.ComboBoxCountry.Name = "ComboBoxCountry"
        Me.ComboBoxCountry.Size = New System.Drawing.Size(144, 23)
        Me.ComboBoxCountry.TabIndex = 57
        Me.ComboBoxCountry.ValueMember = "COUN_ID"
        '
        'COUNTRIESBindingSource
        '
        Me.COUNTRIESBindingSource.DataMember = "COUNTRIES"
        Me.COUNTRIESBindingSource.DataSource = Me.DataSet2DataSet
        '
        'DataSet2DataSet
        '
        Me.DataSet2DataSet.DataSetName = "DataSet2DataSet"
        Me.DataSet2DataSet.EnforceConstraints = False
        Me.DataSet2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RestrictByService
        '
        Me.RestrictByService.AutoSize = True
        Me.RestrictByService.Checked = True
        Me.RestrictByService.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RestrictByService.Location = New System.Drawing.Point(916, 91)
        Me.RestrictByService.Name = "RestrictByService"
        Me.RestrictByService.Size = New System.Drawing.Size(15, 14)
        Me.RestrictByService.TabIndex = 56
        Me.RestrictByService.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(876, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 15)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "Restrict?"
        '
        'RestrictByDomain
        '
        Me.RestrictByDomain.AutoSize = True
        Me.RestrictByDomain.Checked = True
        Me.RestrictByDomain.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RestrictByDomain.Location = New System.Drawing.Point(916, 60)
        Me.RestrictByDomain.Name = "RestrictByDomain"
        Me.RestrictByDomain.Size = New System.Drawing.Size(15, 14)
        Me.RestrictByDomain.TabIndex = 54
        Me.RestrictByDomain.UseVisualStyleBackColor = True
        '
        'RestrictByTools
        '
        Me.RestrictByTools.AutoSize = True
        Me.RestrictByTools.Checked = True
        Me.RestrictByTools.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RestrictByTools.Location = New System.Drawing.Point(916, 29)
        Me.RestrictByTools.Name = "RestrictByTools"
        Me.RestrictByTools.Size = New System.Drawing.Size(15, 14)
        Me.RestrictByTools.TabIndex = 53
        Me.RestrictByTools.UseVisualStyleBackColor = True
        '
        'TextBoxTools
        '
        Me.TextBoxTools.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextBoxTools.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBoxTools.Location = New System.Drawing.Point(391, 25)
        Me.TextBoxTools.Name = "TextBoxTools"
        Me.TextBoxTools.Size = New System.Drawing.Size(517, 21)
        Me.TextBoxTools.TabIndex = 52
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(330, 91)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 15)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "Service:"
        '
        'ComboBoxServices
        '
        Me.ComboBoxServices.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBoxServices.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxServices.DataSource = Me.DataTableServiceBindingSource
        Me.ComboBoxServices.DisplayMember = "SERVICE"
        Me.ComboBoxServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxServices.FormattingEnabled = True
        Me.ComboBoxServices.Location = New System.Drawing.Point(391, 88)
        Me.ComboBoxServices.Name = "ComboBoxServices"
        Me.ComboBoxServices.Size = New System.Drawing.Size(517, 23)
        Me.ComboBoxServices.TabIndex = 50
        '
        'DataTableServiceBindingSource
        '
        Me.DataTableServiceBindingSource.DataMember = "DataTableService"
        Me.DataTableServiceBindingSource.DataSource = Me.DataSet2DataSet
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(330, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 15)
        Me.Label10.TabIndex = 49
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
        Me.ComboBoxDomains.Location = New System.Drawing.Point(391, 57)
        Me.ComboBoxDomains.Name = "ComboBoxDomains"
        Me.ComboBoxDomains.Size = New System.Drawing.Size(517, 23)
        Me.ComboBoxDomains.TabIndex = 48
        '
        'DataTableDomainsBindingSource
        '
        Me.DataTableDomainsBindingSource.DataMember = "DataTableDomains"
        Me.DataTableDomainsBindingSource.DataSource = Me.DataSet2DataSet
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(342, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 15)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Tools:"
        '
        'LabelRecordsFound
        '
        Me.LabelRecordsFound.AutoSize = True
        Me.LabelRecordsFound.Location = New System.Drawing.Point(6, 125)
        Me.LabelRecordsFound.Name = "LabelRecordsFound"
        Me.LabelRecordsFound.Size = New System.Drawing.Size(45, 15)
        Me.LabelRecordsFound.TabIndex = 46
        Me.LabelRecordsFound.Text = "Label9"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(232, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Restrict?"
        '
        'RestrictByTargetLang
        '
        Me.RestrictByTargetLang.AutoSize = True
        Me.RestrictByTargetLang.Checked = True
        Me.RestrictByTargetLang.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RestrictByTargetLang.Location = New System.Drawing.Point(272, 60)
        Me.RestrictByTargetLang.Name = "RestrictByTargetLang"
        Me.RestrictByTargetLang.Size = New System.Drawing.Size(15, 14)
        Me.RestrictByTargetLang.TabIndex = 44
        Me.RestrictByTargetLang.UseVisualStyleBackColor = True
        '
        'RestrictBySourceLang
        '
        Me.RestrictBySourceLang.AutoSize = True
        Me.RestrictBySourceLang.Checked = True
        Me.RestrictBySourceLang.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RestrictBySourceLang.Location = New System.Drawing.Point(272, 29)
        Me.RestrictBySourceLang.Name = "RestrictBySourceLang"
        Me.RestrictBySourceLang.Size = New System.Drawing.Size(15, 14)
        Me.RestrictBySourceLang.TabIndex = 43
        Me.RestrictBySourceLang.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 15)
        Me.Label2.TabIndex = 42
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
        Me.ComboBoxTargetLang.Location = New System.Drawing.Point(120, 57)
        Me.ComboBoxTargetLang.Name = "ComboBoxTargetLang"
        Me.ComboBoxTargetLang.Size = New System.Drawing.Size(144, 23)
        Me.ComboBoxTargetLang.TabIndex = 41
        '
        'BindingSourceTargetLang
        '
        Me.BindingSourceTargetLang.AllowNew = False
        Me.BindingSourceTargetLang.DataMember = "DataTableTargetLang"
        Me.BindingSourceTargetLang.DataSource = Me.DataSet2DataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 15)
        Me.Label1.TabIndex = 40
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
        Me.ComboBoxSourceLang.Location = New System.Drawing.Point(120, 25)
        Me.ComboBoxSourceLang.Name = "ComboBoxSourceLang"
        Me.ComboBoxSourceLang.Size = New System.Drawing.Size(144, 23)
        Me.ComboBoxSourceLang.TabIndex = 39
        '
        'BindingSourceSourceLang
        '
        Me.BindingSourceSourceLang.AllowNew = False
        Me.BindingSourceSourceLang.DataMember = "DataTableSourceLang"
        Me.BindingSourceSourceLang.DataSource = Me.DataSet2DataSet
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.NAMEDataGridViewTextBoxColumn, Me.SOURCELANGDataGridViewTextBoxColumn, Me.TARGETLANG1DataGridViewTextBoxColumn, Me.TARGETLANG2DataGridViewTextBoxColumn, Me.RATEDataGridViewTextBoxColumn, Me.CURRENCYDataGridViewTextBoxColumn, Me.COUNTRYDataGridViewTextBoxColumn, Me.RoleDataGridViewTextBoxColumn, Me.SERVICEDataGridViewTextBoxColumn, Me.APPROVALDataGridViewTextBoxColumn, Me.EmailButton})
        Me.DataGridView1.DataSource = Me.BindingSourceFreelancers
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(954, 373)
        Me.DataGridView1.TabIndex = 25
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'NAMEDataGridViewTextBoxColumn
        '
        Me.NAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.NAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME"
        Me.NAMEDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NAMEDataGridViewTextBoxColumn.MinimumWidth = 100
        Me.NAMEDataGridViewTextBoxColumn.Name = "NAMEDataGridViewTextBoxColumn"
        Me.NAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.NAMEDataGridViewTextBoxColumn.Width = 150
        '
        'SOURCELANGDataGridViewTextBoxColumn
        '
        Me.SOURCELANGDataGridViewTextBoxColumn.DataPropertyName = "SOURCELANG"
        Me.SOURCELANGDataGridViewTextBoxColumn.FillWeight = 13.30059!
        Me.SOURCELANGDataGridViewTextBoxColumn.HeaderText = "Source Lang"
        Me.SOURCELANGDataGridViewTextBoxColumn.Name = "SOURCELANGDataGridViewTextBoxColumn"
        Me.SOURCELANGDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TARGETLANG1DataGridViewTextBoxColumn
        '
        Me.TARGETLANG1DataGridViewTextBoxColumn.DataPropertyName = "TARGETLANG1"
        Me.TARGETLANG1DataGridViewTextBoxColumn.FillWeight = 13.30059!
        Me.TARGETLANG1DataGridViewTextBoxColumn.HeaderText = "TargetLang 1"
        Me.TARGETLANG1DataGridViewTextBoxColumn.Name = "TARGETLANG1DataGridViewTextBoxColumn"
        Me.TARGETLANG1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'TARGETLANG2DataGridViewTextBoxColumn
        '
        Me.TARGETLANG2DataGridViewTextBoxColumn.DataPropertyName = "TARGETLANG2"
        Me.TARGETLANG2DataGridViewTextBoxColumn.FillWeight = 13.30059!
        Me.TARGETLANG2DataGridViewTextBoxColumn.HeaderText = "TargetLang 2"
        Me.TARGETLANG2DataGridViewTextBoxColumn.Name = "TARGETLANG2DataGridViewTextBoxColumn"
        Me.TARGETLANG2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'RATEDataGridViewTextBoxColumn
        '
        Me.RATEDataGridViewTextBoxColumn.DataPropertyName = "RATE"
        Me.RATEDataGridViewTextBoxColumn.FillWeight = 8.842526!
        Me.RATEDataGridViewTextBoxColumn.HeaderText = "Rate"
        Me.RATEDataGridViewTextBoxColumn.Name = "RATEDataGridViewTextBoxColumn"
        Me.RATEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CURRENCYDataGridViewTextBoxColumn
        '
        Me.CURRENCYDataGridViewTextBoxColumn.DataPropertyName = "CURRENCY"
        Me.CURRENCYDataGridViewTextBoxColumn.FillWeight = 6.631895!
        Me.CURRENCYDataGridViewTextBoxColumn.HeaderText = "Currency"
        Me.CURRENCYDataGridViewTextBoxColumn.Name = "CURRENCYDataGridViewTextBoxColumn"
        Me.CURRENCYDataGridViewTextBoxColumn.ReadOnly = True
        '
        'COUNTRYDataGridViewTextBoxColumn
        '
        Me.COUNTRYDataGridViewTextBoxColumn.DataPropertyName = "COUNTRY"
        Me.COUNTRYDataGridViewTextBoxColumn.FillWeight = 8.842526!
        Me.COUNTRYDataGridViewTextBoxColumn.HeaderText = "Country"
        Me.COUNTRYDataGridViewTextBoxColumn.Name = "COUNTRYDataGridViewTextBoxColumn"
        Me.COUNTRYDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RoleDataGridViewTextBoxColumn
        '
        Me.RoleDataGridViewTextBoxColumn.DataPropertyName = "Role"
        Me.RoleDataGridViewTextBoxColumn.FillWeight = 13.30059!
        Me.RoleDataGridViewTextBoxColumn.HeaderText = "Role"
        Me.RoleDataGridViewTextBoxColumn.Name = "RoleDataGridViewTextBoxColumn"
        Me.RoleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SERVICEDataGridViewTextBoxColumn
        '
        Me.SERVICEDataGridViewTextBoxColumn.DataPropertyName = "SERVICE"
        Me.SERVICEDataGridViewTextBoxColumn.FillWeight = 13.30059!
        Me.SERVICEDataGridViewTextBoxColumn.HeaderText = "Service"
        Me.SERVICEDataGridViewTextBoxColumn.Name = "SERVICEDataGridViewTextBoxColumn"
        Me.SERVICEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'APPROVALDataGridViewTextBoxColumn
        '
        Me.APPROVALDataGridViewTextBoxColumn.DataPropertyName = "APPROVAL"
        Me.APPROVALDataGridViewTextBoxColumn.FillWeight = 13.30059!
        Me.APPROVALDataGridViewTextBoxColumn.HeaderText = "Approval"
        Me.APPROVALDataGridViewTextBoxColumn.Name = "APPROVALDataGridViewTextBoxColumn"
        Me.APPROVALDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EmailButton
        '
        Me.EmailButton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.EmailButton.DataPropertyName = "EMAIL1"
        Me.EmailButton.HeaderText = "Emailing"
        Me.EmailButton.Name = "EmailButton"
        Me.EmailButton.ReadOnly = True
        '
        'BindingSourceFreelancers
        '
        Me.BindingSourceFreelancers.AllowNew = False
        Me.BindingSourceFreelancers.DataMember = "DataTableFreelancers"
        Me.BindingSourceFreelancers.DataSource = Me.DataSet2DataSet
        '
        'TabDetails
        '
        Me.TabDetails.Controls.Add(Me.SplitContainer3)
        Me.TabDetails.Location = New System.Drawing.Point(4, 24)
        Me.TabDetails.Name = "TabDetails"
        Me.TabDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDetails.Size = New System.Drawing.Size(960, 505)
        Me.TabDetails.TabIndex = 2
        Me.TabDetails.Text = "Details"
        Me.TabDetails.UseVisualStyleBackColor = True
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer3.IsSplitterFixed = True
        Me.SplitContainer3.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer3.Panel1.Controls.Add(Me.TableLayoutPanel2)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.DataGridView2)
        Me.SplitContainer3.Size = New System.Drawing.Size(954, 499)
        Me.SplitContainer3.SplitterDistance = 184
        Me.SplitContainer3.SplitterWidth = 5
        Me.SplitContainer3.TabIndex = 4
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.48677!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.51323!))
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox5, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox4, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox3, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBoxEmailAddress, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label14, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label16, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label17, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.DetailsBoxName, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonSendEmail, 1, 5)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(445, 178)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'TextBox5
        '
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DTFreelancerInfoBindingSource, "COUN_NAME", True))
        Me.TextBox5.Location = New System.Drawing.Point(103, 111)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(339, 21)
        Me.TextBox5.TabIndex = 9
        '
        'DTFreelancerInfoBindingSource
        '
        Me.DTFreelancerInfoBindingSource.DataMember = "DTFreelancerInfo"
        Me.DTFreelancerInfoBindingSource.DataSource = Me.DataSet2DataSet
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DTFreelancerInfoBindingSource, "RES_PHONE1", True))
        Me.TextBox4.Location = New System.Drawing.Point(103, 84)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(339, 21)
        Me.TextBox4.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DTFreelancerInfoBindingSource, "SKYPE", True))
        Me.TextBox3.Location = New System.Drawing.Point(103, 57)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(339, 21)
        Me.TextBox3.TabIndex = 7
        '
        'TextBoxEmailAddress
        '
        Me.TextBoxEmailAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DTFreelancerInfoBindingSource, "RES_EMAIL1", True))
        Me.TextBoxEmailAddress.Location = New System.Drawing.Point(103, 30)
        Me.TextBoxEmailAddress.Name = "TextBoxEmailAddress"
        Me.TextBoxEmailAddress.ReadOnly = True
        Me.TextBoxEmailAddress.Size = New System.Drawing.Size(339, 21)
        Me.TextBoxEmailAddress.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Location = New System.Drawing.Point(3, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 27)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Name"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label14.Location = New System.Drawing.Point(3, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 27)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Email"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label15.Location = New System.Drawing.Point(3, 54)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 27)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Skype"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label16.Location = New System.Drawing.Point(3, 81)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(94, 27)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Phone"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label17.Location = New System.Drawing.Point(3, 108)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(94, 27)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Country"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DetailsBoxName
        '
        Me.DetailsBoxName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DTFreelancerInfoBindingSource, "RES_NAME", True))
        Me.DetailsBoxName.Location = New System.Drawing.Point(103, 3)
        Me.DetailsBoxName.Name = "DetailsBoxName"
        Me.DetailsBoxName.ReadOnly = True
        Me.DetailsBoxName.Size = New System.Drawing.Size(339, 21)
        Me.DetailsBoxName.TabIndex = 5
        '
        'ButtonSendEmail
        '
        Me.ButtonSendEmail.Location = New System.Drawing.Point(103, 138)
        Me.ButtonSendEmail.Name = "ButtonSendEmail"
        Me.ButtonSendEmail.Size = New System.Drawing.Size(87, 27)
        Me.ButtonSendEmail.TabIndex = 10
        Me.ButtonSendEmail.Text = "Send Email"
        Me.ButtonSendEmail.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.48677!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.51323!))
        Me.TableLayoutPanel2.Controls.Add(Me.RichTextBox1, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox8, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox9, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label18, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label19, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label20, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label21, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox10, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(457, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(441, 197)
        Me.TableLayoutPanel2.TabIndex = 3
        '
        'RichTextBox1
        '
        Me.RichTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSourceCatTools, "TOOLS", True))
        Me.RichTextBox1.Location = New System.Drawing.Point(102, 84)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(335, 94)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = ""
        '
        'BindingSourceCatTools
        '
        Me.BindingSourceCatTools.AllowNew = False
        Me.BindingSourceCatTools.DataMember = "CatTools"
        Me.BindingSourceCatTools.DataSource = Me.DataSet2DataSet
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DTFreelancerInfoBindingSource, "SKYPE", True))
        Me.TextBox8.Location = New System.Drawing.Point(102, 57)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(335, 21)
        Me.TextBox8.TabIndex = 7
        '
        'TextBox9
        '
        Me.TextBox9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DTFreelancerInfoBindingSource, "FUZZYRATE", True))
        Me.TextBox9.Location = New System.Drawing.Point(102, 30)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(335, 21)
        Me.TextBox9.TabIndex = 6
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label18.Location = New System.Drawing.Point(3, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(93, 27)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "TM-RepsRate"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label19.Location = New System.Drawing.Point(3, 27)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(93, 27)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "TM-FuzzyRate"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label20.Location = New System.Drawing.Point(3, 54)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(93, 27)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Skype"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label21.Location = New System.Drawing.Point(3, 81)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(93, 116)
        Me.Label21.TabIndex = 3
        Me.Label21.Text = "CAT Tools"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox10
        '
        Me.TextBox10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DTFreelancerInfoBindingSource, "REPSRATE", True))
        Me.TextBox10.Location = New System.Drawing.Point(102, 3)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(335, 21)
        Me.TextBox10.TabIndex = 5
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RJOB_ASSIGNED, Me.ISCOMPLETED, Me.PROJ_CODE, Me.LASTJOBDataGridViewTextBoxColumn, Me.SERVICEDataGridViewTextBoxColumn1, Me.CLIENTDataGridViewTextBoxColumn, Me.PROJECTMANAGERDataGridViewTextBoxColumn, Me.RJOB_PRICE, Me.RJOB_FEE_KIND, Me.DataGridViewTextBoxColumn8})
        Me.DataGridView2.DataSource = Me.DTDetailsBindingSource
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(954, 310)
        Me.DataGridView2.TabIndex = 1
        '
        'RJOB_ASSIGNED
        '
        Me.RJOB_ASSIGNED.DataPropertyName = "RJOB_ASSIGNED"
        Me.RJOB_ASSIGNED.HeaderText = "Date"
        Me.RJOB_ASSIGNED.Name = "RJOB_ASSIGNED"
        Me.RJOB_ASSIGNED.ReadOnly = True
        '
        'ISCOMPLETED
        '
        Me.ISCOMPLETED.DataPropertyName = "ISCOMPLETED"
        Me.ISCOMPLETED.HeaderText = "Completed"
        Me.ISCOMPLETED.Name = "ISCOMPLETED"
        Me.ISCOMPLETED.ReadOnly = True
        Me.ISCOMPLETED.Visible = False
        '
        'PROJ_CODE
        '
        Me.PROJ_CODE.DataPropertyName = "PROJ_CODE"
        Me.PROJ_CODE.HeaderText = "Code"
        Me.PROJ_CODE.Name = "PROJ_CODE"
        Me.PROJ_CODE.ReadOnly = True
        '
        'LASTJOBDataGridViewTextBoxColumn
        '
        Me.LASTJOBDataGridViewTextBoxColumn.DataPropertyName = "LASTJOB"
        Me.LASTJOBDataGridViewTextBoxColumn.HeaderText = "LastJob"
        Me.LASTJOBDataGridViewTextBoxColumn.Name = "LASTJOBDataGridViewTextBoxColumn"
        Me.LASTJOBDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SERVICEDataGridViewTextBoxColumn1
        '
        Me.SERVICEDataGridViewTextBoxColumn1.DataPropertyName = "SERVICE"
        Me.SERVICEDataGridViewTextBoxColumn1.HeaderText = "Service"
        Me.SERVICEDataGridViewTextBoxColumn1.Name = "SERVICEDataGridViewTextBoxColumn1"
        Me.SERVICEDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CLIENTDataGridViewTextBoxColumn
        '
        Me.CLIENTDataGridViewTextBoxColumn.DataPropertyName = "CLIENT"
        Me.CLIENTDataGridViewTextBoxColumn.HeaderText = "Client"
        Me.CLIENTDataGridViewTextBoxColumn.Name = "CLIENTDataGridViewTextBoxColumn"
        Me.CLIENTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PROJECTMANAGERDataGridViewTextBoxColumn
        '
        Me.PROJECTMANAGERDataGridViewTextBoxColumn.DataPropertyName = "PROJECTMANAGER"
        Me.PROJECTMANAGERDataGridViewTextBoxColumn.HeaderText = "PM"
        Me.PROJECTMANAGERDataGridViewTextBoxColumn.Name = "PROJECTMANAGERDataGridViewTextBoxColumn"
        Me.PROJECTMANAGERDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RJOB_PRICE
        '
        Me.RJOB_PRICE.DataPropertyName = "RJOB_PRICE"
        Me.RJOB_PRICE.HeaderText = "Price"
        Me.RJOB_PRICE.Name = "RJOB_PRICE"
        Me.RJOB_PRICE.ReadOnly = True
        '
        'RJOB_FEE_KIND
        '
        Me.RJOB_FEE_KIND.DataPropertyName = "RJOB_FEE_KIND"
        Me.RJOB_FEE_KIND.HeaderText = "Fee Kind"
        Me.RJOB_FEE_KIND.Name = "RJOB_FEE_KIND"
        Me.RJOB_FEE_KIND.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CURR_NAME"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Currency"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DTDetailsBindingSource
        '
        Me.DTDetailsBindingSource.DataMember = "DTDetails"
        Me.DTDetailsBindingSource.DataSource = Me.DataSet2DataSet
        '
        'TabEmail
        '
        Me.TabEmail.Controls.Add(Me.TableLayoutPanel4)
        Me.TabEmail.Location = New System.Drawing.Point(4, 24)
        Me.TabEmail.Name = "TabEmail"
        Me.TabEmail.Size = New System.Drawing.Size(960, 505)
        Me.TabEmail.TabIndex = 3
        Me.TabEmail.Text = "Email"
        Me.TabEmail.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.AutoSize = True
        Me.TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.Controls.Add(Me.Label22a, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.EmailBody, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.EmailSubject, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.Label30a, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(960, 505)
        Me.TableLayoutPanel4.TabIndex = 9
        '
        'Label22a
        '
        Me.Label22a.AutoSize = True
        Me.Label22a.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label22a.Location = New System.Drawing.Point(3, 36)
        Me.Label22a.Margin = New System.Windows.Forms.Padding(3)
        Me.Label22a.Name = "Label22a"
        Me.Label22a.Size = New System.Drawing.Size(62, 21)
        Me.Label22a.TabIndex = 4
        Me.Label22a.Text = "Subject:"
        Me.Label22a.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EmailBody
        '
        Me.EmailBody.BorderStyle = TXTextControl.BorderStyle.FixedSingle
        Me.EmailBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmailBody.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.EmailBody.Location = New System.Drawing.Point(71, 63)
        Me.EmailBody.Name = "EmailBody"
        Me.EmailBody.Size = New System.Drawing.Size(886, 439)
        Me.EmailBody.TabIndex = 8
        Me.EmailBody.Text = "Write the body here"
        Me.EmailBody.ViewMode = TXTextControl.ViewMode.SimpleControl
        '
        'EmailSubject
        '
        Me.EmailSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmailSubject.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Freelancers_Lookup.My.MySettings.Default, "EmailSubject", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.EmailSubject.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmailSubject.Location = New System.Drawing.Point(71, 36)
        Me.EmailSubject.Name = "EmailSubject"
        Me.EmailSubject.Size = New System.Drawing.Size(886, 21)
        Me.EmailSubject.TabIndex = 7
        Me.EmailSubject.Text = Global.Freelancers_Lookup.My.MySettings.Default.EmailSubject
        '
        'Label30a
        '
        Me.Label30a.AutoSize = True
        Me.Label30a.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label30a.Location = New System.Drawing.Point(3, 0)
        Me.Label30a.Name = "Label30a"
        Me.Label30a.Size = New System.Drawing.Size(62, 33)
        Me.Label30a.TabIndex = 9
        Me.Label30a.Text = "Template:"
        Me.Label30a.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.AutoSize = True
        Me.TableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel5.Controls.Add(Me.TemplatesButtonAdd, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TemplatesButtonRemove, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TemplatesCombo, 2, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(68, 0)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(892, 33)
        Me.TableLayoutPanel5.TabIndex = 10
        '
        'TemplatesButtonAdd
        '
        Me.TemplatesButtonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TemplatesButtonAdd.ImageKey = "Button Add.png"
        Me.TemplatesButtonAdd.ImageList = Me.ImageList1
        Me.TemplatesButtonAdd.Location = New System.Drawing.Point(3, 3)
        Me.TemplatesButtonAdd.Name = "TemplatesButtonAdd"
        Me.TemplatesButtonAdd.Size = New System.Drawing.Size(88, 27)
        Me.TemplatesButtonAdd.TabIndex = 0
        Me.TemplatesButtonAdd.Text = "Add New"
        Me.TemplatesButtonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TemplatesButtonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.TemplatesButtonAdd.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Button Add.png")
        Me.ImageList1.Images.SetKeyName(1, "Button Remove.png")
        '
        'TemplatesButtonRemove
        '
        Me.TemplatesButtonRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TemplatesButtonRemove.ImageKey = "Button Remove.png"
        Me.TemplatesButtonRemove.ImageList = Me.ImageList1
        Me.TemplatesButtonRemove.Location = New System.Drawing.Point(97, 3)
        Me.TemplatesButtonRemove.Name = "TemplatesButtonRemove"
        Me.TemplatesButtonRemove.Size = New System.Drawing.Size(88, 27)
        Me.TemplatesButtonRemove.TabIndex = 1
        Me.TemplatesButtonRemove.Text = "Remove"
        Me.TemplatesButtonRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TemplatesButtonRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.TemplatesButtonRemove.UseVisualStyleBackColor = True
        '
        'TemplatesCombo
        '
        Me.TemplatesCombo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TemplatesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TemplatesCombo.FormattingEnabled = True
        Me.TemplatesCombo.Location = New System.Drawing.Point(191, 6)
        Me.TemplatesCombo.Name = "TemplatesCombo"
        Me.TemplatesCombo.Size = New System.Drawing.Size(698, 23)
        Me.TemplatesCombo.TabIndex = 2
        '
        'TabSettings
        '
        Me.TabSettings.BackColor = System.Drawing.Color.Transparent
        Me.TabSettings.Controls.Add(Me.SplitContainer2)
        Me.TabSettings.Location = New System.Drawing.Point(4, 24)
        Me.TabSettings.Name = "TabSettings"
        Me.TabSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSettings.Size = New System.Drawing.Size(960, 505)
        Me.TabSettings.TabIndex = 1
        Me.TabSettings.Text = "Settings"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.EmailSettingsGroupBox)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer2.Size = New System.Drawing.Size(954, 499)
        Me.SplitContainer2.SplitterDistance = 404
        Me.SplitContainer2.SplitterWidth = 5
        Me.SplitContainer2.TabIndex = 3
        '
        'EmailSettingsGroupBox
        '
        Me.EmailSettingsGroupBox.Controls.Add(Me.TableLayoutPanel3)
        Me.EmailSettingsGroupBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.EmailSettingsGroupBox.Location = New System.Drawing.Point(0, 0)
        Me.EmailSettingsGroupBox.Name = "EmailSettingsGroupBox"
        Me.EmailSettingsGroupBox.Size = New System.Drawing.Size(404, 234)
        Me.EmailSettingsGroupBox.TabIndex = 0
        Me.EmailSettingsGroupBox.TabStop = False
        Me.EmailSettingsGroupBox.Text = "Email Settings"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.1028!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.8972!))
        Me.TableLayoutPanel3.Controls.Add(Me.EmailButtonTest, 1, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.Label27, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label24, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label25, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label26, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label28, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.EmailSettingsName, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.EmailSettingsEmail, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.EmailSettingsServer, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.EmailSettingsPassword, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.EmailSettingsPort, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.EmailTestModeCheckBox, 1, 5)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 17)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 7
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(398, 214)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'EmailButtonTest
        '
        Me.EmailButtonTest.Location = New System.Drawing.Point(110, 163)
        Me.EmailButtonTest.Name = "EmailButtonTest"
        Me.EmailButtonTest.Size = New System.Drawing.Size(87, 27)
        Me.EmailButtonTest.TabIndex = 0
        Me.EmailButtonTest.Text = "Test Email"
        Me.EmailButtonTest.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label27.Location = New System.Drawing.Point(3, 81)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(101, 27)
        Me.Label27.TabIndex = 14
        Me.Label27.Text = "Email Password:"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label24.Location = New System.Drawing.Point(3, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(101, 27)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Your Name:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label25.Location = New System.Drawing.Point(3, 27)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(101, 27)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "Your Email:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label26.Location = New System.Drawing.Point(3, 54)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(101, 27)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "Email Server:"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label28.Location = New System.Drawing.Point(3, 108)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(101, 27)
        Me.Label28.TabIndex = 4
        Me.Label28.Text = "Port:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EmailSettingsName
        '
        Me.EmailSettingsName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Freelancers_Lookup.My.MySettings.Default, "EmailSettingsName", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.EmailSettingsName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmailSettingsName.Location = New System.Drawing.Point(110, 3)
        Me.EmailSettingsName.Name = "EmailSettingsName"
        Me.EmailSettingsName.Size = New System.Drawing.Size(285, 21)
        Me.EmailSettingsName.TabIndex = 6
        Me.EmailSettingsName.Text = Global.Freelancers_Lookup.My.MySettings.Default.EmailSettingsName
        '
        'EmailSettingsEmail
        '
        Me.EmailSettingsEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Freelancers_Lookup.My.MySettings.Default, "EmailSettingsEmail", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.EmailSettingsEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmailSettingsEmail.Location = New System.Drawing.Point(110, 30)
        Me.EmailSettingsEmail.Name = "EmailSettingsEmail"
        Me.EmailSettingsEmail.Size = New System.Drawing.Size(285, 21)
        Me.EmailSettingsEmail.TabIndex = 7
        Me.EmailSettingsEmail.Text = Global.Freelancers_Lookup.My.MySettings.Default.EmailSettingsEmail
        '
        'EmailSettingsServer
        '
        Me.EmailSettingsServer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Freelancers_Lookup.My.MySettings.Default, "EmailSettingsServer", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.EmailSettingsServer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmailSettingsServer.Location = New System.Drawing.Point(110, 57)
        Me.EmailSettingsServer.Name = "EmailSettingsServer"
        Me.EmailSettingsServer.Size = New System.Drawing.Size(285, 21)
        Me.EmailSettingsServer.TabIndex = 8
        Me.EmailSettingsServer.Text = Global.Freelancers_Lookup.My.MySettings.Default.EmailSettingsServer
        '
        'EmailSettingsPassword
        '
        Me.EmailSettingsPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Freelancers_Lookup.My.MySettings.Default, "EmailSettingsPassword", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.EmailSettingsPassword.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmailSettingsPassword.Location = New System.Drawing.Point(110, 84)
        Me.EmailSettingsPassword.Name = "EmailSettingsPassword"
        Me.EmailSettingsPassword.Size = New System.Drawing.Size(285, 21)
        Me.EmailSettingsPassword.TabIndex = 9
        Me.EmailSettingsPassword.Text = Global.Freelancers_Lookup.My.MySettings.Default.EmailSettingsPassword
        Me.EmailSettingsPassword.UseSystemPasswordChar = True
        '
        'EmailSettingsPort
        '
        Me.EmailSettingsPort.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Freelancers_Lookup.My.MySettings.Default, "EmailSettingsPort", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.EmailSettingsPort.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmailSettingsPort.Location = New System.Drawing.Point(110, 111)
        Me.EmailSettingsPort.Name = "EmailSettingsPort"
        Me.EmailSettingsPort.Size = New System.Drawing.Size(285, 21)
        Me.EmailSettingsPort.TabIndex = 10
        Me.EmailSettingsPort.Text = Global.Freelancers_Lookup.My.MySettings.Default.EmailSettingsPort
        '
        'EmailTestModeCheckBox
        '
        Me.EmailTestModeCheckBox.AutoSize = True
        Me.EmailTestModeCheckBox.Checked = Global.Freelancers_Lookup.My.MySettings.Default.EmailTestMode
        Me.EmailTestModeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.EmailTestModeCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Freelancers_Lookup.My.MySettings.Default, "EmailTestMode", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.EmailTestModeCheckBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.EmailTestModeCheckBox.Location = New System.Drawing.Point(110, 138)
        Me.EmailTestModeCheckBox.Name = "EmailTestModeCheckBox"
        Me.EmailTestModeCheckBox.Size = New System.Drawing.Size(227, 19)
        Me.EmailTestModeCheckBox.TabIndex = 15
        Me.EmailTestModeCheckBox.Text = "Test Mode: Don't send to real people"
        Me.EmailTestModeCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.BackColor = System.Drawing.Color.IndianRed
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.ButtonTestDBSettings)
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
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.MinimumSize = New System.Drawing.Size(535, 302)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(545, 346)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Database - HIC SUNT LEONES!"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(111, 205)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(181, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Clear Saved Prefs"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 148)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 15)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Status"
        '
        'ButtonTestDBSettings
        '
        Me.ButtonTestDBSettings.Location = New System.Drawing.Point(111, 172)
        Me.ButtonTestDBSettings.Name = "ButtonTestDBSettings"
        Me.ButtonTestDBSettings.Size = New System.Drawing.Size(87, 27)
        Me.ButtonTestDBSettings.TabIndex = 18
        Me.ButtonTestDBSettings.Text = "Test"
        Me.ButtonTestDBSettings.UseVisualStyleBackColor = True
        '
        'ButtonApplyDBSettings
        '
        Me.ButtonApplyDBSettings.Location = New System.Drawing.Point(205, 172)
        Me.ButtonApplyDBSettings.Name = "ButtonApplyDBSettings"
        Me.ButtonApplyDBSettings.Size = New System.Drawing.Size(87, 27)
        Me.ButtonApplyDBSettings.TabIndex = 12
        Me.ButtonApplyDBSettings.Text = "Apply"
        Me.ButtonApplyDBSettings.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Enabled = False
        Me.CheckBox3.Location = New System.Drawing.Point(469, 114)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(57, 19)
        Me.CheckBox3.TabIndex = 11
        Me.CheckBox3.Text = "Show"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 15)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Password"
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Freelancers_Lookup.My.MySettings.Default, "DBPassword", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxPassword.Location = New System.Drawing.Point(111, 112)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(350, 21)
        Me.TextBoxPassword.TabIndex = 9
        Me.TextBoxPassword.Text = Global.Freelancers_Lookup.My.MySettings.Default.DBPassword
        Me.TextBoxPassword.UseSystemPasswordChar = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Database"
        '
        'TextBoxDatabase
        '
        Me.TextBoxDatabase.AutoCompleteCustomSource.AddRange(New String() {"E:\Program Files (x86)\AIT\Projetex 9\Projetex Server\Database\projetex.fdb", "C:\Projetex9\Projetex Server\Database\projetex.fdb"})
        Me.TextBoxDatabase.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextBoxDatabase.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBoxDatabase.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Freelancers_Lookup.My.MySettings.Default, "DBFile", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxDatabase.Location = New System.Drawing.Point(111, 82)
        Me.TextBoxDatabase.Name = "TextBoxDatabase"
        Me.TextBoxDatabase.Size = New System.Drawing.Size(350, 21)
        Me.TextBoxDatabase.TabIndex = 7
        Me.TextBoxDatabase.Text = Global.Freelancers_Lookup.My.MySettings.Default.DBFile
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Server Port"
        '
        'TextBoxServerPort
        '
        Me.TextBoxServerPort.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextBoxServerPort.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBoxServerPort.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Freelancers_Lookup.My.MySettings.Default, "DBPort", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxServerPort.Location = New System.Drawing.Point(111, 52)
        Me.TextBoxServerPort.Name = "TextBoxServerPort"
        Me.TextBoxServerPort.Size = New System.Drawing.Size(350, 21)
        Me.TextBoxServerPort.TabIndex = 5
        Me.TextBoxServerPort.Text = Global.Freelancers_Lookup.My.MySettings.Default.DBPort
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Server Address"
        '
        'TextBoxServerAddress
        '
        Me.TextBoxServerAddress.AutoCompleteCustomSource.AddRange(New String() {"192.168.0.56", "192.168.56.101"})
        Me.TextBoxServerAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextBoxServerAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBoxServerAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Freelancers_Lookup.My.MySettings.Default, "DBAddress", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxServerAddress.Location = New System.Drawing.Point(111, 22)
        Me.TextBoxServerAddress.Name = "TextBoxServerAddress"
        Me.TextBoxServerAddress.Size = New System.Drawing.Size(350, 21)
        Me.TextBoxServerAddress.TabIndex = 2
        Me.TextBoxServerAddress.Text = Global.Freelancers_Lookup.My.MySettings.Default.DBAddress
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 17)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.StatusLed})
        Me.ShapeContainer1.Size = New System.Drawing.Size(539, 326)
        Me.ShapeContainer1.TabIndex = 20
        Me.ShapeContainer1.TabStop = False
        '
        'StatusLed
        '
        Me.StatusLed.BackColor = System.Drawing.Color.Gold
        Me.StatusLed.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.StatusLed.Location = New System.Drawing.Point(109, 122)
        Me.StatusLed.Name = "StatusLed"
        Me.StatusLed.Size = New System.Drawing.Size(25, 25)
        '
        'DataSet2DataSet1
        '
        Me.DataSet2DataSet1.DataSetName = "DataSet2DataSet"
        Me.DataSet2DataSet1.EnforceConstraints = False
        Me.DataSet2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FbConnection1
        '
        Me.FbConnection1.ConnectionString = resources.GetString("FbConnection1.ConnectionString")
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
        'FreelancerInfoTableAdapter
        '
        Me.FreelancerInfoTableAdapter.ClearBeforeFill = True
        '
        'COUNTRIESTableAdapter
        '
        Me.COUNTRIESTableAdapter.ClearBeforeFill = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 533)
        Me.Controls.Add(Me.TabControl1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.Freelancers_Lookup.My.MySettings.Default, "MFLocation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = Global.Freelancers_Lookup.My.MySettings.Default.MFLocation
        Me.MinimumSize = New System.Drawing.Size(984, 363)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Mayflower: Projetex Lookup Tool"
        Me.TabControl1.ResumeLayout(False)
        Me.TabFreelancers.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.COUNTRIESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTableServiceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTableDomainsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceTargetLang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceSourceLang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSourceFreelancers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabDetails.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DTFreelancerInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.BindingSourceCatTools, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabEmail.ResumeLayout(False)
        Me.TabEmail.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TabSettings.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.EmailSettingsGroupBox.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataSet2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabFreelancers As System.Windows.Forms.TabPage
    Friend WithEvents TabSettings As System.Windows.Forms.TabPage
    Friend WithEvents DataTableSourceLangBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataTableTargetLangBindingSource As System.Windows.Forms.BindingSource
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
    Friend WithEvents ButtonTestDBSettings As System.Windows.Forms.Button
    Friend WithEvents DataTablePeopleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet2DataSet As Freelancers_Lookup.DataSet2DataSet
    Friend WithEvents DataTableFreelancersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FreelancersTableAdapter As Freelancers_Lookup.DataSet2DataSetTableAdapters.FreelancersTableAdapter
    Friend WithEvents DataTableSourceLangBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents SourceLangTableAdapter As Freelancers_Lookup.DataSet2DataSetTableAdapters.SourceLangTableAdapter
    Friend WithEvents BindingSourceFreelancers As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSourceSourceLang As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSourceTargetLang As System.Windows.Forms.BindingSource
    Friend WithEvents TargetLangTableAdapter As Freelancers_Lookup.DataSet2DataSetTableAdapters.TargetLangTableAdapter
    Friend WithEvents FbConnection1 As FirebirdSql.Data.FirebirdClient.FbConnection
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents BindingSourceCatTools As System.Windows.Forms.BindingSource
    Friend WithEvents CatToolsTableAdapter As Freelancers_Lookup.DataSet2DataSetTableAdapters.CatToolsTableAdapter
    Friend WithEvents RESIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RESNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RESCODEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CURRNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CURRDESCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COUNNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COUNFLAGDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents DataTableDomainsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DomainsTableAdapter As Freelancers_Lookup.DataSet2DataSetTableAdapters.DomainsTableAdapter
    Friend WithEvents DataTableServiceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ServiceTableAdapter As Freelancers_Lookup.DataSet2DataSetTableAdapters.ServiceTableAdapter
    Friend WithEvents FbCommand1 As FirebirdSql.Data.FirebirdClient.FbCommand
    Friend WithEvents TabDetails As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DTDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TADetails As Freelancers_Lookup.DataSet2DataSetTableAdapters.TADetails
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DTFreelancerInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet2DataSet1 As Freelancers_Lookup.DataSet2DataSet
    Friend WithEvents FreelancerInfoTableAdapter As Freelancers_Lookup.DataSet2DataSetTableAdapters.FreelancerInfoTableAdapter
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents DetailsBoxName As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents TabEmail As System.Windows.Forms.TabPage
    Friend WithEvents EmailSubject As System.Windows.Forms.TextBox
    Friend WithEvents Label22a As System.Windows.Forms.Label
    Friend WithEvents ButtonSendEmail As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents RestrictByService As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents RestrictByDomain As System.Windows.Forms.CheckBox
    Friend WithEvents RestrictByTools As System.Windows.Forms.CheckBox
    Friend WithEvents TextBoxTools As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxServices As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxDomains As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LabelRecordsFound As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RestrictByTargetLang As System.Windows.Forms.CheckBox
    Friend WithEvents RestrictBySourceLang As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxTargetLang As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxSourceLang As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents EmailSettingsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents EmailSettingsName As System.Windows.Forms.TextBox
    Friend WithEvents EmailSettingsEmail As System.Windows.Forms.TextBox
    Friend WithEvents EmailSettingsServer As System.Windows.Forms.TextBox
    Friend WithEvents EmailSettingsPassword As System.Windows.Forms.TextBox
    Friend WithEvents EmailSettingsPort As System.Windows.Forms.TextBox
    Friend WithEvents EmailButtonTest As System.Windows.Forms.Button
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents EmailBody As TXTextControl.TextControl
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents EmailTestModeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
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
    Friend WithEvents EmailButton As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents RestrictByCountry As System.Windows.Forms.CheckBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxCountry As System.Windows.Forms.ComboBox
    Friend WithEvents COUNTRIESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COUNTRIESTableAdapter As Freelancers_Lookup.DataSet2DataSetTableAdapters.COUNTRIESTableAdapter
    Friend WithEvents RJOB_ASSIGNED As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ISCOMPLETED As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROJ_CODE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LASTJOBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SERVICEDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIENTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROJECTMANAGERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RJOB_PRICE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RJOB_FEE_KIND As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label30a As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TemplatesButtonAdd As System.Windows.Forms.Button
    Friend WithEvents TemplatesButtonRemove As System.Windows.Forms.Button
    Friend WithEvents TemplatesCombo As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Private WithEvents StatusLed As Microsoft.VisualBasic.PowerPacks.OvalShape

End Class
