Public Class GUI

    Public Shared str As String
    Private Sub GUI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Visible = True

        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.Image = Image.FromFile("importexport.jpg")
        PictureBox1.Parent = Me
        Me.Controls.Add(PictureBox1)
        PictureBox1.BringToFront()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bgen.Click
        str = "rohit-PC"

        If RadioButton1.Checked Then
            Dim aa As New dr
            aa.Show()
        End If

        If RadioButton3.Checked Then
            Dim aa As New mr
            aa.Show()
        End If

        If Rb2.Checked Then
            Dim aa As New iecr
            aa.Show()
        End If

        If Rb3.Checked Then
            Dim aa As New itc
            aa.Show()
        End If

        If Rb4.Checked Then
            Dim aa As New mdr
            aa.Show()
        End If

        'If RadioButton4.Checked Then
        '    'Dim aa As New 
        '    'aa.Show()
        'End If

    End Sub

    Private Sub bissue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bissue.Click
        str = "rohit-PC"

        Dim aa As New InputDetails
        aa.show()
    End Sub

    Private Sub bexp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bexp.Click
        str = "rohit-PC"

        Dim aa As New ie
        aa.Show()
    End Sub

    Private Sub bmonitor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bmonitor.Click
        str = "rohit-PC"

        If RadioButton5.Checked Then
            Dim aa As New iecm
            aa.Show()
        End If

        If RadioButton6.Checked Then
            Dim aa As New rcm
            aa.Show()
        End If

        If RadioButton7.Checked Then
            Dim aa As New rcimpexp
            aa.Show()
        End If

        'If RadioButton8.Checked Then
        '    Dim aa As New 
        '    aa.Show()
        'End If

        'If RadioButton9.Checked Then
        '    Dim aa As New 
        '    aa.Show()
        'End If

        If RadioButton10.Checked Then
            Dim aa As New lds
            aa.Show()
        End If

        If RadioButton11.Checked Then
            Dim aa As New docs
            aa.Show()
        End If


    End Sub

    Private Sub bsummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged

    End Sub
End Class
