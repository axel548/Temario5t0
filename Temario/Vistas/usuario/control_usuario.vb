Public Class control_usuario

    Private sql As String
    Private consulta As New Modelo
    Private ent As New Entidad
    Private datos As New Datos
    Dim re(-1) As String

#Region "DOM"
    Private Sub control_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MuniDataSet.View_multas' Puede moverla o quitarla según sea necesario.
        Me.View_multasTableAdapter.Fill(Me.MuniDataSet.View_multas)
        permisos()
        carga()
        buscar()


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

    Private Sub btn_imprimir_Click(sender As Object, e As EventArgs) Handles btn_imprimir.Click
        Dim formReporte As New reporte
        Try
            formReporte.boleta = lbl_código.Text
            formReporte.ShowDialog()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            formReporte.Dispose()
        End Try
    End Sub

    Private Sub lbl_desc_pagar_TextChanged(sender As Object, e As EventArgs) Handles lbl_desc_pagar.TextChanged
        Dim a As Integer, b As Double
        On Error Resume Next
        If IsNumeric(lbl_subtotal_pagar.Text) Then
            a = CDec(lbl_subtotal_pagar.Text)
        End If
        If IsNumeric(lbl_desc_pagar.Text) Then b = CDec(lbl_desc_pagar.Text)
        lbl_total_pagar.Text = CStr(a - b)
    End Sub

    Private Sub lbl_subtotal_pagar_TextChanged(sender As Object, e As EventArgs) Handles lbl_subtotal_pagar.TextChanged
        Dim a As Integer, b As Double
        On Error Resume Next
        If IsNumeric(lbl_subtotal_pagar.Text) Then
            a = CDec(lbl_subtotal_pagar.Text)
        End If
        If IsNumeric(lbl_desc_pagar.Text) Then b = CDec(lbl_desc_pagar.Text)
        lbl_total_pagar.Text = CStr(a - b)
    End Sub

    Private Sub btn_pagar_Click(sender As Object, e As EventArgs) Handles btn_pagar.Click
        Try
            If re.Length >= 0 Then
                For i As Integer = 0 To re.Length
                    ent.boleta = lbl_código.Text
                    ent.remision = re(i)
                    ent.placa = lbl_placa_valor.Text
                    ent.subtotal = lbl_subtotal_pagar.Text
                    ent.descuento = lbl_desc_pagar.Text
                    ent.total = lbl_total_pagar.Text

                    If datos.InsertadoFacturas(ent) Then
                        MsgBox("Factura realizada correctamente " & i)
                        btn_imprimir.Visible = True
                        buscar()
                        dgv_pagar.Rows.Clear()
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox("Error:" & ex.Message)
        End Try
    End Sub

#End Region

#Region "Funciones"
    Private Sub permisos()
        If ActiveUser.faltas = "si" Then
            Panel1.Visible = False
            pnl_consultas_remisiones.Visible = True
            pnl_pagare.Visible = True
        ElseIf ActiveUser.faltas = "no" Then
            Panel1.Visible = True
            pnl_consultas_remisiones.Visible = False
            pnl_pagare.Visible = False
        End If
    End Sub

    Private Sub carga()
        lbl_color_valor.Text = ActiveUser.color
        lbl_marca_valor.Text = ActiveUser.marca
        lbl_placa_valor.Text = ActiveUser.placa
    End Sub

    Private Sub buscar()
        sql = "select * from View_multas where placa = '" + ActiveUser.placa + "'"
        consulta.consulta(dgv_remisiones, sql)
    End Sub

    Private Sub suma()
        If dgv_pagar.Rows.Count = 0 Then
            Me.lbl_subtotal_pagar.Text = "Q 0.00"
        Else
            Dim Total As Single
            Dim cont As Integer = 0 'PARA CONTADOR DE PARTIDAS
            Dim Col As Integer = Me.dgv_pagar.CurrentCell.ColumnIndex
            For Each row As DataGridViewRow In Me.dgv_pagar.Rows
                Total += Val(row.Cells(1).Value) 'ROW.CELLS (NUMERO DE LA COLUMNA A SUMAR).VALUE
            Next
            Me.lbl_subtotal_pagar.Text = Total.ToString
        End If
    End Sub

    Private Sub resta()
        If dgv_pagar.Rows.Count = 0 Then
            Me.lbl_subtotal_pagar.Text = "Q 0.00"
        Else
            Dim Total As Single
            Dim cont As Integer = 0 'PARA CONTADOR DE PARTIDAS
            Dim Col As Integer = Me.dgv_pagar.CurrentCell.ColumnIndex
            For Each row As DataGridViewRow In Me.dgv_pagar.Rows
                Total -= Val(row.Cells(1).Value) 'ROW.CELLS (NUMERO DE LA COLUMNA A SUMAR).VALUE
            Next
            Me.lbl_subtotal_pagar.Text = Total.ToString
        End If
    End Sub
#End Region

#Region "DataGridView"
    Private Sub dgv_remisiones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_remisiones.CellContentClick
        Try
            If Me.dgv_remisiones.Rows(e.RowIndex).Cells("pagar").Value = False Then
                Dim remision = Me.dgv_remisiones.Rows(e.RowIndex).Cells(0).Value.ToString
                Dim precios = Me.dgv_remisiones.Rows(e.RowIndex).Cells(2).Value.ToString

                If re.Length = 0 Then
                    ReDim re(re.Length)
                    re(0) = remision
                ElseIf re.Length >= 1 Then
                    ReDim Preserve re(re.Length)
                    re(re.Length - 1) = remision
                End If

                dgv_pagar.Rows.Add(remision, precios)
                suma()
                lbl_código.Text = datos.Gcodigo()
            ElseIf Me.dgv_remisiones.Rows(e.RowIndex).Cells("pagar").Value = True Then
                If dgv_pagar.Rows.Count = 1 Then
                    dgv_pagar.Rows.Clear()
                    resta()
                Else
                    Dim agregar = Me.dgv_remisiones.Rows(e.RowIndex).Cells(0).Value
                    Dim quitar = Me.dgv_pagar.Rows(e.RowIndex).Cells(0).Value

                    If agregar Is quitar Then
                        dgv_pagar.Rows.RemoveAt(0)
                        resta()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
#End Region

End Class