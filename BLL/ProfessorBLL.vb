Imports DAL
Public Class ProfessorBLL
    Inherits PessoaBLL

#Region "Propriedades"
    Private _codigoProfessor As Integer
    Public Property CodigoProfessor() As Integer
        Get
            Return _codigoProfessor
        End Get
        Set(ByVal value As Integer)
            _codigoProfessor = value
        End Set
    End Property

    Private _matricula As String
    Public Property Matricula() As String
        Get
            Return _matricula
        End Get
        Set(ByVal value As String)
            _matricula = value
        End Set
    End Property

    Private _classificaoProfessor As Integer
    Public Property ClassificaoProfessor() As Integer
        Get
            Return _classificaoProfessor
        End Get
        Set(ByVal value As Integer)
            _classificaoProfessor = value
        End Set
    End Property

#End Region

#Region "Construtores"
    Public Sub New()
        Me.CodigoProfessor = 0
        Me.Codigo = 0
        Me.Matricula = 0
        Me.ClassificaoProfessor = 0
    End Sub

    Public Sub New(codigoprofessor As Integer, codigopessoa As Integer, matricula As Integer, classificacaoprofessor As Integer)
        Me.CodigoProfessor = codigoprofessor
        Me.Codigo = codigopessoa
        Me.Matricula = matricula
        Me.ClassificaoProfessor = classificacaoprofessor
    End Sub

#End Region

#Region "Métodos"

    'inserir professor
    Public Sub inserir()
        Try
            'If (valida()) Then
            'validaçoes de negocios
            Dim dal As New ProfessorDAL
            dal.inserir(Codigo, ClassificaoProfessor)
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

            Dim dal As New ProfessorDAL
            dal.alterar(Codigo, ClassificaoProfessor)
            dal = Nothing

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'selecionar professor (codigo)
    'carregar nas propriedades os valores do BD do codigo passado por parametro
    Public Sub selecionar(
           codigo As Integer)
        Dim tab As DataTable = Nothing
        Try
            Dim dal As New ProfessorDAL
            tab = dal.selecionar(codigo)
            dal = Nothing
            limpar()
            'se tem dados
            If (Not tab Is Nothing) Then
                'tab.Rows.Count: qtde linhas
                If (tab.Rows.Count > 0) Then

                    Me.CodigoProfessor = tab.Rows(0)("prof_codigo")
                    Me.Matricula = tab.Rows(0)("prof_matricula")
                    Me.ClassificaoProfessor = tab.Rows(0)("classprof_codigo")
                    Me.Nome = tab.Rows(0)("pess_nome")
                    Me.Codigo = tab.Rows(0)("pess_codigo")


                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    'selecionar professor (matricula)
    Public Function selecionar(
            matricula As String) As DataTable
        Dim tab As DataTable = Nothing
        Try
            Dim dal As New ProfessorDAL
            tab = dal.selecionar(matricula)
            dal = Nothing
        Catch ex As Exception
            Throw ex
        End Try
        Return tab
    End Function


    Public Sub limpar()
        Me.CodigoProfessor = 0
        Me.Codigo = 0
        Me.Matricula = 0
        Me.Nome = ""

    End Sub




    'excluir
    Public Sub excluir()
        Try
            Dim dal As New ProfessorDAL
            dal.excluir(CodigoProfessor)
            dal = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
End Class
