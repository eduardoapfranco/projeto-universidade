Imports System.Data
Imports System.Data.SqlClient

Public Class CursoDAL

    'inserir
    Public Sub inserir(nome As String, sigla As String, valorcredito As Decimal)

        Try
            Dim cmd As New SqlCommand
            'string de insercao
            cmd.CommandText = "insert into Curso (cur_nome, cur_sigla, cur_valorcredito) VALUES (@nome, @sigla, @valorcredito)"
            'parametros
            cmd.Parameters.Add(New SqlParameter("@nome", SqlDbType.VarChar, 150)).Value = nome
            cmd.Parameters.Add(New SqlParameter("@sigla", SqlDbType.VarChar, 10)).Value = sigla
            cmd.Parameters.Add(New SqlParameter("@valorcredito", SqlDbType.Decimal)).Value = valorcredito
            'faz a insercao do Professor
            Dim con As New Conexao
            con.executaCmd(cmd)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    'alterar
    Public Sub alterar(codigo As Integer, nome As String, sigla As String, valorcredito As Decimal)
        Try
            Using cmd As New SqlCommand
                cmd.CommandText = "update Curso set" & _
                    " cur_nome = @nome, cur_sigla = @sigla, cur_valorcredito = @valorcredito  where cur_codigo = @codigo"
                'parametros
                cmd.Parameters.Add(New SqlParameter("@codigo", SqlDbType.Int)).Value = codigo
                cmd.Parameters.Add(New SqlParameter("@nome", SqlDbType.VarChar, 150)).Value = nome
                cmd.Parameters.Add(New SqlParameter("@sigla", SqlDbType.VarChar, 10)).Value = sigla
                cmd.Parameters.Add(New SqlParameter("@valorcredito", SqlDbType.Decimal)).Value = valorcredito
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
                cmd.CommandText = "select * from Curso WHERE cur_codigo = @codigo"
                cmd.Parameters.Add(New SqlParameter("@codigo", SqlDbType.Int)).Value = codigo
                Dim con As New Conexao
                tab = con.retdadosTab(cmd)
            End Using

        Catch ex As Exception
            Throw ex
        End Try
        Return tab
    End Function
    Public Function selecionar() As DataTable
        Dim tab As DataTable
        Try
            Using cmd As New SqlCommand
                cmd.CommandText = "select * from Curso"
                
                Dim con As New Conexao
                tab = con.retdadosTab(cmd)
            End Using

        Catch ex As Exception
            Throw ex
        End Try
        Return tab
    End Function

    'selecionar valor curso (codigo) retorna datatable
    Public Function selecionarValorCurso(codigo As Integer) As DataTable
        Dim tab As DataTable
        Try
            Using cmd As New SqlCommand
                cmd.CommandText = "select cur_valorcredito from Curso WHERE cur_codigo = @codigo"
                cmd.Parameters.Add(New SqlParameter("@codigo", SqlDbType.Int)).Value = codigo
                Dim con As New Conexao
                tab = con.retdadosTab(cmd)
            End Using

        Catch ex As Exception
            Throw ex
        End Try
        Return tab
    End Function


    Public Function selecionar(nome As String) As DataTable
        Dim tab As DataTable
        Try
            Using cmd As New SqlCommand

                cmd.CommandText = "select cur_codigo, cur_nome, cur_sigla from Curso where cur_nome like @nome or cur_sigla like @nome"
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
                cmd.CommandText = "delete from Curso " & _
                    " where cur_codigo = @codigo"
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

End Class
