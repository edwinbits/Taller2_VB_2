<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm1))
        Me.btnID = New System.Windows.Forms.Button()
        Me.btnTer = New System.Windows.Forms.Button()
        Me.btnSig = New System.Windows.Forms.Button()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.listNombres = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnID
        '
        Me.btnID.BackColor = System.Drawing.Color.GhostWhite
        Me.btnID.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnID.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnID.Font = New System.Drawing.Font("Tahoma", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnID.Location = New System.Drawing.Point(245, 241)
        Me.btnID.Margin = New System.Windows.Forms.Padding(2)
        Me.btnID.Name = "btnID"
        Me.btnID.Size = New System.Drawing.Size(116, 46)
        Me.btnID.TabIndex = 11
        Me.btnID.Text = "Ingresar Datos"
        Me.btnID.UseVisualStyleBackColor = False
        '
        'btnTer
        '
        Me.btnTer.BackColor = System.Drawing.Color.GhostWhite
        Me.btnTer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnTer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTer.Font = New System.Drawing.Font("Tahoma", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTer.Location = New System.Drawing.Point(468, 313)
        Me.btnTer.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTer.Name = "btnTer"
        Me.btnTer.Size = New System.Drawing.Size(82, 32)
        Me.btnTer.TabIndex = 12
        Me.btnTer.Text = "Terminar"
        Me.btnTer.UseVisualStyleBackColor = False
        '
        'btnSig
        '
        Me.btnSig.BackColor = System.Drawing.Color.GhostWhite
        Me.btnSig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSig.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSig.Font = New System.Drawing.Font("Tahoma", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSig.Location = New System.Drawing.Point(62, 313)
        Me.btnSig.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSig.Name = "btnSig"
        Me.btnSig.Size = New System.Drawing.Size(82, 32)
        Me.btnSig.TabIndex = 22
        Me.btnSig.Text = "Siguiente"
        Me.btnSig.UseVisualStyleBackColor = False
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(62, 92)
        Me.txtNombres.Multiline = True
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(127, 130)
        Me.txtNombres.TabIndex = 23
        '
        'listNombres
        '
        Me.listNombres.FormattingEnabled = True
        Me.listNombres.Location = New System.Drawing.Point(430, 110)
        Me.listNombres.Name = "listNombres"
        Me.listNombres.Size = New System.Drawing.Size(120, 95)
        Me.listNombres.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Nombres en Textbox"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(440, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Nombres en Listbox"
        '
        'frm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(588, 375)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.listNombres)
        Me.Controls.Add(Me.txtNombres)
        Me.Controls.Add(Me.btnSig)
        Me.Controls.Add(Me.btnTer)
        Me.Controls.Add(Me.btnID)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frm1"
        Me.Text = "Ejemplo Entrada y Salida de Datos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnID As Button
    Friend WithEvents btnTer As Button
    Friend WithEvents btnSig As Button
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents listNombres As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
