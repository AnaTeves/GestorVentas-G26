<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Beliminar = New Button()
        Bguardar = New Button()
        LAapellido = New Label()
        LAnombre = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        btnSalir = New Button()
        SuspendLayout()
        ' 
        ' Beliminar
        ' 
        Beliminar.Location = New Point(161, 169)
        Beliminar.Name = "Beliminar"
        Beliminar.Size = New Size(112, 34)
        Beliminar.TabIndex = 0
        Beliminar.Text = "Eliminar"
        Beliminar.UseVisualStyleBackColor = True
        ' 
        ' Bguardar
        ' 
        Bguardar.Location = New Point(28, 169)
        Bguardar.Name = "Bguardar"
        Bguardar.Size = New Size(102, 34)
        Bguardar.TabIndex = 1
        Bguardar.Text = "Guardar"
        Bguardar.UseVisualStyleBackColor = True
        ' 
        ' LAapellido
        ' 
        LAapellido.AutoSize = True
        LAapellido.Location = New Point(12, 54)
        LAapellido.Name = "LAapellido"
        LAapellido.Size = New Size(78, 25)
        LAapellido.TabIndex = 2
        LAapellido.Text = "Apellido"
        ' 
        ' LAnombre
        ' 
        LAnombre.AutoSize = True
        LAnombre.Location = New Point(12, 103)
        LAnombre.Name = "LAnombre"
        LAnombre.Size = New Size(78, 25)
        LAnombre.TabIndex = 3
        LAnombre.Text = "Nombre"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(92, 54)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(197, 31)
        TextBox1.TabIndex = 4
        TextBox1.Text = "Teves"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(92, 103)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(197, 31)
        TextBox2.TabIndex = 5
        TextBox2.Text = "Ana Luz"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(307, 12)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(148, 174)
        TextBox3.TabIndex = 6
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(354, 200)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(101, 32)
        btnSalir.TabIndex = 7
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        btnSalir.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        ClientSize = New Size(478, 244)
        Controls.Add(btnSalir)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(LAnombre)
        Controls.Add(LAapellido)
        Controls.Add(Bguardar)
        Controls.Add(Beliminar)
        KeyPreview = True
        Name = "Form1"
        Text = "Mi Primer Forms"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Beliminar As Button
    Friend WithEvents Bguardar As Button
    Friend WithEvents LAapellido As Label
    Friend WithEvents LAnombre As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents btnSalir As Button

End Class
