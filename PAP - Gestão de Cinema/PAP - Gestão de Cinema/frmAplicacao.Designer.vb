<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAplicacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAplicacao))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.pctLogo = New System.Windows.Forms.PictureBox()
        Me.pctExpandir = New System.Windows.Forms.PictureBox()
        Me.btnEscolha1 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.pctLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctExpandir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(215, 443)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'pctLogo
        '
        Me.pctLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pctLogo.Image = Global.PAP___Gestão_de_Cinema.My.Resources.Resources.Logo
        Me.pctLogo.Location = New System.Drawing.Point(14, 14)
        Me.pctLogo.Name = "pctLogo"
        Me.pctLogo.Size = New System.Drawing.Size(160, 45)
        Me.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctLogo.TabIndex = 0
        Me.pctLogo.TabStop = False
        '
        'pctExpandir
        '
        Me.pctExpandir.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pctExpandir.Image = Global.PAP___Gestão_de_Cinema.My.Resources.Resources.header_menu_hamburger
        Me.pctExpandir.Location = New System.Drawing.Point(180, 14)
        Me.pctExpandir.Name = "pctExpandir"
        Me.pctExpandir.Size = New System.Drawing.Size(24, 24)
        Me.pctExpandir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctExpandir.TabIndex = 2
        Me.pctExpandir.TabStop = False
        '
        'btnEscolha1
        '
        Me.btnEscolha1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnEscolha1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnEscolha1.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue
        Me.btnEscolha1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEscolha1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEscolha1.Location = New System.Drawing.Point(0, 98)
        Me.btnEscolha1.Name = "btnEscolha1"
        Me.btnEscolha1.Size = New System.Drawing.Size(215, 37)
        Me.btnEscolha1.TabIndex = 3
        Me.btnEscolha1.Text = "             Teste"
        Me.btnEscolha1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEscolha1.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(0, 140)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(215, 37)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "             Teste"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmAplicacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(661, 443)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEscolha1)
        Me.Controls.Add(Me.pctLogo)
        Me.Controls.Add(Me.pctExpandir)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAplicacao"
        Me.Text = "Aplicação"
        CType(Me.pctLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctExpandir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents pctLogo As System.Windows.Forms.PictureBox
    Friend WithEvents pctExpandir As System.Windows.Forms.PictureBox
    Friend WithEvents btnEscolha1 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
