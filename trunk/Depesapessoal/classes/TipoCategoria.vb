Public Class TipoCategoria
    Private _Cat_id As Integer
    Private _Cat_descricao As String

    Public Property id() As Integer
        Get
            Return _Cat_id
        End Get
        Set(ByVal Value As Integer)
            _Cat_id = Value
        End Set
    End Property

    Public Property descricao() As String
        Get
            Return _Cat_descricao
        End Get
        Set(ByVal Value As String)
            _Cat_descricao = Value
        End Set
    End Property

    Public Function fetchListObject(ByVal id As Integer) As System.Collections.Generic.List(Of TipoCategoria)

        Dim core As New DataBase
        Dim dataReader As MySql.Data.MySqlClient.MySqlDataReader
        Dim tipo As System.Collections.Generic.List(Of TipoCategoria)
        Dim query As String
        Dim i As Integer

        If id <> 0 Then
            query = "SELECT cat_id,cat_descricao FROM categoria WHERE cat_id=" & id & ";"
        Else
            query = "SELECT cat_id,cat_descricao FROM categoria;"
        End If

        dataReader = core.runDataRead(query)
        tipo = New System.Collections.Generic.List(Of TipoCategoria)

        While dataReader.Read
            tipo.Add(New TipoCategoria)
            tipo(i)._Cat_id = dataReader("cat_id")
            tipo(i)._Cat_descricao = dataReader("cat_descricao")
            i += 1
        End While
        dataReader.Close()

        Return tipo
    End Function

End Class



