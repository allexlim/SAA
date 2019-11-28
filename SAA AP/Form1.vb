Public Class Form1
    Dim button(100) As Button
    Dim game As Button
    Dim a As Integer = 0
    Dim wow As Integer = 0
    Dim angka As Integer = 30
    Dim hello As Integer = 0
    Dim simpan As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        game = New Button
        game.BackColor = Color.Gold
        game.Height = 25
        game.Width = 25
        game.Left = 0
        game.Top = 350
        Me.Controls.Add(game)


        For i = 0 To 7
            For j = 0 To 7
                If i Mod 2 = 0 Then
                    a += 1
                    button(a) = New Button
                    button(a).Height = 50
                    button(a).Width = 50
                    button(a).Left = j * 50
                    button(a).Top = (7 - i) * 50
                    button(a).Name = a
                    button(a).Text = a
                    Me.Controls.Add(button(a))
                Else
                    a += 1
                    button(a) = New Button
                    button(a).Height = 50
                    button(a).Width = 50
                    button(a).Left = (7 - j) * 50
                    button(a).Top = (7 - i) * 50
                    button(a).Name = a
                    button(a).Text = a
                    Me.Controls.Add(button(a))
                End If
            Next
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Randomize()
        If angka > 0 Then
            simpan = Rnd() * 5 + 1
            Label2.Text = simpan
            angka -= 1
        Else
            Timer1.Enabled = False
            hello = 1
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If hello = 1 Then
            Timer2.Enabled = False
            simpan = Rnd() * 5 + 1
            Label2.Text = simpan
            Label2.Font = New Font(Label2.Font, FontStyle.Underline)
            angka = 30
            hello = 0
            game.Height = 25
            game.Width = 25
            game.Left = simpan + 50
            game.Top = 350
            Me.Controls.Add(game)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Timer2.Enabled = True
        Label2.Font = New Font(Label2.Font, FontStyle.Strikeout)
    End Sub
End Class
