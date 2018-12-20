Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCodigo.Text = Compautos.codigo
        lblNombre.Text = Compautos.nombre
        dGV1.DataSource = Compautos.newDt
        dGV1.Columns(4).HeaderText = "Dias"
        dGV1.Columns(0).HeaderText = "Periodo"
        lblDias.Text = "Total de Dias: " & Compautos.totalDias
        lblPromedio.Text = "Promedio total: " & Compautos.totalProm
        dGV1.Columns(1).Visible = False
        dGV1.Columns(2).Visible = False
        dGV1.Columns(3).Visible = False
        dGV1.Columns(5).Visible = False
        dGV1.Columns(6).Visible = False
        dGV1.Columns(7).Visible = False
        dGV1.Columns(8).Visible = False
        dGV1.Columns(9).Visible = False
        dGV1.Columns(10).Visible = False
        dGV1.Columns(11).Visible = False
        dGV1.Columns(12).Visible = False
        dGV1.Columns(13).Visible = False
        dGV1.Columns(14).Visible = False
        dGV1.Columns(15).Visible = False
        dGV1.Columns(16).Visible = False
        dGV1.Columns(17).Visible = False
        dGV1.Columns(18).Visible = False
        dGV1.Columns(19).Visible = False
        dGV1.Columns(20).Visible = False
        dGV1.Columns(21).Visible = False



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()

    End Sub
End Class