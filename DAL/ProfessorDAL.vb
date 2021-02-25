Imports System.Data
Imports System.Data.SqlClient

Public Class ProfessorDAL
    'inserir professor em professor
    Public Sub inserir(codigopessoa As Integer, classprofcodigo As Integer)

        Try
            Dim cmd As New SqlCommand
            'pega a data atual
            Dim ano As DateTime = DateTime.Now
            'um codigo padrao para professor
            Dim padrao As Integer = 12
            'formata a data e pega só o ano
            Dim anoFormat = Format(ano, "yyyy")
            'gerar um numero para nao repetir o ra
            Dim rdm As Random = New Random()
            Dim numRmd As Integer
            numRmd = rdm.Next(1, 5) & rdm.Next(1, 6)

            'monta a matricula
            Dim matricula As Integer = anoFormat & padrao & codigopessoa & numRmd
            'string de insercao
            cmd.CommandText = "insert into Professor (pess_codigo, classprof_codigo, prof_matricula) VALUES (@pesscodigo, @classprofcodigo, @profmatricula)"
            'parametros
            cmd.Parameters.Add(New SqlParameter("@pesscodigo", SqlDbType.Int)).Value = codigopessoa
            cmd.Parameters.Add(New SqlParameter("@classprofcodigo", SqlDbType.Int)).Value = classprofcodigo
            cmd.Parameters.Add(New SqlParameter("@profmatricula", SqlDbType.Int)).Value = matricula
            'faz a insercao do Professor
            Dim con As New Conexao
            con.executaCmd(cmd)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    'alterar
    Public Sub alterar(codigo As Integer, classificacao As Integer)
        Try
            Using cmd As New SqlCommand
                cmd.CommandText = "update Professor set" & _
                    " classprof_codigo = @classificacao where prof_codigo = @codigo"
                'parametros
                cmd.Parameters.Add(New SqlParameter("@codigo", SqlDbType.Int)).Value = codigo
                cmd.Parameters.Add(New SqlParameter("@classificacao", SqlDbType.Int)).Value = classificacao
                Dim con As New Conexao
                con.executaCmd(cmd)
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'selecionar professor (codigo) retorna datatable
    Public Function selecionar(codigo As Integer) As DataTable
        Dim tab As DataTable
        Try
            Using cmd As New SqlCommand
                cmd.CommandText = "select * from professor pf INNER JOIN Pessoa p ON p.pess_codigo = pf.pess_codigo INNER JOIN Class_Professor cp ON cp.classprof_codigo = pf.classprof_codigo  WHERE pf.prof_codigo = @codigo"
                cmd.Parameters.Add(New SqlParameter("@codigo", SqlDbType.Int)).Value = codigo
                Dim con As New Conexao
                tab = con.retdadosTab(cmd)
            End Using

        Catch ex As Exception
            Throw ex
        End Try
        Return tab
    End Function

    'selecionar professor por (matricula) retorna datatable
    Public Function selecionar(matricula As String) As DataTable
        Dim tab As DataTable
        Try
            Using cmd As New SqlCommand

                cmd.CommandText = "select pf.prof_codigo, pf.prof_matricula, p.pess_nome from Professor pf INNER JOIN Pessoa p ON p.pess_codigo = pf.pess_codigo INNER JOIN Class_Professor cp ON cp.classprof_codigo = pf.classprof_codigo where pf.prof_matricula like @matricula or p.pess_nome like @matricula"
                cmd.Parameters.Add(New SqlParameter("@matricula", SqlDbType.VarChar)).Value = matricula + "%"
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
                cmd.CommandText = "delete from Professor " & _
                    " where prof_codigo = @codigo"
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
