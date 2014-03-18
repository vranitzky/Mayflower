Imports System.Globalization
Imports System.Net.Mail

Public Class FormMain

    Private Loaded As Boolean = False
    Public Attachments As New Dictionary(Of String, String) ' = New Dictionary(Of String, String)
    Private IsInAddTemplateMode As Boolean = False

    Private Sub GetCatTools()
        Dim t As Freelancers_Lookup.DataSet2DataSet.CatToolsDataTable
        Dim r As DataRow
        Dim a, s As String
        Dim arr As String()
        Dim i As Integer = 0 'hello
        Dim collection As SearchableStringCollection = New SearchableStringCollection
        Dim strlist As List(Of String) = New List(Of String)
        Dim charSeparators() As String = {vbCrLf, ",", "•", "", ""} 'rubbish characters in the Database

        TextBoxTools.AutoCompleteCustomSource.Clear()
        'Me.CatToolsTableAdapter.Fill(Me.DataSet2DataSet.CatTools)
        t = Me.CatToolsTableAdapter.GetData()
        For Each r In t.Rows
            s = r.Item(0).ToString ' this get a row. each row has: "value1" & vbCrLf & "value2" ....
            arr = s.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries)
            For Each a In arr
                ' remove spaces and extra characters like: •
                'collection.Add(a)
                a = a.Trim
                'a = a.
                If a.Length > 1 Then strlist.Add(a)
            Next
        Next
        strlist.Sort()

        Dim uniqueNames = From u In strlist Distinct

        For Each n In uniqueNames
            'ComboBoxTools.Items.Add(n.ToString)
            TextBoxTools.AutoCompleteCustomSource.Add(n.ToString)
        Next
        'For Each s In strlist
        'ComboBoxTools.Items.Add(s)
        'Next
    End Sub

    Private Sub FillFreelancersTable()
        ' if not Tag, then form has not loaded yet. no need for this to be called a million times
        If Not Me.Loaded Then Return

        'Here we must check for all possibilites: if filtering by source, target, domain, etc.
        ' and only display the data relevant to the restrictions
        Dim ret As Integer = 0
        Dim foundstr, sql As String
        Dim command As FirebirdSql.Data.FirebirdClient.FbCommand = New FirebirdSql.Data.FirebirdClient.FbCommand

        Me.Cursor = Cursors.AppStarting

        'Dim f As function

        ' TODO: parametrise this!
        'Build SQL query:
        sql = "SELECT RESOURCES.RES_ID AS ID, " &
                "RESOURCES.RES_NAME AS Name, " &
                "RESOURCES.""AIT$CUSTOMF00068"" AS SourceLang, " &
                "RESOURCES.""AIT$CUSTOMF00069"" AS TargetLang1, " &
                "RESOURCES.""AIT$CUSTOMF00074"" AS TargetLang2, " &
                "RESOURCES.""AIT$CUSTOMF00092"" AS Rate, " &
                "CURR.CURR_NAME AS Currency, COUNTRIES.COUN_NAME AS Country, " &
                "RESOURCES.""AIT$CUSTOMF00093"" AS ""Role"", " &
                "RESOURCES.""AIT$CUSTOMF00094"" AS Service, " &
                "RESOURCES.RES_EMAIL1 AS Email1, " &
                "RESOURCES.""AIT$CUSTOMF00125"" AS Approval " &
                "FROM RESOURCES " &
                "INNER JOIN COUNTRIES ON RESOURCES.COUN_ID = COUNTRIES.COUN_ID " &
                "INNER JOIN CURR ON RESOURCES.CURR_ID = CURR.CURR_ID " &
                "WHERE ((""AIT$CUSTOMF00125"" <> 'Rejected') OR (""AIT$CUSTOMF00125"" is null)) "
        '"WHERE 1=1 "

        'sql = "SELECT	RESOURCES.RES_ID, RESOURCES.RES_NAME, RESOURCES.""AIT$CUSTOMF00068"" AS SourceLang, " &
        '        "RESOURCES.""AIT$CUSTOMF00069"" AS TargetLang1, RESOURCES.""AIT$CUSTOMF00074"" AS TargetLang2, " &
        '        "RESOURCES.RES_CODE, CURR.CURR_NAME, CURR.CURR_DESC, COUNTRIES.COUN_NAME, COUNTRIES.COUN_FLAG " &
        '        "FROM RESOURCES " &
        '        "INNER JOIN COUNTRIES ON RESOURCES.COUN_ID = COUNTRIES.COUN_ID " &
        '        "INNER JOIN CURR ON RESOURCES.CURR_ID = CURR.CURR_ID " &
        '        "WHERE 1=1 "
        'What follows is horrible, I know. Directly using user submitted text into SQL queries? VERY BAD IDEA!
        'Should change this into @parameters
        If RestrictBySourceLang.Checked And ComboBoxSourceLang.Text <> "-ALL-" Then
            sql &= "AND (RESOURCES.""AIT$CUSTOMF00068"" = '" & ComboBoxSourceLang.Text & "')"
        End If
        If RestrictByTargetLang.Checked And ComboBoxTargetLang.Text <> "-ALL-" Then
            sql &= "AND ((RESOURCES.""AIT$CUSTOMF00069"" = '" & ComboBoxTargetLang.Text & "') OR (RESOURCES.""AIT$CUSTOMF00074"" = '" & ComboBoxTargetLang.Text & "')) "
        End If
        If RestrictByService.Checked And ComboBoxServices.Text <> "-ALL-" Then
            sql &= "AND (""AIT$CUSTOMF00094"" = '" & ComboBoxServices.Text & "') "
        End If
        If RestrictByRole.Checked And ComboBoxRole.Text <> "-ALL-" Then
            sql &= "AND (""AIT$CUSTOMF00093"" = '" & ComboBoxRole.Text & "') "
        End If
        If RestrictByDomain.Checked And ComboBoxDomains.Text <> "-ALL-" Then
            sql &= "AND ((RESOURCES.""AIT$CUSTOMF00103"" CONTAINING '" & ComboBoxDomains.Text & "') OR (RESOURCES.""AIT$CUSTOMF00104"" CONTAINING '" & ComboBoxDomains.Text & "') OR (RESOURCES.""AIT$CUSTOMF00105"" CONTAINING '" & ComboBoxDomains.Text & "')) "
        End If
        If RestrictByTools.Checked And TextBoxTools.Text <> "" And TextBoxTools.Text <> "-ALL-" Then
            sql &= "AND (UPPER(RESOURCES.""AIT$CUSTOMF00067"") LIKE UPPER('%" & TextBoxTools.Text & "%')) "
        End If
        If RestrictByCountry.Checked And ComboBoxCountry.SelectedValue.ToString <> "-1" Then
            sql &= "AND (RESOURCES.COUN_ID = '" & ComboBoxCountry.SelectedValue.ToString & "') "
        End If
        If RestrictByName.Checked And Not String.IsNullOrWhiteSpace(TextBoxName.Text) Then
            sql &= "AND (RESOURCES.RES_NAME CONTAINING '" & TextBoxName.Text & "') "
        End If

        command.Connection = FreelancersTableAdapter.Connection
        command.CommandText = sql
        command.CommandType = Global.System.Data.CommandType.Text

        FreelancersTableAdapter.Adapter.SelectCommand = command

        If (FreelancersTableAdapter.ClearBeforeFill = True) Then
            DataSet2DataSet.DataTableFreelancers.Clear()
        End If
        Try
            ret = FreelancersTableAdapter.Adapter.Fill(DataSet2DataSet.DataTableFreelancers)

        Catch ex As Exception
            Return
        Finally
            command.Dispose()
        End Try



        'If RestrictBySourceLang.Checked And ComboBoxSourceLang.Text <> "-ALL-" Then
        'If RestrictByTargetLang.Checked And ComboBoxTargetLang.Text <> "-ALL-" Then
        'ret = FreelancersTableAdapter.FillBySourceAndTargetLang(Me.DataSet2DataSet.DataTableFreelancers, ComboBoxSourceLang.Text, ComboBoxTargetLang.Text)
        'Else
        'ret = FreelancersTableAdapter.FillBySourceLang(Me.DataSet2DataSet.DataTableFreelancers, ComboBoxSourceLang.Text)
        'End If
        'Else
        'If RestrictByTargetLang.Checked And ComboBoxTargetLang.Text <> "-ALL-" Then
        'ret = FreelancersTableAdapter.FillByTargetLang(Me.DataSet2DataSet.DataTableFreelancers, ComboBoxTargetLang.Text)
        'Else
        'ret = FreelancersTableAdapter.Fill(Me.DataSet2DataSet.DataTableFreelancers)
        'End If
        'End If
        foundstr = "Found " & ret.ToString & " record"
        If ret <> 1 Then foundstr &= "s"
        LabelRecordsFound.Text = foundstr
        Me.Cursor = Cursors.Default
        'command.Dispose()
    End Sub

    Private Sub ComboBoxSourceLang_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxSourceLang.SelectionChangeCommitted

        'TODO: SHOULD save target lang, refill targetlang combo with new languages and
        'if saved value is in new list, select it in the combo.

        If RestrictBySourceLang.Checked Then 'if not restricted, ignore any change
            If ComboBoxSourceLang.Text <> "-ALL-" Then
                TargetLangTableAdapter.FillBySourceLanguage(Me.DataSet2DataSet.DataTableTargetLang, ComboBoxSourceLang.Text)
            Else
                TargetLangTableAdapter.Fill(Me.DataSet2DataSet.DataTableTargetLang)
            End If
            FillFreelancersTable()
        End If
    End Sub

    Private Sub ComboBoxTargetLang_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxTargetLang.SelectionChangeCommitted
        If RestrictByTargetLang.Checked Then 'if not restricted, ignore any change
            FillFreelancersTable()
        End If
    End Sub

    Private Sub ComboBoxDomains_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxDomains.SelectionChangeCommitted
        If RestrictByDomain.Checked Then
            FillFreelancersTable()
        End If
    End Sub

    Private Sub ComboBoxServices_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxServices.SelectionChangeCommitted
        If RestrictByService.Checked Then
            FillFreelancersTable()
        End If
    End Sub

    Private Sub ComboBoxCountry_SelectionChangeCommitted(sender As System.Object, e As System.EventArgs) Handles ComboBoxCountry.SelectionChangeCommitted
        If RestrictByCountry.Checked Then
            FillFreelancersTable()
        End If
    End Sub

    Private Sub RestrictByCheckedChanged(sender As System.Object, e As System.EventArgs) Handles RestrictByTools.CheckedChanged, RestrictByTargetLang.CheckedChanged, RestrictBySourceLang.CheckedChanged, RestrictByService.CheckedChanged, RestrictByDomain.CheckedChanged, RestrictByCountry.CheckedChanged, RestrictByName.CheckedChanged, RestrictByRole.CheckedChanged
        FillFreelancersTable()
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        'MessageBox.Show("Double clicked")
        Dim ID As Integer
        Dim a As String

        Try
            Me.Cursor = Cursors.WaitCursor
            ID = CInt(DataGridView1.CurrentRow.Cells(0).Value) 'this is the ID
            FreelancerInfoTableAdapter.FillByResid(Me.DataSet2DataSet.DTFreelancerInfo, ID) ', "'" + FreelancersFolder.Text + "'")
            TADetails.Fill(Me.DataSet2DataSet.DTDetails, ID)
            CatToolsTableAdapter.FillByResID(Me.DataSet2DataSet.CatTools, ID)
            a = Me.DataSet2DataSet.DTFreelancerInfo.Item(0).RES_CODE
            LinkLabelFiles.Text = FreelancersFolder.Text + "\" + a + "\CV"
            TabControl1.SelectedTab = TabDetails
        Catch ex As Exception
            MessageBox.Show("There was an error!" & Environment.NewLine & Environment.NewLine &
                            """" & ex.Message & """" & Environment.NewLine & Environment.NewLine &
                            "Sorry!",
                            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
                            )
        End Try
        Me.Cursor = Me.DefaultCursor
    End Sub

    Private Sub ButtonApplyDBSettings_Click(sender As System.Object, e As System.EventArgs) Handles ButtonApplyDBSettings.Click
        Dim connstr As String
        Dim ok As Boolean = True

        StatusLed.BackColor = Color.Gold

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
        'RichTextBoxConnectionString.Text = connstr

        Try
            'DataSet2DataSet.Clear()

            FreelancersTableAdapter.Connection.ConnectionString = connstr
            SourceLangTableAdapter.Connection.ConnectionString = connstr
            TargetLangTableAdapter.Connection.ConnectionString = connstr
            CatToolsTableAdapter.Connection.ConnectionString = connstr
            ServiceTableAdapter.Connection.ConnectionString = connstr
            DomainsTableAdapter.Connection.ConnectionString = connstr
            TADetails.Connection.ConnectionString = connstr
            FreelancerInfoTableAdapter.Connection.ConnectionString = connstr
            COUNTRIESTableAdapter.Connection.ConnectionString = connstr

            SourceLangTableAdapter.Fill(DataSet2DataSet.DataTableSourceLang)
            TargetLangTableAdapter.Fill(DataSet2DataSet.DataTableTargetLang)
            Me.ServiceTableAdapter.Fill(Me.DataSet2DataSet.DataTableService)
            'TODO: This line of code loads data into the 'DataSet2DataSet.DataTableDomains' table. You can move, or remove it, as needed.
            Me.DomainsTableAdapter.Fill(Me.DataSet2DataSet.DataTableDomains)
            CatToolsTableAdapter.Fill(Me.DataSet2DataSet.CatTools)
            COUNTRIESTableAdapter.Fill(Me.DataSet2DataSet.COUNTRIES)

            'FreelancersTableAdapter.Fill(DataSet2DataSet.DataTableFreelancers)

            GetCatTools()
            FillFreelancersTable()

        Catch ex As Exception
            MessageBox.Show("Failed to connect to data source: " & ex.Message)
            ok = False
            StatusLed.BackColor = Color.Red
            'Finally
            'conn.Close()
        End Try
        If ok Then
            StatusLed.BackColor = Color.Green
            My.Settings.ProjetexDB = connstr
            My.Settings.DBPort = TextBoxServerPort.Text
            My.Settings.DBPassword = TextBoxPassword.Text
            My.Settings.DBAddress = TextBoxServerAddress.Text
            My.Settings.DBFile = TextBoxDatabase.Text

            'TODO reset connection
            'DataSet2DataSet.cl()

            My.Settings.Save()
        End If

        ButtonApplyDBSettings.Enabled = False
    End Sub

    Private Sub ButtonTestDBSettings_Click(sender As System.Object, e As System.EventArgs) Handles ButtonTestDBSettings.Click
        Dim connstr, text As String
        'Dim conn As New 
        Dim OK As Boolean = True

        StatusLed.BackColor = Color.Gold
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
            Me.Cursor = Cursors.Default
        End Try
        If (OK) Then
            ButtonApplyDBSettings.Enabled = True
            StatusLed.BackColor = Color.Green
            'MessageBox.Show("Succesfully connected")
        Else
            StatusLed.BackColor = Color.Red
        End If

    End Sub

    Private Sub TextBoxServerSetting_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxServerPort.TextChanged, TextBoxServerAddress.TextChanged, TextBoxPassword.TextChanged, TextBoxDatabase.TextChanged
        ButtonApplyDBSettings.Enabled = False
        StatusLed.BackColor = Color.Gold
    End Sub

    Private Sub Form1_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown

        ' This is needed to load email body into the txtcontrol, to avoid "txrcontrol must be visible" error
        Dim c As Control = EmailBody.Parent
        EmailBody.Parent = Nothing
        If Not EmailBody.IsHandleCreated Then
            EmailBody.CreateControl()
        End If
        EmailBody.Load(My.Settings.EmailBody, TXTextControl.StringStreamType.HTMLFormat)
        EmailBody.Parent = c

        ' this checks if first run. If so, display a note that settings must be set
        If My.Settings.FirstRun Then
            MsgBox("This is the first run." & Environment.NewLine &
                   "Please remember to check the Settings tab and input a default email in the Email tab.",
                   MsgBoxStyle.Exclamation,
                   "First run"
            )
            TabSettings.Select()
            My.Settings.FirstRun = False
        End If
        ''''''''''''''Me.Text &= " - " & ProductVersion

    End Sub

    Private Sub FormMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Dim t As ada
        Me.Loaded = True

        StatusLed.BackColor = Color.Red
        RestrictBySourceLang.Checked = True
        RestrictByTargetLang.Checked = True
        RestrictBySourceLang.Enabled = True
        RestrictByTargetLang.Enabled = True

        'fill the templates list
        If My.Settings.EmailTemplatesNames Is Nothing Then 'no saved templates - load a default one
            My.Settings.EmailTemplatesNames = New System.Collections.Specialized.StringCollection
            My.Settings.EmailTemplatesNames.Insert(0, "Default") 'TemplatesCombo.Items(0).ToString)
        End If
        If My.Settings.EmailTemplatesBodies Is Nothing Then 'no saved templates - load a default one
            My.Settings.EmailTemplatesBodies = New System.Collections.Specialized.StringCollection
            My.Settings.EmailTemplatesBodies.Insert(0, My.Settings.EmailBody)
        End If
        If My.Settings.EmailTemplatesSubjects Is Nothing Then 'no saved templates - load a default one
            My.Settings.EmailTemplatesSubjects = New System.Collections.Specialized.StringCollection
            My.Settings.EmailTemplatesSubjects.Insert(0, My.Settings.EmailSubject)
        End If
        ' fill the dropbox
        For Each body In My.Settings.EmailTemplatesBodies

        Next
        For i = 0 To My.Settings.EmailTemplatesNames.Count - 1
            TemplatesCombo.Items.Insert(i, My.Settings.EmailTemplatesNames.Item(i))
            'DialogEmailWarning.ComboTemplates.Items.Insert(i, My.Settings.EmailTemplatesNames.Item(i))
        Next
        TemplatesCombo.SelectedIndex = 0
        'MsgBox(My.Settings.EmailTemplatesSubjects.)

        Try
            FbConnection1.ConnectionString = My.Settings.ProjetexDB
            FreelancersTableAdapter.Connection.ConnectionString = My.Settings.ProjetexDB
            SourceLangTableAdapter.Connection.ConnectionString = My.Settings.ProjetexDB
            TargetLangTableAdapter.Connection.ConnectionString = My.Settings.ProjetexDB
            CatToolsTableAdapter.Connection.ConnectionString = My.Settings.ProjetexDB
            ServiceTableAdapter.Connection.ConnectionString = My.Settings.ProjetexDB
            DomainsTableAdapter.Connection.ConnectionString = My.Settings.ProjetexDB
            TADetails.Connection.ConnectionString = My.Settings.ProjetexDB
            FreelancerInfoTableAdapter.Connection.ConnectionString = My.Settings.ProjetexDB
            COUNTRIESTableAdapter.Connection.ConnectionString = My.Settings.ProjetexDB

            'TODO: This line of code loads data into the 'DataSet2DataSet.COUNTRIES' table. You can move, or remove it, as needed.
            Me.COUNTRIESTableAdapter.Fill(Me.DataSet2DataSet.COUNTRIES)

            'TODO: This line of code loads data into the 'DataSet2DataSet.DataTableTargetLang' table. You can move, or remove it, as needed.
            Me.TargetLangTableAdapter.Fill(Me.DataSet2DataSet.DataTableTargetLang)
            'TODO: This line of code loads data into the 'DataSet2DataSet.DataTableSourceLang' table. You can move, or remove it, as needed.
            Me.SourceLangTableAdapter.Fill(Me.DataSet2DataSet.DataTableSourceLang)
            'TODO: This line of code loads data into the 'DataSet2DataSet.DataTableFreelancers' table. You can move, or remove it, as needed.
            'TODO: This line of code loads data into the 'DataSet2DataSet1.DataTableService' table. You can move, or remove it, as needed.
            Me.ServiceTableAdapter.Fill(Me.DataSet2DataSet.DataTableService)
            'TODO: This line of code loads data into the 'DataSet2DataSet.DataTableDomains' table. You can move, or remove it, as needed.
            Me.DomainsTableAdapter.Fill(Me.DataSet2DataSet.DataTableDomains)
            'Me.FreelancersTableAdapter.Fill(Me.DataSet2DataSet.DataTableFreelancers)
            'TODO: This line of code loads data into the 'DataSet2DataSet2.DataTableRole' table. You can move, or remove it, as needed.
            Me.RoleTableAdapter.Fill(Me.DataSet2DataSet2.DataTableRole)
            'TODO: This line of code loads data into the 'DataSet2DataSet.DataTableService' table. You can move, or remove it, as needed.
            'Me.CatToolsTableAdapter.Fill(Me.DataSet2DataSet.CatTools)
            GetCatTools()
            FillFreelancersTable()


            StatusLed.BackColor = Color.Green
        Catch ex As Exception
            '"Failed to connect to database: " & Environment.NewLine &
            'SplashScreen1.Close()
            MessageBox.Show("There was an error!" & Environment.NewLine & Environment.NewLine &
                            """" & ex.Message & """" & Environment.NewLine & Environment.NewLine &
                            "Please set up Database parameters in the next window.",
                            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
                            )
            TabControl1.SelectedTab = TabSettings
            'TabPage1.
            '        Finally
            '            FbConnection1.Close()
        End Try


    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox3.CheckedChanged
        TextBoxPassword.UseSystemPasswordChar = Not CheckBox3.Checked
    End Sub

    Private Sub DataGridView2_RowPostPaint(sender As System.Object, e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles DataGridView2.RowPostPaint
        If DataGridView2.Rows(e.RowIndex).Cells("ISCOMPLETED").Value.ToString = "0" Then
            DataGridView2.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.PeachPuff
        End If
    End Sub

    Private Sub ComboBoxTools_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBoxTools.KeyDown, TextBoxName.KeyDown
        If e.KeyCode = Keys.Return Then
            FillFreelancersTable()
        End If

    End Sub

    Private Function ShowEmailPreviewWarning(recipient As String, template As Integer) As Boolean
        Dim result As Boolean = True

        If DialogEmailWarning.CheckBoxRemindMe.Checked Then
            DialogEmailWarning.LabelYouAreSending.Text = String.Format("Email to {0}", recipient)

            DialogEmailWarning.Tag = template
            DialogEmailWarning.ShowDialog()
            result = (DialogEmailWarning.DialogResult = Windows.Forms.DialogResult.OK)
        End If
        Return result
    End Function

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        'Dim a As String = DataGridView1.CurrentRow.Cells(1).Value.ToString
        Dim recipient, recName As String

        If colName = "EmailButton" Then
            recipient = DataGridView1.CurrentRow.Cells(e.ColumnIndex).Value.ToString
            recName = DataGridView1.CurrentRow.Cells(1).Value.ToString

            If Not String.IsNullOrWhiteSpace(recName) Then
                recipient = """" & recName & """ <" & recipient & ">"
            End If
            If String.IsNullOrWhiteSpace(recipient) Then
                MsgBox("There is no email address to send to!", MsgBoxStyle.Information, "Email error")
            Else
                If ShowEmailPreviewWarning(recipient, TemplatesCombo.SelectedIndex) Then SendEmail(recipient)
            End If
        End If

    End Sub

    Private Sub ButtonSendEmail_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSendEmail.Click
        Dim result As Boolean = True
        Dim naam As String = TextBoxEmailAddress.Text

        If String.IsNullOrWhiteSpace(naam) Then
            MsgBox("There is no email address to send to!", MsgBoxStyle.Information, "Email error")
        Else
            If Not String.IsNullOrWhiteSpace(DetailsBoxName.Text) Then
                naam = """" + DetailsBoxName.Text + """ <" + naam + ">"
            End If
            If ShowEmailPreviewWarning(naam, TemplatesCombo.SelectedIndex) Then
                SendEmail(naam)
            End If
        End If
    End Sub

    Private Sub SendEmail(address As String)
        Dim result As String
        'MessageBox.Show("Temporarily disabled",
        '                  "Warning",
        'MessageBoxButtons.OK,
        'MessageBoxIcon.Warning()
        '                   )
        'Return
        If String.IsNullOrWhiteSpace(EmailSettingsPassword.Text) Then
            ' MsgBox("Please set your enail details first under the ""Settings"" tab!")
            MessageBox.Show("Please set your email details first under the ""Settings"" tab!",
                            "Email setting undetected",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
                            )
            TabControl1.SelectTab(TabSettings)
            Return
        End If

        Dim Recipients As New List(Of String)
        Dim FromEmailAddress As String = """" + EmailSettingsName.Text + """ <" + EmailSettingsEmail.Text + ">"
        Dim Subject As String = EmailSubject.Text
        Dim Body As String = ""
        Dim UserName As String = EmailSettingsEmail.Text
        Dim Password As String = EmailSettingsPassword.Text
        Dim Port As Integer = CInt(EmailSettingsPort.Text)
        Dim Server As String = EmailSettingsServer.Text
        Dim AttachmentsList As New List(Of String)
        Try
            '            System.Diagnostics.Process.Start("mailto:" &
            '                                            address &
            '                                           "?Subject=" & EmailSubject.Text &
            '                                          "&Body=" & EmailBody.Text
            '                                         )
            'if testmode is on, alert, otherwise add recipient to recipients list
            If My.Settings.EmailTestMode Then
                MessageBox.Show("Please note that in this test version, email is sent to yourself ONLY:" & Environment.NewLine & Environment.NewLine &
                        """" & EmailSettingsName.Text & """ <" & EmailSettingsEmail.Text & ">" & Environment.NewLine & Environment.NewLine &
                        "NOT:" & Environment.NewLine & Environment.NewLine &
                        address,
                                "Testing email mode",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                                )
            Else
                Recipients.Add(address)
            End If
            'now the attachments. they come from the DialogEmailWarning
            AttachmentsList = Attachments.Values.ToList
            'in any case, send a copy to yourself
            Recipients.Add(EmailSettingsName.Text & " <" & EmailSettingsEmail.Text & ">")
            'EmailBody.Save(Body, TXTextControl.StringStreamType.HTMLFormat)
            'DialogEmailWarning.EmailBody.Save(Body, TXTextControl.StringStreamType.HTMLFormat)
            Body = DialogEmailWarning.SubmittedBody
            Subject = DialogEmailWarning.SubmittedSubject
            result = SendEmail(Recipients, FromEmailAddress, Subject, Body, UserName, Password, Server, Port, AttachmentsList)
            If result Is Nothing Then
                MsgBox("Success!", MsgBoxStyle.Information, "Email result")
            Else
                MsgBox(result, MsgBoxStyle.Critical, "Email result")
            End If

        Catch ex As Exception
            MessageBox.Show("There was an error!" & Environment.NewLine & Environment.NewLine &
                            """" & ex.Message & """",
                            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
                            )
        End Try

    End Sub

    ''' <summary>
    ''' Sends and email to a list of recipients
    ''' </summary>
    ''' <param name="Recipients">The List(of string) of recipients.</param>
    ''' <param name="FromAddress">The List(of string) of recipients.</param>
    ''' <param name="Subject">The List(of string) of recipients.</param>
    ''' <remarks></remarks>

    Function SendEmail(ByVal Recipients As List(Of String), _
                  ByVal FromAddress As String, _
                  ByVal Subject As String, _
                  ByVal Body As String, _
                  ByVal UserName As String, _
                  ByVal Password As String, _
                  Optional ByVal Server As String = "smtp.gmail.com", _
                  Optional ByVal Port As Integer = 587, _
                  Optional ByVal Attachments As List(Of String) = Nothing) As String
        Dim Email As New MailMessage()
        Try
            Dim SMTPServer As New SmtpClient
            For Each Attachment As String In Attachments
                Email.Attachments.Add(New Attachment(Attachment))
            Next
            Email.From = New MailAddress(FromAddress)
            For Each Recipient As String In Recipients
                Email.To.Add(Recipient)
            Next
            Email.IsBodyHtml = True
            Email.Subject = Subject
            Email.Body = Body
            SMTPServer.Host = Server
            SMTPServer.Port = Port
            SMTPServer.Credentials = New System.Net.NetworkCredential(UserName, Password)
            SMTPServer.EnableSsl = False
            Me.Cursor = Cursors.WaitCursor
            SMTPServer.Send(Email)
            Me.Cursor = Me.DefaultCursor
            Email.Dispose()
            'Return "Email to " & Recipients(0) & " from " & FromAddress & " was sent."
        Catch ex As SmtpException
            Email.Dispose()
            Return "Sending Email Failed. Smtp Error."
        Catch ex As ArgumentOutOfRangeException
            Email.Dispose()
            Return "Sending Email Failed. Check Port Number."
        Catch Ex As InvalidOperationException
            Email.Dispose()
            Return "Sending Email Failed. Check Port Number."
        Catch Ex As Exception
            Email.Dispose()
            Return "Sending Email Failed with the following error:" & Environment.NewLine & Ex.Message
        End Try
        Return Nothing
    End Function

    Private Sub EmailTestButton_Click(sender As Object, e As EventArgs) Handles EmailButtonTest.Click
        Dim Recipients As New List(Of String)
        Recipients.Add(EmailSettingsName.Text & " <" & EmailSettingsEmail.Text & ">")
        Dim FromEmailAddress As String = Recipients(0)
        Dim Subject As String = "Test From Projetex Lookup tool."
        Dim Body As String = ""
        EmailBody.Save(Body, TXTextControl.StringStreamType.HTMLFormat)
        Dim UserName As String = EmailSettingsEmail.Text
        Dim Password As String = EmailSettingsPassword.Text
        Dim Port As Integer = CInt(EmailSettingsPort.Text)
        Dim Server As String = EmailSettingsServer.Text
        Dim Attachments As New List(Of String)
        Dim Err As String
        Err = SendEmail(Recipients, FromEmailAddress, Subject, Body, UserName, Password, Server, Port, Attachments)
        If Not Err Is Nothing Then
            MessageBox.Show("There was an error!" & Environment.NewLine & Environment.NewLine & """" & Err & """",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        Else
            MsgBox("Email sent successfully!", MsgBoxStyle.Information, "Email Test")
        End If
    End Sub

    Private Sub EmailBody_Leave(sender As System.Object, e As System.EventArgs) Handles EmailBody.Leave
        'now we have templates!
        'EmailBody.Save(My.Settings.EmailBody, TXTextControl.StringStreamType.HTMLFormat)
        If Not IsInAddTemplateMode Then ' simple changes to the body
            EmailBody.Save(My.Settings.EmailTemplatesBodies(TemplatesCombo.SelectedIndex), TXTextControl.StringStreamType.HTMLFormat)
        Else 'we are adding a new template. Don't save until the user presses the OK button
            'do nothing
        End If
    End Sub
    Private Sub EmailSubject_Leave(sender As Object, e As EventArgs) Handles EmailSubject.Leave
        If Not IsInAddTemplateMode Then ' simple changes to the body
            My.Settings.EmailTemplatesSubjects(TemplatesCombo.SelectedIndex) = EmailSubject.Text
        Else 'we are adding a new template. Don't save until the user presses the OK button
            'do nothing
            'xxx()
        End If
    End Sub

    Private Sub EmailBody_Enter(sender As System.Object, e As System.EventArgs) Handles EmailBody.Enter
        'EmailBody.Load(My.Settings.EmailBody, TXTextControl.StringStreamType.HTMLFormat)
    End Sub

    Private Sub TemplatesButtonAdd_Click(sender As System.Object, e As System.EventArgs) Handles TemplatesButtonAdd.Click
        Dim title As String
        Dim subject, body As String
        Static Dim tip As System.Windows.Forms.IWin32Window
        Dim newindex As Integer = 0

        If Not tip Is Nothing Then 'a tooltip is being displayed. hide it
            ToolTip1.Hide(tip)
            tip = Nothing
        End If

        If IsInAddTemplateMode Then ' this is the OK button
            title = TemplatesCombo.Text
            If title = "" Then 'missing title
                'ToolTip1.IsBalloon = True
                ToolTip1.Show("Please give a title to the new template", TemplatesCombo)
                tip = TemplatesCombo
                Return
            End If
            subject = EmailSubject.Text
            If subject = "" Then 'missing subject
                'ToolTip1.IsBalloon = True
                ToolTip1.Show("Please enter a subject", EmailSubject)
                tip = EmailSubject
                Return
            End If
            body = EmailBody.Text
            If body = "" Then 'missing body
                'ToolTip1.IsBalloon = True
                ToolTip1.Show("Please enter a body", EmailBody)
                tip = EmailBody
                Return
            End If

            TemplatesButtonAdd.Text = "Add New" 'change it back to 'Add New'
            TemplatesButtonRemove.Text = "Remove" 'change it back to 'Remove'
            TemplatesCombo.DropDownStyle = ComboBoxStyle.DropDownList
            'TODO: all ok, add into templates list
            'MsgBox("here I would save the template:" & Environment.NewLine &
            '       subject & Environment.NewLine &
            '      title & Environment.NewLine &
            '     body,
            '   MsgBoxStyle.Exclamation)
            ' using new index:
            newindex = TemplatesCombo.Items.Count
            title = newindex.ToString & "-" & title

            TemplatesCombo.Items.Insert(newindex, title)

            EmailBody.Save(body, TXTextControl.StringStreamType.HTMLFormat) 'get the HTML

            My.Settings.EmailTemplatesNames.Insert(newindex, title)
            My.Settings.EmailTemplatesSubjects.Insert(newindex, subject)
            My.Settings.EmailTemplatesBodies.Insert(newindex, body)

            TemplatesCombo.SelectedIndex = newindex
            IsInAddTemplateMode = False
        Else 'this is the Add button: user wants to add new template
            TemplatesButtonAdd.Text = "OK" 'change it to OK
            TemplatesButtonRemove.Text = "Cancel" 'change it to Cancel
            TemplatesButtonRemove.Enabled = True
            TemplatesCombo.DropDownStyle = ComboBoxStyle.Simple
            TemplatesCombo.Text = ""
            IsInAddTemplateMode = True
        End If
    End Sub

    Private Sub TemplatesButtonRemove_Click(sender As System.Object, e As System.EventArgs) Handles TemplatesButtonRemove.Click
        If IsInAddTemplateMode Then ' this button is the Cancel button
            TemplatesButtonAdd.Text = "Add New"
            TemplatesButtonRemove.Text = "Remove"
            TemplatesCombo.DropDownStyle = ComboBoxStyle.DropDownList
            'TemplatesButtonRemove.Enabled = False ' because we go to default profile (non erasable)
            ' actually, ^^^ should not be needed - selectedindexchasnge should trigger
            TemplatesCombo.SelectedIndex = 0
            IsInAddTemplateMode = False
        Else 'this is the Remove button
            'TODO: delete template
            Dim index As Integer = TemplatesCombo.SelectedIndex
            TemplatesCombo.SelectedIndex = 0
            TemplatesCombo.Items.RemoveAt(index)
            My.Settings.EmailTemplatesBodies.RemoveAt(index)
            My.Settings.EmailTemplatesNames.RemoveAt(index)
            My.Settings.EmailTemplatesSubjects.RemoveAt(index)
        End If
    End Sub

    Private Sub TemplatesCombo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles TemplatesCombo.SelectedIndexChanged
        Dim index As Integer = CType(sender, ComboBox).SelectedIndex

        EmailSubject.Text = My.Settings.EmailTemplatesSubjects(index)

        'braindead TXControl must be loaded manually first time. I just do it every time and piss off!
        If Not EmailBody.IsHandleCreated Then
            Dim c As Control = EmailBody.Parent
            EmailBody.Parent = Nothing
            EmailBody.CreateControl()
            ''TXTextControl.StreamType.HTMLFormat)
            EmailBody.Parent = c
        End If
        EmailBody.Load(My.Settings.EmailTemplatesBodies(index), TXTextControl.StringStreamType.HTMLFormat)

        If index = 0 Then
            TemplatesButtonRemove.Enabled = False 'don't delete default profile
        Else
            TemplatesButtonRemove.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'For Each s In My.Settings.
        Dim response = MsgBox("Are you sure?" & Environment.NewLine &
               "This will remove all preferences and templates!",
               MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Exclamation,
               "Reset Settings to Default")
        If response = MsgBoxResult.Yes Then
            My.Settings.Reset()
            Application.Restart()
        End If
    End Sub

    Private Sub DataGridView1_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles DataGridView1.RowPostPaint
        If DataGridView1.Rows(e.RowIndex).Cells("APPROVALDataGridViewTextBoxColumn").Value.ToString = "Block" Then
            DataGridView1.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.PeachPuff
        End If
        ''Now the Rate is not a number, but text, so the trick of using INR, USD etc as currency symbol does not work anymore
        ''which means we have to manually add the currency if there is any value in the cell
        'If Not String.IsNullOrWhiteSpace(DataGridView1.Rows(e.RowIndex).Cells("RATEDataGridViewTextBoxColumn").Value.ToString) Then
        'DataGridView1.Rows(e.RowIndex).Cells("RATEDataGridViewTextBoxColumn").Value =
        'DataGridView1.Rows(e.RowIndex).Cells("FreelancersCURRENCY").Value.ToString(+" " + DataGridView1.Rows(e.RowIndex).Cells("RATEDataGridViewTextBoxColumn").Value.ToString)
        'End If
        'Actually, just show a column with currency instead, as sometimes they now put the currency in themselves

    End Sub

    Private Sub DataGridView1_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles DataGridView1.RowPrePaint
        Dim myCI As New CultureInfo("en-IN", True) 'Globalization.CultureTypes.NeutralCultures, True)

        myCI.NumberFormat.CurrencySymbol = DataGridView1.Rows(e.RowIndex).Cells(FreelancersCURRENCY.Index).Value.ToString
        Application.CurrentCulture = myCI

    End Sub

    Private Sub ComboBoxRole_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBoxRole.SelectionChangeCommitted
        If RestrictByRole.Checked Then
            FillFreelancersTable()
        End If
    End Sub

    
    Private Sub LinkLabelFiles_Click(sender As Object, e As EventArgs) Handles LinkLabelFiles.Click
        Try
            System.Diagnostics.Process.Start(LinkLabelFiles.Text)
        Catch ex As Exception
            MsgBox("This freelancer has no CV folder, or the server is not accessible")
        End Try
    End Sub

End Class
