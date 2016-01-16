Imports System.Text.RegularExpressions

Imports System.Runtime.InteropServices
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop






Public Class ie

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ll3.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ll4.Click

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ll10.Click

    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ll4.Click, ll14.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox12.TextChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox2.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox12.Clear()
    End Sub

    Private Sub Label13_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        '  Dim attachedFilePath As String = "\\myserver\myshare\test.txt"

        'File.Open(attachedFilePath, FileMode.Open, FileAccess.Read, FileShare.Read)










        Dim instance As Process
        Dim instances As Process() = Process.GetProcessesByName("EXCEL")
        'If instances.Length >= 1 Then
        'MessageBox.Show("Some excel files are open.Please save your work and then press Ok to continue.")
        ' End If
        'Try
        'If instances.Length >= 1 Then
        'For Each instance In instances
        'instance.Kill()
        'Next
        'End If

        '
        ' Catch


        ' End Try



        If TextBox2.Text = String.Empty Or TextBox4.Text = String.Empty Or TextBox5.Text = String.Empty Or TextBox12.Text = String.Empty Then
            MessageBox.Show("Some fields are left blank.Fill those properly and then proceed")

            Exit Sub
        End If







        Dim textval As String


        Dim pattern As String = "^\d+(?:,\d+)*$"
        Dim match As Match = Regex.Match(TextBox2.Text, pattern)
        If Not match.Success Then
            MessageBox.Show("The quantity you entered for Shipping bill numbers is not in the proper format.Please enter the bill numbers seperated by commas")

            Exit Sub
        End If





        Dim pattern1 As String = "^(([0-9a-zA-Z][0-9a-zA-Z_]*)([,][0-9a-zA-Z][0-9a-zA-Z_]*)*)$"
        Dim m As Match = Regex.Match(TextBox5.Text, pattern1)
        If Not m.Success Then
            MessageBox.Show("The quantity you entered in the 'Documents submitted' field is not in a proper format.Please enter the documents seperated by commas")

            Exit Sub
        End If






        textval = TextBox4.Text
        If Not IsNumeric(textval) Then
            MessageBox.Show("The quantity you entered in the 4th field is not a valid number")

            Exit Sub
        End If



        textval = TextBox12.Text
        If Not IsNumeric(textval) Then
            MessageBox.Show("The quantity you entered is in the 12th field not a valid number")
            Exit Sub

        End If
        Dim a As String = ComboBox1.Text
        Dim b As String = ComboBox2.Text
        Dim c As String = ComboBox3.Text
        Dim d As String = ComboBox4.Text
        Dim h As String = ComboBox5.Text
        Dim f As String = ComboBox6.Text
        Dim g As String = ComboBox8.Text
        Dim i As String = ComboBox7.Text

        PictureBox1.Visible = True
        If a = "No" Or b = "No" Or g = "No" Or c = "No" Or d = "No" Or h = "No" Or f = "No" Or i = "No" Then

            'CheckFile("E:\Users\Omkar\exportform.xlsx")
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

            PictureBox1.Image = Image.FromFile("NOREPORT.jpg")
            PictureBox1.Parent = Me
            Me.Controls.Add(PictureBox1)
            PictureBox1.BringToFront()
            enterexcel()
            Exit Sub
        Else
            'CheckFile("E:\Users\Omkar\exportform.xlsx")
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            PictureBox1.Image = Image.FromFile("SUCCESS.jpg")
            PictureBox1.Parent = Me
            Me.Controls.Add(PictureBox1)
            PictureBox1.BringToFront()
            enterexcel()
        End If



    End Sub

    Private Sub TextBox12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox12.TextChanged








    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox8.SelectedIndexChanged

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click


    End Sub
    Private Sub enterexcel()
        Dim oExcel As Object
        Dim oBook As Object
        Dim oSheet As Object
        'Dim d1 As Date
        ' oExcel = CreateObject("Excel.Application")
        'oBook = oExcel.Workbooks.Open("E:\Users\Omkar\Export Data.xlsx")

        'Start a new workbook in Excel
        Try
            oExcel = CreateObject("Excel.Application", "Omkar-PC")
            oBook = oExcel.Workbooks.Open("E:\Users\Omkar\exportform.xlsx")
            'Add data to cells of the first worksheet in the new workbook
            oSheet = oBook.Worksheets(1)
        Catch
            MessageBox.Show("Some other person is currently working on this.Please try again later")
        End Try
        If oSheet.Range("A1").Value = "" Then
            'TITLES
            oSheet.Range("A1").Value = "Date of Reporting"
            oSheet.Range("B1").Value = "Bill Nos."
            oSheet.Range("C1").Value = "Bill Date"
            oSheet.Range("D1").Value = "Qty"
            oSheet.Range("E1").Value = "Documents"
            oSheet.Range("F1").Value = "Letter Report"
            oSheet.Range("G1").Value = "Promotion copy"
            oSheet.Range("H1").Value = "Control Copy"
            oSheet.Range("I1").Value = "Bill Copy"
            oSheet.Range("J1").Value = "Certificate Copy"
            oSheet.Range("K1").Value = "Original Reg. Certificate"
            oSheet.Range("L1").Value = "Total Qty"
            oSheet.Range("M1").Value = "Penalty Payment"
            oSheet.Range("N1").Value = "Validity"

            oSheet.Range("O1").Value = "Signing Authority"
            oSheet.Range("P1").Value = "RC NUMBER"
            oSheet.Range("A1:P1").Font.Bold = True

            '

            oSheet.Range("A3").Value = DateTimePicker2.Value.Day & "." & DateTimePicker2.Value.Month & "." & DateTimePicker2.Value.Year
            oSheet.Range("B3").Value = CType(TextBox2.Text, String)
            oSheet.Range("C3").Value = DateTimePicker1.Value.Day & "." & DateTimePicker1.Value.Month & "." & DateTimePicker1.Value.Year
            oSheet.Range("D3").Value = CType(TextBox4.Text, String)
            oSheet.Range("E3").Value = CType(TextBox5.Text, String)
            oSheet.Range("F3").Value = CType(ComboBox1.Text, String)
            oSheet.Range("G3").Value = CType(ComboBox2.Text, String)
            oSheet.Range("H3").Value = CType(ComboBox3.Text, String)
            oSheet.Range("I3").Value = CType(ComboBox4.Text, String)
            oSheet.Range("J3").Value = CType(ComboBox5.Text, String)
            oSheet.Range("K3").Value = CType(ComboBox6.Text, String)
            oSheet.Range("L3").Value = CType(TextBox12.Text, String)
            oSheet.Range("M3").Value = CType(ComboBox7.Text, String)
            oSheet.Range("N3").Value = DateTimePicker3.Value.Day & "." & DateTimePicker3.Value.Month & "." & DateTimePicker3.Value.Year
            oSheet.Range("O3").Value = CType(ComboBox8.Text, String)
            oSheet.Range("O3").Value = CType(TextBox13.Text, String)
        Else
            Dim i As Integer = nextrow(oExcel, oBook, oSheet)

            Dim dt As DateTime = DateTimePicker2.Value.AddDays(+30)
            DateTimePicker3.Text = dt
            DateTimePicker3.Visible = True
            oSheet.Range("A" & i).Value = DateTimePicker2.Value.Day & "." & DateTimePicker2.Value.Month & "." & DateTimePicker2.Value.Year
            oSheet.Range("B" & i).Value = CType(TextBox2.Text, String)
            oSheet.Range("C" & i).Value = DateTimePicker1.Value.Day & "." & DateTimePicker1.Value.Month & "." & DateTimePicker1.Value.Year
            oSheet.Range("D" & i).Value = CType(TextBox4.Text, String)
            oSheet.Range("E" & i).Value = CType(TextBox5.Text, String)

            oSheet.Range("F" & i).Value = CType(ComboBox1.Text, String)
            oSheet.Range("G" & i).Value = CType(ComboBox2.Text, String)
            oSheet.Range("H" & i).Value = CType(ComboBox3.Text, String)
            oSheet.Range("I" & i).Value = CType(ComboBox4.Text, String)
            oSheet.Range("J" & i).Value = CType(ComboBox5.Text, String)
            oSheet.Range("K" & i).Value = CType(ComboBox6.Text, String)
            oSheet.Range("L" & i).Value = CType(TextBox12.Text, String)
            oSheet.Range("M" & i).Value = CType(ComboBox7.Text, String)
            oSheet.Range("N" & i).Value = DateTimePicker3.Value.Day & "." & DateTimePicker3.Value.Month & "." & DateTimePicker3.Value.Year
            oSheet.Range("O" & i).Value = CType(ComboBox8.Text, String)
            oSheet.Range("P" & i).Value = CType(TextBox13.Text, String)
        End If

        oExcel.Application.DisplayAlerts = False
        'oExcel.Application.ScreenUpdating = False
        'Save the Workbook and Quit Excel

        Try
            oBook.SaveAs("E:\Users\Omkar\exportform.xlsx")
        Catch
            MessageBox.Show("The excel file cannot be saved as some other user is operating on it.Please try again later.")
        End Try

        oBook.close()
        oExcel.Application.DisplayAlerts = True
        '-------

        oExcel.Quit()
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

        oExcel = Nothing
        oBook = Nothing
        oSheet = Nothing

        System.GC.Collect()
        System.GC.Collect()
        '-----------------

    End Sub
    Private Function nextrow(ByVal oExcel As Object, ByVal oBook As Object, ByVal oSheet As Object) As Integer
        Dim i As Integer = 3
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






    Private Sub ImportExport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
