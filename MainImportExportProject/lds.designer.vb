<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lds
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
        Me.ACCEPT = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rc = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ACCEPT
        '
        Me.ACCEPT.Location = New System.Drawing.Point(84, 99)
        Me.ACCEPT.Name = "ACCEPT"
        Me.ACCEPT.Size = New System.Drawing.Size(75, 23)
        Me.ACCEPT.TabIndex = 0
        Me.ACCEPT.Text = "SUBMIT"
        Me.ACCEPT.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ENTER THE RC"
        '
        'rc
        '
        Me.rc.Location = New System.Drawing.Point(155, 59)
        Me.rc.Name = "rc"
        Me.rc.Size = New System.Drawing.Size(100, 20)
        Me.rc.TabIndex = 2
        '
        'lds
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.rc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ACCEPT)
        Me.Name = "lds"
        Me.Text = "LAST DAY OF SHIPMENT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ACCEPT As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rc As System.Windows.Forms.TextBox

End Class
