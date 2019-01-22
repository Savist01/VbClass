Public Class Form1
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged, CheckBox3.CheckedChanged, CheckBox2.CheckedChanged, CheckBox1.CheckedChanged
        Dim fontstyle As FontStyle = FontStyle.Regular
        If CheckBox1.Checked Then
            fontstyle += FontStyle.Bold

        End If

        If CheckBox2.Checked Then
            fontstyle += FontStyle.Italic
        End If

        If CheckBox3.Checked Then
            fontstyle += FontStyle.Underline
        End If

        If CheckBox4.Checked Then
            fontstyle += FontStyle.Strikeout
        End If

        TextBox1.Font = New Font("Arial", 20, fontstyle)
    End Sub
End Class
