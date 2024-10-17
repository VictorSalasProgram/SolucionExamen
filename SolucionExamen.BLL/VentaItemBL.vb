
Imports SolucionExamen.DAL
Imports SolucionExamen.Entidades

Public Class VentaItemBL
    Private ventaItemDAL As New VentaItemDAL()

    ' Método para agregar un ítem de venta
    Public Sub AgregarVentaItem(item As VentaItem)
        ventaItemDAL.AgregarVentaItem(item)
    End Sub
    Public Function ObtenerVentasItems() As List(Of VentaItem)
        Return ventaItemDAL.ObtenerVentasItems()
    End Function
End Class
