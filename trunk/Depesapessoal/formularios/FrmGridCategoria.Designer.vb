<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGridCategoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGridCategoria))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TBSIncluir = New System.Windows.Forms.ToolStripButton()
        Me.TBSEditar = New System.Windows.Forms.ToolStripButton()
        Me.TBSExcluir = New System.Windows.Forms.ToolStripButton()
        Me.DataGridCategoria = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TBSIncluir, Me.TBSEditar, Me.TBSExcluir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1240, 55)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TBSIncluir
        '
        Me.TBSIncluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TBSIncluir.Image = CType(resources.GetObject("TBSIncluir.Image"), System.Drawing.Image)
        Me.TBSIncluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TBSIncluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TBSIncluir.Name = "TBSIncluir"
        Me.TBSIncluir.Size = New System.Drawing.Size(52, 52)
        Me.TBSIncluir.Text = "Incluir"
        '
        'TBSEditar
        '
        Me.TBSEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TBSEditar.Image = CType(resources.GetObject("TBSEditar.Image"), System.Drawing.Image)
        Me.TBSEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TBSEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TBSEditar.Name = "TBSEditar"
        Me.TBSEditar.Size = New System.Drawing.Size(52, 52)
        Me.TBSEditar.Text = "Editar"
        '
        'TBSExcluir
        '
        Me.TBSExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TBSExcluir.Image = CType(resources.GetObject("TBSExcluir.Image"), System.Drawing.Image)
        Me.TBSExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TBSExcluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TBSExcluir.Name = "TBSExcluir"
        Me.TBSExcluir.Size = New System.Drawing.Size(52, 52)
        Me.TBSExcluir.Text = "Excluir"
        '
        'DataGridCategoria
        '
        Me.DataGridCategoria.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.DataGridCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridCategoria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridCategoria.Location = New System.Drawing.Point(0, 55)
        Me.DataGridCategoria.Name = "DataGridCategoria"
        Me.DataGridCategoria.Size = New System.Drawing.Size(1240, 361)
        Me.DataGridCategoria.TabIndex = 3
        '
        'FrmGridCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1240, 416)
        Me.Controls.Add(Me.DataGridCategoria)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FrmGridCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TBSIncluir As System.Windows.Forms.ToolStripButton
    Friend WithEvents TBSEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TBSExcluir As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridCategoria As System.Windows.Forms.DataGridView
End Class
