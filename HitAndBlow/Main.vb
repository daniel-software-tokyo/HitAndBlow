﻿Public Module Main

    Sub Main()

    End Sub

    ''' <summary>
    ''' 数字を受け取りヒット＆ブローの結果を返す
    ''' </summary>
    ''' <param name="playerAnswer"></param>
    ''' <returns></returns>
    Public Function ReturnResultOfHitAndBlowGame(playerAnswer As Integer) As String
        Dim computerNumber As New List(Of Char)(New Char() {"1"c, "2"c, "3"c, "4"c})
        Dim playerNumber As New List(Of Char)(playerAnswer.ToString.ToCharArray)
        Dim hit As Integer = 0
        Dim blow As Integer = 0
        'hitした数字はblowでは比較しないので削除します。hitの位置を記録します
        Dim hitIndexs As New List(Of Integer)

        For i As Integer = 0 To computerNumber.Count - 1
            If computerNumber(i) = playerNumber(i) Then
                hit += 1
                hitIndexs.Add(i)
            End If
        Next

        If hit < 4 Then

            '反転させ数字の大きい方から削除します
            hitIndexs.Reverse()
            For Each hitIndex As Integer In hitIndexs
                computerNumber.RemoveAt(hitIndex)
                playerNumber.RemoveAt(hitIndex)
            Next

            For j As Integer = 0 To computerNumber.Count - 1
                For k As Integer = 0 To playerNumber.Count - 1
                    If computerNumber(j) = playerNumber(k) Then
                        blow += 1
                        playerNumber.RemoveAt(k)
                        Exit For
                    End If
                Next
            Next

        End If

        Dim result As String = ("Hit:" & hit.ToString & "," & "Blow:" & blow.ToString)
        Return result

    End Function

End Module
