Imports System.Windows.Forms

Public Class DialogEmailWarning

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
End Class
