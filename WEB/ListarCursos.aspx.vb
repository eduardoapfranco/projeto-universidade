Imports DAL

Public Class CadastraListaCurso
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim curso As CursoDAL = New CursoDAL()

        If Not Me.IsPostBack Then
            'Populating a DataTable from database.
            Dim dt As DataTable = curso.selecionar()

            'Building an HTML string.
            Dim html As New StringBuilder()

            'Table start.
            html.Append("<table class='table'>")

            'Building the Header row.
            html.Append("<thead>")

            html.Append("<tr>")

            html.Append("<th>Codigo</th>")
            html.Append("<th>Nome do Curso</th>")
            html.Append("<th>Sigla do Curso</th>")
            html.Append("<th>Crédito do Curso</th>")


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
            PlaceHolder2.Controls.Add(New Literal() With {
               .Text = html.ToString()
             })
        End If

    End Sub

End Class