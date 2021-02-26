Public Class Principal

    Private Sub CadastrarPessoaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarPessoaToolStripMenuItem.Click
        Dim frm As New Pessoa
        frm.ShowDialog()
    End Sub


    Private Sub CadastrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarToolStripMenuItem.Click

    End Sub

    Private Sub CadastrarAlunoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarAlunoToolStripMenuItem.Click
        Dim frm As New Aluno
        frm.ShowDialog()
    End Sub

    Private Sub CadastrarProfessorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarProfessorToolStripMenuItem.Click
        Dim frm As New Professor
        frm.ShowDialog()
    End Sub

    Private Sub CursoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CursoToolStripMenuItem.Click
        Dim frm As New Curso
        frm.ShowDialog()
    End Sub

    Private Sub DisciplinaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisciplinaToolStripMenuItem.Click
        Dim frm As New Disciplina
        frm.ShowDialog()
    End Sub

    Private Sub MATRICULAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MATRICULAToolStripMenuItem.Click
        Dim frm As New Matricula
        frm.ShowDialog()
    End Sub


    Private Sub RELACAOCURSOSEDOCENTESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RELACAOCURSOSEDOCENTESToolStripMenuItem.Click
        'gerar relatorio
        'Dim rpt As New RelacaoCursosDocentes
        'Dim rel As New FRM_Relatorios 'cria uma vez
        ''vincular
        'rel.CrystalReportViewer1.ReportSource = rpt
        'rel.ShowDialog()
    End Sub



    Private Sub RELACAOALUNOCURSOPORSEMANOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RELACAOALUNOCURSOPORSEMANOToolStripMenuItem.Click
        gbRelatorioCidade.Visible = True
        gbRelatorioTotal.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGerarRelatorioAluno.Click
        'If (cbAno.Text <> "" And cbSemestre.Text <> "") Then
        '    'gerar relatorio
        '    Dim rpt As New spRelacaoAlunoCursoPorAnoSemestre
        '    Dim rel As New FRM_Relatorios 'cria uma vez
        '    'passar parametros
        '    rpt.ParameterFields(0).CurrentValues.AddValue(cbAno.Text)
        '    rpt.ParameterFields(1).CurrentValues.AddValue(cbSemestre.Text)
        '    'vincular
        '    rel.CrystalReportViewer1.ReportSource = rpt
        '    rel.ShowDialog()
        'End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'If (cbAnoTotal.Text <> "" And cbSemestreTotal.Text <> "") Then
        '    'gerar relatorio
        '    Dim rpt As New spRelacaoAlunoTotalPorAnoSemestre
        '    Dim rel As New FRM_Relatorios 'cria uma vez
        '    'passar parametros
        '    rpt.ParameterFields(0).CurrentValues.AddValue(cbAnoTotal.Text)
        '    rpt.ParameterFields(1).CurrentValues.AddValue(cbSemestreTotal.Text)
        '    'vincular
        '    rel.CrystalReportViewer1.ReportSource = rpt
        '    rel.ShowDialog()
        'End If
    End Sub

    Private Sub RELACAOTOTALALUNOPORSEMANOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RELACAOTOTALALUNOPORSEMANOToolStripMenuItem.Click
        gbRelatorioCidade.Visible = False
        gbRelatorioTotal.Visible = True

    End Sub
End Class
