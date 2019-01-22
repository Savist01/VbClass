Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBoxMenu.Items.Add("ข้าวกระเพราหมู")
        ListBoxMenu.Items.Add("ข้าวกระเพราไก่")
        ListBoxMenu.Items.Add("ข้าวกระเพราเนื้อ")
        ListBoxMenu.Items.Add("ข้าวกระเพราทะเล")
        ListBoxMenu.Items.Add("ข้าวกระเพรามังสวีรัติ")
        ListBoxMenu.Items.Add("ข้าวกระเพราเจ")
        ListBoxMenu.Items.Add("น้ำเปล่า")
        ListBoxMenu.Items.Add("น้ำผลไม้รวม")
        ListBoxMenu.Items.Add("น้ำชา")
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click

        ListBoxOrder.Items.Add(ListBoxMenu.SelectedItem)
    End Sub

    Private Sub ButtonOut_Click(sender As Object, e As EventArgs) Handles ButtonOut.Click
        ListBoxOrder.Items.Remove(ListBoxOrder.SelectedItem)
    End Sub

    Private Sub ButtonOrder_Click(sender As Object, e As EventArgs) Handles ButtonOrder.Click
        Dim Message As String = ""
        For Each items In ListBoxOrder.Items
            Message &= items & vbNewLine
        Next

        Dim acc As DialogResult = MessageBox.Show("ยืนยันการสั่งอาหารหรือไม่?", "ยืนยันรายการ", MessageBoxButtons.YesNo,
                                                                                    MessageBoxIcon.Question)
        If acc = DialogResult.Yes Then
            MessageBox.Show(Message & vbNewLine, "รายการอาหาร", MessageBoxButtons.OK,
                                                                MessageBoxIcon.Information)
        End If
        ListBoxOrder.Items.Clear()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        ListBoxOrder.Items.Clear()
    End Sub
End Class
