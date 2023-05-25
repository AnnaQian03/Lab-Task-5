Public Class Choice4
    Private Sub BTNNext_Click(sender As Object, e As EventArgs) Handles BTNNext.Click
        MessageBox.Show("Congratulation,you finish the game ")
    End Sub

    Private Sub BTNCheck_Click(sender As Object, e As EventArgs) Handles BTNCheck.Click
        If RadioButton2.Checked = True Then
            correctanswer += 1
            MessageBox.Show("That is good one", "Result",
            MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf RadioButton1.Checked = True Or RadioButton3.Checked = True Then
            MessageBox.Show("0 Point")
        End If
        Point.Text = correctanswer
        BTNCheck.Enabled = False
    End Sub
End Class