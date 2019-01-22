Public Class Form1
    Dim Second As Integer = 0
    Dim ans As Integer = 0
    Dim word() As String = {"Apple", "Bird", "Cats", "Dogs", "Eggs", "Fish"}
    Dim score As Integer = 0
    Dim playCount As Integer = 0
    Dim ran As Random = New Random

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Timer1.Start()
        ans = ran.Next(0, word.Length)
        lblFirstH.Text = word(ans)(0)
        lblCountWord.Text = word(ans).Length
        btnStart.Enabled = False
        Label1.Text = word(ans)
    End Sub



    Private Sub btnAns_Click(sender As Object, e As EventArgs) Handles btnAns.Click
        If txtGuessWord.Text.ToUpper = word(ans).ToUpper Then
            score += 1
            playCount += 1
        Else
            playCount += 1
        End If
        txtGuessWord.Text = ""
        ans = ran.Next(0, word.Length)
        lblFirstH.Text = word(ans)(0)
        lblCountWord.Text = word(ans).Length
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Second = Second + 2
        lblTimer.Text = Second.ToString("00")
        If Second = 20 Then
            Timer1.Stop()
            MessageBox.Show("Guess " & playCount & " words" & vbNewLine &
                            "Correct " & score & " words", "", MessageBoxButtons.OK)
            btnStart.Enabled = True
            lblTimer.Text = "00"
            txtGuessWord.Text = ""
            lblFirstH.Text = "..."
            lblCountWord.Text = "..."
            Second = 0
            score = 0
            playCount = 0
        End If

    End Sub
End Class
