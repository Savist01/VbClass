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
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.ComboBoxFaculty = New System.Windows.Forms.ComboBox()
        Me.ComboBoxmajor = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ButtonOK
        '
        Me.ButtonOK.Enabled = False
        Me.ButtonOK.Location = New System.Drawing.Point(39, 183)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(155, 27)
        Me.ButtonOK.TabIndex = 0
        Me.ButtonOK.Text = "ยืนยัน"
        Me.ButtonOK.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "เลขบัตรประชาชน"
        '
        'TextBoxId
        '
        Me.TextBoxId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxId.Location = New System.Drawing.Point(146, 35)
        Me.TextBoxId.MaxLength = 13
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.Size = New System.Drawing.Size(216, 20)
        Me.TextBoxId.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ชื่อ-นามสกุล"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "คณะที่เลือก"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(78, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "สาขาวิชา"
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(146, 68)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(216, 20)
        Me.TextBoxName.TabIndex = 7
        '
        'ButtonReset
        '
        Me.ButtonReset.Enabled = False
        Me.ButtonReset.Location = New System.Drawing.Point(207, 183)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(155, 27)
        Me.ButtonReset.TabIndex = 9
        Me.ButtonReset.Text = "ล้างข้อมูล"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'ComboBoxFaculty
        '
        Me.ComboBoxFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxFaculty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxFaculty.FormattingEnabled = True
        Me.ComboBoxFaculty.Location = New System.Drawing.Point(146, 95)
        Me.ComboBoxFaculty.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxFaculty.Name = "ComboBoxFaculty"
        Me.ComboBoxFaculty.Size = New System.Drawing.Size(216, 28)
        Me.ComboBoxFaculty.TabIndex = 10
        '
        'ComboBoxmajor
        '
        Me.ComboBoxmajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxmajor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxmajor.FormattingEnabled = True
        Me.ComboBoxmajor.Location = New System.Drawing.Point(146, 130)
        Me.ComboBoxmajor.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxmajor.Name = "ComboBoxmajor"
        Me.ComboBoxmajor.Size = New System.Drawing.Size(216, 28)
        Me.ComboBoxmajor.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 261)
        Me.Controls.Add(Me.ComboBoxmajor)
        Me.Controls.Add(Me.ComboBoxFaculty)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxId)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonOK)
        Me.Name = "Form1"
        Me.Text = "Faculty Interest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonOK As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents ButtonReset As Button
    Friend WithEvents ComboBoxFaculty As ComboBox
    Friend WithEvents ComboBoxmajor As ComboBox
End Class
