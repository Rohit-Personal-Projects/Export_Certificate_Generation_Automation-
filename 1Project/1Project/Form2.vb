Imports System.Text.RegularExpressions

'true stands for valid

Public Class Form1

    Private Sub bsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsubmit.Click
        Dim val As Boolean = False
        'val = validator()
        val = vali2()

        If val Then
            MessageBox.Show("All details valid")
            'store in database
        Else
            MessageBox.Show("Pls enter incomplete data and click on submit again")
        End If

        a()
    End Sub

    Function vali2() As Boolean
        Return True
    End Function

    Function validator() As Boolean

        Dim flag As Boolean = True

        'email val
        If Emailval(temail.Text) = False Then
            MessageBox.Show("email id incorrect")
            flag = False
        End If

        'phone Val
        If phoneval(tphone.Text) = False Then
            MessageBox.Show("Phone Number incorrect")
            flag = False
        End If

        'mode val
        If modeval() = False Then
            MessageBox.Show("Mode of Payment incorrect")
            flag = False
        End If

        Return flag
    End Function

    'to check if its a 10-digit no (not used)
    Function valphone(ByVal emailAddress As String) As Boolean
        Dim pattern As String = "^\d{10}$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)
        If emailAddressMatch.Success Then
            valphone = True
        Else
            valphone = False
        End If
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

    Sub a()
        Dim oExcel As Object
        Dim oBook As Object
        Dim oSheet As Object

        'Start a new workbook in Excel
        oExcel = CreateObject("Excel.Application")
        oBook = oExcel.Workbooks.Add


        'Add data to cells of the first worksheet in the new workbook
        oSheet = oBook.Worksheets(1)
        'TITLES
        oSheet.Range("A1").Value = "NAME"
        oSheet.Range("B1").Value = "PHONE NO"
        oSheet.Range("C1").Value = "E-MAIL ID"
        oSheet.Range("D1").Value = "MODE OF PAYMENT"
        oSheet.Range("A1:D1").Font.Bold = True

        'DATA

        'find blank row
        MessageBox.Show(oSheet.Range("A2").Value)
        oSheet.Range("A2").Value = tname.Text
        oSheet.Range("B2").Value = tphone.Text
        oSheet.Range("C2").Value = temail.Text
        oSheet.Range("D2").Value = tmode.Text

        'Save the Workbook and Quit Excel
        oBook.SaveAs("G:\Export Data.xlsx")
        oBook.SaveAs("G:\Data Backup.xlsx")
        oExcel.Quit()
    End Sub

End Class
