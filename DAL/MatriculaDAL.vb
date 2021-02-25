Imports System.Data
Imports System.Data.SqlClient

Public Class MatriculaDAL
    'inserir disciplina
    Public Function inserir(codigoaluno As Integer, codigocurso As Integer, termo As Integer, turma As String, ano As Integer, semestre As Integer, valor As Decimal)
        Dim codigo As Integer
        Try
            Dim cmd As New SqlCommand
            'string de insercao
            cmd.CommandText = "insert into Matricula (alu_codigo, cur_codigo, mat_termo, mat_turma, mat_ano, mat_semestre,  mat_valor, mat_datamatricula)" & _
                                        "VALUES     (@codigoaluno, @codigocurso, @termo, @turma, @ano, @semestre, @valor, @datamatricula)"
            'parametros
            cmd.Parameters.Add(New SqlParameter("@codigoaluno", SqlDbType.Int)).Value = codigoaluno
            cmd.Parameters.Add(New SqlParameter("@codigocurso", SqlDbType.Int)).Value = codigocurso
            cmd.Parameters.Add(New SqlParameter("@termo", SqlDbType.Int)).Value = termo
            cmd.Parameters.Add(New SqlParameter("@turma", SqlDbType.VarChar, 20)).Value = turma
            cmd.Parameters.Add(New SqlParameter("@ano", SqlDbType.Int)).Value = ano
            cmd.Parameters.Add(New SqlParameter("@semestre", SqlDbType.Int)).Value = semestre
            cmd.Parameters.Add(New SqlParameter("@valor", SqlDbType.Decimal)).Value = valor
            cmd.Parameters.Add(New SqlParameter("@datamatricula", SqlDbType.DateTime)).Value = DateTime.Now()

            'faz a insercao do Professor
            Dim con As New Conexao
            codigo = con.executaCmdAI(cmd, "Matricula")
        Catch ex As Exception
            Throw ex
        End Try

        Return codigo

    End Function


    'alterar
    Public Sub alterar(codigo As Integer, codigoaluno As Integer, codigocurso As Integer, termo As Integer, turma As String, ano As Integer, semestre As Integer, valor As Decimal)
        Try
            Using cmd As New SqlCommand
                cmd.CommandText = "update Matricula set " & _
                    "alu_codigo = @codigoaluno," & _
                    "cur_codigo = @codigocurso," & _
                    "mat_termo = @termo," & _
                    "mat_turma = @turma," & _
                    "mat_ano = @ano," & _
                    "mat_semestre = @semestre," & _
                    "mat_valor = @valor" & _
                    " where mat_codigo = @codigo"
                'parametros
                cmd.Parameters.Add(New SqlParameter("@codigo", SqlDbType.Int)).Value = codigo
                cmd.Parameters.Add(New SqlParameter("@codigoaluno", SqlDbType.Int)).Value = codigoaluno
                cmd.Parameters.Add(New SqlParameter("@codigocurso", SqlDbType.Int)).Value = codigocurso
                cmd.Parameters.Add(New SqlParameter("@termo", SqlDbType.Int)).Value = termo
                cmd.Parameters.Add(New SqlParameter("@turma", SqlDbType.VarChar, 20)).Value = turma
                cmd.Parameters.Add(New SqlParameter("@ano", SqlDbType.Int)).Value = ano
                cmd.Parameters.Add(New SqlParameter("@semestre", SqlDbType.Int)).Value = semestre
                cmd.Parameters.Add(New SqlParameter("@valor", SqlDbType.Decimal)).Value = valor

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
                cmd.CommandText = "select m.mat_codigo, c.cur_nome, p.pess_nome, a.alu_ra, *  from Matricula m " & _
                    "INNER JOIN Curso c ON m.cur_codigo = c.cur_codigo " & _
                    "INNER JOIN Aluno a ON m.alu_codigo = a.alu_codigo " & _
                    "INNER JOIN Pessoa p ON p.pess_codigo = a.pess_codigo " & _
                    "WHERE m.mat_codigo = @codigo"
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

                cmd.CommandText = "select m.mat_codigo, c.cur_nome, p.pess_nome, a.alu_ra, * from Matricula m " & _
                   "INNER JOIN Curso c ON m.cur_codigo = c.cur_codigo " & _
                   "INNER JOIN Aluno a ON m.alu_codigo = a.alu_codigo " & _
                   "INNER JOIN Pessoa p ON p.pess_codigo = a.pess_codigo " & _
                   "WHERE p.pess_nome like @descricao"
                cmd.Parameters.Add(New SqlParameter("@descricao", SqlDbType.VarChar)).Value = descricao + "%"
                Dim con As New Conexao
                tab = con.retdadosTab(cmd)
            End Using

        Catch ex As Exception
            Throw ex
        End Try
        Return tab
    End Function

    'validar matricula por aluno, curso, ano e semestre
    Public Function validarMatricula(codigoaluno As Integer, codigocurso As Integer, ano As Integer, semestre As Integer) As Boolean
        Dim total As Integer
        Try
            Using cmd As New SqlCommand

                cmd.CommandText = "select * from Matricula WHERE alu_codigo = @codigoaluno AND cur_codigo = @codigocurso AND mat_semestre = @semestre AND mat_ano = @ano"
                cmd.Parameters.Add(New SqlParameter("@codigoaluno", SqlDbType.Int)).Value = codigoaluno
                cmd.Parameters.Add(New SqlParameter("@codigocurso", SqlDbType.Int)).Value = codigocurso
                cmd.Parameters.Add(New SqlParameter("@semestre", SqlDbType.Int)).Value = semestre
                cmd.Parameters.Add(New SqlParameter("@ano", SqlDbType.Int)).Value = ano
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

    'excluir
    Public Sub excluir(codigo As Integer)
        Try
            Using cmd As New SqlCommand
                cmd.CommandText = "delete from Matricula " & _
                    " where  mat_codigo = @codigo"
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
