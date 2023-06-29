<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class comparaciones
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
        Me.Panel_BarraTitulo = New System.Windows.Forms.Panel()
        Me.ButtonMinimizar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_nombre1 = New System.Windows.Forms.ComboBox()
        Me.Grid_individuos = New System.Windows.Forms.DataGridView()
        Me.panel_acciones = New System.Windows.Forms.Panel()
        Me.btn_Mostrar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbo_nombre2 = New System.Windows.Forms.ComboBox()
        Me.btn_comparar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel_BarraTitulo.SuspendLayout()
        CType(Me.Grid_individuos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_acciones.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Panel_BarraTitulo.Size = New System.Drawing.Size(907, 36)
        Me.Panel_BarraTitulo.TabIndex = 25
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
        Me.ButtonMinimizar.Location = New System.Drawing.Point(826, 0)
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
        Me.ButtonSalir.Location = New System.Drawing.Point(866, 0)
        Me.ButtonSalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(41, 36)
        Me.ButtonSalir.TabIndex = 2
        Me.ButtonSalir.Text = "X"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Indigo
        Me.Label1.Location = New System.Drawing.Point(38, 134)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 32)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Selecciona tu nombre"
        '
        'cbo_nombre1
        '
        Me.cbo_nombre1.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.cbo_nombre1.FormattingEnabled = True
        Me.cbo_nombre1.Location = New System.Drawing.Point(44, 185)
        Me.cbo_nombre1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbo_nombre1.Name = "cbo_nombre1"
        Me.cbo_nombre1.Size = New System.Drawing.Size(263, 30)
        Me.cbo_nombre1.TabIndex = 69
        '
        'Grid_individuos
        '
        Me.Grid_individuos.AllowUserToAddRows = False
        Me.Grid_individuos.AllowUserToDeleteRows = False
        Me.Grid_individuos.AllowUserToResizeColumns = False
        Me.Grid_individuos.AllowUserToResizeRows = False
        Me.Grid_individuos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grid_individuos.Location = New System.Drawing.Point(43, 322)
        Me.Grid_individuos.Margin = New System.Windows.Forms.Padding(4)
        Me.Grid_individuos.Name = "Grid_individuos"
        Me.Grid_individuos.RowHeadersWidth = 51
        Me.Grid_individuos.Size = New System.Drawing.Size(817, 137)
        Me.Grid_individuos.TabIndex = 70
        '
        'panel_acciones
        '
        Me.panel_acciones.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.panel_acciones.Controls.Add(Me.btn_Mostrar)
        Me.panel_acciones.Controls.Add(Me.btn_eliminar)
        Me.panel_acciones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_acciones.Location = New System.Drawing.Point(0, 522)
        Me.panel_acciones.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panel_acciones.Name = "panel_acciones"
        Me.panel_acciones.Size = New System.Drawing.Size(907, 49)
        Me.panel_acciones.TabIndex = 71
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_Mostrar.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Mostrar.Location = New System.Drawing.Point(688, 0)
        Me.btn_Mostrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(107, 49)
        Me.btn_Mostrar.TabIndex = 75
        Me.btn_Mostrar.Text = "Mostrar Todos"
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.Red
        Me.btn_eliminar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_eliminar.Location = New System.Drawing.Point(795, 0)
        Me.btn_eliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(112, 49)
        Me.btn_eliminar.TabIndex = 37
        Me.btn_eliminar.Text = "Salir"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Indigo
        Me.Label2.Location = New System.Drawing.Point(429, 134)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(441, 32)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Selecciona a alguien para comparar"
        '
        'cbo_nombre2
        '
        Me.cbo_nombre2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_nombre2.FormattingEnabled = True
        Me.cbo_nombre2.Location = New System.Drawing.Point(435, 185)
        Me.cbo_nombre2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbo_nombre2.Name = "cbo_nombre2"
        Me.cbo_nombre2.Size = New System.Drawing.Size(263, 30)
        Me.cbo_nombre2.TabIndex = 73
        '
        'btn_comparar
        '
        Me.btn_comparar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_comparar.Location = New System.Drawing.Point(320, 234)
        Me.btn_comparar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_comparar.Name = "btn_comparar"
        Me.btn_comparar.Size = New System.Drawing.Size(107, 43)
        Me.btn_comparar.TabIndex = 74
        Me.btn_comparar.Text = "Comparar"
        Me.btn_comparar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Indigo
        Me.Label3.Location = New System.Drawing.Point(58, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(802, 68)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Comparacion de Personalidades"
        '
        'comparaciones
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Amistad_LogicaDifusa.My.Resources.Resources.gradiant_bg__1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(907, 571)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_comparar)
        Me.Controls.Add(Me.cbo_nombre2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.panel_acciones)
        Me.Controls.Add(Me.Grid_individuos)
        Me.Controls.Add(Me.cbo_nombre1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel_BarraTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "comparaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "comparaciones"
        Me.Panel_BarraTitulo.ResumeLayout(False)
        CType(Me.Grid_individuos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_acciones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel_BarraTitulo As Panel
    Friend WithEvents ButtonMinimizar As Button
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cbo_nombre1 As ComboBox
    Friend WithEvents Grid_individuos As DataGridView
    Friend WithEvents panel_acciones As Panel
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cbo_nombre2 As ComboBox
    Friend WithEvents btn_comparar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_Mostrar As Button
End Class
