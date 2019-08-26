Imports SimpleAlmacen.Core
Imports System.Data
Imports System.Data.SqlClient

Namespace Data
    Public Class Usuario
        Inherits DBAdmin
        Property IdUsuario As Int32
        Property NombreUsuario As String
        Property Password As String
        Property Nombre As String
        Property Apellidos As String

        Public Function Crear()
            Dim status As Boolean = False
            Dim cnn As SqlConnection = Me.GetConnection()
            Try
                cnn.Open()
                Dim cmd As SqlCommand = cnn.CreateCommand()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "sp_crearUsuario"
                cmd.Parameters.AddWithValue("@nombreUsuario", Me.NombreUsuario)
                cmd.Parameters.AddWithValue("@nombre", Me.Nombre)
                cmd.Parameters.AddWithValue("@apellidos", Me.Apellidos)
                cmd.Parameters.AddWithValue("@password", Me.Password)

                status = (cmd.ExecuteNonQuery > 0)
            Catch ex As SqlException
                Console.WriteLine(ex.Message)
            Finally
                cnn.Close()
            End Try
            Return status
        End Function

        Public Function Buscar(ByVal busqueda As String)

            Dim cnn As SqlConnection = Me.GetConnection()
            Dim dtt As New DataTable()
            Try
                cnn.Open()
                Dim cmd As SqlCommand = cnn.CreateCommand()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = "sp_buscarUsuarios"
                cmd.Parameters.AddWithValue("@busqueda", busqueda)
                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dtt)
            Catch ex As SqlException
                Console.WriteLine(ex.Message)
            Finally
                cnn.Close()
            End Try
            Return dtt
        End Function
    End Class
End Namespace
