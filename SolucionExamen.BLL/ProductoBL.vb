
Imports SolucionExamen.DAL
Imports SolucionExamen.Entidades

Public Class ProductoBL
    Private productoDAL As New ProductoDAL()

    ' Obtener la lista de productos
    Public Function ObtenerProductos() As List(Of Producto)
        Return productoDAL.ObtenerProductos()
    End Function
End Class
