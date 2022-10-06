Imports System.Data.SqlClient

Public Class ComponentsForm
    Private _connectionString As String = ConnectionStringManager.GetConnectionString()
    Private _componentsBinding As BindingSource
    Private _workingMode As WorkingModes

    Private _componentsColumnNames As New List(Of String) From
    {
        "Код",
        "Название",
        "Количество",
        "Единица измерения"
    }

    Property ProductCode As String
    Property ProductName As String

    Private ReadOnly Property ProductLabel As String
        Get
            Return ProductCode + ", " + ProductName
        End Get
    End Property

    Private ReadOnly Property SelectedProductCode
        Get
            If Not ComponentCb.SelectedIndex = -1 Then
                Return ComponentCb.SelectedItem.ToString()
            End If

            Return Nothing
        End Get
    End Property

    Private ReadOnly Property SelectedComponentCode As String
        Get
            If Not ComponentsDgv.Rows.Count = 0 Then
                Return ComponentsDgv.CurrentRow.Cells.Item("Code").Value.ToString()
            End If

            Return Nothing
        End Get
    End Property

    Private ReadOnly Property SelectedProductUnit As String
        Get
            Using connection As New SqlConnection(_connectionString)
                Using command As New SqlCommand("GetProductUnitByCode", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@Code", SqlDbType.Char))
                    command.Parameters("@Code").Value = SelectedProductCode

                    connection.Open()
                    Dim result As String = command.ExecuteScalar().ToString()
                    Return result
                End Using
            End Using
        End Get
    End Property

    Private ReadOnly Property SelectedComponentProductCode As String
        Get
            Using connection As New SqlConnection(_connectionString)
                Using command As New SqlCommand("GetProductCodeByComponentCode", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.Add(New SqlParameter("@Code", SqlDbType.Char))
                    command.Parameters("@Code").Value = SelectedComponentCode

                    connection.Open()
                    Dim result As String = command.ExecuteScalar().ToString()
                    Return result
                End Using
            End Using
        End Get
    End Property

#Region "FormEvents"
    Private Sub ComponentsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindComponentsGrid()
        ProductLbl.Text = ProductLabel
        UpdateComponentsLists()
    End Sub

    Private Sub ChangeLogBtn_Click(sender As Object, e As EventArgs) Handles ChangeLogBtn.Click
        ShowLogForm()
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        SetupControlsAccessibilityForAdding()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        TrySaveChanges()
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        If SelectedComponentCode IsNot Nothing Then
            SetupControlsAccessibilityForUpdating()
            FillTextboxesForUpdating()
        End If
    End Sub

    Private Sub ComponentCb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComponentCb.SelectedIndexChanged
        SetUnit()
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If SelectedComponentCode IsNot Nothing Then
            DeleteComponent()
        End If
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        ResetControlBoxes()
        ResetControlsAccessibility()
    End Sub

#End Region

#Region "VisualControlsManagement"
    Private Sub UpdateComponentsLists()
        GetComponents()
        LoadPossibleComponents()
    End Sub

    Private Sub ResetControlBoxes()
        CodeTb.Clear()
        AmountNum.Value = 0
        ComponentCb.SelectedIndex = -1
    End Sub

    Private Sub SetupControlsAccessibilityForAdding()
        _workingMode = WorkingModes.Adding

        CodeTb.Enabled = True
        AmountNum.Enabled = True
        ComponentCb.Enabled = True
        SaveBtn.Enabled = True
        CancelBtn.Enabled = True

        UpdateBtn.Enabled = False
        DeleteBtn.Enabled = False

        ComponentsDgv.Enabled = False
    End Sub

    Private Sub SetupControlsAccessibilityForUpdating()
        _workingMode = WorkingModes.Updating

        CodeTb.Enabled = True
        AmountNum.Enabled = True
        ComponentCb.Enabled = True
        SaveBtn.Enabled = True
        CancelBtn.Enabled = True

        AddBtn.Enabled = False
        DeleteBtn.Enabled = False

        ComponentsDgv.Enabled = False
    End Sub

    Private Sub ResetControlsAccessibility()
        _workingMode = Nothing

        CodeTb.Enabled = False
        AmountNum.Enabled = False
        ComponentCb.Enabled = False
        SaveBtn.Enabled = False
        CancelBtn.Enabled = False

        AddBtn.Enabled = True
        UpdateBtn.Enabled = True
        DeleteBtn.Enabled = True

        ComponentsDgv.Enabled = True
    End Sub

    Private Sub FillTextboxesForUpdating()
        CodeTb.Text = SelectedComponentCode
        AmountNum.Text = ComponentsDgv.CurrentRow.Cells.Item("Amount").Value.ToString()
        ComponentCb.Items.Add(SelectedComponentProductCode)
        ComponentCb.SelectedItem = SelectedComponentProductCode
    End Sub

    Private Function IsAllControlBoxesFilled() As Boolean
        Return Not (CodeTb.Text = "" OrElse AmountNum.Value = 0 OrElse ComponentCb.SelectedIndex = -1)
    End Function

#End Region

#Region "SqlQueryMethods"
    Public Sub GetComponents()
        ComponentsDgv.Rows.Clear()
        Dim reader As SqlDataReader
        Using connection As New SqlConnection(_connectionString)
            Using command As New SqlCommand("GetProductComponentsByCode", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.Add(New SqlParameter("@Code", SqlDbType.Char))
                command.Parameters("@Code").Value = ProductCode

                connection.Open()
                reader = command.ExecuteReader()

                If reader.HasRows Then
                    _componentsBinding.DataSource = reader
                    GridVisualDisplayHelper.SetGridColumnsNames(ComponentsDgv, _componentsColumnNames)
                End If

                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub LoadPossibleComponents()
        ComponentCb.Items.Clear()
        Dim reader As SqlDataReader
        Using connection As New SqlConnection(_connectionString)
            Using command As New SqlCommand("GetPossibleComponents", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.Add(New SqlParameter("@Code", SqlDbType.Char))
                command.Parameters("@Code").Value = ProductCode

                connection.Open()
                reader = command.ExecuteReader()

                While reader.Read()
                    ComponentCb.Items.Add(reader.GetString("Product"))
                End While

                reader.Close()
            End Using
        End Using
    End Sub

    Private Function AddComponentToDatabase() As Boolean
        Using connection As New SqlConnection(_connectionString)
            connection.Open()
            Using command As New SqlCommand("AddComponent", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.Add(New SqlParameter("@Code", SqlDbType.Char))
                command.Parameters("@Code").Value = CodeTb.Text
                command.Parameters.Add(New SqlParameter("@Amount", SqlDbType.Decimal))
                command.Parameters("@Amount").Value = AmountNum.Value
                command.Parameters.Add(New SqlParameter("@ProdCode", SqlDbType.Char))
                command.Parameters("@ProdCode").Value = ProductCode
                command.Parameters.Add(New SqlParameter("@CompCode", SqlDbType.Char))
                command.Parameters("@CompCode").Value = SelectedProductCode
                Dim result As Integer = command.ExecuteNonQuery()
                Return result > 0
            End Using
        End Using
    End Function

    Private Function UpdateComponentInDatabase() As Boolean
        Using connection As New SqlConnection(_connectionString)
            connection.Open()
            Using command As New SqlCommand("UpdateComponent", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.Add(New SqlParameter("@UpdatedCode", SqlDbType.Char))
                command.Parameters("@UpdatedCode").Value = SelectedComponentCode
                command.Parameters.Add(New SqlParameter("@Code", SqlDbType.Char))
                command.Parameters("@Code").Value = CodeTb.Text
                command.Parameters.Add(New SqlParameter("@Amount", SqlDbType.Decimal))
                command.Parameters("@Amount").Value = AmountNum.Value
                command.Parameters.Add(New SqlParameter("@ProdCode", SqlDbType.Char))
                command.Parameters("@ProdCode").Value = ProductCode
                command.Parameters.Add(New SqlParameter("@CompCode", SqlDbType.Char))
                command.Parameters("@CompCode").Value = SelectedProductCode
                Dim result As Integer = command.ExecuteNonQuery()
                Return result > 0
            End Using
        End Using
    End Function

    Private Function DeleteComponentFromDatabase() As Boolean
        Using connection As New SqlConnection(_connectionString)
            connection.Open()
            Using command As New SqlCommand("DeleteComponent", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.Add(New SqlParameter("@Code", SqlDbType.Char))
                command.Parameters("@Code").Value = SelectedComponentCode
                Dim result As Integer = command.ExecuteNonQuery()
                Return result > 0
            End Using
        End Using
    End Function

#End Region

#Region "ControlsActions"
    Private Sub BindComponentsGrid()
        _componentsBinding = New BindingSource()
        ComponentsDgv.DataSource = _componentsBinding
    End Sub

    Private Sub ShowLogForm()
        If SelectedComponentCode IsNot Nothing Then
            Dim log As ChangeLogForm = New ChangeLogForm()
            log.RecordCode = SelectedComponentCode
            log.TableName = "Component"
            log.ShowDialog()
        End If
    End Sub

    Private Sub TrySaveChanges()
        If Not IsAllControlBoxesFilled() Then
            MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButtons.OK)
            Return
        End If

        Try
            If _workingMode = WorkingModes.Adding Then
                If AddComponentToDatabase() Then
                    MessageBox.Show("Успешно!", "Добавление", MessageBoxButtons.OK)
                    ResetControlBoxes()
                Else
                    MessageBox.Show("Ошибка!", "Добавление", MessageBoxButtons.OK)
                End If
            ElseIf _workingMode = WorkingModes.Updating Then
                If UpdateComponentInDatabase() Then
                    MessageBox.Show("Успешно!", "Обновление", MessageBoxButtons.OK)
                    ResetControlBoxes()
                Else
                    MessageBox.Show("Ошибка!", "Обновление", MessageBoxButtons.OK)
                End If
            End If

            UpdateComponentsLists()
            ResetControlsAccessibility()
        Catch ex As SqlException
            MessageBox.Show("Компонент с таким кодом уже существует!", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SetUnit()
        If Not ComponentCb.SelectedIndex = -1 Then
            UnitLbl.Text = SelectedProductUnit
        Else UnitLbl.Text = ""
        End If
    End Sub

    Private Sub DeleteComponent()
        Try
            If DeleteComponentFromDatabase() Then
                MessageBox.Show("Успешно!", "Удаление", MessageBoxButtons.OK)
            Else
                MessageBox.Show("Ошибка!", "Удаление", MessageBoxButtons.OK)
            End If

            UpdateComponentsLists()
        Catch ex As SqlException
            MessageBox.Show("Невозможно удалить компонент!", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region
End Class