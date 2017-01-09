Public Class frmAplicacao
    Dim m As New CTRL_Menu_do_cinema.MenuCinematico
    Private Sub frmAplicacao_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub frmInico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuCinematico1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuCinematico1.Load
        'm.SelecionarBotao(1)
    End Sub
End Class