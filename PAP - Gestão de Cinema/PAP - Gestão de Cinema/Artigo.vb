Public Class Artigo 'Classe dos artigos que aparecem no flpartigos!
    Public pnl As Panel
    Public btn As Button
    Public pct As PictureBox
    Public lbl(4) As Label
    Public listado As Boolean ' Se VERDADEIRO significa que está na flpartigos do frmVendas_Inserir se FALSO foi eliminado entretanto
    Public Cod As Integer 'Cod de um produto ou de um bilhete
    Public query As String ' Se a string for ≠ de vazio significa que terá guardada um query para INSERIR um novo bilhete (registo) na tabela BILHETES - ou seja, o artigo é um bilhete
    Public quant As Integer 'Guarda a quantidade de artigos da venda
End Class
