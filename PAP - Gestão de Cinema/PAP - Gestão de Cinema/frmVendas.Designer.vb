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
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.pct1 = New System.Windows.Forms.PictureBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.flpartigos = New System.Windows.Forms.FlowLayoutPanel()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.btnProduto = New System.Windows.Forms.Button()
        Me.btnInserir = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.lbl2839 = New System.Windows.Forms.Label()
        Me.rctcliente = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.lblnomefunc = New System.Windows.Forms.Label()
        Me.cmbclientes = New System.Windows.Forms.ComboBox()
        Me.btnOutro = New System.Windows.Forms.Button()
        Me.flp1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.tbc1 = New System.Windows.Forms.TabControl()
        Me.tbpSempre = New System.Windows.Forms.TabPage()
        Me.dgvSempre = New System.Windows.Forms.DataGridView()
        Me.tbpMes = New System.Windows.Forms.TabPage()
        Me.dgvMes = New System.Windows.Forms.DataGridView()
        Me.tbpSemana = New System.Windows.Forms.TabPage()
        Me.dgvSemana = New System.Windows.Forms.DataGridView()
        Me.pnlControlos = New System.Windows.Forms.Panel()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.dgvVendas = New System.Windows.Forms.DataGridView()
        Me.CtrL_MenuCine = New PAP___Gestão_de_Cinema.CTRL_MenuCine()
        Me.pnl1.SuspendLayout()
        CType(Me.pct1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flp1.SuspendLayout()
        Me.tbc1.SuspendLayout()
        Me.tbpSempre.SuspendLayout()
        CType(Me.dgvSempre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpMes.SuspendLayout()
        CType(Me.dgvMes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpSemana.SuspendLayout()
        CType(Me.dgvSemana, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlControlos.SuspendLayout()
        CType(Me.dgvVendas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.flpartigos.Location = New System.Drawing.Point(3, 112)
        Me.flpartigos.Name = "flpartigos"
        Me.flpartigos.Size = New System.Drawing.Size(314, 268)
        Me.flpartigos.TabIndex = 18
        '
        'lbl3
        '
        Me.lbl3.BackColor = System.Drawing.Color.Thistle
        Me.lbl3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.Black
        Me.lbl3.Location = New System.Drawing.Point(3, 84)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(314, 23)
        Me.lbl3.TabIndex = 19
        Me.lbl3.Text = "Artigos selecionados"
        Me.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl2.ForeColor = System.Drawing.Color.White
        Me.lbl2.Location = New System.Drawing.Point(0, 33)
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
        Me.btnProduto.Location = New System.Drawing.Point(2, 390)
        Me.btnProduto.Name = "btnProduto"
        Me.btnProduto.Size = New System.Drawing.Size(102, 22)
        Me.btnProduto.TabIndex = 25
        Me.btnProduto.Text = "Adicionar artigo"
        Me.btnProduto.UseVisualStyleBackColor = False
        '
        'btnInserir
        '
        Me.btnInserir.BackColor = System.Drawing.Color.Thistle
        Me.btnInserir.FlatAppearance.BorderSize = 0
        Me.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInserir.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.btnInserir.ForeColor = System.Drawing.Color.Black
        Me.btnInserir.Location = New System.Drawing.Point(110, 390)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Size = New System.Drawing.Size(99, 22)
        Me.btnInserir.TabIndex = 26
        Me.btnInserir.Text = "Inserir Venda"
        Me.btnInserir.UseVisualStyleBackColor = False
        '
        'btnAlterar
        '
        Me.btnAlterar.BackColor = System.Drawing.Color.Thistle
        Me.btnAlterar.FlatAppearance.BorderSize = 0
        Me.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlterar.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.btnAlterar.ForeColor = System.Drawing.Color.Black
        Me.btnAlterar.Location = New System.Drawing.Point(215, 390)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(102, 22)
        Me.btnAlterar.TabIndex = 27
        Me.btnAlterar.Text = "Alterar Venda"
        Me.btnAlterar.UseVisualStyleBackColor = False
        '
        'lbl2839
        '
        Me.lbl2839.AutoSize = True
        Me.lbl2839.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl2839.ForeColor = System.Drawing.Color.White
        Me.lbl2839.Location = New System.Drawing.Point(-1, 424)
        Me.lbl2839.Name = "lbl2839"
        Me.lbl2839.Size = New System.Drawing.Size(76, 15)
        Me.lbl2839.TabIndex = 28
        Me.lbl2839.Text = "Funcionário:"
        '
        'rctcliente
        '
        Me.rctcliente.BackColor = System.Drawing.Color.White
        Me.rctcliente.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rctcliente.BorderColor = System.Drawing.Color.White
        Me.rctcliente.CornerRadius = 2
        Me.rctcliente.Location = New System.Drawing.Point(2, 48)
        Me.rctcliente.Name = "rctcliente"
        Me.rctcliente.Size = New System.Drawing.Size(283, 25)
        '
        'lblnomefunc
        '
        Me.lblnomefunc.AutoSize = True
        Me.lblnomefunc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnomefunc.ForeColor = System.Drawing.Color.White
        Me.lblnomefunc.Location = New System.Drawing.Point(81, 424)
        Me.lblnomefunc.Name = "lblnomefunc"
        Me.lblnomefunc.Size = New System.Drawing.Size(35, 15)
        Me.lblnomefunc.TabIndex = 30
        Me.lblnomefunc.Text = "XXXX"
        '
        'cmbclientes
        '
        Me.cmbclientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbclientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbclientes.BackColor = System.Drawing.Color.White
        Me.cmbclientes.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbclientes.FormattingEnabled = True
        Me.cmbclientes.Location = New System.Drawing.Point(14, 50)
        Me.cmbclientes.Name = "cmbclientes"
        Me.cmbclientes.Size = New System.Drawing.Size(259, 22)
        Me.cmbclientes.TabIndex = 45
        Me.cmbclientes.Tag = "cliente"
        '
        'btnOutro
        '
        Me.btnOutro.BackColor = System.Drawing.Color.Thistle
        Me.btnOutro.BackgroundImage = CType(resources.GetObject("btnOutro.BackgroundImage"), System.Drawing.Image)
        Me.btnOutro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnOutro.FlatAppearance.BorderSize = 0
        Me.btnOutro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOutro.ForeColor = System.Drawing.Color.Black
        Me.btnOutro.Location = New System.Drawing.Point(291, 48)
        Me.btnOutro.Name = "btnOutro"
        Me.btnOutro.Size = New System.Drawing.Size(26, 26)
        Me.btnOutro.TabIndex = 46
        Me.btnOutro.UseVisualStyleBackColor = False
        '
        'flp1
        '
        Me.flp1.Controls.Add(Me.tbc1)
        Me.flp1.Controls.Add(Me.pnlControlos)
        Me.flp1.Location = New System.Drawing.Point(74, 123)
        Me.flp1.Name = "flp1"
        Me.flp1.Size = New System.Drawing.Size(769, 450)
        Me.flp1.TabIndex = 52
        '
        'tbc1
        '
        Me.tbc1.Controls.Add(Me.tbpSempre)
        Me.tbc1.Controls.Add(Me.tbpMes)
        Me.tbc1.Controls.Add(Me.tbpSemana)
        Me.tbc1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbc1.Location = New System.Drawing.Point(3, 3)
        Me.tbc1.Name = "tbc1"
        Me.tbc1.SelectedIndex = 0
        Me.tbc1.Size = New System.Drawing.Size(429, 439)
        Me.tbc1.TabIndex = 53
        '
        'tbpSempre
        '
        Me.tbpSempre.BackColor = System.Drawing.Color.Silver
        Me.tbpSempre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpSempre.Controls.Add(Me.dgvSempre)
        Me.tbpSempre.Location = New System.Drawing.Point(4, 23)
        Me.tbpSempre.Name = "tbpSempre"
        Me.tbpSempre.Size = New System.Drawing.Size(421, 412)
        Me.tbpSempre.TabIndex = 1
        Me.tbpSempre.Text = "Desde sempre"
        '
        'dgvSempre
        '
        Me.dgvSempre.AllowUserToAddRows = False
        Me.dgvSempre.AllowUserToDeleteRows = False
        Me.dgvSempre.AllowUserToResizeRows = False
        Me.dgvSempre.BackgroundColor = System.Drawing.Color.DimGray
        Me.dgvSempre.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSempre.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle25
        Me.dgvSempre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSempre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSempre.Location = New System.Drawing.Point(0, 0)
        Me.dgvSempre.MultiSelect = False
        Me.dgvSempre.Name = "dgvSempre"
        Me.dgvSempre.ReadOnly = True
        Me.dgvSempre.RowHeadersVisible = False
        Me.dgvSempre.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvSempre.Size = New System.Drawing.Size(419, 410)
        Me.dgvSempre.TabIndex = 53
        '
        'tbpMes
        '
        Me.tbpMes.BackColor = System.Drawing.Color.White
        Me.tbpMes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpMes.Controls.Add(Me.dgvMes)
        Me.tbpMes.Location = New System.Drawing.Point(4, 23)
        Me.tbpMes.Name = "tbpMes"
        Me.tbpMes.Size = New System.Drawing.Size(421, 412)
        Me.tbpMes.TabIndex = 2
        Me.tbpMes.Text = "Deste mês"
        '
        'dgvMes
        '
        Me.dgvMes.AllowUserToAddRows = False
        Me.dgvMes.AllowUserToDeleteRows = False
        Me.dgvMes.AllowUserToResizeRows = False
        Me.dgvMes.BackgroundColor = System.Drawing.Color.DimGray
        Me.dgvMes.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle26
        Me.dgvMes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvMes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMes.Location = New System.Drawing.Point(0, 0)
        Me.dgvMes.MultiSelect = False
        Me.dgvMes.Name = "dgvMes"
        Me.dgvMes.ReadOnly = True
        Me.dgvMes.RowHeadersVisible = False
        Me.dgvMes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvMes.Size = New System.Drawing.Size(419, 410)
        Me.dgvMes.TabIndex = 54
        '
        'tbpSemana
        '
        Me.tbpSemana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpSemana.Controls.Add(Me.dgvSemana)
        Me.tbpSemana.Location = New System.Drawing.Point(4, 23)
        Me.tbpSemana.Name = "tbpSemana"
        Me.tbpSemana.Size = New System.Drawing.Size(421, 412)
        Me.tbpSemana.TabIndex = 3
        Me.tbpSemana.Text = "Desta semana"
        Me.tbpSemana.UseVisualStyleBackColor = True
        '
        'dgvSemana
        '
        Me.dgvSemana.AllowUserToAddRows = False
        Me.dgvSemana.AllowUserToDeleteRows = False
        Me.dgvSemana.AllowUserToResizeRows = False
        Me.dgvSemana.BackgroundColor = System.Drawing.Color.DimGray
        Me.dgvSemana.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSemana.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle27
        Me.dgvSemana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvSemana.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSemana.Location = New System.Drawing.Point(0, 0)
        Me.dgvSemana.MultiSelect = False
        Me.dgvSemana.Name = "dgvSemana"
        Me.dgvSemana.ReadOnly = True
        Me.dgvSemana.RowHeadersVisible = False
        Me.dgvSemana.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvSemana.Size = New System.Drawing.Size(419, 410)
        Me.dgvSemana.TabIndex = 54
        '
        'pnlControlos
        '
        Me.pnlControlos.Controls.Add(Me.btnNovo)
        Me.pnlControlos.Controls.Add(Me.lbl2839)
        Me.pnlControlos.Controls.Add(Me.lblnomefunc)
        Me.pnlControlos.Controls.Add(Me.lbl2)
        Me.pnlControlos.Controls.Add(Me.flpartigos)
        Me.pnlControlos.Controls.Add(Me.lbl3)
        Me.pnlControlos.Controls.Add(Me.btnOutro)
        Me.pnlControlos.Controls.Add(Me.btnProduto)
        Me.pnlControlos.Controls.Add(Me.cmbclientes)
        Me.pnlControlos.Controls.Add(Me.btnInserir)
        Me.pnlControlos.Controls.Add(Me.btnAlterar)
        Me.pnlControlos.Controls.Add(Me.ShapeContainer2)
        Me.pnlControlos.Location = New System.Drawing.Point(438, 3)
        Me.pnlControlos.Name = "pnlControlos"
        Me.pnlControlos.Size = New System.Drawing.Size(327, 447)
        Me.pnlControlos.TabIndex = 43
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.Color.Thistle
        Me.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnNovo.FlatAppearance.BorderSize = 0
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.ForeColor = System.Drawing.Color.Black
        Me.btnNovo.Location = New System.Drawing.Point(1, 0)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(316, 26)
        Me.btnNovo.TabIndex = 48
        Me.btnNovo.Text = "Nova Venda"
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.rctcliente})
        Me.ShapeContainer2.Size = New System.Drawing.Size(327, 447)
        Me.ShapeContainer2.TabIndex = 47
        Me.ShapeContainer2.TabStop = False
        '
        'dgvVendas
        '
        Me.dgvVendas.AllowUserToAddRows = False
        Me.dgvVendas.AllowUserToDeleteRows = False
        Me.dgvVendas.AllowUserToResizeRows = False
        Me.dgvVendas.BackgroundColor = System.Drawing.Color.DimGray
        Me.dgvVendas.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVendas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle28
        Me.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvVendas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvVendas.Location = New System.Drawing.Point(0, 0)
        Me.dgvVendas.MultiSelect = False
        Me.dgvVendas.Name = "dgvVendas"
        Me.dgvVendas.ReadOnly = True
        Me.dgvVendas.RowHeadersVisible = False
        Me.dgvVendas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvVendas.Size = New System.Drawing.Size(419, 410)
        Me.dgvVendas.TabIndex = 53
        '
        'CtrL_MenuCine
        '
        Me.CtrL_MenuCine.Dock = System.Windows.Forms.DockStyle.Left
        Me.CtrL_MenuCine.Location = New System.Drawing.Point(0, 0)
        Me.CtrL_MenuCine.Name = "CtrL_MenuCine"
        Me.CtrL_MenuCine.Size = New System.Drawing.Size(49, 625)
        Me.CtrL_MenuCine.TabIndex = 0
        '
        'frmVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(859, 625)
        Me.Controls.Add(Me.CtrL_MenuCine)
        Me.Controls.Add(Me.flp1)
        Me.Controls.Add(Me.pnl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vendas"
        Me.pnl1.ResumeLayout(False)
        CType(Me.pct1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flp1.ResumeLayout(False)
        Me.tbc1.ResumeLayout(False)
        Me.tbpSempre.ResumeLayout(False)
        CType(Me.dgvSempre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpMes.ResumeLayout(False)
        CType(Me.dgvMes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpSemana.ResumeLayout(False)
        CType(Me.dgvSemana, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlControlos.ResumeLayout(False)
        Me.pnlControlos.PerformLayout()
        CType(Me.dgvVendas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CtrL_MenuCine As PAP___Gestão_de_Cinema.CTRL_MenuCine
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents flpartigos As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents btnProduto As System.Windows.Forms.Button
    Friend WithEvents btnInserir As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents pct1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl2839 As System.Windows.Forms.Label
    Friend WithEvents rctcliente As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblnomefunc As System.Windows.Forms.Label
    Friend WithEvents cmbclientes As System.Windows.Forms.ComboBox
    Friend WithEvents btnOutro As System.Windows.Forms.Button
    Friend WithEvents flp1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents pnlControlos As System.Windows.Forms.Panel
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents dgvSempre As System.Windows.Forms.DataGridView
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents tbc1 As System.Windows.Forms.TabControl
    Friend WithEvents tbpSempre As System.Windows.Forms.TabPage
    Friend WithEvents tbpMes As System.Windows.Forms.TabPage
    Friend WithEvents tbpSemana As System.Windows.Forms.TabPage
    Friend WithEvents dgvMes As System.Windows.Forms.DataGridView
    Friend WithEvents dgvSemana As System.Windows.Forms.DataGridView
    Friend WithEvents dgvVendas As System.Windows.Forms.DataGridView
End Class
