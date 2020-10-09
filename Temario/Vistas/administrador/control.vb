Public Class control
    Private consulta As New Modelo
    Private sql As String

#Region "DOM"
    Private Sub control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiar()
    End Sub

    Private Sub btn_insertar_Click(sender As Object, e As EventArgs) Handles btn_insertar.Click
        sql = "insert into multas values('" + txt_remision.Text + "','" + dtp_fecha.Value + "','" + txt_lugar.Text + "','" + txt_articulo.Text + "','" + txt_motivo.Text + "','" + txt_precio.Text + "','" + txt_placa.Text + "')"
        consulta.consulta(dgv_control, sql)
        limpiar()
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        sql = "update multas set fecha='" + dtp_fecha.Value + "', lugar='" + txt_lugar.Text + "', articulo='" + txt_articulo.Text + "', motivo='" + txt_motivo.Text + "', precio='" + txt_precio.Text + "', placa='" + txt_placa.Text + "' where remision='" + txt_remision.Text + "'"
        consulta.consulta(dgv_control, sql)
        limpiar()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        sql = "delete from multas where remision='" + txt_remision.Text + "'"
        consulta.consulta(dgv_control, sql)
        limpiar()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        sql = "select * from multas where remision='" + txt_remision.Text + "'"
        consulta.consulta(dgv_control, sql)
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Try
            If MessageBox.Show("Estás seguro de cerrar la sesión?", "Warning",
              MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Funciones"
    Private Sub buscar()
        sql = "select * from multas"
        consulta.consulta(dgv_control, sql)
    End Sub

    Private Sub limpiar()
        txt_articulo.Clear()
        txt_lugar.Clear()
        txt_motivo.Clear()
        txt_placa.Clear()
        txt_precio.Clear()
        txt_remision.Clear()
        txt_remision.Focus()
        buscar()
    End Sub
#End Region

#Region "DataGridView"
    Private Sub dgv_control_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_control.CellDoubleClick
        Try
            If MessageBox.Show("¿Desea modificar el registro?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                txt_remision.Text = dgv_control.CurrentRow.Cells(0).Value.ToString
                dtp_fecha.Value = dgv_control.CurrentRow.Cells(1).Value
                txt_lugar.Text = dgv_control.CurrentRow.Cells(2).Value.ToString
                txt_articulo.Text = dgv_control.CurrentRow.Cells(3).Value.ToString
                txt_motivo.Text = dgv_control.CurrentRow.Cells(4).Value.ToString
                txt_precio.Text = dgv_control.CurrentRow.Cells(5).Value.ToString
                txt_placa.Text = dgv_control.CurrentRow.Cells(6).Value.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

End Class