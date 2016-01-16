Public Class lds

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACCEPT.Click

        Dim iecnum As Integer
        Dim oExcel As Object
        Dim oBook As Object
        Dim oSheet As Object
        Dim cnt As Integer
        cnt = 0


        oExcel = CreateObject("Excel.Application")
        oBook = oExcel.Workbooks.Open("D:\ExpImp\exportform.xlsx")

        oSheet = oBook.Worksheets(1)
        iecnum = rc.Text
        Dim r As Boolean = False
        For x As Integer = 2 To oSheet.UsedRange.Rows.Count
            If oSheet.Range("P" & x).value = iecnum Then
                MessageBox.Show(oSheet.Range("L" & x).value)
                r = True



            End If


        Next
        If r = False Then
            MessageBox.Show("no value present ")
        End If
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



