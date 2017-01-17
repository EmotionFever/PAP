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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.flpitens = New System.Windows.Forms.FlowLayoutPanel()
        Me.flpcategorias = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.pnl1.SuspendLayout()
        Me.flpcategorias.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gênero de Produtos:"
        '
        'pnl1
        '
        Me.pnl1.BackColor = System.Drawing.Color.MediumOrchid
        Me.pnl1.Controls.Add(Me.lbl1)
        Me.pnl1.Location = New System.Drawing.Point(11, 12)
        Me.pnl1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(314, 46)
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
        Me.lbl1.Size = New System.Drawing.Size(314, 31)
        Me.lbl1.TabIndex = 4
        Me.lbl1.Text = "Escolha um produto"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'flpitens
        '
        Me.flpitens.AutoScroll = True
        Me.flpitens.Location = New System.Drawing.Point(11, 92)
        Me.flpitens.Name = "flpitens"
        Me.flpitens.Size = New System.Drawing.Size(314, 365)
        Me.flpitens.TabIndex = 19
        Me.flpitens.Visible = False
        '
        'flpcategorias
        '
        Me.flpcategorias.AutoScroll = True
        Me.flpcategorias.Controls.Add(Me.Button4)
        Me.flpcategorias.Location = New System.Drawing.Point(11, 65)
        Me.flpcategorias.Name = "flpcategorias"
        Me.flpcategorias.Size = New System.Drawing.Size(338, 257)
        Me.flpcategorias.TabIndex = 20
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Button4.Location = New System.Drawing.Point(3, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(154, 61)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Bilhetes"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'frmVendas_Inserir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(414, 469)
        Me.Controls.Add(Me.flpcategorias)
        Me.Controls.Add(Me.pnl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.flpitens)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmVendas_Inserir"
        Me.Text = "Escolher produto"
        Me.pnl1.ResumeLayout(False)
        Me.flpcategorias.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents flpitens As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents flpcategorias As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
