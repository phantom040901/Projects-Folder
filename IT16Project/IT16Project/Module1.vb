Imports System.Data.SQLite
Imports System.IO

Module DatabaseConnection

    ' Connection string to the SQLite database file located in the project folder
    Public connectionString As String = "Data Source = " & Application.StartupPath & "\IT16Project.db"

    Public Function ValidateLogin(username As String, password As String, role As String) As Boolean
        Dim query As String = "SELECT 1 FROM Admin WHERE Username = @username AND Password = @password AND Role = @role LIMIT 1"

        Try
            Using connection As New SQLiteConnection(connectionString)
                Using command As New SQLiteCommand(query, connection)
                    command.Parameters.AddWithValue("@username", username)
                    command.Parameters.AddWithValue("@password", password)
                    command.Parameters.AddWithValue("@role", role)

                    connection.Open()

                    Dim result As Object = command.ExecuteScalar()

                    ' If result is not Nothing, login is successful
                    Return result IsNot Nothing
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Error validating login: " & ex.Message)
            Return False
        End Try
    End Function

End Module
