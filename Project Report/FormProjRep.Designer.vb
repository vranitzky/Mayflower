<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProjRep
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProjRep))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageProjects = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridViewReport1 = New System.Windows.Forms.DataGridView()
        Me.PROJIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIENTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIENTCONTACTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROJNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STARTEDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DELIVERYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DAYSLEFTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTESDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetPR = New Project_Report.DataSetPR()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonGO = New System.Windows.Forms.Button()
        Me.DateTimePickerTo = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerFrom = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxPM = New System.Windows.Forms.ComboBox()
        Me.AITUSERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabSettings = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LabelDBStatus = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.DataTable1TableAdapter = New Project_Report.DataSetPRTableAdapters.DataTable1TableAdapter()
        Me.AIT_USERSTableAdapter = New Project_Report.DataSetPRTableAdapters.AIT_USERSTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPageProjects.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.DataGridViewReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetPR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.AITUSERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSettings.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageProjects)
        Me.TabControl1.Controls.Add(Me.TabSettings)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1143, 509)
        Me.TabControl1.TabIndex = 1
        '
        'TabPageProjects
        '
        Me.TabPageProjects.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPageProjects.Location = New System.Drawing.Point(4, 22)
        Me.TabPageProjects.Name = "TabPageProjects"
        Me.TabPageProjects.Size = New System.Drawing.Size(1135, 483)
        Me.TabPageProjects.TabIndex = 2
        Me.TabPageProjects.Text = "Projects"
        Me.TabPageProjects.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.DataGridViewReport1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1135, 483)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'DataGridViewReport1
        '
        Me.DataGridViewReport1.AllowUserToAddRows = False
        Me.DataGridViewReport1.AllowUserToDeleteRows = False
        Me.DataGridViewReport1.AllowUserToOrderColumns = True
        Me.DataGridViewReport1.AutoGenerateColumns = False
        Me.DataGridViewReport1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewReport1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewReport1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewReport1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PROJIDDataGridViewTextBoxColumn, Me.CLIENTNAMEDataGridViewTextBoxColumn, Me.CLIENTCONTACTDataGridViewTextBoxColumn, Me.PMDataGridViewTextBoxColumn, Me.PROJNAMEDataGridViewTextBoxColumn, Me.STARTEDDataGridViewTextBoxColumn, Me.DELIVERYDataGridViewTextBoxColumn, Me.DAYSLEFTDataGridViewTextBoxColumn, Me.NOTESDataGridViewTextBoxColumn, Me.RES})
        Me.DataGridViewReport1.DataSource = Me.DataTable1BindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewReport1.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewReport1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewReport1.Location = New System.Drawing.Point(3, 33)
        Me.DataGridViewReport1.Name = "DataGridViewReport1"
        Me.DataGridViewReport1.ReadOnly = True
        Me.DataGridViewReport1.RowHeadersVisible = False
        Me.DataGridViewReport1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridViewReport1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridViewReport1.Size = New System.Drawing.Size(1129, 447)
        Me.DataGridViewReport1.TabIndex = 1
        '
        'PROJIDDataGridViewTextBoxColumn
        '
        Me.PROJIDDataGridViewTextBoxColumn.DataPropertyName = "PROJ_ID"
        Me.PROJIDDataGridViewTextBoxColumn.HeaderText = "PROJ_ID"
        Me.PROJIDDataGridViewTextBoxColumn.Name = "PROJIDDataGridViewTextBoxColumn"
        Me.PROJIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PROJIDDataGridViewTextBoxColumn.Visible = False
        '
        'CLIENTNAMEDataGridViewTextBoxColumn
        '
        Me.CLIENTNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CLIENTNAMEDataGridViewTextBoxColumn.DataPropertyName = "CLIENTNAME"
        Me.CLIENTNAMEDataGridViewTextBoxColumn.HeaderText = "Client Name"
        Me.CLIENTNAMEDataGridViewTextBoxColumn.Name = "CLIENTNAMEDataGridViewTextBoxColumn"
        Me.CLIENTNAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIENTNAMEDataGridViewTextBoxColumn.Width = 89
        '
        'CLIENTCONTACTDataGridViewTextBoxColumn
        '
        Me.CLIENTCONTACTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CLIENTCONTACTDataGridViewTextBoxColumn.DataPropertyName = "CLIENTCONTACT"
        Me.CLIENTCONTACTDataGridViewTextBoxColumn.HeaderText = "Client Contact"
        Me.CLIENTCONTACTDataGridViewTextBoxColumn.Name = "CLIENTCONTACTDataGridViewTextBoxColumn"
        Me.CLIENTCONTACTDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIENTCONTACTDataGridViewTextBoxColumn.Width = 98
        '
        'PMDataGridViewTextBoxColumn
        '
        Me.PMDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PMDataGridViewTextBoxColumn.DataPropertyName = "PM"
        Me.PMDataGridViewTextBoxColumn.HeaderText = "PM"
        Me.PMDataGridViewTextBoxColumn.Name = "PMDataGridViewTextBoxColumn"
        Me.PMDataGridViewTextBoxColumn.ReadOnly = True
        Me.PMDataGridViewTextBoxColumn.Width = 48
        '
        'PROJNAMEDataGridViewTextBoxColumn
        '
        Me.PROJNAMEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PROJNAMEDataGridViewTextBoxColumn.DataPropertyName = "PROJNAME"
        Me.PROJNAMEDataGridViewTextBoxColumn.HeaderText = "Project"
        Me.PROJNAMEDataGridViewTextBoxColumn.Name = "PROJNAMEDataGridViewTextBoxColumn"
        Me.PROJNAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.PROJNAMEDataGridViewTextBoxColumn.Width = 65
        '
        'STARTEDDataGridViewTextBoxColumn
        '
        Me.STARTEDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.STARTEDDataGridViewTextBoxColumn.DataPropertyName = "STARTED"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.STARTEDDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.STARTEDDataGridViewTextBoxColumn.HeaderText = "Started on"
        Me.STARTEDDataGridViewTextBoxColumn.Name = "STARTEDDataGridViewTextBoxColumn"
        Me.STARTEDDataGridViewTextBoxColumn.ReadOnly = True
        Me.STARTEDDataGridViewTextBoxColumn.Width = 81
        '
        'DELIVERYDataGridViewTextBoxColumn
        '
        Me.DELIVERYDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DELIVERYDataGridViewTextBoxColumn.DataPropertyName = "DELIVERY"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "d"
        Me.DELIVERYDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.DELIVERYDataGridViewTextBoxColumn.HeaderText = "Delivery"
        Me.DELIVERYDataGridViewTextBoxColumn.Name = "DELIVERYDataGridViewTextBoxColumn"
        Me.DELIVERYDataGridViewTextBoxColumn.ReadOnly = True
        Me.DELIVERYDataGridViewTextBoxColumn.Width = 70
        '
        'DAYSLEFTDataGridViewTextBoxColumn
        '
        Me.DAYSLEFTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DAYSLEFTDataGridViewTextBoxColumn.DataPropertyName = "DAYSLEFT"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "N0"
        Me.DAYSLEFTDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.DAYSLEFTDataGridViewTextBoxColumn.HeaderText = "Days Left"
        Me.DAYSLEFTDataGridViewTextBoxColumn.Name = "DAYSLEFTDataGridViewTextBoxColumn"
        Me.DAYSLEFTDataGridViewTextBoxColumn.ReadOnly = True
        Me.DAYSLEFTDataGridViewTextBoxColumn.Width = 77
        '
        'NOTESDataGridViewTextBoxColumn
        '
        Me.NOTESDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NOTESDataGridViewTextBoxColumn.DataPropertyName = "NOTES"
        Me.NOTESDataGridViewTextBoxColumn.HeaderText = "Notes"
        Me.NOTESDataGridViewTextBoxColumn.MinimumWidth = 250
        Me.NOTESDataGridViewTextBoxColumn.Name = "NOTESDataGridViewTextBoxColumn"
        Me.NOTESDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RES
        '
        Me.RES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RES.DataPropertyName = "RES"
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RES.DefaultCellStyle = DataGridViewCellStyle4
        Me.RES.HeaderText = "Resources"
        Me.RES.MinimumWidth = 250
        Me.RES.Name = "RES"
        Me.RES.ReadOnly = True
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.DataSetPR
        '
        'DataSetPR
        '
        Me.DataSetPR.DataSetName = "DataSetPR"
        Me.DataSetPR.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 7
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.ButtonGO, 6, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.DateTimePickerTo, 5, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.DateTimePickerFrom, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.ComboBoxPM, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label8, 4, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1129, 24)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'ButtonGO
        '
        Me.ButtonGO.AutoSize = True
        Me.ButtonGO.Location = New System.Drawing.Point(768, 0)
        Me.ButtonGO.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonGO.Name = "ButtonGO"
        Me.ButtonGO.Size = New System.Drawing.Size(75, 25)
        Me.ButtonGO.TabIndex = 16
        Me.ButtonGO.Text = "Generate"
        Me.ButtonGO.UseVisualStyleBackColor = True
        '
        'DateTimePickerTo
        '
        Me.DateTimePickerTo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePickerTo.Location = New System.Drawing.Point(515, 3)
        Me.DateTimePickerTo.Name = "DateTimePickerTo"
        Me.DateTimePickerTo.Size = New System.Drawing.Size(250, 20)
        Me.DateTimePickerTo.TabIndex = 15
        '
        'DateTimePickerFrom
        '
        Me.DateTimePickerFrom.Checked = False
        Me.DateTimePickerFrom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DateTimePickerFrom.Location = New System.Drawing.Point(230, 3)
        Me.DateTimePickerFrom.Name = "DateTimePickerFrom"
        Me.DateTimePickerFrom.Size = New System.Drawing.Size(250, 20)
        Me.DateTimePickerFrom.TabIndex = 14
        Me.DateTimePickerFrom.Value = New Date(2013, 1, 1, 0, 0, 0, 0)
        '
        'ComboBoxPM
        '
        Me.ComboBoxPM.DataSource = Me.AITUSERSBindingSource
        Me.ComboBoxPM.DisplayMember = "NAME"
        Me.ComboBoxPM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboBoxPM.FormattingEnabled = True
        Me.ComboBoxPM.Location = New System.Drawing.Point(35, 3)
        Me.ComboBoxPM.Name = "ComboBoxPM"
        Me.ComboBoxPM.Size = New System.Drawing.Size(150, 21)
        Me.ComboBoxPM.TabIndex = 13
        '
        'AITUSERSBindingSource
        '
        Me.AITUSERSBindingSource.DataMember = "AIT$USERS"
        Me.AITUSERSBindingSource.DataSource = Me.DataSetPR
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 27)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "PM:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(191, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 27)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "From:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(486, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 27)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "To:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.LabelDBStatus)
        Me.GroupBox1.Controls.Add(Me.Button1)
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
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(60, 147)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Status"
        '
        'LabelDBStatus
        '
        Me.LabelDBStatus.AutoSize = True
        Me.LabelDBStatus.Location = New System.Drawing.Point(108, 147)
        Me.LabelDBStatus.Name = "LabelDBStatus"
        Me.LabelDBStatus.Size = New System.Drawing.Size(16, 13)
        Me.LabelDBStatus.TabIndex = 22
        Me.LabelDBStatus.Text = "..."
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
        Me.TextBoxPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Project_Report.My.MySettings.Default, "DBPassword", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxPassword.Location = New System.Drawing.Point(111, 112)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(350, 20)
        Me.TextBoxPassword.TabIndex = 9
        Me.TextBoxPassword.Text = Global.Project_Report.My.MySettings.Default.DBPassword
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
        Me.TextBoxDatabase.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Project_Report.My.MySettings.Default, "DBFile", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxDatabase.Location = New System.Drawing.Point(111, 82)
        Me.TextBoxDatabase.Name = "TextBoxDatabase"
        Me.TextBoxDatabase.Size = New System.Drawing.Size(350, 20)
        Me.TextBoxDatabase.TabIndex = 7
        Me.TextBoxDatabase.Text = Global.Project_Report.My.MySettings.Default.DBFile
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
        Me.TextBoxServerPort.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Project_Report.My.MySettings.Default, "DBPort", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxServerPort.Location = New System.Drawing.Point(111, 52)
        Me.TextBoxServerPort.Name = "TextBoxServerPort"
        Me.TextBoxServerPort.Size = New System.Drawing.Size(350, 20)
        Me.TextBoxServerPort.TabIndex = 5
        Me.TextBoxServerPort.Text = Global.Project_Report.My.MySettings.Default.DBPort
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
        Me.TextBoxServerAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Project_Report.My.MySettings.Default, "DBAddress", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBoxServerAddress.Location = New System.Drawing.Point(111, 22)
        Me.TextBoxServerAddress.Name = "TextBoxServerAddress"
        Me.TextBoxServerAddress.Size = New System.Drawing.Size(350, 20)
        Me.TextBoxServerAddress.TabIndex = 2
        Me.TextBoxServerAddress.Text = Global.Project_Report.My.MySettings.Default.DBAddress
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
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'AIT_USERSTableAdapter
        '
        Me.AIT_USERSTableAdapter.ClearBeforeFill = True
        '
        'FormProjRep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 509)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormProjRep"
        Me.Text = "Project Report"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageProjects.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.DataGridViewReport1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetPR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.AITUSERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSettings.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabSettings As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
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
    Friend WithEvents DataSetPR As Project_Report.DataSetPR
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FbConnection1 As FirebirdSql.Data.FirebirdClient.FbConnection
    Friend WithEvents DataColumn1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataColumn2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataColumn3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataColumn4DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataColumn5DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataColumn6DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataColumn7DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataColumn8DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SALEOWNERDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONTACTNAMEDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents INVOICEDATEDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents INVOICENUMBERDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PARTYNAMEDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CURRENCYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTALAMOUNTDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PAIDSOFARDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DUEDATEDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LASTPAYMENTDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LabelDBStatus As System.Windows.Forms.Label
    Friend WithEvents DataTable1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable1TableAdapter As Project_Report.DataSetPRTableAdapters.DataTable1TableAdapter
    Friend WithEvents AITUSERSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AIT_USERSTableAdapter As Project_Report.DataSetPRTableAdapters.AIT_USERSTableAdapter
    Friend WithEvents TabPageProjects As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ButtonGO As System.Windows.Forms.Button
    Friend WithEvents DateTimePickerTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBoxPM As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewReport1 As System.Windows.Forms.DataGridView
    Friend WithEvents PROJIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIENTNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIENTCONTACTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROJNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STARTEDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DELIVERYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DAYSLEFTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOTESDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RES As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
