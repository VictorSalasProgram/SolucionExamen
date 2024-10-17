
Imports SolucionExamen.DAL
Imports SolucionExamen.Entidades

Public Class ClienteBL
    Private clienteDAL As New ClienteDAL()

    ' Obtener la lista de clientes
    Public Function ObtenerClientes() As List(Of Cliente)
        Return clienteDAL.ObtenerClientes()
    End Function
End Class

