Imports System
Imports System.IO
Imports System.Text
Imports OfficeOpenXml
Imports FirebirdSql
Imports System.Configuration
Imports System.Globalization

'remember to UPDATE updateTableAdapters EVERY TIME you add a TableAdapter!!!!!

Public Class FormFinRep
    Private Loaded As Boolean = False
    Private defaultCulture As CultureInfo = Application.CurrentCulture

    Private Sub updateTableAdapters(connstr As String)
        DTReport1TA.Connection.ConnectionString = connstr
        DTReport2TA.Connection.ConnectionString = connstr

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            DTReport1TA.Fill(DataSetFR.DTReport1, DateTimePickerFrom.Value, DateTimePickerTo.Value)
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
        'TODO: This line of code loads data into the 'DataSetFR.DTReport2' table. You can move, or remove it, as needed.
        'Me.DTReport2TA.Fill(Me.DataSetFR.DTReport2)
        DateTimePickerR2.Value = Today
        Try
            updateTableAdapters(My.Settings.ProjetexDB)
            Me.Loaded = True
            'FbConnection1.ConnectionString = My.Settings.ProjetexDB
            'DTReport1TA.Connection.ConnectionString = My.Settings.ProjetexDB
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
        exportToXLSX(DataGridViewReport1, "Profit Report " + DateTimePickerFrom.Value.ToShortDateString.Replace("/", "-") +
                                        "-" + DateTimePickerTo.Value.ToShortDateString.Replace("/", "-"))
    End Sub

    Private Sub exportToXLSX(grid As DataGridView, filename As String)
        Dim path, currency As String
        Dim currencyColumn As DataGridViewColumn = Nothing

        currency = ""
        Try
            SaveFileDialog1.FileName = filename + ".xlsx"
            If SaveFileDialog1.ShowDialog() Then
                path = SaveFileDialog1.FileName
            Else
                Return
            End If

            Dim f As FileInfo = New FileInfo(path)
            If f.Exists Then f.Delete()

            Dim p = New OfficeOpenXml.ExcelPackage(f)

            Dim ws = p.Workbook.Worksheets.Add(name)

            Dim i As Integer = 1
            For Each c As DataGridViewColumn In grid.Columns
                ws.SetValue(1, i, c.HeaderText)
                i = i + 1
                If c.DataPropertyName = "CURRENCY" Then
                    currencyColumn = c
                End If
            Next
            ws.Cells("1:1").Style.Font.Bold = True
            ws.Cells("1:1").Style.Border.Bottom.Style = Style.ExcelBorderStyle.Medium

            For r = 0 To grid.Rows.Count - 1
                If Not IsNothing(currencyColumn) Then
                    currency = grid.Rows(r).Cells(currencyColumn.Index).Value.ToString
                    CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol = currency
                    'Parse(DataGridViewReport2.Rows(e.RowIndex).Cells(OVERDUEDataGridViewTextBoxColumn.Name.ToString).Value
                End If
                For c = 0 To grid.Columns.Count - 1
                    Try
                        If IsDBNull(grid.Rows(r).Cells(c).Value) Then
                            Continue For
                        End If
                        If grid.Columns(c).DefaultCellStyle.Format.StartsWith("C") Then 'currency
                            ws.SetValue(r + 2, c + 1, Double.Parse(grid.Rows(r).Cells(c).Value.ToString))
                            ws.Cells(r + 2, c + 1).Style.Numberformat.Format = "[$" + currency + "]\ #,##0.00;[Red]\-[$" + currency + "]\ #,##0.00"
                            'ws.Cells(r + 2, c + 1).Style.Numberformat.Format = "#,##0.00;[Red]\-#,##0.00"
                        ElseIf grid.Columns(c).DefaultCellStyle.Format.StartsWith("p") Then 'percentage
                            ws.SetValue(r + 2, c + 1, Double.Parse(grid.Rows(r).Cells(c).Value.ToString) / 100)
                            ws.Cells(r + 2, c + 1).Style.Numberformat.Format = "0.00%"
                        ElseIf grid.Columns(c).DefaultCellStyle.Format.StartsWith("N") Then 'number
                            If grid.Columns(c).DefaultCellStyle.Format.StartsWith("N0") Then
                                ws.SetValue(r + 2, c + 1, Integer.Parse(grid.Rows(r).Cells(c).Value.ToString))
                                ws.Cells(r + 2, c + 1).Style.Numberformat.Format = "0"
                            Else
                                ws.SetValue(r + 2, c + 1, Double.Parse(grid.Rows(r).Cells(c).Value.ToString))
                                ws.Cells(r + 2, c + 1).Style.Numberformat.Format = "#,##0.00;[Red]\-#,##0.00"
                            End If
                        ElseIf grid.Columns(c).DefaultCellStyle.Format.StartsWith("d") Then 'date
                            ws.SetValue(r + 2, c + 1, grid.Rows(r).Cells(c).Value)
                            ws.Cells(r + 2, c + 1).Style.Numberformat.Format = "dd/mm/yyyy"
                        Else
                            ws.SetValue(r + 2, c + 1, grid.Rows(r).Cells(c).Value)
                        End If
                    Catch ex As Exception
                        MsgBox("r=" + r.ToString + " c=" + c.ToString + vbNewLine + ex.Message)
                    End Try

                Next
            Next
            p.Save()
            System.Diagnostics.Process.Start(f.FullName)
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        exportToXLSX(DataGridViewReport2, "Payment Tracker " + DateTimePickerR2.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture))
    End Sub

    Private Sub DateTimePickerR2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerR2.ValueChanged
        If Not Me.Loaded Then Return
        Try
            DTReport2TA.Fill(DataSetFR.DTReport2, DateTimePickerR2.Value) '.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture))
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub DataGridViewReport2_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles DataGridViewReport2.RowPostPaint
        If Integer.Parse(DataGridViewReport2.Rows(e.RowIndex).Cells(OVERDUEDataGridViewTextBoxColumn.Index).Value.ToString) > 0 Then
            DataGridViewReport2.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.PeachPuff
        Else
            DataGridViewReport2.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGreen
        End If
        'Application.CurrentCulture = defaultCulture
    End Sub

    Private Sub DataGridViewReport2_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles DataGridViewReport2.RowPrePaint
        Dim myCI As New CultureInfo("en-IN", True) 'Globalization.CultureTypes.NeutralCultures, True)

        myCI.NumberFormat.CurrencySymbol = DataGridViewReport2.Rows(e.RowIndex).Cells(CURRENCY.Index).Value.ToString
        Application.CurrentCulture = myCI
        'CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol = DataGridViewReport2.Rows(e.RowIndex).Cells(CURRENCY.Index).Value.ToString
    End Sub
End Class