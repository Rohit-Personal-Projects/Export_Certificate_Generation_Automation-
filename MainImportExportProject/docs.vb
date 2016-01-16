Public Class docs

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
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
                r = True
                MessageBox.Show(oSheet.Range("H" & x).Value)
                Exit For
            End If


        Next
        If r = False Then
            MessageBox.Show("no such entry exist in the database")
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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
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
                r = True
                MessageBox.Show(oSheet.Range("G" & x).Value)
                Exit For
            End If


        Next
        If r = False Then
            MessageBox.Show("no such entry exist in the database")
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim iecnum As Integer
        Dim oExcel As Object
        Dim oBook As Object
        Dim oSheet As Object
        Dim cnt As Integer
        cnt = 0


        oExcel = CreateObject("Excel.Application")
        oBook = oExcel.Workbooks.Open("D:\ExpImp\exportform.xlsx")

        oSheet = oBook.Worksheets(1)
        iecnum = rC.Text
        
        Dim r As Boolean = False
        For x As Integer = 2 To oSheet.UsedRange.Rows.Count
            If oSheet.Range("P" & x).value = iecnum Then
                r = True
                MessageBox.Show(oSheet.Range("F" & x).Value)
                Exit For
            End If


        Next
        If r = False Then
            MessageBox.Show("no such entry exist in the database")
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

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
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
                r = True
                MessageBox.Show(oSheet.Range("I" & x).Value)
                Exit For
            End If


        Next
        If r = False Then
            MessageBox.Show("no such entry exist in the database")
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

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
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
                r = True
                MessageBox.Show(oSheet.Range("J" & x).Value)
                Exit For
            End If


        Next
        If r = False Then
            MessageBox.Show("no such entry exist in the database")
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

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
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
                r = True
                MessageBox.Show(oSheet.Range("K" & x).Value)
                Exit For
            End If


        Next
        If r = False Then
            MessageBox.Show("no such entry exist in the database")
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

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
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
                r = True
                MessageBox.Show(oSheet.Range("L" & x).Value)
                Exit For
            End If


        Next
        If r = False Then
            MessageBox.Show("no such entry exist in the database")
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

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
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
                r = True
                MessageBox.Show(oSheet.Range("M" & x).Value)
                Exit For
            End If


        Next
        If r = False Then
            MessageBox.Show("no such entry exist in the database")
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

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
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
            If CDbl(oSheet.Range("P" & x).value) = iecnum Then
                r = True
                MessageBox.Show("Rs." & oSheet.Range("Q" & x).Value)
                Exit For
            End If


        Next
        If r = False Then
            MessageBox.Show("no such entry exist in the database")
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

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rc.TextChanged

    End Sub
End Class
