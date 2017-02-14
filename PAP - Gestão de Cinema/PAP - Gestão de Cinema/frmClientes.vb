Public Class frmClientes

    Private Sub chkemail_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkMorada1.CheckedChanged

    End Sub

    Private Sub CtrL_MenuCine1_Load(sender As System.Object, e As System.EventArgs) Handles CtrL_MenuCine.Load
        CtrL_MenuCine.Sincronizar_acessos()
        CtrL_MenuCine.SelecionarBotao(2)
    End Sub

    Private Sub frmClientes_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub
End Class