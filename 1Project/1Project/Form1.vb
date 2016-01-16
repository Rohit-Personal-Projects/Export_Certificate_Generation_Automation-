Imports System.Text.RegularExpressions

Public Class Form1

    Private Sub bsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsubmit.Click
        Dim val As Boolean = False
        val = validator()

        If val Then
            MessageBox.Show("All details valid")
        Else
            MessageBox.Show("email id incorrect")
        End If

    End Sub

    Function validator() As Boolean





        'email val
        If EmailAddressCheck(temail.Text) Then
            MessageBox.Show("All details valid")
        Else
            MessageBox.Show("email id incorrect")
        End If


        'phone Val
        Dim ph As Boolean = False

        Try
            Dim fd As Double
            fd = CType(tphone.Text, Double)
        Catch ex As Exception
            ph = True
        End Try

        'If ph = False And valphone(tphone.Text) Then
        If ph = False Then
            MessageBox.Show("p.Correct")
        Else
            MessageBox.Show("p.Wrong")
        End If


        'mode val
        If tmode.Text = tmode.Items(0) Or
            tmode.Text = tmode.Items(1) Or
            tmode.Text = tmode.Items(2) Or
            tmode.Text = tmode.Items(3) Then
            MessageBox.Show("m.correct")
        Else
            MessageBox.Show("m.Wrong")
        End If
    End Function

    'to check if its a 10-digit no
    Function valphone(ByVal emailAddress As String) As Boolean
        Dim pattern As String = "^\d{10}$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)
        If emailAddressMatch.Success Then
            valphone = True
        Else
            valphone = False
        End If
    End Function


    Function EmailAddressCheck(ByVal emailAddress As String) As Boolean
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)
        If emailAddressMatch.Success Then
            EmailAddressCheck = True
        Else
            EmailAddressCheck = False
        End If
    End Function
End Class
