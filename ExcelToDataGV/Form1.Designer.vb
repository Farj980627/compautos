<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtExcel = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbMesInicial = New System.Windows.Forms.ComboBox()
        Me.cbAñoInicial = New System.Windows.Forms.ComboBox()
        Me.cbMesFinal = New System.Windows.Forms.ComboBox()
        Me.cbAñoFinal = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.dtExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(273, 38)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Abrir Archivo de Excel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtExcel
        '
        Me.dtExcel.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtExcel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtExcel.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dtExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtExcel.Location = New System.Drawing.Point(12, 54)
        Me.dtExcel.Name = "dtExcel"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtExcel.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dtExcel.RowHeadersVisible = False
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        Me.dtExcel.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dtExcel.RowTemplate.Height = 24
        Me.dtExcel.Size = New System.Drawing.Size(1679, 784)
        Me.dtExcel.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(319, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(184, 38)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Guardar Datos"
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 863)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(832, 31)
        Me.TableLayoutPanel1.TabIndex = 4
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
        'cbAñoInicial
        '
        Me.cbAñoInicial.BackColor = System.Drawing.Color.White
        Me.cbAñoInicial.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAñoInicial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbAñoInicial.FormattingEnabled = True
        Me.cbAñoInicial.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019"})
        Me.cbAñoInicial.Location = New System.Drawing.Point(279, 3)
        Me.cbAñoInicial.Name = "cbAñoInicial"
        Me.cbAñoInicial.Size = New System.Drawing.Size(132, 31)
        Me.cbAñoInicial.TabIndex = 1
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
        'cbAñoFinal
        '
        Me.cbAñoFinal.BackColor = System.Drawing.Color.White
        Me.cbAñoFinal.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAñoFinal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cbAñoFinal.FormattingEnabled = True
        Me.cbAñoFinal.Items.AddRange(New Object() {"2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019"})
        Me.cbAñoFinal.Location = New System.Drawing.Point(693, 3)
        Me.cbAñoFinal.Name = "cbAñoFinal"
        Me.cbAñoFinal.Size = New System.Drawing.Size(136, 31)
        Me.cbAñoFinal.TabIndex = 3
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
        Me.Label1.Text = "From: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(506, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 31)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "To:"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(850, 861)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(250, 38)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Calcular Promedio"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1703, 922)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dtExcel)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dtExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents dtExcel As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents cbAñoInicial As ComboBox
    Friend WithEvents cbMesInicial As ComboBox
    Friend WithEvents cbMesFinal As ComboBox
    Friend WithEvents cbAñoFinal As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
End Class
