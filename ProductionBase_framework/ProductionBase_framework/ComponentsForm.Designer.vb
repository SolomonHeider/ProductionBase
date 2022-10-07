<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComponentsForm
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
        Me.ComponentsDgv = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProductLbl = New System.Windows.Forms.Label()
        Me.ChangeLogBtn = New System.Windows.Forms.Button()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UnitLbl = New System.Windows.Forms.Label()
        Me.CodeTb = New System.Windows.Forms.TextBox()
        Me.ComponentCb = New System.Windows.Forms.ComboBox()
        Me.AmountNum = New System.Windows.Forms.NumericUpDown()
        CType(Me.ComponentsDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmountNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComponentsDgv
        '
        Me.ComponentsDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ComponentsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ComponentsDgv.Location = New System.Drawing.Point(12, 25)
        Me.ComponentsDgv.Name = "ComponentsDgv"
        Me.ComponentsDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ComponentsDgv.Size = New System.Drawing.Size(513, 380)
        Me.ComponentsDgv.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Изделие: "
        '
        'ProductLbl
        '
        Me.ProductLbl.AutoSize = True
        Me.ProductLbl.Location = New System.Drawing.Point(75, 9)
        Me.ProductLbl.Name = "ProductLbl"
        Me.ProductLbl.Size = New System.Drawing.Size(31, 13)
        Me.ProductLbl.TabIndex = 2
        Me.ProductLbl.Text = "none"
        '
        'ChangeLogBtn
        '
        Me.ChangeLogBtn.Location = New System.Drawing.Point(543, 25)
        Me.ChangeLogBtn.Name = "ChangeLogBtn"
        Me.ChangeLogBtn.Size = New System.Drawing.Size(245, 23)
        Me.ChangeLogBtn.TabIndex = 3
        Me.ChangeLogBtn.Text = "Журнал изменений"
        Me.ChangeLogBtn.UseVisualStyleBackColor = True
        '
        'AddBtn
        '
        Me.AddBtn.Location = New System.Drawing.Point(543, 126)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(245, 23)
        Me.AddBtn.TabIndex = 5
        Me.AddBtn.Text = "Добавить новый"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'UpdateBtn
        '
        Me.UpdateBtn.Location = New System.Drawing.Point(543, 155)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(245, 23)
        Me.UpdateBtn.TabIndex = 6
        Me.UpdateBtn.Text = "Изменить выделенный"
        Me.UpdateBtn.UseVisualStyleBackColor = True
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Location = New System.Drawing.Point(543, 184)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(245, 23)
        Me.DeleteBtn.TabIndex = 7
        Me.DeleteBtn.Text = "Удалить выделенный"
        Me.DeleteBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Enabled = False
        Me.CancelBtn.Location = New System.Drawing.Point(543, 382)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(245, 23)
        Me.CancelBtn.TabIndex = 8
        Me.CancelBtn.Text = "Отмена"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'SaveBtn
        '
        Me.SaveBtn.Enabled = False
        Me.SaveBtn.Location = New System.Drawing.Point(543, 353)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(245, 23)
        Me.SaveBtn.TabIndex = 9
        Me.SaveBtn.Text = "Сохранить"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(555, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Код компонента"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(582, 283)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Компонент"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(579, 309)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Количество"
        '
        'UnitLbl
        '
        Me.UnitLbl.AutoSize = True
        Me.UnitLbl.Location = New System.Drawing.Point(745, 309)
        Me.UnitLbl.Name = "UnitLbl"
        Me.UnitLbl.Size = New System.Drawing.Size(24, 13)
        Me.UnitLbl.TabIndex = 13
        Me.UnitLbl.Text = "unit"
        '
        'CodeTb
        '
        Me.CodeTb.Enabled = False
        Me.CodeTb.Location = New System.Drawing.Point(651, 254)
        Me.CodeTb.MaxLength = 30
        Me.CodeTb.Name = "CodeTb"
        Me.CodeTb.Size = New System.Drawing.Size(137, 20)
        Me.CodeTb.TabIndex = 14
        '
        'ComponentCb
        '
        Me.ComponentCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComponentCb.Enabled = False
        Me.ComponentCb.FormattingEnabled = True
        Me.ComponentCb.Location = New System.Drawing.Point(651, 280)
        Me.ComponentCb.Name = "ComponentCb"
        Me.ComponentCb.Size = New System.Drawing.Size(137, 21)
        Me.ComponentCb.Sorted = True
        Me.ComponentCb.TabIndex = 15
        '
        'AmountNum
        '
        Me.AmountNum.DecimalPlaces = 8
        Me.AmountNum.Enabled = False
        Me.AmountNum.Location = New System.Drawing.Point(651, 307)
        Me.AmountNum.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.AmountNum.Name = "AmountNum"
        Me.AmountNum.Size = New System.Drawing.Size(88, 20)
        Me.AmountNum.TabIndex = 16
        '
        'ComponentsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 418)
        Me.Controls.Add(Me.AmountNum)
        Me.Controls.Add(Me.ComponentCb)
        Me.Controls.Add(Me.CodeTb)
        Me.Controls.Add(Me.UnitLbl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.UpdateBtn)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.ChangeLogBtn)
        Me.Controls.Add(Me.ProductLbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComponentsDgv)
        Me.Name = "ComponentsForm"
        Me.Text = "Состав изделия"
        CType(Me.ComponentsDgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmountNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComponentsDgv As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ProductLbl As Label
    Friend WithEvents ChangeLogBtn As Button
    Friend WithEvents AddBtn As Button
    Friend WithEvents UpdateBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents CancelBtn As Button
    Friend WithEvents SaveBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents UnitLbl As Label
    Friend WithEvents CodeTb As TextBox
    Friend WithEvents ComponentCb As ComboBox
    Friend WithEvents AmountNum As NumericUpDown
End Class
