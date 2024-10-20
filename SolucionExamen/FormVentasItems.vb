﻿Imports System.Configuration
Imports System.Data.SqlClient
Imports SolucionExamen.BLL
Imports SolucionExamen.Entidades



Public Class FormVentasItems
    Private VentaItemBL As New VentaItemBL()
    Private ProductoBL As New ProductoBL()






    Private Sub FormVentasItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar los ítems del DataGridView o lo que necesites cargar inicialmente
        CargarVentasItems("")


        ' Llamar al método para cargar los productos en el ComboBox
        CargarProductos()
    End Sub

    ' Método para cargar los productos en el ComboBox
    Private Sub CargarProductos()
        Try
            ' Obtener la lista de productos desde la base de datos
            Dim productos As List(Of Producto) = ProductoBL.ObtenerProductos()

            ' Asignar la lista de productos al ComboBox de agregar
            cmbProductos.DataSource = productos
            cmbProductos.DisplayMember = "Nombre"  ' Mostrar el nombre del producto
            cmbProductos.ValueMember = "ID"        ' Almacenar el ID del producto como valor del ComboBox

            ' Asignar la lista de productos al ComboBox de modificar
            cmbProductoModificar.DataSource = New List(Of Producto)(productos) ' Crear una nueva lista para evitar conflictos
            cmbProductoModificar.DisplayMember = "Nombre"
            cmbProductoModificar.ValueMember = "ID"

            ' Opcional: Limpiar selección inicial
            cmbProductos.SelectedIndex = -1
            cmbProductoModificar.SelectedIndex = -1

            ' Verificar si hay productos y cargar el precio del primero
            If productos.Count > 0 Then
                txtPrecioUnitario.Text = productos(0).Precio.ToString("F2") ' Mostrar el precio del primer producto con dos decimales
                cmbProductos.SelectedIndex = 0 ' Seleccionar el primer producto (opcional)
            Else
                txtPrecioUnitario.Clear() ' Limpiar el TextBox si no hay productos
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar los productos: " & ex.Message)
        End Try
    End Sub



    Private Sub txtBuscadorClientes_TextChanged(sender As Object, e As EventArgs) Handles txtBuscadorVentasItems.TextChanged
        CargarVentasItems(txtBuscadorVentasItems.Text)
    End Sub
    Private Sub CargarVentasItems(Optional ByVal busqueda As String = "")
        ' Conexión a la base de datos
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("SolucionExamen.My.MySettings.pruebademoConnectionString").ConnectionString


        ' Ajustamos la consulta SQL para buscar por IDVenta, Nombre del Producto o PrecioUnitario
        Dim query As String = "
    SELECT vi.IDVenta, p.Nombre AS NombreProducto, vi.PrecioUnitario, vi.Cantidad, vi.PrecioTotal 
    FROM VentasItems vi 
    INNER JOIN productos p ON vi.IDProducto = p.ID 
    WHERE (vi.IDVenta LIKE @busqueda OR p.Nombre LIKE @busqueda OR CAST(vi.PrecioUnitario AS NVARCHAR) LIKE @busqueda OR CAST(vi.Cantidad AS NVARCHAR) LIKE @busqueda OR CAST(vi.PrecioTotal AS NVARCHAR) LIKE @busqueda)"

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
                dgvVentasItems.DataSource = dt

                ' Si quieres ocultar la columna IDProducto en caso de que la quieras

            End Using
        End Using
    End Sub


    Private Sub btnAgregarVenta_Click(sender As Object, e As EventArgs) Handles btnAgregarVenta.Click
        pnlAggVentaItems.Visible = True
    End Sub

    Private Sub txtPrecioUnitario_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioUnitario.TextChanged
        Try
            Dim cantidad As Integer
            Dim precioUnitario As Integer

            ' Verifica si ambos campos contienen valores numéricos válidos
            If Integer.TryParse(txtCantidad.Text, cantidad) AndAlso Integer.TryParse(txtPrecioUnitario.Text, precioUnitario) Then
                ' Realiza el cálculo y coloca el resultado en txtPrecioTotal
                txtPrecioTotal.Text = (cantidad * precioUnitario).ToString()
            Else
                ' Limpia el campo txtPrecioTotal si los valores no son válidos
                txtPrecioTotal.Text = ""
            End If
        Catch ex As Exception
            ' Manejo de errores, si ocurre alguna excepción
            MessageBox.Show("Ocurrió un error: " & ex.Message)
        End Try
    End Sub


    Private Sub txtPrecioTotal_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioTotal.TextChanged
        Try
            ' Si txtPrecioTotal está vacío, limpia el valor de txtCantidad y termina la ejecución
            If String.IsNullOrEmpty(txtPrecioTotal.Text) Then
                txtCantidad.Text = ""
                Return
            End If

            ' Verifica que ambos campos tengan valores válidos numéricos
            Dim precioTotal As Decimal
            Dim precioUnitario As Decimal

            ' Intenta convertir los valores de los TextBox a números decimales
            If Decimal.TryParse(txtPrecioTotal.Text, precioTotal) AndAlso Decimal.TryParse(txtPrecioUnitario.Text, precioUnitario) Then
                ' Verifica que el precio unitario no sea cero para evitar la división por cero
                If precioUnitario <> 0 Then
                    ' Calcula la cantidad y la asigna al TextBox txtCantidad
                    txtCantidad.Text = (precioTotal / precioUnitario).ToString()
                Else
                    ' Si el precio unitario es cero, muestra 0 en txtCantidad
                    txtCantidad.Text = "0"
                End If
            Else
                ' Si no se puede convertir a decimal, deja la cantidad vacía
                txtCantidad.Text = ""
            End If

        Catch ex As Exception
            ' Manejo de errores, si ocurre alguna excepción
            MessageBox.Show("Ocurrió un error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCancelaAgg_Click(sender As Object, e As EventArgs) Handles btnCancelaAgg.Click
        pnlAggVentaItems.Visible = False
        txtPrecioTotal.Clear()
        txtCantidad.Clear()
        txtPrecioUnitario.Clear()

    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        Try
            Dim cantidad As Decimal
            Dim precioUnitario As Decimal
            Dim total As Decimal

            ' Verifica si ambos TextBox contienen valores numéricos válidos
            If Decimal.TryParse(txtCantidad.Text, cantidad) AndAlso Decimal.TryParse(txtPrecioUnitario.Text, precioUnitario) Then
                ' Calcula el total y lo muestra en txtPrecioTotal
                total = cantidad * precioUnitario
                txtPrecioTotal.Text = total.ToString("F2") ' Formato con 2 decimales
            Else
                ' Limpia el campo txtPrecioTotal si los valores no son válidos
                txtPrecioTotal.Clear()
            End If
        Catch ex As Exception
            ' Manejo de cualquier excepción que ocurra
            MessageBox.Show("Ocurrió un error: " & ex.Message)
        End Try
    End Sub


    Private Sub btnAgg_Click(sender As Object, e As EventArgs) Handles btnAgg.Click
        If String.IsNullOrWhiteSpace(txtPrecioUnitario.Text) OrElse String.IsNullOrWhiteSpace(txtCantidad.Text) OrElse String.IsNullOrWhiteSpace(txtPrecioTotal.Text) OrElse String.IsNullOrWhiteSpace(txtNroVenta.Text) OrElse cmbProductos.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Establecer la cadena de conexión a la base de datos
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("SolucionExamen.My.MySettings.pruebademoConnectionString").ConnectionString


        ' Crear la consulta SQL para insertar un nuevo cliente
        Dim query As String = "INSERT INTO Ventasitems (IDVenta, IDProducto, Preciounitario, Cantidad, Preciototal) VALUES (@IDVenta, @IDProducto, @PrecioUnitario, @Cantidad, @PrecioTotal)"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Asignar los valores de los parámetros
                command.Parameters.AddWithValue("@IDVenta", txtNroVenta.Text) ' IDVenta
                command.Parameters.AddWithValue("@IDProducto", cmbProductos.SelectedValue) ' IDProducto desde el ComboBox
                command.Parameters.AddWithValue("@PrecioUnitario", Single.Parse(txtPrecioUnitario.Text))
                command.Parameters.AddWithValue("@Cantidad", Single.Parse(txtCantidad.Text))
                command.Parameters.AddWithValue("@PrecioTotal", Single.Parse(txtPrecioTotal.Text))

                Try
                    ' Abrir la conexión
                    connection.Open()
                    ' Ejecutar la consulta
                    command.ExecuteNonQuery()
                    MessageBox.Show("Venta agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Opcional: Limpiar los TextBox después de guardar
                    txtPrecioUnitario.Clear()
                    txtCantidad.Clear()
                    txtPrecioTotal.Clear()
                    txtNroVenta.Clear() ' Limpiar el campo IDVenta
                    cmbProductos.SelectedIndex = -1 ' Limpiar selección del ComboBox
                    pnlAggVentaItems.Visible = False
                    CargarVentasItems("")

                Catch ex As Exception
                    MessageBox.Show("Error al agregar venta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End Using

        End Using
    End Sub


    Private Sub txtNroVenta_TextChanged(sender As Object, e As EventArgs) Handles txtNroVenta.TextChanged
        ' Verificar si el texto es un número válido
        Dim idVenta As Integer
        If Integer.TryParse(txtNroVenta.Text, idVenta) Then
            ' Establecer la cadena de conexión a la base de datos
            Dim connectionString As String = ConfigurationManager.ConnectionStrings("SolucionExamen.My.MySettings.pruebademoConnectionString").ConnectionString


            ' Crear la consulta SQL para obtener el IDCliente y el Total asociados al IDVenta
            Dim queryVenta As String = "SELECT IDCliente, Total FROM ventas WHERE ID = @IDVenta"

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Using commandVenta As New SqlCommand(queryVenta, connection)
                    ' Asignar el valor del IDVenta a la consulta
                    commandVenta.Parameters.AddWithValue("@IDVenta", idVenta)

                    Try
                        ' Ejecutar la consulta y obtener el IDCliente y el Total
                        Using reader As SqlDataReader = commandVenta.ExecuteReader()
                            If reader.Read() Then
                                ' Obtener el IDCliente y el Total de la tabla ventas
                                Dim idCliente As Integer = reader("IDCliente")
                                Dim totalVenta As Decimal = reader("Total")

                                ' Mostrar el total en txtPrecioTotal
                                txtPrecioTotal.Text = totalVenta.ToString("F2")

                                ' Cerrar el reader antes de ejecutar la segunda consulta
                                reader.Close()

                                ' Crear la consulta SQL para obtener el nombre del cliente de la tabla Clientes
                                Dim queryCliente As String = "SELECT Cliente FROM clientes WHERE ID = @IDCliente"

                                ' Buscar el nombre del cliente
                                Using commandCliente As New SqlCommand(queryCliente, connection)
                                    commandCliente.Parameters.AddWithValue("@IDCliente", idCliente)

                                    ' Obtener el nombre del cliente
                                    Dim nombreCliente As Object = commandCliente.ExecuteScalar()

                                    ' Verificar si se obtuvo un resultado y mostrarlo en el TextBox
                                    If nombreCliente IsNot Nothing Then
                                        txtCliente.Text = nombreCliente.ToString() ' Mostrar el nombre del cliente en txtCliente
                                    Else
                                        txtCliente.Clear() ' Limpiar el TextBox si no se encontró el cliente
                                    End If
                                End Using
                            Else
                                txtCliente.Clear() ' Limpiar el TextBox si no se encuentra la venta
                                txtPrecioTotal.Clear() ' Limpiar el TextBox si no se encuentra la venta
                            End If
                        End Using

                    Catch ex As Exception
                        MessageBox.Show("Error al buscar la venta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using
        Else
            txtCliente.Clear() ' Limpiar el TextBox si la entrada no es un número válido
            txtPrecioTotal.Clear() ' Limpiar el TextBox si la entrada no es un número válido
        End If

        ' Verificar si txtCliente está vacío y limpiar txtPrecioTotal
        If String.IsNullOrWhiteSpace(txtCliente.Text) Then
            txtPrecioTotal.Clear()
        End If
    End Sub

    Private Sub cmbProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductos.SelectedIndexChanged
        cmbProductos.ValueMember = "ID" ' Asegúrate de que "ID" es el nombre correcto de la columna que contiene los IDs
        ' Solo actualizar txtPrecioUnitario si hay un producto seleccionado
        If cmbProductos.SelectedIndex <> -1 Then
            ' Establecer la cadena de conexión a la base de datos
            Dim connectionString As String = ConfigurationManager.ConnectionStrings("SolucionExamen.My.MySettings.pruebademoConnectionString").ConnectionString


            ' Obtener el ID del producto seleccionado
            Dim idProducto As Integer
            If Integer.TryParse(cmbProductos.SelectedValue.ToString(), idProducto) Then
                ' Crear la consulta SQL para obtener el precio del producto
                Dim queryProducto As String = "SELECT Precio FROM productos WHERE ID = @ID"

                Using connection As New SqlConnection(connectionString)
                    Using commandProducto As New SqlCommand(queryProducto, connection)
                        commandProducto.Parameters.AddWithValue("@ID", idProducto)

                        Try
                            ' Abrir la conexión
                            connection.Open()

                            ' Obtener el precio del producto
                            Dim precioUnitario As Object = commandProducto.ExecuteScalar()

                            ' Verificar si se obtuvo un resultado y mostrarlo en txtPrecioUnitario
                            If precioUnitario IsNot Nothing Then
                                txtPrecioUnitario.Text = Convert.ToDecimal(precioUnitario).ToString("F2") ' Mostrar el precio en txtPrecioUnitario
                                txtCantidad.ReadOnly = False
                            Else
                                ' Limpiar el TextBox si no se encontró el precio
                            End If

                        Catch ex As Exception
                            MessageBox.Show("Error al buscar el precio del producto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                    End Using
                End Using
            Else
                MessageBox.Show("Error: ID de producto no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

        ' No se limpia txtPrecioTotal, se mantendrá como está hasta que cambie txtNroVenta
    End Sub

    Private Sub bntModificarVentasItems_Click(sender As Object, e As EventArgs) Handles bntModificarVentasItems.Click
        ' Verificar si hay una fila seleccionada en el DataGridView
        If dgvVentasItems.SelectedRows.Count > 0 Then
            ' Hacer visible el panel de modificación
            pnlModificarVentaItem.Visible = True

            ' Obtener los valores de las columnas seleccionadas y asignarlos a los TextBox
            Dim filaSeleccionada As DataGridViewRow = dgvVentasItems.SelectedRows(0)

            ' Asignar el valor de la columna "Cantidad" a txtCantidadModificar
            txtCantidadModificar.Text = filaSeleccionada.Cells("Cantidad").Value.ToString()

            ' Asignar el valor de la columna "IDVenta" a txtNroVentaModificar
            txtNroVentaModificar.Text = filaSeleccionada.Cells("IDVenta").Value.ToString()

            ' Asignar el valor de la columna "PrecioUnitario" a txtPrecioUnitarioModificar
            txtPrecioUnitarioModificar.Text = filaSeleccionada.Cells("PrecioUnitario").Value.ToString()

            txtPrecioTotalModificar.Text = filaSeleccionada.Cells("PrecioTotal").Value.ToString()
            ' Asignar el producto seleccionado al ComboBox
            Dim idProducto As String = filaSeleccionada.Cells("NombreProducto").Value.ToString()

            cmbProductoModificar.SelectedValue = idProducto


        Else
            ' Mostrar mensaje si no se selecciona ninguna fila
            MessageBox.Show("Seleccione un producto para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pnlModificarVentaItem.Visible = False
        txtCantidadModificar.Clear()

    End Sub

    Private Sub dgvVentasItems_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVentasItems.CellContentClick

    End Sub

    Private Sub dgvVentasItems_SelectionChanged(sender As Object, e As EventArgs) Handles dgvVentasItems.SelectionChanged
        ' Verifica si hay alguna celda seleccionada
        If dgvVentasItems.SelectedCells.Count > 0 Then
            bntModificarVentasItems.Enabled = True
        Else
            bntModificarVentasItems.Enabled = False
        End If
        If dgvVentasItems.SelectedCells.Count > 0 Then
            btnEliminarCliente.Enabled = True
        Else
            btnEliminarCliente.Enabled = False
        End If

    End Sub

    Private Sub cmbProductoModificar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductoModificar.SelectedIndexChanged
        If cmbProductoModificar.SelectedIndex <> -1 Then
            Dim productoSeleccionado As Producto = CType(cmbProductoModificar.SelectedItem, Producto)
            txtPrecioUnitarioModificar.Text = productoSeleccionado.Precio.ToString("F2") ' Muestra el precio con dos decimales
        Else
            txtPrecioUnitarioModificar.Clear() ' Limpiar el campo si no hay selección
        End If
    End Sub

    Private Sub txtNroVentaModificar_TextChanged(sender As Object, e As EventArgs) Handles txtNroVentaModificar.TextChanged
        ' Verificar si el texto es un número válido
        Dim idVenta As Integer
        If Integer.TryParse(txtNroVentaModificar.Text, idVenta) Then
            ' Establecer la cadena de conexión a la base de datos
            Dim connectionString As String = ConfigurationManager.ConnectionStrings("SolucionExamen.My.MySettings.pruebademoConnectionString").ConnectionString


            ' Crear la consulta SQL para obtener el IDCliente y el Total asociados al IDVenta
            Dim queryVenta As String = "SELECT IDCliente, Total FROM ventas WHERE ID = @IDVenta"

            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Using commandVenta As New SqlCommand(queryVenta, connection)
                    ' Asignar el valor del IDVenta a la consulta
                    commandVenta.Parameters.AddWithValue("@IDVenta", idVenta)

                    Try
                        ' Ejecutar la consulta y obtener el IDCliente y el Total
                        Using reader As SqlDataReader = commandVenta.ExecuteReader()
                            If reader.Read() Then
                                ' Obtener el IDCliente y el Total de la tabla ventas
                                Dim idCliente As Integer = reader("IDCliente")
                                Dim totalVenta As Decimal = reader("Total")

                                ' Mostrar el total en txtPrecioTotal
                                txtPrecioTotal.Text = totalVenta.ToString("F2")

                                ' Cerrar el reader antes de ejecutar la segunda consulta
                                reader.Close()

                                ' Crear la consulta SQL para obtener el nombre del cliente de la tabla Clientes
                                Dim queryCliente As String = "SELECT Cliente FROM clientes WHERE ID = @IDCliente"

                                ' Buscar el nombre del cliente
                                Using commandCliente As New SqlCommand(queryCliente, connection)
                                    commandCliente.Parameters.AddWithValue("@IDCliente", idCliente)

                                    ' Obtener el nombre del cliente
                                    Dim nombreCliente As Object = commandCliente.ExecuteScalar()

                                    ' Verificar si se obtuvo un resultado y mostrarlo en el TextBox
                                    If nombreCliente IsNot Nothing Then
                                        txtClienteModificar.Text = nombreCliente.ToString() ' Mostrar el nombre del cliente en txtCliente
                                    Else
                                        txtClienteModificar.Clear() ' Limpiar el TextBox si no se encontró el cliente
                                    End If
                                End Using
                            Else
                                txtClienteModificar.Clear() ' Limpiar el TextBox si no se encuentra la venta
                                txtPrecioTotal.Clear() ' Limpiar el TextBox si no se encuentra la venta
                            End If
                        End Using

                    Catch ex As Exception
                        MessageBox.Show("Error al buscar la venta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using
        Else
            txtCliente.Clear() ' Limpiar el TextBox si la entrada no es un número válido
            txtPrecioTotal.Clear() ' Limpiar el TextBox si la entrada no es un número válido
        End If

        ' Verificar si txtCliente está vacío y limpiar txtPrecioTotal
        If String.IsNullOrWhiteSpace(txtCliente.Text) Then
            txtPrecioTotal.Clear()
        End If
    End Sub

    Private Sub btnModificarVenta_Click(sender As Object, e As EventArgs) Handles btnModificarVenta.Click
        If String.IsNullOrWhiteSpace(txtNroVentaModificar.Text) Then
            MessageBox.Show("Por favor, ingrese un número de venta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim idVenta As Integer
        If Not Integer.TryParse(txtNroVentaModificar.Text, idVenta) Then
            MessageBox.Show("El ID de venta debe ser un número válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Establecer la cadena de conexión a la base de datos
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("SolucionExamen.My.MySettings.pruebademoConnectionString").ConnectionString


        ' Crear la consulta SQL para actualizar la venta
        Dim query As String = "UPDATE VentasItems SET IDProducto = @IDProducto, PrecioUnitario = @PrecioUnitario, Cantidad = @Cantidad, PrecioTotal = @PrecioTotal WHERE IDVenta = @IDVenta"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Asignar los valores de los parámetros
                command.Parameters.AddWithValue("@IDProducto", cmbProductoModificar.SelectedValue)
                command.Parameters.AddWithValue("@PrecioUnitario", Single.Parse(txtPrecioUnitarioModificar.Text))
                command.Parameters.AddWithValue("@Cantidad", Single.Parse(txtCantidadModificar.Text))
                command.Parameters.AddWithValue("@PrecioTotal", Single.Parse(txtPrecioTotalModificar.Text))
                command.Parameters.AddWithValue("@IDVenta", idVenta)

                Try
                    ' Abrir la conexión
                    connection.Open()
                    ' Ejecutar la consulta
                    Dim filasAfectadas As Integer = command.ExecuteNonQuery()

                    If filasAfectadas > 0 Then
                        MessageBox.Show("Venta actualizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CargarVentasItems("")
                    Else
                        MessageBox.Show("No se encontró la venta para actualizar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If

                    ' Opcional: Limpiar los campos después de actualizar
                    pnlModificarVentaItem.Visible = False
                    ' Método para recargar el DataGridView con los datos actualizados

                Catch ex As Exception
                    MessageBox.Show("Error al actualizar la venta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnEliminarCliente_Click(sender As Object, e As EventArgs) Handles btnEliminarCliente.Click
        ' Verifica que haya una fila seleccionada en el DataGridView
        If dgvVentasItems.SelectedRows.Count > 0 Then
            ' Obtén el ID del cliente seleccionado (asumiendo que está en la primera columna)
            Dim idVenta As Integer = Convert.ToInt32(dgvVentasItems.SelectedRows(0).Cells(0).Value)

            ' Confirmar la eliminación
            Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar esta venta?", "Confirmación", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                ' Conectar a la base de datos
                Dim connectionString As String = ConfigurationManager.ConnectionStrings("SolucionExamen.My.MySettings.pruebademoConnectionString").ConnectionString

                Using conn As New SqlConnection(connectionString)
                    Try
                        conn.Open()

                        ' Comando SQL para eliminar el cliente de la base de datos por su ID
                        Dim query As String = "DELETE FROM ventasitems WHERE ID = @ID"

                        Using cmd As New SqlCommand(query, conn)
                            ' Parámetro para el ID
                            cmd.Parameters.AddWithValue("@ID", idVenta)

                            ' Ejecutar la consulta
                            cmd.ExecuteNonQuery()
                        End Using

                        MessageBox.Show("Venta eliminada correctamente.")

                        ' Refrescar el DataGridView
                        CargarVentasItems("")

                    Catch ex As Exception
                        MessageBox.Show("Error al eliminar la venta: " & ex.Message)
                    End Try
                End Using
            End If
        Else
            MessageBox.Show("Seleccione una venta para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub pnlModificarVentaItem_Paint(sender As Object, e As PaintEventArgs) Handles pnlModificarVentaItem.Paint

    End Sub





    ' Variables para el arrastre del panel
    Private mouseIsDown As Boolean = False
    Private mouseOffset As Point

    ' Evento MouseDown: cuando se hace clic en el panel
    Private Sub pnlModificarVentaItem_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlModificarVentaItem.MouseDown
        If e.Button = MouseButtons.Left Then
            ' Marcar que el mouse está presionado
            mouseIsDown = True
            ' Guardar la posición del mouse relativa al panel
            mouseOffset = New Point(-e.X, -e.Y)
        End If
    End Sub

    ' Evento MouseMove: cuando se mueve el mouse sobre el panel
    Private Sub pnlModificarVentaItem11(sender As Object, e As MouseEventArgs) Handles pnlModificarVentaItem.MouseMove
        If mouseIsDown Then
            ' Obtener la posición actual del mouse en la pantalla
            Dim mousePos As Point = Control.MousePosition
            ' Ajustar la posición del panel en función del desplazamiento
            pnlModificarVentaItem.Location = Me.PointToClient(New Point(mousePos.X + mouseOffset.X, mousePos.Y + mouseOffset.Y))
        End If
    End Sub

    ' Evento MouseUp: cuando se suelta el botón del mouse
    Private Sub pnlAggProducto_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlModificarVentaItem.MouseUp
        ' El mouse ya no está presionado
        mouseIsDown = False
    End Sub


    'SEGUNDO PANEL



    Private mouseIsDown1 As Boolean = False
    Private mouseOffset1 As Point

    ' Evento MouseDown: cuando se hace clic en el panel
    Private Sub pnlAggVentaItems_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlAggVentaItems.MouseDown
        If e.Button = MouseButtons.Left Then
            ' Marcar que el mouse está presionado
            mouseIsDown1 = True
            ' Guardar la posición del mouse relativa al panel
            mouseOffset1 = New Point(-e.X, -e.Y)
        End If
    End Sub

    ' Evento MouseMove: cuando se mueve el mouse sobre el panel
    Private Sub pnlAggVentaItems1(sender As Object, e As MouseEventArgs) Handles pnlAggVentaItems.MouseMove
        If mouseIsDown1 Then
            ' Obtener la posición actual del mouse en la pantalla
            Dim mousePos As Point = Control.MousePosition
            ' Ajustar la posición del panel en función del desplazamiento
            pnlAggVentaItems.Location = Me.PointToClient(New Point(mousePos.X + mouseOffset1.X, mousePos.Y + mouseOffset1.Y))
        End If
    End Sub

    ' Evento MouseUp: cuando se suelta el botón del mouse
    Private Sub pnlModificarProducto_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlAggVentaItems.MouseUp
        ' El mouse ya no está presionado
        mouseIsDown1 = False
    End Sub

    Private Sub txtPrecioTotalModificar_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioTotalModificar.TextChanged
        Try
            ' Si txtPrecioTotal está vacío, limpia el valor de txtCantidad y termina la ejecución
            If String.IsNullOrEmpty(txtPrecioTotalModificar.Text) Then
                txtCantidad.Text = ""
                Return
            End If

            ' Verifica que ambos campos tengan valores válidos numéricos
            Dim precioTotal As Decimal
            Dim precioUnitario As Decimal

            ' Intenta convertir los valores de los TextBox a números decimales
            If Decimal.TryParse(txtPrecioTotalModificar.Text, precioTotal) AndAlso Decimal.TryParse(txtPrecioUnitario.Text, precioUnitario) Then
                ' Verifica que el precio unitario no sea cero para evitar la división por cero
                If precioUnitario <> 0 Then
                    ' Calcula la cantidad y la asigna al TextBox txtCantidad
                    txtCantidad.Text = (precioTotal / precioUnitario).ToString()
                Else
                    ' Si el precio unitario es cero, puedes mostrar un mensaje o hacer algo
                    txtCantidad.Text = "0"
                End If
            Else
                ' Si no se puede convertir, deja la cantidad vacía o en cero
                txtCantidad.Text = "0"
            End If

        Catch ex As Exception
            ' Manejo de errores, si ocurre alguna excepción
            MessageBox.Show("Ocurrió un error: " & ex.Message)
        End Try
    End Sub

    Private Sub txtCantidadModificar_TextChanged(sender As Object, e As EventArgs) Handles txtCantidadModificar.TextChanged
        Try
            ' Si txtCantidadModificar está vacío, limpia el valor de txtPrecioTotalModificar y termina la ejecución
            If String.IsNullOrEmpty(txtCantidadModificar.Text) Then
                txtPrecioTotalModificar.Text = ""
                Return
            End If

            ' Verifica que ambos campos tengan valores válidos numéricos
            Dim cantidad As Decimal
            Dim precioUnitario As Decimal

            ' Intenta convertir los valores de los TextBox a números decimales
            If Decimal.TryParse(txtCantidadModificar.Text, cantidad) AndAlso Decimal.TryParse(txtPrecioUnitarioModificar.Text, precioUnitario) Then
                ' Calcula el precio total y lo asigna al TextBox txtPrecioTotalModificar
                txtPrecioTotalModificar.Text = (cantidad * precioUnitario).ToString()
            Else
                ' Si no se puede convertir a decimal, deja el precio total vacío
                txtPrecioTotalModificar.Text = ""
            End If

        Catch ex As Exception
            ' Manejo de errores, si ocurre alguna excepción
            MessageBox.Show("Ocurrió un error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnReportesItems_Click(sender As Object, e As EventArgs)

    End Sub
End Class