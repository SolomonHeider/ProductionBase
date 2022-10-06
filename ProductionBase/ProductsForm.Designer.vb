<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ProductsDgv = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ChangeLogBtn = New System.Windows.Forms.Button()
        Me.CodeTb = New System.Windows.Forms.TextBox()
        Me.NameTb = New System.Windows.Forms.TextBox()
        Me.UnitTb = New System.Windows.Forms.TextBox()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        CType(Me.ProductsDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductsDgv
        '
        Me.ProductsDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ProductsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductsDgv.Location = New System.Drawing.Point(12, 12)
        Me.ProductsDgv.MultiSelect = False
        Me.ProductsDgv.Name = "ProductsDgv"
        Me.ProductsDgv.RowTemplate.Height = 25
        Me.ProductsDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProductsDgv.Size = New System.Drawing.Size(534, 398)
        Me.ProductsDgv.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(561, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(291, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Состав изделия"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ChangeLogBtn
        '
        Me.ChangeLogBtn.Location = New System.Drawing.Point(561, 41)
        Me.ChangeLogBtn.Name = "ChangeLogBtn"
        Me.ChangeLogBtn.Size = New System.Drawing.Size(291, 23)
        Me.ChangeLogBtn.TabIndex = 2
        Me.ChangeLogBtn.Text = "Журнал изменений"
        Me.ChangeLogBtn.UseVisualStyleBackColor = True
        '
        'CodeTb
        '
        Me.CodeTb.Enabled = False
        Me.CodeTb.Location = New System.Drawing.Point(683, 258)
        Me.CodeTb.MaxLength = 30
        Me.CodeTb.Name = "CodeTb"
        Me.CodeTb.Size = New System.Drawing.Size(169, 23)
        Me.CodeTb.TabIndex = 3
        '
        'NameTb
        '
        Me.NameTb.Enabled = False
        Me.NameTb.Location = New System.Drawing.Point(683, 287)
        Me.NameTb.MaxLength = 150
        Me.NameTb.Name = "NameTb"
        Me.NameTb.Size = New System.Drawing.Size(169, 23)
        Me.NameTb.TabIndex = 4
        '
        'UnitTb
        '
        Me.UnitTb.Enabled = False
        Me.UnitTb.Location = New System.Drawing.Point(683, 316)
        Me.UnitTb.MaxLength = 2
        Me.UnitTb.Name = "UnitTb"
        Me.UnitTb.Size = New System.Drawing.Size(169, 23)
        Me.UnitTb.TabIndex = 5
        '
        'AddBtn
        '
        Me.AddBtn.Location = New System.Drawing.Point(559, 154)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(293, 23)
        Me.AddBtn.TabIndex = 6
        Me.AddBtn.Text = "Добавить новое"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'UpdateBtn
        '
        Me.UpdateBtn.Location = New System.Drawing.Point(559, 183)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(293, 23)
        Me.UpdateBtn.TabIndex = 7
        Me.UpdateBtn.Text = "Изменить выделенное"
        Me.UpdateBtn.UseVisualStyleBackColor = True
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Location = New System.Drawing.Point(559, 212)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(293, 23)
        Me.DeleteBtn.TabIndex = 8
        Me.DeleteBtn.Text = "Удалить выделенное"
        Me.DeleteBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(650, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Код"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(618, 290)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Название"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(561, 319)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Единица измерения"
        '
        'SaveBtn
        '
        Me.SaveBtn.Enabled = False
        Me.SaveBtn.Location = New System.Drawing.Point(559, 359)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(293, 23)
        Me.SaveBtn.TabIndex = 12
        Me.SaveBtn.Text = "Сохранить"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Enabled = False
        Me.CancelBtn.Location = New System.Drawing.Point(559, 388)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(293, 23)
        Me.CancelBtn.TabIndex = 13
        Me.CancelBtn.Text = "Отмена"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'ProductsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 424)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.UpdateBtn)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.UnitTb)
        Me.Controls.Add(Me.NameTb)
        Me.Controls.Add(Me.CodeTb)
        Me.Controls.Add(Me.ChangeLogBtn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProductsDgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ProductsForm"
        Me.Text = "Изделия"
        CType(Me.ProductsDgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProductsDgv As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents ChangeLogBtn As Button
    Friend WithEvents CodeTb As TextBox
    Friend WithEvents NameTb As TextBox
    Friend WithEvents UnitTb As TextBox
    Friend WithEvents AddBtn As Button
    Friend WithEvents UpdateBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SaveBtn As Button
    Friend WithEvents CancelBtn As Button
End Class
