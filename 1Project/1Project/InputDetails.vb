Imports System.Text.RegularExpressions
Imports System.Runtime.InteropServices
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop.Word
Imports Microsoft.Office.Interop

'true stands for valid

'current status
'1.disabled all validations for ease
'2.but click has comments which has excel sheet formattin
'3.1st entry handled
'4.modified 2nd entry to next entry
'5.comma addded b4 phone nos startin wit 0, else start ka 0s are deleted
'6.overwrite without prompt
'7.interop pkg
'8.created word file
'9.RC incr
'10.certi
'11.table lines
'12.excel borders
'13.each certi in new folder
'14.foreign buyer details
'15.date format dd.mm.yyyy

'to handle
'1.DGFT server (last)
'2.make a manual

''extract date parts
'Dim z As String
'            z = oSheet.Range("B" & i).Value
'            MessageBox.Show(z)
'            z.Split()


Public Class InputDetails
    Private Sub bsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsubmit.Click
        Dim val As Boolean = False
        'val = validator()
        val = v2()
        If tphone.Text.StartsWith("0") Then
            tphone.Text = "," & tphone.Text
        End If

        'fills d unfilled field after conversion
        quantity()

        If val Then
            MessageBox.Show("All details valid")
            'store in database
            excelfn()
            'wordfn()
        Else
            MessageBox.Show("Pls enter incomplete data and click on submit again")
        End If

    End Sub
    Function v2() As Boolean
        Return True
    End Function
    Function validator() As Boolean

        Dim flag As Boolean = True

        ''file no val (is it only digits)
        'If phoneval(tfileno.Text) = False Then
        '    MessageBox.Show("File Number Invalid")
        'End If

        'file no val
        If tfileno.Text = Nothing Then
            MessageBox.Show("File Number cannot be empty")
            Return False
        End If

        'IEC no val
        If phoneval(tiec.Text) = False Then
            MessageBox.Show("IEC Number Invalid")
            Return False
        End If

        'email val
        If Emailval(temail.Text) = False Then
            MessageBox.Show("email id incorrect")
            Return False
        End If

        'phone Val
        If phoneval(tphone.Text) = False Then
            MessageBox.Show("Phone Number incorrect")
            Return False
        End If

        'quantity val
        If tqmt.Text <> Nothing Then
            If phoneval(tqmt.Text) = False Then
                MessageBox.Show("Quantity in MT should be in digits")
                Return False
            End If
        End If
        If tqbales.Text <> Nothing Then
            If phoneval(tqbales.Text) = False Then
                MessageBox.Show("Quantity in Bales should be in digits")
                Return False
            End If
        End If

        'mode val
        If modeval() = False Then
            MessageBox.Show("Mode of Payment incorrect")
            Return False
        End If

        Return flag
    End Function
    Function Emailval(ByVal emailAddress As String) As Boolean
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)
        If emailAddressMatch.Success Then
            Emailval = True
        Else
            Emailval = False
        End If
    End Function
    Private Function phoneval(ByVal p1 As String) As Boolean
        Dim ph As Boolean = False

        Try
            Dim fd As Double
            fd = CType(p1, Double)
        Catch ex As Exception
            ph = True
        End Try

        'If ph = False And valphone(tphone.Text) Then
        If ph = False Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function modeval() As Boolean
        If tmode.Text = tmode.Items(0) Or
            tmode.Text = tmode.Items(1) Or
            tmode.Text = tmode.Items(2) Or
            tmode.Text = tmode.Items(3) Then
            Return True
        Else
            Return False
        End If
    End Function
    Sub excelfn()
        Dim oExcel As Object
        Dim oBook As Object
        Dim oSheet As Object

        'Start a new workbook in Excel
        oExcel = CreateObject("Excel.Application")
        oBook = oExcel.Workbooks.Open("G:\Bhadhresh Files\Export Data.xlsx")
        'Add data to cells of the first worksheet in the new workbook
        oSheet = oBook.Worksheets(1)

        If oSheet.Range("A1").Value = "" Then
            'TITLES
            oSheet.Range("A1").Value = "File Number"
            oSheet.Range("B1").Value = "Date"
            oSheet.Range("C1").Value = "IEC Number"
            oSheet.Range("D1").Value = "Name"
            oSheet.Range("E1").Value = "Address"
            oSheet.Range("F1").Value = "Email-id"
            oSheet.Range("G1").Value = "Phone No"
            oSheet.Range("H1").Value = "RC Number"
            oSheet.Range("I1").Value = "ITC(HS) Code"
            oSheet.Range("J1").Value = "Export Item Description"
            oSheet.Range("K1").Value = "Quantity(MT)"
            oSheet.Range("L1").Value = "Quantity(Bales)"
            oSheet.Range("M1").Value = "Mode Of Payment"
            oSheet.Range("N1").Value = "FOB in US$"
            oSheet.Range("O1").Value = "FOB in INR"
            oSheet.Range("P1").Value = "Signing Authority"
            oSheet.Range("A1:P1").Font.Bold = True


            'DATA
            oSheet.Range("A2").Value = tfileno.Text
            oSheet.Range("B2").Value = tdate.Value.Day & "." & tdate.Value.Month & "." & tdate.Value.Year
            oSheet.Range("C2").Value = tiec.Text
            oSheet.Range("D2").Value = tname.Text
            oSheet.Range("E2").Value = taddress.Text
            oSheet.Range("F2").Value = temail.Text
            oSheet.Range("G2").Value = CType(tphone.Text, String)
            oSheet.Range("H2").Value = 1
            oSheet.Range("I2").Value = titc.Text
            oSheet.Range("J2").Value = tdescrip.Text
            oSheet.Range("K2").Value = tqmt.Text
            oSheet.Range("L2").Value = tqbales.Text
            oSheet.Range("M2").Value = tmode.Text
            oSheet.Range("N2").Value = tfobd.Text
            oSheet.Range("O2").Value = tfobr.Text
            oSheet.Range("P2").Value = tauth.Text

        Else
            Dim i As Integer = nextrow(oExcel, oBook, oSheet)

            'DATA
            oSheet.Range("A" & i).Value = tfileno.Text
            oSheet.Range("B" & i).Value = tdate.Value.Day & "." & tdate.Value.Month & "." & tdate.Value.Year
            oSheet.Range("C" & i).Value = tiec.Text
            oSheet.Range("D" & i).Value = tname.Text
            oSheet.Range("E" & i).Value = taddress.Text
            oSheet.Range("F" & i).Value = temail.Text
            oSheet.Range("G" & i).Value = CType(tphone.Text, String)
            oSheet.Range("H" & i).Value = i
            oSheet.Range("I" & i).Value = titc.Text
            oSheet.Range("J" & i).Value = tdescrip.Text
            oSheet.Range("K" & i).Value = tqmt.Text
            oSheet.Range("L" & i).Value = tqbales.Text
            oSheet.Range("M" & i).Value = tmode.Text
            oSheet.Range("N" & i).Value = tfobd.Text
            oSheet.Range("O" & i).Value = tfobr.Text
            oSheet.Range("P" & i).Value = tauth.Text
        End If

        Dim j As Integer = nextrow(oExcel, oBook, oSheet)
        oExcel.Range("A1:P" & j - 1).BORDERS.Color = RGB(0, 0, 0)
        wordfn(j)

        oExcel.Application.DisplayAlerts = False
        'oExcel.Application.ScreenUpdating = False
        'Save the Workbook and Quit Excel
        oBook.SaveAs("G:\Bhadhresh Files\Export Data.xlsx")
        oBook.SaveAs("G:\Bhadhresh Files\Data Backup.xlsx")
        oExcel.Application.DisplayAlerts = True
        '-------

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
        '-----------------

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
    'Sub excelformat()
    'Dim ApExcel As Object 'To open Excel
    'ApExcel = CreateObject("Excel.application") 'Creates an object
    'ApExcel.Visible = True ' So you can see Excel
    'ApExcel.Workbooks.Add() 'Adds a new book.
    'ApExcel.cells(1, 1).Formula = "HELLO"   'Add Text to a Cell
    ''You can use the line above, changing coordenates to go to any 
    ''cell and you can also add Formulas
    'ApExcel.Range("A1:Z1").BORDERS.Color = RGB(0, 0, 0) 'Use it to 
    ''change the borders.
    'ApExcel.Columns("A:AY").EntireColumn.AutoFit() 'To adjust the 
    ''column's width.
    'ApExcel.Range("A:Z").Select() 'To establish a selection
    'ApExcel.Selection.NumberFormat = "0" 'Adding different formats
    'End Sub
    Private Sub wordfn(ByVal r As Integer)
        Dim oWord As Word.Application
        Dim oDoc As Word.Document
        Dim oTable As Word.Table
        Dim oPara1 As Word.Paragraph, oPara2 As Word.Paragraph
        Dim oPara3 As Word.Paragraph, oPara4 As Word.Paragraph
        Dim oPara31 As Word.Paragraph
        Dim oPara32 As Word.Paragraph
        Dim oPara33 As Word.Paragraph
        Dim oPara5 As Word.Paragraph
        Dim oPara6 As Word.Paragraph, oPara7 As Word.Paragraph
        Dim oPara8 As Word.Paragraph, oPara9 As Word.Paragraph
        Dim oPara10 As Word.Paragraph, oPara11 As Word.Paragraph
        'Dim oPara12 As Word.Paragraph

        'Start Word and open the document template.
        oWord = CreateObject("Word.Application")
        oWord.Visible = False
        oDoc = oWord.Documents.Add

        '*****************************  HEADINGS  ***********************************

        'Insert a paragraph at the beginning of the document.
        oPara1 = oDoc.Content.Paragraphs.Add
        Dim PIctureLocation As String = "G:\Bhadhresh Files\india.jpg"
        oDoc.Bookmarks.Item("\endofdoc").Range.InlineShapes.AddPicture(PIctureLocation)
        oPara1.Range.Text = ""
        oPara1.Range.Font.Bold = True
        oPara1.Range.Font.Underline = True
        oPara1.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
        oPara1.Format.SpaceAfter = 10    '24 pt spacing after paragraph.
        oPara1.Range.InsertParagraphAfter()

        'Insert a paragraph at the end of the document.
        '** \endofdoc is a predefined bookmark.
        oPara2 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara2.Range.Text = "Registration Certificate of " & tdescrip.Text
        oPara2.Format.SpaceAfter = 8
        oPara2.Range.InsertParagraphAfter()
        oPara2.Range.Font.Underline = False
        oPara2.Range.Font.Bold = False
        oPara2.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft

        'Insert another paragraph.
        oPara3 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara3.Range.Text = "No. DGFT/MUMBAI/" & tdescrip.Text & "/2012-13/RC." & "23" & "/AM13                               Dated: " & tdate.Value
        oPara3.Format.SpaceAfter = 10
        oPara3.Range.InsertParagraphAfter()

        'Insert another paragraph.
        oPara31 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara31.Range.Font.Bold = True
        oPara31.Range.Font.Underline = True
        oPara31.Range.Text = "(A) Applicant's Details"
        oPara31.Format.SpaceAfter = 8
        oPara31.Range.InsertParagraphAfter()

        oPara32 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara32.Range.Text = "1." & vbTab & "Name of the Firm/Company" & vbTab & ": " & tname.Text & vbNewLine & "2." & vbTab & "Address" & vbTab & vbTab & vbTab & vbTab & ": " & taddress.Text & vbNewLine & "3." & vbTab & "IEC" & vbNewLine & vbTab & vbTab & "(i) Number" & vbTab & vbTab & ": " & tiec.Text & vbNewLine & vbTab & vbTab & "(i) Issuing Authority" & vbTab & ": O/O ADDITIONAL D.G.F.T., MUMBAI." & vbNewLine
        oPara32.Range.InsertParagraphAfter()
        oPara32.Format.SpaceAfter = 30

        oPara33 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara33.Range.Text = "(B) Contracts Registration Details:"
        oPara33.Range.Font.Bold = True
        oPara33.Range.Font.Underline = True
        oPara33.Range.InsertParagraphAfter()
        oPara33.Format.SpaceAfter = 10

        'Insert a 2 x 5 table, fill it with data, and make the first row bold
        oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 2, 5)
        oTable.Borders.Enable = Word.WdLineStyle.wdLineStyleSingle

        oTable.Cell(1, 1).Range.Text = "(1) Tariff Code"
        oTable.Cell(1, 2).Range.Text = "(2) Item Description"
        oTable.Cell(1, 3).Range.Text = "(3) Quantity"
        oTable.Cell(1, 4).Range.Text = "(4) Foreign Buyer Details"
        oTable.Cell(1, 5).Range.Text = "(5) Payment Terms"

        oTable.Cell(2, 1).Range.Text = titc.Text
        oTable.Cell(2, 2).Range.Text = tdescrip.Text
        oTable.Cell(2, 3).Range.Text = tqmt.Text & " MT" & vbNewLine & tqbales.Text & " Bales"
        oTable.Cell(2, 4).Range.Text = "1.Name :" & texp1.Text & vbNewLine & "2.Address:" & texp2.Text & vbNewLine & "3.Phone No:" & texp3.Text & vbNewLine & "4.Fax No.:" & texp4.Text & vbNewLine & "5.Email:" & texp5.Text & vbNewLine & "6.Contract No.:" & texp6.Text
        oTable.Cell(2, 5).Range.Text = tmode.Text

        oTable.Rows.Item(1).Range.Font.Bold = True
        oTable.Rows.Item(1).Range.Font.Underline = False
        oTable.Rows.Item(1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter

        oTable.Rows.Item(2).Range.Font.Bold = False
        oTable.Rows.Item(2).Range.Font.Underline = False

        oTable.Columns.Item(1).Width = oWord.InchesToPoints(0.7)   'Change width of columns 1 & 2
        oTable.Columns.Item(2).Width = oWord.InchesToPoints(1)
        oTable.Columns.Item(3).Width = oWord.InchesToPoints(0.7)
        oTable.Columns.Item(4).Width = oWord.InchesToPoints(2.5)
        oTable.Columns.Item(5).Width = oWord.InchesToPoints(1.5)

        oTable.Range.InsertParagraphAfter()

        'Add some text after the table.
        oPara4 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara4.Range.Text = ""
        oPara4.Format.SpaceAfter = 30
        oPara4.Range.InsertParagraphAfter()
        oPara4.Range.Font.Underline = False

        oPara5 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara5.Range.Text = "(C) Validity" & vbTab & ": 30 DAYS FROM THE ISSUANCE OF CERTIFICATE"
        oPara5.Format.SpaceAfter = 2
        oPara5.Range.InsertParagraphAfter()
        oPara5.Range.Font.Bold = True
        oPara5.Range.Font.Underline = False

        oPara6 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara6.Range.Text = "Note:" & vbNewLine & vbNewLine
        oPara6.Range.InsertParagraphAfter()
        oPara6.Range.Font.Bold = False
        oPara6.Range.Font.Underline = False

        oPara7 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara7.Range.Font.Bold = True
        oPara7.Range.Text = "(D) Time to Export (Validity of RC):"
        oPara7.Range.Font.Bold = False
        oPara7.Range.InsertParagraphAfter()
        oPara7.Range.Font.Size = 8

        oPara8 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara8.Range.Text = vbTab & "Export must be completed within 30 days from the date of issuance of the RC. The validity of the RC would expire after 30 days. Failure to complete export of the full quantity (with a tolerance of 5% by weight) for which RC was obtained would entail" & vbNewLine & vbTab & "(a) Debarment from obtaining any Registration Certificate in future, in addition to initiation of penal action under Section 11(2) of Foreign Trade (Development & Regulation) Act, 1992, (as amended)."
        oPara8.Range.InsertParagraphAfter()
        oPara8.Format.SpaceAfter = 10
        oPara8.Range.Font.Size = 10

        oPara9 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara9.Range.Text = vbNewLine & "(E) Reporting"
        oPara9.Range.Font.Bold = True
        oPara9.Range.InsertParagraphAfter()
        oPara9.Range.Font.Size = 8
        oPara9.Range.Font.Bold = False

        oPara10 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara10.Range.Text = vbTab & "Holders of the RC would observe a two stage reporting system, sending two reports to the RA from whom the RC was obtained" & vbNewLine & vbTab & "(a) a simple first report only about the quantity of export, to whom exported and when exported, in respect of each consignment immediately on obtaining the Let Export Order (LEO) and" & vbNewLine & vbTab & "(b) a consolidated second report within 35 days of the issue of RC in detail (EP copy of shipping bill required) about all exports done in respect of the complete quantity for which the RC was obtained." & vbNewLine & vbNewLine
        oPara10.Range.InsertParagraphAfter()
        oPara10.Range.Font.Bold = False
        oPara10.Range.Font.Size = 14

        oPara11 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara10.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
        oPara11.Range.Text = "Yours faithfully" & vbNewLine & vbNewLine & tauth.Text & vbNewLine & "Asstt. Director General of Foreign Trade" & vbNewLine & "For Addl. Director General of Foreign Trade, Mumbai"
        oPara11.Range.InsertParagraphAfter()
        oPara11.Range.Font.Size = 14



        '**************** WORD LOGIC ENDS *******************

        Dim docname As String
        docname = "G:\Bhadhresh Files\Certificates\Certificate RC no. " & r & ".docx"
        oDoc.SaveAs(docname)
        'All done. Close this form.
        Me.Close()
        oWord.Quit()
        oWord = Nothing
        oDoc = Nothing
        System.GC.Collect()
        System.GC.Collect()
    End Sub
    Private Sub quantity()
        If tqmt.Text <> Nothing Then
            Dim q As Double
            q = CType(tqmt.Text, Double)
            q = q * 5.882353
            Dim s As String
            s = CType(q, String)
            tqbales.Text = s
        End If

        If tqbales.Text <> Nothing Then
            Dim q1 As Double
            q1 = CType(tqbales.Text, Double)
            q1 = q1 / 5.882353
            Dim s1 As String
            s1 = CType(q1, String)
            tqmt.Text = s1
        End If
    End Sub
End Class