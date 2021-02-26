Imports BLL
Public Class Aluno

    Public Sub habilitaBotoes(status As Boolean)
        btnInserir.Enabled = status
        btnExcluir.Enabled = status
        btnLocalizar.Enabled = status
        btnCancelar.Enabled = Not status
        btnSalvar.Enabled = Not status
    End Sub

    Public Sub Limpar()
        txtNome.Text = ""
        txtCodigo.Text = ""
        txtRA.Text = ""
        txtCodigoPessoa.Text = ""

    End Sub
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles gbForm.Enter

    End Sub

    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        btnLocalizarPessoa.Enabled = True
        'btnLocalizar.Enabled = True
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try

            Dim objBll As New AlunoBLL
            objBll.Nome = txtNome.Text
            objBll.Codigo = txtCodigoPessoa.Text


            objBll.inserir()

            objBll = Nothing
            MessageBox.Show("Dados salvos com sucesso!")
            habilitaBotoes(True)
            Limpar()
            gbForm.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        btnLocalizarPessoa.Enabled = False
        txtRA.Enabled = False
        txtCodigo.Enabled = False
        txtNome.Enabled = False
        txtCodigoPessoa.Enabled = False
        btnSalvar.Enabled = False
        btnExcluir.Enabled = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        habilitaBotoes(True)
        Limpar()
        btnCancelar.Enabled = True
        btnLocalizarPessoa.Enabled = False
        btnExcluir.Enabled = False

        'cancelar e salvar: true
    End Sub

    Private Sub Aluno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnLocalizarPessoa.Enabled = False
        txtRA.Enabled = False
        txtCodigo.Enabled = False
        txtNome.Enabled = False
        txtCodigoPessoa.Enabled = False
        btnSalvar.Enabled = False
        btnExcluir.Enabled = False

    End Sub

    Private Sub btnLocalizar_Click(sender As Object, e As EventArgs) Handles btnLocalizar.Click
        habilitaBotoes(False)
        txtRA.Enabled = False
        txtCodigo.Enabled = False
        txtNome.Enabled = False
        txtCodigoPessoa.Enabled = False
        btnSalvar.Enabled = False
        btnExcluir.Enabled = True
        Dim frmc As New AlunoConsulta
        frmc.ShowDialog()
        If (frmc.codigo <> 0) Then
            Try
                Dim objbll As New AlunoBLL
                objbll.selecionar(frmc.codigo)
                'atribuir para formulario 
                txtCodigo.Text = objbll.CodigoAluno
                txtRA.Text = objbll.RA
                txtNome.Text = objbll.Nome
                txtCodigoPessoa.Text = objbll.Codigo


                objbll = Nothing
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
        frmc = Nothing
    End Sub

    Private Sub btnLocalizarPessoa_Click(sender As Object, e As EventArgs) Handles btnLocalizarPessoa.Click
        btnInserir.Enabled = False
        txtRA.Enabled = False
        txtCodigo.Enabled = False
        btnCancelar.Enabled = True
        btnSalvar.Enabled = True
        btnLocalizar.Enabled = False

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
        If (txtCodigo.Text <> "") Then
            Try
                Dim objbll As New AlunoBLL
                objbll.CodigoAluno = txtCodigo.Text
                objbll.excluir()
                objbll = Nothing
                Limpar()
                MessageBox.Show("Aluno excluido com sucesso!")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("Favor, localizar um registro.")
        End If
    End Sub

    Private Sub gbBotoes_Enter(sender As Object, e As EventArgs) Handles gbBotoes.Enter

    End Sub
End Class