<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.flp1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlBilhetes = New System.Windows.Forms.Panel()
        Me.lblBilhetes = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.pnlClientes = New System.Windows.Forms.Panel()
        Me.lblClientes = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.pnlFuncionarios = New System.Windows.Forms.Panel()
        Me.lblFuncionarios = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.pnlFilmes = New System.Windows.Forms.Panel()
        Me.lblFilmes = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.pnlGraus = New System.Windows.Forms.Panel()
        Me.lblGraus = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.pnlHorarios = New System.Windows.Forms.Panel()
        Me.lblHorarios = New System.Windows.Forms.Label()
        Me.lbl7 = New System.Windows.Forms.Label()
        Me.pnlProdutos = New System.Windows.Forms.Panel()
        Me.lblProdutos = New System.Windows.Forms.Label()
        Me.lbl8 = New System.Windows.Forms.Label()
        Me.pnlSalas = New System.Windows.Forms.Panel()
        Me.lblSalas = New System.Windows.Forms.Label()
        Me.lbl9 = New System.Windows.Forms.Label()
        Me.pnlVendas = New System.Windows.Forms.Panel()
        Me.lblVendas = New System.Windows.Forms.Label()
        Me.lbl10 = New System.Windows.Forms.Label()
        Me.CtrL_MenuCine = New PAP___Gestão_de_Cinema.CTRL_MenuCine()
        Me.pct1 = New System.Windows.Forms.PictureBox()
        Me.pct2 = New System.Windows.Forms.PictureBox()
        Me.pct3 = New System.Windows.Forms.PictureBox()
        Me.pct4 = New System.Windows.Forms.PictureBox()
        Me.pct5 = New System.Windows.Forms.PictureBox()
        Me.pct6 = New System.Windows.Forms.PictureBox()
        Me.pct7 = New System.Windows.Forms.PictureBox()
        Me.pct8 = New System.Windows.Forms.PictureBox()
        Me.pct9 = New System.Windows.Forms.PictureBox()
        Me.pnl1.SuspendLayout()
        Me.flp1.SuspendLayout()
        Me.pnlBilhetes.SuspendLayout()
        Me.pnlClientes.SuspendLayout()
        Me.pnlFuncionarios.SuspendLayout()
        Me.pnlFilmes.SuspendLayout()
        Me.pnlGraus.SuspendLayout()
        Me.pnlHorarios.SuspendLayout()
        Me.pnlProdutos.SuspendLayout()
        Me.pnlSalas.SuspendLayout()
        Me.pnlVendas.SuspendLayout()
        CType(Me.pct1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.pnl1.Controls.Add(Me.lbl1)
        Me.pnl1.Location = New System.Drawing.Point(74, 24)
        Me.pnl1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(556, 93)
        Me.pnl1.TabIndex = 3
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.lbl1.ForeColor = System.Drawing.Color.White
        Me.lbl1.Location = New System.Drawing.Point(0, 8)
        Me.lbl1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(556, 78)
        Me.lbl1.TabIndex = 4
        Me.lbl1.Text = "O que deseja fazer?"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'flp1
        '
        Me.flp1.Controls.Add(Me.pnlBilhetes)
        Me.flp1.Controls.Add(Me.pnlClientes)
        Me.flp1.Controls.Add(Me.pnlFuncionarios)
        Me.flp1.Controls.Add(Me.pnlFilmes)
        Me.flp1.Controls.Add(Me.pnlGraus)
        Me.flp1.Controls.Add(Me.pnlHorarios)
        Me.flp1.Controls.Add(Me.pnlProdutos)
        Me.flp1.Controls.Add(Me.pnlSalas)
        Me.flp1.Controls.Add(Me.pnlVendas)
        Me.flp1.Location = New System.Drawing.Point(79, 175)
        Me.flp1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.flp1.Name = "flp1"
        Me.flp1.Size = New System.Drawing.Size(553, 396)
        Me.flp1.TabIndex = 4
        '
        'pnlBilhetes
        '
        Me.pnlBilhetes.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlBilhetes.Controls.Add(Me.lblBilhetes)
        Me.pnlBilhetes.Controls.Add(Me.lbl2)
        Me.pnlBilhetes.Controls.Add(Me.pct1)
        Me.pnlBilhetes.Location = New System.Drawing.Point(2, 3)
        Me.pnlBilhetes.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnlBilhetes.Name = "pnlBilhetes"
        Me.pnlBilhetes.Size = New System.Drawing.Size(176, 125)
        Me.pnlBilhetes.TabIndex = 4
        '
        'lblBilhetes
        '
        Me.lblBilhetes.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBilhetes.Location = New System.Drawing.Point(0, 55)
        Me.lblBilhetes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBilhetes.Name = "lblBilhetes"
        Me.lblBilhetes.Size = New System.Drawing.Size(176, 48)
        Me.lblBilhetes.TabIndex = 3
        Me.lblBilhetes.Text = "Pode ver, inserir, alterar e apagar bilhetes"
        Me.lblBilhetes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl2
        '
        Me.lbl2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(60, 0)
        Me.lbl2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(116, 55)
        Me.lbl2.TabIndex = 2
        Me.lbl2.Text = "Bilhetes"
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlClientes
        '
        Me.pnlClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnlClientes.Controls.Add(Me.lblClientes)
        Me.pnlClientes.Controls.Add(Me.lbl3)
        Me.pnlClientes.Controls.Add(Me.pct2)
        Me.pnlClientes.Location = New System.Drawing.Point(182, 3)
        Me.pnlClientes.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnlClientes.Name = "pnlClientes"
        Me.pnlClientes.Size = New System.Drawing.Size(176, 125)
        Me.pnlClientes.TabIndex = 5
        '
        'lblClientes
        '
        Me.lblClientes.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientes.Location = New System.Drawing.Point(0, 55)
        Me.lblClientes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClientes.Name = "lblClientes"
        Me.lblClientes.Size = New System.Drawing.Size(176, 48)
        Me.lblClientes.TabIndex = 3
        Me.lblClientes.Text = "Pode ver, inserir, alterar e apagar clientes"
        Me.lblClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl3
        '
        Me.lbl3.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(60, 0)
        Me.lbl3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(116, 55)
        Me.lbl3.TabIndex = 2
        Me.lbl3.Text = "Clientes"
        Me.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlFuncionarios
        '
        Me.pnlFuncionarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlFuncionarios.Controls.Add(Me.lblFuncionarios)
        Me.pnlFuncionarios.Controls.Add(Me.lbl4)
        Me.pnlFuncionarios.Controls.Add(Me.pct3)
        Me.pnlFuncionarios.Location = New System.Drawing.Point(362, 3)
        Me.pnlFuncionarios.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnlFuncionarios.Name = "pnlFuncionarios"
        Me.pnlFuncionarios.Size = New System.Drawing.Size(176, 125)
        Me.pnlFuncionarios.TabIndex = 0
        '
        'lblFuncionarios
        '
        Me.lblFuncionarios.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFuncionarios.Location = New System.Drawing.Point(0, 55)
        Me.lblFuncionarios.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFuncionarios.Name = "lblFuncionarios"
        Me.lblFuncionarios.Size = New System.Drawing.Size(176, 48)
        Me.lblFuncionarios.TabIndex = 3
        Me.lblFuncionarios.Text = "Pode ver, inserir, alterar e apagar funcionários"
        Me.lblFuncionarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl4
        '
        Me.lbl4.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.Location = New System.Drawing.Point(60, 0)
        Me.lbl4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(116, 55)
        Me.lbl4.TabIndex = 2
        Me.lbl4.Text = "Funcionários"
        Me.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlFilmes
        '
        Me.pnlFilmes.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnlFilmes.Controls.Add(Me.lblFilmes)
        Me.pnlFilmes.Controls.Add(Me.lbl5)
        Me.pnlFilmes.Controls.Add(Me.pct4)
        Me.pnlFilmes.Location = New System.Drawing.Point(2, 134)
        Me.pnlFilmes.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnlFilmes.Name = "pnlFilmes"
        Me.pnlFilmes.Size = New System.Drawing.Size(176, 125)
        Me.pnlFilmes.TabIndex = 6
        '
        'lblFilmes
        '
        Me.lblFilmes.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilmes.Location = New System.Drawing.Point(0, 55)
        Me.lblFilmes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFilmes.Name = "lblFilmes"
        Me.lblFilmes.Size = New System.Drawing.Size(176, 48)
        Me.lblFilmes.TabIndex = 3
        Me.lblFilmes.Text = "Pode ver, inserir, alterar e apagar filmes"
        Me.lblFilmes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl5
        '
        Me.lbl5.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.Location = New System.Drawing.Point(60, 0)
        Me.lbl5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(116, 55)
        Me.lbl5.TabIndex = 2
        Me.lbl5.Text = "Filmes"
        Me.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlGraus
        '
        Me.pnlGraus.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnlGraus.Controls.Add(Me.lblGraus)
        Me.pnlGraus.Controls.Add(Me.lbl6)
        Me.pnlGraus.Controls.Add(Me.pct5)
        Me.pnlGraus.Location = New System.Drawing.Point(182, 134)
        Me.pnlGraus.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnlGraus.Name = "pnlGraus"
        Me.pnlGraus.Size = New System.Drawing.Size(176, 125)
        Me.pnlGraus.TabIndex = 7
        '
        'lblGraus
        '
        Me.lblGraus.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGraus.Location = New System.Drawing.Point(0, 55)
        Me.lblGraus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGraus.Name = "lblGraus"
        Me.lblGraus.Size = New System.Drawing.Size(176, 48)
        Me.lblGraus.TabIndex = 3
        Me.lblGraus.Text = "Pode ver, inserir, alterar e apagar graus"
        Me.lblGraus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl6
        '
        Me.lbl6.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.Location = New System.Drawing.Point(60, 0)
        Me.lbl6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(116, 55)
        Me.lbl6.TabIndex = 2
        Me.lbl6.Text = "Graus"
        Me.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlHorarios
        '
        Me.pnlHorarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pnlHorarios.Controls.Add(Me.lblHorarios)
        Me.pnlHorarios.Controls.Add(Me.lbl7)
        Me.pnlHorarios.Controls.Add(Me.pct6)
        Me.pnlHorarios.Location = New System.Drawing.Point(362, 134)
        Me.pnlHorarios.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnlHorarios.Name = "pnlHorarios"
        Me.pnlHorarios.Size = New System.Drawing.Size(176, 125)
        Me.pnlHorarios.TabIndex = 8
        '
        'lblHorarios
        '
        Me.lblHorarios.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHorarios.Location = New System.Drawing.Point(0, 55)
        Me.lblHorarios.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHorarios.Name = "lblHorarios"
        Me.lblHorarios.Size = New System.Drawing.Size(176, 48)
        Me.lblHorarios.TabIndex = 3
        Me.lblHorarios.Text = "Pode ver, inserir, alterar e apagar horários de salas"
        Me.lblHorarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl7
        '
        Me.lbl7.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl7.Location = New System.Drawing.Point(60, 0)
        Me.lbl7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(116, 55)
        Me.lbl7.TabIndex = 2
        Me.lbl7.Text = "Horários"
        Me.lbl7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlProdutos
        '
        Me.pnlProdutos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnlProdutos.Controls.Add(Me.lblProdutos)
        Me.pnlProdutos.Controls.Add(Me.lbl8)
        Me.pnlProdutos.Controls.Add(Me.pct7)
        Me.pnlProdutos.Location = New System.Drawing.Point(2, 265)
        Me.pnlProdutos.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnlProdutos.Name = "pnlProdutos"
        Me.pnlProdutos.Size = New System.Drawing.Size(176, 125)
        Me.pnlProdutos.TabIndex = 9
        '
        'lblProdutos
        '
        Me.lblProdutos.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdutos.Location = New System.Drawing.Point(0, 55)
        Me.lblProdutos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProdutos.Name = "lblProdutos"
        Me.lblProdutos.Size = New System.Drawing.Size(176, 48)
        Me.lblProdutos.TabIndex = 3
        Me.lblProdutos.Text = "Pode ver, inserir, alterar e apagar produtos"
        Me.lblProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl8
        '
        Me.lbl8.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl8.Location = New System.Drawing.Point(60, 0)
        Me.lbl8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Size = New System.Drawing.Size(116, 55)
        Me.lbl8.TabIndex = 2
        Me.lbl8.Text = "Produtos"
        Me.lbl8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlSalas
        '
        Me.pnlSalas.BackColor = System.Drawing.Color.PaleTurquoise
        Me.pnlSalas.Controls.Add(Me.lblSalas)
        Me.pnlSalas.Controls.Add(Me.lbl9)
        Me.pnlSalas.Controls.Add(Me.pct8)
        Me.pnlSalas.Location = New System.Drawing.Point(182, 265)
        Me.pnlSalas.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnlSalas.Name = "pnlSalas"
        Me.pnlSalas.Size = New System.Drawing.Size(176, 125)
        Me.pnlSalas.TabIndex = 10
        '
        'lblSalas
        '
        Me.lblSalas.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalas.Location = New System.Drawing.Point(0, 55)
        Me.lblSalas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSalas.Name = "lblSalas"
        Me.lblSalas.Size = New System.Drawing.Size(176, 48)
        Me.lblSalas.TabIndex = 3
        Me.lblSalas.Text = "Pode ver, inserir, alterar e apagar salas"
        Me.lblSalas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl9
        '
        Me.lbl9.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl9.Location = New System.Drawing.Point(60, 0)
        Me.lbl9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Size = New System.Drawing.Size(116, 55)
        Me.lbl9.TabIndex = 2
        Me.lbl9.Text = "Salas"
        Me.lbl9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlVendas
        '
        Me.pnlVendas.BackColor = System.Drawing.Color.Thistle
        Me.pnlVendas.Controls.Add(Me.lblVendas)
        Me.pnlVendas.Controls.Add(Me.lbl10)
        Me.pnlVendas.Controls.Add(Me.pct9)
        Me.pnlVendas.Location = New System.Drawing.Point(362, 265)
        Me.pnlVendas.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnlVendas.Name = "pnlVendas"
        Me.pnlVendas.Size = New System.Drawing.Size(176, 125)
        Me.pnlVendas.TabIndex = 11
        '
        'lblVendas
        '
        Me.lblVendas.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendas.Location = New System.Drawing.Point(0, 55)
        Me.lblVendas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVendas.Name = "lblVendas"
        Me.lblVendas.Size = New System.Drawing.Size(176, 48)
        Me.lblVendas.TabIndex = 3
        Me.lblVendas.Text = "Pode ver, inserir, alterar e apagar vendas"
        Me.lblVendas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl10
        '
        Me.lbl10.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl10.Location = New System.Drawing.Point(60, 0)
        Me.lbl10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(116, 55)
        Me.lbl10.TabIndex = 2
        Me.lbl10.Text = "Vendas"
        Me.lbl10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CtrL_MenuCine
        '
        Me.CtrL_MenuCine.Dock = System.Windows.Forms.DockStyle.Left
        Me.CtrL_MenuCine.Location = New System.Drawing.Point(0, 0)
        Me.CtrL_MenuCine.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.CtrL_MenuCine.Name = "CtrL_MenuCine"
        Me.CtrL_MenuCine.Size = New System.Drawing.Size(49, 619)
        Me.CtrL_MenuCine.TabIndex = 2
        '
        'pct1
        '
        Me.pct1.BackgroundImage = Global.PAP___Gestão_de_Cinema.My.Resources.Resources.bilhetes
        Me.pct1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pct1.Location = New System.Drawing.Point(0, 0)
        Me.pct1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pct1.Name = "pct1"
        Me.pct1.Size = New System.Drawing.Size(59, 55)
        Me.pct1.TabIndex = 1
        Me.pct1.TabStop = False
        '
        'pct2
        '
        Me.pct2.BackgroundImage = Global.PAP___Gestão_de_Cinema.My.Resources.Resources.cliente
        Me.pct2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pct2.Location = New System.Drawing.Point(0, 0)
        Me.pct2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pct2.Name = "pct2"
        Me.pct2.Size = New System.Drawing.Size(59, 55)
        Me.pct2.TabIndex = 1
        Me.pct2.TabStop = False
        '
        'pct3
        '
        Me.pct3.BackgroundImage = Global.PAP___Gestão_de_Cinema.My.Resources.Resources.utilizadores
        Me.pct3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pct3.Location = New System.Drawing.Point(0, 0)
        Me.pct3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pct3.Name = "pct3"
        Me.pct3.Size = New System.Drawing.Size(59, 55)
        Me.pct3.TabIndex = 1
        Me.pct3.TabStop = False
        '
        'pct4
        '
        Me.pct4.BackgroundImage = Global.PAP___Gestão_de_Cinema.My.Resources.Resources.filmes
        Me.pct4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pct4.Location = New System.Drawing.Point(0, 0)
        Me.pct4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pct4.Name = "pct4"
        Me.pct4.Size = New System.Drawing.Size(59, 55)
        Me.pct4.TabIndex = 1
        Me.pct4.TabStop = False
        '
        'pct5
        '
        Me.pct5.BackgroundImage = Global.PAP___Gestão_de_Cinema.My.Resources.Resources.graus
        Me.pct5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pct5.Location = New System.Drawing.Point(0, 0)
        Me.pct5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pct5.Name = "pct5"
        Me.pct5.Size = New System.Drawing.Size(59, 55)
        Me.pct5.TabIndex = 1
        Me.pct5.TabStop = False
        '
        'pct6
        '
        Me.pct6.BackgroundImage = Global.PAP___Gestão_de_Cinema.My.Resources.Resources.horarios
        Me.pct6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pct6.Location = New System.Drawing.Point(0, 0)
        Me.pct6.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pct6.Name = "pct6"
        Me.pct6.Size = New System.Drawing.Size(59, 55)
        Me.pct6.TabIndex = 1
        Me.pct6.TabStop = False
        '
        'pct7
        '
        Me.pct7.BackgroundImage = Global.PAP___Gestão_de_Cinema.My.Resources.Resources.produtos
        Me.pct7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pct7.Location = New System.Drawing.Point(0, 0)
        Me.pct7.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pct7.Name = "pct7"
        Me.pct7.Size = New System.Drawing.Size(59, 55)
        Me.pct7.TabIndex = 1
        Me.pct7.TabStop = False
        '
        'pct8
        '
        Me.pct8.BackgroundImage = Global.PAP___Gestão_de_Cinema.My.Resources.Resources.salas
        Me.pct8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pct8.Location = New System.Drawing.Point(0, 0)
        Me.pct8.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pct8.Name = "pct8"
        Me.pct8.Size = New System.Drawing.Size(59, 55)
        Me.pct8.TabIndex = 1
        Me.pct8.TabStop = False
        '
        'pct9
        '
        Me.pct9.BackgroundImage = Global.PAP___Gestão_de_Cinema.My.Resources.Resources.vendas
        Me.pct9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pct9.Location = New System.Drawing.Point(0, 0)
        Me.pct9.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pct9.Name = "pct9"
        Me.pct9.Size = New System.Drawing.Size(59, 55)
        Me.pct9.TabIndex = 1
        Me.pct9.TabStop = False
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(661, 619)
        Me.Controls.Add(Me.CtrL_MenuCine)
        Me.Controls.Add(Me.pnl1)
        Me.Controls.Add(Me.flp1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestão de Cinema"
        Me.pnl1.ResumeLayout(False)
        Me.flp1.ResumeLayout(False)
        Me.pnlBilhetes.ResumeLayout(False)
        Me.pnlClientes.ResumeLayout(False)
        Me.pnlFuncionarios.ResumeLayout(False)
        Me.pnlFilmes.ResumeLayout(False)
        Me.pnlGraus.ResumeLayout(False)
        Me.pnlHorarios.ResumeLayout(False)
        Me.pnlProdutos.ResumeLayout(False)
        Me.pnlSalas.ResumeLayout(False)
        Me.pnlVendas.ResumeLayout(False)
        CType(Me.pct1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CtrL_MenuCine As PAP___Gestão_de_Cinema.CTRL_MenuCine
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents flp1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents pnlFuncionarios As System.Windows.Forms.Panel
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents pct3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblFuncionarios As System.Windows.Forms.Label
    Friend WithEvents pnlBilhetes As System.Windows.Forms.Panel
    Friend WithEvents lblBilhetes As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents pct1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlClientes As System.Windows.Forms.Panel
    Friend WithEvents lblClientes As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents pct2 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlFilmes As System.Windows.Forms.Panel
    Friend WithEvents lblFilmes As System.Windows.Forms.Label
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents pct4 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlGraus As System.Windows.Forms.Panel
    Friend WithEvents lblGraus As System.Windows.Forms.Label
    Friend WithEvents lbl6 As System.Windows.Forms.Label
    Friend WithEvents pct5 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlHorarios As System.Windows.Forms.Panel
    Friend WithEvents lblHorarios As System.Windows.Forms.Label
    Friend WithEvents lbl7 As System.Windows.Forms.Label
    Friend WithEvents pct6 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlProdutos As System.Windows.Forms.Panel
    Friend WithEvents lblProdutos As System.Windows.Forms.Label
    Friend WithEvents lbl8 As System.Windows.Forms.Label
    Friend WithEvents pct7 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlSalas As System.Windows.Forms.Panel
    Friend WithEvents lblSalas As System.Windows.Forms.Label
    Friend WithEvents lbl9 As System.Windows.Forms.Label
    Friend WithEvents pct8 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlVendas As System.Windows.Forms.Panel
    Friend WithEvents lblVendas As System.Windows.Forms.Label
    Friend WithEvents lbl10 As System.Windows.Forms.Label
    Friend WithEvents pct9 As System.Windows.Forms.PictureBox
End Class
