Public Class dr

    Private Sub ACCEPT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACCEPT.Click
        Dim sdate As String
        Dim oExcel As Object
        Dim oBook As Object
        Dim oSheet As Object
        Dim a As Integer


        oExcel = CreateObject("Excel.Application")
        oBook = oExcel.Workbooks.Open("F:\Export Data.xlsx")

        oSheet = oBook.Worksheets(1)

        sdate = DDATE.Text
        ' oSheet.Range("B" & i).Value = tdate.Value.Day & "." & tdate.Value.Month & "." & tdate.Value.Year
        For x As Integer = 1 To oSheet.UsedRange.Rows.Count - 1
            ' Dim i As Integer = nextrow(oExcel, oBook, oSheet)
            Dim z As String
            z = oSheet.Range("B" & x).Value
            'MessageBox.Show(z)
            'z.Split()
            If z = sdate Then


                DataGridView1.Rows.Add()
                DataGridView1.Item(0, a).Value = oSheet.Range("A" & x).Value
                DataGridView1.Item(1, a).Value = oSheet.Range("B" & x).Value
                DataGridView1.Item(2, a).Value = oSheet.Range("C" & x).Value
                DataGridView1.Item(3, a).Value = oSheet.Range("D" & x).Value
                DataGridView1.Item(4, a).Value = oSheet.Range("E" & x).Value
                DataGridView1.Item(5, a).Value = oSheet.Range("F" & x).Value
                DataGridView1.Item(6, a).Value = oSheet.Range("G" & x).Value
                a = a + 1

            End If

            ' Else  MessageBox.Show(" NO REPORTS GENERATED")



        Next
        oExcel.Quit()
        oExcel = Nothing
        oBook = Nothing
        oSheet = Nothing

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





End Class
