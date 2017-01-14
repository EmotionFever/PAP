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
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.grpApagar = New System.Windows.Forms.GroupBox()
        Me.lblidade = New System.Windows.Forms.Label()
        Me.lbllocalidade = New System.Windows.Forms.Label()
        Me.lblnome = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.btnApagar = New System.Windows.Forms.Button()
        Me.lbl13 = New System.Windows.Forms.Label()
        Me.lbl12 = New System.Windows.Forms.Label()
        Me.lbl10 = New System.Windows.Forms.Label()
        Me.lbl9 = New System.Windows.Forms.Label()
        Me.chkMorada = New System.Windows.Forms.CheckBox()
        Me.chkMorada1 = New System.Windows.Forms.CheckBox()
        Me.chkNIF = New System.Windows.Forms.CheckBox()
        Me.chknome = New System.Windows.Forms.CheckBox()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.rctNome = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.rct56 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rct40 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rct30 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rctTelemovel = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rctIII = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rctMorada = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rctNIF = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMorada = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ckkTel = New System.Windows.Forms.CheckBox()
        Me.mtbTel = New System.Windows.Forms.MaskedTextBox()
        Me.lblInserir = New System.Windows.Forms.Label()
        Me.mtbNIF = New System.Windows.Forms.MaskedTextBox()
        Me.lblProcurar = New System.Windows.Forms.Label()
        Me.lblAlterar = New System.Windows.Forms.Label()
        Me.CtrL_MenuCine = New PAP___Gestão_de_Cinema.CTRL_MenuCine()
        Me.pnl1.SuspendLayout()
        Me.grpApagar.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnl1.Controls.Add(Me.lbl1)
        Me.pnl1.Location = New System.Drawing.Point(76, 27)
        Me.pnl1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(682, 93)
        Me.pnl1.TabIndex = 4
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl1.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.lbl1.ForeColor = System.Drawing.Color.Black
        Me.lbl1.Location = New System.Drawing.Point(0, 0)
        Me.lbl1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(682, 93)
        Me.lbl1.TabIndex = 4
        Me.lbl1.Text = "Clientes"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpApagar
        '
        Me.grpApagar.Controls.Add(Me.lblidade)
        Me.grpApagar.Controls.Add(Me.lbllocalidade)
        Me.grpApagar.Controls.Add(Me.lblnome)
        Me.grpApagar.Controls.Add(Me.lblemail)
        Me.grpApagar.Controls.Add(Me.btnApagar)
        Me.grpApagar.Controls.Add(Me.lbl13)
        Me.grpApagar.Controls.Add(Me.lbl12)
        Me.grpApagar.Controls.Add(Me.lbl10)
        Me.grpApagar.Controls.Add(Me.lbl9)
        Me.grpApagar.ForeColor = System.Drawing.Color.White
        Me.grpApagar.Location = New System.Drawing.Point(76, 499)
        Me.grpApagar.Name = "grpApagar"
        Me.grpApagar.Size = New System.Drawing.Size(312, 155)
        Me.grpApagar.TabIndex = 14
        Me.grpApagar.TabStop = False
        Me.grpApagar.Text = "Apagar"
        '
        'lblidade
        '
        Me.lblidade.AutoSize = True
        Me.lblidade.Location = New System.Drawing.Point(126, 47)
        Me.lblidade.Name = "lblidade"
        Me.lblidade.Size = New System.Drawing.Size(16, 13)
        Me.lblidade.TabIndex = 17
        Me.lblidade.Text = "---"
        '
        'lbllocalidade
        '
        Me.lbllocalidade.AutoSize = True
        Me.lbllocalidade.Location = New System.Drawing.Point(126, 97)
        Me.lbllocalidade.Name = "lbllocalidade"
        Me.lbllocalidade.Size = New System.Drawing.Size(16, 13)
        Me.lbllocalidade.TabIndex = 20
        Me.lbllocalidade.Text = "---"
        '
        'lblnome
        '
        Me.lblnome.AutoSize = True
        Me.lblnome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnome.Location = New System.Drawing.Point(126, 22)
        Me.lblnome.Name = "lblnome"
        Me.lblnome.Size = New System.Drawing.Size(16, 13)
        Me.lblnome.TabIndex = 16
        Me.lblnome.Text = "---"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Location = New System.Drawing.Point(126, 70)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(16, 13)
        Me.lblemail.TabIndex = 19
        Me.lblemail.Text = "---"
        '
        'btnApagar
        '
        Me.btnApagar.ForeColor = System.Drawing.Color.Black
        Me.btnApagar.Location = New System.Drawing.Point(16, 122)
        Me.btnApagar.Name = "btnApagar"
        Me.btnApagar.Size = New System.Drawing.Size(274, 23)
        Me.btnApagar.TabIndex = 9
        Me.btnApagar.Text = "Apagar registo selecionado"
        Me.btnApagar.UseVisualStyleBackColor = True
        '
        'lbl13
        '
        Me.lbl13.AutoSize = True
        Me.lbl13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl13.Location = New System.Drawing.Point(13, 97)
        Me.lbl13.Name = "lbl13"
        Me.lbl13.Size = New System.Drawing.Size(62, 13)
        Me.lbl13.TabIndex = 11
        Me.lbl13.Text = "Localidade:"
        '
        'lbl12
        '
        Me.lbl12.AutoSize = True
        Me.lbl12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl12.Location = New System.Drawing.Point(15, 70)
        Me.lbl12.Name = "lbl12"
        Me.lbl12.Size = New System.Drawing.Size(38, 13)
        Me.lbl12.TabIndex = 9
        Me.lbl12.Text = "E-mail:"
        '
        'lbl10
        '
        Me.lbl10.AutoSize = True
        Me.lbl10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl10.Location = New System.Drawing.Point(15, 47)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(35, 13)
        Me.lbl10.TabIndex = 5
        Me.lbl10.Text = "Pisos:"
        '
        'lbl9
        '
        Me.lbl9.AutoSize = True
        Me.lbl9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl9.Location = New System.Drawing.Point(15, 22)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Size = New System.Drawing.Size(113, 13)
        Me.lbl9.TabIndex = 0
        Me.lbl9.Text = "Nome do Condomínio:"
        '
        'chkMorada
        '
        Me.chkMorada.AutoSize = True
        Me.chkMorada.Location = New System.Drawing.Point(743, 342)
        Me.chkMorada.Name = "chkMorada"
        Me.chkMorada.Size = New System.Drawing.Size(15, 14)
        Me.chkMorada.TabIndex = 25
        Me.chkMorada.UseVisualStyleBackColor = True
        '
        'chkMorada1
        '
        Me.chkMorada1.AutoSize = True
        Me.chkMorada1.Location = New System.Drawing.Point(743, 281)
        Me.chkMorada1.Name = "chkMorada1"
        Me.chkMorada1.Size = New System.Drawing.Size(15, 14)
        Me.chkMorada1.TabIndex = 24
        Me.chkMorada1.UseVisualStyleBackColor = True
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
        Me.lbl6.Size = New System.Drawing.Size(53, 15)
        Me.lbl6.TabIndex = 22
        Me.lbl6.Text = "Morada:"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl3.ForeColor = System.Drawing.Color.White
        Me.lbl3.Location = New System.Drawing.Point(518, 196)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(212, 15)
        Me.lbl3.TabIndex = 21
        Me.lbl3.Text = "Número de Indetificação Fiscal (NIF):"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.White
        Me.lbl2.Location = New System.Drawing.Point(518, 135)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(102, 15)
        Me.lbl2.TabIndex = 20
        Me.lbl2.Text = "Nome do Cliente:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(76, 135)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(436, 358)
        Me.DataGridView1.TabIndex = 15
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
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.rct56, Me.rct40, Me.rct30, Me.rctTelemovel, Me.rctIII, Me.rctMorada, Me.rctNIF, Me.rctNome})
        Me.ShapeContainer1.Size = New System.Drawing.Size(853, 692)
        Me.ShapeContainer1.TabIndex = 26
        Me.ShapeContainer1.TabStop = False
        '
        'rct56
        '
        Me.rct56.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rct56.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rct56.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rct56.CornerRadius = 2
        Me.rct56.Location = New System.Drawing.Point(695, 464)
        Me.rct56.Name = "rct56"
        Me.rct56.Size = New System.Drawing.Size(65, 21)
        '
        'rct40
        '
        Me.rct40.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rct40.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rct40.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rct40.CornerRadius = 2
        Me.rct40.Location = New System.Drawing.Point(522, 465)
        Me.rct40.Name = "rct40"
        Me.rct40.Size = New System.Drawing.Size(65, 21)
        '
        'rct30
        '
        Me.rct30.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rct30.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rct30.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rct30.CornerRadius = 2
        Me.rct30.Location = New System.Drawing.Point(610, 464)
        Me.rct30.Name = "rct30"
        Me.rct30.Size = New System.Drawing.Size(63, 21)
        '
        'rctTelemovel
        '
        Me.rctTelemovel.BackColor = System.Drawing.Color.White
        Me.rctTelemovel.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rctTelemovel.BorderColor = System.Drawing.Color.White
        Me.rctTelemovel.CornerRadius = 2
        Me.rctTelemovel.Location = New System.Drawing.Point(521, 401)
        Me.rctTelemovel.Name = "rctTelemovel"
        Me.rctTelemovel.Size = New System.Drawing.Size(210, 25)
        '
        'rctIII
        '
        Me.rctIII.BackColor = System.Drawing.Color.White
        Me.rctIII.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rctIII.BorderColor = System.Drawing.Color.White
        Me.rctIII.CornerRadius = 2
        Me.rctIII.Location = New System.Drawing.Point(520, 336)
        Me.rctIII.Name = "rctIII"
        Me.rctIII.Size = New System.Drawing.Size(210, 25)
        '
        'rctMorada
        '
        Me.rctMorada.BackColor = System.Drawing.Color.White
        Me.rctMorada.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rctMorada.BorderColor = System.Drawing.Color.White
        Me.rctMorada.CornerRadius = 2
        Me.rctMorada.Location = New System.Drawing.Point(521, 274)
        Me.rctMorada.Name = "rctMorada"
        Me.rctMorada.Size = New System.Drawing.Size(210, 25)
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
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(193, 14)
        Me.txtnome.TabIndex = 27
        Me.txtnome.Tag = ""
        '
        'txtemail
        '
        Me.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtemail.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.ForeColor = System.Drawing.Color.Black
        Me.txtemail.Location = New System.Drawing.Point(530, 281)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(193, 14)
        Me.txtemail.TabIndex = 28
        Me.txtemail.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(518, 321)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 15)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Morada:"
        '
        'txtMorada
        '
        Me.txtMorada.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMorada.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMorada.ForeColor = System.Drawing.Color.Black
        Me.txtMorada.Location = New System.Drawing.Point(528, 342)
        Me.txtMorada.Name = "txtMorada"
        Me.txtMorada.Size = New System.Drawing.Size(193, 14)
        Me.txtMorada.TabIndex = 30
        Me.txtMorada.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(518, 385)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Telemóvel:"
        '
        'ckkTel
        '
        Me.ckkTel.AutoSize = True
        Me.ckkTel.Location = New System.Drawing.Point(743, 408)
        Me.ckkTel.Name = "ckkTel"
        Me.ckkTel.Size = New System.Drawing.Size(15, 14)
        Me.ckkTel.TabIndex = 32
        Me.ckkTel.UseVisualStyleBackColor = True
        '
        'mtbTel
        '
        Me.mtbTel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtbTel.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.mtbTel.Location = New System.Drawing.Point(529, 408)
        Me.mtbTel.Mask = "000000000"
        Me.mtbTel.Name = "mtbTel"
        Me.mtbTel.Size = New System.Drawing.Size(195, 14)
        Me.mtbTel.TabIndex = 33
        '
        'lblInserir
        '
        Me.lblInserir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblInserir.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblInserir.ForeColor = System.Drawing.Color.White
        Me.lblInserir.Location = New System.Drawing.Point(524, 468)
        Me.lblInserir.Name = "lblInserir"
        Me.lblInserir.Size = New System.Drawing.Size(62, 15)
        Me.lblInserir.TabIndex = 34
        Me.lblInserir.Text = "Inserir"
        Me.lblInserir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'lblProcurar
        '
        Me.lblProcurar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblProcurar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblProcurar.ForeColor = System.Drawing.Color.White
        Me.lblProcurar.Location = New System.Drawing.Point(613, 468)
        Me.lblProcurar.Name = "lblProcurar"
        Me.lblProcurar.Size = New System.Drawing.Size(61, 15)
        Me.lblProcurar.TabIndex = 36
        Me.lblProcurar.Text = "Procurar"
        Me.lblProcurar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAlterar
        '
        Me.lblAlterar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAlterar.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lblAlterar.ForeColor = System.Drawing.Color.White
        Me.lblAlterar.Location = New System.Drawing.Point(697, 468)
        Me.lblAlterar.Name = "lblAlterar"
        Me.lblAlterar.Size = New System.Drawing.Size(61, 15)
        Me.lblAlterar.TabIndex = 38
        Me.lblAlterar.Text = "Procurar"
        Me.lblAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CtrL_MenuCine
        '
        Me.CtrL_MenuCine.Dock = System.Windows.Forms.DockStyle.Left
        Me.CtrL_MenuCine.Location = New System.Drawing.Point(0, 0)
        Me.CtrL_MenuCine.Name = "CtrL_MenuCine"
        Me.CtrL_MenuCine.Size = New System.Drawing.Size(49, 692)
        Me.CtrL_MenuCine.TabIndex = 0
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(853, 692)
        Me.Controls.Add(Me.lblAlterar)
        Me.Controls.Add(Me.lblProcurar)
        Me.Controls.Add(Me.mtbNIF)
        Me.Controls.Add(Me.lblInserir)
        Me.Controls.Add(Me.mtbTel)
        Me.Controls.Add(Me.ckkTel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMorada)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtnome)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.chkMorada)
        Me.Controls.Add(Me.grpApagar)
        Me.Controls.Add(Me.chkMorada1)
        Me.Controls.Add(Me.chkNIF)
        Me.Controls.Add(Me.pnl1)
        Me.Controls.Add(Me.chknome)
        Me.Controls.Add(Me.CtrL_MenuCine)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        Me.pnl1.ResumeLayout(False)
        Me.grpApagar.ResumeLayout(False)
        Me.grpApagar.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CtrL_MenuCine As PAP___Gestão_de_Cinema.CTRL_MenuCine
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents grpApagar As System.Windows.Forms.GroupBox
    Friend WithEvents lblidade As System.Windows.Forms.Label
    Friend WithEvents lbllocalidade As System.Windows.Forms.Label
    Friend WithEvents lblnome As System.Windows.Forms.Label
    Friend WithEvents lblemail As System.Windows.Forms.Label
    Friend WithEvents btnApagar As System.Windows.Forms.Button
    Friend WithEvents lbl13 As System.Windows.Forms.Label
    Friend WithEvents lbl12 As System.Windows.Forms.Label
    Friend WithEvents lbl10 As System.Windows.Forms.Label
    Friend WithEvents lbl9 As System.Windows.Forms.Label
    Friend WithEvents chkMorada As System.Windows.Forms.CheckBox
    Friend WithEvents chkMorada1 As System.Windows.Forms.CheckBox
    Friend WithEvents chkNIF As System.Windows.Forms.CheckBox
    Friend WithEvents chknome As System.Windows.Forms.CheckBox
    Friend WithEvents lbl6 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents rctNome As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents rctIII As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rctMorada As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rctNIF As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMorada As System.Windows.Forms.TextBox
    Friend WithEvents rct30 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rctTelemovel As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ckkTel As System.Windows.Forms.CheckBox
    Friend WithEvents mtbTel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblInserir As System.Windows.Forms.Label
    Friend WithEvents mtbNIF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents rct40 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblProcurar As System.Windows.Forms.Label
    Friend WithEvents rct56 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblAlterar As System.Windows.Forms.Label
End Class
