Public Class Form1
    Dim votos As New Votos


    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click

        If Label2.Text = "1" And Label3.Text = "3" Then
            cont = cont + 1
            dilma = dilma + 1
            Form2.Show()
            Me.Close()
        ElseIf Label2.Text = "4" And Label3.Text = "5" Then
            cont = cont + 1
            serra = serra + 1
            Form2.Show()
            Me.Close()
        ElseIf Label2.Text = "2" And Label3.Text = "8" Then
            cont = cont + 1
            levy = levy + 1
            Form2.Show()
            Me.Close()
        ElseIf Label2.Text = "1" And Label3.Text = "6" Then
            cont = cont + 1
            zemaria = zemaria + 1
            Form2.Show()
            Me.Close()
        ElseIf Label2.Text = "4" And Label3.Text = "3" Then
            cont = cont + 1
            marina = marina + 1
            Form2.Show()
            Me.Close()
        ElseIf Label2.Text = "0" And Label3.Text = "0" Then
            cont = cont + 1
            nulos = nulos + 1
            Form2.Show()
            Me.Close()
        Else
            MessageBox.Show("Candidato inválido! por favor selecione um dos candidatos válidos", "Urna Eletrônica", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If


    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox2.Image = My.Resources.perfil2
        Label8.Text = ""
        Label9.Text = ""
        Label11.Text = ""


        If Label2.Text = "" Then
            Label2.Text = "1"
        ElseIf Label3.Text <> "" Then
            Label2.Text = "1"
            Label3.Text = ""
        Else
            Label3.Text = "1"
        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PictureBox2.Image = My.Resources.perfil2
        Label8.Text = ""
        Label9.Text = ""
        Label11.Text = ""

        If Label2.Text = "" Then
            Label2.Text = "2"
        ElseIf Label3.Text <> "" Then
            Label2.Text = "2"
            Label3.Text = ""
        Else
            Label3.Text = "2"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PictureBox2.Image = My.Resources.perfil2
        Label8.Text = ""
        Label9.Text = ""
        Label11.Text = ""

        If Label2.Text = "" Then
            Label2.Text = "3"
        ElseIf Label3.Text <> "" Then
            Label2.Text = "3"
            Label3.Text = ""
        Else
            Label3.Text = "3"
        End If

        If Label2.Text = "1" And Label3.Text = "3" Then
            PictureBox2.Image = My.Resources.dilma
            PictureBox2.Visible = True
            Label8.Text = "PT"
            Label9.Text = "Dilma Rouseff"
            Label11.Text = "13"
        ElseIf Label2.Text = "4" And Label3.Text = "3" Then
            PictureBox2.Image = My.Resources.marina
            PictureBox2.Visible = True
            Label8.Text = " PV"
            Label9.Text = "Marina Silva"
            Label11.Text = "43"
        Else
            PictureBox2.Image = My.Resources.perfil2
        End If


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        PictureBox2.Image = My.Resources.perfil2
        Label8.Text = ""
        Label9.Text = ""
        Label11.Text = ""

        If Label2.Text = "" Then
            Label2.Text = "4"
        ElseIf Label3.Text <> "" Then
            Label2.Text = "4"
            Label3.Text = ""
        Else
            Label3.Text = "4"
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        PictureBox2.Image = My.Resources.perfil2
        Label8.Text = ""
        Label9.Text = ""
        Label11.Text = ""

        If Label2.Text = "" Then
            Label2.Text = "5"
        ElseIf Label3.Text <> "" Then
            Label2.Text = "5"
            Label3.Text = ""
        Else
            Label3.Text = "5"
        End If

        If Label2.Text = "4" And Label3.Text = "5" Then
            PictureBox2.Image = My.Resources.serra
            PictureBox2.Visible = True
            Label8.Text = "PSDB"
            Label9.Text = "José Serra"
            Label11.Text = "45"
        Else
            PictureBox2.Image = My.Resources.perfil2
        End If

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        PictureBox2.Image = My.Resources.perfil2
        Label8.Text = ""
        Label9.Text = ""
        Label11.Text = ""

        If Label2.Text = "" Then
            Label2.Text = "6"
        ElseIf Label3.Text <> "" Then
            Label2.Text = "6"
            Label3.Text = ""
        Else
            Label3.Text = "6"
        End If

        If Label2.Text = "1" And Label3.Text = "6" Then
            PictureBox2.Image = My.Resources.zemaria
            PictureBox2.Visible = True
            Label8.Text = "PSTU"
            Label9.Text = "Zé Maria"
            Label11.Text = "16"
        Else
            PictureBox2.Image = My.Resources.perfil2
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        PictureBox2.Image = My.Resources.perfil2
        Label8.Text = ""
        Label9.Text = ""
        Label11.Text = ""

        If Label2.Text = "" Then
            Label2.Text = "7"
        ElseIf Label3.Text <> "" Then
            Label2.Text = "7"
            Label3.Text = ""
        Else
            Label3.Text = "7"
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        PictureBox2.Image = My.Resources.perfil2
        Label8.Text = ""
        Label9.Text = ""
        Label11.Text = ""

        If Label2.Text = "" Then
            Label2.Text = "8"
        ElseIf Label3.Text <> "" Then
            Label2.Text = "8"
            Label3.Text = ""
        Else
            Label3.Text = "8"
        End If
        If Label2.Text = "2" And Label3.Text = "8" Then
            PictureBox2.Image = My.Resources.levy
            PictureBox2.Visible = True
            Label8.Text = "PRTB"
            Label9.Text = "Levy Fidelix"
            Label11.Text = "28"
        Else
            PictureBox2.Image = My.Resources.perfil2
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        PictureBox2.Image = My.Resources.perfil2
        Label8.Text = ""
        Label9.Text = ""
        Label11.Text = ""

        If Label2.Text = "" Then
            Label2.Text = "9"
        ElseIf Label3.Text <> "" Then
            Label2.Text = "9"
            Label3.Text = ""
        Else
            Label3.Text = "9"
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        PictureBox2.Image = My.Resources.perfil2
        Label8.Text = ""
        Label9.Text = ""
        Label11.Text = ""

        If Label2.Text = "" Then
            Label2.Text = "0"
        ElseIf Label3.Text <> "" Then
            Label2.Text = "0"
            Label3.Text = ""
        Else
            Label3.Text = "0"
        End If

        If Label2.Text = "0" And Label3.Text = "0" Then
            PictureBox2.Image = My.Resources.perfil2
            PictureBox2.Visible = True
            Label8.Text = "VOTO NULO"
            Label9.Text = "VOTO NULO"
            Label11.Text = "VOTO NULO"
        Else
            PictureBox2.Image = My.Resources.perfil2
        End If

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Label2.Text = ""
        Label3.Text = ""
        Label8.Text = ""
        Label9.Text = ""
        Label11.Text = ""

        PictureBox2.Image = My.Resources.perfil2
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click



    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click



    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave

    End Sub

    Private Sub Label3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Enter

    End Sub

    Private Sub Label3_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Validated

    End Sub

    Private Sub PictureBox2_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles PictureBox2.Validating

    End Sub

    Private Sub Label3_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Label3.Validating

    End Sub

    Private Sub Form1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MouseHover

    End Sub

    Private Sub GroupBox1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.MouseHover

    End Sub

    Private Sub GroupBox1_QueryContinueDrag(ByVal sender As System.Object, ByVal e As System.Windows.Forms.QueryContinueDragEventArgs) Handles GroupBox1.QueryContinueDrag

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        End
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Form3.Show()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        cont += 1
        nulos += 1
        Form2.Show()
        Me.Close()
    End Sub
End Class
