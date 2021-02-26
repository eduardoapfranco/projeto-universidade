Imports BLL
Public Class ProfessorConsulta

    Public codigo As Integer

    Private Sub txtNome_KeyUp(sender As Object, e As KeyEventArgs) Handles txtNome.KeyUp
        Try
            Dim objbll As New ProfessorBLL
            Dim tab As DataTable = objbll.selecionar(
                txtNome.Text)
            dgDados.DataSource = tab 'vincular datatable na grid
            'se teve retorno SQl
            If (tab.Rows.Count > 0) Then
                'personalizar as colunas
                dgDados.Columns("prof_codigo").HeaderText = "COD"
                dgDados.Columns("prof_matricula").HeaderText = "MATRICULA"
                dgDados.Columns("pess_nome").HeaderText = "NOME"
                'não exibir coluna
                'pode ser uma a uma
                'dgDados.Columns("fun_datanascimento").Visible = False
                'ou com for
                For index = 5 To dgDados.Columns.Count - 1
                    dgDados.Columns(index).Visible = False
                Next

            End If
            objbll = Nothing
        Catch ex As Exception
            MessageBox.Show("Erro: " & ex.Message)
        End Try
    End Sub



    Private Sub dgdados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgdados.CellDoubleClick
        If (e.RowIndex <> -1) Then
            If (dgDados.Rows(e.RowIndex).Cells(0).Value.ToString() <> "") Then
                codigo = dgDados.Rows(e.RowIndex).Cells(0).Value
                Me.Close()
            End If
        End If

    End Sub

    Private Sub PessoaConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgDados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDados.CellContentClick

    End Sub
End Class