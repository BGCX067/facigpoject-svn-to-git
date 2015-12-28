Public Class MDIPRINCIPAL
    Private Sub UsuárioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuárioToolStripMenuItem.Click
        Dim frmGridUser As New frmGridUsuario

        frmGridUser.MdiParent = Me
        frmGridUser.Width = Me.Width
        frmGridUser.Height = Me.Height
        frmGridUser.Show()
    End Sub


    Private Sub CategoriToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoriToolStripMenuItem.Click
        Dim frmcat As New FrmGridCategoria
        frmcat.MdiParent = Me

        frmcat.Width = Me.Width
        frmcat.Height = Me.Height
        frmcat.Show()
    End Sub

    Private Sub DespesasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DespesasToolStripMenuItem1.Click
        Dim Frmdespesa As New FrmGridDespesa

        Frmdespesa.MdiParent = Me
        Frmdespesa.Width = Me.Width
        Frmdespesa.Height = Me.Height
        Frmdespesa.Show()
    End Sub

    Private Sub ReceitasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceitasToolStripMenuItem.Click
        Dim FrmReceita As New FrmGridReceita

        FrmReceita.MdiParent = Me
        FrmReceita.Width = Me.Width
        FrmReceita.Height = Me.Height
        FrmReceita.Show()
    End Sub

    Private Sub CalculadoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Shell("calc", AppWinStyle.NormalFocus)
    End Sub

    Private Sub MDIPRINCIPAL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim frmlogin As New FrmLogin
        frmlogin.ShowDialog()

    End Sub

    Private Sub FluxoCaixaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FluxoCaixaToolStripMenuItem.Click
        Dim frmrelat As New FrmRelatReceita
        frmrelat.ShowDialog()
    End Sub

    Private Sub SobreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SobreToolStripMenuItem.Click
        Dim resultado As DialogResult = MessageBox.Show("Deseja fechar o sistema ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resultado = vbYes Then
            Close()
        End If
    End Sub

    Private Sub DespesasToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DespesasToolStripMenuItem2.Click
        Dim frmrelat As New FrmRelatorio
        frmrelat.ShowDialog()
    End Sub

    Private Sub ManualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManualToolStripMenuItem.Click
        Process.Start(Application.StartupPath & "\Manual do sistema.pdf")
    End Sub

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub SobreToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SobreToolStripMenuItem1.Click
        Dim frm As New FrmSobre
        frm.ShowDialog()
    End Sub
End Class