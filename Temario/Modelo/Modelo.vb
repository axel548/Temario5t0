Public Class Modelo
    Dim datos As New Datos

    Public Function ingreso(placa As String, tipo As String)
        Return datos.Ingreso(placa, tipo)
    End Function

    Public Function consulta(tabla As DataGridView, sql As String) As Boolean
        Return datos.Consulta(tabla, sql)
    End Function

    Public Function login(usr As String, contra As String)
        Return datos.login(usr, contra)
    End Function
End Class
