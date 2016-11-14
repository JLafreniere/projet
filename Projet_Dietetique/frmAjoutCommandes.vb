Imports MySql.Data.MySqlClient
Imports System.Data
'Jonathan Villeneuve
Public Class frmAjoutCommandes
    Dim bd As New GestionBD("Server=localhost;Database=bd_application;Uid=root;Pwd=;")
    Dim ds As New DataSet
    Dim ds2 As New DataSet
    Dim ds3 As New DataSet
    Dim ds4 As New DataSet
    Dim ds5 As New DataSet
    Dim ds6 As New DataSet
    Dim ds7 As New DataSet
    Dim dss As New DataSet
    Dim col(2) As String
    Dim envoye As Boolean = False





    Private Sub frmAjoutCommandes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bd.ConnectionString = "Server=localhost; DataBase=bd_application;UId=root;Pwd=; Convert Zero Datetime=true; Allow Zero DateTime=true;"
        chargerDataset()
        remplirComboBox()
        'AutoCompletion des comboBox
        cbProduits.AutoCompleteMode = AutoCompleteMode.Append
        cbProduits.DropDownStyle = ComboBoxStyle.DropDown
        cbProduits.AutoCompleteSource = AutoCompleteSource.ListItems
        cbFournisseurs.AutoCompleteMode = AutoCompleteMode.Append
        cbFournisseurs.DropDownStyle = ComboBoxStyle.DropDown
        cbFournisseurs.AutoCompleteSource = AutoCompleteSource.ListItems

    End Sub
    'Remplit les Dataset
    Sub chargerDataset()
        bd.dsCommandes.Clear()
        bd.dsFournisseurs.Clear()
        bd.dsProduitFourn.Clear()
        bd.dsProduits.Clear()
        bd.dsDetailsCommandes.Clear()


        bd.Requete("Select * from commandes", bd.dsCommandes, bd.daCommandes, "commandes")
        bd.Requete("Select  * from fournisseurs order by nom_fournisseur", bd.dsFournisseurs, bd.daFournisseurs, "fournisseurs")
        bd.Requete("Select * from produits_fournisseurs", bd.dsProduitFourn, bd.daProduitFourn, "produits_fournisseurs")
        bd.Requete("Select * from details_commande", bd.dsDetailsCommandes, bd.daDetailsCommandes, "details_commande")


    End Sub


    'Remplit le combobox des Fournisseurs
    Sub remplirComboBox()

        For i As Integer = 0 To bd.dsFournisseurs.Tables(0).Rows.Count - 1
            cbFournisseurs.Items.Add(bd.dsFournisseurs.Tables(0).Rows(i).Item(1))
        Next

    End Sub
    'Ajoute la commande dans la bd (elle sera modifiable tant que l'utilisateur ne cliquera pas sur le bouton envoyer)
    Sub ajouter()
        Dim drNouvel As DataRow

        Dim reference As Integer

        drNouvel = bd.dsCommandes.Tables(0).NewRow
        drNouvel(1) = dtpDate.Value

        'On recherche le no du fournisseur qui correspond à l'élément sélectionné du comboBox des Founisseurs
        bd.Requete("Select * from `fournisseurs` where `nom_fournisseur` = '" + cbFournisseurs.Text + "'", ds5, bd.daFournisseurs, "fournisseurs")


        drNouvel(2) = ds5.Tables(0).Rows(0).Item(0)


        'Le no de référence sera un nombre aléatoire
        Dim generator As New Random

        reference = generator.Next(10000, 999999)
        drNouvel(3) = reference
        drNouvel(4) = txtNotes.Text

        drNouvel(5) = envoye

        bd.dsCommandes.Tables(0).Rows.Add(drNouvel)
        bd.miseAjourBD(bd.dsCommandes, bd.daCommandes, "commandes")





        chargerDataset()


        'On ajoute les produits de la commande dans la table dÉtails_commandes
        For Each element As ListViewItem In lsvProduits.Items
            Dim ds8 As New DataSet
            'On recherche le produit qui correspond au nom du produit dans le listView
            bd.Requete("Select * from produits where nom_produit = '" + Replace(element.SubItems(0).Text, "'", "''") + "'", ds8, bd.daProduits, "produits")
            drNouvel = bd.dsDetailsCommandes.Tables(0).NewRow
            drNouvel(0) = bd.dsCommandes.Tables(0).Rows.Count + 1


            drNouvel(1) = ds8.Tables(0).Rows(0).Item(0)
            drNouvel(2) = element.SubItems(2).Text
            bd.dsDetailsCommandes.Tables(0).Rows.Add(drNouvel)


        Next

        bd.miseAjourBD(bd.dsDetailsCommandes, bd.daDetailsCommandes, "details_commande")
        viderChamp()
    End Sub
    'Modifie le contenu de la commande dans la bd
    Sub modifier()
        bd.Requete("Select * from `fournisseurs` where `nom_fournisseur` = '" + cbFournisseurs.Text + "'", dss, bd.daFournisseurs, "fournisseurs")
        Dim drnouvel As DataRow
        'On met à jour la table details_commandes
        bd.nonQuery("Delete from details_commande where `id_commande` = '" + (frmCommandes.position + 1).ToString + "'")
        bd.miseAjourBD(bd.dsDetailsCommandes, bd.daDetailsCommandes, "details_commande")
        For Each element As ListViewItem In lsvProduits.Items
            Dim ds8 As New DataSet
            'On recherche le produit qui correspond au nom du produit dans le listView
            bd.Requete("Select * from produits where nom_produit = '" + Replace(element.SubItems(0).Text, "'", "''") + "'", ds8, bd.daProduits, "produits")
            drnouvel = bd.dsDetailsCommandes.Tables(0).NewRow
            drnouvel(0) = frmCommandes.position + 1



            drnouvel(1) = ds8.Tables(0).Rows(0).Item(0)
            drnouvel(2) = element.SubItems(2).Text
            bd.dsDetailsCommandes.Tables(0).Rows.Add(drnouvel)


        Next

        bd.nonQuery("UPDATE `commandes` set `date_commande` = '" + dtpDate.Value.Date.ToString + "' , `note` = '" + txtNotes.Text + "', `fournisseur` = '" + dss.Tables(0).Rows(0).Item(0).ToString + "' where `id_commande` = '" + (frmCommandes.position + 1).ToString + "'")


        bd.miseAjourBD(bd.dsDetailsCommandes, bd.daDetailsCommandes, "details_commande")
        bd.miseAjourBD(bd.dsCommandes, bd.daCommandes, "commandes")

    End Sub
    'Modifie le contenu du combobox des produits en fonction du fournisseur sélectionné
    Private Sub cbFournisseurs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFournisseurs.SelectedIndexChanged
        cbProduits.Items.Clear()
        ds.Clear()
        ds2.Clear()
        bd.Requete("Select * from `produits_fournisseurs` where `id_fournisseur` = '" + (cbFournisseurs.SelectedIndex + 1).ToString + "'", ds, bd.daProduitFourn, "produits_fournisseurs")

        If ds.Tables(0).Rows.Count > 0 Then


            For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                bd.Requete("Select * from produits where `id_produit` = '" + ds.Tables(0).Rows(i).Item(1).ToString + "'", ds2, bd.daProduits, "produits")
                cbProduits.Items.Add(ds2.Tables(0).Rows(i).Item(1))
            Next
        End If

    End Sub



    Private Sub btnEnregistrer_Click(sender As Object, e As EventArgs) Handles btnEnregistrer.Click
        If btnEnregistrer.Text = "Enregistrer" Then
            ajouter()
        Else
            modifier()

        End If

    End Sub

    Sub viderChamp()
        txtNotes.Text = ""
        cbFournisseurs.Text = ""
        cbProduits.Text = ""
        dtpDate.Value = Today
        lsvProduits.Items.Clear()



    End Sub
    'Remplit le ListView des Produits
    Sub remplirProduit()
        col(0) = cbProduits.Text
        col(1) = nudQuantite.Value
        'On recherche le produit pour calculer le total
        bd.Requete("Select * from `produits` where `nom_produit` = '" + cbProduits.Text + "'", ds3, bd.daProduits, "produits")
        bd.Requete("Select * from `produits_fournisseurs` where `id_fournisseur` = '" + (cbFournisseurs.SelectedIndex + 1).ToString + "' and `id_produit` = '" + ds3.Tables(0).Rows(0).Item(0).ToString + "'", ds4, bd.daProduitFourn, "produits_fournisseurs")
        col(2) = CInt(nudQuantite.Value * ds4.Tables(0).Rows(0).Item(3))


        Dim lvi As New ListViewItem(col)
        lsvProduits.Items.Add(lvi)
    End Sub

    Private Sub btnAjouterProduit_Click(sender As Object, e As EventArgs) Handles btnAjouterProduit.Click
        remplirProduit()

    End Sub
    'Supprime le produit du listView
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSupprimerListiew.Click
        For Each element As ListViewItem In lsvProduits.SelectedItems
            lsvProduits.Items.Remove(element)
        Next
    End Sub
    'Remplit le listView selon la commande
    Sub remplirListView()
        lsvProduits.Items.Clear()
        bd.dsDetailsCommandes.Clear()
        bd.Requete("Select * from details_commande where `id_commande` = '" + (frmCommandes.position + 1).ToString + "'", bd.dsDetailsCommandes, bd.daDetailsCommandes, "details_commande")

        For i As Integer = 0 To bd.dsDetailsCommandes.Tables(0).Rows.Count - 1
            Dim ds8 As New DataSet
            Dim ds9 As New DataSet
            'On recherche le produit pour afficher le nom du produit dans le listView 
            bd.Requete("Select * from produits where `id_produit` = '" + bd.dsDetailsCommandes.Tables(0).Rows(i).Item(1).ToString + "'", ds8, bd.daProduits, "produits")
            'On recherche le produit pour pouvoir afficher le prix dans le listView
            bd.Requete("Select * from produits_fournisseurs where `ID_produit` = '" + bd.dsDetailsCommandes.Tables(0).Rows(i).Item(1).ToString + "'", ds9, bd.daProduitFourn, "produits_fournisseurs")

            col(0) = ds8.Tables(0).Rows(0).Item(1)
            col(1) = CInt(bd.dsDetailsCommandes.Tables(0).Rows(i).Item(2) / ds9.Tables(0).Rows(0).Item(3))
            col(2) = bd.dsDetailsCommandes.Tables(0).Rows(i).Item(2)

            Dim lvi As New ListViewItem(col)
            lsvProduits.Items.Add(lvi)
        Next

    End Sub
    'Envoie la commande (elle ne sera que consultable)
    Sub envoyer()
        envoye = True
        ajouter()


    End Sub

    Private Sub btnEnvoyer_Click(sender As Object, e As EventArgs) Handles btnEnvoyer.Click
        'Si la commande est dans la base de données on la modifie, si elle 
        envoyer()

    End Sub
End Class