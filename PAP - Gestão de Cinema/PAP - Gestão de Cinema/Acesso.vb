Public Class Acesso
    Public Const DIMPER As Integer = 3
    Public permissao(DIMPER) As Boolean
    '0 -> consultar; 1 -> alterar; 2 -> inserir

    Public Function acesso() As Boolean
        Dim soma As Integer = 0
        For y As Integer = 0 To DIMPER - 1
            soma += permissao(y)
        Next
        If soma = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
End Class
