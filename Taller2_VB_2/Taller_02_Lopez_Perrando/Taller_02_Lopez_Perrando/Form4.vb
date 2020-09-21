Public Class frm3
    Private Sub frm3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btnLim_Click(sender As Object, e As EventArgs) Handles btnLim.Click
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

    Private Sub optFondoVerde_CheckedChanged(sender As Object, e As EventArgs) Handles optFondoVerde.CheckedChanged
        txtTexto.BackColor = Color.DarkGreen
    End Sub

    Private Sub optFondoRojo_CheckedChanged(sender As Object, e As EventArgs) Handles optFondoRojo.CheckedChanged
        txtTexto.BackColor = Color.DarkRed
    End Sub

    Private Sub optFondoAzul_CheckedChanged(sender As Object, e As EventArgs) Handles optFondoAzul.CheckedChanged
        txtTexto.BackColor = Color.DarkBlue
    End Sub

    Private Sub optFuenteCyan_CheckedChanged(sender As Object, e As EventArgs) Handles optFuenteCyan.CheckedChanged
        txtTexto.ForeColor = Color.Cyan
    End Sub

    Private Sub optFuenteMagenta_CheckedChanged(sender As Object, e As EventArgs) Handles optFuenteMagenta.CheckedChanged
        txtTexto.ForeColor = Color.Magenta
    End Sub

    Private Sub optFuenteBlanco_CheckedChanged(sender As Object, e As EventArgs) Handles optFuenteBlanco.CheckedChanged
        txtTexto.ForeColor = Color.White
    End Sub

    Private Sub chkMayuscula_CheckedChanged(sender As Object, e As EventArgs) Handles chkMayuscula.CheckedChanged
        If chkMayuscula.Checked = True Then
            txtTexto.Text = UCase(txtTexto.Text)
        Else
            txtTexto.Text = LCase(txtTexto.Text)
        End If
    End Sub

    Private Sub chkNegrita_CheckedChanged(sender As Object, e As EventArgs) Handles chkNegrita.CheckedChanged
        If chkNegrita.Checked = True Then
            txtTexto.Font = New Font(txtTexto.Font, FontStyle.Bold)
        Else
            txtTexto.Font = New Font(txtTexto.Font, FontStyle.Regular)
        End If
    End Sub
End Class