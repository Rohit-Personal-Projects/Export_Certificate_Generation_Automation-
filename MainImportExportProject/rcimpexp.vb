Public Class rcimpexp

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButIMP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButIMP.Click
        Dim sdate As Integer
        Dim oExcel As Object
        Dim oBook As Object
        Dim oSheet As Object

        oExcel = CreateObject("Excel.Application")
        oBook = oExcel.Workbooks.Open("D:\ExpImp\Export Data.xlsx")

        oSheet = oBook.Worksheets(1)

        sdate = itchs.Text

        Dim colum As Integer = 2
        Dim a As Integer
        a = 0
        Dim r As Boolean = False
        ' oSheet.Range("B" & i).Value = tdate.Value.Day & "." & tdate.Value.Month & "." & tdate.Value.Year
        For x As Integer = 2 To oSheet.UsedRange.Rows.Count - 1
            '  Dim i As Integer = nextrow(oExcel, oBook, oSheet)
            If oSheet.Range("H" & x).value = sdate Then
                MessageBox.Show(oSheet.Range("K" & x).value)
                r = True


            End If

        Next
        If r = False Then
            MessageBox.Show(" NO rc number present")
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

    Private Sub ButEXP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButEXP.Click
        Dim sdate As Integer
        Dim oExcel As Object
        Dim oBook As Object
        Dim oSheet As Object

        oExcel = CreateObject("Excel.Application")
        oBook = oExcel.Workbooks.Open("D:\ExpImp\exportform.xlsx")

        oSheet = oBook.Worksheets(1)

        sdate = itchs.Text

        Dim colum As Integer = 2
        Dim a As Integer
        a = 0
        Dim r As Boolean = False
        ' oSheet.Range("B" & i).Value = tdate.Value.Day & "." & tdate.Value.Month & "." & tdate.Value.Year
        For x As Integer = 2 To oSheet.UsedRange.Rows.Count - 1
            '  Dim i As Integer = nextrow(oExcel, oBook, oSheet)
            If oSheet.Range("P" & x).value = sdate Then
                MessageBox.Show(oSheet.Range("L" & x).value)
                r = True


            End If

        Next
        If r = False Then
            MessageBox.Show(" NO rc number present")
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
