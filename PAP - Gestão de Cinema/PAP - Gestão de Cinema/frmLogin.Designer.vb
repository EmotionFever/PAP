<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.rctPass = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rctUtl = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lblErroUtl = New System.Windows.Forms.Label()
        Me.lblErroPass = New System.Windows.Forms.Label()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.pctImagem = New System.Windows.Forms.PictureBox()
        Me.pctPass = New System.Windows.Forms.PictureBox()
        Me.pctUtl = New System.Windows.Forms.PictureBox()
        Me.pnl1.SuspendLayout()
        CType(Me.pctImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctUtl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BackColor = System.Drawing.Color.Firebrick
        Me.pnl1.Controls.Add(Me.lbl1)
        Me.pnl1.Location = New System.Drawing.Point(22, 25)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(249, 82)
        Me.pnl1.TabIndex = 0
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.lbl1.ForeColor = System.Drawing.Color.White
        Me.lbl1.Location = New System.Drawing.Point(0, 15)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(249, 54)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "Iniciar Sessão"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.rctPass, Me.rctUtl})
        Me.ShapeContainer1.Size = New System.Drawing.Size(457, 372)
        Me.ShapeContainer1.TabIndex = 2
        Me.ShapeContainer1.TabStop = False
        '
        'rctPass
        '
        Me.rctPass.BackColor = System.Drawing.Color.White
        Me.rctPass.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rctPass.BorderColor = System.Drawing.Color.White
        Me.rctPass.CornerRadius = 3
        Me.rctPass.Location = New System.Drawing.Point(22, 240)
        Me.rctPass.Name = "rctPass"
        Me.rctPass.Size = New System.Drawing.Size(249, 36)
        '
        'rctUtl
        '
        Me.rctUtl.BackColor = System.Drawing.Color.White
        Me.rctUtl.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rctUtl.BorderColor = System.Drawing.Color.White
        Me.rctUtl.CornerRadius = 3
        Me.rctUtl.Location = New System.Drawing.Point(22, 154)
        Me.rctUtl.Name = "rctUtl"
        Me.rctUtl.Size = New System.Drawing.Size(249, 36)
        '
        'txtNome
        '
        Me.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNome.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.ForeColor = System.Drawing.Color.Black
        Me.txtNome.Location = New System.Drawing.Point(64, 162)
        Me.txtNome.MaxLength = 50
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(198, 22)
        Me.txtNome.TabIndex = 3
        Me.txtNome.Tag = ""
        '
        'txtPass
        '
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPass.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.Black
        Me.txtPass.Location = New System.Drawing.Point(64, 248)
        Me.txtPass.MaxLength = 50
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPass.Size = New System.Drawing.Size(197, 22)
        Me.txtPass.TabIndex = 4
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.White
        Me.lbl2.Location = New System.Drawing.Point(20, 133)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(133, 16)
        Me.lbl2.TabIndex = 8
        Me.lbl2.Text = "Nome de utilizador:"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.ForeColor = System.Drawing.Color.White
        Me.lbl5.Location = New System.Drawing.Point(20, 219)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(101, 16)
        Me.lbl5.TabIndex = 9
        Me.lbl5.Text = "Palavra-passe:"
        '
        'lblErroUtl
        '
        Me.lblErroUtl.AutoSize = True
        Me.lblErroUtl.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErroUtl.ForeColor = System.Drawing.Color.Salmon
        Me.lblErroUtl.Location = New System.Drawing.Point(20, 195)
        Me.lblErroUtl.Name = "lblErroUtl"
        Me.lblErroUtl.Size = New System.Drawing.Size(0, 15)
        Me.lblErroUtl.TabIndex = 12
        '
        'lblErroPass
        '
        Me.lblErroPass.AutoSize = True
        Me.lblErroPass.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErroPass.ForeColor = System.Drawing.Color.Salmon
        Me.lblErroPass.Location = New System.Drawing.Point(21, 281)
        Me.lblErroPass.Name = "lblErroPass"
        Me.lblErroPass.Size = New System.Drawing.Size(0, 15)
        Me.lblErroPass.TabIndex = 13
        '
        'btnEntrar
        '
        Me.btnEntrar.BackColor = System.Drawing.Color.Blue
        Me.btnEntrar.FlatAppearance.BorderSize = 0
        Me.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntrar.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.btnEntrar.ForeColor = System.Drawing.Color.White
        Me.btnEntrar.Location = New System.Drawing.Point(20, 313)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(251, 37)
        Me.btnEntrar.TabIndex = 14
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.UseVisualStyleBackColor = False
        '
        'pctImagem
        '
        Me.pctImagem.BackgroundImage = Global.PAP___Gestão_de_Cinema.My.Resources.Resources.rolo_imagem
        Me.pctImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pctImagem.Location = New System.Drawing.Point(290, 24)
        Me.pctImagem.Name = "pctImagem"
        Me.pctImagem.Size = New System.Drawing.Size(407, 326)
        Me.pctImagem.TabIndex = 15
        Me.pctImagem.TabStop = False
        '
        'pctPass
        '
        Me.pctPass.BackColor = System.Drawing.Color.White
        Me.pctPass.BackgroundImage = Global.PAP___Gestão_de_Cinema.My.Resources.Resources.locked_1
        Me.pctPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctPass.Location = New System.Drawing.Point(25, 243)
        Me.pctPass.Name = "pctPass"
        Me.pctPass.Size = New System.Drawing.Size(34, 32)
        Me.pctPass.TabIndex = 11
        Me.pctPass.TabStop = False
        '
        'pctUtl
        '
        Me.pctUtl.BackColor = System.Drawing.Color.White
        Me.pctUtl.BackgroundImage = Global.PAP___Gestão_de_Cinema.My.Resources.Resources.user1
        Me.pctUtl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctUtl.Location = New System.Drawing.Point(24, 157)
        Me.pctUtl.Name = "pctUtl"
        Me.pctUtl.Size = New System.Drawing.Size(34, 32)
        Me.pctUtl.TabIndex = 10
        Me.pctUtl.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(457, 372)
        Me.Controls.Add(Me.pctImagem)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.lblErroPass)
        Me.Controls.Add(Me.lblErroUtl)
        Me.Controls.Add(Me.pctPass)
        Me.Controls.Add(Me.pctUtl)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.pnl1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.pnl1.ResumeLayout(False)
        CType(Me.pctImagem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctUtl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents rctPass As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rctUtl As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents pctUtl As System.Windows.Forms.PictureBox
    Friend WithEvents pctPass As System.Windows.Forms.PictureBox
    Friend WithEvents lblErroUtl As System.Windows.Forms.Label
    Friend WithEvents lblErroPass As System.Windows.Forms.Label
    Friend WithEvents btnEntrar As System.Windows.Forms.Button
    Friend WithEvents pctImagem As System.Windows.Forms.PictureBox

End Class
