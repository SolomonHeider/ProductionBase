Imports System.Data.SqlClient

Public Class ChangeLogForm
    Private _connectionString As String = ConnectionStringManager.GetConnectionString()
    Private _logBinding As BindingSource

    Private _componentsColumnNames As New List(Of String) From
    {
        "№",
        "Дата",
        "Таблица",
        "Код",
        "Поле",
        "Старое значение",
        "Новое значение",
        "Тип"
    }

    Public Property RecordCode As String
    Public Property TableName As String

    Private Sub ChangeLogForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _logBinding = New BindingSource()
        ChangeLogDgv.DataSource = _logBinding
        GetLog()
    End Sub

    Public Sub GetLog()
        ChangeLogDgv.Rows.Clear()
        Dim reader As SqlDataReader
        Using connection As New SqlConnection(_connectionString)
            Using command As New SqlCommand("GetChangeLogByCode", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.Add(New SqlParameter("@Code", SqlDbType.Char))
                command.Parameters("@Code").Value = RecordCode
                command.Parameters.Add(New SqlParameter("@Table", SqlDbType.Char))
                command.Parameters("@Table").Value = TableName

                connection.Open()
                reader = command.ExecuteReader()
                If reader.HasRows Then
                    _logBinding.DataSource = reader
                    GridVisualDisplayHelper.SetGridColumnsNames(ChangeLogDgv, _componentsColumnNames)
                End If

                reader.Close()
            End Using
        End Using
    End Sub
End Class