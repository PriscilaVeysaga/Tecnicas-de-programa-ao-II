<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblConta = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.lblAniversario = New System.Windows.Forms.Label()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.lblSaldoFinal = New System.Windows.Forms.Label()
        Me.txbConta = New System.Windows.Forms.TextBox()
        Me.txbCliente = New System.Windows.Forms.TextBox()
        Me.txbAniversario = New System.Windows.Forms.TextBox()
        Me.txbSaldo = New System.Windows.Forms.TextBox()
        Me.txbValor = New System.Windows.Forms.TextBox()
        Me.txbSaldoFinal = New System.Windows.Forms.TextBox()
        Me.btnDepositar = New System.Windows.Forms.Button()
        Me.btnSacar = New System.Windows.Forms.Button()
        Me.btnCriar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblConta
        '
        Me.lblConta.AutoSize = True
        Me.lblConta.Location = New System.Drawing.Point(78, 45)
        Me.lblConta.Name = "lblConta"
        Me.lblConta.Size = New System.Drawing.Size(39, 15)
        Me.lblConta.TabIndex = 0
        Me.lblConta.Text = "Conta"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(76, 95)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(44, 15)
        Me.lblCliente.TabIndex = 1
        Me.lblCliente.Text = "Cliente"
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Location = New System.Drawing.Point(76, 139)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(36, 15)
        Me.lblSaldo.TabIndex = 2
        Me.lblSaldo.Text = "Saldo"
        '
        'lblAniversario
        '
        Me.lblAniversario.AutoSize = True
        Me.lblAniversario.Location = New System.Drawing.Point(76, 184)
        Me.lblAniversario.Name = "lblAniversario"
        Me.lblAniversario.Size = New System.Drawing.Size(66, 15)
        Me.lblAniversario.TabIndex = 3
        Me.lblAniversario.Text = "Aniversário"
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(99, 260)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(33, 15)
        Me.lblValor.TabIndex = 4
        Me.lblValor.Text = "Valor"
        '
        'lblSaldoFinal
        '
        Me.lblSaldoFinal.AutoSize = True
        Me.lblSaldoFinal.Location = New System.Drawing.Point(436, 260)
        Me.lblSaldoFinal.Name = "lblSaldoFinal"
        Me.lblSaldoFinal.Size = New System.Drawing.Size(36, 15)
        Me.lblSaldoFinal.TabIndex = 5
        Me.lblSaldoFinal.Text = "Saldo"
        '
        'txbConta
        '
        Me.txbConta.Location = New System.Drawing.Point(167, 37)
        Me.txbConta.Name = "txbConta"
        Me.txbConta.Size = New System.Drawing.Size(342, 23)
        Me.txbConta.TabIndex = 6
        '
        'txbCliente
        '
        Me.txbCliente.Location = New System.Drawing.Point(167, 87)
        Me.txbCliente.Name = "txbCliente"
        Me.txbCliente.Size = New System.Drawing.Size(342, 23)
        Me.txbCliente.TabIndex = 7
        '
        'txbAniversario
        '
        Me.txbAniversario.Location = New System.Drawing.Point(167, 181)
        Me.txbAniversario.Name = "txbAniversario"
        Me.txbAniversario.Size = New System.Drawing.Size(342, 23)
        Me.txbAniversario.TabIndex = 9
        '
        'txbSaldo
        '
        Me.txbSaldo.Location = New System.Drawing.Point(167, 131)
        Me.txbSaldo.Name = "txbSaldo"
        Me.txbSaldo.Size = New System.Drawing.Size(342, 23)
        Me.txbSaldo.TabIndex = 8
        '
        'txbValor
        '
        Me.txbValor.Location = New System.Drawing.Point(78, 294)
        Me.txbValor.Name = "txbValor"
        Me.txbValor.Size = New System.Drawing.Size(100, 23)
        Me.txbValor.TabIndex = 10
        '
        'txbSaldoFinal
        '
        Me.txbSaldoFinal.Location = New System.Drawing.Point(409, 294)
        Me.txbSaldoFinal.Name = "txbSaldoFinal"
        Me.txbSaldoFinal.Size = New System.Drawing.Size(100, 23)
        Me.txbSaldoFinal.TabIndex = 11
        '
        'btnDepositar
        '
        Me.btnDepositar.Location = New System.Drawing.Point(262, 260)
        Me.btnDepositar.Name = "btnDepositar"
        Me.btnDepositar.Size = New System.Drawing.Size(75, 23)
        Me.btnDepositar.TabIndex = 12
        Me.btnDepositar.Text = "Depositar"
        Me.btnDepositar.UseVisualStyleBackColor = True
        '
        'btnSacar
        '
        Me.btnSacar.Location = New System.Drawing.Point(262, 319)
        Me.btnSacar.Name = "btnSacar"
        Me.btnSacar.Size = New System.Drawing.Size(75, 23)
        Me.btnSacar.TabIndex = 13
        Me.btnSacar.Text = "Sacar"
        Me.btnSacar.UseVisualStyleBackColor = True
        '
        'btnCriar
        '
        Me.btnCriar.Location = New System.Drawing.Point(615, 120)
        Me.btnCriar.Name = "btnCriar"
        Me.btnCriar.Size = New System.Drawing.Size(117, 34)
        Me.btnCriar.TabIndex = 14
        Me.btnCriar.Text = "Criar"
        Me.btnCriar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCriar)
        Me.Controls.Add(Me.btnSacar)
        Me.Controls.Add(Me.btnDepositar)
        Me.Controls.Add(Me.txbSaldoFinal)
        Me.Controls.Add(Me.txbValor)
        Me.Controls.Add(Me.txbAniversario)
        Me.Controls.Add(Me.txbSaldo)
        Me.Controls.Add(Me.txbCliente)
        Me.Controls.Add(Me.txbConta)
        Me.Controls.Add(Me.lblSaldoFinal)
        Me.Controls.Add(Me.lblValor)
        Me.Controls.Add(Me.lblAniversario)
        Me.Controls.Add(Me.lblSaldo)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.lblConta)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblConta As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblSaldo As Label
    Friend WithEvents lblAniversario As Label
    Friend WithEvents lblValor As Label
    Friend WithEvents lblSaldoFinal As Label
    Friend WithEvents txbConta As TextBox
    Friend WithEvents txbCliente As TextBox
    Friend WithEvents txbAniversario As TextBox
    Friend WithEvents txbSaldo As TextBox
    Friend WithEvents txbValor As TextBox
    Friend WithEvents txbSaldoFinal As TextBox
    Friend WithEvents btnDepositar As Button
    Friend WithEvents btnSacar As Button
    Friend WithEvents btnCriar As Button
End Class
