Public Class frm1

    Private Sub btnID_Click(sender As Object, e As EventArgs) Handles btnID.Click
        'Recibira el nombre desde un InputBox y mostrara lo ingresado'
        Dim nombre As String
        Dim nombres2(10) As String
        Dim i As Integer

        nombre = InputBox("Ingrese Nombre", "Registro de Datos Personales", "", 100, 50)
        If nombre IsNot "" Then
            MsgBox("Bienvenido Usuario: " + nombre, MsgBoxStyle.OkOnly, "Registro de Datos")
            'Registrara los nombres en listas y arreglos'
            listNombres.Items.Add(nombre)
            While i < listNombres.Items.Count.ToString()
                nombres2(i) = listNombres.Items(i)
                i = i + 1
            End While

            txtNombres.Text = nombres2(0) + vbCrLf + nombres2(1) + vbCrLf + nombres2(2) + vbCrLf + nombres2(3) + vbCrLf + nombres2(4) + vbCrLf + nombres2(5) + vbCrLf + nombres2(6) + vbCrLf + nombres2(7) + vbCrLf + nombres2(8) + vbCrLf + nombres2(9)

        End If


    End Sub

    Private Sub btnTer_Click(sender As Object, e As EventArgs) Handles btnTer.Click
        'Mostrara un msgbox que preguntara si desea salir'
        Dim opcion As DialogResult
        opcion = MsgBox("¿Realmente desea salir?", vbYesNo + vbQuestion, "Salir del programa")
        If opcion = DialogResult.Yes Then
            Close()
            Application.Exit()
            End
        End If
    End Sub

    Private Sub btnSig_Click(sender As Object, e As EventArgs) Handles btnSig.Click
        'Este boton pasara a la siguiente pantalla'
        Me.Hide()
        frm2.Show()
    End Sub

End Class