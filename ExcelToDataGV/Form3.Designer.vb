<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.lblPromedio = New System.Windows.Forms.Label()
        Me.txtFaltas = New System.Windows.Forms.TextBox()
        Me.lblFaltas = New System.Windows.Forms.Label()
        Me.lblSueldoDia = New System.Windows.Forms.Label()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSueldoNum = New System.Windows.Forms.Label()
        Me.lblPromedioNum = New System.Windows.Forms.Label()
        Me.lblDescuento = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPromedio
        '
        Me.lblPromedio.AutoSize = True
        Me.lblPromedio.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblPromedio.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromedio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPromedio.Location = New System.Drawing.Point(117, 330)
        Me.lblPromedio.Name = "lblPromedio"
        Me.lblPromedio.Size = New System.Drawing.Size(178, 34)
        Me.lblPromedio.TabIndex = 25
        Me.lblPromedio.Text = "Promedio: "
        Me.lblPromedio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFaltas
        '
        Me.txtFaltas.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtFaltas.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFaltas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFaltas.Location = New System.Drawing.Point(432, 246)
        Me.txtFaltas.Name = "txtFaltas"
        Me.txtFaltas.Size = New System.Drawing.Size(131, 43)
        Me.txtFaltas.TabIndex = 21
        '
        'lblFaltas
        '
        Me.lblFaltas.AutoSize = True
        Me.lblFaltas.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblFaltas.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFaltas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFaltas.Location = New System.Drawing.Point(117, 249)
        Me.lblFaltas.Name = "lblFaltas"
        Me.lblFaltas.Size = New System.Drawing.Size(287, 34)
        Me.lblFaltas.TabIndex = 22
        Me.lblFaltas.Text = "Días  Falta/Curso:"
        Me.lblFaltas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSueldoDia
        '
        Me.lblSueldoDia.AutoSize = True
        Me.lblSueldoDia.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblSueldoDia.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSueldoDia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSueldoDia.Location = New System.Drawing.Point(117, 173)
        Me.lblSueldoDia.Name = "lblSueldoDia"
        Me.lblSueldoDia.Size = New System.Drawing.Size(238, 34)
        Me.lblSueldoDia.TabIndex = 24
        Me.lblSueldoDia.Text = "Sueldo Diario: "
        Me.lblSueldoDia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblDepartamento.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartamento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDepartamento.Location = New System.Drawing.Point(117, 95)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(232, 34)
        Me.lblDepartamento.TabIndex = 23
        Me.lblDepartamento.Text = "Departamento"
        Me.lblDepartamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblNombre.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblNombre.Location = New System.Drawing.Point(117, 25)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(136, 34)
        Me.lblNombre.TabIndex = 20
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblCodigo.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblCodigo.Location = New System.Drawing.Point(19, 25)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(92, 34)
        Me.lblCodigo.TabIndex = 19
        Me.lblCodigo.Text = "Code"
        Me.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(594, 399)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 34)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Descuento :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSueldoNum
        '
        Me.lblSueldoNum.AutoSize = True
        Me.lblSueldoNum.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblSueldoNum.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSueldoNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblSueldoNum.Location = New System.Drawing.Point(351, 173)
        Me.lblSueldoNum.Name = "lblSueldoNum"
        Me.lblSueldoNum.Size = New System.Drawing.Size(72, 34)
        Me.lblSueldoNum.TabIndex = 27
        Me.lblSueldoNum.Text = "$$$"
        Me.lblSueldoNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPromedioNum
        '
        Me.lblPromedioNum.AutoSize = True
        Me.lblPromedioNum.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblPromedioNum.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromedioNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblPromedioNum.Location = New System.Drawing.Point(301, 330)
        Me.lblPromedioNum.Name = "lblPromedioNum"
        Me.lblPromedioNum.Size = New System.Drawing.Size(72, 34)
        Me.lblPromedioNum.TabIndex = 28
        Me.lblPromedioNum.Text = "$$$"
        Me.lblPromedioNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDescuento
        '
        Me.lblDescuento.AutoSize = True
        Me.lblDescuento.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblDescuento.Font = New System.Drawing.Font("Lucida Fax", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescuento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDescuento.Location = New System.Drawing.Point(805, 399)
        Me.lblDescuento.Name = "lblDescuento"
        Me.lblDescuento.Size = New System.Drawing.Size(72, 34)
        Me.lblDescuento.TabIndex = 29
        Me.lblDescuento.Text = "$$$"
        Me.lblDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(12, 579)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(125, 38)
        Me.Button4.TabIndex = 30
        Me.Button4.Text = "Atras"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(600, 246)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 46)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Calcular"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1115, 629)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.lblDescuento)
        Me.Controls.Add(Me.lblPromedioNum)
        Me.Controls.Add(Me.lblSueldoNum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblPromedio)
        Me.Controls.Add(Me.lblSueldoDia)
        Me.Controls.Add(Me.lblDepartamento)
        Me.Controls.Add(Me.lblFaltas)
        Me.Controls.Add(Me.txtFaltas)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblCodigo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPromedio As Label
    Friend WithEvents txtFaltas As TextBox
    Friend WithEvents lblFaltas As Label
    Friend WithEvents lblSueldoDia As Label
    Friend WithEvents lblDepartamento As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSueldoNum As Label
    Friend WithEvents lblPromedioNum As Label
    Friend WithEvents lblDescuento As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
End Class
