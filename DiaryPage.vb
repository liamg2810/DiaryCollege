Imports System.IO
Imports Newtonsoft.Json

Public Class DiaryPage
    Dim currentIndex As Integer = 0
    Dim hasSearched As Boolean = False

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

    Private Sub Search()
        Dim selectedDate As String = dtpSearch.Value.ToString("dd/MM/yyyy") + " 00:00:00"

        Console.WriteLine(selectedDate)

        Dim filePath As String = GetJsonFilePath()

        Dim jsonData As String = File.ReadAllText(filePath)

        Dim diaryEntries As List(Of Dictionary(Of String, Object))

        Console.WriteLine(jsonData)

        If String.IsNullOrWhiteSpace(jsonData) Then
            diaryEntries = New List(Of Dictionary(Of String, Object))()
        Else
            diaryEntries = JsonConvert.DeserializeObject(Of List(Of Dictionary(Of String, Object)))(jsonData)
        End If

        Console.WriteLine(diaryEntries)

        For Each entry In diaryEntries
            Console.WriteLine(entry("date"))
        Next

        Dim matchingEntries = From entry In diaryEntries
                              Where entry("date").ToString() = selectedDate
                              Select entry

        If matchingEntries.Any() Then
            Console.WriteLine(matchingEntries.Count)
            Console.WriteLine(currentIndex)

            If currentIndex >= matchingEntries.Count Then
                currentIndex = matchingEntries.Count - 1
            End If

            Dim entry = matchingEntries(currentIndex)
            tbTitle.Text = entry("title")
            dtpDate.Value = entry("date")
            tbEntry.Text = entry("entry")
            tbMood.Text = entry("mood")
            tbTarget.Text = entry("targets")
        Else
            MessageBox.Show("No entries found for the selected date.")
        End If

        btnSubmit.Hide()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        hasSearched = True
        currentIndex = 0
        Search()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        tbTitle.Text = ""
        dtpDate.Value = DateTime.Today()
        tbEntry.Text = ""
        tbMood.Text = ""
        tbTarget.Text = ""

        hasSearched = False
        btnSubmit.Show()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If Not hasSearched Then
            Return
        End If

        currentIndex += 1
        Search()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If Not hasSearched Then
            Return
        End If

        currentIndex -= 1

        If currentIndex < 0 Then
            currentIndex = 0
        End If


        Search()
    End Sub
End Class