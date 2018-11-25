Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports GAME.Game.Entity
Imports GAME.CompressExtension

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



