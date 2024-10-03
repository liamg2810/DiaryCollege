Public Class LoginPage
    Private ValidUsername As String = "admin"
    Private ValidPassword As String = "password"

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username = tbUsername.Text
        Dim password = tbPassword.Text

        If username = ValidUsername AndAlso password = ValidPassword Then
            MainPage.Show()
            Hide()
        Else
            MessageBox.Show("Invalid username or password!")
        End If
    End Sub

    Private Sub LoginPage_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub LoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbUsername.Text = ""
        tbPassword.Text = ""
    End Sub
End Class