Public Class frm2
    Private Sub btnTer_Click(sender As Object, e As EventArgs) Handles btnTer.Click
        'Este boton nos permitira salir del programa'
        Dim opcion As DialogResult
        opcion = MsgBox("¿Realmente desea salir?", vbYesNo + vbQuestion, "Salir del programa")
        If opcion = DialogResult.Yes Then
            Close()
            Application.Exit()
            End
        End If
    End Sub

    Private Sub frm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargaremos el frame desde 0'
        txtTexto.Text = " "
        txtTexto.BackColor = Color.White
        txtTexto.ForeColor = Color.Black

        If chkMayuscula.CheckState = CheckState.Checked Then
            chkMayuscula.CheckState = CheckState.Unchecked
        End If

        If chkNegrita.CheckState = CheckState.Checked Then
            chkNegrita.CheckState = CheckState.Unchecked
        End If

        txtTexto.Focus()
    End Sub

    Private Sub btnSig_Click(sender As Object, e As EventArgs) Handles btnLim.Click
        'Este boton limpiara la pantalla para que todo quede reseteado'
        txtTexto.Text = " "
        txtTexto.BackColor = Color.White
        txtTexto.ForeColor = Color.Black

        If chkMayuscula.CheckState = CheckState.Checked Then
            chkMayuscula.CheckState = CheckState.Unchecked
        End If

        If chkNegrita.CheckState = CheckState.Checked Then
            chkNegrita.CheckState = CheckState.Unchecked
        End If

        txtTexto.Focus()
    End Sub

    Private Sub btnRCambios_Click(sender As Object, e As EventArgs) Handles btnRCambios.Click
        'Este boton realizara los cambios que haya seleccionado el usuario'
        If optFondoVerde.Checked = True Then
            txtTexto.BackColor = Color.DarkGreen
        ElseIf optFondoRojo.Checked = True Then
            txtTexto.BackColor = Color.DarkRed
        ElseIf optFondoAzul.Checked = True Then
            txtTexto.BackColor = Color.DarkBlue
        End If

        If optFuenteCyan.Checked = True Then
            txtTexto.ForeColor = Color.DarkCyan
        ElseIf optFuenteMagenta.Checked = True Then
            txtTexto.ForeColor = Color.DarkMagenta
        ElseIf optFuenteBlanco.Checked = True Then
            txtTexto.ForeColor = Color.White
        End If

        If chkMayuscula.Checked = True Then
            txtTexto.Text = UCase(txtTexto.Text)
        Else
            txtTexto.Text = LCase(txtTexto.Text)
        End If

        If chkNegrita.Checked = True Then
            txtTexto.Font = New Font(txtTexto.Font, FontStyle.Bold)
        Else
            txtTexto.Font = New Font(txtTexto.Font, FontStyle.Regular)
        End If
    End Sub

    Private Sub btnSig_Click_1(sender As Object, e As EventArgs) Handles btnSig.Click
        'Este boton pasara a la siguiente pantalla'
        Me.Hide()
        frm3.Show()
    End Sub
End Class