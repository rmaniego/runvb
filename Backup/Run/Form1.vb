Public Class Form1
    Dim a As Integer = 2
    Dim b As Integer = 1
    Dim c As Integer = 0
    Dim d As Integer = 10
    Dim g As Integer = 20
    Dim h As Integer = 0
    'player.Left = -187

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        player.Left += a
        If a > 50 Then
            a = 50
        End If

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Label6.Visible = False
        player.Visible = True
        h += 1
        If c = 1 Then
            Label1.Text = "Reach the red stump to win..."
            b = 1
        ElseIf c = 2 Then
            Label1.Text = "Running swiftly..."
            b = 1
            c = 3
        End If

        Timer1.Enabled = True
        a += 2
    End Sub
    Private Sub Label2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.MouseHover
        Label2.Left = 306
    End Sub
    Private Sub Label2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.MouseLeave
        Label2.Left = 300
    End Sub
    Private Sub Label3_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.MouseHover
        Label3.Left = 184
    End Sub
    Private Sub Label3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.MouseLeave
        Label3.Left = 190
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        a -= 2
        If a < 0 Then
            a = 0
        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        a -= 2
        If a < 0 Then
            a = 0
        End If
    End Sub

    Private Sub Label4_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.MouseHover
        Timer3.Enabled = True
        Timer4.Enabled = False
    End Sub
    Private Sub Label4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.MouseLeave
        Timer4.Enabled = True
        Timer3.Enabled = False
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If Not (Label4.Top > 0) Then
            Label4.Top += 5
        Else
            Timer3.Enabled = False
        End If
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        If Not (Label4.Top < -28) Then
            Label4.Top -= 5
        Else
            Timer4.Enabled = False
        End If
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        If Label4.Top > 0 Then
            Dispose()
            Close()
        End If
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        b += 1
        If b > 0 And b < 15 And (b Mod 2 = 1) Then
            Label6.Visible = False
        ElseIf b > 16 And Label1.Visible = True Then
            Label6.Visible = True
        ElseIf d = 0 Then
            Label6.Text = "Start now!!"
            Label1.Visible = True
            Timer6.Enabled = True
            Label2.Visible = True
            Label3.Visible = True
            Label5.Visible = True
            Timer5.Enabled = False
            b = 1
            c = 1
        Else
            Label6.Visible = True
            Label6.Text = "Starts in " & d & " ..."
            d -= 1
        End If

        If h > 0 And h < 15 And (h Mod 2 = 1) Then
            h += 1
            Label6.Visible = False
        ElseIf h > 16 And Label1.Visible = True Then
            h += 1
            Label6.Visible = True
        End If
    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        Label5.Text = g & " sec left!!"
        g -= 1

        If g < 0 And player.Left < 528 Then
            Label6.Text = "You lost!!"
            Timer7.Enabled = True
            Label6.Visible = True
            Label7.Visible = True
            Label1.Visible = False
            Timer6.Enabled = False
            Label2.Visible = False
            player.Visible = False
            Label3.Visible = False
            Label5.Visible = False
            Stp.Visible = False
        ElseIf g < 0 And player.Left > 527 Then
            Label6.Text = "You won!!"
            Timer7.Enabled = True
            Label6.Visible = True
            Label7.Visible = True
            Label1.Visible = False
            Timer6.Enabled = False
            Label2.Visible = False
            player.Visible = False
            Label3.Visible = False
            Label5.Visible = False
            Stp.Visible = False
        End If
    End Sub

    Private Sub Label7_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.MouseHover
        Timer7.Enabled = True
        Timer8.Enabled = False
    End Sub
    Private Sub Label7_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.MouseLeave
        Timer8.Enabled = True
        Timer7.Enabled = False
    End Sub

    Private Sub Timer7_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer7.Tick
        If Not (Label7.Left < 460) Then
            Label7.Text = " < Restart"
            Label7.Left -= 5
        Else
            Timer7.Enabled = False
        End If
    End Sub

    Private Sub Timer8_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer8.Tick
        If Not (Label7.Left > 620) Then
            Label7.Text = " > Restart"
            Label7.Left += 5
        Else
            Timer8.Enabled = False
        End If
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        If Label7.Left < 500 Then
            player.Left = -75
            Stp.Visible = True
            Timer8.Enabled = True
            Timer7.Enabled = False
            Timer5.Enabled = True
            a = 2
            c = 0
            d = 10
            g = 20
            h = 0
        End If
    End Sub
End Class
