Imports Microsoft.Office.Interop.Excel
Imports System.Data.DataTable
Imports Microsoft.Office.Interop
Imports System.IO

Public Class rcm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim numRow As Integer
        Dim obook As Excel.Workbook
        Dim oapp As Excel.Application
        oapp = New Excel.Application
        obook = oapp.Workbooks.Open("D:\ExpImp\Export Data.xlsx")
        numRow = 2
        While (obook.ActiveSheet.Cells(numRow, 8).Value IsNot Nothing)
            numRow = numRow + 1
        End While

        MsgBox("THE NUMBER OF RC'S ISSUED ARE" & "  " & numRow - 2)


    End Sub



End Class
