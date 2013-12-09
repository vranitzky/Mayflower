Namespace DataSet1TableAdapters
    Partial Public Class DataTablePeopleTableAdapter
        Public Property ConnectionString As String
            Get
                Return Connection.ConnectionString
            End Get
            Set(value As String)
                Connection.ConnectionString = value
            End Set
        End Property
    End Class
End Namespace

Partial Class DataSet1
End Class
