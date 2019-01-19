Imports System.Data.OleDb
Imports MySql.Data.MySqlClient
Public Class Compautos
    Dim dbconect As conexion
    Dim conn As OleDbConnection
    Dim data As OleDbDataAdapter
    Dim datos As DataSet
    Dim excel As String
    Dim openFile As New OpenFileDialog
    Public Shared mesInicio, mesFin, yearInicio, yearFinal, nombre, periodo, codigo, totalDias, totalProm As String

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim currentIndex As Integer = cbAñoFinal.Items.Count
        Dim currentYear As String = cbAñoFinal.Items(currentIndex - 1).ToString
        Dim newYear As String
        newYear = currentYear + 1
        cbAñoFinal.Items.Add(newYear)
        My.Settings.years.Clear()
        For Each item In cbAñoFinal.Items
            My.Settings.years.Add(item.ToString)
        Next
        My.Settings.Save()
        MsgBox("Año Agregado Correctamente")

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form3.ShowDialog()

    End Sub

    Private Sub cbNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbNombre.SelectedIndexChanged
        TableLayoutPanel2.Hide()
        Button4.Hide()
        Button5.Hide()

    End Sub

    Public Shared newDt As New DataTable

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.ShowDialog()
    End Sub
    'Mostrar el Excel en el dataGrid
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            openFile.InitialDirectory = "C:\"
            openFile.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm"
            If openFile.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                Dim fi As New IO.FileInfo(openFile.FileName)
                Dim FileName As String = openFile.FileName
                excel = fi.FullName
                conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excel + ";Extended Properties=Excel 12.0;")
                data = New OleDbDataAdapter("select * from [Hoja1$]", conn)
                datos = New DataSet
                data.Fill(datos, "[Hoja1$]")
                dtExcel.DataSource = datos
                dtExcel.DataMember = "[Hoja1$]"
                conn.Close()
                If dtExcel.Visible = False Then
                    dtExcel.Visible = True
                    TableLayoutPanel2.Visible = False
                End If
                MsgBox("Archivo Cargado Correctamente")
                MsgBox("Favor de checar que no existan renglones sin datos al final del archivo")
                Button4.Hide()
                Button5.Hide()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    'Insertar el archivo de Excel en la Base de datos
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26 As String
            periodo = dtExcel.Rows(1).Cells(0).Value.ToString
            If conexion.comparar(periodo).Equals(True) Then
                MsgBox("El Periodo ya esta registrado, favor de corregir")
            Else
                For i As Integer = 0 To dtExcel.Rows.Count - 2 Step +1
                    a1 = dtExcel.Rows(i).Cells(0).Value.ToString()
                    a2 = dtExcel.Rows(i).Cells(1).Value.ToString()
                    a3 = dtExcel.Rows(i).Cells(2).Value.ToString()
                    a4 = dtExcel.Rows(i).Cells(3).Value.ToString()
                    a5 = dtExcel.Rows(i).Cells(4).Value.ToString()
                    a6 = dtExcel.Rows(i).Cells(5).Value.ToString()
                    a7 = dtExcel.Rows(i).Cells(6).Value.ToString()
                    a8 = dtExcel.Rows(i).Cells(7).Value.ToString()
                    a9 = dtExcel.Rows(i).Cells(8).Value.ToString()
                    a10 = dtExcel.Rows(i).Cells(9).Value.ToString()
                    a11 = dtExcel.Rows(i).Cells(10).Value.ToString()
                    a12 = dtExcel.Rows(i).Cells(11).Value.ToString()
                    a13 = dtExcel.Rows(i).Cells(12).Value.ToString()
                    a14 = dtExcel.Rows(i).Cells(13).Value.ToString()
                    a15 = dtExcel.Rows(i).Cells(14).Value.ToString()
                    a16 = dtExcel.Rows(i).Cells(15).Value.ToString()
                    a17 = dtExcel.Rows(i).Cells(16).Value.ToString()
                    a18 = dtExcel.Rows(i).Cells(17).Value.ToString()
                    a19 = dtExcel.Rows(i).Cells(18).Value.ToString()
                    a20 = dtExcel.Rows(i).Cells(19).Value.ToString()
                    a21 = dtExcel.Rows(i).Cells(20).Value.ToString()
                    a22 = dtExcel.Rows(i).Cells(21).Value.ToString()
                    a23 = dtExcel.Rows(i).Cells(22).Value.ToString()
                    a24 = dtExcel.Rows(i).Cells(23).Value.ToString()
                    a25 = dtExcel.Rows(i).Cells(24).Value.ToString()
                    a26 = dtExcel.Rows(i).Cells(25).Value.ToString()

                    conexion.addvalue(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26)
                Next
                MsgBox("Datos insertados correctamente")
                cbNombre.DataSource = conexion.getNombres
                cbNombre.DisplayMember = "Nombre"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each i As String In My.Settings.years
            cbAñoFinal.Items.Add(i)
            cbAñoInicial.Items.Add(i)
        Next
        TableLayoutPanel2.Hide()
        Button4.Hide()
        Button5.Hide()
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        cbNombre.DataSource = conexion.getNombres
        cbNombre.DisplayMember = "Nombre"
    End Sub
    'Guardar el intervalo de periodos
    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If cbAñoFinal.SelectedIndex < cbAñoInicial.SelectedIndex Then
                MsgBox("El año final es menor que el año inicial.")
            ElseIf cbAñoFinal.SelectedIndex = cbAñoInicial.SelectedIndex And cbMesFinal.SelectedIndex < cbMesInicial.SelectedIndex Then
                MsgBox("El mes final es menor que el inicial. ")
            ElseIf cbMesInicial.Text = "" Or cbAñoInicial.Text = "" Or cbMesFinal.Text = "" Or cbAñoFinal.Text = "" Then
                MsgBox("Faltan datos para realizar la busqueda ")
                'Busqueda para un mes y año iguales
            ElseIf cbMesInicial.SelectedIndex = cbMesFinal.SelectedIndex And cbAñoInicial.SelectedIndex = cbAñoFinal.SelectedIndex Then

                nombre = cbNombre.Text
                If cbMesInicial.SelectedIndex >= 9 Then
                    mesInicio = cbMesInicial.SelectedIndex + 1
                Else
                    mesInicio = "0" & cbMesInicial.SelectedIndex + 1
                End If
                yearInicio = cbAñoInicial.Text
                Dim ColSuma As New Data.DataColumn("Suma", GetType(System.String))
                Dim ColProm As New Data.DataColumn("Promedio", GetType(System.String))
                newDt = conexion.getCampos2.Copy()
                Dim contador As Integer = 0
                Dim suma As Double = 0
                Dim sumaTotal As Double = 0
                Dim diasTotales As Double = 0
                Dim promFinal As Double = 0
                newDt.Columns.Add(ColSuma)
                newDt.Columns.Add(ColProm)
                For i As Integer = 0 To newDt.Rows.Count - 1 Step +1
                    contador = 5
                    dtExcel.DataSource = newDt
                    While contador < newDt.Columns.Count - 3
                        suma = suma + Double.Parse(newDt(i)(contador))
                        contador = contador + 1
                    End While
                    newDt.Rows(i)("Suma") = suma
                    newDt.Rows(i)("Promedio") = Math.Round(suma / Double.Parse(conexion.getCampos2(i)(4)), 2)
                    codigo = newDt.Rows(0)(1)
                    suma = 0
                    contador = 0
                Next
                dtExcel.Columns("Suma").DisplayIndex = 5
                dtExcel.Columns("Promedio").DisplayIndex = 6
                For k As Integer = 0 To newDt.Rows.Count - 1 Step +1
                    sumaTotal = sumaTotal + newDt(k)("Suma")
                    diasTotales = diasTotales + newDt(k)("diasTrabajados")
                Next
                promFinal = Math.Round(sumaTotal / diasTotales, 2)
                lblCodigo.Text = newDt(0)("codigo")
                lblNombre.Text = cbNombre.Text
                lblPeriodos.Text = cbMesInicial.Text & cbAñoInicial.Text & " a " & cbMesFinal.Text & cbAñoFinal.Text
                lblPercepciones.Text = Format(sumaTotal, "$ ##,##0.00")
                lblDias.Text = diasTotales & " " & "Dias"
                lblPromedio.Text = Format(promFinal, "$ ##,##0.00")
                totalDias = diasTotales
                totalProm = promFinal
                dtExcel.Hide()
                TableLayoutPanel2.Show()
                Button4.Show()
                Button5.Show()
            Else
                'busqueda mes y año diferentes
                nombre = cbNombre.Text
                For w As Integer = 0 To cbMesInicial.SelectedIndex Step +1
                    mesInicio = "0" & w + 1
                    If w >= 9 Then
                        mesInicio = w + 1
                    End If
                Next
                For k As Integer = 0 To cbMesFinal.SelectedIndex Step +1
                    mesFin = "0" & k + 1
                    If k >= 9 Then
                        mesFin = k + 1
                    End If
                Next
                yearInicio = cbAñoInicial.Text
                yearFinal = cbAñoFinal.Text

                Dim ColSuma As New Data.DataColumn("Suma", GetType(System.String))
                Dim ColProm As New Data.DataColumn("Promedio", GetType(System.String))
                newDt = conexion.getCampos.Copy()
                Dim contador As Integer = 0
                Dim suma As Double = 0
                Dim sumaTotal As Double = 0
                Dim diasTotales As Double = 0
                Dim promFinal As Double = 0
                newDt.Columns.Add(ColSuma)
                newDt.Columns.Add(ColProm)
                For i As Integer = 0 To newDt.Rows.Count - 1 Step +1
                    contador = 5
                    dtExcel.DataSource = newDt
                    While contador < newDt.Columns.Count - 3
                        suma = suma + Double.Parse(newDt(i)(contador))
                        contador = contador + 1
                    End While
                    newDt.Rows(i)("Suma") = suma
                    newDt.Rows(i)("Promedio") = Math.Round(suma / Double.Parse(conexion.getCampos(i)(4)), 2)
                    codigo = newDt.Rows(0)(1)
                    suma = 0
                    contador = 0
                Next
                dtExcel.Columns("Suma").DisplayIndex = 5
                dtExcel.Columns("Promedio").DisplayIndex = 6
                For k As Integer = 0 To newDt.Rows.Count - 1 Step +1
                    sumaTotal = sumaTotal + newDt(k)("Suma")
                    diasTotales = diasTotales + newDt(k)("diasTrabajados")
                Next
                promFinal = Math.Round(sumaTotal / diasTotales, 2)
                lblCodigo.Text = newDt(0)("codigo")
                lblNombre.Text = cbNombre.Text
                lblPeriodos.Text = cbMesInicial.Text & cbAñoInicial.Text & " a " & cbMesFinal.Text & cbAñoFinal.Text
                lblPercepciones.Text = Format(sumaTotal, "$ ##,##0.00")
                lblDias.Text = diasTotales & " " & "Dias"
                lblPromedio.Text = Format(promFinal, "$ ##,##0.00")
                totalDias = diasTotales
                totalProm = promFinal
                dtExcel.Hide()
                TableLayoutPanel2.Show()
                Button4.Show()
                Button5.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
