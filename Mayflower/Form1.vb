Public Class Form1
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
        'TODO: This line of code loads data into the 'DataSet1.DataTablePeople' table. You can move, or remove it, as needed.
        '        Me.DataTablePeopleTableAdapter.Fill(Me.DataSet1.DataTablePeople)
        'TODO: This line of code loads data into the 'DataSet1.DataTableTargetLang' table. You can move, or remove it, as needed.
        '        Me.DataTableTargetLangTableAdapter.Fill(Me.DataSet1.DataTableTargetLang)
        'TODO: This line of code loads data into the 'DataSet1.DataTableSourceLang' table. You can move, or remove it, as needed.
        '       Me.DataTableSourceLangTableAdapter.Fill(Me.DataSet1.DataTableSourceLang)

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
        DataTablePeopleBindingSource.Filter = "(SOURCELANG='" + ComboBoxSourceLang.Text + "') AND (TARGETLANG1='" + ComboBoxTargetLang.Text + "')"
        DataTableTargetLangBindingSource.Filter = " (SOURCELANG = '" + ComboBoxSourceLang.Text + "')"
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub ComboBoxTargetLang_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxTargetLang.SelectedIndexChanged
        DataTablePeopleBindingSource.Filter = "(SOURCELANG='" + ComboBoxSourceLang.Text + "') AND (TARGETLANG1='" + ComboBoxTargetLang.Text + "')"
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            TextBoxPassword.PasswordChar = ""
        Else
            TextBoxPassword.PasswordChar = "*"
        End If

    End Sub

    Private Sub ButtonApplyDBSettings_Click(sender As System.Object, e As System.EventArgs) Handles ButtonApplyDBSettings.Click
        Dim DefConn As String = "Driver={Firebird/InterBase(r) driver};dbname=localhost/3050:C:\Projetex9\Projetex Server\Database\projetex.fdb;charset=UTF8;uid=ODBC;role=PROJETEX_ODBC;client=C:\Program Files (x86)\AIT\Firebird Server\bin\fbclient.dll"
        Dim connstr As String
        Dim a As System.Data.ConnectionState
        Dim ok As Boolean = True

        connstr = "Driver={Firebird/InterBase(r) driver};" +
            "dbname=" + TextBoxServerAddress.Text + "/" +
            TextBoxServerPort.Text + ":" +
            TextBoxDatabase.Text + ";" +
            "charset=UTF8;uid=ODBC;role=PROJETEX_ODBC;" +
            "password=" + TextBoxPassword.Text + ";" +
            "client=" + TextBoxDBLib.Text
        RichTextBoxConnectionString.Text = connstr

        'My.Settings.Properties.
        'DataSet1.
        'DataTablePeopleBindingSource

        Try
            DataSet1.Clear()
            DataTablePeopleTableAdapter.Connection.Close()
            DataTablePeopleTableAdapter.ConnectionString = connstr
            a = DataTablePeopleTableAdapter.Connection.State
            DataTablePeopleTableAdapter.Connection.Open()
            DataTablePeopleTableAdapter.Fill(Me.DataSet1.DataTablePeople)
            DataTableSourceLangTableAdapter.Connection.Close()
            DataTableSourceLangTableAdapter.Connection.ConnectionString = connstr
            DataTableSourceLangTableAdapter.Connection.Open()
            DataTableSourceLangTableAdapter.Fill(Me.DataSet1.DataTableSourceLang)
            DataTableTargetLangTableAdapter.Connection.Close()
            DataTableTargetLangTableAdapter.Connection.ConnectionString = connstr
            DataTableTargetLangTableAdapter.Connection.Open()
            DataTableTargetLangTableAdapter.Fill(Me.DataSet1.DataTableTargetLang)

        Catch ex As Exception
            MessageBox.Show("Failed to connect to data source: " & ex.Message)
            ok = False
            'Finally
            'conn.Close()
        End Try
        'DataTablePeopleTableAdapter.Connection.ConnectionString = connstr
        'DataTablePeopleTableAdapter.Connection.Open()
        'DataTableSourceLangTableAdapter.Connection.Close()
        'DataTableSourceLangTableAdapter.Connection.ConnectionString = connstr
        'DataTableSourceLangTableAdapter.Connection.Open()
        'DataTableTargetLangTableAdapter.Connection.Close()
        'DataTableTargetLangTableAdapter.Connection.ConnectionString = connstr
        'DataTableTargetLangTableAdapter.Connection.Open()


    End Sub

    Private Sub ButtonSelectLib_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSelectLib.Click
        OpenFileDialogSelectLib.InitialDirectory = Replace(TextBoxDBLib.Text, "fbclient.dll", "")
        If (OpenFileDialogSelectLib.ShowDialog()) Then
            TextBoxDBLib.Text = OpenFileDialogSelectLib.FileName
        End If

    End Sub

    Private Sub ButtonTestDBSettings_Click(sender As System.Object, e As System.EventArgs) Handles ButtonTestDBSettings.Click
        Dim connstr As String
        Dim conn As New Odbc.OdbcConnection
        Dim OK As Boolean = True

        connstr = "Driver={Firebird/InterBase(r) driver};" +
            "dbname=" + TextBoxServerAddress.Text + "/" +
            TextBoxServerPort.Text + ":" +
            TextBoxDatabase.Text + ";" +
            "charset=UTF8;uid=ODBC;role=PROJETEX_ODBC;" +
            "password=" + TextBoxPassword.Text + ";" +
            "client=" + TextBoxDBLib.Text
        RichTextBoxConnectionString.Text = connstr

        conn.ConnectionString = connstr
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Failed to connect to data source: " & ex.Message)
            OK = False
        Finally
            conn.Close()
        End Try
        If (OK) Then MessageBox.Show("Succesfully connected")
    End Sub
End Class
