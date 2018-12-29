Imports System
Imports System.Text
Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StringBuilderPerform()
        ConcateStringByPlus()
    End Sub

    Sub StringBuilderPerform()
        Console.WriteLine("start")
        Dim sb As New StringBuilder()
        Dim startTime As DateTime = DateTime.Now
        For i As Integer = 1 To 10000
            sb.Append(i)
            sb.Append(", ")
        Next
        Dim endTime As DateTime = DateTime.Now
        Console.WriteLine("String Builder Took: " & (endTime - startTime).ToString)
    End Sub
    Sub ConcateStringByPlus()
        Console.WriteLine("start")
        Dim sb As New StringBuilder()
        Dim str As String = ""
        Dim startTime As DateTime = DateTime.Now
        For i As Integer = 1 To 10000
            str += i.ToString
        Next
        Dim endTime As DateTime = DateTime.Now
        Console.WriteLine("+= Took: " & (endTime - startTime).ToString)
    End Sub
End Class
