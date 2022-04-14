Public Class Conta

    Private conta As String
    Private cliente As String
    Private saldo As Decimal


    Public Property pConta As String
        Get
            Return conta
        End Get
        Set(value As String)
            conta = value
        End Set
    End Property

    Public Property pCliente As String
        Get
            Return cliente
        End Get
        Set(value As String)
            cliente = value
        End Set
    End Property

    Public Property pSaldo As Decimal
        Get
            Return saldo
        End Get
        Set(value As Decimal)
            saldo = value
        End Set
    End Property

    Public Sub New(conta As String, cliente As String, saldo As Decimal)
        Me.conta = conta
        Me.cliente = cliente
        Me.saldo = saldo
    End Sub

    Public Sub New()
    End Sub

    Public Sub Depositar(valor As Decimal)
        If (valor >= 1) Then
            Me.saldo = saldo + valor
        Else
            MsgBox("Valor a ser depositado deve ser maior que 1!!!")
        End If
    End Sub

    Public Sub Sacar(valor As Decimal)
        If (valor <= Me.saldo) Then
            Me.saldo = saldo - valor
        Else
            MsgBox("Valor solicitado maior que o saldo!!!")
        End If
    End Sub

End Class
