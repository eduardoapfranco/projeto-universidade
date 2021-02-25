Imports DAL
Public Class DisciplinaBLL

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

    Private _descricao As String
    Public Property Descricao() As String
        Get
            Return _descricao
        End Get
        Set(ByVal value As String)
            _descricao = value
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

    Private _cargaHoraria As Integer
    Public Property CargaHoraria() As Integer
        Get
            Return _cargahoraria
        End Get
        Set(ByVal value As Integer)
            _cargahoraria = value
        End Set
    End Property

    Private _numeroCreditos As Integer
    Public Property NumeroCreditos() As Integer
        Get
            Return _numeroCreditos
        End Get
        Set(ByVal value As Integer)
            _numeroCreditos = value
        End Set
    End Property

    Private _codigoProfessor As Integer
    Public Property CodigoProfessor() As Integer
        Get
            Return _codigoProfessor
        End Get
        Set(ByVal value As Integer)
            _codigoProfessor = value
        End Set
    End Property


#End Region

#Region "Construtores"
    Public Sub New()
        Me.Codigo = 0
        Me.Descricao = ""
        Me.CodigoCurso = 0
        Me.Termo = 0
        Me.Turma = ""
        Me.CargaHoraria = 0
        Me.NumeroCreditos = 0
        Me.CodigoProfessor = 0
    End Sub

    Public Sub New(codigo As Integer, descricao As String, codigocurso As Integer, termo As Integer, turma As String, cargahoraria As Integer, numerocreditos As Integer, codigoprofessor As Integer)
        Me.Codigo = codigo
        Me.Descricao = descricao
        Me.CodigoCurso = codigocurso
        Me.Termo = termo
        Me.Turma = turma
        Me.CargaHoraria = cargahoraria
        Me.NumeroCreditos = numerocreditos
        Me.CodigoProfessor = codigoprofessor
    End Sub

    Public Sub New(codigo As Integer)
        selecionar(codigo)
    End Sub
#End Region

#Region "Métodos"

    'inserir Disciplina
    Public Sub inserir()
        Try
            'If (valida()) Then
            'validaçoes de negocios
            Dim dal As New DisciplinaDAL
            dal.inserir(Descricao, CodigoCurso, Termo, Turma, CargaHoraria, NumeroCreditos, CodigoProfessor)
            dal = Nothing
            ' Else
            'Throw New Exception("Você possui pendências que impedem esta operação")
            ' End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'alterar
    Public Sub alterar()
        Try

            Dim dal As New DisciplinaDAL
            dal.alterar(Codigo, Descricao, CodigoCurso, Termo, Turma, CargaHoraria, NumeroCreditos, CodigoProfessor)
            dal = Nothing

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
            Dim dal As New DisciplinaDAL
            tab = dal.selecionar(codigo)
            dal = Nothing
            limpar()
            'se tem dados
            If (Not tab Is Nothing) Then
                'tab.Rows.Count: qtde linhas
                If (tab.Rows.Count > 0) Then

                    Me.Codigo = tab.Rows(0)("disc_codigo")
                    Me.Descricao = tab.Rows(0)("disc_descricao")
                    Me.CodigoCurso = tab.Rows(0)("cur_codigo")
                    Me.Termo = tab.Rows(0)("disc_termo")
                    Me.Turma = tab.Rows(0)("disc_turma")
                    Me.CargaHoraria = tab.Rows(0)("disc_cargahoraria")
                    Me.NumeroCreditos = tab.Rows(0)("disc_numerocreditos")
                    Me.CodigoProfessor = tab.Rows(0)("prof_codigo")


                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    'selecionar disciplina numeros creditos (codigo)
    'carregar nas propriedades os valores do BD do codigo passado por parametro
    Public Sub selecionarNumeroCreditos(
           codigo As Integer)
        Dim tab As DataTable = Nothing
        Try
            Dim dal As New DisciplinaDAL
            tab = dal.selecionarNumeroCreditos(codigo)
            dal = Nothing
            limpar()
            'se tem dados
            If (Not tab Is Nothing) Then
                'tab.Rows.Count: qtde linhas
                If (tab.Rows.Count > 0) Then
                    Me.NumeroCreditos = tab.Rows(0)("disc_numerocreditos")
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    'selecionar disciplina (descricao)
    Public Function selecionar(
            descricao As String) As DataTable
        Dim tab As DataTable = Nothing
        Try
            Dim dal As New DisciplinaDAL
            tab = dal.selecionar(descricao)
            dal = Nothing
        Catch ex As Exception
            Throw ex
        End Try
        Return tab
    End Function


    Public Sub limpar()
        Me.Codigo = 0
        Me.Descricao = ""
        Me.CodigoCurso = 0
        Me.Termo = 0
        Me.Turma = ""
        Me.CargaHoraria = 0
        Me.NumeroCreditos = 0
        Me.CodigoProfessor = 0

    End Sub




    'excluir
    Public Sub excluir()
        Try
            Dim dal As New DisciplinaDAL
            dal.excluir(Codigo)
            dal = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
End Class
