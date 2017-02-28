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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEncargos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CtrL_MenuCine = New PAP___Gestão_de_Cinema.CTRL_MenuCine()
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.tbc1 = New System.Windows.Forms.TabControl()
        Me.tbpAtivado = New System.Windows.Forms.TabPage()
        Me.dgvAtivado = New System.Windows.Forms.DataGridView()
        Me.tbpDesativado = New System.Windows.Forms.TabPage()
        Me.dgvDesativado = New System.Windows.Forms.DataGridView()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.rctNome = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.lstTabelas = New System.Windows.Forms.ListBox()
        Me.lstTa_Enc = New System.Windows.Forms.ListBox()
        Me.btnAdi_Ta = New System.Windows.Forms.Button()
        Me.btnRet_Ta = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lstPermissoes = New System.Windows.Forms.ListBox()
        Me.lstPer_Ta = New System.Windows.Forms.ListBox()
        Me.btnInserir = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnDesativar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAtivar = New System.Windows.Forms.Button()
        Me.pnl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbc1.SuspendLayout()
        Me.tbpAtivado.SuspendLayout()
        CType(Me.dgvAtivado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpDesativado.SuspendLayout()
        CType(Me.dgvDesativado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CtrL_MenuCine
        '
        Me.CtrL_MenuCine.Dock = System.Windows.Forms.DockStyle.Left
        Me.CtrL_MenuCine.Location = New System.Drawing.Point(0, 0)
        Me.CtrL_MenuCine.Name = "CtrL_MenuCine"
        Me.CtrL_MenuCine.Size = New System.Drawing.Size(49, 666)
        Me.CtrL_MenuCine.TabIndex = 0
        '
        'pnl1
        '
        Me.pnl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnl1.Controls.Add(Me.PictureBox1)
        Me.pnl1.Controls.Add(Me.lbl1)
        Me.pnl1.Location = New System.Drawing.Point(74, 24)
        Me.pnl1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(634, 93)
        Me.pnl1.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(7, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 80)
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
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
        Me.tbc1.Location = New System.Drawing.Point(74, 123)
        Me.tbc1.Name = "tbc1"
        Me.tbc1.SelectedIndex = 0
        Me.tbc1.Size = New System.Drawing.Size(634, 148)
        Me.tbc1.TabIndex = 48
        '
        'tbpAtivado
        '
        Me.tbpAtivado.BackColor = System.Drawing.Color.Silver
        Me.tbpAtivado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpAtivado.Controls.Add(Me.dgvAtivado)
        Me.tbpAtivado.Location = New System.Drawing.Point(4, 23)
        Me.tbpAtivado.Name = "tbpAtivado"
        Me.tbpAtivado.Size = New System.Drawing.Size(626, 121)
        Me.tbpAtivado.TabIndex = 1
        Me.tbpAtivado.Text = "Encargos ativados"
        '
        'dgvAtivado
        '
        Me.dgvAtivado.AllowUserToAddRows = False
        Me.dgvAtivado.AllowUserToDeleteRows = False
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
        Me.dgvAtivado.Name = "dgvAtivado"
        Me.dgvAtivado.ReadOnly = True
        Me.dgvAtivado.RowHeadersVisible = False
        Me.dgvAtivado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvAtivado.Size = New System.Drawing.Size(624, 119)
        Me.dgvAtivado.TabIndex = 15
        '
        'tbpDesativado
        '
        Me.tbpDesativado.BackColor = System.Drawing.Color.Silver
        Me.tbpDesativado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbpDesativado.Controls.Add(Me.dgvDesativado)
        Me.tbpDesativado.Location = New System.Drawing.Point(4, 23)
        Me.tbpDesativado.Name = "tbpDesativado"
        Me.tbpDesativado.Size = New System.Drawing.Size(626, 121)
        Me.tbpDesativado.TabIndex = 2
        Me.tbpDesativado.Text = "Encargos desativados"
        '
        'dgvDesativado
        '
        Me.dgvDesativado.AllowUserToAddRows = False
        Me.dgvDesativado.AllowUserToDeleteRows = False
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
        Me.dgvDesativado.Name = "dgvDesativado"
        Me.dgvDesativado.ReadOnly = True
        Me.dgvDesativado.RowHeadersVisible = False
        Me.dgvDesativado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvDesativado.Size = New System.Drawing.Size(624, 119)
        Me.dgvDesativado.TabIndex = 16
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.White
        Me.lbl2.Location = New System.Drawing.Point(75, 283)
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
        Me.rctNome.Location = New System.Drawing.Point(75, 298)
        Me.rctNome.Name = "rctNome"
        Me.rctNome.Size = New System.Drawing.Size(210, 25)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.rctNome})
        Me.ShapeContainer1.Size = New System.Drawing.Size(735, 666)
        Me.ShapeContainer1.TabIndex = 50
        Me.ShapeContainer1.TabStop = False
        '
        'txtnome
        '
        Me.txtnome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnome.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnome.ForeColor = System.Drawing.Color.Black
        Me.txtnome.Location = New System.Drawing.Point(84, 304)
        Me.txtnome.MaxLength = 50
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(193, 14)
        Me.txtnome.TabIndex = 51
        Me.txtnome.Tag = "nome"
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnNovo.FlatAppearance.BorderSize = 0
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNovo.ForeColor = System.Drawing.Color.Black
        Me.btnNovo.Location = New System.Drawing.Point(314, 298)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(394, 26)
        Me.btnNovo.TabIndex = 52
        Me.btnNovo.Text = "Novo registo"
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'lstTabelas
        '
        Me.lstTabelas.BackColor = System.Drawing.Color.White
        Me.lstTabelas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstTabelas.FormattingEnabled = True
        Me.lstTabelas.Location = New System.Drawing.Point(74, 369)
        Me.lstTabelas.Name = "lstTabelas"
        Me.lstTabelas.Size = New System.Drawing.Size(120, 145)
        Me.lstTabelas.TabIndex = 53
        '
        'lstTa_Enc
        '
        Me.lstTa_Enc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.lstTa_Enc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstTa_Enc.FormattingEnabled = True
        Me.lstTa_Enc.Location = New System.Drawing.Point(242, 369)
        Me.lstTa_Enc.Name = "lstTa_Enc"
        Me.lstTa_Enc.Size = New System.Drawing.Size(120, 145)
        Me.lstTa_Enc.TabIndex = 54
        '
        'btnAdi_Ta
        '
        Me.btnAdi_Ta.BackColor = System.Drawing.Color.Transparent
        Me.btnAdi_Ta.BackgroundImage = CType(resources.GetObject("btnAdi_Ta.BackgroundImage"), System.Drawing.Image)
        Me.btnAdi_Ta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAdi_Ta.FlatAppearance.BorderSize = 0
        Me.btnAdi_Ta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdi_Ta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdi_Ta.ForeColor = System.Drawing.Color.Black
        Me.btnAdi_Ta.Location = New System.Drawing.Point(203, 369)
        Me.btnAdi_Ta.Name = "btnAdi_Ta"
        Me.btnAdi_Ta.Size = New System.Drawing.Size(29, 26)
        Me.btnAdi_Ta.TabIndex = 57
        Me.btnAdi_Ta.UseVisualStyleBackColor = False
        '
        'btnRet_Ta
        '
        Me.btnRet_Ta.BackColor = System.Drawing.Color.Transparent
        Me.btnRet_Ta.BackgroundImage = CType(resources.GetObject("btnRet_Ta.BackgroundImage"), System.Drawing.Image)
        Me.btnRet_Ta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRet_Ta.FlatAppearance.BorderSize = 0
        Me.btnRet_Ta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRet_Ta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRet_Ta.ForeColor = System.Drawing.Color.Black
        Me.btnRet_Ta.Location = New System.Drawing.Point(203, 488)
        Me.btnRet_Ta.Name = "btnRet_Ta"
        Me.btnRet_Ta.Size = New System.Drawing.Size(29, 26)
        Me.btnRet_Ta.TabIndex = 58
        Me.btnRet_Ta.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(549, 369)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(29, 26)
        Me.Button1.TabIndex = 62
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(549, 488)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(29, 26)
        Me.Button2.TabIndex = 61
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lstPermissoes
        '
        Me.lstPermissoes.BackColor = System.Drawing.Color.White
        Me.lstPermissoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstPermissoes.FormattingEnabled = True
        Me.lstPermissoes.Location = New System.Drawing.Point(588, 369)
        Me.lstPermissoes.Name = "lstPermissoes"
        Me.lstPermissoes.Size = New System.Drawing.Size(120, 145)
        Me.lstPermissoes.TabIndex = 60
        '
        'lstPer_Ta
        '
        Me.lstPer_Ta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.lstPer_Ta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstPer_Ta.FormattingEnabled = True
        Me.lstPer_Ta.Location = New System.Drawing.Point(420, 369)
        Me.lstPer_Ta.Name = "lstPer_Ta"
        Me.lstPer_Ta.Size = New System.Drawing.Size(120, 145)
        Me.lstPer_Ta.TabIndex = 59
        '
        'btnInserir
        '
        Me.btnInserir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnInserir.FlatAppearance.BorderSize = 0
        Me.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInserir.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInserir.ForeColor = System.Drawing.Color.Black
        Me.btnInserir.Location = New System.Drawing.Point(74, 538)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Size = New System.Drawing.Size(202, 26)
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
        Me.btnAlterar.Location = New System.Drawing.Point(290, 538)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(202, 26)
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
        Me.btnDesativar.Location = New System.Drawing.Point(506, 538)
        Me.btnDesativar.Name = "btnDesativar"
        Me.btnDesativar.Size = New System.Drawing.Size(202, 26)
        Me.btnDesativar.TabIndex = 65
        Me.btnDesativar.Text = "Desativar"
        Me.btnDesativar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(239, 351)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 15)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Tabelas do Encargo:"
        '
        'Label2
        '
        Me.Label2.AllowDrop = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(417, 339)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 30)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Permissões nessa Tabela:"
        '
        'btnAtivar
        '
        Me.btnAtivar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAtivar.FlatAppearance.BorderSize = 0
        Me.btnAtivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtivar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtivar.ForeColor = System.Drawing.Color.Black
        Me.btnAtivar.Location = New System.Drawing.Point(506, 538)
        Me.btnAtivar.Name = "btnAtivar"
        Me.btnAtivar.Size = New System.Drawing.Size(202, 26)
        Me.btnAtivar.TabIndex = 68
        Me.btnAtivar.Text = "Ativar"
        Me.btnAtivar.UseVisualStyleBackColor = False
        '
        'frmEncargos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(735, 666)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDesativar)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnInserir)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lstPermissoes)
        Me.Controls.Add(Me.lstPer_Ta)
        Me.Controls.Add(Me.btnRet_Ta)
        Me.Controls.Add(Me.btnAdi_Ta)
        Me.Controls.Add(Me.lstTa_Enc)
        Me.Controls.Add(Me.lstTabelas)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.txtnome)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.tbc1)
        Me.Controls.Add(Me.pnl1)
        Me.Controls.Add(Me.CtrL_MenuCine)
        Me.Controls.Add(Me.btnAtivar)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEncargos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Encargos"
        Me.pnl1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbc1.ResumeLayout(False)
        Me.tbpAtivado.ResumeLayout(False)
        CType(Me.dgvAtivado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpDesativado.ResumeLayout(False)
        CType(Me.dgvDesativado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CtrL_MenuCine As PAP___Gestão_de_Cinema.CTRL_MenuCine
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tbc1 As System.Windows.Forms.TabControl
    Friend WithEvents tbpAtivado As System.Windows.Forms.TabPage
    Friend WithEvents dgvAtivado As System.Windows.Forms.DataGridView
    Friend WithEvents tbpDesativado As System.Windows.Forms.TabPage
    Friend WithEvents dgvDesativado As System.Windows.Forms.DataGridView
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents rctNome As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents lstTabelas As System.Windows.Forms.ListBox
    Friend WithEvents lstTa_Enc As System.Windows.Forms.ListBox
    Friend WithEvents btnAdi_Ta As System.Windows.Forms.Button
    Friend WithEvents btnRet_Ta As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lstPermissoes As System.Windows.Forms.ListBox
    Friend WithEvents lstPer_Ta As System.Windows.Forms.ListBox
    Friend WithEvents btnInserir As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnDesativar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAtivar As System.Windows.Forms.Button
End Class
