Imports System.Data.SqlClient

Public Class Form2
    Dim tablaProveedor As New DataTable
    Dim adapProveedor As New SqlDataAdapter
    Dim tablaCliente As New DataTable
    Dim adapCliente As New SqlDataAdapter
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim url As New Conexion
        Dim con As SqlConnection

        'Conexion
        con = New SqlConnection(url.GetUrl)

        'Tabla Proveedor
        'Select
        adapProveedor.SelectCommand = New SqlCommand("spObtenerProveedores", con)
        adapProveedor.SelectCommand.CommandType = CommandType.StoredProcedure

        'Insert
        adapProveedor.InsertCommand = New SqlCommand("spInsertarProveedor", con)
        adapProveedor.InsertCommand.CommandType = CommandType.StoredProcedure
        adapProveedor.InsertCommand.Parameters.Add("@proveedorID", SqlDbType.Int, 4, "proveedorID")
        adapProveedor.InsertCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50, "nombre")
        adapProveedor.InsertCommand.Parameters.Add("@valor_Crediticio", SqlDbType.Decimal, 20, "valor_Crediticio")
        adapProveedor.InsertCommand.Parameters.Add("@saldo", SqlDbType.Float, 20, "saldo")
        adapProveedor.InsertCommand.Parameters.Add("@tipo_proveedor_id", SqlDbType.Char, 4, "tipo_proveedor_id")

        'Update
        adapProveedor.UpdateCommand = New SqlCommand("spActualizarProveedor", con)
        adapProveedor.UpdateCommand.CommandType = CommandType.StoredProcedure
        adapProveedor.UpdateCommand.Parameters.Add("@proveedorID", SqlDbType.Int, 4, "proveedorID")
        adapProveedor.UpdateCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50, "nombre")
        adapProveedor.UpdateCommand.Parameters.Add("@valor_Crediticio", SqlDbType.Decimal, 20, "valor_Crediticio")
        adapProveedor.UpdateCommand.Parameters.Add("@saldo", SqlDbType.Float, 20, "saldo")
        adapProveedor.UpdateCommand.Parameters.Add("@tipo_proveedor_id", SqlDbType.Char, 4, "tipo_proveedor_id")

        'Delete
        adapProveedor.DeleteCommand = New SqlCommand("spEliminarProveedor", con)
        adapProveedor.DeleteCommand.CommandType = CommandType.StoredProcedure
        adapProveedor.DeleteCommand.Parameters.Add("@proveedorID", SqlDbType.Int, 4, "proveedorID")

        'DataGridView Proveedor
        adapProveedor.Fill(tablaProveedor)
        DataGridView1.DataSource = tablaProveedor
        'DataGridView1.Columns("proveedorID").ReadOnly = True

        'Tabla Cliente
        'Select
        adapCliente.SelectCommand = New SqlCommand("spSeleccionarCliente", con)
        adapCliente.SelectCommand.CommandType = CommandType.StoredProcedure

        'Insert
        adapCliente.InsertCommand = New SqlCommand("spInsertarCliente", con)
        adapCliente.InsertCommand.CommandType = CommandType.StoredProcedure
        adapCliente.InsertCommand.Parameters.Add("@clienteID", SqlDbType.Int, 4, "clienteID")
        adapCliente.InsertCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50, "nombre")
        adapCliente.InsertCommand.Parameters.Add("@dni", SqlDbType.VarChar, 50, "dni")
        adapCliente.InsertCommand.Parameters.Add("@saldo", SqlDbType.Float, 20, "saldo")
        adapCliente.InsertCommand.Parameters.Add("@cliente_tipo_id", SqlDbType.VarChar, 10, "cliente_tipo_id")

        'Update
        adapCliente.UpdateCommand = New SqlCommand("spActualizarCliente", con)
        adapCliente.UpdateCommand.CommandType = CommandType.StoredProcedure
        adapCliente.UpdateCommand.Parameters.Add("@clienteID", SqlDbType.Int, 4, "clienteID")
        adapCliente.UpdateCommand.Parameters.Add("@nombre", SqlDbType.VarChar, 50, "nombre")
        adapCliente.UpdateCommand.Parameters.Add("@dni", SqlDbType.VarChar, 50, "dni")
        adapCliente.UpdateCommand.Parameters.Add("@saldo", SqlDbType.Float, 20, "saldo")
        adapCliente.UpdateCommand.Parameters.Add("@cliente_tipo_id", SqlDbType.VarChar, 10, "cliente_tipo_id")

        'Delete
        adapCliente.DeleteCommand = New SqlCommand("spEliminarCliente", con)
        adapCliente.DeleteCommand.CommandType = CommandType.StoredProcedure
        adapCliente.DeleteCommand.Parameters.Add("@clienteID", SqlDbType.Int, 4, "clienteID")

        'DataGridView Cliente
        adapCliente.Fill(tablaCliente)
        DataGridView2.DataSource = tablaCliente
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            adapProveedor.Update(tablaProveedor)
            MsgBox("Los datos se han Actualizado")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()

        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            adapCliente.Update(tablaCliente)
            MsgBox("Los datos se han Actualizado")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class