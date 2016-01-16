<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tname = New System.Windows.Forms.TextBox()
        Me.tphone = New System.Windows.Forms.TextBox()
        Me.temail = New System.Windows.Forms.TextBox()
        Me.lname = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tmode = New System.Windows.Forms.ComboBox()
        Me.bsubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tname
        '
        Me.tname.Location = New System.Drawing.Point(123, 22)
        Me.tname.Name = "tname"
        Me.tname.Size = New System.Drawing.Size(252, 20)
        Me.tname.TabIndex = 0
        '
        'tphone
        '
        Me.tphone.Location = New System.Drawing.Point(123, 58)
        Me.tphone.Name = "tphone"
        Me.tphone.Size = New System.Drawing.Size(252, 20)
        Me.tphone.TabIndex = 1
        '
        'temail
        '
        Me.temail.Location = New System.Drawing.Point(123, 96)
        Me.temail.Name = "temail"
        Me.temail.Size = New System.Drawing.Size(252, 20)
        Me.temail.TabIndex = 2
        '
        'lname
        '
        Me.lname.AutoSize = True
        Me.lname.Location = New System.Drawing.Point(22, 25)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(35, 13)
        Me.lname.TabIndex = 3
        Me.lname.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Phone No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mode Of Payment"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Email-Id"
        '
        'tmode
        '
        Me.tmode.FormattingEnabled = True
        Me.tmode.Items.AddRange(New Object() {"irrevocablee letter of credit", "FIRC", "Advance Payment(Min 25%)", "Cash againsh docs"})
        Me.tmode.Location = New System.Drawing.Point(123, 131)
        Me.tmode.Name = "tmode"
        Me.tmode.Size = New System.Drawing.Size(252, 21)
        Me.tmode.TabIndex = 8
        '
        'bsubmit
        '
        Me.bsubmit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bsubmit.Location = New System.Drawing.Point(0, 175)
        Me.bsubmit.Name = "bsubmit"
        Me.bsubmit.Size = New System.Drawing.Size(410, 45)
        Me.bsubmit.TabIndex = 9
        Me.bsubmit.Text = "Submit"
        Me.bsubmit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 220)
        Me.Controls.Add(Me.bsubmit)
        Me.Controls.Add(Me.tmode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lname)
        Me.Controls.Add(Me.temail)
        Me.Controls.Add(Me.tphone)
        Me.Controls.Add(Me.tname)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tname As System.Windows.Forms.TextBox
    Friend WithEvents tphone As System.Windows.Forms.TextBox
    Friend WithEvents temail As System.Windows.Forms.TextBox
    Friend WithEvents lname As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tmode As System.Windows.Forms.ComboBox
    Friend WithEvents bsubmit As System.Windows.Forms.Button

End Class
