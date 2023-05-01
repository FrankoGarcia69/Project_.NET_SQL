Imports System.Data.SqlClient

Public Class Conexion
    'Funcion Conexion
    Public Function GetUrl() As String
        Dim url As String
        url = "Server = ; Database = ; UID = ; pwd = " 'Cambiar los Parametros para conectarse a su DB; Server de clase = 3.128.144.165
        GetUrl = url
    End Function
End Class
