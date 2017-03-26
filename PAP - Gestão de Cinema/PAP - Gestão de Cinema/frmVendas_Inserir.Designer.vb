<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendas_Inserir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVendas_Inserir))
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.flpitens = New System.Windows.Forms.FlowLayoutPanel()
        Me.flpcategorias = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnBilhetes = New System.Windows.Forms.Button()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.lblprod = New System.Windows.Forms.Label()
        Me.grp1 = New System.Windows.Forms.GroupBox()
        Me.lblquant = New System.Windows.Forms.Label()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.nmrQuant = New System.Windows.Forms.NumericUpDown()
        Me.pnl1.SuspendLayout()
        Me.flpcategorias.SuspendLayout()
        Me.grp1.SuspendLayout()
        CType(Me.nmrQuant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BackColor = System.Drawing.Color.Thistle
        Me.pnl1.Controls.Add(Me.lbl1)
        Me.pnl1.Location = New System.Drawing.Point(11, 12)
        Me.pnl1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(338, 46)
        Me.pnl1.TabIndex = 17
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.Black
        Me.lbl1.Location = New System.Drawing.Point(0, 7)
        Me.lbl1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(336, 31)
        Me.lbl1.TabIndex = 4
        Me.lbl1.Text = "Que tipo de artigo quer?"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'flpitens
        '
        Me.flpitens.AutoScroll = True
        Me.flpitens.Location = New System.Drawing.Point(12, 64)
        Me.flpitens.Name = "flpitens"
        Me.flpitens.Size = New System.Drawing.Size(335, 305)
        Me.flpitens.TabIndex = 19
        Me.flpitens.Visible = False
        '
        'flpcategorias
        '
        Me.flpcategorias.AutoScroll = True
        Me.flpcategorias.Controls.Add(Me.btnBilhetes)
        Me.flpcategorias.Location = New System.Drawing.Point(11, 64)
        Me.flpcategorias.Name = "flpcategorias"
        Me.flpcategorias.Size = New System.Drawing.Size(338, 345)
        Me.flpcategorias.TabIndex = 20
        '
        'btnBilhetes
        '
        Me.btnBilhetes.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnBilhetes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBilhetes.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnBilhetes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBilhetes.Location = New System.Drawing.Point(3, 3)
        Me.btnBilhetes.Name = "btnBilhetes"
        Me.btnBilhetes.Size = New System.Drawing.Size(154, 61)
        Me.btnBilhetes.TabIndex = 3
        Me.btnBilhetes.Tag = ""
        Me.btnBilhetes.Text = "Bilhetes"
        Me.btnBilhetes.UseVisualStyleBackColor = False
        '
        'btnVoltar
        '
        Me.btnVoltar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnVoltar.BackgroundImage = Global.PAP___Gestão_de_Cinema.My.Resources.Resources.voltar
        Me.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnVoltar.FlatAppearance.BorderSize = 0
        Me.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoltar.Location = New System.Drawing.Point(310, 375)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(35, 34)
        Me.btnVoltar.TabIndex = 21
        Me.btnVoltar.UseVisualStyleBackColor = False
        '
        'lblprod
        '
        Me.lblprod.AutoEllipsis = True
        Me.lblprod.BackColor = System.Drawing.Color.Transparent
        Me.lblprod.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprod.ForeColor = System.Drawing.Color.White
        Me.lblprod.Location = New System.Drawing.Point(6, 16)
        Me.lblprod.Name = "lblprod"
        Me.lblprod.Size = New System.Drawing.Size(326, 20)
        Me.lblprod.TabIndex = 22
        Me.lblprod.Text = "Digite quantas unidade deseja de XXXXX"
        '
        'grp1
        '
        Me.grp1.Controls.Add(Me.lblquant)
        Me.grp1.Controls.Add(Me.btnConfirmar)
        Me.grp1.Controls.Add(Me.nmrQuant)
        Me.grp1.Controls.Add(Me.lblprod)
        Me.grp1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp1.ForeColor = System.Drawing.Color.White
        Me.grp1.Location = New System.Drawing.Point(11, 427)
        Me.grp1.Name = "grp1"
        Me.grp1.Size = New System.Drawing.Size(338, 107)
        Me.grp1.TabIndex = 23
        Me.grp1.TabStop = False
        Me.grp1.Text = "Quantos produtos deseja?"
        '
        'lblquant
        '
        Me.lblquant.AutoSize = True
        Me.lblquant.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblquant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblquant.Location = New System.Drawing.Point(141, 41)
        Me.lblquant.Name = "lblquant"
        Me.lblquant.Size = New System.Drawing.Size(132, 14)
        Me.lblquant.TabIndex = 25
        Me.lblquant.Text = "Só existem x unidades"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.Color.Thistle
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.ForeColor = System.Drawing.Color.Black
        Me.btnConfirmar.Location = New System.Drawing.Point(8, 69)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(323, 27)
        Me.btnConfirmar.TabIndex = 24
        Me.btnConfirmar.Tag = ""
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'nmrQuant
        '
        Me.nmrQuant.Location = New System.Drawing.Point(9, 39)
        Me.nmrQuant.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmrQuant.Name = "nmrQuant"
        Me.nmrQuant.Size = New System.Drawing.Size(114, 20)
        Me.nmrQuant.TabIndex = 23
        Me.nmrQuant.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'frmVendas_Inserir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(360, 547)
        Me.Controls.Add(Me.grp1)
        Me.Controls.Add(Me.flpcategorias)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.pnl1)
        Me.Controls.Add(Me.flpitens)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVendas_Inserir"
        Me.Text = "Escolher produto"
        Me.TopMost = True
        Me.pnl1.ResumeLayout(False)
        Me.flpcategorias.ResumeLayout(False)
        Me.grp1.ResumeLayout(False)
        Me.grp1.PerformLayout()
        CType(Me.nmrQuant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents flpitens As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents flpcategorias As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnBilhetes As System.Windows.Forms.Button
    Friend WithEvents btnVoltar As System.Windows.Forms.Button
    Friend WithEvents lblprod As System.Windows.Forms.Label
    Friend WithEvents grp1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents nmrQuant As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblquant As System.Windows.Forms.Label
End Class
