Imports MySql.Data.MySqlClient

Public Class Form1
    Private timer As Integer

    Private hours As Integer = 0
    Private minutes As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim companies = New String() {"PANG", "TGN"}
        Dim users = New String() {"Usuario1", "Usuario2", "Usuario3"}
        Dim services = New String() {"Soporte", "Plataforma"}

        cbCompany.Items.AddRange(companies)
        cbUser.Items.AddRange(users)
        cbService.Items.AddRange(services)

        lblStartDate.Text = DateString
        lblStartTime.Text = TimeString

        Timer1.Start()
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cbCompany.Text.Equals("") Or
            cbUser.Text.Equals("") Or
            cbService.Text.Equals("") Or
            cbActivity.Text.Equals("") Then
            lblMessage.Text = "All fields must be completed!"
        Else
            Dim MySqlConn As New MySqlConnection

            MySqlConn.ConnectionString = ("")

            lblMessage.Text = ""

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
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timer += 1

        If timer < 60 Then
            lblDuration.Text = If((hours < 10), "0" & hours.ToString, hours)
            lblDuration.Text += ":" & If((minutes < 10), "0" & minutes.ToString, minutes)
            lblDuration.Text += ":" & If((timer < 10), "0" & timer.ToString, timer)
        ElseIf timer = 60 Then
            minutes += 1
            timer = 0

            If minutes = 60 Then
                hours += 1
                minutes = 0
            End If
        End If
    End Sub
End Class
