Imports System.Windows.Forms

Public Class DialogDetails

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


    Private Sub DialogDetails_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Me.DetailsTableAdapter.FillByRES_ID(Me.DataSet2.DataTableDetails, CInt(Me.Tag))

    End Sub
End Class
