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

    Public Shared Sub addvalue(ByVal p1 As String, p2 As String, p3 As String, p4 As String, p5 As String, p6 As String, p7 As String, p8 As String, p9 As String, p10 As String, p11 As String, p12 As String, p13 As String, p14 As String, p15 As String, p16 As String, p17 As String, p18 As String, p19 As String, p20 As String, p21 As String, p22 As String, p23 As String, p24 As String, p25 As String, p26 As String, p27 As String, p28 As String, p29 As String, p30 As String, p31 As String, p32 As String, p33 As String, p34 As String, p35 As String, p36 As String, p37 As String, p38 As String, p39 As String, p40 As String, p41 As String, p42 As String, p43 As String, p44 As String, p45 As String, p46 As String, p47 As String, p48 As String, p49 As String, p50 As String, p51 As String)
        Dim con As MySqlConnection = conexion.conection()
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("insert into compautos_nomina values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}', '{25}', '{26}', '{27}', '{28}', '{29}', '{30}', '{31}', '{32}', '{33}', '{34}', '{35}', '{36}', '{37}', '{38}', '{39}', '{40}', '{41}', '{42}', '{43}', '{44}', '{45}', '{46}', '{47}', '{48}', '{49}', '{50}')  ", p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31, p32, p33, p34, p35, p36, p37, p38, p39, p40, p41, p42, p43, p44, p45, p46, p47, p48, p49, p50, p51), con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Public Shared Function getCampos() As DataTable
        Dim con As MySqlConnection = conexion.conection()
        Dim dt As DataTable = New DataTable()
        Dim cmd As MySqlCommand = New MySqlCommand(String.Format("SELECT periodo,codigo,nombre, departamento, diasTrabajados,sueldo,otrasPercepciones,compensasion,destajos, destajo, comisiones, vacacionesTiempo, vacacionesReportadas, comisionSeminuevos, comisionUsados, comisionAltaGama, comisionProshop, comisionSicrea, comisionRefacciones, comisionServicio, comisionHyP, bonificacion FROM compautos_nomina"), con)
        Dim adap As New MySqlDataAdapter(cmd)
        adap.Fill(dt)
        con.Close()
        Return dt
    End Function


End Class
