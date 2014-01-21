﻿Imports System
Imports System.IO
Imports System.Text
Imports OfficeOpenXml
Imports FirebirdSql
Imports System.Configuration
'remember to UPDATE ButtonApplyDBSettings_Click EVERY TIME you add a TableAdapter!!!!!

Public Class FormFinRep
    Private TableAdapters As DataTable
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            DTReport1TA.Fill(DataSet2.DTReport1, DateTimePickerFrom.Value, DateTimePickerTo.Value)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Cursor = Me.DefaultCursor
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
            FbConnection1.ConnectionString = My.Settings.ProjetexDB
            DTReport1TA.Connection.ConnectionString = My.Settings.ProjetexDB
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

    Private Sub ButtonR1Export_Click(sender As Object, e As EventArgs) Handles ButtonR1Export.Click
        Dim path As String

        Try
            SaveFileDialog1.FileName = DateTimePickerFrom.Value.ToShortDateString.Replace("/", "") +
                                        "-" +
                                        DateTimePickerTo.Value.ToShortDateString.Replace("/", "")
            If SaveFileDialog1.ShowDialog() Then
                path = SaveFileDialog1.FileName
            Else
                Return
            End If

            Dim f As FileInfo = New FileInfo(path)
            If f.Exists Then f.Delete()

            Dim p = New OfficeOpenXml.ExcelPackage(f)

            Dim ws = p.Workbook.Worksheets.Add("Report1")

            Dim i As Integer = 1
            For Each c As DataGridViewColumn In DataGridViewReport1.Columns
                ws.SetValue(1, i, c.HeaderText)
                i = i + 1
            Next
            ws.Cells("1:1").Style.Font.Bold = True
            ws.Cells("1:1").Style.Border.Bottom.Style = Style.ExcelBorderStyle.Medium

            For r = 0 To DataGridViewReport1.Rows.Count - 1
                For c = 0 To DataGridViewReport1.Columns.Count - 1
                    ws.SetValue(r + 2, c + 1, DataGridViewReport1.Rows(r).Cells(c).Value)
                    'wr.Write(DataGridViewReport1.Rows(r).Cells(c).Value.ToString + vbTab)
                Next
                'wr.WriteLine()
            Next

            'Dim wr1 As StreamWriter = New StreamWriter(path, False, Encoding.UTF8)
            'wr1.Write(p.

            'wr1.Close()

            p.Save()

        Catch ex As Exception
            MsgBox("There was an error:" + vbNewLine + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
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
        RichTextBoxConnectionString.Text = connstr

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

        DTReport1TA.Connection.ConnectionString = connstr

        Me.Cursor = Me.DefaultCursor
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
        XmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile)

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
        config.Save(ConfigurationSaveMode.Modified)

        ' Force a reload of the changed section, 
        ' if needed. This makes the new values available 
        ' for reading.
        ConfigurationManager.RefreshSection("connectionStrings")

        My.Settings("ProjetexDB2") = conn
        My.Settings.Save()
        'My.Settings.Upgrade()
        'My.Settings.Reload()
        conn = My.Settings.ProjetexDB2
    End Sub


End Class