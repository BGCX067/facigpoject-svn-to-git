
'/****************************************
'Nome: Despesa Pessoal                                     Versão:1.0
'Descricao:formulário para cadastro de usuários no sistema
'Entradas:o usuário deverá informa todos os campos no formulário são obrigatório
'Saídas:inserção no banco de dados 
'Autor:Geraldo Gonçalves dias
'Ano:2013

Imports MySql.Data.MySqlClient
Imports MySql.Data
Public Class FrmCadastrarUsuario
    'Declaração de variáveis
    Dim CodigoUsuario As Integer
    Dim user As New Usuario
    Dim valida As New Validate

    Private Sub BtnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalvar.Click
        'Validando o campo nome
        If TxtNome.Text = "" Then
            MsgBox("É necessário preencher o campo nome.", MessageBoxIcon.Information)
            TxtNome.Focus()
            Exit Sub
        End If

        'Validando o campo Email
        If (valida.ValidateEmail(TxtEmail.Text)) = False Then
            MsgBox("Email inválido", MessageBoxIcon.Information)
            TxtEmail.Focus()
            Exit Sub
        End If

        'Validando o campo senha
        If TxtSenha.Text = "" Then
            MsgBox("É necessário especificar a senha.", MessageBoxIcon.Information)
            TxtSenha.Focus()
            Exit Sub
        End If

        'Validado o campo de confirmação de senha
        If TxtConfirmaSenha.Text = "" Then
            MsgBox("É necessário especificar a confirmação de senha.", MessageBoxIcon.Information)
            TxtConfirmaSenha.Focus()
            Exit Sub
        End If

        'verificando se as senhas do usuário estão iguais
        If TxtConfirmaSenha.Text <> TxtSenha.Text Then
            MsgBox("A senha são diferentes!", MessageBoxIcon.Information)
            Exit Sub
        End If

        'passando os valores dos campos para a classe
        user.Nome = TxtNome.Text
        user.Email = TxtEmail.Text
        user.Senha = TxtSenha.Text

        'Verificando se está na inclusão de dados
        'onde CodigoUsuario =0 é inserção,caso seja diferente de 0 e atualização dos dados
        If CodigoUsuario = 0 Then
            If (user.salvarUser = True) Then
                MsgBox("Dados cadastrados com sucesso!", MessageBoxIcon.Information)
                Close()
            End If
        Else
            If (user.Atualiza(CodigoUsuario) = True) Then
                MsgBox("Dados atualizado com sucesso!", MessageBoxIcon.Information)
                Close()
            End If
        End If
    End Sub
    'Pasando os valores por valor da grid para os campos do formulário na edição
    Sub Alterar(ByVal codigo As String, ByVal nome As String, ByVal Email As String, ByVal Senha As String)
        Dim frmgrid As New FrmGridCategoria
        TxtNome.Text = nome
        TxtEmail.Text = Email
        TxtSenha.Text = Senha
        TxtConfirmaSenha.Text = Senha
        CodigoUsuario = codigo
    End Sub

    'Fechando o formulário de usuáro
    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Dim resultado As DialogResult = MessageBox.Show("Deseja cancelar ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resultado = vbYes Then
            Close()
        End If

    End Sub
    '------------------------------------------------------------------------------------------------------------------------------------------
    'verificando se a tecla enter foi pressionada caso tenha sido a tecla enter, ele faz a função do tab
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

    Private Sub TxtConfirmaSenha_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtConfirmaSenha.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub TxtEmail_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtEmail.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    '-------------------------------------------------------------------------------------------------------------------------------------------
End Class
