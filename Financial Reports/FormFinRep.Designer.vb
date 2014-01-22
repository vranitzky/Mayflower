<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFinRep
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFinRep))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabReport1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ButtonR1Export = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewReport1 = New System.Windows.Forms.DataGridView()
        Me.TabReport2 = New System.Windows.Forms.TabPage()
        Me.TabReport3 = New System.Windows.Forms.TabPage()
        Me.TabSettings = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelDBStatus = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ButtonTestDBSettings = New System.Windows.Forms.Button()
        Me.ButtonApplyDBSettings = New System.Windows.Forms.Button()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FbConnection1 = New FirebirdSql.Data.FirebirdClient.FbConnection()
        Me.DTReport1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet2 = New Financial_Reports.DataSet2()
        Me.DTReport1TA = New Financial_Reports.DataSet2TableAdapters.DTReport1TA()
        Me.PROJIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROJFULLDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCONNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CJOBSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RJOBSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AITUSERREALNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProfitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCProfitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimePickerFrom = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerTo = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxDatabase = New System.Windows.Forms.TextBox()
        Me.TextBoxServerPort = New System.Windows.Forms.TextBox()
        Me.TextBoxServerAddress = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabReport1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridViewReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabReport2.SuspendLayout()
        Me.TabSettings.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DTReport1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabReport1)
        Me.TabControl1.Controls.Add(Me.TabReport2)
        Me.TabControl1.Controls.Add(Me.TabReport3)
        Me.TabControl1.Controls.Add(Me.TabSettings)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1143, 509)
        Me.TabControl1.TabIndex = 1
        '
        'TabReport1
        '
        Me.TabReport1.Controls.Add(Me.SplitContainer1)
        Me.TabReport1.Location = New System.Drawing.Point(4, 22)
        Me.TabReport1.Name = "TabReport1"
        Me.TabReport1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabReport1.Size = New System.Drawing.Size(1135, 483)
        Me.TabReport1.TabIndex = 0
        Me.TabReport1.Text = "Profit Report"
        Me.TabReport1.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonR1Export)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DateTimePickerFrom)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DateTimePickerTo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridViewReport1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1129, 477)
        Me.SplitContainer1.SplitterDistance = 28
        Me.SplitContainer1.TabIndex = 0
        '
        'ButtonR1Export
        '
        Me.ButtonR1Export.Location = New System.Drawing.Point(593, 2)
        Me.ButtonR1Export.Name = "ButtonR1Export"
        Me.ButtonR1Export.Size = New System.Drawing.Size(75, 23)
        Me.ButtonR1Export.TabIndex = 9
        Me.ButtonR1Export.Text = "Export"
        Me.ButtonR1Export.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(512, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Generate"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(279, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "To:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "From:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridViewReport1
        '
        Me.DataGridViewReport1.AllowUserToAddRows = False
        Me.DataGridViewReport1.AllowUserToDeleteRows = False
        Me.DataGridViewReport1.AllowUserToOrderColumns = True
        Me.DataGridViewReport1.AutoGenerateColumns = False
        Me.DataGridViewReport1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridViewReport1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewReport1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PROJIDDataGridViewTextBoxColumn, Me.PROJFULLDataGridViewTextBoxColumn, Me.CCONNAMEDataGridViewTextBoxColumn, Me.CJOBSDataGridViewTextBoxColumn, Me.RJOBSDataGridViewTextBoxColumn, Me.AITUSERREALNAMEDataGridViewTextBoxColumn, Me.ProfitDataGridViewTextBoxColumn, Me.PCProfitDataGridViewTextBoxColumn, Me.InvNoDataGridViewTextBoxColumn})
        Me.DataGridViewReport1.DataSource = Me.DTReport1BindingSource
        Me.DataGridViewReport1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewReport1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewReport1.Name = "DataGridViewReport1"
        Me.DataGridViewReport1.ReadOnly = True
        Me.DataGridViewReport1.RowHeadersVisible = False
        Me.DataGridViewReport1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewReport1.Size = New System.Drawing.Size(1129, 445)
        Me.DataGridViewReport1.TabIndex = 0
        '
        'TabReport2
        '
        Me.TabReport2.Controls.Add(Me.SplitContainer2)
        Me.TabReport2.Location = New System.Drawing.Point(4, 22)
        Me.TabReport2.Name = "TabReport2"
        Me.TabReport2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabReport2.Size = New System.Drawing.Size(1135, 483)
        Me.TabReport2.TabIndex = 2
        Me.TabReport2.Text = "Report2"
        Me.TabReport2.UseVisualStyleBackColor = True
        '
        'TabReport3
        '
        Me.TabReport3.Location = New System.Drawing.Point(4, 22)
        Me.TabReport3.Name = "TabReport3"
        Me.TabReport3.Size = New System.Drawing.Size(1135, 483)
        Me.TabReport3.TabIndex = 3
        Me.TabReport3.Text = "Report3"
        Me.TabReport3.UseVisualStyleBackColor = True
        '
        'TabSettings
        '
        Me.TabSettings.BackColor = System.Drawing.Color.Transparent
        Me.TabSettings.Controls.Add(Me.GroupBox1)
        Me.TabSettings.Location = New System.Drawing.Point(4, 22)
        Me.TabSettings.Name = "TabSettings"
        Me.TabSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.TabSettings.Size = New System.Drawing.Size(1135, 483)
        Me.TabSettings.TabIndex = 1
        Me.TabSettings.Text = "Settings"
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.BackColor = System.Drawing.Color.IndianRed
        Me.GroupBox1.Controls.Add(Me.LabelDBStatus)
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
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.MinimumSize = New System.Drawing.Size(535, 329)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1129, 477)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Database - HIC SUNT LEONES!"
        '
        'LabelDBStatus
        '
        Me.LabelDBStatus.AutoSize = True
        Me.LabelDBStatus.Location = New System.Drawing.Point(108, 148)
        Me.LabelDBStatus.Name = "LabelDBStatus"
        Me.LabelDBStatus.Size = New System.Drawing.Size(39, 13)
        Me.LabelDBStatus.TabIndex = 22
        Me.LabelDBStatus.Text = "Label4"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(111, 205)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Clear Saved Prefs"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(68, 148)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
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
        Me.CheckBox3.Size = New System.Drawing.Size(53, 17)
        Me.CheckBox3.TabIndex = 11
        Me.CheckBox3.Text = "Show"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(52, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Database"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Server Port"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Server Address"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Excel Sheet|*.xlsx"
        Me.SaveFileDialog1.Title = "Select file to export to"
        '
        'FbConnection1
        '
        Me.FbConnection1.ConnectionString = resources.GetString("FbConnection1.ConnectionString")
        '
        'DTReport1BindingSource
        '
        Me.DTReport1BindingSource.DataMember = "DTReport1"
        Me.DTReport1BindingSource.DataSource = Me.DataSet2
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DTReport1TA
        '
        Me.DTReport1TA.ClearBeforeFill = True
        '
        'PROJIDDataGridViewTextBoxColumn
        '
        Me.PROJIDDataGridViewTextBoxColumn.DataPropertyName = "PROJ_ID"
        Me.PROJIDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.PROJIDDataGridViewTextBoxColumn.Name = "PROJIDDataGridViewTextBoxColumn"
        Me.PROJIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PROJIDDataGridViewTextBoxColumn.Width = 43
        '
        'PROJFULLDataGridViewTextBoxColumn
        '
        Me.PROJFULLDataGridViewTextBoxColumn.DataPropertyName = "PROJ_FULL"
        Me.PROJFULLDataGridViewTextBoxColumn.HeaderText = "Project"
        Me.PROJFULLDataGridViewTextBoxColumn.Name = "PROJFULLDataGridViewTextBoxColumn"
        Me.PROJFULLDataGridViewTextBoxColumn.ReadOnly = True
        Me.PROJFULLDataGridViewTextBoxColumn.Width = 65
        '
        'CCONNAMEDataGridViewTextBoxColumn
        '
        Me.CCONNAMEDataGridViewTextBoxColumn.DataPropertyName = "CCON_NAME"
        Me.CCONNAMEDataGridViewTextBoxColumn.HeaderText = "Client Account"
        Me.CCONNAMEDataGridViewTextBoxColumn.Name = "CCONNAMEDataGridViewTextBoxColumn"
        Me.CCONNAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.CCONNAMEDataGridViewTextBoxColumn.Width = 101
        '
        'CJOBSDataGridViewTextBoxColumn
        '
        Me.CJOBSDataGridViewTextBoxColumn.DataPropertyName = "CJOBS"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.CJOBSDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.CJOBSDataGridViewTextBoxColumn.HeaderText = "Client Jobs"
        Me.CJOBSDataGridViewTextBoxColumn.Name = "CJOBSDataGridViewTextBoxColumn"
        Me.CJOBSDataGridViewTextBoxColumn.ReadOnly = True
        Me.CJOBSDataGridViewTextBoxColumn.Width = 83
        '
        'RJOBSDataGridViewTextBoxColumn
        '
        Me.RJOBSDataGridViewTextBoxColumn.DataPropertyName = "RJOBS"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.RJOBSDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.RJOBSDataGridViewTextBoxColumn.HeaderText = "Freelance Jobs"
        Me.RJOBSDataGridViewTextBoxColumn.Name = "RJOBSDataGridViewTextBoxColumn"
        Me.RJOBSDataGridViewTextBoxColumn.ReadOnly = True
        Me.RJOBSDataGridViewTextBoxColumn.Width = 96
        '
        'AITUSERREALNAMEDataGridViewTextBoxColumn
        '
        Me.AITUSERREALNAMEDataGridViewTextBoxColumn.DataPropertyName = "AIT$USER_REALNAME"
        Me.AITUSERREALNAMEDataGridViewTextBoxColumn.HeaderText = "Sale Owner"
        Me.AITUSERREALNAMEDataGridViewTextBoxColumn.Name = "AITUSERREALNAMEDataGridViewTextBoxColumn"
        Me.AITUSERREALNAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.AITUSERREALNAMEDataGridViewTextBoxColumn.Width = 80
        '
        'ProfitDataGridViewTextBoxColumn
        '
        Me.ProfitDataGridViewTextBoxColumn.DataPropertyName = "Profit"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.ProfitDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.ProfitDataGridViewTextBoxColumn.HeaderText = "Profit"
        Me.ProfitDataGridViewTextBoxColumn.Name = "ProfitDataGridViewTextBoxColumn"
        Me.ProfitDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProfitDataGridViewTextBoxColumn.Width = 56
        '
        'PCProfitDataGridViewTextBoxColumn
        '
        Me.PCProfitDataGridViewTextBoxColumn.DataPropertyName = "PCProfit"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "p2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.PCProfitDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.PCProfitDataGridViewTextBoxColumn.HeaderText = "%Profit"
        Me.PCProfitDataGridViewTextBoxColumn.Name = "PCProfitDataGridViewTextBoxColumn"
        Me.PCProfitDataGridViewTextBoxColumn.ReadOnly = True
        Me.PCProfitDataGridViewTextBoxColumn.Width = 64
        '
        'InvNoDataGridViewTextBoxColumn
        '
        Me.InvNoDataGridViewTextBoxColumn.DataPropertyName = "InvNo"
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.InvNoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.InvNoDataGridViewTextBoxColumn.HeaderText = "InvNo"
        Me.InvNoDataGridViewTextBoxColumn.Name = "InvNoDataGridViewTextBoxColumn"
        Me.InvNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.InvNoDataGridViewTextBoxColumn.Width = 61
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Button3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Button4)
        Me.SplitContainer2.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer2.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer2.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1129, 477)
        Me.SplitContainer2.SplitterDistance = 28
        Me.SplitContainer2.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(593, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Export"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(512, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Generate"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(279, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "To:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 15)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "From:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.DataGridView1.DataSource = Me.DTReport1BindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1129, 445)
        Me.DataGridView1.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PROJ_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 43
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PROJ_FULL"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Project"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 65
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CCON_NAME"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Client Account"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 101
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CJOBS"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn4.HeaderText = "Client Jobs"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 83
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "RJOBS"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn5.HeaderText = "Freelance Jobs"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 96
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "AIT$USER_REALNAME"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Sale Owner"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 80
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Profit"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn7.HeaderText = "Profit"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 56
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PCProfit"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "p2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn8.HeaderText = "%Profit"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 64
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "InvNo"
        DataGridViewCellStyle10.Format = "N0"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn9.HeaderText = "InvNo"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 61
        '
        'DateTimePickerFrom
        '
        Me.DateTimePickerFrom.Checked = False
        Me.DateTimePickerFrom.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.Financial_Reports.My.MySettings.Default, "R1DateFrom", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DateTimePickerFrom.Location = New System.Drawing.Point(49, 3)
        Me.DateTimePickerFrom.Name = "DateTimePickerFrom"
        Me.DateTimePickerFrom.Size = New System.Drawing.Size(200, 21)
        Me.DateTimePickerFrom.TabIndex = 6
        Me.DateTimePickerFrom.Value = Global.Financial_Reports.My.MySettings.Default.R1DateFrom
        '
        'DateTimePickerTo
        '
        Me.DateTimePickerTo.Checked = False
        Me.DateTimePickerTo.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.Financial_Reports.My.MySettings.Default, "R1DateTo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DateTimePickerTo.Location = New System.Drawing.Point(306, 3)
        Me.DateTimePickerTo.Name = "DateTimePickerTo"
        Me.DateTimePickerTo.Size = New System.Drawing.Size(200, 21)
        Me.DateTimePickerTo.TabIndex = 5
        Me.DateTimePickerTo.Value = Global.Financial_Reports.My.MySettings.Default.R1DateTo
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Checked = False
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.Financial_Reports.My.MySettings.Default, "R1DateFrom", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DateTimePicker1.Location = New System.Drawing.Point(49, 3)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 21)
        Me.DateTimePicker1.TabIndex = 6
        Me.DateTimePicker1.Value = Global.Financial_Reports.My.MySettings.Default.R1DateFrom
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Checked = False
        Me.DateTimePicker2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.Financial_Reports.My.MySettings.Default, "R1DateTo", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.DateTimePicker2.Location = New System.Drawing.Point(306, 3)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 21)
        Me.DateTimePicker2.TabIndex = 5
        Me.DateTimePicker2.Value = Global.Financial_Reports.My.MySettings.Default.R1DateTo
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Financial_Reports.My.MySettings.Default, "DBPassword", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxPassword.Location = New System.Drawing.Point(111, 112)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(350, 20)
        Me.TextBoxPassword.TabIndex = 9
        Me.TextBoxPassword.Text = Global.Financial_Reports.My.MySettings.Default.DBPassword
        Me.TextBoxPassword.UseSystemPasswordChar = True
        '
        'TextBoxDatabase
        '
        Me.TextBoxDatabase.AutoCompleteCustomSource.AddRange(New String() {"E:\Program Files (x86)\AIT\Projetex 9\Projetex Server\Database\projetex.fdb", "C:\Projetex9\Projetex Server\Database\projetex.fdb"})
        Me.TextBoxDatabase.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextBoxDatabase.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBoxDatabase.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Financial_Reports.My.MySettings.Default, "DBFile", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxDatabase.Location = New System.Drawing.Point(111, 82)
        Me.TextBoxDatabase.Name = "TextBoxDatabase"
        Me.TextBoxDatabase.Size = New System.Drawing.Size(350, 20)
        Me.TextBoxDatabase.TabIndex = 7
        Me.TextBoxDatabase.Text = Global.Financial_Reports.My.MySettings.Default.DBFile
        '
        'TextBoxServerPort
        '
        Me.TextBoxServerPort.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextBoxServerPort.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBoxServerPort.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Financial_Reports.My.MySettings.Default, "DBPort", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxServerPort.Location = New System.Drawing.Point(111, 52)
        Me.TextBoxServerPort.Name = "TextBoxServerPort"
        Me.TextBoxServerPort.Size = New System.Drawing.Size(350, 20)
        Me.TextBoxServerPort.TabIndex = 5
        Me.TextBoxServerPort.Text = Global.Financial_Reports.My.MySettings.Default.DBPort
        '
        'TextBoxServerAddress
        '
        Me.TextBoxServerAddress.AutoCompleteCustomSource.AddRange(New String() {"192.168.0.56", "192.168.56.101"})
        Me.TextBoxServerAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.TextBoxServerAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBoxServerAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Financial_Reports.My.MySettings.Default, "DBAddress", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxServerAddress.Location = New System.Drawing.Point(111, 22)
        Me.TextBoxServerAddress.Name = "TextBoxServerAddress"
        Me.TextBoxServerAddress.Size = New System.Drawing.Size(350, 20)
        Me.TextBoxServerAddress.TabIndex = 2
        Me.TextBoxServerAddress.Text = Global.Financial_Reports.My.MySettings.Default.DBAddress
        '
        'FormFinRep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 509)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormFinRep"
        Me.Text = "Financial Reports"
        Me.TabControl1.ResumeLayout(False)
        Me.TabReport1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridViewReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabReport2.ResumeLayout(False)
        Me.TabSettings.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DTReport1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabReport1 As System.Windows.Forms.TabPage
    Friend WithEvents TabReport2 As System.Windows.Forms.TabPage
    Friend WithEvents TabReport3 As System.Windows.Forms.TabPage
    Friend WithEvents TabSettings As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ButtonTestDBSettings As System.Windows.Forms.Button
    Friend WithEvents ButtonApplyDBSettings As System.Windows.Forms.Button
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDatabase As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxServerPort As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxServerAddress As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewReport1 As System.Windows.Forms.DataGridView
    Friend WithEvents DTReport1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet2 As Financial_Reports.DataSet2
    Friend WithEvents DTReport1TA As Financial_Reports.DataSet2TableAdapters.DTReport1TA
    Friend WithEvents ButtonR1Export As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents LabelDBStatus As System.Windows.Forms.Label
    Friend WithEvents FbConnection1 As FirebirdSql.Data.FirebirdClient.FbConnection
    Friend WithEvents PROJIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROJFULLDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCONNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CJOBSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RJOBSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AITUSERREALNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProfitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PCProfitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
