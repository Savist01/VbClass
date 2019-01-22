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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBoxMenu = New System.Windows.Forms.ListBox()
        Me.ListBoxOrder = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.ButtonOut = New System.Windows.Forms.Button()
        Me.ButtonOrder = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "เมนูทางร้าน"
        '
        'ListBoxMenu
        '
        Me.ListBoxMenu.FormattingEnabled = True
        Me.ListBoxMenu.Location = New System.Drawing.Point(35, 51)
        Me.ListBoxMenu.Name = "ListBoxMenu"
        Me.ListBoxMenu.Size = New System.Drawing.Size(193, 147)
        Me.ListBoxMenu.TabIndex = 1
        '
        'ListBoxOrder
        '
        Me.ListBoxOrder.FormattingEnabled = True
        Me.ListBoxOrder.Location = New System.Drawing.Point(327, 51)
        Me.ListBoxOrder.Name = "ListBoxOrder"
        Me.ListBoxOrder.Size = New System.Drawing.Size(193, 147)
        Me.ListBoxOrder.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(324, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "เมนูที่เลือก"
        '
        'ButtonAdd
        '
        Me.ButtonAdd.Location = New System.Drawing.Point(242, 91)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAdd.TabIndex = 4
        Me.ButtonAdd.Text = "เพิ่ม >"
        Me.ButtonAdd.UseVisualStyleBackColor = True
        '
        'ButtonOut
        '
        Me.ButtonOut.Location = New System.Drawing.Point(242, 129)
        Me.ButtonOut.Name = "ButtonOut"
        Me.ButtonOut.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOut.TabIndex = 5
        Me.ButtonOut.Text = "< ลด"
        Me.ButtonOut.UseVisualStyleBackColor = True
        '
        'ButtonOrder
        '
        Me.ButtonOrder.Location = New System.Drawing.Point(526, 51)
        Me.ButtonOrder.Name = "ButtonOrder"
        Me.ButtonOrder.Size = New System.Drawing.Size(95, 36)
        Me.ButtonOrder.TabIndex = 7
        Me.ButtonOrder.Text = "สั่งอาหาร"
        Me.ButtonOrder.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(526, 93)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(95, 36)
        Me.ButtonCancel.TabIndex = 6
        Me.ButtonCancel.Text = "ยกเลิก"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 257)
        Me.Controls.Add(Me.ButtonOrder)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonOut)
        Me.Controls.Add(Me.ButtonAdd)
        Me.Controls.Add(Me.ListBoxOrder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBoxMenu)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Foor Order"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListBoxMenu As ListBox
    Friend WithEvents ListBoxOrder As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents ButtonOut As Button
    Friend WithEvents ButtonOrder As Button
    Friend WithEvents ButtonCancel As Button
End Class
