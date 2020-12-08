Imports System.Data.SqlClient
Public Class Stock
    Public comando As SqlCommand
    Public conexion As SqlConnection = New SqlConnection("Data Source=DESKTOP-L87VDHJ;Initial Catalog=CompuCenter;Integrated Security=True")
    Public dr As SqlDataReader

    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

End Class