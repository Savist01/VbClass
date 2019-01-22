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
        Me.TextBalance = New System.Windows.Forms.TextBox()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.TextWithdraw = New System.Windows.Forms.TextBox()
        Me.Text2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelResult = New System.Windows.Forms.Label()
        Me.Text1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBalance
        '
        Me.TextBalance.Location = New System.Drawing.Point(126, 19)
        Me.TextBalance.Name = "TextBalance"
        Me.TextBalance.Size = New System.Drawing.Size(149, 20)
        Me.TextBalance.TabIndex = 1
        '
        'ButtonOK
        '
        Me.ButtonOK.Location = New System.Drawing.Point(200, 71)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOK.TabIndex = 2
        Me.ButtonOK.Text = "ตกลง"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'TextWithdraw
        '
        Me.TextWithdraw.Location = New System.Drawing.Point(126, 45)
        Me.TextWithdraw.Name = "TextWithdraw"
        Me.TextWithdraw.Size = New System.Drawing.Size(149, 20)
        Me.TextWithdraw.TabIndex = 3
        '
        'Text2
        '
        Me.Text2.AutoSize = True
        Me.Text2.Location = New System.Drawing.Point(23, 48)
        Me.Text2.Name = "Text2"
        Me.Text2.Size = New System.Drawing.Size(97, 13)
        Me.Text2.TabIndex = 5
        Me.Text2.Text = "จำนวนเงินที่จะถอน"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ชนิดธนบัตร"
        '
        'LabelResult
        '
        Me.LabelResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelResult.Location = New System.Drawing.Point(126, 103)
        Me.LabelResult.Name = "LabelResult"
        Me.LabelResult.Size = New System.Drawing.Size(149, 86)
        Me.LabelResult.TabIndex = 7
        '
        'Text1
        '
        Me.Text1.AutoSize = True
        Me.Text1.Location = New System.Drawing.Point(23, 22)
        Me.Text1.Name = "Text1"
        Me.Text1.Size = New System.Drawing.Size(81, 13)
        Me.Text1.TabIndex = 0
        Me.Text1.Text = "ยอดเงินคงเหลือ"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 222)
        Me.Controls.Add(Me.LabelResult)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Text2)
        Me.Controls.Add(Me.TextWithdraw)
        Me.Controls.Add(Me.ButtonOK)
        Me.Controls.Add(Me.TextBalance)
        Me.Controls.Add(Me.Text1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBalance As TextBox
    Friend WithEvents ButtonOK As Button
    Friend WithEvents TextWithdraw As TextBox
    Friend WithEvents Text2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelResult As Label
    Friend WithEvents Text1 As Label
End Class
