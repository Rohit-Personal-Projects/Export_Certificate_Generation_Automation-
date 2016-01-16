Public Class lds

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACCEPT.Click

        Dim iecnum As Integer
        Dim oExcel As Object
        Dim oBook As Object
        Dim oSheet As Object
        Dim cnt As Integer
        cnt = 0


        oExcel = CreateObject("Excel.Application")
        oBook = oExcel.Workbooks.Open("D:\exportform.xlsx")

        oSheet = oBook.Worksheets(1)
        iecnum = rc.Text
        For x As Integer = 1 To oSheet.UsedRange.Rows.Count - 1
            If oSheet.Range("P" & x).value = iecnum Then
                MessageBox.Show("LAST DATE OF SHIPMENT IS" & "  " & oSheet.Range("N" & x))


            ElseIf MessageBox.Show("no such entry exist in the database") Then
            End If


        Next

    End Sub
End Class



