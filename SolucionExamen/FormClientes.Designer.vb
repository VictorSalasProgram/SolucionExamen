<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormClientes))
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.txtBuscadorClientes = New System.Windows.Forms.TextBox()
        Me.btnEliminarCliente = New System.Windows.Forms.Button()
        Me.pnlAggCliente = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelaAgg = New System.Windows.Forms.Button()
        Me.btnAgg = New System.Windows.Forms.Button()
        Me.txtTelefonoCliente = New System.Windows.Forms.TextBox()
        Me.txtCorreoCliente = New System.Windows.Forms.TextBox()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.pnlModificarCliente = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCancelarModificacion = New System.Windows.Forms.Button()
        Me.btnModificarCLiente = New System.Windows.Forms.Button()
        Me.txtTelefonoModificar = New System.Windows.Forms.TextBox()
        Me.txtCorreoModificar = New System.Windows.Forms.TextBox()
        Me.txtClienteModificar = New System.Windows.Forms.TextBox()
        Me.bntModificarCliente = New System.Windows.Forms.Button()
        Me.btnAgregarCliente = New System.Windows.Forms.Button()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAggCliente.SuspendLayout()
        Me.pnlModificarCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvClientes
        '
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Location = New System.Drawing.Point(13, 77)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.RowHeadersWidth = 51
        Me.dgvClientes.RowTemplate.Height = 24
        Me.dgvClientes.Size = New System.Drawing.Size(775, 361)
        Me.dgvClientes.TabIndex = 0
        '
        'txtBuscadorClientes
        '
        Me.txtBuscadorClientes.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscadorClientes.Location = New System.Drawing.Point(13, 30)
        Me.txtBuscadorClientes.Name = "txtBuscadorClientes"
        Me.txtBuscadorClientes.Size = New System.Drawing.Size(583, 34)
        Me.txtBuscadorClientes.TabIndex = 1
        '
        'btnEliminarCliente
        '
        Me.btnEliminarCliente.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnEliminarCliente.Enabled = False
        Me.btnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarCliente.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarCliente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEliminarCliente.Location = New System.Drawing.Point(836, 275)
        Me.btnEliminarCliente.Name = "btnEliminarCliente"
        Me.btnEliminarCliente.Size = New System.Drawing.Size(191, 63)
        Me.btnEliminarCliente.TabIndex = 4
        Me.btnEliminarCliente.Text = "Eliminar"
        Me.btnEliminarCliente.UseVisualStyleBackColor = False
        '
        'pnlAggCliente
        '
        Me.pnlAggCliente.Controls.Add(Me.Label4)
        Me.pnlAggCliente.Controls.Add(Me.Label3)
        Me.pnlAggCliente.Controls.Add(Me.Label2)
        Me.pnlAggCliente.Controls.Add(Me.Label1)
        Me.pnlAggCliente.Controls.Add(Me.btnCancelaAgg)
        Me.pnlAggCliente.Controls.Add(Me.btnAgg)
        Me.pnlAggCliente.Controls.Add(Me.txtTelefonoCliente)
        Me.pnlAggCliente.Controls.Add(Me.txtCorreoCliente)
        Me.pnlAggCliente.Controls.Add(Me.txtNombreCliente)
        Me.pnlAggCliente.Location = New System.Drawing.Point(150, 47)
        Me.pnlAggCliente.Name = "pnlAggCliente"
        Me.pnlAggCliente.Size = New System.Drawing.Size(546, 312)
        Me.pnlAggCliente.TabIndex = 5
        Me.pnlAggCliente.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(192, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 27)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Agrega cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 27)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Telefono:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 27)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Correo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 27)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Cliente:"
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
        'txtTelefonoCliente
        '
        Me.txtTelefonoCliente.Location = New System.Drawing.Point(272, 183)
        Me.txtTelefonoCliente.Name = "txtTelefonoCliente"
        Me.txtTelefonoCliente.Size = New System.Drawing.Size(219, 22)
        Me.txtTelefonoCliente.TabIndex = 2
        '
        'txtCorreoCliente
        '
        Me.txtCorreoCliente.Location = New System.Drawing.Point(272, 124)
        Me.txtCorreoCliente.Name = "txtCorreoCliente"
        Me.txtCorreoCliente.Size = New System.Drawing.Size(219, 22)
        Me.txtCorreoCliente.TabIndex = 1
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(272, 72)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(219, 22)
        Me.txtNombreCliente.TabIndex = 0
        '
        'pnlModificarCliente
        '
        Me.pnlModificarCliente.Controls.Add(Me.Label5)
        Me.pnlModificarCliente.Controls.Add(Me.Label6)
        Me.pnlModificarCliente.Controls.Add(Me.Label7)
        Me.pnlModificarCliente.Controls.Add(Me.Label8)
        Me.pnlModificarCliente.Controls.Add(Me.btnCancelarModificacion)
        Me.pnlModificarCliente.Controls.Add(Me.btnModificarCLiente)
        Me.pnlModificarCliente.Controls.Add(Me.txtTelefonoModificar)
        Me.pnlModificarCliente.Controls.Add(Me.txtCorreoModificar)
        Me.pnlModificarCliente.Controls.Add(Me.txtClienteModificar)
        Me.pnlModificarCliente.Location = New System.Drawing.Point(36, 130)
        Me.pnlModificarCliente.Name = "pnlModificarCliente"
        Me.pnlModificarCliente.Size = New System.Drawing.Size(546, 312)
        Me.pnlModificarCliente.TabIndex = 6
        Me.pnlModificarCliente.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(192, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(220, 27)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Modifica cliente"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(59, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 27)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Telefono:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(59, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 27)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Correo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(59, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 27)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Cliente:"
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
        'btnModificarCLiente
        '
        Me.btnModificarCLiente.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnModificarCLiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarCLiente.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarCLiente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnModificarCLiente.Location = New System.Drawing.Point(112, 242)
        Me.btnModificarCLiente.Name = "btnModificarCLiente"
        Me.btnModificarCLiente.Size = New System.Drawing.Size(157, 36)
        Me.btnModificarCLiente.TabIndex = 6
        Me.btnModificarCLiente.Text = "Modificar"
        Me.btnModificarCLiente.UseVisualStyleBackColor = False
        '
        'txtTelefonoModificar
        '
        Me.txtTelefonoModificar.Location = New System.Drawing.Point(272, 183)
        Me.txtTelefonoModificar.Name = "txtTelefonoModificar"
        Me.txtTelefonoModificar.Size = New System.Drawing.Size(219, 22)
        Me.txtTelefonoModificar.TabIndex = 2
        '
        'txtCorreoModificar
        '
        Me.txtCorreoModificar.Location = New System.Drawing.Point(272, 124)
        Me.txtCorreoModificar.Name = "txtCorreoModificar"
        Me.txtCorreoModificar.Size = New System.Drawing.Size(219, 22)
        Me.txtCorreoModificar.TabIndex = 1
        '
        'txtClienteModificar
        '
        Me.txtClienteModificar.Location = New System.Drawing.Point(272, 72)
        Me.txtClienteModificar.Name = "txtClienteModificar"
        Me.txtClienteModificar.Size = New System.Drawing.Size(219, 22)
        Me.txtClienteModificar.TabIndex = 0
        '
        'bntModificarCliente
        '
        Me.bntModificarCliente.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.bntModificarCliente.Enabled = False
        Me.bntModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bntModificarCliente.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntModificarCliente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bntModificarCliente.Location = New System.Drawing.Point(836, 173)
        Me.bntModificarCliente.Name = "bntModificarCliente"
        Me.bntModificarCliente.Size = New System.Drawing.Size(191, 63)
        Me.bntModificarCliente.TabIndex = 3
        Me.bntModificarCliente.Text = "Modificar"
        Me.bntModificarCliente.UseVisualStyleBackColor = False
        '
        'btnAgregarCliente
        '
        Me.btnAgregarCliente.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarCliente.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCliente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAgregarCliente.Location = New System.Drawing.Point(836, 77)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(191, 63)
        Me.btnAgregarCliente.TabIndex = 2
        Me.btnAgregarCliente.Text = "Agregar"
        Me.btnAgregarCliente.UseVisualStyleBackColor = False
        '
        'FormClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 454)
        Me.Controls.Add(Me.pnlModificarCliente)
        Me.Controls.Add(Me.pnlAggCliente)
        Me.Controls.Add(Me.btnEliminarCliente)
        Me.Controls.Add(Me.bntModificarCliente)
        Me.Controls.Add(Me.btnAgregarCliente)
        Me.Controls.Add(Me.txtBuscadorClientes)
        Me.Controls.Add(Me.dgvClientes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormClientes"
        Me.Text = "Clientes"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAggCliente.ResumeLayout(False)
        Me.pnlAggCliente.PerformLayout()
        Me.pnlModificarCliente.ResumeLayout(False)
        Me.pnlModificarCliente.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents txtBuscadorClientes As TextBox
    Friend WithEvents btnAgregarCliente As Button
    Friend WithEvents bntModificarCliente As Button
    Friend WithEvents btnEliminarCliente As Button
    Friend WithEvents pnlAggCliente As Panel
    Friend WithEvents btnCancelaAgg As Button
    Friend WithEvents btnAgg As Button
    Friend WithEvents txtTelefonoCliente As TextBox
    Friend WithEvents txtCorreoCliente As TextBox
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pnlModificarCliente As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCancelarModificacion As Button
    Friend WithEvents btnModificarCLiente As Button
    Friend WithEvents txtTelefonoModificar As TextBox
    Friend WithEvents txtCorreoModificar As TextBox
    Friend WithEvents txtClienteModificar As TextBox
End Class
