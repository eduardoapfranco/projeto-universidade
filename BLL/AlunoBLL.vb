Imports DAL
Public Class AlunoBLL
    Inherits PessoaBLL

#Region "Propriedades"
    Private _codigoAluno As Integer
    Public Property CodigoAluno() As Integer
        Get
            Return _codigoAluno
        End Get
        Set(ByVal value As Integer)
            _codigoAluno = value
        End Set
    End Property

    Private _ra As String
    Public Property RA() As String
        Get
            Return _ra
        End Get
        Set(ByVal value As String)
            _ra = value
        End Set
    End Property

#End Region

#Region "Construtores"
    Public Sub New()
        Me.CodigoAluno = 0
        Me.Codigo = 0
        Me.RA = 0
    End Sub

    Public Sub New(codigoaluno As Integer, codigopessoa As Integer, ra As Integer)
        Me.CodigoAluno = codigoaluno
        Me.Codigo = codigopessoa
        Me.RA = ra
    End Sub

#End Region

#Region "Métodos"

    'inserir
    Public Sub inserir()
        Try
            'If (valida()) Then
            'validaçoes de negocios
            Dim dal As New AlunoDAL
            dal.inserir(Codigo)
            dal = Nothing
            ' Else
            'Throw New Exception("Você possui pendências que impedem esta operação")
            ' End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    'selecionar aluno (codigo)
    'carregar nas propriedades os valores do BD do codigo passado por parametro
    Public Sub selecionar(
           codigo As Integer)
        Dim tab As DataTable = Nothing
        Try
            Dim dal As New AlunoDAL
            tab = dal.selecionar(codigo)
            dal = Nothing
            limpar()
            'se tem dados
            If (Not tab Is Nothing) Then
                'tab.Rows.Count: qtde linhas
                If (tab.Rows.Count > 0) Then

                    Me.CodigoAluno = tab.Rows(0)("alu_codigo")
                    Me.RA = tab.Rows(0)("alu_ra")
                    Me.Nome = tab.Rows(0)("pess_nome")
                    Me.Codigo = tab.Rows(0)("pess_codigo")


                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    'selecionar aluno (ra)
    Public Function selecionar(
            ra As String) As DataTable
        Dim tab As DataTable = Nothing
        Try
            Dim dal As New AlunoDAL
            tab = dal.selecionar(ra)
            dal = Nothing
        Catch ex As Exception
            Throw ex
        End Try
        Return tab
    End Function


    Public Sub limpar()
        Me.CodigoAluno = 0
        Me.Codigo = 0
        Me.RA = 0
        Me.Nome = ""

    End Sub




    'excluir
    Public Sub excluir()
        Try

            Dim dal As New AlunoDAL
            dal.excluir(CodigoAluno)
            dal = Nothing

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
End Class
