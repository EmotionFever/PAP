Public Class frmVendas
    Public Const MAX_ARTIGOS As Integer = 25
    Public art(MAX_ARTIGOS) As Artigo
    Public cont_art As Integer = 0
    Private Sub CtrL_MenuCine_Load(sender As System.Object, e As System.EventArgs) Handles CtrL_MenuCine.Load
        CtrL_MenuCine.Sincronizar_acessos()
        CtrL_MenuCine.SelecionarBotao(8)
    End Sub

    Private Sub lblProduto_Click(sender As System.Object, e As System.EventArgs) Handles btnProduto.Click
        frmVendas_Inserir.Show()
    End Sub

    Private Sub lblX_Click(sender As System.Object, e As System.EventArgs) Handles lblX.Click
        pnltest.Hide()
    End Sub

    Private Sub frmVendas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub ApagarProduto(sender As System.Object, e As System.EventArgs)
        Dim btnx As Button = DirectCast(sender, Button)


    End Sub
End Class