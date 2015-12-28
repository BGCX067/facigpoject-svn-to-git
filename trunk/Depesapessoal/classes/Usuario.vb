Public Class Usuario
    Private _usu_id As Integer
    Private _usu_email As String
    Private _usu_senha As String
    Private _usu_nome As String

    Public Property Id() As Integer
        Get
            Return _usu_id
        End Get
        Set(ByVal value As Integer)
            _usu_id = value
        End Set
    End Property

    Public Property Nome As String
        Get
            Return _usu_nome
        End Get
        Set(ByVal value As String)
            _usu_nome = value
        End Set
    End Property

    Public Property Email As String

        Get
            Return _usu_email
        End Get
        Set(ByVal value As String)
            _usu_email = value
        End Set
    End Property

    Public Property Senha As String

        Get
            Return _usu_senha
        End Get
        Set(ByVal value As String)
            _usu_senha = value
        End Set
    End Property
    Public Function Logar() As Boolean
        Dim SQLAcao As String
        Dim ExecutQuery As New DataBase
        Dim tb As MySql.Data.MySqlClient.MySqlDataReader

        SQLAcao = "Select * from usuario where usu_nome='" & Nome & "' and usu_senha='" & Senha & "' "
        tb = ExecutQuery.runDataRead(SQLAcao)
        If IsNothing(tb) Then
            Return False
            Exit Function
        End If
        While tb.Read
            Return True
        End While
        Return False
    End Function

    Public Function salvarUser() As Boolean
        Dim SQLAcao As String
        Dim ExecutQuery As New DataBase
        salvarUser = False
        SQLAcao = "insert into usuario (usu_nome,usu_email,usu_senha) values ('" & Nome & "','" & Email & "','" & Senha & "')"
        If ExecutQuery.runQuery(SQLAcao) = False Then
            Exit Function
        End If

        salvarUser = True
    End Function

    Public Function Atualiza(ByVal Id As Integer) As Boolean
        Dim SQLAcao As String
        Dim ExecutQuery As New DataBase

        SQLAcao = "update usuario set usu_nome='" & Nome & "', usu_email='" & Email & "', usu_senha='" & Senha & "' WHERE usuario.usu_id='" & Id & "'"
        If (ExecutQuery.runQuery(SQLAcao)) = 0 Then
            Return True
            Exit Function
        End If

        Return False
    End Function
    Public Function Delete(ByVal Id As Integer) As Boolean
        Dim SQLAcao As String
        Dim ExecutQuery As New DataBase

        SQLAcao = "delete from usuario where usu_id='" & Id & "'"
        If (ExecutQuery.runQuery(SQLAcao)) = 0 Then
            Return True
            Exit Function
        End If

        Return False

    End Function

End Class
