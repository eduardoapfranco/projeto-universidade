Imports DAL

Public Class MatriculaDisciplinasBLL
#Region "Propriedades"

    Private _disciplina As DisciplinaBLL
    Public Property Disciplina() As DisciplinaBLL
        Get
            Return _disciplina
        End Get
        Set(ByVal value As DisciplinaBLL)
            _disciplina = value
        End Set
    End Property

    Private _mat_codigo As Integer
    Public Property MatCodigo() As Integer
        Get
            Return _mat_codigo
        End Get
        Set(ByVal value As Integer)
            _mat_codigo = value
        End Set
    End Property



#End Region

#Region "Construtor"
    Public Sub New()
        Me.MatCodigo = 0
        Me.Disciplina = Nothing
    End Sub

    Public Sub New(mat_codido As Integer,
                   disc_codigo As Integer)
        Me.MatCodigo = mat_codido
        Me.Disciplina = New DisciplinaBLL(disc_codigo)
    End Sub
#End Region

#Region "Métodos"
    Public Sub inserir()
        Try
            Dim dal As New MatriculaDisciplinasDAL
            dal.inserir(MatCodigo, Disciplina.Codigo)
            dal = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub excluirTodos(mat_codigo As Integer)
        Try
            Dim dal As New MatriculaDisciplinasDAL
            dal.excluirTodos(mat_codigo)
            dal = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function selecionarTodos(mat_codigo As Integer) As DataTable
        Dim tab As DataTable = Nothing
        Try
            Dim dal As New MatriculaDisciplinasDAL
            tab = dal.selecionarTodos(mat_codigo)
            dal = Nothing
        Catch ex As Exception
            Throw ex
        End Try
        Return tab
    End Function
#End Region
End Class
