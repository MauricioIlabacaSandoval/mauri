Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonTEXTO.Click
        SaveFileDialog1.DefaultExt = "pdf"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Dim DOCUMENTO As New Document
                Dim ESCRITOR As PdfWriter = PdfWriter.GetInstance(DOCUMENTO, New FileStream(SaveFileDialog1.FileName, FileMode.Create))
                DOCUMENTO.Open()
                DOCUMENTO.Add(New Paragraph(TextBox1.Text))
                DOCUMENTO.Close()
                MsgBox("CREADO ARCHIVO PDF")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonIMAGEN.Click
        SaveFileDialog1.DefaultExt = "pdf"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Dim DOCUMENTO As New Document
                Dim ESCRITOR As PdfWriter = PdfWriter.GetInstance(DOCUMENTO, New FileStream(SaveFileDialog1.FileName, FileMode.Create))
                DOCUMENTO.Open()
                Dim IMAGEN As Image = Image.GetInstance(OpenFileDialog1.FileName)

                DOCUMENTO.Add(IMAGEN)
                DOCUMENTO.Close()
                MsgBox("CREADO ARCHIVO PDF")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles ButtonTODO.Click
        SaveFileDialog1.DefaultExt = "pdf"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                Dim DOCUMENTO As New Document
                Dim ESCRITOR As PdfWriter = PdfWriter.GetInstance(DOCUMENTO, New FileStream(SaveFileDialog1.FileName, FileMode.Create))
                DOCUMENTO.Open()
                DOCUMENTO.Add(New Paragraph(TextBox1.Text))
                Dim IMAGEN As Image = Image.GetInstance(OpenFileDialog1.FileName)

                DOCUMENTO.Add(IMAGEN)
                DOCUMENTO.Close()
                MsgBox("CREADO ARCHIVO PDF")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Bitmap.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Visible = False



    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub
End Class
