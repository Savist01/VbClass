Public Class Form1
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChkCourse.Items.Add("English for speaking")
        ChkCourse.Items.Add("English for reading")
        ChkCourse.Items.Add("English for writing")
        ChkCourse.Items.Add("English for listening")
        ChkCourse.Items.Add("Grammar Course")
        ChkCourse.Items.Add("Vocabuary Course")
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged
        If txtId.TextLength < 0 Then
            txtId.Text = ""
        End If

        If txtId.TextLength = 13 Then
            If IsNumeric(txtId.Text) Then
                txtId.BackColor = Color.White
            Else txtId.BackColor = Color.Red
            End If
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If ChkCourse.SelectedIndex = -1 Then
            MessageBox.Show("กรุณาเลือกคอร์สเรียน", "Warning", MessageBoxButtons.OK,
                                                        MessageBoxIcon.Warning)
        Else
            For Each item In ChkCourse.CheckedItems
                ChkEnroll.Items.Add(item)
                ChkCourse.Items.RemoveAt(item)
            Next

        End If


    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If ChkEnroll.SelectedIndex = -1 Then
            MessageBox.Show("ไม่มีคอร์สเรียนที่เลือก", "Warning", MessageBoxButtons.OK,
                                                        MessageBoxIcon.Warning)
        Else
            ChkCourse.Items.Add(ChkEnroll.SelectedItem)
            ChkEnroll.Items.Remove(ChkEnroll.SelectedItem)
        End If

    End Sub
End Class
