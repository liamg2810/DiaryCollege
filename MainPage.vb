Public Class MainPage
    Private Sub MainPage_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub btnDiary_Click(sender As Object, e As EventArgs) Handles btnDiary.Click
        DiaryPage.Show()
        Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        LoginPage.Show()
        Hide()
    End Sub
End Class