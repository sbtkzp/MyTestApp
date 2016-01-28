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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Table2DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table2TableAdapter = New MyTestApp.LibrarySyetemDataSetTableAdapters.table2TableAdapter()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Table3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table3TableAdapter = New MyTestApp.LibrarySyetemDataSetTableAdapters.table3TableAdapter()
        Me.Table3DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.LibrarySyetemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrefecturesMasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Table2DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.Table3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table3DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableAdapterManager.table2TableAdapter = Nothing
        Me.TableAdapterManager.table3TableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MyTestApp.LibrarySyetemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PrefecturesMasComboBox
        '
        Me.PrefecturesMasComboBox.DataSource = Me.PrefecturesMasBindingSource
        Me.PrefecturesMasComboBox.DisplayMember = "NAME"
        Me.PrefecturesMasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
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
        Me.T1DataGridView.Location = New System.Drawing.Point(6, 6)
        Me.T1DataGridView.Name = "T1DataGridView"
        Me.T1DataGridView.RowTemplate.Height = 21
        Me.T1DataGridView.Size = New System.Drawing.Size(350, 247)
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 106)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(370, 285)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.T1DataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(362, 259)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "t1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.Table2DataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(362, 259)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "table2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Table2DataGridView
        '
        Me.Table2DataGridView.AutoGenerateColumns = False
        Me.Table2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table2DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Table2DataGridView.DataSource = Me.Table2BindingSource
        Me.Table2DataGridView.Location = New System.Drawing.Point(6, 6)
        Me.Table2DataGridView.Name = "Table2DataGridView"
        Me.Table2DataGridView.RowTemplate.Height = 21
        Me.Table2DataGridView.Size = New System.Drawing.Size(350, 247)
        Me.Table2DataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NAME"
        Me.DataGridViewTextBoxColumn5.HeaderText = "NAME"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PAYMENT"
        Me.DataGridViewTextBoxColumn6.HeaderText = "PAYMENT"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Table2BindingSource
        '
        Me.Table2BindingSource.DataMember = "table2"
        Me.Table2BindingSource.DataSource = Me.LibrarySyetemDataSet
        '
        'Table2TableAdapter
        '
        Me.Table2TableAdapter.ClearBeforeFill = True
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.Table3DataGridView)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(362, 259)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Table3BindingSource
        '
        Me.Table3BindingSource.DataMember = "table3"
        Me.Table3BindingSource.DataSource = Me.LibrarySyetemDataSet
        '
        'Table3TableAdapter
        '
        Me.Table3TableAdapter.ClearBeforeFill = True
        '
        'Table3DataGridView
        '
        Me.Table3DataGridView.AutoGenerateColumns = False
        Me.Table3DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table3DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.Table3DataGridView.DataSource = Me.Table3BindingSource
        Me.Table3DataGridView.Location = New System.Drawing.Point(6, 3)
        Me.Table3DataGridView.Name = "Table3DataGridView"
        Me.Table3DataGridView.RowTemplate.Height = 21
        Me.Table3DataGridView.Size = New System.Drawing.Size(350, 250)
        Me.Table3DataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "NAME"
        Me.DataGridViewTextBoxColumn8.HeaderText = "NAME"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "table2_ID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "table2_ID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "DESCRIPTION"
        Me.DataGridViewTextBoxColumn10.HeaderText = "DESCRIPTION"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 403)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PrefecturesMasComboBox)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.LibrarySyetemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrefecturesMasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Table2DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.Table3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table3DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Table2BindingSource As BindingSource
    Friend WithEvents Table2TableAdapter As LibrarySyetemDataSetTableAdapters.table2TableAdapter
    Friend WithEvents Table2DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Table3BindingSource As BindingSource
    Friend WithEvents Table3TableAdapter As LibrarySyetemDataSetTableAdapters.table3TableAdapter
    Friend WithEvents Table3DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
End Class
