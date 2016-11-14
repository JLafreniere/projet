Imports System.Data
Imports MySql.Data.MySqlClient
'Jonathan Villeneuve
Public Class frmAjoutRecettes
    Dim bd As New GestionBD("Server=localhost;Database=bd_application;Uid=root;Pwd=;")
    Dim coll(2) As String
    Dim allergies As String
    Dim portion As Integer



    Sub chargerDataset()
        bd.dsRecettes.Clear()
        bd.dsProduits.Clear()
        bd.dsDetails.Clear()
        bd.Requete("select * from produits", bd.dsProduits, bd.daProduits, "produits")
        bd.Requete("select * from details_recette", bd.dsDetails, bd.daDetails, "details_recette")
        bd.Requete("select * from recettes", bd.dsRecettes, bd.daRecettes, "recettes")
    End Sub

    Private Sub frmAjoutRecettes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bd.ConnectionString = "Server=localhost; DataBase=bd_application;UId=root;Pwd=; Convert Zero Datetime=true; Allow Zero DateTime=true;"
        remplirCombo()
        chargerDataset()
        Dim ds As New DataSet
        bd.Requete("select * from produits order by nom_produit", ds, bd.daProduits, "produits")
        cbProduit.DataSource = ds.Tables(0)
        cbProduit.ValueMember = ds.Tables(0).Columns(0).ToString
        cbProduit.DisplayMember = ds.Tables(0).Columns(1).ToString
        cbProduit.AutoCompleteMode = AutoCompleteMode.Append
        cbProduit.DropDownStyle = ComboBoxStyle.DropDown
        cbProduit.AutoCompleteSource = AutoCompleteSource.ListItems
        txtId.Visible = False
        lblId.Visible = False

        Dim ctl As Control
        For Each ctl In Me.Controls
            AddHandler ctl.KeyDown, AddressOf controleSuivant
        Next



    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtTemperature_TextChanged(sender As Object, e As EventArgs) Handles txtFaraneith.TextChanged
        ' Converti le texte de txtFaraneith en celcius (txtCelcius)
        txtCelcius.Text = (CInt(txtFaraneith.Text) - 32) / 1.8
    End Sub

    Private Sub txtCelcius_TextChanged(sender As Object, e As EventArgs) Handles txtCelcius.TextChanged

    End Sub
    'Rempli le Combobox des Produits
    Sub remplirCombo()
        bd.Requete("select * from produits", bd.dsProduits, bd.daProduits, "produits")

        For i As Integer = 0 To bd.dsProduits.Tables(0).Rows.Count - 1
            cbProduit.Items.Add(bd.dsProduits.Tables(0).Rows(i)(1))
            cbProduit.AutoCompleteMode = AutoCompleteMode.Append

        Next
    End Sub

    Private Sub btnAllergies_Click(sender As Object, e As EventArgs) Handles btnAllergies.Click
        'Ajoute le contenu de txtAllergies à la ListBox des Allergies
        lstAllergies.Items.Add(txtAllergies.Text)
        txtAllergies.Text = ""

    End Sub

    Sub Ajout()
        'Ajoute la recette dans la bd

        Dim congelable As Boolean

        Dim drnouvel As DataRow
        drnouvel = bd.dsRecettes.Tables(0).NewRow()
        drnouvel(1) = txtNom.Text
        drnouvel(2) = txtPreparation.Text
        drnouvel(3) = txtCuisson.Text
        drnouvel(4) = nudPortions.Value
        drnouvel(7) = txtFaraneith.Text
        drnouvel(9) = txtEtapes.Text
        ''Si le checkbox est coché
        If chkCongelable.Checked Then
            congelable = True
        Else
            congelable = False

        End If
        'Transfère les données du ListBox Allergies dans la variable allergies
        For i As Integer = 0 To lstAllergies.Items.Count - 1


            allergies += lstAllergies.Items(i).ToString & vbCrLf



        Next
        '); delete from recettes;


        drnouvel(12) = allergies
        drnouvel(15) = congelable
        drnouvel(14) = txtCategorie.Text
        drnouvel(13) = txtConservation.Text & " " & cbConservation.Text
        drnouvel(11) = txtRemarques.Text
        drnouvel(8) = txtRefroid.Text & " " & cbRefroid.Text
        drnouvel(5) = txtPortions.Text & " " & cbPortions.Text



        bd.dsRecettes.Tables(0).Rows.Add(drnouvel)
        bd.miseAjourBD(bd.dsRecettes, bd.daRecettes, "recettes")
        chargerDataset()


        'Ajoute les produits de la recettes dans la table détail_recettes
        For Each i As ListViewItem In lsvProduit.Items
            Dim ds As New DataSet
            bd.Requete("select * from produits where nom_produit = '" & Replace(i.SubItems(0).Text, "'", "''") & "'", ds, bd.daProduits, "produits")
            MsgBox(bd.dsRecettes.Tables(0).Rows(bd.dsRecettes.Tables(0).Rows.Count - 1).Item(0).ToString)
            drnouvel = bd.dsDetails.Tables(0).NewRow()
            drnouvel(0) = ds.Tables(0).Rows(0).Item(0)
            drnouvel(1) = bd.dsRecettes.Tables(0).Rows(bd.dsRecettes.Tables(0).Rows.Count - 1).Item(0)
            drnouvel(2) = i.SubItems(1).Text
            bd.dsDetails.Tables(0).Rows.Add(drnouvel)
        Next
        bd.miseAjourBD(bd.dsDetails, bd.daDetails, "details_recette")

    End Sub



    Private Sub btnEnregistrer_Click(sender As Object, e As EventArgs) Handles btnEnregistrer.Click
        If btnEnregistrer.Text = "Enregistrer" Then
            Ajout()
        Else
            modifier()

        End If
        chargerDataset()
        Me.Close()
        viderChamps()

    End Sub

    'Ajoute le texte de txtAllergies au ListBox des Allergies
    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        coll(0) = cbProduit.Text
        coll(1) = txtQuantite.Text
        coll(2) = cbUnite.Text


        Dim lvi As New ListViewItem(coll)
        lsvProduit.Items.Add(lvi)

    End Sub

    'Remplit le ListView des Produits en fonction de la recette
    Sub remplirListView()
        lsvProduit.Items.Clear()
        bd.dsDetails.Clear()
        bd.Requete("select * from details_recette where id_recette = " & txtId.Text, bd.dsDetails, bd.daDetails, "details_recette")

        For i As Integer = 0 To bd.dsDetails.Tables(0).Rows.Count - 1
            Dim ds As New DataSet
            bd.Requete("select * from produits where id_produit = " & bd.dsDetails.Tables(0).Rows(i).Item(0), ds, bd.daProduits, "produits")

            coll(0) = ds.Tables(0).Rows(0)(1).ToString
            coll(1) = bd.dsDetails.Tables(0).Rows(i)(2).ToString
            coll(2) = bd.dsDetails.Tables(0).Rows(i)(3).ToString

            Dim lvi As New ListViewItem(coll)
            lsvProduit.Items.Add(lvi)
        Next


    End Sub

    Private Sub txtAllergies_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAllergies.KeyPress
        'Ajoute le texte de txtAllergies au Listbox si l'utilisateur pèse sur Enter
        If e.KeyChar = Chr(13) Then
            lstAllergies.Items.Add(txtAllergies.Text)
            txtAllergies.Text = ""
        End If
    End Sub
    'Modifie la recette dans la bas de données
    Dim congelable As Boolean

    Sub modifier()
        Dim nom As String = txtNom.Text
        Dim preparation As String = txtPreparation.Text
        Dim cuisson As String = txtCuisson.Text
        Dim port As String = nudPortions.Value
        Dim porti As String = txtPortions.Text & " " & cbConservation.Text
        Dim refroid As String = txtRefroid.Text & " " & cbRefroid.Text

        For i As Integer = 0 To lstAllergies.Items.Count - 1

            allergies += lstAllergies.Items(i).ToString & vbCrLf
        Next
        If chkCongelable.Checked Then
            congelable = True
        Else
            congelable = False

        End If
        bd.nonQuery("UPDATE `recettes` set `nom` = '" + txtNom.Text + "', `temps_preparation` = '" + preparation + "' , `temps_cuisson` = '" + cuisson + "' , `nb_portions` = '" + port.ToString + "' , `taille_portion` = '" + porti + "' , 
         `temps_refroidissement` = '" + refroid + "', `etapes` = '" + txtEtapes.Text + "', `remarque` = '" + txtRemarques.Text + "' , `allergies` = '" + allergies + "' 
         , `duree_conservation` = '" + txtConservation.Text + " " + cbConservation.Text + "' , `categorie` = '" + txtCategorie.Text + "', `congelable` = '" + congelable.ToString + "' where `id_recette` = '" + txtId.Text + "'")
        bd.miseAjourBD(bd.dsRecettes, bd.daRecettes, "recettes")

    End Sub
    'Vide les champs du formulaire
    Sub viderChamps()
        txtNom.Text = ""
        txtCategorie.Text = ""
        txtCelcius.Text = ""
        txtConservation.Text = ""
        txtCuisson.Text = ""
        txtEtapes.Text = ""
        txtFaraneith.Text = ""
        txtId.Text = ""
        txtPortions.Text = ""
        txtRefroid.Text = ""
        txtRemarques.Text = ""
        nudPortions.Value = 1
        cbPortions.Text = ""
        lstAllergies.Items.Clear()


    End Sub
    'Bloque les lettres dans les Zones de textes qui auront des valeurs numériques
    Private Sub txtConservation_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConservation.KeyPress, txtCuisson.KeyPress, txtPreparation.KeyPress, txtFaraneith.KeyPress,
            txtPortions.KeyPress, txtRefroid.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub
    'Met à jour les données dans le listView en fonction de de la valeur de nudPortions
    Private Sub nudPortions_ValueChanged(sender As Object, e As EventArgs) Handles nudPortions.ValueChanged
        For Each element As ListViewItem In lsvProduit.Items
            Dim qte As Double = element.SubItems(1).Text
            element.SubItems(1).Text = Math.Round(((qte * nudPortions.Value) / portion), 1, MidpointRounding.AwayFromZero)

        Next
        portion = nudPortions.Value
    End Sub

    'Supprime le produit du ListView et de la table détail_recettes
    Private Sub Supprimer_Click(sender As Object, e As EventArgs) Handles Supprimer.Click
        If MsgBox("Voulez-vous enlever ce produit de la recette?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            For Each element As ListViewItem In lsvProduit.SelectedItems
                lsvProduit.Items.Remove(element)

            Next
        End If
        'bd.dsDetails.Tables(0).Rows(position).Delete()
    End Sub

    Private Sub btnSupprimerAllergies_Click(sender As Object, e As EventArgs) Handles btnSupprimerAllergies.Click
        lstAllergies.Items.Remove(lstAllergies.SelectedItem)
    End Sub

    'Quand l'utilisateur pèse sur enter, le focus est mis sur le contrôle suivant
    Sub controleSuivant(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then

            e.SuppressKeyPress = True
            Me.SelectNextControl(Me.ActiveControl, True, True, True, True)
        End If


    End Sub
End Class