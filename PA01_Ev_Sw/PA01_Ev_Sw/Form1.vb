Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nota1, nota2 As Integer
        Dim prom As Double
        Dim situ As String
        Dim co As Color

        nota1 = TextBox1.Text
        nota2 = TextBox2.Text

        prom = (nota1 + nota2) / 2
        TextBox3.Text = prom

        If prom >= 10.5 Then
            situ = "Aprobado"
        Else
            situ = "Desaprobado"
            co = Color.Red
        End If
        TextBox4.Text = situ
        TextBox3.ForeColor = co

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
