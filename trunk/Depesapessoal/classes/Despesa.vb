Public Class Despesa

    Private _des_cat_id As Integer
    Private _des_descricao As String
    Private _des_data As String
    Private _des_valor As Double
    Private _des_valor_quitado As Double
    Private _des_quitado As String
    Private _des_numero_parcela As Integer

    Public Property Cat_id() As Integer

        Get
            Return _des_cat_id
        End Get
        Set(ByVal value As Integer)
            _des_cat_id = value
        End Set
    End Property

    Public Property Descricao() As String

        Get
            Return _des_descricao
        End Get
        Set(ByVal value As String)
            _des_descricao = value
        End Set
    End Property
    Public Property Data() As String

        Get
            Return _des_data
        End Get
        Set(ByVal value As String)
            _des_data = value
        End Set
    End Property
    Public Property Valor() As Double

        Get
            Return _des_valor
        End Get
        Set(ByVal value As Double)
            _des_valor = value
        End Set
    End Property
    Public Property Valor_Quitado() As Double

        Get
            Return _des_valor_quitado
        End Get
        Set(ByVal value As Double)
            _des_valor_quitado = value
        End Set
    End Property

    Public Property Quitado() As String

        Get
            Return _des_quitado
        End Get
        Set(ByVal value As String)
            _des_quitado = value
        End Set
    End Property
    Public Property NumeroParcela() As Integer

        Get
            Return _des_numero_parcela
        End Get
        Set(ByVal value As Integer)
            _des_numero_parcela = value
        End Set
    End Property
    Public Function salvar() As Boolean
        Dim SQLAcao As String
        Dim ExecutQuery As New DataBase

        SQLAcao = "insert into despesas (des_cat_id,des_descricao,des_data,des_valor,des_numero_parcela,des_valor_quitado,des_quitado) values ('" & Cat_id & "','" & Descricao & "','" & Data & "','" & Valor & "','" & NumeroParcela & "','" & Valor_Quitado & "','" & Quitado & "')"
        If ExecutQuery.runQuery(SQLAcao) = False Then
            salvar = False
            Exit Function
        End If

        Return True
    End Function

    Public Function Atualiza(ByVal codigo As Integer) As Boolean
        Dim SQLAcao As String
        Dim ExecutQuery As New DataBase

        SQLAcao = "update despesas set des_cat_id='" & Cat_id & "', des_descricao='" & Descricao & "', des_data='" & Data & "', des_valor='" & Valor & "', des_numero_parcela='" & NumeroParcela & "', des_valor_quitado='" & Valor_Quitado & "', des_quitado='" & Quitado & "' WHERE despesas.des_id='" & codigo & "'"
        If (ExecutQuery.runQuery(SQLAcao)) = 0 Then
            Return True
            Exit Function
        End If

        Return False
    End Function
    Public Function Delete(ByVal codigo As Integer)
        Dim SQLAcao As String
        Dim ExecutQuery As New DataBase

        SQLAcao = "delete from despesas where des_id='" & codigo & "'"
        If (ExecutQuery.runQuery(SQLAcao)) = 0 Then
            Return True
            Exit Function
        End If
        Return False
    End Function
End Class
