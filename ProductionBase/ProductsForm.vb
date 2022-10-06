Imports System.Data.SqlClient

Public Class ProductsForm
    Private _connectionString As String = ConnectionStringManager.GetConnectionString()
    Private _productsBinding As BindingSource
    Private _workingMode As WorkingModes

    Private _productColumnNames As New List(Of String) From
    {
        "Код",
        "Название",
        "Единица измерения"
    }

    Private ReadOnly Property SelectedProductCode As String
        Get
            If Not ProductsDgv.Rows.Count = 0 Then
                Return ProductsDgv.CurrentRow.Cells.Item("Code").Value.ToString()
            End If

            Return Nothing
        End Get
    End Property

    Private ReadOnly Property SelectedProductName As String
        Get
            If Not ProductsDgv.Rows.Count = 0 Then
                Return ProductsDgv.CurrentRow.Cells.Item("Name").Value.ToString()
            End If

            Return Nothing
        End Get
    End Property

#Region "FormEvents"
    Private Sub ProductsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindProductsGrid()
        LoadProducts()
    End Sub

    Private Sub ComponentsBtn_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If SelectedProductCode IsNot Nothing Then
            ShowComponentsForm()
        End If
    End Sub

    Private Sub ChangeLogBtn_Click(sender As Object, e As EventArgs) Handles ChangeLogBtn.Click
        ShowLogForm()
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If SelectedProductCode IsNot Nothing Then
            DeleteProduct()
        End If
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        SetupControlsAccessibilityForAdding()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        TrySaveChanges()
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        If SelectedProductCode IsNot Nothing Then
            SetupControlsAccessibilityForUpdating()
            FillTextboxesForUpdating()
        End If
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        ResetTextboxes()
        RestoreControlsAccessibility()
    End Sub
#End Region

#Region "VisualControlsManagement"
    Private Sub ResetTextboxes()
        CodeTb.Clear()
        NameTb.Clear()
        UnitTb.Clear()
    End Sub

    Private Sub SetupControlsAccessibilityForAdding()
        _workingMode = WorkingModes.Adding

        CodeTb.Enabled = True
        NameTb.Enabled = True
        UnitTb.Enabled = True

        SaveBtn.Enabled = True
        CancelBtn.Enabled = True

        UpdateBtn.Enabled = False
        DeleteBtn.Enabled = False

        ProductsDgv.Enabled = False
    End Sub

    Private Sub SetupControlsAccessibilityForUpdating()
        _workingMode = WorkingModes.Updating

        CodeTb.Enabled = True
        NameTb.Enabled = True
        UnitTb.Enabled = True

        SaveBtn.Enabled = True
        CancelBtn.Enabled = True

        AddBtn.Enabled = False
        DeleteBtn.Enabled = False

        ProductsDgv.Enabled = False
    End Sub

    Private Sub RestoreControlsAccessibility()
        _workingMode = Nothing

        CodeTb.Enabled = False
        NameTb.Enabled = False
        UnitTb.Enabled = False

        SaveBtn.Enabled = False
        CancelBtn.Enabled = False

        AddBtn.Enabled = True
        UpdateBtn.Enabled = True
        DeleteBtn.Enabled = True

        ProductsDgv.Enabled = True
    End Sub

    Private Sub FillTextboxesForUpdating()
        CodeTb.Text = SelectedProductCode
        NameTb.Text = SelectedProductName
        UnitTb.Text = ProductsDgv.CurrentRow.Cells.Item("Unit").Value.ToString()
    End Sub

    Private Function IsAllTextboxesFilled() As Boolean
        Return Not (CodeTb.Text = "" OrElse NameTb.Text = "" OrElse UnitTb.Text = "")
    End Function
#End Region

