Imports System.Web.Services.Protocols
Imports System.Data.SqlClient
Namespace CompressExtension

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

End Namespace