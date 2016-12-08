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
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.pnl2 = New System.Windows.Forms.Panel()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.rct3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rct2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.rct1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtPasse = New System.Windows.Forms.TextBox()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pnl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnl1.Controls.Add(Me.lbl4)
        Me.pnl1.Controls.Add(Me.lbl1)
        Me.pnl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl1.Location = New System.Drawing.Point(0, 0)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(295, 78)
        Me.pnl1.TabIndex = 0
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.White
        Me.lbl4.Location = New System.Drawing.Point(268, 9)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(20, 19)
        Me.lbl4.TabIndex = 2
        Me.lbl4.Text = "X"
        '
        'lbl1
        '
        Me.lbl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl1.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.lbl1.ForeColor = System.Drawing.Color.White
        Me.lbl1.Location = New System.Drawing.Point(0, 0)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(295, 74)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "Iniciar Sessão"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnl2
        '
        Me.pnl2.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.pnl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl2.Location = New System.Drawing.Point(0, 314)
        Me.pnl2.Name = "pnl2"
        Me.pnl2.Size = New System.Drawing.Size(295, 26)
        Me.pnl2.TabIndex = 1
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.rct3, Me.rct2, Me.rct1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(295, 340)
        Me.ShapeContainer1.TabIndex = 2
        Me.ShapeContainer1.TabStop = False
        '
        'rct3
        '
        Me.rct3.BackColor = System.Drawing.Color.Yellow
        Me.rct3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rct3.BorderColor = System.Drawing.Color.Yellow
        Me.rct3.CornerRadius = 5
        Me.rct3.Location = New System.Drawing.Point(21, 256)
        Me.rct3.Name = "rct3"
        Me.rct3.Size = New System.Drawing.Size(249, 36)
        '
        'rct2
        '
        Me.rct2.BackColor = System.Drawing.Color.White
        Me.rct2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rct2.BorderColor = System.Drawing.Color.White
        Me.rct2.CornerRadius = 3
        Me.rct2.Location = New System.Drawing.Point(22, 192)
        Me.rct2.Name = "rct2"
        Me.rct2.Size = New System.Drawing.Size(249, 36)
        '
        'rct1
        '
        Me.rct1.BackColor = System.Drawing.Color.White
        Me.rct1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.rct1.BorderColor = System.Drawing.Color.White
        Me.rct1.CornerRadius = 3
        Me.rct1.Location = New System.Drawing.Point(22, 120)
        Me.rct1.Name = "rct1"
        Me.rct1.Size = New System.Drawing.Size(249, 36)
        '
        'txtNome
        '
        Me.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNome.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.ForeColor = System.Drawing.Color.Black
        Me.txtNome.Location = New System.Drawing.Point(64, 128)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(198, 22)
        Me.txtNome.TabIndex = 3
        Me.txtNome.Tag = ""
        '
        'txtPasse
        '
        Me.txtPasse.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPasse.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPasse.ForeColor = System.Drawing.Color.Black
        Me.txtPasse.Location = New System.Drawing.Point(64, 200)
        Me.txtPasse.Name = "txtPasse"
        Me.txtPasse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPasse.Size = New System.Drawing.Size(197, 22)
        Me.txtPasse.TabIndex = 4
        '
        'lbl3
        '
        Me.lbl3.BackColor = System.Drawing.Color.Yellow
        Me.lbl3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.Black
        Me.lbl3.Location = New System.Drawing.Point(24, 262)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(246, 26)
        Me.lbl3.TabIndex = 7
        Me.lbl3.Text = "Entrar"
        Me.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nome de utilizador:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(20, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Palavra-passe:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(24, 123)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 32)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(25, 195)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 32)
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(295, 340)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.txtPasse)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.pnl2)
        Me.Controls.Add(Me.pnl1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents pnl2 As System.Windows.Forms.Panel
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents rct2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rct1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtPasse As System.Windows.Forms.TextBox
    Friend WithEvents rct3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
