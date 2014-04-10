
Namespace My

    'This class allows you to handle specific events on the settings class:
    ' The SettingChanging event is raised before a setting's value is changed.
    ' The PropertyChanged event is raised after a setting's value is changed.
    ' The SettingsLoaded event is raised after the setting values are loaded.
    ' The SettingsSaving event is raised before the setting values are saved.
    Partial Friend NotInheritable Class MySettings
        Private Sub MySettings_PropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs) Handles Me.PropertyChanged
            If e.PropertyName = "ProjetexDB" Then
                Me("ProjetexDB2") = Me("ProjetexDB")
            End If
        End Sub

        Private Sub MySettings_SettingsLoaded(ByVal sender As Object, ByVal e As System.Configuration.SettingsLoadedEventArgs) Handles Me.SettingsLoaded
            Dim conn, a As String

            conn = "User=ODBC;" +
    "Password=" + My.Settings.DBPassword + ";" +
    "Database=" + My.Settings.DBFile + ";" +
    "DataSource=" + My.Settings.DBAddress + ";" +
    "Port=" + My.Settings.DBPort + ";" +
    "Dialect=3;" +
    "Charset=UTF8;" +
    "Role=PROJETEX_ODBC;" +
    "Connection lifetime=15;" +
    "Pooling=true;" +
    "MinPoolSize=0;" +
    "MaxPoolSize=50;" +
    "Packet Size=8192;" +
    "ServerType=0"

            'My.Settings.ProjetexDB = conn
            a = Me("ProjetexDB2").ToString
            'MessageBox.Show("Current ProjetexDB2: " & a)
            Me("ProjetexDB2") = Me("ProjetexDB")
        End Sub
    End Class
End Namespace
