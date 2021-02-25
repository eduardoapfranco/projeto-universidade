Imports System.Data
Imports System.Data.SqlClient

Public Class DisciplinaDAL
    'inserir disciplina
    Public Sub inserir(descricao As String, codigocurso As Integer, termo As Integer, turma As String, cargahoraria As Integer, numerocreditos As Integer, codigoprofessor As Integer)
        Try
            Dim cmd As New SqlCommand
            'string de insercao
            cmd.CommandText = "insert into Disciplina (disc_descricao, cur_codigo, disc_termo, disc_turma, disc_cargahoraria, disc_numerocreditos,  prof_codigo)" & _
                                        "VALUES     (@descricao, @codigocurso, @termo, @turma, @cargahoraria, @numerocreditos, @codigoprofessor)"
            'parametros
            cmd.Parameters.Add(New SqlParameter("@descricao", SqlDbType.VarChar, 150)).Value = descricao
            cmd.Parameters.Add(New SqlParameter("@codigocurso", SqlDbType.Int)).Value = codigocurso
            cmd.Parameters.Add(New SqlParameter("@termo", SqlDbType.Int)).Value = termo
            cmd.Parameters.Add(New SqlParameter("@turma", SqlDbType.VarChar, 20)).Value = turma
            cmd.Parameters.Add(New SqlParameter("@cargahoraria", SqlDbType.Int)).Value = cargahoraria
            cmd.Parameters.Add(New SqlParameter("@numerocreditos", SqlDbType.Int)).Value = numerocreditos
            cmd.Parameters.Add(New SqlParameter("@codigoprofessor", SqlDbType.Int)).Value = codigoprofessor
            'faz a insercao do Professor
            Dim con As New Conexao
            con.executaCmd(cmd)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    'alterar
    Public Sub alterar(codigo As Integer, descricao As String, codigocurso As Integer, termo As Integer, turma As String, cargahoraria As Integer, numerocreditos As Integer, codigoprofessor As Integer)
        Try
            Using cmd As New SqlCommand
                cmd.CommandText = "update Disciplina set " & _
                    "disc_descricao = @descricao," & _
                    "cur_codigo = @codigocurso," & _
                    "disc_termo = @termo," & _
                    "disc_turma = @turma," & _
                    "disc_cargahoraria = @cargahoraria," & _
                    "disc_numerocreditos = @numerocreditos," & _
                    "prof_codigo = @codigoprofessor" & _
                    " where disc_codigo = @codigo"
                'parametros
                cmd.Parameters.Add(New SqlParameter("@codigo", SqlDbType.Int)).Value = codigo
                cmd.Parameters.Add(New SqlParameter("@descricao", SqlDbType.VarChar, 150)).Value = descricao
                cmd.Parameters.Add(New SqlParameter("@codigocurso", SqlDbType.Int)).Value = codigocurso
                cmd.Parameters.Add(New SqlParameter("@termo", SqlDbType.Int)).Value = termo
                cmd.Parameters.Add(New SqlParameter("@turma", SqlDbType.VarChar, 20)).Value = turma
                cmd.Parameters.Add(New SqlParameter("@cargahoraria", SqlDbType.Int)).Value = cargahoraria
                cmd.Parameters.Add(New SqlParameter("@numerocreditos", SqlDbType.Int)).Value = numerocreditos
                cmd.Parameters.Add(New SqlParameter("@codigoprofessor", SqlDbType.Int)).Value = codigoprofessor
                Dim con As New Conexao
                con.executaCmd(cmd)
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'selecionar disciplina (codigo) retorna datatable
    Public Function selecionar(codigo As Integer) As DataTable
        Dim tab As DataTable
        Try
            Using cmd As New SqlCommand
                cmd.CommandText = "select * from Disciplina d " & _
                    "INNER JOIN Curso c ON d.cur_codigo = c.cur_codigo " & _
                    "INNER JOIN Professor pf ON d.prof_codigo = pf.prof_codigo " & _
                    "INNER JOIN Pessoa p ON p.pess_codigo = pf.pess_codigo " & _
                    "WHERE d.disc_codigo = @codigo"
                cmd.Parameters.Add(New SqlParameter("@codigo", SqlDbType.Int)).Value = codigo
                Dim con As New Conexao
                tab = con.retdadosTab(cmd)
            End Using

        Catch ex As Exception
            Throw ex
        End Try
        Return tab
    End Function

    'selecionar disciplina creditos disciplinas (codigo) retorna datatable
    Public Function selecionarNumeroCreditos(codigo As Integer) As DataTable
        Dim tab As DataTable
        Try
            Using cmd As New SqlCommand
                cmd.CommandText = "select d.disc_numerocreditos from Disciplina d WHERE d.disc_codigo = @codigo"
                cmd.Parameters.Add(New SqlParameter("@codigo", SqlDbType.Int)).Value = codigo
                Dim con As New Conexao
                tab = con.retdadosTab(cmd)
            End Using

        Catch ex As Exception
            Throw ex
        End Try
        Return tab
    End Function

    'selecionar disciplina por (descricao) retorna datatable
    Public Function selecionar(descricao As String) As DataTable
        Dim tab As DataTable
        Try
            Using cmd As New SqlCommand
                'cmd.CommandText = "select * from Disciplina d " & _
                '  "INNER JOIN Curso c ON d.cur_codigo = c.cur_codigo " & _
                '  "INNER JOIN Professor pf ON d.prof_codigo = pf.prof_codigo " & _
                '  "INNER JOIN Pessoa p ON p.pess_codigo = pf.pess_codigo " & _
                '  "WHERE d.disc_codigo = @codigo"
                cmd.CommandText = "select d.disc_codigo, d.disc_descricao, d.disc_termo, d.disc_turma from Disciplina d where d.disc_descricao like @descricao"
                cmd.Parameters.Add(New SqlParameter("@descricao", SqlDbType.VarChar)).Value = descricao + "%"
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
                cmd.CommandText = "delete from Disciplina " & _
                    " where disc_codigo = @codigo"
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
