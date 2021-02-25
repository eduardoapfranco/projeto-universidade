Imports DAL
Public Class MatriculaBLL

#Region "Propriedades"
    Private _codigo As Integer
    Public Property Codigo() As Integer
        Get
            Return _codigo
        End Get
        Set(ByVal value As Integer)
            _codigo = value
        End Set
    End Property

    Private _codigoAluno As Integer
    Public Property CodigoAluno() As Integer
        Get
            Return _codigoAluno
        End Get
        Set(ByVal value As Integer)
            _codigoAluno = value
        End Set
    End Property

    Private _codigoCurso As Integer
    Public Property CodigoCurso() As Integer
        Get
            Return _codigoCurso
        End Get
        Set(ByVal value As Integer)
            _codigoCurso = value
        End Set
    End Property

    Private _termo As Integer
    Public Property Termo() As Integer
        Get
            Return _termo
        End Get
        Set(ByVal value As Integer)
            _termo = value
        End Set
    End Property

    Private _turma As String
    Public Property Turma() As String
        Get
            Return _turma
        End Get
        Set(ByVal value As String)
            _turma = value
        End Set
    End Property

    Private _ano As Integer
    Public Property Ano() As Integer
        Get
            Return _ano
        End Get
        Set(ByVal value As Integer)
            _ano = value
        End Set
    End Property

    Private _semestre As Integer
    Public Property Semestre() As Integer
        Get
            Return _semestre
        End Get
        Set(ByVal value As Integer)
            _semestre = value
        End Set
    End Property

    Private _valor As Decimal
    Public Property Valor() As Decimal
        Get
            Return _valor
        End Get
        Set(ByVal value As Decimal)
            _valor = value
        End Set
    End Property

    Private _dataMatricula As DateTime
    Public Property DataMatricula() As DateTime
        Get
            Return _dataMatricula
        End Get
        Set(ByVal value As DateTime)
            _dataMatricula = value
        End Set
    End Property
    
    'matriculasdisciplinasbll
    Private _listaMatDisc As List(Of MatriculaDisciplinasBLL)
    Public Property ListaMatDisc() As List(Of MatriculaDisciplinasBLL)
        Get
            Return _listaMatDisc
        End Get
        Set(ByVal value As List(Of MatriculaDisciplinasBLL))
            _listaMatDisc = value
        End Set
    End Property

#End Region

#Region "Construtores"
    Public Sub New()
        Me.Codigo = 0
        Me.CodigoAluno = 0
        Me.CodigoCurso = 0
        Me.Termo = 0
        Me.Turma = ""
        Me.Ano = 0
        Me.Semestre = 0
        Me.Valor = 0
        Me.DataMatricula = Date.Now()
        Me.ListaMatDisc = New List(Of MatriculaDisciplinasBLL)
    End Sub

    Public Sub New(codigo As Integer, codigoaluno As String, codigocurso As Integer, termo As Integer, turma As String, ano As Integer, semestre As Integer, valor As Decimal, datamatricula As DateTime)
        Me.Codigo = codigo
        Me.CodigoAluno = codigoaluno
        Me.CodigoCurso = codigocurso
        Me.Termo = termo
        Me.Turma = turma
        Me.Ano = ano
        Me.Semestre = semestre
        Me.Valor = valor
        Me.DataMatricula = datamatricula
        Me.ListaMatDisc = New List(Of MatriculaDisciplinasBLL)
    End Sub

#End Region

#Region "Métodos"

    'inserir Matricula
    Public Sub inserir()
        Try
            Dim dal As New MatriculaDAL
            If (dal.validarMatricula(CodigoAluno, CodigoCurso, Ano, Semestre)) Then
                'validaçoes de negocios
                Codigo = dal.inserir(CodigoAluno, CodigoCurso, Termo, Turma, Ano, Semestre, Valor)
                dal = Nothing
                inserirDisciplinas(Codigo)
            Else
                Throw New Exception("Você já está matriculado nesse curso, nesse ano e nesse semestre!")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'alterar
    Public Sub alterar()
        Try

            Dim dal As New MatriculaDAL
            dal.alterar(Codigo, CodigoAluno, CodigoCurso, Termo, Turma, Ano, Semestre, Valor)
            dal = Nothing
            excluirDisciplinas(Codigo)
            inserirDisciplinas(Codigo)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'selecionar disciplina (codigo)
    'carregar nas propriedades os valores do BD do codigo passado por parametro
    Public Sub selecionar(
           codigo As Integer)
        Dim tab As DataTable = Nothing
        Try
            Dim dal As New MatriculaDAL
            tab = dal.selecionar(codigo)
            dal = Nothing
            limpar()
            'se tem dados
            If (Not tab Is Nothing) Then
                'tab.Rows.Count: qtde linhas
                If (tab.Rows.Count > 0) Then

                    Me.Codigo = tab.Rows(0)("mat_codigo")
                    Me.CodigoAluno = tab.Rows(0)("alu_codigo")
                    Me.CodigoCurso = tab.Rows(0)("cur_codigo")
                    Me.Termo = tab.Rows(0)("mat_termo")
                    Me.Turma = tab.Rows(0)("mat_turma")
                    Me.Ano = tab.Rows(0)("mat_ano")
                    Me.Semestre = tab.Rows(0)("mat_semestre")
                    Me.Valor = tab.Rows(0)("mat_valor")
                    Me.DataMatricula = tab.Rows(0)("mat_datamatricula")


                End If
            End If
            carregaListaDisciplina(codigo)
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    'selecionar disciplina (descricao)
    Public Function selecionar(
            descricao As String) As DataTable
        Dim tab As DataTable = Nothing
        Try
            Dim dal As New MatriculaDAL
            tab = dal.selecionar(descricao)
            dal = Nothing
        Catch ex As Exception
            Throw ex
        End Try
        Return tab
    End Function


    Public Sub limpar()
        Me.Codigo = 0
        Me.CodigoAluno = 0
        Me.CodigoCurso = 0
        Me.Termo = 0
        Me.Turma = ""
        Me.Ano = 0
        Me.Semestre = 0
        Me.Valor = 0
        Me.DataMatricula = Date.Now()

    End Sub


    'excluir
    Public Sub excluir()
        Try
            excluirDisciplinas(Codigo)
            Dim dal As New MatriculaDAL
            dal.excluir(Codigo)
            dal = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "Disciplinas"
    'mat_codigo preciso carregar a lista 
    'com as disciplinas
    Public Sub carregaListaDisciplina(mat_codigo As Integer)
        Try
            Dim tab As DataTable
            Dim objc As New MatriculaDisciplinasBLL
            tab = objc.selecionarTodos(mat_codigo)
            'percorrer o datatable
            ListaMatDisc = New List(Of MatriculaDisciplinasBLL)
            Dim objaux As MatriculaDisciplinasBLL
            For Each linha As DataRow In tab.Rows
                'criar obj
                objaux = New MatriculaDisciplinasBLL(
                    linha("mat_codigo"), linha("disc_codigo"))
                'adicionar na lista
                ListaMatDisc.Add(objaux)
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub excluirDisciplinas(codmat As Integer)
        Try
            Dim objc As New MatriculaDisciplinasBLL
            objc.excluirTodos(codmat)
            objc = Nothing
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub inserirDisciplinas(codmat As Integer)
        Try
            'percorrer a lista
            For Each obj As MatriculaDisciplinasBLL
                In ListaMatDisc
                'inserir
                obj.MatCodigo = codmat
                obj.inserir()
            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region
End Class
