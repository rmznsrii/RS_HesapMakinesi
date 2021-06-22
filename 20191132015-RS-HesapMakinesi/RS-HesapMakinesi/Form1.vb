Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
    Private Function toplama(ByVal sayi1 As Double, sayi2 As Double) As Double
        Return sayi1 + sayi2
    End Function

    Private Sub toplamabtn_Click(sender As Object, e As EventArgs) Handles toplamabtn.Click
        Dim sonuc As Double
        sonuc = toplama(sayi1:=TextBox1.Text, sayi2:=TextBox2.Text)
        TextBox3.Text = sonuc
    End Sub
    Private Function cikartma(ByVal sayi1 As Double, sayi2 As Double) As Double
        Return sayi1 - sayi2
    End Function

    Private Sub cikarmabtn_Click(sender As Object, e As EventArgs) Handles cikarmabtn.Click
        Dim sonuc As Double
        sonuc = cikartma(sayi1:=TextBox1.Text, sayi2:=TextBox2.Text)
        TextBox3.Text = sonuc
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Text = " "
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        TextBox2.Text = " "
    End Sub
    Private Function carpma(ByVal sayi1 As Double, sayi2 As Double) As Double
        Return sayi1 * sayi2
    End Function

    Private Sub carpmabtn_Click(sender As Object, e As EventArgs) Handles carpmabtn.Click
        Dim sonuc As Double
        sonuc = carpma(sayi1:=TextBox1.Text, sayi2:=TextBox2.Text)
        TextBox3.Text = sonuc
    End Sub
    Private Function bolme(ByVal sayi1 As Double, sayi2 As Double) As Double
        Return sayi1 / sayi2
    End Function

    Private Sub bolmebtn_Click(sender As Object, e As EventArgs) Handles bolmebtn.Click
        Dim sonuc As Double
        sonuc = bolme(sayi1:=TextBox1.Text, sayi2:=TextBox2.Text)
        TextBox3.Text = sonuc
    End Sub
    Private Function us(ByVal sayi1 As Double, sayi2 As Double) As Double
        Return sayi1 ^ sayi2
    End Function

    Private Sub üsbtn_Click(sender As Object, e As EventArgs) Handles üsbtn.Click
        Dim sonuc As Double
        sonuc = us(sayi1:=TextBox1.Text, sayi2:=TextBox2.Text)
        TextBox3.Text = sonuc
    End Sub
    Private Function modunual(ByVal sayi1 As Double, sayi2 As Double) As Double
        Return sayi1 Mod sayi2
    End Function

    Private Sub modbtn_Click(sender As Object, e As EventArgs) Handles modbtn.Click
        Dim sonuc As Double
        sonuc = modunual(sayi1:=TextBox1.Text, sayi2:=TextBox2.Text)
        TextBox3.Text = sonuc
    End Sub

    Private Sub temizlebtn_Click(sender As Object, e As EventArgs) Handles temizlebtn.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub
End Class
