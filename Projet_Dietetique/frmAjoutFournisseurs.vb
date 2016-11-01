'Jonathan Villeneuve
Imports System.ComponentModel
Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class frmAjoutFournisseurs
    Dim bd As New GestionBD("Server=localhost;Database=bd_application;Uid=root;Pwd=;")
    Dim jours = {"Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche"}

    'Charge le dataset Fournisseurs
    Sub chargerDataset()
        bd.dsFournisseurs.Clear()
        bd.Requete("select * from fournisseurs order by nom_fournisseur", bd.dsFournisseurs, bd.daFournisseurs, "fournisseurs")

    End Sub
    Private Sub frmAjoutFournisseurs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bd.ConnectionString = "Server=localhost; DataBase=bd_application;UId=root;Pwd=; Convert Zero Datetime=true; Allow Zero DateTime=true;"
        chargerDataset()
        txtId.Visible = False
        btnEnregistrer.Enabled = False
        Dim ctl As Control
        For Each ctl In Me.Controls
            AddHandler ctl.KeyDown, AddressOf controleSuivant
        Next

    End Sub
    'Ajoute le fournisseur dans la bd
    Sub Ajouter()

        Dim email As New Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")

        Dim drNouvel As DataRow
        'Validation du courriel (le code postal et les numéros (téléphone cell et Télécopieur) sont des Masked TextBox)
        If email.IsMatch(txtCourriel.Text) Then
            drNouvel = bd.dsFournisseurs.Tables(0).NewRow
            drNouvel(1) = txtNom.Text
            drNouvel(2) = txtNotes.Text
            drNouvel(3) = txtAdresse.Text
            drNouvel(4) = txtVille.Text
            drNouvel(5) = txtProvince.Text
            drNouvel(6) = txtCodePostal.Text
            drNouvel(7) = txtTel.Text
            drNouvel(8) = txtPoste.Text
            drNouvel(9) = txtCell.Text
            drNouvel(10) = txtFax.Text
            drNouvel(11) = txtContact.Text
            drNouvel(12) = cbCommande.Text
            drNouvel(13) = cbLivraison.Text
            drNouvel(14) = nudCommande.Value
            drNouvel(15) = txtPrix.Text
            drNouvel(16) = txtFrais.Text
            drNouvel(17) = txtCourriel.Text



            bd.dsFournisseurs.Tables(0).Rows.Add(drNouvel)
            bd.miseAjourBD(bd.dsFournisseurs, bd.daFournisseurs, "fournisseurs")

            chargerDataset()
            viderChamp()




        ElseIf email.IsMatch(txtCourriel.Text) = False Then
            txtCourriel.ForeColor = Color.Red
            MsgBox("Le courriel doit être du format suivant: exemple123@monsite.com")










        End If






    End Sub

    Private Sub btnEnregistrer_Click(sender As Object, e As EventArgs) Handles btnEnregistrer.Click
        If btnEnregistrer.Text = "Enregistrer" Then
            Ajouter()

        Else
            If MsgBox("Voulez-vous enregistrer les modifications suivantes?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                modifier()


            End If


        End If




    End Sub
    'Vide les champs du formulaire 
    Sub viderChamp()
        txtNom.Text = ""
        txtNotes.Text = ""
        txtAdresse.Text = ""
        txtVille.Text = ""
        txtProvince.Text = ""
        txtCodePostal.Text = ""
        txtTel.Text = ""
        txtPoste.Text = ""
        txtCell.Text = ""
        txtFax.Text = ""
        txtContact.Text = ""
        cbCommande.Text = ""
        cbLivraison.Text = ""
        nudCommande.Value = 1
        txtPrix.Text = ""
        txtFrais.Text = ""
        txtCourriel.Text = ""

    End Sub
    'Bloque les lettres dans les champs qui recevront des chiffres
    Private Sub txtPrix_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrix.KeyPress, txtFrais.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub
    'Modifie le fournisseur
    Sub modifier()

        bd.nonQuery("UPDATE `fournisseurs` set `nom_fournisseur` = '" + txtNom.Text + "' , `note` = '" + txtNotes.Text + "', `adresse` = '" + txtAdresse.Text + "' , `ville` = '" + txtVille.Text + "' , 
`province` = '" + txtProvince.Text + "' , `code_postal` = '" + txtCodePostal.Text + "' , `telephone` = '" + txtTel.Text + "',`poste` = '" + txtPoste.Text + "' , `cell` = '" + txtCell.Text + "',
 `fax` = '" + txtFax.Text + "', `nom_contact` = '" + txtContact.Text + "', `jour_commande` = '" + cbCommande.Text + "' , `jour_livraison` = '" + cbLivraison.Text + "', `delai_commande` = '" + nudCommande.Value.ToString + "',
`cout_minimum` = '" + txtPrix.Text + "' , `frais_livraison` = '" + txtFrais.Text + "' , `courriel` = '" + txtCourriel.Text + "' where `id_fournisseur` = '" + txtId.Text + "'")

        bd.miseAjourBD(bd.dsFournisseurs, bd.daFournisseurs, "fournisseurs")
        viderChamp()

    End Sub

    'Met à jour  de facon dynamique le contenu de cbLivraison en fonction de l'élément sélectionné de cbCommande
    Private Sub cbCommande_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCommande.SelectedIndexChanged
        cbLivraison.Items.Clear()

        For i As Integer = cbCommande.SelectedIndex To cbCommande.Items.Count - 1
            cbLivraison.Items.Add(jours(i))
        Next


    End Sub


    Private Sub txtAdresse_TextChanged(sender As Object, e As EventArgs) Handles txtAdresse.TextChanged, txtContact.TextChanged _
        , txtCourriel.TextChanged, txtFrais.TextChanged, txtId.TextChanged, txtNom.TextChanged, txtNotes.TextChanged, txtPoste.TextChanged, txtPrix.TextChanged, txtProvince.TextChanged _
        , txtVille.TextChanged

        If sender.text <> "" Then
            btnEnregistrer.Enabled = True


        End If

    End Sub

    Private Sub txtCell_GotFocus(sender As Object, e As EventArgs) Handles txtCourriel.GotFocus
        sender.ForeColor = SystemColors.WindowText
    End Sub

    'Quand l'utilisateur pèse sur enter, le focus est mis sur le contrôle suivant
    Sub controleSuivant(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then

            e.SuppressKeyPress = True
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If


    End Sub

    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        Close()
        frmFournisseurs.Show()

    End Sub
End Class