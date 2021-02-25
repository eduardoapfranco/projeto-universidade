Imports DAL
Public Class Funcoes
    Function retDadosCB(nomeTabela As String,
                        nomeCampoCodigo As String,
                        nomeCampoDescricao As String,
                        filtro As String) As DataTable
        Dim tab As DataTable
        Try
            Dim dados As New Conexao
            tab = dados.retDadosCB(nomeTabela, nomeCampoCodigo,
                             nomeCampoDescricao, filtro)
            dados = Nothing
        Catch ex As Exception
            Throw ex
        End Try
        Return tab
    End Function
End Class
