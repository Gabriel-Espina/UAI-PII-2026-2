Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Visible = True
        Label2.Text = "Los numeros ingresados son: " & TextBox1.Text
    End Sub
End Class