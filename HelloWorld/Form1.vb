Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim companies = New String() {"PANG", "TGN"}
        Dim services = New String() {"Soporte", "Plataforma"}

        cbCompany.Items.AddRange(companies)
        cbService.Items.AddRange(services)
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim MySqlConn As New MySqlConnection

        MySqlConn.ConnectionString = ("")

        Try
            MySqlConn.Open()

            MessageBox.Show("Connection to Database has been opened.")
        Catch myerror As MySqlException
            MessageBox.Show("Cannot connect to database: " & myerror.Message)
        Finally

            MySqlConn.Dispose()

        End Try

        Try
            MySqlConn.Close()

            MessageBox.Show("Connection to Database has been Closed.")
        Catch myerror As MySqlException
            MessageBox.Show("Cannot connect to database: " & myerror.Message)
        Finally
            MySqlConn.Dispose()
        End Try

        lblMessage.Text = "Saved!"
    End Sub
    Private Sub cbService_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbService.SelectedIndexChanged
        cbActivity.Items.Clear()

        Dim activities = New String() {}

        Select Case cbService.Text
            Case "Soporte"
                activities = New String() {
                    "Restaurar equipo", "Tareas de soporte..."
                }
            Case "Plataforma"
                activities = New String() {
                    "Crear nueva cuenta de dominio", "Tareas de plataforma..."
                }
        End Select

        cbActivity.Items.AddRange(activities)
    End Sub
End Class
