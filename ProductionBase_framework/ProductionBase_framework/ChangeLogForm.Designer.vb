<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeLogForm
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
        Me.ChangeLogDgv = New System.Windows.Forms.DataGridView()
        CType(Me.ChangeLogDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChangeLogDgv
        '
        Me.ChangeLogDgv.AllowUserToAddRows = False
        Me.ChangeLogDgv.AllowUserToDeleteRows = False
        Me.ChangeLogDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ChangeLogDgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChangeLogDgv.Location = New System.Drawing.Point(0, 0)
        Me.ChangeLogDgv.Name = "ChangeLogDgv"
        Me.ChangeLogDgv.ReadOnly = True
        Me.ChangeLogDgv.Size = New System.Drawing.Size(837, 450)
        Me.ChangeLogDgv.TabIndex = 0
        '
        'ChangeLogForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 450)
        Me.Controls.Add(Me.ChangeLogDgv)
        Me.Name = "ChangeLogForm"
        Me.Text = "Журнал изменений"
        CType(Me.ChangeLogDgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ChangeLogDgv As DataGridView
End Class
