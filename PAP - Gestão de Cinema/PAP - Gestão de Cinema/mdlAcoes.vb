Module mdlAcoes
    Public Sub AlterarEstado(rct As PowerPacks.RectangleShape, obj As Object, pct As PictureBox, str As String)
        If str = "restaurar" Then
            obj.BackColor = Color.White
            rct.BackColor = Color.White
            rct.BorderColor = Color.White
            obj.ForeColor = Color.Black
            pct.BackColor = Color.White
        ElseIf str = "errar" Then
            obj.BackColor = Color.LightSalmon
            rct.BackColor = Color.LightSalmon
            rct.BorderColor = Color.LightSalmon
            obj.ForeColor = Color.Red
            pct.BackColor = Color.LightSalmon
        ElseIf str = "acertar" Then
            obj.BackColor = Color.LightGreen
            rct.BackColor = Color.LightGreen
            rct.BorderColor = Color.LightGreen
            pct.BackColor = Color.LightGreen
        End If
    End Sub
    Public Sub AlterarEstado(rct As PowerPacks.RectangleShape, obj As Object, str As String)
        If str = "restaurar" Then
            obj.BackColor = Color.White
            rct.BackColor = Color.White
            rct.BorderColor = Color.White
            obj.ForeColor = Color.Black
        ElseIf str = "errar" Then
            obj.BackColor = Color.LightSalmon
            rct.BackColor = Color.LightSalmon
            rct.BorderColor = Color.LightSalmon
            obj.ForeColor = Color.Red
        ElseIf str = "acertar" Then
            obj.BackColor = Color.LightGreen
            rct.BackColor = Color.LightGreen
            rct.BorderColor = Color.LightGreen
        End If
    End Sub
    Public Sub AlterarEstado(rct As PowerPacks.RectangleShape, str As String)
        If str = "restaurar" Then
            rct.BackColor = Color.White
            rct.BorderColor = Color.White
        ElseIf str = "errar" Then
            rct.BackColor = Color.LightSalmon
            rct.BorderColor = Color.LightSalmon
        ElseIf str = "acertar" Then
            rct.BackColor = Color.LightGreen
            rct.BorderColor = Color.LightGreen
        End If
    End Sub

    Function verificacao(rct As PowerPacks.RectangleShape, obj As Object) As String
        If TypeOf obj Is TextBox Then
            If obj.Text = "" Or IsNumeric(obj.Text) Then
                AlterarEstado(rct, obj, "errar")
                Return "Não escreveu um " + obj.tag.ToString + " válido. "
            Else
                AlterarEstado(rct, obj, "acertar")
                Return ""
            End If
        End If
        If TypeOf obj Is MaskedTextBox Then
            If obj.Text = "" Or obj.Text.Length < 9 Then
                AlterarEstado(rct, obj, "errar")
                Return "Não escreveu um " + obj.tag.ToString + ". "
            Else
                AlterarEstado(rct, obj, "acertar")
                Return ""
            End If
        End If
        If TypeOf obj Is ComboBox Then
            If obj.Text = "" Then
                AlterarEstado(rct, "errar")
                Return "Não escolheu uma " + obj.tag.ToString + ". "
            Else
                AlterarEstado(rct, "acertar")
                Return ""
            End If
        End If
    End Function
End Module
