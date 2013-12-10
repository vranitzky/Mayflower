﻿Public Class Form1
    Dim Filters As New List(Of String)
    Private Function MakeSQLFilter()
        Dim a As String = ""

        If Filters.Count = 0 Then Return ""
        For index = 0 To Filters.Count - 2
            a = a & (Filters(index) & " AND ")
        Next
        a = a & Filters(Filters.Count - 1)

        Return a
    End Function

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        StatusLed.Tag = False
        StatusLed.BackColor = Color.Red
        Try
            'TODO: This line of code loads data into the 'DataSet2.DataTableTargetLang' table. You can move, or remove it, as needed.
            Me.TargetLangTableAdapter.Fill(Me.DataSet2.DataTableTargetLang)
            'TODO: This line of code loads data into the 'DataSet2.DataTableSourceLang' table. You can move, or remove it, as needed.
            Me.SourceLangTableAdapter.Fill(Me.DataSet2.DataTableSourceLang)
            'TODO: This line of code loads data into the 'DataSet2.DataTableFreelancers' table. You can move, or remove it, as needed.
            Me.FreelancersTableAdapter.Fill(Me.DataSet2.DataTableFreelancers)
            StatusLed.BackColor = Color.Green
        Catch ex As Exception
            '"Failed to connect to database: " & Environment.NewLine &
            MessageBox.Show(
                            ex.Message & Environment.NewLine &
                            "Please set up parameters.",
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

    Private Sub ComboBoxSourceLang_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxSourceLang.SelectedIndexChanged
        'DataTablePeopleBindingSource.Filter = "SOURCELANG='" + ComboBoxSourceLang.Text + "'"
        Dim a As String = ""
        ' = """" + "AIT$CUSTOMF00068""='" + ComboBoxSourceLang.Text + "'"
        'a = Chr(34) + "AIT$CUSTOMF00068" + Chr(34) + " = 'English'"
        'a = "(NOT (""AIT$CUSTOMF00069"" IS NULL)) AND (""AIT$CUSTOMF00068"" = 'English')"
        'a = "(" + Chr(34) + "RES_ID" + Chr(34) + " = '1088')"
        'DataTableTargetLangBindingSource.Filter = a '"(""AIT$CUSTOMF00068"" = 'English')"
        'DataTableTargetLangTableAdapter.FillBy(DataSet1.DataTableTargetLang, "English")
        Filters.Clear()
        Filters.Add("(SOURCELANG='" + ComboBoxSourceLang.Text + "')")
        Filters.Add("(TARGETLANG1='" + ComboBoxTargetLang.Text + "')")
        'For index = 0 To Filters.Count - 2
        'a = a & (Filters(index) & " AND ")
        'Next
        'a = a & Filters(Filters.Count - 1)
        a = MakeSQLFilter()
        BindingSourceTargetLang.Filter = " (SOURCELANG = '" + ComboBoxSourceLang.Text + "')"
        BindingSourceFreelancers.Filter = "(SOURCELANG='" + ComboBoxSourceLang.Text + "') AND (TARGETLANG1='" + ComboBoxTargetLang.Text + "')"
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub ComboBoxTargetLang_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxTargetLang.SelectedIndexChanged
        BindingSourceFreelancers.Filter = "(SOURCELANG='" + ComboBoxSourceLang.Text + "') AND (TARGETLANG1='" + ComboBoxTargetLang.Text + "')"
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            TextBoxPassword.UseSystemPasswordChar = False
            'PasswordChar = ""
        Else
            TextBoxPassword.UseSystemPasswordChar = True
        End If

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
        If ok Then StatusLed.BackColor = Color.Green

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
        StatusLed.Tag = True
    End Sub

End Class
