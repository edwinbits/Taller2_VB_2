Public Class frmPP
    'Version de visual studio 6.0'
    Private Sub btnIns_Click(sender As Object, e As EventArgs) Handles btnIns.Click
        'Este boton colocara visible la instruccion y el titulo y ocultara la informacion que no se desea mostrar'
        txtIns.Visible = True
        lblIns.Visible = True
        lblUTP.Visible = False
        lblFISC.Visible = False
        btnRegPP.Visible = True
        btnIns.Visible = False
    End Sub

    Private Sub btnRegPP_Click(sender As Object, e As EventArgs) Handles btnRegPP.Click
        'Este boton colocara ocultara la instruccion y el titulo y mostrara la informacion que se desea'
        txtIns.Visible = False
        lblIns.Visible = False
        lblUTP.Visible = True
        lblFISC.Visible = True
        btnRegPP.Visible = False
        btnIns.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSig.Click
        'Este boton pasara a la siguiente pantalla'
        frm1.Show()
        Me.Hide()
    End Sub
End Class
