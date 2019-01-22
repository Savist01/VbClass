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
        Me.btnShow = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LiVowel = New System.Windows.Forms.TextBox()
        Me.LiAlpha = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(42, 60)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(643, 23)
        Me.btnShow.TabIndex = 0
        Me.btnShow.Text = "Show Letter"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "List of Vowel"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(42, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(643, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "List of Alphabet"
        '
        'LiVowel
        '
        Me.LiVowel.Location = New System.Drawing.Point(169, 100)
        Me.LiVowel.Name = "LiVowel"
        Me.LiVowel.Size = New System.Drawing.Size(474, 20)
        Me.LiVowel.TabIndex = 4
        '
        'LiAlpha
        '
        Me.LiAlpha.Location = New System.Drawing.Point(169, 138)
        Me.LiAlpha.Name = "LiAlpha"
        Me.LiAlpha.Size = New System.Drawing.Size(474, 20)
        Me.LiAlpha.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 195)
        Me.Controls.Add(Me.LiAlpha)
        Me.Controls.Add(Me.LiVowel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnShow)
        Me.Name = "Form1"
        Me.Text = "Vowel and Alphabet"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnShow As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LiVowel As TextBox
    Friend WithEvents LiAlpha As TextBox
End Class
