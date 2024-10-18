<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProductos))
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.btnEliminarProducto = New System.Windows.Forms.Button()
        Me.bntModificarProducto = New System.Windows.Forms.Button()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.txtBuscadorProducto = New System.Windows.Forms.TextBox()
        Me.pnlAggProducto = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelaAgg = New System.Windows.Forms.Button()
        Me.btnAgg = New System.Windows.Forms.Button()
        Me.txtCategoriaProducto = New System.Windows.Forms.TextBox()
        Me.txtPrecioProducto = New System.Windows.Forms.TextBox()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.pnlModificarProducto = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCancelarModificacion = New System.Windows.Forms.Button()
        Me.btnModificarProducto2 = New System.Windows.Forms.Button()
        Me.txtCategoriaModificar = New System.Windows.Forms.TextBox()
        Me.txtPrecioModificar = New System.Windows.Forms.TextBox()
        Me.txtProductoModificar = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAggProducto.SuspendLayout()
        Me.pnlModificarProducto.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvProductos
        '
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Location = New System.Drawing.Point(114, 119)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.RowHeadersWidth = 51
        Me.dgvProductos.RowTemplate.Height = 24
        Me.dgvProductos.Size = New System.Drawing.Size(472, 327)
        Me.dgvProductos.TabIndex = 0
        '
        'btnEliminarProducto
        '
        Me.btnEliminarProducto.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnEliminarProducto.Enabled = False
        Me.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarProducto.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarProducto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEliminarProducto.Location = New System.Drawing.Point(657, 317)
        Me.btnEliminarProducto.Name = "btnEliminarProducto"
        Me.btnEliminarProducto.Size = New System.Drawing.Size(191, 63)
        Me.btnEliminarProducto.TabIndex = 7
        Me.btnEliminarProducto.Text = "Eliminar"
        Me.btnEliminarProducto.UseVisualStyleBackColor = False
        '
        'bntModificarProducto
        '
        Me.bntModificarProducto.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.bntModificarProducto.Enabled = False
        Me.bntModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bntModificarProducto.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntModificarProducto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bntModificarProducto.Location = New System.Drawing.Point(657, 215)
        Me.bntModificarProducto.Name = "bntModificarProducto"
        Me.bntModificarProducto.Size = New System.Drawing.Size(191, 63)
        Me.bntModificarProducto.TabIndex = 6
        Me.bntModificarProducto.Text = "Modificar"
        Me.bntModificarProducto.UseVisualStyleBackColor = False
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarProducto.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProducto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAgregarProducto.Location = New System.Drawing.Point(657, 119)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(191, 63)
        Me.btnAgregarProducto.TabIndex = 5
        Me.btnAgregarProducto.Text = "Agregar"
        Me.btnAgregarProducto.UseVisualStyleBackColor = False
        '
        'txtBuscadorProducto
        '
        Me.txtBuscadorProducto.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscadorProducto.Location = New System.Drawing.Point(114, 61)
        Me.txtBuscadorProducto.Name = "txtBuscadorProducto"
        Me.txtBuscadorProducto.Size = New System.Drawing.Size(472, 34)
        Me.txtBuscadorProducto.TabIndex = 8
        '
        'pnlAggProducto
        '
        Me.pnlAggProducto.Controls.Add(Me.Label4)
        Me.pnlAggProducto.Controls.Add(Me.Label3)
        Me.pnlAggProducto.Controls.Add(Me.Label2)
        Me.pnlAggProducto.Controls.Add(Me.Label1)
        Me.pnlAggProducto.Controls.Add(Me.btnCancelaAgg)
        Me.pnlAggProducto.Controls.Add(Me.btnAgg)
        Me.pnlAggProducto.Controls.Add(Me.txtCategoriaProducto)
        Me.pnlAggProducto.Controls.Add(Me.txtPrecioProducto)
        Me.pnlAggProducto.Controls.Add(Me.txtNombreProducto)
        Me.pnlAggProducto.Location = New System.Drawing.Point(61, 119)
        Me.pnlAggProducto.Name = "pnlAggProducto"
        Me.pnlAggProducto.Size = New System.Drawing.Size(546, 312)
        Me.pnlAggProducto.TabIndex = 9
        Me.pnlAggProducto.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(192, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 27)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Agrega Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 27)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Categoria:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 27)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Precio:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 27)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombre:"
        '
        'btnCancelaAgg
        '
        Me.btnCancelaAgg.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnCancelaAgg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelaAgg.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelaAgg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancelaAgg.Location = New System.Drawing.Point(275, 242)
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
        Me.btnAgg.Location = New System.Drawing.Point(112, 242)
        Me.btnAgg.Name = "btnAgg"
        Me.btnAgg.Size = New System.Drawing.Size(135, 36)
        Me.btnAgg.TabIndex = 6
        Me.btnAgg.Text = "Agregar"
        Me.btnAgg.UseVisualStyleBackColor = False
        '
        'txtCategoriaProducto
        '
        Me.txtCategoriaProducto.Location = New System.Drawing.Point(272, 183)
        Me.txtCategoriaProducto.Name = "txtCategoriaProducto"
        Me.txtCategoriaProducto.Size = New System.Drawing.Size(219, 22)
        Me.txtCategoriaProducto.TabIndex = 2
        '
        'txtPrecioProducto
        '
        Me.txtPrecioProducto.Location = New System.Drawing.Point(272, 124)
        Me.txtPrecioProducto.Name = "txtPrecioProducto"
        Me.txtPrecioProducto.Size = New System.Drawing.Size(219, 22)
        Me.txtPrecioProducto.TabIndex = 1
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Location = New System.Drawing.Point(272, 72)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(219, 22)
        Me.txtNombreProducto.TabIndex = 0
        '
        'pnlModificarProducto
        '
        Me.pnlModificarProducto.Controls.Add(Me.Label5)
        Me.pnlModificarProducto.Controls.Add(Me.Label6)
        Me.pnlModificarProducto.Controls.Add(Me.Label7)
        Me.pnlModificarProducto.Controls.Add(Me.Label8)
        Me.pnlModificarProducto.Controls.Add(Me.btnCancelarModificacion)
        Me.pnlModificarProducto.Controls.Add(Me.btnModificarProducto2)
        Me.pnlModificarProducto.Controls.Add(Me.txtCategoriaModificar)
        Me.pnlModificarProducto.Controls.Add(Me.txtPrecioModificar)
        Me.pnlModificarProducto.Controls.Add(Me.txtProductoModificar)
        Me.pnlModificarProducto.Location = New System.Drawing.Point(185, 62)
        Me.pnlModificarProducto.Name = "pnlModificarProducto"
        Me.pnlModificarProducto.Size = New System.Drawing.Size(546, 312)
        Me.pnlModificarProducto.TabIndex = 10
        Me.pnlModificarProducto.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(192, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(233, 27)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Modifica Producto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(59, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 27)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Categoria"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(59, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 27)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Precio:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(59, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 27)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Nombre:"
        '
        'btnCancelarModificacion
        '
        Me.btnCancelarModificacion.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnCancelarModificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarModificacion.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarModificacion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancelarModificacion.Location = New System.Drawing.Point(275, 242)
        Me.btnCancelarModificacion.Name = "btnCancelarModificacion"
        Me.btnCancelarModificacion.Size = New System.Drawing.Size(150, 36)
        Me.btnCancelarModificacion.TabIndex = 7
        Me.btnCancelarModificacion.Text = "Cancelar"
        Me.btnCancelarModificacion.UseVisualStyleBackColor = False
        '
        'btnModificarProducto2
        '
        Me.btnModificarProducto2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnModificarProducto2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarProducto2.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarProducto2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnModificarProducto2.Location = New System.Drawing.Point(112, 242)
        Me.btnModificarProducto2.Name = "btnModificarProducto2"
        Me.btnModificarProducto2.Size = New System.Drawing.Size(157, 36)
        Me.btnModificarProducto2.TabIndex = 6
        Me.btnModificarProducto2.Text = "Modificar"
        Me.btnModificarProducto2.UseVisualStyleBackColor = False
        '
        'txtCategoriaModificar
        '
        Me.txtCategoriaModificar.Location = New System.Drawing.Point(272, 183)
        Me.txtCategoriaModificar.Name = "txtCategoriaModificar"
        Me.txtCategoriaModificar.Size = New System.Drawing.Size(219, 22)
        Me.txtCategoriaModificar.TabIndex = 2
        '
        'txtPrecioModificar
        '
        Me.txtPrecioModificar.Location = New System.Drawing.Point(272, 124)
        Me.txtPrecioModificar.Name = "txtPrecioModificar"
        Me.txtPrecioModificar.Size = New System.Drawing.Size(219, 22)
        Me.txtPrecioModificar.TabIndex = 1
        '
        'txtProductoModificar
        '
        Me.txtProductoModificar.Location = New System.Drawing.Point(272, 72)
        Me.txtProductoModificar.Name = "txtProductoModificar"
        Me.txtProductoModificar.Size = New System.Drawing.Size(219, 22)
        Me.txtProductoModificar.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(948, 56)
        Me.Panel1.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(431, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(129, 27)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "PRODUCTOS"
        '
        'FormProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 491)
        Me.Controls.Add(Me.pnlAggProducto)
        Me.Controls.Add(Me.pnlModificarProducto)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtBuscadorProducto)
        Me.Controls.Add(Me.btnEliminarProducto)
        Me.Controls.Add(Me.bntModificarProducto)
        Me.Controls.Add(Me.btnAgregarProducto)
        Me.Controls.Add(Me.dgvProductos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAggProducto.ResumeLayout(False)
        Me.pnlAggProducto.PerformLayout()
        Me.pnlModificarProducto.ResumeLayout(False)
        Me.pnlModificarProducto.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents btnEliminarProducto As Button
    Friend WithEvents bntModificarProducto As Button
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents txtBuscadorProducto As TextBox
    Friend WithEvents pnlAggProducto As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancelaAgg As Button
    Friend WithEvents btnAgg As Button
    Friend WithEvents txtCategoriaProducto As TextBox
    Friend WithEvents txtPrecioProducto As TextBox
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents pnlModificarProducto As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCancelarModificacion As Button
    Friend WithEvents btnModificarProducto2 As Button
    Friend WithEvents txtCategoriaModificar As TextBox
    Friend WithEvents txtPrecioModificar As TextBox
    Friend WithEvents txtProductoModificar As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
End Class
