<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVendas))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.pct1 = New System.Windows.Forms.PictureBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.flpartigos = New System.Windows.Forms.FlowLayoutPanel()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.btnProduto = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CtrL_MenuCine = New PAP___Gestão_de_Cinema.CTRL_MenuCine()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rctIII = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmblocalidade = New System.Windows.Forms.ComboBox()
        Me.btnOutro = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl1.SuspendLayout()
        CType(Me.pct1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(74, 134)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(436, 407)
        Me.DataGridView1.TabIndex = 17
        '
        'pnl1
        '
        Me.pnl1.BackColor = System.Drawing.Color.Thistle
        Me.pnl1.Controls.Add(Me.pct1)
        Me.pnl1.Controls.Add(Me.lbl1)
        Me.pnl1.Location = New System.Drawing.Point(74, 24)
        Me.pnl1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(757, 93)
        Me.pnl1.TabIndex = 16
        '
        'pct1
        '
        Me.pct1.BackgroundImage = CType(resources.GetObject("pct1.BackgroundImage"), System.Drawing.Image)
        Me.pct1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pct1.Location = New System.Drawing.Point(3, 5)
        Me.pct1.Name = "pct1"
        Me.pct1.Size = New System.Drawing.Size(88, 88)
        Me.pct1.TabIndex = 5
        Me.pct1.TabStop = False
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.lbl1.ForeColor = System.Drawing.Color.Black
        Me.lbl1.Location = New System.Drawing.Point(96, 22)
        Me.lbl1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(661, 52)
        Me.lbl1.TabIndex = 4
        Me.lbl1.Text = "Vendas"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'flpartigos
        '
        Me.flpartigos.AutoScroll = True
        Me.flpartigos.Location = New System.Drawing.Point(517, 213)
        Me.flpartigos.Name = "flpartigos"
        Me.flpartigos.Size = New System.Drawing.Size(314, 268)
        Me.flpartigos.TabIndex = 18
        '
        'lbl3
        '
        Me.lbl3.BackColor = System.Drawing.Color.Thistle
        Me.lbl3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.Black
        Me.lbl3.Location = New System.Drawing.Point(517, 185)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(314, 23)
        Me.lbl3.TabIndex = 19
        Me.lbl3.Text = "Produtos selecionados"
        Me.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl2.ForeColor = System.Drawing.Color.White
        Me.lbl2.Location = New System.Drawing.Point(514, 134)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(49, 15)
        Me.lbl2.TabIndex = 20
        Me.lbl2.Text = "Cliente:"
        '
        'btnProduto
        '
        Me.btnProduto.BackColor = System.Drawing.Color.Thistle
        Me.btnProduto.FlatAppearance.BorderSize = 0
        Me.btnProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduto.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.btnProduto.ForeColor = System.Drawing.Color.Black
        Me.btnProduto.Location = New System.Drawing.Point(516, 491)
        Me.btnProduto.Name = "btnProduto"
        Me.btnProduto.Size = New System.Drawing.Size(102, 22)
        Me.btnProduto.TabIndex = 25
        Me.btnProduto.Text = "Adicionar produto"
        Me.btnProduto.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Thistle
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(624, 491)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 22)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Inserir Venda"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Thistle
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(729, 491)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 22)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Alterar Venda"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'CtrL_MenuCine
        '
        Me.CtrL_MenuCine.Dock = System.Windows.Forms.DockStyle.Left
        Me.CtrL_MenuCine.Location = New System.Drawing.Point(0, 0)
        Me.CtrL_MenuCine.Name = "CtrL_MenuCine"
        Me.CtrL_MenuCine.Size = New System.Drawing.Size(49, 618)
        Me.CtrL_MenuCine.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(513, 526)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Funcionario:"
        '
        'rctIII
        '
        Me.rctIII.BackColor = System.Drawing.Color.White
        Me.rctIII.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rctIII.BorderColor = System.Drawing.Color.White
        Me.rctIII.CornerRadius = 2
        Me.rctIII.Location = New System.Drawing.Point(516, 149)
        Me.rctIII.Name = "rctIII"
        Me.rctIII.Size = New System.Drawing.Size(259, 25)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.rctIII})
        Me.ShapeContainer1.Size = New System.Drawing.Size(855, 618)
        Me.ShapeContainer1.TabIndex = 29
        Me.ShapeContainer1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(595, 526)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 15)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "XXXX"
        '
        'cmblocalidade
        '
        Me.cmblocalidade.BackColor = System.Drawing.Color.White
        Me.cmblocalidade.FormattingEnabled = True
        Me.cmblocalidade.Location = New System.Drawing.Point(528, 152)
        Me.cmblocalidade.Name = "cmblocalidade"
        Me.cmblocalidade.Size = New System.Drawing.Size(235, 21)
        Me.cmblocalidade.TabIndex = 45
        '
        'btnOutro
        '
        Me.btnOutro.BackColor = System.Drawing.Color.Thistle
        Me.btnOutro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnOutro.FlatAppearance.BorderSize = 0
        Me.btnOutro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOutro.ForeColor = System.Drawing.Color.Black
        Me.btnOutro.Location = New System.Drawing.Point(783, 149)
        Me.btnOutro.Name = "btnOutro"
        Me.btnOutro.Size = New System.Drawing.Size(48, 26)
        Me.btnOutro.TabIndex = 46
        Me.btnOutro.Text = "Outro"
        Me.btnOutro.UseVisualStyleBackColor = False
        '
        'frmVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(855, 618)
        Me.Controls.Add(Me.btnOutro)
        Me.Controls.Add(Me.cmblocalidade)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnProduto)
        Me.Controls.Add(Me.CtrL_MenuCine)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.flpartigos)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.pnl1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vendas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl1.ResumeLayout(False)
        CType(Me.pct1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CtrL_MenuCine As PAP___Gestão_de_Cinema.CTRL_MenuCine
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents flpartigos As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents btnProduto As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents pct1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rctIII As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmblocalidade As System.Windows.Forms.ComboBox
    Friend WithEvents btnOutro As System.Windows.Forms.Button
End Class
