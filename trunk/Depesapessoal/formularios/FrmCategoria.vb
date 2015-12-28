
'/****************************************
'Nome: Despesa Pessoal                                     Versão:1.0
'Descricao:formulário para cadastro de usuários no sistema
'Entradas:o usuário deverá informa todos os campos no formulário são obrigatório
'Saídas:inserção no banco de dados 
'Autor:Geraldo Gonçalves dias
'Ano:2013
Public Class FrmCategoria
    'Declaração de variáveis
    Dim CodigoCategoria As Integer
    Dim cat As New Categoria

    Private Sub BtnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalvar.Click
        'Verificando se  campo descrição foi preenchido
        If Txtdescricao.Text = "" Then
            MsgBox("É necessário especificar a descrição.", MessageBoxIcon.Information)
            Txtdescricao.Focus()
            Exit Sub
        End If

        'Passando o valor do campo descrição para a classe.
        cat.Descricao = Txtdescricao.Text

        'Verificando se está na inclusão de dados
        'onde CodigoUsuario =0 é inserção,caso seja diferente de 0 e atualização dos dados
        If CodigoCategoria = 0 Then
            If (cat.Salvar = True) Then
                MsgBox("Dados cadastrados com sucesso!", MessageBoxIcon.Information)
                Close()
            End If
        Else
            If (cat.Atualiza(CodigoCategoria) = True) Then
                MsgBox("Dados atualizado com sucesso!", MessageBoxIcon.Information)
                Close()
            End If
        End If

    End Sub
    'Fechando o formulário caso o usuário  tenha clicado no botão cancelar
    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Dim resultado As DialogResult = MessageBox.Show("Deseja cancelar ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = vbYes Then
            Close()
        End If
    End Sub

    'Pasando os valores para os campos do formulário por valor
    Sub Alterar(ByVal codigo As String, ByVal Descricao As String)
        Dim frmgrid As New FrmGridCategoria

        Txtdescricao.Text = Descricao
        CodigoCategoria = codigo
    End Sub
    'verificando se a tecla enter foi pressionada caso tenha sido a tecla enter, ele faz a função do tab

    Private Sub Txtdescricao_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txtdescricao.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub BtnSalvar_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BtnSalvar.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub BtnCancelar_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BtnCancelar.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub
    '---------------------------------------------------------------------------------------------------
End Class