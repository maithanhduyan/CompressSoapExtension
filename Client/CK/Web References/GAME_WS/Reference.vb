﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.8937
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'This source code was auto-generated by Microsoft.VSDesigner, Version 2.0.50727.8937.
'
Imports System.IO
Imports ICSharpCode.SharpZipLib.Zip
Namespace GAME_WS

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.8922"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Web.Services.WebServiceBindingAttribute(Name:="GameServiceSoap", [Namespace]:="http://tempuri.org/")> _
    Partial Public Class GameService
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol

        Private HelloWorldOperationCompleted As System.Threading.SendOrPostCallback

        Private GetCardOperationCompleted As System.Threading.SendOrPostCallback

        Private useDefaultCredentialsSetExplicitly As Boolean

        '''<remarks/>
        Public Sub New()
            MyBase.New()
            Me.Url = Global.CK.My.MySettings.Default.CK_GAME_WS_GameService
            If (Me.IsLocalFileSystemWebService(Me.Url) = True) Then
                Me.UseDefaultCredentials = True
                Me.useDefaultCredentialsSetExplicitly = False
            Else
                Me.useDefaultCredentialsSetExplicitly = True
            End If
        End Sub

        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set(ByVal value As String)
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = True) _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = False)) _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = False)) Then
                    MyBase.UseDefaultCredentials = False
                End If
                MyBase.Url = value
            End Set
        End Property

        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set(ByVal value As Boolean)
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = True
            End Set
        End Property

        '''<remarks/>
        Public Event HelloWorldCompleted As HelloWorldCompletedEventHandler

        '''<remarks/>
        Public Event GetCardCompleted As GetCardCompletedEventHandler

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Hello", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Bare), CompressSoapExtension()> _
        Public Function HelloWorld() As <System.Xml.Serialization.XmlElementAttribute([Namespace]:="http://tempuri.org/")> String
            Dim results() As Object = Me.Invoke("HelloWorld", New Object(-1) {})
            Return CType(results(0), String)
        End Function

        '''<remarks/>
        Public Overloads Sub HelloWorldAsync()
            Me.HelloWorldAsync(Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub HelloWorldAsync(ByVal userState As Object)
            If (Me.HelloWorldOperationCompleted Is Nothing) Then
                Me.HelloWorldOperationCompleted = AddressOf Me.OnHelloWorldOperationCompleted
            End If
            Me.InvokeAsync("HelloWorld", New Object(-1) {}, Me.HelloWorldOperationCompleted, userState)
        End Sub

        Private Sub OnHelloWorldOperationCompleted(ByVal arg As Object)
            If (Not (Me.HelloWorldCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent HelloWorldCompleted(Me, New HelloWorldCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetCard", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Bare), CompressSoapExtension()> _
        Public Function GetCard() As <System.Xml.Serialization.XmlElementAttribute([Namespace]:="http://tempuri.org/")> Card
            Dim results() As Object = Me.Invoke("GetCard", New Object(-1) {})
            Return CType(results(0), Card)
        End Function

        '''<remarks/>
        Public Overloads Sub GetCardAsync()
            Me.GetCardAsync(Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub GetCardAsync(ByVal userState As Object)
            If (Me.GetCardOperationCompleted Is Nothing) Then
                Me.GetCardOperationCompleted = AddressOf Me.OnGetCardOperationCompleted
            End If
            Me.InvokeAsync("GetCard", New Object(-1) {}, Me.GetCardOperationCompleted, userState)
        End Sub

        Private Sub OnGetCardOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetCardCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetCardCompleted(Me, New GetCardCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub

        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing) _
                        OrElse (url Is String.Empty)) Then
                Return False
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024) _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return True
            End If
            Return False
        End Function
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.8922"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://tempuri.org/")> _
    Partial Public Class Card

        Private cardNum_Field() As Integer

        '''<remarks/>
        Public Property cardNum_() As Integer()
            Get
                Return Me.cardNum_Field
            End Get
            Set(ByVal value As Integer())
                Me.cardNum_Field = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.8922")> _
    Public Delegate Sub HelloWorldCompletedEventHandler(ByVal sender As Object, ByVal e As HelloWorldCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.8922"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code")> _
    Partial Public Class HelloWorldCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), String)
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.8922")> _
    Public Delegate Sub GetCardCompletedEventHandler(ByVal sender As Object, ByVal e As GetCardCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.8922"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code")> _
    Partial Public Class GetCardCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As Card
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), Card)
            End Get
        End Property
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

End Namespace
