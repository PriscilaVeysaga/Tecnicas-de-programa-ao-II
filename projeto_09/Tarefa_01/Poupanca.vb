Public Class Poupanca

    Inherits Conta
    Private Aniversario As Integer

    Public Sub New(conta As String, cliente As String, saldo As Decimal, aniversario As Integer)
        MyBase.New(conta, cliente, saldo)
        Me.Aniversario = aniversario
    End Sub

    Public Sub New()
    End Sub

    Public Property pAniversario As Integer
        Get
            Return Aniversario
        End Get
        Set(value As Integer)
            Aniversario = value
        End Set
    End Property
End Class
