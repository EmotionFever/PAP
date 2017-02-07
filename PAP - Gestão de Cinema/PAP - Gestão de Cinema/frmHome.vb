Imports MySql.Data.MySqlClient
Public Class frmHome
    Dim ligacao As New MySqlConnection("Server=localhost;DataBase=ppap;Uid=root;Pwd=;Connect Timeout=30;")
    Dim adapter As New MySqlDataAdapter
    Dim comando As MySqlCommand
    Dim query As String
    Dim leitor As MySqlDataReader
    'Código tipo para todos os formulários
    Private Sub CtrL_MenuCine_Load(sender As System.Object, e As System.EventArgs) Handles CtrL_MenuCine.Load
        CtrL_MenuCine.SelecionarBotao(0)
    End Sub



    Private Sub frmHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim nome, nome_completo As String
        query = "select * from funcionarios where codF=" + frmLogin.codF.ToString

        comando = New MySqlCommand(query, ligacao)
        ligacao.Open()
        leitor = comando.ExecuteReader
        leitor.Read()
        nome_completo = leitor.GetString("nome")

        'Código para mostrar apenas o 1º nome
        For y As Integer = 0 To nome_completo.Length - 1
            If nome_completo(y) = " " Then
                nome = nome_completo.Remove(y, nome_completo.Length - y)
                Exit For
            End If
        Next
        lblPergunta.Text = "O que deseja fazer, " + nome + "?"
        ligacao.Dispose()
    End Sub

    Private Sub frmHome_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub


End Class