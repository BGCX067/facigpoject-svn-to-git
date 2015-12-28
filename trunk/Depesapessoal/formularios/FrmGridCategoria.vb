Public Class FrmGridCategoria

  
    Private Sub TBSIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBSIncluir.Click
        Dim form As New FrmCategoria
        form.ShowDialog()
        PreencherGrid()
    End Sub

    Private Sub TBSEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBSEditar.Click
        Dim Descricao, codigo As String
        ' Tipo = DataGridCategoria.CurrentRow.Cells(2).Value() 'guardas os dados de cada coluna em vars
        Descricao = DataGridCategoria.CurrentRow.Cells(1).Value() 'guardas os dados de cada coluna em vars
        codigo = DataGridCategoria.CurrentRow.Cells(0).Value()
        Dim form As New FrmCategoria 'abres o form onde tens os dados
        form.Alterar(codigo, Descricao)
        form.ShowDialog()
        PreencherGrid()
    End Sub

    Private Sub TBSExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBSExcluir.Click
        Dim codigo As String
        Dim cat As New Categoria
        Dim ExecutQuery As New DataBase
        Dim tb As MySql.Data.MySqlClient.MySqlDataReader
        Dim SqlAcao As String

        Dim resultado As DialogResult = MessageBox.Show("Confirma a exclusão deste registro ?", _
          "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


        codigo = DataGridCategoria.CurrentRow.Cells(0).Value()
        If resultado = DialogResult.Yes Then

            SqlAcao = "select * from categoria inner join despesas on(despesas.des_cat_id=categoria.cat_id) where categoria.cat_id='" & codigo & "' "
            tb = ExecutQuery.runDataRead(SqlAcao)
            While tb.Read
                MsgBox("Não foi possivel fazer a exclusão,pois o registro posui dependencia na tabela: Despesas", MessageBoxIcon.Warning)
                Exit Sub
            End While
            tb.Close()

            SqlAcao = "select * from categoria inner join receita on(receita.rec_cat_id=categoria.cat_id) where categoria.cat_id='" & codigo & "' "
            tb = ExecutQuery.runDataRead(SqlAcao)
            While tb.Read
                MsgBox("Não foi possivel fazer a exclusão,pois o registro posui dependencia na tabela: Receita", MessageBoxIcon.Warning)
                Exit Sub
            End While
            tb.Close()



            If codigo <> 0 Then
                If cat.Delete(codigo) = True Then
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


        SQLAcao = "SELECT  cat_id as Codigo,cat_descricao as Descricao  FROM CATEGORIA"
        DataGridCategoria.DataSource = ExecutQuery.runDataTable(SQLAcao)

    End Sub

    Private Sub FrmGridCategoria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PreencherGrid()
    End Sub
End Class