Public Class Form1
    Private Sub BtPlus_Click(sender As Object, e As EventArgs) Handles BtPlus.Click
        Dim S1 As Double = CDbl(TbNum1.Text) + CDbl(TbNum2.Text)
        TbResult.Text = Format(S1, "#,##0.00")
    End Sub

    Private Sub BtMinus_Click(sender As Object, e As EventArgs) Handles BtMinus.Click
        Dim S2 As Double = CDbl(TbNum1.Text) - CDbl(TbNum2.Text)
        TbResult.Text = Format(S2, "#,##0.00")
    End Sub

    Private Sub BtKuun_Click(sender As Object, e As EventArgs) Handles BtKuun.Click
        Dim S1 As Double = CDbl(TbNum1.Text) * CDbl(TbNum2.Text)
        TbResult.Text = Format(S1, "#,##0.00")
    End Sub

    Private Sub BtHan_Click(sender As Object, e As EventArgs) Handles BtHan.Click
        Dim S1 As Double = CDbl(TbNum1.Text) / CDbl(TbNum2.Text)
        TbResult.Text = Format(S1, "#,##0.00")
    End Sub

    Private Sub BtClear_Click(sender As Object, e As EventArgs) Handles BtClear.Click
        TbNum1.Text = ""
        TbNum2.Text = ""
    End Sub
End Class
