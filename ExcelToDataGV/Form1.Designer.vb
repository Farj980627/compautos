<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Compautos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Compautos))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtExcel = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbAñoFinal = New System.Windows.Forms.ComboBox()
        Me.cbMesFinal = New System.Windows.Forms.ComboBox()
        Me.cbAñoInicial = New System.Windows.Forms.ComboBox()
        Me.cbMesInicial = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cbNombre = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblPromedio = New System.Windows.Forms.Label()
        Me.lblDias = New System.Windows.Forms.Label()
        Me.lblPercepciones = New System.Windows.Forms.Label()
        Me.lblPeriodos = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.dtExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(24, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(219, 45)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Abrir Archivo"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtExcel
        '
        Me.dtExcel.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtExcel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtExcel.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dtExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtExcel.Location = New System.Drawing.Point(24, 54)
        Me.dtExcel.Name = "dtExcel"
        Me.dtExcel.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtExcel.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dtExcel.RowHeadersVisible = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        Me.dtExcel.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dtExcel.RowTemplate.Height = 24
        Me.dtExcel.Size = New System.Drawing.Size(1679, 784)
        Me.dtExcel.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(276, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(241, 45)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Guardar Datos"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.Controls.Add(Me.cbAñoFinal, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cbMesFinal, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cbAñoInicial, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cbMesInicial, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 3, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 895)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(832, 31)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'cbAñoFinal
        '
        Me.cbAñoFinal.BackColor = System.Drawing.Color.White
        Me.cbAñoFinal.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAñoFinal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbAñoFinal.FormattingEnabled = True
        Me.cbAñoFinal.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cbAñoFinal.Location = New System.Drawing.Point(693, 3)
        Me.cbAñoFinal.Name = "cbAñoFinal"
        Me.cbAñoFinal.Size = New System.Drawing.Size(136, 31)
        Me.cbAñoFinal.TabIndex = 3
        '
        'cbMesFinal
        '
        Me.cbMesFinal.BackColor = System.Drawing.Color.White
        Me.cbMesFinal.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMesFinal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbMesFinal.FormattingEnabled = True
        Me.cbMesFinal.Items.AddRange(New Object() {"Enero" & Global.Microsoft.VisualBasic.ChrW(9), "Febrero" & Global.Microsoft.VisualBasic.ChrW(9), "Marzo", "Abril", "Mayo" & Global.Microsoft.VisualBasic.ChrW(9), "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cbMesFinal.Location = New System.Drawing.Point(555, 3)
        Me.cbMesFinal.Name = "cbMesFinal"
        Me.cbMesFinal.Size = New System.Drawing.Size(132, 31)
        Me.cbMesFinal.TabIndex = 2
        '
        'cbAñoInicial
        '
        Me.cbAñoInicial.BackColor = System.Drawing.Color.White
        Me.cbAñoInicial.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAñoInicial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbAñoInicial.FormattingEnabled = True
        Me.cbAñoInicial.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cbAñoInicial.Location = New System.Drawing.Point(279, 3)
        Me.cbAñoInicial.Name = "cbAñoInicial"
        Me.cbAñoInicial.Size = New System.Drawing.Size(132, 31)
        Me.cbAñoInicial.TabIndex = 1
        '
        'cbMesInicial
        '
        Me.cbMesInicial.BackColor = System.Drawing.Color.White
        Me.cbMesInicial.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMesInicial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbMesInicial.FormattingEnabled = True
        Me.cbMesInicial.Items.AddRange(New Object() {"Enero" & Global.Microsoft.VisualBasic.ChrW(9), "Febrero" & Global.Microsoft.VisualBasic.ChrW(9), "Marzo", "Abril", "Mayo" & Global.Microsoft.VisualBasic.ChrW(9), "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cbMesInicial.Location = New System.Drawing.Point(141, 3)
        Me.cbMesInicial.Name = "cbMesInicial"
        Me.cbMesInicial.Size = New System.Drawing.Size(132, 31)
        Me.cbMesInicial.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(61, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Inicio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(502, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 31)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Fin:"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(850, 895)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(281, 50)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Calcular Promedio"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cbNombre
        '
        Me.cbNombre.BackColor = System.Drawing.Color.White
        Me.cbNombre.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNombre.ForeColor = System.Drawing.Color.Black
        Me.cbNombre.FormattingEnabled = True
        Me.cbNombre.Items.AddRange(New Object() {"Enero" & Global.Microsoft.VisualBasic.ChrW(9), "Febrero" & Global.Microsoft.VisualBasic.ChrW(9), "Marzo", "Abril", "Mayo" & Global.Microsoft.VisualBasic.ChrW(9), "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cbNombre.Location = New System.Drawing.Point(291, 858)
        Me.cbNombre.Name = "cbNombre"
        Me.cbNombre.Size = New System.Drawing.Size(408, 31)
        Me.cbNombre.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(183, 861)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nombre: "
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblPromedio, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.lblDias, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblPercepciones, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblPeriodos, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblNombre, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label5, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.lblCodigo, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(319, 168)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(994, 292)
        Me.TableLayoutPanel2.TabIndex = 8
        '
        'lblPromedio
        '
        Me.lblPromedio.AutoSize = True
        Me.lblPromedio.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromedio.ForeColor = System.Drawing.Color.White
        Me.lblPromedio.Location = New System.Drawing.Point(350, 232)
        Me.lblPromedio.Name = "lblPromedio"
        Me.lblPromedio.Size = New System.Drawing.Size(264, 34)
        Me.lblPromedio.TabIndex = 19
        Me.lblPromedio.Text = "PromedioSalario"
        Me.lblPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDias
        '
        Me.lblDias.AutoSize = True
        Me.lblDias.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDias.ForeColor = System.Drawing.Color.White
        Me.lblDias.Location = New System.Drawing.Point(350, 174)
        Me.lblDias.Name = "lblDias"
        Me.lblDias.Size = New System.Drawing.Size(151, 34)
        Me.lblDias.TabIndex = 18
        Me.lblDias.Text = "totalDias"
        Me.lblDias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPercepciones
        '
        Me.lblPercepciones.AutoSize = True
        Me.lblPercepciones.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercepciones.ForeColor = System.Drawing.Color.White
        Me.lblPercepciones.Location = New System.Drawing.Point(350, 116)
        Me.lblPercepciones.Name = "lblPercepciones"
        Me.lblPercepciones.Size = New System.Drawing.Size(284, 34)
        Me.lblPercepciones.TabIndex = 17
        Me.lblPercepciones.Text = "totalPercepciones"
        Me.lblPercepciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPeriodos
        '
        Me.lblPeriodos.AutoSize = True
        Me.lblPeriodos.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeriodos.ForeColor = System.Drawing.Color.White
        Me.lblPeriodos.Location = New System.Drawing.Point(350, 58)
        Me.lblPeriodos.Name = "lblPeriodos"
        Me.lblPeriodos.Size = New System.Drawing.Size(147, 34)
        Me.lblPeriodos.TabIndex = 16
        Me.lblPeriodos.Text = "Periodos"
        Me.lblPeriodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(350, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(136, 34)
        Me.lblNombre.TabIndex = 15
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 34)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Periodo:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(311, 34)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Total Percepciones:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(3, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(178, 34)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Total Dias:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(3, 232)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(291, 34)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Salario Promedio: "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.Color.White
        Me.lblCodigo.Location = New System.Drawing.Point(3, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(131, 34)
        Me.lblCodigo.TabIndex = 10
        Me.lblCodigo.Text = "Codigo "
        Me.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(675, 475)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(318, 47)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Ver Detalles Avanzados"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Compautos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1703, 957)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbNombre)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dtExcel)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Compautos"
        Me.Text = "Compautos"
        CType(Me.dtExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents dtExcel As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents cbAñoInicial As ComboBox
    Friend WithEvents cbMesInicial As ComboBox
    Friend WithEvents cbMesFinal As ComboBox
    Friend WithEvents cbAñoFinal As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbNombre As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblPromedio As Label
    Friend WithEvents lblDias As Label
    Friend WithEvents lblPercepciones As Label
    Friend WithEvents lblPeriodos As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button4 As Button
End Class
