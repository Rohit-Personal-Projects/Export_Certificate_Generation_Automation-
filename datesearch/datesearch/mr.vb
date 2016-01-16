Public Class mr

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sdate As String
        Dim oExcel As Object
        Dim oBook As Object
        Dim oSheet As Object
        Dim a As Integer


        oExcel = CreateObject("Excel.Application")
        oBook = oExcel.Workbooks.Open("F:\Export Data.xlsx")

        oSheet = oBook.Worksheets(1)

        sdate = ComboBox1.Text
        ' oSheet.Range("B" & i).Value = tdate.Value.Day & "." & tdate.Value.Month & "." & tdate.Value.Year
        For x As Integer = 2 To oSheet.UsedRange.Rows.Count - 1
            ' Dim i As Integer = nextrow(oExcel, oBook, oSheet)
            Dim z As String
            z = oSheet.Range("B" & x).Value
            MessageBox.Show(z)
            Dim s As String() = z.Split(".")
            MessageBox.Show(s(0))
            If s(1) = sdate Then


                DataGridView1.Rows.Add()
                DataGridView1.Item(0, a).Value = oSheet.Range("A" & x).Value
                DataGridView1.Item(1, a).Value = oSheet.Range("B" & x).Value
                DataGridView1.Item(2, a).Value = oSheet.Range("C" & x).Value
                DataGridView1.Item(3, a).Value = oSheet.Range("D" & x).Value
                DataGridView1.Item(4, a).Value = oSheet.Range("E" & x).value
                DataGridView1.Item(5, a).Value = oSheet.Range("F" & x).value
                DataGridView1.Item(6, a).Value = oSheet.Range("G" & x).value
                DataGridView1.Item(6, a).Value = oSheet.Range("G" & x).value
                DataGridView1.Item(6, a).Value = oSheet.Range("H" & x).value
                DataGridView1.Item(6, a).Value = oSheet.Range("I" & x).value
                DataGridView1.Item(6, a).Value = oSheet.Range("J" & x).value
                DataGridView1.Item(6, a).Value = oSheet.Range("K" & x).value
                DataGridView1.Item(6, a).Value = oSheet.Range("L" & x).value
                DataGridView1.Item(6, a).Value = oSheet.Range("M" & x).value
                DataGridView1.Item(6, a).Value = oSheet.Range("N" & x).value
                DataGridView1.Item(6, a).Value = oSheet.Range("O" & x).value
                a = a + 1

            ElseIf MessageBox.Show("no such entry exists in the database") Then
            End If


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
