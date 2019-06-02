Public Class Form2
    Public tempo As Integer

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tempo = 3
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
      

        If tempo > 0 Then
            Label2.Text = "Nova votação em " & Val(tempo) & " segundos"
            tempo -= 1
        Else
            Form1.Show()
            Me.Close()
        End If
    End Sub
End Class