Imports System.IO
Imports Newtonsoft.Json

Public Class DiaryPage

    Private Function GetJsonFilePath() As String
        Dim baseDir As String = AppDomain.CurrentDomain.BaseDirectory

        Dim projectRoot As String = Path.Combine(baseDir, "..", "..", "Data", "data.json")

        Return Path.GetFullPath(projectRoot)
    End Function

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

        Dim data As New Dictionary(Of String, Object) From {
            {"title", titleVal},
            {"date", dateVal},
            {"entry", entry},
            {"mood", mood},
            {"targets", targets}
        }

        Dim jsonData As String = File.ReadAllText(GetJsonFilePath())

        Dim diaryEntries As List(Of Dictionary(Of String, Object))

        If String.IsNullOrWhiteSpace(jsonData) Then
            diaryEntries = New List(Of Dictionary(Of String, Object))()
        Else
            diaryEntries = JsonConvert.DeserializeObject(Of List(Of Dictionary(Of String, Object)))(jsonData)
        End If

        diaryEntries.Add(data)

        Dim updatedJson As String = JsonConvert.SerializeObject(diaryEntries, Formatting.Indented)

        File.WriteAllText(GetJsonFilePath(), updatedJson)

    End Sub
End Class