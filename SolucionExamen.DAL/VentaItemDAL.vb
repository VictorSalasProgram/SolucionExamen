
Imports SolucionExamen.Entidades
Imports System.Data.SqlClient

Public Class VentaItemDAL
    Private connection As New DatabaseConnection()

    ' Método para agregar un item a la venta
    Public Sub AgregarVentaItem(item As VentaItem)
        Dim query As String = "INSERT INTO ventasitems (IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal) VALUES (@IDVenta, @IDProducto, @PrecioUnitario, @Cantidad, @PrecioTotal)"

        Using conn As SqlConnection = connection.GetConnection()
            conn.Open()
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@IDVenta", item.IDVenta)
                cmd.Parameters.AddWithValue("@IDProducto", item.IDProducto)
                cmd.Parameters.AddWithValue("@PrecioUnitario", item.PrecioUnitario)
                cmd.Parameters.AddWithValue("@Cantidad", item.Cantidad)
                cmd.Parameters.AddWithValue("@PrecioTotal", item.PrecioTotal)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Function ObtenerVentasItems() As List(Of VentaItem)
        Dim query As String = "SELECT * FROM VentasItems"
        Dim ventasItems As New List(Of VentaItem)

        Using conn As SqlConnection = connection.GetConnection()
            conn.Open()
            Using cmd As New SqlCommand(query, conn)
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim ventaItem As New VentaItem With {
                    .ID = CInt(reader("ID")),
                    .IDVenta = CInt(reader("IDVenta")),
                    .IDProducto = CInt(reader("IDProducto")),
                    .PrecioUnitario = Convert.ToDecimal(reader("PrecioUnitario")),
                    .Cantidad = Convert.ToDecimal(reader("Cantidad")),
                    .PrecioTotal = Convert.ToDecimal(reader("PrecioTotal"))
                }
                    ventasItems.Add(ventaItem)
                End While
            End Using
        End Using

        Return ventasItems
    End Function

End Class
