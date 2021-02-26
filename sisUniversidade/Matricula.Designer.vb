<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Matricula
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
        Me.cbTermo = New System.Windows.Forms.ComboBox()
        Me.cbTurma = New System.Windows.Forms.ComboBox()
        Me.cbAno = New System.Windows.Forms.ComboBox()
        Me.cbSemestre = New System.Windows.Forms.ComboBox()
        Me.btnExcluirDisc = New System.Windows.Forms.Button()
        Me.btnInserirDisc = New System.Windows.Forms.Button()
        Me.cbDisciplinas = New System.Windows.Forms.ComboBox()
        Me.DISCIPLINAS = New System.Windows.Forms.Label()
        Me.dgDados = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLocalizarCurso = New System.Windows.Forms.Button()
        Me.btnLocalizarAluno = New System.Windows.Forms.Button()
        Me.txtCurso = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAluno = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCodigoCurso = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCodigoAluno = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbBotoes = New System.Windows.Forms.GroupBox()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnLocalizar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnInserir = New System.Windows.Forms.Button()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.gbForm.SuspendLayout()
        CType(Me.dgDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBotoes.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbForm
        '
        Me.gbForm.Controls.Add(Me.cbTermo)
        Me.gbForm.Controls.Add(Me.cbTurma)
        Me.gbForm.Controls.Add(Me.cbAno)
        Me.gbForm.Controls.Add(Me.cbSemestre)
        Me.gbForm.Controls.Add(Me.btnExcluirDisc)
        Me.gbForm.Controls.Add(Me.btnInserirDisc)
        Me.gbForm.Controls.Add(Me.cbDisciplinas)
        Me.gbForm.Controls.Add(Me.DISCIPLINAS)
        Me.gbForm.Controls.Add(Me.dgDados)
        Me.gbForm.Controls.Add(Me.txtValor)
        Me.gbForm.Controls.Add(Me.Label2)
        Me.gbForm.Controls.Add(Me.btnLocalizarCurso)
        Me.gbForm.Controls.Add(Me.btnLocalizarAluno)
        Me.gbForm.Controls.Add(Me.txtCurso)
        Me.gbForm.Controls.Add(Me.Label10)
        Me.gbForm.Controls.Add(Me.txtAluno)
        Me.gbForm.Controls.Add(Me.Label9)
        Me.gbForm.Controls.Add(Me.txtCodigoCurso)
        Me.gbForm.Controls.Add(Me.Label8)
        Me.gbForm.Controls.Add(Me.txtCodigoAluno)
        Me.gbForm.Controls.Add(Me.Label7)
        Me.gbForm.Controls.Add(Me.Label6)
        Me.gbForm.Controls.Add(Me.Label5)
        Me.gbForm.Controls.Add(Me.Label4)
        Me.gbForm.Controls.Add(Me.Label3)
        Me.gbForm.Controls.Add(Me.txtCodigo)
        Me.gbForm.Controls.Add(Me.Label1)
        Me.gbForm.Location = New System.Drawing.Point(12, 12)
        Me.gbForm.Name = "gbForm"
        Me.gbForm.Size = New System.Drawing.Size(665, 433)
        Me.gbForm.TabIndex = 0
        Me.gbForm.TabStop = False
        '
        'cbTermo
        '
        Me.cbTermo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTermo.FormattingEnabled = True
        Me.cbTermo.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cbTermo.Location = New System.Drawing.Point(19, 72)
        Me.cbTermo.Name = "cbTermo"
        Me.cbTermo.Size = New System.Drawing.Size(103, 21)
        Me.cbTermo.TabIndex = 10
        '
        'cbTurma
        '
        Me.cbTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTurma.FormattingEnabled = True
        Me.cbTurma.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "X", "Z"})
        Me.cbTurma.Location = New System.Drawing.Point(127, 72)
        Me.cbTurma.Name = "cbTurma"
        Me.cbTurma.Size = New System.Drawing.Size(103, 21)
        Me.cbTurma.TabIndex = 15
        '
        'cbAno
        '
        Me.cbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAno.FormattingEnabled = True
        Me.cbAno.Items.AddRange(New Object() {"2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023"})
        Me.cbAno.Location = New System.Drawing.Point(18, 117)
        Me.cbAno.Name = "cbAno"
        Me.cbAno.Size = New System.Drawing.Size(103, 21)
        Me.cbAno.TabIndex = 20
        '
        'cbSemestre
        '
        Me.cbSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSemestre.FormattingEnabled = True
        Me.cbSemestre.Items.AddRange(New Object() {"1", "2"})
        Me.cbSemestre.Location = New System.Drawing.Point(127, 116)
        Me.cbSemestre.Name = "cbSemestre"
        Me.cbSemestre.Size = New System.Drawing.Size(103, 21)
        Me.cbSemestre.TabIndex = 25
        '
        'btnExcluirDisc
        '
        Me.btnExcluirDisc.Location = New System.Drawing.Point(518, 245)
        Me.btnExcluirDisc.Name = "btnExcluirDisc"
        Me.btnExcluirDisc.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluirDisc.TabIndex = 1004
        Me.btnExcluirDisc.Text = "Excluir"
        Me.btnExcluirDisc.UseVisualStyleBackColor = True
        '
        'btnInserirDisc
        '
        Me.btnInserirDisc.Location = New System.Drawing.Point(430, 245)
        Me.btnInserirDisc.Name = "btnInserirDisc"
        Me.btnInserirDisc.Size = New System.Drawing.Size(75, 23)
        Me.btnInserirDisc.TabIndex = 1003
        Me.btnInserirDisc.Text = "Inserir"
        Me.btnInserirDisc.UseVisualStyleBackColor = True
        '
        'cbDisciplinas
        '
        Me.cbDisciplinas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDisciplinas.FormattingEnabled = True
        Me.cbDisciplinas.Location = New System.Drawing.Point(99, 247)
        Me.cbDisciplinas.Name = "cbDisciplinas"
        Me.cbDisciplinas.Size = New System.Drawing.Size(307, 21)
        Me.cbDisciplinas.TabIndex = 1002
        '
        'DISCIPLINAS
        '
        Me.DISCIPLINAS.AutoSize = True
        Me.DISCIPLINAS.Location = New System.Drawing.Point(18, 247)
        Me.DISCIPLINAS.Name = "DISCIPLINAS"
        Me.DISCIPLINAS.Size = New System.Drawing.Size(79, 13)
        Me.DISCIPLINAS.TabIndex = 1001
        Me.DISCIPLINAS.Text = "DISCIPLINAS :"
        '
        'dgDados
        '
        Me.dgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDados.Location = New System.Drawing.Point(19, 274)
        Me.dgDados.MultiSelect = False
        Me.dgDados.Name = "dgDados"
        Me.dgDados.Size = New System.Drawing.Size(574, 153)
        Me.dgDados.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(233, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1000
        Me.Label2.Text = "VALOR:"
        '
        'btnLocalizarCurso
        '
        Me.btnLocalizarCurso.Location = New System.Drawing.Point(357, 208)
        Me.btnLocalizarCurso.Name = "btnLocalizarCurso"
        Me.btnLocalizarCurso.Size = New System.Drawing.Size(129, 23)
        Me.btnLocalizarCurso.TabIndex = 35
        Me.btnLocalizarCurso.Text = "Localizar Curso"
        Me.btnLocalizarCurso.UseVisualStyleBackColor = True
        '
        'btnLocalizarAluno
        '
        Me.btnLocalizarAluno.Location = New System.Drawing.Point(357, 165)
        Me.btnLocalizarAluno.Name = "btnLocalizarAluno"
        Me.btnLocalizarAluno.Size = New System.Drawing.Size(129, 23)
        Me.btnLocalizarAluno.TabIndex = 30
        Me.btnLocalizarAluno.Text = "Localizar Aluno"
        Me.btnLocalizarAluno.UseVisualStyleBackColor = True
        '
        'txtCurso
        '
        Me.txtCurso.Location = New System.Drawing.Point(129, 211)
        Me.txtCurso.Name = "txtCurso"
        Me.txtCurso.Size = New System.Drawing.Size(215, 20)
        Me.txtCurso.TabIndex = 997
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(120, 195)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "CURSO:"
        '
        'txtAluno
        '
        Me.txtAluno.Location = New System.Drawing.Point(129, 167)
        Me.txtAluno.Name = "txtAluno"
        Me.txtAluno.Size = New System.Drawing.Size(215, 20)
        Me.txtAluno.TabIndex = 998
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(120, 151)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "ALUNO:"
        '
        'txtCodigoCurso
        '
        Me.txtCodigoCurso.Location = New System.Drawing.Point(19, 211)
        Me.txtCodigoCurso.Name = "txtCodigoCurso"
        Me.txtCodigoCurso.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoCurso.TabIndex = 997
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 194)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "COD CURSO :"
        '
        'txtCodigoAluno
        '
        Me.txtCodigoAluno.Location = New System.Drawing.Point(21, 167)
        Me.txtCodigoAluno.Name = "txtCodigoAluno"
        Me.txtCodigoAluno.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoAluno.TabIndex = 999
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "COD ALUNO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(124, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "SEMESTRE:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "ANO:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(118, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "TURMA: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "TERMO: "
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
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COD MATRICULA :"
        '
        'gbBotoes
        '
        Me.gbBotoes.Controls.Add(Me.btnAlterar)
        Me.gbBotoes.Controls.Add(Me.btnLocalizar)
        Me.gbBotoes.Controls.Add(Me.btnExcluir)
        Me.gbBotoes.Controls.Add(Me.btnCancelar)
        Me.gbBotoes.Controls.Add(Me.btnSalvar)
        Me.gbBotoes.Controls.Add(Me.btnInserir)
        Me.gbBotoes.Location = New System.Drawing.Point(12, 451)
        Me.gbBotoes.Name = "gbBotoes"
        Me.gbBotoes.Size = New System.Drawing.Size(665, 60)
        Me.gbBotoes.TabIndex = 1
        Me.gbBotoes.TabStop = False
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(99, 19)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(75, 23)
        Me.btnAlterar.TabIndex = 6
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnLocalizar
        '
        Me.btnLocalizar.Location = New System.Drawing.Point(423, 19)
        Me.btnLocalizar.Name = "btnLocalizar"
        Me.btnLocalizar.Size = New System.Drawing.Size(107, 23)
        Me.btnLocalizar.TabIndex = 5
        Me.btnLocalizar.Text = "Localizar"
        Me.btnLocalizar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(342, 19)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluir.TabIndex = 3
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(261, 19)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(180, 19)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvar.TabIndex = 3
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnInserir
        '
        Me.btnInserir.Location = New System.Drawing.Point(19, 19)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Size = New System.Drawing.Size(75, 23)
        Me.btnInserir.TabIndex = 2
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.UseVisualStyleBackColor = True
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(236, 117)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(100, 20)
        Me.txtValor.TabIndex = 26
        '
        'Matricula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 610)
        Me.Controls.Add(Me.gbBotoes)
        Me.Controls.Add(Me.gbForm)
        Me.Name = "Matricula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MATRICULA"
        Me.gbForm.ResumeLayout(False)
        Me.gbForm.PerformLayout()
        CType(Me.dgDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBotoes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbForm As System.Windows.Forms.GroupBox
    Friend WithEvents gbBotoes As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnLocalizar As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnInserir As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoCurso As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoAluno As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCurso As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtAluno As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnLocalizarAluno As System.Windows.Forms.Button
    Friend WithEvents btnLocalizarCurso As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgDados As System.Windows.Forms.DataGridView
    Friend WithEvents DISCIPLINAS As System.Windows.Forms.Label
    Friend WithEvents cbDisciplinas As System.Windows.Forms.ComboBox
    Friend WithEvents btnExcluirDisc As System.Windows.Forms.Button
    Friend WithEvents btnInserirDisc As System.Windows.Forms.Button
    Friend WithEvents cbSemestre As System.Windows.Forms.ComboBox
    Friend WithEvents cbAno As System.Windows.Forms.ComboBox
    Friend WithEvents cbTermo As System.Windows.Forms.ComboBox
    Friend WithEvents cbTurma As System.Windows.Forms.ComboBox
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
End Class
