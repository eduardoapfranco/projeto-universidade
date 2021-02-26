<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Professor
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
        Me.gbForm = New System.Windows.Forms.GroupBox()
        Me.cbClassificacao = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnLocalizarPessoa = New System.Windows.Forms.Button()
        Me.txtCodigoPessoa = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbBotoes = New System.Windows.Forms.GroupBox()
        Me.btnLocalizar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnInserir = New System.Windows.Forms.Button()
        Me.gbForm.SuspendLayout()
        Me.gbBotoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbForm
        '
        Me.gbForm.Controls.Add(Me.cbClassificacao)
        Me.gbForm.Controls.Add(Me.Label5)
        Me.gbForm.Controls.Add(Me.btnLocalizarPessoa)
        Me.gbForm.Controls.Add(Me.txtCodigoPessoa)
        Me.gbForm.Controls.Add(Me.Label4)
        Me.gbForm.Controls.Add(Me.txtNome)
        Me.gbForm.Controls.Add(Me.Label3)
        Me.gbForm.Controls.Add(Me.txtMatricula)
        Me.gbForm.Controls.Add(Me.Label2)
        Me.gbForm.Controls.Add(Me.txtCodigo)
        Me.gbForm.Controls.Add(Me.Label1)
        Me.gbForm.Location = New System.Drawing.Point(12, 12)
        Me.gbForm.Name = "gbForm"
        Me.gbForm.Size = New System.Drawing.Size(665, 148)
        Me.gbForm.TabIndex = 0
        Me.gbForm.TabStop = False
        '
        'cbClassificacao
        '
        Me.cbClassificacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbClassificacao.FormattingEnabled = True
        Me.cbClassificacao.Location = New System.Drawing.Point(21, 110)
        Me.cbClassificacao.Name = "cbClassificacao"
        Me.cbClassificacao.Size = New System.Drawing.Size(178, 21)
        Me.cbClassificacao.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "CLASSIFICAÇÃO: "
        '
        'btnLocalizarPessoa
        '
        Me.btnLocalizarPessoa.Location = New System.Drawing.Point(530, 16)
        Me.btnLocalizarPessoa.Name = "btnLocalizarPessoa"
        Me.btnLocalizarPessoa.Size = New System.Drawing.Size(126, 23)
        Me.btnLocalizarPessoa.TabIndex = 6
        Me.btnLocalizarPessoa.Text = "Localizar Pessoa"
        Me.btnLocalizarPessoa.UseVisualStyleBackColor = True
        '
        'txtCodigoPessoa
        '
        Me.txtCodigoPessoa.Location = New System.Drawing.Point(242, 72)
        Me.txtCodigoPessoa.Name = "txtCodigoPessoa"
        Me.txtCodigoPessoa.Size = New System.Drawing.Size(215, 20)
        Me.txtCodigoPessoa.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(233, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "COD PESSOA: "
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(21, 72)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(215, 20)
        Me.txtNome.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "NOME: "
        '
        'txtMatricula
        '
        Me.txtMatricula.Location = New System.Drawing.Point(127, 33)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(100, 20)
        Me.txtMatricula.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(124, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "MATRICULA: "
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(21, 33)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COD PROFESSOR :"
        '
        'gbBotoes
        '
        Me.gbBotoes.Controls.Add(Me.btnLocalizar)
        Me.gbBotoes.Controls.Add(Me.btnExcluir)
        Me.gbBotoes.Controls.Add(Me.btnCancelar)
        Me.gbBotoes.Controls.Add(Me.btnSalvar)
        Me.gbBotoes.Controls.Add(Me.btnInserir)
        Me.gbBotoes.Location = New System.Drawing.Point(12, 175)
        Me.gbBotoes.Name = "gbBotoes"
        Me.gbBotoes.Size = New System.Drawing.Size(665, 110)
        Me.gbBotoes.TabIndex = 1
        Me.gbBotoes.TabStop = False
        '
        'btnLocalizar
        '
        Me.btnLocalizar.Location = New System.Drawing.Point(358, 49)
        Me.btnLocalizar.Name = "btnLocalizar"
        Me.btnLocalizar.Size = New System.Drawing.Size(107, 23)
        Me.btnLocalizar.TabIndex = 5
        Me.btnLocalizar.Text = "Localizar Professor"
        Me.btnLocalizar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(277, 49)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluir.TabIndex = 3
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(196, 49)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(115, 49)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvar.TabIndex = 3
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnInserir
        '
        Me.btnInserir.Location = New System.Drawing.Point(34, 49)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Size = New System.Drawing.Size(75, 23)
        Me.btnInserir.TabIndex = 2
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.UseVisualStyleBackColor = True
        '
        'Professor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 541)
        Me.Controls.Add(Me.gbBotoes)
        Me.Controls.Add(Me.gbForm)
        Me.Name = "Professor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PROFESSOR"
        Me.gbForm.ResumeLayout(False)
        Me.gbForm.PerformLayout()
        Me.gbBotoes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbForm As System.Windows.Forms.GroupBox
    Friend WithEvents gbBotoes As System.Windows.Forms.GroupBox
    Friend WithEvents txtMatricula As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnLocalizar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnInserir As System.Windows.Forms.Button
    Friend WithEvents txtCodigoPessoa As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnLocalizarPessoa As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbClassificacao As System.Windows.Forms.ComboBox
End Class
