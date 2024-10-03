Imports System.Data.SQLite

Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim selectedRole As String = cb_UserType.SelectedItem?.ToString()

        If String.IsNullOrEmpty(selectedRole) Then
            MessageBox.Show("Please select a user type.")
        Else
            If ValidateLogin(username, password, selectedRole) Then
                If selectedRole = "Admin" Then
                    Form1.Show()
                ElseIf selectedRole = "Employee" Then
                    Dim form1 As New Form1()
                    form1.Show()
                End If

                Me.Hide()
                txtUsername.Text = ""
                txtPassword.Text = ""
                cb_UserType.SelectedIndex = -1
            Else
                MessageBox.Show($"Invalid username or password for {selectedRole}. Please try again.")
                txtUsername.Text = ""
                txtPassword.Text = ""
            End If
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As New SQLiteConnection(DatabaseConnection.connectionString)
        Form1.Show()

        Try
            connection.Open()
            If connection.State = ConnectionState.Open Then
                MessageBox.Show("Database connection successful.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Database connection failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error connecting to database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub



End Class
