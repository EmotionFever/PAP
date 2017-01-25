<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVendas))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.flpartigos = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnltest = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pctProduto = New System.Windows.Forms.PictureBox()
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblnome = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.CtrL_MenuCine = New PAP___Gestão_de_Cinema.CTRL_MenuCine()
        Me.btnProduto = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl1.SuspendLayout()
        Me.flpartigos.SuspendLayout()
        Me.pnltest.SuspendLayout()
        CType(Me.pctProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(74, 134)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(436, 384)
        Me.DataGridView1.TabIndex = 17
        '
        'pnl1
        '
        Me.pnl1.BackColor = System.Drawing.Color.Thistle
        Me.pnl1.Controls.Add(Me.lbl1)
        Me.pnl1.Location = New System.Drawing.Point(74, 26)
        Me.pnl1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(757, 93)
        Me.pnl1.TabIndex = 16
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.lbl1.ForeColor = System.Drawing.Color.Black
        Me.lbl1.Location = New System.Drawing.Point(0, 22)
        Me.lbl1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(757, 52)
        Me.lbl1.TabIndex = 4
        Me.lbl1.Text = "Vendas"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'flpartigos
        '
        Me.flpartigos.AutoScroll = True
        Me.flpartigos.Controls.Add(Me.pnltest)
        Me.flpartigos.Location = New System.Drawing.Point(517, 162)
        Me.flpartigos.Name = "flpartigos"
        Me.flpartigos.Size = New System.Drawing.Size(314, 268)
        Me.flpartigos.TabIndex = 18
        '
        'pnltest
        '
        Me.pnltest.BackColor = System.Drawing.Color.Firebrick
        Me.pnltest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnltest.Controls.Add(Me.Label2)
        Me.pnltest.Controls.Add(Me.Label1)
        Me.pnltest.Controls.Add(Me.pctProduto)
        Me.pnltest.Controls.Add(Me.lblX)
        Me.pnltest.Controls.Add(Me.lblnome)
        Me.pnltest.Location = New System.Drawing.Point(3, 3)
        Me.pnltest.Name = "pnltest"
        Me.pnltest.Size = New System.Drawing.Size(289, 74)
        Me.pnltest.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(72, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Preco total €"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(72, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Quantidade x Preco"
        '
        'pctProduto
        '
        Me.pctProduto.Location = New System.Drawing.Point(0, 0)
        Me.pctProduto.Name = "pctProduto"
        Me.pctProduto.Size = New System.Drawing.Size(72, 72)
        Me.pctProduto.TabIndex = 2
        Me.pctProduto.TabStop = False
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.ForeColor = System.Drawing.Color.White
        Me.lblX.Location = New System.Drawing.Point(258, 30)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(14, 13)
        Me.lblX.TabIndex = 1
        Me.lblX.Text = "X"
        '
        'lblnome
        '
        Me.lblnome.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnome.ForeColor = System.Drawing.Color.White
        Me.lblnome.Location = New System.Drawing.Point(72, 4)
        Me.lblnome.Name = "lblnome"
        Me.lblnome.Size = New System.Drawing.Size(210, 18)
        Me.lblnome.TabIndex = 0
        Me.lblnome.Text = "Nome do que quer que seja"
        '
        'lbl3
        '
        Me.lbl3.BackColor = System.Drawing.Color.Black
        Me.lbl3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.White
        Me.lbl3.Location = New System.Drawing.Point(517, 134)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(314, 23)
        Me.lbl3.TabIndex = 19
        Me.lbl3.Text = "Produtos selecionados"
        Me.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl2.ForeColor = System.Drawing.Color.White
        Me.lbl2.Location = New System.Drawing.Point(516, 471)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(49, 15)
        Me.lbl2.TabIndex = 20
        Me.lbl2.Text = "Cliente:"
        '
        'CtrL_MenuCine
        '
        Me.CtrL_MenuCine.Dock = System.Windows.Forms.DockStyle.Left
        Me.CtrL_MenuCine.Location = New System.Drawing.Point(0, 0)
        Me.CtrL_MenuCine.Name = "CtrL_MenuCine"
        Me.CtrL_MenuCine.Size = New System.Drawing.Size(49, 609)
        Me.CtrL_MenuCine.TabIndex = 0
        '
        'btnProduto
        '
        Me.btnProduto.BackColor = System.Drawing.Color.Thistle
        Me.btnProduto.FlatAppearance.BorderSize = 0
        Me.btnProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduto.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.btnProduto.ForeColor = System.Drawing.Color.Black
        Me.btnProduto.Location = New System.Drawing.Point(516, 440)
        Me.btnProduto.Name = "btnProduto"
        Me.btnProduto.Size = New System.Drawing.Size(102, 22)
        Me.btnProduto.TabIndex = 25
        Me.btnProduto.Text = "Adicionar produto"
        Me.btnProduto.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Thistle
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(624, 440)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 22)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Inserir Venda"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Thistle
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(729, 440)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 22)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Alterar Venda"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'frmVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(843, 609)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnProduto)
        Me.Controls.Add(Me.CtrL_MenuCine)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.flpartigos)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.pnl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vendas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl1.ResumeLayout(False)
        Me.flpartigos.ResumeLayout(False)
        Me.pnltest.ResumeLayout(False)
        Me.pnltest.PerformLayout()
        CType(Me.pctProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CtrL_MenuCine As PAP___Gestão_de_Cinema.CTRL_MenuCine
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents flpartigos As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents pnltest As System.Windows.Forms.Panel
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lblX As System.Windows.Forms.Label
    Friend WithEvents lblnome As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pctProduto As System.Windows.Forms.PictureBox
    Friend WithEvents btnProduto As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
