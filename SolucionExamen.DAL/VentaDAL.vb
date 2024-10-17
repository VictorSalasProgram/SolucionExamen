Imports SolucionExamen.Entidades
Imports System.Data.SqlClient

Public Class VentaDAL
    Private connection As New DatabaseConnection()

    ' Método para agregar una nueva venta
    Public Function AgregarVenta(venta As Venta) As Integer
        Dim query As String = "INSERT INTO ventas (IDCliente, Fecha, Total) OUTPUT INSERTED.ID VALUES (@IDCliente, @Fecha, @Total)"
        Dim nuevaVentaID As Integer

        Using conn As SqlConnection = connection.GetConnection()
            conn.Open()
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@IDCliente", venta.IDCliente)
                cmd.Parameters.AddWithValue("@Fecha", venta.Fecha)
                cmd.Parameters.AddWithValue("@Total", venta.Total)
                nuevaVentaID = CInt(cmd.ExecuteScalar())
            End Using
        End Using

        Return nuevaVentaID
    End Function

    ' Método para obtener todas las ventas
    Public Function ObtenerVentas() As List(Of Venta)
        Dim query As String = "SELECT * FROM ventas"
        Dim ventas As New List(Of Venta)

        Using conn As SqlConnection = connection.GetConnection()
            conn.Open()
            Using cmd As New SqlCommand(query, conn)
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim venta As New Venta With {
                        .ID = CInt(reader("ID")),
                        .IDCliente = CInt(reader("IDCliente")),
                        .Fecha = Convert.ToDateTime(reader("Fecha")),
                        .Total = Convert.ToDecimal(reader("Total"))
                    }
                    ventas.Add(venta)
                End While
            End Using
        End Using

        Return ventas
    End Function

    ' Método para obtener una venta por ID y su cliente asociado


    ' Método para obtener una venta por ID
    Public Function ObtenerVentaPorID(id As Integer) As Venta
        Dim query As String = "SELECT v.IDCliente, c.Cliente FROM ventas v INNER JOIN clientes c ON v.IDCliente = c.ID WHERE v.ID = @ID"
        Dim venta As Venta = Nothing

        Using conn As SqlConnection = connection.GetConnection()
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ID", id)
                conn.Open()
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        venta = New Venta() With {
                            .IDCliente = CInt(reader("IDCliente")
                         )}
                    End If
                End Using
            End Using
        End Using

        Return venta
    End Function



End Class

