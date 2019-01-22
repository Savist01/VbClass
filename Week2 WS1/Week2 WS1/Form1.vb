Public Class Form1
    Private Sub TextBalance_TextChanged(sender As Object, e As EventArgs) Handles TextBalance.TextChanged
        Dim Ran As Random = New Random
        TextBalance.Text = Ran.Next(1, 9) * 100000
        TextWithdraw.Select()
    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        Dim Wid As Integer = CInt(TextWithdraw.Text)
        Dim E1000 As Integer = TextWithdraw.Text \ 1000
        Dim E500 As Integer = (TextWithdraw.Text - (E1000 * 1000)) \ 500
        Dim E100 As Integer = (TextWithdraw.Text - ((E1000 * 1000) + (E500 * 500))) \ 100

        If TextWithdraw.Text <= 100 Then
            MessageBox.Show("ยอดขั้นต่ำต้องเป็นหลักร้อยเท่านั้น", "Warning", MessageBoxButtons.OK,
                                                                   MessageBoxIcon.Warning)
        End If

        If TextBalance.Text >= 100 Then
            If TextWithdraw.Text < TextBalance.Text Then
                If TextWithdraw.Text <= 20000 Then
                    LabelResult.Text = "1000 : " & E1000 & vbNewLine &
                                        "500 : " & E500 & vbNewLine &
                                        "100 : " & E100 & vbNewLine
                    'TextBalance.Text = Wid

                Else
                    MessageBox.Show("ถอดได้ไม่เกิน 20,000", "Warning", MessageBoxButtons.OK,
                                                                    MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("ยอดเงินคงเหลือไม่เพียงพอ", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Stop)
            End If

        End If

    End Sub

    Private Sub TextWithdraw_TextChanged(sender As Object, e As EventArgs) Handles TextWithdraw.TextChanged

    End Sub
End Class
