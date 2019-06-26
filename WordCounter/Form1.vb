Public Class frmCounter

    Private Sub cmdEvaluate_Click(sender As Object, e As EventArgs) Handles cmdEvaluate.Click
        EvaluateLetters()
        EvaluateWords()
    End Sub

    Private Sub EvaluateLetters()
        lstLetters.Items.Clear()

        Dim chars = txtText.Text.Where(Function(c) Not Char.IsWhiteSpace(c)).
                                 GroupBy(Function(c) Char.ToLower(c)).
                                 OrderByDescending(Function(group) group.Count).
                                 Take(10).
                                 Select(Function(group) $"{group.Key} - {group.Count}")

        For Each group In chars
            lstLetters.Items.Add(group)
        Next
    End Sub

    Private Sub EvaluateWords()
        lstWords.Items.Clear()

        Dim words = txtText.Text.Replace(".", " ").Replace(",", " ").Replace("-", " ").Replace(":", " ").Replace("""", " ").Replace(";", " ").
                                 Split(" ").
                                 Where(Function(word) Not String.IsNullOrEmpty(word.Trim())).
                                 GroupBy(Function(word) word.ToLower()).
                                 OrderByDescending(Function(group) group.Count).
                                 Select(Function(group) $"{group.Key} - {group.Count}")

        For Each group In words
            lstWords.Items.Add(group)
        Next
    End Sub

    Private Sub txtText_Enter(sender As Object, e As EventArgs) Handles txtText.Enter
        txtText.SelectAll()
    End Sub

End Class
