Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxFaculty.Items.Add("สาขาวิศวกรรมศาสตร์")
        ComboBoxFaculty.Items.Add("สาขาเทคโนโลยีสารสนเทศ")
        ComboBoxFaculty.Items.Add("สาขาบริหารธุรกิจ")


    End Sub

    Private Sub ComboBoxFaculty_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBoxFaculty.SelectedIndexChanged
        Dim EN() As String = {"สาขาวิศวกรรมยานยนต์", "สาขาวิศวกรรมการผลิต", "สาขาวิศวกรรมคอมพิวเตอร์", "สาขาวิศวกรรมไฟฟ้า"}
        Dim IT() As String = {"สาขาเทคโนโลยีสารสนเทศ", "สาขามัลติมีเดีย", "สาขาเทคโนโลยีสารสนเทศทางธุรกิจ"}
        Dim BUSS() As String = {"สาขาบริหารธุรกิจญี่ปุ่น", "สาขาการจัดการอุตสาหกรรม", "สาขาการบัญชี", "สาขาการจัดการทรัพยากรมนุษย์"}

        If ComboBoxFaculty.SelectedIndex = 0 Then
            ComboBoxmajor.Items.Clear() 'ต้องเคลียก่่อนใส่ใหม่ ด้วยคำสั่ง Clear()
            ComboBoxmajor.Items.AddRange(EN)
        ElseIf ComboBoxFaculty.SelectedIndex = 1 Then
            ComboBoxmajor.Items.Clear()
            ComboBoxmajor.Items.AddRange(IT)
        ElseIf ComboBoxFaculty.SelectedIndex = 2 Then
            ComboBoxmajor.Items.Clear()
            ComboBoxmajor.Items.AddRange(BUSS)
        End If
    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        Dim PPL As String = TextBoxId.Text
        Dim Name As String = TextBoxName.Text
        Dim Fac As String = ComboBoxFaculty.SelectedItem
        Dim ma As String = ComboBoxmajor.SelectedItem


        MessageBox.Show("หมายเลขบัตรประชาชน : " & PPL & vbNewLine &
                          "ชื่อ-นามสกุล : " & Name & vbNewLine &
                          "คณะและสาขาที่เลือก" & Fac & " " & ma)
        TextBoxId.Text = ""
        TextBoxName.Text = ""
        ComboBoxFaculty.Items.Clear()
        ComboBoxmajor.Items.Clear()

        ComboBoxFaculty.Items.Add("สาขาวิศวกรรมศาสตร์")
        ComboBoxFaculty.Items.Add("สาขาเทคโนโลยีสารสนเทศ")
        ComboBoxFaculty.Items.Add("สาขาบริหารธุรกิจ")
        ButtonReset.Enabled = False
    End Sub


    Private Sub Text_TextChanged(sender As Object, e As EventArgs) Handles TextBoxId.TextChanged, TextBoxName.TextChanged, ComboBoxFaculty.SelectedIndexChanged, ComboBoxmajor.SelectedIndexChanged
        Dim ff As String = ""
        For Each items In ComboBoxFaculty.Items
            ff &= items
        Next

        Dim mm As String = ""
        For Each items In ComboBoxmajor.Items
            ff &= items
        Next

        If TextBoxId.TextLength <> 0 And TextBoxName.TextLength <> 0 And ComboBoxFaculty.SelectedIndex <> -1 And ComboBoxmajor.SelectedIndex <> -1 Then
            ButtonOK.Enabled = True
        Else
            ButtonOK.Enabled = False
        End If

        If TextBoxId.TextLength <> 0 Or TextBoxName.TextLength <> 0 Or ComboBoxFaculty.SelectedIndex <> -1 Or ComboBoxmajor.SelectedIndex <> -1 Then
            ButtonReset.Enabled = True

        Else
            ButtonReset.Enabled = False
        End If

    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        TextBoxId.Text = ""
        TextBoxName.Text = ""
        ComboBoxFaculty.Items.Clear()
        ComboBoxmajor.Items.Clear()

        ComboBoxFaculty.Items.Add("สาขาวิศวกรรมศาสตร์")
        ComboBoxFaculty.Items.Add("สาขาเทคโนโลยีสารสนเทศ")
        ComboBoxFaculty.Items.Add("สาขาบริหารธุรกิจ")
        ButtonReset.Enabled = False
    End Sub
End Class
