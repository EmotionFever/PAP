Public Class frmVendas
    Public Const MAX_ARTIGOS As Integer = 25
    Public art(MAX_ARTIGOS) As Artigo
    Public cont_art As Integer = 0
    Private Sub CtrL_MenuCine_Load(sender As System.Object, e As System.EventArgs) Handles CtrL_MenuCine.Load
        CtrL_MenuCine.Sincronizar_acessos(Me, 8)
    End Sub

    Private Sub lblProduto_Click(sender As System.Object, e As System.EventArgs) Handles btnProduto.Click
        frmVendas_Inserir.Show()
    End Sub

    Public Sub ApagarProduto(sender As System.Object, e As System.EventArgs)
        Dim btnx As Button = DirectCast(sender, Button)


    End Sub

    Private Sub btnOutro_Click(sender As System.Object, e As System.EventArgs) Handles btnOutro.Click
        frmClientes.Show()
        Me.Close()
    End Sub
End Class