Imports DAL

Public Class CadastraAluno
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim aluno As AlunoDAL = New AlunoDAL()

        If Not Me.IsPostBack Then
            'Populating a DataTable from database.
            Dim dt As DataTable = aluno.selecionar()

            'Building an HTML string.
            Dim html As New StringBuilder()

            'Table start.
            html.Append("<table class='table table-striped'>")

            'Building the Header row.
            html.Append("<thead>")
            html.Append("<tr>")

            html.Append("<th>Codigo</th>")
            html.Append("<th>Registro Academico</th>")
            html.Append("<th>Nome</th>")


            html.Append("</tr>")
            html.Append("</thead>")
            html.Append("<tbody>")

            'Building the Data rows.
            For Each row As DataRow In dt.Rows
                html.Append("<tr>")
                For Each column As DataColumn In dt.Columns
                    html.Append("<td>")
                    html.Append(row(column.ColumnName))
                    html.Append("</td>")
                Next
                html.Append("</tr>")
            Next
            html.Append("</tbody>")
            'Table end.
            html.Append("</table>")

            'Append the HTML string to Placeholder.
            PlaceHolder1.Controls.Add(New Literal() With {
               .Text = html.ToString()
             })
        End If

    End Sub

End Class