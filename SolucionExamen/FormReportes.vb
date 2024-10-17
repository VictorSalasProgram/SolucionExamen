Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports Microsoft.ReportingServices.Diagnostics.Internal
Imports SolucionExamen.Entidades


Public Class FormReportes


    Private Sub FormReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarReporte()
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
    End Sub
    Private Sub CargarReporte()
        ' Cadena de conexión a la base de datos
        Dim connectionString As String = "Server=localhost\SQLEXPRESS;Database=pruebademo;Integrated Security=True;MultipleActiveResultSets=True;Timeout=120;"

        ' Consulta SQL que quieres ejecutar (ajusta según tu tabla y columnas)
        Dim query As String = "SELECT ID, Nombre, Precio, Categoria FROM productos"

        ' Crea la conexión y el adaptador para llenar el pruebademoDataSet
        Using connection As New SqlConnection(connectionString)
            Dim adapter As New SqlDataAdapter(query, connection)

            ' Usa el DataSet tipado generado por el diseñador
            Dim dataset As New pruebademoDataSet()

            Try
                ' Llena el DataSet con los datos de la consulta
                adapter.Fill(dataset.productos)

                ' Configura el ReportViewer
                ReportViewer1.LocalReport.DataSources.Clear()
                Dim reportDataSource As New ReportDataSource("DataSet1", dataset.Tables("productos"))
                ReportViewer1.LocalReport.DataSources.Add(reportDataSource)

                ' Refresca el ReportViewer para mostrar los datos
                ReportViewer1.RefreshReport()

            Catch ex As Exception
                MessageBox.Show("Error al cargar los datos: " & ex.Message)
            End Try
        End Using
    End Sub



End Class
