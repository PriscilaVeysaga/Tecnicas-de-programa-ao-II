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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.lblAltura = New System.Windows.Forms.Label()
        Me.txbPeso = New System.Windows.Forms.TextBox()
        Me.txbAltura = New System.Windows.Forms.TextBox()
        Me.btnImc = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(182, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Calculadora de IMC"
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Location = New System.Drawing.Point(71, 105)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(90, 15)
        Me.lblPeso.TabIndex = 1
        Me.lblPeso.Text = "Digite seu peso:"
        '
        'lblAltura
        '
        Me.lblAltura.AutoSize = True
        Me.lblAltura.Location = New System.Drawing.Point(71, 153)
        Me.lblAltura.Name = "lblAltura"
        Me.lblAltura.Size = New System.Drawing.Size(98, 15)
        Me.lblAltura.TabIndex = 2
        Me.lblAltura.Text = "Digite sua altura: "
        '
        'txbPeso
        '
        Me.txbPeso.Location = New System.Drawing.Point(182, 102)
        Me.txbPeso.Name = "txbPeso"
        Me.txbPeso.Size = New System.Drawing.Size(250, 23)
        Me.txbPeso.TabIndex = 3
        '
        'txbAltura
        '
        Me.txbAltura.Location = New System.Drawing.Point(182, 145)
        Me.txbAltura.Name = "txbAltura"
        Me.txbAltura.Size = New System.Drawing.Size(250, 23)
        Me.txbAltura.TabIndex = 4
        '
        'btnImc
        '
        Me.btnImc.Location = New System.Drawing.Point(71, 229)
        Me.btnImc.Name = "btnImc"
        Me.btnImc.Size = New System.Drawing.Size(107, 45)
        Me.btnImc.TabIndex = 5
        Me.btnImc.Text = "Calcular IMC"
        Me.btnImc.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(233, 229)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(107, 45)
        Me.btnLimpar.TabIndex = 6
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(400, 229)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(107, 45)
        Me.btnSair.TabIndex = 7
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 450)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnImc)
        Me.Controls.Add(Me.txbAltura)
        Me.Controls.Add(Me.txbPeso)
        Me.Controls.Add(Me.lblAltura)
        Me.Controls.Add(Me.lblPeso)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblPeso As Label
    Friend WithEvents lblAltura As Label
    Friend WithEvents txbPeso As TextBox
    Friend WithEvents txbAltura As TextBox
    Friend WithEvents btnImc As Button
    Friend WithEvents btnLimpar As Button
    Friend WithEvents btnSair As Button
End Class
