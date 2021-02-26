Imports BLL
Public Class Matricula
    'datatable que sera vinculado na grid
    Dim tab As DataTable

    Public Sub habilitaBotoes(status As Boolean)
        btnInserir.Enabled = status
        btnSalvar.Enabled = status
        btnCancelar.Enabled = status 
        btnExcluir.Enabled = Not status
        btnLocalizar.Enabled = status
        btnAlterar.Enabled = Not status
        btnLocalizarAluno.Enabled = Not status
        btnLocalizarCurso.Enabled = Not status


    End Sub

    Public Sub habilitaCampos(status As Boolean)
        cbTermo.Enabled = status
        cbTurma.Enabled = status
        cbAno.Enabled = status
        cbSemestre.Enabled = status
        txtValor.Enabled = False

        txtCodigoAluno.Enabled = False
        txtAluno.Enabled = False
        txtCodigoCurso.Enabled = False
        txtCurso.Enabled = False
        txtCodigo.Enabled = False
    End Sub
    Public Sub Limpar()
        txtCodigo.Text = ""
        cbTermo.SelectedItem = Nothing
        cbTurma.SelectedItem = Nothing
        cbAno.SelectedItem = Nothing
        txtValor.Text = ""
        cbSemestre.SelectedItem = Nothing
        cbDisciplinas.SelectedItem = Nothing
        txtCodigoAluno.Text = ""
        txtAluno.Text = ""
        txtCodigoCurso.Text = ""
        txtCurso.Text = ""


    End Sub
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles gbForm.Enter

    End Sub

    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        cbDisciplinas.SelectedIndex = -1
        cbDisciplinas.Enabled = False
        habilitaBotoes(True)
        habilitaCampos(True)
        btnInserirDisc.Enabled = False
        btnExcluirDisc.Enabled = False
        dgDados.Enabled = False
        btnLocalizar.Enabled = False
        btnLocalizarAluno.Enabled = True
        btnLocalizarCurso.Enabled = True

        'btnAlterar.Enabled = False
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try

            Dim objBll As New MatriculaBLL


            If (cbTermo.Text = "" Or cbTurma.Text = "" Or cbAno.Text = "" Or txtCodigoAluno.Text = "" Or txtCodigoCurso.Text = "" Or txtValor.Text = "" Or cbSemestre.Text = "") Then
                MessageBox.Show("Preencha todos os campos e selecione o aluno e selecione o curso!")
            Else
                objBll.Termo = cbTermo.Text
                objBll.Turma = cbTurma.Text
                objBll.Ano = cbAno.Text
                objBll.Semestre = cbSemestre.Text
                objBll.CodigoAluno = txtCodigoAluno.Text
                objBll.CodigoCurso = txtCodigoCurso.Text
                objBll.Valor = txtValor.Text

                'para a lista
                Dim objc As MatriculaDisciplinasBLL
                For Each linha As DataRow In tab.Rows
                    objc = New MatriculaDisciplinasBLL(
                        0, linha("codigo"))
                    objBll.ListaMatDisc.Add(objc)

                Next

                If (txtCodigo.Text = "") Then
                    objBll.inserir()

                Else
                    objBll.Codigo = txtCodigo.Text
                    objBll.alterar()
                End If
                MessageBox.Show("Dados salvos com sucesso!")
                tab.Rows.Clear()
                Limpar()
                habilitaBotoes(True)
                habilitaCampos(False)
                cbDisciplinas.SelectedIndex = Nothing
                cbDisciplinas.Enabled = False

            End If
            objBll = Nothing




        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        cbDisciplinas.Enabled = False
        Limpar()
        habilitaBotoes(True)
        habilitaCampos(False)
        btnSalvar.Enabled = False
        btnCancelar.Enabled = True
        btnInserirDisc.Enabled = False
        btnExcluirDisc.Enabled = False
        dgDados.Enabled = False


        'cancelar e salvar: true
    End Sub

    Private Sub Professor_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        btnCancelar_Click(sender, e)
        habilitaBotoes(True)
        habilitaCampos(False)
        dgDados.Enabled = False
        btnInserirDisc.Enabled = False
        btnExcluirDisc.Enabled = False
        cbDisciplinas.Enabled = False
        btnCancelar_Click(sender, e)

    End Sub

    Private Sub btnLocalizar_Click(sender As Object, e As EventArgs) Handles btnLocalizar.Click
        btnExcluirDisc.Enabled = False
        btnInserirDisc.Enabled = False
        btnInserir.Enabled = False
        dgDados.Enabled = False
        cbDisciplinas.Enabled = False
        btnAlterar.Enabled = True
        btnExcluir.Enabled = True
        Dim frmc As New MatriculaConsulta
        frmc.ShowDialog()
        If (frmc.codigo <> 0) Then
            Try
                Dim objbll As New MatriculaBLL
                objbll.selecionar(frmc.codigo)
                'atribuir para formulario 
                txtCodigo.Text = objbll.Codigo
                cbTermo.Text = objbll.Termo
                cbTurma.Text = objbll.Turma
                cbAno.Text = objbll.Ano
                cbSemestre.Text = objbll.Semestre
                txtValor.Text = objbll.Valor

                Dim objbllAluno As New AlunoBLL
                objbllAluno.selecionar(objbll.CodigoAluno)
                txtCodigoAluno.Text = objbllAluno.CodigoAluno
                txtAluno.Text = objbllAluno.Nome

                Dim objbllCur As New CursoBLL

                objbllCur.selecionar(objbll.CodigoCurso)
                txtCodigoCurso.Text = objbllCur.Codigo
                txtCurso.Text = objbllCur.Nome


                Funcoes.preencheCombo(cbDisciplinas, "Disciplina", "disc_codigo", "disc_descricao", " cur_codigo = " & objbllCur.Codigo & "")
                'criar o datatable
                tab = New DataTable
                'quais sao as colunas
                tab.Columns.Add("codigo")
                tab.Columns.Add("descricao")
                'vincular na grid
                dgDados.DataSource = tab

                'percorrer a lista
                'atribuindo no datatable
                'tab.Rows.Clear()
                Dim linha As DataRow
                For Each obj As MatriculaDisciplinasBLL In
                    objbll.ListaMatDisc
                    linha = tab.NewRow
                    linha("codigo") = obj.Disciplina.Codigo
                    linha("descricao") = obj.Disciplina.Descricao
                    tab.Rows.Add(linha)
                    tab.AcceptChanges()
                Next

                objbll = Nothing
                objbllAluno = Nothing
                objbllCur = Nothing
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        frmc = Nothing
    End Sub



    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        btnLocalizar.Enabled = True
        btnSalvar.Enabled = False
        btnCancelar.Enabled = True
        If (txtCodigo.Text <> "") Then
            Try
                Dim objbll As New MatriculaBLL
                objbll.Codigo = txtCodigo.Text
                objbll.excluir()
                objbll = Nothing
                Limpar()
                tab.Rows.Clear()
                MessageBox.Show("Excluido com sucesso!")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("Favor, localizar um registro.")
        End If
    End Sub



    Private Sub btnLocalizarProfessor_Click(sender As Object, e As EventArgs) Handles btnLocalizarAluno.Click
        Dim frmc As New AlunoConsulta
        frmc.ShowDialog()
        If (frmc.codigo <> 0) Then
            Try
                Dim objbll As New AlunoBLL

                objbll.selecionar(frmc.codigo)
                'atribuir para formulario 
                txtCodigoAluno.Text = objbll.CodigoAluno
                txtAluno.Text = objbll.Nome
                objbll = Nothing
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        frmc = Nothing
    End Sub

    Private Sub btnLocalizarCurso_Click(sender As Object, e As EventArgs) Handles btnLocalizarCurso.Click

        Dim frmc As New CursoConsulta
        frmc.ShowDialog()
        If (frmc.codigo <> 0) Then
            Try
                Dim objbll As New CursoBLL

                objbll.selecionar(frmc.codigo)
                'atribuir para formulario 
                txtCodigoCurso.Text = objbll.Codigo
                txtCurso.Text = objbll.Nome
                cbDisciplinas.Enabled = True
                btnInserirDisc.Enabled = True
                btnExcluirDisc.Enabled = True
                dgDados.Enabled = True

                Funcoes.preencheCombo(cbDisciplinas, "Disciplina", "disc_codigo", "disc_descricao", " cur_codigo = " & objbll.Codigo & "")
                'criar o datatable
                tab = New DataTable
                'quais sao as colunas
                tab.Columns.Add("codigo")
                tab.Columns.Add("descricao")
                'vincular na grid
                dgDados.DataSource = tab

                objbll = Nothing
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        frmc = Nothing
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        habilitaCampos(True)
        habilitaBotoes(True)
        btnExcluirDisc.Enabled = True
        btnInserirDisc.Enabled = True
        dgDados.Enabled = True
        cbDisciplinas.Enabled = True
        btnLocalizarAluno.Enabled = False
        btnLocalizarCurso.Enabled = False
        btnInserir.Enabled = False
    End Sub


    Private Sub dgDados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDados.CellContentClick

    End Sub

    Private Sub btnInserirDisc_Click(sender As Object, e As EventArgs) Handles btnInserirDisc.Click
        'validar se já foi incluida
        'percorrer o datatable
        Dim total As Decimal
        Dim aux As Decimal

        If (txtValor.Text = "") Then
            txtValor.Text = 0
            Dim ValorStr As String = txtValor.Text
            aux = Convert.ToDecimal(ValorStr)
        Else
            Dim ValorStr As String = txtValor.Text
            aux = Convert.ToDecimal(ValorStr)
        End If

        Dim objDisc As New DisciplinaBLL
        Dim objCur As New CursoBLL
        Dim objMat As New MatriculaBLL
        Dim encontrou As Boolean = False
        For Each l As DataRow In tab.Rows
            If (l("codigo") = cbDisciplinas.SelectedValue) Then
                encontrou = True
            End If
        Next
        If (Not encontrou) Then
            'adicionar no datatable uma linha
            Dim linha As DataRow
            linha = tab.NewRow

            objDisc.selecionarNumeroCreditos(cbDisciplinas.SelectedValue)
            objCur.selecionarValorCurso(txtCodigoCurso.Text)

            total = objDisc.NumeroCreditos * objCur.ValorCredito

            txtValor.Text = aux + total


            linha("codigo") = cbDisciplinas.SelectedValue
            linha("descricao") = cbDisciplinas.Text
            tab.Rows.Add(linha)
            tab.AcceptChanges() 'refresh
        Else
            MessageBox.Show("Já incluido")
        End If
        objDisc = Nothing
        objCur = Nothing
        objMat = Nothing
    End Sub

    Private Sub btnExcluirDisc_Click(sender As Object, e As EventArgs) Handles btnExcluirDisc.Click
        Dim total As Decimal
        Dim aux As Decimal
        Dim objDisc As New DisciplinaBLL
        Dim objCur As New CursoBLL
        Dim objMat As New MatriculaBLL

        If (txtValor.Text = "") Then
            txtValor.Text = 0
            Dim ValorStr As String = txtValor.Text
            aux = Convert.ToDecimal(ValorStr)
        Else
            Dim ValorStr As String = txtValor.Text
            aux = Convert.ToDecimal(ValorStr)
        End If



       

        ''excluir uma linha do datatable
        Dim indice As Integer = -1
        'percorrer a grid buscando pela linha selecionada
        For Each linha As DataGridViewRow
            In dgDados.SelectedRows
            indice = linha.Index
        Next

        'excluir do datatable
        If (indice <> -1 And tab.Rows.Count > 0 And
            indice < tab.Rows.Count) Then

            objDisc.selecionarNumeroCreditos(dgDados.CurrentRow.Cells(0).Value)
            objCur.selecionarValorCurso(txtCodigoCurso.Text)
            total = objDisc.NumeroCreditos * objCur.ValorCredito
            txtValor.Text = aux - total
            tab.Rows.RemoveAt(indice)
            tab.AcceptChanges()
        End If

        objDisc = Nothing
        objCur = Nothing
        objMat = Nothing
    End Sub

End Class