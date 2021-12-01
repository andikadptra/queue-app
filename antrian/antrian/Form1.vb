Public Class Form1
    Dim type As String
    Dim queue As Integer
    Dim mainText As String
    Dim buttonClick As Integer
    Dim queueA = 0
    Dim queueB = 0

    Sub tombol1()
        If type = "A" Then
            queueA = queueA + 1
            mainInfo.Text = type + " - " + queueA.ToString()
            Dim sapiObject = CreateObject("SAPI.spvoice")
            sapiObject.speak(mainInfo.Text)
        ElseIf type = "B" Then
            queueB = queueB + 1
            mainInfo.Text = type + " - " + queueB.ToString()
            Dim sapiObject = CreateObject("SAPI.spvoice")
            sapiObject.speak(mainInfo.Text)
        End If
    End Sub

    Sub tombol2()
        If type = "A" Then
            For i As Integer = 1 To 2
                queueA = queueA + 1
                mainInfo.Text = type + " - " + queueA.ToString()
            Next
        ElseIf type = "B" Then
            For i As Integer = 1 To 2
                queueB = queueB + 1
                mainInfo.Text = type + " - " + queueB.ToString()
                Dim sapiObject = CreateObject("SAPI.spvoice")
                sapiObject.speak(mainInfo.Text)
            Next
        End If
    End Sub
    Sub tombol6()
        If type = "A" Then
            For i As Integer = 1 To 6
                queueA = queueA + 1
                mainInfo.Text = type + " - " + queueA.ToString()
                Dim sapiObject = CreateObject("SAPI.spvoice")
                sapiObject.speak(mainInfo.Text)
            Next
        ElseIf type = "B" Then
            For i As Integer = 1 To 6
                queueB = queueB + 1
                mainInfo.Text = type + " - " + queueB.ToString()
                Dim sapiObject = CreateObject("SAPI.spvoice")
                sapiObject.speak(mainInfo.Text)
            Next
        End If
    End Sub

    Private Sub mainInfo_Click(sender As Object, e As EventArgs) Handles mainInfo.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        buttonClick = 1
    End Sub
    Private Sub counterA_Click(sender As Object, e As EventArgs) Handles counterA.Click
        type = "A"
    End Sub
    Private Sub generate_Click(sender As Object, e As EventArgs) Handles generate.Click
        If type = "A" Then
            If buttonClick = 1 Then
                tombol1()
            ElseIf buttonClick = 2 Then
                tombol2()
            ElseIf buttonClick = 6 Then
                tombol6()
            End If
        ElseIf type = "B" Then
            If buttonClick = 1 Then
                tombol1()
            ElseIf buttonClick = 2 Then
                tombol2()
            End If
        End If

    End Sub
    Private Sub counterB_Click(sender As Object, e As EventArgs) Handles counterB.Click
        type = "B"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        buttonClick = 2
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        buttonClick = 6
    End Sub
End Class
