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
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.flpitens = New System.Windows.Forms.FlowLayoutPanel()
        Me.flpcategorias = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnBilhetes = New System.Windows.Forms.Button()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.pnl1.SuspendLayout()
        Me.flpcategorias.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BackColor = System.Drawing.Color.MediumOrchid
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
        Me.lbl1.Text = "Que tipo de produto quer?"
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
        Me.flpcategorias.Size = New System.Drawing.Size(336, 347)
        Me.flpcategorias.TabIndex = 20
        '
        'btnBilhetes
        '
        Me.btnBilhetes.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnBilhetes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBilhetes.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btnBilhetes.Location = New System.Drawing.Point(3, 3)
        Me.btnBilhetes.Name = "btnBilhetes"
        Me.btnBilhetes.Size = New System.Drawing.Size(154, 61)
        Me.btnBilhetes.TabIndex = 3
        Me.btnBilhetes.Text = "Bilhetes"
        Me.btnBilhetes.UseVisualStyleBackColor = False
        '
        'btnVoltar
        '
        Me.btnVoltar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnVoltar.FlatAppearance.BorderSize = 0
        Me.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoltar.Location = New System.Drawing.Point(303, 375)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(43, 36)
        Me.btnVoltar.TabIndex = 21
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.UseVisualStyleBackColor = False
        '
        'frmVendas_Inserir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(414, 469)
        Me.Controls.Add(Me.flpcategorias)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.pnl1)
        Me.Controls.Add(Me.flpitens)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmVendas_Inserir"
        Me.Text = "Escolher produto"
        Me.pnl1.ResumeLayout(False)
        Me.flpcategorias.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents flpitens As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents flpcategorias As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnBilhetes As System.Windows.Forms.Button
    Friend WithEvents btnVoltar As System.Windows.Forms.Button
End Class
