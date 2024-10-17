<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVentasItems
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvVentasItems = New System.Windows.Forms.DataGridView()
        Me.btnEliminarCliente = New System.Windows.Forms.Button()
        Me.bntModificarVentasItems = New System.Windows.Forms.Button()
        Me.btnAgregarVenta = New System.Windows.Forms.Button()
        Me.txtBuscadorVentasItems = New System.Windows.Forms.TextBox()
        Me.pnlAggVentaItems = New System.Windows.Forms.Panel()
        Me.txtNroVenta = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbProductos = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelaAgg = New System.Windows.Forms.Button()
        Me.btnAgg = New System.Windows.Forms.Button()
        Me.txtPrecioTotal = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtPrecioUnitario = New System.Windows.Forms.TextBox()
        Me.pnlModificarVentaItem = New System.Windows.Forms.Panel()
        Me.txtNroVentaModificar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtClienteModificar = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbProductoModificar = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPrecioTotalModificar = New System.Windows.Forms.TextBox()
        Me.txtCantidadModificar = New System.Windows.Forms.TextBox()
        Me.txtPrecioUnitarioModificar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnModificarVenta = New System.Windows.Forms.Button()
        CType(Me.dgvVentasItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAggVentaItems.SuspendLayout()
        Me.pnlModificarVentaItem.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvVentasItems
        '
        Me.dgvVentasItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentasItems.Location = New System.Drawing.Point(12, 97)
        Me.dgvVentasItems.Name = "dgvVentasItems"
        Me.dgvVentasItems.RowHeadersWidth = 51
        Me.dgvVentasItems.RowTemplate.Height = 24
        Me.dgvVentasItems.Size = New System.Drawing.Size(866, 362)
        Me.dgvVentasItems.TabIndex = 0
        '
        'btnEliminarCliente
        '
        Me.btnEliminarCliente.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnEliminarCliente.Enabled = False
        Me.btnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarCliente.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarCliente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEliminarCliente.Location = New System.Drawing.Point(918, 295)
        Me.btnEliminarCliente.Name = "btnEliminarCliente"
        Me.btnEliminarCliente.Size = New System.Drawing.Size(191, 63)
        Me.btnEliminarCliente.TabIndex = 10
        Me.btnEliminarCliente.Text = "Eliminar"
        Me.btnEliminarCliente.UseVisualStyleBackColor = False
        '
        'bntModificarVentasItems
        '
        Me.bntModificarVentasItems.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.bntModificarVentasItems.Enabled = False
        Me.bntModificarVentasItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bntModificarVentasItems.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntModificarVentasItems.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bntModificarVentasItems.Location = New System.Drawing.Point(918, 193)
        Me.bntModificarVentasItems.Name = "bntModificarVentasItems"
        Me.bntModificarVentasItems.Size = New System.Drawing.Size(191, 63)
        Me.bntModificarVentasItems.TabIndex = 9
        Me.bntModificarVentasItems.Text = "Modificar"
        Me.bntModificarVentasItems.UseVisualStyleBackColor = False
        '
        'btnAgregarVenta
        '
        Me.btnAgregarVenta.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnAgregarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarVenta.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarVenta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAgregarVenta.Location = New System.Drawing.Point(918, 97)
        Me.btnAgregarVenta.Name = "btnAgregarVenta"
        Me.btnAgregarVenta.Size = New System.Drawing.Size(191, 63)
        Me.btnAgregarVenta.TabIndex = 8
        Me.btnAgregarVenta.Text = "Agregar"
        Me.btnAgregarVenta.UseVisualStyleBackColor = False
        '
        'txtBuscadorVentasItems
        '
        Me.txtBuscadorVentasItems.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscadorVentasItems.Location = New System.Drawing.Point(12, 37)
        Me.txtBuscadorVentasItems.Name = "txtBuscadorVentasItems"
        Me.txtBuscadorVentasItems.Size = New System.Drawing.Size(866, 34)
        Me.txtBuscadorVentasItems.TabIndex = 11
        '
        'pnlAggVentaItems
        '
        Me.pnlAggVentaItems.Controls.Add(Me.txtNroVenta)
        Me.pnlAggVentaItems.Controls.Add(Me.Label11)
        Me.pnlAggVentaItems.Controls.Add(Me.txtCliente)
        Me.pnlAggVentaItems.Controls.Add(Me.Label10)
        Me.pnlAggVentaItems.Controls.Add(Me.cmbProductos)
        Me.pnlAggVentaItems.Controls.Add(Me.Label9)
        Me.pnlAggVentaItems.Controls.Add(Me.Label4)
        Me.pnlAggVentaItems.Controls.Add(Me.Label3)
        Me.pnlAggVentaItems.Controls.Add(Me.Label2)
        Me.pnlAggVentaItems.Controls.Add(Me.Label1)
        Me.pnlAggVentaItems.Controls.Add(Me.btnCancelaAgg)
        Me.pnlAggVentaItems.Controls.Add(Me.btnAgg)
        Me.pnlAggVentaItems.Controls.Add(Me.txtPrecioTotal)
        Me.pnlAggVentaItems.Controls.Add(Me.txtCantidad)
        Me.pnlAggVentaItems.Controls.Add(Me.txtPrecioUnitario)
        Me.pnlAggVentaItems.Location = New System.Drawing.Point(102, 12)
        Me.pnlAggVentaItems.Name = "pnlAggVentaItems"
        Me.pnlAggVentaItems.Size = New System.Drawing.Size(576, 435)
        Me.pnlAggVentaItems.TabIndex = 12
        Me.pnlAggVentaItems.Visible = False
        '
        'txtNroVenta
        '
        Me.txtNroVenta.Location = New System.Drawing.Point(285, 70)
        Me.txtNroVenta.Name = "txtNroVenta"
        Me.txtNroVenta.Size = New System.Drawing.Size(219, 22)
        Me.txtNroVenta.TabIndex = 20
        Me.txtNroVenta.Text = "0"
        Me.txtNroVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(69, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 27)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Cliente"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(282, 116)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(219, 22)
        Me.txtCliente.TabIndex = 18
        Me.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(69, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(181, 27)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Nro de Venta:"
        '
        'cmbProductos
        '
        Me.cmbProductos.Font = New System.Drawing.Font("Consolas", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProductos.FormattingEnabled = True
        Me.cmbProductos.Location = New System.Drawing.Point(285, 163)
        Me.cmbProductos.Name = "cmbProductos"
        Me.cmbProductos.Size = New System.Drawing.Size(216, 30)
        Me.cmbProductos.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(69, 163)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(129, 27)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Producto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(150, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(285, 27)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Agrega venta de Items"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(69, 319)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 27)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(69, 260)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 27)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Cantidad:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 27)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Precio Unitario:"
        '
        'btnCancelaAgg
        '
        Me.btnCancelaAgg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnCancelaAgg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelaAgg.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelaAgg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancelaAgg.Location = New System.Drawing.Point(285, 383)
        Me.btnCancelaAgg.Name = "btnCancelaAgg"
        Me.btnCancelaAgg.Size = New System.Drawing.Size(135, 36)
        Me.btnCancelaAgg.TabIndex = 7
        Me.btnCancelaAgg.Text = "Cancelar"
        Me.btnCancelaAgg.UseVisualStyleBackColor = False
        '
        'btnAgg
        '
        Me.btnAgg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnAgg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgg.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAgg.Location = New System.Drawing.Point(122, 383)
        Me.btnAgg.Name = "btnAgg"
        Me.btnAgg.Size = New System.Drawing.Size(135, 36)
        Me.btnAgg.TabIndex = 6
        Me.btnAgg.Text = "Agregar"
        Me.btnAgg.UseVisualStyleBackColor = False
        '
        'txtPrecioTotal
        '
        Me.txtPrecioTotal.Location = New System.Drawing.Point(282, 324)
        Me.txtPrecioTotal.Name = "txtPrecioTotal"
        Me.txtPrecioTotal.ReadOnly = True
        Me.txtPrecioTotal.Size = New System.Drawing.Size(219, 22)
        Me.txtPrecioTotal.TabIndex = 2
        Me.txtPrecioTotal.Text = "0"
        Me.txtPrecioTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(282, 265)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(219, 22)
        Me.txtCantidad.TabIndex = 1
        Me.txtCantidad.Text = "0"
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPrecioUnitario
        '
        Me.txtPrecioUnitario.Location = New System.Drawing.Point(282, 213)
        Me.txtPrecioUnitario.Name = "txtPrecioUnitario"
        Me.txtPrecioUnitario.Size = New System.Drawing.Size(219, 22)
        Me.txtPrecioUnitario.TabIndex = 0
        Me.txtPrecioUnitario.Text = "0"
        Me.txtPrecioUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlModificarVentaItem
        '
        Me.pnlModificarVentaItem.Controls.Add(Me.txtNroVentaModificar)
        Me.pnlModificarVentaItem.Controls.Add(Me.Label6)
        Me.pnlModificarVentaItem.Controls.Add(Me.txtClienteModificar)
        Me.pnlModificarVentaItem.Controls.Add(Me.Label7)
        Me.pnlModificarVentaItem.Controls.Add(Me.cmbProductoModificar)
        Me.pnlModificarVentaItem.Controls.Add(Me.Label8)
        Me.pnlModificarVentaItem.Controls.Add(Me.Label12)
        Me.pnlModificarVentaItem.Controls.Add(Me.Label13)
        Me.pnlModificarVentaItem.Controls.Add(Me.Label14)
        Me.pnlModificarVentaItem.Controls.Add(Me.txtPrecioTotalModificar)
        Me.pnlModificarVentaItem.Controls.Add(Me.txtCantidadModificar)
        Me.pnlModificarVentaItem.Controls.Add(Me.txtPrecioUnitarioModificar)
        Me.pnlModificarVentaItem.Controls.Add(Me.Label5)
        Me.pnlModificarVentaItem.Controls.Add(Me.Button1)
        Me.pnlModificarVentaItem.Controls.Add(Me.btnModificarVenta)
        Me.pnlModificarVentaItem.Location = New System.Drawing.Point(34, 82)
        Me.pnlModificarVentaItem.Name = "pnlModificarVentaItem"
        Me.pnlModificarVentaItem.Size = New System.Drawing.Size(537, 471)
        Me.pnlModificarVentaItem.TabIndex = 13
        Me.pnlModificarVentaItem.Visible = False
        '
        'txtNroVentaModificar
        '
        Me.txtNroVentaModificar.Location = New System.Drawing.Point(256, 89)
        Me.txtNroVentaModificar.Name = "txtNroVentaModificar"
        Me.txtNroVentaModificar.Size = New System.Drawing.Size(219, 22)
        Me.txtNroVentaModificar.TabIndex = 32
        Me.txtNroVentaModificar.Text = "0"
        Me.txtNroVentaModificar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 27)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Cliente"
        '
        'txtClienteModificar
        '
        Me.txtClienteModificar.Location = New System.Drawing.Point(253, 135)
        Me.txtClienteModificar.Name = "txtClienteModificar"
        Me.txtClienteModificar.ReadOnly = True
        Me.txtClienteModificar.Size = New System.Drawing.Size(219, 22)
        Me.txtClienteModificar.TabIndex = 30
        Me.txtClienteModificar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(40, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 27)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Nro de Venta:"
        '
        'cmbProductoModificar
        '
        Me.cmbProductoModificar.Font = New System.Drawing.Font("Consolas", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProductoModificar.FormattingEnabled = True
        Me.cmbProductoModificar.Location = New System.Drawing.Point(256, 182)
        Me.cmbProductoModificar.Name = "cmbProductoModificar"
        Me.cmbProductoModificar.Size = New System.Drawing.Size(216, 30)
        Me.cmbProductoModificar.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(40, 182)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 27)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Producto:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(40, 338)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 27)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Total:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(40, 279)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 27)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Cantidad:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(40, 232)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(220, 27)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Precio Unitario:"
        '
        'txtPrecioTotalModificar
        '
        Me.txtPrecioTotalModificar.Location = New System.Drawing.Point(253, 343)
        Me.txtPrecioTotalModificar.Name = "txtPrecioTotalModificar"
        Me.txtPrecioTotalModificar.ReadOnly = True
        Me.txtPrecioTotalModificar.Size = New System.Drawing.Size(219, 22)
        Me.txtPrecioTotalModificar.TabIndex = 23
        Me.txtPrecioTotalModificar.Text = "0"
        Me.txtPrecioTotalModificar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCantidadModificar
        '
        Me.txtCantidadModificar.Location = New System.Drawing.Point(253, 284)
        Me.txtCantidadModificar.Name = "txtCantidadModificar"
        Me.txtCantidadModificar.Size = New System.Drawing.Size(219, 22)
        Me.txtCantidadModificar.TabIndex = 22
        Me.txtCantidadModificar.Text = "0"
        Me.txtCantidadModificar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPrecioUnitarioModificar
        '
        Me.txtPrecioUnitarioModificar.Location = New System.Drawing.Point(253, 232)
        Me.txtPrecioUnitarioModificar.Name = "txtPrecioUnitarioModificar"
        Me.txtPrecioUnitarioModificar.ReadOnly = True
        Me.txtPrecioUnitarioModificar.Size = New System.Drawing.Size(219, 22)
        Me.txtPrecioUnitarioModificar.TabIndex = 21
        Me.txtPrecioUnitarioModificar.Text = "0"
        Me.txtPrecioUnitarioModificar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(180, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(207, 27)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Modificar Venta"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(265, 402)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 36)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnModificarVenta
        '
        Me.btnModificarVenta.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnModificarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarVenta.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarVenta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnModificarVenta.Location = New System.Drawing.Point(102, 402)
        Me.btnModificarVenta.Name = "btnModificarVenta"
        Me.btnModificarVenta.Size = New System.Drawing.Size(135, 36)
        Me.btnModificarVenta.TabIndex = 6
        Me.btnModificarVenta.Text = "Agregar"
        Me.btnModificarVenta.UseVisualStyleBackColor = False
        '
        'FormVentasItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1233, 596)
        Me.Controls.Add(Me.pnlModificarVentaItem)
        Me.Controls.Add(Me.pnlAggVentaItems)
        Me.Controls.Add(Me.txtBuscadorVentasItems)
        Me.Controls.Add(Me.btnEliminarCliente)
        Me.Controls.Add(Me.bntModificarVentasItems)
        Me.Controls.Add(Me.btnAgregarVenta)
        Me.Controls.Add(Me.dgvVentasItems)
        Me.Name = "FormVentasItems"
        Me.Text = "FormVentasItems"
        CType(Me.dgvVentasItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAggVentaItems.ResumeLayout(False)
        Me.pnlAggVentaItems.PerformLayout()
        Me.pnlModificarVentaItem.ResumeLayout(False)
        Me.pnlModificarVentaItem.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvVentasItems As DataGridView
    Friend WithEvents btnEliminarCliente As Button
    Friend WithEvents bntModificarVentasItems As Button
    Friend WithEvents btnAgregarVenta As Button
    Friend WithEvents txtBuscadorVentasItems As TextBox
    Friend WithEvents pnlAggVentaItems As Panel
    Friend WithEvents pnlModificarVentaItem As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnModificarVenta As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancelaAgg As Button
    Friend WithEvents btnAgg As Button
    Friend WithEvents txtPrecioTotal As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtPrecioUnitario As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbProductos As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents txtNroVenta As TextBox
    Friend WithEvents txtNroVentaModificar As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtClienteModificar As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbProductoModificar As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtPrecioTotalModificar As TextBox
    Friend WithEvents txtCantidadModificar As TextBox
    Friend WithEvents txtPrecioUnitarioModificar As TextBox
End Class
