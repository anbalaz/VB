Public Class frmMain

    Private Sub cmdNewAnimal_Click(sender As Object, e As EventArgs) Handles cmdNewAnimal.Click
        If String.IsNullOrEmpty(txtName.Text) Then
            MessageBox.Show("Provide animal name, please.", "Zverimex", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtName.Focus()

        ElseIf cmbKind.SelectedIndex = -1 Then
            MessageBox.Show("Provide animal kind, please.", "Zverimex", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbKind.Focus()

        Else
            lstAnimals.Items.Add(AnimalFactory.CreateAnimal(cmbKind.SelectedItem.ToString(), txtName.Text))

        End If
    End Sub

    Private Sub cmdOrderByTime_Click(sender As Object, e As EventArgs) Handles cmdOrderByTime.Click
        SortAnimals(Sub(animals As List(Of Animal)) animals.Sort(New Comparison(Of Animal)(Function(a1, a2) a1.TimeAdded.CompareTo(a2.TimeAdded))))
    End Sub

    Private Sub cmdOrderByLegs_Click(sender As Object, e As EventArgs) Handles cmdOrderByLegs.Click
        SortAnimals(Sub(animals As List(Of Animal)) animals.Sort())
    End Sub

    Public Sub SortAnimals(sort As Action(Of List(Of Animal)))
        Dim animals As List(Of Animal) = New List(Of Animal)(lstAnimals.Items.Cast(Of Animal))

        sort.Invoke(animals)

        lstAnimals.Items.Clear()
        For Each a In animals
            lstAnimals.Items.Add(a)
        Next
    End Sub

    Private Sub cmdTalk_Click(sender As Object, e As EventArgs) Handles cmdTalk.Click
        If lstAnimals.SelectedItem IsNot Nothing Then
            MessageBox.Show(CType(lstAnimals.SelectedItem, Animal).Reply(), "Zverimex", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
