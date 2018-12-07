Imports System.Data.OleDb
Imports MySql.Data.MySqlClient


Public Class Form1
    Dim dbconect As conexion
    Dim conn As OleDbConnection
    Dim data As OleDbDataAdapter
    Dim datos As DataSet
    Dim excel As String
    Dim openFile As New OpenFileDialog

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            openFile.InitialDirectory = "C:\Users\Abisai\Downloads"
            openFile.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm"
            If openFile.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                Dim fi As New IO.FileInfo(openFile.FileName)
                Dim FileName As String = openFile.FileName
                excel = fi.FullName
                conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excel + ";Extended Properties=Excel 12.0;")
                data = New OleDbDataAdapter("select * from [Hoja2$]", conn)
                datos = New DataSet
                data.Fill(datos, "[Hoja2$]")
                dtExcel.DataSource = datos
                dtExcel.DataMember = "[Hoja2$]"
                conn.Close()
                MsgBox("Archivo Cargado Correctamente")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28, a29, a30, a31, a32, a33, a34, a35, a36, a37, a38, a39, a40, a41, a42, a43, a44, a45, a46, a47, a48, a49, a50, a51, a52, a53 As String
            For i As Integer = 0 To dtExcel.Rows.Count Step +1

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
                a27 = dtExcel.Rows(i).Cells(26).Value.ToString()
                a28 = dtExcel.Rows(i).Cells(27).Value.ToString()
                a29 = dtExcel.Rows(i).Cells(28).Value.ToString()
                a30 = dtExcel.Rows(i).Cells(29).Value.ToString()
                a31 = dtExcel.Rows(i).Cells(30).Value.ToString()
                a32 = dtExcel.Rows(i).Cells(31).Value.ToString()
                a33 = dtExcel.Rows(i).Cells(32).Value.ToString()
                a34 = dtExcel.Rows(i).Cells(33).Value.ToString()
                a35 = dtExcel.Rows(i).Cells(34).Value.ToString()
                a36 = dtExcel.Rows(i).Cells(35).Value.ToString()
                a37 = dtExcel.Rows(i).Cells(36).Value.ToString()
                a38 = dtExcel.Rows(i).Cells(37).Value.ToString()
                a39 = dtExcel.Rows(i).Cells(38).Value.ToString()
                a40 = dtExcel.Rows(i).Cells(39).Value.ToString()
                a41 = dtExcel.Rows(i).Cells(40).Value.ToString()
                a42 = dtExcel.Rows(i).Cells(41).Value.ToString()
                a43 = dtExcel.Rows(i).Cells(42).Value.ToString()
                a44 = dtExcel.Rows(i).Cells(43).Value.ToString()
                a45 = dtExcel.Rows(i).Cells(44).Value.ToString()
                a46 = dtExcel.Rows(i).Cells(45).Value.ToString()
                a47 = dtExcel.Rows(i).Cells(46).Value.ToString()
                a48 = dtExcel.Rows(i).Cells(47).Value.ToString()
                a49 = dtExcel.Rows(i).Cells(48).Value.ToString()
                a50 = dtExcel.Rows(i).Cells(49).Value.ToString()
                a51 = dtExcel.Rows(i).Cells(50).Value.ToString()
                a52 = dtExcel.Rows(i).Cells(51).Value.ToString()
                a53 = dtExcel.Rows(i).Cells(52).Value.ToString()

                conexion.addvalue(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28, a29, a30, a31, a32, a33, a34, a35, a36, a37, a38, a39, a40, a41, a42, a43, a44, a45, a46, a47, a48, a49, a50, a51, a52, a53)


            Next
            MsgBox("Everithing will be alright")


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try




    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        dtExcel.DataSource = conexion.getCampos()
        conexion.getCampos()
        Dim dato As String
        Dim suma As Double
        For i As Integer = 0 To conexion.getCampos.Rows.Count Step +1

            For o As Integer = 3 To conexion.getCampos.Columns.Count - 2 Step +1



                For y As Integer = 3 To 18 Step +1
                    dato = conexion.getCampos.Rows(i)(o).ToString
                    suma += Double.Parse(dato)
                Next

                MsgBox(suma.ToString)
            Next

        Next


    End Sub
End Class
