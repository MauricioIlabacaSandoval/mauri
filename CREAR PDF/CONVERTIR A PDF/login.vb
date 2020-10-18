Public Class login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        If TextBox1.Text <> "" And TextBox2.Text <> "" Then


            If TextBox1.Text = "profe" And TextBox2.Text = "1234" Then
                Form1.Show()
                Me.Visible = False
            Else
                MsgBox("Usuario y/o contraseña incorrecta")
            End If

        End If


    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

End Class
