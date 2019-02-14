<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEncargos
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEncargos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.pctTitulo = New System.Windows.Forms.PictureBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.tbc1 = New System.Windows.Forms.TabControl()
        Me.tbpAtivado = New System.Windows.Forms.TabPage()
        Me.lstEnc_Ativ = New System.Windows.Forms.ListBox()
        Me.dgvEnc_Ta_Ativ = New System.Windows.Forms.DataGridView()
        Me.tbpDesativado = New System.Windows.Forms.TabPage()
        Me.lstEnc_Desa = New System.Windows.Forms.ListBox()
        Me.dgvEnc_Ta_Desa = New System.Windows.Forms.DataGridView()
        Me.pnlInformacao = New System.Windows.Forms.Panel()
        Me.pct3 = New System.Windows.Forms.PictureBox()
        Me.pct2 = New System.Windows.Forms.PictureBox()
        Me.lblT = New System.Windows.Forms.Label()
        Me.lblSeta = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.rctNome = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.lstTabelas = New System.Windows.Forms.ListBox()
        Me.lstTa_Enc = New System.Windows.Forms.ListBox()
        Me.lstPermissoes = New System.Windows.Forms.ListBox()
        Me.lstTa_Per = New System.Windows.Forms.ListBox()
        Me.btnInserir = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnDesativar = New System.Windows.Forms.Button()
        Me.lbl784 = New System.Windows.Forms.Label()
        Me.lbl83 = New System.Windows.Forms.Label()
        Me.btnAtivar = New System.Windows.Forms.Button()
        Me.pnlMostrar = New System.Windows.Forms.Panel()
        Me.pnlControlos = New System.Windows.Forms.Panel()
        Me.pnlProibicao = New System.Windows.Forms.Panel()
        Me.pctInfo = New System.Windows.Forms.PictureBox()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lblHammer = New System.Windows.Forms.Label()
        Me.lbl0 = New System.Windows.Forms.Label()
        Me.lbl67 = New System.Windows.Forms.Label()
        Me.lbl87 = New System.Windows.Forms.Label()
        Me.btnAdi_Ta = New System.Windows.Forms.Button()
        Me.btnRet_Ta = New System.Windows.Forms.Button()
        Me.btnAdi_Pe = New System.Windows.Forms.Button()
        Me.btnRet_Pe = New System.Windows.Forms.Button()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.flp1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.CtrL_MenuCine = New PAP___Gestão_de_Cinema.CTRL_MenuCine()
        Me.tlt1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnl1.SuspendLayout()
        CType(Me.pctTitulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbc1.SuspendLayout()
        Me.tbpAtivado.SuspendLayout()
        CType(Me.dgvEnc_Ta_Ativ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpDesativado.SuspendLayout()
        CType(Me.dgvEnc_Ta_Desa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInformacao.SuspendLayout()
        CType(Me.pct3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMostrar.SuspendLayout()
        Me.pnlControlos.SuspendLayout()
        Me.pnlProibicao.SuspendLayout()
        CType(Me.pctInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flp1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnl1.Controls.Add(Me.pctTitulo)
        Me.pnl1.Controls.Add(Me.lbl1)
        Me.pnl1.Location = New System.Drawing.Point(74, 24)
        Me.pnl1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(634, 93)
        Me.pnl1.TabIndex = 5
        '
        'pctTitulo
        '
        Me.pctTitulo.BackgroundImage = CType(resources.GetObject("pctTitulo.BackgroundImage"), System.Drawing.Image)
        Me.pctTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pctTitulo.Location = New System.Drawing.Point(7, 8)
        Me.pctTitulo.Name = "pctTitulo"
        Me.pctTitulo.Size = New System.Drawing.Size(78, 80)
        Me.pctTitulo.TabIndex = 51
        Me.pctTitulo.TabStop = False
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.lbl1.ForeColor = System.Drawing.Color.Black
        Me.lbl1.Location = New System.Drawing.Point(96, 21)
        Me.lbl1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(538, 55)
        Me.lbl1.TabIndex = 4
        Me.lbl1.Text = "Encargos"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbc1
        '
        Me.tbc1.Controls.Add(Me.tbpAtivado)
        Me.tbc1.Controls.Add(Me.tbpDesativado)
        Me.tbc1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbc1.Location = New System.Drawing.Point(1, 0)
        Me.tbc1.Name = "tbc1"
        Me.tbc1.SelectedIndex = 0
        Me.tbc1.Size = New System.Drawing.Size(634, 148)
        Me.tbc1.TabIndex = 48
        '
        'tbpAtivado
        '
        Me.tbpAtivado.BackColor = System.Drawing.Color.Silver
        Me.tbpAtivado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpAtivado.Controls.Add(Me.lstEnc_Ativ)
        Me.tbpAtivado.Controls.Add(Me.dgvEnc_Ta_Ativ)
        Me.tbpAtivado.Location = New System.Drawing.Point(4, 23)
        Me.tbpAtivado.Name = "tbpAtivado"
        Me.tbpAtivado.Size = New System.Drawing.Size(626, 121)
        Me.tbpAtivado.TabIndex = 1
        Me.tbpAtivado.Text = "Encargos ativados"
        '
        'lstEnc_Ativ
        '
        Me.lstEnc_Ativ.BackColor = System.Drawing.Color.White
        Me.lstEnc_Ativ.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstEnc_Ativ.Dock = System.Windows.Forms.DockStyle.Left
        Me.lstEnc_Ativ.FormattingEnabled = True
        Me.lstEnc_Ativ.ItemHeight = 14
        Me.lstEnc_Ativ.Location = New System.Drawing.Point(0, 0)
        Me.lstEnc_Ativ.Name = "lstEnc_Ativ"
        Me.lstEnc_Ativ.Size = New System.Drawing.Size(158, 119)
        Me.lstEnc_Ativ.TabIndex = 69
        '
        'dgvEnc_Ta_Ativ
        '
        Me.dgvEnc_Ta_Ativ.AllowUserToAddRows = False
        Me.dgvEnc_Ta_Ativ.AllowUserToDeleteRows = False
        Me.dgvEnc_Ta_Ativ.AllowUserToResizeColumns = False
        Me.dgvEnc_Ta_Ativ.AllowUserToResizeRows = False
        Me.dgvEnc_Ta_Ativ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvEnc_Ta_Ativ.BackgroundColor = System.Drawing.Color.DimGray
        Me.dgvEnc_Ta_Ativ.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEnc_Ta_Ativ.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEnc_Ta_Ativ.Dock = System.Windows.Forms.DockStyle.Right
        Me.dgvEnc_Ta_Ativ.Location = New System.Drawing.Point(159, 0)
        Me.dgvEnc_Ta_Ativ.MultiSelect = False
        Me.dgvEnc_Ta_Ativ.Name = "dgvEnc_Ta_Ativ"
        Me.dgvEnc_Ta_Ativ.ReadOnly = True
        Me.dgvEnc_Ta_Ativ.RowHeadersVisible = False
        Me.dgvEnc_Ta_Ativ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEnc_Ta_Ativ.Size = New System.Drawing.Size(465, 119)
        Me.dgvEnc_Ta_Ativ.TabIndex = 16
        '
        'tbpDesativado
        '
        Me.tbpDesativado.BackColor = System.Drawing.Color.Silver
        Me.tbpDesativado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpDesativado.Controls.Add(Me.lstEnc_Desa)
        Me.tbpDesativado.Controls.Add(Me.dgvEnc_Ta_Desa)
        Me.tbpDesativado.Location = New System.Drawing.Point(4, 23)
        Me.tbpDesativado.Name = "tbpDesativado"
        Me.tbpDesativado.Size = New System.Drawing.Size(626, 121)
        Me.tbpDesativado.TabIndex = 2
        Me.tbpDesativado.Text = "Encargos desativados"
        '
        'lstEnc_Desa
        '
        Me.lstEnc_Desa.BackColor = System.Drawing.Color.White
        Me.lstEnc_Desa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstEnc_Desa.Dock = System.Windows.Forms.DockStyle.Left
        Me.lstEnc_Desa.FormattingEnabled = True
        Me.lstEnc_Desa.ItemHeight = 14
        Me.lstEnc_Desa.Location = New System.Drawing.Point(0, 0)
        Me.lstEnc_Desa.Name = "lstEnc_Desa"
        Me.lstEnc_Desa.Size = New System.Drawing.Size(158, 119)
        Me.lstEnc_Desa.TabIndex = 72
        '
        'dgvEnc_Ta_Desa
        '
        Me.dgvEnc_Ta_Desa.AllowUserToAddRows = False
        Me.dgvEnc_Ta_Desa.AllowUserToDeleteRows = False
        Me.dgvEnc_Ta_Desa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvEnc_Ta_Desa.BackgroundColor = System.Drawing.Color.DimGray
        Me.dgvEnc_Ta_Desa.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEnc_Ta_Desa.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEnc_Ta_Desa.Dock = System.Windows.Forms.DockStyle.Right
        Me.dgvEnc_Ta_Desa.Location = New System.Drawing.Point(159, 0)
        Me.dgvEnc_Ta_Desa.Name = "dgvEnc_Ta_Desa"
        Me.dgvEnc_Ta_Desa.ReadOnly = True
        Me.dgvEnc_Ta_Desa.RowHeadersVisible = False
        Me.dgvEnc_Ta_Desa.Size = New System.Drawing.Size(465, 119)
        Me.dgvEnc_Ta_Desa.TabIndex = 71
        '
        'pnlInformacao
        '
        Me.pnlInformacao.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnlInformacao.Controls.Add(Me.pct3)
        Me.pnlInformacao.Controls.Add(Me.pct2)
        Me.pnlInformacao.Controls.Add(Me.lblT)
        Me.pnlInformacao.Controls.Add(Me.lblSeta)
        Me.pnlInformacao.Location = New System.Drawing.Point(165, 23)
        Me.pnlInformacao.Name = "pnlInformacao"
        Me.pnlInformacao.Size = New System.Drawing.Size(466, 121)
        Me.pnlInformacao.TabIndex = 70
        '
        'pct3
        '
        Me.pct3.BackColor = System.Drawing.Color.Transparent
        Me.pct3.BackgroundImage = CType(resources.GetObject("pct3.BackgroundImage"), System.Drawing.Image)
        Me.pct3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pct3.Location = New System.Drawing.Point(436, 92)
        Me.pct3.Name = "pct3"
        Me.pct3.Size = New System.Drawing.Size(30, 28)
        Me.pct3.TabIndex = 53
        Me.pct3.TabStop = False
        Me.tlt1.SetToolTip(Me.pct3, "Informação")
        '
        'pct2
        '
        Me.pct2.BackColor = System.Drawing.Color.White
        Me.pct2.BackgroundImage = CType(resources.GetObject("pct2.BackgroundImage"), System.Drawing.Image)
        Me.pct2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pct2.Location = New System.Drawing.Point(94, 47)
        Me.pct2.Name = "pct2"
        Me.pct2.Size = New System.Drawing.Size(30, 28)
        Me.pct2.TabIndex = 52
        Me.pct2.TabStop = False
        '
        'lblT
        '
        Me.lblT.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblT.Location = New System.Drawing.Point(135, 40)
        Me.lblT.Name = "lblT"
        Me.lblT.Size = New System.Drawing.Size(266, 57)
        Me.lblT.TabIndex = 0
        Me.lblT.Text = "Carregue num Encargo para ver, aqui, as suas permissões"
        '
        'lblSeta
        '
        Me.lblSeta.AutoSize = True
        Me.lblSeta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblSeta.Font = New System.Drawing.Font("Arial", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeta.ForeColor = System.Drawing.Color.White
        Me.lblSeta.Location = New System.Drawing.Point(28, 7)
        Me.lblSeta.Name = "lblSeta"
        Me.lblSeta.Size = New System.Drawing.Size(140, 107)
        Me.lblSeta.TabIndex = 1
        Me.lblSeta.Text = "◄"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.White
        Me.lbl2.Location = New System.Drawing.Point(1, 7)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(115, 15)
        Me.lbl2.TabIndex = 49
        Me.lbl2.Text = "*Nome do Encargo:"
        '
        'rctNome
        '
        Me.rctNome.BackColor = System.Drawing.Color.White
        Me.rctNome.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rctNome.BorderColor = System.Drawing.Color.White
        Me.rctNome.CornerRadius = 2
        Me.rctNome.Location = New System.Drawing.Point(1, 22)
        Me.rctNome.Name = "rctNome"
        Me.rctNome.Size = New System.Drawing.Size(210, 25)
        '
        'txtnome
        '
        Me.txtnome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnome.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnome.ForeColor = System.Drawing.Color.Black
        Me.txtnome.Location = New System.Drawing.Point(10, 28)
        Me.txtnome.MaxLength = 50
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(193, 14)
        Me.txtnome.TabIndex = 51
        Me.txtnome.Tag = "0"
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnNovo.FlatAppearance.BorderSize = 0
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.ForeColor = System.Drawing.Color.Black
        Me.btnNovo.Location = New System.Drawing.Point(240, 22)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(394, 26)
        Me.btnNovo.TabIndex = 52
        Me.btnNovo.Text = "Novo registo"
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'lstTabelas
        '
        Me.lstTabelas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.lstTabelas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstTabelas.FormattingEnabled = True
        Me.lstTabelas.Location = New System.Drawing.Point(0, 93)
        Me.lstTabelas.Name = "lstTabelas"
        Me.lstTabelas.Size = New System.Drawing.Size(120, 119)
        Me.lstTabelas.TabIndex = 53
        '
        'lstTa_Enc
        '
        Me.lstTa_Enc.BackColor = System.Drawing.Color.White
        Me.lstTa_Enc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstTa_Enc.FormattingEnabled = True
        Me.lstTa_Enc.Location = New System.Drawing.Point(168, 93)
        Me.lstTa_Enc.Name = "lstTa_Enc"
        Me.lstTa_Enc.Size = New System.Drawing.Size(120, 119)
        Me.lstTa_Enc.TabIndex = 54
        Me.lstTa_Enc.Tag = "0"
        '
        'lstPermissoes
        '
        Me.lstPermissoes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.lstPermissoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstPermissoes.FormattingEnabled = True
        Me.lstPermissoes.Location = New System.Drawing.Point(514, 93)
        Me.lstPermissoes.Name = "lstPermissoes"
        Me.lstPermissoes.Size = New System.Drawing.Size(120, 119)
        Me.lstPermissoes.TabIndex = 60
        '
        'lstTa_Per
        '
        Me.lstTa_Per.BackColor = System.Drawing.Color.White
        Me.lstTa_Per.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstTa_Per.FormattingEnabled = True
        Me.lstTa_Per.Location = New System.Drawing.Point(346, 93)
        Me.lstTa_Per.Name = "lstTa_Per"
        Me.lstTa_Per.Size = New System.Drawing.Size(120, 119)
        Me.lstTa_Per.TabIndex = 59
        Me.lstTa_Per.Tag = "0"
        '
        'btnInserir
        '
        Me.btnInserir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnInserir.FlatAppearance.BorderSize = 0
        Me.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInserir.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInserir.ForeColor = System.Drawing.Color.Black
        Me.btnInserir.Location = New System.Drawing.Point(0, 232)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Size = New System.Drawing.Size(315, 26)
        Me.btnInserir.TabIndex = 63
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.UseVisualStyleBackColor = False
        '
        'btnAlterar
        '
        Me.btnAlterar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAlterar.FlatAppearance.BorderSize = 0
        Me.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlterar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlterar.ForeColor = System.Drawing.Color.Black
        Me.btnAlterar.Location = New System.Drawing.Point(321, 232)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(312, 26)
        Me.btnAlterar.TabIndex = 64
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = False
        '
        'btnDesativar
        '
        Me.btnDesativar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDesativar.FlatAppearance.BorderSize = 0
        Me.btnDesativar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDesativar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesativar.ForeColor = System.Drawing.Color.Black
        Me.btnDesativar.Location = New System.Drawing.Point(-1, 264)
        Me.btnDesativar.Name = "btnDesativar"
        Me.btnDesativar.Size = New System.Drawing.Size(635, 26)
        Me.btnDesativar.TabIndex = 65
        Me.btnDesativar.Text = "Desativar"
        Me.btnDesativar.UseVisualStyleBackColor = False
        '
        'lbl784
        '
        Me.lbl784.AutoSize = True
        Me.lbl784.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl784.ForeColor = System.Drawing.Color.White
        Me.lbl784.Location = New System.Drawing.Point(165, 75)
        Me.lbl784.Name = "lbl784"
        Me.lbl784.Size = New System.Drawing.Size(121, 15)
        Me.lbl784.TabIndex = 66
        Me.lbl784.Text = "Tabelas do Encargo:"
        '
        'lbl83
        '
        Me.lbl83.AllowDrop = True
        Me.lbl83.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl83.ForeColor = System.Drawing.Color.White
        Me.lbl83.Location = New System.Drawing.Point(343, 63)
        Me.lbl83.Name = "lbl83"
        Me.lbl83.Size = New System.Drawing.Size(121, 30)
        Me.lbl83.TabIndex = 67
        Me.lbl83.Text = "Permissões nessa Tabela:"
        '
        'btnAtivar
        '
        Me.btnAtivar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAtivar.FlatAppearance.BorderSize = 0
        Me.btnAtivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtivar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtivar.ForeColor = System.Drawing.Color.Black
        Me.btnAtivar.Location = New System.Drawing.Point(-1, 264)
        Me.btnAtivar.Name = "btnAtivar"
        Me.btnAtivar.Size = New System.Drawing.Size(635, 26)
        Me.btnAtivar.TabIndex = 68
        Me.btnAtivar.Text = "Ativar"
        Me.btnAtivar.UseVisualStyleBackColor = False
        '
        'pnlMostrar
        '
        Me.pnlMostrar.Controls.Add(Me.pnlInformacao)
        Me.pnlMostrar.Controls.Add(Me.tbc1)
        Me.pnlMostrar.Location = New System.Drawing.Point(3, 3)
        Me.pnlMostrar.Name = "pnlMostrar"
        Me.pnlMostrar.Size = New System.Drawing.Size(634, 153)
        Me.pnlMostrar.TabIndex = 71
        '
        'pnlControlos
        '
        Me.pnlControlos.Controls.Add(Me.pnlProibicao)
        Me.pnlControlos.Controls.Add(Me.lbl67)
        Me.pnlControlos.Controls.Add(Me.lbl87)
        Me.pnlControlos.Controls.Add(Me.btnDesativar)
        Me.pnlControlos.Controls.Add(Me.btnAtivar)
        Me.pnlControlos.Controls.Add(Me.lbl2)
        Me.pnlControlos.Controls.Add(Me.txtnome)
        Me.pnlControlos.Controls.Add(Me.lbl83)
        Me.pnlControlos.Controls.Add(Me.btnNovo)
        Me.pnlControlos.Controls.Add(Me.lbl784)
        Me.pnlControlos.Controls.Add(Me.lstTabelas)
        Me.pnlControlos.Controls.Add(Me.lstTa_Enc)
        Me.pnlControlos.Controls.Add(Me.btnAlterar)
        Me.pnlControlos.Controls.Add(Me.btnAdi_Ta)
        Me.pnlControlos.Controls.Add(Me.btnInserir)
        Me.pnlControlos.Controls.Add(Me.btnRet_Ta)
        Me.pnlControlos.Controls.Add(Me.btnAdi_Pe)
        Me.pnlControlos.Controls.Add(Me.lstTa_Per)
        Me.pnlControlos.Controls.Add(Me.btnRet_Pe)
        Me.pnlControlos.Controls.Add(Me.lstPermissoes)
        Me.pnlControlos.Controls.Add(Me.ShapeContainer2)
        Me.pnlControlos.Location = New System.Drawing.Point(3, 162)
        Me.pnlControlos.Name = "pnlControlos"
        Me.pnlControlos.Size = New System.Drawing.Size(644, 325)
        Me.pnlControlos.TabIndex = 72
        '
        'pnlProibicao
        '
        Me.pnlProibicao.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnlProibicao.Controls.Add(Me.pctInfo)
        Me.pnlProibicao.Controls.Add(Me.lbl3)
        Me.pnlProibicao.Controls.Add(Me.lblHammer)
        Me.pnlProibicao.Controls.Add(Me.lbl0)
        Me.pnlProibicao.Location = New System.Drawing.Point(646, 0)
        Me.pnlProibicao.Name = "pnlProibicao"
        Me.pnlProibicao.Size = New System.Drawing.Size(635, 258)
        Me.pnlProibicao.TabIndex = 74
        Me.pnlProibicao.Visible = False
        '
        'pctInfo
        '
        Me.pctInfo.BackColor = System.Drawing.Color.Transparent
        Me.pctInfo.BackgroundImage = CType(resources.GetObject("pctInfo.BackgroundImage"), System.Drawing.Image)
        Me.pctInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pctInfo.Location = New System.Drawing.Point(0, 230)
        Me.pctInfo.Name = "pctInfo"
        Me.pctInfo.Size = New System.Drawing.Size(30, 28)
        Me.pctInfo.TabIndex = 54
        Me.pctInfo.TabStop = False
        Me.tlt1.SetToolTip(Me.pctInfo, "Informação")
        '
        'lbl3
        '
        Me.lbl3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(145, 104)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(333, 54)
        Me.lbl3.TabIndex = 51
        Me.lbl3.Text = "Só pode realizar ações enquanto estiver na aba dos registos ativados"
        Me.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHammer
        '
        Me.lblHammer.AutoSize = True
        Me.lblHammer.BackColor = System.Drawing.Color.Transparent
        Me.lblHammer.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHammer.ForeColor = System.Drawing.Color.Red
        Me.lblHammer.Location = New System.Drawing.Point(251, 0)
        Me.lblHammer.Name = "lblHammer"
        Me.lblHammer.Size = New System.Drawing.Size(125, 108)
        Me.lblHammer.TabIndex = 0
        Me.lblHammer.Text = "🛠"
        '
        'lbl0
        '
        Me.lbl0.AutoSize = True
        Me.lbl0.BackColor = System.Drawing.Color.Transparent
        Me.lbl0.Font = New System.Drawing.Font("Microsoft Sans Serif", 170.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl0.Location = New System.Drawing.Point(435, 51)
        Me.lbl0.Name = "lbl0"
        Me.lbl0.Size = New System.Drawing.Size(299, 257)
        Me.lbl0.TabIndex = 1
        Me.lbl0.Text = "🛠"
        '
        'lbl67
        '
        Me.lbl67.AutoSize = True
        Me.lbl67.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl67.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl67.ForeColor = System.Drawing.Color.White
        Me.lbl67.Location = New System.Drawing.Point(514, 75)
        Me.lbl67.Name = "lbl67"
        Me.lbl67.Size = New System.Drawing.Size(81, 17)
        Me.lbl67.TabIndex = 77
        Me.lbl67.Text = "Permissões:"
        Me.tlt1.SetToolTip(Me.lbl67, "Permissões são aquilo que o utilizador pode fazer numa tabela")
        '
        'lbl87
        '
        Me.lbl87.AutoSize = True
        Me.lbl87.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl87.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl87.ForeColor = System.Drawing.Color.White
        Me.lbl87.Location = New System.Drawing.Point(1, 75)
        Me.lbl87.Name = "lbl87"
        Me.lbl87.Size = New System.Drawing.Size(56, 17)
        Me.lbl87.TabIndex = 76
        Me.lbl87.Text = "Tabelas:"
        Me.tlt1.SetToolTip(Me.lbl87, "Tabelas são partes do programa que o utilizador pode ter acesso")
        '
        'btnAdi_Ta
        '
        Me.btnAdi_Ta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdi_Ta.BackgroundImage = CType(resources.GetObject("btnAdi_Ta.BackgroundImage"), System.Drawing.Image)
        Me.btnAdi_Ta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAdi_Ta.FlatAppearance.BorderSize = 0
        Me.btnAdi_Ta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdi_Ta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnAdi_Ta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdi_Ta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdi_Ta.ForeColor = System.Drawing.Color.Black
        Me.btnAdi_Ta.Location = New System.Drawing.Point(131, 93)
        Me.btnAdi_Ta.Name = "btnAdi_Ta"
        Me.btnAdi_Ta.Size = New System.Drawing.Size(26, 26)
        Me.btnAdi_Ta.TabIndex = 57
        Me.tlt1.SetToolTip(Me.btnAdi_Ta, "Adicionar tabela")
        Me.btnAdi_Ta.UseVisualStyleBackColor = False
        '
        'btnRet_Ta
        '
        Me.btnRet_Ta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRet_Ta.BackgroundImage = CType(resources.GetObject("btnRet_Ta.BackgroundImage"), System.Drawing.Image)
        Me.btnRet_Ta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRet_Ta.FlatAppearance.BorderSize = 0
        Me.btnRet_Ta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRet_Ta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnRet_Ta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRet_Ta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRet_Ta.ForeColor = System.Drawing.Color.Black
        Me.btnRet_Ta.Location = New System.Drawing.Point(130, 186)
        Me.btnRet_Ta.Name = "btnRet_Ta"
        Me.btnRet_Ta.Size = New System.Drawing.Size(26, 26)
        Me.btnRet_Ta.TabIndex = 58
        Me.tlt1.SetToolTip(Me.btnRet_Ta, "Retirar tabela")
        Me.btnRet_Ta.UseVisualStyleBackColor = False
        '
        'btnAdi_Pe
        '
        Me.btnAdi_Pe.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAdi_Pe.BackgroundImage = CType(resources.GetObject("btnAdi_Pe.BackgroundImage"), System.Drawing.Image)
        Me.btnAdi_Pe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAdi_Pe.FlatAppearance.BorderSize = 0
        Me.btnAdi_Pe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAdi_Pe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnAdi_Pe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdi_Pe.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdi_Pe.ForeColor = System.Drawing.Color.Black
        Me.btnAdi_Pe.Location = New System.Drawing.Point(476, 93)
        Me.btnAdi_Pe.Name = "btnAdi_Pe"
        Me.btnAdi_Pe.Size = New System.Drawing.Size(26, 26)
        Me.btnAdi_Pe.TabIndex = 62
        Me.tlt1.SetToolTip(Me.btnAdi_Pe, "Adicionar permissão")
        Me.btnAdi_Pe.UseVisualStyleBackColor = False
        '
        'btnRet_Pe
        '
        Me.btnRet_Pe.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRet_Pe.BackgroundImage = CType(resources.GetObject("btnRet_Pe.BackgroundImage"), System.Drawing.Image)
        Me.btnRet_Pe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRet_Pe.FlatAppearance.BorderSize = 0
        Me.btnRet_Pe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRet_Pe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnRet_Pe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRet_Pe.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRet_Pe.ForeColor = System.Drawing.Color.Black
        Me.btnRet_Pe.Location = New System.Drawing.Point(476, 186)
        Me.btnRet_Pe.Name = "btnRet_Pe"
        Me.btnRet_Pe.Size = New System.Drawing.Size(26, 26)
        Me.btnRet_Pe.TabIndex = 61
        Me.tlt1.SetToolTip(Me.btnRet_Pe, "Retirar permissão")
        Me.btnRet_Pe.UseVisualStyleBackColor = False
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.rctNome})
        Me.ShapeContainer2.Size = New System.Drawing.Size(644, 325)
        Me.ShapeContainer2.TabIndex = 0
        Me.ShapeContainer2.TabStop = False
        '
        'flp1
        '
        Me.flp1.Controls.Add(Me.pnlMostrar)
        Me.flp1.Controls.Add(Me.pnlControlos)
        Me.flp1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flp1.Location = New System.Drawing.Point(72, 118)
        Me.flp1.Name = "flp1"
        Me.flp1.Size = New System.Drawing.Size(654, 493)
        Me.flp1.TabIndex = 73
        '
        'CtrL_MenuCine
        '
        Me.CtrL_MenuCine.Dock = System.Windows.Forms.DockStyle.Left
        Me.CtrL_MenuCine.Location = New System.Drawing.Point(0, 0)
        Me.CtrL_MenuCine.Name = "CtrL_MenuCine"
        Me.CtrL_MenuCine.Size = New System.Drawing.Size(49, 623)
        Me.CtrL_MenuCine.TabIndex = 0
        '
        'tlt1
        '
        Me.tlt1.AutomaticDelay = 100
        Me.tlt1.AutoPopDelay = 7000
        Me.tlt1.InitialDelay = 100
        Me.tlt1.ReshowDelay = 20
        '
        'frmEncargos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(734, 623)
        Me.Controls.Add(Me.CtrL_MenuCine)
        Me.Controls.Add(Me.flp1)
        Me.Controls.Add(Me.pnl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEncargos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Encargos"
        Me.pnl1.ResumeLayout(False)
        CType(Me.pctTitulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbc1.ResumeLayout(False)
        Me.tbpAtivado.ResumeLayout(False)
        CType(Me.dgvEnc_Ta_Ativ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpDesativado.ResumeLayout(False)
        CType(Me.dgvEnc_Ta_Desa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInformacao.ResumeLayout(False)
        Me.pnlInformacao.PerformLayout()
        CType(Me.pct3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMostrar.ResumeLayout(False)
        Me.pnlControlos.ResumeLayout(False)
        Me.pnlControlos.PerformLayout()
        Me.pnlProibicao.ResumeLayout(False)
        Me.pnlProibicao.PerformLayout()
        CType(Me.pctInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flp1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CtrL_MenuCine As PAP___Gestão_de_Cinema.CTRL_MenuCine
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents pctTitulo As System.Windows.Forms.PictureBox
    Friend WithEvents tbc1 As System.Windows.Forms.TabControl
    Friend WithEvents tbpAtivado As System.Windows.Forms.TabPage
    Friend WithEvents tbpDesativado As System.Windows.Forms.TabPage
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents rctNome As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents lstTabelas As System.Windows.Forms.ListBox
    Friend WithEvents lstTa_Enc As System.Windows.Forms.ListBox
    Friend WithEvents btnAdi_Ta As System.Windows.Forms.Button
    Friend WithEvents btnRet_Ta As System.Windows.Forms.Button
    Friend WithEvents btnAdi_Pe As System.Windows.Forms.Button
    Friend WithEvents btnRet_Pe As System.Windows.Forms.Button
    Friend WithEvents lstPermissoes As System.Windows.Forms.ListBox
    Friend WithEvents lstTa_Per As System.Windows.Forms.ListBox
    Friend WithEvents btnInserir As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnDesativar As System.Windows.Forms.Button
    Friend WithEvents lbl784 As System.Windows.Forms.Label
    Friend WithEvents lbl83 As System.Windows.Forms.Label
    Friend WithEvents btnAtivar As System.Windows.Forms.Button
    Friend WithEvents dgvEnc_Ta_Ativ As System.Windows.Forms.DataGridView
    Friend WithEvents lstEnc_Ativ As System.Windows.Forms.ListBox
    Friend WithEvents pnlInformacao As System.Windows.Forms.Panel
    Friend WithEvents pct3 As System.Windows.Forms.PictureBox
    Friend WithEvents pct2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblT As System.Windows.Forms.Label
    Friend WithEvents lblSeta As System.Windows.Forms.Label
    Friend WithEvents lstEnc_Desa As System.Windows.Forms.ListBox
    Friend WithEvents dgvEnc_Ta_Desa As System.Windows.Forms.DataGridView
    Friend WithEvents pnlMostrar As System.Windows.Forms.Panel
    Friend WithEvents pnlControlos As System.Windows.Forms.Panel
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents flp1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents pnlProibicao As System.Windows.Forms.Panel
    Friend WithEvents pctInfo As System.Windows.Forms.PictureBox
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lblHammer As System.Windows.Forms.Label
    Friend WithEvents lbl0 As System.Windows.Forms.Label
    Friend WithEvents tlt1 As System.Windows.Forms.ToolTip
    Friend WithEvents lbl67 As System.Windows.Forms.Label
    Friend WithEvents lbl87 As System.Windows.Forms.Label
End Class
