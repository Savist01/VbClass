Public Class Form1
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Plz fill something")
        End If
        Dim word As String = TextBox1.Text.ToLower 'เปลี่ยนเป็นตัวเล็ก
        Dim raw As String = TextBox1.Text
        Dim listVowel() As String = {"a", "e", "i", "o", "u"}
        Dim vowel As String = ""
        Dim Alpha As String = ""

        For w = 0 To word.Length - 1 'loop of word
            Dim check As Boolean = True


            For Each v In listVowel 'loop of list vowel
                If word(w) = v Then
                    vowel &= $"{raw(w)} "
                    check = False
                    Exit For
                End If

            Next
            If check = True Then
                Alpha &= $"{raw(w)} "
            End If

        Next
        LiVowel.Text = vowel
        LiAlpha.Text = Alpha
    End Sub
End Class
