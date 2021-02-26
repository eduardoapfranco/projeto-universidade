Imports BLL
Public Class Curso
    Public Sub habilitaBotoes(status As Boolean)
        btnInserir.Enabled = status
        btnExcluir.Enabled = status
        btnLocalizar.Enabled = status
        btnAlterar.Enabled = Not status
        btnCancelar.Enabled = Not status
        btnSalvar.Enabled = Not status
    End Sub
    Public Sub habilitaCampos(status As Boolean)

        txtNome.Enabled = status
        txtSigla.Enabled = status
        txtValorCredito.Enabled = status
    End Sub
    Public Sub Limpar()
        txtNome.Text = ""
        txtCodigo.Text = ""
        txtSigla.Text = ""
        txtValorCredito.Text = ""
    End Sub
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles gbForm.Enter

    End Sub

    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        habilitaBotoes(False)
        btnAlterar.Enabled = False
        txtNome.Enabled = True
        txtSigla.Enabled = True
        txtValorCredito.Enabled = True
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try

            Dim objBll As New CursoBLL

           
            If (txtNome.Text = "" Or txtSigla.Text = "" Or txtValorCredito.Text = "") Then
                MessageBox.Show("Preencha todos os campos")
            Else
                objBll.Nome = txtNome.Text
                objBll.ValorCredito = txtValorCredito.Text
                objBll.Sigla = txtSigla.Text
                If (txtCodigo.Text = "") Then
                    objBll.inserir()

                Else

                    objBll.Codigo = txtCodigo.Text
                    objBll.alterar()

                End If
                MessageBox.Show("Dados salvos com sucesso!")
            End If

            objBll = Nothing


            Limpar()
            habilitaBotoes(True)
            habilitaCampos(False)
            txtCodigo.Enabled = False
            'gbForm.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



        btnExcluir.Enabled = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Limpar()
        habilitaBotoes(True)
        btnCancelar.Enabled = True
        btnExcluir.Enabled = False
        txtCodigo.Enabled = False
        txtNome.Enabled = False
        txtSigla.Enabled = False
        txtValorCredito.Enabled = False

        'cancelar e salvar: true
    End Sub

    Private Sub Curso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        habilitaCampos(False)
        txtCodigo.Enabled = False
        btnCancelar_Click(sender, e)


    End Sub

    Private Sub btnLocalizar_Click(sender As Object, e As EventArgs) Handles btnLocalizar.Click
        habilitaCampos(False)

        btnSalvar.Enabled = False
        btnExcluir.Enabled = True
        btnAlterar.Enabled = True
        btnCancelar.Enabled = True

        Dim frmc As New CursoConsulta
        frmc.ShowDialog()
        If (frmc.codigo <> 0) Then
            Try
                Dim objbll As New CursoBLL
                objbll.selecionar(frmc.codigo)
                'atribuir para formulario 
                txtCodigo.Text = objbll.Codigo
                txtNome.Text = objbll.Nome
                txtSigla.Text = objbll.Sigla
                txtValorCredito.Text = objbll.ValorCredito
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
                Dim objbll As New CursoBLL
                objbll.Codigo = txtCodigo.Text
                objbll.excluir()
                objbll = Nothing
                Limpar()
                MessageBox.Show("Curso excluido com sucesso!")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("Favor, localizar um registro.")
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbClassificacao_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    'Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
    '    btnLocalizarPessoa.Enabled = False
    '    btnInserir.Enabled = False
    '    btnLocalizar.Enabled = True
    '    btnSalvar.Enabled = True
    '    cbClassificacao.Enabled = True
    '    btnLocalizar.Enabled = True
    'End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        btnSalvar.Enabled = True
        habilitaCampos(True)
    End Sub
End Class