Imports System.Data.OleDb
Imports System.Runtime.InteropServices

Public Class comparaciones
    Private Sub comparaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_informacion()
        '//Mostrar_Tabla()
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Close()
        form_inicio.Show()
    End Sub

    Private Sub ButtonMinimizar_Click(sender As Object, e As EventArgs) Handles ButtonMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
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


    Private Sub cargar_informacion()

        Try

            'Obtiene informacion de una columna
            Dim tabla As New DataTable


            '// Obtiene informacion de una columna
            Dim consulta_sql As String = "SELECT nombre FROM registros"

            'Varuable daptador que realiza el enlace entre la consulta/conexion
            Dim adaptador As New OleDbDataAdapter(consulta_sql, conexion)

            'Llena la informacion que encontro en la variable tabla
            adaptador.Fill(tabla)
            'Llena el combobox con la variable tabla (todos los encontrados)
            cbo_nombre1.DataSource = tabla

            'Muestra la informacion solamente del campo Nombre en el combobox. DisplayMember muestra la info de la columna

            cbo_nombre1.DisplayMember = "Nombre"


            'Obtiene informacion de una columna
            Dim tabla2 As New DataTable


            '// Obtiene informacion de una columna
            Dim consulta_sql2 As String = "SELECT nombre FROM registros"

            'Varuable daptador que realiza el enlace entre la consulta/conexion
            Dim adaptador2 As New OleDbDataAdapter(consulta_sql, conexion)

            'Llena la informacion que encontro en la variable tabla
            adaptador2.Fill(tabla2)
            'Llena el combobox con la variable tabla (todos los encontrados)
            cbo_nombre2.DataSource = tabla2

            'Muestra la informacion solamente del campo Nombre en el combobox. DisplayMember muestra la info de la columna

            cbo_nombre2.DisplayMember = "Nombre"

        Catch ex As Exception

            MsgBox("Error de Operación" & ex.Message, MsgBoxStyle.Critical)

        End Try

    End Sub
    Private Sub Mostrar_Tabla_Todos()
        Try

            Dim Paquete As New DataSet

            Dim Consulta_sql As String

            Dim Adaptador As New OleDbDataAdapter

            Consulta_sql = "SELECT * FROM registros"

            Adaptador = New OleDbDataAdapter(Consulta_sql, conexion)

            Paquete.Tables.Add("registros")

            Adaptador.Fill(Paquete.Tables("registros"))

            Grid_individuos.DataSource = Paquete.Tables("registros")

            Grid_individuos.AllowUserToAddRows = False

            Grid_individuos.Columns("nickname").Width = 100
            Grid_individuos.Columns("nombre").Visible = False
            Grid_individuos.Columns("rangoEdad").Width = 75
            Grid_individuos.Columns("sexo").Width = 50
            Grid_individuos.Columns("nivelEducativo").Width = 100
            Grid_individuos.Columns("ocupacion").Width = 90
            Grid_individuos.Columns("personalidad").Width = 90
            Grid_individuos.Columns("deportes").Width = 75
            Grid_individuos.Columns("gustoViajar").Width = 80
            Grid_individuos.Columns("gustoLeer").Width = 75
            Grid_individuos.Columns("gustoMusica").Width = 80
            Grid_individuos.Columns("apegoReligion").Width = 90
            Grid_individuos.Columns("apegoFamilia").Width = 80
            Grid_individuos.Columns("gustoCine").Width = 80
            Grid_individuos.Columns("estadoSalud").Width = 80
            Grid_individuos.Columns("interes").Width = 80
            Grid_individuos.Columns("apariencia").Width = 80



        Catch ex As Exception
            'Mensaje de error
            MsgBox("Error operacion" & ex.Message, MsgBoxStyle.Critical)


        End Try
    End Sub

    Private Sub Mostrar_Tabla()
        Try

            Dim Paquete As New DataSet

            Dim Consulta_sql As String

            Dim Adaptador As New OleDbDataAdapter

            Consulta_sql = "SELECT * FROM registros WHERE nombre = '" & cbo_nombre1.Text & "' OR nombre = '" & cbo_nombre2.Text & "'"

            Adaptador = New OleDbDataAdapter(Consulta_sql, conexion)

            Paquete.Tables.Add("registros")

            Adaptador.Fill(Paquete.Tables("registros"))

            Grid_individuos.DataSource = Paquete.Tables("registros")

            Grid_individuos.AllowUserToAddRows = False

            Grid_individuos.Columns("nickname").Width = 100
            Grid_individuos.Columns("nombre").Visible = False
            Grid_individuos.Columns("rangoEdad").Width = 75
            Grid_individuos.Columns("sexo").Width = 50
            Grid_individuos.Columns("nivelEducativo").Width = 100
            Grid_individuos.Columns("ocupacion").Width = 90
            Grid_individuos.Columns("personalidad").Width = 90
            Grid_individuos.Columns("deportes").Width = 75
            Grid_individuos.Columns("gustoViajar").Width = 80
            Grid_individuos.Columns("gustoLeer").Width = 75
            Grid_individuos.Columns("gustoMusica").Width = 80
            Grid_individuos.Columns("apegoReligion").Width = 90
            Grid_individuos.Columns("apegoFamilia").Width = 80
            Grid_individuos.Columns("gustoCine").Width = 80
            Grid_individuos.Columns("estadoSalud").Width = 80
            Grid_individuos.Columns("interes").Width = 80
            Grid_individuos.Columns("apariencia").Width = 80



        Catch ex As Exception
            'Mensaje de error
            MsgBox("Error operacion" & ex.Message, MsgBoxStyle.Critical)


        End Try
    End Sub

    Public nombre_individuo As String


    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Me.Close()
        form_inicio.Show()
    End Sub

    Public Comando_Calcular As New OleDb.OleDbCommand


    Private Sub calcular()
        Dim valor As Double
        Dim valor2 As Double
        Dim contador As Double

        Try
            Comando_Calcular.Connection = conexion

            ''//gustoViajar + gustoLeer + gustoMusica + apegoReligion + apegoFamilia + gustoCine + estadoSalud + interes + apariencia 

            '// Rango Edad
            Comando_Calcular = New OleDbCommand("SELECT rangoEdad AS total FROM registros WHERE nombre = '" & cbo_nombre1.Text & "'", conexion)

            valor = Comando_Calcular.ExecuteScalar()

            Comando_Calcular = New OleDbCommand("SELECT rangoEdad AS total FROM registros WHERE nombre = '" & cbo_nombre2.Text & "'", conexion)

            valor2 = Comando_Calcular.ExecuteScalar()

            If valor > 0.5 And valor2 > 0.5 Then

                contador = contador + 1

            ElseIf valor < 0.5 And valor2 < 0.5 Then

                contador = contador + 1

            End If

            '//Sexo

            Comando_Calcular = New OleDbCommand("SELECT sexo AS total FROM registros WHERE nombre = '" & cbo_nombre1.Text & "'", conexion)

            valor = Comando_Calcular.ExecuteScalar()

            Comando_Calcular = New OleDbCommand("SELECT sexo AS total FROM registros WHERE nombre = '" & cbo_nombre2.Text & "'", conexion)

            valor2 = Comando_Calcular.ExecuteScalar()
            If valor > 0.5 And valor2 > 0.5 Then

                contador = contador + 1

            ElseIf valor < 0.5 And valor2 < 0.5 Then

                contador = contador + 1

            End If

            '//nivelEducativo
            Comando_Calcular = New OleDbCommand("SELECT nivelEducativo AS total FROM registros WHERE nombre = '" & cbo_nombre1.Text & "'", conexion)

            valor = Comando_Calcular.ExecuteScalar()

            Comando_Calcular = New OleDbCommand("SELECT nivelEducativo AS total FROM registros WHERE nombre = '" & cbo_nombre2.Text & "'", conexion)

            valor2 = Comando_Calcular.ExecuteScalar()
            If valor > 0.5 And valor2 > 0.5 Then

                contador = contador + 1

            ElseIf valor < 0.5 And valor2 < 0.5 Then

                contador = contador + 1

            End If
            '//ocupacion
            Comando_Calcular = New OleDbCommand("SELECT ocupacion AS total FROM registros WHERE nombre = '" & cbo_nombre1.Text & "'", conexion)

            valor = Comando_Calcular.ExecuteScalar()

            Comando_Calcular = New OleDbCommand("SELECT ocupacion AS total FROM registros WHERE nombre = '" & cbo_nombre2.Text & "'", conexion)

            valor2 = Comando_Calcular.ExecuteScalar()
            If valor > 0.5 And valor2 > 0.5 Then

                contador = contador + 1

            ElseIf valor < 0.5 And valor2 < 0.5 Then

                contador = contador + 1

            End If

            '//personalidad
            Comando_Calcular = New OleDbCommand("SELECT personalidad AS total FROM registros WHERE nombre = '" & cbo_nombre1.Text & "'", conexion)

            valor = Comando_Calcular.ExecuteScalar()

            Comando_Calcular = New OleDbCommand("SELECT personalidad AS total FROM registros WHERE nombre = '" & cbo_nombre2.Text & "'", conexion)

            valor2 = Comando_Calcular.ExecuteScalar()
            If valor > 0.5 And valor2 > 0.5 Then

                contador = contador + 1

            ElseIf valor < 0.5 And valor2 < 0.5 Then

                contador = contador + 1

            End If
            '//deportes
            Comando_Calcular = New OleDbCommand("SELECT deportes AS total FROM registros WHERE nombre = '" & cbo_nombre1.Text & "'", conexion)

            valor = Comando_Calcular.ExecuteScalar()

            Comando_Calcular = New OleDbCommand("SELECT deportes AS total FROM registros WHERE nombre = '" & cbo_nombre2.Text & "'", conexion)

            valor2 = Comando_Calcular.ExecuteScalar()
            If valor > 0.5 And valor2 > 0.5 Then

                contador = contador + 1

            ElseIf valor < 0.5 And valor2 < 0.5 Then

                contador = contador + 1

            End If
            '//gustoViajar
            Comando_Calcular = New OleDbCommand("SELECT gustoViajar AS total FROM registros WHERE nombre = '" & cbo_nombre1.Text & "'", conexion)

            valor = Comando_Calcular.ExecuteScalar()

            Comando_Calcular = New OleDbCommand("SELECT gustoViajar AS total FROM registros WHERE nombre = '" & cbo_nombre2.Text & "'", conexion)

            valor2 = Comando_Calcular.ExecuteScalar()
            If valor > 0.5 And valor2 > 0.5 Then

                contador = contador + 1

            ElseIf valor < 0.5 And valor2 < 0.5 Then

                contador = contador + 1

            End If
            '//gustoLeer
            Comando_Calcular = New OleDbCommand("SELECT gustoLeer AS total FROM registros WHERE nombre = '" & cbo_nombre1.Text & "'", conexion)

            valor = Comando_Calcular.ExecuteScalar()

            Comando_Calcular = New OleDbCommand("SELECT gustoLeer AS total FROM registros WHERE nombre = '" & cbo_nombre2.Text & "'", conexion)

            valor2 = Comando_Calcular.ExecuteScalar()
            If valor > 0.5 And valor2 > 0.5 Then

                contador = contador + 1

            ElseIf valor < 0.5 And valor2 < 0.5 Then

                contador = contador + 1

            End If
            '//gustoMusica
            Comando_Calcular = New OleDbCommand("SELECT gustoMusica AS total FROM registros WHERE nombre = '" & cbo_nombre1.Text & "'", conexion)

            valor = Comando_Calcular.ExecuteScalar()

            Comando_Calcular = New OleDbCommand("SELECT gustoMusica AS total FROM registros WHERE nombre = '" & cbo_nombre2.Text & "'", conexion)

            valor2 = Comando_Calcular.ExecuteScalar()
            If valor > 0.5 And valor2 > 0.5 Then

                contador = contador + 1

            ElseIf valor < 0.5 And valor2 < 0.5 Then

                contador = contador + 1

            End If
            '//apegoReligion
            Comando_Calcular = New OleDbCommand("SELECT apegoReligion AS total FROM registros WHERE nombre = '" & cbo_nombre1.Text & "'", conexion)

            valor = Comando_Calcular.ExecuteScalar()

            Comando_Calcular = New OleDbCommand("SELECT apegoReligion AS total FROM registros WHERE nombre = '" & cbo_nombre2.Text & "'", conexion)

            valor2 = Comando_Calcular.ExecuteScalar()
            If valor > 0.5 And valor2 > 0.5 Then

                contador = contador + 1

            ElseIf valor < 0.5 And valor2 < 0.5 Then

                contador = contador + 1

            End If
            '//apegoFamilia
            Comando_Calcular = New OleDbCommand("SELECT apegoFamilia AS total FROM registros WHERE nombre = '" & cbo_nombre1.Text & "'", conexion)

            valor = Comando_Calcular.ExecuteScalar()

            Comando_Calcular = New OleDbCommand("SELECT apegoFamilia AS total FROM registros WHERE nombre = '" & cbo_nombre2.Text & "'", conexion)

            valor2 = Comando_Calcular.ExecuteScalar()
            If valor > 0.5 And valor2 > 0.5 Then

                contador = contador + 1

            ElseIf valor < 0.5 And valor2 < 0.5 Then

                contador = contador + 1

            End If
            '//gustoCine
            Comando_Calcular = New OleDbCommand("SELECT gustoCine AS total FROM registros WHERE nombre = '" & cbo_nombre1.Text & "'", conexion)

            valor = Comando_Calcular.ExecuteScalar()

            Comando_Calcular = New OleDbCommand("SELECT gustoCine AS total FROM registros WHERE nombre = '" & cbo_nombre2.Text & "'", conexion)

            valor2 = Comando_Calcular.ExecuteScalar()
            If valor > 0.5 And valor2 > 0.5 Then

                contador = contador + 1

            ElseIf valor < 0.5 And valor2 < 0.5 Then

                contador = contador + 1

            End If
            '//estadoSalud
            Comando_Calcular = New OleDbCommand("SELECT estadoSalud AS total FROM registros WHERE nombre = '" & cbo_nombre1.Text & "'", conexion)

            valor = Comando_Calcular.ExecuteScalar()

            Comando_Calcular = New OleDbCommand("SELECT estadoSalud AS total FROM registros WHERE nombre = '" & cbo_nombre2.Text & "'", conexion)

            valor2 = Comando_Calcular.ExecuteScalar()
            If valor > 0.5 And valor2 > 0.5 Then

                contador = contador + 1

            ElseIf valor < 0.5 And valor2 < 0.5 Then

                contador = contador + 1

            End If
            '// interes 

            Comando_Calcular = New OleDbCommand("SELECT interes AS total FROM registros WHERE nombre = '" & cbo_nombre1.Text & "'", conexion)

            valor = Comando_Calcular.ExecuteScalar()

            Comando_Calcular = New OleDbCommand("SELECT interes AS total FROM registros WHERE nombre = '" & cbo_nombre2.Text & "'", conexion)

            valor2 = Comando_Calcular.ExecuteScalar()
            If valor > 0.5 And valor2 > 0.5 Then

                contador = contador + 1

            ElseIf valor < 0.5 And valor2 < 0.5 Then

                contador = contador + 1

            End If
            '//apariencia
            Comando_Calcular = New OleDbCommand("SELECT apariencia AS total FROM registros WHERE nombre = '" & cbo_nombre1.Text & "'", conexion)

            valor = Comando_Calcular.ExecuteScalar()

            Comando_Calcular = New OleDbCommand("SELECT apariencia AS total FROM registros WHERE nombre = '" & cbo_nombre2.Text & "'", conexion)

            valor2 = Comando_Calcular.ExecuteScalar()
            If valor > 0.5 And valor2 > 0.5 Then

                contador = contador + 1

            ElseIf valor < 0.5 And valor2 < 0.5 Then

                contador = contador + 1

            End If

            '//Calculo final
            If contador > 10 Then
                MsgBox(cbo_nombre1.Text & " y " & cbo_nombre2.Text & " Son muy compatibles")

            ElseIf contador > 5 Then
                MsgBox(cbo_nombre1.Text & " y " & cbo_nombre2.Text & " Son compatibles")

            Else
                MsgBox(cbo_nombre1.Text & " y " & cbo_nombre2.Text & " No son compatibles")
            End If

            Mostrar_Tabla()

            '//MsgBox(valor, MsgBoxStyle.Information)
            '//Console.WriteLine(valor)
        Catch ex As Exception

            MsgBox("Error de Operacion " & ex.Message, MsgBoxStyle.Critical)

        End Try


    End Sub

    Private Sub btn_comparar_Click_1(sender As Object, e As EventArgs) Handles btn_comparar.Click
        calcular()
    End Sub

    Private Sub btn_Mostrar_Click(sender As Object, e As EventArgs) Handles btn_Mostrar.Click
        Mostrar_Tabla_Todos()
    End Sub
End Class