Imports System.Globalization
Public Class GTMainForm
    Const MAXREQUESTLENGTH As Integer = 5000
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

    Public Function sendGETRequest(ByVal req As System.Collections.Generic.Dictionary(Of String, String)) As Object ' System.Collections.Generic.Dictionary(Of String, String)
        Dim response, reqString As String
        Dim webRequest As HttpWebRequest ' = HttpWebRequest.Create("http://localhost:80/tra")
        Dim webResponse As HttpWebResponse
        Dim cl As New HttpClient
        Dim serializer As New System.Web.Script.Serialization.JavaScriptSerializer
        Dim responseReader As System.IO.StreamReader

        'If req("q").Length >= 5000 Then
        'Throw New Exception("Maximum 5000 characters per request, for now!")
        'End If
        'GET https://www.googleapis.com/language/translate/v2?key=INSERT-YOUR-KEY&source=en&target=de&q=Hello%20world
        reqString =
            "https://www.googleapis.com/language/translate/v2?" +
            "key=" + req("key")
        If req.ContainsKey("source") Then
            reqString &= "&source=" + req("source")
        End If
        reqString &= "&target=" + req("target")
        reqString &= "&q=" + System.Web.HttpUtility.UrlEncode(req("q"), System.Text.Encoding.UTF8)
        webRequest = HttpWebRequest.Create(reqString)
        webRequest.Method = "GET"
        'webRequest.ContentType = "application/json"
        webRequest.UserAgent = "API Testing 0.1"
        webRequest.Accept = "*/*"
        webRequest.KeepAlive = False
        'For Each line In SourceText.Lines
        '
        'Next

        webResponse = webRequest.GetResponse
        responseReader = New System.IO.StreamReader(webResponse.GetResponseStream)
        response = responseReader.ReadToEnd
        responseReader.Close()
        Dim temp As New Object
        Try
            temp = serializer.Deserialize(Of Object)(response)("data")("translations")
        Catch ex As Exception
            MsgBox("in sendGETreq:" + ex.Message, MsgBoxStyle.Exclamation)
        End Try

        Return temp
    End Function
    Public Function sendPOSTRequest(ByVal req As System.Collections.Generic.Dictionary(Of String, String)) As Object ' System.Collections.Generic.Dictionary(Of String, String)
        Dim response, reqString As String
        Dim webRequest As HttpWebRequest ' = HttpWebRequest.Create("http://localhost:80/tra")
        Dim webResponse As HttpWebResponse
        Dim cl As New HttpClient
        Dim serializer As New System.Web.Script.Serialization.JavaScriptSerializer
        Dim responseReader As System.IO.StreamReader

        'If req("q").Length >= 5000 Then
        'Throw New Exception("Maximum 5000 characters per request, for now!")
        'End If
        'GET https://www.googleapis.com/language/translate/v2?key=INSERT-YOUR-KEY&source=en&target=de&q=Hello%20world
        'reqString =
        '   "https://www.googleapis.com/language/translate/v2?" +
        '  "key=" + req("key")
        '''If req("source") = "--" Then
        '''req("source") = ""
        '''End If
        'reqString = "http://localhost"
        reqString = "https://www.googleapis.com/language/translate/v2"
        ' +
        '"key=" + req("key")
        'If req.ContainsKey("source") Then
        'reqString &= "&source=" + req("source")
        'End If
        'reqString &= "&target=" + req("target")
        ''reqString &= "&q=" + req("q")
        webRequest = HttpWebRequest.Create(reqString)
        webRequest.Method = "POST"
        webRequest.ContentType = "application/x-www-form-urlencoded"
        webRequest.UserAgent = "API Testing 0.1"
        webRequest.Accept = "*/*"
        webRequest.Headers.Add("X-HTTP-Method-Override: GET")
        webRequest.KeepAlive = False
        'For Each line In SourceText.Lines
        '
        'Next
        Dim data, encodedData As String
        Dim bytes As Byte()
        Dim chars As Char()
        Dim temp As New Object
        Dim requestWriter As System.IO.StreamWriter
        Try
            data = serializer.Serialize(req)
            bytes = Encoding.UTF8.GetBytes(data)
            chars = Encoding.UTF8.GetChars(bytes)
            'encodedData = System.Web.HttpUtility.UrlEncode(data)
            encodedData = "key=" + req("key")
            If req.ContainsKey("source") Then
                encodedData &= "&source=" + req("source")
            End If
            encodedData &= "&target=" + req("target")
            encodedData &= "&q=" + req("q")
            'webRequest.ContentLength = 58 'chars.Count
            'webRequest.ContentLength = chars.Count
            'datastream = request.GetRequestStream
            requestWriter = New System.IO.StreamWriter(webRequest.GetRequestStream(), System.Text.Encoding.UTF8)
            'encodedData = System.Web.HttpUtility.UrlEncode(encodedData, System.Text.Encoding.UTF8)
            requestWriter.Write(encodedData)
            'requestWriter.Write(chars, 0, chars.Length)
            requestWriter.Close()


            webResponse = webRequest.GetResponse
            responseReader = New System.IO.StreamReader(webResponse.GetResponseStream)
            response = responseReader.ReadToEnd
            responseReader.Close()
            'Try
            temp = serializer.Deserialize(Of Object)(response)("data")("translations")
        Catch ex As Exception
            MsgBox("in sendPOSTreq:" + ex.Message, MsgBoxStyle.Exclamation)
        End Try

        Return temp
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim g As New Google.Apis.Translate.v2.LanguagesResource.ListRequest()

        Dim o As New System.Collections.Generic.Dictionary(Of String, String)
        Dim source, dest As String
        Dim numlines, donelines As Integer

        Try
            source = ""
            dest = ""
            Me.Cursor = Cursors.WaitCursor
            If APIKey.TextLength = 0 Then Throw New System.Exception("No API key!")
            If SourceText.Text.Length = 0 Then Throw New System.Exception("No source text!")

            'o("q") = System.Web.HttpUtility.UrlEncode(SourceText.Text, System.Text.Encoding.UTF8)

            If SourceCombo.SelectedValue.ToString <> "--" Then
                o("source") = SourceCombo.SelectedValue.ToString
            End If
            o("target") = TargetCombo.SelectedValue.ToString
            o("key") = APIKey.Text
            SourceText.Save(source, TXTextControl.StringStreamType.HTMLFormat)
            'source = SourceText.Text
            ' because there is a limit of 5000 chars, we must do it line by line
            numlines = SourceText.Lines.Count
            donelines = 0
            Using SR = New IO.StringReader(source)
                Dim linestobetranslated As String = ""
                Dim linebeingconsidered As String = ""
                While SR.Peek >= 0
                    linestobetranslated = ""
                    While SR.Peek >= 0
                        If linebeingconsidered = "" Then
                            'linebeingconsidered = System.Web.HttpUtility.UrlEncode(SR.ReadLine, System.Text.Encoding.UTF8)
                            linebeingconsidered = SR.ReadLine
                        End If 'else, we had a linebeingconsidered from a previous run that would have made the string too long
                        If linestobetranslated.Length + linebeingconsidered.Length > MAXREQUESTLENGTH Then
                            Exit While
                        Else
                            linestobetranslated &= linebeingconsidered
                            linebeingconsidered = ""
                            donelines += 1
                        End If
                    End While
                    o("q") = linestobetranslated

                    Dim temp As Object
                    'temp = sendGETRequest(o)
                    temp = sendPOSTRequest(o)
                    'MsgBox("Done: " + Str(donelines) + "/" + Str(numlines))
                    Dim s As String = ""
                    For Each x As Dictionary(Of String, Object) In temp
                        If x.ContainsKey("translatedText") Then
                            s &= x("translatedText")
                        End If
                    Next
                    dest &= s + Environment.NewLine
                    TargetText.Load(dest, TXTextControl.StringStreamType.HTMLFormat)
                End While
            End Using
            'o("q") = System.Web.HttpUtility.UrlEncode(s, System.Text.Encoding.UTF8)

            '            Dim temp As Object
            'temp = sendGETRequest(o)
            's = ""
            'For Each x In temp
            '            s &= x("translatedText")
            'Next
            'TargetText.Text = s
            TargetText.Load(dest, TXTextControl.StringStreamType.HTMLFormat)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        Me.Cursor = Me.DefaultCursor
    End Sub

    Private Sub BeGlobalMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate the list box using an array as DataSource. 
        Me.Cursor = Cursors.WaitCursor

        Dim o As Object
        Dim s, shortname, longname As String
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

        Dim tempSourceLanguages, tempTargetLanguages As New ArrayList()
        Dim SourceLanguages, TargetLanguages As New ArrayList()
        Dim cultures() As CultureInfo = CultureInfo.GetCultures(CultureTypes.AllCultures)

        o = getLanguageListFromGoogle()
        Dim o2 = o("data")
        For Each item In o2("languages")
            shortname = item("language")
            longname = shortname '-Just in case nothing is found...
            Select Case shortname
                'Google handles Chinese strangely and NOT according to standards!
                Case "zh-TW"
                    longname = "Chinese (Traditional)"
                Case "zh"
                    longname = "Chinese (Simplified)"
                Case "eo"
                    longname = "Esperanto"
                Case "ceb"
                    longname = "Cebuano"
                Case "yi"
                    longname = "Yiddish"
                Case "ht"
                    longname = "Haitian"
                Case "iw"
                    longname = "Hebrew"
                Case "jw"
                    longname = "Javanese"
                Case "la"
                    longname = "Latin"
                Case "no"
                    longname = "Norwegian"
                Case "hmn"
                    longname = "Hmong"
                Case "tl"
                    longname = "Tagalog"
                Case "es"
                    longname = "Spanish"
                Case Else
                    For Each c In cultures
                        If c.TwoLetterISOLanguageName = shortname Or c.ThreeLetterISOLanguageName = shortname Then
                             longname = c.EnglishName
                            Exit For
                        End If
                    Next
            End Select
            Dim lf As New LanguageDesc(shortname, longname) 'insert values swapped so that they can be sorted by long name later
            tempSourceLanguages.Add(lf)
            tempTargetLanguages.Add(lf)
            Log.AppendText("Found language: [" + shortname + "] " +
                  longname + vbNewLine) ' + b.Value.ToString)

        Next
        tempSourceLanguages.Add(New LanguageDesc("--", "- Automatic Recognition -"))
        tempTargetLanguages.Sort()
        tempSourceLanguages.Sort()
        'now swap long and short names
        For Each x As LanguageDesc In tempTargetLanguages
            Dim y As New LanguageDesc(x.ShortName, x.LongName)
            TargetLanguages.Add(y)
        Next
        For Each x As LanguageDesc In tempSourceLanguages
            Dim y As New LanguageDesc(x.ShortName, x.LongName)
            SourceLanguages.Add(y)
        Next
        TargetCombo.DataSource = TargetLanguages
        TargetCombo.DisplayMember = "LongName"
        TargetCombo.ValueMember = "ShortName"
        TargetCombo.SelectedValue = "en"
        SourceCombo.DataSource = SourceLanguages
        SourceCombo.DisplayMember = "LongName"
        SourceCombo.ValueMember = "ShortName"
        SourceCombo.SelectedIndex = 0

        Log.AppendText(vbNewLine + "You may close this window now.")
        Me.Cursor = Me.DefaultCursor

    End Sub

    Private Sub ButtonClearSource_Click(sender As Object, e As EventArgs) Handles ButtonClearSource.Click
        SourceText.ResetContents()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TargetText.ResetContents()
    End Sub

    Private Sub ButtonLoad_Click(sender As Object, e As EventArgs) Handles ButtonLoad.Click
        Try
            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim temp As String = Path.GetExtension(OpenFileDialog1.FileName)
                Dim type As TXTextControl.StreamType
                Select Case Path.GetExtension(OpenFileDialog1.FileName)
                    Case ".txt"
                        type = TXTextControl.StreamType.PlainText
                    Case ".pdf"
                        type = TXTextControl.StreamType.AdobePDF
                    Case ".htm", ".html"
                        type = TXTextControl.StreamType.HTMLFormat
                    Case ".doc"
                        type = TXTextControl.StreamType.MSWord
                    Case Else
                        Throw New ArgumentException("Unknown file type")
                End Select
                LabelFileName.Text = OpenFileDialog1.FileName
                SourceText.Load(OpenFileDialog1.FileName, type)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
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
