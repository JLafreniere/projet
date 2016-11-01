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
    Dim col(2) As String





    Private Sub frmAjoutCommandes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bd.ConnectionString = "Server=localhost; DataBase=bd_application;UId=root;Pwd=; Convert Zero Datetime=true; Allow Zero DateTime=true;"
        chargerDataset()
        remplirComboBox()
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
        bd.Requete("Select  * from fournisseurs", bd.dsFournisseurs, bd.daFournisseurs, "fournisseurs")
        bd.Requete("Select * from produits_fournisseurs", bd.dsProduitFourn, bd.daProduitFourn, "produits_fournisseurs")
        bd.Requete("Select * from details_commande", bd.dsDetailsCommandes, bd.daDetailsCommandes, "details_commande")


    End Sub


    'Remplit le combobox des Fournisseurs
    Sub remplirComboBox()

        For i As Integer = 0 To bd.dsFournisseurs.Tables(0).Rows.Count - 1
            cbFournisseurs.Items.Add(bd.dsFournisseurs.Tables(0).Rows(i).Item(1))
        Next

    End Sub
    'Ajoute la commande dans la bd
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

        bd.dsCommandes.Tables(0).Rows.Add(drNouvel)
        bd.miseAjourBD(bd.dsCommandes, bd.daCommandes, "commandes")





        chargerDataset()


        'On ajoute les produits de la commande dans la table dÉtails_commandes
        For Each element As ListViewItem In lsvProduits.Items
            Dim ds8 As New DataSet
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
        ajouter()
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
End Class