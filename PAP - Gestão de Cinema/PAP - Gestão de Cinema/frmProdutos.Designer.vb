<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProdutos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProdutos))
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.pct1 = New System.Windows.Forms.PictureBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.flp1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.tbc1 = New System.Windows.Forms.TabControl()
        Me.tbpAtivado = New System.Windows.Forms.TabPage()
        Me.flpProdAtiv = New System.Windows.Forms.FlowLayoutPanel()
        Me.tbpDesativado = New System.Windows.Forms.TabPage()
        Me.flpProdDesa = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlControlos = New System.Windows.Forms.Panel()
        Me.chkImagem = New System.Windows.Forms.CheckBox()
        Me.pctImgLoc = New System.Windows.Forms.PictureBox()
        Me.lblImgNome = New System.Windows.Forms.Label()
        Me.lbl90 = New System.Windows.Forms.Label()
        Me.chkGenero = New System.Windows.Forms.CheckBox()
        Me.btnEscolher = New System.Windows.Forms.Button()
        Me.chkStock = New System.Windows.Forms.CheckBox()
        Me.chkPreco = New System.Windows.Forms.CheckBox()
        Me.pnlProduto = New System.Windows.Forms.Panel()
        Me.cmbGeneros = New System.Windows.Forms.ComboBox()
        Me.nmrStock = New System.Windows.Forms.NumericUpDown()
        Me.nmrPreco = New System.Windows.Forms.NumericUpDown()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblGenero = New System.Windows.Forms.Label()
        Me.lblPreco = New System.Windows.Forms.Label()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.btnImagem = New System.Windows.Forms.Button()
        Me.btnDesativar = New System.Windows.Forms.Button()
        Me.btnAtivar = New System.Windows.Forms.Button()
        Me.pnlProibicao = New System.Windows.Forms.Panel()
        Me.pct3 = New System.Windows.Forms.PictureBox()
        Me.lblT = New System.Windows.Forms.Label()
        Me.lblHammer = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkNome = New System.Windows.Forms.CheckBox()
        Me.btnProcurar = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnInserir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ofdImagem = New System.Windows.Forms.OpenFileDialog()
        Me.CtrL_MenuCine = New PAP___Gestão_de_Cinema.CTRL_MenuCine()
        Me.pnl1.SuspendLayout()
        CType(Me.pct1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flp1.SuspendLayout()
        Me.tbc1.SuspendLayout()
        Me.tbpAtivado.SuspendLayout()
        Me.tbpDesativado.SuspendLayout()
        Me.pnlControlos.SuspendLayout()
        CType(Me.pctImgLoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlProduto.SuspendLayout()
        CType(Me.nmrStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmrPreco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlProibicao.SuspendLayout()
        CType(Me.pct3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnl1.Controls.Add(Me.pct1)
        Me.pnl1.Controls.Add(Me.lbl1)
        Me.pnl1.Location = New System.Drawing.Point(74, 24)
        Me.pnl1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(682, 93)
        Me.pnl1.TabIndex = 5
        '
        'pct1
        '
        Me.pct1.BackgroundImage = CType(resources.GetObject("pct1.BackgroundImage"), System.Drawing.Image)
        Me.pct1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pct1.Location = New System.Drawing.Point(5, 5)
        Me.pct1.Name = "pct1"
        Me.pct1.Size = New System.Drawing.Size(88, 88)
        Me.pct1.TabIndex = 43
        Me.pct1.TabStop = False
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.lbl1.ForeColor = System.Drawing.Color.Black
        Me.lbl1.Location = New System.Drawing.Point(96, 21)
        Me.lbl1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(586, 55)
        Me.lbl1.TabIndex = 4
        Me.lbl1.Text = "Produtos"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'flp1
        '
        Me.flp1.Controls.Add(Me.tbc1)
        Me.flp1.Controls.Add(Me.pnlControlos)
        Me.flp1.Location = New System.Drawing.Point(74, 123)
        Me.flp1.Name = "flp1"
        Me.flp1.Size = New System.Drawing.Size(708, 525)
        Me.flp1.TabIndex = 51
        '
        'tbc1
        '
        Me.tbc1.Controls.Add(Me.tbpAtivado)
        Me.tbc1.Controls.Add(Me.tbpDesativado)
        Me.tbc1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbc1.Location = New System.Drawing.Point(3, 3)
        Me.tbc1.Name = "tbc1"
        Me.tbc1.SelectedIndex = 0
        Me.tbc1.Size = New System.Drawing.Size(391, 522)
        Me.tbc1.TabIndex = 52
        '
        'tbpAtivado
        '
        Me.tbpAtivado.BackColor = System.Drawing.Color.Silver
        Me.tbpAtivado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpAtivado.Controls.Add(Me.flpProdAtiv)
        Me.tbpAtivado.Location = New System.Drawing.Point(4, 23)
        Me.tbpAtivado.Name = "tbpAtivado"
        Me.tbpAtivado.Size = New System.Drawing.Size(383, 495)
        Me.tbpAtivado.TabIndex = 1
        Me.tbpAtivado.Text = "produtos ativados"
        '
        'flpProdAtiv
        '
        Me.flpProdAtiv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpProdAtiv.Location = New System.Drawing.Point(0, 0)
        Me.flpProdAtiv.Name = "flpProdAtiv"
        Me.flpProdAtiv.Size = New System.Drawing.Size(381, 493)
        Me.flpProdAtiv.TabIndex = 8
        '
        'tbpDesativado
        '
        Me.tbpDesativado.BackColor = System.Drawing.Color.Silver
        Me.tbpDesativado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpDesativado.Controls.Add(Me.flpProdDesa)
        Me.tbpDesativado.Location = New System.Drawing.Point(4, 23)
        Me.tbpDesativado.Name = "tbpDesativado"
        Me.tbpDesativado.Size = New System.Drawing.Size(383, 495)
        Me.tbpDesativado.TabIndex = 2
        Me.tbpDesativado.Text = "Produtos desativados"
        '
        'flpProdDesa
        '
        Me.flpProdDesa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpProdDesa.Location = New System.Drawing.Point(0, 0)
        Me.flpProdDesa.Name = "flpProdDesa"
        Me.flpProdDesa.Size = New System.Drawing.Size(381, 493)
        Me.flpProdDesa.TabIndex = 7
        '
        'pnlControlos
        '
        Me.pnlControlos.Controls.Add(Me.chkImagem)
        Me.pnlControlos.Controls.Add(Me.pctImgLoc)
        Me.pnlControlos.Controls.Add(Me.lblImgNome)
        Me.pnlControlos.Controls.Add(Me.lbl90)
        Me.pnlControlos.Controls.Add(Me.chkGenero)
        Me.pnlControlos.Controls.Add(Me.btnEscolher)
        Me.pnlControlos.Controls.Add(Me.chkStock)
        Me.pnlControlos.Controls.Add(Me.chkPreco)
        Me.pnlControlos.Controls.Add(Me.pnlProduto)
        Me.pnlControlos.Controls.Add(Me.btnDesativar)
        Me.pnlControlos.Controls.Add(Me.btnAtivar)
        Me.pnlControlos.Controls.Add(Me.pnlProibicao)
        Me.pnlControlos.Controls.Add(Me.chkNome)
        Me.pnlControlos.Controls.Add(Me.btnProcurar)
        Me.pnlControlos.Controls.Add(Me.btnAlterar)
        Me.pnlControlos.Controls.Add(Me.btnInserir)
        Me.pnlControlos.Location = New System.Drawing.Point(400, 3)
        Me.pnlControlos.Name = "pnlControlos"
        Me.pnlControlos.Size = New System.Drawing.Size(284, 580)
        Me.pnlControlos.TabIndex = 43
        '
        'chkImagem
        '
        Me.chkImagem.AutoSize = True
        Me.chkImagem.Location = New System.Drawing.Point(253, 25)
        Me.chkImagem.Name = "chkImagem"
        Me.chkImagem.Size = New System.Drawing.Size(15, 14)
        Me.chkImagem.TabIndex = 67
        Me.chkImagem.UseVisualStyleBackColor = True
        '
        'pctImgLoc
        '
        Me.pctImgLoc.BackgroundImage = CType(resources.GetObject("pctImgLoc.BackgroundImage"), System.Drawing.Image)
        Me.pctImgLoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pctImgLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pctImgLoc.Image = CType(resources.GetObject("pctImgLoc.Image"), System.Drawing.Image)
        Me.pctImgLoc.Location = New System.Drawing.Point(8, 9)
        Me.pctImgLoc.Name = "pctImgLoc"
        Me.pctImgLoc.Size = New System.Drawing.Size(74, 56)
        Me.pctImgLoc.TabIndex = 66
        Me.pctImgLoc.TabStop = False
        '
        'lblImgNome
        '
        Me.lblImgNome.AutoEllipsis = True
        Me.lblImgNome.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImgNome.ForeColor = System.Drawing.Color.White
        Me.lblImgNome.Location = New System.Drawing.Point(88, 24)
        Me.lblImgNome.Name = "lblImgNome"
        Me.lblImgNome.Size = New System.Drawing.Size(157, 15)
        Me.lblImgNome.TabIndex = 65
        Me.lblImgNome.Text = "---"
        '
        'lbl90
        '
        Me.lbl90.AutoSize = True
        Me.lbl90.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl90.ForeColor = System.Drawing.Color.White
        Me.lbl90.Location = New System.Drawing.Point(88, 9)
        Me.lbl90.Name = "lbl90"
        Me.lbl90.Size = New System.Drawing.Size(106, 15)
        Me.lbl90.TabIndex = 61
        Me.lbl90.Text = "Nome do ficheiro:"
        '
        'chkGenero
        '
        Me.chkGenero.AutoSize = True
        Me.chkGenero.Location = New System.Drawing.Point(43, 315)
        Me.chkGenero.Name = "chkGenero"
        Me.chkGenero.Size = New System.Drawing.Size(15, 14)
        Me.chkGenero.TabIndex = 64
        Me.chkGenero.UseVisualStyleBackColor = True
        '
        'btnEscolher
        '
        Me.btnEscolher.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEscolher.FlatAppearance.BorderSize = 0
        Me.btnEscolher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEscolher.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEscolher.ForeColor = System.Drawing.Color.Black
        Me.btnEscolher.Location = New System.Drawing.Point(88, 42)
        Me.btnEscolher.Name = "btnEscolher"
        Me.btnEscolher.Size = New System.Drawing.Size(157, 23)
        Me.btnEscolher.TabIndex = 51
        Me.btnEscolher.Text = "Escolher imagem"
        Me.btnEscolher.UseVisualStyleBackColor = False
        '
        'chkStock
        '
        Me.chkStock.AutoSize = True
        Me.chkStock.Location = New System.Drawing.Point(255, 285)
        Me.chkStock.Name = "chkStock"
        Me.chkStock.Size = New System.Drawing.Size(15, 14)
        Me.chkStock.TabIndex = 63
        Me.chkStock.UseVisualStyleBackColor = True
        '
        'chkPreco
        '
        Me.chkPreco.AutoSize = True
        Me.chkPreco.Location = New System.Drawing.Point(255, 150)
        Me.chkPreco.Name = "chkPreco"
        Me.chkPreco.Size = New System.Drawing.Size(15, 14)
        Me.chkPreco.TabIndex = 62
        Me.chkPreco.UseVisualStyleBackColor = True
        '
        'pnlProduto
        '
        Me.pnlProduto.BackColor = System.Drawing.Color.Black
        Me.pnlProduto.Controls.Add(Me.cmbGeneros)
        Me.pnlProduto.Controls.Add(Me.nmrStock)
        Me.pnlProduto.Controls.Add(Me.nmrPreco)
        Me.pnlProduto.Controls.Add(Me.txtNome)
        Me.pnlProduto.Controls.Add(Me.lblNome)
        Me.pnlProduto.Controls.Add(Me.lblGenero)
        Me.pnlProduto.Controls.Add(Me.lblPreco)
        Me.pnlProduto.Controls.Add(Me.lblStock)
        Me.pnlProduto.Controls.Add(Me.btnImagem)
        Me.pnlProduto.Location = New System.Drawing.Point(37, 86)
        Me.pnlProduto.Name = "pnlProduto"
        Me.pnlProduto.Size = New System.Drawing.Size(210, 220)
        Me.pnlProduto.TabIndex = 59
        '
        'cmbGeneros
        '
        Me.cmbGeneros.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmbGeneros.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGeneros.FormattingEnabled = True
        Me.cmbGeneros.Location = New System.Drawing.Point(0, 119)
        Me.cmbGeneros.Name = "cmbGeneros"
        Me.cmbGeneros.Size = New System.Drawing.Size(143, 31)
        Me.cmbGeneros.TabIndex = 61
        Me.cmbGeneros.Tag = "género"
        Me.cmbGeneros.Visible = False
        '
        'nmrStock
        '
        Me.nmrStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.nmrStock.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nmrStock.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nmrStock.Location = New System.Drawing.Point(125, 188)
        Me.nmrStock.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.nmrStock.Name = "nmrStock"
        Me.nmrStock.Size = New System.Drawing.Size(83, 30)
        Me.nmrStock.TabIndex = 65
        Me.nmrStock.Tag = "stock"
        Me.nmrStock.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.nmrStock.Visible = False
        '
        'nmrPreco
        '
        Me.nmrPreco.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.nmrPreco.DecimalPlaces = 2
        Me.nmrPreco.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nmrPreco.Increment = New Decimal(New Integer() {10, 0, 0, 131072})
        Me.nmrPreco.Location = New System.Drawing.Point(125, 57)
        Me.nmrPreco.Maximum = New Decimal(New Integer() {9999, 0, 0, 131072})
        Me.nmrPreco.Name = "nmrPreco"
        Me.nmrPreco.Size = New System.Drawing.Size(83, 30)
        Me.nmrPreco.TabIndex = 62
        Me.nmrPreco.Tag = "preço"
        Me.nmrPreco.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.nmrPreco.Visible = False
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtNome.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.Location = New System.Drawing.Point(4, 12)
        Me.txtNome.MaxLength = 25
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(202, 30)
        Me.txtNome.TabIndex = 61
        Me.txtNome.Tag = "nome"
        Me.txtNome.Visible = False
        '
        'lblNome
        '
        Me.lblNome.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblNome.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.ForeColor = System.Drawing.Color.Black
        Me.lblNome.Location = New System.Drawing.Point(0, 0)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(210, 52)
        Me.lblNome.TabIndex = 59
        Me.lblNome.Text = "Nome do Produto"
        Me.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGenero
        '
        Me.lblGenero.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.lblGenero.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenero.Location = New System.Drawing.Point(2, 57)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(23, 161)
        Me.lblGenero.TabIndex = 52
        Me.lblGenero.Text = "Géneros"
        '
        'lblPreco
        '
        Me.lblPreco.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblPreco.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreco.ForeColor = System.Drawing.Color.Black
        Me.lblPreco.Location = New System.Drawing.Point(125, 57)
        Me.lblPreco.Name = "lblPreco"
        Me.lblPreco.Size = New System.Drawing.Size(83, 25)
        Me.lblPreco.TabIndex = 54
        Me.lblPreco.Text = "Preço"
        '
        'lblStock
        '
        Me.lblStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblStock.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock.ForeColor = System.Drawing.Color.Black
        Me.lblStock.Location = New System.Drawing.Point(144, 191)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(64, 27)
        Me.lblStock.TabIndex = 53
        Me.lblStock.Text = "Stock"
        '
        'btnImagem
        '
        Me.btnImagem.BackColor = System.Drawing.Color.White
        Me.btnImagem.BackgroundImage = CType(resources.GetObject("btnImagem.BackgroundImage"), System.Drawing.Image)
        Me.btnImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnImagem.FlatAppearance.BorderSize = 0
        Me.btnImagem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.btnImagem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImagem.Location = New System.Drawing.Point(0, 55)
        Me.btnImagem.Name = "btnImagem"
        Me.btnImagem.Size = New System.Drawing.Size(210, 165)
        Me.btnImagem.TabIndex = 58
        Me.btnImagem.UseVisualStyleBackColor = False
        '
        'btnDesativar
        '
        Me.btnDesativar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDesativar.FlatAppearance.BorderSize = 0
        Me.btnDesativar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDesativar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesativar.ForeColor = System.Drawing.Color.Black
        Me.btnDesativar.Location = New System.Drawing.Point(8, 373)
        Me.btnDesativar.Name = "btnDesativar"
        Me.btnDesativar.Size = New System.Drawing.Size(260, 22)
        Me.btnDesativar.TabIndex = 43
        Me.btnDesativar.Text = "Desativar Cliente"
        Me.btnDesativar.UseVisualStyleBackColor = False
        '
        'btnAtivar
        '
        Me.btnAtivar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAtivar.FlatAppearance.BorderSize = 0
        Me.btnAtivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtivar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtivar.ForeColor = System.Drawing.Color.Black
        Me.btnAtivar.Location = New System.Drawing.Point(8, 373)
        Me.btnAtivar.Name = "btnAtivar"
        Me.btnAtivar.Size = New System.Drawing.Size(260, 22)
        Me.btnAtivar.TabIndex = 48
        Me.btnAtivar.Text = "Ativar Cliente"
        Me.btnAtivar.UseVisualStyleBackColor = False
        '
        'pnlProibicao
        '
        Me.pnlProibicao.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnlProibicao.Controls.Add(Me.pct3)
        Me.pnlProibicao.Controls.Add(Me.lblT)
        Me.pnlProibicao.Controls.Add(Me.lblHammer)
        Me.pnlProibicao.Controls.Add(Me.Label1)
        Me.pnlProibicao.Location = New System.Drawing.Point(291, 3)
        Me.pnlProibicao.Name = "pnlProibicao"
        Me.pnlProibicao.Size = New System.Drawing.Size(241, 365)
        Me.pnlProibicao.TabIndex = 48
        Me.pnlProibicao.Visible = False
        '
        'pct3
        '
        Me.pct3.BackColor = System.Drawing.Color.Transparent
        Me.pct3.BackgroundImage = CType(resources.GetObject("pct3.BackgroundImage"), System.Drawing.Image)
        Me.pct3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pct3.Location = New System.Drawing.Point(0, 340)
        Me.pct3.Name = "pct3"
        Me.pct3.Size = New System.Drawing.Size(30, 28)
        Me.pct3.TabIndex = 54
        Me.pct3.TabStop = False
        '
        'lblT
        '
        Me.lblT.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblT.Location = New System.Drawing.Point(10, 108)
        Me.lblT.Name = "lblT"
        Me.lblT.Size = New System.Drawing.Size(219, 140)
        Me.lblT.TabIndex = 51
        Me.lblT.Text = "Só pode realizar ações enquanto estiver na aba dos registos ativados"
        Me.lblT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHammer
        '
        Me.lblHammer.AutoSize = True
        Me.lblHammer.BackColor = System.Drawing.Color.Transparent
        Me.lblHammer.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHammer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHammer.Location = New System.Drawing.Point(70, 29)
        Me.lblHammer.Name = "lblHammer"
        Me.lblHammer.Size = New System.Drawing.Size(62, 91)
        Me.lblHammer.TabIndex = 0
        Me.lblHammer.Text = "🛠"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 150.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(67, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 226)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "🛠"
        '
        'chkNome
        '
        Me.chkNome.AutoSize = True
        Me.chkNome.Location = New System.Drawing.Point(255, 106)
        Me.chkNome.Name = "chkNome"
        Me.chkNome.Size = New System.Drawing.Size(15, 14)
        Me.chkNome.TabIndex = 22
        Me.chkNome.UseVisualStyleBackColor = True
        '
        'btnProcurar
        '
        Me.btnProcurar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnProcurar.FlatAppearance.BorderSize = 0
        Me.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcurar.ForeColor = System.Drawing.Color.Black
        Me.btnProcurar.Location = New System.Drawing.Point(99, 345)
        Me.btnProcurar.Name = "btnProcurar"
        Me.btnProcurar.Size = New System.Drawing.Size(79, 22)
        Me.btnProcurar.TabIndex = 40
        Me.btnProcurar.Text = "Procurar"
        Me.btnProcurar.UseVisualStyleBackColor = False
        '
        'btnAlterar
        '
        Me.btnAlterar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAlterar.FlatAppearance.BorderSize = 0
        Me.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlterar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlterar.ForeColor = System.Drawing.Color.Black
        Me.btnAlterar.Location = New System.Drawing.Point(184, 345)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(84, 22)
        Me.btnAlterar.TabIndex = 41
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = False
        '
        'btnInserir
        '
        Me.btnInserir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnInserir.FlatAppearance.BorderSize = 0
        Me.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInserir.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInserir.ForeColor = System.Drawing.Color.Black
        Me.btnInserir.Location = New System.Drawing.Point(9, 345)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Size = New System.Drawing.Size(84, 22)
        Me.btnInserir.TabIndex = 39
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(55, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(132, 134)
        Me.Panel1.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 33)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Nome do Produto"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(79, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 16)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Preço"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 98)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Géneros"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(91, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 17)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "stock"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(0, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 100)
        Me.Button1.TabIndex = 58
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ofdImagem
        '
        Me.ofdImagem.Tag = "imagem"
        Me.ofdImagem.Title = "Escolha uma imagem para um produto"
        '
        'CtrL_MenuCine
        '
        Me.CtrL_MenuCine.Dock = System.Windows.Forms.DockStyle.Left
        Me.CtrL_MenuCine.Location = New System.Drawing.Point(0, 0)
        Me.CtrL_MenuCine.Name = "CtrL_MenuCine"
        Me.CtrL_MenuCine.Size = New System.Drawing.Size(49, 666)
        Me.CtrL_MenuCine.TabIndex = 0
        '
        'frmProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(780, 666)
        Me.Controls.Add(Me.CtrL_MenuCine)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.flp1)
        Me.Controls.Add(Me.pnl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProdutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produtos"
        Me.pnl1.ResumeLayout(False)
        CType(Me.pct1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flp1.ResumeLayout(False)
        Me.tbc1.ResumeLayout(False)
        Me.tbpAtivado.ResumeLayout(False)
        Me.tbpDesativado.ResumeLayout(False)
        Me.pnlControlos.ResumeLayout(False)
        Me.pnlControlos.PerformLayout()
        CType(Me.pctImgLoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlProduto.ResumeLayout(False)
        Me.pnlProduto.PerformLayout()
        CType(Me.nmrStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmrPreco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlProibicao.ResumeLayout(False)
        Me.pnlProibicao.PerformLayout()
        CType(Me.pct3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CtrL_MenuCine As PAP___Gestão_de_Cinema.CTRL_MenuCine
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents pct1 As System.Windows.Forms.PictureBox
    Friend WithEvents flp1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents pnlControlos As System.Windows.Forms.Panel
    Friend WithEvents pnlProibicao As System.Windows.Forms.Panel
    Friend WithEvents pct3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblT As System.Windows.Forms.Label
    Friend WithEvents lblHammer As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDesativar As System.Windows.Forms.Button
    Friend WithEvents btnAtivar As System.Windows.Forms.Button
    Friend WithEvents btnProcurar As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnInserir As System.Windows.Forms.Button
    Friend WithEvents chkNome As System.Windows.Forms.CheckBox
    Friend WithEvents btnEscolher As System.Windows.Forms.Button
    Friend WithEvents lblGenero As System.Windows.Forms.Label
    Friend WithEvents lblPreco As System.Windows.Forms.Label
    Friend WithEvents lblStock As System.Windows.Forms.Label
    Friend WithEvents btnImagem As System.Windows.Forms.Button
    Friend WithEvents tbc1 As System.Windows.Forms.TabControl
    Friend WithEvents tbpAtivado As System.Windows.Forms.TabPage
    Friend WithEvents flpProdAtiv As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents tbpDesativado As System.Windows.Forms.TabPage
    Friend WithEvents flpProdDesa As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents pnlProduto As System.Windows.Forms.Panel
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents chkGenero As System.Windows.Forms.CheckBox
    Friend WithEvents chkStock As System.Windows.Forms.CheckBox
    Friend WithEvents chkPreco As System.Windows.Forms.CheckBox
    Friend WithEvents nmrPreco As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents nmrStock As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbGeneros As System.Windows.Forms.ComboBox
    Friend WithEvents ofdImagem As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lbl90 As System.Windows.Forms.Label
    Friend WithEvents chkImagem As System.Windows.Forms.CheckBox
    Friend WithEvents pctImgLoc As System.Windows.Forms.PictureBox
    Friend WithEvents lblImgNome As System.Windows.Forms.Label
End Class
