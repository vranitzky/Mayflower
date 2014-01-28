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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFinRep))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabReport1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ButtonR1Export = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DateTimePickerFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePickerTo = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewReport1 = New System.Windows.Forms.DataGridView()
        Me.PROJIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROJFULLDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCONNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CJOBSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RJOBSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AITUSERREALNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProfitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCProfitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTReport1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetFR = New Financial_Reports.DataSetFR()
        Me.TabReport2 = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.DateTimePickerR2 = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridViewReport2 = New System.Windows.Forms.DataGridView()
        Me.SALEOWNERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONTACTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INVOICEDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INVOICENUMBERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PARTYNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALAMOUNTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PENDINGAMOUNTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACTUALLYPAIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DUEDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OVERDUEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTReport2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxDatabase = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxServerPort = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxServerAddress = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FbConnection1 = New FirebirdSql.Data.FirebirdClient.FbConnection()
        Me.DTReport1TA = New Financial_Reports.DataSetFRTableAdapters.DTReport1TA()
        Me.DTReport2TA = New Financial_Reports.DataSetFRTableAdapters.DTReport2TA()
        Me.TabControl1.SuspendLayout()
        Me.TabReport1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridViewReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTReport1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetFR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabReport2.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.DataGridViewReport2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTReport2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSettings.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.DataGridViewReport1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewReport1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewReport1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PROJIDDataGridViewTextBoxColumn, Me.PROJFULLDataGridViewTextBoxColumn, Me.CCONNAMEDataGridViewTextBoxColumn, Me.CJOBSDataGridViewTextBoxColumn, Me.RJOBSDataGridViewTextBoxColumn, Me.AITUSERREALNAMEDataGridViewTextBoxColumn, Me.ProfitDataGridViewTextBoxColumn, Me.PCProfitDataGridViewTextBoxColumn, Me.InvNoDataGridViewTextBoxColumn})
        Me.DataGridViewReport1.DataSource = Me.DTReport1BindingSource
        Me.DataGridViewReport1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewReport1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewReport1.Name = "DataGridViewReport1"
        Me.DataGridViewReport1.ReadOnly = True
        Me.DataGridViewReport1.RowHeadersVisible = False
        Me.DataGridViewReport1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridViewReport1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewReport1.Size = New System.Drawing.Size(1129, 445)
        Me.DataGridViewReport1.TabIndex = 0
        '
        'PROJIDDataGridViewTextBoxColumn
        '
        Me.PROJIDDataGridViewTextBoxColumn.DataPropertyName = "PROJ_ID"
        Me.PROJIDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.PROJIDDataGridViewTextBoxColumn.Name = "PROJIDDataGridViewTextBoxColumn"
        Me.PROJIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PROJFULLDataGridViewTextBoxColumn
        '
        Me.PROJFULLDataGridViewTextBoxColumn.DataPropertyName = "PROJ_FULL"
        Me.PROJFULLDataGridViewTextBoxColumn.HeaderText = "Project"
        Me.PROJFULLDataGridViewTextBoxColumn.Name = "PROJFULLDataGridViewTextBoxColumn"
        Me.PROJFULLDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CCONNAMEDataGridViewTextBoxColumn
        '
        Me.CCONNAMEDataGridViewTextBoxColumn.DataPropertyName = "CCON_NAME"
        Me.CCONNAMEDataGridViewTextBoxColumn.HeaderText = "Client Account"
        Me.CCONNAMEDataGridViewTextBoxColumn.Name = "CCONNAMEDataGridViewTextBoxColumn"
        Me.CCONNAMEDataGridViewTextBoxColumn.ReadOnly = True
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
        '
        'AITUSERREALNAMEDataGridViewTextBoxColumn
        '
        Me.AITUSERREALNAMEDataGridViewTextBoxColumn.DataPropertyName = "AIT$USER_REALNAME"
        Me.AITUSERREALNAMEDataGridViewTextBoxColumn.HeaderText = "Sale Owner"
        Me.AITUSERREALNAMEDataGridViewTextBoxColumn.Name = "AITUSERREALNAMEDataGridViewTextBoxColumn"
        Me.AITUSERREALNAMEDataGridViewTextBoxColumn.ReadOnly = True
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
        '
        'DTReport1BindingSource
        '
        Me.DTReport1BindingSource.DataMember = "DTReport1"
        Me.DTReport1BindingSource.DataSource = Me.DataSetFR
        '
        'DataSetFR
        '
        Me.DataSetFR.DataSetName = "DataSetFR"
        Me.DataSetFR.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabReport2
        '
        Me.TabReport2.Controls.Add(Me.SplitContainer2)
        Me.TabReport2.Location = New System.Drawing.Point(4, 22)
        Me.TabReport2.Name = "TabReport2"
        Me.TabReport2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabReport2.Size = New System.Drawing.Size(1135, 483)
        Me.TabReport2.TabIndex = 2
        Me.TabReport2.Text = "Payment Tracker"
        Me.TabReport2.UseVisualStyleBackColor = True
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.DateTimePickerR2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Button3)
        Me.SplitContainer2.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.DataGridViewReport2)
        Me.SplitContainer2.Size = New System.Drawing.Size(1129, 477)
        Me.SplitContainer2.SplitterDistance = 25
        Me.SplitContainer2.TabIndex = 1
        '
        'DateTimePickerR2
        '
        Me.DateTimePickerR2.Location = New System.Drawing.Point(0, 2)
        Me.DateTimePickerR2.Name = "DateTimePickerR2"
        Me.DateTimePickerR2.Size = New System.Drawing.Size(145, 21)
        Me.DateTimePickerR2.TabIndex = 10
        Me.DateTimePickerR2.Value = New Date(2014, 1, 20, 0, 0, 0, 0)
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(148, 0)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 25)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Export"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridViewReport2
        '
        Me.DataGridViewReport2.AllowUserToAddRows = False
        Me.DataGridViewReport2.AllowUserToDeleteRows = False
        Me.DataGridViewReport2.AllowUserToOrderColumns = True
        Me.DataGridViewReport2.AutoGenerateColumns = False
        Me.DataGridViewReport2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewReport2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewReport2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SALEOWNERDataGridViewTextBoxColumn, Me.CONTACTNAMEDataGridViewTextBoxColumn, Me.INVOICEDATEDataGridViewTextBoxColumn, Me.INVOICENUMBERDataGridViewTextBoxColumn, Me.PARTYNAMEDataGridViewTextBoxColumn, Me.TOTALAMOUNTDataGridViewTextBoxColumn, Me.PENDINGAMOUNTDataGridViewTextBoxColumn, Me.ACTUALLYPAIDDataGridViewTextBoxColumn, Me.DUEDATEDataGridViewTextBoxColumn, Me.OVERDUEDataGridViewTextBoxColumn})
        Me.DataGridViewReport2.DataSource = Me.DTReport2BindingSource
        Me.DataGridViewReport2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewReport2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewReport2.Name = "DataGridViewReport2"
        Me.DataGridViewReport2.ReadOnly = True
        Me.DataGridViewReport2.RowHeadersVisible = False
        Me.DataGridViewReport2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridViewReport2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewReport2.Size = New System.Drawing.Size(1129, 448)
        Me.DataGridViewReport2.TabIndex = 0
        '
        'SALEOWNERDataGridViewTextBoxColumn
        '
        Me.SALEOWNERDataGridViewTextBoxColumn.DataPropertyName = "SALEOWNER"
        Me.SALEOWNERDataGridViewTextBoxColumn.HeaderText = "SALEOWNER"
        Me.SALEOWNERDataGridViewTextBoxColumn.Name = "SALEOWNERDataGridViewTextBoxColumn"
        Me.SALEOWNERDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CONTACTNAMEDataGridViewTextBoxColumn
        '
        Me.CONTACTNAMEDataGridViewTextBoxColumn.DataPropertyName = "CONTACTNAME"
        Me.CONTACTNAMEDataGridViewTextBoxColumn.HeaderText = "CONTACTNAME"
        Me.CONTACTNAMEDataGridViewTextBoxColumn.Name = "CONTACTNAMEDataGridViewTextBoxColumn"
        Me.CONTACTNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'INVOICEDATEDataGridViewTextBoxColumn
        '
        Me.INVOICEDATEDataGridViewTextBoxColumn.DataPropertyName = "INVOICEDATE"
        DataGridViewCellStyle6.Format = "d"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.INVOICEDATEDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.INVOICEDATEDataGridViewTextBoxColumn.HeaderText = "INVOICEDATE"
        Me.INVOICEDATEDataGridViewTextBoxColumn.Name = "INVOICEDATEDataGridViewTextBoxColumn"
        Me.INVOICEDATEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'INVOICENUMBERDataGridViewTextBoxColumn
        '
        Me.INVOICENUMBERDataGridViewTextBoxColumn.DataPropertyName = "INVOICENUMBER"
        Me.INVOICENUMBERDataGridViewTextBoxColumn.HeaderText = "INVOICENUMBER"
        Me.INVOICENUMBERDataGridViewTextBoxColumn.Name = "INVOICENUMBERDataGridViewTextBoxColumn"
        Me.INVOICENUMBERDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PARTYNAMEDataGridViewTextBoxColumn
        '
        Me.PARTYNAMEDataGridViewTextBoxColumn.DataPropertyName = "PARTYNAME"
        Me.PARTYNAMEDataGridViewTextBoxColumn.HeaderText = "PARTYNAME"
        Me.PARTYNAMEDataGridViewTextBoxColumn.Name = "PARTYNAMEDataGridViewTextBoxColumn"
        Me.PARTYNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TOTALAMOUNTDataGridViewTextBoxColumn
        '
        Me.TOTALAMOUNTDataGridViewTextBoxColumn.DataPropertyName = "TOTALAMOUNT"
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.TOTALAMOUNTDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.TOTALAMOUNTDataGridViewTextBoxColumn.HeaderText = "TOTALAMOUNT"
        Me.TOTALAMOUNTDataGridViewTextBoxColumn.Name = "TOTALAMOUNTDataGridViewTextBoxColumn"
        Me.TOTALAMOUNTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PENDINGAMOUNTDataGridViewTextBoxColumn
        '
        Me.PENDINGAMOUNTDataGridViewTextBoxColumn.DataPropertyName = "PENDINGAMOUNT"
        DataGridViewCellStyle8.Format = "C2"
        Me.PENDINGAMOUNTDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.PENDINGAMOUNTDataGridViewTextBoxColumn.HeaderText = "PENDINGAMOUNT"
        Me.PENDINGAMOUNTDataGridViewTextBoxColumn.Name = "PENDINGAMOUNTDataGridViewTextBoxColumn"
        Me.PENDINGAMOUNTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ACTUALLYPAIDDataGridViewTextBoxColumn
        '
        Me.ACTUALLYPAIDDataGridViewTextBoxColumn.DataPropertyName = "ACTUALLYPAID"
        DataGridViewCellStyle9.Format = "C2"
        Me.ACTUALLYPAIDDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.ACTUALLYPAIDDataGridViewTextBoxColumn.HeaderText = "ACTUALLYPAID"
        Me.ACTUALLYPAIDDataGridViewTextBoxColumn.Name = "ACTUALLYPAIDDataGridViewTextBoxColumn"
        Me.ACTUALLYPAIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DUEDATEDataGridViewTextBoxColumn
        '
        Me.DUEDATEDataGridViewTextBoxColumn.DataPropertyName = "DUEDATE"
        DataGridViewCellStyle10.Format = "d"
        Me.DUEDATEDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.DUEDATEDataGridViewTextBoxColumn.HeaderText = "DUEDATE"
        Me.DUEDATEDataGridViewTextBoxColumn.Name = "DUEDATEDataGridViewTextBoxColumn"
        Me.DUEDATEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OVERDUEDataGridViewTextBoxColumn
        '
        Me.OVERDUEDataGridViewTextBoxColumn.DataPropertyName = "OVERDUE"
        DataGridViewCellStyle11.Format = "N0"
        Me.OVERDUEDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle11
        Me.OVERDUEDataGridViewTextBoxColumn.HeaderText = "OVERDUE"
        Me.OVERDUEDataGridViewTextBoxColumn.Name = "OVERDUEDataGridViewTextBoxColumn"
        Me.OVERDUEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DTReport2BindingSource
        '
        Me.DTReport2BindingSource.DataMember = "DTReport2"
        Me.DTReport2BindingSource.DataSource = Me.DataSetFR
        '
        'TabReport3
        '
        Me.TabReport3.Location = New System.Drawing.Point(4, 22)
        Me.TabReport3.Name = "TabReport3"
        Me.TabReport3.Size = New System.Drawing.Size(1135, 483)
        Me.TabReport3.TabIndex = 3
        Me.TabReport3.Text = "Incentive Calc"
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Database"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Server Port"
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Server Address"
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
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Excel Sheet|*.xlsx"
        Me.SaveFileDialog1.Title = "Select file to export to"
        '
        'FbConnection1
        '
        Me.FbConnection1.ConnectionString = resources.GetString("FbConnection1.ConnectionString")
        '
        'DTReport1TA
        '
        Me.DTReport1TA.ClearBeforeFill = True
        '
        'DTReport2TA
        '
        Me.DTReport2TA.ClearBeforeFill = True
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
        CType(Me.DTReport1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetFR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabReport2.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.DataGridViewReport2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTReport2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSettings.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents DataSetFR As Financial_Reports.DataSetFR
    Friend WithEvents DTReport1TA As Financial_Reports.DataSetFRTableAdapters.DTReport1TA
    Friend WithEvents ButtonR1Export As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents LabelDBStatus As System.Windows.Forms.Label
    Friend WithEvents FbConnection1 As FirebirdSql.Data.FirebirdClient.FbConnection
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewReport2 As System.Windows.Forms.DataGridView
    Friend WithEvents DTReport2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DTReport2TA As Financial_Reports.DataSetFRTableAdapters.DTReport2TA
    Friend WithEvents DataColumn1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataColumn2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataColumn3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataColumn4DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataColumn5DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataColumn6DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataColumn7DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataColumn8DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROJIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROJFULLDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCONNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CJOBSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RJOBSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AITUSERREALNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProfitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PCProfitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateTimePickerR2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents SALEOWNERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONTACTNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents INVOICEDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents INVOICENUMBERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PARTYNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALAMOUNTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PENDINGAMOUNTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ACTUALLYPAIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DUEDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OVERDUEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
