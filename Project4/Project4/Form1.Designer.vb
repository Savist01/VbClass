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
        Me.LbNum1 = New System.Windows.Forms.Label()
        Me.TbNum1 = New System.Windows.Forms.TextBox()
        Me.BtClear = New System.Windows.Forms.Button()
        Me.LbNum2 = New System.Windows.Forms.Label()
        Me.TbNum2 = New System.Windows.Forms.TextBox()
        Me.TbResult = New System.Windows.Forms.TextBox()
        Me.LbResult = New System.Windows.Forms.Label()
        Me.BtPlus = New System.Windows.Forms.Button()
        Me.BtMinus = New System.Windows.Forms.Button()
        Me.BtKuun = New System.Windows.Forms.Button()
        Me.BtHan = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LbNum1
        '
        Me.LbNum1.AutoSize = True
        Me.LbNum1.Location = New System.Drawing.Point(12, 9)
        Me.LbNum1.Name = "LbNum1"
        Me.LbNum1.Size = New System.Drawing.Size(53, 13)
        Me.LbNum1.TabIndex = 0
        Me.LbNum1.Text = "Number 1"
        '
        'TbNum1
        '
        Me.TbNum1.Location = New System.Drawing.Point(71, 6)
        Me.TbNum1.Name = "TbNum1"
        Me.TbNum1.Size = New System.Drawing.Size(100, 20)
        Me.TbNum1.TabIndex = 1
        '
        'BtClear
        '
        Me.BtClear.Location = New System.Drawing.Point(177, 56)
        Me.BtClear.Name = "BtClear"
        Me.BtClear.Size = New System.Drawing.Size(62, 23)
        Me.BtClear.TabIndex = 2
        Me.BtClear.Text = "Clear"
        Me.BtClear.UseVisualStyleBackColor = True
        '
        'LbNum2
        '
        Me.LbNum2.AutoSize = True
        Me.LbNum2.Location = New System.Drawing.Point(12, 35)
        Me.LbNum2.Name = "LbNum2"
        Me.LbNum2.Size = New System.Drawing.Size(53, 13)
        Me.LbNum2.TabIndex = 3
        Me.LbNum2.Text = "Number 2"
        '
        'TbNum2
        '
        Me.TbNum2.Location = New System.Drawing.Point(71, 32)
        Me.TbNum2.Name = "TbNum2"
        Me.TbNum2.Size = New System.Drawing.Size(100, 20)
        Me.TbNum2.TabIndex = 4
        '
        'TbResult
        '
        Me.TbResult.Location = New System.Drawing.Point(71, 58)
        Me.TbResult.Name = "TbResult"
        Me.TbResult.ReadOnly = True
        Me.TbResult.Size = New System.Drawing.Size(100, 20)
        Me.TbResult.TabIndex = 5
        '
        'LbResult
        '
        Me.LbResult.AutoSize = True
        Me.LbResult.Location = New System.Drawing.Point(12, 61)
        Me.LbResult.Name = "LbResult"
        Me.LbResult.Size = New System.Drawing.Size(37, 13)
        Me.LbResult.TabIndex = 6
        Me.LbResult.Text = "Result"
        '
        'BtPlus
        '
        Me.BtPlus.Location = New System.Drawing.Point(177, 6)
        Me.BtPlus.Name = "BtPlus"
        Me.BtPlus.Size = New System.Drawing.Size(28, 23)
        Me.BtPlus.TabIndex = 7
        Me.BtPlus.Text = "+"
        Me.BtPlus.UseVisualStyleBackColor = True
        '
        'BtMinus
        '
        Me.BtMinus.Location = New System.Drawing.Point(211, 6)
        Me.BtMinus.Name = "BtMinus"
        Me.BtMinus.Size = New System.Drawing.Size(28, 23)
        Me.BtMinus.TabIndex = 8
        Me.BtMinus.Text = "-"
        Me.BtMinus.UseVisualStyleBackColor = True
        '
        'BtKuun
        '
        Me.BtKuun.Location = New System.Drawing.Point(177, 32)
        Me.BtKuun.Name = "BtKuun"
        Me.BtKuun.Size = New System.Drawing.Size(28, 23)
        Me.BtKuun.TabIndex = 9
        Me.BtKuun.Text = "*"
        Me.BtKuun.UseVisualStyleBackColor = True
        '
        'BtHan
        '
        Me.BtHan.Location = New System.Drawing.Point(211, 32)
        Me.BtHan.Name = "BtHan"
        Me.BtHan.Size = New System.Drawing.Size(28, 23)
        Me.BtHan.TabIndex = 10
        Me.BtHan.Text = "/"
        Me.BtHan.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 206)
        Me.Controls.Add(Me.BtHan)
        Me.Controls.Add(Me.BtKuun)
        Me.Controls.Add(Me.BtMinus)
        Me.Controls.Add(Me.BtPlus)
        Me.Controls.Add(Me.LbResult)
        Me.Controls.Add(Me.TbResult)
        Me.Controls.Add(Me.TbNum2)
        Me.Controls.Add(Me.LbNum2)
        Me.Controls.Add(Me.BtClear)
        Me.Controls.Add(Me.TbNum1)
        Me.Controls.Add(Me.LbNum1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbNum1 As Label
    Friend WithEvents TbNum1 As TextBox
    Friend WithEvents BtClear As Button
    Friend WithEvents LbNum2 As Label
    Friend WithEvents TbNum2 As TextBox
    Friend WithEvents TbResult As TextBox
    Friend WithEvents LbResult As Label
    Friend WithEvents BtPlus As Button
    Friend WithEvents BtMinus As Button
    Friend WithEvents BtKuun As Button
    Friend WithEvents BtHan As Button
End Class
