Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Beliminar.Click, Bguardar.Click
        TextBox3.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Bguardar.Click
        Dim apellido = TextBox1.Text
        Dim nombre = TextBox2.Text

        Dim concatenado = apellido & " " & nombre
        TextBox3.Text = concatenado
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub form1Keydown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSalir.Visible = True
        End If
    End Sub
End Class
