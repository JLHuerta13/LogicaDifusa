<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ingresarIndividuos
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
        Me.ButtonMinimizar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.Panel_BarraTitulo = New System.Windows.Forms.Panel()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.btn_registrar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.panel_acciones = New System.Windows.Forms.Panel()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.cbo_edad = New System.Windows.Forms.ComboBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.lbl_edad = New System.Windows.Forms.Label()
        Me.lbl_sexo = New System.Windows.Forms.Label()
        Me.cbo_sexo = New System.Windows.Forms.ComboBox()
        Me.lbl_interes = New System.Windows.Forms.Label()
        Me.cbo_interes = New System.Windows.Forms.ComboBox()
        Me.lbl_educacion = New System.Windows.Forms.Label()
        Me.cbo_educacion = New System.Windows.Forms.ComboBox()
        Me.lbl_ocupacion = New System.Windows.Forms.Label()
        Me.cbo_ocupacion = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_personalidad = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbo_deportes = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbo_viajar = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbo_cine = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbo_leer = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbo_musica = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbo_religion = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbo_salud = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbo_apariencia = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_nickname = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbo_familia = New System.Windows.Forms.ComboBox()
        Me.Panel_BarraTitulo.SuspendLayout()
        Me.panel_acciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonMinimizar
        '
        Me.ButtonMinimizar.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonMinimizar.FlatAppearance.BorderSize = 0
        Me.ButtonMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.ButtonMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.ButtonMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMinimizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMinimizar.ForeColor = System.Drawing.Color.Black
        Me.ButtonMinimizar.Location = New System.Drawing.Point(1395, 0)
        Me.ButtonMinimizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonMinimizar.Name = "ButtonMinimizar"
        Me.ButtonMinimizar.Size = New System.Drawing.Size(40, 36)
        Me.ButtonMinimizar.TabIndex = 3
        Me.ButtonMinimizar.Text = "_"
        Me.ButtonMinimizar.UseVisualStyleBackColor = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonSalir.FlatAppearance.BorderSize = 0
        Me.ButtonSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSalir.ForeColor = System.Drawing.Color.Black
        Me.ButtonSalir.Location = New System.Drawing.Point(1435, 0)
        Me.ButtonSalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(41, 36)
        Me.ButtonSalir.TabIndex = 2
        Me.ButtonSalir.Text = "X"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'Panel_BarraTitulo
        '
        Me.Panel_BarraTitulo.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel_BarraTitulo.Controls.Add(Me.ButtonMinimizar)
        Me.Panel_BarraTitulo.Controls.Add(Me.ButtonSalir)
        Me.Panel_BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_BarraTitulo.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Panel_BarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.Panel_BarraTitulo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel_BarraTitulo.Name = "Panel_BarraTitulo"
        Me.Panel_BarraTitulo.Size = New System.Drawing.Size(1476, 36)
        Me.Panel_BarraTitulo.TabIndex = 24
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nombre.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.ForeColor = System.Drawing.Color.Indigo
        Me.lbl_nombre.Location = New System.Drawing.Point(77, 202)
        Me.lbl_nombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(239, 33)
        Me.lbl_nombre.TabIndex = 54
        Me.lbl_nombre.Text = "2. ¿Cómo te llamas?"
        '
        'btn_registrar
        '
        Me.btn_registrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_registrar.Location = New System.Drawing.Point(1257, 0)
        Me.btn_registrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_registrar.Name = "btn_registrar"
        Me.btn_registrar.Size = New System.Drawing.Size(107, 43)
        Me.btn_registrar.TabIndex = 38
        Me.btn_registrar.Text = "Registrar"
        Me.btn_registrar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.Red
        Me.btn_eliminar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_eliminar.Location = New System.Drawing.Point(1364, 0)
        Me.btn_eliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(112, 43)
        Me.btn_eliminar.TabIndex = 37
        Me.btn_eliminar.Text = "Salir"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'panel_acciones
        '
        Me.panel_acciones.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.panel_acciones.Controls.Add(Me.btn_limpiar)
        Me.panel_acciones.Controls.Add(Me.btn_registrar)
        Me.panel_acciones.Controls.Add(Me.btn_eliminar)
        Me.panel_acciones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_acciones.Location = New System.Drawing.Point(0, 721)
        Me.panel_acciones.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panel_acciones.Name = "panel_acciones"
        Me.panel_acciones.Size = New System.Drawing.Size(1476, 43)
        Me.panel_acciones.TabIndex = 53
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_limpiar.Location = New System.Drawing.Point(1109, 0)
        Me.btn_limpiar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(148, 43)
        Me.btn_limpiar.TabIndex = 39
        Me.btn_limpiar.Text = "Limpiar valores"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'cbo_edad
        '
        Me.cbo_edad.FormattingEnabled = True
        Me.cbo_edad.Items.AddRange(New Object() {"15-17", "18-20", "21-23", "24-26", "27-30"})
        Me.cbo_edad.Location = New System.Drawing.Point(83, 354)
        Me.cbo_edad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbo_edad.Name = "cbo_edad"
        Me.cbo_edad.Size = New System.Drawing.Size(172, 24)
        Me.cbo_edad.TabIndex = 51
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(83, 252)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(252, 22)
        Me.txt_nombre.TabIndex = 49
        '
        'LabelTitulo
        '
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LabelTitulo.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.Color.Indigo
        Me.LabelTitulo.Location = New System.Drawing.Point(75, 38)
        Me.LabelTitulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(196, 33)
        Me.LabelTitulo.TabIndex = 41
        Me.LabelTitulo.Text = "FORMULARIO"
        '
        'lbl_edad
        '
        Me.lbl_edad.AutoSize = True
        Me.lbl_edad.BackColor = System.Drawing.Color.Transparent
        Me.lbl_edad.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_edad.ForeColor = System.Drawing.Color.Indigo
        Me.lbl_edad.Location = New System.Drawing.Point(77, 308)
        Me.lbl_edad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_edad.Name = "lbl_edad"
        Me.lbl_edad.Size = New System.Drawing.Size(207, 33)
        Me.lbl_edad.TabIndex = 58
        Me.lbl_edad.Text = "3. Rango de edad"
        '
        'lbl_sexo
        '
        Me.lbl_sexo.AutoSize = True
        Me.lbl_sexo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_sexo.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_sexo.ForeColor = System.Drawing.Color.Indigo
        Me.lbl_sexo.Location = New System.Drawing.Point(77, 405)
        Me.lbl_sexo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_sexo.Name = "lbl_sexo"
        Me.lbl_sexo.Size = New System.Drawing.Size(99, 33)
        Me.lbl_sexo.TabIndex = 59
        Me.lbl_sexo.Text = "4. Sexo"
        '
        'cbo_sexo
        '
        Me.cbo_sexo.FormattingEnabled = True
        Me.cbo_sexo.Items.AddRange(New Object() {"Hombre", "Mujer"})
        Me.cbo_sexo.Location = New System.Drawing.Point(83, 452)
        Me.cbo_sexo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbo_sexo.Name = "cbo_sexo"
        Me.cbo_sexo.Size = New System.Drawing.Size(172, 24)
        Me.cbo_sexo.TabIndex = 60
        '
        'lbl_interes
        '
        Me.lbl_interes.AutoSize = True
        Me.lbl_interes.BackColor = System.Drawing.Color.Transparent
        Me.lbl_interes.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_interes.ForeColor = System.Drawing.Color.Indigo
        Me.lbl_interes.Location = New System.Drawing.Point(77, 497)
        Me.lbl_interes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_interes.Name = "lbl_interes"
        Me.lbl_interes.Size = New System.Drawing.Size(432, 33)
        Me.lbl_interes.TabIndex = 61
        Me.lbl_interes.Text = "5. ¿Qué buscas? (Hombres o mujeres)"
        '
        'cbo_interes
        '
        Me.cbo_interes.FormattingEnabled = True
        Me.cbo_interes.Items.AddRange(New Object() {"Hombres", "Mujeres"})
        Me.cbo_interes.Location = New System.Drawing.Point(83, 546)
        Me.cbo_interes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbo_interes.Name = "cbo_interes"
        Me.cbo_interes.Size = New System.Drawing.Size(172, 24)
        Me.cbo_interes.TabIndex = 62
        '
        'lbl_educacion
        '
        Me.lbl_educacion.AutoSize = True
        Me.lbl_educacion.BackColor = System.Drawing.Color.Transparent
        Me.lbl_educacion.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_educacion.ForeColor = System.Drawing.Color.Indigo
        Me.lbl_educacion.Location = New System.Drawing.Point(77, 606)
        Me.lbl_educacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_educacion.Name = "lbl_educacion"
        Me.lbl_educacion.Size = New System.Drawing.Size(216, 33)
        Me.lbl_educacion.TabIndex = 63
        Me.lbl_educacion.Text = "6. Nivel educativo"
        '
        'cbo_educacion
        '
        Me.cbo_educacion.FormattingEnabled = True
        Me.cbo_educacion.Items.AddRange(New Object() {"Basica", "Media", "Superior"})
        Me.cbo_educacion.Location = New System.Drawing.Point(83, 655)
        Me.cbo_educacion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbo_educacion.Name = "cbo_educacion"
        Me.cbo_educacion.Size = New System.Drawing.Size(172, 24)
        Me.cbo_educacion.TabIndex = 64
        '
        'lbl_ocupacion
        '
        Me.lbl_ocupacion.AutoSize = True
        Me.lbl_ocupacion.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ocupacion.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ocupacion.ForeColor = System.Drawing.Color.Indigo
        Me.lbl_ocupacion.Location = New System.Drawing.Point(583, 106)
        Me.lbl_ocupacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_ocupacion.Name = "lbl_ocupacion"
        Me.lbl_ocupacion.Size = New System.Drawing.Size(163, 33)
        Me.lbl_ocupacion.TabIndex = 65
        Me.lbl_ocupacion.Text = "7. Ocupación"
        '
        'cbo_ocupacion
        '
        Me.cbo_ocupacion.FormattingEnabled = True
        Me.cbo_ocupacion.Items.AddRange(New Object() {"Estudiante", "Trabajador", "Desempleado."})
        Me.cbo_ocupacion.Location = New System.Drawing.Point(588, 159)
        Me.cbo_ocupacion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbo_ocupacion.Name = "cbo_ocupacion"
        Me.cbo_ocupacion.Size = New System.Drawing.Size(172, 24)
        Me.cbo_ocupacion.TabIndex = 66
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Indigo
        Me.Label1.Location = New System.Drawing.Point(583, 202)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 33)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "8. Personalidad"
        '
        'cbo_personalidad
        '
        Me.cbo_personalidad.FormattingEnabled = True
        Me.cbo_personalidad.Items.AddRange(New Object() {"Introvertida", "Extrovertida"})
        Me.cbo_personalidad.Location = New System.Drawing.Point(588, 251)
        Me.cbo_personalidad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbo_personalidad.Name = "cbo_personalidad"
        Me.cbo_personalidad.Size = New System.Drawing.Size(172, 24)
        Me.cbo_personalidad.TabIndex = 68
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Indigo
        Me.Label2.Location = New System.Drawing.Point(583, 298)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(378, 33)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "9. ¿Realizas actividad deportiva?"
        '
        'cbo_deportes
        '
        Me.cbo_deportes.FormattingEnabled = True
        Me.cbo_deportes.Items.AddRange(New Object() {"Nula", "Leve", "Moderada", "Alta", "Profesional"})
        Me.cbo_deportes.Location = New System.Drawing.Point(588, 343)
        Me.cbo_deportes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbo_deportes.Name = "cbo_deportes"
        Me.cbo_deportes.Size = New System.Drawing.Size(172, 24)
        Me.cbo_deportes.TabIndex = 70
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Indigo
        Me.Label3.Location = New System.Drawing.Point(583, 395)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 33)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "10. ¿Te gusta viajar?"
        '
        'cbo_viajar
        '
        Me.cbo_viajar.FormattingEnabled = True
        Me.cbo_viajar.Items.AddRange(New Object() {"Nulo", "Leve", "Moderado", "Alto"})
        Me.cbo_viajar.Location = New System.Drawing.Point(588, 441)
        Me.cbo_viajar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbo_viajar.Name = "cbo_viajar"
        Me.cbo_viajar.Size = New System.Drawing.Size(172, 24)
        Me.cbo_viajar.TabIndex = 72
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Indigo
        Me.Label4.Location = New System.Drawing.Point(583, 496)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(275, 33)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "11. ¿Te gusta ir al cine?"
        '
        'cbo_cine
        '
        Me.cbo_cine.FormattingEnabled = True
        Me.cbo_cine.Items.AddRange(New Object() {"Nulo", "Leve", "Moderado", "Alto"})
        Me.cbo_cine.Location = New System.Drawing.Point(588, 545)
        Me.cbo_cine.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbo_cine.Name = "cbo_cine"
        Me.cbo_cine.Size = New System.Drawing.Size(172, 24)
        Me.cbo_cine.TabIndex = 74
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Indigo
        Me.Label5.Location = New System.Drawing.Point(583, 596)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(220, 33)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "12. ¿Te gusta leer?"
        '
        'cbo_leer
        '
        Me.cbo_leer.FormattingEnabled = True
        Me.cbo_leer.Items.AddRange(New Object() {"Nulo", "Leve", "Moderado", "Alto"})
        Me.cbo_leer.Location = New System.Drawing.Point(588, 655)
        Me.cbo_leer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbo_leer.Name = "cbo_leer"
        Me.cbo_leer.Size = New System.Drawing.Size(172, 24)
        Me.cbo_leer.TabIndex = 76
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Indigo
        Me.Label6.Location = New System.Drawing.Point(1055, 106)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(283, 33)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "13. ¿Te gusta la música?"
        '
        'cbo_musica
        '
        Me.cbo_musica.FormattingEnabled = True
        Me.cbo_musica.Items.AddRange(New Object() {"Nulo", "Leve", "Moderado", "Alto"})
        Me.cbo_musica.Location = New System.Drawing.Point(1061, 158)
        Me.cbo_musica.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbo_musica.Name = "cbo_musica"
        Me.cbo_musica.Size = New System.Drawing.Size(172, 24)
        Me.cbo_musica.TabIndex = 78
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Indigo
        Me.Label7.Location = New System.Drawing.Point(1055, 202)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(266, 33)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "14. Apego a la religión"
        '
        'cbo_religion
        '
        Me.cbo_religion.FormattingEnabled = True
        Me.cbo_religion.Items.AddRange(New Object() {"Nulo", "Leve", "Moderado", "Alto"})
        Me.cbo_religion.Location = New System.Drawing.Point(1061, 250)
        Me.cbo_religion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbo_religion.Name = "cbo_religion"
        Me.cbo_religion.Size = New System.Drawing.Size(172, 24)
        Me.cbo_religion.TabIndex = 80
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Indigo
        Me.Label8.Location = New System.Drawing.Point(1055, 405)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(232, 33)
        Me.Label8.TabIndex = 81
        Me.Label8.Text = "16. Estado de salud"
        '
        'cbo_salud
        '
        Me.cbo_salud.FormattingEnabled = True
        Me.cbo_salud.Items.AddRange(New Object() {"Muy mala", "Mala", "Buena", "Muy buena"})
        Me.cbo_salud.Location = New System.Drawing.Point(1061, 457)
        Me.cbo_salud.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbo_salud.Name = "cbo_salud"
        Me.cbo_salud.Size = New System.Drawing.Size(172, 24)
        Me.cbo_salud.TabIndex = 82
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Indigo
        Me.Label9.Location = New System.Drawing.Point(1055, 497)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(329, 66)
        Me.Label9.TabIndex = 83
        Me.Label9.Text = "17. ¿Qué te importa mas? " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "¿Apariencia o personalidad?"
        '
        'cbo_apariencia
        '
        Me.cbo_apariencia.FormattingEnabled = True
        Me.cbo_apariencia.Items.AddRange(New Object() {"Apariencia", "Personalidad"})
        Me.cbo_apariencia.Location = New System.Drawing.Point(1061, 582)
        Me.cbo_apariencia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbo_apariencia.Name = "cbo_apariencia"
        Me.cbo_apariencia.Size = New System.Drawing.Size(172, 24)
        Me.cbo_apariencia.TabIndex = 84
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Indigo
        Me.Label10.Location = New System.Drawing.Point(77, 106)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(264, 33)
        Me.Label10.TabIndex = 85
        Me.Label10.Text = "1. Ingresa tu nickname"
        '
        'txt_nickname
        '
        Me.txt_nickname.Location = New System.Drawing.Point(83, 160)
        Me.txt_nickname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nickname.Name = "txt_nickname"
        Me.txt_nickname.Size = New System.Drawing.Size(252, 22)
        Me.txt_nickname.TabIndex = 86
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Indigo
        Me.Label11.Location = New System.Drawing.Point(1055, 308)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(257, 33)
        Me.Label11.TabIndex = 87
        Me.Label11.Text = "15. Apego a la familia"
        '
        'cbo_familia
        '
        Me.cbo_familia.FormattingEnabled = True
        Me.cbo_familia.Items.AddRange(New Object() {"Nulo", "Leve", "Moderado", "Alto"})
        Me.cbo_familia.Location = New System.Drawing.Point(1061, 354)
        Me.cbo_familia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbo_familia.Name = "cbo_familia"
        Me.cbo_familia.Size = New System.Drawing.Size(172, 24)
        Me.cbo_familia.TabIndex = 88
        '
        'ingresarIndividuos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Amistad_LogicaDifusa.My.Resources.Resources.gradiant_bg__1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1476, 764)
        Me.Controls.Add(Me.cbo_familia)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_nickname)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbo_apariencia)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbo_salud)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbo_religion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbo_musica)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbo_leer)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbo_cine)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbo_viajar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbo_deportes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbo_personalidad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbo_ocupacion)
        Me.Controls.Add(Me.lbl_ocupacion)
        Me.Controls.Add(Me.cbo_educacion)
        Me.Controls.Add(Me.lbl_educacion)
        Me.Controls.Add(Me.cbo_interes)
        Me.Controls.Add(Me.lbl_interes)
        Me.Controls.Add(Me.cbo_sexo)
        Me.Controls.Add(Me.lbl_sexo)
        Me.Controls.Add(Me.lbl_edad)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.panel_acciones)
        Me.Controls.Add(Me.cbo_edad)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Controls.Add(Me.Panel_BarraTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ingresarIndividuos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ingresarIndividuos"
        Me.Panel_BarraTitulo.ResumeLayout(False)
        Me.panel_acciones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonMinimizar As Button
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents Panel_BarraTitulo As Panel
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents btn_registrar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents panel_acciones As Panel
    Friend WithEvents cbo_edad As ComboBox
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents lbl_edad As Label
    Friend WithEvents lbl_sexo As Label
    Friend WithEvents cbo_sexo As ComboBox
    Friend WithEvents lbl_interes As Label
    Friend WithEvents cbo_interes As ComboBox
    Friend WithEvents lbl_educacion As Label
    Friend WithEvents cbo_educacion As ComboBox
    Friend WithEvents lbl_ocupacion As Label
    Friend WithEvents cbo_ocupacion As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbo_personalidad As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbo_deportes As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbo_viajar As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbo_cine As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbo_leer As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbo_musica As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cbo_religion As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbo_salud As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbo_apariencia As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_nickname As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cbo_familia As ComboBox
    Friend WithEvents btn_limpiar As Button
End Class
