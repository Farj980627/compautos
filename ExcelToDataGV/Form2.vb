Imports itextsharp.text.pdf
Imports itextsharp.text
Imports System.IO
Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtFinal As New DataTable
        dtFinal = Compautos.newDt.Copy()
        dtFinal.Columns.Remove("Codigo")
        dtFinal.Columns.Remove("nombre")
        dtFinal.Columns.Remove("departamento")
        dtFinal.Columns.Remove("sueldo")
        dtFinal.Columns.Remove("otrasPercepciones")
        dtFinal.Columns.Remove("compensasion")
        dtFinal.Columns.Remove("destajos")
        dtFinal.Columns.Remove("destajo")
        dtFinal.Columns.Remove("comisiones")
        dtFinal.Columns.Remove("vacacionesTiempo")
        dtFinal.Columns.Remove("vacacionesReportadas")
        dtFinal.Columns.Remove("comisionSeminuevos")
        dtFinal.Columns.Remove("comisionUsados")
        dtFinal.Columns.Remove("comisionAltaGama")
        dtFinal.Columns.Remove("comisionProshop")
        dtFinal.Columns.Remove("comisionSicrea")
        dtFinal.Columns.Remove("comisionRefacciones")
        dtFinal.Columns.Remove("comisionServicio")
        dtFinal.Columns.Remove("comisionHyP")
        dtFinal.Columns.Remove("bonificacion")
        dGV1.DataSource = dtFinal
        dGV1.Columns(1).HeaderText = "Dias"
        dGV1.Columns(0).HeaderText = "Periodo"
        dGV1.Columns(1).Name = "Dias"
        dGV1.Columns(0).Name = "Periodo"
        lblCodigo.Text = Compautos.codigo
        lblNombre.Text = Compautos.nombre
        lblDias.Text = "Total de Días: " & Compautos.totalDias
        lblPromedio.Text = "Promedio total: $" & Compautos.totalProm
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s As String = Compautos.codigo & " " & Compautos.nombre
        Dim doc As Document = New Document(PageSize.LETTER)
        Dim user As String = Environment.UserName
        Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New System.IO.FileStream("C:\Users\" & user & "\Desktop\" & s & ".pdf", System.IO.FileMode.Create))
        doc.AddTitle("Informacion " & s)
        doc.AddCreator("compautos")
        doc.Open()
        doc.Add(New Paragraph("                      COMPAUTOS     Resumen "))
        doc.Add(Chunk.NEWLINE)
        doc.Add(Chunk.NEWLINE)
        doc.Add(Chunk.NEWLINE)
        doc.Add(New Paragraph(Compautos.codigo & "           " & Compautos.nombre))
        doc.Add(Chunk.NEWLINE)
        Dim _standardFont As iTextSharp.text.Font = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 48, iTextSharp.text.Font.ITALIC, BaseColor.BLUE)
        Dim table As PdfPTable = New PdfPTable(dGV1.Columns.Count)
        table.WidthPercentage = 100
        For i As Integer = 0 To dGV1.Columns.Count - 1 Step +1
            Dim cell As PdfPCell = New PdfPCell()
            cell.AddElement(New Chunk(dGV1.Columns(i).Name.ToString()))
            cell.BorderWidth = 0
            cell.Colspan = 1
            table.AddCell(cell)
        Next
        For i As Integer = 0 To dGV1.Rows.Count - 2 Step +1
            For j As Integer = 0 To dGV1.Columns.Count - 1 Step +1
                Dim cell As PdfPCell = New PdfPCell()
                cell.AddElement(New Chunk(dGV1.Rows(i).Cells(j).Value.ToString()))
                cell.BorderColor = BaseColor.BLACK
                cell.BorderWidth = 0
                table.AddCell(cell)
            Next
        Next
        doc.Add(table)
        doc.Add(Chunk.NEWLINE)
        doc.Add(Chunk.NEWLINE)
        doc.Add(Chunk.NEWLINE)
        doc.Add(New Paragraph("Dias Totales :" & Compautos.totalDias & "                   " & "Promedio General: $" & Compautos.totalProm))
        doc.Close()
        writer.Close()
        MessageBox.Show("¡PDF generado correctamente!")
    End Sub
End Class