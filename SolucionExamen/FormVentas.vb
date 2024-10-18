Imports System.Data.SqlClient
Imports SolucionExamen.BLL
Imports SolucionExamen.Entidades

Public Class FormVentas
    Private VentaBL As New VentaBL()
    Private ClienteBL As New ClienteBL()

    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            ' Cargar la lista de ventas en el DataGridView
            dgvVentas.DataSource = VentaBL.ObtenerVentas()
            dgvVentas.Columns("ID").Visible = False

            ' Cargar la lista de clientes en el ComboBox principal
            Dim clientes As List(Of Cliente) = ClienteBL.ObtenerClientes()
            cmbClientes.DataSource = clientes
            cmbClientes.DisplayMember = "Nombre"  ' Mostrar el nombre del cliente
            cmbClientes.ValueMember = "ID"        ' Almacenar el ID del cliente como valor del ComboBox

            ' Cargar la lista de clientes en el ComboBox de modificación
            cmbClienteModificar.DataSource = clientes
            cmbClienteModificar.DisplayMember = "Nombre"  ' Mostrar el nombre del cliente
            cmbClienteModificar.ValueMember = "ID"        ' Almacenar el ID del cliente como valor del ComboBox

        Catch ex As Exception
            MessageBox.Show("Error al cargar el formulario: " & ex.Message)
        End Try
    End Sub
    Private Sub CargarVentas(Optional ByVal busqueda As String = "")
        ' Aquí debes establecer la conexión con la base de datos
        Dim connectionString As String = "Server = localhost \ SQLEXPRESS;Database=pruebademo;Integrated Security=True;MultipleActiveResultSets=True;Timeout=120;"

        ' Ajustamos la consulta SQL para buscar por IDVenta, IDProducto o PrecioUnitario
        Dim query As String = "SELECT * FROM VentasItems WHERE (IDVenta LIKE @busqueda OR IDProducto LIKE @busqueda OR CAST(PrecioUnitario AS NVARCHAR) LIKE @busqueda OR CAST(Cantidad AS NVARCHAR) LIKE @busqueda OR CAST(PrecioTotal AS NVARCHAR) LIKE @busqueda)"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Agregar parámetro a la consulta
                command.Parameters.AddWithValue("@busqueda", "%" & busqueda & "%")
                connection.Open()

                ' Llenar un DataTable con los resultados
                Dim dt As New DataTable()
                Using reader As SqlDataReader = command.ExecuteReader()
                    dt.Load(reader)
                End Using

                ' Asignar los resultados al DataGridView
                dgvVentas.DataSource = dt
            End Using
        End Using
    End Sub

    Private Sub txtBuscadorClientes_TextChanged(sender As Object, e As EventArgs) Handles txtBuscadorVentas.TextChanged
        CargarVentas(txtBuscadorVentas.Text)
    End Sub

    Private Sub btnAgregarVenta_Click(sender As Object, e As EventArgs) Handles btnAgregarVenta.Click
        pnlAggVenta.Visible = True

    End Sub

    Private Sub btnCancelaAgg_Click(sender As Object, e As EventArgs) Handles btnCancelaAgg.Click
        pnlAggVenta.Visible = False

    End Sub

    Private Sub btnAgg_Click(sender As Object, e As EventArgs) Handles btnAggVenta.Click
        If cmbClientes.SelectedIndex = -1 OrElse String.IsNullOrWhiteSpace(txtTotalVenta.Text) Then
            MessageBox.Show("Por favor, seleccione un cliente y complete el campo total.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Establecer la cadena de conexión a la base de datos
        Dim connectionString As String = "Server = localhost \ SQLEXPRESS;Database=pruebademo;Integrated Security=True;MultipleActiveResultSets=True;Timeout=120;"

        ' Crear la consulta SQL para insertar una nueva venta
        Dim query As String = "INSERT INTO Ventas (IDCliente, Fecha, Total) VALUES (@IDCliente, @Fecha, @Total)"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Asignar los valores de los parámetros
                command.Parameters.AddWithValue("@IDCliente", CInt(cmbClientes.SelectedValue)) ' IDCliente obtenido del ComboBox
                command.Parameters.AddWithValue("@Fecha", dtpFechaVenta.Value) ' Toma la fecha del DateTimePicker
                command.Parameters.AddWithValue("@Total", Convert.ToDecimal(txtTotalVenta.Text)) ' Convierte el total a un valor decimal

                Try
                    ' Abrir la conexión
                    connection.Open()
                    ' Ejecutar la consulta
                    command.ExecuteNonQuery()
                    MessageBox.Show("Venta agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Opcional: Limpiar los controles después de guardar
                    cmbClientes.SelectedIndex = -1
                    dtpFechaVenta.Value = DateTime.Now
                    txtTotalVenta.Clear()
                    pnlAggVenta.Visible = False

                    ' Si tienes algún método para actualizar la lista de ventas, lo puedes llamar aquí
                    dgvVentas.DataSource = VentaBL.ObtenerVentas() ' CargarVentas() ' Ejemplo de cómo recargar la lista de ventas

                Catch ex As Exception
                    MessageBox.Show("Error al agregar venta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End Using
        End Using

    End Sub

    Private Sub bntModificarVenta_Click(sender As Object, e As EventArgs) Handles bntModificarVenta.Click


        ' Verificar si hay una fila seleccionada en el DataGridView
        If dgvVentas.SelectedRows.Count > 0 Then
            ' Hacer visible el panel de modificación
            pnlModificarVenta.Visible = True

            ' Obtener los valores de las columnas seleccionadas y asignarlos a los TextBox
            Dim filaSeleccionada As DataGridViewRow = dgvVentas.SelectedRows(0)

            ' Asignar el valor de la columna "Cliente" a cmbClienteModificar
            Dim idCliente As Integer = Convert.ToInt32(filaSeleccionada.Cells("IDCliente").Value)

            ' Asignar el cliente seleccionado en el ComboBox
            cmbClienteModificar.SelectedValue = idCliente

            ' Asignar el valor de la columna "Fecha" a dtpFechaVentaModificar
            dtpFechaVentaModificar.Value = Convert.ToDateTime(filaSeleccionada.Cells("Fecha").Value)

            ' Asignar el valor de la columna "Total" a txtTotalModificar
            txtTotalModificar.Text = filaSeleccionada.Cells("Total").Value.ToString()
        Else
            ' Mostrar mensaje si no se selecciona ninguna fila
            MessageBox.Show("Seleccione una venta para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub dvgVentas_SelectionChanged(sender As Object, e As EventArgs) Handles dgvVentas.SelectionChanged
        ' Verifica si hay alguna celda seleccionada
        If dgvVentas.SelectedCells.Count > 0 Then
            bntModificarVenta.Enabled = True
        Else
            bntModificarVenta.Enabled = False
        End If
        If dgvVentas.SelectedCells.Count > 0 Then
            btnEliminarVenta.Enabled = True
        Else
            btnEliminarVenta.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pnlModificarVenta.Visible = False
    End Sub


    Private Sub btnModificarVenta_Click(sender As Object, e As EventArgs) Handles btnModificarVenta.Click
        If dgvVentas.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione una venta para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Obtener el ID de la venta seleccionada
        Dim filaSeleccionada As DataGridViewRow = dgvVentas.SelectedRows(0)
        Dim idVenta As Integer = Convert.ToInt32(filaSeleccionada.Cells("ID").Value) ' Cambiar a "ID" para obtener el ID de la venta

        ' Establecer la cadena de conexión a la base de datos
        Dim connectionString As String = "Server = localhost \ SQLEXPRESS;Database=pruebademo;Integrated Security=True;MultipleActiveResultSets=True;Timeout=120;"

        ' Crear la consulta SQL para actualizar la venta
        Dim query As String = "UPDATE Ventas SET IDCliente = @IDCliente, Fecha = @Fecha, Total = @Total WHERE ID = @IDVenta"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Asignar los valores de los parámetros
                command.Parameters.AddWithValue("@IDCliente", cmbClienteModificar.SelectedValue)
                command.Parameters.AddWithValue("@Fecha", dtpFechaVentaModificar.Value)
                command.Parameters.AddWithValue("@Total", Single.Parse(txtTotalModificar.Text))
                command.Parameters.AddWithValue("@IDVenta", idVenta) ' Usar ID de la venta

                Try
                    ' Abrir la conexión
                    connection.Open()
                    ' Ejecutar la consulta
                    command.ExecuteNonQuery()
                    MessageBox.Show("Venta actualizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Opcional: Limpiar los campos después de actualizar
                    pnlModificarVenta.Visible = False
                    dgvVentas.DataSource = VentaBL.ObtenerVentas() ' Método para recargar el DataGridView con los datos actualizados

                Catch ex As Exception
                    MessageBox.Show("Error al actualizar la venta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnEliminarVenta_Click(sender As Object, e As EventArgs) Handles btnEliminarVenta.Click
        ' Verifica que haya una fila seleccionada en el DataGridView
        If dgvVentas.SelectedRows.Count > 0 Then
            ' Obtén el ID del cliente seleccionado (asumiendo que está en la primera columna)
            Dim idVenta As Integer = Convert.ToInt32(dgvVentas.SelectedRows(0).Cells(0).Value)

            ' Confirmar la eliminación
            Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar esta venta?", "Confirmación", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                ' Conectar a la base de datos
                Dim connectionString As String = "Server = localhost \ SQLEXPRESS;Database=pruebademo;Integrated Security=True;MultipleActiveResultSets=True;Timeout=120;"
                Using conn As New SqlConnection(connectionString)
                    Try
                        conn.Open()

                        ' Comando SQL para eliminar el cliente de la base de datos por su ID
                        Dim query As String = "DELETE FROM ventas WHERE ID = @ID"

                        Using cmd As New SqlCommand(query, conn)
                            ' Parámetro para el ID
                            cmd.Parameters.AddWithValue("@ID", idVenta)

                            ' Ejecutar la consulta
                            cmd.ExecuteNonQuery()
                        End Using

                        MessageBox.Show("Cliente eliminado correctamente.")

                        ' Refrescar el DataGridView
                        dgvVentas.DataSource = VentaBL.ObtenerVentas()

                    Catch ex As Exception
                        MessageBox.Show("Error al eliminar la venta: " & ex.Message)
                    End Try
                End Using
            End If
        Else
            MessageBox.Show("Seleccione una venta para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub





    ' Variables para el arrastre del panel
    Private mouseIsDown As Boolean = False
    Private mouseOffset As Point

    ' Evento MouseDown: cuando se hace clic en el panel
    Private Sub pnlAggVentas_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlAggVenta.MouseDown
        If e.Button = MouseButtons.Left Then
            ' Marcar que el mouse está presionado
            mouseIsDown = True
            ' Guardar la posición del mouse relativa al panel
            mouseOffset = New Point(-e.X, -e.Y)
        End If
    End Sub

    ' Evento MouseMove: cuando se mueve el mouse sobre el panel
    Private Sub pnlAggVentas1(sender As Object, e As MouseEventArgs) Handles pnlAggVenta.MouseMove
        If mouseIsDown Then
            ' Obtener la posición actual del mouse en la pantalla
            Dim mousePos As Point = Control.MousePosition
            ' Ajustar la posición del panel en función del desplazamiento
            pnlAggVenta.Location = Me.PointToClient(New Point(mousePos.X + mouseOffset.X, mousePos.Y + mouseOffset.Y))
        End If
    End Sub

    ' Evento MouseUp: cuando se suelta el botón del mouse
    Private Sub pnlAggVenta_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlAggVenta.MouseUp
        ' El mouse ya no está presionado
        mouseIsDown = False
    End Sub


    'SEGUNDO PANEL



    Private mouseIsDown1 As Boolean = False
    Private mouseOffset1 As Point

    ' Evento MouseDown: cuando se hace clic en el panel
    Private Sub pnlModificarVenta_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlModificarVenta.MouseDown
        If e.Button = MouseButtons.Left Then
            ' Marcar que el mouse está presionado
            mouseIsDown1 = True
            ' Guardar la posición del mouse relativa al panel
            mouseOffset1 = New Point(-e.X, -e.Y)
        End If
    End Sub

    ' Evento MouseMove: cuando se mueve el mouse sobre el panel
    Private Sub pnlModificarVenta1(sender As Object, e As MouseEventArgs) Handles pnlModificarVenta.MouseMove
        If mouseIsDown1 Then
            ' Obtener la posición actual del mouse en la pantalla
            Dim mousePos As Point = Control.MousePosition
            ' Ajustar la posición del panel en función del desplazamiento
            pnlModificarVenta.Location = Me.PointToClient(New Point(mousePos.X + mouseOffset1.X, mousePos.Y + mouseOffset1.Y))
        End If
    End Sub

    ' Evento MouseUp: cuando se suelta el botón del mouse
    Private Sub pnlAggVentaItems_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlModificarVenta.MouseUp
        ' El mouse ya no está presionado
        mouseIsDown1 = False
    End Sub
End Class