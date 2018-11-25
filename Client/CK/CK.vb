Public Class CK

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim game As New GAME_WS.GameService
        MsgBox("msg: " & game.HelloWorld)
    End Sub
End Class

