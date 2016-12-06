'Jonathan Villeneuve
Imports System.Data
Imports MySql.Data.MySqlClient
Public Class frmFournisseurs
    Dim bd As New GestionBD("Server=localhost;Database=bd_application;Uid=root;Pwd=;")
    Dim coll(3) As String
    Public position As Integer
    Dim ds As New DataSet


    Private Sub frmFournisseurs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtRecherche.Enabled = False
        rdbDefaut.Enabled = False


        Controls.Add(New Header(Me, True))
        'Connexion à la bd et Chargement des Dataset
        bd.ConnectionString = "Server=localhost; DataBase=bd_application;UId=root;Pwd=; Convert Zero Datetime=true; Allow Zero DateTime=true;"
        chargerDataset()
        remplirListview()

        couleurBouton("D", btnSupprimer)
        couleurBouton("D", btnModifier)
        couleurBouton("D", BtnRechercher)

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



    Sub chargerDataset()
        bd.dsFournisseurs.Clear()
        bd.Requete("select * from fournisseurs  order by nom_fournisseur", bd.dsFournisseurs, bd.daFournisseurs, "fournisseurs")
        bd.Requete("Select distinct ville from fournisseurs", ds, bd.daFournisseurs, "fournisseurs")

    End Sub


    'Remplit le listView des Fournisseurs
    Sub remplirListview()
        lsvFournisseurs.Items.Clear()

        For i = 0 To bd.dsFournisseurs.Tables(0).Rows.Count - 1
            coll(0) = bd.dsFournisseurs.Tables(0).Rows(i)(1).ToString
            coll(1) = bd.dsFournisseurs.Tables(0).Rows(i)(3).ToString
            coll(2) = bd.dsFournisseurs.Tables(0).Rows(i)(4).ToString
            coll(3) = bd.dsFournisseurs.Tables(0).Rows(i)(11).ToString

            Dim lvi As New ListViewItem(coll)

            lsvFournisseurs.Items.Add(lvi)

        Next
    End Sub

    'Remplis le formulaire de frmAjoutFournisseurs selon les données du Fournisseur sélectionné
    Sub remplirFormulaire()
        frmAjoutFournisseurs.Show()
        frmAjoutFournisseurs.txtId.Text = bd.dsFournisseurs.Tables(0).Rows(position).Item(0).ToString
        frmAjoutFournisseurs.txtNom.Text = bd.dsFournisseurs.Tables(0).Rows(position).Item(1).ToString
        frmAjoutFournisseurs.txtNotes.Text = bd.dsFournisseurs.Tables(0).Rows(position).Item(2).ToString
        frmAjoutFournisseurs.txtAdresse.Text = bd.dsFournisseurs.Tables(0).Rows(position).Item(3).ToString
        frmAjoutFournisseurs.txtVille.Text = bd.dsFournisseurs.Tables(0).Rows(position).Item(4).ToString
        frmAjoutFournisseurs.txtProvince.Text = bd.dsFournisseurs.Tables(0).Rows(position).Item(5).ToString
        frmAjoutFournisseurs.txtCodePostal.Text = bd.dsFournisseurs.Tables(0).Rows(position).Item(6).ToString
        frmAjoutFournisseurs.txtTel.Text = bd.dsFournisseurs.Tables(0).Rows(position).Item(7).ToString
        frmAjoutFournisseurs.txtPoste.Text = bd.dsFournisseurs.Tables(0).Rows(position).Item(8).ToString
        frmAjoutFournisseurs.txtCell.Text = bd.dsFournisseurs.Tables(0).Rows(position).Item(9).ToString
        frmAjoutFournisseurs.txtFax.Text = bd.dsFournisseurs.Tables(0).Rows(position).Item(10).ToString
        frmAjoutFournisseurs.txtContact.Text = bd.dsFournisseurs.Tables(0).Rows(position).Item(11).ToString
        frmAjoutFournisseurs.cbCommande.Text = bd.dsFournisseurs.Tables(0).Rows(position).Item(12).ToString
        frmAjoutFournisseurs.cbLivraison.Text = bd.dsFournisseurs.Tables(0).Rows(position).Item(13).ToString
        frmAjoutFournisseurs.nudCommande.Text = bd.dsFournisseurs.Tables(0).Rows(position).Item(14).ToString
        frmAjoutFournisseurs.txtPrix.Text = bd.dsFournisseurs.Tables(0).Rows(position).Item(15).ToString
        frmAjoutFournisseurs.txtFrais.Text = bd.dsFournisseurs.Tables(0).Rows(position).Item(16).ToString
        frmAjoutFournisseurs.txtCourriel.Text = bd.dsFournisseurs.Tables(0).Rows(position).Item(17).ToString
        frmAjoutFournisseurs.Text = "Modifier un fournisseur"
        frmAjoutFournisseurs.btnEnregistrer.Enabled = True

    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click

        frmAjoutFournisseurs.Show()

    End Sub

    Private Sub lsvFournisseurs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvFournisseurs.SelectedIndexChanged
        'Renvoie l'Indice de l'élément sélectionné dans le ListView
        If lsvFournisseurs.SelectedItems.Count > 0 Then
            couleurBouton("E", btnSupprimer)
            couleurBouton("E", btnModifier)
            position = lsvFournisseurs.SelectedIndices(0)
        Else
            btnSupprimer.Enabled = False
            btnModifier.Enabled = False
        End If
    End Sub

    'Supprime le fournisseur dans la bd
    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        If MsgBox("Voulez-vous supprimer le fournisseur " & lsvFournisseurs.FocusedItem.SubItems(0).Text & "?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            bd.nonQuery("Update fournisseurs set inactif = '1' where no_fournisseur = '" + position + "'")
            btnSupprimer.Enabled = False
            btnModifier.Enabled = False

            bd.miseAjourBD(bd.dsFournisseurs, bd.daFournisseurs, "fournisseurs")
            remplirListview()
        End If


    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        remplirFormulaire()

        frmAjoutFournisseurs.btnEnregistrer.Text = "Modifier"
    End Sub
    'Recherche le Fournisseur dans la bd
    Sub recherche()
        lsvFournisseurs.Enabled = True
        bd.dsFournisseurs.Clear()
        If (txtRecherche.Text = "") Then
            bd.Requete("select * from fournisseurs order by nom_fournisseur", bd.dsFournisseurs, bd.daFournisseurs, "fournisseurs")
            'Si le radioBouton Nom est Coché on recherche par nom
        ElseIf rdbNom.Checked Then
            bd.Requete("Select * from fournisseurs where lower(nom_fournisseur) like lower('" & Replace(txtRecherche.Text, "'", "''") & "%')  order by nom_fournisseur", bd.dsFournisseurs, bd.daFournisseurs, "fournisseurs")
            'Si le radioBouton Ville est Coché on recherche par ville
        ElseIf rdbVille.Checked Then
            bd.Requete("Select * from fournisseurs where lower(ville) like lower('" & Replace(txtRecherche.Text, "'", "''") & "%')  order by nom_fournisseur", bd.dsFournisseurs, bd.daFournisseurs, "fournisseurs")
            'Retour à l'affichage par défaut
        ElseIf rdbDefaut.Checked Then
            bd.Requete("Select * from fournisseurs order by nom_fournisseur", bd.dsFournisseurs, bd.daFournisseurs, "fournisseurs")
        End If

        remplirListview()

        If lsvFournisseurs.Items.Count = 0 Then
            lsvFournisseurs.Items.Add("Aucun fournisseur trouvé")
            lsvFournisseurs.Enabled = False

            bd.Requete("select * from fournisseurs order by nom_fournisseur", bd.dsFournisseurs, bd.daFournisseurs, "fournisseurs")
        End If

        btnSupprimer.Enabled = False
        btnModifier.Enabled = False
        txtRecherche.Text = ""
    End Sub

    Private Sub BtnRechercher_Click(sender As Object, e As EventArgs) Handles BtnRechercher.Click
        recherche()

    End Sub

    'Fait la recherche si l'utilisateur pèse sur Enter
    Private Sub txtRecherche_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRecherche.KeyPress
        If e.KeyChar = Chr(13) Then
            recherche()


        End If

    End Sub

    Private Sub txtRecherche_GotFocus(sender As Object, e As EventArgs) Handles txtRecherche.GotFocus
        couleurBouton("D", btnSupprimer)
        couleurBouton("D", btnModifier)
    End Sub

    Private Sub rdbNom_CheckedChanged(sender As Object, e As EventArgs) Handles rdbNom.CheckedChanged, rdbVille.CheckedChanged
        If sender.Checked Then
            txtRecherche.Enabled = True
            rdbDefaut.Enabled = True
            couleurBouton("E", BtnRechercher)
        End If


    End Sub
End Class