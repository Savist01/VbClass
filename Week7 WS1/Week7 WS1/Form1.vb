Public Class Form1
    Private Sub btnChk_Click(sender As Object, e As EventArgs) Handles btnChk.Click

        Dim constellation() As String = {"ชวด", "ฉลู", "ขาล", "ขาล", "มะโรง", "มะเส็ง", "มะเมีย", "มะแม", "วอก", "ระกา", "จอ", "กุน"}

        Dim Y As Integer = txtYear.Text
        Dim MM As Integer = (Y + 5) Mod 12



        MessageBox.Show("พ.ศ." & Y & " ตรงกับปี:" & constellation(MM))
        txtYear.Text = ""
    End Sub
End Class
