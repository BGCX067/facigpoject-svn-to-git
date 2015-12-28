<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.TxtSenha = New System.Windows.Forms.TextBox()
        Me.BtnLoga = New System.Windows.Forms.Button()
        Me.BtnCancela = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(189, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(186, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Senha"
        '
        'TxtNome
        '
        Me.TxtNome.Location = New System.Drawing.Point(186, 61)
        Me.TxtNome.MaxLength = 50
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(209, 20)
        Me.TxtNome.TabIndex = 0
        '
        'TxtSenha
        '
        Me.TxtSenha.Location = New System.Drawing.Point(186, 100)
        Me.TxtSenha.MaxLength = 50
        Me.TxtSenha.Name = "TxtSenha"
        Me.TxtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtSenha.Size = New System.Drawing.Size(209, 20)
        Me.TxtSenha.TabIndex = 1
        '
        'BtnLoga
        '
        Me.BtnLoga.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLoga.Location = New System.Drawing.Point(228, 140)
        Me.BtnLoga.Name = "BtnLoga"
        Me.BtnLoga.Size = New System.Drawing.Size(75, 23)
        Me.BtnLoga.TabIndex = 2
        Me.BtnLoga.Text = "Entrar"
        Me.BtnLoga.UseVisualStyleBackColor = True
        '
        'BtnCancela
        '
        Me.BtnCancela.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancela.Location = New System.Drawing.Point(320, 139)
        Me.BtnCancela.Name = "BtnCancela"
        Me.BtnCancela.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancela.TabIndex = 3
        Me.BtnCancela.Text = "Cancelar"
        Me.BtnCancela.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(180, 177)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(187, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Login"
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(401, 177)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnCancela)
        Me.Controls.Add(Me.BtnLoga)
        Me.Controls.Add(Me.TxtSenha)
        Me.Controls.Add(Me.TxtNome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtNome As System.Windows.Forms.TextBox
    Friend WithEvents TxtSenha As System.Windows.Forms.TextBox
    Friend WithEvents BtnLoga As System.Windows.Forms.Button
    Friend WithEvents BtnCancela As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
