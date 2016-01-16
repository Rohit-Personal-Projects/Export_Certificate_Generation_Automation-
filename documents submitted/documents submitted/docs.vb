Public Class docs

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
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
                MessageBox.Show(oSheet.Range("H" & x).Value)


            Else
                MessageBox.Show("no such entry exist in the database")
            End If


        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
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
                MessageBox.Show(oSheet.Range("G" & x).Value)


            Else
                MessageBox.Show("no such entry exist in the database")
            End If


        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim iecnum As Integer
        Dim oExcel As Object
        Dim oBook As Object
        Dim oSheet As Object
        Dim cnt As Integer
        cnt = 0


        oExcel = CreateObject("Excel.Application")
        oBook = oExcel.Workbooks.Open("D:\exportform.xlsx")

        oSheet = oBook.Worksheets(1)
        iecnum = rC.Text
        For x As Integer = 1 To oSheet.UsedRange.Rows.Count - 1
            If oSheet.Range("P" & x).value = iecnum Then
                MessageBox.Show(oSheet.Range("F" & x).Value)


            Else
                MessageBox.Show("no such entry exist in the database")
            End If


        Next
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
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
                MessageBox.Show(oSheet.Range("I" & x).Value)


            Else
                MessageBox.Show("no such entry exist in the database")
            End If


        Next
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
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
                MessageBox.Show(oSheet.Range("J" & x).Value)


            Else
                MessageBox.Show("no such entry exist in the database")
            End If


        Next
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
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
                MessageBox.Show(oSheet.Range("K" & x).Value)


            Else
                MessageBox.Show("no such entry exist in the database")
            End If


        Next
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
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
                MessageBox.Show(oSheet.Range("L" & x).Value)


            Else
                MessageBox.Show("no such entry exist in the database")
            End If


        Next
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
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
                MessageBox.Show(oSheet.Range("M" & x).Value)


            Else
                MessageBox.Show("no such entry exist in the database")
            End If


        Next
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
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
                MessageBox.Show(oSheet.Range("N" & x).Value)


            Else
                MessageBox.Show("no such entry exist in the database")
            End If


        Next
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rc.TextChanged

    End Sub
End Class
