

Imports System.Data.SqlClient


Public Class FormClientes



    Private connectionString As String = "Server=localhost\SQLEXPRESS;Database=pruebademo;Integrated Security=True;MultipleActiveResultSets=True;Timeout=120;"
    ' Suponiendo que ya tienes un DataGridView llamado dgvClientes en tu formulario
    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar todos los clientes al inicio
        CargarClientes("")
    End Sub

    Private Sub txtBuscadprClientes_TextChanged(sender As Object, e As EventArgs) Handles txtBuscadorClientes.TextChanged
        ' Llamar al método para buscar clientes cuando el texto cambia
        CargarClientes(txtBuscadorClientes.Text)
    End Sub

    Private Sub CargarClientes(Optional ByVal busqueda As String = "")
        ' Aquí debes establecer la conexión con la base de datos
        Dim connectionString As String = "Server=localhost\SQLEXPRESS;Database=pruebademo;Integrated Security=True;MultipleActiveResultSets=True;Timeout=120;"

        ' Ajustamos la consulta SQL para buscar en todos los campos
        Dim query As String = "SELECT * FROM Clientes WHERE (Cliente LIKE @busqueda OR Correo LIKE @busqueda OR Telefono LIKE @busqueda)"

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
                dgvClientes.DataSource = dt
            End Using
        End Using
    End Sub


    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        pnlAggCliente.Visible = True


    End Sub

    Private Sub btnCancelaAgg_Click(sender As Object, e As EventArgs) Handles btnCancelaAgg.Click
        pnlAggCliente.Visible = False
    End Sub

    Private Sub btnAgg_Click(sender As Object, e As EventArgs) Handles btnAgg.Click
        ' Validar que los TextBox no estén vacíos
        If String.IsNullOrWhiteSpace(txtNombreCliente.Text) OrElse String.IsNullOrWhiteSpace(txtCorreoCliente.Text) OrElse String.IsNullOrWhiteSpace(txtTelefonoCliente.Text) Then
            MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Establecer la cadena de conexión a la base de datos
        Dim connectionString As String = "Server=localhost\SQLEXPRESS;Database=pruebademo;Integrated Security=True;MultipleActiveResultSets=True;Timeout=120;"

        ' Crear la consulta SQL para insertar un nuevo cliente
        Dim query As String = "INSERT INTO Clientes (Cliente, Correo, Telefono) VALUES (@Cliente, @Correo, @Telefono)"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Asignar los valores de los parámetros
                command.Parameters.AddWithValue("@Cliente", txtNombreCliente.Text)
                command.Parameters.AddWithValue("@Correo", txtCorreoCliente.Text)
                command.Parameters.AddWithValue("@Telefono", txtTelefonoCliente.Text)

                Try
                    ' Abrir la conexión
                    connection.Open()
                    ' Ejecutar la consulta
                    command.ExecuteNonQuery()
                    MessageBox.Show("Cliente agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Opcional: Limpiar los TextBox después de guardar
                    txtNombreCliente.Clear()
                    txtCorreoCliente.Clear()
                    txtTelefonoCliente.Clear()
                    pnlAggCliente.Visible = False
                    CargarClientes("")
                Catch ex As Exception
                    MessageBox.Show("Error al agregar cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End Using

        End Using

    End Sub
    Private Sub dgvClientes_SelectionChanged(sender As Object, e As EventArgs) Handles dgvClientes.SelectionChanged
        ' Verifica si hay alguna celda seleccionada
        If dgvClientes.SelectedCells.Count > 0 Then
            bntModificarCliente.Enabled = True
        Else
            bntModificarCliente.Enabled = False
        End If
        If dgvClientes.SelectedCells.Count > 0 Then
            btnEliminarCliente.Enabled = True
        Else
            btnEliminarCliente.Enabled = False
        End If
    End Sub
    Private Sub btnEliminarCliente_Click(sender As Object, e As EventArgs) Handles btnEliminarCliente.Click
        ' Verifica que haya una fila seleccionada en el DataGridView
        If dgvClientes.SelectedRows.Count > 0 Then
            ' Obtén el ID del cliente seleccionado (asumiendo que está en la primera columna)
            Dim idCliente As Integer = Convert.ToInt32(dgvClientes.SelectedRows(0).Cells(0).Value)

            ' Confirmar la eliminación
            Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?", "Confirmación", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                ' Conectar a la base de datos
                Dim connectionString As String = "Server=localhost\SQLEXPRESS;Database=pruebademo;Integrated Security=True;MultipleActiveResultSets=True;Timeout=120;"
                Using conn As New SqlConnection(connectionString)
                    Try
                        conn.Open()

                        ' Comando SQL para eliminar el cliente de la base de datos por su ID
                        Dim query As String = "DELETE FROM clientes WHERE ID = @ID"

                        Using cmd As New SqlCommand(query, conn)
                            ' Parámetro para el ID
                            cmd.Parameters.AddWithValue("@ID", idCliente)

                            ' Ejecutar la consulta
                            cmd.ExecuteNonQuery()
                        End Using

                        MessageBox.Show("Cliente eliminado correctamente.")

                        ' Refrescar el DataGridView
                        CargarClientes("")

                    Catch ex As Exception
                        MessageBox.Show("Error al eliminar el cliente: " & ex.Message)
                    End Try
                End Using
            End If
        Else
            MessageBox.Show("Seleccione un cliente para eliminar.")
        End If
    End Sub



    Private Sub bntModificarCliente_Click(sender As Object, e As EventArgs) Handles bntModificarCliente.Click

        ' Verificar si hay una fila seleccionada en el DataGridView
        If dgvClientes.SelectedRows.Count > 0 Then
            ' Hacer visible el panel de modificación
            pnlModificarCliente.Visible = True

            ' Obtener los valores de las columnas seleccionadas y asignarlos a los TextBox
            Dim filaSeleccionada As DataGridViewRow = dgvClientes.SelectedRows(0)

            ' Asignar el valor de la columna "Cliente" a txtClienteModificar
            txtClienteModificar.Text = filaSeleccionada.Cells("Cliente").Value.ToString()

            ' Asignar el valor de la columna "Correo" a txtCorreoModificar
            txtCorreoModificar.Text = filaSeleccionada.Cells("Correo").Value.ToString()

            ' Asignar el valor de la columna "Telefono" a txtTelefonoModificar
            txtTelefonoModificar.Text = filaSeleccionada.Cells("Telefono").Value.ToString()
        Else
            ' Mostrar mensaje si no se selecciona ninguna fila
            MessageBox.Show("Seleccione un cliente para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCancelarModificacion.Click
        pnlModificarCliente.Visible = False
    End Sub

    Private Sub btnModificarCliente_Click(sender As Object, e As EventArgs) Handles btnModificarCLiente.Click
        ' Verifica que haya una fila seleccionada en el DataGridView


        ' Obtener el ID del cliente seleccionado (asumiendo que está en la primera columna)
        Dim clienteId As Integer = Convert.ToInt32(dgvClientes.SelectedRows(0).Cells(0).Value)

        ' Aquí debes establecer la conexión con la base de datos
        Dim connectionString As String = "Server=localhost\SQLEXPRESS;Database=pruebademo;Integrated Security=True;MultipleActiveResultSets=True;Timeout=120;"

        ' Consulta SQL para actualizar el cliente
        Dim query As String = "UPDATE Clientes SET Cliente = @cliente, Correo = @correo, Telefono = @telefono WHERE ID = @id"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Agregar los parámetros
                command.Parameters.AddWithValue("@cliente", txtClienteModificar.Text)
                command.Parameters.AddWithValue("@correo", txtCorreoModificar.Text)
                command.Parameters.AddWithValue("@telefono", txtTelefonoModificar.Text)
                command.Parameters.AddWithValue("@id", clienteId)

                connection.Open()

                Try
                    ' Ejecutar el comando
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    ' Verificar si se actualizó algún registro
                    If rowsAffected > 0 Then
                        MessageBox.Show("Cliente modificado exitosamente.")
                        ' Aquí puedes refrescar el DataGridView si es necesario
                        CargarClientes("")
                        txtClienteModificar.Clear()
                        txtCorreoModificar.Clear()
                        txtTelefonoModificar.Clear()
                        pnlModificarCliente.Visible = False
                    Else
                        MessageBox.Show("No se encontró el cliente para modificar.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error al modificar el cliente: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

End Class
