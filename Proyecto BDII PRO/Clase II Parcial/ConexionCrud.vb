Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class ConexionCrud

    Public conexion As SqlConnection = New SqlConnection("Data Source=DESKTOP-L87VDHJ;Initial Catalog=CompuCenter;Integrated Security=True")
    Public cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet
    Public da As SqlDataAdapter
    Public comando As SqlCommand
    Public dr As SqlDataReader

    Public Sub conectar()
        Try
            conexion.Open()
        Catch ex As Exception
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub Consulta(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub
    Function eliminar(ByVal tabla, ByVal condicion)
        Try
            conexion.Open()
            Dim elimina As String = "delete from " + tabla + " where " + condicion
            comando = New SqlCommand(elimina, conexion)
            Dim i As Integer = comando.ExecuteNonQuery()
            conexion.Close()
            If (i > 0) Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MessageBox.Show("Elimine primero el empleado")
        End Try
    End Function

    Function actualizar(ByVal sql)
        conexion.Open()
        comando = New SqlCommand(sql, conexion)
        Dim i As Integer = comando.ExecuteNonQuery
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function validarEmpleados(ByVal codigo As String) As Boolean
        Dim respuesta As Boolean = False
        Try
            conexion.Open()
            comando = New SqlCommand("select * from Center.empleados where IdCodigo = '" + codigo + "'", conexion)
            dr = comando.ExecuteReader
            If dr.Read Then
                respuesta = True
                dr.Close()

            End If
            conexion.Close
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return respuesta
    End Function

    Function Insertar(ByVal sql)
        conexion.Open()
        comando = New SqlCommand(sql, conexion)
        Dim i As Integer = comando.ExecuteNonQuery
        conexion.Close()

        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function validarStock(ByVal codigo As String) As Boolean
        Dim respuesta As Boolean = False
        Try
            conexion.Open()
            comando = New SqlCommand("select * from Center.stock where IdCodigo = '" + codigo + "'", conexion)
            dr = comando.ExecuteReader
            If dr.Read Then
                respuesta = True
                dr.Close()

            End If
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return respuesta
    End Function

    Function MostrarAsignacion(ByVal sql)
        conexion.Open()
        comando = New SqlCommand(sql, conexion)
        Dim i As Integer = comando.ExecuteNonQuery
        conexion.Close()

        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function paquetes(ByVal sql)
        conexion.Open()
        comando = New SqlCommand(sql, conexion)
        Dim i As Integer = comando.ExecuteNonQuery
        conexion.Close()
        Return i
    End Function

    Function modificar(ByVal tabla, ByVal campos, ByVal condicion)
        Try
            conexion.Open()
            Dim modificarE As String = "update " + tabla + " set " + campos + " where " + condicion
            comando = New SqlCommand(modificarE, conexion)
            Dim i As Integer = comando.ExecuteNonQuery()
            conexion.Close()
            If (i > 0) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)

        End Try

    End Function

End Class



