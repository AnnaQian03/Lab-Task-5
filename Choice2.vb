Public Class Choice2
    Private Sub BTNNext_Click(sender As Object, e As EventArgs) Handles BTNNext.Click
        Choice3.Show()
        Me.Hide()

    End Sub

    Private Sub BTNCheck_Click(sender As Object, e As EventArgs) Handles BTNCheck.Click
        If RadioButton3.Checked = True Then
            correctanswer += 1
            MessageBox.Show("That is good one", "Result",
            MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf RadioButton1.Checked = True Or RadioButton2.Checked = True Then
            MessageBox.Show("0 Point")
        End If
        Point.Text = correctanswer
        BTNCheck.Enabled = False
    End Sub
End Class