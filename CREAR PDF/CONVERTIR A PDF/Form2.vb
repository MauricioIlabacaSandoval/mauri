Public Class Form2
    Private Sub AbrirPdfToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirPdfToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        AxAcroPDF1.src = OpenFileDialog1.FileName
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub AxAcroPDF1_Enter(sender As Object, e As EventArgs) Handles AxAcroPDF1.Enter

    End Sub
End Class