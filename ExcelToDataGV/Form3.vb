Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtFinal As New DataTable
        dtFinal = Compautos.newDt.Copy()
        lblDescuento.Hide()
        lblCodigo.Text = Compautos.codigo
        lblNombre.Text = Compautos.nombre
        lblDepartamento.Text = dtFinal(0)("departamento").ToString
        lblSueldoNum.Text = dtFinal(0)("sueldoDiario").ToString
        lblPromedioNum.Text = Compautos.totalProm

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub txtFaltas_TextChanged(sender As Object, e As EventArgs) Handles txtFaltas.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblDescuento.Text = ((Double.Parse(txtFaltas.Text)) * (Double.Parse(lblPromedioNum.Text))) - ((Double.Parse(lblSueldoNum.Text) * (Double.Parse(txtFaltas.Text))))
        lblDescuento.Show()
    End Sub
End Class