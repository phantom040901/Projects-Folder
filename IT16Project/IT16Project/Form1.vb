Imports System.IO

Public Class Form1
    Private Sub btnClassifiedClick(sender As Object, e As EventArgs) Handles btnClassified.Click
        pnlOnVaria.Height = btnClassified.Height
        pnlOnVaria.Top = btnClassified.Top
        pnlClassified.Visible = True
        pnlOnVaria.Visible = True
        pnlConfigurationFiles.Visible = False
        pnlOnDispo.Visible = False
        pnlComplianceReports.Visible = False
        pnlOnJuice.Visible = False
        pnlAuditLogs.Visible = False
        pnlOnOther.Visible = False
        pnlAbout.Visible = False
        pnlOnAbout.Visible = False
        LoadFiles("Classified")
    End Sub
    Private Sub btnConfigurationFiles_Click(sender As Object, e As EventArgs) Handles btnConfigurationFiles.Click
        pnlOnDispo.Height = btnConfigurationFiles.Height
        pnlOnDispo.Top = btnConfigurationFiles.Top
        pnlClassified.Visible = False
        pnlOnVaria.Visible = False
        pnlConfigurationFiles.Visible = True
        pnlOnDispo.Visible = True
        pnlComplianceReports.Visible = False
        pnlOnJuice.Visible = False
        pnlAuditLogs.Visible = False
        pnlOnOther.Visible = False
        pnlAbout.Visible = False
        pnlOnAbout.Visible = False
        LoadFiles("ConfigurationFiles")
    End Sub


    Private Sub btnAuditLogs_Click(sender As Object, e As EventArgs) Handles btnAuditLogs.Click
        pnlOnJuice.Height = btnAuditLogs.Height
        pnlOnJuice.Top = btnAuditLogs.Top
        pnlClassified.Visible = False
        pnlOnVaria.Visible = False
        pnlConfigurationFiles.Visible = False
        pnlOnDispo.Visible = False
        pnlComplianceReports.Visible = False
        pnlOnJuice.Visible = True  ' Make sure the panel for AuditLogs is set to visible
        pnlAuditLogs.Visible = True
        pnlOnOther.Visible = False
        pnlAbout.Visible = False
        pnlOnAbout.Visible = False
        LoadFiles("AuditLogs")
    End Sub


    Private Sub btnComplianceReports_Click(sender As Object, e As EventArgs) Handles btnComplianceReports.Click
        pnlOnOther.Height = btnComplianceReports.Height
        pnlOnOther.Top = btnComplianceReports.Top
        pnlClassified.Visible = False
        pnlOnVaria.Visible = False
        pnlConfigurationFiles.Visible = False
        pnlOnDispo.Visible = False
        pnlComplianceReports.Visible = True
        pnlOnJuice.Visible = False
        pnlAuditLogs.Visible = False
        pnlOnOther.Visible = True
        pnlAbout.Visible = False
        pnlOnAbout.Visible = False
        LoadFiles("ComplianceReports")
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        pnlOnAbout.Height = btnAbout.Height
        pnlOnAbout.Top = btnAbout.Top
        pnlClassified.Visible = False
        pnlOnVaria.Visible = False
        pnlConfigurationFiles.Visible = False
        pnlOnDispo.Visible = False
        pnlComplianceReports.Visible = False
        pnlOnJuice.Visible = False
        pnlAuditLogs.Visible = False
        pnlOnOther.Visible = False
        pnlAbout.Visible = True
        pnlOnAbout.Visible = True
    End Sub

    Private Sub LoadFiles(category As String)
        Select Case category
            Case "Classified"
                DataGridView1.Rows.Clear()
            Case "ConfigurationFiles"
                DataGridView3.Rows.Clear()
            Case "ComplianceReports"
                DataGridView4.Rows.Clear()
            Case "AuditLogs"
                DataGridView2.Rows.Clear()
        End Select

        Dim folderPath As String = "D:\Files\" & category

        Console.WriteLine("Folder Path: " & folderPath)

        If Directory.Exists(folderPath) Then
            Dim files As String() = Directory.GetFiles(folderPath)

            Console.WriteLine("Number of Files: " & files.Length)

            For Each file As String In files
                Dim fileName As String = Path.GetFileName(file)
                Console.WriteLine("File: " & fileName)
                Dim fileSize As Long = New FileInfo(file).Length
                Dim fileType As String = Path.GetExtension(file)

                Select Case category
                    Case "Classified"
                        DataGridView1.Rows.Add(fileName, fileSize, fileType)
                    Case "ConfigurationFiles"
                        DataGridView3.Rows.Add(fileName, fileSize, fileType)
                    Case "ComplianceReports"
                        DataGridView4.Rows.Add(fileName, fileSize, fileType)
                    Case "AuditLogs"
                        DataGridView2.Rows.Add(fileName, fileSize, fileType)
                End Select
            Next
        Else
            MessageBox.Show("Directory '" & folderPath & "' does not exist.")
        End If
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim dataGridView As DataGridView = CType(sender, DataGridView)

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedFileName As String = dataGridView.Rows(e.RowIndex).Cells(0).Value.ToString()

            Dim choice As String = InputBox("Choose an action for the file: " & selectedFileName & vbCrLf & "1. Read the file" & vbCrLf & "2. Encrypt the file" & vbCrLf & "3. Decrypt the file", "File Action", "1")

            Select Case choice
                Case "1"
                    ReadFile(selectedFileName)
                Case "2"
                    EncryptFile(selectedFileName)
                Case "3"
                    DecryptFile(selectedFileName)
                Case Else
                    MessageBox.Show("Invalid choice.")
            End Select
        End If
    End Sub

    Private Sub ReadFile(fileName As String)
        MessageBox.Show("Reading file: " & fileName)
    End Sub

    Private Sub EncryptFile(fileName As String)
        MessageBox.Show("Encrypting file: " & fileName)
    End Sub

    Private Sub DecryptFile(fileName As String)
        MessageBox.Show("Decrypting file: " & fileName)
    End Sub


    Private Sub HandleCellClick(dataGridView As DataGridView, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedFileName As String = dataGridView.Rows(e.RowIndex).Cells(0).Value.ToString()

            MessageBox.Show("Selected File: " & selectedFileName)
        End If
    End Sub


End Class