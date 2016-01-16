Public Class itc

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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

        DataGridView1.Rows.Clear()

        For x As Integer = 2 To oSheet.UsedRange.Rows.Count
            '  Dim i As Integer = nextrow(oExcel, oBook, oSheet)
            If oSheet.Range("I" & x).value = sdate Then
                DataGridView1.Rows.Add()
                DataGridView1.Item(0, a).Value = oSheet.Range("A" & x).Value
                DataGridView1.Item(1, a).Value = oSheet.Range("B" & x).Value
                DataGridView1.Item(2, a).Value = oSheet.Range("C" & x).Value
                DataGridView1.Item(3, a).Value = oSheet.Range("D" & x).Value
                DataGridView1.Item(4, a).Value = oSheet.Range("E" & x).Value
                DataGridView1.Item(5, a).Value = oSheet.Range("F" & x).Value
                DataGridView1.Item(6, a).Value = oSheet.Range("G" & x).Value
                DataGridView1.Item(7, a).Value = oSheet.Range("H" & x).Value
                DataGridView1.Item(8, a).Value = oSheet.Range("I" & x).Value
                DataGridView1.Item(9, a).Value = oSheet.Range("J" & x).Value
                DataGridView1.Item(10, a).Value = oSheet.Range("K" & x).Value
                DataGridView1.Item(11, a).Value = oSheet.Range("L" & x).Value
                DataGridView1.Item(12, a).Value = oSheet.Range("M" & x).Value
                DataGridView1.Item(13, a).Value = oSheet.Range("N" & x).Value
                DataGridView1.Item(14, a).Value = oSheet.Range("O" & x).Value
                DataGridView1.Item(15, a).Value = oSheet.Range("P" & x).Value
                a = a + 1
                r = True


            End If

        Next
        If r = False Then
            MessageBox.Show(" NO REPORTS GENERATED")
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
    Private Function nextrow(ByVal oExcel As Object, ByVal oBook As Object, ByVal oSheet As Object) As Integer
        Dim i As Integer = 0
        While True
            i += 1
            Dim s As String
            s = CType(i, String)
            If oSheet.Range("A" & s).Value = Nothing Then
                Exit While
            End If
        End While
        Return i
    End Function


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
