<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LibrarySyetemDataSet = New MyTestApp.LibrarySyetemDataSet()
        Me.PrefecturesMasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrefecturesMasTableAdapter = New MyTestApp.LibrarySyetemDataSetTableAdapters.PrefecturesMasTableAdapter()
        Me.TableAdapterManager = New MyTestApp.LibrarySyetemDataSetTableAdapters.TableAdapterManager()
        Me.PrefecturesMasComboBox = New System.Windows.Forms.ComboBox()
        Me.T1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.T1TableAdapter = New MyTestApp.LibrarySyetemDataSetTableAdapters.t1TableAdapter()
        Me.T1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.LibrarySyetemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrefecturesMasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LibrarySyetemDataSet
        '
        Me.LibrarySyetemDataSet.DataSetName = "LibrarySyetemDataSet"
        Me.LibrarySyetemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrefecturesMasBindingSource
        '
        Me.PrefecturesMasBindingSource.DataMember = "PrefecturesMas"
        Me.PrefecturesMasBindingSource.DataSource = Me.LibrarySyetemDataSet
        '
        'PrefecturesMasTableAdapter
        '
        Me.PrefecturesMasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PrefecturesMasTableAdapter = Me.PrefecturesMasTableAdapter
        Me.TableAdapterManager.t1TableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MyTestApp.LibrarySyetemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PrefecturesMasComboBox
        '
        Me.PrefecturesMasComboBox.DataSource = Me.PrefecturesMasBindingSource
        Me.PrefecturesMasComboBox.DisplayMember = "NAME"
        Me.PrefecturesMasComboBox.FormattingEnabled = True
        Me.PrefecturesMasComboBox.Location = New System.Drawing.Point(12, 80)
        Me.PrefecturesMasComboBox.Name = "PrefecturesMasComboBox"
        Me.PrefecturesMasComboBox.Size = New System.Drawing.Size(300, 20)
        Me.PrefecturesMasComboBox.TabIndex = 2
        Me.PrefecturesMasComboBox.ValueMember = "ID"
        '
        'T1BindingSource
        '
        Me.T1BindingSource.DataMember = "t1"
        Me.T1BindingSource.DataSource = Me.LibrarySyetemDataSet
        '
        'T1TableAdapter
        '
        Me.T1TableAdapter.ClearBeforeFill = True
        '
        'T1DataGridView
        '
        Me.T1DataGridView.AutoGenerateColumns = False
        Me.T1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.T1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.T1DataGridView.DataSource = Me.T1BindingSource
        Me.T1DataGridView.Location = New System.Drawing.Point(12, 140)
        Me.T1DataGridView.Name = "T1DataGridView"
        Me.T1DataGridView.RowTemplate.Height = 21
        Me.T1DataGridView.Size = New System.Drawing.Size(353, 220)
        Me.T1DataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NAME"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NAME"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DESCRIPTION"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DESCRIPTION"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 403)
        Me.Controls.Add(Me.T1DataGridView)
        Me.Controls.Add(Me.PrefecturesMasComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.LibrarySyetemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrefecturesMasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents LibrarySyetemDataSet As LibrarySyetemDataSet
    Friend WithEvents PrefecturesMasBindingSource As BindingSource
    Friend WithEvents PrefecturesMasTableAdapter As LibrarySyetemDataSetTableAdapters.PrefecturesMasTableAdapter
    Friend WithEvents TableAdapterManager As LibrarySyetemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PrefecturesMasComboBox As ComboBox
    Friend WithEvents T1BindingSource As BindingSource
    Friend WithEvents T1TableAdapter As LibrarySyetemDataSetTableAdapters.t1TableAdapter
    Friend WithEvents T1DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
