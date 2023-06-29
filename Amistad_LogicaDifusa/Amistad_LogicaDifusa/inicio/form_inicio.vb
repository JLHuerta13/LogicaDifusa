Imports System.Runtime.InteropServices
Imports System.Data.OleDb
Public Class form_inicio
    Private Sub form_inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enlace()
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Me.Close()
    End Sub

    Private Sub ButtonMinimizar_Click(sender As Object, e As EventArgs) Handles ButtonMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        ingresarIndividuos.Show()
        Me.Hide()
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

    Private Sub form_inicio_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub LabelTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles LabelTitulo.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btn_inicioSesion_Click(sender As Object, e As EventArgs) Handles btn_inicioSesion.Click
        Me.Hide()
        comparaciones.Show()
    End Sub
End Class
