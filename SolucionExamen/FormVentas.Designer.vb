<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVentas
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
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.btnEliminarVenta = New System.Windows.Forms.Button()
        Me.bntModificarVenta = New System.Windows.Forms.Button()
        Me.btnAgregarVenta = New System.Windows.Forms.Button()
        Me.txtBuscadorVentas = New System.Windows.Forms.TextBox()
        Me.pnlAggVenta = New System.Windows.Forms.Panel()
        Me.dtpFechaVenta = New System.Windows.Forms.DateTimePicker()
        Me.cmbClientes = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelaAgg = New System.Windows.Forms.Button()
        Me.btnAggVenta = New System.Windows.Forms.Button()
        Me.txtTotalVenta = New System.Windows.Forms.TextBox()
        Me.pnlModificarVenta = New System.Windows.Forms.Panel()
        Me.dtpFechaVentaModificar = New System.Windows.Forms.DateTimePicker()
        Me.cmbClienteModificar = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnModificarVenta = New System.Windows.Forms.Button()
        Me.txtTotalModificar = New System.Windows.Forms.TextBox()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAggVenta.SuspendLayout()
        Me.pnlModificarVenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvVentas
        '
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Location = New System.Drawing.Point(44, 95)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.RowHeadersWidth = 51
        Me.dgvVentas.RowTemplate.Height = 24
        Me.dgvVentas.Size = New System.Drawing.Size(775, 326)
        Me.dgvVentas.TabIndex = 0
        '
        'btnEliminarVenta
        '
        Me.btnEliminarVenta.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnEliminarVenta.Enabled = False
        Me.btnEliminarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarVenta.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarVenta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEliminarVenta.Location = New System.Drawing.Point(900, 293)
        Me.btnEliminarVenta.Name = "btnEliminarVenta"
        Me.btnEliminarVenta.Size = New System.Drawing.Size(191, 63)
        Me.btnEliminarVenta.TabIndex = 7
        Me.btnEliminarVenta.Text = "Eliminar"
        Me.btnEliminarVenta.UseVisualStyleBackColor = False
        '
        'bntModificarVenta
        '
        Me.bntModificarVenta.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.bntModificarVenta.Enabled = False
        Me.bntModificarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bntModificarVenta.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntModificarVenta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bntModificarVenta.Location = New System.Drawing.Point(900, 191)
        Me.bntModificarVenta.Name = "bntModificarVenta"
        Me.bntModificarVenta.Size = New System.Drawing.Size(191, 63)
        Me.bntModificarVenta.TabIndex = 6
        Me.bntModificarVenta.Text = "Modificar"
        Me.bntModificarVenta.UseVisualStyleBackColor = False
        '
        'btnAgregarVenta
        '
        Me.btnAgregarVenta.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnAgregarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarVenta.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarVenta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAgregarVenta.Location = New System.Drawing.Point(900, 95)
        Me.btnAgregarVenta.Name = "btnAgregarVenta"
        Me.btnAgregarVenta.Size = New System.Drawing.Size(191, 63)
        Me.btnAgregarVenta.TabIndex = 5
        Me.btnAgregarVenta.Text = "Agregar"
        Me.btnAgregarVenta.UseVisualStyleBackColor = False
        '
        'txtBuscadorVentas
        '
        Me.txtBuscadorVentas.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscadorVentas.Location = New System.Drawing.Point(44, 39)
        Me.txtBuscadorVentas.Name = "txtBuscadorVentas"
        Me.txtBuscadorVentas.Size = New System.Drawing.Size(583, 34)
        Me.txtBuscadorVentas.TabIndex = 8
        '
        'pnlAggVenta
        '
        Me.pnlAggVenta.Controls.Add(Me.dtpFechaVenta)
        Me.pnlAggVenta.Controls.Add(Me.cmbClientes)
        Me.pnlAggVenta.Controls.Add(Me.Label4)
        Me.pnlAggVenta.Controls.Add(Me.Label3)
        Me.pnlAggVenta.Controls.Add(Me.Label2)
        Me.pnlAggVenta.Controls.Add(Me.Label1)
        Me.pnlAggVenta.Controls.Add(Me.btnCancelaAgg)
        Me.pnlAggVenta.Controls.Add(Me.btnAggVenta)
        Me.pnlAggVenta.Controls.Add(Me.txtTotalVenta)
        Me.pnlAggVenta.Location = New System.Drawing.Point(59, 79)
        Me.pnlAggVenta.Name = "pnlAggVenta"
        Me.pnlAggVenta.Size = New System.Drawing.Size(546, 312)
        Me.pnlAggVenta.TabIndex = 10
        Me.pnlAggVenta.Visible = False
        '
        'dtpFechaVenta
        '
        Me.dtpFechaVenta.Font = New System.Drawing.Font("Consolas", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaVenta.Location = New System.Drawing.Point(239, 119)
        Me.dtpFechaVenta.Name = "dtpFechaVenta"
        Me.dtpFechaVenta.Size = New System.Drawing.Size(200, 29)
        Me.dtpFechaVenta.TabIndex = 13
        '
        'cmbClientes
        '
        Me.cmbClientes.Font = New System.Drawing.Font("Consolas", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClientes.FormattingEnabled = True
        Me.cmbClientes.Location = New System.Drawing.Point(239, 66)
        Me.cmbClientes.Name = "cmbClientes"
        Me.cmbClientes.Size = New System.Drawing.Size(216, 30)
        Me.cmbClientes.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(192, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 27)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Agregar Venta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(59, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 27)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 27)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Fecha:"
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
        'btnAggVenta
        '
        Me.btnAggVenta.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btnAggVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAggVenta.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAggVenta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAggVenta.Location = New System.Drawing.Point(112, 242)
        Me.btnAggVenta.Name = "btnAggVenta"
        Me.btnAggVenta.Size = New System.Drawing.Size(135, 36)
        Me.btnAggVenta.TabIndex = 6
        Me.btnAggVenta.Text = "Agregar"
        Me.btnAggVenta.UseVisualStyleBackColor = False
        '
        'txtTotalVenta
        '
        Me.txtTotalVenta.Location = New System.Drawing.Point(241, 178)
        Me.txtTotalVenta.Name = "txtTotalVenta"
        Me.txtTotalVenta.Size = New System.Drawing.Size(219, 22)
        Me.txtTotalVenta.TabIndex = 2
        '
        'pnlModificarVenta
        '
        Me.pnlModificarVenta.Controls.Add(Me.dtpFechaVentaModificar)
        Me.pnlModificarVenta.Controls.Add(Me.cmbClienteModificar)
        Me.pnlModificarVenta.Controls.Add(Me.Label5)
        Me.pnlModificarVenta.Controls.Add(Me.Label6)
        Me.pnlModificarVenta.Controls.Add(Me.Label7)
        Me.pnlModificarVenta.Controls.Add(Me.Label8)
        Me.pnlModificarVenta.Controls.Add(Me.Button1)
        Me.pnlModificarVenta.Controls.Add(Me.btnModificarVenta)
        Me.pnlModificarVenta.Controls.Add(Me.txtTotalModificar)
        Me.pnlModificarVenta.Location = New System.Drawing.Point(487, 12)
        Me.pnlModificarVenta.Name = "pnlModificarVenta"
        Me.pnlModificarVenta.Size = New System.Drawing.Size(546, 312)
        Me.pnlModificarVenta.TabIndex = 11
        Me.pnlModificarVenta.Visible = False
        '
        'dtpFechaVentaModificar
        '
        Me.dtpFechaVentaModificar.Font = New System.Drawing.Font("Consolas", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaVentaModificar.Location = New System.Drawing.Point(272, 119)
        Me.dtpFechaVentaModificar.Name = "dtpFechaVentaModificar"
        Me.dtpFechaVentaModificar.Size = New System.Drawing.Size(200, 29)
        Me.dtpFechaVentaModificar.TabIndex = 14
        '
        'cmbClienteModificar
        '
        Me.cmbClienteModificar.Font = New System.Drawing.Font("Consolas", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClienteModificar.FormattingEnabled = True
        Me.cmbClienteModificar.Location = New System.Drawing.Point(272, 67)
        Me.cmbClienteModificar.Name = "cmbClienteModificar"
        Me.cmbClienteModificar.Size = New System.Drawing.Size(216, 30)
        Me.cmbClienteModificar.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(192, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(207, 27)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Modificar Venta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(59, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 27)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Total:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(59, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 27)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Fecha:"
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Consolas", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(275, 242)
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
        Me.btnModificarVenta.Location = New System.Drawing.Point(112, 242)
        Me.btnModificarVenta.Name = "btnModificarVenta"
        Me.btnModificarVenta.Size = New System.Drawing.Size(141, 36)
        Me.btnModificarVenta.TabIndex = 6
        Me.btnModificarVenta.Text = "Modificar"
        Me.btnModificarVenta.UseVisualStyleBackColor = False
        '
        'txtTotalModificar
        '
        Me.txtTotalModificar.Location = New System.Drawing.Point(272, 183)
        Me.txtTotalModificar.Name = "txtTotalModificar"
        Me.txtTotalModificar.Size = New System.Drawing.Size(219, 22)
        Me.txtTotalModificar.TabIndex = 2
        '
        'FormVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 487)
        Me.Controls.Add(Me.pnlModificarVenta)
        Me.Controls.Add(Me.pnlAggVenta)
        Me.Controls.Add(Me.txtBuscadorVentas)
        Me.Controls.Add(Me.btnEliminarVenta)
        Me.Controls.Add(Me.bntModificarVenta)
        Me.Controls.Add(Me.btnAgregarVenta)
        Me.Controls.Add(Me.dgvVentas)
        Me.Name = "FormVentas"
        Me.Text = "FormVentas"
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAggVenta.ResumeLayout(False)
        Me.pnlAggVenta.PerformLayout()
        Me.pnlModificarVenta.ResumeLayout(False)
        Me.pnlModificarVenta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents btnEliminarVenta As Button
    Friend WithEvents bntModificarVenta As Button
    Friend WithEvents btnAgregarVenta As Button
    Friend WithEvents txtBuscadorVentas As TextBox
    Friend WithEvents pnlAggVenta As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancelaAgg As Button
    Friend WithEvents btnAggVenta As Button
    Friend WithEvents txtTotalVenta As TextBox
    Friend WithEvents pnlModificarVenta As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnModificarVenta As Button
    Friend WithEvents txtTotalModificar As TextBox
    Friend WithEvents cmbClientes As ComboBox
    Friend WithEvents dtpFechaVenta As DateTimePicker
    Friend WithEvents dtpFechaVentaModificar As DateTimePicker
    Friend WithEvents cmbClienteModificar As ComboBox
End Class
