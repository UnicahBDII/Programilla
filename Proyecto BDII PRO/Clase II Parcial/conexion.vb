Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class conexion


    Public conexion As SqlConnection = New SqlConnection("Data Source=DESKTOP-LGDBE5Q\SQLEXPRESS;Initial Catalog=CompuCenter;Integrated Security=True")
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public lectura As SqlDataReader
    Public comando As SqlCommand
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

    'Public Sub consulta(ByVal sql As String, ByVal tabla As String)
    '    Try
    '        conexion.Open()
    '        ds.Tables.Clear()
    '        da = New SqlDataAdapter(sql, conexion)
    '        comando = New SqlCommandBuilder(da)

    '        da.Fill(ds, tabla)

    '    Catch ex As Exception
    '        conexion.Close()
    '    End Try
    '    conexion.Close()
    'End Sub





    'Public cn As SqlConnection
    'Public adaptador As SqlDataAdapter
    'Public dt As DataTable
    'Public comando As SqlCommand
    'Public dr As SqlDataReader


    Sub llenarDataGridEmpleados(ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("Select * from Center.empleados", cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
    End Sub


    Sub llenarDataGridStock(ByVal dgv As DataGridView)
        Try
            'adaptador = New SqlDataAdapter("select st.identidad , st.nombre, st.puesto, te.paquete, te.cantidad, te.modelo from Center.stock st inner join Center.telefonos te on st.idPuesto = te.id", cn)
            adaptador = New SqlDataAdapter("select st.IdCodigo, st.identidad , st.nombre, st.puesto, te.modelo,te.tipoPaquete,te.Descripcion, te.cantidad from Center.stock st inner join Center.telefonos te on st.idPuesto = te.id", cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
    End Sub

    Sub llenarDataGridTelefonos(ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("Select * from Center.empleados", cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
    End Sub



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

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return respuesta
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

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return respuesta
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
