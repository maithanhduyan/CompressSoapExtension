Imports System.Web.Services.Protocols
Imports System.IO
Imports ICSharpCode.SharpZipLib.Zip
Namespace CompressExtension

    Public Class CompressExtension
        Inherits SoapExtension
        Private oldStream As Stream
        Private newStream As Stream
        Private zipInputStream As ZipInputStream
        Private zipOutputStream As ZipOutputStream


        Public Overloads Overrides Function GetInitializer(ByVal methodInfo As LogicalMethodInfo, ByVal attribute As SoapExtensionAttribute) As Object
            Return Nothing
        End Function

        Public Overloads Overrides Function GetInitializer(ByVal serviceType As Type) As Object
            Return Nothing
        End Function


        Public Overrides Sub Initialize(ByVal initializer As Object)
        End Sub

        Public Overrides Function ChainStream(ByVal stream As Stream) As Stream
            Me.oldStream = stream
            Me.newStream = New MemoryStream
            Me.zipInputStream = New ZipInputStream(Me.oldStream)
            Me.zipInputStream.Password = "PASSWORD"
            Return Me.newStream
        End Function

        Public Overrides Sub ProcessMessage(ByVal message As SoapMessage)
            Select Case message.Stage
                Case SoapMessageStage.BeforeSerialize

                Case SoapMessageStage.AfterSerialize
                    WriteOutput(message)
                    Console.WriteLine("Soap Message: " & message.ToString)

                Case SoapMessageStage.BeforeDeserialize
                    WriteInput(message)
                    Console.WriteLine("Soap Message: " & message.ToString)


                Case SoapMessageStage.AfterDeserialize

                Case Else
                    Throw New Exception("invalid stage")
            End Select
        End Sub


        Public Sub WriteOutput(ByVal message As SoapMessage)
            If Me.zipOutputStream Is Nothing Then
                Me.zipOutputStream = New ZipOutputStream(Me.oldStream)
                Me.zipOutputStream.SetLevel(5)
                Me.zipOutputStream.Password = "PASSWORD"
            End If
            Dim entry As New ZipEntry(ZipEntry.CleanName(""))
            entry.Size = Me.newStream.Length
            Me.zipOutputStream.PutNextEntry(entry)
            Me.newStream.Position = 0
            Dim writeData(Me.newStream.Length) As Byte
            Me.newStream.Read(writeData, 0, CInt(Me.newStream.Length))
            Me.zipOutputStream.Write(writeData, 0, CInt(Me.newStream.Length))
            Me.zipOutputStream.Finish()
            Console.WriteLine("Soap Message: " & message.ToString)
        End Sub

        Public Sub WriteInput(ByVal message As SoapMessage)
            Dim size As Integer = 2048
            Dim writeData(2048) As Byte
            Dim zipEntry As ZipEntry = Me.zipInputStream.GetNextEntry()
            While True
                size = Me.zipInputStream.Read(writeData, 0, size)
                If size > 0 Then
                    Me.newStream.Write(writeData, 0, size)
                Else
                    Exit While
                End If
            End While
            Me.newStream.Position = 0
            Console.WriteLine("Soap Message: " & message.ToString)
        End Sub
    End Class
End Namespace