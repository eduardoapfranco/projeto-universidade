<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarPessoaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarAlunoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarProfessorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CursoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisciplinaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MATRICULAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RELATORIOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RELACAOCURSOSEDOCENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RELACAOALUNOCURSOPORSEMANOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RELACAOTOTALALUNOPORSEMANOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbRelatorioCidade = New System.Windows.Forms.GroupBox()
        Me.gbRelatorioTotal = New System.Windows.Forms.GroupBox()
        Me.cbAnoTotal = New System.Windows.Forms.ComboBox()
        Me.cbSemestreTotal = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbAno = New System.Windows.Forms.ComboBox()
        Me.cbSemestre = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnGerarRelatorioAluno = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.gbRelatorioCidade.SuspendLayout()
        Me.gbRelatorioTotal.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarToolStripMenuItem, Me.RELATORIOSToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(604, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastrarToolStripMenuItem
        '
        Me.CadastrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarPessoaToolStripMenuItem, Me.CadastrarAlunoToolStripMenuItem, Me.CadastrarProfessorToolStripMenuItem, Me.CursoToolStripMenuItem, Me.DisciplinaToolStripMenuItem, Me.MATRICULAToolStripMenuItem})
        Me.CadastrarToolStripMenuItem.Name = "CadastrarToolStripMenuItem"
        Me.CadastrarToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.CadastrarToolStripMenuItem.Text = "CADASTROS"
        '
        'CadastrarPessoaToolStripMenuItem
        '
        Me.CadastrarPessoaToolStripMenuItem.Name = "CadastrarPessoaToolStripMenuItem"
        Me.CadastrarPessoaToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.CadastrarPessoaToolStripMenuItem.Text = "PESSOA"
        '
        'CadastrarAlunoToolStripMenuItem
        '
        Me.CadastrarAlunoToolStripMenuItem.Name = "CadastrarAlunoToolStripMenuItem"
        Me.CadastrarAlunoToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.CadastrarAlunoToolStripMenuItem.Text = "ALUNO"
        '
        'CadastrarProfessorToolStripMenuItem
        '
        Me.CadastrarProfessorToolStripMenuItem.Name = "CadastrarProfessorToolStripMenuItem"
        Me.CadastrarProfessorToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.CadastrarProfessorToolStripMenuItem.Text = "PROFESSOR"
        '
        'CursoToolStripMenuItem
        '
        Me.CursoToolStripMenuItem.Name = "CursoToolStripMenuItem"
        Me.CursoToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.CursoToolStripMenuItem.Text = "CURSO"
        '
        'DisciplinaToolStripMenuItem
        '
        Me.DisciplinaToolStripMenuItem.Name = "DisciplinaToolStripMenuItem"
        Me.DisciplinaToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.DisciplinaToolStripMenuItem.Text = "DISCIPLINA"
        '
        'MATRICULAToolStripMenuItem
        '
        Me.MATRICULAToolStripMenuItem.Name = "MATRICULAToolStripMenuItem"
        Me.MATRICULAToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.MATRICULAToolStripMenuItem.Text = "MATRICULA"
        '
        'RELATORIOSToolStripMenuItem
        '
        Me.RELATORIOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RELACAOCURSOSEDOCENTESToolStripMenuItem, Me.RELACAOALUNOCURSOPORSEMANOToolStripMenuItem, Me.RELACAOTOTALALUNOPORSEMANOToolStripMenuItem})
        Me.RELATORIOSToolStripMenuItem.Name = "RELATORIOSToolStripMenuItem"
        Me.RELATORIOSToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.RELATORIOSToolStripMenuItem.Text = "RELATORIOS"
        '
        'RELACAOCURSOSEDOCENTESToolStripMenuItem
        '
        Me.RELACAOCURSOSEDOCENTESToolStripMenuItem.Name = "RELACAOCURSOSEDOCENTESToolStripMenuItem"
        Me.RELACAOCURSOSEDOCENTESToolStripMenuItem.Size = New System.Drawing.Size(299, 22)
        Me.RELACAOCURSOSEDOCENTESToolStripMenuItem.Text = "RELACAO CURSOS E DOCENTES"
        '
        'RELACAOALUNOCURSOPORSEMANOToolStripMenuItem
        '
        Me.RELACAOALUNOCURSOPORSEMANOToolStripMenuItem.Name = "RELACAOALUNOCURSOPORSEMANOToolStripMenuItem"
        Me.RELACAOALUNOCURSOPORSEMANOToolStripMenuItem.Size = New System.Drawing.Size(299, 22)
        Me.RELACAOALUNOCURSOPORSEMANOToolStripMenuItem.Text = "RELACAO ALUNO CURSO POR SEM / ANO"
        '
        'RELACAOTOTALALUNOPORSEMANOToolStripMenuItem
        '
        Me.RELACAOTOTALALUNOPORSEMANOToolStripMenuItem.Name = "RELACAOTOTALALUNOPORSEMANOToolStripMenuItem"
        Me.RELACAOTOTALALUNOPORSEMANOToolStripMenuItem.Size = New System.Drawing.Size(299, 22)
        Me.RELACAOTOTALALUNOPORSEMANOToolStripMenuItem.Text = "RELACAO TOTAL ALUNO POR SEM / ANO"
        '
        'gbRelatorioCidade
        '
        Me.gbRelatorioCidade.Controls.Add(Me.Label4)
        Me.gbRelatorioCidade.Controls.Add(Me.cbAno)
        Me.gbRelatorioCidade.Controls.Add(Me.cbSemestre)
        Me.gbRelatorioCidade.Controls.Add(Me.Label6)
        Me.gbRelatorioCidade.Controls.Add(Me.Label5)
        Me.gbRelatorioCidade.Controls.Add(Me.btnGerarRelatorioAluno)
        Me.gbRelatorioCidade.Location = New System.Drawing.Point(12, 48)
        Me.gbRelatorioCidade.Name = "gbRelatorioCidade"
        Me.gbRelatorioCidade.Size = New System.Drawing.Size(266, 208)
        Me.gbRelatorioCidade.TabIndex = 4
        Me.gbRelatorioCidade.TabStop = False
        Me.gbRelatorioCidade.Visible = False
        '
        'gbRelatorioTotal
        '
        Me.gbRelatorioTotal.Controls.Add(Me.Label3)
        Me.gbRelatorioTotal.Controls.Add(Me.cbAnoTotal)
        Me.gbRelatorioTotal.Controls.Add(Me.cbSemestreTotal)
        Me.gbRelatorioTotal.Controls.Add(Me.Label1)
        Me.gbRelatorioTotal.Controls.Add(Me.Label2)
        Me.gbRelatorioTotal.Controls.Add(Me.Button1)
        Me.gbRelatorioTotal.Location = New System.Drawing.Point(310, 48)
        Me.gbRelatorioTotal.Name = "gbRelatorioTotal"
        Me.gbRelatorioTotal.Size = New System.Drawing.Size(257, 208)
        Me.gbRelatorioTotal.TabIndex = 30
        Me.gbRelatorioTotal.TabStop = False
        Me.gbRelatorioTotal.Visible = False
        '
        'cbAnoTotal
        '
        Me.cbAnoTotal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAnoTotal.FormattingEnabled = True
        Me.cbAnoTotal.Items.AddRange(New Object() {"2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023"})
        Me.cbAnoTotal.Location = New System.Drawing.Point(33, 76)
        Me.cbAnoTotal.Name = "cbAnoTotal"
        Me.cbAnoTotal.Size = New System.Drawing.Size(103, 21)
        Me.cbAnoTotal.TabIndex = 28
        '
        'cbSemestreTotal
        '
        Me.cbSemestreTotal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSemestreTotal.FormattingEnabled = True
        Me.cbSemestreTotal.Items.AddRange(New Object() {"1", "2"})
        Me.cbSemestreTotal.Location = New System.Drawing.Point(142, 75)
        Me.cbSemestreTotal.Name = "cbSemestreTotal"
        Me.cbSemestreTotal.Size = New System.Drawing.Size(103, 21)
        Me.cbSemestreTotal.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(139, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "SEMESTRE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "ANO:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(33, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Gerar Relatorio"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbAno
        '
        Me.cbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAno.FormattingEnabled = True
        Me.cbAno.Items.AddRange(New Object() {"2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023"})
        Me.cbAno.Location = New System.Drawing.Point(33, 76)
        Me.cbAno.Name = "cbAno"
        Me.cbAno.Size = New System.Drawing.Size(103, 21)
        Me.cbAno.TabIndex = 28
        '
        'cbSemestre
        '
        Me.cbSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSemestre.FormattingEnabled = True
        Me.cbSemestre.Items.AddRange(New Object() {"1", "2"})
        Me.cbSemestre.Location = New System.Drawing.Point(142, 75)
        Me.cbSemestre.Name = "cbSemestre"
        Me.cbSemestre.Size = New System.Drawing.Size(103, 21)
        Me.cbSemestre.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(139, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "SEMESTRE:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "ANO:"
        '
        'btnGerarRelatorioAluno
        '
        Me.btnGerarRelatorioAluno.Location = New System.Drawing.Point(33, 120)
        Me.btnGerarRelatorioAluno.Name = "btnGerarRelatorioAluno"
        Me.btnGerarRelatorioAluno.Size = New System.Drawing.Size(143, 23)
        Me.btnGerarRelatorioAluno.TabIndex = 2
        Me.btnGerarRelatorioAluno.Text = "Gerar Relatorio"
        Me.btnGerarRelatorioAluno.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "RELATÓRIO TOTAL ALUNOS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "RELATÓRIO  ALUNOS POR CURSO"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 511)
        Me.Controls.Add(Me.gbRelatorioTotal)
        Me.Controls.Add(Me.gbRelatorioCidade)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SISTEMA UNIVERSIDADE"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbRelatorioCidade.ResumeLayout(False)
        Me.gbRelatorioCidade.PerformLayout()
        Me.gbRelatorioTotal.ResumeLayout(False)
        Me.gbRelatorioTotal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CadastrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastrarPessoaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastrarAlunoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastrarProfessorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CursoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisciplinaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MATRICULAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RELATORIOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RELACAOCURSOSEDOCENTESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RELACAOALUNOCURSOPORSEMANOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RELACAOTOTALALUNOPORSEMANOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gbRelatorioCidade As System.Windows.Forms.GroupBox
    Friend WithEvents btnGerarRelatorioAluno As System.Windows.Forms.Button
    Friend WithEvents cbAno As System.Windows.Forms.ComboBox
    Friend WithEvents cbSemestre As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gbRelatorioTotal As System.Windows.Forms.GroupBox
    Friend WithEvents cbAnoTotal As System.Windows.Forms.ComboBox
    Friend WithEvents cbSemestreTotal As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
