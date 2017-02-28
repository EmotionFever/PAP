Public Class frmFuncionarios

    Private Sub CtrL_MenuCine1_Load(sender As System.Object, e As System.EventArgs) Handles CtrL_MenuCine.Load
        CTRL_MenuCine.Sincronizar_acessos()
        CTRL_MenuCine.SelecionarBotao(2)
    End Sub
End Class