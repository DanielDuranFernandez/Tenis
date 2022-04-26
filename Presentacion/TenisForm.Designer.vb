<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TenisForm
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ButtonAnadirJugadora = New System.Windows.Forms.Button()
        Me.labelIdJugadora = New System.Windows.Forms.Label()
        Me.txtIdJugadora = New System.Windows.Forms.TextBox()
        Me.txtNombreJugadora = New System.Windows.Forms.TextBox()
        Me.labelNombreJugadora = New System.Windows.Forms.Label()
        Me.txtFechaJugadora = New System.Windows.Forms.TextBox()
        Me.labelFechaJugadora = New System.Windows.Forms.Label()
        Me.txtPaisJugadora = New System.Windows.Forms.TextBox()
        Me.labelPaisJugadora = New System.Windows.Forms.Label()
        Me.lstJugadoras = New System.Windows.Forms.ListBox()
        Me.ButtonConectar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonAnadirJugadora
        '
        Me.ButtonAnadirJugadora.Location = New System.Drawing.Point(193, 127)
        Me.ButtonAnadirJugadora.Name = "ButtonAnadirJugadora"
        Me.ButtonAnadirJugadora.Size = New System.Drawing.Size(102, 64)
        Me.ButtonAnadirJugadora.TabIndex = 0
        Me.ButtonAnadirJugadora.Text = "Añadir jugadora"
        Me.ButtonAnadirJugadora.UseVisualStyleBackColor = True
        '
        'labelIdJugadora
        '
        Me.labelIdJugadora.AutoSize = True
        Me.labelIdJugadora.Location = New System.Drawing.Point(48, 57)
        Me.labelIdJugadora.Name = "labelIdJugadora"
        Me.labelIdJugadora.Size = New System.Drawing.Size(80, 16)
        Me.labelIdJugadora.TabIndex = 1
        Me.labelIdJugadora.Text = "Id Jugadora"
        '
        'txtIdJugadora
        '
        Me.txtIdJugadora.Location = New System.Drawing.Point(51, 76)
        Me.txtIdJugadora.Name = "txtIdJugadora"
        Me.txtIdJugadora.Size = New System.Drawing.Size(100, 22)
        Me.txtIdJugadora.TabIndex = 2
        '
        'txtNombreJugadora
        '
        Me.txtNombreJugadora.Location = New System.Drawing.Point(51, 127)
        Me.txtNombreJugadora.Name = "txtNombreJugadora"
        Me.txtNombreJugadora.Size = New System.Drawing.Size(100, 22)
        Me.txtNombreJugadora.TabIndex = 4
        '
        'labelNombreJugadora
        '
        Me.labelNombreJugadora.AutoSize = True
        Me.labelNombreJugadora.Location = New System.Drawing.Point(48, 108)
        Me.labelNombreJugadora.Name = "labelNombreJugadora"
        Me.labelNombreJugadora.Size = New System.Drawing.Size(118, 16)
        Me.labelNombreJugadora.TabIndex = 3
        Me.labelNombreJugadora.Text = "Nombre Jugadora"
        '
        'txtFechaJugadora
        '
        Me.txtFechaJugadora.Location = New System.Drawing.Point(51, 184)
        Me.txtFechaJugadora.Name = "txtFechaJugadora"
        Me.txtFechaJugadora.Size = New System.Drawing.Size(100, 22)
        Me.txtFechaJugadora.TabIndex = 6
        '
        'labelFechaJugadora
        '
        Me.labelFechaJugadora.AutoSize = True
        Me.labelFechaJugadora.Location = New System.Drawing.Point(48, 165)
        Me.labelFechaJugadora.Name = "labelFechaJugadora"
        Me.labelFechaJugadora.Size = New System.Drawing.Size(107, 16)
        Me.labelFechaJugadora.TabIndex = 5
        Me.labelFechaJugadora.Text = "Fecha Jugadora"
        '
        'txtPaisJugadora
        '
        Me.txtPaisJugadora.Location = New System.Drawing.Point(51, 239)
        Me.txtPaisJugadora.Name = "txtPaisJugadora"
        Me.txtPaisJugadora.Size = New System.Drawing.Size(100, 22)
        Me.txtPaisJugadora.TabIndex = 8
        '
        'labelPaisJugadora
        '
        Me.labelPaisJugadora.AutoSize = True
        Me.labelPaisJugadora.Location = New System.Drawing.Point(48, 220)
        Me.labelPaisJugadora.Name = "labelPaisJugadora"
        Me.labelPaisJugadora.Size = New System.Drawing.Size(96, 16)
        Me.labelPaisJugadora.TabIndex = 7
        Me.labelPaisJugadora.Text = "País Jugadora"
        '
        'lstJugadoras
        '
        Me.lstJugadoras.FormattingEnabled = True
        Me.lstJugadoras.ItemHeight = 16
        Me.lstJugadoras.Location = New System.Drawing.Point(344, 108)
        Me.lstJugadoras.Name = "lstJugadoras"
        Me.lstJugadoras.Size = New System.Drawing.Size(159, 116)
        Me.lstJugadoras.TabIndex = 9
        '
        'ButtonConectar
        '
        Me.ButtonConectar.Location = New System.Drawing.Point(147, 330)
        Me.ButtonConectar.Name = "ButtonConectar"
        Me.ButtonConectar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonConectar.TabIndex = 10
        Me.ButtonConectar.Text = "Conectar"
        Me.ButtonConectar.UseVisualStyleBackColor = True
        '
        'TenisForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonConectar)
        Me.Controls.Add(Me.lstJugadoras)
        Me.Controls.Add(Me.txtPaisJugadora)
        Me.Controls.Add(Me.labelPaisJugadora)
        Me.Controls.Add(Me.txtFechaJugadora)
        Me.Controls.Add(Me.labelFechaJugadora)
        Me.Controls.Add(Me.txtNombreJugadora)
        Me.Controls.Add(Me.labelNombreJugadora)
        Me.Controls.Add(Me.txtIdJugadora)
        Me.Controls.Add(Me.labelIdJugadora)
        Me.Controls.Add(Me.ButtonAnadirJugadora)
        Me.Name = "TenisForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonAnadirJugadora As Button
    Friend WithEvents labelIdJugadora As Label
    Friend WithEvents txtIdJugadora As TextBox
    Friend WithEvents txtNombreJugadora As TextBox
    Friend WithEvents labelNombreJugadora As Label
    Friend WithEvents txtFechaJugadora As TextBox
    Friend WithEvents labelFechaJugadora As Label
    Friend WithEvents txtPaisJugadora As TextBox
    Friend WithEvents labelPaisJugadora As Label
    Friend WithEvents lstJugadoras As ListBox
    Friend WithEvents ButtonConectar As Button
End Class
