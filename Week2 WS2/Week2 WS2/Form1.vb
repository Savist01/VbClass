Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonText.Click
        Dim AllSalary As Double = CDbl(TextSalary.Text * 12)
        Dim AfterMinus As Double = CDbl((AllSalary * 40) / 100)
        Dim UseThis As Double = CDbl(AfterMinus - 30000)


        If UseThis >= 4000001 Then
            LabelTax.Text = (UseThis * 35) / 100
        ElseIf UseThis >= 2000001 Then
            LabelTax.Text = (UseThis * 30) / 100
        ElseIf UseThis >= 1000001 Then
            LabelTax.Text = (UseThis * 25) / 100
        ElseIf UseThis >= 750001 Then
            LabelTax.Text = (UseThis * 20) / 100
        ElseIf UseThis >= 500001 Then
            LabelTax.Text = (UseThis * 15) / 100
        ElseIf UseThis >= 300001 Then
            LabelTax.Text = (UseThis * 10) / 100
        ElseIf UseThis >= 150001 Then
            LabelTax.Text = (UseThis * 5) / 100
        Else
            LabelTax.Text = "ได้รับการยกเว้นภาษี"
        End If

    End Sub
End Class
