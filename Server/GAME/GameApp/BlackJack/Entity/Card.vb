Namespace Game.Entity

    Public Class Card
        Public cardNum_ As Integer()
        Dim suit_ As String() = {"Diamond", "Club", "Heart", "Spade"}
        Dim face_ As String() = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"}

#Region "Constructor"
        Public Sub New()
            InitializeCardNum()
        End Sub
#End Region


#Region "Initial Card"
        Private Sub InitializeCardNum()
            For num As Integer = 1 To 52
                cardNum_(num) = num
            Next
        End Sub
#End Region

#Region "Properties"
        Public ReadOnly Property Suit()
            Get
                Return suit_
            End Get
        End Property

        Public ReadOnly Property Face()
            Get
                Return face_
            End Get
        End Property

#End Region
    End Class
End Namespace