Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2 As Double
        If Double.TryParse(TextBox1.Text, num1) AndAlso Double.TryParse(TextBox2.Text, num2) Then
            MessageBox.Show("Resultado: " & (num1 + num2).ToString())
        Else
            MessageBox.Show("Ingresa números válidos")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num1, num2 As Double
        If Double.TryParse(TextBox1.Text, num1) AndAlso Double.TryParse(TextBox2.Text, num2) Then
            MessageBox.Show("Resultado: " & (num1 - num2).ToString())
        Else
            MessageBox.Show("Ingresa números válidos")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num1, num2 As Double
        If Double.TryParse(TextBox1.Text, num1) AndAlso Double.TryParse(TextBox2.Text, num2) Then
            MessageBox.Show("Resultado: " & (num1 * num2).ToString())
        Else
            MessageBox.Show("Ingresa números válidos")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num1, num2 As Double
        If Double.TryParse(TextBox1.Text, num1) AndAlso Double.TryParse(TextBox2.Text, num2) Then
            If num2 <> 0 Then
                MessageBox.Show("Resultado: " & (num1 / num2).ToString())
            Else
                MessageBox.Show("No se puede dividir por cero")
            End If
        Else
            MessageBox.Show("Ingresa números válidos")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim baseNum, exponente As Double
        If Double.TryParse(TextBox1.Text, baseNum) AndAlso Double.TryParse(TextBox2.Text, exponente) Then
            Dim resultado As Double = Math.Pow(baseNum, exponente)
            MessageBox.Show("Resultado: " & resultado.ToString())
        Else
            MessageBox.Show("Ingresa números válidos")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim num1 As Double
        If Double.TryParse(TextBox1.Text, num1) Then
            If num1 >= 0 Then
                Dim resultado As Double = Math.Sqrt(num1)
                MessageBox.Show("Raíz del 1er número: " & resultado.ToString())
            Else
                MessageBox.Show("No existe raíz de un número negativo")
            End If
        Else
            MessageBox.Show("Ingresa un número válido en el primer cuadro")
        End If
    End Sub
End Class
