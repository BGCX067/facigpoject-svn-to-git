Imports System.Data.SqlClient

Public Class Categoria
    'Declaração das variaveis
    Private _cat_id As String
    Private _cat_descricao As String
    Private _cat_tipo As String

    'Recuperando os dados do campo id e enviando para o banco

    Public Property Id() As Integer
        Get
            Return _cat_id
        End Get
        Set(ByVal value As Integer)
            _cat_id = value
        End Set
    End Property


    'Recuperando os dados do campo descrição e enviando para o banco

    Public Property Descricao() As String

        Get
            Return _cat_descricao
        End Get
        Set(ByVal value As String)
            _cat_descricao = value
        End Set
    End Property

    'Recuperando os dados do campo tipo e enviando para o banco
    Public Property Tipo() As String

        Get
            Return _cat_tipo
        End Get
        Set(ByVal value As String)
            _cat_tipo = value
        End Set
    End Property

    'Função para salvar dados no banco
    Public Function Salvar() As Boolean
        Dim SQLAcao As String
        Dim ExecutQuery As New DataBase

        SQLAcao = "insert into categoria (cat_descricao) values ('" & Descricao & "')"
        If ExecutQuery.runQuery(SQLAcao) = 0 Then
            Return False
            Exit Function
        End If

        Return True
    End Function

    'Função para atulizar dados do banco;
    Public Function Atualiza(ByVal Id As Integer) As Boolean
        Dim SQLAcao As String
        Dim ExecutQuery As New DataBase

        SQLAcao = "update categoria set cat_descricao='" & Descricao & "' WHERE categoria.cat_id='" & Id & "'"
        If (ExecutQuery.runQuery(SQLAcao)) = 0 Then
            Return True
            Exit Function
        End If

        Return False
    End Function

    'Função para deletar dados no banco
    Public Function Delete(ByVal Id As Integer) As Boolean
        Dim SQLAcao As String
        Dim ExecutQuery As New DataBase

        SQLAcao = "delete from categoria where cat_id='" & Id & "'"
        If (ExecutQuery.runQuery(SQLAcao)) = 0 Then
            Return True
            Exit Function
        End If

        Return False

    End Function
End Class
