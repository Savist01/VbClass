Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim first As Integer = CInt(TextBox1.Text)
        Dim last As Integer = CInt(TextBox2.Text)
        Dim steps As Integer = CInt(TextBox3.Text)
        Dim message As String = ""

        If steps > 0 Then
            If first < last Then 'ถ้าเลขเริ่มต้นน้อยกว่าสิ้นสุดจริง ทำ
                For X = first To last Step steps
                    message += X & vbNewLine
                Next
                MessageBox.Show(message)
            Else
                MessageBox.Show("เลขเริ่มต้นต้องน้อยกว่าลขสิ้นสุด ! !")
            End If

        ElseIf steps < 0 Then
            If first > last Then 'ถ้าเลขเริ่มต้นน้อยกว่าสิ้นสุดจริง ทำ
                For X = first To last Step steps
                    message += X & vbNewLine
                Next
                MessageBox.Show(message)
            Else
                MessageBox.Show("เลขเริ่มต้นต้องมากกว่าลขสิ้นสุด ! !")
            End If

        ElseIf steps = 0 Then
            MessageBox.Show("Step cant be 0")
        End If

    End Sub
End Class
