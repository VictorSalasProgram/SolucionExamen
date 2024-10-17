
Imports SolucionExamen.DAL
Imports SolucionExamen.Entidades

Public Class VentaBL
    Private ventaDAL As New VentaDAL()

    ' Método para agregar una venta
    Public Function AgregarVenta(venta As Venta) As Integer
        Return ventaDAL.AgregarVenta(venta)
    End Function
    Public Function ObtenerVentas() As List(Of Venta)
        Return ventaDAL.ObtenerVentas()
    End Function
End Class
