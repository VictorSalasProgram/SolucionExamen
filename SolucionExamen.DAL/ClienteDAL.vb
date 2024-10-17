
Imports SolucionExamen.Entidades
Imports System.Data.SqlClient

Public Class ClienteDAL
    Private connection As New DatabaseConnection()

    ' Obtener todos los clientes
    Public Function ObtenerClientes() As List(Of Cliente)
        Dim query As String = "SELECT * FROM Clientes"
        Dim clientes As New List(Of Cliente)

        Using conn As SqlConnection = connection.GetConnection()
            conn.Open()
            Using cmd As New SqlCommand(query, conn)
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim cliente As New Cliente With {
                        .ID = CInt(reader("ID")),
                        .Nombre = reader("Cliente").ToString(),
                        .Telefono = reader("Telefono").ToString(),
                        .Correo = reader("Correo").ToString()
                    }
                    clientes.Add(cliente)
                End While
            End Using
        End Using

        Return clientes
    End Function


End Class
