Public Class frmVendas

    Private Sub CtrL_MenuCine_Load(sender As System.Object, e As System.EventArgs) Handles CtrL_MenuCine.Load
        CtrL_MenuCine.SelecionarBotao(8)
    End Sub

    Private Sub lblProduto_Click(sender As System.Object, e As System.EventArgs) Handles lblProduto.Click
        frmVendas_Inserir.Show()
    End Sub
End Class