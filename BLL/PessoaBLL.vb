Imports DAL
Public Class PessoaBLL

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

    Private _rg As String
    Public Property Rg() As String
        Get
            Return _rg
        End Get
        Set(ByVal value As String)
            _rg = value
        End Set
    End Property

    Private _cpf As String
    Public Property Cpf() As String
        Get
            Return _cpf
        End Get
        Set(ByVal value As String)
            _cpf = value
        End Set
    End Property

    Private _endereco As String
    Public Property Endereco() As String
        Get
            Return _endereco
        End Get
        Set(ByVal value As String)
            _endereco = value
        End Set
    End Property

    Private _bairro As String
    Public Property Bairro() As String
        Get
            Return _bairro
        End Get
        Set(ByVal value As String)
            _bairro = value
        End Set
    End Property

    Private _numero As String
    Public Property Numero() As String
        Get
            Return _numero
        End Get
        Set(ByVal value As String)
            _numero = value
        End Set
    End Property

    Private _complemento As String
    Public Property Complemento() As String
        Get
            Return _complemento
        End Get
        Set(ByVal value As String)
            _complemento = value
        End Set
    End Property

    Private _cep As String
    Public Property Cep() As String
        Get
            Return _cep
        End Get
        Set(ByVal value As String)
            _cep = value
        End Set
    End Property


    Private _cidade As String
    Public Property Cidade() As String
        Get
            Return _cidade
        End Get
        Set(ByVal value As String)
            _cidade = value
        End Set
    End Property

    Private _uf As String
    Public Property Uf() As String
        Get
            Return _uf
        End Get
        Set(ByVal value As String)
            _uf = value
        End Set
    End Property

    Private _telefone As String
    Public Property Telefone() As String
        Get
            Return _telefone
        End Get
        Set(ByVal value As String)
            _telefone = value
        End Set
    End Property

    Private _celular As String
    Public Property Celular() As String
        Get
            Return _celular
        End Get
        Set(ByVal value As String)
            _celular = value
        End Set
    End Property

    Private _dataNascimento As Date
    Public Property DataNascimento() As Date
        Get
            Return _dataNascimento
        End Get
        Set(ByVal value As Date)
            _dataNascimento = value
        End Set
    End Property

    Private _sexo As Char
    Public Property Sexo() As Char
        Get
            Return _sexo
        End Get
        Set(ByVal value As Char)
            _sexo = value
        End Set
    End Property

    Private _email As String
    Public Property Email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

    Private _datacadastro As DateTime
    Public Property DataCadastro() As DateTime
        Get
            Return _datacadastro
        End Get
        Set(ByVal value As DateTime)
            _datacadastro = value
        End Set
    End Property

#End Region

#Region "Construtores"
    Public Sub New()
        Me.Codigo = 0
        Me.Nome = ""
        Me.Rg = ""
        Me.Cpf = ""
        Me.Endereco = ""
        Me.Bairro = ""
        Me.Numero = ""
        Me.Complemento = ""
        Me.Cep = ""
        Me.Cidade = ""
        Me.Uf = ""
        Me.Telefone = ""
        Me.Celular = ""
        Me.DataNascimento = Date.Now
        Me.Sexo = ""
        Me.Email = ""
        Me.DataCadastro = DateTime.Now()
    End Sub

    Public Sub New(codigo As Integer, nome As String, rg As String,
                    cpf As String, endereco As String, bairro As String,
                    numero As String, complemento As String, cep As String,
                    cidade As String, uf As String, telefone As String,
                    celular As String, datanascimento As Date, sexo As Char,
                    email As String, datacadastro As DateTime)
        Me.Codigo = codigo
        Me.Nome = nome
        Me.Rg = rg
        Me.Cpf = cpf
        Me.Endereco = endereco
        Me.Bairro = bairro
        Me.Numero = numero
        Me.Complemento = complemento
        Me.Cep = cep
        Me.Cidade = cidade
        Me.Uf = uf
        Me.Telefone = telefone
        Me.Celular = celular
        Me.DataNascimento = datanascimento
        Me.Sexo = sexo
        Me.Email = email
        Me.DataCadastro = datacadastro
    End Sub

#End Region

#Region "Métodos"

    'inserir
    Public Sub inserir()
        Try
            Dim dal As New PessoaDAL
            'validação por cpf
            If (dal.validarCpf(Cpf)) Then
                Codigo = dal.inserir(Nome, Rg, Cpf, Endereco, Bairro, Numero, Complemento, Cidade, Uf, Telefone, Celular, DataNascimento, Sexo, Email, Cep)
                dal = Nothing
            Else
                Throw New Exception("Você já está cadastrado em nosso sistema")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'alterar
    Public Sub alterar()
        Try

            Dim dal As New PessoaDAL
            dal.alterar(Codigo, Nome, Rg, Cpf, Endereco, Bairro, Numero, Complemento, Cidade, Uf, Telefone, Celular, DataNascimento, Sexo, Email, Cep)
            dal = Nothing

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'selecionar(codigo)
    'carregar nas propriedades os valores do BD do codigo passado por parametro
    Public Sub selecionar(
           codigo As Integer)
        Dim tab As DataTable = Nothing
        Try
            Dim dal As New PessoaDAL
            tab = dal.selecionar(codigo)
            dal = Nothing
            limpar()
            'se tem dados
            If (Not tab Is Nothing) Then
                'tab.Rows.Count: qtde linhas
                If (tab.Rows.Count > 0) Then
                   
                    Me.Codigo = tab.Rows(0)("pess_codigo")
                    Me.Nome = tab.Rows(0)("pess_nome")
                    Me.Rg = tab.Rows(0)("pess_rg")
                    Me.Cpf = tab.Rows(0)("pess_cpf")
                    Me.Endereco = tab.Rows(0)("pess_endereco")
                    Me.Bairro = tab.Rows(0)("pess_bairro")
                    Me.Numero = tab.Rows(0)("pess_numero")
                    Me.Complemento = tab.Rows(0)("pess_complemento")
                    Me.Cidade = tab.Rows(0)("pess_cidade")
                    Me.Uf = tab.Rows(0)("pess_uf")
                    Me.Telefone = tab.Rows(0)("pess_telefone")
                    Me.Celular = tab.Rows(0)("pess_celular")
                    Me.DataNascimento = tab.Rows(0)("pess_datanascimento")
                    Me.Sexo = tab.Rows(0)("pess_sexo")
                    Me.Email = tab.Rows(0)("pess_email")
                    Me.Cep = tab.Rows(0)("pess_cep")
                  
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub limpar()
        Me.Codigo = 0
        Me.Nome = ""
        Me.Rg = ""
        Me.Cpf = ""
        Me.Endereco = ""
        Me.Bairro = ""
        Me.Numero = ""
        Me.Complemento = ""
        Me.Cidade = ""
        Me.Uf = ""
        Me.Telefone = ""
        Me.Celular = ""
        Me.DataNascimento = Date.Now
        Me.Sexo = ""
        Me.Email = ""
        Me.Cep = ""
    End Sub

    'selecionar(nome)
    Public Function selecionar(
            nome As String) As DataTable
        Dim tab As DataTable = Nothing
        Try
            Dim dal As New PessoaDAL
            tab = dal.selecionar(nome)
            dal = Nothing
        Catch ex As Exception
            Throw ex
        End Try
        Return tab
    End Function


    'excluir
    Public Sub excluir()
        Try

            Dim dal As New PessoaDAL
            dal.excluir(Codigo)
            dal = Nothing

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

   
#End Region
End Class
