<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm2
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
        Me.txtTexto = New System.Windows.Forms.TextBox()
        Me.btnLim = New System.Windows.Forms.Button()
        Me.btnTer = New System.Windows.Forms.Button()
        Me.grpOpFuente = New System.Windows.Forms.GroupBox()
        Me.chkNegrita = New System.Windows.Forms.CheckBox()
        Me.chkMayuscula = New System.Windows.Forms.CheckBox()
        Me.grpFuente = New System.Windows.Forms.GroupBox()
        Me.optFuenteBlanco = New System.Windows.Forms.RadioButton()
        Me.optFuenteMagenta = New System.Windows.Forms.RadioButton()
        Me.optFuenteCyan = New System.Windows.Forms.RadioButton()
        Me.grpFondo = New System.Windows.Forms.GroupBox()
        Me.optFondoAzul = New System.Windows.Forms.RadioButton()
        Me.optFondoRojo = New System.Windows.Forms.RadioButton()
        Me.optFondoVerde = New System.Windows.Forms.RadioButton()
        Me.btnRCambios = New System.Windows.Forms.Button()
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.btnSig = New System.Windows.Forms.Button()
        Me.grpOpFuente.SuspendLayout()
        Me.grpFuente.SuspendLayout()
        Me.grpFondo.SuspendLayout()
        Me.pnl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTexto
        '
        Me.txtTexto.BackColor = System.Drawing.Color.White
        Me.txtTexto.Font = New System.Drawing.Font("Tahoma", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTexto.Location = New System.Drawing.Point(43, 46)
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(536, 40)
        Me.txtTexto.TabIndex = 0
        Me.txtTexto.Text = "TEXTO A CAMBIAR"
        '
        'btnLim
        '
        Me.btnLim.BackColor = System.Drawing.Color.GhostWhite
        Me.btnLim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLim.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLim.Font = New System.Drawing.Font("Tahoma", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLim.Location = New System.Drawing.Point(81, 652)
        Me.btnLim.Name = "btnLim"
        Me.btnLim.Size = New System.Drawing.Size(163, 61)
        Me.btnLim.TabIndex = 22
        Me.btnLim.Text = "Limpiar"
        Me.btnLim.UseVisualStyleBackColor = False
        '
        'btnTer
        '
        Me.btnTer.BackColor = System.Drawing.Color.GhostWhite
        Me.btnTer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTer.Font = New System.Drawing.Font("Tahoma", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTer.Location = New System.Drawing.Point(1126, 652)
        Me.btnTer.Name = "btnTer"
        Me.btnTer.Size = New System.Drawing.Size(163, 61)
        Me.btnTer.TabIndex = 23
        Me.btnTer.Text = "Terminar"
        Me.btnTer.UseVisualStyleBackColor = False
        '
        'grpOpFuente
        '
        Me.grpOpFuente.BackColor = System.Drawing.Color.SeaShell
        Me.grpOpFuente.Controls.Add(Me.chkNegrita)
        Me.grpOpFuente.Controls.Add(Me.chkMayuscula)
        Me.grpOpFuente.Font = New System.Drawing.Font("Tahoma", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOpFuente.Location = New System.Drawing.Point(824, 39)
        Me.grpOpFuente.Name = "grpOpFuente"
        Me.grpOpFuente.Size = New System.Drawing.Size(376, 315)
        Me.grpOpFuente.TabIndex = 2
        Me.grpOpFuente.TabStop = False
        Me.grpOpFuente.Text = "Opciones de fuente"
        '
        'chkNegrita
        '
        Me.chkNegrita.AutoSize = True
        Me.chkNegrita.Font = New System.Drawing.Font("Tahoma", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNegrita.Location = New System.Drawing.Point(202, 231)
        Me.chkNegrita.Name = "chkNegrita"
        Me.chkNegrita.Size = New System.Drawing.Size(122, 29)
        Me.chkNegrita.TabIndex = 1
        Me.chkNegrita.Text = "Negrita"
        Me.chkNegrita.UseVisualStyleBackColor = True
        '
        'chkMayuscula
        '
        Me.chkMayuscula.AutoSize = True
        Me.chkMayuscula.Font = New System.Drawing.Font("Tahoma", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMayuscula.ForeColor = System.Drawing.Color.Black
        Me.chkMayuscula.Location = New System.Drawing.Point(84, 81)
        Me.chkMayuscula.Name = "chkMayuscula"
        Me.chkMayuscula.Size = New System.Drawing.Size(161, 29)
        Me.chkMayuscula.TabIndex = 0
        Me.chkMayuscula.Text = "MAYUSCULA"
        Me.chkMayuscula.UseVisualStyleBackColor = True
        '
        'grpFuente
        '
        Me.grpFuente.BackColor = System.Drawing.Color.Snow
        Me.grpFuente.Controls.Add(Me.optFuenteBlanco)
        Me.grpFuente.Controls.Add(Me.optFuenteMagenta)
        Me.grpFuente.Controls.Add(Me.optFuenteCyan)
        Me.grpFuente.Font = New System.Drawing.Font("Tahoma", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFuente.Location = New System.Drawing.Point(404, 39)
        Me.grpFuente.Name = "grpFuente"
        Me.grpFuente.Size = New System.Drawing.Size(376, 316)
        Me.grpFuente.TabIndex = 25
        Me.grpFuente.TabStop = False
        Me.grpFuente.Text = "Color de fuente"
        '
        'optFuenteBlanco
        '
        Me.optFuenteBlanco.AutoSize = True
        Me.optFuenteBlanco.Font = New System.Drawing.Font("Tahoma", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optFuenteBlanco.ForeColor = System.Drawing.Color.Black
        Me.optFuenteBlanco.Location = New System.Drawing.Point(194, 232)
        Me.optFuenteBlanco.Name = "optFuenteBlanco"
        Me.optFuenteBlanco.Size = New System.Drawing.Size(113, 29)
        Me.optFuenteBlanco.TabIndex = 31
        Me.optFuenteBlanco.TabStop = True
        Me.optFuenteBlanco.Text = "Blanco"
        Me.optFuenteBlanco.UseVisualStyleBackColor = True
        '
        'optFuenteMagenta
        '
        Me.optFuenteMagenta.AutoSize = True
        Me.optFuenteMagenta.Font = New System.Drawing.Font("Tahoma", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optFuenteMagenta.ForeColor = System.Drawing.Color.DarkMagenta
        Me.optFuenteMagenta.Location = New System.Drawing.Point(129, 154)
        Me.optFuenteMagenta.Name = "optFuenteMagenta"
        Me.optFuenteMagenta.Size = New System.Drawing.Size(135, 29)
        Me.optFuenteMagenta.TabIndex = 30
        Me.optFuenteMagenta.TabStop = True
        Me.optFuenteMagenta.Text = "Magenta"
        Me.optFuenteMagenta.UseVisualStyleBackColor = True
        '
        'optFuenteCyan
        '
        Me.optFuenteCyan.AutoSize = True
        Me.optFuenteCyan.Font = New System.Drawing.Font("Tahoma", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optFuenteCyan.ForeColor = System.Drawing.Color.DarkCyan
        Me.optFuenteCyan.Location = New System.Drawing.Point(69, 80)
        Me.optFuenteCyan.Name = "optFuenteCyan"
        Me.optFuenteCyan.Size = New System.Drawing.Size(95, 29)
        Me.optFuenteCyan.TabIndex = 29
        Me.optFuenteCyan.TabStop = True
        Me.optFuenteCyan.Text = "Cyan"
        Me.optFuenteCyan.UseVisualStyleBackColor = True
        '
        'grpFondo
        '
        Me.grpFondo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grpFondo.Controls.Add(Me.optFondoAzul)
        Me.grpFondo.Controls.Add(Me.optFondoRojo)
        Me.grpFondo.Controls.Add(Me.optFondoVerde)
        Me.grpFondo.Font = New System.Drawing.Font("Tahoma", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFondo.Location = New System.Drawing.Point(24, 40)
        Me.grpFondo.Name = "grpFondo"
        Me.grpFondo.Size = New System.Drawing.Size(324, 315)
        Me.grpFondo.TabIndex = 29
        Me.grpFondo.TabStop = False
        Me.grpFondo.Text = "Color de fondo"
        '
        'optFondoAzul
        '
        Me.optFondoAzul.AutoSize = True
        Me.optFondoAzul.Font = New System.Drawing.Font("Tahoma", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optFondoAzul.ForeColor = System.Drawing.Color.DarkBlue
        Me.optFondoAzul.Location = New System.Drawing.Point(158, 231)
        Me.optFondoAzul.Name = "optFondoAzul"
        Me.optFondoAzul.Size = New System.Drawing.Size(87, 29)
        Me.optFondoAzul.TabIndex = 28
        Me.optFondoAzul.TabStop = True
        Me.optFondoAzul.Text = "Azul"
        Me.optFondoAzul.UseVisualStyleBackColor = True
        '
        'optFondoRojo
        '
        Me.optFondoRojo.AutoSize = True
        Me.optFondoRojo.Font = New System.Drawing.Font("Tahoma", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optFondoRojo.ForeColor = System.Drawing.Color.DarkRed
        Me.optFondoRojo.Location = New System.Drawing.Point(104, 153)
        Me.optFondoRojo.Name = "optFondoRojo"
        Me.optFondoRojo.Size = New System.Drawing.Size(92, 29)
        Me.optFondoRojo.TabIndex = 27
        Me.optFondoRojo.TabStop = True
        Me.optFondoRojo.Text = "Rojo"
        Me.optFondoRojo.UseVisualStyleBackColor = True
        '
        'optFondoVerde
        '
        Me.optFondoVerde.AutoSize = True
        Me.optFondoVerde.Font = New System.Drawing.Font("Tahoma", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optFondoVerde.ForeColor = System.Drawing.Color.DarkGreen
        Me.optFondoVerde.Location = New System.Drawing.Point(36, 81)
        Me.optFondoVerde.Name = "optFondoVerde"
        Me.optFondoVerde.Size = New System.Drawing.Size(103, 29)
        Me.optFondoVerde.TabIndex = 26
        Me.optFondoVerde.TabStop = True
        Me.optFondoVerde.Text = "Verde"
        Me.optFondoVerde.UseVisualStyleBackColor = True
        '
        'btnRCambios
        '
        Me.btnRCambios.BackColor = System.Drawing.Color.GhostWhite
        Me.btnRCambios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRCambios.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRCambios.Font = New System.Drawing.Font("Tahoma", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRCambios.Location = New System.Drawing.Point(512, 385)
        Me.btnRCambios.Name = "btnRCambios"
        Me.btnRCambios.Size = New System.Drawing.Size(189, 81)
        Me.btnRCambios.TabIndex = 24
        Me.btnRCambios.Text = "Realizar Cambios"
        Me.btnRCambios.UseVisualStyleBackColor = False
        '
        'pnl1
        '
        Me.pnl1.BackColor = System.Drawing.Color.DarkGray
        Me.pnl1.Controls.Add(Me.btnRCambios)
        Me.pnl1.Controls.Add(Me.grpFondo)
        Me.pnl1.Controls.Add(Me.grpFuente)
        Me.pnl1.Controls.Add(Me.grpOpFuente)
        Me.pnl1.Location = New System.Drawing.Point(67, 122)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(1222, 488)
        Me.pnl1.TabIndex = 24
        '
        'btnSig
        '
        Me.btnSig.BackColor = System.Drawing.Color.GhostWhite
        Me.btnSig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSig.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSig.Font = New System.Drawing.Font("Tahoma", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSig.Location = New System.Drawing.Point(600, 652)
        Me.btnSig.Name = "btnSig"
        Me.btnSig.Size = New System.Drawing.Size(163, 61)
        Me.btnSig.TabIndex = 25
        Me.btnSig.Text = "Siguiente"
        Me.btnSig.UseVisualStyleBackColor = False
        '
        'frm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1358, 748)
        Me.Controls.Add(Me.btnSig)
        Me.Controls.Add(Me.pnl1)
        Me.Controls.Add(Me.btnTer)
        Me.Controls.Add(Me.btnLim)
        Me.Controls.Add(Me.txtTexto)
        Me.Name = "frm2"
        Me.Text = "Ejemplo RadioButton y Checkbox"
        Me.grpOpFuente.ResumeLayout(False)
        Me.grpOpFuente.PerformLayout()
        Me.grpFuente.ResumeLayout(False)
        Me.grpFuente.PerformLayout()
        Me.grpFondo.ResumeLayout(False)
        Me.grpFondo.PerformLayout()
        Me.pnl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTexto As TextBox
    Friend WithEvents btnLim As Button
    Friend WithEvents btnTer As Button
    Friend WithEvents grpOpFuente As GroupBox
    Friend WithEvents chkNegrita As CheckBox
    Friend WithEvents chkMayuscula As CheckBox
    Friend WithEvents grpFuente As GroupBox
    Friend WithEvents optFuenteBlanco As RadioButton
    Friend WithEvents optFuenteMagenta As RadioButton
    Friend WithEvents optFuenteCyan As RadioButton
    Friend WithEvents grpFondo As GroupBox
    Friend WithEvents optFondoAzul As RadioButton
    Friend WithEvents optFondoRojo As RadioButton
    Friend WithEvents optFondoVerde As RadioButton
    Friend WithEvents btnRCambios As Button
    Friend WithEvents pnl1 As Panel
    Friend WithEvents btnSig As Button
End Class
