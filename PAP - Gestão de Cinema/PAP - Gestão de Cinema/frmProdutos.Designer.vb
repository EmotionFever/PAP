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
        Me.pnlS = New System.Windows.Forms.Panel()
        Me.lbl89 = New System.Windows.Forms.Label()
        Me.lbl890 = New System.Windows.Forms.Label()
        Me.lbl67 = New System.Windows.Forms.Label()
        Me.lbl44 = New System.Windows.Forms.Label()
        Me.pctS = New System.Windows.Forms.PictureBox()
        Me.tbpDesativado = New System.Windows.Forms.TabPage()
        Me.flpProdDesa = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlControlos = New System.Windows.Forms.Panel()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.pnlAtivar = New System.Windows.Forms.Panel()
        Me.lbl92 = New System.Windows.Forms.Label()
        Me.pnlSelecionado = New System.Windows.Forms.Panel()
        Me.lbl56 = New System.Windows.Forms.Label()
        Me.lblSto = New System.Windows.Forms.Label()
        Me.lblPre = New System.Windows.Forms.Label()
        Me.lblGen = New System.Windows.Forms.Label()
        Me.pctImg = New System.Windows.Forms.PictureBox()
        Me.btnAtivar = New System.Windows.Forms.Button()
        Me.btnDesativar = New System.Windows.Forms.Button()
        Me.pnlCriar = New System.Windows.Forms.Panel()
        Me.nmrStock = New System.Windows.Forms.NumericUpDown()
        Me.nmrPreco = New System.Windows.Forms.NumericUpDown()
        Me.lbl00 = New System.Windows.Forms.Label()
        Me.cmbGenero = New System.Windows.Forms.ComboBox()
        Me.btnRem = New System.Windows.Forms.Button()
        Me.lblImgNome = New System.Windows.Forms.Label()
        Me.btnAdi = New System.Windows.Forms.Button()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblStock = New System.Windows.Forms.Label()
        Me.lblPreco = New System.Windows.Forms.Label()
        Me.lblGenero = New System.Windows.Forms.Label()
        Me.btnImagem = New System.Windows.Forms.Button()
        Me.chkNome1 = New System.Windows.Forms.CheckBox()
        Me.chkImagem = New System.Windows.Forms.CheckBox()
        Me.btnProcurar = New System.Windows.Forms.Button()
        Me.chkGenero1 = New System.Windows.Forms.CheckBox()
        Me.chkPreco1 = New System.Windows.Forms.CheckBox()
        Me.chkStock1 = New System.Windows.Forms.CheckBox()
        Me.pnlProibicao = New System.Windows.Forms.Panel()
        Me.pct3 = New System.Windows.Forms.PictureBox()
        Me.lblT = New System.Windows.Forms.Label()
        Me.lblHammer = New System.Windows.Forms.Label()
        Me.lbl90 = New System.Windows.Forms.Label()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnInserir = New System.Windows.Forms.Button()
        Me.ofdImagem = New System.Windows.Forms.OpenFileDialog()
        Me.CtrL_MenuCine = New PAP___Gestão_de_Cinema.CTRL_MenuCine()
        Me.pnl1.SuspendLayout()
        CType(Me.pct1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flp1.SuspendLayout()
        Me.tbc1.SuspendLayout()
        Me.tbpAtivado.SuspendLayout()
        Me.flpProdAtiv.SuspendLayout()
        Me.pnlS.SuspendLayout()
        CType(Me.pctS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpDesativado.SuspendLayout()
        Me.pnlControlos.SuspendLayout()
        Me.pnlAtivar.SuspendLayout()
        Me.pnlSelecionado.SuspendLayout()
        CType(Me.pctImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCriar.SuspendLayout()
        CType(Me.nmrStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmrPreco, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlProibicao.SuspendLayout()
        CType(Me.pct3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pct1.BackgroundImage = Global.PAP___Gestão_de_Cinema.My.Resources.Resources.produtos
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
        Me.flp1.Size = New System.Drawing.Size(702, 520)
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
        Me.tbc1.Size = New System.Drawing.Size(408, 491)
        Me.tbc1.TabIndex = 52
        '
        'tbpAtivado
        '
        Me.tbpAtivado.BackColor = System.Drawing.Color.Silver
        Me.tbpAtivado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpAtivado.Controls.Add(Me.flpProdAtiv)
        Me.tbpAtivado.Location = New System.Drawing.Point(4, 23)
        Me.tbpAtivado.Name = "tbpAtivado"
        Me.tbpAtivado.Size = New System.Drawing.Size(400, 464)
        Me.tbpAtivado.TabIndex = 1
        Me.tbpAtivado.Text = "Produtos ativados"
        '
        'flpProdAtiv
        '
        Me.flpProdAtiv.AutoScroll = True
        Me.flpProdAtiv.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.flpProdAtiv.Controls.Add(Me.pnlS)
        Me.flpProdAtiv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpProdAtiv.Location = New System.Drawing.Point(0, 0)
        Me.flpProdAtiv.Name = "flpProdAtiv"
        Me.flpProdAtiv.Size = New System.Drawing.Size(398, 462)
        Me.flpProdAtiv.TabIndex = 8
        '
        'pnlS
        '
        Me.pnlS.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.pnlS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlS.Controls.Add(Me.lbl89)
        Me.pnlS.Controls.Add(Me.lbl890)
        Me.pnlS.Controls.Add(Me.lbl67)
        Me.pnlS.Controls.Add(Me.lbl44)
        Me.pnlS.Controls.Add(Me.pctS)
        Me.pnlS.Location = New System.Drawing.Point(3, 3)
        Me.pnlS.Name = "pnlS"
        Me.pnlS.Size = New System.Drawing.Size(121, 148)
        Me.pnlS.TabIndex = 62
        '
        'lbl89
        '
        Me.lbl89.BackColor = System.Drawing.Color.Transparent
        Me.lbl89.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl89.ForeColor = System.Drawing.Color.White
        Me.lbl89.Location = New System.Drawing.Point(0, 0)
        Me.lbl89.Name = "lbl89"
        Me.lbl89.Size = New System.Drawing.Size(121, 15)
        Me.lbl89.TabIndex = 66
        Me.lbl89.Text = "Nome do Produto"
        Me.lbl89.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl890
        '
        Me.lbl890.AutoSize = True
        Me.lbl890.BackColor = System.Drawing.Color.Transparent
        Me.lbl890.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl890.ForeColor = System.Drawing.Color.White
        Me.lbl890.Location = New System.Drawing.Point(0, 132)
        Me.lbl890.Name = "lbl890"
        Me.lbl890.Size = New System.Drawing.Size(37, 15)
        Me.lbl890.TabIndex = 66
        Me.lbl890.Text = "Stock"
        '
        'lbl67
        '
        Me.lbl67.AutoSize = True
        Me.lbl67.BackColor = System.Drawing.Color.Transparent
        Me.lbl67.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl67.ForeColor = System.Drawing.Color.White
        Me.lbl67.Location = New System.Drawing.Point(0, 117)
        Me.lbl67.Name = "lbl67"
        Me.lbl67.Size = New System.Drawing.Size(39, 15)
        Me.lbl67.TabIndex = 66
        Me.lbl67.Text = "Preço"
        '
        'lbl44
        '
        Me.lbl44.AutoEllipsis = True
        Me.lbl44.BackColor = System.Drawing.Color.Transparent
        Me.lbl44.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl44.ForeColor = System.Drawing.Color.White
        Me.lbl44.Location = New System.Drawing.Point(0, 102)
        Me.lbl44.Name = "lbl44"
        Me.lbl44.Size = New System.Drawing.Size(121, 15)
        Me.lbl44.TabIndex = 66
        Me.lbl44.Text = "Género"
        Me.lbl44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pctS
        '
        Me.pctS.BackColor = System.Drawing.Color.Firebrick
        Me.pctS.BackgroundImage = CType(resources.GetObject("pctS.BackgroundImage"), System.Drawing.Image)
        Me.pctS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pctS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pctS.Location = New System.Drawing.Point(0, 14)
        Me.pctS.Name = "pctS"
        Me.pctS.Size = New System.Drawing.Size(121, 87)
        Me.pctS.TabIndex = 70
        Me.pctS.TabStop = False
        '
        'tbpDesativado
        '
        Me.tbpDesativado.BackColor = System.Drawing.Color.Silver
        Me.tbpDesativado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpDesativado.Controls.Add(Me.flpProdDesa)
        Me.tbpDesativado.Location = New System.Drawing.Point(4, 23)
        Me.tbpDesativado.Name = "tbpDesativado"
        Me.tbpDesativado.Size = New System.Drawing.Size(400, 464)
        Me.tbpDesativado.TabIndex = 2
        Me.tbpDesativado.Text = "Produtos desativados"
        '
        'flpProdDesa
        '
        Me.flpProdDesa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpProdDesa.Location = New System.Drawing.Point(0, 0)
        Me.flpProdDesa.Name = "flpProdDesa"
        Me.flpProdDesa.Size = New System.Drawing.Size(398, 462)
        Me.flpProdDesa.TabIndex = 7
        '
        'pnlControlos
        '
        Me.pnlControlos.Controls.Add(Me.pnlAtivar)
        Me.pnlControlos.Controls.Add(Me.pnlCriar)
        Me.pnlControlos.Controls.Add(Me.chkNome1)
        Me.pnlControlos.Controls.Add(Me.chkImagem)
        Me.pnlControlos.Controls.Add(Me.btnProcurar)
        Me.pnlControlos.Controls.Add(Me.chkGenero1)
        Me.pnlControlos.Controls.Add(Me.chkPreco1)
        Me.pnlControlos.Controls.Add(Me.chkStock1)
        Me.pnlControlos.Controls.Add(Me.pnlProibicao)
        Me.pnlControlos.Controls.Add(Me.btnAlterar)
        Me.pnlControlos.Controls.Add(Me.btnInserir)
        Me.pnlControlos.Location = New System.Drawing.Point(417, 3)
        Me.pnlControlos.Name = "pnlControlos"
        Me.pnlControlos.Size = New System.Drawing.Size(273, 503)
        Me.pnlControlos.TabIndex = 43
        '
        'txtNome
        '
        Me.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNome.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.ForeColor = System.Drawing.Color.Black
        Me.txtNome.Location = New System.Drawing.Point(8, 2)
        Me.txtNome.MaxLength = 50
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(193, 23)
        Me.txtNome.TabIndex = 52
        Me.txtNome.Tag = "nome"
        Me.txtNome.Visible = False
        Me.txtNome.WordWrap = False
        '
        'pnlAtivar
        '
        Me.pnlAtivar.Controls.Add(Me.lbl92)
        Me.pnlAtivar.Controls.Add(Me.pnlSelecionado)
        Me.pnlAtivar.Controls.Add(Me.btnAtivar)
        Me.pnlAtivar.Controls.Add(Me.btnDesativar)
        Me.pnlAtivar.Location = New System.Drawing.Point(12, 298)
        Me.pnlAtivar.Name = "pnlAtivar"
        Me.pnlAtivar.Size = New System.Drawing.Size(253, 200)
        Me.pnlAtivar.TabIndex = 75
        '
        'lbl92
        '
        Me.lbl92.AutoSize = True
        Me.lbl92.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl92.ForeColor = System.Drawing.Color.White
        Me.lbl92.Location = New System.Drawing.Point(1, 3)
        Me.lbl92.Name = "lbl92"
        Me.lbl92.Size = New System.Drawing.Size(124, 15)
        Me.lbl92.TabIndex = 42
        Me.lbl92.Text = "Produto selecionado"
        '
        'pnlSelecionado
        '
        Me.pnlSelecionado.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.pnlSelecionado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSelecionado.Controls.Add(Me.lbl56)
        Me.pnlSelecionado.Controls.Add(Me.lblSto)
        Me.pnlSelecionado.Controls.Add(Me.lblPre)
        Me.pnlSelecionado.Controls.Add(Me.lblGen)
        Me.pnlSelecionado.Controls.Add(Me.pctImg)
        Me.pnlSelecionado.Location = New System.Drawing.Point(70, 21)
        Me.pnlSelecionado.Name = "pnlSelecionado"
        Me.pnlSelecionado.Size = New System.Drawing.Size(121, 148)
        Me.pnlSelecionado.TabIndex = 74
        '
        'lbl56
        '
        Me.lbl56.BackColor = System.Drawing.Color.Transparent
        Me.lbl56.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl56.ForeColor = System.Drawing.Color.White
        Me.lbl56.Location = New System.Drawing.Point(0, 0)
        Me.lbl56.Name = "lbl56"
        Me.lbl56.Size = New System.Drawing.Size(121, 15)
        Me.lbl56.TabIndex = 66
        Me.lbl56.Text = "Nome do Produto"
        Me.lbl56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSto
        '
        Me.lblSto.AutoSize = True
        Me.lblSto.BackColor = System.Drawing.Color.Transparent
        Me.lblSto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSto.ForeColor = System.Drawing.Color.White
        Me.lblSto.Location = New System.Drawing.Point(0, 132)
        Me.lblSto.Name = "lblSto"
        Me.lblSto.Size = New System.Drawing.Size(37, 15)
        Me.lblSto.TabIndex = 66
        Me.lblSto.Text = "Stock"
        '
        'lblPre
        '
        Me.lblPre.AutoSize = True
        Me.lblPre.BackColor = System.Drawing.Color.Transparent
        Me.lblPre.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPre.ForeColor = System.Drawing.Color.White
        Me.lblPre.Location = New System.Drawing.Point(0, 117)
        Me.lblPre.Name = "lblPre"
        Me.lblPre.Size = New System.Drawing.Size(39, 15)
        Me.lblPre.TabIndex = 66
        Me.lblPre.Text = "Preço"
        '
        'lblGen
        '
        Me.lblGen.AutoEllipsis = True
        Me.lblGen.BackColor = System.Drawing.Color.Transparent
        Me.lblGen.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGen.ForeColor = System.Drawing.Color.White
        Me.lblGen.Location = New System.Drawing.Point(0, 102)
        Me.lblGen.Name = "lblGen"
        Me.lblGen.Size = New System.Drawing.Size(121, 15)
        Me.lblGen.TabIndex = 66
        Me.lblGen.Text = "Género"
        Me.lblGen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pctImg
        '
        Me.pctImg.BackColor = System.Drawing.Color.Firebrick
        Me.pctImg.BackgroundImage = CType(resources.GetObject("pctImg.BackgroundImage"), System.Drawing.Image)
        Me.pctImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pctImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pctImg.Location = New System.Drawing.Point(0, 14)
        Me.pctImg.Name = "pctImg"
        Me.pctImg.Size = New System.Drawing.Size(121, 87)
        Me.pctImg.TabIndex = 70
        Me.pctImg.TabStop = False
        '
        'btnAtivar
        '
        Me.btnAtivar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAtivar.FlatAppearance.BorderSize = 0
        Me.btnAtivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtivar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtivar.ForeColor = System.Drawing.Color.Black
        Me.btnAtivar.Location = New System.Drawing.Point(5, 175)
        Me.btnAtivar.Name = "btnAtivar"
        Me.btnAtivar.Size = New System.Drawing.Size(244, 22)
        Me.btnAtivar.TabIndex = 48
        Me.btnAtivar.Text = "Ativar Produto"
        Me.btnAtivar.UseVisualStyleBackColor = False
        '
        'btnDesativar
        '
        Me.btnDesativar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDesativar.FlatAppearance.BorderSize = 0
        Me.btnDesativar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDesativar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesativar.ForeColor = System.Drawing.Color.Black
        Me.btnDesativar.Location = New System.Drawing.Point(5, 175)
        Me.btnDesativar.Name = "btnDesativar"
        Me.btnDesativar.Size = New System.Drawing.Size(244, 22)
        Me.btnDesativar.TabIndex = 43
        Me.btnDesativar.Text = "Desativar Produto"
        Me.btnDesativar.UseVisualStyleBackColor = False
        '
        'pnlCriar
        '
        Me.pnlCriar.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.pnlCriar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCriar.Controls.Add(Me.txtNome)
        Me.pnlCriar.Controls.Add(Me.nmrStock)
        Me.pnlCriar.Controls.Add(Me.nmrPreco)
        Me.pnlCriar.Controls.Add(Me.lbl00)
        Me.pnlCriar.Controls.Add(Me.cmbGenero)
        Me.pnlCriar.Controls.Add(Me.btnRem)
        Me.pnlCriar.Controls.Add(Me.lblImgNome)
        Me.pnlCriar.Controls.Add(Me.btnAdi)
        Me.pnlCriar.Controls.Add(Me.lblNome)
        Me.pnlCriar.Controls.Add(Me.lblStock)
        Me.pnlCriar.Controls.Add(Me.lblPreco)
        Me.pnlCriar.Controls.Add(Me.lblGenero)
        Me.pnlCriar.Controls.Add(Me.btnImagem)
        Me.pnlCriar.Location = New System.Drawing.Point(26, 4)
        Me.pnlCriar.Name = "pnlCriar"
        Me.pnlCriar.Size = New System.Drawing.Size(210, 257)
        Me.pnlCriar.TabIndex = 71
        '
        'nmrStock
        '
        Me.nmrStock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nmrStock.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nmrStock.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nmrStock.Location = New System.Drawing.Point(3, 227)
        Me.nmrStock.Name = "nmrStock"
        Me.nmrStock.Size = New System.Drawing.Size(193, 26)
        Me.nmrStock.TabIndex = 73
        Me.nmrStock.Tag = "stock"
        Me.nmrStock.Visible = False
        '
        'nmrPreco
        '
        Me.nmrPreco.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nmrPreco.DecimalPlaces = 2
        Me.nmrPreco.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nmrPreco.Increment = New Decimal(New Integer() {10, 0, 0, 131072})
        Me.nmrPreco.Location = New System.Drawing.Point(3, 203)
        Me.nmrPreco.Name = "nmrPreco"
        Me.nmrPreco.Size = New System.Drawing.Size(193, 26)
        Me.nmrPreco.TabIndex = 72
        Me.nmrPreco.Tag = "preço"
        Me.nmrPreco.Visible = False
        '
        'lbl00
        '
        Me.lbl00.AutoSize = True
        Me.lbl00.BackColor = System.Drawing.Color.White
        Me.lbl00.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl00.ForeColor = System.Drawing.Color.Black
        Me.lbl00.Location = New System.Drawing.Point(37, 144)
        Me.lbl00.Name = "lbl00"
        Me.lbl00.Size = New System.Drawing.Size(107, 15)
        Me.lbl00.TabIndex = 71
        Me.lbl00.Text = "Nome da imagem"
        '
        'cmbGenero
        '
        Me.cmbGenero.BackColor = System.Drawing.Color.White
        Me.cmbGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbGenero.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGenero.FormattingEnabled = True
        Me.cmbGenero.Location = New System.Drawing.Point(3, 178)
        Me.cmbGenero.Name = "cmbGenero"
        Me.cmbGenero.Size = New System.Drawing.Size(193, 31)
        Me.cmbGenero.TabIndex = 53
        Me.cmbGenero.Tag = "genero"
        Me.cmbGenero.Visible = False
        '
        'btnRem
        '
        Me.btnRem.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRem.BackgroundImage = CType(resources.GetObject("btnRem.BackgroundImage"), System.Drawing.Image)
        Me.btnRem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRem.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btnRem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnRem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRem.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRem.ForeColor = System.Drawing.Color.White
        Me.btnRem.Location = New System.Drawing.Point(0, 143)
        Me.btnRem.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRem.Name = "btnRem"
        Me.btnRem.Size = New System.Drawing.Size(35, 35)
        Me.btnRem.TabIndex = 71
        Me.btnRem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnRem.UseVisualStyleBackColor = False
        '
        'lblImgNome
        '
        Me.lblImgNome.AutoEllipsis = True
        Me.lblImgNome.BackColor = System.Drawing.Color.White
        Me.lblImgNome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblImgNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblImgNome.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImgNome.ForeColor = System.Drawing.Color.Black
        Me.lblImgNome.Location = New System.Drawing.Point(37, 160)
        Me.lblImgNome.Name = "lblImgNome"
        Me.lblImgNome.Size = New System.Drawing.Size(171, 17)
        Me.lblImgNome.TabIndex = 65
        Me.lblImgNome.Text = "---"
        '
        'btnAdi
        '
        Me.btnAdi.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdi.BackgroundImage = CType(resources.GetObject("btnAdi.BackgroundImage"), System.Drawing.Image)
        Me.btnAdi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAdi.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnAdi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.btnAdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdi.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdi.ForeColor = System.Drawing.Color.White
        Me.btnAdi.Location = New System.Drawing.Point(173, 28)
        Me.btnAdi.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAdi.Name = "btnAdi"
        Me.btnAdi.Size = New System.Drawing.Size(35, 35)
        Me.btnAdi.TabIndex = 68
        Me.btnAdi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.btnAdi.UseVisualStyleBackColor = False
        '
        'lblNome
        '
        Me.lblNome.BackColor = System.Drawing.Color.Transparent
        Me.lblNome.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.ForeColor = System.Drawing.Color.White
        Me.lblNome.Location = New System.Drawing.Point(0, 0)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(210, 26)
        Me.lblNome.TabIndex = 66
        Me.lblNome.Text = "Nome do Produto"
        Me.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStock
        '
        Me.lblStock.BackColor = System.Drawing.Color.Transparent
        Me.lblStock.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock.ForeColor = System.Drawing.Color.White
        Me.lblStock.Location = New System.Drawing.Point(0, 230)
        Me.lblStock.Name = "lblStock"
        Me.lblStock.Size = New System.Drawing.Size(209, 23)
        Me.lblStock.TabIndex = 66
        Me.lblStock.Text = "Stock"
        '
        'lblPreco
        '
        Me.lblPreco.BackColor = System.Drawing.Color.Transparent
        Me.lblPreco.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreco.ForeColor = System.Drawing.Color.White
        Me.lblPreco.Location = New System.Drawing.Point(0, 205)
        Me.lblPreco.Name = "lblPreco"
        Me.lblPreco.Size = New System.Drawing.Size(208, 23)
        Me.lblPreco.TabIndex = 66
        Me.lblPreco.Text = "Preço"
        '
        'lblGenero
        '
        Me.lblGenero.AutoEllipsis = True
        Me.lblGenero.BackColor = System.Drawing.Color.Transparent
        Me.lblGenero.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenero.ForeColor = System.Drawing.Color.White
        Me.lblGenero.Location = New System.Drawing.Point(0, 179)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(210, 26)
        Me.lblGenero.TabIndex = 66
        Me.lblGenero.Text = "Género"
        Me.lblGenero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnImagem
        '
        Me.btnImagem.BackColor = System.Drawing.Color.Firebrick
        Me.btnImagem.BackgroundImage = Global.PAP___Gestão_de_Cinema.My.Resources.Resources.produtos
        Me.btnImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnImagem.FlatAppearance.BorderSize = 0
        Me.btnImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImagem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImagem.ForeColor = System.Drawing.Color.Black
        Me.btnImagem.Location = New System.Drawing.Point(0, 28)
        Me.btnImagem.Name = "btnImagem"
        Me.btnImagem.Size = New System.Drawing.Size(210, 151)
        Me.btnImagem.TabIndex = 76
        Me.btnImagem.UseVisualStyleBackColor = False
        '
        'chkNome1
        '
        Me.chkNome1.AutoSize = True
        Me.chkNome1.Location = New System.Drawing.Point(244, 12)
        Me.chkNome1.Name = "chkNome1"
        Me.chkNome1.Size = New System.Drawing.Size(15, 14)
        Me.chkNome1.TabIndex = 22
        Me.chkNome1.UseVisualStyleBackColor = True
        '
        'chkImagem
        '
        Me.chkImagem.AutoSize = True
        Me.chkImagem.Location = New System.Drawing.Point(244, 98)
        Me.chkImagem.Name = "chkImagem"
        Me.chkImagem.Size = New System.Drawing.Size(15, 14)
        Me.chkImagem.TabIndex = 67
        Me.chkImagem.UseVisualStyleBackColor = True
        '
        'btnProcurar
        '
        Me.btnProcurar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnProcurar.FlatAppearance.BorderSize = 0
        Me.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcurar.ForeColor = System.Drawing.Color.Black
        Me.btnProcurar.Location = New System.Drawing.Point(99, 270)
        Me.btnProcurar.Name = "btnProcurar"
        Me.btnProcurar.Size = New System.Drawing.Size(79, 23)
        Me.btnProcurar.TabIndex = 40
        Me.btnProcurar.Text = "Procurar"
        Me.btnProcurar.UseVisualStyleBackColor = False
        '
        'chkGenero1
        '
        Me.chkGenero1.AutoSize = True
        Me.chkGenero1.Location = New System.Drawing.Point(244, 184)
        Me.chkGenero1.Name = "chkGenero1"
        Me.chkGenero1.Size = New System.Drawing.Size(15, 14)
        Me.chkGenero1.TabIndex = 64
        Me.chkGenero1.UseVisualStyleBackColor = True
        '
        'chkPreco1
        '
        Me.chkPreco1.AutoSize = True
        Me.chkPreco1.Location = New System.Drawing.Point(244, 213)
        Me.chkPreco1.Name = "chkPreco1"
        Me.chkPreco1.Size = New System.Drawing.Size(15, 14)
        Me.chkPreco1.TabIndex = 62
        Me.chkPreco1.UseVisualStyleBackColor = True
        '
        'chkStock1
        '
        Me.chkStock1.AutoSize = True
        Me.chkStock1.Location = New System.Drawing.Point(244, 243)
        Me.chkStock1.Name = "chkStock1"
        Me.chkStock1.Size = New System.Drawing.Size(15, 14)
        Me.chkStock1.TabIndex = 63
        Me.chkStock1.UseVisualStyleBackColor = True
        '
        'pnlProibicao
        '
        Me.pnlProibicao.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnlProibicao.Controls.Add(Me.pct3)
        Me.pnlProibicao.Controls.Add(Me.lblT)
        Me.pnlProibicao.Controls.Add(Me.lblHammer)
        Me.pnlProibicao.Controls.Add(Me.lbl90)
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
        Me.lblHammer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblHammer.Location = New System.Drawing.Point(70, 29)
        Me.lblHammer.Name = "lblHammer"
        Me.lblHammer.Size = New System.Drawing.Size(106, 91)
        Me.lblHammer.TabIndex = 0
        Me.lblHammer.Text = "🛠"
        '
        'lbl90
        '
        Me.lbl90.AutoSize = True
        Me.lbl90.BackColor = System.Drawing.Color.Transparent
        Me.lbl90.Font = New System.Drawing.Font("Microsoft Sans Serif", 150.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl90.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl90.Location = New System.Drawing.Point(67, 187)
        Me.lbl90.Name = "lbl90"
        Me.lbl90.Size = New System.Drawing.Size(263, 226)
        Me.lbl90.TabIndex = 1
        Me.lbl90.Text = "🛠"
        '
        'btnAlterar
        '
        Me.btnAlterar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAlterar.FlatAppearance.BorderSize = 0
        Me.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlterar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlterar.ForeColor = System.Drawing.Color.Black
        Me.btnAlterar.Location = New System.Drawing.Point(184, 270)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(85, 22)
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
        Me.btnInserir.Location = New System.Drawing.Point(8, 270)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Size = New System.Drawing.Size(84, 22)
        Me.btnInserir.TabIndex = 39
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.UseVisualStyleBackColor = False
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
        Me.CtrL_MenuCine.Size = New System.Drawing.Size(49, 652)
        Me.CtrL_MenuCine.TabIndex = 0
        '
        'frmProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(780, 652)
        Me.Controls.Add(Me.CtrL_MenuCine)
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
        Me.flpProdAtiv.ResumeLayout(False)
        Me.pnlS.ResumeLayout(False)
        Me.pnlS.PerformLayout()
        CType(Me.pctS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpDesativado.ResumeLayout(False)
        Me.pnlControlos.ResumeLayout(False)
        Me.pnlControlos.PerformLayout()
        Me.pnlAtivar.ResumeLayout(False)
        Me.pnlAtivar.PerformLayout()
        Me.pnlSelecionado.ResumeLayout(False)
        Me.pnlSelecionado.PerformLayout()
        CType(Me.pctImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCriar.ResumeLayout(False)
        Me.pnlCriar.PerformLayout()
        CType(Me.nmrStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmrPreco, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlProibicao.ResumeLayout(False)
        Me.pnlProibicao.PerformLayout()
        CType(Me.pct3, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lbl90 As System.Windows.Forms.Label
    Friend WithEvents btnDesativar As System.Windows.Forms.Button
    Friend WithEvents btnAtivar As System.Windows.Forms.Button
    Friend WithEvents btnProcurar As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnInserir As System.Windows.Forms.Button
    Friend WithEvents chkNome1 As System.Windows.Forms.CheckBox
    Friend WithEvents tbc1 As System.Windows.Forms.TabControl
    Friend WithEvents tbpAtivado As System.Windows.Forms.TabPage
    Friend WithEvents flpProdAtiv As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents tbpDesativado As System.Windows.Forms.TabPage
    Friend WithEvents flpProdDesa As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents chkGenero1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkStock1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkPreco1 As System.Windows.Forms.CheckBox
    Friend WithEvents ofdImagem As System.Windows.Forms.OpenFileDialog
    Friend WithEvents chkImagem As System.Windows.Forms.CheckBox
    Friend WithEvents lblImgNome As System.Windows.Forms.Label
    Friend WithEvents btnAdi As System.Windows.Forms.Button
    Friend WithEvents pnlCriar As System.Windows.Forms.Panel
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents lblStock As System.Windows.Forms.Label
    Friend WithEvents lblPreco As System.Windows.Forms.Label
    Friend WithEvents lblGenero As System.Windows.Forms.Label
    Friend WithEvents btnRem As System.Windows.Forms.Button
    Friend WithEvents pnlSelecionado As System.Windows.Forms.Panel
    Friend WithEvents lbl56 As System.Windows.Forms.Label
    Friend WithEvents lblSto As System.Windows.Forms.Label
    Friend WithEvents lblPre As System.Windows.Forms.Label
    Friend WithEvents lblGen As System.Windows.Forms.Label
    Friend WithEvents pctImg As System.Windows.Forms.PictureBox
    Friend WithEvents pnlAtivar As System.Windows.Forms.Panel
    Friend WithEvents lbl92 As System.Windows.Forms.Label
    Friend WithEvents lbl00 As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents cmbGenero As System.Windows.Forms.ComboBox
    Friend WithEvents nmrPreco As System.Windows.Forms.NumericUpDown
    Friend WithEvents nmrStock As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnImagem As System.Windows.Forms.Button
    Friend WithEvents pnlS As System.Windows.Forms.Panel
    Friend WithEvents lbl89 As System.Windows.Forms.Label
    Friend WithEvents lbl890 As System.Windows.Forms.Label
    Friend WithEvents lbl67 As System.Windows.Forms.Label
    Friend WithEvents lbl44 As System.Windows.Forms.Label
    Friend WithEvents pctS As System.Windows.Forms.PictureBox
End Class
