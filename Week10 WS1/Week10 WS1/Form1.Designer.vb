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
        Me.txtSE = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LBR1 = New System.Windows.Forms.Label()
        Me.LBR2 = New System.Windows.Forms.Label()
        Me.LBR3 = New System.Windows.Forms.Label()
        Me.LBR4 = New System.Windows.Forms.Label()
        Me.LBR5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "กรอกรหัสลูกค้า"
        '
        'txtSE
        '
        Me.txtSE.Location = New System.Drawing.Point(138, 26)
        Me.txtSE.Name = "txtSE"
        Me.txtSE.Size = New System.Drawing.Size(560, 20)
        Me.txtSE.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(704, 23)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "ค้นหา"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LBR5)
        Me.GroupBox1.Controls.Add(Me.LBR4)
        Me.GroupBox1.Controls.Add(Me.LBR3)
        Me.GroupBox1.Controls.Add(Me.LBR2)
        Me.GroupBox1.Controls.Add(Me.LBR1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(754, 365)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ข้อมูลลูกค้า"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ชื่อบริษัท"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ชื่อผู้ติดต่อ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ที่อยู่"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(60, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "เมือง"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(60, 294)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "เบอร์โทรศัพท์"
        '
        'LBR1
        '
        Me.LBR1.AutoSize = True
        Me.LBR1.Location = New System.Drawing.Point(169, 51)
        Me.LBR1.Name = "LBR1"
        Me.LBR1.Size = New System.Drawing.Size(16, 13)
        Me.LBR1.TabIndex = 9
        Me.LBR1.Text = "..."
        '
        'LBR2
        '
        Me.LBR2.AutoSize = True
        Me.LBR2.Location = New System.Drawing.Point(169, 110)
        Me.LBR2.Name = "LBR2"
        Me.LBR2.Size = New System.Drawing.Size(16, 13)
        Me.LBR2.TabIndex = 10
        Me.LBR2.Text = "..."
        '
        'LBR3
        '
        Me.LBR3.AutoSize = True
        Me.LBR3.Location = New System.Drawing.Point(169, 169)
        Me.LBR3.Name = "LBR3"
        Me.LBR3.Size = New System.Drawing.Size(16, 13)
        Me.LBR3.TabIndex = 11
        Me.LBR3.Text = "..."
        '
        'LBR4
        '
        Me.LBR4.AutoSize = True
        Me.LBR4.Location = New System.Drawing.Point(169, 231)
        Me.LBR4.Name = "LBR4"
        Me.LBR4.Size = New System.Drawing.Size(16, 13)
        Me.LBR4.TabIndex = 12
        Me.LBR4.Text = "..."
        '
        'LBR5
        '
        Me.LBR5.AutoSize = True
        Me.LBR5.Location = New System.Drawing.Point(169, 294)
        Me.LBR5.Name = "LBR5"
        Me.LBR5.Size = New System.Drawing.Size(16, 13)
        Me.LBR5.TabIndex = 13
        Me.LBR5.Text = "..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSE)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "ข้อมูลลูกค้า"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSE As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LBR5 As Label
    Friend WithEvents LBR4 As Label
    Friend WithEvents LBR3 As Label
    Friend WithEvents LBR2 As Label
    Friend WithEvents LBR1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
