<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTRL_MenuCine
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.flp1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.btnBilhetes = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnFuncionarios = New System.Windows.Forms.Button()
        Me.btnFilmes = New System.Windows.Forms.Button()
        Me.btnEncargos = New System.Windows.Forms.Button()
        Me.btnHorarios = New System.Windows.Forms.Button()
        Me.btnProdutos = New System.Windows.Forms.Button()
        Me.btnSalas = New System.Windows.Forms.Button()
        Me.btnVendas = New System.Windows.Forms.Button()
        Me.pctEncolhido = New System.Windows.Forms.PictureBox()
        Me.pctLogo = New System.Windows.Forms.PictureBox()
        Me.pctBotao = New System.Windows.Forms.PictureBox()
        Me.tmrAnimacao = New System.Windows.Forms.Timer(Me.components)
        Me.pnl1.SuspendLayout()
        Me.flp1.SuspendLayout()
        CType(Me.pctEncolhido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctBotao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BackColor = System.Drawing.Color.Firebrick
        Me.pnl1.Controls.Add(Me.flp1)
        Me.pnl1.Controls.Add(Me.pctEncolhido)
        Me.pnl1.Controls.Add(Me.pctLogo)
        Me.pnl1.Controls.Add(Me.pctBotao)
        Me.pnl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl1.Location = New System.Drawing.Point(0, 0)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(49, 619)
        Me.pnl1.TabIndex = 8
        '
        'flp1
        '
        Me.flp1.Controls.Add(Me.btnInicio)
        Me.flp1.Controls.Add(Me.btnBilhetes)
        Me.flp1.Controls.Add(Me.btnClientes)
        Me.flp1.Controls.Add(Me.btnFuncionarios)
        Me.flp1.Controls.Add(Me.btnFilmes)
        Me.flp1.Controls.Add(Me.btnEncargos)
        Me.flp1.Controls.Add(Me.btnHorarios)
        Me.flp1.Controls.Add(Me.btnProdutos)
        Me.flp1.Controls.Add(Me.btnSalas)
        Me.flp1.Controls.Add(Me.btnVendas)
        Me.flp1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flp1.Location = New System.Drawing.Point(-3, 103)
        Me.flp1.Name = "flp1"
        Me.flp1.Size = New System.Drawing.Size(265, 518)
        Me.flp1.TabIndex = 13
        '
        'btnInicio
        '
        Me.btnInicio.BackColor = System.Drawing.Color.Firebrick
        Me.btnInicio.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.btnInicio.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue
        Me.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicio.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicio.ForeColor = System.Drawing.Color.White
        Me.btnInicio.Image = Global.PAP___Gestão_de_Cinema.My.Resources.Resources.home_converted
        Me.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInicio.Location = New System.Drawing.Point(3, 3)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.btnInicio.Size = New System.Drawing.Size(260, 45)
        Me.btnInicio.TabIndex = 3
        Me.btnInicio.Tag = ""
        Me.btnInicio.Text = "  Fomulário Inicial"
        Me.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInicio.UseVisualStyleBackColor = False
        '
        'btnBilhetes
        '
        Me.btnBilhetes.BackColor = System.Drawing.Color.Firebrick
        Me.btnBilhetes.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnBilhetes.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.btnBilhetes.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue
        Me.btnBilhetes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBilhetes.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBilhetes.ForeColor = System.Drawing.Color.White
        Me.btnBilhetes.Image = Global.PAP___Gestão_de_Cinema.My.Resources.Resources.bilhetes_converted
        Me.btnBilhetes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBilhetes.Location = New System.Drawing.Point(3, 54)
        Me.btnBilhetes.Name = "btnBilhetes"
        Me.btnBilhetes.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.btnBilhetes.Size = New System.Drawing.Size(260, 45)
        Me.btnBilhetes.TabIndex = 7
        Me.btnBilhetes.Tag = ""
        Me.btnBilhetes.Text = "  Bilhetes"
        Me.btnBilhetes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBilhetes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBilhetes.UseVisualStyleBackColor = False
        '
        'btnClientes
        '
        Me.btnClientes.BackColor = System.Drawing.Color.Firebrick
        Me.btnClientes.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.btnClientes.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.Color.White
        Me.btnClientes.Image = Global.PAP___Gestão_de_Cinema.My.Resources.Resources.cliente_converted
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.Location = New System.Drawing.Point(3, 105)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.btnClientes.Size = New System.Drawing.Size(260, 45)
        Me.btnClientes.TabIndex = 8
        Me.btnClientes.Tag = ""
        Me.btnClientes.Text = "  Clientes"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'btnFuncionarios
        '
        Me.btnFuncionarios.BackColor = System.Drawing.Color.Firebrick
        Me.btnFuncionarios.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnFuncionarios.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.btnFuncionarios.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue
        Me.btnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFuncionarios.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFuncionarios.ForeColor = System.Drawing.Color.White
        Me.btnFuncionarios.Image = Global.PAP___Gestão_de_Cinema.My.Resources.Resources.utilizadores_converted
        Me.btnFuncionarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFuncionarios.Location = New System.Drawing.Point(3, 156)
        Me.btnFuncionarios.Name = "btnFuncionarios"
        Me.btnFuncionarios.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.btnFuncionarios.Size = New System.Drawing.Size(260, 45)
        Me.btnFuncionarios.TabIndex = 15
        Me.btnFuncionarios.Tag = ""
        Me.btnFuncionarios.Text = "  Funcionários"
        Me.btnFuncionarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFuncionarios.UseVisualStyleBackColor = False
        '
        'btnFilmes
        '
        Me.btnFilmes.BackColor = System.Drawing.Color.Firebrick
        Me.btnFilmes.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnFilmes.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.btnFilmes.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue
        Me.btnFilmes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilmes.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilmes.ForeColor = System.Drawing.Color.White
        Me.btnFilmes.Image = Global.PAP___Gestão_de_Cinema.My.Resources.Resources.filmes_converted
        Me.btnFilmes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFilmes.Location = New System.Drawing.Point(3, 207)
        Me.btnFilmes.Name = "btnFilmes"
        Me.btnFilmes.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.btnFilmes.Size = New System.Drawing.Size(260, 45)
        Me.btnFilmes.TabIndex = 9
        Me.btnFilmes.Tag = ""
        Me.btnFilmes.Text = "  Filmes"
        Me.btnFilmes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFilmes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFilmes.UseVisualStyleBackColor = False
        '
        'btnEncargos
        '
        Me.btnEncargos.BackColor = System.Drawing.Color.Firebrick
        Me.btnEncargos.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnEncargos.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.btnEncargos.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue
        Me.btnEncargos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEncargos.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEncargos.ForeColor = System.Drawing.Color.White
        Me.btnEncargos.Image = Global.PAP___Gestão_de_Cinema.My.Resources.Resources.graus_converted
        Me.btnEncargos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEncargos.Location = New System.Drawing.Point(3, 258)
        Me.btnEncargos.Name = "btnEncargos"
        Me.btnEncargos.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.btnEncargos.Size = New System.Drawing.Size(260, 45)
        Me.btnEncargos.TabIndex = 10
        Me.btnEncargos.Tag = ""
        Me.btnEncargos.Text = "  Encargos"
        Me.btnEncargos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEncargos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEncargos.UseVisualStyleBackColor = False
        '
        'btnHorarios
        '
        Me.btnHorarios.BackColor = System.Drawing.Color.Firebrick
        Me.btnHorarios.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnHorarios.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.btnHorarios.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue
        Me.btnHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHorarios.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHorarios.ForeColor = System.Drawing.Color.White
        Me.btnHorarios.Image = Global.PAP___Gestão_de_Cinema.My.Resources.Resources.horarios_converted
        Me.btnHorarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHorarios.Location = New System.Drawing.Point(3, 309)
        Me.btnHorarios.Name = "btnHorarios"
        Me.btnHorarios.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.btnHorarios.Size = New System.Drawing.Size(260, 45)
        Me.btnHorarios.TabIndex = 11
        Me.btnHorarios.Tag = ""
        Me.btnHorarios.Text = "  Horários"
        Me.btnHorarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHorarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHorarios.UseVisualStyleBackColor = False
        '
        'btnProdutos
        '
        Me.btnProdutos.BackColor = System.Drawing.Color.Firebrick
        Me.btnProdutos.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnProdutos.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.btnProdutos.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue
        Me.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProdutos.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProdutos.ForeColor = System.Drawing.Color.White
        Me.btnProdutos.Image = Global.PAP___Gestão_de_Cinema.My.Resources.Resources.produtos_converted
        Me.btnProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProdutos.Location = New System.Drawing.Point(3, 360)
        Me.btnProdutos.Name = "btnProdutos"
        Me.btnProdutos.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.btnProdutos.Size = New System.Drawing.Size(260, 45)
        Me.btnProdutos.TabIndex = 12
        Me.btnProdutos.Tag = ""
        Me.btnProdutos.Text = "  Produtos"
        Me.btnProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProdutos.UseVisualStyleBackColor = False
        '
        'btnSalas
        '
        Me.btnSalas.BackColor = System.Drawing.Color.Firebrick
        Me.btnSalas.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSalas.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.btnSalas.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue
        Me.btnSalas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalas.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalas.ForeColor = System.Drawing.Color.White
        Me.btnSalas.Image = Global.PAP___Gestão_de_Cinema.My.Resources.Resources.salas_converted
        Me.btnSalas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalas.Location = New System.Drawing.Point(3, 411)
        Me.btnSalas.Name = "btnSalas"
        Me.btnSalas.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.btnSalas.Size = New System.Drawing.Size(260, 45)
        Me.btnSalas.TabIndex = 13
        Me.btnSalas.Tag = ""
        Me.btnSalas.Text = "  Salas"
        Me.btnSalas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalas.UseVisualStyleBackColor = False
        '
        'btnVendas
        '
        Me.btnVendas.BackColor = System.Drawing.Color.Firebrick
        Me.btnVendas.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnVendas.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.btnVendas.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue
        Me.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVendas.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVendas.ForeColor = System.Drawing.Color.White
        Me.btnVendas.Image = Global.PAP___Gestão_de_Cinema.My.Resources.Resources.vendas_converted
        Me.btnVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVendas.Location = New System.Drawing.Point(3, 462)
        Me.btnVendas.Name = "btnVendas"
        Me.btnVendas.Padding = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.btnVendas.Size = New System.Drawing.Size(260, 45)
        Me.btnVendas.TabIndex = 14
        Me.btnVendas.Tag = ""
        Me.btnVendas.Text = "  Vendas"
        Me.btnVendas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVendas.UseVisualStyleBackColor = False
        '
        'pctEncolhido
        '
        Me.pctEncolhido.BackColor = System.Drawing.Color.Firebrick
        Me.pctEncolhido.Image = Global.PAP___Gestão_de_Cinema.My.Resources.Resources.rolo_imagem
        Me.pctEncolhido.Location = New System.Drawing.Point(10, 47)
        Me.pctEncolhido.Name = "pctEncolhido"
        Me.pctEncolhido.Size = New System.Drawing.Size(33, 30)
        Me.pctEncolhido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctEncolhido.TabIndex = 6
        Me.pctEncolhido.TabStop = False
        '
        'pctLogo
        '
        Me.pctLogo.BackColor = System.Drawing.Color.Firebrick
        Me.pctLogo.Image = Global.PAP___Gestão_de_Cinema.My.Resources.Resources.Logo
        Me.pctLogo.Location = New System.Drawing.Point(10, 33)
        Me.pctLogo.Name = "pctLogo"
        Me.pctLogo.Size = New System.Drawing.Size(238, 64)
        Me.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctLogo.TabIndex = 0
        Me.pctLogo.TabStop = False
        Me.pctLogo.Visible = False
        '
        'pctBotao
        '
        Me.pctBotao.BackColor = System.Drawing.Color.Firebrick
        Me.pctBotao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctBotao.Image = Global.PAP___Gestão_de_Cinema.My.Resources.Resources.header_menu_hamburger
        Me.pctBotao.Location = New System.Drawing.Point(13, 9)
        Me.pctBotao.Name = "pctBotao"
        Me.pctBotao.Size = New System.Drawing.Size(24, 24)
        Me.pctBotao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBotao.TabIndex = 2
        Me.pctBotao.TabStop = False
        Me.pctBotao.Tag = "0"
        '
        'tmrAnimacao
        '
        Me.tmrAnimacao.Interval = 25
        '
        'CTRL_MenuCine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnl1)
        Me.Name = "CTRL_MenuCine"
        Me.Size = New System.Drawing.Size(49, 619)
        Me.pnl1.ResumeLayout(False)
        Me.flp1.ResumeLayout(False)
        CType(Me.pctEncolhido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctBotao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnProdutos As System.Windows.Forms.Button
    Friend WithEvents btnHorarios As System.Windows.Forms.Button
    Friend WithEvents btnEncargos As System.Windows.Forms.Button
    Friend WithEvents btnFilmes As System.Windows.Forms.Button
    Friend WithEvents btnClientes As System.Windows.Forms.Button
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents btnBilhetes As System.Windows.Forms.Button
    Friend WithEvents pctEncolhido As System.Windows.Forms.PictureBox
    Friend WithEvents pctLogo As System.Windows.Forms.PictureBox
    Friend WithEvents pctBotao As System.Windows.Forms.PictureBox
    Friend WithEvents btnInicio As System.Windows.Forms.Button
    Friend WithEvents tmrAnimacao As System.Windows.Forms.Timer
    Friend WithEvents flp1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnSalas As System.Windows.Forms.Button
    Friend WithEvents btnVendas As System.Windows.Forms.Button
    Friend WithEvents btnFuncionarios As System.Windows.Forms.Button

End Class
