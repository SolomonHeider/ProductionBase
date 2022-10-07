<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductsForm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ProductsDgv = New System.Windows.Forms.DataGridView()
        Me.ComponentsBtn = New System.Windows.Forms.Button()
        Me.ChangeLogBtn = New System.Windows.Forms.Button()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CodeTb = New System.Windows.Forms.TextBox()
        Me.NameTb = New System.Windows.Forms.TextBox()
        Me.UnitTb = New System.Windows.Forms.TextBox()
        CType(Me.ProductsDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductsDgv
        '
        Me.ProductsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductsDgv.Location = New System.Drawing.Point(12, 12)
        Me.ProductsDgv.MultiSelect = False
        Me.ProductsDgv.Name = "ProductsDgv"
        Me.ProductsDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProductsDgv.Size = New System.Drawing.Size(504, 368)
        Me.ProductsDgv.TabIndex = 0
        '
        'ComponentsBtn
        '
        Me.ComponentsBtn.Location = New System.Drawing.Point(533, 12)
        Me.ComponentsBtn.Name = "ComponentsBtn"
        Me.ComponentsBtn.Size = New System.Drawing.Size(255, 23)
        Me.ComponentsBtn.TabIndex = 1
        Me.ComponentsBtn.Text = "Состав изделия"
        Me.ComponentsBtn.UseVisualStyleBackColor = True
        '
        'ChangeLogBtn
        '
        Me.ChangeLogBtn.Location = New System.Drawing.Point(533, 41)
        Me.ChangeLogBtn.Name = "ChangeLogBtn"
        Me.ChangeLogBtn.Size = New System.Drawing.Size(255, 23)
        Me.ChangeLogBtn.TabIndex = 2
        Me.ChangeLogBtn.Text = "Журнал изменений"
        Me.ChangeLogBtn.UseVisualStyleBackColor = True
        '
        'AddBtn
        '
        Me.AddBtn.Location = New System.Drawing.Point(533, 129)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(255, 23)
        Me.AddBtn.TabIndex = 3
        Me.AddBtn.Text = "Добавить новое"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'UpdateBtn
        '
        Me.UpdateBtn.Location = New System.Drawing.Point(533, 158)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(255, 23)
        Me.UpdateBtn.TabIndex = 4
        Me.UpdateBtn.Text = "Изменить выделенное"
        Me.UpdateBtn.UseVisualStyleBackColor = True
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Location = New System.Drawing.Point(533, 187)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(255, 23)
        Me.DeleteBtn.TabIndex = 5
        Me.DeleteBtn.Text = "Удалить выделенное"
        Me.DeleteBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Enabled = False
        Me.CancelBtn.Location = New System.Drawing.Point(533, 357)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(255, 23)
        Me.CancelBtn.TabIndex = 6
        Me.CancelBtn.Text = "Отмена"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'SaveBtn
        '
        Me.SaveBtn.Enabled = False
        Me.SaveBtn.Location = New System.Drawing.Point(533, 328)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(255, 23)
        Me.SaveBtn.TabIndex = 7
        Me.SaveBtn.Text = "Сохранить"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(617, 241)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Код"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(534, 293)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Единица измерения"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(586, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Название"
        '
        'CodeTb
        '
        Me.CodeTb.Enabled = False
        Me.CodeTb.Location = New System.Drawing.Point(649, 238)
        Me.CodeTb.MaxLength = 30
        Me.CodeTb.Name = "CodeTb"
        Me.CodeTb.Size = New System.Drawing.Size(139, 20)
        Me.CodeTb.TabIndex = 11
        '
        'NameTb
        '
        Me.NameTb.Enabled = False
        Me.NameTb.Location = New System.Drawing.Point(649, 264)
        Me.NameTb.MaxLength = 150
        Me.NameTb.Name = "NameTb"
        Me.NameTb.Size = New System.Drawing.Size(139, 20)
        Me.NameTb.TabIndex = 12
        '
        'UnitTb
        '
        Me.UnitTb.Enabled = False
        Me.UnitTb.Location = New System.Drawing.Point(649, 290)
        Me.UnitTb.MaxLength = 2
        Me.UnitTb.Name = "UnitTb"
        Me.UnitTb.Size = New System.Drawing.Size(139, 20)
        Me.UnitTb.TabIndex = 13
        '
        'ProductsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 393)
        Me.Controls.Add(Me.UnitTb)
        Me.Controls.Add(Me.NameTb)
        Me.Controls.Add(Me.CodeTb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.UpdateBtn)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.ChangeLogBtn)
        Me.Controls.Add(Me.ComponentsBtn)
        Me.Controls.Add(Me.ProductsDgv)
        Me.Name = "ProductsForm"
        Me.Text = "Изделия"
        CType(Me.ProductsDgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProductsDgv As DataGridView
    Friend WithEvents ComponentsBtn As Button
    Friend WithEvents ChangeLogBtn As Button
    Friend WithEvents AddBtn As Button
    Friend WithEvents UpdateBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents CancelBtn As Button
    Friend WithEvents SaveBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CodeTb As TextBox
    Friend WithEvents NameTb As TextBox
    Friend WithEvents UnitTb As TextBox
End Class
