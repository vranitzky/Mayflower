Imports System
Imports System.IO
Imports System.Text
Imports OfficeOpenXml

Public Class FormFinRep

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DTReport1TA.Fill(DataSet2.DTReport1, DateTimePickerFrom.Value, DateTimePickerTo.Value)
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub FormFinRep_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub ButtonR1Export_Click(sender As Object, e As EventArgs) Handles ButtonR1Export.Click

        Dim cols As Integer
        Dim path As String

        Try

            If SaveFileDialog1.ShowDialog() Then
                path = SaveFileDialog1.FileName
            Else
                Return
            End If

            Dim f As FileInfo = New FileInfo(path)
            Dim p = New OfficeOpenXml.ExcelPackage(f)

            Dim ws = p.Workbook.Worksheets.Add("Report1")

            For r = 0 To DataGridViewReport1.Rows.Count - 1
                For c = 0 To DataGridViewReport1.Columns.Count - 1
                    ws.Cells(r, c).Value = DataGridViewReport1.Rows(r).Cells(c).Value
                    'wr.Write(DataGridViewReport1.Rows(r).Cells(c).Value.ToString + vbTab)
                Next
                'wr.WriteLine()
            Next

            Dim wr1 As StreamWriter = New StreamWriter(path, False, Encoding.UTF8)
            wr1.Write(p.GetAsByteArray())
            wr1.Close()

            Return





            Dim wr As StreamWriter = New StreamWriter(path, False, Encoding.UTF8)
            'StreamWriter wr = new StreamWriter("GB STOCK.csv", false, Encoding.UTF8);

            ' determine the number of columns and write columns to file 
            cols = DataGridViewReport1.ColumnCount

            For i = 0 To cols - 1
                wr.Write(DataGridViewReport1.Columns(i).HeaderText + vbTab)
            Next
            wr.WriteLine()

            '    //write rows to excel file
            For r = 0 To DataGridViewReport1.Rows.Count - 1
                For c = 0 To DataGridViewReport1.Columns.Count - 1
                    wr.Write(DataGridViewReport1.Rows(r).Cells(c).Value.ToString + vbTab)
                Next
                wr.WriteLine()
            Next

            wr.Close()
        Catch ex As Exception
            MsgBox("There was an error:" + vbNewLine + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        '                            if (dgvStock.Rows[i].Cells[j].Value != null)
        '                               {
        '                                  wr.Write(dgvStock.Rows[i].Cells[j].Value + ",");
        '                             }
        '            Else
        '                           {
        '                              wr.Write(",");
        '                         }
    End Sub
End Class