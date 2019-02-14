<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.pctSalas = New System.Windows.Forms.PictureBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.flp1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.tbc1 = New System.Windows.Forms.TabControl()
        Me.tbpAtivado = New System.Windows.Forms.TabPage()
        Me.dgvAtivado = New System.Windows.Forms.DataGridView()
        Me.tbpDesativado = New System.Windows.Forms.TabPage()
        Me.dgvDesativado = New System.Windows.Forms.DataGridView()
        Me.pnlControlos = New System.Windows.Forms.Panel()
        Me.pnlProibicao = New System.Windows.Forms.Panel()
        Me.pct3 = New System.Windows.Forms.PictureBox()
        Me.lblT = New System.Windows.Forms.Label()
        Me.lblHammer = New System.Windows.Forms.Label()
        Me.lbl73 = New System.Windows.Forms.Label()
        Me.nmrLinhas = New System.Windows.Forms.NumericUpDown()
        Me.nmrColunas = New System.Windows.Forms.NumericUpDown()
        Me.pnlAtivar = New System.Windows.Forms.Panel()
        Me.btnDesativar = New System.Windows.Forms.Button()
        Me.lbl92 = New System.Windows.Forms.Label()
        Me.btnAtivar = New System.Windows.Forms.Button()
        Me.lbl9 = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblnome = New System.Windows.Forms.Label()
        Me.lbl94 = New System.Windows.Forms.Label()
        Me.lbl10 = New System.Windows.Forms.Label()
        Me.lblColunas = New System.Windows.Forms.Label()
        Me.lbl12 = New System.Windows.Forms.Label()
        Me.lblLinhas = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.chknome = New System.Windows.Forms.CheckBox()
        Me.cmbtipo = New System.Windows.Forms.ComboBox()
        Me.chkcolunas = New System.Windows.Forms.CheckBox()
        Me.chklinhas = New System.Windows.Forms.CheckBox()
        Me.chktipo = New System.Windows.Forms.CheckBox()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.lbl90 = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.rctTipo = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rctLinhas = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rctColunas = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rctNome = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.cmblocalidade = New System.Windows.Forms.ComboBox()
        Me.pctTitulo = New System.Windows.Forms.PictureBox()
        Me.CtrL_MenuCine = New PAP___Gestão_de_Cinema.CTRL_MenuCine()
        Me.btnProcurar = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnInserir = New System.Windows.Forms.Button()
        Me.pnl1.SuspendLayout()
        CType(Me.pctSalas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flp1.SuspendLayout()
        Me.tbc1.SuspendLayout()
        Me.tbpAtivado.SuspendLayout()
        CType(Me.dgvAtivado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpDesativado.SuspendLayout()
        CType(Me.dgvDesativado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlControlos.SuspendLayout()
        Me.pnlProibicao.SuspendLayout()
        CType(Me.pct3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmrLinhas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmrColunas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAtivar.SuspendLayout()
        CType(Me.pctTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.pnl1.Controls.Add(Me.pctSalas)
        Me.pnl1.Controls.Add(Me.lbl1)
        Me.pnl1.Location = New System.Drawing.Point(74, 24)
        Me.pnl1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(689, 93)
        Me.pnl1.TabIndex = 5
        '
        'pctSalas
        '
        Me.pctSalas.BackgroundImage = CType(resources.GetObject("pctSalas.BackgroundImage"), System.Drawing.Image)
        Me.pctSalas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pctSalas.Location = New System.Drawing.Point(3, 4)
        Me.pctSalas.Name = "pctSalas"
        Me.pctSalas.Size = New System.Drawing.Size(88, 85)
        Me.pctSalas.TabIndex = 50
        Me.pctSalas.TabStop = False
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.lbl1.ForeColor = System.Drawing.Color.Black
        Me.lbl1.Location = New System.Drawing.Point(96, 21)
        Me.lbl1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(594, 55)
        Me.lbl1.TabIndex = 4
        Me.lbl1.Text = "Salas"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'flp1
        '
        Me.flp1.Controls.Add(Me.tbc1)
        Me.flp1.Controls.Add(Me.pnlControlos)
        Me.flp1.Location = New System.Drawing.Point(74, 123)
        Me.flp1.Name = "flp1"
        Me.flp1.Size = New System.Drawing.Size(714, 493)
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
        Me.tbc1.Size = New System.Drawing.Size(439, 482)
        Me.tbc1.TabIndex = 47
        '
        'tbpAtivado
        '
        Me.tbpAtivado.BackColor = System.Drawing.Color.Silver
        Me.tbpAtivado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpAtivado.Controls.Add(Me.dgvAtivado)
        Me.tbpAtivado.ForeColor = System.Drawing.Color.Black
        Me.tbpAtivado.Location = New System.Drawing.Point(4, 23)
        Me.tbpAtivado.Name = "tbpAtivado"
        Me.tbpAtivado.Size = New System.Drawing.Size(431, 455)
        Me.tbpAtivado.TabIndex = 1
        Me.tbpAtivado.Text = "Salas ativadas"
        '
        'dgvAtivado
        '
        Me.dgvAtivado.AllowUserToAddRows = False
        Me.dgvAtivado.AllowUserToDeleteRows = False
        Me.dgvAtivado.AllowUserToResizeRows = False
        Me.dgvAtivado.BackgroundColor = System.Drawing.Color.DimGray
        Me.dgvAtivado.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAtivado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAtivado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvAtivado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAtivado.Location = New System.Drawing.Point(0, 0)
        Me.dgvAtivado.MultiSelect = False
        Me.dgvAtivado.Name = "dgvAtivado"
        Me.dgvAtivado.ReadOnly = True
        Me.dgvAtivado.RowHeadersVisible = False
        Me.dgvAtivado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvAtivado.Size = New System.Drawing.Size(429, 453)
        Me.dgvAtivado.TabIndex = 15
        '
        'tbpDesativado
        '
        Me.tbpDesativado.BackColor = System.Drawing.Color.Silver
        Me.tbpDesativado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpDesativado.Controls.Add(Me.dgvDesativado)
        Me.tbpDesativado.ForeColor = System.Drawing.Color.Black
        Me.tbpDesativado.Location = New System.Drawing.Point(4, 23)
        Me.tbpDesativado.Name = "tbpDesativado"
        Me.tbpDesativado.Size = New System.Drawing.Size(431, 455)
        Me.tbpDesativado.TabIndex = 2
        Me.tbpDesativado.Text = "Salas desativadas"
        '
        'dgvDesativado
        '
        Me.dgvDesativado.AllowUserToAddRows = False
        Me.dgvDesativado.AllowUserToDeleteRows = False
        Me.dgvDesativado.AllowUserToResizeRows = False
        Me.dgvDesativado.BackgroundColor = System.Drawing.Color.DimGray
        Me.dgvDesativado.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDesativado.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDesativado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvDesativado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDesativado.Location = New System.Drawing.Point(0, 0)
        Me.dgvDesativado.MultiSelect = False
        Me.dgvDesativado.Name = "dgvDesativado"
        Me.dgvDesativado.ReadOnly = True
        Me.dgvDesativado.RowHeadersVisible = False
        Me.dgvDesativado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvDesativado.Size = New System.Drawing.Size(429, 453)
        Me.dgvDesativado.TabIndex = 16
        '
        'pnlControlos
        '
        Me.pnlControlos.Controls.Add(Me.btnProcurar)
        Me.pnlControlos.Controls.Add(Me.btnAlterar)
        Me.pnlControlos.Controls.Add(Me.btnInserir)
        Me.pnlControlos.Controls.Add(Me.pnlProibicao)
        Me.pnlControlos.Controls.Add(Me.nmrLinhas)
        Me.pnlControlos.Controls.Add(Me.nmrColunas)
        Me.pnlControlos.Controls.Add(Me.pnlAtivar)
        Me.pnlControlos.Controls.Add(Me.lbl2)
        Me.pnlControlos.Controls.Add(Me.lbl6)
        Me.pnlControlos.Controls.Add(Me.lbl3)
        Me.pnlControlos.Controls.Add(Me.chknome)
        Me.pnlControlos.Controls.Add(Me.cmbtipo)
        Me.pnlControlos.Controls.Add(Me.chkcolunas)
        Me.pnlControlos.Controls.Add(Me.chklinhas)
        Me.pnlControlos.Controls.Add(Me.chktipo)
        Me.pnlControlos.Controls.Add(Me.txtnome)
        Me.pnlControlos.Controls.Add(Me.lbl90)
        Me.pnlControlos.Controls.Add(Me.ShapeContainer2)
        Me.pnlControlos.Location = New System.Drawing.Point(448, 3)
        Me.pnlControlos.Name = "pnlControlos"
        Me.pnlControlos.Size = New System.Drawing.Size(258, 482)
        Me.pnlControlos.TabIndex = 43
        '
        'pnlProibicao
        '
        Me.pnlProibicao.BackColor = System.Drawing.Color.PaleTurquoise
        Me.pnlProibicao.Controls.Add(Me.pct3)
        Me.pnlProibicao.Controls.Add(Me.lblT)
        Me.pnlProibicao.Controls.Add(Me.lblHammer)
        Me.pnlProibicao.Controls.Add(Me.lbl73)
        Me.pnlProibicao.Location = New System.Drawing.Point(270, 3)
        Me.pnlProibicao.Name = "pnlProibicao"
        Me.pnlProibicao.Size = New System.Drawing.Size(241, 290)
        Me.pnlProibicao.TabIndex = 48
        Me.pnlProibicao.Visible = False
        '
        'pct3
        '
        Me.pct3.BackColor = System.Drawing.Color.Transparent
        Me.pct3.BackgroundImage = CType(resources.GetObject("pct3.BackgroundImage"), System.Drawing.Image)
        Me.pct3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pct3.Location = New System.Drawing.Point(0, 263)
        Me.pct3.Name = "pct3"
        Me.pct3.Size = New System.Drawing.Size(30, 28)
        Me.pct3.TabIndex = 54
        Me.pct3.TabStop = False
        '
        'lblT
        '
        Me.lblT.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblT.ForeColor = System.Drawing.Color.Black
        Me.lblT.Location = New System.Drawing.Point(10, 99)
        Me.lblT.Name = "lblT"
        Me.lblT.Size = New System.Drawing.Size(219, 72)
        Me.lblT.TabIndex = 51
        Me.lblT.Text = "Só pode realizar ações enquanto estiver na aba dos registos ativados"
        Me.lblT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHammer
        '
        Me.lblHammer.AutoSize = True
        Me.lblHammer.BackColor = System.Drawing.Color.Transparent
        Me.lblHammer.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHammer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblHammer.Location = New System.Drawing.Point(70, -5)
        Me.lblHammer.Name = "lblHammer"
        Me.lblHammer.Size = New System.Drawing.Size(106, 91)
        Me.lblHammer.TabIndex = 0
        Me.lblHammer.Text = "🛠"
        '
        'lbl73
        '
        Me.lbl73.AutoSize = True
        Me.lbl73.BackColor = System.Drawing.Color.Transparent
        Me.lbl73.Font = New System.Drawing.Font("Microsoft Sans Serif", 150.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl73.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl73.Location = New System.Drawing.Point(63, 107)
        Me.lbl73.Name = "lbl73"
        Me.lbl73.Size = New System.Drawing.Size(263, 226)
        Me.lbl73.TabIndex = 1
        Me.lbl73.Text = "🛠"
        '
        'nmrLinhas
        '
        Me.nmrLinhas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nmrLinhas.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nmrLinhas.Location = New System.Drawing.Point(11, 155)
        Me.nmrLinhas.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmrLinhas.Name = "nmrLinhas"
        Me.nmrLinhas.Size = New System.Drawing.Size(193, 16)
        Me.nmrLinhas.TabIndex = 59
        Me.nmrLinhas.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nmrColunas
        '
        Me.nmrColunas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nmrColunas.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nmrColunas.Location = New System.Drawing.Point(11, 93)
        Me.nmrColunas.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmrColunas.Name = "nmrColunas"
        Me.nmrColunas.Size = New System.Drawing.Size(193, 16)
        Me.nmrColunas.TabIndex = 58
        Me.nmrColunas.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'pnlAtivar
        '
        Me.pnlAtivar.Controls.Add(Me.btnDesativar)
        Me.pnlAtivar.Controls.Add(Me.lbl92)
        Me.pnlAtivar.Controls.Add(Me.btnAtivar)
        Me.pnlAtivar.Controls.Add(Me.lbl9)
        Me.pnlAtivar.Controls.Add(Me.lblTipo)
        Me.pnlAtivar.Controls.Add(Me.lblnome)
        Me.pnlAtivar.Controls.Add(Me.lbl94)
        Me.pnlAtivar.Controls.Add(Me.lbl10)
        Me.pnlAtivar.Controls.Add(Me.lblColunas)
        Me.pnlAtivar.Controls.Add(Me.lbl12)
        Me.pnlAtivar.Controls.Add(Me.lblLinhas)
        Me.pnlAtivar.Location = New System.Drawing.Point(0, 295)
        Me.pnlAtivar.Name = "pnlAtivar"
        Me.pnlAtivar.Size = New System.Drawing.Size(253, 139)
        Me.pnlAtivar.TabIndex = 49
        '
        'btnDesativar
        '
        Me.btnDesativar.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnDesativar.FlatAppearance.BorderSize = 0
        Me.btnDesativar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDesativar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesativar.ForeColor = System.Drawing.Color.Black
        Me.btnDesativar.Location = New System.Drawing.Point(6, 99)
        Me.btnDesativar.Name = "btnDesativar"
        Me.btnDesativar.Size = New System.Drawing.Size(236, 22)
        Me.btnDesativar.TabIndex = 43
        Me.btnDesativar.Text = "Desativar Sala"
        Me.btnDesativar.UseVisualStyleBackColor = False
        '
        'lbl92
        '
        Me.lbl92.AutoSize = True
        Me.lbl92.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl92.ForeColor = System.Drawing.Color.White
        Me.lbl92.Location = New System.Drawing.Point(1, 12)
        Me.lbl92.Name = "lbl92"
        Me.lbl92.Size = New System.Drawing.Size(118, 15)
        Me.lbl92.TabIndex = 42
        Me.lbl92.Text = "Cliente selecionado"
        '
        'btnAtivar
        '
        Me.btnAtivar.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnAtivar.FlatAppearance.BorderSize = 0
        Me.btnAtivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtivar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtivar.ForeColor = System.Drawing.Color.Black
        Me.btnAtivar.Location = New System.Drawing.Point(4, 99)
        Me.btnAtivar.Name = "btnAtivar"
        Me.btnAtivar.Size = New System.Drawing.Size(237, 22)
        Me.btnAtivar.TabIndex = 48
        Me.btnAtivar.Text = "Ativar Sala"
        Me.btnAtivar.UseVisualStyleBackColor = False
        '
        'lbl9
        '
        Me.lbl9.AutoSize = True
        Me.lbl9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl9.ForeColor = System.Drawing.Color.White
        Me.lbl9.Location = New System.Drawing.Point(19, 33)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Size = New System.Drawing.Size(76, 14)
        Me.lbl9.TabIndex = 0
        Me.lbl9.Text = "Nome da Sala:"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.ForeColor = System.Drawing.Color.White
        Me.lblTipo.Location = New System.Drawing.Point(111, 47)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(19, 14)
        Me.lblTipo.TabIndex = 46
        Me.lblTipo.Text = "---"
        '
        'lblnome
        '
        Me.lblnome.AutoEllipsis = True
        Me.lblnome.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnome.ForeColor = System.Drawing.Color.White
        Me.lblnome.Location = New System.Drawing.Point(111, 33)
        Me.lblnome.Name = "lblnome"
        Me.lblnome.Size = New System.Drawing.Size(131, 14)
        Me.lblnome.TabIndex = 16
        Me.lblnome.Text = "---"
        '
        'lbl94
        '
        Me.lbl94.AutoSize = True
        Me.lbl94.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl94.ForeColor = System.Drawing.Color.White
        Me.lbl94.Location = New System.Drawing.Point(19, 47)
        Me.lbl94.Name = "lbl94"
        Me.lbl94.Size = New System.Drawing.Size(69, 14)
        Me.lbl94.TabIndex = 45
        Me.lbl94.Text = "Tipo de Sala:"
        '
        'lbl10
        '
        Me.lbl10.AutoSize = True
        Me.lbl10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl10.ForeColor = System.Drawing.Color.White
        Me.lbl10.Location = New System.Drawing.Point(19, 61)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(49, 14)
        Me.lbl10.TabIndex = 5
        Me.lbl10.Text = "Colunas:"
        '
        'lblColunas
        '
        Me.lblColunas.AutoSize = True
        Me.lblColunas.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColunas.ForeColor = System.Drawing.Color.White
        Me.lblColunas.Location = New System.Drawing.Point(111, 61)
        Me.lblColunas.Name = "lblColunas"
        Me.lblColunas.Size = New System.Drawing.Size(19, 14)
        Me.lblColunas.TabIndex = 17
        Me.lblColunas.Text = "---"
        '
        'lbl12
        '
        Me.lbl12.AutoSize = True
        Me.lbl12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl12.ForeColor = System.Drawing.Color.White
        Me.lbl12.Location = New System.Drawing.Point(19, 75)
        Me.lbl12.Name = "lbl12"
        Me.lbl12.Size = New System.Drawing.Size(42, 14)
        Me.lbl12.TabIndex = 9
        Me.lbl12.Text = "Linhas:"
        '
        'lblLinhas
        '
        Me.lblLinhas.AutoEllipsis = True
        Me.lblLinhas.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLinhas.ForeColor = System.Drawing.Color.White
        Me.lblLinhas.Location = New System.Drawing.Point(111, 75)
        Me.lblLinhas.Name = "lblLinhas"
        Me.lblLinhas.Size = New System.Drawing.Size(131, 14)
        Me.lblLinhas.TabIndex = 19
        Me.lblLinhas.Text = "---"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.White
        Me.lbl2.Location = New System.Drawing.Point(-1, 11)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(93, 15)
        Me.lbl2.TabIndex = 20
        Me.lbl2.Text = "*Nome da Sala:"
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl6.ForeColor = System.Drawing.Color.White
        Me.lbl6.Location = New System.Drawing.Point(-1, 134)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(53, 15)
        Me.lbl6.TabIndex = 22
        Me.lbl6.Text = "*Linhas:"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl3.ForeColor = System.Drawing.Color.White
        Me.lbl3.Location = New System.Drawing.Point(-1, 72)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(61, 15)
        Me.lbl3.TabIndex = 21
        Me.lbl3.Text = "*Colunas:"
        '
        'chknome
        '
        Me.chknome.AutoSize = True
        Me.chknome.Location = New System.Drawing.Point(224, 32)
        Me.chknome.Name = "chknome"
        Me.chknome.Size = New System.Drawing.Size(15, 14)
        Me.chknome.TabIndex = 22
        Me.chknome.UseVisualStyleBackColor = True
        '
        'cmbtipo
        '
        Me.cmbtipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbtipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbtipo.BackColor = System.Drawing.Color.White
        Me.cmbtipo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtipo.FormattingEnabled = True
        Me.cmbtipo.Location = New System.Drawing.Point(11, 214)
        Me.cmbtipo.MaxLength = 50
        Me.cmbtipo.Name = "cmbtipo"
        Me.cmbtipo.Size = New System.Drawing.Size(193, 22)
        Me.cmbtipo.TabIndex = 44
        Me.cmbtipo.Tag = "localidade"
        '
        'chkcolunas
        '
        Me.chkcolunas.AutoSize = True
        Me.chkcolunas.Location = New System.Drawing.Point(224, 94)
        Me.chkcolunas.Name = "chkcolunas"
        Me.chkcolunas.Size = New System.Drawing.Size(15, 14)
        Me.chkcolunas.TabIndex = 23
        Me.chkcolunas.UseVisualStyleBackColor = True
        '
        'chklinhas
        '
        Me.chklinhas.AutoSize = True
        Me.chklinhas.Location = New System.Drawing.Point(224, 157)
        Me.chklinhas.Name = "chklinhas"
        Me.chklinhas.Size = New System.Drawing.Size(15, 14)
        Me.chklinhas.TabIndex = 24
        Me.chklinhas.UseVisualStyleBackColor = True
        '
        'chktipo
        '
        Me.chktipo.AutoSize = True
        Me.chktipo.Location = New System.Drawing.Point(224, 218)
        Me.chktipo.Name = "chktipo"
        Me.chktipo.Size = New System.Drawing.Size(15, 14)
        Me.chktipo.TabIndex = 25
        Me.chktipo.UseVisualStyleBackColor = True
        '
        'txtnome
        '
        Me.txtnome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnome.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnome.ForeColor = System.Drawing.Color.Black
        Me.txtnome.Location = New System.Drawing.Point(11, 32)
        Me.txtnome.MaxLength = 50
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(193, 14)
        Me.txtnome.TabIndex = 27
        Me.txtnome.Tag = "nome"
        '
        'lbl90
        '
        Me.lbl90.AutoSize = True
        Me.lbl90.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl90.ForeColor = System.Drawing.Color.White
        Me.lbl90.Location = New System.Drawing.Point(-1, 197)
        Me.lbl90.Name = "lbl90"
        Me.lbl90.Size = New System.Drawing.Size(84, 15)
        Me.lbl90.TabIndex = 29
        Me.lbl90.Text = "*Tipo de Sala:"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.rctTipo, Me.rctLinhas, Me.rctColunas, Me.rctNome})
        Me.ShapeContainer2.Size = New System.Drawing.Size(258, 482)
        Me.ShapeContainer2.TabIndex = 0
        Me.ShapeContainer2.TabStop = False
        '
        'rctTipo
        '
        Me.rctTipo.BackColor = System.Drawing.Color.White
        Me.rctTipo.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rctTipo.BorderColor = System.Drawing.Color.White
        Me.rctTipo.CornerRadius = 2
        Me.rctTipo.Location = New System.Drawing.Point(2, 212)
        Me.rctTipo.Name = "rctTipo"
        Me.rctTipo.Size = New System.Drawing.Size(210, 25)
        '
        'rctLinhas
        '
        Me.rctLinhas.BackColor = System.Drawing.Color.White
        Me.rctLinhas.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rctLinhas.BorderColor = System.Drawing.Color.White
        Me.rctLinhas.CornerRadius = 2
        Me.rctLinhas.Location = New System.Drawing.Point(3, 150)
        Me.rctLinhas.Name = "rctLinhas"
        Me.rctLinhas.Size = New System.Drawing.Size(210, 25)
        '
        'rctColunas
        '
        Me.rctColunas.BackColor = System.Drawing.Color.White
        Me.rctColunas.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rctColunas.BorderColor = System.Drawing.Color.White
        Me.rctColunas.CornerRadius = 2
        Me.rctColunas.Location = New System.Drawing.Point(3, 88)
        Me.rctColunas.Name = "rctColunas"
        Me.rctColunas.Size = New System.Drawing.Size(210, 25)
        '
        'rctNome
        '
        Me.rctNome.BackColor = System.Drawing.Color.White
        Me.rctNome.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rctNome.BorderColor = System.Drawing.Color.White
        Me.rctNome.CornerRadius = 2
        Me.rctNome.Location = New System.Drawing.Point(3, 26)
        Me.rctNome.Name = "rctNome"
        Me.rctNome.Size = New System.Drawing.Size(210, 25)
        '
        'cmblocalidade
        '
        Me.cmblocalidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmblocalidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmblocalidade.BackColor = System.Drawing.Color.White
        Me.cmblocalidade.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmblocalidade.FormattingEnabled = True
        Me.cmblocalidade.Location = New System.Drawing.Point(11, 214)
        Me.cmblocalidade.MaxLength = 50
        Me.cmblocalidade.Name = "cmblocalidade"
        Me.cmblocalidade.Size = New System.Drawing.Size(193, 22)
        Me.cmblocalidade.TabIndex = 44
        Me.cmblocalidade.Tag = "localidade"
        '
        'pctTitulo
        '
        Me.pctTitulo.BackgroundImage = CType(resources.GetObject("pctTitulo.BackgroundImage"), System.Drawing.Image)
        Me.pctTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pctTitulo.Location = New System.Drawing.Point(3, 4)
        Me.pctTitulo.Name = "pctTitulo"
        Me.pctTitulo.Size = New System.Drawing.Size(88, 85)
        Me.pctTitulo.TabIndex = 50
        Me.pctTitulo.TabStop = False
        '
        'CtrL_MenuCine
        '
        Me.CtrL_MenuCine.Dock = System.Windows.Forms.DockStyle.Left
        Me.CtrL_MenuCine.Location = New System.Drawing.Point(0, 0)
        Me.CtrL_MenuCine.Name = "CtrL_MenuCine"
        Me.CtrL_MenuCine.Size = New System.Drawing.Size(49, 630)
        Me.CtrL_MenuCine.TabIndex = 0
        '
        'btnProcurar
        '
        Me.btnProcurar.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnProcurar.FlatAppearance.BorderSize = 0
        Me.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcurar.ForeColor = System.Drawing.Color.Black
        Me.btnProcurar.Location = New System.Drawing.Point(86, 266)
        Me.btnProcurar.Name = "btnProcurar"
        Me.btnProcurar.Size = New System.Drawing.Size(72, 22)
        Me.btnProcurar.TabIndex = 62
        Me.btnProcurar.Text = "Procurar"
        Me.btnProcurar.UseVisualStyleBackColor = False
        '
        'btnAlterar
        '
        Me.btnAlterar.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnAlterar.FlatAppearance.BorderSize = 0
        Me.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlterar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlterar.ForeColor = System.Drawing.Color.Black
        Me.btnAlterar.Location = New System.Drawing.Point(164, 266)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(77, 22)
        Me.btnAlterar.TabIndex = 63
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = False
        '
        'btnInserir
        '
        Me.btnInserir.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnInserir.FlatAppearance.BorderSize = 0
        Me.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInserir.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInserir.ForeColor = System.Drawing.Color.Black
        Me.btnInserir.Location = New System.Drawing.Point(3, 266)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Size = New System.Drawing.Size(77, 22)
        Me.btnInserir.TabIndex = 61
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.UseVisualStyleBackColor = False
        '
        'frmSalas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(790, 630)
        Me.Controls.Add(Me.flp1)
        Me.Controls.Add(Me.CtrL_MenuCine)
        Me.Controls.Add(Me.pnl1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSalas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salas"
        Me.pnl1.ResumeLayout(False)
        CType(Me.pctSalas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flp1.ResumeLayout(False)
        Me.tbc1.ResumeLayout(False)
        Me.tbpAtivado.ResumeLayout(False)
        CType(Me.dgvAtivado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpDesativado.ResumeLayout(False)
        CType(Me.dgvDesativado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlControlos.ResumeLayout(False)
        Me.pnlControlos.PerformLayout()
        Me.pnlProibicao.ResumeLayout(False)
        Me.pnlProibicao.PerformLayout()
        CType(Me.pct3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmrLinhas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmrColunas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAtivar.ResumeLayout(False)
        Me.pnlAtivar.PerformLayout()
        CType(Me.pctTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CtrL_MenuCine As PAP___Gestão_de_Cinema.CTRL_MenuCine
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents pctSalas As System.Windows.Forms.PictureBox
    Friend WithEvents flp1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents tbc1 As System.Windows.Forms.TabControl
    Friend WithEvents tbpAtivado As System.Windows.Forms.TabPage
    Friend WithEvents dgvAtivado As System.Windows.Forms.DataGridView
    Friend WithEvents tbpDesativado As System.Windows.Forms.TabPage
    Friend WithEvents dgvDesativado As System.Windows.Forms.DataGridView
    Friend WithEvents pnlControlos As System.Windows.Forms.Panel
    Friend WithEvents pnlProibicao As System.Windows.Forms.Panel
    Friend WithEvents pct3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblT As System.Windows.Forms.Label
    Friend WithEvents lblHammer As System.Windows.Forms.Label
    Friend WithEvents lbl73 As System.Windows.Forms.Label
    Friend WithEvents pnlAtivar As System.Windows.Forms.Panel
    Friend WithEvents btnDesativar As System.Windows.Forms.Button
    Friend WithEvents lbl92 As System.Windows.Forms.Label
    Friend WithEvents btnAtivar As System.Windows.Forms.Button
    Friend WithEvents lbl9 As System.Windows.Forms.Label
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents lblnome As System.Windows.Forms.Label
    Friend WithEvents lbl94 As System.Windows.Forms.Label
    Friend WithEvents lbl10 As System.Windows.Forms.Label
    Friend WithEvents lblColunas As System.Windows.Forms.Label
    Friend WithEvents lbl12 As System.Windows.Forms.Label
    Friend WithEvents lblLinhas As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl6 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents chknome As System.Windows.Forms.CheckBox
    Friend WithEvents cmbtipo As System.Windows.Forms.ComboBox
    Friend WithEvents chkcolunas As System.Windows.Forms.CheckBox
    Friend WithEvents chklinhas As System.Windows.Forms.CheckBox
    Friend WithEvents chktipo As System.Windows.Forms.CheckBox
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents lbl90 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents rctTipo As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rctLinhas As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rctColunas As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rctNome As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents cmblocalidade As System.Windows.Forms.ComboBox
    Friend WithEvents pctTitulo As System.Windows.Forms.PictureBox
    Friend WithEvents nmrLinhas As System.Windows.Forms.NumericUpDown
    Friend WithEvents nmrColunas As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnProcurar As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnInserir As System.Windows.Forms.Button
End Class
