Imports MySql.Data.MySqlClient
Public Class frmCalendarios
    Dim ligacao As New MySqlConnection("Server=localhost;DataBase=ppap;Uid=root;Pwd=;Connect Timeout=30;")
    Dim comando As MySqlCommand
    Dim leitor As MySqlDataReader
    Public Const MAXCALENDARIOS As Integer = 50 ' número máximo de sessões que mostro de um dia numa determinada sala
    Dim sss(MAXCALENDARIOS) As Sessao
    Dim cont_calendarios As Integer = 0
    Dim codSelecionado As Integer

    Public Sub pnlGrade1_Paint(sender As Object, e As PaintEventArgs) Handles pnlGrade1.Paint
        Dim cor As Color = Color.Black
        Dim caneta As Pen = New Pen(cor, 1)
        Dim g As Graphics = e.Graphics
        Dim ponto1 As New Point(0, 180)
        Dim ponto2 As New Point(100, 180)
        For y As Integer = 60 To 60 * 23 Step 60
            ponto1 = New Point(0, y)
            ponto2 = New Point(pnlGrade1.Size.Width, y)
            g.DrawLine(caneta, ponto1, ponto2)
        Next
        g.Dispose()
    End Sub

    Private Sub CtrL_MenuCine_Load(sender As System.Object, e As System.EventArgs) Handles CtrL_MenuCine.Load
        Dim btnProcurar As New Button
        CtrL_MenuCine.Sincronizar_acessos(Me, 5)
        CtrL_MenuCine.Sincronizar_permissoes({btnProcurar}, {btnAlterar, pnlAtivar}, {btnInserir})
        If btnProcurar.Visible And Not btnAlterar.Visible And Not btnInserir.Visible Then
            pnlControlos.Hide()
        End If
        If btnInserir.Visible And Not btnAlterar.Visible And Not btnInserir.Visible Then
            pnlMostrar.Hide()
        End If
    End Sub

    Private Sub LimparTudo()
        'Limpo os objetos input do formulário
        cmbFilme.Text = ""
        AlterarEstado(rctFilme, cmbFilme, "restaurar")
        chkFilme.Checked = False

        cmbSala.Text = ""
        AlterarEstado(rctSala, cmbSala, "restaurar")
        chkSala.Checked = False

        'Limpar o tempo
        nmrHoras.Value = 0
        AlterarEstado(rctHoras, "restaurar")
        nmrMinutos.Value = 0
        AlterarEstado(rctMinutos, "restaurar")
        chkTempo.Checked = False

        dtpDataI.Value = DateTime.Now
        AlterarEstado(rctDataI, "restaurar")
        chkDataI.Checked = False

        dtpDataF.Value = DateTime.Now
        AlterarEstado(rctDataF, "restaurar")
        chkDataF.Checked = False
    End Sub

    Private Sub des_selecionar()
        pnlCalM.BorderStyle = BorderStyle.FixedSingle
        pnlCalM.BackColor = Color.FromArgb(192, 255, 192)
        lblNome.Text = "Nome do Filme"
        lblNome.Font = New Font(lblNome.Font, lblNome.Font.Style And Not FontStyle.Strikeout)
        pctFilme.BackgroundImage = My.Resources.horarios
        lblHoras.Text = "Hora Inicial - Hora Final"
        lblHoras.Font = New Font(lblHoras.Font, lblHoras.Font.Style And Not FontStyle.Strikeout)
        lblSala.Text = "Designação da Sala"
        lblSala.Font = New Font(lblSala.Font, lblSala.Font.Style And Not FontStyle.Strikeout)
        lblPrazo.Text = "Período de exibição"
        lblPrazo.Font = New Font(lblPrazo.Font, lblPrazo.Font.Style And Not FontStyle.Strikeout)

        codSelecionado = 0

        btnAlterar.Enabled = False
        btnDesativar.Enabled = False
    End Sub

    Private Sub SessaoClicada(ByVal sender As Object, ByVal e As EventArgs)
        Dim btnx As Button = DirectCast(sender, Button) 'Este botão ganha todas as características do botão clicado

        pnlCalM.BorderStyle = BorderStyle.Fixed3D
        pnlCalM.BackColor = sss(CInt(btnx.Tag)).pnl.BackColor
        lblNome.Text = sss(CInt(btnx.Tag)).lblFilme.Text
        pctFilme.BackgroundImage = sss(CInt(btnx.Tag)).btnImgFilme.BackgroundImage
        lblHoras.Text = sss(CInt(btnx.Tag)).lblHoras.Text
        lblSala.Text = sss(CInt(btnx.Tag)).lblSalas.Text
        lblPrazo.Text = sss(CInt(btnx.Tag)).lblData.Text
        codSelecionado = sss(CInt(btnx.Tag)).codCa

        btnAlterar.Enabled = True
        btnDesativar.Enabled = True
    End Sub

    Private Sub ver(ByVal query As String)
        'Elimina todas as sessões do ecrã 
        For x As Integer = 0 To cont_calendarios - 1
            sss(x) = Nothing
        Next
        pnlGrade1.Controls.Clear()

        'Coloca as sessões, usando a respetiva classe, da BD
        Try
            comando = New MySqlCommand(query, ligacao)
            ligacao.Open()
            leitor = comando.ExecuteReader
            While leitor.Read
                If cont_calendarios < MAXCALENDARIOS Then
                    sss(cont_calendarios) = New Sessao
                    If Not IsDBNull(leitor.Item("imagem")) Then
                        Dim lb() As Byte = leitor.Item("imagem")
                        Dim lstr As New System.IO.MemoryStream(lb)
                        sss(cont_calendarios).criar_sss(leitor.GetInt32("codCa"), leitor.GetString("filme"), Image.FromStream(lstr), leitor.GetInt32("minutosi"), leitor.GetInt32("minutosf"), leitor.GetString("sala"), leitor.GetString("datai"), leitor.GetString("dataf"), cont_calendarios, pnlGrade1)
                    Else
                        sss(cont_calendarios).criar_sss(leitor.GetInt32("codCa"), leitor.GetString("filme"), leitor.GetInt32("minutoi"), leitor.GetInt32("minutof"), leitor.GetString("sala"), leitor.GetString("datai"), leitor.GetString("dataf"), cont_calendarios, pnlGrade1)
                    End If
                    AddHandler sss(cont_calendarios).btnImgFilme.Click, AddressOf SessaoClicada
                    cont_calendarios += 1

                Else
                    MessageBox.Show("O limite máximo de sessões que o programa pode mostrar é de " + MAXCALENDARIOS + " sessões", "Excesso de sessões", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit While
                End If
            End While
            ligacao.Close()
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro a ver: " + ex.Message, "Visualização sem sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ligacao.Close()
        End Try
        'pnlGrade1.Refresh()
    End Sub

    Private Sub ver_todos()
        btnAlterar.Enabled = False
        btnDesativar.Enabled = False
        codSelecionado = 0
        ver("select codCa" &
            ", filmes.nome as filme" &
            ", hour(calendarios.hora) * 60 + minute(calendarios.hora) as minutosi, (hour(calendarios.hora)+hour(filmes.duracao)) * 60 + minute(calendarios.hora)+minute(filmes.duracao) as minutosf" &
            ", salas.nome as sala" &
            ", calendarios.datai as datai" &
            ", calendarios.dataf as dataf" &
            ", filmes.imagem as imagem " &
            "from calendarios, filmes, salas " &
            "where calendarios.cods=salas.cods " &
            "and calendarios.codfl=filmes.codfl " &
            "and salas.cods=" + If(cmbSalaS.SelectedValue IsNot Nothing, cmbSalaS.SelectedValue.ToString, "0") + " " &
            "and CAST('" + dtpDataS.Value.Year.ToString + "-" + dtpDataS.Value.Month.ToString + "-" + dtpDataS.Value.Day.ToString + "' AS DATE) between calendarios.datai and calendarios.dataf " &
            "UNION " &
            "select codCa" &
            ", filmes.nome as filme" &
            ", hour(calendarios.hora) * 60 + minute(calendarios.hora) - 24 * 60 as minutosi" &
            ", (hour(calendarios.hora)+hour(filmes.duracao)) * 60 + minute(calendarios.hora)+minute(filmes.duracao) - 24 * 60 as minutosf" &
            ", salas.nome as sala" &
            ", calendarios.datai as datai" &
            ", calendarios.dataf as dataf" &
            ", filmes.imagem as imagem " &
            "from calendarios, filmes, salas " &
            "where calendarios.cods = salas.cods " &
            "and calendarios.codfl=filmes.codfl " &
            "and salas.cods=" + If(cmbSalaS.SelectedValue IsNot Nothing, cmbSalaS.SelectedValue.ToString, "0") + " " &
            "and CAST('" + dtpDataS.Value.AddDays(-1).Year.ToString + "-" + dtpDataS.Value.AddDays(-1).Month.ToString + "-" + dtpDataS.Value.AddDays(-1).Day.ToString + "' AS DATE) between calendarios.datai and calendarios.dataf " &
            "and TIME_TO_SEC(hora)+TIME_TO_SEC(duracao) > TIME_TO_SEC('24:00')")
    End Sub

    Private Sub frmCalendarios_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btnDesativar.Enabled = False
        btnAlterar.Enabled = False

        'Aqui, encho as combobox com dados para o utilizador escolher
        encher(cmbFilme, ligacao, "filmes", "nome", "codfl", "select codfl, nome from filmes where ativado=1")
        cmbFilme.Text = ""
        encher(cmbSala, ligacao, "salas", "nome", "cods", "select cods, nome from salas where ativado=1")
        cmbSala.Text = ""
        encher(cmbSalaS, ligacao, "salas", "nome", "cods", "select cods, nome from salas where ativado=1")

        ver_todos() 'O ver tem de ser aqui porque ele usa o cmbsalaS logo se ele for NULL, não funciona

        AddHandler cmbSalaS.SelectedValueChanged, AddressOf cmbSalaS_SelectedValueChanged
        AddHandler dtpDataS.ValueChanged, AddressOf dtpDataS_ValueChanged
    End Sub

    Private Sub btnOutro_Click(sender As System.Object, e As System.EventArgs) Handles btnOutro.Click
        If ass(1).permissao(2) Then
            CtrL_MenuCine.IrParaFilmes()
        Else
            MessageBox.Show("Não tem permissão para inserir novos filmes", "Insersão impossível", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub frmCalendarios_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If mdlAcoes.fechar Then
            End
        End If
    End Sub

    Private Sub cmbFilme_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbFilme.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmbSala_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbSala.KeyPress
        e.Handled = True
    End Sub

    Private Sub nmrHoras_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nmrHoras.KeyPress
        e.Handled = True
    End Sub

    Private Sub nmrMinutos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nmrMinutos.KeyPress
        e.Handled = True
    End Sub

    Private Function verificar_intervalo(ByVal DataI As String, ByVal DataF As String, ByVal HoraI As String) As String
        Return ter_str(ligacao, "strPP",
            "SELECT CONCAT(datai,' e ',dataf,' do filme ',filmes.nome,' das ',hora,' às ',SEC_TO_TIME(TIME_TO_SEC(hora)+TIME_TO_SEC(duracao))) as strPP " &
            "FROM calendarios, filmes " &
            "WHERE calendarios.codfl = filmes.codfl " &
            "AND calendarios.codca<>" + codSelecionado.ToString + " " &
            "AND calendarios.cods=" + cmbSala.SelectedValue.ToString + " " &
            "AND ((('" + DataI + "' BETWEEN datai AND dataf " &
            "OR '" + DataF + "' BETWEEN datai AND dataf " &
            "OR datai BETWEEN '" + DataI + "' AND '" + DataF + "' " &
            "OR dataf BETWEEN '" + DataI + "' AND '" + DataF + "') " &
            "AND (time('" + HoraI + "') BETWEEN hora AND SEC_TO_TIME(TIME_TO_SEC(hora)+TIME_TO_SEC(duracao)) " &
            "OR SEC_TO_TIME(TIME_TO_SEC('" + HoraI + "')+TIME_TO_SEC((SELECT duracao FROM filmes WHERE codfl=" + cmbFilme.SelectedValue.ToString + "))) " &
            "BETWEEN hora AND SEC_TO_TIME(TIME_TO_SEC(hora)+TIME_TO_SEC(duracao)) " &
            "OR hora BETWEEN time('" + HoraI + "') and SEC_TO_TIME(TIME_TO_SEC('" + HoraI + "')+TIME_TO_SEC((SELECT duracao FROM filmes WHERE codfl=" + cmbFilme.SelectedValue.ToString + "))) " &
            "OR SEC_TO_TIME(TIME_TO_SEC(hora)+TIME_TO_SEC(duracao)) BETWEEN time('" + HoraI + "') and SEC_TO_TIME(TIME_TO_SEC('" + HoraI + "')+TIME_TO_SEC((SELECT duracao FROM filmes WHERE codfl=" + cmbFilme.SelectedValue.ToString + "))))) " &
            "OR (('" + DataI + "' BETWEEN DATE_ADD(datai, INTERVAL 1 DAY) AND DATE_ADD(dataf, INTERVAL 1 DAY) " &
            "OR '" + DataF + "' BETWEEN DATE_ADD(datai, INTERVAL 1 DAY) AND DATE_ADD(dataf, INTERVAL 1 DAY) " &
            "OR DATE_ADD(datai, INTERVAL 1 DAY) BETWEEN '" + DataI + "' AND '" + DataF + "' " &
            "OR DATE_ADD(dataf, INTERVAL 1 DAY) BETWEEN '" + DataI + "' AND '" + DataF + "') " &
            "AND time('" + HoraI + "') BETWEEN time('0:0') AND SEC_TO_TIME(TIME_TO_SEC(hora)+TIME_TO_SEC(duracao)-TIME_TO_SEC('24:00'))))")
    End Function

    Private Sub btnInserir_Click(sender As System.Object, e As System.EventArgs) Handles btnInserir.Click
        Dim str_erro As String = ""
        str_erro += verificacao(rctFilme, cmbFilme)
        str_erro += verificacao(rctSala, cmbSala)

        ' Verificar as horas e minutos
        If DateDiff(DateInterval.Day, dtpDataI.Value.Date, dtpDataF.Value.Date) >= 0 Then
            AlterarEstado(rctDataI, "acertar")
            AlterarEstado(rctDataF, "acertar")
        Else
            AlterarEstado(rctDataI, "errar")
            AlterarEstado(rctDataF, "errar")
            str_erro += "A data inicial que inseriu vem depois da data final. "
        End If

        If str_erro = "" Then
            Dim DataI As String = dtpDataI.Value.Year.ToString + "-" + dtpDataI.Value.Month.ToString + "-" + dtpDataI.Value.Day.ToString
            Dim DataF As String = dtpDataF.Value.Year.ToString + "-" + dtpDataF.Value.Month.ToString + "-" + dtpDataF.Value.Day.ToString
            des_selecionar()
            Dim HoraI As String = nmrHoras.Value.ToString + ":" + nmrMinutos.Value.ToString
            Dim r As String = verificar_intervalo(DataI, DataF, HoraI)
            If r <> "" Then
                str_erro += "Há uma sessão entre os dias " + r + " que faz conflito com a sua. "
                AlterarEstado(rctHoras, nmrHoras, "errar")
                AlterarEstado(rctMinutos, nmrMinutos, "errar")
                AlterarEstado(rctDataI, "errar")
                AlterarEstado(rctDataF, "errar")
            Else
                AlterarEstado(rctHoras, nmrHoras, "acertar")
                AlterarEstado(rctMinutos, nmrMinutos, "acertar")
            End If
        End If
        If str_erro = "" Then
            acao("inserir", ligacao, "insert into calendarios (codfl,cods,hora,datai,dataf) " &
            "values (" + cmbFilme.SelectedValue.ToString + "," + cmbSala.SelectedValue.ToString + "," &
            "'" + nmrHoras.Value.ToString + ":" + nmrMinutos.Value.ToString + "'," &
            "'" + dtpDataI.Value.Year.ToString + "-" + dtpDataI.Value.Month.ToString + "-" + dtpDataI.Value.Day.ToString + "'," &
            "'" + dtpDataF.Value.Year.ToString + "-" + dtpDataF.Value.Month.ToString + "-" + dtpDataF.Value.Day.ToString + "')", 1)

            LimparTudo()

            'Volto a mostrar a tabela, mas, desta vez, atualizada.
            ver_todos()
        Else
            MessageBox.Show(str_erro, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnDesativar.Click
        'Desativo os dados da linha selecionada na base de dados
        If codSelecionado > 0 Then
            If ter(ligacao, "quant", "select count(*) as quant from bilhetes where codca=" + codSelecionado.ToString) = 0 Then
                acao("eliminar", ligacao, "delete from calendarios where codca=" + codSelecionado.ToString, 1)

                ver_todos()

                pnlCalM.BackColor = Color.FromArgb(224, 224, 224)
            Else
                MessageBox.Show("Como a sessão que selecionou se encontra associada a pelo menos um bilhete, não pode ser eliminada", "Não é possível eliminar essa sessão", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub cmbFilmes_TextChanged(sender As Object, e As System.EventArgs) Handles cmbFilme.SelectedValueChanged
        AlterarEstado(rctFilme, "restaurar")
    End Sub

    Private Sub cmbSala_TextChanged(sender As Object, e As System.EventArgs) Handles cmbSala.SelectedValueChanged
        AlterarEstado(rctSala, "restaurar")
    End Sub

    Private Sub nmrHoras_TextChanged(sender As Object, e As System.EventArgs) Handles nmrHoras.ValueChanged
        AlterarEstado(rctHoras, nmrHoras, "restaurar")
        AlterarEstado(rctMinutos, nmrMinutos, "restaurar")
        AlterarEstado(rctDataI, "restaurar")
        AlterarEstado(rctDataF, "restaurar")
    End Sub

    Private Sub nmrMinutos_TextChanged(sender As Object, e As System.EventArgs) Handles nmrMinutos.ValueChanged
        AlterarEstado(rctHoras, nmrHoras, "restaurar")
        AlterarEstado(rctMinutos, nmrMinutos, "restaurar")
        AlterarEstado(rctDataI, "restaurar")
        AlterarEstado(rctDataF, "restaurar")
    End Sub

    Private Sub dtpDataI_TextChanged(sender As Object, e As System.EventArgs) Handles dtpDataI.ValueChanged
        AlterarEstado(rctHoras, nmrHoras, "restaurar")
        AlterarEstado(rctMinutos, nmrMinutos, "restaurar")
        AlterarEstado(rctDataI, "restaurar")
        AlterarEstado(rctDataF, "restaurar")
    End Sub

    Private Sub dtpDataF_TextChanged(sender As Object, e As System.EventArgs) Handles dtpDataF.ValueChanged
        AlterarEstado(rctHoras, nmrHoras, "restaurar")
        AlterarEstado(rctMinutos, nmrMinutos, "restaurar")
        AlterarEstado(rctDataI, "restaurar")
        AlterarEstado(rctDataF, "restaurar")
    End Sub

    Private Sub btnAlterar_Click(sender As System.Object, e As System.EventArgs) Handles btnAlterar.Click
        Dim str_erro As String = ""
        Dim pquery As String = ""
        Dim averiguar As String = ""
        If codSelecionado > 0 Then
            If chkFilme.Checked Then
                str_erro += verificacao(rctFilme, cmbFilme)
            End If
            If chkSala.Checked Then
                str_erro += verificacao(rctSala, cmbSala)
            End If

            ' Verificar as horas e minutos
            If chkDataI.Checked And chkDataF.Checked Then
                If DateDiff(DateInterval.Year, dtpDataI.Value.Date, dtpDataF.Value.Date) >= 0 Then
                    AlterarEstado(rctDataI, "acertar")
                    AlterarEstado(rctDataF, "acertar")
                Else
                    AlterarEstado(rctDataI, "errar")
                    AlterarEstado(rctDataF, "errar")
                    str_erro += "A data inicial que inseriu vem depois da data final. "
                End If
            End If

            If str_erro = "" And (chkFilme.Checked Or chkSala.Checked Or chkTempo.Checked Or chkDataI.Checked Or chkDataF.Checked) Then
                Dim time As DateTime
                Dim codfl As Integer
                If chkFilme.Checked Then
                    codfl = cmbFilme.SelectedValue
                Else
                    codfl = ter(ligacao, "codfl", "select codfl from calendarios where codca=" + codSelecionado.ToString)
                End If
                Dim cods As Integer
                If chkSala.Checked Then
                    cods = cmbSala.SelectedValue
                Else
                    cods = ter(ligacao, "cods", "select cods from calendarios where codca=" + codSelecionado.ToString)
                End If
                Dim DataI As String
                If chkDataI.Checked Then
                    DataI = dtpDataI.Value.Year.ToString + "-" + dtpDataI.Value.Month.ToString + "-" + dtpDataI.Value.Day.ToString
                Else
                    time = DateTime.Parse(ter_str(ligacao, "datai", "select datai from calendarios where codca=" + codSelecionado.ToString))
                    DataI = time.Year.ToString + "-" + time.Month.ToString + "-" + time.Day.ToString
                End If
                Dim DataF As String
                If chkDataF.Checked Then
                    DataF = dtpDataF.Value.Year.ToString + "-" + dtpDataF.Value.Month.ToString + "-" + dtpDataF.Value.Day.ToString
                Else
                    time = DateTime.Parse(ter_str(ligacao, "dataf", "select dataf from calendarios where codca=" + codSelecionado.ToString))
                    DataF = time.Year.ToString + "-" + time.Month.ToString + "-" + time.Day.ToString
                End If
                Dim HoraI As String
                If chkTempo.Checked Then
                    HoraI = nmrHoras.Value.ToString + ":" + nmrMinutos.Value.ToString
                Else
                    HoraI = ter_str(ligacao, "hora", "select hora from calendarios where codca=" + codSelecionado.ToString)
                End If
                Dim r As String = verificar_intervalo(DataI, DataF, HoraI)
                If r <> "" Then
                    str_erro += "Há uma sessão entre os dias " + r + " que faz conflito com a sua alterada. "
                    If chkTempo.Checked Then
                        AlterarEstado(rctHoras, nmrHoras, "errar")
                        AlterarEstado(rctMinutos, nmrMinutos, "errar")
                    End If
                    If chkDataI.Checked Then
                        AlterarEstado(rctDataI, "errar")
                    End If
                    If chkDataF.Checked Then
                        AlterarEstado(rctDataF, "errar")
                    End If

                Else
                    If chkTempo.Checked Then
                        AlterarEstado(rctHoras, nmrHoras, "acertar")
                        AlterarEstado(rctMinutos, nmrMinutos, "acertar")
                    End If
                    pquery += " cods=" + cods.ToString + ", codfl=" + codfl.ToString + ", datai='" + DataI + "', dataf='" + DataF + "', hora='" + HoraI + "'"
                End If
            End If

            If str_erro = "" Then
                If pquery <> "" Then
                    acao("alterar", ligacao, "update calendarios set" + pquery + " where codca=" + codSelecionado.ToString, 1)

                    ver_todos()

                    LimparTudo()

                    des_selecionar()
                Else
                    MessageBox.Show("Não selecionou nenhum campo para alterar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show(str_erro, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub dtpDataS_ValueChanged(sender As Object, e As System.EventArgs)
        ver_todos()
    End Sub

    Private Sub cmbSalaS_SelectedValueChanged(sender As Object, e As System.EventArgs)
        ver_todos()
    End Sub
End Class