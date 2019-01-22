﻿Public Class Form1
    Private Sub TextBoxNum_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNum.TextChanged
        If TextBoxNum.Text <> "" Then
            ButtonCalculate.Enabled = True
            ButtonClear.Enabled = True
        End If
        If TextBoxNum.Text = "" Then
            ButtonCalculate.Enabled = True
            ButtonClear.Enabled = False
            ButtonCalculate.Enabled = False
        End If
    End Sub

    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click
        Dim ppl As Integer
        Dim BasePrice As Double
        Dim DisPrice As Double

        Try
            ppl = CInt(TextBoxNum.Text)
        Catch ex As Exception
            MessageBox.Show("กรุณาป้อนจำนวนลูกค้าเป็นตัวเลข", "Error", MessageBoxButtons.OK,
                                                MessageBoxIcon.Error)
        End Try

        If rdFriend.Checked = False And rdBuddy.Checked = False And rdNo.Checked = False Then
            MessageBox.Show("กรุณาป้อนจำนวนลูกค้าหรือเลือกประเภทบัตร", "Error", MessageBoxButtons.OK,
                                                                    MessageBoxIcon.Error)
        End If

        BasePrice = ppl * 299

        If rdNo.Checked = True Then
            LabelTotal.Text = Format(BasePrice, "###0.00") & " บาท"
        End If

        If rdFriend.Checked = True Then
            Dim dis5 = (BasePrice * 5) / 100
            DisPrice = BasePrice - dis5
            LabelTotal.Text = Format(DisPrice, "###0.00") & " บาท"
        End If

        If rdBuddy.Checked = True Then
            Dim dis10 = (BasePrice * 10) / 100
            DisPrice = BasePrice - dis10
            LabelTotal.Text = Format(DisPrice, "###0.00") & " บาท"
        End If

    End Sub






    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBoxNum.Text = ""
        LabelTotal.Text = ""
        rdFriend.Checked = False
        rdBuddy.Checked = False
        rdNo.Checked = False
        ButtonCalculate.Enabled = False
        ButtonClear.Enabled = False
    End Sub
End Class
