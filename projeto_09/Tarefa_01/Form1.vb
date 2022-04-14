Public Class Form1

    Dim obj_poupanca As New Poupanca

    Private Sub btnCriar_Click(sender As Object, e As EventArgs) Handles btnCriar.Click
        obj_poupanca.pConta = txbConta.Text
        obj_poupanca.pCliente = txbCliente.Text
        obj_poupanca.pSaldo = CDec(txbSaldo.Text)
        obj_poupanca.pAniversario = CInt(txbAniversario.Text)

        AtualizaSaldo()
    End Sub

    Private Sub btnDepositar_Click(sender As Object, e As EventArgs) Handles btnDepositar.Click
        obj_poupanca.Depositar(CDec(txbValor.Text))
        AtualizaSaldo()
    End Sub

    Private Sub btnSacar_Click(sender As Object, e As EventArgs) Handles btnSacar.Click
        obj_poupanca.Sacar(CDec(txbValor.Text))
        AtualizaSaldo()
    End Sub

    Private Sub AtualizaSaldo()
        txbSaldoFinal.Text = obj_poupanca.pSaldo
    End Sub
End Class
