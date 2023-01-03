Module Module1

    Sub Main()
        Dim n As New Random
        Dim innings As Double = 0
        Dim max = 0
        Do
            innings += 1
            Dim score = 0
            Dim out As Boolean = False
            While Not out
                Dim roll = n.Next(1, 7)
                If roll = 6 Then
                    roll = n.Next(1, 5)
                    If roll <> 4 Then
                        out = True
                    End If
                Else
                    Select Case roll
                        Case 2 Or 3
                            score += roll - 1
                        Case 4
                            score += roll
                        Case 5
                            score += 6
                        Case Else
                            score += 0
                    End Select
                End If
            End While
            If score > max Then
                max = score
                Console.WriteLine("After {0} games, a new top score of {1} at time of {2}", innings.ToString("#,#"), score, Now.ToString("h:mm:ss tt"))
            End If
        Loop
    End Sub

End Module
