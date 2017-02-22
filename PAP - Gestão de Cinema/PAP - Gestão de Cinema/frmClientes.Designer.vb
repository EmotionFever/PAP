<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.pct1 = New System.Windows.Forms.PictureBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lblNIF = New System.Windows.Forms.Label()
        Me.lblTlm = New System.Windows.Forms.Label()
        Me.lblnome = New System.Windows.Forms.Label()
        Me.lblRua = New System.Windows.Forms.Label()
        Me.lbl13 = New System.Windows.Forms.Label()
        Me.lbl12 = New System.Windows.Forms.Label()
        Me.lbl10 = New System.Windows.Forms.Label()
        Me.lbl9 = New System.Windows.Forms.Label()
        Me.chkLocalidade = New System.Windows.Forms.CheckBox()
        Me.chkRua = New System.Windows.Forms.CheckBox()
        Me.chkNIF = New System.Windows.Forms.CheckBox()
        Me.chknome = New System.Windows.Forms.CheckBox()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.rctNome = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.rctTlm = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rctLocalidade = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rctRua = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rctNIF = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.txtRua = New System.Windows.Forms.TextBox()
        Me.lbl90 = New System.Windows.Forms.Label()
        Me.lbl91 = New System.Windows.Forms.Label()
        Me.chkTlm = New System.Windows.Forms.CheckBox()
        Me.mtbTlm = New System.Windows.Forms.MaskedTextBox()
        Me.mtbNIF = New System.Windows.Forms.MaskedTextBox()
        Me.btnInserir = New System.Windows.Forms.Button()
        Me.btnProcurar = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.lbl92 = New System.Windows.Forms.Label()
        Me.btnDesativar = New System.Windows.Forms.Button()
        Me.cmblocalidade = New System.Windows.Forms.ComboBox()
        Me.lbl94 = New System.Windows.Forms.Label()
        Me.lblLocalidade = New System.Windows.Forms.Label()
        Me.CtrL_MenuCine = New PAP___Gestão_de_Cinema.CTRL_MenuCine()
        Me.pnl1.SuspendLayout()
        CType(Me.pct1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnl1.Controls.Add(Me.pct1)
        Me.pnl1.Controls.Add(Me.lbl1)
        Me.pnl1.Location = New System.Drawing.Point(74, 24)
        Me.pnl1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(682, 93)
        Me.pnl1.TabIndex = 4
        '
        'pct1
        '
        Me.pct1.BackgroundImage = CType(resources.GetObject("pct1.BackgroundImage"), System.Drawing.Image)
        Me.pct1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pct1.Location = New System.Drawing.Point(3, 5)
        Me.pct1.Name = "pct1"
        Me.pct1.Size = New System.Drawing.Size(88, 88)
        Me.pct1.TabIndex = 42
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
        Me.lbl1.Text = "Clientes"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNIF
        '
        Me.lblNIF.AutoSize = True
        Me.lblNIF.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNIF.ForeColor = System.Drawing.Color.White
        Me.lblNIF.Location = New System.Drawing.Point(627, 537)
        Me.lblNIF.Name = "lblNIF"
        Me.lblNIF.Size = New System.Drawing.Size(19, 14)
        Me.lblNIF.TabIndex = 17
        Me.lblNIF.Text = "---"
        '
        'lblTlm
        '
        Me.lblTlm.AutoSize = True
        Me.lblTlm.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTlm.ForeColor = System.Drawing.Color.White
        Me.lblTlm.Location = New System.Drawing.Point(627, 579)
        Me.lblTlm.Name = "lblTlm"
        Me.lblTlm.Size = New System.Drawing.Size(19, 14)
        Me.lblTlm.TabIndex = 20
        Me.lblTlm.Text = "---"
        '
        'lblnome
        '
        Me.lblnome.AutoSize = True
        Me.lblnome.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnome.ForeColor = System.Drawing.Color.White
        Me.lblnome.Location = New System.Drawing.Point(627, 523)
        Me.lblnome.Name = "lblnome"
        Me.lblnome.Size = New System.Drawing.Size(19, 14)
        Me.lblnome.TabIndex = 16
        Me.lblnome.Text = "---"
        '
        'lblRua
        '
        Me.lblRua.AutoEllipsis = True
        Me.lblRua.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRua.ForeColor = System.Drawing.Color.White
        Me.lblRua.Location = New System.Drawing.Point(627, 551)
        Me.lblRua.Name = "lblRua"
        Me.lblRua.Size = New System.Drawing.Size(131, 14)
        Me.lblRua.TabIndex = 19
        Me.lblRua.Text = "---"
        '
        'lbl13
        '
        Me.lbl13.AutoSize = True
        Me.lbl13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl13.ForeColor = System.Drawing.Color.White
        Me.lbl13.Location = New System.Drawing.Point(535, 579)
        Me.lbl13.Name = "lbl13"
        Me.lbl13.Size = New System.Drawing.Size(57, 14)
        Me.lbl13.TabIndex = 11
        Me.lbl13.Text = "Telemóvel:"
        '
        'lbl12
        '
        Me.lbl12.AutoSize = True
        Me.lbl12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl12.ForeColor = System.Drawing.Color.White
        Me.lbl12.Location = New System.Drawing.Point(535, 551)
        Me.lbl12.Name = "lbl12"
        Me.lbl12.Size = New System.Drawing.Size(29, 14)
        Me.lbl12.TabIndex = 9
        Me.lbl12.Text = "Rua:"
        '
        'lbl10
        '
        Me.lbl10.AutoSize = True
        Me.lbl10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl10.ForeColor = System.Drawing.Color.White
        Me.lbl10.Location = New System.Drawing.Point(535, 537)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(25, 14)
        Me.lbl10.TabIndex = 5
        Me.lbl10.Text = "NIF:"
        '
        'lbl9
        '
        Me.lbl9.AutoSize = True
        Me.lbl9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl9.ForeColor = System.Drawing.Color.White
        Me.lbl9.Location = New System.Drawing.Point(535, 523)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Size = New System.Drawing.Size(87, 14)
        Me.lbl9.TabIndex = 0
        Me.lbl9.Text = "Nome do Cliente:"
        '
        'chkLocalidade
        '
        Me.chkLocalidade.AutoSize = True
        Me.chkLocalidade.Location = New System.Drawing.Point(743, 342)
        Me.chkLocalidade.Name = "chkLocalidade"
        Me.chkLocalidade.Size = New System.Drawing.Size(15, 14)
        Me.chkLocalidade.TabIndex = 25
        Me.chkLocalidade.UseVisualStyleBackColor = True
        '
        'chkRua
        '
        Me.chkRua.AutoSize = True
        Me.chkRua.Location = New System.Drawing.Point(743, 281)
        Me.chkRua.Name = "chkRua"
        Me.chkRua.Size = New System.Drawing.Size(15, 14)
        Me.chkRua.TabIndex = 24
        Me.chkRua.UseVisualStyleBackColor = True
        '
        'chkNIF
        '
        Me.chkNIF.AutoSize = True
        Me.chkNIF.Location = New System.Drawing.Point(743, 218)
        Me.chkNIF.Name = "chkNIF"
        Me.chkNIF.Size = New System.Drawing.Size(15, 14)
        Me.chkNIF.TabIndex = 23
        Me.chkNIF.UseVisualStyleBackColor = True
        '
        'chknome
        '
        Me.chknome.AutoSize = True
        Me.chknome.Location = New System.Drawing.Point(743, 156)
        Me.chknome.Name = "chknome"
        Me.chknome.Size = New System.Drawing.Size(15, 14)
        Me.chknome.TabIndex = 22
        Me.chknome.UseVisualStyleBackColor = True
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl6.ForeColor = System.Drawing.Color.White
        Me.lbl6.Location = New System.Drawing.Point(518, 258)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(32, 15)
        Me.lbl6.TabIndex = 22
        Me.lbl6.Text = "Rua:"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl3.ForeColor = System.Drawing.Color.White
        Me.lbl3.Location = New System.Drawing.Point(518, 196)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(217, 15)
        Me.lbl3.TabIndex = 21
        Me.lbl3.Text = "*Número de Indetificação Fiscal (NIF):"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.White
        Me.lbl2.Location = New System.Drawing.Point(518, 135)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(107, 15)
        Me.lbl2.TabIndex = 20
        Me.lbl2.Text = "*Nome do Cliente:"
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.BackgroundColor = System.Drawing.Color.DimGray
        Me.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(74, 134)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv1.RowHeadersVisible = False
        Me.dgv1.Size = New System.Drawing.Size(436, 489)
        Me.dgv1.TabIndex = 15
        '
        'rctNome
        '
        Me.rctNome.BackColor = System.Drawing.Color.White
        Me.rctNome.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rctNome.BorderColor = System.Drawing.Color.White
        Me.rctNome.CornerRadius = 2
        Me.rctNome.Location = New System.Drawing.Point(521, 150)
        Me.rctNome.Name = "rctNome"
        Me.rctNome.Size = New System.Drawing.Size(210, 25)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.rctTlm, Me.rctLocalidade, Me.rctRua, Me.rctNIF, Me.rctNome})
        Me.ShapeContainer1.Size = New System.Drawing.Size(781, 643)
        Me.ShapeContainer1.TabIndex = 26
        Me.ShapeContainer1.TabStop = False
        '
        'rctTlm
        '
        Me.rctTlm.BackColor = System.Drawing.Color.White
        Me.rctTlm.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rctTlm.BorderColor = System.Drawing.Color.White
        Me.rctTlm.CornerRadius = 2
        Me.rctTlm.Location = New System.Drawing.Point(521, 401)
        Me.rctTlm.Name = "rctTlm"
        Me.rctTlm.Size = New System.Drawing.Size(210, 25)
        '
        'rctLocalidade
        '
        Me.rctLocalidade.BackColor = System.Drawing.Color.White
        Me.rctLocalidade.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rctLocalidade.BorderColor = System.Drawing.Color.White
        Me.rctLocalidade.CornerRadius = 2
        Me.rctLocalidade.Location = New System.Drawing.Point(520, 336)
        Me.rctLocalidade.Name = "rctLocalidade"
        Me.rctLocalidade.Size = New System.Drawing.Size(210, 25)
        '
        'rctRua
        '
        Me.rctRua.BackColor = System.Drawing.Color.White
        Me.rctRua.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rctRua.BorderColor = System.Drawing.Color.White
        Me.rctRua.CornerRadius = 2
        Me.rctRua.Location = New System.Drawing.Point(521, 274)
        Me.rctRua.Name = "rctRua"
        Me.rctRua.Size = New System.Drawing.Size(210, 25)
        '
        'rctNIF
        '
        Me.rctNIF.BackColor = System.Drawing.Color.White
        Me.rctNIF.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rctNIF.BorderColor = System.Drawing.Color.White
        Me.rctNIF.CornerRadius = 2
        Me.rctNIF.Location = New System.Drawing.Point(521, 212)
        Me.rctNIF.Name = "rctNIF"
        Me.rctNIF.Size = New System.Drawing.Size(210, 25)
        '
        'txtnome
        '
        Me.txtnome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnome.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnome.ForeColor = System.Drawing.Color.Black
        Me.txtnome.Location = New System.Drawing.Point(530, 156)
        Me.txtnome.MaxLength = 50
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(193, 14)
        Me.txtnome.TabIndex = 27
        Me.txtnome.Tag = ""
        '
        'txtRua
        '
        Me.txtRua.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRua.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRua.ForeColor = System.Drawing.Color.Black
        Me.txtRua.Location = New System.Drawing.Point(530, 280)
        Me.txtRua.MaxLength = 100
        Me.txtRua.Name = "txtRua"
        Me.txtRua.Size = New System.Drawing.Size(193, 14)
        Me.txtRua.TabIndex = 28
        Me.txtRua.Tag = ""
        '
        'lbl90
        '
        Me.lbl90.AutoSize = True
        Me.lbl90.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl90.ForeColor = System.Drawing.Color.White
        Me.lbl90.Location = New System.Drawing.Point(518, 321)
        Me.lbl90.Name = "lbl90"
        Me.lbl90.Size = New System.Drawing.Size(77, 15)
        Me.lbl90.TabIndex = 29
        Me.lbl90.Text = "*Localidade:"
        '
        'lbl91
        '
        Me.lbl91.AutoSize = True
        Me.lbl91.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl91.ForeColor = System.Drawing.Color.White
        Me.lbl91.Location = New System.Drawing.Point(518, 385)
        Me.lbl91.Name = "lbl91"
        Me.lbl91.Size = New System.Drawing.Size(67, 15)
        Me.lbl91.TabIndex = 31
        Me.lbl91.Text = "Telemóvel:"
        '
        'chkTlm
        '
        Me.chkTlm.AutoSize = True
        Me.chkTlm.Location = New System.Drawing.Point(743, 408)
        Me.chkTlm.Name = "chkTlm"
        Me.chkTlm.Size = New System.Drawing.Size(15, 14)
        Me.chkTlm.TabIndex = 32
        Me.chkTlm.UseVisualStyleBackColor = True
        '
        'mtbTlm
        '
        Me.mtbTlm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtbTlm.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.mtbTlm.Location = New System.Drawing.Point(529, 408)
        Me.mtbTlm.Mask = "000000000"
        Me.mtbTlm.Name = "mtbTlm"
        Me.mtbTlm.Size = New System.Drawing.Size(195, 14)
        Me.mtbTlm.TabIndex = 33
        '
        'mtbNIF
        '
        Me.mtbNIF.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtbNIF.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.mtbNIF.Location = New System.Drawing.Point(528, 218)
        Me.mtbNIF.Mask = "000000000"
        Me.mtbNIF.Name = "mtbNIF"
        Me.mtbNIF.Size = New System.Drawing.Size(195, 14)
        Me.mtbNIF.TabIndex = 35
        '
        'btnInserir
        '
        Me.btnInserir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnInserir.FlatAppearance.BorderSize = 0
        Me.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInserir.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInserir.ForeColor = System.Drawing.Color.Black
        Me.btnInserir.Location = New System.Drawing.Point(520, 464)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Size = New System.Drawing.Size(77, 22)
        Me.btnInserir.TabIndex = 39
        Me.btnInserir.Text = "Inserir"
        Me.btnInserir.UseVisualStyleBackColor = False
        '
        'btnProcurar
        '
        Me.btnProcurar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnProcurar.FlatAppearance.BorderSize = 0
        Me.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcurar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcurar.ForeColor = System.Drawing.Color.Black
        Me.btnProcurar.Location = New System.Drawing.Point(603, 464)
        Me.btnProcurar.Name = "btnProcurar"
        Me.btnProcurar.Size = New System.Drawing.Size(72, 22)
        Me.btnProcurar.TabIndex = 40
        Me.btnProcurar.Text = "Procurar"
        Me.btnProcurar.UseVisualStyleBackColor = False
        '
        'btnAlterar
        '
        Me.btnAlterar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAlterar.FlatAppearance.BorderSize = 0
        Me.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlterar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlterar.ForeColor = System.Drawing.Color.Black
        Me.btnAlterar.Location = New System.Drawing.Point(681, 464)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(77, 22)
        Me.btnAlterar.TabIndex = 41
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = False
        '
        'lbl92
        '
        Me.lbl92.AutoSize = True
        Me.lbl92.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl92.ForeColor = System.Drawing.Color.White
        Me.lbl92.Location = New System.Drawing.Point(517, 502)
        Me.lbl92.Name = "lbl92"
        Me.lbl92.Size = New System.Drawing.Size(118, 15)
        Me.lbl92.TabIndex = 42
        Me.lbl92.Text = "Cliente selecionado"
        '
        'btnDesativar
        '
        Me.btnDesativar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDesativar.FlatAppearance.BorderSize = 0
        Me.btnDesativar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDesativar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesativar.ForeColor = System.Drawing.Color.Black
        Me.btnDesativar.Location = New System.Drawing.Point(520, 602)
        Me.btnDesativar.Name = "btnDesativar"
        Me.btnDesativar.Size = New System.Drawing.Size(236, 22)
        Me.btnDesativar.TabIndex = 43
        Me.btnDesativar.Text = "Desativar Cliente"
        Me.btnDesativar.UseVisualStyleBackColor = False
        '
        'cmblocalidade
        '
        Me.cmblocalidade.BackColor = System.Drawing.Color.White
        Me.cmblocalidade.FormattingEnabled = True
        Me.cmblocalidade.Location = New System.Drawing.Point(530, 338)
        Me.cmblocalidade.Name = "cmblocalidade"
        Me.cmblocalidade.Size = New System.Drawing.Size(193, 21)
        Me.cmblocalidade.TabIndex = 44
        '
        'lbl94
        '
        Me.lbl94.AutoSize = True
        Me.lbl94.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl94.ForeColor = System.Drawing.Color.White
        Me.lbl94.Location = New System.Drawing.Point(535, 565)
        Me.lbl94.Name = "lbl94"
        Me.lbl94.Size = New System.Drawing.Size(62, 14)
        Me.lbl94.TabIndex = 45
        Me.lbl94.Text = "Localidade:"
        '
        'lblLocalidade
        '
        Me.lblLocalidade.AutoSize = True
        Me.lblLocalidade.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalidade.ForeColor = System.Drawing.Color.White
        Me.lblLocalidade.Location = New System.Drawing.Point(627, 565)
        Me.lblLocalidade.Name = "lblLocalidade"
        Me.lblLocalidade.Size = New System.Drawing.Size(19, 14)
        Me.lblLocalidade.TabIndex = 46
        Me.lblLocalidade.Text = "---"
        '
        'CtrL_MenuCine
        '
        Me.CtrL_MenuCine.Dock = System.Windows.Forms.DockStyle.Left
        Me.CtrL_MenuCine.Location = New System.Drawing.Point(0, 0)
        Me.CtrL_MenuCine.Name = "CtrL_MenuCine"
        Me.CtrL_MenuCine.Size = New System.Drawing.Size(49, 643)
        Me.CtrL_MenuCine.TabIndex = 0
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(781, 643)
        Me.Controls.Add(Me.lblLocalidade)
        Me.Controls.Add(Me.lbl94)
        Me.Controls.Add(Me.cmblocalidade)
        Me.Controls.Add(Me.btnDesativar)
        Me.Controls.Add(Me.lblTlm)
        Me.Controls.Add(Me.lbl13)
        Me.Controls.Add(Me.lblRua)
        Me.Controls.Add(Me.lbl12)
        Me.Controls.Add(Me.lblNIF)
        Me.Controls.Add(Me.lbl10)
        Me.Controls.Add(Me.lblnome)
        Me.Controls.Add(Me.lbl9)
        Me.Controls.Add(Me.lbl92)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnProcurar)
        Me.Controls.Add(Me.btnInserir)
        Me.Controls.Add(Me.CtrL_MenuCine)
        Me.Controls.Add(Me.mtbNIF)
        Me.Controls.Add(Me.mtbTlm)
        Me.Controls.Add(Me.chkTlm)
        Me.Controls.Add(Me.lbl91)
        Me.Controls.Add(Me.lbl90)
        Me.Controls.Add(Me.txtRua)
        Me.Controls.Add(Me.txtnome)
        Me.Controls.Add(Me.chkLocalidade)
        Me.Controls.Add(Me.chkRua)
        Me.Controls.Add(Me.chkNIF)
        Me.Controls.Add(Me.pnl1)
        Me.Controls.Add(Me.chknome)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        Me.pnl1.ResumeLayout(False)
        CType(Me.pct1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CtrL_MenuCine As PAP___Gestão_de_Cinema.CTRL_MenuCine
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lblNIF As System.Windows.Forms.Label
    Friend WithEvents lblTlm As System.Windows.Forms.Label
    Friend WithEvents lblnome As System.Windows.Forms.Label
    Friend WithEvents lblRua As System.Windows.Forms.Label
    Friend WithEvents lbl13 As System.Windows.Forms.Label
    Friend WithEvents lbl12 As System.Windows.Forms.Label
    Friend WithEvents lbl10 As System.Windows.Forms.Label
    Friend WithEvents lbl9 As System.Windows.Forms.Label
    Friend WithEvents chkLocalidade As System.Windows.Forms.CheckBox
    Friend WithEvents chkRua As System.Windows.Forms.CheckBox
    Friend WithEvents chkNIF As System.Windows.Forms.CheckBox
    Friend WithEvents chknome As System.Windows.Forms.CheckBox
    Friend WithEvents lbl6 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents rctNome As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents rctLocalidade As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rctRua As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rctNIF As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents txtRua As System.Windows.Forms.TextBox
    Friend WithEvents lbl90 As System.Windows.Forms.Label
    Friend WithEvents rctTlm As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lbl91 As System.Windows.Forms.Label
    Friend WithEvents chkTlm As System.Windows.Forms.CheckBox
    Friend WithEvents mtbTlm As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbNIF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnInserir As System.Windows.Forms.Button
    Friend WithEvents btnProcurar As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents pct1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl92 As System.Windows.Forms.Label
    Friend WithEvents btnDesativar As System.Windows.Forms.Button
    Friend WithEvents cmblocalidade As System.Windows.Forms.ComboBox
    Friend WithEvents lbl94 As System.Windows.Forms.Label
    Friend WithEvents lblLocalidade As System.Windows.Forms.Label
End Class
