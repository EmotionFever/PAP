Public Class frmVendas

    Private Sub CtrL_MenuCine_Load(sender As System.Object, e As System.EventArgs) Handles CtrL_MenuCine.Load
        CtrL_MenuCine.SelecionarBotao(8)
    End Sub

    Private Sub lblProduto_Click(sender As System.Object, e As System.EventArgs) Handles lblProduto.Click
        frmVendas_Inserir.Show()
    End Sub


    Private Sub frmVendas_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub lblX_Click(sender As System.Object, e As System.EventArgs) Handles lblX.Click
        pnltest.Hide()
    End Sub


End Class