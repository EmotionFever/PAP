Imports MySql.Data.MySqlClient
Public Class frmVendas
    Dim ligacao As New MySqlConnection("Server=localhost;DataBase=ppap;Uid=root;Pwd=;Connect Timeout=30;")
    Public Const MAX_ARTIGOS As Integer = 25
    Public art(MAX_ARTIGOS) As Artigo
    Public cont_art As Integer = 0
    Public prod_total As Integer
    Private Sub CtrL_MenuCine_Load(sender As System.Object, e As System.EventArgs) Handles CtrL_MenuCine.Load
        'CtrL_MenuCine.Sincronizar_acessos(Me, 8)
    End Sub

    Private Sub lblProduto_Click(sender As System.Object, e As System.EventArgs) Handles btnProduto.Click
        prod_total = ter(ligacao, "quantidade", "select count(codP) as quantidade from produtos where ativado=1")
        frmVendas_Inserir.Show()
    End Sub

    Public Sub ApagarProduto(sender As System.Object, e As System.EventArgs)
        Dim btnx As Button = DirectCast(sender, Button)
    End Sub

    Private Sub btnOutro_Click(sender As System.Object, e As System.EventArgs) Handles btnOutro.Click
        If frmLogin.ass(2).permissao(2) Then
            frmClientes.Show()
            Me.Close()
        Else
            MessageBox.Show("Não tem permissão para inserir novos clientes", "Insersão impossível", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub frmVendas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class