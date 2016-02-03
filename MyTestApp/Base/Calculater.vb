Imports MyTestApp

Public Class Calculater
    Implements ICalculater
    Private rrule As RoundRule

    Private Enum RoundRule
        Ceil
        Floor
        Round
    End Enum

    Public Sub New()
        Select Case My.Settings.RoundRule
            Case "Ceil"
                rrule = RoundRule.Ceil
            Case "Floor"
                rrule = RoundRule.Floor
            Case "Round"
                rrule = RoundRule.Round
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
End Class
