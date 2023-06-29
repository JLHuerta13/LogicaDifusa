Imports System.Data.OleDb
Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices


Public Class ingresarIndividuos

    Dim edad As Double
    Dim sexo As Double
    Dim interes As Double
    Dim educacion As Double
    Dim ocupacion As Double
    Dim personalidad As Double
    Dim deportes As Double
    Dim viajar As Double
    Dim leer As Double
    Dim musica As Double
    Dim cine As Double
    Dim religion As Double
    Dim familia As Double
    Dim salud As Double
    Dim apariencia As Double


    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Close()
        form_inicio.Show()
    End Sub

    Private Sub ButtonMinimizar_Click(sender As Object, e As EventArgs) Handles ButtonMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Me.Close()
        form_inicio.Show()
    End Sub

    '//**************************************************************
    '// Librerias y eventos para poder mover de lugar el formulario
    '//**************************************************************
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub Panel_BarraTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel_BarraTitulo.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub


    Public Comando_Registar As New OleDb.OleDbCommand

    Private Sub Ingresar_registro()
        Try

            Comando_Registar.Connection = conexion
            Comando_Registar = New OleDb.OleDbCommand("INSERT INTO registros(nickname, nombre, rangoEdad, sexo, interes, nivelEducativo, ocupacion, personalidad, deportes, gustoViajar, gustoLeer, gustoMusica, gustoCine, apegoReligion, apegoFamilia, estadoSalud, apariencia)" & Chr(13) &
                                                      "VALUES(nickname, nombre, rangoEdad, sexo, interes, nivelEducativo, ocupacion, personalidad, deportes, gustoViajar, gustoLeer, gustoMusica, gustoCine, apegoReligion, apegoFamilia, estadoSalud, apariencia)", conexion)
            'nickname, nombre, rangoEdad, sexo, interes, nivelEducativo, ocupacion, personalidad,
            'deportes, gustoViajar, gustoLeer, gustoMusica, gustoCine, apegoReligion, apegoFamilia,
            'estadoSalud, apariencia

            Comando_Registar.Parameters.AddWithValue("@nickname", txt_nickname.Text)
            Comando_Registar.Parameters.AddWithValue("@nombre", txt_nombre.Text)
            Comando_Registar.Parameters.AddWithValue("@rangoEdad", edad)
            Comando_Registar.Parameters.AddWithValue("@sexo", sexo)
            Comando_Registar.Parameters.AddWithValue("@interes", interes)
            Comando_Registar.Parameters.AddWithValue("@nivelEducativo", educacion)
            Comando_Registar.Parameters.AddWithValue("@ocupacion", ocupacion)
            Comando_Registar.Parameters.AddWithValue("@personalidad", personalidad)
            Comando_Registar.Parameters.AddWithValue("@deportes", deportes)
            Comando_Registar.Parameters.AddWithValue("@gustoViajar", viajar)
            Comando_Registar.Parameters.AddWithValue("@gustoLeer", leer)
            Comando_Registar.Parameters.AddWithValue("@gustoMusica", musica)
            Comando_Registar.Parameters.AddWithValue("@gustoCine", cine)
            Comando_Registar.Parameters.AddWithValue("@apegoReligion", religion)
            Comando_Registar.Parameters.AddWithValue("@apegoFamilia", familia)
            Comando_Registar.Parameters.AddWithValue("@estadoSalud", salud)
            Comando_Registar.Parameters.AddWithValue("@apariencia", apariencia)


            Comando_Registar.ExecuteNonQuery()

        Catch ex As Exception
            '//************************************MENSAJE DE ERROR************************************
            MsgBox("Error de Operacion" & ex.Message, MsgBoxStyle.Critical)
            '//************************************MENSAJE DE ERROR************************************

        End Try


    End Sub

    Private Sub Reiniciar_Valores()
        txt_nickname.Clear()
        txt_nombre.Clear()
        cbo_apariencia.Text = "Selecciona"
        cbo_cine.Text = "Selecciona"
        cbo_deportes.Text = "Selecciona"
        cbo_edad.Text = "Selecciona"
        cbo_educacion.Text = "Selecciona"
        cbo_familia.Text = "Selecciona"
        cbo_interes.Text = "Selecciona"
        cbo_leer.Text = "Selecciona"
        cbo_musica.Text = "Selecciona"
        cbo_ocupacion.Text = "Selecciona"
        cbo_personalidad.Text = "Selecciona"
        cbo_religion.Text = "Selecciona"
        cbo_salud.Text = "Selecciona"
        cbo_sexo.Text = "Selecciona"
        cbo_viajar.Text = "Selecciona"
    End Sub

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles btn_registrar.Click
        If txt_nickname.Text = Nothing Or
        txt_nombre.Text = Nothing Or
        cbo_apariencia.Text = "Selecciona" Or
        cbo_cine.Text = "Selecciona" Or
        cbo_deportes.Text = "Selecciona" Or
        cbo_edad.Text = "Selecciona" Or
        cbo_educacion.Text = "Selecciona" Or
        cbo_interes.Text = "Selecciona" Or
        cbo_leer.Text = "Selecciona" Or
        cbo_musica.Text = "Selecciona" Or
        cbo_ocupacion.Text = "Selecciona" Or
        cbo_personalidad.Text = "Selecciona" Or
        cbo_religion.Text = "Selecciona" Or
        cbo_familia.Text = "Selecciona" Or
        cbo_salud.Text = "Selecciona" Or
        cbo_sexo.Text = "Selecciona" Or
        cbo_viajar.Text = "Selecciona" Then

            '//************************************MENSAJE DE ERROR************************************
            MsgBox("Hay cuadros en blanco. Ingresa la información necesaria" & MsgBoxStyle.Critical)
            '//************************************MENSAJE DE ERROR************************************

        Else
            Dim Respuesta As DialogResult = MessageBox.Show("Se registrara un nuevo individuo, ¿Desea continuar?", "Nuevo individuo", MessageBoxButtons.YesNo)

            If Respuesta = DialogResult.Yes Then
                '// Instrucciones si el usuario presiona SI
                Ingresar_registro()
                Reiniciar_Valores()


            ElseIf Respuesta = DialogResult.No Then
                '// Instrucciones si el usuario presiona NO

            End If


        End If
    End Sub

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        Reiniciar_Valores()
    End Sub

    Private Sub cbo_edad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_edad.SelectedIndexChanged
        ' 15-17
        ' 18-20
        ' 21-23
        ' 24-26
        ' 27-30
        If cbo_edad.Text = "15-17" Then
            edad = 0.2
        ElseIf cbo_edad.Text = "18-20" Then
            edad = 0.4
        ElseIf cbo_edad.Text = "21-23" Then
            edad = 0.6
        ElseIf cbo_edad.Text = "24-26" Then
            edad = 0.8
        ElseIf cbo_edad.Text = "27-30" Then
            edad = 1.0
        End If
    End Sub

    Private Sub cbo_sexo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_sexo.SelectedIndexChanged
        'Hombre
        'Mujer
        If cbo_sexo.Text = "Hombre" Then
            sexo = 1
        ElseIf cbo_sexo.Text = "Mujer" Then
            sexo = 0
        End If
    End Sub

    Private Sub cbo_interes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_interes.SelectedIndexChanged
        'Hombres
        'Mujeres
        If cbo_interes.Text = "Hombres" Then
            interes = 1
        ElseIf cbo_interes.Text = "Mujeres" Then
            interes = 0
        End If
    End Sub

    Private Sub cbo_educacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_educacion.SelectedIndexChanged
        'Básica
        'Media
        'Superior
        If cbo_educacion.Text = "Basica" Then
            educacion = 0
        End If
        If cbo_educacion.Text = "Media" Then
            educacion = 0.5
        End If
        If cbo_educacion.Text = "Superior" Then
            educacion = 1
        End If
    End Sub

    Private Sub cbo_ocupacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_ocupacion.SelectedIndexChanged
        'Estudiante
        'Trabajador
        'Desempleado.
        If cbo_ocupacion.Text = "Estudiante" Then
            ocupacion = 0.5
        ElseIf cbo_ocupacion.Text = "Trabajador" Then
            ocupacion = 1
        ElseIf cbo_ocupacion.Text = "Desempleado" Then
            ocupacion = 0
        End If
    End Sub

    Private Sub cbo_personalidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_personalidad.SelectedIndexChanged
        'Introvertida
        'Extrovertida
        If cbo_personalidad.Text = "Introvertida" Then
            personalidad = 0
        ElseIf cbo_personalidad.Text = "Extrovertida" Then
            personalidad = 1
        End If
    End Sub

    Private Sub cbo_deportes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_deportes.SelectedIndexChanged
        'Nula
        'Leve
        'Moderada
        'Alta
        'Profesional
        If cbo_deportes.Text = "Nula" Then
            deportes = 0.2
        ElseIf cbo_deportes.Text = "Leve" Then
            deportes = 0.4
        ElseIf cbo_deportes.Text = "Moderada" Then
            deportes = 0.6
        ElseIf cbo_deportes.Text = "Alta" Then
            deportes = 0.8
        ElseIf cbo_deportes.Text = "Profesional" Then
            deportes = 1.0
        End If
    End Sub

    Private Sub cbo_viajar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_viajar.SelectedIndexChanged
        'Nulo
        'Leve
        'Moderado
        'Alto
        If cbo_viajar.Text = "Nulo" Then
            viajar = 0.25
        ElseIf cbo_viajar.Text = "Leve" Then
            viajar = 0.5
        ElseIf cbo_viajar.Text = "Moderado" Then
            viajar = 0.75
        ElseIf cbo_viajar.Text = "Alto" Then
            viajar = 1
        End If
    End Sub

    Private Sub cbo_cine_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_cine.SelectedIndexChanged
        'Nulo
        'Leve
        'Moderado
        'Alto
        If cbo_cine.Text = "Nulo" Then
            cine = 0.25
        ElseIf cbo_cine.Text = "Leve" Then
            cine = 0.5
        ElseIf cbo_cine.Text = "Moderado" Then
            cine = 0.75
        ElseIf cbo_cine.Text = "Alto" Then
            cine = 1
        End If
    End Sub

    Private Sub cbo_leer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_leer.SelectedIndexChanged
        'Nulo
        'Leve
        'Moderado
        'Alto
        If cbo_leer.Text = "Nulo" Then
            leer = 0.25
        ElseIf cbo_leer.Text = "Leve" Then
            leer = 0.5
        ElseIf cbo_leer.Text = "Moderado" Then
            leer = 0.75
        ElseIf cbo_leer.Text = "Alto" Then
            leer = 1
        End If
    End Sub

    Private Sub cbo_musica_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_musica.SelectedIndexChanged
        'Nulo
        'Leve
        'Moderado
        'Alto
        If cbo_musica.Text = "Nulo" Then
            musica = 0.25
        ElseIf cbo_musica.Text = "Leve" Then
            musica = 0.5
        ElseIf cbo_musica.Text = "Moderado" Then
            musica = 0.75
        ElseIf cbo_musica.Text = "Alto" Then
            musica = 1
        End If
    End Sub

    Private Sub cbo_religion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_religion.SelectedIndexChanged
        'Nulo
        'Leve
        'Moderado
        'Alto
        If cbo_religion.Text = "Nulo" Then
            religion = 0.25
        ElseIf cbo_religion.Text = "Leve" Then
            religion = 0.5
        ElseIf cbo_religion.Text = "Moderado" Then
            religion = 0.75
        ElseIf cbo_religion.Text = "Alto" Then
            religion = 1
        End If
    End Sub

    Private Sub cbo_familia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_familia.SelectedIndexChanged
        'Nulo
        'Leve
        'Moderado
        'Alto
        If cbo_familia.Text = "Nulo" Then
            familia = 0.25
        ElseIf cbo_familia.Text = "Leve" Then
            familia = 0.5
        ElseIf cbo_familia.Text = "Moderado" Then
            familia = 0.75
        ElseIf cbo_familia.Text = "Alto" Then
            familia = 1
        End If
    End Sub

    Private Sub cbo_salud_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_salud.SelectedIndexChanged
        'Muy mala
        'Mala
        'Buena
        'Muy buena
        If cbo_salud.Text = "Muy mala" Then
            salud = 0.25
        ElseIf cbo_salud.Text = "Mala" Then
            salud = 0.5
        ElseIf cbo_salud.Text = "Buena" Then
            salud = 0.75
        ElseIf cbo_salud.Text = "Muy buena" Then
            salud = 1
        End If
    End Sub

    Private Sub cbo_apariencia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_apariencia.SelectedIndexChanged
        'apariencia
        'personalidad
        If cbo_apariencia.Text = "ápariencia" Then
            apariencia = 1
        ElseIf cbo_apariencia.Text = "personalidad" Then
            apariencia = 0
        End If
    End Sub

    Private Sub ingresarIndividuos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reiniciar_Valores()
    End Sub

    Private Sub cbo_edad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbo_edad.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub cbo_sexo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbo_viajar.KeyPress, cbo_sexo.KeyPress, cbo_salud.KeyPress, cbo_religion.KeyPress, cbo_personalidad.KeyPress, cbo_ocupacion.KeyPress, cbo_musica.KeyPress, cbo_leer.KeyPress, cbo_interes.KeyPress, cbo_familia.KeyPress, cbo_educacion.KeyPress, cbo_deportes.KeyPress, cbo_cine.KeyPress, cbo_apariencia.KeyPress
        e.KeyChar = ""
    End Sub
End Class