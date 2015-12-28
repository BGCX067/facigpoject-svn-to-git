Public Class FrmGridReceita
    Sub PreencherGrid()
        Dim SQLAcao As String
        Dim ExecutQuery As New DataBase

        SQLAcao = "select receita.rec_id as Codigo, receita.rec_cat_id,categoria.cat_descricao as Categoria,receita.rec_descricao as receita,receita.rec_data as Data,receita.rec_valor as Valor,receita.rec_valor_quitado as ValorQuitado,receita.rec_quitado as Quitado from receita inner join categoria on categoria.cat_id=receita.rec_cat_id"
        DataGridReceita.DataSource = ExecutQuery.runDataTable(SQLAcao)
        DataGridReceita.Columns(1).Visible = False

    End Sub
    Private Sub FrmGridReceita_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PreencherGrid()
    End Sub
    Private Sub TBSIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBSIncluir.Click
        Dim form As New FrmReceitas
        form.ShowDialog()
        PreencherGrid()
    End Sub

    Private Sub TBSEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBSEditar.Click
        Dim Codigocategria, codigo As Integer
        Dim Descricao As String
        Dim data As Date
        Dim valor As Double
        Dim valorquitado As Double
        Dim quitado As String


        codigo = DataGridReceita.CurrentRow.Cells(0).Value()
        Codigocategria = DataGridReceita.CurrentRow.Cells(1).Value() 'guardas os dados de cada coluna em vars
        Descricao = DataGridReceita.CurrentRow.Cells(3).Value() 'guardas os dados de cada coluna em vars
        data = DataGridReceita.CurrentRow.Cells(4).Value()
        valor = DataGridReceita.CurrentRow.Cells(5).Value
        valorquitado = DataGridReceita.CurrentRow.Cells(6).Value
        quitado = DataGridReceita.CurrentRow.Cells(7).Value
        Dim form As New FrmReceitas 'abres o form onde tens os dados


        form.Alterar(codigo, Codigocategria, Descricao, valor, valorquitado, data, quitado)
        form.ShowDialog()
        PreencherGrid()
    End Sub
    Private Sub TBSExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBSExcluir.Click
        Dim codigo As String
        Dim Rec As New Receitas
        Dim resultado As DialogResult = MessageBox.Show("Confirma a exclusão deste registro ?", _
          "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        codigo = DataGridReceita.CurrentRow.Cells(0).Value()

        If resultado = DialogResult.Yes Then
            If codigo <> 0 Then
                If Rec.Delete(codigo) = True Then
                    MsgBox("Dado deletado com sucesso!", MessageBoxIcon.Information)
                    PreencherGrid()
                Else
                    MsgBox("erro  ao deletar!", MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub
End Class