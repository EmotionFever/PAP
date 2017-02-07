Imports MySql.Data.MySqlClient
Public Class frmLogin
    Dim ligacao As New MySqlConnection("Server=localhost;DataBase=ppap;Uid=root;Pwd=;Connect Timeout=30;")
    Dim adapter As New MySqlDataAdapter
    Dim comando As MySqlCommand
    Dim query As String
    Dim leitor As MySqlDataReader
    Private Sub verificacao()
        If txtNome.Text = "" Then
            lblErroUtl.Text = "Não escreveu o nome de utilizador"
            rctUtl.BackColor = Color.LightSalmon
            rctUtl.BorderColor = Color.LightSalmon
            txtNome.BackColor = Color.LightSalmon
            pctUtl.BackColor = Color.LightSalmon
        End If

        If txtPass.Text = "" Then
            lblErroPass.Text = "Não escreveu a palavra-passe"
            rctPass.BackColor = Color.LightSalmon
            rctPass.BorderColor = Color.LightSalmon
            txtPass.BackColor = Color.LightSalmon
            pctPass.BackColor = Color.LightSalmon
        End If

        If lblErroUtl.Text <> "" Or lblErroPass.Text <> "" Then
            Exit Sub
        End If

        query = "select codG, nome from funcionarios"
        comando = New MySqlCommand(query, ligacao)

        ligacao.Open()
        leitor = comando.ExecuteReader

        'Se utilizador existe na base de dados
        '   rctUtl.BackColor = Color.LightGreen
        '   rctUtl.BorderColor = Color.LightGreen
        '   txtNome.BackColor = Color.LightGreen
        '   pctUtl.BackColor = Color.LightGreen

        '   Se txtPass.text = palavrapasse 
        '       me.hide()
        '       frmHome.show()
        'Else
        '   lblErroUtl.Text = "Utilizador inexistente"
        '   rctUtl.BackColor = Color.LightSalmon
        '   rctUtl.BorderColor = Color.LightSalmon
        '   txtNome.BackColor = Color.LightSalmon
        '   txtNome.ForeColor = Color.Red
        '   pct1.BackColor = Color.LightSalmon
    End Sub

    Private Sub lbl3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        verificacao()
    End Sub

    Private Sub txtNome_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNome.TextChanged
        lblErroUtl.Text = ""
        rctUtl.BackColor = Color.White
        rctUtl.BorderColor = Color.White
        txtNome.BackColor = Color.White
        txtNome.ForeColor = Color.Black
        pctUtl.BackColor = Color.White
    End Sub

    Private Sub txtPass_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPass.TextChanged
        lblErroPass.Text = ""
        rctPass.BackColor = Color.White
        rctPass.BorderColor = Color.White
        txtPass.BackColor = Color.White
        txtPass.ForeColor = Color.Black
        pctPass.BackColor = Color.White
    End Sub

    Private Sub frmLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
