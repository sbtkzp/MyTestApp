''' <summary>
''' 計算機クラス
''' </summary>

Public Class Calculater
    Implements ICalculater

    ''' <summary>
    ''' 丸め処理実行方法を示す列挙体
    ''' </summary>
    Enum RoundRule
        Ceil    ' 切り上げ
        Floor   ' 切り捨て
        Round   ' 四捨五入
    End Enum

    ''' <summary>
    ''' 丸め処理のルールを格納
    ''' </summary>
    ''' <returns>端数処理のルール</returns>
    Private Property Rule As RoundRule

    Public Sub New()
        Select Case My.Settings.RoundRule
            Case "Ceil"
                Rule = RoundRule.Ceil
            Case "Floor"
                Rule = RoundRule.Floor
            Case "Round"
                Rule = RoundRule.Round
        End Select
    End Sub
    ''' <summary>
    ''' 指定桁数以下を切り上げた値を返すメソッド
    ''' </summary>
    ''' <param name="value">端数処理対象の数値</param>
    ''' <param name="digit">この桁数以下を切り上げる</param>
    ''' <returns></returns>
    Public Function CeiledValue(value As Decimal, digit As Integer) As Integer Implements ICalculater.CeiledValue
        '' 実態として、小数点を移動させ、端数処理して少数点を戻す
        If digit <> 0 Then
            Dim movePoint As Integer = Math.Pow(10, digit)
            Return Math.Ceiling(value / movePoint) * movePoint
        Else
            Return Math.Ceiling(value)
        End If
    End Function

    ''' <summary>
    ''' 指定桁数以下を切り捨てた値を返すメソッド
    ''' </summary>
    ''' <param name="value">端数処理対象の数値</param>
    ''' <param name="digit">この桁数以下を切り捨てる</param>
    ''' <returns></returns>
    Public Function FlooredValue(value As Decimal, digit As Integer) As Integer Implements ICalculater.FlooredValue
        '' 実態として、小数点を移動させ、端数処理して少数点を戻す
        If digit <> 0 Then
            Dim movePoint As Integer = Math.Pow(10, digit)
            Return Math.Floor(value / movePoint) * movePoint
        Else
            Return Math.Floor(value)
        End If
    End Function

    ''' <summary>
    ''' 指定桁数以下を四捨五入した値を返すメソッド
    ''' </summary>
    ''' <param name="value">端数処理対象の数値</param>
    ''' <param name="digit">この桁数以下を端数とする</param>
    ''' <returns></returns>
    Public Function RoundedValue(value As Decimal, digit As Integer) As Integer Implements ICalculater.RoundedValue
        '' 実態として、小数点を移動させ、端数処理して少数点を戻す
        If digit <> 0 Then
            Dim movePoint As Integer = Math.Pow(10, digit)
            Return Math.Round(value / movePoint) * movePoint
        Else
            Return Math.Round(value)
        End If
    End Function

    ''' <summary>
    ''' 端数処理した値を返すメソッド
    ''' </summary>
    ''' <param name="value">端数処理対象の数値</param>
    ''' <param name="digit">この桁数以下を端数とする</param>
    ''' <returns></returns>
    Public Function DoRound(value As Decimal, digit As Integer) As Integer Implements ICalculater.DoRound
        Dim rounded As Integer
        Select Case Rule
            Case RoundRule.Ceil
                rounded = CeiledValue(value, digit)
            Case RoundRule.Floor
                rounded = FlooredValue(value, digit)
            Case RoundRule.Round
                rounded = RoundedValue(value, digit)
        End Select
        Return rounded
    End Function
End Class
