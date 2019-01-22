Public Class Form1

    Dim num() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
    Dim NTH() As String = {"๐", "๑", "๒", "๓", "๔", "๕", "๖", "๗", "๘", "๙"}
    Dim CTH() As String = {"ศูนย์", "หนึ่ง", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า"}

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim BASE As String = TextBox1.Text
        Dim ChaNTH As String = ""

        For Each w In BASE
            For Each v In num
                If w = v Then
                    ChaNTH &= $"{NTH(v)}"
                End If
            Next
        Next
        Label1.Text = ChaNTH
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim BASE As String = TextBox1.Text
        Dim ChaCTH As String = ""

        For Each w In BASE
            For Each v In num
                If w = v Then
                    ChaCTH &= $"{CTH(v)} "
                End If
            Next
        Next
        Label1.Text = ChaCTH
    End Sub
End Class
