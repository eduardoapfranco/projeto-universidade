<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pessoa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnInserir = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnLocalizar = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.gbForm = New System.Windows.Forms.GroupBox()
        Me.txtCelular = New System.Windows.Forms.MaskedTextBox()
        Me.txtTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.txtCPF = New System.Windows.Forms.MaskedTextBox()
        Me.txtCEP = New System.Windows.Forms.MaskedTextBox()
        Me.dtpDataNascimento = New System.Windows.Forms.DateTimePicker()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbSexo = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRG = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbBotoes = New System.Windows.Forms.GroupBox()
        Me.gbForm.SuspendLayout()
        Me.gbBotoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnInserir
        '
        Me.btnInserir.Location = New System.Drawing.Point(17, 19)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Size = New System.Drawing.Size(75, 23)
        Me.btnInserir.TabIndex = 36
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(98, 19)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(75, 23)
        Me.btnAlterar.TabIndex = 37
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(179, 19)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvar.TabIndex = 38
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(260, 19)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluir.TabIndex = 39
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(341, 19)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 40
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnLocalizar
        '
        Me.btnLocalizar.Location = New System.Drawing.Point(422, 19)
        Me.btnLocalizar.Name = "btnLocalizar"
        Me.btnLocalizar.Size = New System.Drawing.Size(75, 23)
        Me.btnLocalizar.TabIndex = 41
        Me.btnLocalizar.Text = "Localizar"
        Me.btnLocalizar.UseVisualStyleBackColor = True
        '
        'gbForm
        '
        Me.gbForm.Controls.Add(Me.txtCelular)
        Me.gbForm.Controls.Add(Me.txtTelefone)
        Me.gbForm.Controls.Add(Me.txtCPF)
        Me.gbForm.Controls.Add(Me.txtCEP)
        Me.gbForm.Controls.Add(Me.dtpDataNascimento)
        Me.gbForm.Controls.Add(Me.txtCodigo)
        Me.gbForm.Controls.Add(Me.Label17)
        Me.gbForm.Controls.Add(Me.Label16)
        Me.gbForm.Controls.Add(Me.txtEmail)
        Me.gbForm.Controls.Add(Me.Label15)
        Me.gbForm.Controls.Add(Me.cbSexo)
        Me.gbForm.Controls.Add(Me.Label14)
        Me.gbForm.Controls.Add(Me.Label13)
        Me.gbForm.Controls.Add(Me.Label11)
        Me.gbForm.Controls.Add(Me.Label10)
        Me.gbForm.Controls.Add(Me.cbEstado)
        Me.gbForm.Controls.Add(Me.Label9)
        Me.gbForm.Controls.Add(Me.txtCidade)
        Me.gbForm.Controls.Add(Me.Label8)
        Me.gbForm.Controls.Add(Me.txtBairro)
        Me.gbForm.Controls.Add(Me.Label7)
        Me.gbForm.Controls.Add(Me.txtComplemento)
        Me.gbForm.Controls.Add(Me.Label6)
        Me.gbForm.Controls.Add(Me.txtNumero)
        Me.gbForm.Controls.Add(Me.Label5)
        Me.gbForm.Controls.Add(Me.txtEndereco)
        Me.gbForm.Controls.Add(Me.Label4)
        Me.gbForm.Controls.Add(Me.Label3)
        Me.gbForm.Controls.Add(Me.txtRG)
        Me.gbForm.Controls.Add(Me.Label2)
        Me.gbForm.Controls.Add(Me.txtNome)
        Me.gbForm.Controls.Add(Me.Label1)
        Me.gbForm.Location = New System.Drawing.Point(22, 12)
        Me.gbForm.Name = "gbForm"
        Me.gbForm.Size = New System.Drawing.Size(876, 276)
        Me.gbForm.TabIndex = 42
        Me.gbForm.TabStop = False
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(367, 191)
        Me.txtCelular.Mask = "(00) 00000-0000"
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(208, 20)
        Me.txtCelular.TabIndex = 70
        '
        'txtTelefone
        '
        Me.txtTelefone.Location = New System.Drawing.Point(98, 190)
        Me.txtTelefone.Mask = "(00) 0000-0000"
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(208, 20)
        Me.txtTelefone.TabIndex = 65
        '
        'txtCPF
        '
        Me.txtCPF.Location = New System.Drawing.Point(635, 86)
        Me.txtCPF.Mask = "000.000.000-00"
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(208, 20)
        Me.txtCPF.TabIndex = 15
        '
        'txtCEP
        '
        Me.txtCEP.Location = New System.Drawing.Point(367, 138)
        Me.txtCEP.Mask = "00000-000"
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(208, 20)
        Me.txtCEP.TabIndex = 40
        '
        'dtpDataNascimento
        '
        Me.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataNascimento.Location = New System.Drawing.Point(98, 165)
        Me.dtpDataNascimento.MinDate = New Date(1920, 1, 1, 0, 0, 0, 0)
        Me.dtpDataNascimento.Name = "dtpDataNascimento"
        Me.dtpDataNascimento.Size = New System.Drawing.Size(208, 20)
        Me.dtpDataNascimento.TabIndex = 50
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(98, 60)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(91, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(22, 67)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(33, 13)
        Me.Label17.TabIndex = 66
        Me.Label17.Text = "COD:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(311, 141)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(34, 13)
        Me.Label16.TabIndex = 64
        Me.Label16.Text = "CEP: "
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(635, 141)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(208, 20)
        Me.txtEmail.TabIndex = 45
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(579, 145)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(48, 13)
        Me.Label15.TabIndex = 62
        Me.Label15.Text = "E-MAIL: "
        '
        'cbSexo
        '
        Me.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSexo.FormattingEnabled = True
        Me.cbSexo.Items.AddRange(New Object() {"M - Masculino", "F - Feminino"})
        Me.cbSexo.Location = New System.Drawing.Point(635, 190)
        Me.cbSexo.Name = "cbSexo"
        Me.cbSexo.Size = New System.Drawing.Size(209, 21)
        Me.cbSexo.TabIndex = 75
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(581, 198)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 13)
        Me.Label14.TabIndex = 60
        Me.Label14.Text = "SEXO: "
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(22, 167)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 13)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "DT NASC.:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(311, 196)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "CEL:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 193)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "TEL:"
        '
        'cbEstado
        '
        Me.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Items.AddRange(New Object() {"AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"})
        Me.cbEstado.Location = New System.Drawing.Point(636, 164)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(208, 21)
        Me.cbEstado.TabIndex = 60
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(581, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 13)
        Me.Label9.TabIndex = 52
        Me.Label9.Text = "UF:"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(367, 164)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(208, 20)
        Me.txtCidade.TabIndex = 55
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(311, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "CIDADE:"
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(98, 138)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(208, 20)
        Me.txtBairro.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "BAIRRO:"
        '
        'txtComplemento
        '
        Me.txtComplemento.Location = New System.Drawing.Point(635, 112)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(208, 20)
        Me.txtComplemento.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(579, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "COMPL.:"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(367, 112)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(208, 20)
        Me.txtNumero.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(312, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "NUM:"
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(98, 112)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(208, 20)
        Me.txtEndereco.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "ENDEREÇO:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(581, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "CPF:"
        '
        'txtRG
        '
        Me.txtRG.Location = New System.Drawing.Point(367, 86)
        Me.txtRG.Name = "txtRG"
        Me.txtRG.Size = New System.Drawing.Size(208, 20)
        Me.txtRG.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(313, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "RG:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(98, 86)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(208, 20)
        Me.txtNome.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "NOME:"
        '
        'gbBotoes
        '
        Me.gbBotoes.Controls.Add(Me.btnInserir)
        Me.gbBotoes.Controls.Add(Me.btnAlterar)
        Me.gbBotoes.Controls.Add(Me.btnLocalizar)
        Me.gbBotoes.Controls.Add(Me.btnSalvar)
        Me.gbBotoes.Controls.Add(Me.btnCancelar)
        Me.gbBotoes.Controls.Add(Me.btnExcluir)
        Me.gbBotoes.Location = New System.Drawing.Point(21, 294)
        Me.gbBotoes.Name = "gbBotoes"
        Me.gbBotoes.Size = New System.Drawing.Size(877, 62)
        Me.gbBotoes.TabIndex = 43
        Me.gbBotoes.TabStop = False
        '
        'Pessoa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 388)
        Me.Controls.Add(Me.gbBotoes)
        Me.Controls.Add(Me.gbForm)
        Me.Name = "Pessoa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PESSOA"
        Me.gbForm.ResumeLayout(False)
        Me.gbForm.PerformLayout()
        Me.gbBotoes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnInserir As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnLocalizar As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cbSexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtComplemento As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRG As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbBotoes As System.Windows.Forms.GroupBox
    Friend WithEvents gbForm As System.Windows.Forms.GroupBox
    Friend WithEvents txtCEP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtTelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCelular As System.Windows.Forms.MaskedTextBox
    Friend WithEvents dtpDataNascimento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