#Region "SqlQueryMethods"
    Public Sub LoadProducts()
        ProductsDgv.Rows.Clear()
        Dim reader As SqlDataReader
        Using connection As New SqlConnection(_connectionString)
            connection.Open()
            Dim commandText As String = "SELECT * FROM Product"
            Dim command As New SqlCommand(commandText, connection)
            reader = command.ExecuteReader()
            If reader.HasRows Then
                _productsBinding.DataSource = reader
                GridVisualDisplayHelper.SetGridColumnsNames(ProductsDgv, _productColumnNames)
            End If

            reader.Close()
        End Using
    End Sub

    Private Function AddProductToDatabase() As Boolean
        Using connection As New SqlConnection(_connectionString)
            connection.Open()
            Using command As New SqlCommand("AddProduct", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.Add(New SqlParameter("@Code", SqlDbType.Char))
                command.Parameters("@Code").Value = CodeTb.Text
                command.Parameters.Add(New SqlParameter("@Name", SqlDbType.Char))
                command.Parameters("@Name").Value = NameTb.Text
                command.Parameters.Add(New SqlParameter("@Unit", SqlDbType.Char))
                command.Parameters("@Unit").Value = UnitTb.Text
                Dim result As Integer = command.ExecuteNonQuery()
                Return result > 0
            End Using
        End Using
    End Function

    Private Function UpdateProductInDatabase() As Boolean
        Using connection As New SqlConnection(_connectionString)
            connection.Open()
            Using command As New SqlCommand("UpdateProduct", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.Add(New SqlParameter("@UpdatedCode", SqlDbType.Char))
                command.Parameters("@UpdatedCode").Value = SelectedProductCode
                command.Parameters.Add(New SqlParameter("@Code", SqlDbType.Char))
                command.Parameters("@Code").Value = CodeTb.Text
                command.Parameters.Add(New SqlParameter("@Name", SqlDbType.Char))
                command.Parameters("@Name").Value = NameTb.Text
                command.Parameters.Add(New SqlParameter("@Unit", SqlDbType.Char))
                command.Parameters("@Unit").Value = UnitTb.Text
                Dim result As Integer = command.ExecuteNonQuery()
                Return result > 0
            End Using
        End Using
    End Function

    Private Function DeleteProductFromDatabase() As Boolean
        Using connection As New SqlConnection(_connectionString)
            connection.Open()
            Using command As New SqlCommand("DeleteProduct", connection)
                command.CommandType = CommandType.StoredProcedure
                command.Parameters.Add(New SqlParameter("@Code", SqlDbType.Char))
                command.Parameters("@Code").Value = SelectedProductCode
                Dim result As Integer = command.ExecuteNonQuery()
                Return result > 0
            End Using
        End Using
    End Function

#End Region

#Region "ControlsActions"
    Private Sub BindProductsGrid()
        _productsBinding = New BindingSource()
        ProductsDgv.DataSource = _productsBinding
    End Sub

    Private Sub ShowComponentsForm()
        Dim components As ComponentsForm = New ComponentsForm()
        components.ProductCode = SelectedProductCode
        components.ProductName = SelectedProductName
        components.ShowDialog()
    End Sub

    Private Sub ShowLogForm()
        If SelectedProductCode IsNot Nothing Then
            Dim log As ChangeLogForm = New ChangeLogForm()
            log.RecordCode = SelectedProductCode
            log.TableName = "Product"
            log.ShowDialog()
        End If
    End Sub

    Private Sub DeleteProduct()
        Try
            If DeleteProductFromDatabase() Then
                MessageBox.Show("Успешно!", "Удаление", MessageBoxButtons.OK)
            Else
                MessageBox.Show("Ошибка!", "Удаление", MessageBoxButtons.OK)
            End If

            LoadProducts()
        Catch ex As SqlException
            MessageBox.Show("Невозможно удалить изделие!", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TrySaveChanges()
        If Not IsAllTextboxesFilled() Then
            MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButtons.OK)
            Return
        End If

        Try
            If _workingMode = WorkingModes.Adding Then
                If AddProductToDatabase() Then
                    MessageBox.Show("Успешно!", "Добавление", MessageBoxButtons.OK)
                    ResetTextboxes()
                Else
                    MessageBox.Show("Ошибка!", "Добавление", MessageBoxButtons.OK)
                End If
            ElseIf _workingMode = WorkingModes.Updating Then
                If UpdateProductInDatabase() Then
                    MessageBox.Show("Успешно!", "Обновление", MessageBoxButtons.OK)
                    ResetTextboxes()
                Else
                    MessageBox.Show("Ошибка!", "Обновление", MessageBoxButtons.OK)
                End If
            End If

            LoadProducts()
            RestoreControlsAccessibility()
        Catch ex As SqlException
            MessageBox.Show("Изделие с таким кодом уже существует!", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region
End Class
