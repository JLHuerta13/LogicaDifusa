'*************************************************
'Librerias para conexion a una Base de Datos
'*************************************************

Imports System.Data
Imports System.Data.OleDb


Module conexion_access

    '********************* StartupPath : El directorio desde el que se ejecuta el exe de la aplicación
    Public ruta As String = Application.StartupPath

    '*************************************************
    'Enlance a la base de datos
    '*************************************************
    Public conexion As New OleDbConnection

    Sub enlace()

        conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " & vbLf &
            ruta + "\RecursosSistema\database\bancoDePerfles1.accdb"
        conexion.Open()

    End Sub

End Module
