Imports System.Security.Cryptography
Namespace Game.Cryptography
    Public Class SHA

        Public Shared Function SHA_256(ByVal input) As String
            Dim sha256 As SHA256 = SHA256Managed.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(input)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Dim stringBuilder_ As New StringBuilder()

            For i As Integer = 0 To hash.Length - 1
                stringBuilder_.Append(hash(i).ToString("X2"))
            Next
            Return "" & stringBuilder_.ToString
        End Function
    End Class
End Namespace