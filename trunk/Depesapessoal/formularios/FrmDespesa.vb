'/****************************************
'Nome: Despesa Pessoal                                     Versão:1.0
'Descricao:formulário para cadastro de lançamento de despesa no sistema
'Entradas:o usuário deverá informa preencher todos capos exceto o numero de parcelas não é obrigatório
'Saídas:inserção no banco de dados 
'Autor:Geraldo Gonçalves dias
'Ano:2013

Public Class FrmDespesa
    'Declaração de variavel
    Dim CodigoDespesa As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Instânciando a classe despesa
        Dim Despesa As New Despesa
        Dim data As DateTime

        'verificando se no combo de categoria foi selecionado algum valor
        If CmbCategoria.SelectedItem.id = 0 Then
            MsgBox("É necessário especificar a categoria", MessageBoxIcon.Information)
            Exit Sub
        End If

        'verificando se o usuário informou a descrição
        If TxtDescricao.Text = "" Then
            MsgBox("É necessário especifica a descrição.", MessageBoxIcon.Information)
            TxtDescricao.Focus()
            Exit Sub
        End If

        'verificando se o campo valor foi preenchido
        If TxtValor.Text = "" Then
            MsgBox("É necessário especifica o valor.", MessageBoxIcon.Information)
            TxtValor.Focus()
            Exit Sub
        End If

        'verificando se foi informado o valor quitado, caso não tenha sido informado passa 0 para o campo
        If TxtValorQuitado.Text = "" Then
            TxtValorQuitado.Text = 0
        End If

        If TxtNumeroParcela.Text = "" Then
            TxtNumeroParcela.Text = 1
        End If

        If CmbQuitado.Text = "" Then
            MsgBox("È necessário especificar o valor do campo quitado", MessageBoxIcon.Information)
            Exit Sub
        End If

        data = DateTimePic.Value

        For i = 0 To TxtNumeroParcela.Text - 1
            Despesa.Cat_id = CmbCategoria.SelectedValue.id
            Despesa.Descricao = TxtDescricao.Text
            Despesa.Valor = Math.Round(TxtValor.Text / TxtNumeroParcela.Text, 2)
            If i <> 0 Then
                data = data.AddDays(i + 30)
            End If
            Despesa.Data = Format(data, "yyy-MM-dd")
            Despesa.Valor_Quitado = TxtValor.Text
            Despesa.NumeroParcela = TxtNumeroParcela.Text
            Despesa.Quitado = CmbQuitado.Text
            If CodigoDespesa = 0 Then
                If (Despesa.salvar = True) Then
                    If i = TxtNumeroParcela.Text - 1 Then
                        MsgBox("Dados cadastrados com sucesso!", MessageBoxIcon.Information)
                        Close()
                    End If
                End If
            Else
                If (Despesa.Atualiza(CodigoDespesa) = True) Then
                    If i = TxtNumeroParcela.Text - 1 Then
                        MsgBox("Dados atualizado com sucesso!", MessageBoxIcon.Information)
                        Close()
                    End If
                End If
            End If
        Next
    End Sub
    Public Sub New()
        Dim Tipo As New TipoCategoria
        InitializeComponent()

        CmbCategoria.DataSource = Tipo.fetchListObject(0)
        CmbCategoria.DisplayMember = "descricao"

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim resultado As DialogResult = MessageBox.Show("Deseja cancelar ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resultado = vbYes Then
            Close()
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

    Public Sub Alterar(ByVal codigo As String, ByVal CodigoCategoria As Integer, ByVal Descricao As String, ByVal valor As Double, ByVal numero As Integer, ByVal valorquitado As Double, ByVal data As Date, ByVal quitado As String)
        Dim Tipo As New TipoCategoria
        Dim TipoLst As New List(Of TipoCategoria)

        TipoLst = Tipo.fetchListObject(CodigoCategoria)

        For a = 0 To CmbCategoria.Items.Count - 1
            If CmbCategoria.Items(a).id = TipoLst(0).id Then
                CmbCategoria.SelectedIndex = a
            End If
        Next

        TxtDescricao.Text = Descricao
        CodigoDespesa = codigo
        TxtValor.Text = valor
        TxtNumeroParcela.Text = numero
        TxtValorQuitado.Text = valorquitado
        DateTimePic.Value = data
        If quitado = "Não" Then
            CmbQuitado.SelectedIndex = 1
        Else
            CmbQuitado.SelectedIndex = 0
        End If
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

    Private Sub TxtDescricao_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDescricao.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub TxtNumeroParcela_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNumeroParcela.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxtNumeroParcela_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNumeroParcela.KeyUp
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

    Private Sub DateTimePic_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DateTimePic.KeyUp
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub
End Class