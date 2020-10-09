Public Class log_control
    Private modelo As New Modelo

#Region "Dom"
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        validar()
    End Sub

    Private Sub ckb_mostrar_CheckedChanged(sender As Object, e As EventArgs) Handles ckb_mostrar.CheckedChanged
        Try
            If ckb_mostrar.Checked = True Then
                txt_contra.UseSystemPasswordChar = False
            Else
                txt_contra.UseSystemPasswordChar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub lnklbl_regresar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklbl_regresar.LinkClicked
        Dim form As New Registro
        form.Show()
        Hide()
    End Sub
#End Region

#Region "Funciones"
    Private Sub ingreso()
        Dim validar = modelo.login(txt_usuario.Text, txt_contra.Text)
        Dim form As New control
        Try
            If validar = True Then
                MessageBox.Show("Ingreso exitoso")
                form.Show()
                AddHandler form.FormClosed, AddressOf logout
                Hide()
            Else
                MessageBox.Show("Hay datos incorrectos")
                txt_usuario.Clear()
                txt_contra.Clear()
                txt_usuario.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub validar()
        If txt_usuario.Text = "" And txt_contra.Text = "" Then
            MessageBox.Show("Hay campos vacíos")
        ElseIf txt_usuario.Text = "" And txt_contra.Text <> "" Then
            MessageBox.Show("El campo de usuario esta vacío")
        ElseIf txt_usuario.Text <> "" And txt_contra.Text = "" Then
            MessageBox.Show("El campo de contraseña esta vacío")
        ElseIf txt_usuario.Text <> "" And txt_contra.Text <> "" Then
            ingreso()
        End If
    End Sub
    Private Sub logout()
        Try
            txt_usuario.Clear()
            txt_contra.Clear()
            txt_usuario.Focus()
            Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Eventos"
    Private Sub txt_contra_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_contra.KeyDown
        If e.KeyCode = Keys.Enter Then
            validar()
        End If
    End Sub

#End Region
End Class