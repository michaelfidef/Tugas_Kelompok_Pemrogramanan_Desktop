Public Class Form1

    Dim checker As Boolean
    Dim addOneToScore As Integer = 0
    Dim TimerNumber As Integer

    Private Sub Enable_False()
        btn11.Enabled = False
        btn12.Enabled = False
        btn13.Enabled = False
        btn21.Enabled = False
        btn22.Enabled = False
        btn23.Enabled = False
        btn31.Enabled = False
        btn32.Enabled = False
        btn33.Enabled = False

        TimerNumber = 11
    End Sub

    Private Sub reset()
        btn11.Enabled = True
        btn12.Enabled = True
        btn13.Enabled = True
        btn21.Enabled = True
        btn22.Enabled = True
        btn23.Enabled = True
        btn31.Enabled = True
        btn32.Enabled = True
        btn33.Enabled = True

        btn11.Text = ""
        btn12.Text = ""
        btn13.Text = ""
        btn21.Text = ""
        btn22.Text = ""
        btn23.Text = ""
        btn31.Text = ""
        btn32.Text = ""
        btn33.Text = ""

        btn11.BackColor = Color.White
        btn12.BackColor = Color.White
        btn13.BackColor = Color.White
        btn21.BackColor = Color.White
        btn22.BackColor = Color.White
        btn23.BackColor = Color.White
        btn31.BackColor = Color.White
        btn32.BackColor = Color.White
        btn33.BackColor = Color.White

        TimerNumber = 11

    End Sub

    Private Sub reset_interface()
        lblRound1.Text = "0"
        ScoreX.Text = "0"
        ScoreO.Text = "0"

    End Sub

    Private Sub btn11_Click(sender As Object, e As EventArgs) Handles btn11.Click
        If (checker = False) Then
            btn11.Text = "X"
            lblGiliran1.Text = "O"
            checker = True
        Else
            btn11.Text = "O"
            lblGiliran1.Text = "X"
            checker = False
        End If
        If Timer1.Enabled = True Then
            Timer1.Start()
        Else
            lblTime.Text = 10
            Timer1.Start()
        End If
        btn11.Enabled = False
        Timer1.Enabled = True
        checkForWin()

    End Sub

    Private Sub btn12_Click(sender As Object, e As EventArgs) Handles btn12.Click
        If (checker = False) Then
            btn12.Text = "X"
            lblGiliran1.Text = "O"
            checker = True
        Else
            btn12.Text = "O"
            lblGiliran1.Text = "X"
            checker = False
        End If
        If Timer1.Enabled = True Then
            Timer1.Start()
        Else
            lblTime.Text = 10
            Timer1.Start()
        End If
        btn12.Enabled = False
        Timer1.Enabled = True
        checkForWin()

    End Sub

    Private Sub btn13_Click(sender As Object, e As EventArgs) Handles btn13.Click
        If (checker = False) Then
            btn13.Text = "X"
            lblGiliran1.Text = "0"
            checker = True
        Else
            btn13.Text = "O"
            lblGiliran1.Text = "X"
            checker = False
        End If
        btn13.Enabled = False
        Timer1.Enabled = True
        checkForWin()
    End Sub

    Private Sub btn21_Click(sender As Object, e As EventArgs) Handles btn21.Click
        If (checker = False) Then
            btn21.Text = "X"
            lblGiliran1.Text = "0"
            checker = True
        Else
            btn21.Text = "O"
            lblGiliran1.Text = "X"
            checker = False
        End If
        btn21.Enabled = False
        Timer1.Enabled = True
        checkForWin()
    End Sub

    Private Sub btn22_Click(sender As Object, e As EventArgs) Handles btn22.Click
        If (checker = False) Then
            btn22.Text = "X"
            lblGiliran1.Text = "O"
            checker = True
        Else
            btn22.Text = "O"
            lblGiliran1.Text = "X"
            checker = False
        End If
        btn22.Enabled = False
        Timer1.Enabled = True
        checkForWin()
    End Sub

    Private Sub btn23_Click(sender As Object, e As EventArgs) Handles btn23.Click
        If (checker = False) Then
            btn23.Text = "X"
            lblGiliran1.Text = "O"
            checker = True
        Else
            btn23.Text = "O"
            lblGiliran1.Text = "X"
            checker = False
        End If
        btn23.Enabled = False
        Timer1.Enabled = True
        checkForWin()
    End Sub

    Private Sub btn31_Click(sender As Object, e As EventArgs) Handles btn31.Click
        If (checker = False) Then
            btn31.Text = "X"
            lblGiliran1.Text = "O"
            checker = True
        Else
            btn31.Text = "O"
            lblGiliran1.Text = "X"
            checker = False
        End If
        btn31.Enabled = False
        Timer1.Enabled = True
        checkForWin()
    End Sub

    Private Sub btn32_Click(sender As Object, e As EventArgs) Handles btn32.Click
        If (checker = False) Then
            btn32.Text = "X"
            lblGiliran1.Text = "O"
            checker = True
        Else
            btn32.Text = "O"
            lblGiliran1.Text = "X"
            checker = False
        End If
        btn32.Enabled = False
        Timer1.Enabled = True
        checkForWin()
    End Sub

    Private Sub btn33_Click(sender As Object, e As EventArgs) Handles btn33.Click
        If (checker = False) Then
            btn33.Text = "X"
            lblGiliran1.Text = "O"
            checker = True
        Else
            btn33.Text = "O"
            lblGiliran1.Text = "X"
            checker = False
        End If
        btn33.Enabled = False
        Timer1.Enabled = True
        checkForWin()
    End Sub

    Sub checkForWin()
        TimerNumber = 11
        If btn11.Text = "X" And btn12.Text = "X" And btn13.Text = "X" Then
            btn11.BackColor = Color.Green
            btn12.BackColor = Color.Green
            btn13.BackColor = Color.Green
            Timer1.Enabled = False
            MessageBox.Show("Pemenang game set saat ini adalah pemain x", "Pemenang Game Set ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(ScoreX.Text)
            ScoreX.Text = Convert.ToString(addOneToScore + 1)
            addOneToScore = Convert.ToInt64(lblRound1.Text)
            lblRound1.Text = Convert.ToString(addOneToScore + 1)
            Enable_False()
            reset()
        End If
        If btn11.Text = "X" And btn22.Text = "X" And btn33.Text = "X" Then
            btn11.BackColor = Color.Green
            btn22.BackColor = Color.Green
            btn33.BackColor = Color.Green
            Timer1.Enabled = False
            MessageBox.Show("Pemenang game set saat ini adalah pemain x", "Pemenang Game Set ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(ScoreX.Text)
            ScoreX.Text = Convert.ToString(addOneToScore + 1)
            addOneToScore = Convert.ToInt64(lblRound1.Text)
            lblRound1.Text = Convert.ToString(addOneToScore + 1)
            Enable_False()
            reset()
        End If
        If btn11.Text = "X" And btn21.Text = "X" And btn31.Text = "X" Then
            btn11.BackColor = Color.Green
            btn21.BackColor = Color.Green
            btn31.BackColor = Color.Green
            Timer1.Enabled = False
            MessageBox.Show("Pemenang game set saat ini adalah pemain x", "Pemenang Game Set ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(ScoreX.Text)
            ScoreX.Text = Convert.ToString(addOneToScore + 1)
            addOneToScore = Convert.ToInt64(lblRound1.Text)
            lblRound1.Text = Convert.ToString(addOneToScore + 1)
            Enable_False()
            reset()
        End If
        If btn12.Text = "X" And btn22.Text = "X" And btn32.Text = "X" Then
            btn12.BackColor = Color.Green
            btn22.BackColor = Color.Green
            btn32.BackColor = Color.Green
            Timer1.Enabled = False
            MessageBox.Show("Pemenang game set saat ini adalah pemain x", "Pemenang Game Set ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(ScoreX.Text)
            ScoreX.Text = Convert.ToString(addOneToScore + 1)
            addOneToScore = Convert.ToInt64(lblRound1.Text)
            lblRound1.Text = Convert.ToString(addOneToScore + 1)
            Enable_False()
            reset()
        End If
        If btn13.Text = "X" And btn23.Text = "X" And btn33.Text = "X" Then
            btn13.BackColor = Color.Green
            btn23.BackColor = Color.Green
            btn33.BackColor = Color.Green
            Timer1.Enabled = False
            MessageBox.Show("Pemenang game set saat ini adalah pemain x", "Pemenang Game Set ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(ScoreX.Text)
            ScoreX.Text = Convert.ToString(addOneToScore + 1)
            addOneToScore = Convert.ToInt64(lblRound1.Text)
            lblRound1.Text = Convert.ToString(addOneToScore + 1)
            Enable_False()
            reset()
        End If
        If btn21.Text = "X" And btn22.Text = "X" And btn23.Text = "X" Then
            btn21.BackColor = Color.Green
            btn22.BackColor = Color.Green
            btn23.BackColor = Color.Green
            Timer1.Enabled = False
            MessageBox.Show("Pemenang game set saat ini adalah pemain x", "Pemenang Game Set ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(ScoreX.Text)
            ScoreX.Text = Convert.ToString(addOneToScore + 1)
            addOneToScore = Convert.ToInt64(lblRound1.Text)
            lblRound1.Text = Convert.ToString(addOneToScore + 1)
            Enable_False()
            reset()
        End If
        If btn31.Text = "X" And btn32.Text = "X" And btn33.Text = "X" Then
            btn31.BackColor = Color.Green
            btn32.BackColor = Color.Green
            btn33.BackColor = Color.Green
            Timer1.Enabled = False
            MessageBox.Show("Pemenang game set saat ini adalah pemain x", "Pemenang Game Set ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(ScoreX.Text)
            ScoreX.Text = Convert.ToString(addOneToScore + 1)
            addOneToScore = Convert.ToInt64(lblRound1.Text)
            lblRound1.Text = Convert.ToString(addOneToScore + 1)
            Enable_False()
            reset()
        End If
        If btn13.Text = "X" And btn22.Text = "X" And btn31.Text = "X" Then
            btn13.BackColor = Color.Green
            btn22.BackColor = Color.Green
            btn31.BackColor = Color.Green
            Timer1.Enabled = False
            MessageBox.Show("Pemenang game set saat ini adalah pemain x", "Pemenang Game Set ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(ScoreX.Text)
            ScoreX.Text = Convert.ToString(addOneToScore + 1)
            addOneToScore = Convert.ToInt64(lblRound1.Text)
            lblRound1.Text = Convert.ToString(addOneToScore + 1)
            Enable_False()
            reset()
        End If

        If btn11.Text = "O" And btn12.Text = "O" And btn13.Text = "O" Then
            btn11.BackColor = Color.Green
            btn12.BackColor = Color.Green
            btn13.BackColor = Color.Green
            Timer1.Enabled = False
            MessageBox.Show("Pemenang game set saat ini adalah pemain O", "Pemenang Game Set ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(ScoreO.Text)
            ScoreO.Text = Convert.ToString(addOneToScore + 1)
            addOneToScore = Convert.ToInt64(lblRound1.Text)
            lblRound1.Text = Convert.ToString(addOneToScore + 1)
            Enable_False()
            reset()
        End If
        If btn11.Text = "O" And btn22.Text = "O" And btn33.Text = "O" Then
            btn11.BackColor = Color.Green
            btn22.BackColor = Color.Green
            btn33.BackColor = Color.Green
            Timer1.Enabled = False
            MessageBox.Show("Pemenang game set saat ini adalah pemain O", "Pemenang Game Set ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(ScoreO.Text)
            ScoreO.Text = Convert.ToString(addOneToScore + 1)
            addOneToScore = Convert.ToInt64(lblRound1.Text)
            lblRound1.Text = Convert.ToString(addOneToScore + 1)
            Enable_False()
            reset()
        End If
        If btn11.Text = "O" And btn21.Text = "O" And btn31.Text = "O" Then
            btn11.BackColor = Color.Green
            btn21.BackColor = Color.Green
            btn31.BackColor = Color.Green
            Timer1.Enabled = False
            MessageBox.Show("Pemenang game set saat ini adalah pemain O", "Pemenang Game Set ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(ScoreO.Text)
            ScoreO.Text = Convert.ToString(addOneToScore + 1)
            addOneToScore = Convert.ToInt64(lblRound1.Text)
            lblRound1.Text = Convert.ToString(addOneToScore + 1)
            Enable_False()
            reset()
        End If
        If btn12.Text = "O" And btn22.Text = "O" And btn32.Text = "O" Then
            btn12.BackColor = Color.Green
            btn22.BackColor = Color.Green
            btn32.BackColor = Color.Green
            Timer1.Enabled = False
            MessageBox.Show("Pemenang game set saat ini adalah pemain O", "Pemenang Game Set ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(ScoreO.Text)
            ScoreO.Text = Convert.ToString(addOneToScore + 1)
            addOneToScore = Convert.ToInt64(lblRound1.Text)
            lblRound1.Text = Convert.ToString(addOneToScore + 1)
            Enable_False()
            reset()
        End If
        If btn13.Text = "O" And btn23.Text = "O" And btn33.Text = "O" Then
            btn13.BackColor = Color.Green
            btn23.BackColor = Color.Green
            btn33.BackColor = Color.Green
            Timer1.Enabled = False
            MessageBox.Show("Pemenang game set saat ini adalah pemain O", "Pemenang Game Set ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(ScoreO.Text)
            ScoreO.Text = Convert.ToString(addOneToScore + 1)
            addOneToScore = Convert.ToInt64(lblRound1.Text)
            lblRound1.Text = Convert.ToString(addOneToScore + 1)
            Enable_False()
            reset()
        End If
        If btn21.Text = "O" And btn22.Text = "O" And btn23.Text = "O" Then
            btn21.BackColor = Color.Green
            btn22.BackColor = Color.Green
            btn23.BackColor = Color.Green
            Timer1.Enabled = False
            MessageBox.Show("Pemenang game set saat ini adalah pemain O", "Pemenang Game Set ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(ScoreO.Text)
            ScoreO.Text = Convert.ToString(addOneToScore + 1)
            addOneToScore = Convert.ToInt64(lblRound1.Text)
            lblRound1.Text = Convert.ToString(addOneToScore + 1)
            Enable_False()
            reset()
        End If
        If btn31.Text = "O" And btn32.Text = "O" And btn33.Text = "O" Then
            btn31.BackColor = Color.Green
            btn32.BackColor = Color.Green
            btn33.BackColor = Color.Green
            Timer1.Enabled = False
            MessageBox.Show("Pemenang game set saat ini adalah pemain O", "Pemenang Game Set ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(ScoreO.Text)
            ScoreO.Text = Convert.ToString(addOneToScore + 1)
            addOneToScore = Convert.ToInt64(lblRound1.Text)
            lblRound1.Text = Convert.ToString(addOneToScore + 1)
            Enable_False()
            reset()
        End If
        If btn13.Text = "O" And btn22.Text = "O" And btn31.Text = "O" Then
            btn13.BackColor = Color.Green
            btn22.BackColor = Color.Green
            btn31.BackColor = Color.Green
            Timer1.Enabled = False
            MessageBox.Show("Pemenang game set saat ini adalah pemain O", "Pemenang Game Set ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(ScoreO.Text)
            ScoreO.Text = Convert.ToString(addOneToScore + 1)
            addOneToScore = Convert.ToInt64(lblRound1.Text)
            lblRound1.Text = Convert.ToString(addOneToScore + 1)
            Enable_False()
            reset()
        End If
        Score_Count()
        Draw()
    End Sub

    Private Sub Score_Count()
        If ScoreX.Text = 2 Then
            Dim playAgain As DialogResult = MessageBox.Show("Pemenangnya Adalah Pemain X", "Main Lagi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If playAgain = DialogResult.Yes Then
                reset()
                reset_interface()
            Else
                Application.Exit()
            End If
        End If
        If ScoreO.Text = 2 Then
            Dim playAgain As DialogResult = MessageBox.Show("Pemenangnya Adalah Pemain O", "Main Lagi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If playAgain = DialogResult.Yes Then
                reset()
                reset_interface()
            Else
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub Draw()
        If btn11.Enabled = False And btn12.Enabled = False And
            btn13.Enabled = False And
            btn21.Enabled = False And
            btn22.Enabled = False And
            btn23.Enabled = False And
            btn31.Enabled = False And
            btn32.Enabled = False And
            btn33.Enabled = False Then
            Timer1.Enabled = False
            MessageBox.Show("Hasil Game Set Saat Ini Adalah Draw!", "Pemenang Game Set", MessageBoxButtons.OK, MessageBoxIcon.Information)
            reset()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimerNumber = TimerNumber - 1
        lblTime.Text = TimerNumber

        If TimerNumber = 0 And lblGiliran1.Text = "X" Then
            Timer1.Enabled = False
            MessageBox.Show("Waktu Habis, Pemenang Set ini O", "Pemenang Game Set ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(ScoreO.Text)
            ScoreO.Text = Convert.ToString(addOneToScore + 1)
            addOneToScore = Convert.ToInt64(lblRound1.Text)
            lblRound1.Text = Convert.ToString(addOneToScore + 1)
            Score_Count()
            reset()
        End If
        If TimerNumber = 0 And lblGiliran1.Text = "O" Then
            Timer1.Enabled = False
            MessageBox.Show("Waktu Habis, Pemenang Set ini X", "Pemenang Game Set ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            addOneToScore = Convert.ToInt64(ScoreX.Text)
            ScoreX.Text = Convert.ToString(addOneToScore + 1)
            addOneToScore = Convert.ToInt64(lblRound1.Text)
            lblRound1.Text = Convert.ToString(addOneToScore + 1)
            Score_Count()
            reset()
        End If
    End Sub

End Class