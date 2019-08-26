
Imports SimpleAlmacen.Data
Public Class FrmUsuarios
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.Buscar()
    End Sub

    Private Sub Buscar()
        Dim usr As New Usuario()
        dgvUsuarios.DataSource = usr.Buscar(txtBusqueda.Text)
    End Sub

    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Buscar()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class

