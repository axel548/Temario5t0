Imports System.Data.SqlClient

Public Class Datos
    Inherits Conexion

    Public Function Ingreso(placa As String, tipo As String)
        Using connec = Getconnection()
            connec.Open()
            Using comando = New SqlCommand
                With comando
                    .Connection = connec
                    .CommandText = "SELECT * FROM carros WHERE placa=@placa and tip_placa=@tipo"
                    .Parameters.AddWithValue("@placa", placa)
                    .Parameters.AddWithValue("@tipo", tipo)
                    .CommandType = CommandType.Text
                End With
                Dim reader = comando.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        ActiveUser.placa = reader.GetString(0)
                        ActiveUser.modelo = reader.GetString(2)
                        ActiveUser.marca = reader.GetString(3)
                        ActiveUser.color = reader.GetString(4)
                        ActiveUser.faltas = reader.GetString(5)
                    End While
                    reader.Dispose()
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function

    Public Function Consulta(ByVal tabla As DataGridView, ByVal sql As String) As Boolean
        Dim dt As DataTable
        Using connec = Getconnection()
            connec.Open()
            Try
                Using da = New SqlDataAdapter(sql, connec)
                    dt = New DataTable
                    da.Fill(dt)
                    tabla.DataSource = dt
                    Return True
                End Using
            Catch ex As Exception
                Return False
            End Try
            connec.Close()
        End Using
    End Function

    Public Function login(usr As String, contra As String)
        Using connec = Getconnection()
            connec.Open()
            Using comando = New SqlCommand
                With comando
                    .Connection = connec
                    .CommandText = "SELECT * FROM usr WHERE usr=@usr and contra=@contra"
                    .Parameters.AddWithValue("@usr", usr)
                    .Parameters.AddWithValue("@contra", contra)
                    .CommandType = CommandType.Text
                End With
                Dim reader = comando.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        ActiveUser.id = reader.GetInt32(0)
                        ActiveUser.usr = reader.GetString(1)
                        ActiveUser.tipo_usr = reader.GetString(2)
                    End While
                    reader.Dispose()
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function

    Public Function InsertadoFacturas(ByVal ent As Entidad) As Boolean
        Using connec = Getconnection()
            connec.Open()
            Try
                Using cmd = New SqlCommand("ADDfactura", connec)
                    With cmd
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.AddWithValue("@boleta", ent.boleta)
                        .Parameters.AddWithValue("@remision", ent.remision)
                        .Parameters.AddWithValue("@placa", ent.placa)
                        .Parameters.AddWithValue("@subtotal", ent.subtotal)
                        .Parameters.AddWithValue("@descuento", ent.descuento)
                        .Parameters.AddWithValue("@total", ent.total)
                    End With
                    If CBool(cmd.ExecuteNonQuery()) Then
                        Return True
                    Else
                        Return False
                    End If
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                connec.Close()
            End Try
        End Using
    End Function

    Function Gcodigo() As String
        Dim codigo As Integer = 0
        Dim total As Integer = 0
        Try
            Using conec = Getconnection()
                conec.Open()

                Using cmd = New SqlCommand("select count(*) as totalregistros from factura", conec)
                    Dim reader = cmd.ExecuteReader()
                    If reader.Read Then
                        total = CInt(reader.Item("totalregistros"))
                        total += 1
                    End If
                    reader.Close()

                    If total < 10 Then
                        codigo = total.ToString
                    ElseIf total < 100 Then
                        codigo = total.ToString
                    ElseIf total < 1000 Then
                        codigo = total.ToString
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return codigo
    End Function

End Class
