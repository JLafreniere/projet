﻿
Public Class frmAjoutInventaire
    Dim bd As New GestionBD("Server=localhost;Database=bd_application;Uid=root;Pwd=;")

    'Francis Audet

    Private Sub frmAjoutInventaire_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Controls.Add(New Header(Me, False))
        'connection bd + charger ds
        bd.ConnectionString = "Server=localhost; DataBase=bd_application;UId=root;Pwd=; Convert Zero Datetime=true; Allow Zero DateTime=true;"
        bd.dsInventaire.Clear()
        bd.Requete("select * from inventaire", bd.dsInventaire, bd.daInventaire, "inventaire")

        'auto completion
        bd.dsProduits.Clear()
        bd.Requete("Select * from produits order by nom_produit", bd.dsProduits, bd.daProduits, "produits")
        cmbProduit.DataSource = bd.dsProduits.Tables(0)
        cmbProduit.ValueMember = bd.dsProduits.Tables(0).Columns(0).ToString
        cmbProduit.DisplayMember = bd.dsProduits.Tables(0).Columns(1).ToString

        cmbProduit.AutoCompleteMode = AutoCompleteMode.Append
        cmbProduit.DropDownStyle = ComboBoxStyle.DropDown
        cmbProduit.AutoCompleteSource = AutoCompleteSource.ListItems


        For i As Integer = 0 To bd.uniteMesure.length - 1
            cmbUnite.Items.Add(bd.uniteMesure(i))
        Next

        For i As Integer = 0 To bd.equivalence.length - 1
            cmbEquivalence.Items.Add(bd.equivalence(i))
        Next

        cmbUnite.Text = bd.uniteMesure(2).ToString
        cmbEquivalence.Text = bd.equivalence(2).ToString

        dtpPeremption.MinDate = Today
        lblEquivalence.Visible = False
        txtEquivalence.Visible = False
        cmbEquivalence.Visible = False
        couleurBouton("D", btnAjouter)

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


    Private Sub afficherform() Handles MyBase.Shown
        Dim r As Rectangle
        If Parent IsNot Nothing Then
            r = Parent.RectangleToScreen(Parent.ClientRectangle)
        Else
            r = Screen.FromPoint(Me.Location).WorkingArea
        End If

        Dim x = r.Left + (r.Width - Me.Width) \ 2 + 10
        Dim y = r.Top + (r.Height - Me.Height) \ 2
        Me.Location = New Point(x, y)
    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        'ajoute l'item en inventaire
        Dim dstemp As New DataSet
        bd.Requete("select * from produits where hidden = 0  and upper(nom_produit) = '" & Replace(cmbProduit.Text.ToUpper, "'", "''") & "'", dstemp, bd.daProduits, "produits")

        If dstemp.Tables(0).Rows.Count = 0 Then
            MsgBox("Nom de produit inexistant")
        Else

            Dim drnouvel As DataRow

        drnouvel = bd.dsInventaire.Tables(0).NewRow()

            drnouvel(1) = cmbProduit.SelectedValue
            drnouvel(2) = txtNom.Text
            drnouvel(3) = txtQuantite.Text


            drnouvel(4) = txtFormat.Text
            drnouvel(5) = txtDescription.Text

            If dtpPeremption.Visible = True Then
                drnouvel(6) = dtpPeremption.Value
            End If


            drnouvel(7) = dtpReception.Value

                If txtEquivalence.Text IsNot "" Then
                    drnouvel(8) = txtEquivalence.Text
                    drnouvel(9) = cmbEquivalence.Text
                End If


                drnouvel(10) = cmbUnite.Text
                drnouvel(11) = txtTotal.Text
                bd.dsInventaire.Tables(0).Rows.Add(drnouvel)

                bd.miseAjourBD(bd.dsInventaire, bd.daInventaire, "inventaire")

                effacerText()
                Me.Close()
                frmInventaire.plusDeFraicheurSubway6PouceA3et99()
                frmInventaire.Show()
            End If
    End Sub

    Sub effacerText()
        'vide le formulaire
        For Each element In Controls
            If TypeOf (element) IsNot Label And TypeOf (element) IsNot Button Then
                element.resetText
            End If
        Next
    End Sub

    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        'ferme le formulaire
        effacerText()
        Me.Close()
        frmInventaire.Show()
    End Sub

    Private Sub cmbFormat_KeyDown(sender As Object, e As Object) Handles cmbUnite.KeyDown, cmbUnite.KeyPress
        e.Handled = True
    End Sub



    Private Sub cmbFormat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUnite.SelectedIndexChanged
        'affiche ou pas l'équvalence
        If cmbUnite.Text = "Unité" Then
            lblEquivalence.Visible = True
            txtEquivalence.Visible = True
            cmbEquivalence.Visible = True


        Else
            lblEquivalence.Visible = False
            txtEquivalence.Visible = False
            cmbEquivalence.Visible = False
        End If

        lblTotal.Text = cmbUnite.Text
    End Sub




    Private Sub txtFormat_TextChanged(sender As Object, e As EventArgs) Handles txtFormat.TextChanged, txtQuantite.TextChanged, txtEquivalence.TextChanged
        'calcul total
        Try

            If txtQuantite.Text >= 1 And txtFormat.Text >= 1 Then
                txtTotal.Text = txtQuantite.Text * txtFormat.Text
            End If

        Catch exc As Exception : End Try
    End Sub

    Private Sub txtNom_TextChanged(sender As Object, e As EventArgs) Handles txtNom.TextChanged
        If txtNom.Text = "" Then
            couleurBouton("D", btnAjouter)
        Else
            couleurBouton("E", btnAjouter)
        End If
    End Sub

    Private Sub txtQuantite_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantite.KeyPress, txtFormat.KeyPress, txtEquivalence.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbProduit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProduit.SelectedIndexChanged
        Try
            Dim ds As New DataSet

            bd.Requete("select * from produits where id_produit = " & cmbProduit.SelectedValue, ds, bd.daProduits, "produits")

            If (ds.Tables(0).Rows(0).Item(7) = 0) Then
                dtpPeremption.Visible = False
                lblPeremption.Visible = False

            Else
                dtpPeremption.Visible = True
                lblPeremption.Visible = True
            End If
        Catch ex As Exception : End Try
    End Sub
End Class

