﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.MenuCinematico1 = New CTRL_Menu_do_cinema.MenuCinematico()
        Me.SuspendLayout()
        '
        'MenuCinematico1
        '
        Me.MenuCinematico1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuCinematico1.Location = New System.Drawing.Point(0, 0)
        Me.MenuCinematico1.Name = "MenuCinematico1"
        Me.MenuCinematico1.Size = New System.Drawing.Size(260, 443)
        Me.MenuCinematico1.TabIndex = 0
        '
        'frmAplicacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(661, 443)
        Me.Controls.Add(Me.MenuCinematico1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAplicacao"
        Me.Text = "Formulário Inicial"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuCinematico1 As CTRL_Menu_do_cinema.MenuCinematico
End Class
