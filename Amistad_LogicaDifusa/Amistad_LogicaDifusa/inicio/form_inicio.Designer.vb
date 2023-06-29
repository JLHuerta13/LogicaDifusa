<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_inicio))
        Me.Panel_BarraTitulo = New System.Windows.Forms.Panel()
        Me.ButtonMinimizar = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.LabelTitulo = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.lbl_usuarios = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_inicioSesion = New System.Windows.Forms.Button()
        Me.Panel_BarraTitulo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel_BarraTitulo.Size = New System.Drawing.Size(857, 30)
        Me.Panel_BarraTitulo.TabIndex = 23
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
        Me.ButtonMinimizar.Location = New System.Drawing.Point(776, 0)
        Me.ButtonMinimizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonMinimizar.Name = "ButtonMinimizar"
        Me.ButtonMinimizar.Size = New System.Drawing.Size(40, 30)
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
        Me.ButtonSalir.Location = New System.Drawing.Point(816, 0)
        Me.ButtonSalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(41, 30)
        Me.ButtonSalir.TabIndex = 2
        Me.ButtonSalir.Text = "X"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'LabelTitulo
        '
        Me.LabelTitulo.AutoSize = True
        Me.LabelTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LabelTitulo.Font = New System.Drawing.Font("MS Reference Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitulo.ForeColor = System.Drawing.Color.Indigo
        Me.LabelTitulo.Location = New System.Drawing.Point(63, 60)
        Me.LabelTitulo.Name = "LabelTitulo"
        Me.LabelTitulo.Size = New System.Drawing.Size(277, 87)
        Me.LabelTitulo.TabIndex = 22
        Me.LabelTitulo.Text = "Búsqueda de amistad " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "aplicando " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lógica Difusa"
        Me.LabelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(-35, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(77, 17)
        Me.LinkLabel1.TabIndex = 30
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "LinkLabel1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(188, 218)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 29
        '
        'btn_submit
        '
        Me.btn_submit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_submit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_submit.Location = New System.Drawing.Point(641, 82)
        Me.btn_submit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(177, 66)
        Me.btn_submit.TabIndex = 28
        Me.btn_submit.Text = "Ingresar nuevo individuo"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'lbl_usuarios
        '
        Me.lbl_usuarios.AutoSize = True
        Me.lbl_usuarios.BackColor = System.Drawing.Color.Transparent
        Me.lbl_usuarios.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuarios.ForeColor = System.Drawing.Color.Indigo
        Me.lbl_usuarios.Location = New System.Drawing.Point(467, 316)
        Me.lbl_usuarios.Name = "lbl_usuarios"
        Me.lbl_usuarios.Size = New System.Drawing.Size(180, 138)
        Me.lbl_usuarios.TabIndex = 26
        Me.lbl_usuarios.Text = "* Daniel Alejandro " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Treviño Garza" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "* Jorge Luis " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Huerta Vargas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "* Guillermo Sal" &
    "gado " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Calva"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(44, 272)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(392, 214)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'btn_inicioSesion
        '
        Me.btn_inicioSesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_inicioSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_inicioSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_inicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_inicioSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_inicioSesion.Location = New System.Drawing.Point(641, 171)
        Me.btn_inicioSesion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_inicioSesion.Name = "btn_inicioSesion"
        Me.btn_inicioSesion.Size = New System.Drawing.Size(177, 42)
        Me.btn_inicioSesion.TabIndex = 32
        Me.btn_inicioSesion.Text = "Iniciar"
        Me.btn_inicioSesion.UseVisualStyleBackColor = True
        '
        'form_inicio
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Amistad_LogicaDifusa.My.Resources.Resources.gradiant_bg__1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(857, 516)
        Me.Controls.Add(Me.btn_inicioSesion)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel_BarraTitulo)
        Me.Controls.Add(Me.LabelTitulo)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.lbl_usuarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "form_inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel_BarraTitulo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel_BarraTitulo As Panel
    Friend WithEvents ButtonMinimizar As Button
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents LabelTitulo As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_submit As Button
    Friend WithEvents lbl_usuarios As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_inicioSesion As Button
End Class
