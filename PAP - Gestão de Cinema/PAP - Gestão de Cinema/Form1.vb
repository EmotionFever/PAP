Public Class frmLogin
    Private Function verificacao() As Boolean
        If txtNome.Text <> "" Then
            'Se utilizador existe na base de dados
            '   rctUtl.BackColor = Color.LightGreen
            '   rctUtl.BorderColor = Color.LightGreen
            '   txtNome.BackColor = Color.LightGreen
            '   pctUtl.BackColor = Color.LightGreen
            'Else
            '   lblErroUtl.Text = "Utilizador inexistente"
            '   rctUtl.BackColor = Color.LightSalmon
            '   rctUtl.BorderColor = Color.LightSalmon
            '   txtNome.BackColor = Color.LightSalmon
            '   txtNome.ForeColor = Color.Red
            '   pct1.BackColor = Color.LightSalmon
        Else
            lblErroUtl.Text = "Não escreveu o nome de utilizador"
            rctUtl.BackColor = Color.LightSalmon
            rctUtl.BorderColor = Color.LightSalmon
            txtNome.BackColor = Color.LightSalmon
            pctUtl.BackColor = Color.LightSalmon
        End If

        If txtPass.Text <> "" Then
            'Se senha não coincide com o utilizador
            '   lblErroPass.Text = "Palavra-passe incorreta"
            '   rctPass.BackColor = Color.LightSalmon
            '   rctPass.BorderColor = Color.LightSalmon
            '   txtPass.BackColor = Color.LightSalmon
            '   txtNome.ForeColor = Color.Red
            '   pct2.BackColor = Color.LightSalmon

        Else
            lblErroPass.Text = "Não escreveu a palavra-passe"
            rctPass.BackColor = Color.LightSalmon
            rctPass.BorderColor = Color.LightSalmon
            txtPass.BackColor = Color.LightSalmon
            pctPass.BackColor = Color.LightSalmon
        End If

        If lblErroPass.Text = "" And lblErroUtl.Text = "" Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub lbl3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEntrar.Click
        If verificacao() Then
            frmAplicacao.Show()
            Me.Hide()
        End If
        'Código entrar
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
End Class
