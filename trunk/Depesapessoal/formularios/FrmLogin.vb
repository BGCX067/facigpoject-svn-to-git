Public Class FrmLogin


    Private Sub BtnLoga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLoga.Click
        Dim user As New Usuario

        If TxtNome.Text = "" Then
            MsgBox("É necessário preencher o campo nome.", MessageBoxIcon.Information)
            Exit Sub
        End If
        If TxtSenha.Text = "" Then
            MsgBox("É necessário preencher o campo senha.", MessageBoxIcon.Information)
            Exit Sub
        End If
        user.Nome = TxtNome.Text
        user.Senha = TxtSenha.Text
        If user.Logar() = True Then
            Me.Close()
        Else
            MsgBox("Usuário ou senha incorreto.", MessageBoxIcon.Information)
            Exit Sub
        End If
    End Sub
    Private Sub BtnCancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancela.Click
        End
    End Sub

    Private Sub TxtNome_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNome.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub TxtSenha_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtSenha.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub BtnLoga_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BtnLoga.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub BtnCancela_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BtnCancela.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub
End Class