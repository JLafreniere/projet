Imports System.ComponentModel
Imports System.Data
Imports System.IO
Imports MySql.Data.MySqlClient
'Francis Audet 90%
'Jonathan Villeneuve 10%


Public Class frmAjoutRecettes
    Dim bd As New GestionBD("Server=localhost;Database=bd_application;Uid=root;Pwd=;")
    Dim coll(2) As String
    Dim allergies As String
    Dim portion As Integer
    Public id As Integer


    Public Sub fClose() Handles MyBase.FormClosing
        frmAccueil.Hide()
    End Sub


    Private Sub frmAjoutRecettes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bd.ConnectionString = "Server=localhost; DataBase=bd_application;UId=root;Pwd=; Convert Zero Datetime=true; Allow Zero DateTime=true;"



        Dim h As New Header(Me, False) 'Met le header du formulaire
        h.exitOnClose = False
        Controls.Add(h)

        chargerDataset()



        'Remplir les combobox
        Dim ds As New DataSet
        bd.Requete("select * from produits where hidden = 0 order by nom_produit", ds, bd.daProduits, "produits")
        cbProduit.DataSource = ds.Tables(0)
        cbProduit.ValueMember = ds.Tables(0).Columns(0).ToString
        cbProduit.DisplayMember = ds.Tables(0).Columns(1).ToString
        cbProduit.AutoCompleteMode = AutoCompleteMode.Append
        cbProduit.DropDownStyle = ComboBoxStyle.DropDown
        cbProduit.AutoCompleteSource = AutoCompleteSource.ListItems
        couleurBouton("D", btnAllergies)
        couleurBouton("D", btnSupprimerAllergies)
        couleurBouton("D", btnEnregistrer)
        For i As Integer = 0 To bd.uniteMesure.length - 1
            cbPortions.Items.Add(bd.uniteMesure(i))

        Next
        cbPortions.SelectedIndex = 2
        For i As Integer = 0 To bd.uniteMesure.length - 1
            cbUnite.Items.Add(bd.uniteMesure(i))
        Next
    End Sub

    Sub chargerDataset() 'Rempli les dataset
        bd.dsRecettes.Clear()
        bd.dsProduits.Clear()
        bd.dsDetails.Clear()
        bd.Requete("select * from produits where hidden = 0", bd.dsProduits, bd.daProduits, "produits")
        bd.Requete("select * from details_recette", bd.dsDetails, bd.daDetails, "details_recette")
        bd.Requete("select * from recettes", bd.dsRecettes, bd.daRecettes, "recettes")
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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picRecette.Click 'Permet d'importer une image 
        'Jonathan Lafreniere
        Try
            OpenFileDialog1.Filter = "Images (*.bmp, *.jpg, *.png, *.JLC)|*.bmp;*.jpg;*.png; *.JLC"
            OpenFileDialog1.ShowDialog()
            picRecette.Image = Image.FromFile(OpenFileDialog1.FileName)
            Me.picRecette.SizeMode = PictureBoxSizeMode.StretchImage
        Catch exc As Exception
        End Try
    End Sub


    Private Sub txtTemperature_TextChanged(sender As Object, e As EventArgs) Handles txtFaraneith.KeyUp, txtCelcius.KeyUp
        'Calcul de temperature
        Try
            If sender.tag = "f" Then
                ' Converti le texte de txtFaraneith en celcius (txtCelcius)
                txtCelcius.Text =
                Math.Round(((CDbl(txtFaraneith.Text) - 32) / 1.8), 0, MidpointRounding.AwayFromZero)

            Else
                'celsius * 9/5 + 32 
                txtFaraneith.Text = Math.Round((CDbl(txtCelcius.Text) * 1.8) + 32, 0, MidpointRounding.AwayFromZero)
            End If
        Catch exc As Exception : End Try
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
            If i = 0 Then
                allergies += lstAllergies.Items(i).ToString
            Else
                allergies += vbCrLf & lstAllergies.Items(i).ToString
            End If

        Next


        drnouvel(12) = allergies
        drnouvel(15) = congelable
        drnouvel(14) = txtCategorie.Text
        drnouvel(13) = txtConservation.Text
        drnouvel(11) = txtRemarques.Text
        drnouvel(8) = txtRefroid.Text
        drnouvel(6) = cbPortions.Text
        drnouvel(5) = txtPortions.Text

        'Image on save l'image dans le bin avec un nom associé a l'ID de la recette
        If Not picRecette.Image Is Nothing Then 'copie l'image dans le bin et sauvegarde le path dans la bd
            Try
                Dim str As String = bd.executeScalar("select coalesce(max(id_recette), 1) from recettes")
                id = (str + 1)
                FileCopy(OpenFileDialog1.FileName, My.Application.Info.DirectoryPath & "\Images\JLC" & str & ".JLC")
                drnouvel(10) = "JLC" &
               str & ".JLC"
            Catch exc As Exception
                drnouvel(10) = bd.executeScalar("select image from recettes where id_recette = " & id)
            End Try
        End If



        bd.dsRecettes.Tables(0).Rows.Add(drnouvel)
        bd.miseAjourBD(bd.dsRecettes, bd.daRecettes, "recettes")
        chargerDataset()


        'Ajoute les produits de la recettes dans la table détail_recettes
        For Each i As ListViewItem In lsvProduit.Items
            Dim ds As New DataSet
            bd.Requete("select * from produits where nom_produit = '" & Replace(i.SubItems(0).Text, "'", "''") & "'", ds, bd.daProduits, "produits")
            drnouvel = bd.dsDetails.Tables(0).NewRow()
            drnouvel(0) = ds.Tables(0).Rows(0).Item(0)
            drnouvel(1) = bd.dsRecettes.Tables(0).Rows(bd.dsRecettes.Tables(0).Rows.Count - 1).Item(0)
            drnouvel(2) = i.SubItems(1).Text
            drnouvel(3) = i.SubItems(2).Text
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
        frmAccueil.Hide()
        frmVoirRecettes.Hide()
        frmVoirRecettes.refreshPage()
        frmVoirRecettes.Show()
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
        bd.Requete("select * from details_recette where id_recette = " & id, bd.dsDetails, bd.daDetails, "details_recette")

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
        'Rempli la allergies'
        For i As Integer = 0 To lstAllergies.Items.Count - 1
            If i = 0 Then
                allergies += Replace(lstAllergies.Items(i).ToString, "'", "''")
            Else
                allergies += vbCrLf & Replace(lstAllergies.Items(i).ToString, "'", "''")
            End If


        Next
        If chkCongelable.Checked Then
            congelable = True
        Else
            congelable = False
        End If

        Dim dsTemp As New DataSet
        bd.Requete("select * from recettes where id_recette = " & id, dsTemp, bd.daRecettes, "recettes")
        Dim strImage As String = dsTemp.Tables(0).Rows(0).Item(10).ToString
        If Not picRecette.Image Is Nothing Then 'copie l'image dans le bin et sauvegarde le path dans la bd
            Try
                picRecette.Image = Nothing
                picRecette.Dispose()
                File.Copy(OpenFileDialog1.FileName, My.Application.Info.DirectoryPath & "\Images\JLC" & id & ".JLC", True)
                strImage = "JLC" & id & ".JLC"
            Catch exc As Exception

            End Try
        End If

        'update
        bd.nonQuery("UPDATE recettes set nom = '" & Replace(txtNom.Text, "'", "''") & "', temps_preparation = '" & Replace(txtPreparation.Text, "'", "''") & "' , temps_cuisson = '" & Replace(txtCuisson.Text, "'", "''") & "' , nb_portions = " & nudPortions.Value & " , taille_portion = " & Replace(txtPortions.Text, "'", "''") & " , 
         unite_mesure = '" & Replace(cbPortions.Text, "'", "''") & "' , temps_refroidissement = '" & Replace(txtRefroid.Text, "'", "''") & "', etapes = '" & Replace(txtEtapes.Text, "'", "''") & "' , Image = '" & strImage & "', remarque = '" & Replace(txtRemarques.Text, "'", "''") & "' , Allergene = '" & allergies & "' 
         , duree_conservation = '" & Replace(txtConservation.Text, "'", "''") & "' , categorie = '" & Replace(txtCategorie.Text, "'", "''") & "' , congelable = '" & congelable.ToString & "' where id_recette = " & id)


        bd.nonQuery("Delete from details_recette where id_recette = " & id)

        'update les aliments de la recette
        chargerDataset()
        Dim drnouvel As DataRow
        For Each i As ListViewItem In lsvProduit.Items
            Dim ds As New DataSet
            bd.Requete("select * from produits where nom_produit = '" & Replace(i.SubItems(0).Text, "'", "''") & "'", ds, bd.daProduits, "produits")
            drnouvel = bd.dsDetails.Tables(0).NewRow()
            drnouvel(0) = ds.Tables(0).Rows(0).Item(0)
            drnouvel(1) = id
            drnouvel(2) = i.SubItems(1).Text
            drnouvel(3) = i.SubItems(2).Text
            bd.dsDetails.Tables(0).Rows.Add(drnouvel)
        Next
        bd.miseAjourBD(bd.dsDetails, bd.daDetails, "details_recette")


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
        txtPortions.Text = ""
        txtRefroid.Text = ""
        txtRemarques.Text = ""
        nudPortions.Value = 1
        lstAllergies.Items.Clear()


    End Sub

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

    Private Sub lstAllergies_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAllergies.SelectedIndexChanged
        'Change l'état des boutons d'allergie
        If lstAllergies.SelectedItems.Count > 0 Then
            couleurBouton("E", btnSupprimerAllergies)
        Else
            couleurBouton("D", btnSupprimerAllergies)

        End If
    End Sub

    Private Sub cbProduit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProduit.TextChanged, cbProduit.KeyUp, txtQuantite.TextChanged, cbUnite.TextChanged
        Dim dsTemp As New DataSet

        bd.Requete("select * from produits where hidden = 0 and upper(nom_produit) = upper('" & Replace(cbProduit.Text, "'", "''") & "')", dsTemp, bd.daProduits, "produits")

        If dsTemp.Tables(0).Rows.Count = 0 Or txtQuantite.Text = "" Or cbUnite.Text = "" Then
            couleurBouton("D", btnAjouter)

        Else
            couleurBouton("E", btnAjouter)

        End If

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCelcius.KeyPress, txtFaraneith.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantite.KeyPress, txtPortions.KeyPress


        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                If e.KeyChar = "," Then
                    If sender.Text.IndexOf(",") >= 0 Then 'Allows " . " and prevents more than 1 " . "
                        e.Handled = True
                    Else
                        e.Handled = False
                    End If
                Else
                End If
            End If
        End If


    End Sub

    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        Me.Close()
        frmVoirRecettes.Show()
    End Sub

    Private Sub frmAjoutRecettes_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frmVoirRecettes.Show()
    End Sub

    Private Sub txtAllergies_TextChanged(sender As Object, e As EventArgs) Handles txtAllergies.TextChanged
        If txtAllergies.Text = "" Then
            couleurBouton("D", btnAllergies)
        Else
            couleurBouton("E", btnAllergies)
        End If
    End Sub

    Private Sub txtNom_TextChanged(sender As Object, e As EventArgs) Handles txtNom.TextChanged, txtCategorie.TextChanged, txtPreparation.TextChanged, txtCuisson.TextChanged, txtFaraneith.TextChanged, txtCelcius.TextChanged, txtRefroid.TextChanged,
        txtConservation.TextChanged, nudPortions.ValueChanged, txtPortions.TextChanged, cbPortions.TextChanged, chkCongelable.CheckStateChanged, txtRemarques.TextChanged, txtAllergies.TextChanged, cbProduit.TextChanged, txtQuantite.TextChanged, cbUnite.TextChanged,
        txtEtapes.TextChanged, picRecette.Click

        If txtNom.Text = "" Then
            couleurBouton("D", btnEnregistrer)
        Else
            couleurBouton("E", btnEnregistrer)
        End If
    End Sub
End Class