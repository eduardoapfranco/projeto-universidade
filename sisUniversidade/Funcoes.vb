Imports BLL
Public Class Funcoes
    Shared Sub preencheCombo(combo As ComboBox,
                        nomeTabela As String,
                       nomeCampoCodigo As String,
                       nomeCampoDescricao As String,
                       filtro As String)
        Try
            Dim bll As New BLL.Funcoes
            Dim tab As DataTable =
                bll.retDadosCB(nomeTabela, nomeCampoCodigo,
                           nomeCampoDescricao, filtro)
            bll = Nothing
            If (Not tab Is Nothing) Then
                'vinculando combobox com datatable
                combo.DataSource = tab
                'indicando qual o nome da coluna na base de dados
                'que referencia o codigo
                combo.ValueMember = nomeCampoCodigo
                'indica o nome da coluna na base de dados
                'que referencia a descrição
                combo.DisplayMember = nomeCampoDescricao
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
