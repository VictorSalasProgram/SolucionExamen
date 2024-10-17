Imports System.Data.SqlClient


Public Class DatabaseConnection

    Private connectionString As String = "Server = localhost \ SQLEXPRESS;Database=pruebademo;Integrated Security=True;MultipleActiveResultSets=True;Timeout=120;"

    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function
End Class



'Server = localhost;Uid=sa;Pwd=sasa;MultipleActiveResultSets=True;Timeout=120;Database=pruebademo;


'Server = localhost \ SQLEXPRESS;Database=pruebademo;Integrated Security=True;MultipleActiveResultSets=True;Timeout=120;