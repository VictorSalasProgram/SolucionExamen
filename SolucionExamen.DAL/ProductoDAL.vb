
Imports SolucionExamen.Entidades
Imports System.Data.SqlClient

Public Class ProductoDAL
    Private connection As New DatabaseConnection()

    ' Método para obtener todos los productos
    Public Function ObtenerProductos() As List(Of Producto)
        Dim query As String = "SELECT * FROM productos"
        Dim productos As New List(Of Producto)

        Using conn As SqlConnection = connection.GetConnection()
            conn.Open()
            Using cmd As New SqlCommand(query, conn)
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim producto As New Producto With {
                        .ID = CInt(reader("ID")),
                        .Nombre = reader("Nombre").ToString(),
                        .Precio = CDbl(reader("Precio")),
                        .Categoria = reader("Categoria").ToString()
                    }
                    productos.Add(producto)
                End While
            End Using
        End Using

        Return productos
    End Function


End Class
