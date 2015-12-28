Public Class FrmGridDespesa
    Private Sub TBSIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBSIncluir.Click
        Dim form As New FrmDespesa
        form.ShowDialog()
        PreencherGrid()
    End Sub

    Private Sub TBSEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBSEditar.Click
        Dim Codigocategria, codigo As Integer
        Dim Descricao As String
        Dim data As Date
        Dim valor As Double
        Dim numero As Integer
        Dim valorquitado As Double
        Dim quitado As String


        codigo = DataGridDespesa.CurrentRow.Cells(0).Value()
        Codigocategria = DataGridDespesa.CurrentRow.Cells(1).Value() 'guardas os dados de cada coluna em vars
        Descricao = DataGridDespesa.CurrentRow.Cells(3).Value() 'guardas os dados de cada coluna em vars
        data = DataGridDespesa.CurrentRow.Cells(4).Value()
        valor = DataGridDespesa.CurrentRow.Cells(5).Value
        numero = DataGridDespesa.CurrentRow.Cells(6).Value
        valorquitado = DataGridDespesa.CurrentRow.Cells(7).Value
        quitado = DataGridDespesa.CurrentRow.Cells(8).Value
        Dim form As New FrmDespesa 'abres o form onde tens os dados


        form.Alterar(codigo, Codigocategria, Descricao, valor, numero, valorquitado, data, quitado)
        form.ShowDialog()
        PreencherGrid()
    End Sub
    Private Sub TBSExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBSExcluir.Click
        Dim codigo As String
        Dim Dep As New Despesa
        Dim resultado As DialogResult = MessageBox.Show("Confirma a exclusão deste registro ?", _
          "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


        codigo = DataGridDespesa.CurrentRow.Cells(0).Value()


        If resultado = DialogResult.Yes Then
            If codigo <> 0 Then
                If Dep.Delete(codigo) = True Then
                    MsgBox("Dado deletado com sucesso!", MessageBoxIcon.Information)
                    PreencherGrid()
                Else
                    MsgBox("erro  ao deletar!", MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub
    Sub PreencherGrid()
        Dim SQLAcao As String
        Dim ExecutQuery As New DataBase



        SQLAcao = "SELECT despesas.des_id as codigo,des_cat_id as codigoCategoria,categoria.cat_descricao as Categoria,despesas.des_descricao as Despesa,despesas.des_data as data,despesas.des_valor as valor,despesas.des_numero_parcela as NumeroParcela,despesas.des_valor_quitado as ValorTotal,des_quitado as Quitado  from despesas inner join categoria on categoria.cat_id=despesas.des_cat_id"
        DataGridDespesa.DataSource = ExecutQuery.runDataTable(SQLAcao)
        DataGridDespesa.Columns(1).Visible = False
        DataGridDespesa.Columns(6).Visible = False



    End Sub

    Private Sub FrmGridDespesa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PreencherGrid()
    End Sub
End Class
