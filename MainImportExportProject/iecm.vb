Public Class iecm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim iecnum As Integer
        Dim oExcel As Object
        Dim oBook As Object
        Dim oSheet As Object
        Dim cnt As Integer
        cnt = 0


        oExcel = CreateObject("Excel.Application")
        oBook = oExcel.Workbooks.Open("D:\ExpImp\Export Data.xlsx")

        oSheet = oBook.Worksheets(1)
        iecnum = iectext.Text
        For x As Integer = 2 To oSheet.UsedRange.Rows.Count
            If oSheet.Range("C" & x).Value = iecnum Then
                ' MessageBox.Show(oSheet.Range("C" & x).value)
                cnt = cnt + 1
            End If
        Next
        MessageBox.Show("the number 0f iec " & iecnum & " is " & cnt)
        oExcel.Quit()

        oExcel = Nothing
        oBook = Nothing
        oSheet = Nothing

        Dim instance As Process
        Dim instances As Process() = Process.GetProcessesByName("EXCEL")

        Try
            If instances.Length >= 1 Then
                For Each instance In instances
                    instance.Kill()
                Next
            End If


        Catch
        End Try
        System.GC.Collect()
        System.GC.Collect()





    End Sub
End Class
