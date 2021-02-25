Imports System.Data
Imports System.Data.SqlClient

Public Class AlunoDAL
    'inserir aluno em aluno
    Public Sub inserir(codigopessoa As Integer)

        Try
            Dim cmd As New SqlCommand
            'pega a data atual
            Dim ano As DateTime = DateTime.Now
            'um codigo padrao para aluno
            Dim padrao As Integer = 5
            'formata a data e pega só o ano
            Dim anoFormat = Format(ano, "yyyy")
            'gerar um numero para nao repetir o ra
            Dim rdm As Random = New Random()
            Dim numRmd As Integer
            numRmd = rdm.Next(1, 5) & rdm.Next(1, 6)

    

            'monta o ra
            Dim ra As Integer = anoFormat & padrao & codigopessoa & numRmd
            'string de insercao
            cmd.CommandText = "insert into Aluno (pess_codigo, alu_ra) VALUES (@pesscodigo, @ra)"
            'parametros
            cmd.Parameters.Add(New SqlParameter("@pesscodigo", SqlDbType.Int)).Value = codigopessoa
            cmd.Parameters.Add(New SqlParameter("@ra", SqlDbType.Int)).Value = ra
            'faz a insercao do RA
            Dim con As New Conexao
            con.executaCmd(cmd)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    

    'selecionar aluno (codigo) retorna datatable
    Public Function selecionar(codigo As Integer) As DataTable
        Dim tab As DataTable
        Try
            Using cmd As New SqlCommand
                cmd.CommandText = "select * from aluno a INNER JOIN Pessoa p ON p.pess_codigo = a.pess_codigo WHERE alu_codigo = @codigo"
                cmd.Parameters.Add(New SqlParameter("@codigo", SqlDbType.Int)).Value = codigo
                Dim con As New Conexao
                tab = con.retdadosTab(cmd)
            End Using

        Catch ex As Exception
            Throw ex
        End Try
        Return tab
    End Function

    'selecionar aluno por (RA) retorna datatable
    Public Function selecionar(ra As String) As DataTable
        Dim tab As DataTable
        Try
            Using cmd As New SqlCommand
               
                cmd.CommandText = "select a.alu_codigo, a.alu_ra, p.pess_nome from Aluno a INNER JOIN Pessoa p ON p.pess_codigo = a.pess_codigo where a.alu_ra like @ra or p.pess_nome like @ra"
                cmd.Parameters.Add(New SqlParameter("@ra", SqlDbType.VarChar)).Value = ra + "%"
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
                cmd.CommandText = "delete from aluno " & _
                    " where alu_codigo = @codigo"
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
