Imports System.Data.SqlClient
Imports System.Data

'MatriculasDisciplinas
Public Class MatriculaDisciplinasDAL

    Public Sub inserir(mat_codigo As Integer,
                       disc_codigo As Integer)

        Try
            Dim sql As String
            Using cmd As New SqlCommand
                sql = "insert into Matricula_Disciplinas" & _
                    " (mat_codigo, disc_codigo) values " & _
                    " (@mat_codigo, @disc_codigo)"
                cmd.CommandText = sql
                cmd.Parameters.Add(New SqlParameter(
        "@mat_codigo", SqlDbType.Int)).Value = mat_codigo
                cmd.Parameters.Add(New SqlParameter("@disc_codigo",
                    SqlDbType.Int)).Value = disc_codigo
                Dim con As New Conexao
                con.executaCmd(cmd)
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub excluirTodos(mat_codigo As Integer)
        Try
            Dim sql As String
            Using cmd As New SqlCommand
                sql = "delete from Matricula_Disciplinas " & _
                    " where mat_codigo= @mat_codigo"
                cmd.CommandText = sql
                cmd.Parameters.Add(New SqlParameter("@mat_codigo",
                    SqlDbType.Int)).Value = mat_codigo
                Dim con As New Conexao
                con.executaCmd(cmd)
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function selecionarTodos(mat_codigo As Integer) As DataTable
        Dim tab As DataTable = Nothing
        Try
            Dim sql As String
            Using cmd As New SqlCommand
                sql = "select * from Matricula_Disciplinas" & _
                    " where mat_codigo=@mat_codigo"
                cmd.CommandText = sql
                cmd.Parameters.Add(New SqlParameter("@mat_codigo",
                    SqlDbType.Int)).Value = mat_codigo
                Dim con As New Conexao
                tab = con.retdadosTab(cmd)
            End Using
        Catch ex As Exception
            Throw ex
        End Try
        Return tab
    End Function


End Class
