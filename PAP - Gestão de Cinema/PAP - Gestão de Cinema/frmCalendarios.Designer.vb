<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalendarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalendarios))
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.pnlCalendario = New System.Windows.Forms.Panel()
        Me.pnlHoras = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tlpHoras = New System.Windows.Forms.TableLayoutPanel()
        Me.lblH23 = New System.Windows.Forms.Label()
        Me.lblH22 = New System.Windows.Forms.Label()
        Me.lblH21 = New System.Windows.Forms.Label()
        Me.lblH20 = New System.Windows.Forms.Label()
        Me.lblH19 = New System.Windows.Forms.Label()
        Me.lblH18 = New System.Windows.Forms.Label()
        Me.lblH17 = New System.Windows.Forms.Label()
        Me.lblH16 = New System.Windows.Forms.Label()
        Me.lblH15 = New System.Windows.Forms.Label()
        Me.lblH14 = New System.Windows.Forms.Label()
        Me.lblH013 = New System.Windows.Forms.Label()
        Me.lblH012 = New System.Windows.Forms.Label()
        Me.lblH011 = New System.Windows.Forms.Label()
        Me.lblH10 = New System.Windows.Forms.Label()
        Me.lblH9 = New System.Windows.Forms.Label()
        Me.lblH8 = New System.Windows.Forms.Label()
        Me.lblH7 = New System.Windows.Forms.Label()
        Me.lblH6 = New System.Windows.Forms.Label()
        Me.lblH5 = New System.Windows.Forms.Label()
        Me.lblH4 = New System.Windows.Forms.Label()
        Me.lblH3 = New System.Windows.Forms.Label()
        Me.lblH2 = New System.Windows.Forms.Label()
        Me.lblH1 = New System.Windows.Forms.Label()
        Me.lblH0 = New System.Windows.Forms.Label()
        Me.tlpSalas = New System.Windows.Forms.TableLayoutPanel()
        Me.lblS1 = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.CtrL_MenuCine = New PAP___Gestão_de_Cinema.CTRL_MenuCine()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCalendario.SuspendLayout()
        Me.pnlHoras.SuspendLayout()
        Me.tlpHoras.SuspendLayout()
        Me.tlpSalas.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl1
        '
        Me.pnl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnl1.Controls.Add(Me.PictureBox1)
        Me.pnl1.Controls.Add(Me.lbl1)
        Me.pnl1.Location = New System.Drawing.Point(74, 24)
        Me.pnl1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(682, 93)
        Me.pnl1.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 85)
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.Color.Transparent
        Me.lbl1.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.lbl1.ForeColor = System.Drawing.Color.Black
        Me.lbl1.Location = New System.Drawing.Point(96, 21)
        Me.lbl1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(586, 55)
        Me.lbl1.TabIndex = 4
        Me.lbl1.Text = "Calendários"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlCalendario
        '
        Me.pnlCalendario.AutoScroll = True
        Me.pnlCalendario.BackColor = System.Drawing.Color.ForestGreen
        Me.pnlCalendario.Controls.Add(Me.pnlHoras)
        Me.pnlCalendario.Controls.Add(Me.tlpSalas)
        Me.pnlCalendario.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlCalendario.Location = New System.Drawing.Point(74, 132)
        Me.pnlCalendario.Name = "pnlCalendario"
        Me.pnlCalendario.Size = New System.Drawing.Size(363, 522)
        Me.pnlCalendario.TabIndex = 51
        '
        'pnlHoras
        '
        Me.pnlHoras.AutoScroll = True
        Me.pnlHoras.BackColor = System.Drawing.Color.GreenYellow
        Me.pnlHoras.Controls.Add(Me.Panel1)
        Me.pnlHoras.Controls.Add(Me.TableLayoutPanel1)
        Me.pnlHoras.Controls.Add(Me.tlpHoras)
        Me.pnlHoras.Location = New System.Drawing.Point(0, 37)
        Me.pnlHoras.Name = "pnlHoras"
        Me.pnlHoras.Size = New System.Drawing.Size(363, 482)
        Me.pnlHoras.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(51, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(124, 360)
        Me.Panel1.TabIndex = 2
        '
        'tlpHoras
        '
        Me.tlpHoras.BackColor = System.Drawing.Color.DarkGreen
        Me.tlpHoras.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tlpHoras.ColumnCount = 1
        Me.tlpHoras.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.tlpHoras.Controls.Add(Me.lblH23, 0, 23)
        Me.tlpHoras.Controls.Add(Me.lblH22, 0, 22)
        Me.tlpHoras.Controls.Add(Me.lblH21, 0, 21)
        Me.tlpHoras.Controls.Add(Me.lblH20, 0, 20)
        Me.tlpHoras.Controls.Add(Me.lblH19, 0, 19)
        Me.tlpHoras.Controls.Add(Me.lblH18, 0, 18)
        Me.tlpHoras.Controls.Add(Me.lblH17, 0, 17)
        Me.tlpHoras.Controls.Add(Me.lblH16, 0, 16)
        Me.tlpHoras.Controls.Add(Me.lblH15, 0, 15)
        Me.tlpHoras.Controls.Add(Me.lblH14, 0, 14)
        Me.tlpHoras.Controls.Add(Me.lblH013, 0, 13)
        Me.tlpHoras.Controls.Add(Me.lblH012, 0, 12)
        Me.tlpHoras.Controls.Add(Me.lblH011, 0, 11)
        Me.tlpHoras.Controls.Add(Me.lblH10, 0, 10)
        Me.tlpHoras.Controls.Add(Me.lblH9, 0, 9)
        Me.tlpHoras.Controls.Add(Me.lblH8, 0, 8)
        Me.tlpHoras.Controls.Add(Me.lblH7, 0, 7)
        Me.tlpHoras.Controls.Add(Me.lblH6, 0, 6)
        Me.tlpHoras.Controls.Add(Me.lblH5, 0, 5)
        Me.tlpHoras.Controls.Add(Me.lblH4, 0, 4)
        Me.tlpHoras.Controls.Add(Me.lblH3, 0, 3)
        Me.tlpHoras.Controls.Add(Me.lblH2, 0, 2)
        Me.tlpHoras.Controls.Add(Me.lblH1, 0, 1)
        Me.tlpHoras.Controls.Add(Me.lblH0, 0, 0)
        Me.tlpHoras.Location = New System.Drawing.Point(0, 0)
        Me.tlpHoras.Name = "tlpHoras"
        Me.tlpHoras.RowCount = 24
        Me.tlpHoras.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.tlpHoras.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.tlpHoras.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.tlpHoras.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.tlpHoras.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.tlpHoras.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.tlpHoras.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.tlpHoras.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.tlpHoras.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.tlpHoras.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.tlpHoras.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.tlpHoras.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.tlpHoras.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.tlpHoras.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.tlpHoras.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.tlpHoras.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.tlpHoras.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.tlpHoras.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.tlpHoras.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.tlpHoras.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.tlpHoras.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.tlpHoras.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.tlpHoras.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.tlpHoras.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.tlpHoras.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpHoras.Size = New System.Drawing.Size(46, 1441)
        Me.tlpHoras.TabIndex = 1
        '
        'lblH23
        '
        Me.lblH23.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblH23.ForeColor = System.Drawing.Color.White
        Me.lblH23.Location = New System.Drawing.Point(4, 1381)
        Me.lblH23.Name = "lblH23"
        Me.lblH23.Size = New System.Drawing.Size(39, 59)
        Me.lblH23.TabIndex = 75
        Me.lblH23.Text = "23"
        Me.lblH23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblH22
        '
        Me.lblH22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblH22.ForeColor = System.Drawing.Color.White
        Me.lblH22.Location = New System.Drawing.Point(4, 1321)
        Me.lblH22.Name = "lblH22"
        Me.lblH22.Size = New System.Drawing.Size(39, 59)
        Me.lblH22.TabIndex = 74
        Me.lblH22.Text = "22"
        Me.lblH22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblH21
        '
        Me.lblH21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblH21.ForeColor = System.Drawing.Color.White
        Me.lblH21.Location = New System.Drawing.Point(4, 1261)
        Me.lblH21.Name = "lblH21"
        Me.lblH21.Size = New System.Drawing.Size(39, 59)
        Me.lblH21.TabIndex = 73
        Me.lblH21.Text = "21"
        Me.lblH21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblH20
        '
        Me.lblH20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblH20.ForeColor = System.Drawing.Color.White
        Me.lblH20.Location = New System.Drawing.Point(4, 1201)
        Me.lblH20.Name = "lblH20"
        Me.lblH20.Size = New System.Drawing.Size(39, 59)
        Me.lblH20.TabIndex = 72
        Me.lblH20.Text = "20"
        Me.lblH20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblH19
        '
        Me.lblH19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblH19.ForeColor = System.Drawing.Color.White
        Me.lblH19.Location = New System.Drawing.Point(4, 1141)
        Me.lblH19.Name = "lblH19"
        Me.lblH19.Size = New System.Drawing.Size(39, 59)
        Me.lblH19.TabIndex = 71
        Me.lblH19.Text = "19"
        Me.lblH19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblH18
        '
        Me.lblH18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblH18.ForeColor = System.Drawing.Color.White
        Me.lblH18.Location = New System.Drawing.Point(4, 1081)
        Me.lblH18.Name = "lblH18"
        Me.lblH18.Size = New System.Drawing.Size(39, 59)
        Me.lblH18.TabIndex = 70
        Me.lblH18.Text = "18"
        Me.lblH18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblH17
        '
        Me.lblH17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblH17.ForeColor = System.Drawing.Color.White
        Me.lblH17.Location = New System.Drawing.Point(4, 1021)
        Me.lblH17.Name = "lblH17"
        Me.lblH17.Size = New System.Drawing.Size(39, 59)
        Me.lblH17.TabIndex = 69
        Me.lblH17.Text = "17"
        Me.lblH17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblH16
        '
        Me.lblH16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblH16.ForeColor = System.Drawing.Color.White
        Me.lblH16.Location = New System.Drawing.Point(4, 961)
        Me.lblH16.Name = "lblH16"
        Me.lblH16.Size = New System.Drawing.Size(39, 59)
        Me.lblH16.TabIndex = 68
        Me.lblH16.Text = "16"
        Me.lblH16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblH15
        '
        Me.lblH15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblH15.ForeColor = System.Drawing.Color.White
        Me.lblH15.Location = New System.Drawing.Point(4, 901)
        Me.lblH15.Name = "lblH15"
        Me.lblH15.Size = New System.Drawing.Size(39, 59)
        Me.lblH15.TabIndex = 67
        Me.lblH15.Text = "15"
        Me.lblH15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblH14
        '
        Me.lblH14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblH14.ForeColor = System.Drawing.Color.White
        Me.lblH14.Location = New System.Drawing.Point(4, 841)
        Me.lblH14.Name = "lblH14"
        Me.lblH14.Size = New System.Drawing.Size(39, 59)
        Me.lblH14.TabIndex = 66
        Me.lblH14.Text = "14"
        Me.lblH14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblH013
        '
        Me.lblH013.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblH013.ForeColor = System.Drawing.Color.White
        Me.lblH013.Location = New System.Drawing.Point(4, 781)
        Me.lblH013.Name = "lblH013"
        Me.lblH013.Size = New System.Drawing.Size(39, 59)
        Me.lblH013.TabIndex = 65
        Me.lblH013.Text = "13"
        Me.lblH013.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblH012
        '
        Me.lblH012.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblH012.ForeColor = System.Drawing.Color.White
        Me.lblH012.Location = New System.Drawing.Point(4, 721)
        Me.lblH012.Name = "lblH012"
        Me.lblH012.Size = New System.Drawing.Size(39, 59)
        Me.lblH012.TabIndex = 64
        Me.lblH012.Text = "12"
        Me.lblH012.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblH011
        '
        Me.lblH011.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblH011.ForeColor = System.Drawing.Color.White
        Me.lblH011.Location = New System.Drawing.Point(4, 661)
        Me.lblH011.Name = "lblH011"
        Me.lblH011.Size = New System.Drawing.Size(39, 59)
        Me.lblH011.TabIndex = 63
        Me.lblH011.Text = "11"
        Me.lblH011.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblH10
        '
        Me.lblH10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblH10.ForeColor = System.Drawing.Color.White
        Me.lblH10.Location = New System.Drawing.Point(4, 601)
        Me.lblH10.Name = "lblH10"
        Me.lblH10.Size = New System.Drawing.Size(39, 59)
        Me.lblH10.TabIndex = 62
        Me.lblH10.Text = "10"
        Me.lblH10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblH9
        '
        Me.lblH9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblH9.ForeColor = System.Drawing.Color.White
        Me.lblH9.Location = New System.Drawing.Point(4, 541)
        Me.lblH9.Name = "lblH9"
        Me.lblH9.Size = New System.Drawing.Size(39, 59)
        Me.lblH9.TabIndex = 61
        Me.lblH9.Text = "9"
        Me.lblH9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblH8
        '
        Me.lblH8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblH8.ForeColor = System.Drawing.Color.White
        Me.lblH8.Location = New System.Drawing.Point(4, 481)
        Me.lblH8.Name = "lblH8"
        Me.lblH8.Size = New System.Drawing.Size(39, 59)
        Me.lblH8.TabIndex = 60
        Me.lblH8.Text = "8"
        Me.lblH8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblH7
        '
        Me.lblH7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblH7.ForeColor = System.Drawing.Color.White
        Me.lblH7.Location = New System.Drawing.Point(4, 421)
        Me.lblH7.Name = "lblH7"
        Me.lblH7.Size = New System.Drawing.Size(39, 59)
        Me.lblH7.TabIndex = 59
        Me.lblH7.Text = "7"
        Me.lblH7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblH6
        '
        Me.lblH6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblH6.ForeColor = System.Drawing.Color.White
        Me.lblH6.Location = New System.Drawing.Point(4, 361)
        Me.lblH6.Name = "lblH6"
        Me.lblH6.Size = New System.Drawing.Size(39, 59)
        Me.lblH6.TabIndex = 58
        Me.lblH6.Text = "6"
        Me.lblH6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblH5
        '
        Me.lblH5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblH5.ForeColor = System.Drawing.Color.White
        Me.lblH5.Location = New System.Drawing.Point(4, 301)
        Me.lblH5.Name = "lblH5"
        Me.lblH5.Size = New System.Drawing.Size(39, 59)
        Me.lblH5.TabIndex = 57
        Me.lblH5.Text = "5"
        Me.lblH5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblH4
        '
        Me.lblH4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblH4.ForeColor = System.Drawing.Color.White
        Me.lblH4.Location = New System.Drawing.Point(4, 241)
        Me.lblH4.Name = "lblH4"
        Me.lblH4.Size = New System.Drawing.Size(39, 59)
        Me.lblH4.TabIndex = 56
        Me.lblH4.Text = "4"
        Me.lblH4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblH3
        '
        Me.lblH3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblH3.ForeColor = System.Drawing.Color.White
        Me.lblH3.Location = New System.Drawing.Point(4, 181)
        Me.lblH3.Name = "lblH3"
        Me.lblH3.Size = New System.Drawing.Size(39, 59)
        Me.lblH3.TabIndex = 55
        Me.lblH3.Text = "3"
        Me.lblH3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblH2
        '
        Me.lblH2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblH2.ForeColor = System.Drawing.Color.White
        Me.lblH2.Location = New System.Drawing.Point(4, 121)
        Me.lblH2.Name = "lblH2"
        Me.lblH2.Size = New System.Drawing.Size(39, 59)
        Me.lblH2.TabIndex = 54
        Me.lblH2.Text = "2"
        Me.lblH2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblH1
        '
        Me.lblH1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblH1.ForeColor = System.Drawing.Color.White
        Me.lblH1.Location = New System.Drawing.Point(4, 61)
        Me.lblH1.Name = "lblH1"
        Me.lblH1.Size = New System.Drawing.Size(39, 59)
        Me.lblH1.TabIndex = 53
        Me.lblH1.Text = "1"
        Me.lblH1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblH0
        '
        Me.lblH0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblH0.ForeColor = System.Drawing.Color.White
        Me.lblH0.Location = New System.Drawing.Point(4, 1)
        Me.lblH0.Name = "lblH0"
        Me.lblH0.Size = New System.Drawing.Size(39, 59)
        Me.lblH0.TabIndex = 52
        Me.lblH0.Text = "0"
        Me.lblH0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tlpSalas
        '
        Me.tlpSalas.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tlpSalas.ColumnCount = 2
        Me.tlpSalas.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.tlpSalas.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137.0!))
        Me.tlpSalas.Controls.Add(Me.lblS1, 0, 0)
        Me.tlpSalas.Controls.Add(Me.lbl, 0, 0)
        Me.tlpSalas.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlpSalas.Location = New System.Drawing.Point(0, 0)
        Me.tlpSalas.Name = "tlpSalas"
        Me.tlpSalas.RowCount = 1
        Me.tlpSalas.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpSalas.Size = New System.Drawing.Size(181, 37)
        Me.tlpSalas.TabIndex = 0
        '
        'lblS1
        '
        Me.lblS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblS1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblS1.ForeColor = System.Drawing.Color.White
        Me.lblS1.Location = New System.Drawing.Point(49, 1)
        Me.lblS1.Name = "lblS1"
        Me.lblS1.Size = New System.Drawing.Size(131, 35)
        Me.lblS1.TabIndex = 55
        Me.lblS1.Text = "Sala 1"
        Me.lblS1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl
        '
        Me.lbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.ForeColor = System.Drawing.Color.White
        Me.lbl.Location = New System.Drawing.Point(4, 1)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(38, 35)
        Me.lbl.TabIndex = 54
        Me.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CtrL_MenuCine
        '
        Me.CtrL_MenuCine.Dock = System.Windows.Forms.DockStyle.Left
        Me.CtrL_MenuCine.Location = New System.Drawing.Point(0, 0)
        Me.CtrL_MenuCine.Name = "CtrL_MenuCine"
        Me.CtrL_MenuCine.Size = New System.Drawing.Size(49, 666)
        Me.CtrL_MenuCine.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134.0!))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(45, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 24
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(136, 1441)
        Me.TableLayoutPanel1.TabIndex = 52
        '
        'frmCalendarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(782, 666)
        Me.Controls.Add(Me.pnlCalendario)
        Me.Controls.Add(Me.pnl1)
        Me.Controls.Add(Me.CtrL_MenuCine)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCalendarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calendários"
        Me.pnl1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCalendario.ResumeLayout(False)
        Me.pnlHoras.ResumeLayout(False)
        Me.tlpHoras.ResumeLayout(False)
        Me.tlpSalas.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CtrL_MenuCine As PAP___Gestão_de_Cinema.CTRL_MenuCine
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents pnlCalendario As System.Windows.Forms.Panel
    Friend WithEvents tlpSalas As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlHoras As System.Windows.Forms.Panel
    Friend WithEvents tlpHoras As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblH0 As System.Windows.Forms.Label
    Friend WithEvents lblH23 As System.Windows.Forms.Label
    Friend WithEvents lblH22 As System.Windows.Forms.Label
    Friend WithEvents lblH21 As System.Windows.Forms.Label
    Friend WithEvents lblH20 As System.Windows.Forms.Label
    Friend WithEvents lblH19 As System.Windows.Forms.Label
    Friend WithEvents lblH18 As System.Windows.Forms.Label
    Friend WithEvents lblH17 As System.Windows.Forms.Label
    Friend WithEvents lblH16 As System.Windows.Forms.Label
    Friend WithEvents lblH15 As System.Windows.Forms.Label
    Friend WithEvents lblH14 As System.Windows.Forms.Label
    Friend WithEvents lblH013 As System.Windows.Forms.Label
    Friend WithEvents lblH012 As System.Windows.Forms.Label
    Friend WithEvents lblH011 As System.Windows.Forms.Label
    Friend WithEvents lblH10 As System.Windows.Forms.Label
    Friend WithEvents lblH9 As System.Windows.Forms.Label
    Friend WithEvents lblH8 As System.Windows.Forms.Label
    Friend WithEvents lblH7 As System.Windows.Forms.Label
    Friend WithEvents lblH6 As System.Windows.Forms.Label
    Friend WithEvents lblH5 As System.Windows.Forms.Label
    Friend WithEvents lblH4 As System.Windows.Forms.Label
    Friend WithEvents lblH3 As System.Windows.Forms.Label
    Friend WithEvents lblH2 As System.Windows.Forms.Label
    Friend WithEvents lblH1 As System.Windows.Forms.Label
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblS1 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
End Class
