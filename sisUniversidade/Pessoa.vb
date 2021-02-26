Imports BLL
Public Class Pessoa
    Public Sub habilitaBotoes(status As Boolean)
        btnInserir.Enabled = status
        btnAlterar.Enabled = status
        btnExcluir.Enabled = status
        btnLocalizar.Enabled = status
        btnCancelar.Enabled = Not status
        btnSalvar.Enabled = Not status
    End Sub

    Public Sub Limpar()
        txtNome.Text = ""
        txtCodigo.Text = ""
        txtRG.Text = ""
        txtCPF.Text = ""
        txtEndereco.Text = ""
        txtBairro.Text = ""
        txtNumero.Text = ""
        txtComplemento.Text = ""
        txtCidade.Text = ""
        cbEstado.Text = ""
        txtTelefone.Text = ""
        txtCelular.Text = ""
        dtpDataNascimento.Value = Date.Now()
        cbSexo.Text = ""
        txtEmail.Text = ""
        txtCEP.Text = ""

    End Sub
    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            Dim objBll As New PessoaBLL

           



            If (txtNome.Text = "" Or txtRG.Text = "" Or txtRG.Text = "" Or txtCPF.Text = "" Or txtEndereco.Text = "" Or txtBairro.Text = "" Or txtNumero.Text = "" Or
                txtComplemento.Text = "" Or txtCidade.Text = "" Or cbEstado.Text = "" Or txtTelefone.Text = "" Or txtCelular.Text = "" Or dtpDataNascimento.Text = "" Or cbSexo.Text = "" Or
                txtEmail.Text = "" Or txtCEP.Text = "") Then
                MessageBox.Show("Favor informar todos campos")
            Else

                objBll.Nome = txtNome.Text
                objBll.Rg = txtRG.Text
                objBll.Cpf = txtCPF.Text
                objBll.Endereco = txtEndereco.Text
                objBll.Bairro = txtBairro.Text
                objBll.Numero = txtNumero.Text
                objBll.Complemento = txtComplemento.Text
                objBll.Cidade = txtCidade.Text
                objBll.Uf = cbEstado.Text
                objBll.Telefone = txtTelefone.Text
                objBll.Celular = txtCelular.Text
                objBll.DataNascimento = dtpDataNascimento.Value
                objBll.Sexo = cbSexo.Text
                objBll.Email = txtEmail.Text
                objBll.Cep = txtCEP.Text

                If (txtCodigo.Text = "") Then

                    'inserir 
                    objBll.inserir()

                Else
                'alterar
                objBll.Codigo = txtCodigo.Text
                objBll.alterar()
            End If
                objBll = Nothing
                MessageBox.Show("Dados salvos com sucesso!")
                habilitaBotoes(True)
                Limpar()
                gbForm.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Aluno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbForm.Enabled = False
    End Sub

    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        habilitaBotoes(False)
        gbForm.Enabled = True
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        habilitaBotoes(True)
        Limpar()
        gbForm.Enabled = False
        'cancelar e salvar: true
    End Sub

    Private Sub gbForm_Enter(sender As Object, e As EventArgs) Handles gbForm.Enter

    End Sub

    Private Sub btnLocalizar_Click(sender As Object, e As EventArgs) Handles btnLocalizar.Click
        btnInserir.Enabled = False
        Dim frmc As New PessoaConsulta
        frmc.ShowDialog()
        If (frmc.codigo <> 0) Then
            Try
                Dim objbll As New PessoaBLL
                objbll.selecionar(frmc.codigo)
                'atribuir para formulario 
                txtCodigo.Text = objbll.Codigo
                txtNome.Text = objbll.Nome
                txtRG.Text = objbll.Rg
                txtCPF.Text = objbll.Cpf
                txtEndereco.Text = objbll.Endereco
                txtBairro.Text = objbll.Bairro
                txtNumero.Text = objbll.Numero
                txtComplemento.Text = objbll.Complemento
                txtCidade.Text = objbll.Cidade
                cbEstado.Text = objbll.Uf
                txtTelefone.Text = objbll.Telefone
                txtCelular.Text = objbll.Celular
                dtpDataNascimento.Value = objbll.DataNascimento
                If (objbll.Sexo = "F") Then
                    cbSexo.SelectedIndex = 1
                Else
                    cbSexo.SelectedIndex = 0
                End If
                txtEmail.Text = objbll.Email
                txtCEP.Text = objbll.Cep

                objbll = Nothing
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        frmc = Nothing
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        If (txtCodigo.Text <> "") Then
            habilitaBotoes(False)
            gbForm.Enabled = True
        Else
            MessageBox.Show("Favor, localizar um registro.")
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If (txtCodigo.Text <> "") Then
            Try
                Dim objbll As New PessoaBLL
                objbll.Codigo = txtCodigo.Text
                objbll.excluir()
                objbll = Nothing
                Limpar()
                MessageBox.Show("Dados excluidos com sucesso!")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("Favor, localizar um registro.")
        End If
    End Sub


End Class