Imports BLL
Public Class Disciplina
    Public Sub habilitaBotoes(status As Boolean)
        btnInserir.Enabled = status
        btnSalvar.Enabled = status
        btnCancelar.Enabled = status
        btnExcluir.Enabled = Not status
        btnLocalizar.Enabled = status
        btnAlterar.Enabled = Not status
        btnLocalizarProfessor.Enabled = Not status
        btnLocalizarCurso.Enabled = Not status


    End Sub

    Public Sub habilitaCampos(status As Boolean)
        txtDescricao.Enabled = status
        txtTermo.Enabled = status
        txtTurma.Enabled = status
        txtCargaHoraria.Enabled = status
        txtNumeroCreditos.Enabled = status

        txtCodigoProfessor.Enabled = False
        txtProfessor.Enabled = False
        txtCodigoCurso.Enabled = False
        txtCurso.Enabled = False
        txtCodigo.Enabled = False
    End Sub
    Public Sub Limpar()
        txtCodigo.Text = ""
        txtDescricao.Text = ""
        txtTermo.Text = ""
        txtTurma.Text = ""
        txtCargaHoraria.Text = ""
        txtNumeroCreditos.Text = ""
        txtCodigoProfessor.Text = ""
        txtProfessor.Text = ""
        txtCodigoCurso.Text = ""
        txtCurso.Text = ""
    End Sub
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles gbForm.Enter

    End Sub

    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        habilitaBotoes(True)
        habilitaCampos(True)
        btnLocalizar.Enabled = False
        btnLocalizarProfessor.Enabled = True
        btnLocalizarCurso.Enabled = True
        'btnAlterar.Enabled = False
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try

            Dim objBll As New DisciplinaBLL

          

            If (txtDescricao.Text = "" Or txtTermo.Text = "" Or txtTurma.Text = "" Or txtCargaHoraria.Text = "" Or txtCodigoProfessor.Text = "" Or txtCodigoCurso.Text = "") Then
                MessageBox.Show("Preencha todos os campos e selecione o professor e selecione o curso!")
            Else
                objBll.Descricao = txtDescricao.Text
                objBll.Termo = txtTermo.Text
                objBll.Turma = txtTurma.Text
                objBll.CargaHoraria = txtCargaHoraria.Text
                objBll.NumeroCreditos = txtNumeroCreditos.Text
                objBll.CodigoProfessor = txtCodigoProfessor.Text
                objBll.CodigoCurso = txtCodigoCurso.Text

                If (txtCodigo.Text = "") Then
                    objBll.inserir()

                Else
                    objBll.Codigo = txtCodigo.Text
                    objBll.alterar()
                End If
                MessageBox.Show("Dados salvos com sucesso!")
                Limpar()
                habilitaBotoes(True)
                habilitaCampos(False)
            End If
            objBll = Nothing


            

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Limpar()
        habilitaBotoes(True)
        habilitaCampos(False)
        btnSalvar.Enabled = False
        btnCancelar.Enabled = True
      

        'cancelar e salvar: true
    End Sub

    Private Sub Professor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        habilitaBotoes(True)
        habilitaCampos(False)
        btnCancelar_Click(sender, e)
        
    End Sub

    Private Sub btnLocalizar_Click(sender As Object, e As EventArgs) Handles btnLocalizar.Click

        btnAlterar.Enabled = True
        btnExcluir.Enabled = True
        Dim frmc As New DisciplinaConsulta
        frmc.ShowDialog()
        If (frmc.codigo <> 0) Then
            Try
                Dim objbll As New DisciplinaBLL
                objbll.selecionar(frmc.codigo)
                'atribuir para formulario 
                txtCodigo.Text = objbll.Codigo
                txtDescricao.Text = objbll.Descricao
                txtTermo.Text = objbll.Termo
                txtTurma.Text = objbll.Turma
                txtCargaHoraria.Text = objbll.CargaHoraria
                txtNumeroCreditos.Text = objbll.NumeroCreditos

                Dim objbllProf As New ProfessorBLL
                objbllProf.selecionar(objbll.CodigoProfessor)
                txtCodigoProfessor.Text = objbllProf.CodigoProfessor
                txtProfessor.Text = objbllProf.Nome

                Dim objbllCur As New CursoBLL

                objbllCur.selecionar(objbll.CodigoCurso)
                txtCodigoCurso.Text = objbllCur.Codigo
                txtCurso.Text = objbllCur.Nome

                objbll = Nothing
                objbllProf = Nothing
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
                Dim objbll As New DisciplinaBLL
                objbll.Codigo = txtCodigo.Text
                objbll.excluir()
                objbll = Nothing
                Limpar()
                MessageBox.Show("Excluido com sucesso!")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("Favor, localizar um registro.")
        End If
    End Sub



    Private Sub btnLocalizarProfessor_Click(sender As Object, e As EventArgs) Handles btnLocalizarProfessor.Click
        Dim frmc As New ProfessorConsulta
        frmc.ShowDialog()
        If (frmc.codigo <> 0) Then
            Try
                Dim objbll As New ProfessorBLL

                objbll.selecionar(frmc.codigo)
                'atribuir para formulario 
                txtCodigoProfessor.Text = objbll.CodigoProfessor
                txtProfessor.Text = objbll.Nome
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
        btnLocalizarProfessor.Enabled = True
        btnLocalizarCurso.Enabled = True
    End Sub
End Class