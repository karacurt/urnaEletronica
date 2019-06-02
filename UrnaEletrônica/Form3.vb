Public Class Form3
    Dim votos As New Votos

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' votos.Calcular()
        ' Label1.Text = Val(votos.Calcular())
        votos.DilmaVotos()
        votos.LevyVotos()
        votos.MarinaVotos()
        votos.SerraVotos()
        votos.ZemariaVotos()
        votos.NulosVotos()

        Label1.Text = votos.DilmaVotos().ToString("0.0 %")
        Label3.Text = votos.SerraVotos().ToString("0.0 %")
        Label17.Text = votos.LevyVotos().ToString("0.0 %")
        Label25.Text = votos.ZemariaVotos().ToString("0.0 %")
        Label33.Text = votos.MarinaVotos().ToString("0.0 %")
        Label45.Text = votos.NulosVotos().ToString("0.0 %")
        Label46.Text = Val(cont) & " Votos"

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
      
    End Sub

    Private Sub Label42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label42.Click

    End Sub

    Private Sub Label46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label46.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cont = 0
        dilma = 0
        serra = 0
        zemaria = 0
        levy = 0
        marina = 0
        nulos = 0
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MessageBox.Show("Software desenvolvido por Daniel de Jesus Lima e Victor Santos - 4i20 Corporation, todos os direitos reservados.", "Sobre", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class