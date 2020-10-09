Public Class Registro
    Dim modelo As New Modelo

#Region "DOM"
    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        verfificar()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklbl_admin.LinkClicked
        Dim login As New log_control
        login.Show()
        Hide()
    End Sub
#End Region

#Region "Eventos"
    Private Sub txt_placa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_placa.KeyPress
        If Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
            MsgBox("No se permite espacios")
        ElseIf Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
            MsgBox("No se permiten simbolos")
        End If
    End Sub
    Private Sub txt_placa_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_placa.KeyDown
        If e.KeyCode = Keys.Enter Then
            verfificar()
        End If
    End Sub
#End Region

#Region "Funciones"
    Private Sub ingreso()
        Dim validar = modelo.ingreso(txt_placa.Text, cb_tipoPlaca.Text)
        Dim form As New control_usuario
        Try
            If validar = True Then
                MessageBox.Show("Ingreso exitoso")
                form.Show()
                AddHandler form.FormClosed, AddressOf Logout
                Hide()
            Else
                MessageBox.Show("No. de placa incorrecto")
                txt_placa.Clear()
                txt_placa.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Logout()
        Try
            txt_placa.Clear()
            txt_placa.Focus()
            Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub verfificar()
        If txt_placa.Text = "" And cb_tipoPlaca.Text = "" Then
            MessageBox.Show("Hay campos vacíos")
        ElseIf txt_placa.Text = "" And cb_tipoPlaca.Text <> "" Then
            MessageBox.Show("El campo placa esta vacío")
        ElseIf txt_placa.Text <> "" And cb_tipoPlaca.Text = "" Then
            MessageBox.Show("El campo tipo de placa esta vacío")
        ElseIf txt_placa.Text <> "" And cb_tipoPlaca.Text <> "" Then
            ingreso()
        End If

    End Sub
#End Region

End Class
