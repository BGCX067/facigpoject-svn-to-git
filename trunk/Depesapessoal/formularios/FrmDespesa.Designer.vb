<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDespesa
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbCategoria = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtDescricao = New System.Windows.Forms.TextBox()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.TxtValorQuitado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CmbQuitado = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TxtNumeroParcela = New System.Windows.Forms.TextBox()
        Me.LblParcela = New System.Windows.Forms.Label()
        Me.DateTimePic = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Categoria"
        '
        'CmbCategoria
        '
        Me.CmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCategoria.FormattingEnabled = True
        Me.CmbCategoria.Location = New System.Drawing.Point(12, 29)
        Me.CmbCategoria.Name = "CmbCategoria"
        Me.CmbCategoria.Size = New System.Drawing.Size(121, 21)
        Me.CmbCategoria.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(136, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descrição:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(139, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Data"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Valor"
        '
        'TxtDescricao
        '
        Me.TxtDescricao.Location = New System.Drawing.Point(139, 29)
        Me.TxtDescricao.MaxLength = 45
        Me.TxtDescricao.Name = "TxtDescricao"
        Me.TxtDescricao.Size = New System.Drawing.Size(274, 20)
        Me.TxtDescricao.TabIndex = 1
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(12, 72)
        Me.TxtValor.MaxLength = 10
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(121, 20)
        Me.TxtValor.TabIndex = 3
        '
        'TxtValorQuitado
        '
        Me.TxtValorQuitado.Enabled = False
        Me.TxtValorQuitado.Location = New System.Drawing.Point(324, 72)
        Me.TxtValorQuitado.MaxLength = 10
        Me.TxtValorQuitado.Name = "TxtValorQuitado"
        Me.TxtValorQuitado.Size = New System.Drawing.Size(89, 20)
        Me.TxtValorQuitado.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(321, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Valor Total"
        '
        'CmbQuitado
        '
        Me.CmbQuitado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbQuitado.FormattingEnabled = True
        Me.CmbQuitado.Items.AddRange(New Object() {"Sim", "Não"})
        Me.CmbQuitado.Location = New System.Drawing.Point(15, 112)
        Me.CmbQuitado.Name = "CmbQuitado"
        Me.CmbQuitado.Size = New System.Drawing.Size(69, 21)
        Me.CmbQuitado.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Quitado"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(257, 133)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Salvar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(338, 133)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TxtNumeroParcela
        '
        Me.TxtNumeroParcela.Location = New System.Drawing.Point(242, 72)
        Me.TxtNumeroParcela.MaxLength = 10
        Me.TxtNumeroParcela.Name = "TxtNumeroParcela"
        Me.TxtNumeroParcela.Size = New System.Drawing.Size(76, 20)
        Me.TxtNumeroParcela.TabIndex = 5
        '
        'LblParcela
        '
        Me.LblParcela.AutoSize = True
        Me.LblParcela.Location = New System.Drawing.Point(239, 56)
        Me.LblParcela.Name = "LblParcela"
        Me.LblParcela.Size = New System.Drawing.Size(63, 13)
        Me.LblParcela.TabIndex = 14
        Me.LblParcela.Text = "Nº Parcelas"
        '
        'DateTimePic
        '
        Me.DateTimePic.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePic.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePic.Location = New System.Drawing.Point(139, 72)
        Me.DateTimePic.Name = "DateTimePic"
        Me.DateTimePic.Size = New System.Drawing.Size(98, 20)
        Me.DateTimePic.TabIndex = 4
        '
        'FrmDespesa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(418, 175)
        Me.ControlBox = False
        Me.Controls.Add(Me.DateTimePic)
        Me.Controls.Add(Me.LblParcela)
        Me.Controls.Add(Me.TxtNumeroParcela)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CmbQuitado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtValorQuitado)
        Me.Controls.Add(Me.TxtValor)
        Me.Controls.Add(Me.TxtDescricao)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbCategoria)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmDespesa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents TxtValor As System.Windows.Forms.TextBox
    Friend WithEvents TxtValorQuitado As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CmbQuitado As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TxtNumeroParcela As System.Windows.Forms.TextBox
    Friend WithEvents LblParcela As System.Windows.Forms.Label
    Friend WithEvents DateTimePic As System.Windows.Forms.DateTimePicker
End Class
