Imports System.Data
Imports System.Data.SqlClient
Public Class Conexao
    'str con - ataque propaganda 
    'Dim con As New SqlConnection("data source=PC3\SQLEXPRESS;integrated security=true;initial catalog = sisUniversidade;")
    'str con - toledo
    'Dim con As New SqlConnection("data source=LAB11-02;integrated security=true;initial catalog = sisUniversidade;")
    Dim con As New SqlConnection("Data Source=localhost;Initial Catalog=sisUniversidade;User ID=sa;Password=DBKey123;")

    Function abreConexao() As Boolean
        Try
            If (con.State = ConnectionState.Closed) Then
                con.Open()
            End If
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function

    Function fechaConexao() As Boolean
        Try
            If (con.State = ConnectionState.Open) Then
                con.Close()
            End If
            Return True
        Catch ex As Exception
            Throw ex
            Return False
        End Try
    End Function
    'update, delete, insert (sem a necessidade de retornar o codigo inserido)
    Function executaCmd(ByVal cmd As SqlCommand) As Integer
        Dim ret As Integer
        Try
            cmd.Connection = con
            abreConexao()
            ret = cmd.ExecuteNonQuery
            fechaConexao()
        Catch ex As Exception
            Throw ex
            ret = -1
        Finally
            cmd = Nothing
        End Try
        Return ret
    End Function
    'select retornar uma linha e uma coluna, por exemplo count(*)
    Function executaCmdScalar(ByVal cmd As SqlCommand) As String
        Dim ret As String
        Try
            cmd.Connection = con
            abreConexao()
            ret = cmd.ExecuteScalar
            fechaConexao()
        Catch ex As Exception
            Throw ex
            ret = ""
        Finally
            cmd = Nothing
        End Try
        Return ret
    End Function
    'insert com necessidade de retornar o codigo inserido
    Function executaCmdAI(ByVal cmd As SqlCommand, ByVal tabela As String) As Integer
        Dim ret As Integer
        Try
            cmd.Connection = con
            abreConexao()
            cmd.CommandText &= ";select @@identity " & tabela & ";"
            ret = Convert.ToInt32(cmd.ExecuteScalar.ToString)
            fechaConexao()
        Catch ex As Exception
            Throw ex
            ret = -1
        Finally
            cmd = Nothing
        End Try
        Return ret

    End Function
    'select 
    Function retdadosTab(ByVal cmd As SqlCommand) As DataTable
        Dim tab As DataTable
        Dim ds As DataSet
        Dim da As SqlDataAdapter
        Try
            cmd.Connection = con
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            ds = New DataSet
            da.Fill(ds, "tab")
            tab = ds.Tables("tab")
        Catch ex As Exception
            Throw ex
        Finally
            da = Nothing
            ds = Nothing
        End Try
        Return tab
    End Function
    'select porém ter um retorno mais pesado (não utilizaremos)
    Function retdados(ByVal cmd As SqlCommand) As DataSet
        Dim ds As DataSet
        Dim da As SqlDataAdapter
        Try
            cmd.Connection = con
            da = New SqlDataAdapter
            da.SelectCommand = cmd
            ds = New DataSet
            da.Fill(ds, "tab")
        Catch ex As Exception
            Throw ex
        Finally
            da = Nothing
        End Try
        Return ds
    End Function

    'retornar dados de uma tabela
    Function retDadosCB(nomeTabela As String,
                        nomeCampoCodigo As String,
                        nomeCampoDescricao As String,
                        filtro As String) As DataTable
        Dim tab As DataTable
        Try
            Dim sql As String
            sql = "select " & nomeCampoCodigo & ", " & _
                "" & nomeCampoDescricao & _
                " from " & nomeTabela
            If (filtro <> "") Then
                sql &= " where " & filtro
            End If
            Dim cmd As New SqlCommand
            cmd.CommandText = sql
            tab = retdadosTab(cmd)
        Catch ex As Exception
            Throw ex
        End Try
        Return tab
    End Function


End Class
