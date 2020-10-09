Imports System.Data.SqlClient
Public Class Conexion
    Private conexion As String
    Protected Sub New()
        conexion = My.Settings.Cadena
    End Sub

    Protected Function Getconnection() As SqlConnection
        Return New SqlConnection(conexion)
    End Function
End Class
