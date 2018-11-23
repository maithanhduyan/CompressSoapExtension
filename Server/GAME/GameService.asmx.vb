Imports System
Imports System.Data
Imports System.Collections.Generic
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml
Imports System.Xml.Xsl
Imports System.Xml.XPath
Imports System.Xml.Serialization

Imports System.IO
Imports System.Text
Imports ICSharpCode.SharpZipLib.Zip
Imports System.ComponentModel
Imports GAME.Game.Entity

<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
Public Class GameService
    Inherits System.Web.Services.WebService

    <WebMethod(), SoapDocumentMethod("http://tempuri.org/Hello", ParameterStyle:=SoapParameterStyle.Bare), CompressSoapExtension()> _
    Public Function HelloWorld() As String
        Return "Hello World"
    End Function

    <WebMethod(), SoapDocumentMethod("http://tempuri.org/GetCard", ParameterStyle:=SoapParameterStyle.Bare), CompressSoapExtension()> _
    Public Function GetCard() As Card
        Dim card As New Card
        Return card
    End Function

End Class

#Region "CompressSoapExtension"

<AttributeUsage(AttributeTargets.Method)> _
Public Class CompressSoapExtensionAttribute
    Inherits SoapExtensionAttribute

    Private pri As Integer

    Public Overrides ReadOnly Property ExtensionType() As Type
        Get
            Return GetType(CompressExtension)
        End Get
    End Property

    Public Overrides Property Priority() As Integer
        Get
            Return pri
        End Get
        Set(ByVal Value As Integer)
            pri = Value
        End Set
    End Property
End Class

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

            Case SoapMessageStage.BeforeDeserialize
                WriteInput(message)

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
    End Sub
End Class

#End Region


