Public Class FormInicio




    Private Sub btnProductos_Click(sender As Object, e As EventArgs)
        Dim frmProductos As New FormProductos()
        frmProductos.Show()
    End Sub




    Private Sub btnClientes_Click_1(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim frmClientes As New FormClientes()
        frmClientes.Show()
    End Sub

    Private Sub btnVentas_Click_1(sender As Object, e As EventArgs) Handles btnVentas.Click

        Dim frmVentasItems As New FormVentasItems()
        frmVentasItems.Show()
    End Sub

    Private Sub btnProductos_Click_1(sender As Object, e As EventArgs) Handles btnProductos.Click
        Dim frmProductos As New FormProductos()
        frmProductos.Show()
    End Sub

    Private Sub btnReportes_Click_1(sender As Object, e As EventArgs) Handles btnReportes.Click
        Dim frmReportes As New FormReportes() ' Asegúrate de que este formulario esté creado
        frmReportes.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
                Me.Close() ' Cierra el formulario
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frmVentas As New FormVentas()
        frmVentas.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
