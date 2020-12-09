Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class conexion

    Public conexion As SqlConnection = New SqlConnection("Data Source=DESKTOP-LGDBE5Q\SQLEXPRESS;Initial Catalog=CompuCenter;Integrated Security=True")
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public lectura As SqlDataReader
    Public comando As SqlCommandBuilder
    Public cmd As New SqlCommand


    Public Sub conectar()
        Try
            conexion.Open()
            MessageBox.Show("Conectado con exito")
        Catch ex As Exception
            MessageBox.Show("No se ha podido acceder a la base de datos")
        Finally
            conexion.Close()
        End Try
    End Sub
    '------------------------------------------------------------procedimientos empleados--------------------------------------------
    Public Function consulta()
        Try
            conexion.Open()
            adaptador = New SqlDataAdapter("Select * from Center.empleados", conexion)
            Dim dt As New DataTable
            adaptador.Fill(dt)
            Return dt
            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conexion.Close()
        End Try

    End Function

    Public Function ingresarEmpleado(idcodigo As Integer, identidad As String, nombre As String, direccion As String,
                                         edad As Integer, sexo As String, idpuesto As Integer) As Boolean
        Try
            conexion.Open()
            cmd = New SqlCommand("dbo.RegistrarEmpleado", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@IdCodigo", idcodigo)
            cmd.Parameters.AddWithValue("@Identidad", identidad)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@direccion", direccion)
            cmd.Parameters.AddWithValue("@edad", edad)
            cmd.Parameters.AddWithValue("@sexo", sexo)
            cmd.Parameters.AddWithValue("@Id_Puesto", idpuesto)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function


    Public Function actualizarEmpleado(identidad As String, nombre As String, direccion As String,
                                         edad As String, sexo As String, idpuesto As Integer) As Boolean
        Try
            conexion.Open()
            cmd = New SqlCommand("dbo.ActualizarEmpleado", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@identidad", identidad)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@direccion", direccion)
            cmd.Parameters.AddWithValue("@edad", edad)
            cmd.Parameters.AddWithValue("@sexo", sexo)
            cmd.Parameters.AddWithValue("@Id_Puesto", idpuesto)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function eliminarEmpleado(identidad As String) As Boolean
        Try
            conexion.Open()
            cmd = New SqlCommand("dbo.eliminarEmpleado", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@identidadEmpleado", identidad)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function
End Class






