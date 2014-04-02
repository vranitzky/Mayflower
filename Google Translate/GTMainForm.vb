Imports System.Globalization
Public Class GTMainForm

    Public Function getLanguageListFromGoogle() As Object
        Dim response As String
        Dim webRequest As HttpWebRequest
        Dim webResponse As HttpWebResponse
        Dim cl As New HttpClient
        Dim serializer As New System.Web.Script.Serialization.JavaScriptSerializer
        Dim responseReader As System.IO.StreamReader

        'send a POST request
        webRequest = HttpWebRequest.Create("https://www.googleapis.com/language/translate/v2/languages?key=" + APIKey.Text)
        webRequest.Method = "GET"
        webRequest.UserAgent = "API Testing 0.1"
        webRequest.Accept = "*/*"
        webRequest.KeepAlive = False

        webResponse = webRequest.GetResponse
        responseReader = New System.IO.StreamReader(webResponse.GetResponseStream)
        response = responseReader.ReadToEnd
        responseReader.Close()

        Return serializer.DeserializeObject(response)
    End Function

    Public Function sendGETRequest(ByVal req As System.Collections.Generic.Dictionary(Of String, String)) As System.Collections.Generic.Dictionary(Of String, String)
        Dim data, response As String
        Dim bytes As Byte()
        Dim chars As Char()
        Dim webRequest As HttpWebRequest ' = HttpWebRequest.Create("http://localhost:80/tra")
        Dim webResponse As HttpWebResponse
        Dim cl As New HttpClient
        Dim requestWriter As System.IO.StreamWriter
        Dim serializer As New System.Web.Script.Serialization.JavaScriptSerializer
        Dim responseReader As System.IO.StreamReader

        'GET https://www.googleapis.com/language/translate/v2?key=INSERT-YOUR-KEY&source=en&target=de&q=Hello%20world
        webRequest = HttpWebRequest.Create(
            "https://www.googleapis.com/language/translate/v2?" +
            "key=" + req("key") +
            "&source=" + req("source") +
            "&target=" + req("target") +
            "&q=" + req("q")
        )
        'System.Net.WebRequest.
        'webRequest = HttpWebRequest.Create("http://localhost/trans")
        webRequest.Method = "GET"
        webRequest.ContentType = "application/json"
        'CType(request, HttpWebRequest).UserAgent = ".NET Framework Example Client"
        webRequest.UserAgent = "API Testing 0.1"
        webRequest.Accept = "*/*"
        'webRequest.Headers.Add("Authorization: BeGlobal apiKey=27fLF6xJlm3y%2FCjWXeg%2FMg%3D%3D")
        webRequest.KeepAlive = False
        'webRequest.
        'For Each line In SourceText.Lines
        '
        'Next

        'data = serializer.Serialize(req)
        'bytes = Encoding.UTF8.GetBytes(data)
        'chars = Encoding.UTF8.GetChars(bytes)
        ''encodedData = System.Web.HttpUtility.UrlEncode(data)
        ''webRequest.ContentLength = 58 'chars.Count
        ''datastream = request.GetRequestStream
        'requestWriter = New System.IO.StreamWriter(webRequest.GetRequestStream(), System.Text.Encoding.UTF8)
        ''requestWriter.Write(encodedData)
        'requestWriter.Write(chars, 0, chars.Length)
        'requestWriter.Close()

        Try
            webResponse = webRequest.GetResponse
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            ServerSays.Text = response
        End Try
        responseReader = New System.IO.StreamReader(webResponse.GetResponseStream)
        response = responseReader.ReadToEnd
        responseReader.Close()
        Return serializer.Deserialize(Of System.Collections.Generic.Dictionary(Of String, String))(response)

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim g As New Google.Apis.Translate.v2.LanguagesResource.ListRequest()

        Dim o As New System.Collections.Generic.Dictionary(Of String, String)

        Try
            Me.Cursor = Cursors.WaitCursor
            If APIKey.TextLength = 0 Then Throw New System.Exception("No API key!")
            If SourceText.TextLength = 0 Then Throw New System.Exception("No source text!")
            'If SourceCombo.SelectedText.Length = 0 Then Throw New System.Exception("No source language selected!")
            'If TargetCombo.SelectedText.Length = 0 Then Throw New System.Exception("No target language selected!")

            o("q") = System.Web.HttpUtility.UrlEncode(SourceText.Text, System.Text.Encoding.UTF8)
            o("source") = SourceCombo.SelectedValue.ToString
            o("target") = TargetCombo.SelectedValue.ToString
            o("key") = APIKey.Text
            'data = "{""text"":""" + System.Web.HttpUtility.UrlEncode(SourceText.Text, System.Text.Encoding.UTF8) + """, ""from"":"""
            'data += SourceCombo.SelectedValue.ToString
            'data += """, ""to"":"""
            'data += TargetCombo.SelectedValue.ToString
            'data += """}"
            TargetText.Text = sendGETRequest(o)("translation")
            'o = serializer.DeserializeObject(response)
            'TargetText.Text = o("translation")

            'Dim pattern As String = ".*translation"":""([^""]*)"".*"  ' "\b(\w+)\s\1\b"
            'Dim rgx As New Regex(pattern, RegexOptions.IgnoreCase)

            'Dim match As Match = rgx.Match(response)
            'Do While match.Success
            ' TargetText.Text = Match.Groups.Item(1).Value
            '
            '            Match = Match.NextMatch()
            '           Loop
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Me.Cursor = Me.DefaultCursor
    End Sub

    Private Sub BeGlobalMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate the list box using an array as DataSource. 
        Me.Cursor = Cursors.WaitCursor

        Dim o As Object
        Dim s As String
        Dim f As New Form()
        With f
            .Width = 600
            .Height = 600
            .Text = "Retrieving list of languages..."
        End With
        Dim Log As New RichTextBox
        With Log
            .Dock = DockStyle.Fill
            '.Location = (20,20)
        End With
        'AddHandler MyTextbox.TextChanged, AddressOf MyTextbox_TextChanged
        f.Controls.Add(Log)
        f.Show(Me)

        Log.AppendText("Retrieving list of languages... " + vbNewLine)
        Log.Refresh()

        Dim SourceLanguages, TargetLanguages As New ArrayList()
        Dim cultures() As CultureInfo = CultureInfo.GetCultures(CultureTypes.AllCultures)

        o = getLanguageListFromGoogle()
        Dim o2 = o("data")
        For Each item In o2("languages")
            For Each c In cultures
                If c.TwoLetterISOLanguageName = item("language") Then
                    Dim lf As New LanguageDesc(c.EnglishName, item("language"))
                    SourceLanguages.Add(lf)
                    TargetLanguages.Add(lf)
                    Log.AppendText("Found language: " +
                          lf.ShortName + " - " + lf.LongName + vbNewLine) ' + b.Value.ToString)
                    Exit For
                End If
            Next

        Next
        TargetCombo.DataSource = TargetLanguages
        TargetCombo.DisplayMember = "LongName"
        TargetCombo.ValueMember = "ShortName"
        TargetCombo.SelectedIndex = 0
        SourceCombo.DataSource = SourceLanguages
        SourceCombo.DisplayMember = "LongName"
        SourceCombo.ValueMember = "ShortName"
        SourceCombo.SelectedIndex = 0

        Log.AppendText(vbNewLine + "You may close this window now.")
        Me.Cursor = Me.DefaultCursor

    End Sub

   
    Private Sub SourceCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SourceCombo.SelectedIndexChanged
        ' Dim TargetLanguages As New ArrayList()

        'For Each x In LanguagesQ(CType(QualityCombo.SelectedItem, LanguageDesc).ShortName)
        ' Dim lf As New LanguageDesc(x.Value, x.Key)
        'TargetLanguages.Add(lf)
        'Next

        'TargetCombo.DataSource = LanguagesQ(CType(QualityCombo.SelectedItem, LanguageDesc).ShortName)(CType(SourceCombo.SelectedItem, LanguageDesc).ShortName)
        'TargetCombo.DisplayMember = "LongName"
        'TargetCombo.ValueMember = "ShortName"
        'TargetCombo.SelectedIndex = 0

        'TargetCombo.DataSource = Languages(SourceCombo.SelectedItem)
    End Sub

    Private Sub QualityCombo_SelectedIndexChanged(sender As Object, e As EventArgs)
        ' if the quality changes, we must change source listbox (which will change target itself via event)
        Dim SourceLanguages, TargetLanguages As New ArrayList()

        ' now we build the arrays for the target listbox
        'For Each x In AllFromLanguagesAvailableQ(CType(QualityCombo.SelectedItem, LanguageDesc).ShortName)
        'Dim lf As New LanguageDesc(x.Value, x.Key)
        'SourceLanguages.Add(lf)
        'Next

        'SourceCombo.DataSource = SourceLanguages
        'SourceCombo.DisplayMember = "LongName"
        'SourceCombo.ValueMember = "ShortName"
        'SourceCombo.SelectedIndex = 0


    End Sub
End Class
Public Class LanguageDesc
    Implements IComparable

    Private myShortName As String
    Private myLongName As String

    Public Sub New(ByVal strLongName As String, ByVal strShortName As String)
        Me.myShortName = strShortName
        Me.myLongName = strLongName
    End Sub 'New

    Public ReadOnly Property ShortName() As String
        Get
            Return myShortName
        End Get
    End Property

    Public ReadOnly Property LongName() As String
        Get
            Return myLongName
        End Get
    End Property

    Public Overrides Function toString() As String
        Return myShortName
    End Function

    Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
        ' Dim other As CustomerInfo = DirectCast(obj, _
        'CustomerInfo)
        'Return Me.ID.CompareTo(other.ID)
        Dim other As LanguageDesc = DirectCast(obj, LanguageDesc)

        Return Me.myShortName.CompareTo(other.myShortName)
    End Function
End Class 'LanguagePair
