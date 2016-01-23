Public Class Form1

    Public Shared bookId As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MessageBox.Show(Button1.Text)
        Console.Write("Boe-")

        ' T1TableAdapter.Update("book7", "setumei7", 2, "book2", "setumei2")
        ' T1TableAdapter.Update(LibrarySyetemDataSet.t1.Rows.Item(1))
        ' T1TableAdapter.Insert("book8", "setumei8")
        T1TableAdapter.Update(LibrarySyetemDataSet.t1)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'LibrarySyetemDataSet.t1' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.T1TableAdapter.Fill(Me.LibrarySyetemDataSet.t1)
        'TODO: このコード行はデータを 'LibrarySyetemDataSet.PrefecturesMas' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.PrefecturesMasTableAdapter.Fill(Me.LibrarySyetemDataSet.PrefecturesMas)

        'Dim adapter As New LibrarySyetemDataSetTableAdapters.t1TableAdapter
        'adapter.Fill()
        Me.LibrarySyetemDataSet.t1.IDColumn.AutoIncrementSeed = T1DataGridView.Rows.Count

    End Sub

    Private Sub PrefecturesMasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PrefecturesMasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibrarySyetemDataSet)

    End Sub
End Class
