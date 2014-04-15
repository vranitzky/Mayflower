Imports System
Imports System.IO
Imports System.Text
Imports FirebirdSql
Imports System.Configuration
Imports System.Globalization

'!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
'!!!! remember to UPDATE updateTableAdapters EVERY TIME you add a TableAdapter !!!!!
'!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

Public Class FormJobsRep
    Private Loaded As Boolean = False
    Private defaultCulture As CultureInfo = Application.CurrentCulture

    '!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    '!!!! remember to UPDATE updateTableAdapters EVERY TIME you add a TableAdapter !!!!!
    '!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    Private Sub updateTableAdapters(connstr As String)
        'DTReport1TA.Connection.ConnectionString = connstr
        'DTReport2TA.Connection.ConnectionString = connstr
        'DTReport3TA.Connection.ConnectionString = connstr
        'DTReportIncentiveTA.Connection.ConnectionString = connstr
        DataTableProjectsTableAdapter.Connection.ConnectionString = connstr
        DataTableClJobsTableAdapter.Connection.ConnectionString = connstr
        DataTableCoJobsTableAdapter.Connection.ConnectionString = connstr
        DataTableFrJobsTableAdapter.Connection.ConnectionString = connstr
        DataTableProfitTableAdapter.Connection.ConnectionString = connstr

    End Sub
 
    Public Sub New()
        ' This call is required by the designer.
        Try
            InitializeComponent()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub FormFinRep_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            updateTableAdapters(My.Settings.ProjetexDB)
            'TODO: This line of code loads data into the 'DataSetJr1.DataTableProjects' table. You can move, or remove it, as needed.
            Me.DataTableProjectsTableAdapter.Fill(Me.DataSetJr.DataTableProjects)
            Me.Loaded = True
            'Label1.DataBindings.Add("Text", BindingSourceProfit, "CLIENTJOBS")
        Catch ppp As System.Data.ConstraintException
            'do nothing!
        Catch ex As Exception
            MessageBox.Show("There was an error!" & Environment.NewLine & Environment.NewLine &
                            """" & ex.Message & """" & Environment.NewLine & Environment.NewLine &
                            "Please set up Database parameters in the next window.",
                            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
                            )
            TabControl1.SelectedTab = TabSettings

        End Try
    End Sub
    Private Sub ButtonGO_Click(sender As Object, e As EventArgs) Handles ButtonGO.Click
        Me.Cursor = Cursors.WaitCursor
        Dim row As System.Data.DataRowView = ComboBoxProject.SelectedItem
        Try
            'Me.DataTable1TableAdapter.FillByPM(Me.DataSetJr.DataTable1, row.Item("ID"), DateTimePickerFrom.Value, DateTimePickerTo.Value)

            Me.DataTableClJobsTableAdapter.Fill(Me.DataSetJr.DataTableClJobs, Integer.Parse(ComboBoxProject.SelectedValue.ToString))
            'DataGridViewReport1.AutoSize = False
            Me.DataTableCoJobsTableAdapter.Fill(Me.DataSetJr.DataTableCoJobs, Integer.Parse(ComboBoxProject.SelectedValue.ToString))
            Me.DataTableFrJobsTableAdapter.Fill(Me.DataSetJr.DataTableFrJobs, Integer.Parse(ComboBoxProject.SelectedValue.ToString))
            Me.DataTableProfitTableAdapter.Fill(Me.DataSetJr.DataTableProfit, Integer.Parse(ComboBoxProject.SelectedValue.ToString))

            'LabelProfit.DataBindings.Add()
            'LabelProfit.Text = Me.DataSetJr.DataTableProfit.Rows(0).Field(Of Double)("CLIENTJOBS").ToString
            '// autosize all columns according to their content
            'DataGridViewReport1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
            '// make column 1 (or whatever) fill the empty space
            'DataGridViewReport1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            '// remove column 1 autosizing to prevent 'jumping' behaviour
            'DataGridViewReport1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            '// let the last column fill the empty space when the grid or any column is resized (more natural/expected behaviour) 
            'DataGridViewReport1.Columns.GetLastColumn(DataGridViewElementStates.None, DataGridViewElementStates.None).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Cursor = Me.DefaultCursor

    End Sub

    Private Sub ButtonR1Export_Click(sender As Object, e As EventArgs)
        ' exportToXLSX(DataGridViewReport1, "Profit Report " + DateTimePickerFrom.Value.ToShortDateString.Replace("/", "-") +
        '                                "-" + DateTimePickerTo.Value.ToShortDateString.Replace("/", "-"))
    End Sub

    
    Private Sub ButtonTestDBSettings_Click(sender As Object, e As EventArgs) Handles ButtonTestDBSettings.Click
        Dim connstr, text As String
        'Dim conn As New 
        Dim OK As Boolean = True
        'Dim FbConnection1 As

        LabelDBStatus.Text = "Testing..."
        'StatusLed.BackColor = Color.Gold
        text = ButtonTestDBSettings.Text
        ButtonTestDBSettings.Text = "Testing..."
        ButtonTestDBSettings.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        'TimerLed.Enabled = True
        'TimerLed.Start()

        connstr = "User=ODBC;" +
            "Password=" + TextBoxPassword.Text + ";" +
            "Database=" + TextBoxDatabase.Text + ";" +
            "DataSource=" + TextBoxServerAddress.Text + ";" +
            "Port=" + TextBoxServerPort.Text + ";" +
            "Dialect=3;" +
            "Charset=UTF8;" +
            "Role=PROJETEX_ODBC;" +
            "Connection lifetime=15;" +
            "Pooling=true;" +
            "MinPoolSize=0;" +
            "MaxPoolSize=50;" +
            "Packet Size=8192;" +
            "ServerType=0"
        FbConnection1.ConnectionString = connstr
        'RichTextBoxConnectionString.Text = connstr

        Try
            FbConnection1.Open()
        Catch ex As Exception
            MessageBox.Show("Failed to connect to data source: " & ex.Message)
            OK = False
        Finally
            FbConnection1.Close()
            ButtonTestDBSettings.Enabled = True
            ButtonTestDBSettings.Text = text
            'TimerLed.Stop()
            'TimerLed.Enabled = False
            Me.Cursor = Me.DefaultCursor
        End Try
        If (OK) Then
            ButtonApplyDBSettings.Enabled = True
            LabelDBStatus.Text = "Connected"
            'StatusLed.BackColor = Color.Green
            'MessageBox.Show("Succesfully connected")
        Else
            LabelDBStatus.Text = "NOT Connected!"
            'StatusLed.BackColor = Color.Red
        End If

    End Sub

    Private Sub ButtonApplyDBSettings_Click(sender As Object, e As EventArgs) Handles ButtonApplyDBSettings.Click
        applyDBSettings()
    End Sub

    Public Sub updateConfigConnection(conn As String)
        Dim XmlDoc As Xml.XmlDocument = New Xml.XmlDocument()
        Dim att As Xml.XmlAttributeCollection
        Dim n1, n2, n3 As Xml.XmlNode

        XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile)
        For Each XElement As Xml.XmlElement In XmlDoc.DocumentElement
            If XElement.Name = "connectionStrings" Then
                att = XElement.FirstChild.Attributes
                'nodes = att.GetNamedItem
                n1 = att.Item(0)
                n2 = att.Item(1)
                n3 = att.Item(2)
                XElement.FirstChild.Attributes.Item(1).Value = conn
                n1 = att.Item(0)
                n2 = att.Item(1)
                n3 = att.Item(2)

            End If
        Next
        Try
            'XmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile)
        Catch ex As Exception
            MsgBox("xmldoc.save: " + ex.Message)
        End Try

        ' Get the roaming configuration 
        ' that applies to the current user.
        Dim roamingConfig As Configuration = _
        ConfigurationManager.OpenExeConfiguration( _
            ConfigurationUserLevel.PerUserRoaming)

        ' Map the roaming configuration file. This
        ' enables the application to access 
        ' the configuration file using the
        ' System.Configuration.Configuration class
        Dim configFileMap As New ExeConfigurationFileMap()
        configFileMap.ExeConfigFilename = _
            roamingConfig.FilePath

        ' Get the mapped configuration file.
        Dim config As Configuration = _
            ConfigurationManager.OpenMappedExeConfiguration( _
                configFileMap, ConfigurationUserLevel.None)

        ' Synchronize the application configuration
        ' if needed. The following two steps seem
        ' to solve some out of synch issues 
        ' between roaming and default
        ' configuration.
        Try
            config.Save(ConfigurationSaveMode.Modified)
        Catch ex As Exception
            MsgBox("config.save: " + ex.Message)
        End Try

        ' Force a reload of the changed section, 
        ' if needed. This makes the new values available 
        ' for reading.
        ConfigurationManager.RefreshSection("connectionStrings")

        Try
            My.Settings("ProjetexDB2") = conn
            My.Settings.Save()
            'My.Settings.Upgrade()
            'My.Settings.Reload()
            conn = My.Settings.ProjetexDB2
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        updateTableAdapters(conn)

    End Sub

    Private Sub applyDBSettings()
        Dim connstr As String
        'Dim conn As New 
        Dim OK As Boolean = True
        'Dim FbConnection1 As

        'LabelDBStatus.Text = "Testing..."
        'StatusLed.BackColor = Color.Gold
        'text = ButtonTestDBSettings.Text
        'ButtonTestDBSettings.Text = "Testing..."
        'ButtonTestDBSettings.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        'TimerLed.Enabled = True
        'TimerLed.Start()

        connstr = "User=ODBC;" +
            "Password=" + TextBoxPassword.Text + ";" +
            "Database=" + TextBoxDatabase.Text + ";" +
            "DataSource=" + TextBoxServerAddress.Text + ";" +
            "Port=" + TextBoxServerPort.Text + ";" +
            "Dialect=3;" +
            "Charset=UTF8;" +
            "Role=PROJETEX_ODBC;" +
            "Connection lifetime=15;" +
            "Pooling=true;" +
            "MinPoolSize=0;" +
            "MaxPoolSize=50;" +
            "Packet Size=8192;" +
            "ServerType=0"
        'FbConnection1.ConnectionString = connstr
        'RichTextBoxConnectionString.Text = connstr
        updateConfigConnection(connstr)

        Me.Cursor = Me.DefaultCursor
    End Sub

    Private Sub FormFinRep_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        applyDBSettings()
    End Sub






End Class