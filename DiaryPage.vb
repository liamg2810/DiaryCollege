Public Class DiaryPage

    Private Sub DiaryPage_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        MainPage.Show()
        Hide()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim titleVal As String = tbTitle.Text
        Dim dateVal As Date = dtpDate.Value
        Dim entry As String = tbEntry.Text
        Dim mood As String = tbMood.Text
        Dim targets As String = tbTarget.Text

        If String.IsNullOrEmpty(titleVal) Or String.IsNullOrEmpty(entry) Then
            MessageBox.Show("Please fill required fields")
            Return
        End If

        Dim data As New Dictionary(Of
    End Sub
End Class