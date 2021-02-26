Imports BLL
Public Class Professor
    Public Sub habilitaBotoes(status As Boolean)
        btnInserir.Enabled = status
        btnExcluir.Enabled = status
        btnLocalizar.Enabled = status
        btnLocalizarPessoa.Enabled = Not status
        btnCancelar.Enabled = Not status
        btnSalvar.Enabled = Not status
    End Sub
    Public Sub Limpar()
        txtNome.Text = ""
        txtCodigo.Text = ""
        txtMatricula.Text = ""
        txtCodigoPessoa.Text = ""
    End Sub
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles gbForm.Enter

    End Sub

    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        habilitaBotoes(False)
        'btnLocalizar.Enabled = True
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try

            Dim objBll As New ProfessorBLL
            objBll.Nome = txtNome.Text
            objBll.Codigo = txtCodigoPessoa.Text

            objBll.ClassificaoProfessor = cbClassificacao.SelectedValue
            If (txtCodigo.Text = "") Then
                If (txtNome.Text = "" Or txtCodigoPessoa.Text = "") Then
                    MessageBox.Show("Selecione a pessoa para cadastrar o professor!")
                Else
                    objBll.inserir()
                End If
            Else
                objBll.CodigoProfessor = txtCodigo.Text
                objBll.alterar()

            End If

                objBll = Nothing
                MessageBox.Show("Dados salvos com sucesso!")

                Limpar()
                habilitaBotoes(True)
                'gbForm.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        btnLocalizarPessoa.Enabled = False
        btnLocalizar.Enabled = True
        txtMatricula.Enabled = False
        txtCodigo.Enabled = False
        txtNome.Enabled = False
        cbClassificacao.Enabled = True
        txtCodigoPessoa.Enabled = False

        btnExcluir.Enabled = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Limpar()
        habilitaBotoes(True)
        btnCancelar.Enabled = True
        btnLocalizarPessoa.Enabled = False
        btnExcluir.Enabled = False
        cbClassificacao.Enabled = False

        'cancelar e salvar: true
    End Sub

    Private Sub Professor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnLocalizarPessoa.Enabled = False
        txtMatricula.Enabled = False
        txtCodigo.Enabled = False
        txtNome.Enabled = False
        txtCodigoPessoa.Enabled = False
        btnSalvar.Enabled = False
        btnExcluir.Enabled = False
        cbClassificacao.Enabled = False

        btnCancelar_Click(sender, e)
        Funcoes.preencheCombo(cbClassificacao, "Class_Professor",
                              "classprof_codigo",
                              "classprof_nome", "")

    End Sub

    Private Sub btnLocalizar_Click(sender As Object, e As EventArgs) Handles btnLocalizar.Click
        btnInserir.Enabled = False
        txtMatricula.Enabled = False
        txtCodigo.Enabled = False
        txtNome.Enabled = False
        txtCodigoPessoa.Enabled = False
        btnSalvar.Enabled = True
        btnExcluir.Enabled = True
        cbClassificacao.Enabled = True
        btnCancelar.Enabled = True

        Dim frmc As New ProfessorConsulta
        frmc.ShowDialog()
        If (frmc.codigo <> 0) Then
            Try
                Dim objbll As New ProfessorBLL
                objbll.selecionar(frmc.codigo)
                'atribuir para formulario 
                txtCodigo.Text = objbll.CodigoProfessor
                txtMatricula.Text = objbll.Matricula
                txtNome.Text = objbll.Nome
                txtCodigoPessoa.Text = objbll.Codigo
                cbClassificacao.SelectedValue = objbll.ClassificaoProfessor


                objbll = Nothing
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        frmc = Nothing
    End Sub

    Private Sub btnLocalizarPessoa_Click(sender As Object, e As EventArgs) Handles btnLocalizarPessoa.Click
        btnInserir.Enabled = False
        txtMatricula.Enabled = False
        txtCodigo.Enabled = False
        btnCancelar.Enabled = True
        btnSalvar.Enabled = True
        btnLocalizar.Enabled = False
        cbClassificacao.Enabled = True


        Dim frmc As New PessoaConsulta
        frmc.ShowDialog()
        If (frmc.codigo <> 0) Then
            Try
                Dim objbll As New PessoaBLL

                objbll.selecionar(frmc.codigo)
                'atribuir para formulario 

                txtNome.Text = objbll.Nome
                txtCodigoPessoa.Text = objbll.Codigo


                objbll = Nothing
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
                Dim objbll As New ProfessorBLL
                objbll.CodigoProfessor = txtCodigo.Text
                objbll.excluir()
                objbll = Nothing
                Limpar()
                MessageBox.Show("Professor excluido com sucesso!")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("Favor, localizar um registro.")
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub cbClassificacao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbClassificacao.SelectedIndexChanged

    End Sub

    'Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
    '    btnLocalizarPessoa.Enabled = False
    '    btnInserir.Enabled = False
    '    btnLocalizar.Enabled = True
    '    btnSalvar.Enabled = True
    '    cbClassificacao.Enabled = True
    '    btnLocalizar.Enabled = True
    'End Sub
End Class