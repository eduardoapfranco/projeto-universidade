Imports DAL
Public Class CursoBLL

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

    Private _nome As String
    Public Property Nome() As String
        Get
            Return _nome
        End Get
        Set(ByVal value As String)
            _nome = value
        End Set
    End Property

    Private _sigla As String
    Public Property Sigla() As String
        Get
            Return _sigla
        End Get
        Set(ByVal value As String)
            _sigla = value
        End Set
    End Property

    Private _valorCredito As Double
    Public Property ValorCredito() As Double
        Get
            Return _valorCredito
        End Get
        Set(ByVal value As Double)
            _valorCredito = value
        End Set
    End Property

#End Region

#Region "Construtores"
    Public Sub New()
        Me.Codigo = 0
        Me.Nome = ""
        Me.Sigla = ""
        Me.ValorCredito = 0
    End Sub

    Public Sub New(codigo As Integer, nome As String, sigla As String, valorcredito As Double)
        Me.Codigo = codigo
        Me.Nome = nome
        Me.Sigla = sigla
        Me.ValorCredito = valorcredito
    End Sub

#End Region

#Region "Métodos"

    'inserir professor
    Public Sub inserir()
        Try
            'If (valida()) Then
            'validaçoes de negocios
            Dim dal As New CursoDAL
            dal.inserir(Nome, Sigla, ValorCredito)
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

            Dim dal As New CursoDAL
            dal.alterar(Codigo, Nome, Sigla, ValorCredito)
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
            Dim dal As New CursoDAL
            tab = dal.selecionar(codigo)
            dal = Nothing
            limpar()
            'se tem dados
            If (Not tab Is Nothing) Then
                'tab.Rows.Count: qtde linhas
                If (tab.Rows.Count > 0) Then

                    Me.Codigo = tab.Rows(0)("cur_codigo")
                    Me.Nome = tab.Rows(0)("cur_nome")
                    Me.Sigla = tab.Rows(0)("cur_sigla")
                    Me.ValorCredito = tab.Rows(0)("cur_valorcredito")

                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    'selecionar valor curso  (codigo)
    'carregar nas propriedades os valores do BD do codigo passado por parametro
    Public Sub selecionarValorCurso(
           codigo As Integer)
        Dim tab As DataTable = Nothing
        Try
            Dim dal As New CursoDAL
            tab = dal.selecionarValorCurso(codigo)
            dal = Nothing
            limpar()
            'se tem dados
            If (Not tab Is Nothing) Then
                'tab.Rows.Count: qtde linhas
                If (tab.Rows.Count > 0) Then
                    Me.ValorCredito = tab.Rows(0)("cur_valorcredito")
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    'selecionar professor (matricula)
    Public Function selecionar(
            nome As String) As DataTable
        Dim tab As DataTable = Nothing
        Try
            Dim dal As New CursoDAL
            tab = dal.selecionar(nome)
            dal = Nothing
        Catch ex As Exception
            Throw ex
        End Try
        Return tab
    End Function


    Public Sub limpar()
        Me.Codigo = 0
        Me.Nome = ""
        Me.Sigla = ""
        Me.ValorCredito = 0

    End Sub




    'excluir
    Public Sub excluir()
        Try
            Dim dal As New CursoDAL
            dal.excluir(Codigo)
            dal = Nothing
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
End Class
