<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InputDetails))
        Me.tname = New System.Windows.Forms.TextBox()
        Me.tphone = New System.Windows.Forms.TextBox()
        Me.temail = New System.Windows.Forms.TextBox()
        Me.lname = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tmode = New System.Windows.Forms.ComboBox()
        Me.bsubmit = New System.Windows.Forms.Button()
        Me.tiec = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tfileno = New System.Windows.Forms.TextBox()
        Me.tdate = New System.Windows.Forms.DateTimePicker()
        Me.taddress = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tfobd = New System.Windows.Forms.TextBox()
        Me.tauth = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tfobr = New System.Windows.Forms.TextBox()
        Me.tqmt = New System.Windows.Forms.TextBox()
        Me.tqbales = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.titc = New System.Windows.Forms.TextBox()
        Me.tdescrip = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.texp1 = New System.Windows.Forms.TextBox()
        Me.texp2 = New System.Windows.Forms.TextBox()
        Me.texp3 = New System.Windows.Forms.TextBox()
        Me.texp4 = New System.Windows.Forms.TextBox()
        Me.texp5 = New System.Windows.Forms.TextBox()
        Me.texp6 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tname
        '
        Me.tname.Location = New System.Drawing.Point(143, 135)
        Me.tname.Name = "tname"
        Me.tname.Size = New System.Drawing.Size(293, 22)
        Me.tname.TabIndex = 3
        '
        'tphone
        '
        Me.tphone.Location = New System.Drawing.Point(143, 219)
        Me.tphone.Name = "tphone"
        Me.tphone.Size = New System.Drawing.Size(293, 22)
        Me.tphone.TabIndex = 6
        '
        'temail
        '
        Me.temail.Location = New System.Drawing.Point(143, 191)
        Me.temail.Name = "temail"
        Me.temail.Size = New System.Drawing.Size(293, 22)
        Me.temail.TabIndex = 5
        '
        'lname
        '
        Me.lname.AutoSize = True
        Me.lname.Location = New System.Drawing.Point(17, 138)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(37, 14)
        Me.lname.TabIndex = 3
        Me.lname.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Phone No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 371)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 14)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mode Of Payment"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 14)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Email-Id"
        '
        'tmode
        '
        Me.tmode.FormattingEnabled = True
        Me.tmode.Items.AddRange(New Object() {"irrevocablee letter of credit", "firc", "advance payment(min 25%)", "cash againsh docs"})
        Me.tmode.Location = New System.Drawing.Point(143, 369)
        Me.tmode.Name = "tmode"
        Me.tmode.Size = New System.Drawing.Size(293, 22)
        Me.tmode.TabIndex = 12
        '
        'bsubmit
        '
        Me.bsubmit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bsubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bsubmit.Location = New System.Drawing.Point(0, 660)
        Me.bsubmit.Name = "bsubmit"
        Me.bsubmit.Size = New System.Drawing.Size(551, 49)
        Me.bsubmit.TabIndex = 16
        Me.bsubmit.Text = "Submit"
        Me.bsubmit.UseVisualStyleBackColor = True
        '
        'tiec
        '
        Me.tiec.Location = New System.Drawing.Point(143, 107)
        Me.tiec.Name = "tiec"
        Me.tiec.Size = New System.Drawing.Size(293, 22)
        Me.tiec.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(17, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 14)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "IEC Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 14)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "File Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 14)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 166)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 14)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Address Of Applicant"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 253)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 14)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "RC Number"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 283)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 14)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "ITC(HS) Code"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 314)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 14)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Export Item Description"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(17, 343)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 14)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Quantity"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(229, 343)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 14)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "MT"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(399, 343)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 14)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Bales"
        '
        'tfileno
        '
        Me.tfileno.Location = New System.Drawing.Point(143, 51)
        Me.tfileno.Name = "tfileno"
        Me.tfileno.Size = New System.Drawing.Size(293, 22)
        Me.tfileno.TabIndex = 0
        '
        'tdate
        '
        Me.tdate.Location = New System.Drawing.Point(143, 79)
        Me.tdate.Name = "tdate"
        Me.tdate.Size = New System.Drawing.Size(293, 22)
        Me.tdate.TabIndex = 1
        '
        'taddress
        '
        Me.taddress.Location = New System.Drawing.Point(143, 163)
        Me.taddress.Name = "taddress"
        Me.taddress.Size = New System.Drawing.Size(293, 22)
        Me.taddress.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(17, 400)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 14)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "FOB Value in US$"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(17, 464)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(97, 14)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Signing Authority"
        '
        'tfobd
        '
        Me.tfobd.Location = New System.Drawing.Point(143, 398)
        Me.tfobd.Name = "tfobd"
        Me.tfobd.Size = New System.Drawing.Size(293, 22)
        Me.tfobd.TabIndex = 13
        '
        'tauth
        '
        Me.tauth.Location = New System.Drawing.Point(143, 461)
        Me.tauth.Name = "tauth"
        Me.tauth.Size = New System.Drawing.Size(293, 22)
        Me.tauth.TabIndex = 15
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(17, 432)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(94, 14)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "FOB Value in INR"
        '
        'tfobr
        '
        Me.tfobr.Location = New System.Drawing.Point(143, 428)
        Me.tfobr.Name = "tfobr"
        Me.tfobr.Size = New System.Drawing.Size(293, 22)
        Me.tfobr.TabIndex = 14
        '
        'tqmt
        '
        Me.tqmt.Location = New System.Drawing.Point(143, 341)
        Me.tqmt.Name = "tqmt"
        Me.tqmt.Size = New System.Drawing.Size(77, 22)
        Me.tqmt.TabIndex = 10
        '
        'tqbales
        '
        Me.tqbales.Location = New System.Drawing.Point(300, 341)
        Me.tqbales.Name = "tqbales"
        Me.tqbales.Size = New System.Drawing.Size(88, 22)
        Me.tqbales.TabIndex = 11
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(262, 343)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(18, 14)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "or"
        '
        'titc
        '
        Me.titc.Location = New System.Drawing.Point(143, 280)
        Me.titc.Name = "titc"
        Me.titc.Size = New System.Drawing.Size(293, 22)
        Me.titc.TabIndex = 8
        '
        'tdescrip
        '
        Me.tdescrip.Location = New System.Drawing.Point(143, 311)
        Me.tdescrip.Name = "tdescrip"
        Me.tdescrip.Size = New System.Drawing.Size(293, 22)
        Me.tdescrip.TabIndex = 9
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(157, 9)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(218, 24)
        Me.Label19.TabIndex = 38
        Me.Label19.Text = "ISSUANCE DETAILS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(143, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 14)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "(Autogenerated)"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label20.Location = New System.Drawing.Point(17, 495)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(121, 14)
        Me.Label20.TabIndex = 40
        Me.Label20.Text = "Foreign Buyer Details:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(171, 498)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(37, 14)
        Me.Label21.TabIndex = 41
        Me.Label21.Tag = ""
        Me.Label21.Text = "Name"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(171, 553)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(59, 14)
        Me.Label22.TabIndex = 42
        Me.Label22.Text = "Phone No."
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(171, 581)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(44, 14)
        Me.Label23.TabIndex = 43
        Me.Label23.Text = "Fax No."
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(171, 609)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(51, 14)
        Me.Label24.TabIndex = 44
        Me.Label24.Text = "Email-Id"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(171, 637)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(70, 14)
        Me.Label25.TabIndex = 45
        Me.Label25.Text = "Contract No."
        '
        'texp1
        '
        Me.texp1.Location = New System.Drawing.Point(252, 495)
        Me.texp1.Name = "texp1"
        Me.texp1.Size = New System.Drawing.Size(184, 22)
        Me.texp1.TabIndex = 46
        '
        'texp2
        '
        Me.texp2.Location = New System.Drawing.Point(252, 522)
        Me.texp2.Name = "texp2"
        Me.texp2.Size = New System.Drawing.Size(184, 22)
        Me.texp2.TabIndex = 47
        '
        'texp3
        '
        Me.texp3.Location = New System.Drawing.Point(252, 550)
        Me.texp3.Name = "texp3"
        Me.texp3.Size = New System.Drawing.Size(184, 22)
        Me.texp3.TabIndex = 48
        '
        'texp4
        '
        Me.texp4.Location = New System.Drawing.Point(252, 578)
        Me.texp4.Name = "texp4"
        Me.texp4.Size = New System.Drawing.Size(184, 22)
        Me.texp4.TabIndex = 49
        '
        'texp5
        '
        Me.texp5.Location = New System.Drawing.Point(252, 606)
        Me.texp5.Name = "texp5"
        Me.texp5.Size = New System.Drawing.Size(184, 22)
        Me.texp5.TabIndex = 50
        '
        'texp6
        '
        Me.texp6.Location = New System.Drawing.Point(252, 634)
        Me.texp6.Name = "texp6"
        Me.texp6.Size = New System.Drawing.Size(184, 22)
        Me.texp6.TabIndex = 51
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(171, 525)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(49, 14)
        Me.Label26.TabIndex = 52
        Me.Label26.Text = "Address"
        '
        'InputDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(551, 709)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.texp6)
        Me.Controls.Add(Me.texp5)
        Me.Controls.Add(Me.texp4)
        Me.Controls.Add(Me.texp3)
        Me.Controls.Add(Me.texp2)
        Me.Controls.Add(Me.texp1)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.tdescrip)
        Me.Controls.Add(Me.titc)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.tqbales)
        Me.Controls.Add(Me.tqmt)
        Me.Controls.Add(Me.tfobr)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.tauth)
        Me.Controls.Add(Me.tfobd)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.taddress)
        Me.Controls.Add(Me.tdate)
        Me.Controls.Add(Me.tfileno)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tiec)
        Me.Controls.Add(Me.bsubmit)
        Me.Controls.Add(Me.tmode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lname)
        Me.Controls.Add(Me.temail)
        Me.Controls.Add(Me.tphone)
        Me.Controls.Add(Me.tname)
        Me.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InputDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Input Details"
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
    Friend WithEvents tiec As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tfileno As System.Windows.Forms.TextBox
    Friend WithEvents tdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents taddress As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents tfobd As System.Windows.Forms.TextBox
    Friend WithEvents tauth As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents tfobr As System.Windows.Forms.TextBox
    Friend WithEvents tqmt As System.Windows.Forms.TextBox
    Friend WithEvents tqbales As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents titc As System.Windows.Forms.TextBox
    Friend WithEvents tdescrip As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents texp1 As System.Windows.Forms.TextBox
    Friend WithEvents texp2 As System.Windows.Forms.TextBox
    Friend WithEvents texp3 As System.Windows.Forms.TextBox
    Friend WithEvents texp4 As System.Windows.Forms.TextBox
    Friend WithEvents texp5 As System.Windows.Forms.TextBox
    Friend WithEvents texp6 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label

End Class
