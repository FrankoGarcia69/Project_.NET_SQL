Imports System.Data.SqlClient

Public Class Form3
    Dim tablaSaldos As New DataTable
    Dim adapSaldos As New SqlDataAdapter
    Dim tablaPedidos As New DataTable
    Dim adapPedidos As New SqlDataAdapter
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim url As String
        Dim con As SqlConnection

        'Conexion
        url = "Server = 3.128.144.165; Database = DB20182000189; UID = franko.garcia; pwd = fgarcia"
        con = New SqlConnection(url)

        'Vista Saldos
        adapSaldos.SelectCommand = New SqlCommand("select * from vwCliente", con)
        adapSaldos.SelectCommand.CommandType = CommandType.Text

        'DataGridView Saldos
        adapSaldos.Fill(tablaSaldos)
        DataGridView1.DataSource = tablaSaldos

        'Vista Pedidos
        adapPedidos.SelectCommand = New SqlCommand("select * from vwPedidos", con)
        adapPedidos.SelectCommand.CommandType = CommandType.Text

        'DataGridView Pedidos
        adapPedidos.Fill(tablaPedidos)
        DataGridView2.DataSource = tablaPedidos


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()

        Form1.Show()
    End Sub
End Class