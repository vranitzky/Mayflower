Option Strict On

''' <summary>
''' Represents a collection of strings similar in performance to a HashSet(Of String) that offers partial string searches.
''' </summary>
''' <remarks></remarks>
Public Class SearchableStringCollection
    Implements ICollection(Of String)

    Private _ListCore As New Dictionary(Of Char, SearchableStringCollection)

    ''' <summary>
    ''' Adds the specified string to the collection if it does not already exist.
    ''' </summary>
    ''' <param name="item">The string to add to the collection.</param>
    ''' <remarks></remarks>
    Public Sub Add(item As String) Implements System.Collections.Generic.ICollection(Of String).Add
        If OnAdd((item & Chr(0)).ToArray, 0) Then
            _Count += 1
        End If
    End Sub

    ''' <summary>
    ''' Clears all strings from the collection.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Clear() Implements System.Collections.Generic.ICollection(Of String).Clear
        _ListCore.Clear()
        _Count = 0
    End Sub

    ''' <summary>
    ''' Gets a value indicating whether the collection contains the specified string.
    ''' </summary>
    ''' <param name="item">The exact string to find.</param>
    ''' <returns>True if the collection contains the specified string, otherwise false.</returns>
    ''' <remarks></remarks>
    Public Function Contains(item As String) As Boolean Implements System.Collections.Generic.ICollection(Of String).Contains
        Return OnContains((item & Chr(0)).ToCharArray, 0)
    End Function

    ''' <summary>
    ''' Gets a value indicating whether the collection contains any strings that begin with the specified characters.
    ''' </summary>
    ''' <param name="startsWith">The starting characters to search for.</param>
    ''' <returns>True if the collection contains one or more strings beginning with the specified characters, otherwise false.</returns>
    ''' <remarks></remarks>
    Public Function ContainsStartingWith(startsWith As String) As Boolean
        Return OnContains(startsWith.ToCharArray, 0)
    End Function

    ''' <summary>
    ''' Copies the contents of the collection to the specified array.
    ''' </summary>
    ''' <param name="array">The array of strings to copy the collection into.</param>
    ''' <param name="arrayIndex">The location in the array at which copying begins.</param>
    ''' <remarks></remarks>
    Public Sub CopyTo(array() As String, arrayIndex As Integer) Implements System.Collections.Generic.ICollection(Of String).CopyTo
        For Each entry As String In Me
            array(arrayIndex) = entry
            arrayIndex += 1
            If arrayIndex = array.Length Then Exit For
        Next
    End Sub

    Private _Count As Integer
    ''' <summary>
    ''' Gets the number of complete strings contained in the collection.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Count As Integer Implements System.Collections.Generic.ICollection(Of String).Count
        Get
            Return _Count
        End Get
    End Property

    ''' <summary>
    ''' Gets an array of strings that begin with the specified characters.
    ''' </summary>
    ''' <param name="startsWith">The starting characters to find.</param>
    ''' <returns>An array of strings beginning with the specified characters.</returns>
    ''' <remarks></remarks>
    Public Function Find(startsWith As String) As String()
        Return OnFind(startsWith.ToCharArray, 0)
    End Function

    ''' <summary>
    ''' Gets an enumerator that iterates over the strings in the collection.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetEnumerator() As System.Collections.Generic.IEnumerator(Of String) Implements System.Collections.Generic.IEnumerable(Of String).GetEnumerator
        Return New SearchableStringCollectionEnumerator(Me._ListCore.GetEnumerator)
    End Function

    Protected Function GetEnumeratorCore() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
        Return GetEnumerator()
    End Function

    ''' <summary>
    ''' Returns false indicating that the collection is not read-only.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property IsReadOnly As Boolean Implements System.Collections.Generic.ICollection(Of String).IsReadOnly
        Get
            Return False
        End Get
    End Property

    ''' <summary>
    ''' Removes the specified string from the collection.
    ''' </summary>
    ''' <param name="item">The string to remove from the collection.</param>
    ''' <returns>True if the string is found and removed, otherwise false.</returns>
    ''' <remarks></remarks>
    Public Function Remove(item As String) As Boolean Implements System.Collections.Generic.ICollection(Of String).Remove
        Dim result As Boolean = OnRemove((item & Chr(0)).ToCharArray, 0)
        If result Then _Count -= 1
        Return result
    End Function

    Protected Overridable Function OnAdd(characters() As Char, index As Integer) As Boolean
        Dim result As Boolean = False
        If characters.Length > 0 Then
            If Not _ListCore.ContainsKey(characters(index)) Then
                _ListCore.Add(characters(index), New SearchableStringCollection)
                If index = characters.Length - 1 Then result = True
            End If
            If index < characters.Length - 1 Then
                result = _ListCore(characters(index)).OnAdd(characters, index + 1)
            End If
        End If
        Return result
    End Function

    Protected Overridable Function OnContains(characters() As Char, index As Integer) As Boolean
        If _ListCore.ContainsKey(characters(index)) Then
            If index < characters.Length - 1 Then
                Return _ListCore(characters(index)).OnContains(characters, index + 1)
            End If
            Return True
        End If
        Return False
    End Function

    Protected Overridable Function OnFind(characters() As Char, index As Integer) As String()
        Dim result As New List(Of String)
        If _ListCore.ContainsKey(characters(index)) Then
            If index < characters.Length - 1 Then
                result.AddRange(_ListCore(characters(index)).OnFind(characters, index + 1))
            Else
                Using enm As New SearchableStringCollectionEnumerator(_ListCore(characters(index))._ListCore.GetEnumerator)
                    While enm.MoveNext
                        result.Add(String.Concat(New String(characters), enm.Current))
                    End While
                End Using
            End If
        End If
        Return result.ToArray
    End Function

    Protected Overridable Function OnRemove(characters() As Char, index As Integer) As Boolean
        If _ListCore.ContainsKey(characters(index)) Then
            If index < characters.Length - 1 Then
                If _ListCore(characters(index)).OnRemove(characters, index + 1) Then
                    If _ListCore(characters(index))._ListCore.Count = 0 Then
                        _ListCore.Remove(characters(index))
                    End If
                    Return True
                End If
            Else
                _ListCore.Remove(characters(index))
                Return True
            End If
        End If
        Return False
    End Function

    ''' <summary>
    ''' Enumerates the elements of a SearchableStringCollection.
    ''' </summary>
    ''' <remarks></remarks>
    Public Class SearchableStringCollectionEnumerator
        Implements IEnumerator(Of String)

        Private _Enumerators As New List(Of IEnumerator(Of KeyValuePair(Of Char, SearchableStringCollection)))
        Private _Current As New System.Text.StringBuilder
        Private _BaseEnumerator As IEnumerator(Of KeyValuePair(Of Char, SearchableStringCollection))

        Protected Friend Sub New(baseEnumerator As IEnumerator(Of KeyValuePair(Of Char, SearchableStringCollection)))
            _BaseEnumerator = baseEnumerator
            _Enumerators.Add(_BaseEnumerator)
        End Sub

        ''' <summary>
        ''' Gets the element in the collection at the current position of the enumerator.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property Current As String Implements System.Collections.Generic.IEnumerator(Of String).Current
            Get
                Return _Current.ToString
            End Get
        End Property

        Protected ReadOnly Property CurrentCore As Object Implements System.Collections.IEnumerator.Current
            Get
                Return Current
            End Get
        End Property

        ''' <summary>
        ''' Advances the enumerator to the next element in the collection.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext
            Dim result As Boolean = BuildCurrent()
            If _Current.Length > 0 Then _Current.Length -= 1
            Return result
        End Function

        ''' <summary>
        ''' Sets the enumerator to its initial position, which is before the first element in the collection.
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub Reset() Implements System.Collections.IEnumerator.Reset
            _Current.Clear()
            _Enumerators.Remove(_BaseEnumerator)
            _BaseEnumerator.Reset()
            For Each enm As IEnumerator(Of KeyValuePair(Of Char, SearchableStringCollection)) In _Enumerators
                enm.Dispose()
            Next
            _Enumerators.Clear()
            _Enumerators.Add(_BaseEnumerator)
        End Sub

        Private Function BuildCurrent() As Boolean
            Dim result As Boolean = False
            If _Enumerators.Count > 0 Then
                If _Enumerators(_Enumerators.Count - 1).MoveNext() Then
                    _Current.Append(_Enumerators(_Enumerators.Count - 1).Current.Key)
                    If Not _Current(_Current.Length - 1) = Chr(0) Then
                        _Enumerators.Add(_Enumerators(_Enumerators.Count - 1).Current.Value._ListCore.GetEnumerator)
                        result = BuildCurrent()
                    Else
                        result = True
                    End If
                Else
                    _Enumerators.RemoveAt(_Enumerators.Count - 1)
                    If _Current.Length > 0 Then _Current.Length -= 1
                    result = BuildCurrent()
                End If
            End If
            Return result
        End Function

#Region "IDisposable Support"
        Private disposedValue As Boolean
        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    For Each enm As IEnumerator(Of KeyValuePair(Of Char, SearchableStringCollection)) In _Enumerators
                        enm.Dispose()
                    Next
                    _Enumerators.Clear()
                    _Current.Clear()
                    _BaseEnumerator.Dispose()
                    _BaseEnumerator = Nothing
                End If
            End If
            Me.disposedValue = True
        End Sub
        Public Sub Dispose() Implements IDisposable.Dispose
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
#End Region

    End Class
End Class
