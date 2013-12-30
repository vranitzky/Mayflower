Imports System.Windows.Forms

Public Class DialogEmailWarning
    'Private Attachments As Dictionary(Of String, String) = New Dictionary(Of String, String)

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub DialogEmailWarning_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Dim c As Control = EmailBody.Parent
        EmailBody.Parent = Nothing
        If Not EmailBody.IsHandleCreated Then
            EmailBody.CreateControl()
        End If
        EmailBody.Load(My.Settings.EmailBody, TXTextControl.StringStreamType.HTMLFormat)

        EmailBody.Parent = c

    End Sub

    Private Sub Attach_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button1.Click
        Dim b As System.Windows.Forms.Button = CType(sender, Button)

        If Not FormMain.Attachments.ContainsKey(b.Name) Then
            FormMain.Attachments(b.Name) = ""
        End If

        If FormMain.Attachments(b.Name) <> "" Then 'we have an attachment
            FormMain.Attachments(b.Name) = ""
            b.ImageKey = "DocAdd"
            b.Text = "Add"
            b.Size = b.MinimumSize
        Else
            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                FormMain.Attachments(b.Name) = OpenFileDialog1.FileName
                b.ImageKey = "DocRemove"
                b.Text = "Remove " + OpenFileDialog1.SafeFileName
            End If
        End If
    End Sub
End Class
