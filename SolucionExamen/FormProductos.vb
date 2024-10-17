Imports System.Data.SqlClient
Imports SolucionExamen.BLL

Public Class FormProductos
    Private connectionString As String = "Server = localhost;Uid=sa;Pwd=sasa;MultipleActiveResultSets=True;Timeout=120;Database=pruebademo;;"
    Private ProductoBL As New ProductoBL()
    Private Sub FormProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Usamos la instancia clienteBL para llamar a ObtenerClientes
            dgvProductos.DataSource = ProductoBL.ObtenerProductos()
        Catch ex As Exception
            MessageBox.Show("Error al cargar el formulario: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        pnlAggProducto.Visible = True
    End Sub

    Private Sub btnCancelarModificacion_Click(sender As Object, e As EventArgs) Handles btnCancelarModificacion.Click
        pnlModificarProducto.Visible = False
    End Sub

    Private Sub btnCancelaAgg_Click(sender As Object, e As EventArgs) Handles btnCancelaAgg.Click
        pnlAggProducto.Visible = False
    End Sub
    Private Sub CargarProductos(Optional ByVal busqueda As String = "")
        ' Aquí debes establecer la conexión con la base de datos
        Dim connectionString As String = "Server = localhost;Uid=sa;Pwd=sasa;MultipleActiveResultSets=True;Timeout=120;Database=pruebademo;"

        ' Ajustamos la consulta SQL para buscar por nombre, precio o categoría
        Dim query As String = "SELECT * FROM Productos WHERE (Nombre LIKE @busqueda OR Categoria LIKE @busqueda OR CAST(Precio AS NVARCHAR) LIKE @busqueda)"

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
                dgvProductos.DataSource = dt
            End Using
        End Using
    End Sub



    Private Sub btnAgg_Click(sender As Object, e As EventArgs) Handles btnAgg.Click
        If String.IsNullOrWhiteSpace(txtNombreProducto.Text) OrElse String.IsNullOrWhiteSpace(txtPrecioProducto.Text) OrElse String.IsNullOrWhiteSpace(txtCategoriaProducto.Text) Then
            MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Establecer la cadena de conexión a la base de datos
        Dim connectionString As String = "Server = localhost;Uid=sa;Pwd=sasa;MultipleActiveResultSets=True;Timeout=120;Database=pruebademo;"

        ' Crear la consulta SQL para insertar un nuevo cliente
        Dim query As String = "INSERT INTO Productos (Nombre, Precio, Categoria) VALUES (@Nombre, @Precio, @Categoria)"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Asignar los valores de los parámetros
                command.Parameters.AddWithValue("@Nombre", txtNombreProducto.Text)
                command.Parameters.AddWithValue("@Precio", txtPrecioProducto.Text)
                command.Parameters.AddWithValue("@Categoria", txtCategoriaProducto.Text)

                Try
                    ' Abrir la conexión
                    connection.Open()
                    ' Ejecutar la consulta
                    command.ExecuteNonQuery()
                    MessageBox.Show("Producto agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Opcional: Limpiar los TextBox después de guardar
                    txtNombreProducto.Clear()
                    txtPrecioProducto.Clear()
                    txtCategoriaProducto.Clear()
                    pnlAggProducto.Visible = False
                    CargarProductos("")

                Catch ex As Exception
                    MessageBox.Show("Error al agregar producto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End Using

        End Using
    End Sub

    Private Sub txtBuscadorProducto_TextChanged(sender As Object, e As EventArgs) Handles txtBuscadorProducto.TextChanged
        ' Llama a la función CargarProductos pasándole el texto del TextBox como parámetro
        CargarProductos(txtBuscadorProducto.Text)
    End Sub

    Private Sub btnEliminarProducto_Click(sender As Object, e As EventArgs) Handles btnEliminarProducto.Click
        ' Verifica que haya una fila seleccionada en el DataGridView
        If dgvProductos.SelectedRows.Count > 0 Then
            ' Obtén el ID del cliente seleccionado (asumiendo que está en la primera columna)
            Dim idProducto As Integer = Convert.ToInt32(dgvProductos.SelectedRows(0).Cells(0).Value)

            ' Confirmar la eliminación
            Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?", "Confirmación", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                ' Conectar a la base de datos
                Dim connectionString As String = "Server = localhost;Uid=sa;Pwd=sasa;MultipleActiveResultSets=True;Timeout=120;Database=pruebademo;"
                Using conn As New SqlConnection(connectionString)
                    Try
                        conn.Open()

                        ' Comando SQL para eliminar el cliente de la base de datos por su ID
                        Dim query As String = "DELETE FROM productos WHERE ID = @ID"

                        Using cmd As New SqlCommand(query, conn)
                            ' Parámetro para el ID
                            cmd.Parameters.AddWithValue("@ID", idProducto)

                            ' Ejecutar la consulta
                            cmd.ExecuteNonQuery()
                        End Using

                        MessageBox.Show("Producto eliminado correctamente.")

                        ' Refrescar el DataGridView
                        CargarProductos("")

                    Catch ex As Exception
                        MessageBox.Show("Error al eliminar el producto: " & ex.Message)
                    End Try
                End Using
            End If
        Else
            MessageBox.Show("Seleccione un producto para eliminar.")
        End If
    End Sub

    Private Sub dgvProductos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProductos.SelectionChanged
        ' Verifica si hay alguna celda seleccionada
        If dgvProductos.SelectedCells.Count > 0 Then
            bntModificarProducto.Enabled = True
        Else
            bntModificarProducto.Enabled = False
        End If
        If dgvProductos.SelectedCells.Count > 0 Then
            btnEliminarProducto.Enabled = True
        Else
            btnEliminarProducto.Enabled = False
        End If
    End Sub

    Private Sub bntModificarProducto_Click(sender As Object, e As EventArgs) Handles bntModificarProducto.Click
        ' Verificar si hay una fila seleccionada en el DataGridView
        If dgvProductos.SelectedRows.Count > 0 Then
            ' Hacer visible el panel de modificación
            pnlModificarProducto.Visible = True

            ' Obtener los valores de las columnas seleccionadas y asignarlos a los TextBox
            Dim filaSeleccionada As DataGridViewRow = dgvProductos.SelectedRows(0)

            ' Asignar el valor de la columna "Cliente" a txtClienteModificar
            txtProductoModificar.Text = filaSeleccionada.Cells("Nombre").Value.ToString()

            ' Asignar el valor de la columna "Correo" a txtCorreoModificar
            txtPrecioModificar.Text = filaSeleccionada.Cells("Precio").Value.ToString()

            ' Asignar el valor de la columna "Telefono" a txtTelefonoModificar
            txtCategoriaModificar.Text = filaSeleccionada.Cells("Categoria").Value.ToString()
        Else
            ' Mostrar mensaje si no se selecciona ninguna fila
            MessageBox.Show("Seleccione un producto para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnModificarProducto2_Click(sender As Object, e As EventArgs) Handles btnModificarProducto2.Click

        ' Verifica que haya una fila seleccionada en el DataGridView


        ' Obtener el ID del cliente seleccionado (asumiendo que está en la primera columna)
        Dim productoId As Integer = Convert.ToInt32(dgvProductos.SelectedRows(0).Cells(0).Value)

        ' Aquí debes establecer la conexión con la base de datos
        Dim connectionString As String = "Server = localhost;Uid=sa;Pwd=sasa;MultipleActiveResultSets=True;Timeout=120;Database=pruebademo;"

        ' Consulta SQL para actualizar el cliente
        Dim query As String = "UPDATE Productos SET Nombre = @nombre, Precio = @precio, Categoria = @categoria WHERE ID = @id"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Agregar los parámetros
                command.Parameters.AddWithValue("@nombre", txtProductoModificar.Text)
                command.Parameters.AddWithValue("@precio", txtPrecioModificar.Text)
                command.Parameters.AddWithValue("@categoria", txtCategoriaModificar.Text)
                command.Parameters.AddWithValue("@id", productoId)

                connection.Open()

                Try
                    ' Ejecutar el comando
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    ' Verificar si se actualizó algún registro
                    If rowsAffected > 0 Then
                        MessageBox.Show("Producto modificado exitosamente.")
                        ' Aquí puedes refrescar el DataGridView si es necesario
                        CargarProductos("")
                        txtProductoModificar.Clear()
                        txtPrecioModificar.Clear()
                        txtCategoriaModificar.Clear()
                        pnlModificarProducto.Visible = False
                    Else
                        MessageBox.Show("No se encontró el producto para modificar.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error al modificar el producto: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub











    ' Variables para el arrastre del panel
    Private mouseIsDown As Boolean = False
    Private mouseOffset As Point

    ' Evento MouseDown: cuando se hace clic en el panel
    Private Sub pnlAggProducto_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlAggProducto.MouseDown
        If e.Button = MouseButtons.Left Then
            ' Marcar que el mouse está presionado
            mouseIsDown = True
            ' Guardar la posición del mouse relativa al panel
            mouseOffset = New Point(-e.X, -e.Y)
        End If
    End Sub

    ' Evento MouseMove: cuando se mueve el mouse sobre el panel
    Private Sub pnlAggProducto1(sender As Object, e As MouseEventArgs) Handles pnlAggProducto.MouseMove
        If mouseIsDown Then
            ' Obtener la posición actual del mouse en la pantalla
            Dim mousePos As Point = Control.MousePosition
            ' Ajustar la posición del panel en función del desplazamiento
            pnlAggProducto.Location = Me.PointToClient(New Point(mousePos.X + mouseOffset.X, mousePos.Y + mouseOffset.Y))
        End If
    End Sub

    ' Evento MouseUp: cuando se suelta el botón del mouse
    Private Sub pnlAggProducto_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlAggProducto.MouseUp
        ' El mouse ya no está presionado
        mouseIsDown = False
    End Sub


    'SEGUNDO PANEL



    Private mouseIsDown1 As Boolean = False
    Private mouseOffset1 As Point

    ' Evento MouseDown: cuando se hace clic en el panel
    Private Sub pnlModificarProducto_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlModificarProducto.MouseDown
        If e.Button = MouseButtons.Left Then
            ' Marcar que el mouse está presionado
            mouseIsDown1 = True
            ' Guardar la posición del mouse relativa al panel
            mouseOffset1 = New Point(-e.X, -e.Y)
        End If
    End Sub

    ' Evento MouseMove: cuando se mueve el mouse sobre el panel
    Private Sub pnlModificarProducto1(sender As Object, e As MouseEventArgs) Handles pnlModificarProducto.MouseMove
        If mouseIsDown1 Then
            ' Obtener la posición actual del mouse en la pantalla
            Dim mousePos As Point = Control.MousePosition
            ' Ajustar la posición del panel en función del desplazamiento
            pnlModificarProducto.Location = Me.PointToClient(New Point(mousePos.X + mouseOffset1.X, mousePos.Y + mouseOffset1.Y))
        End If
    End Sub

    ' Evento MouseUp: cuando se suelta el botón del mouse
    Private Sub pnlModificarProducto_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlModificarProducto.MouseUp
        ' El mouse ya no está presionado
        mouseIsDown1 = False
    End Sub

End Class