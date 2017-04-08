Public Class frmCalendarios
    Private Sub CtrL_MenuCine_Load(sender As System.Object, e As System.EventArgs) Handles CtrL_MenuCine.Load
        'CtrL_MenuCine.Sincronizar_acessos(Me, 5)
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub frmCalendarios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tlpSalas.ColumnCount += 1
        tlpSalas.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute = 134))
        Dim lbl = New Label
        With lbl
            .TextAlign = ContentAlignment.MiddleCenter
            .Text = "Sala 2"
            .Dock = DockStyle.Fill
            .ForeColor = Color.White
            .Font = New Font("Arial", 9, FontStyle.Regular)
            .AutoSize = False
        End With
        tlpSalas.Size = New Size(tlpSalas.Size.Width + 134, tlpSalas.Size.Height)
        tlpSalas.Controls.Add(lbl)

        tlpHoras.ColumnCount += 1
        tlpHoras.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute = 134))
        tlpHoras.Size = New Size(tlpHoras.Size.Width + 134, tlpHoras.Size.Height)
    End Sub


    Private Sub lblH0_Click(sender As System.Object, e As System.EventArgs) Handles lblH0.Click

    End Sub
End Class