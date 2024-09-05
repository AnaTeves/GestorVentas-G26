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
        Ldni = New Label()
        Lmodificar = New Label()
        Lnya = New Label()
        Lapellido = New Label()
        Lnombre = New Label()
        TDNI = New TextBox()
        TApellido = New TextBox()
        TNombre = New TextBox()
        TGuardar = New Button()
        TEliminar = New Button()
        SuspendLayout()
        ' 
        ' Ldni
        ' 
        Ldni.AutoSize = True
        Ldni.Location = New Point(39, 105)
        Ldni.Name = "Ldni"
        Ldni.Size = New Size(43, 25)
        Ldni.TabIndex = 0
        Ldni.Text = "DNI"
        ' 
        ' Lmodificar
        ' 
        Lmodificar.AutoSize = True
        Lmodificar.ForeColor = Color.Red
        Lmodificar.Location = New Point(228, 43)
        Lmodificar.Name = "Lmodificar"
        Lmodificar.Size = New Size(87, 25)
        Lmodificar.TabIndex = 1
        Lmodificar.Text = "Modificar"
        ' 
        ' Lnya
        ' 
        Lnya.AutoSize = True
        Lnya.Location = New Point(39, 43)
        Lnya.Name = "Lnya"
        Lnya.Size = New Size(164, 25)
        Lnya.TabIndex = 2
        Lnya.Text = "Nombre y apellido:"
        ' 
        ' Lapellido
        ' 
        Lapellido.AutoSize = True
        Lapellido.Location = New Point(39, 203)
        Lapellido.Name = "Lapellido"
        Lapellido.Size = New Size(78, 25)
        Lapellido.TabIndex = 3
        Lapellido.Text = "Apellido"
        ' 
        ' Lnombre
        ' 
        Lnombre.AutoSize = True
        Lnombre.Location = New Point(39, 153)
        Lnombre.Name = "Lnombre"
        Lnombre.Size = New Size(78, 25)
        Lnombre.TabIndex = 4
        Lnombre.Text = "Nombre"
        ' 
        ' TDNI
        ' 
        TDNI.Location = New Point(101, 105)
        TDNI.Name = "TDNI"
        TDNI.Size = New Size(214, 31)
        TDNI.TabIndex = 5
        ' 
        ' TApellido
        ' 
        TApellido.Location = New Point(123, 200)
        TApellido.Name = "TApellido"
        TApellido.Size = New Size(214, 31)
        TApellido.TabIndex = 6
        ' 
        ' TNombre
        ' 
        TNombre.Location = New Point(132, 150)
        TNombre.Name = "TNombre"
        TNombre.Size = New Size(214, 31)
        TNombre.TabIndex = 7
        ' 
        ' TGuardar
        ' 
        TGuardar.Location = New Point(39, 278)
        TGuardar.Name = "TGuardar"
        TGuardar.Size = New Size(121, 32)
        TGuardar.TabIndex = 8
        TGuardar.Text = "Guardar"
        TGuardar.UseVisualStyleBackColor = True
        ' 
        ' TEliminar
        ' 
        TEliminar.Location = New Point(205, 278)
        TEliminar.Name = "TEliminar"
        TEliminar.Size = New Size(121, 32)
        TEliminar.TabIndex = 9
        TEliminar.Text = "Eliminar"
        TEliminar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TEliminar)
        Controls.Add(TGuardar)
        Controls.Add(TNombre)
        Controls.Add(TApellido)
        Controls.Add(TDNI)
        Controls.Add(Lnombre)
        Controls.Add(Lapellido)
        Controls.Add(Lnya)
        Controls.Add(Lmodificar)
        Controls.Add(Ldni)
        Name = "Form1"
        Text = "Pequeño formulario"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Ldni As Label
    Friend WithEvents Lmodificar As Label
    Friend WithEvents Lnya As Label
    Friend WithEvents Lapellido As Label
    Friend WithEvents Lnombre As Label
    Friend WithEvents TDNI As TextBox
    Friend WithEvents TApellido As TextBox
    Friend WithEvents TNombre As TextBox
    Friend WithEvents TGuardar As Button
    Friend WithEvents TEliminar As Button

End Class
