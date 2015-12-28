
Public Class FrmReceitas
    Dim CodigoReceita As String
    Private Sub BtnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalvar.Click
        Dim valida As New Validate
        Dim Receita As New Receitas

        If CmbCategoria.SelectedItem.id = 0 Then
            MsgBox("É necessário especificar a categoria", MessageBoxIcon.Information)
            Exit Sub
        End If

        If TxtDescricao.Text = "" Then
            MsgBox("É necessário especificar a descrição", MessageBoxIcon.Information)
            Exit Sub
        End If

        If TxtValor.Text = "" Then
            MsgBox("É necessário especificar o valor", MessageBoxIcon.Information)
            Exit Sub
        End If

        If CmbQuitado.Text = "" Then
            MsgBox("É necessário especificar o campo quitado", MessageBoxIcon.Information)
            Exit Sub
        End If

      

        Receita.Cat_id = CmbCategoria.SelectedValue.id
        Receita.Descricao = TxtDescricao.Text
        Receita.Valor = Val(TxtValor.Text)
        Receita.Data = Format(DateTimePic.Value, "yyy-MM-dd")
        Receita.Valorquitado = Val(TxtValorQuitado.Text)
        Receita.Quitado = CmbQuitado.Text


        If CodigoReceita = 0 Then
            If (Receita.salvar = True) Then
                MsgBox("Dados cadastrados com sucesso!", MessageBoxIcon.Information)
                Close()
            End If
        Else

            If (Receita.Atualiza(CodigoReceita) = True) Then
                MsgBox("Dados atualizado com sucesso!", MessageBoxIcon.Information)
                Close()
            End If
        End If

    End Sub
    Private Sub TxtValor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtValor.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxtValorQuitado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtValorQuitado.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Dim resultado As DialogResult = MessageBox.Show("Deseja cancelar ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resultado = vbYes Then
            Close()
        End If
    End Sub


    Public Sub Alterar(ByVal codigo As String, ByVal CodigoCategoria As Integer, ByVal Descricao As String, ByVal valor As Double, ByVal valorquitado As Double, ByVal data As Date, ByVal quitado As String)
        Dim Tipo As New TipoCategoria
        Dim TipoLst As New List(Of TipoCategoria)

        TipoLst = Tipo.fetchListObject(CodigoCategoria)

        For a = 0 To CmbCategoria.Items.Count - 1
            If CmbCategoria.Items(a).id = TipoLst(0).id Then
                CmbCategoria.SelectedIndex = a
            End If
        Next
        TxtDescricao.Text = Descricao
        CodigoReceita = codigo
        TxtValor.Text = valor
        TxtValorQuitado.Text = valorquitado
        DateTimePic.Value = data
        If quitado = "Não" Then
            CmbQuitado.SelectedIndex = 1
        Else
            CmbQuitado.SelectedIndex = 0
        End If



    End Sub

    Public Sub New()
        Dim Tipo As New TipoCategoria
        InitializeComponent()

        CmbCategoria.DataSource = Tipo.fetchListObject(0)
        CmbCategoria.DisplayMember = "descricao"

    End Sub

    Private Sub CmbCategoria_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbCategoria.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub CmbQuitado_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmbQuitado.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub DateTimePic_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DateTimePic.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub TxtDescricao_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDescricao.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub TxtValor_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtValor.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub TxtValorQuitado_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtValorQuitado.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub
End Class