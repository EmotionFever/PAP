<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDefinicoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDefinicoes))
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.grb1 = New System.Windows.Forms.GroupBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnUsername = New System.Windows.Forms.Button()
        Me.lbl67 = New System.Windows.Forms.Label()
        Me.chkTexto = New System.Windows.Forms.CheckBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.btnPass = New System.Windows.Forms.Button()
        Me.lbl89 = New System.Windows.Forms.Label()
        Me.mtbTlm = New System.Windows.Forms.MaskedTextBox()
        Me.btnTlm = New System.Windows.Forms.Button()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.btnOutra = New System.Windows.Forms.Button()
        Me.btnLocalidade = New System.Windows.Forms.Button()
        Me.cmblocalidade = New System.Windows.Forms.ComboBox()
        Me.txtrua = New System.Windows.Forms.TextBox()
        Me.btnRua = New System.Windows.Forms.Button()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.btnDatanasc = New System.Windows.Forms.Button()
        Me.dtpDatanasc = New System.Windows.Forms.DateTimePicker()
        Me.btnNome = New System.Windows.Forms.Button()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.rct56 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rct5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rct3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rct4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rct2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rct1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rctNome = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.pctFuncionario = New System.Windows.Forms.PictureBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblIdade = New System.Windows.Forms.Label()
        Me.lblRua = New System.Windows.Forms.Label()
        Me.lblLocalidade = New System.Windows.Forms.Label()
        Me.lblTlm = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.tmrPiscar = New System.Windows.Forms.Timer(Me.components)
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.CtrL_MenuCine = New PAP___Gestão_de_Cinema.CTRL_MenuCine()
        Me.pnl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grb1.SuspendLayout()
        CType(Me.pctFuncionario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BackColor = System.Drawing.Color.PeachPuff
        Me.pnl1.Controls.Add(Me.PictureBox1)
        Me.pnl1.Controls.Add(Me.lbl1)
        Me.pnl1.Location = New System.Drawing.Point(74, 24)
        Me.pnl1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(692, 93)
        Me.pnl1.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(3, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 85)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.lbl1.ForeColor = System.Drawing.Color.Black
        Me.lbl1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl1.Location = New System.Drawing.Point(94, 21)
        Me.lbl1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(593, 52)
        Me.lbl1.TabIndex = 4
        Me.lbl1.Text = "Definições"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl2.Location = New System.Drawing.Point(18, 27)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(78, 15)
        Me.lbl2.TabIndex = 21
        Me.lbl2.Text = "O seu nome:"
        '
        'grb1
        '
        Me.grb1.Controls.Add(Me.txtUsername)
        Me.grb1.Controls.Add(Me.btnUsername)
        Me.grb1.Controls.Add(Me.lbl67)
        Me.grb1.Controls.Add(Me.chkTexto)
        Me.grb1.Controls.Add(Me.txtPass)
        Me.grb1.Controls.Add(Me.btnPass)
        Me.grb1.Controls.Add(Me.lbl89)
        Me.grb1.Controls.Add(Me.mtbTlm)
        Me.grb1.Controls.Add(Me.btnTlm)
        Me.grb1.Controls.Add(Me.lbl6)
        Me.grb1.Controls.Add(Me.btnOutra)
        Me.grb1.Controls.Add(Me.btnLocalidade)
        Me.grb1.Controls.Add(Me.cmblocalidade)
        Me.grb1.Controls.Add(Me.txtrua)
        Me.grb1.Controls.Add(Me.btnRua)
        Me.grb1.Controls.Add(Me.lbl5)
        Me.grb1.Controls.Add(Me.lbl4)
        Me.grb1.Controls.Add(Me.btnDatanasc)
        Me.grb1.Controls.Add(Me.dtpDatanasc)
        Me.grb1.Controls.Add(Me.btnNome)
        Me.grb1.Controls.Add(Me.lbl3)
        Me.grb1.Controls.Add(Me.txtnome)
        Me.grb1.Controls.Add(Me.lbl2)
        Me.grb1.Controls.Add(Me.ShapeContainer1)
        Me.grb1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.grb1.ForeColor = System.Drawing.Color.White
        Me.grb1.Location = New System.Drawing.Point(74, 293)
        Me.grb1.Name = "grb1"
        Me.grb1.Size = New System.Drawing.Size(694, 297)
        Me.grb1.TabIndex = 22
        Me.grb1.TabStop = False
        Me.grb1.Text = "Alterar informações"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.Location = New System.Drawing.Point(30, 110)
        Me.txtUsername.MaxLength = 50
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(193, 14)
        Me.txtUsername.TabIndex = 55
        Me.txtUsername.Tag = ""
        '
        'btnUsername
        '
        Me.btnUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnUsername.FlatAppearance.BorderSize = 0
        Me.btnUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsername.Image = CType(resources.GetObject("btnUsername.Image"), System.Drawing.Image)
        Me.btnUsername.Location = New System.Drawing.Point(246, 100)
        Me.btnUsername.Name = "btnUsername"
        Me.btnUsername.Size = New System.Drawing.Size(29, 31)
        Me.btnUsername.TabIndex = 54
        Me.btnUsername.UseVisualStyleBackColor = False
        '
        'lbl67
        '
        Me.lbl67.AutoSize = True
        Me.lbl67.BackColor = System.Drawing.Color.Transparent
        Me.lbl67.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl67.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl67.Location = New System.Drawing.Point(19, 89)
        Me.lbl67.Name = "lbl67"
        Me.lbl67.Size = New System.Drawing.Size(150, 15)
        Me.lbl67.TabIndex = 53
        Me.lbl67.Text = "O seu nome de utilizador:"
        '
        'chkTexto
        '
        Me.chkTexto.AutoSize = True
        Me.chkTexto.Location = New System.Drawing.Point(281, 170)
        Me.chkTexto.Name = "chkTexto"
        Me.chkTexto.Size = New System.Drawing.Size(54, 19)
        Me.chkTexto.TabIndex = 52
        Me.chkTexto.Text = "Texto"
        Me.chkTexto.UseVisualStyleBackColor = True
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPass.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.Black
        Me.txtPass.Location = New System.Drawing.Point(30, 173)
        Me.txtPass.MaxLength = 50
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(193, 14)
        Me.txtPass.TabIndex = 51
        Me.txtPass.Tag = ""
        Me.txtPass.UseSystemPasswordChar = True
        '
        'btnPass
        '
        Me.btnPass.BackColor = System.Drawing.Color.Silver
        Me.btnPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPass.FlatAppearance.BorderSize = 0
        Me.btnPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPass.Image = CType(resources.GetObject("btnPass.Image"), System.Drawing.Image)
        Me.btnPass.Location = New System.Drawing.Point(246, 163)
        Me.btnPass.Name = "btnPass"
        Me.btnPass.Size = New System.Drawing.Size(29, 31)
        Me.btnPass.TabIndex = 50
        Me.btnPass.UseVisualStyleBackColor = False
        '
        'lbl89
        '
        Me.lbl89.AutoSize = True
        Me.lbl89.BackColor = System.Drawing.Color.Transparent
        Me.lbl89.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl89.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl89.Location = New System.Drawing.Point(19, 152)
        Me.lbl89.Name = "lbl89"
        Me.lbl89.Size = New System.Drawing.Size(126, 15)
        Me.lbl89.TabIndex = 49
        Me.lbl89.Text = "A sua palavra-passe:"
        '
        'mtbTlm
        '
        Me.mtbTlm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.mtbTlm.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtbTlm.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.mtbTlm.Location = New System.Drawing.Point(365, 238)
        Me.mtbTlm.Mask = "000000000"
        Me.mtbTlm.Name = "mtbTlm"
        Me.mtbTlm.Size = New System.Drawing.Size(193, 14)
        Me.mtbTlm.TabIndex = 48
        '
        'btnTlm
        '
        Me.btnTlm.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTlm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnTlm.FlatAppearance.BorderSize = 0
        Me.btnTlm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTlm.Image = CType(resources.GetObject("btnTlm.Image"), System.Drawing.Image)
        Me.btnTlm.Location = New System.Drawing.Point(578, 230)
        Me.btnTlm.Name = "btnTlm"
        Me.btnTlm.Size = New System.Drawing.Size(29, 31)
        Me.btnTlm.TabIndex = 40
        Me.btnTlm.UseVisualStyleBackColor = False
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl6.Location = New System.Drawing.Point(353, 217)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(165, 15)
        Me.lbl6.TabIndex = 39
        Me.lbl6.Text = "O seu número de telemóvel:"
        '
        'btnOutra
        '
        Me.btnOutra.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnOutra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnOutra.FlatAppearance.BorderSize = 0
        Me.btnOutra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOutra.ForeColor = System.Drawing.Color.Black
        Me.btnOutra.Location = New System.Drawing.Point(613, 163)
        Me.btnOutra.Name = "btnOutra"
        Me.btnOutra.Size = New System.Drawing.Size(46, 31)
        Me.btnOutra.TabIndex = 38
        Me.btnOutra.Text = "Outra"
        Me.btnOutra.UseVisualStyleBackColor = False
        '
        'btnLocalidade
        '
        Me.btnLocalidade.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLocalidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLocalidade.FlatAppearance.BorderSize = 0
        Me.btnLocalidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLocalidade.Image = CType(resources.GetObject("btnLocalidade.Image"), System.Drawing.Image)
        Me.btnLocalidade.Location = New System.Drawing.Point(578, 163)
        Me.btnLocalidade.Name = "btnLocalidade"
        Me.btnLocalidade.Size = New System.Drawing.Size(29, 31)
        Me.btnLocalidade.TabIndex = 37
        Me.btnLocalidade.UseVisualStyleBackColor = False
        '
        'cmblocalidade
        '
        Me.cmblocalidade.BackColor = System.Drawing.Color.White
        Me.cmblocalidade.FormattingEnabled = True
        Me.cmblocalidade.Location = New System.Drawing.Point(365, 168)
        Me.cmblocalidade.Name = "cmblocalidade"
        Me.cmblocalidade.Size = New System.Drawing.Size(193, 23)
        Me.cmblocalidade.TabIndex = 23
        '
        'txtrua
        '
        Me.txtrua.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtrua.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtrua.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrua.ForeColor = System.Drawing.Color.Black
        Me.txtrua.Location = New System.Drawing.Point(365, 111)
        Me.txtrua.MaxLength = 100
        Me.txtrua.Name = "txtrua"
        Me.txtrua.Size = New System.Drawing.Size(193, 14)
        Me.txtrua.TabIndex = 36
        Me.txtrua.Tag = ""
        '
        'btnRua
        '
        Me.btnRua.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRua.FlatAppearance.BorderSize = 0
        Me.btnRua.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRua.Image = CType(resources.GetObject("btnRua.Image"), System.Drawing.Image)
        Me.btnRua.Location = New System.Drawing.Point(578, 102)
        Me.btnRua.Name = "btnRua"
        Me.btnRua.Size = New System.Drawing.Size(29, 31)
        Me.btnRua.TabIndex = 35
        Me.btnRua.UseVisualStyleBackColor = False
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl5.Location = New System.Drawing.Point(353, 152)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(103, 15)
        Me.lbl5.TabIndex = 34
        Me.lbl5.Text = "A sua localidade:"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl4.Location = New System.Drawing.Point(353, 89)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(64, 15)
        Me.lbl4.TabIndex = 33
        Me.lbl4.Text = "A sua rua:"
        '
        'btnDatanasc
        '
        Me.btnDatanasc.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDatanasc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDatanasc.FlatAppearance.BorderSize = 0
        Me.btnDatanasc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDatanasc.Image = CType(resources.GetObject("btnDatanasc.Image"), System.Drawing.Image)
        Me.btnDatanasc.Location = New System.Drawing.Point(578, 40)
        Me.btnDatanasc.Name = "btnDatanasc"
        Me.btnDatanasc.Size = New System.Drawing.Size(29, 31)
        Me.btnDatanasc.TabIndex = 32
        Me.btnDatanasc.UseVisualStyleBackColor = False
        '
        'dtpDatanasc
        '
        Me.dtpDatanasc.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpDatanasc.Cursor = System.Windows.Forms.Cursors.Default
        Me.dtpDatanasc.CustomFormat = ""
        Me.dtpDatanasc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDatanasc.Location = New System.Drawing.Point(365, 44)
        Me.dtpDatanasc.Name = "dtpDatanasc"
        Me.dtpDatanasc.Size = New System.Drawing.Size(193, 21)
        Me.dtpDatanasc.TabIndex = 31
        '
        'btnNome
        '
        Me.btnNome.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnNome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnNome.FlatAppearance.BorderSize = 0
        Me.btnNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNome.Image = CType(resources.GetObject("btnNome.Image"), System.Drawing.Image)
        Me.btnNome.Location = New System.Drawing.Point(246, 40)
        Me.btnNome.Name = "btnNome"
        Me.btnNome.Size = New System.Drawing.Size(29, 31)
        Me.btnNome.TabIndex = 30
        Me.btnNome.UseVisualStyleBackColor = False
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl3.Location = New System.Drawing.Point(353, 27)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(157, 15)
        Me.lbl3.TabIndex = 29
        Me.lbl3.Text = "A sua data de nascimento:"
        '
        'txtnome
        '
        Me.txtnome.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtnome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnome.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnome.ForeColor = System.Drawing.Color.Black
        Me.txtnome.Location = New System.Drawing.Point(30, 48)
        Me.txtnome.MaxLength = 100
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(193, 14)
        Me.txtnome.TabIndex = 28
        Me.txtnome.Tag = ""
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 17)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.rct56, Me.rct5, Me.rct3, Me.rct4, Me.rct2, Me.rct1, Me.rctNome})
        Me.ShapeContainer1.Size = New System.Drawing.Size(688, 277)
        Me.ShapeContainer1.TabIndex = 22
        Me.ShapeContainer1.TabStop = False
        '
        'rct56
        '
        Me.rct56.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rct56.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rct56.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rct56.CornerRadius = 2
        Me.rct56.Location = New System.Drawing.Point(19, 87)
        Me.rct56.Name = "rct56"
        Me.rct56.Size = New System.Drawing.Size(210, 25)
        '
        'rct5
        '
        Me.rct5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.rct5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rct5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.rct5.CornerRadius = 2
        Me.rct5.Location = New System.Drawing.Point(19, 150)
        Me.rct5.Name = "rct5"
        Me.rct5.Size = New System.Drawing.Size(210, 25)
        '
        'rct3
        '
        Me.rct3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rct3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rct3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rct3.CornerRadius = 2
        Me.rct3.Location = New System.Drawing.Point(353, 215)
        Me.rct3.Name = "rct3"
        Me.rct3.Size = New System.Drawing.Size(210, 25)
        '
        'rct4
        '
        Me.rct4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rct4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rct4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rct4.CornerRadius = 2
        Me.rct4.Location = New System.Drawing.Point(353, 150)
        Me.rct4.Name = "rct4"
        Me.rct4.Size = New System.Drawing.Size(210, 25)
        '
        'rct2
        '
        Me.rct2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rct2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rct2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rct2.CornerRadius = 2
        Me.rct2.Location = New System.Drawing.Point(353, 88)
        Me.rct2.Name = "rct2"
        Me.rct2.Size = New System.Drawing.Size(210, 25)
        '
        'rct1
        '
        Me.rct1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rct1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rct1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rct1.CornerRadius = 2
        Me.rct1.Location = New System.Drawing.Point(353, 25)
        Me.rct1.Name = "rct1"
        Me.rct1.Size = New System.Drawing.Size(210, 25)
        '
        'rctNome
        '
        Me.rctNome.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rctNome.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rctNome.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rctNome.CornerRadius = 2
        Me.rctNome.Location = New System.Drawing.Point(19, 25)
        Me.rctNome.Name = "rctNome"
        Me.rctNome.Size = New System.Drawing.Size(210, 25)
        '
        'pctFuncionario
        '
        Me.pctFuncionario.BackColor = System.Drawing.Color.PeachPuff
        Me.pctFuncionario.BackgroundImage = CType(resources.GetObject("pctFuncionario.BackgroundImage"), System.Drawing.Image)
        Me.pctFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pctFuncionario.Location = New System.Drawing.Point(74, 155)
        Me.pctFuncionario.Name = "pctFuncionario"
        Me.pctFuncionario.Size = New System.Drawing.Size(126, 123)
        Me.pctFuncionario.TabIndex = 23
        Me.pctFuncionario.TabStop = False
        '
        'lblNome
        '
        Me.lblNome.AutoEllipsis = True
        Me.lblNome.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNome.Location = New System.Drawing.Point(206, 155)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(205, 40)
        Me.lblNome.TabIndex = 42
        Me.lblNome.Text = "Nome de Utilizador"
        Me.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIdade
        '
        Me.lblIdade.AutoSize = True
        Me.lblIdade.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblIdade.Location = New System.Drawing.Point(206, 209)
        Me.lblIdade.Name = "lblIdade"
        Me.lblIdade.Size = New System.Drawing.Size(39, 16)
        Me.lblIdade.TabIndex = 43
        Me.lblIdade.Text = "Idade"
        '
        'lblRua
        '
        Me.lblRua.AutoSize = True
        Me.lblRua.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRua.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblRua.Location = New System.Drawing.Point(206, 227)
        Me.lblRua.Name = "lblRua"
        Me.lblRua.Size = New System.Drawing.Size(31, 16)
        Me.lblRua.TabIndex = 44
        Me.lblRua.Text = "Rua"
        '
        'lblLocalidade
        '
        Me.lblLocalidade.AutoSize = True
        Me.lblLocalidade.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocalidade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblLocalidade.Location = New System.Drawing.Point(206, 244)
        Me.lblLocalidade.Name = "lblLocalidade"
        Me.lblLocalidade.Size = New System.Drawing.Size(70, 16)
        Me.lblLocalidade.TabIndex = 45
        Me.lblLocalidade.Text = "Localidade"
        '
        'lblTlm
        '
        Me.lblTlm.AutoSize = True
        Me.lblTlm.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTlm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTlm.Location = New System.Drawing.Point(206, 262)
        Me.lblTlm.Name = "lblTlm"
        Me.lblTlm.Size = New System.Drawing.Size(80, 16)
        Me.lblTlm.TabIndex = 46
        Me.lblTlm.Text = "Nº telemóvel"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.PeachPuff
        Me.lblTitulo.Location = New System.Drawing.Point(73, 124)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(206, 24)
        Me.lblTitulo.TabIndex = 47
        Me.lblTitulo.Text = "As suas informações"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tmrPiscar
        '
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(206, 193)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(116, 16)
        Me.lblUsername.TabIndex = 48
        Me.lblUsername.Text = "Nome de utilizador"
        '
        'CtrL_MenuCine
        '
        Me.CtrL_MenuCine.Dock = System.Windows.Forms.DockStyle.Left
        Me.CtrL_MenuCine.Location = New System.Drawing.Point(0, 0)
        Me.CtrL_MenuCine.Name = "CtrL_MenuCine"
        Me.CtrL_MenuCine.Size = New System.Drawing.Size(49, 627)
        Me.CtrL_MenuCine.TabIndex = 0
        '
        'frmDefinicoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(793, 627)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.CtrL_MenuCine)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblTlm)
        Me.Controls.Add(Me.lblLocalidade)
        Me.Controls.Add(Me.lblRua)
        Me.Controls.Add(Me.lblIdade)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.pctFuncionario)
        Me.Controls.Add(Me.grb1)
        Me.Controls.Add(Me.pnl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDefinicoes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurações"
        Me.pnl1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grb1.ResumeLayout(False)
        Me.grb1.PerformLayout()
        CType(Me.pctFuncionario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CtrL_MenuCine As PAP___Gestão_de_Cinema.CTRL_MenuCine
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents grb1 As System.Windows.Forms.GroupBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents rctNome As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents btnDatanasc As System.Windows.Forms.Button
    Friend WithEvents dtpDatanasc As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnNome As System.Windows.Forms.Button
    Friend WithEvents rct2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rct1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents rct4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents btnOutra As System.Windows.Forms.Button
    Friend WithEvents btnLocalidade As System.Windows.Forms.Button
    Friend WithEvents cmblocalidade As System.Windows.Forms.ComboBox
    Friend WithEvents txtrua As System.Windows.Forms.TextBox
    Friend WithEvents btnRua As System.Windows.Forms.Button
    Friend WithEvents lbl6 As System.Windows.Forms.Label
    Friend WithEvents btnTlm As System.Windows.Forms.Button
    Friend WithEvents rct3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents pctFuncionario As System.Windows.Forms.PictureBox
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents lblIdade As System.Windows.Forms.Label
    Friend WithEvents lblRua As System.Windows.Forms.Label
    Friend WithEvents lblLocalidade As System.Windows.Forms.Label
    Friend WithEvents lblTlm As System.Windows.Forms.Label
    Friend WithEvents mtbTlm As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents tmrPiscar As System.Windows.Forms.Timer
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents btnPass As System.Windows.Forms.Button
    Friend WithEvents lbl89 As System.Windows.Forms.Label
    Friend WithEvents rct5 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents chkTexto As System.Windows.Forms.CheckBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents btnUsername As System.Windows.Forms.Button
    Friend WithEvents lbl67 As System.Windows.Forms.Label
    Friend WithEvents rct56 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblUsername As System.Windows.Forms.Label
End Class
