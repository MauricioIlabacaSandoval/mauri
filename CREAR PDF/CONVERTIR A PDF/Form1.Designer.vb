<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonTEXTO = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonIMAGEN = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ButtonTODO = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonTEXTO
        '
        Me.ButtonTEXTO.BackColor = System.Drawing.Color.Gray
        Me.ButtonTEXTO.Location = New System.Drawing.Point(151, 314)
        Me.ButtonTEXTO.Name = "ButtonTEXTO"
        Me.ButtonTEXTO.Size = New System.Drawing.Size(140, 40)
        Me.ButtonTEXTO.TabIndex = 0
        Me.ButtonTEXTO.Text = "TEXTO A PDF"
        Me.ButtonTEXTO.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 39)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(400, 250)
        Me.TextBox1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Turquoise
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(465, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(400, 250)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'ButtonIMAGEN
        '
        Me.ButtonIMAGEN.BackColor = System.Drawing.Color.Gray
        Me.ButtonIMAGEN.Location = New System.Drawing.Point(591, 357)
        Me.ButtonIMAGEN.Name = "ButtonIMAGEN"
        Me.ButtonIMAGEN.Size = New System.Drawing.Size(140, 40)
        Me.ButtonIMAGEN.TabIndex = 3
        Me.ButtonIMAGEN.Text = "IMAGEN"
        Me.ButtonIMAGEN.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ButtonTODO
        '
        Me.ButtonTODO.BackColor = System.Drawing.Color.Gray
        Me.ButtonTODO.Location = New System.Drawing.Point(151, 412)
        Me.ButtonTODO.Name = "ButtonTODO"
        Me.ButtonTODO.Size = New System.Drawing.Size(140, 40)
        Me.ButtonTODO.TabIndex = 6
        Me.ButtonTODO.Text = "IMAGEN Y TEXTO"
        Me.ButtonTODO.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gray
        Me.Button2.Location = New System.Drawing.Point(591, 421)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 40)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Lector pdf"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(22, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Ingreso de texto a pdf."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(484, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(324, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Haz click en el cuadro para elejir una imagen "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(364, 314)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(492, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Haz click en el boton para solo un pdf con la imagen que selecionaste"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(351, 400)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(504, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Herramienta PDF acrobar permite leer rotar y muchas herramientas mas"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(877, 515)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ButtonTODO)
        Me.Controls.Add(Me.ButtonIMAGEN)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ButtonTEXTO)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Aquamarine
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Convertidor pdf"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonTEXTO As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonIMAGEN As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ButtonTODO As System.Windows.Forms.Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
