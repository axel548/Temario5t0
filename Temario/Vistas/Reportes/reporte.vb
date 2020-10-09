Public Class reporte
    Public boleta As Integer

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Try
            Dim objReport As New Factura
            objReport.SetParameterValue("@boleta", boleta)
            CrystalReportViewer1.ReportSource = objReport
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
End Class