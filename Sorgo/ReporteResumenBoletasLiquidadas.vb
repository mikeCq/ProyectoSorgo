Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class ReporteResumenBoletasLiquidadas
    Private Sub ReporteResumenBoletasLiquidadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RptBoletasLiq As New ReporteLiquidacionResumen
        Dim codigo As String = liquidacionCalculosProd.codigoLiquidacionTP
        RptBoletasLiq.SetDatabaseLogon("sa", "Usuario01", "SERVER2008\SERVER12", "SORGO")
        RptBoletasLiq.SetParameterValue("@idliquidacionTotal", codigo)
        CrResumenBoletas.ReportSource = RptBoletasLiq
    End Sub

    Private Sub CrResumenBoletas_Load(sender As Object, e As EventArgs) Handles CrResumenBoletas.Load

    End Sub
End Class