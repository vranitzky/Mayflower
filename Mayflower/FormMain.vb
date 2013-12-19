Public Class FormMain
    Private Loaded As Boolean = False

    Private Sub GetCatTools()
        Dim t As Mayflower.DataSet2.CatToolsDataTable
        Dim r As DataRow
        Dim a, s As String
        Dim arr As String()
        Dim i As Integer = 0
        Dim collection As SearchableStringCollection = New SearchableStringCollection
        Dim strlist As List(Of String) = New List(Of String)
        Dim charSeparators() As String = {vbCrLf, ",", "•", "", ""} 'rubbish characters in the Database

        TextBoxTools.AutoCompleteCustomSource.Clear()
        'Me.CatToolsTableAdapter.Fill(Me.DataSet2.CatTools)
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

        'Build SQL query:
        sql = "SELECT RESOURCES.RES_ID AS ID, " &
                "RESOURCES.RES_NAME AS Name, " &
                "RESOURCES.""AIT$CUSTOMF00068"" AS SourceLang, " &
                "RESOURCES.""AIT$CUSTOMF00069"" AS TargetLang1, " &
                "RESOURCES.""AIT$CUSTOMF00074"" AS TargetLang2, " &
                "RESOURCES.""AIT$CUSTOMF00092"" AS Rate, " &
                "CURR.CURR_DESC AS Currency, COUNTRIES.COUN_NAME AS Country, " &
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

        If RestrictBySourceLang.Checked And ComboBoxSourceLang.Text <> "-ALL-" Then
            sql &= "AND (RESOURCES.""AIT$CUSTOMF00068"" = '" & ComboBoxSourceLang.Text & "')"
        End If
        If RestrictByTargetLang.Checked And ComboBoxTargetLang.Text <> "-ALL-" Then
            sql &= "AND ((RESOURCES.""AIT$CUSTOMF00069"" = '" & ComboBoxTargetLang.Text & "') OR (RESOURCES.""AIT$CUSTOMF00074"" = '" & ComboBoxTargetLang.Text & "')) "
        End If
        If RestrictByService.Checked And ComboBoxServices.Text <> "-ALL-" Then
            sql &= "AND (""AIT$CUSTOMF00094"" = '" & ComboBoxServices.Text & "') "
        End If
        If RestrictByDomain.Checked And ComboBoxDomains.Text <> "-ALL-" Then
            sql &= "AND ((RESOURCES.""AIT$CUSTOMF00103"" CONTAINING '" & ComboBoxDomains.Text & "') OR (RESOURCES.""AIT$CUSTOMF00104"" CONTAINING '" & ComboBoxDomains.Text & "') OR (RESOURCES.""AIT$CUSTOMF00105"" CONTAINING '" & ComboBoxDomains.Text & "')) "
        End If
        If RestrictByTools.Checked And TextBoxTools.Text <> "" And TextBoxTools.Text <> "-ALL-" Then
            sql &= "AND (UPPER(RESOURCES.""AIT$CUSTOMF00067"") LIKE UPPER('%" & TextBoxTools.Text & "%')) "
        End If

        command.Connection = FreelancersTableAdapter.Connection
        command.CommandText = sql
        command.CommandType = Global.System.Data.CommandType.Text

        FreelancersTableAdapter.Adapter.SelectCommand = command

        If (FreelancersTableAdapter.ClearBeforeFill = True) Then
            DataSet2.DataTableFreelancers.Clear()
        End If
        Try
            ret = FreelancersTableAdapter.Adapter.Fill(DataSet2.DataTableFreelancers)

        Catch ex As Exception
            Return
        Finally
            command.Dispose()
        End Try



        'If RestrictBySourceLang.Checked And ComboBoxSourceLang.Text <> "-ALL-" Then
        'If RestrictByTargetLang.Checked And ComboBoxTargetLang.Text <> "-ALL-" Then
        'ret = FreelancersTableAdapter.FillBySourceAndTargetLang(Me.DataSet2.DataTableFreelancers, ComboBoxSourceLang.Text, ComboBoxTargetLang.Text)
        'Else
        'ret = FreelancersTableAdapter.FillBySourceLang(Me.DataSet2.DataTableFreelancers, ComboBoxSourceLang.Text)
        'End If
        'Else
        'If RestrictByTargetLang.Checked And ComboBoxTargetLang.Text <> "-ALL-" Then
        'ret = FreelancersTableAdapter.FillByTargetLang(Me.DataSet2.DataTableFreelancers, ComboBoxTargetLang.Text)
        'Else
        'ret = FreelancersTableAdapter.Fill(Me.DataSet2.DataTableFreelancers)
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
                TargetLangTableAdapter.FillBySourceLanguage(Me.DataSet2.DataTableTargetLang, ComboBoxSourceLang.Text)
            Else
                TargetLangTableAdapter.Fill(Me.DataSet2.DataTableTargetLang)
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

    Private Sub RestrictByCheckedChanged(sender As System.Object, e As System.EventArgs) Handles RestrictByTools.CheckedChanged, RestrictByTargetLang.CheckedChanged, RestrictBySourceLang.CheckedChanged, RestrictByService.CheckedChanged, RestrictByDomain.CheckedChanged
        FillFreelancersTable()
    End Sub

    Private Sub DataGridView1_CellMouseDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        'MessageBox.Show("Double clicked")
        Dim ID As Integer
        'Dim a As String

        Try
            ID = CInt(DataGridView1.CurrentRow.Cells(0).Value) 'this is the ID
            FreelancerInfoTableAdapter.FillByResid(Me.DataSet2.DTFreelancerInfo, ID)
            TADetails.Fill(Me.DataSet2.DTDetails, ID)
            CatToolsTableAdapter.FillByResID(Me.DataSet2.CatTools, ID)
        Catch ex As Exception
            MessageBox.Show("There was an error!" & Environment.NewLine & Environment.NewLine &
                            """" & ex.Message & """" & Environment.NewLine & Environment.NewLine &
                            "Sorry!",
                            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
                            )
        End Try

        ' DataSet2.DTFreelancerInfo = FreelancerInfoTableAdapter.GetDataByResid(ID)
        'a = DTFreelancerInfoBindingSource.ToString()
        TabControl1.SelectedIndex = 1
        'TabDetails.Show()

        'Me.FreelancersTableAdapter.
        'Me.DetailsTableAdapter.FillByRES_ID('22')
        'Me.DetailsTableAdapter.FillByRES_ID(Me.DataSet2.DataTableDetails, CInt(Me.Tag))



        'DialogDetails.Tag = DataGridView1.CurrentRow.Cells(0).Value
        'DialogDetails.ShowDialog()

        'FormDetails.TADetails.Fill(FormDetails.DTDetailsBindingSource.



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
        RichTextBoxConnectionString.Text = connstr

        Try
            'DataSet2.Clear()

            FreelancersTableAdapter.Connection.ConnectionString = connstr
            SourceLangTableAdapter.Connection.ConnectionString = connstr
            TargetLangTableAdapter.Connection.ConnectionString = connstr
            CatToolsTableAdapter.Connection.ConnectionString = connstr
            ServiceTableAdapter.Connection.ConnectionString = connstr
            DomainsTableAdapter.Connection.ConnectionString = connstr
            TADetails.Connection.ConnectionString = connstr
            FreelancerInfoTableAdapter.Connection.ConnectionString = connstr

            SourceLangTableAdapter.Fill(DataSet2.DataTableSourceLang)
            TargetLangTableAdapter.Fill(DataSet2.DataTableTargetLang)
            Me.ServiceTableAdapter.Fill(Me.DataSet2.DataTableService)
            'TODO: This line of code loads data into the 'DataSet2.DataTableDomains' table. You can move, or remove it, as needed.
            Me.DomainsTableAdapter.Fill(Me.DataSet2.DataTableDomains)
            CatToolsTableAdapter.Fill(Me.DataSet2.CatTools)

            'FreelancersTableAdapter.Fill(DataSet2.DataTableFreelancers)

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
            'DataSet2.cl()

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
        'StatusLed.Tag = True
    End Sub

    Private Sub FormMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Dim t As ada
        Me.Loaded = True

        StatusLed.BackColor = Color.Red
        RestrictBySourceLang.Checked = True
        RestrictByTargetLang.Checked = True
        RestrictBySourceLang.Enabled = True
        RestrictByTargetLang.Enabled = True

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

            'TODO: This line of code loads data into the 'DataSet2.DataTableTargetLang' table. You can move, or remove it, as needed.
            Me.TargetLangTableAdapter.Fill(Me.DataSet2.DataTableTargetLang)
            'TODO: This line of code loads data into the 'DataSet2.DataTableSourceLang' table. You can move, or remove it, as needed.
            Me.SourceLangTableAdapter.Fill(Me.DataSet2.DataTableSourceLang)
            'TODO: This line of code loads data into the 'DataSet2.DataTableFreelancers' table. You can move, or remove it, as needed.
            'TODO: This line of code loads data into the 'DataSet21.DataTableService' table. You can move, or remove it, as needed.
            Me.ServiceTableAdapter.Fill(Me.DataSet2.DataTableService)
            'TODO: This line of code loads data into the 'DataSet2.DataTableDomains' table. You can move, or remove it, as needed.
            Me.DomainsTableAdapter.Fill(Me.DataSet2.DataTableDomains)
            'Me.FreelancersTableAdapter.Fill(Me.DataSet2.DataTableFreelancers)
            'TODO: This line of code loads data into the 'DataSet2.DataTableService' table. You can move, or remove it, as needed.
            'Me.CatToolsTableAdapter.Fill(Me.DataSet2.CatTools)
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

    Private Sub ComboBoxTools_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBoxTools.KeyDown
        If e.KeyCode = Keys.Return Then
            FillFreelancersTable()
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        Dim a As String = DataGridView1.CurrentRow.Cells(1).Value.ToString
        If colName = "EmailButton" Then
            'Put you code here for this button click. You can tell which row it is on by
            'reading the RowIndex property from the event arg e.
            'DataGridView1.
            'MessageBox.Show(String.Format("You clicked the button: {0}", DataGridView1.CurrentRow.Cells(e.ColumnIndex).Value.ToString))
            SendEmail(DataGridView1.CurrentRow.Cells(e.ColumnIndex).Value.ToString)
        End If

    End Sub

    Private Sub ButtonSendEmail_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSendEmail.Click
        SendEmail(TextBoxEmailAddress.Text)
    End Sub

    Private Sub SendEmail(address As String)
        Try
            System.Diagnostics.Process.Start("mailto:" &
                                             address &
                                             "?Subject=" & EmailSubject.Text &
                                             "&Body=" & EmailBody.Text
                                             )
        Catch ex As Exception
            MessageBox.Show("There was an error!" & Environment.NewLine & Environment.NewLine &
                            """" & ex.Message & """",
                            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
                            )
        End Try

    End Sub
End Class
