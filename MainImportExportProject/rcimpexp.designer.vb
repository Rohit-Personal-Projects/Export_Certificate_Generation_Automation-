<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rcimpexp
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.itchs = New System.Windows.Forms.TextBox()
        Me.ButIMP = New System.Windows.Forms.Button()
        Me.ButEXP = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ENTER THE RC NUMBER"
        '
        'itchs
        '
        Me.itchs.Location = New System.Drawing.Point(172, 50)
        Me.itchs.Name = "itchs"
        Me.itchs.Size = New System.Drawing.Size(100, 20)
        Me.itchs.TabIndex = 1
        '
        'ButIMP
        '
        Me.ButIMP.Location = New System.Drawing.Point(34, 107)
        Me.ButIMP.Name = "ButIMP"
        Me.ButIMP.Size = New System.Drawing.Size(75, 23)
        Me.ButIMP.TabIndex = 2
        Me.ButIMP.Text = "IMPORTED"
        Me.ButIMP.UseVisualStyleBackColor = True
        '
        'ButEXP
        '
        Me.ButEXP.Location = New System.Drawing.Point(159, 107)
        Me.ButEXP.Name = "ButEXP"
        Me.ButEXP.Size = New System.Drawing.Size(75, 23)
        Me.ButEXP.TabIndex = 3
        Me.ButEXP.Text = "EXPORTED"
        Me.ButEXP.UseVisualStyleBackColor = True
        '
        'rcimpexp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.ButEXP)
        Me.Controls.Add(Me.ButIMP)
        Me.Controls.Add(Me.itchs)
        Me.Controls.Add(Me.Label1)
        Me.Name = "rcimpexp"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents itchs As System.Windows.Forms.TextBox
    Friend WithEvents ButIMP As System.Windows.Forms.Button
    Friend WithEvents ButEXP As System.Windows.Forms.Button

End Class
