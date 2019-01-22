Public Class Register


    Private Sub chkThai_CheckedChanged(sender As Object, e As EventArgs) Handles chkThai.CheckedChanged, chkOther.CheckedChanged, chkJapan.CheckedChanged, chkEndlish.CheckedChanged, chkChina.CheckedChanged
        If chkOther.Checked = True Then
            TextBoxOther.Enabled = True
        End If

        If chkOther.Checked = False Then
            TextBoxOther.Text = ""
        End If
    End Sub

    Private Sub TextBoxPassword_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPassword.TextChanged

        If TextBoxPassword.TextLength < 10 Then
            LabelPassword.Text = "Quality: Medium"
            LabelPassword.BackColor = Color.OrangeRed
        End If

        If TextBoxPassword.TextLength < 4 Then
            LabelPassword.Text = "Quality: Low"
            LabelPassword.BackColor = Color.Red
        End If

        If TextBoxPassword.TextLength >= 10 Then
            LabelPassword.Text = "Quality: High"
            LabelPassword.BackColor = Color.Green
        End If

        If TextBoxPassword.Text = "" Then
            LabelPassword.Text = ""
            LabelPassword.BackColor = Nothing
        End If
    End Sub


    Private Sub TextBoxConfirm_TextChanged(sender As Object, e As EventArgs) Handles TextBoxConfirm.TextChanged
        If TextBoxPassword.Text <> TextBoxConfirm.Text Then
            LabelConfirm.Text = "Incorrect"
            LabelConfirm.BackColor = Color.Red
        End If

        If TextBoxPassword.Text = TextBoxConfirm.Text Then
            LabelConfirm.Text = "Correct"
            LabelConfirm.BackColor = Color.Green
        End If

        If TextBoxConfirm.Text = "" Then
            LabelConfirm.Text = ""
            LabelConfirm.BackColor = Nothing
        End If
    End Sub

    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        If TextBoxUsername.Text = "" Then
            MessageBox.Show("Please insert Username", "Error", MessageBoxButtons.OK,
                                                            MessageBoxIcon.Error)
            Exit Sub
        End If

        If TextBoxPassword.Text = "" Or TextBoxConfirm.Text = "" Then
            MessageBox.Show("Please insert Password or Confirm-Password", "Error", MessageBoxButtons.OK,
                                                            MessageBoxIcon.Error)
            Exit Sub
        End If

        If rdMale.Checked = False And rdFemale.Checked = False Then
            MessageBox.Show("Please choose your gender", "Error", MessageBoxButtons.OK,
                                                            MessageBoxIcon.Error)
            Exit Sub
        End If

        If chkEndlish.Checked = False And chkThai.Checked = False And chkJapan.Checked = False And chkChina.Checked = False And chkOther.Checked = False Then
            MessageBox.Show("Please choose language", "Error", MessageBoxButtons.OK,
                                                            MessageBoxIcon.Error)
            Exit Sub
        End If

        If chkOther.Checked = True And TextBoxOther.Text = "" Then
            MessageBox.Show("Please insert other language", "Error", MessageBoxButtons.OK,
                                                            MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim Gen As String
        If rdMale.Checked = True Then
            Gen = "Male"
        Else
            Gen = "Female"
        End If

        Dim lan As String = ""
        If chkThai.Checked = True Then
            lan += "Thai "
        End If

        If chkEndlish.Checked = True Then
            lan += "English "
        End If

        If chkChina.Checked = True Then
            lan += "Chinese "
        End If

        If chkJapan.Checked = True Then
            lan += "Japanese "
        End If

        If chkOther.Checked = True Then
            lan += TextBoxOther.Text
        End If

        MessageBox.Show("Username : " & TextBoxUsername.Text & vbNewLine &
                        "Gender : " & Gen & vbNewLine &
                        "You can speak : " & lan & vbNewLine)
    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        TextBoxUsername.Text = ""
        TextBoxPassword.Text = ""
        TextBoxConfirm.Text = ""
        rdMale.Checked = False
        rdFemale.Checked = False
        chkChina.Checked = False
        chkEndlish.Checked = False
        chkThai.Checked = False
        chkJapan.Checked = False
    End Sub
End Class
