Public Class BeGlobalMainForm
    'Private Languages As SortedDictionary(Of String, ArrayList)
    'Private AllFromLanguagesAvailable As SortedDictionary(Of String, String)
    Private LanguagesQ As New SortedDictionary(Of String, SortedDictionary(Of String, ArrayList))
    Private AllFromLanguagesAvailableQ As New SortedDictionary(Of String, SortedDictionary(Of String, String))

    Public Function getLanguageListFromSDL() As Object
        ' curl -H "Authorization: BeGlobal apiKey=BeGlobalAPIKey" https://api.beglobal.com/languages 
        Dim data, response As String
        Dim bytes As Byte()
        Dim chars As Char()
        Dim webRequest As HttpWebRequest ' = HttpWebRequest.Create("http://localhost:80/tra")
        Dim webResponse As HttpWebResponse
        Dim cl As New HttpClient
        Dim requestWriter As System.IO.StreamWriter
        Dim serializer As New System.Web.Script.Serialization.JavaScriptSerializer
        Dim responseReader As System.IO.StreamReader

        'send a POST request
        webRequest = HttpWebRequest.Create("https://api.beglobal.com/languages")
        webRequest.Method = "GET"
        'webRequest.ContentType = "application/json"
        'CType(request, HttpWebRequest).UserAgent = ".NET Framework Example Client"
        webRequest.UserAgent = "API Testing 0.1"
        webRequest.Accept = "*/*"
        webRequest.Headers.Add("Authorization: BeGlobal apiKey=27fLF6xJlm3y%2FCjWXeg%2FMg%3D%3D")
        webRequest.KeepAlive = False

        webResponse = webRequest.GetResponse
        responseReader = New System.IO.StreamReader(webResponse.GetResponseStream)
        response = responseReader.ReadToEnd
        responseReader.Close()

        Return serializer.DeserializeObject(response)
    End Function

    Public Function sendPOSTRequest(ByVal req As System.Collections.Generic.Dictionary(Of String, String)) As System.Collections.Generic.Dictionary(Of String, String)
        Dim data, response As String
        Dim bytes As Byte()
        Dim chars As Char()
        Dim webRequest As HttpWebRequest ' = HttpWebRequest.Create("http://localhost:80/tra")
        Dim webResponse As HttpWebResponse
        Dim cl As New HttpClient
        Dim requestWriter As System.IO.StreamWriter
        Dim serializer As New System.Web.Script.Serialization.JavaScriptSerializer
        Dim responseReader As System.IO.StreamReader

        'send a POST request
        webRequest = HttpWebRequest.Create("https://api.beglobal.com/translate")
        'webRequest = HttpWebRequest.Create("http://localhost/trans")
        webRequest.Method = "POST"
        webRequest.ContentType = "application/json"
        'CType(request, HttpWebRequest).UserAgent = ".NET Framework Example Client"
        webRequest.UserAgent = "API Testing 0.1"
        webRequest.Accept = "*/*"
        webRequest.Headers.Add("Authorization: BeGlobal apiKey=27fLF6xJlm3y%2FCjWXeg%2FMg%3D%3D")
        webRequest.KeepAlive = False
        'webRequest.
        'For Each line In SourceText.Lines
        '
        'Next

        data = serializer.Serialize(req)
        bytes = Encoding.UTF8.GetBytes(data)
        chars = Encoding.UTF8.GetChars(bytes)
        'encodedData = System.Web.HttpUtility.UrlEncode(data)
        'webRequest.ContentLength = 58 'chars.Count
        'datastream = request.GetRequestStream
        requestWriter = New System.IO.StreamWriter(webRequest.GetRequestStream(), System.Text.Encoding.UTF8)
        'requestWriter.Write(encodedData)
        requestWriter.Write(chars, 0, chars.Length)
        requestWriter.Close()

        webResponse = webRequest.GetResponse
        responseReader = New System.IO.StreamReader(webResponse.GetResponseStream)
        response = responseReader.ReadToEnd
        responseReader.Close()

        ServerSays.Text = response

        Return serializer.Deserialize(Of System.Collections.Generic.Dictionary(Of String, String))(response)

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim o As New System.Collections.Generic.Dictionary(Of String, String)

        Try
            Me.Cursor = Cursors.WaitCursor
            If APIKey.TextLength = 0 Then Throw New System.Exception("No API key!")
            If SourceText.TextLength = 0 Then Throw New System.Exception("No source text!")
            'If SourceCombo.SelectedText.Length = 0 Then Throw New System.Exception("No source language selected!")
            'If TargetCombo.SelectedText.Length = 0 Then Throw New System.Exception("No target language selected!")

            o("text") = System.Web.HttpUtility.UrlEncode(SourceText.Text, System.Text.Encoding.UTF8)
            o("from") = SourceCombo.SelectedValue.ToString
            o("to") = TargetCombo.SelectedValue.ToString
            'data = "{""text"":""" + System.Web.HttpUtility.UrlEncode(SourceText.Text, System.Text.Encoding.UTF8) + """, ""from"":"""
            'data += SourceCombo.SelectedValue.ToString
            'data += """, ""to"":"""
            'data += TargetCombo.SelectedValue.ToString
            'data += """}"
            TargetText.Text = sendPOSTRequest(o)("translation")
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
        Dim QualityList As New ArrayList()

        Me.Cursor = Cursors.WaitCursor

        Dim o As Object
        Dim a As System.Collections.Generic.KeyValuePair(Of String, Object)
        Dim oarr1 As Object()
        Dim dictsourcelangs As New SortedDictionary(Of String, String)
        Dim sd As New SortedDictionary(Of String, LanguageDesc)


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

 
        'AllFromLanguagesAvailable = New Collections.Generic.SortedDictionary(Of String, String)
        'Languages = New Collections.Generic.SortedDictionary(Of String, ArrayList)

        'AllFromLanguagesAvailableQ(0) = New SortedDictionary(Of String, String)
        'a.Add("eee") = o
        o = getLanguageListFromSDL()

        For Each a In o("languageExpertise")
            Dim Q As String = a.Key
            Dim Ql As String
            'AllFromLanguagesAvailableQ.(a.Key) = New Collections.Generic.SortedDictionary(Of String, String)
            'machine translation 'Q1', standard 'Q3', verified 'Q4' and specialized 'Q5'
            If Q(0) = "Q" Then
                Select Q
                    Case "Q1"
                        Ql = "Machine"
                    Case "Q3"
                        Ql = "Standard"
                    Case "Q4"
                        Ql = "Verified"
                    Case "Q5"
                        Ql = "Specialised"
                    Case Else
                        Ql = "?"
                End Select
                Ql = Q + "-" + Ql
                QualityList.Add(New LanguageDesc(Ql, Q))
                AllFromLanguagesAvailableQ.Add(Q, New Collections.Generic.SortedDictionary(Of String, String))
                LanguagesQ.Add(Q, New Collections.Generic.SortedDictionary(Of String, ArrayList))
                oarr1 = a.Value

                For Each item As Dictionary(Of String, Object) In oarr1
                    Dim pair, langFrom, langTo As Dictionary(Of String, Object)

                    pair = item("languagePair")
                    langFrom = pair("from")
                    langTo = pair("to")

                    Log.AppendText("Found language pair: " +
                           langFrom("fullName") + " " + a.Key + " (" + langFrom("code") + ")" +
                           "-->" +
                           langTo("name") + " (" + langTo("code") + ")" + vbNewLine) ' + b.Value.ToString)

                    'If Not AllFromLanguagesAvailable.ContainsKey(langFrom("code")) Then
                    'AllFromLanguagesAvailable(langFrom("code")) = langFrom("fullName")
                    'End If
                    If Not AllFromLanguagesAvailableQ(Q).ContainsKey(langFrom("code")) Then
                        AllFromLanguagesAvailableQ(Q)(langFrom("code")) = langFrom("fullName")
                    End If

                    'If Not Languages.ContainsKey(langFrom("code")) Then
                    'Languages(langFrom("code")) = New ArrayList
                    'End If
                    'Languages(langFrom("code")).Add(New LanguageDesc(langTo("fullName"), langTo("code")))
                    If Not LanguagesQ(Q).ContainsKey(langFrom("code")) Then
                        LanguagesQ(Q)(langFrom("code")) = New ArrayList
                    End If
                    LanguagesQ(Q)(langFrom("code")).Add(New LanguageDesc(langTo("fullName"), langTo("code")))

                Next
                For Each item In LanguagesQ(Q)
                    item.Value.Sort()
                Next
                ' now we build the arrays for the listboxes
                'For Each x In AllFromLanguagesAvailable
                'Dim lf As New LanguageDesc(x.Value, x.Key)
                'SourceLanguages.Add(lf)
                'Next
            End If
        Next

        QualityList.Sort()
        QualityCombo.DataSource = QualityList
        QualityCombo.DisplayMember = "LongName"
        QualityCombo.ValueMember = "ShortName"

        Log.AppendText(vbNewLine + "You may close this window now.")
        Me.Cursor = Me.DefaultCursor

    End Sub

    Private Sub SourceCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SourceCombo.SelectedIndexChanged
        ' Dim TargetLanguages As New ArrayList()

        'For Each x In LanguagesQ(CType(QualityCombo.SelectedItem, LanguageDesc).ShortName)
        ' Dim lf As New LanguageDesc(x.Value, x.Key)
        'TargetLanguages.Add(lf)
        'Next

        TargetCombo.DataSource = LanguagesQ(CType(QualityCombo.SelectedItem, LanguageDesc).ShortName)(CType(SourceCombo.SelectedItem, LanguageDesc).ShortName)
        TargetCombo.DisplayMember = "LongName"
        TargetCombo.ValueMember = "ShortName"
        TargetCombo.SelectedIndex = 0

        'TargetCombo.DataSource = Languages(SourceCombo.SelectedItem)
    End Sub

    Private Sub QualityCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles QualityCombo.SelectedIndexChanged
        ' if the quality changes, we must change source listbox (which will change target itself via event)
        Dim SourceLanguages, TargetLanguages As New ArrayList()

        ' now we build the arrays for the target listbox
        'For Each x In AllFromLanguagesAvailableQ(QualityCombo.SelectedItem)
        For Each x In AllFromLanguagesAvailableQ(CType(QualityCombo.SelectedItem, LanguageDesc).ShortName)
            Dim lf As New LanguageDesc(x.Value, x.Key)
            SourceLanguages.Add(lf)
        Next

        SourceCombo.DataSource = SourceLanguages
        SourceCombo.DisplayMember = "LongName"
        SourceCombo.ValueMember = "ShortName"
        SourceCombo.SelectedIndex = 0


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
