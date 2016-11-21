Public Class frmRetraitInventaire
    Dim bd As New GestionBD("Server=localhost;Database=bd_application;Uid=root;Pwd=;")
    Private Sub frmRetraitInventaire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True

        Controls.Add(New Header(Me, False))
        'connection bd + charger ds
        bd.ConnectionString = "Server=localhost; DataBase=bd_application;UId=root;Pwd=; Convert Zero Datetime=true; Allow Zero DateTime=true;"

        bd.Requete("select * from inventaire where id_inventaire = " & frmInventaire.no, bd.dsInventaire, bd.daInventaire, "inventaire")
        lblItem.Text = bd.dsInventaire.Tables(0).Rows(0).Item(2).ToString
        txtTotal.Text = bd.dsInventaire.Tables(0).Rows(0).Item(11).ToString
        lblUnite.Text = bd.dsInventaire.Tables(0).Rows(0).Item(10).ToString
        lblUniteTotal.Text = bd.dsInventaire.Tables(0).Rows(0).Item(10).ToString
        couleurBouton("D", btnRetirer)
    End Sub

    Sub couleurBouton(etat As String, b As Button)
        'Fonction permetant de changer la couleur d'un bouton selon l'etat
        If etat = "D" Then
            b.BackColor = (Color.LightGray)
            b.ForeColor = Color.White
            b.Enabled = False

        Else
            b.BackColor = Color.FromArgb(0, 176, 240)
            b.Enabled = True
        End If
    End Sub


    Private Sub btnRetirer_Click(sender As Object, e As EventArgs) Handles btnRetirer.Click
        bd.dsInventaire.Tables(0).Rows(0).Item(11) = txtTotal.Text

        If txtTotal.Text = 0 Then
            If MsgBox("Voulez-vous supprimer : " & lblItem.Text & " de l'inventaire ? (Quantité restante : 0)", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                bd.nonQuery("delete from inventaire where id_inventaire = " & frmInventaire.no)
            End If
        End If

        bd.miseAjourBD(bd.dsInventaire, bd.daInventaire, "inventaire")
        Me.Close()
        frmInventaire.plusDeFraicheurSubway6PouceA3et99()
    End Sub

    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        Me.Close()
    End Sub

    Private Sub txtQuantite_TextChanged(sender As Object, e As EventArgs) Handles txtQuantite.TextChanged
        Try
            txtTotal.Text = bd.dsInventaire.Tables(0).Rows(0).Item(11)
            If (bd.dsInventaire.Tables(0).Rows(0).Item(11) >= txtQuantite.Text) Then
                txtTotal.Text = (bd.dsInventaire.Tables(0).Rows(0).Item(11) - txtQuantite.Text)
                lblQuantite.Font = New Font(lblQuantite.Font, FontStyle.Regular)
                couleurBouton("E", btnRetirer)

            Else
                lblQuantite.Font = New Font(lblQuantite.Font, FontStyle.Bold)
                txtTotal.Text = bd.dsInventaire.Tables(0).Rows(0).Item(11)
                txtQuantite.Text = bd.dsInventaire.Tables(0).Rows(0).Item(11)
            End If
        Catch exc As Exception : End Try
    End Sub


    Private Sub txtQuantite_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantite.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) AndAlso Not e.KeyChar = "," Then
            e.Handled = True
        End If
    End Sub
End Class