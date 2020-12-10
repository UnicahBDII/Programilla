﻿Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class conexion

    Public conexion As SqlConnection = New SqlConnection("Data Source=DESKTOP-LGDBE5Q\SQLEXPRESS;Initial Catalog=CompuCenter;Integrated Security=True")
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public lectura As SqlDataReader
    Public comando As SqlCommandBuilder
    Public cmd As New SqlCommand
    Public numero As Integer


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
    Public Function consulta(nombretabla As String)
        Try
            conexion.Open()
            adaptador = New SqlDataAdapter("Select * from " & nombretabla, conexion)
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

    Public Function BuscarEmpleado(identidad As String)
        Try
            conexion.Open()
            cmd = New SqlCommand("dbo.BuscarEmpleado", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@identidad", identidad)

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
                conexion.Close()
            Else
                Return Nothing
            End If




        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function



    'procedimientos para productos'
    Public Function ingresarProductos(id As Integer, codigobarra As String, nombre As String, preciocompra As Decimal,
                                         precioventa As Decimal, cantidad As Integer, caracteristicas As String, modelo As Integer) As Boolean
        Try
            conexion.Open()
            cmd = New SqlCommand("dbo.agregarProducto", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@codigobarra", codigobarra)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@precio", preciocompra)
            cmd.Parameters.AddWithValue("@precioventa", precioventa)
            cmd.Parameters.AddWithValue("@cantidad", cantidad)
            cmd.Parameters.AddWithValue("@caracteristica", caracteristicas)
            cmd.Parameters.AddWithValue("@modelo", modelo)


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

    'Procedimientos para ventas'
    Public Function ingresarVenta(idcodigo As Integer, idcliente As Integer, idempleado As Integer, fecha As String,
                                     formapago As Integer, numerofactura As Integer, total As Decimal) As Boolean
        Try
            conexion.Open()
            cmd = New SqlCommand("dbo.insertarventas", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@id", idcodigo)
            cmd.Parameters.AddWithValue("@idcliente", idcliente)
            cmd.Parameters.AddWithValue("@idempleado", idempleado)
            cmd.Parameters.AddWithValue("@fecha", fecha)
            cmd.Parameters.AddWithValue("@formadepago", formapago)
            cmd.Parameters.AddWithValue("@numeroFactura", numerofactura)
            cmd.Parameters.AddWithValue("@total", total)

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


    Public Function actualizarVenta(idcodigo As Integer, idcliente As Integer, idempleado As Integer, fecha As Date,
                                     formapago As Integer, numerofactura As Integer, total As Decimal) As Boolean
        Try
            conexion.Open()
            cmd = New SqlCommand("dbo.modificarventa", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@id", idcodigo)
            cmd.Parameters.AddWithValue("@idcliente", idcliente)
            cmd.Parameters.AddWithValue("@idempleado", idempleado)
            cmd.Parameters.AddWithValue("@fecha", fecha)
            cmd.Parameters.AddWithValue("@formadepago", formapago)
            cmd.Parameters.AddWithValue("@numeroFactura", numerofactura)
            cmd.Parameters.AddWithValue("@total", total)


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

    Function retornarIdventa()
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()
            cmd.CommandText = ("SELECT MAX(id) FROM Center.venta")

            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = value
            conexion.Close()

            Return valorARetornar


        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try

    End Function

    'procedimientos para detalle de venta'

    Function retornarIddetalleproducto()
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()
            cmd.CommandText = ("SELECT MAX(iddetalleventa) FROM Center.detalleventa")

            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = value
            conexion.Close()

            Return valorARetornar


        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
        conexion.Close()
    End Function

    Function retornarventa(ByVal contador As Integer)
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()

            numero = retornarIdventa()

            Select Case contador
                Case 0
                    cmd.CommandText = ("SELECT id FROM Center.venta where id = " & numero)

                    conexion.Open()

                    Dim value As Object = cmd.ExecuteScalar()

                    valorARetornar = value
                    conexion.Close()

                    Return valorARetornar

                Case 1
                    cmd.CommandText = ("SELECT idcliente FROM Center.venta where id = " & numero)

                    conexion.Open()

                    Dim value As Object = cmd.ExecuteScalar()

                    valorARetornar = value
                    conexion.Close()

                    Return valorARetornar
                Case 2
                    cmd.CommandText = ("SELECT concat(nombre,' ', apellido) FROM Center.venta inner join Center.cliente on Center.venta.idcliente=Center.cliente.id and Center.venta.id = " & numero)

                    conexion.Open()

                    Dim value As Object = cmd.ExecuteScalar()

                    valorARetornar = value
                    conexion.Close()

                    Return valorARetornar
                Case 3
                    cmd.CommandText = ("SELECT  fecha FROM Center.venta where id = " & numero)

                    conexion.Open()

                    Dim value As Object = cmd.ExecuteScalar()

                    valorARetornar = value
                    conexion.Close()

                    Return valorARetornar
                Case 4
                    cmd.CommandText = ("SELECT formapago FROM Center.venta where id = " & numero)

                    conexion.Open()

                    Dim value As Object = cmd.ExecuteScalar()

                    valorARetornar = value
                    conexion.Close()

                    Return valorARetornar

                Case 5

                    cmd.CommandText = ("SELECT numerofactura FROM Center.venta where id = " & numero)

                    conexion.Open()

                    Dim value As Object = cmd.ExecuteScalar()

                    valorARetornar = value
                    conexion.Close()

                    Return valorARetornar
            End Select



        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()
        Finally
            conexion.Close()
        End Try

    End Function

    Public Function insertardetalleVenta(iddetalleventa As Integer, idventa As Integer, idProducto As Integer, cantidad As Integer,
                                   precio As Decimal) As Boolean
        Try
            conexion.Open()
            cmd = New SqlCommand("dbo.insertarDetalleventa", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Parameters.AddWithValue("@iddetalledeventa", iddetalleventa)
            cmd.Parameters.AddWithValue("@idventa", idventa)
            cmd.Parameters.AddWithValue("@idproducto", idProducto)
            cmd.Parameters.AddWithValue("@cantidad", cantidad)
            cmd.Parameters.AddWithValue("@precio", precio)




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


    Public Function selectdeproductosdetalle(idventa As Integer)

        Try
            conexion.Open()
            cmd = New SqlCommand("llenargrid", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@idventa", idventa)

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)



                Return dt
                conexion.Close()
            Else
                Return Nothing
                conexion.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function Eliminardetalleventa(iddetalledeventa As Integer)
        Try
            conexion.Open()
            cmd = New SqlCommand("dbo.eliminardetalleventa", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@iddetalledeventa", iddetalledeventa)

            If cmd.ExecuteNonQuery <> 0 Then
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
        conexion.Close()
    End Function
End Class






