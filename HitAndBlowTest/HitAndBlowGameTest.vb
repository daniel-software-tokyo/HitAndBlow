﻿Imports HitAndBlow
Imports NUnit.Framework
<TestFixture> Public MustInherit Class HitAndBlowGameTest
    Private sut As HitAndBlowGame
    <SetUp> Public Overridable Sub Setup()
        sut = New HitAndBlowGame
    End Sub

    Public Class CountNumberOfHitTest : Inherits HitAndBlowGameTest
        <Test()> Public Sub ヒット数を返すメソッドのテスト()
            Dim playerNumber As New List(Of Char)(New Char() {"1"c, "5"c, "3"c, "0"c})
            Dim computerNumber As New List(Of Char)(New Char() {"1"c, "5"c, "3"c, "4"c})


            Dim result As Integer = sut.CountNumberOfHit(computerNumber, playerNumber)
            Assert.That(result, [Is].EqualTo(3))

        End Sub
    End Class

    Public Class CountNumberOfBlowTest : Inherits HitAndBlowGameTest
        <Test()> Public Sub ブロー数を返すメソッドのテスト()
            Dim playerNumber As New List(Of Char)(New Char() {"4"c, "3"c, "8"c, "0"c})
            Dim computerNumber As New List(Of Char)(New Char() {"1"c, "5"c, "3"c, "4"c})


            Dim result As Integer = sut.CountNumberOfBlow(computerNumber, playerNumber)
            Assert.That(result, [Is].EqualTo(2))

        End Sub
    End Class

    Public Class DeleteHitNumberTest : Inherits HitAndBlowGameTest
        <Test()> Public Sub ヒットした数字削除して返すかテスト()
            Dim number As New List(Of Char)(New Char() {"1"c, "2"c, "3"c, "4"c})
            Dim hitNumberIndex As New List(Of Integer)(New Integer() {2, 1})

            Dim resultList As New List(Of Char)(New Char() {"1"c, "4"c})

            Dim result As List(Of Char) = sut.DeleteHitNumber(number, hitNumberIndex)
            Assert.That(result, [Is].EqualTo(resultList))

        End Sub
    End Class

    Public Class GetHitIndexstTest : Inherits HitAndBlowGameTest
        <Test()> Public Sub ヒットした位置を返すメソッドのテスト()
            Dim playerNumber As New List(Of Char)(New Char() {"1"c, "2"c, "3"c, "4"c})
            Dim computerNumber As New List(Of Char)(New Char() {"1"c, "5"c, "3"c, "4"c})

            Dim resultList As New List(Of Integer)(New Integer() {0, 2, 3})

            Dim result As List(Of Integer) = sut.GetHitIndexs(computerNumber, playerNumber)
            Assert.That(result, [Is].EqualTo(resultList))


        End Sub
    End Class

End Class
