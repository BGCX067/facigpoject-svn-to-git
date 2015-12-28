Public Class frmGridUsuario


    'Evento do botão incluir 
    Private Sub TBSIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBSIncluir.Click
        Dim form As New FrmCadastrarUsuario
        form.ShowDialog()
        PreencherGrid()
    End Sub


    Private Sub TBSEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBSEditar.Click
        Dim Nome, Email, codigo, senha As String

        codigo = DataGridUsuario.CurrentRow.Cells(0).Value()
        Nome = DataGridUsuario.CurrentRow.Cells(1).Value() 'guardas os dados de cada coluna em variavel
        Email = DataGridUsuario.CurrentRow.Cells(2).Value() 'guardas os dados de cada coluna em varivale
        senha = DataGridUsuario.CurrentRow.Cells(3).Value() 'guardas os dados de cada coluna em variavel


        Dim form As New FrmCadastrarUsuario 'abres o form onde tens os dados
        form.Alterar(codigo, Nome, Email, senha)
        form.ShowDialog()
        PreencherGrid()
    End Sub

    Private Sub TBSExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBSExcluir.Click
        Dim codigo As String
        Dim user As New Usuario
        Dim tb As MySql.Data.MySqlClient.MySqlDataReader
        Dim ExecutQuery As New DataBase
        Dim SQLAcao As String
        Dim i As Integer
        Dim resultado As DialogResult = MessageBox.Show("Confirma a exclusão deste registro ?", _
          "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


        codigo = DataGridUsuario.CurrentRow.Cells(0).Value()
        If resultado = DialogResult.Yes Then
            SQLAcao = "select usu_id from usuario"
            tb = ExecutQuery.runDataRead(SQLAcao)
            While tb.Read
                i += 1
            End While
            tb.Close()

            If i = 1 Then
                MsgBox("Usuario não pode ser excluido", MessageBoxIcon.Warning)
                Exit Sub
            End If



            If codigo <> 0 Then
                If user.Delete(codigo) = True Then
                    MsgBox("Dado deletado com sucesso!", MessageBoxIcon.Information)
                    PreencherGrid()
                Else
                    MsgBox("erro  ao deletar!", MessageBoxIcon.Exclamation)
                End If
            End If
        End If
    End Sub
    Sub PreencherGrid()
        Dim SQLAcao As String
        Dim ExecutQuery As New DataBase
        SQLAcao = "SELECT usuario.usu_id as Codigo,usuario.usu_nome as Nome,usu_email as Email,usu_senha FROM usuario"
        DataGridUsuario.DataSource = ExecutQuery.runDataTable(SQLAcao)
        DataGridUsuario.Columns(3).Visible = False

    End Sub

    Private Sub frmGridUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PreencherGrid()
    End Sub
End Class