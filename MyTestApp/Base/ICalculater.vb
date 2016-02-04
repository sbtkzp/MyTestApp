''' <summary>
''' 計算機インタフェース
''' </summary>

Public Interface ICalculater

    ''' <summary>
    ''' 特定桁数以下を切り上げた値を返すメソッド
    ''' </summary>
    ''' <param name="value">端数処理対象の数値</param>
    ''' <param name="digit">この桁数以下を端数とする</param>
    ''' <returns></returns>
    Function CeiledValue(ByVal value As Decimal, ByVal digit As Integer) As Integer

    ''' <summary>
    ''' 特定桁数以下を切り捨てた値を返すメソッド
    ''' </summary>
    ''' <param name="value">端数処理対象の数値</param>
    ''' <param name="digit">この桁数以下を端数とする</param>
    ''' <returns></returns>
    Function FlooredValue(ByVal value As Decimal, ByVal digit As Integer) As Integer

    ''' <summary>
    ''' 特定桁数以下を四捨五入した値を返すメソッド
    ''' </summary>
    ''' <param name="value">端数処理対象の数値</param>
    ''' <param name="digit">この桁数以下を端数とする</param>
    ''' <returns></returns>
    Function RoundedValue(ByVal value As Decimal, ByVal digit As Integer) As Integer

    ''' <summary>
    ''' 端数処理した値を返すメソッド
    ''' </summary>
    ''' <param name="value">端数処理対象の数値</param>
    ''' <param name="digit">この桁数以下を端数とする</param>
    ''' <returns></returns>
    Function DoRound(ByVal value As Decimal, ByVal digit As Integer) As Integer

End Interface
