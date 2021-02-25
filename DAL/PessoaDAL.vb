Imports System.Data
Imports System.Data.SqlClient

Public Class PessoaDAL
    'inserir na tabale pessoa e retorna o código e ja inseri em aluno
    Public Function inserir(nome As String, rg As String, cpf As String,
                            endereco As String, bairro As String, numero As String,
                            complemento As String, cidade As String, uf As String,
                            telefone As String, celular As String, datanascimento As Date,
                            sexo As Char, email As String, cep As String) As Integer
        Dim codigo As Integer
        Try
            Using cmd As New SqlCommand
                'string de inserção
                cmd.CommandText = "insert into Pessoa " & _
                    "(pess_nome, pess_rg, pess_cpf, pess_endereco, pess_bairro," & _
                    " pess_numero, pess_complemento, pess_cidade, pess_uf," & _
                    "pess_telefone, pess_celular, pess_datanascimento, pess_sexo, pess_email," & _
                    "pess_datacadastro, pess_cep)" & _
                    " values" & _
                    " (@nome, @rg, @cpf, @endereco, @bairro, @numero, @complemento," & _
                    "@cidade, @uf, @telefone, @celular, @datanascimento, @sexo, @email, @datacadastro, @cep)"
                'parametros
                cmd.Parameters.Add(New SqlParameter("@nome", SqlDbType.VarChar, 250)).Value = nome
                cmd.Parameters.Add(New SqlParameter("@rg", SqlDbType.VarChar, 13)).Value = rg
                cmd.Parameters.Add(New SqlParameter("@cpf", SqlDbType.VarChar, 14)).Value = cpf
                cmd.Parameters.Add(New SqlParameter("@endereco", SqlDbType.VarChar, 250)).Value = endereco
                cmd.Parameters.Add(New SqlParameter("@bairro", SqlDbType.VarChar, 150)).Value = bairro
                cmd.Parameters.Add(New SqlParameter("@numero", SqlDbType.VarChar, 20)).Value = numero
                cmd.Parameters.Add(New SqlParameter("@complemento", SqlDbType.VarChar, 150)).Value = complemento
                cmd.Parameters.Add(New SqlParameter("@cidade", SqlDbType.VarChar, 150)).Value = cidade
                cmd.Parameters.Add(New SqlParameter("@uf", SqlDbType.VarChar, 2)).Value = uf
                cmd.Parameters.Add(New SqlParameter("@telefone", SqlDbType.VarChar, 14)).Value = telefone
                cmd.Parameters.Add(New SqlParameter("@celular", SqlDbType.VarChar, 15)).Value = celular
                cmd.Parameters.Add(New SqlParameter("@datanascimento", SqlDbType.Date)).Value = datanascimento
                cmd.Parameters.Add(New SqlParameter("@sexo", SqlDbType.Char, 1)).Value = sexo
                cmd.Parameters.Add(New SqlParameter("@email", SqlDbType.VarChar, 250)).Value = email
                cmd.Parameters.Add(New SqlParameter("@datacadastro", SqlDbType.DateTime)).Value = DateTime.Now()
                cmd.Parameters.Add(New SqlParameter("@cep", SqlDbType.VarChar, 9)).Value = cep

                Dim con As New Conexao
                'executa o metodo de insercao da conexao e retorna o codigo, passei como parametro o cmd e o nome da tabela
                codigo = con.executaCmdAI(cmd, "Pessoa")
            End Using

        Catch ex As Exception
            Throw ex
        End Try

        'Try
        '    Dim cmd As New SqlCommand
        '    'pega a data atual
        '    Dim ano As DateTime = DateTime.Now
        '    'um codigo padrao para aluno
        '    Dim padrao As Integer = 154
        '    'formata a data e pega só o ano
        '    Dim anoFormat = Format(ano, "yyyy")
        '    'monta o ra
        '    Dim ra As String = anoFormat & padrao & codigo
        '    'string de insercao
        '    cmd.CommandText = "insert into Aluno (pess_codigo, alu_ra) VALUES (@pesscodigo, @ra)"
        '    'parametros
        '    cmd.Parameters.Add(New SqlParameter("@pesscodigo", SqlDbType.Int)).Value = codigo
        '    cmd.Parameters.Add(New SqlParameter("@ra", SqlDbType.Int)).Value = ra
        '    'faz a insercao do RA
        '    Dim con As New Conexao
        '    con.executaCmd(cmd)
        'Catch ex As Exception
        '    Throw ex
        'End Try
        Return codigo
    End Function

    'alterar
    Public Sub alterar(codigo As Integer, nome As String, rg As String, cpf As String,
                            endereco As String, bairro As String, numero As String,
                            complemento As String, cidade As String, uf As String,
                            telefone As String, celular As String, datanascimento As Date,
                            sexo As Char, email As String, cep As String)
        Try
            Using cmd As New SqlCommand
                cmd.CommandText = "update Pessoa set" & _
                    " pess_nome = @nome, pess_rg = @rg, pess_cpf = @cpf, pess_endereco = @endereco, pess_bairro = @bairro, " & _
                    " pess_numero = @numero, pess_complemento = @complemento, pess_cidade = @cidade, pess_uf = @uf, pess_telefone = @telefone, " & _
                    " pess_celular = @celular, pess_datanascimento = @datanascimento, pess_sexo = @sexo, pess_email = @email, pess_cep = @cep " & _
                      " where pess_codigo = @codigo"

                'parametros
                cmd.Parameters.Add(New SqlParameter("@codigo", SqlDbType.Int)).Value = codigo
                cmd.Parameters.Add(New SqlParameter("@nome", SqlDbType.VarChar, 250)).Value = nome
                cmd.Parameters.Add(New SqlParameter("@rg", SqlDbType.VarChar, 13)).Value = rg
                cmd.Parameters.Add(New SqlParameter("@cpf", SqlDbType.VarChar, 14)).Value = cpf
                cmd.Parameters.Add(New SqlParameter("@endereco", SqlDbType.VarChar, 250)).Value = endereco
                cmd.Parameters.Add(New SqlParameter("@bairro", SqlDbType.VarChar, 150)).Value = bairro
                cmd.Parameters.Add(New SqlParameter("@numero", SqlDbType.VarChar, 20)).Value = numero
                cmd.Parameters.Add(New SqlParameter("@complemento", SqlDbType.VarChar, 150)).Value = complemento
                cmd.Parameters.Add(New SqlParameter("@cidade", SqlDbType.VarChar, 150)).Value = cidade
                cmd.Parameters.Add(New SqlParameter("@uf", SqlDbType.VarChar, 2)).Value = uf
                cmd.Parameters.Add(New SqlParameter("@telefone", SqlDbType.VarChar, 14)).Value = telefone
                cmd.Parameters.Add(New SqlParameter("@celular", SqlDbType.VarChar, 15)).Value = celular
                cmd.Parameters.Add(New SqlParameter("@datanascimento", SqlDbType.Date)).Value = datanascimento
                cmd.Parameters.Add(New SqlParameter("@sexo", SqlDbType.Char, 1)).Value = sexo
                cmd.Parameters.Add(New SqlParameter("@email", SqlDbType.VarChar, 250)).Value = email
                cmd.Parameters.Add(New SqlParameter("@cep", SqlDbType.VarChar, 9)).Value = cep
                Dim con As New Conexao
                con.executaCmd(cmd)
            End Using



        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'selecionar (codigo) retorna datatable
    Public Function selecionar(codigo As Integer) As DataTable
        Dim tab As DataTable
        Try
            Using cmd As New SqlCommand
                cmd.CommandText = "select * from pessoa " & _
                    " where pess_codigo = @codigo"
                cmd.Parameters.Add(New SqlParameter("@codigo", SqlDbType.Int)).Value = codigo
                Dim con As New Conexao
                tab = con.retdadosTab(cmd)
            End Using



        Catch ex As Exception
            Throw ex
        End Try
        Return tab
    End Function

    'selecionar (nome) retorna datatable
    Public Function selecionar(nome As String) As DataTable
        Dim tab As DataTable
        Try
            Using cmd As New SqlCommand
                cmd.CommandText = "select * from pessoa " & _
                    " where pess_nome like @nome"
                cmd.Parameters.Add(New SqlParameter("@nome", SqlDbType.VarChar)).Value = nome + "%"
                Dim con As New Conexao
                tab = con.retdadosTab(cmd)
            End Using

        Catch ex As Exception
            Throw ex
        End Try
        Return tab
    End Function

    'excluir
    Public Sub excluir(codigo As Integer)
        Try
            Using cmd As New SqlCommand
                cmd.CommandText = "delete from pessoa " & _
                    " where pess_codigo = @codigo"
                cmd.Parameters.Add(
                  New SqlParameter("@codigo",
                  SqlDbType.Int)).Value =
                  codigo
                Dim con As New Conexao
                con.executaCmd(cmd)
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    'validar pessoa porcpf
    Public Function validarCpf(cpf As String) As Boolean
        Dim total As Integer
        Try
            Using cmd As New SqlCommand

                cmd.CommandText = "select * from Pessoa WHERE pess_cpf = @cpf "
                cmd.Parameters.Add(New SqlParameter("@cpf", SqlDbType.VarChar, 14)).Value = cpf
                Dim con As New Conexao
                total = con.executaCmdScalar(cmd)
            End Using

            If total > 1 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class


