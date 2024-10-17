Public Class FormInicio
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    'Private Sub FormInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    ' Configuración del formulario
    '    Me.Text = "Aplicación de prueba"
    '    Me.Size = New Size(400, 400) ' Tamaño del formulario
    '    Me.StartPosition = FormStartPosition.CenterScreen ' Centrar el formulario
    '    Me.BackColor = Color.Black ' Color de fondo negro
    '    Me.ForeColor = Color.White ' Color de letras blanco

    '    ' Label para el título
    '    Dim lblTitulo As New Label()
    '    lblTitulo.Text = "Aplicación Demo"
    '    lblTitulo.Font = New Font("Arial", 16, FontStyle.Bold) ' Tamaño y estilo de fuente
    '    lblTitulo.AutoSize = True
    '    lblTitulo.ForeColor = Color.White ' Color de letras del label
    '    lblTitulo.Location = New Point((Me.ClientSize.Width - lblTitulo.Width) / 2, 20) ' Centrar el label horizontalmente
    '    Me.Controls.Add(lblTitulo)

    '    ' Botón para Clientes
    '    Dim btnClientes As New Button()
    '    btnClientes.Text = "Clientes"
    '    btnClientes.Size = New Size(200, 50) ' Tamaño del botón
    '    btnClientes.Location = New Point((Me.ClientSize.Width - btnClientes.Width) / 2, 80) ' Centrar el botón
    '    btnClientes.BackColor = Color.Gray ' Color de fondo del botón
    '    btnClientes.ForeColor = Color.White ' Color de letras del botón
    '    AddHandler btnClientes.Click, AddressOf btnClientes_Click
    '    Me.Controls.Add(btnClientes)

    '    ' Botón para Productos
    '    Dim btnProductos As New Button()
    '    btnProductos.Text = "Productos"
    '    btnProductos.Size = New Size(200, 50) ' Tamaño del botón
    '    btnProductos.Location = New Point((Me.ClientSize.Width - btnProductos.Width) / 2, 150) ' Centrar el botón
    '    btnProductos.BackColor = Color.Gray ' Color de fondo del botón
    '    btnProductos.ForeColor = Color.White ' Color de letras del botón
    '    AddHandler btnProductos.Click, AddressOf btnProductos_Click
    '    Me.Controls.Add(btnProductos)

    '    ' Botón para Ventas
    '    Dim btnVentas As New Button()
    '    btnVentas.Text = "Ventas"
    '    btnVentas.Size = New Size(200, 50) ' Tamaño del botón
    '    btnVentas.Location = New Point((Me.ClientSize.Width - btnVentas.Width) / 2, 220) ' Centrar el botón
    '    btnVentas.BackColor = Color.Gray ' Color de fondo del botón
    '    btnVentas.ForeColor = Color.White ' Color de letras del botón
    '    AddHandler btnVentas.Click, AddressOf btnVentas_Click
    '    Me.Controls.Add(btnVentas)

    '    ' Botón para Reportes
    '    Dim btnReportes As New Button()
    '    btnReportes.Text = "Reportes"
    '    btnReportes.Size = New Size(200, 50) ' Tamaño del botón
    '    btnReportes.Location = New Point((Me.ClientSize.Width - btnReportes.Width) / 2, 290) ' Centrar el botón
    '    btnReportes.BackColor = Color.Gray ' Color de fondo del botón
    '    btnReportes.ForeColor = Color.White ' Color de letras del botón
    '    AddHandler btnReportes.Click, AddressOf btnReportes_Click
    '    Me.Controls.Add(btnReportes)

    '    ' Botón para Salir
    '    Dim btnSalir As New Button()
    '    btnSalir.Text = "Salir"
    '    btnSalir.Size = New Size(200, 50) ' Tamaño del botón
    '    btnSalir.Location = New Point((Me.ClientSize.Width - btnSalir.Width) / 2, 360) ' Centrar el botón
    '    btnSalir.BackColor = Color.Red ' Color de fondo del botón
    '    btnSalir.ForeColor = Color.White ' Color de letras del botón
    '    AddHandler btnSalir.Click, AddressOf btnSalir_Click
    '    Me.Controls.Add(btnSalir)
    'End Sub





    Private Sub btnProductos_Click(sender As Object, e As EventArgs)
        Dim frmProductos As New FormProductos()
        frmProductos.Show()
    End Sub



    Private Sub FormInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
End Class
