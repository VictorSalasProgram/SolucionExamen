<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormReportes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReportes))
        Me.PruebademoDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PruebademoDataSet = New SolucionExamen.pruebademoDataSet()
        Me.PruebademoDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.productosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PruebademoDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PruebademoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PruebademoDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PruebademoDataSetBindingSource1
        '
        Me.PruebademoDataSetBindingSource1.DataSource = Me.PruebademoDataSet
        Me.PruebademoDataSetBindingSource1.Position = 0
        '
        'PruebademoDataSet
        '
        Me.PruebademoDataSet.DataSetName = "pruebademoDataSet"
        Me.PruebademoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PruebademoDataSetBindingSource
        '
        Me.PruebademoDataSetBindingSource.DataSource = Me.PruebademoDataSet
        Me.PruebademoDataSetBindingSource.Position = 0
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.PruebademoDataSetBindingSource1
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SolucionExamen.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(693, 493)
        Me.ReportViewer1.TabIndex = 0
        '
        'productosBindingSource
        '
        Me.productosBindingSource.DataMember = "productos"
        Me.productosBindingSource.DataSource = Me.PruebademoDataSet
        '
        'FormReportes
        '
        Me.ClientSize = New System.Drawing.Size(693, 493)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormReportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        CType(Me.PruebademoDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PruebademoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PruebademoDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PruebademoDataSetBindingSource As BindingSource
    Friend WithEvents PruebademoDataSet As pruebademoDataSet
    Friend WithEvents PruebademoDataSetBindingSource1 As BindingSource
    Friend WithEvents productosBindingSource As BindingSource
End Class
