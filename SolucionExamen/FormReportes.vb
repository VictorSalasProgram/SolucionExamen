Imports Microsoft.Reporting.WinForms
Imports SolucionExamen.Entidades


Public Class FormReportes


    Private Sub FormReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load


    End Sub
End Class
