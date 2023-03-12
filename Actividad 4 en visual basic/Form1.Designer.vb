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
        Me.btnPerro = New System.Windows.Forms.Button()
        Me.BtnGato = New System.Windows.Forms.Button()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPerro
        '
        Me.btnPerro.Location = New System.Drawing.Point(201, 40)
        Me.btnPerro.Name = "btnPerro"
        Me.btnPerro.Size = New System.Drawing.Size(75, 29)
        Me.btnPerro.TabIndex = 0
        Me.btnPerro.Text = "Perro"
        Me.btnPerro.UseVisualStyleBackColor = True
        '
        'BtnGato
        '
        Me.BtnGato.Location = New System.Drawing.Point(199, 84)
        Me.BtnGato.Name = "BtnGato"
        Me.BtnGato.Size = New System.Drawing.Size(77, 43)
        Me.BtnGato.TabIndex = 1
        Me.BtnGato.Text = "Gato"
        Me.BtnGato.UseVisualStyleBackColor = True
        '
        'lblResultado
        '
        Me.lblResultado.Location = New System.Drawing.Point(494, 99)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(234, 169)
        Me.lblResultado.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.BtnGato)
        Me.Controls.Add(Me.btnPerro)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPerro As Button
    Friend WithEvents BtnGato As Button
    Friend WithEvents lblResultado As Label
End Class
