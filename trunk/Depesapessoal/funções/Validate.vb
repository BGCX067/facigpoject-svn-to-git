Public Class Validate

    Public Function ValidarCampo(ByVal campo As String) As Boolean
        If (campo = "") Then
            MsgBox("É necessário especificar o valor!")
            ValidarCampo = False
            Exit Function
        Else
            ValidarCampo = True
        End If
    End Function
    Function ValidateEmail(ByVal email As String) As Boolean
        Dim emailRegex As _
            New System.Text.RegularExpressions.Regex( _
            "^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As  _
            System.Text.RegularExpressions.Match = emailRegex.Match(email)
        Return emailMatch.Success
    End Function
End Class
