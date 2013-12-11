Public Class FormMain
    Dim Filters As New List(Of String)
    Private Sub FillFreelancersTable()
        Dim ret As Integer = 0
        Dim foundstr As String

        Me.Cursor = Cursors.AppStarting
        If RestrictBySourceLang.Checked Then
            If RestrictByTargetLang.Checked Then
                ret = FreelancersTableAdapter.FillBySourceAndTargetLang(Me.DataSet2.DataTableFreelancers, ComboBoxSourceLang.Text, ComboBoxTargetLang.Text)
            Else
                ret = FreelancersTableAdapter.FillBySourceLang(Me.DataSet2.DataTableFreelancers, ComboBoxSourceLang.Text)
            End If
        Else
            If RestrictByTargetLang.Checked Then
                ret = FreelancersTableAdapter.FillByTargetLang(Me.DataSet2.DataTableFreelancers, ComboBoxTargetLang.Text)
            Else
                ret = FreelancersTableAdapter.Fill(Me.DataSet2.DataTableFreelancers)
            End If
        End If
        foundstr = "Found " & ret.ToString & " record"
        If ret <> 1 Then foundstr &= "s"
        LabelRecordsFound.Text = foundstr
        Me.Cursor = Cursors.Default
    End Sub


    Private Function MakeSQLFilter()
        Dim a As String = ""

        If Filters.Count = 0 Then Return ""
        For index = 0 To Filters.Count - 2
            a = a & (Filters(index) & " AND ")
        Next
        a = a & Filters(Filters.Count - 1)

        Return a
    End Function

    Private Sub ComboBoxSourceLang_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxSourceLang.SelectedIndexChanged
        'BindingSourceTargetLang.Filter = " (SOURCELANG = '" + ComboBoxSourceLang.Text + "')"
        'Dim dt As DataTable
        'dt = TargetLangTableAdapter.GetDataBySourceLanguage(ComboBoxSourceLang.Text)

        TargetLangTableAdapter.FillBySourceLanguage(Me.DataSet2.DataTableTargetLang, ComboBoxSourceLang.Text)
        ''BindingSourceFreelancers.Filter = "(SOURCELANG='" + ComboBoxSourceLang.Text + "') AND (TARGETLANG1='" + ComboBoxTargetLang.Text + "')"

        FillFreelancersTable()

        'If RestrictByTargetLang.Checked Then
        'FreelancersTableAdapter.FillBySourceAndTargetLang(Me.DataSet2.DataTableFreelancers, ComboBoxSourceLang.Text, ComboBoxTargetLang.Text)
        'Else
        'FreelancersTableAdapter.FillBySourceLang(Me.DataSet2.DataTableFreelancers, ComboBoxSourceLang.Text)
        'End If
    End Sub

    Private Sub ComboBoxTargetLang_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxTargetLang.SelectedIndexChanged
        'BindingSourceFreelancers.Filter = "(SOURCELANG='" + ComboBoxSourceLang.Text + "') AND (TARGETLANG1='" + ComboBoxTargetLang.Text + "')"
        FillFreelancersTable()

        'If RestrictByTargetLang.Checked Then
        'FreelancersTableAdapter.FillBySourceAndTargetLang(Me.DataSet2.DataTableFreelancers, ComboBoxSourceLang.Text, ComboBoxTargetLang.Text)
        'Else
        'FreelancersTableAdapter.FillBySourceLang(Me.DataSet2.DataTableFreelancers, ComboBoxSourceLang.Text)
        'End If
        'FreelancersTableAdapter.FillBySourceAndTargetLang(Me.DataSet2.DataTableFreelancers, ComboBoxSourceLang.Text, ComboBoxTargetLang.Text)
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
            DataSet2.Clear()
            FreelancersTableAdapter.Connection.ConnectionString = connstr
            SourceLangTableAdapter.Connection.ConnectionString = connstr
            TargetLangTableAdapter.Connection.ConnectionString = connstr

            SourceLangTableAdapter.Fill(DataSet2.DataTableSourceLang)
            TargetLangTableAdapter.Fill(DataSet2.DataTableTargetLang)
            FreelancersTableAdapter.Fill(DataSet2.DataTableFreelancers)

        Catch ex As Exception
            'MessageBox.Show("Failed to connect to data source: \r\n" & ex.Message)
            ok = False
            StatusLed.BackColor = Color.Red
            'Finally
            'conn.Close()
        End Try
        If ok Then
            StatusLed.BackColor = Color.Green
            My.Settings.ProjetexDB = connstr
        End If


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
            'MessageBox.Show("Failed to connect to data source: " & ex.Message)
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
        StatusLed.BackColor = Color.Red
        RestrictBySourceLang.Checked = True
        RestrictByTargetLang.Checked = True
        RestrictBySourceLang.Enabled = True
        RestrictByTargetLang.Enabled = True

        Try
            FreelancersTableAdapter.Connection.ConnectionString = My.Settings.ProjetexDB
            SourceLangTableAdapter.Connection.ConnectionString = My.Settings.ProjetexDB
            TargetLangTableAdapter.Connection.ConnectionString = My.Settings.ProjetexDB
            AIT_USERSTableAdapter.Connection.ConnectionString = My.Settings.ProjetexDB

            'TODO: This line of code loads data into the 'DataSet2.DataTableTargetLang' table. You can move, or remove it, as needed.
            Me.TargetLangTableAdapter.Fill(Me.DataSet2.DataTableTargetLang)
            'TODO: This line of code loads data into the 'DataSet2.DataTableSourceLang' table. You can move, or remove it, as needed.
            Me.SourceLangTableAdapter.Fill(Me.DataSet2.DataTableSourceLang)
            'TODO: This line of code loads data into the 'DataSet2.DataTableFreelancers' table. You can move, or remove it, as needed.
            'Me.FreelancersTableAdapter.Fill(Me.DataSet2.DataTableFreelancers)
            'TODO: This line of code loads data into the 'DataSet2._AIT_USERS' table. You can move, or remove it, as needed.
            Me.AIT_USERSTableAdapter.Fill(Me.DataSet2._AIT_USERS)

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
            TabControl1.SelectedTab = TabPage2
            'TabPage1.
            '        Finally
            '            FbConnection1.Close()
        End Try


    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox3.CheckedChanged

        TextBoxPassword.UseSystemPasswordChar = Not CheckBox3.Checked

    End Sub


    Private Sub RestrictByLang_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RestrictByTargetLang.CheckedChanged, RestrictBySourceLang.CheckedChanged
        FillFreelancersTable()

        'If RestrictByTargetLang.Checked Then
        'FreelancersTableAdapter.FillBySourceAndTargetLang(Me.DataSet2.DataTableFreelancers, ComboBoxSourceLang.Text, ComboBoxTargetLang.Text)
        'Else
        'FreelancersTableAdapter.FillBySourceLang(Me.DataSet2.DataTableFreelancers, ComboBoxSourceLang.Text)
        'End If
    End Sub

End Class
