Imports MySql.Data.MySqlClient
Public Class frmLogin
    Dim ligacao As New MySqlConnection("Server=localhost;DataBase=ppap;Uid=root;Pwd=;Connect Timeout=30;")
    Dim adapter As New MySqlDataAdapter
    Dim comando As MySqlCommand
    Dim query As String
    Dim leitor As MySqlDataReader
    Public codF As Integer
    Public ass(CTRL_MenuCine.DIMTA) As Acesso

    Private Sub restaurarUtl()
        lblErroUtl.Text = ""
        AlterarEstado(rctUtl, txtNome, pctUtl, "restaurar")
    End Sub

    Private Sub restaurarPass()
        lblErroPass.Text = ""
        AlterarEstado(rctPass, txtPass, pctPass, "restaurar")
    End Sub

    Private Sub verificacao()
        restaurarUtl()
        restaurarPass()

        If txtNome.Text = "" Then
            lblErroUtl.Text = "Não escreveu o nome de utilizador"
            AlterarEstado(rctUtl, txtNome, pctUtl, "errar")
        End If

        If txtPass.Text = "" Then
            lblErroPass.Text = "Não escreveu a palavra-passe"
            AlterarEstado(rctPass, txtPass, pctPass, "errar")
        End If

        If lblErroUtl.Text <> "" Or lblErroPass.Text <> "" Then
            Exit Sub
        End If

        Try
            query = "select funcionarios.codF as codF, funcionarios.nome, funcionarios.palavra_passe as palavra_passe  from funcionarios, encargos where funcionarios.code=encargos.code and funcionarios.empregado=1 and encargos.ativado=1 and username='" + txtNome.Text + "'" '"select funcionarios.nome, encargos.nome from funcionarios, encargos where funcionarios.code=encargos.code and funcionarios.nome='zé'"
            comando = New MySqlCommand(query, ligacao)
            ligacao.Open()
            leitor = comando.ExecuteReader
            If leitor.Read Then 'Utilizador está empregado e o seu encargo não está desativado
                AlterarEstado(rctUtl, txtNome, pctUtl, "acertar")
                If txtPass.Text = leitor.GetString("palavra_passe") Then
                    codF = leitor.GetInt32("codF")
                    ligacao.Dispose()

                    query = "select aux_enc.codta as tabela, aux_enc.codPe as permissao from funcionarios, encargos, aux_enc where funcionarios.codE=encargos.codE and  encargos.codE=aux_enc.codE and codF=" + codF.ToString
                    comando = New MySqlCommand(query, ligacao)
                    ligacao.Open()
                    leitor = comando.ExecuteReader
                    Dim cont_per As Integer = 0
                    While leitor.Read
                        If ass(cont_per).tabela = leitor.GetInt32("tabela") Then
                            ass(cont_per).permissao(leitor.GetInt32("permissao") - 1) = True
                        Else
                            cont_per += 1
                            ass(cont_per).permissao(leitor.GetInt32("permissao") - 1) = True
                        End If
                    End While
                    ligacao.Dispose()

                    frmHome.Show()
                    Me.Hide()
                Else
                    lblErroPass.Text = "Palavra-passe incorreta"
                    AlterarEstado(rctPass, txtPass, pctPass, "errar")
                    ligacao.Dispose()
                End If
            Else
                lblErroUtl.Text = "Utilizador inexistente"
                AlterarEstado(rctUtl, txtNome, pctUtl, "acertar")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ligacao.Close()
        End Try
    End Sub

    Private Sub lbl3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        verificacao()
    End Sub

    Private Sub txtNome_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNome.TextChanged
        restaurarUtl()
    End Sub

    Private Sub txtPass_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPass.TextChanged
        restaurarPass()
    End Sub

    Private Sub frmLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        For a As Integer = 0 To CTRL_MenuCine.DIMTA - 1
            ass(a) = New Acesso
        Next
    End Sub
End Class
