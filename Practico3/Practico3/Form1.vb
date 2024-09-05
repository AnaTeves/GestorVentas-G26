Public Class Form1
    Private Sub Ldni_Click(sender As Object, e As EventArgs) Handles Ldni.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Lnombre.Click

    End Sub

    Private Sub TDNI_TextChanged(sender As Object, e As EventArgs) Handles TDNI.TextChanged

    End Sub

    Private Sub TDNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDNI.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombre.KeyPress, TApellido.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TGuardar_Click(sender As Object, e As EventArgs) Handles TGuardar.Click
        Dim ask As MsgBoxResult

        If (String.IsNullOrWhiteSpace(TNombre.Text) Or String.IsNullOrWhiteSpace(TApellido.Text) Or String.IsNullOrWhiteSpace(TDNI.Text)) Then
            MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            ask = MessageBox.Show("Seguro que desea insertar un nuevo cliente?", "Confirmar insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Dim nombre = TNombre.Text
            Dim apellido = TApellido.Text

            Dim concatenado = nombre & " " & apellido
            Lmodificar.Text = concatenado
        End If
    End Sub
End Class
