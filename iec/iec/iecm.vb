Public Class iecm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim iecnum As Integer
        Dim oExcel As Object
        Dim oBook As Object
        Dim oSheet As Object
        Dim cnt As Integer
        cnt = 0


        oExcel = CreateObject("Excel.Application")
        oBook = oExcel.Workbooks.Open("F:\Export Data.xlsx")

        oSheet = oBook.Worksheets(1)
        iecnum = iectext.Text
        For x As Integer = 2 To oSheet.UsedRange.Rows.Count - 1
            If oSheet.Range("B" & x).Value = iecnum Then
                cnt = cnt + 1
            End If
        Next
        MessageBox.Show("the number 0f iec" & iecnum & "is" & cnt)




    End Sub
End Class
