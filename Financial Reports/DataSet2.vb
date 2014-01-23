Partial Class DataSet2
    Partial Class DTReport2DataTable

        Private Sub DTReport2DataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.DataColumn5Column.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class


End Class
