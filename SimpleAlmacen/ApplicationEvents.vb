Namespace My
    ' Los siguientes eventos están disponibles para MyApplication:
    ' Inicio: se desencadena cuando se inicia la aplicación, antes de que se cree el formulario de inicio.
    ' Apagado: generado después de cerrar todos los formularios de la aplicación. Este evento no se genera si la aplicación termina de forma anómala.
    ' UnhandledException: generado si la aplicación detecta una excepción no controlada.
    ' StartupNextInstance: se desencadena cuando se inicia una aplicación de instancia única y la aplicación ya está activa. 
    ' NetworkAvailabilityChanged: se desencadena cuando la conexión de red está conectada o desconectada.
    Partial Friend Class MyApplication
        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            Dim frm As New FrmLogin()
            If (frm.ShowDialog() = DialogResult.OK) Then
                Me.MainForm = Global.SimpleAlmacen.FrmApp
            Else
                Me.MainForm = Global.SimpleAlmacen.FrmLogin
            End If
        End Sub
    End Class
End Namespace
