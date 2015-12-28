Public Class Receitas
    Dim _rec_id As Integer
    Dim _rec_cat_id As Integer
    Dim _rec_descricao As String
    Dim _rec_data As String
    Dim _rec_valor As Double
    Dim _rec_valor_quitado As Double
    Dim _rec_quitado As String

    Public Property Id() As Integer
        Get
            Return _rec_id
        End Get
        Set(ByVal Value As Integer)
            _rec_id = Value
        End Set
    End Property

    Public Property Cat_id() As Integer

        Get
            Return _rec_cat_id
        End Get
        Set(ByVal value As Integer)
            _rec_cat_id = value
        End Set
    End Property
    Public Property Descricao() As String

        Get
            Return _rec_descricao
        End Get
        Set(ByVal value As String)
            _rec_descricao = value
        End Set
    End Property

    Public Property Data() As String

        Get
            Return _rec_data
        End Get
        Set(ByVal value As String)
            _rec_data = value
        End Set
    End Property

    Public Property Valor() As Double

        Get
            Return _rec_valor
        End Get
        Set(ByVal value As Double)
            _rec_valor = value
        End Set
    End Property

    Public Property Valorquitado() As Double

        Get
            Return _rec_valor_quitado
        End Get
        Set(ByVal value As Double)
            _rec_valor_quitado = value
        End Set
    End Property

    Public Property Quitado() As String

        Get
            Return _rec_quitado
        End Get
        Set(ByVal value As String)
            _rec_quitado = value
        End Set
    End Property

    Public Function salvar() As Boolean
        Dim SQLAcao As String
        Dim ExecutQuery As New DataBase


        SQLAcao = "insert into receita (rec_cat_id,rec_descricao,rec_data,rec_valor,rec_valor_quitado,rec_quitado) values ('" & Cat_id & "','" & Descricao & "','" & Data & "','" & Valor & "','" & Valorquitado & "','" & Quitado & "')"
        If ExecutQuery.runQuery(SQLAcao) = False Then
            salvar = False
            Exit Function
        End If


        Return True

    End Function
    Public Function Atualiza(ByVal codigo As Integer) As Boolean
        Dim SQLAcao As String
        Dim ExecutQuery As New DataBase

        SQLAcao = "update receita set rec_cat_id='" & Cat_id & "' ,rec_descricao='" & Descricao & "', rec_data='" & Data & "', rec_valor='" & Valor & "', rec_valor_quitado='" & Valorquitado & "', rec_quitado='" & Quitado & "' WHERE receita.rec_id='" & codigo & "'"
        If (ExecutQuery.runQuery(SQLAcao)) = 0 Then
            Return True
            Exit Function
        End If

        Return False
    End Function
    Public Function Delete(ByVal codigo As Integer)
        Dim SQLAcao As String
        Dim ExecutQuery As New DataBase

        SQLAcao = "delete from receita where rec_id='" & codigo & "'"
        If (ExecutQuery.runQuery(SQLAcao)) = 0 Then
            Return True
            Exit Function
        End If
        Return False
    End Function
End Class
