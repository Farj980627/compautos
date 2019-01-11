Imports MySql.Data.MySqlClient

Public Class conexion
    Public Shared Function conection() As MySqlConnection
        Dim db As MySqlConnectionStringBuilder = New MySqlConnectionStringBuilder()
        db.Server = "localhost"
        db.UserID = "root"
        db.Password = "rootroot"
        db.Database = "nominas"
        db.SslMode = MySqlSslMode.None
        Dim con As MySqlConnection = New MySqlConnection(db.ToString())
        con.Open()
        Return con
    End Function
    Public Shared Sub addvalue(ByVal p1 As String, p2 As String, p3 As String, p4 As String, p5 As String, p6 As String, p7 As String, p8 As String, p9 As String, p10 As String, p11 As String, p12 As String, p13 As String, p14 As String, p15 As String, p16 As String, p17 As String, p18 As String, p19 As String, p20 As String, p21 As String, p22 As String, p23 As String, p24 As String, p25 As String, p26 As String)
        Dim con As MySqlConnection = conexion.conection()
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("insert  into compautos_nomina values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}', '{25}') ", p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Shared Function comparar(pperiodo) As Boolean
        Dim con As MySqlConnection = conexion.conection()
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("select distinct periodo from compautos_nomina"), con)
        Dim dt As New DataTable
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        Dim saber As Boolean = False
        Dim compa As String = ""
        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1 Step +1
                compa = dt.Rows(i)(0).ToString
                If compa.Equals(pperiodo) Then
                    saber = True
                End If
            Next
        End If
        con.Close()
        Return saber
    End Function
    Public Shared Function getNombres() As DataTable
        Dim con As MySqlConnection = conexion.conection()
        Dim dt As New DataTable()
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("Select distinct nombre from compautos_nomina order by nombre"), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getCampos2() As DataTable
        Dim con As MySqlConnection = conexion.conection()
        Dim dt As DataTable = New DataTable()
        Dim periodoActual, nombre As String
        periodoActual = Compautos.mesInicio & Compautos.yearInicio
        nombre = Compautos.nombre
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT periodo,codigo,nombre, departamento,
                diasTrabajados,sueldo,otrasPercepciones,compensasion,destajos, destajo, comisiones, vacacionesTiempo,
                vacacionesReportadas, comisionSeminuevos, comisionUsados, comisionAltaGama, comisionProshop, comisionSicrea,
                comisionRefacciones, comisionServicio, comisionHyP, bonificacion FROM compautos_nomina
                where periodo='" + periodoActual + "' and nombre = '" + nombre + "'"), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function
    Public Shared Function getCampos() As DataTable
        Dim con As MySqlConnection = conexion.conection()
        Dim dt As DataTable = New DataTable()
        Dim detener As Boolean = False
        Dim contador, contador2 As Integer
        Dim mesActual As String = ""
        Dim periodoActual As String = ""
        Dim nombre As String = ""
        contador = Compautos.mesInicio
        contador2 = Compautos.yearInicio
        nombre = Compautos.nombre
        While detener = False
            If contador = 13 Then
                contador = 1
                contador2 = contador2 + 1
            End If
            If contador = Compautos.mesFin And contador2 = Compautos.yearFinal Then
                detener = True
            End If
            If contador < 10 Then
                mesActual = "0" & contador
            Else mesActual = contador
            End If
            periodoActual = mesActual & contador2
            Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT periodo,codigo,nombre, departamento,
                diasTrabajados,sueldo,otrasPercepciones,compensasion,destajos, destajo, comisiones, vacacionesTiempo,
                vacacionesReportadas, comisionSeminuevos, comisionUsados, comisionAltaGama, comisionProshop, comisionSicrea,
                comisionRefacciones, comisionServicio, comisionHyP, bonificacion FROM compautos_nomina
                where periodo='" + periodoActual + "' and nombre = '" + nombre + "'"), con)
            Dim adap As New MySqlDataAdapter(cmd)
            adap.Fill(dt)
            contador = contador + 1
        End While
        con.Close()
        Return dt
    End Function
End Class
