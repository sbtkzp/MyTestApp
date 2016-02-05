''' <summary>
''' DBへの読み書き機能を有するフォームのインタフェース
''' </summary>
''' <history>柴田和樹 2016/02/06 Create</history>
Public Interface IFormDBAdaptable

    ''' <summary>
    ''' テーブル情報を格納
    ''' </summary>
    ''' <returns>1つのテーブル情報</returns>
    Property table

    ''' <summary>
    ''' 登録する行についての情報
    ''' </summary>
    ''' <returns>使用テーブルの行情報</returns>
    Property row

    ''' <summary>
    ''' コントロールの値をDBへ登録可能な値に変換するメソッド
    ''' </summary>
    ''' <param name="columnName">データ行のカラム名</param>
    ''' <param name="type">DBへ登録可能な型</param>
    ''' <returns></returns>
    Function ConvertToDBVal(ByVal columnName, ByVal type)

    ''' <summary>
    ''' DBからの取得値をコントロールに当て込む値へ変換するメソッド
    ''' </summary>
    ''' <param name="columnName">データ行のカラム名</param>
    ''' <param name="type">コントロールへ当て込む際の型</param>
    ''' <returns></returns>
    Function ConvertFromDBVal(ByVal columnName, ByVal type)

End Interface
