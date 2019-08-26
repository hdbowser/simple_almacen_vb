Imports System
Imports System.Data.SqlClient
Imports System.Configuration

Namespace Core
    Public MustInherit Class DBAdmin
        Public Function GetConnection()
            Dim connectionString = ConfigurationManager.ConnectionStrings("ConnectionStr").ConnectionString
            Dim cnn As New SqlConnection(connectionString)
            Return cnn
        End Function
    End Class
End Namespace
