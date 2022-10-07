Imports System.Configuration

Public Class ConnectionStringManager
    Public Shared Function GetConnectionString() As String
        Dim settings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("ConnectionString")

        Dim connectionString As String = ""
        If settings IsNot Nothing Then
            connectionString = settings.ConnectionString
        End If

        Return connectionString
    End Function
End Class