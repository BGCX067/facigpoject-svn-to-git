<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadastrarUsuario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadastrarUsuario))
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtSenha = New System.Windows.Forms.TextBox()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.LblSenha = New System.Windows.Forms.Label()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.LblNome = New System.Windows.Forms.Label()
        Me.TxtConfirmaSenha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(265, 145)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 6
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Location = New System.Drawing.Point(183, 146)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalvar.TabIndex = 5
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(100, 38)
        Me.TxtEmail.MaxLength = 40
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(239, 20)
        Me.TxtEmail.TabIndex = 1
        '
        'TxtSenha
        '
        Me.TxtSenha.Location = New System.Drawing.Point(100, 73)
        Me.TxtSenha.MaxLength = 8
        Me.TxtSenha.Name = "TxtSenha"
        Me.TxtSenha.Size = New System.Drawing.Size(239, 20)
        Me.TxtSenha.TabIndex = 3
        Me.TxtSenha.UseSystemPasswordChar = True
        '
        'TxtNome
        '
        Me.TxtNome.Location = New System.Drawing.Point(100, 12)
        Me.TxtNome.MaxLength = 40
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(239, 20)
        Me.TxtNome.TabIndex = 0
        '
        'LblSenha
        '
        Me.LblSenha.AutoSize = True
        Me.LblSenha.Location = New System.Drawing.Point(14, 73)
        Me.LblSenha.Name = "LblSenha"
        Me.LblSenha.Size = New System.Drawing.Size(38, 13)
        Me.LblSenha.TabIndex = 22
        Me.LblSenha.Text = "Senha"
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Location = New System.Drawing.Point(14, 45)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(32, 13)
        Me.LblEmail.TabIndex = 21
        Me.LblEmail.Text = "Email"
        '
        'LblNome
        '
        Me.LblNome.AutoSize = True
        Me.LblNome.Location = New System.Drawing.Point(11, 12)
        Me.LblNome.Name = "LblNome"
        Me.LblNome.Size = New System.Drawing.Size(35, 13)
        Me.LblNome.TabIndex = 19
        Me.LblNome.Text = "Nome"
        '
        'TxtConfirmaSenha
        '
        Me.TxtConfirmaSenha.Location = New System.Drawing.Point(100, 110)
        Me.TxtConfirmaSenha.MaxLength = 8
        Me.TxtConfirmaSenha.Name = "TxtConfirmaSenha"
        Me.TxtConfirmaSenha.Size = New System.Drawing.Size(239, 20)
        Me.TxtConfirmaSenha.TabIndex = 4
        Me.TxtConfirmaSenha.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Confirma senha"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'FrmCadastrarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(355, 217)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtConfirmaSenha)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnSalvar)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtSenha)
        Me.Controls.Add(Me.TxtNome)
        Me.Controls.Add(Me.LblSenha)
        Me.Controls.Add(Me.LblEmail)
        Me.Controls.Add(Me.LblNome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCadastrarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnSalvar As System.Windows.Forms.Button
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents TxtSenha As System.Windows.Forms.TextBox
    Friend WithEvents TxtNome As System.Windows.Forms.TextBox
    Friend WithEvents LblSenha As System.Windows.Forms.Label
    Friend WithEvents LblEmail As System.Windows.Forms.Label
    Friend WithEvents LblNome As System.Windows.Forms.Label
    Friend WithEvents TxtConfirmaSenha As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
