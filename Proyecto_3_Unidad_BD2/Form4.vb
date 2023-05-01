Imports System.Data.SqlClient

Public Class Form4
    Dim tablaClientePago As New DataTable
    Dim adapClientePago As New SqlDataAdapter
    Dim tablaDatosProveedor As New DataTable
    Dim adapDatosProveedor As New SqlDataAdapter
    Dim url As New Conexion
    Dim con As SqlConnection
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        

        'Conexion
        con = New SqlConnection(url.GetUrl)

        'Funcion Tipo Tabla fClientePago()
        adapClientePago.SelectCommand = New SqlCommand("select * from fClientePago()", con)
        adapClientePago.SelectCommand.CommandType = CommandType.Text

        'DataGridView ClientePago
        adapClientePago.Fill(tablaClientePago)
        DataGridView1.DataSource = tablaClientePago

        

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Funcion Tipo Tabla datosProveedor(#)
        adapDatosProveedor.SelectCommand = New SqlCommand("select * from datosProveedor(" & TextBox1.Text & ")", con)
        adapDatosProveedor.SelectCommand.CommandType = CommandType.Text

        'DataGridView DatosProveedor
        adapDatosProveedor.Fill(tablaDatosProveedor)
        DataGridView2.DataSource = tablaDatosProveedor
    End Sub
End Class