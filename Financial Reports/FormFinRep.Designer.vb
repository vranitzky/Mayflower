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
        Me.DateTimePickerFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePickerTo = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewReport1 = New System.Windows.Forms.DataGridView()
        Me.TabReport2 = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
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
        Me.DataSet2 = New Financial_Reports.DataSet2()
        Me.DTReport1TA = New Financial_Reports.DataSet2TableAdapters.DTReport1TA()
        Me.DTReport2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DTReport2TA = New Financial_Reports.DataSet2TableAdapters.DTReport2TA()
        Me.DataColumn1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataColumn2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataColumn3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataColumn4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataColumn5DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataColumn6DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataColumn7DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataColumn8DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabReport1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridViewReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabReport2.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSettings.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DTReport1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTReport2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridViewReport1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataColumn1DataGridViewTextBoxColumn, Me.DataColumn2DataGridViewTextBoxColumn, Me.DataColumn3DataGridViewTextBoxColumn, Me.DataColumn4DataGridViewTextBoxColumn, Me.DataColumn5DataGridViewTextBoxColumn, Me.DataColumn6DataGridViewTextBoxColumn, Me.DataColumn7DataGridViewTextBoxColumn, Me.DataColumn8DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DTReport2BindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1129, 445)
        Me.DataGridView1.TabIndex = 0
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
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.CJOBSDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.CJOBSDataGridViewTextBoxColumn.HeaderText = "Client Jobs"
        Me.CJOBSDataGridViewTextBoxColumn.Name = "CJOBSDataGridViewTextBoxColumn"
        Me.CJOBSDataGridViewTextBoxColumn.ReadOnly = True
        Me.CJOBSDataGridViewTextBoxColumn.Width = 83
        '
        'RJOBSDataGridViewTextBoxColumn
        '
        Me.RJOBSDataGridViewTextBoxColumn.DataPropertyName = "RJOBS"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.RJOBSDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
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
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.ProfitDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.ProfitDataGridViewTextBoxColumn.HeaderText = "Profit"
        Me.ProfitDataGridViewTextBoxColumn.Name = "ProfitDataGridViewTextBoxColumn"
        Me.ProfitDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProfitDataGridViewTextBoxColumn.Width = 56
        '
        'PCProfitDataGridViewTextBoxColumn
        '
        Me.PCProfitDataGridViewTextBoxColumn.DataPropertyName = "PCProfit"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "p2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.PCProfitDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.PCProfitDataGridViewTextBoxColumn.HeaderText = "%Profit"
        Me.PCProfitDataGridViewTextBoxColumn.Name = "PCProfitDataGridViewTextBoxColumn"
        Me.PCProfitDataGridViewTextBoxColumn.ReadOnly = True
        Me.PCProfitDataGridViewTextBoxColumn.Width = 64
        '
        'InvNoDataGridViewTextBoxColumn
        '
        Me.InvNoDataGridViewTextBoxColumn.DataPropertyName = "InvNo"
        DataGridViewCellStyle10.Format = "N0"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.InvNoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle10
        Me.InvNoDataGridViewTextBoxColumn.HeaderText = "InvNo"
        Me.InvNoDataGridViewTextBoxColumn.Name = "InvNoDataGridViewTextBoxColumn"
        Me.InvNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.InvNoDataGridViewTextBoxColumn.Width = 61
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
        'DTReport2BindingSource
        '
        Me.DTReport2BindingSource.DataMember = "DTReport2"
        Me.DTReport2BindingSource.DataSource = Me.DataSet2
        '
        'DTReport2TA
        '
        Me.DTReport2TA.ClearBeforeFill = True
        '
        'DataColumn1DataGridViewTextBoxColumn
        '
        Me.DataColumn1DataGridViewTextBoxColumn.DataPropertyName = "DataColumn1"
        Me.DataColumn1DataGridViewTextBoxColumn.HeaderText = "DataColumn1"
        Me.DataColumn1DataGridViewTextBoxColumn.Name = "DataColumn1DataGridViewTextBoxColumn"
        Me.DataColumn1DataGridViewTextBoxColumn.ReadOnly = True
        Me.DataColumn1DataGridViewTextBoxColumn.Width = 96
        '
        'DataColumn2DataGridViewTextBoxColumn
        '
        Me.DataColumn2DataGridViewTextBoxColumn.DataPropertyName = "DataColumn2"
        Me.DataColumn2DataGridViewTextBoxColumn.HeaderText = "DataColumn2"
        Me.DataColumn2DataGridViewTextBoxColumn.Name = "DataColumn2DataGridViewTextBoxColumn"
        Me.DataColumn2DataGridViewTextBoxColumn.ReadOnly = True
        Me.DataColumn2DataGridViewTextBoxColumn.Width = 96
        '
        'DataColumn3DataGridViewTextBoxColumn
        '
        Me.DataColumn3DataGridViewTextBoxColumn.DataPropertyName = "DataColumn3"
        Me.DataColumn3DataGridViewTextBoxColumn.HeaderText = "DataColumn3"
        Me.DataColumn3DataGridViewTextBoxColumn.Name = "DataColumn3DataGridViewTextBoxColumn"
        Me.DataColumn3DataGridViewTextBoxColumn.ReadOnly = True
        Me.DataColumn3DataGridViewTextBoxColumn.Width = 96
        '
        'DataColumn4DataGridViewTextBoxColumn
        '
        Me.DataColumn4DataGridViewTextBoxColumn.DataPropertyName = "DataColumn4"
        Me.DataColumn4DataGridViewTextBoxColumn.HeaderText = "DataColumn4"
        Me.DataColumn4DataGridViewTextBoxColumn.Name = "DataColumn4DataGridViewTextBoxColumn"
        Me.DataColumn4DataGridViewTextBoxColumn.ReadOnly = True
        Me.DataColumn4DataGridViewTextBoxColumn.Width = 96
        '
        'DataColumn5DataGridViewTextBoxColumn
        '
        Me.DataColumn5DataGridViewTextBoxColumn.DataPropertyName = "DataColumn5"
        Me.DataColumn5DataGridViewTextBoxColumn.HeaderText = "DataColumn5"
        Me.DataColumn5DataGridViewTextBoxColumn.Name = "DataColumn5DataGridViewTextBoxColumn"
        Me.DataColumn5DataGridViewTextBoxColumn.ReadOnly = True
        Me.DataColumn5DataGridViewTextBoxColumn.Width = 96
        '
        'DataColumn6DataGridViewTextBoxColumn
        '
        Me.DataColumn6DataGridViewTextBoxColumn.DataPropertyName = "DataColumn6"
        Me.DataColumn6DataGridViewTextBoxColumn.HeaderText = "DataColumn6"
        Me.DataColumn6DataGridViewTextBoxColumn.Name = "DataColumn6DataGridViewTextBoxColumn"
        Me.DataColumn6DataGridViewTextBoxColumn.ReadOnly = True
        Me.DataColumn6DataGridViewTextBoxColumn.Width = 96
        '
        'DataColumn7DataGridViewTextBoxColumn
        '
        Me.DataColumn7DataGridViewTextBoxColumn.DataPropertyName = "DataColumn7"
        Me.DataColumn7DataGridViewTextBoxColumn.HeaderText = "DataColumn7"
        Me.DataColumn7DataGridViewTextBoxColumn.Name = "DataColumn7DataGridViewTextBoxColumn"
        Me.DataColumn7DataGridViewTextBoxColumn.ReadOnly = True
        Me.DataColumn7DataGridViewTextBoxColumn.Width = 96
        '
        'DataColumn8DataGridViewTextBoxColumn
        '
        Me.DataColumn8DataGridViewTextBoxColumn.DataPropertyName = "DataColumn8"
        Me.DataColumn8DataGridViewTextBoxColumn.HeaderText = "DataColumn8"
        Me.DataColumn8DataGridViewTextBoxColumn.Name = "DataColumn8DataGridViewTextBoxColumn"
        Me.DataColumn8DataGridViewTextBoxColumn.ReadOnly = True
        Me.DataColumn8DataGridViewTextBoxColumn.Width = 96
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
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSettings.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DTReport1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTReport2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PROJIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROJFULLDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCONNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CJOBSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RJOBSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AITUSERREALNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProfitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PCProfitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DTReport2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DTReport2TA As Financial_Reports.DataSet2TableAdapters.DTReport2TA
    Friend WithEvents DataColumn1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataColumn2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataColumn3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataColumn4DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataColumn5DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataColumn6DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataColumn7DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataColumn8DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
