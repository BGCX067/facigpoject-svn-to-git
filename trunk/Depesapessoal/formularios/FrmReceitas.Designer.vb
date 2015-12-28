<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReceitas
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.TxtDescricao = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbCategoria = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbQuitado = New System.Windows.Forms.ComboBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.DateTimePic = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtValorQuitado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(337, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Quitado"
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(12, 80)
        Me.TxtValor.MaxLength = 10
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(121, 20)
        Me.TxtValor.TabIndex = 2
        '
        'TxtDescricao
        '
        Me.TxtDescricao.Location = New System.Drawing.Point(139, 32)
        Me.TxtDescricao.MaxLength = 45
        Me.TxtDescricao.Name = "TxtDescricao"
        Me.TxtDescricao.Size = New System.Drawing.Size(277, 20)
        Me.TxtDescricao.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Valor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(139, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Data"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(140, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Descrição"
        '
        'CmbCategoria
        '
        Me.CmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCategoria.FormattingEnabled = True
        Me.CmbCategoria.Location = New System.Drawing.Point(12, 31)
        Me.CmbCategoria.Name = "CmbCategoria"
        Me.CmbCategoria.Size = New System.Drawing.Size(121, 21)
        Me.CmbCategoria.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Categoria"
        '
        'CmbQuitado
        '
        Me.CmbQuitado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbQuitado.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CmbQuitado.FormattingEnabled = True
        Me.CmbQuitado.Items.AddRange(New Object() {"Sim", "Não"})
        Me.CmbQuitado.Location = New System.Drawing.Point(340, 80)
        Me.CmbQuitado.Name = "CmbQuitado"
        Me.CmbQuitado.Size = New System.Drawing.Size(61, 21)
        Me.CmbQuitado.TabIndex = 5
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(340, 123)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancelar.TabIndex = 7
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.Location = New System.Drawing.Point(259, 123)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.BtnSalvar.TabIndex = 6
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'DateTimePic
        '
        Me.DateTimePic.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePic.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePic.Location = New System.Drawing.Point(139, 81)
        Me.DateTimePic.Name = "DateTimePic"
        Me.DateTimePic.Size = New System.Drawing.Size(103, 20)
        Me.DateTimePic.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(242, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Valor Quitado"
        '
        'TxtValorQuitado
        '
        Me.TxtValorQuitado.Location = New System.Drawing.Point(245, 81)
        Me.TxtValorQuitado.MaxLength = 10
        Me.TxtValorQuitado.Name = "TxtValorQuitado"
        Me.TxtValorQuitado.Size = New System.Drawing.Size(89, 20)
        Me.TxtValorQuitado.TabIndex = 4
        '
        'FrmReceitas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(428, 169)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtValorQuitado)
        Me.Controls.Add(Me.DateTimePic)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnSalvar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CmbQuitado)
        Me.Controls.Add(Me.TxtValor)
        Me.Controls.Add(Me.TxtDescricao)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbCategoria)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmReceitas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtValor As System.Windows.Forms.TextBox
    Friend WithEvents TxtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbQuitado As System.Windows.Forms.ComboBox
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnSalvar As System.Windows.Forms.Button
    Friend WithEvents DateTimePic As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtValorQuitado As System.Windows.Forms.TextBox

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
