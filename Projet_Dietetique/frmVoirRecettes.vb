Imports System.Data
Imports MySql.Data.MySqlClient
Public Class frmVoirRecettes
    'Jonathan Villeneuve
    Dim bd As New GestionBD("Server=localhost;Database=bd_application;Uid=root;Pwd=;")
    Dim dsRecettes As DataSet
    Dim daRecettes As New MySqlDataAdapter
    Dim dsProduits As DataSet
    Dim daProduits As New MySqlDataAdapter
    Dim itemcoll(3) As String
    Dim position As Integer
    Dim allergies() As String
    Dim portions(2) As String
    Dim conservation() As String
    Dim refroidissement() As String

    Private Sub frmVoirRecettes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Ajoute l'entête avec les onglets
        Controls.Add(New Header(Me, True))
        bd.ConnectionString = "Server=localhost; DataBase=bd_application;UId=root;Pwd=; Convert Zero Datetime=true; Allow Zero DateTime=true;"

        centerControl(mainpanel)
        chargerdataset()
        remplirListView()
    End Sub

    'Centre le panel au centre de la page
    Private Sub centerControl(c As Control)
        c.Left = (Me.ClientSize.Width / 2) - (c.Width / 2)
    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        Hide()
        frmAjoutRecettes.Show()


    End Sub
    Sub chargerdataset() 'Rempli les dataset produits et recettes
        bd.dsRecettes.Clear()
        bd.dsProduits.Clear()
        bd.dsDetails.Clear()
        bd.Requete("select * from recettes order by nom", bd.dsRecettes, bd.daRecettes, "recettes")
        bd.Requete("select * from produits ", bd.dsProduits, bd.daProduits, "produits")
        bd.Requete("select * from details_recette", bd.dsDetails, bd.daDetails, "details_recette")
    End Sub
    'Rempli le listview avec les données de la table recettes
    Sub remplirListView()
        lsvRecette.Items.Clear()
        For i = 0 To bd.dsRecettes.Tables(0).Rows.Count - 1
            itemcoll(0) = bd.dsRecettes.Tables(0).Rows(i)(1).ToString
            itemcoll(1) = bd.dsRecettes.Tables(0).Rows(i)(2).ToString
            itemcoll(2) = bd.dsRecettes.Tables(0).Rows(i)(8).ToString
            itemcoll(3) = bd.dsRecettes.Tables(0).Rows(i)(12).ToString

            Dim lvi As New ListViewItem(itemcoll)
            lsvRecette.Items.Add(lvi)
        Next
    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        remplirFormulaire()

    End Sub

    Private Sub lsvRecette_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvRecette.SelectedIndexChanged
        'Renvoie l'Indice de l'élément sélectionné dans le ListView
        If lsvRecette.SelectedItems.Count > 0 Then
            btnModifier.Enabled = True
            btnSupprimer.Enabled = True
            position = lsvRecette.SelectedIndices(0)
        Else
            btnSupprimer.Enabled = False
            btnModifier.Enabled = False
        End If
    End Sub

    'Affecte aux controles de la form frmRecettes les données de l'élément du ListView Sélectionné
    Sub remplirFormulaire()
        frmAjoutRecettes.Show()
        frmAjoutRecettes.txtId.Text = bd.dsRecettes.Tables(0).Rows(position).Item(0).ToString
        frmAjoutRecettes.txtNom.Text = bd.dsRecettes.Tables(0).Rows(position).Item(1).ToString
        frmAjoutRecettes.txtPreparation.Text = bd.dsRecettes.Tables(0).Rows(position).Item(2).ToString
        frmAjoutRecettes.txtCuisson.Text = bd.dsRecettes.Tables(0).Rows(position).Item(3).ToString
        frmAjoutRecettes.txtFaraneith.Text = bd.dsRecettes.Tables(0).Rows(position).Item(7).ToString
        frmAjoutRecettes.nudPortions.Value = bd.dsRecettes.Tables(0).Rows(position).Item(4).ToString
        frmAjoutRecettes.txtCategorie.Text = bd.dsRecettes.Tables(0).Rows(position).Item(14).ToString
        ' On coche ou  le checkBox si la recette est congelable
        If bd.dsRecettes.Tables(0).Rows(position).Item(15).ToString = True Then
            frmAjoutRecettes.chkCongelable.Checked = True
        Else
            frmAjoutRecettes.chkCongelable.Checked = False
        End If
        frmAjoutRecettes.txtEtapes.Text = bd.dsRecettes.Tables(0).Rows(position).Item(9).ToString
        frmAjoutRecettes.txtRemarques.Text = bd.dsRecettes.Tables(0).Rows(position).Item(11).ToString
        'On ajoute les allergies dans le listbox
        allergies = bd.dsRecettes.Tables(0).Rows(position).Item(12).ToString.Split(vbCrLf)
        For i As Integer = 0 To allergies.Length - 1
            frmAjoutRecettes.lstAllergies.Items.Add(allergies(i))
        Next

        portions = bd.dsRecettes.Tables(0).Rows(position).Item(5).ToString.Split(" ")

        frmAjoutRecettes.txtPortions.Text = portions(0)
        frmAjoutRecettes.cbPortions.Text = portions(1)
        conservation = bd.dsRecettes.Tables(0).Rows(position).Item(13).ToString.Split(" ")
        frmAjoutRecettes.txtConservation.Text = conservation(0)
        frmAjoutRecettes.cbConservation.Text = conservation(1)
        refroidissement = bd.dsRecettes.Tables(0).Rows(position).Item(8).ToString.Split(" ")
        frmAjoutRecettes.txtRefroid.Text = refroidissement(0)
        frmAjoutRecettes.cbRefroid.Text = refroidissement(1)
        frmAjoutRecettes.btnEnregistrer.Text = "Modifier"

        frmAjoutRecettes.remplirListView()

    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click 'Supprime la recette sélectionée et les données de la table détails_recettes liées à cette recette
        Dim ds As New DataSet
        Dim ds2 As New DataSet
        If MsgBox("Voulez-vous supprimer cette recette?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            For Each element As ListViewItem In lsvRecette.SelectedItems

                bd.Requete("Select * from recettes where nom = '" & element.SubItems(0).Text & "'", ds, bd.daRecettes, "recettes")

                bd.Requete("Select * from details_recette where id_recette =  " & ds.Tables(0).Rows(0).Item(0).ToString & " ", ds2, bd.daDetails, "details_recette")

                For i As Integer = 0 To ds2.Tables(0).Rows.Count - 1
                    ds2.Tables(0).Rows(i).Delete()

                Next
                bd.miseAjourBD(bd.dsDetails, bd.daDetails, "details_recette")
            Next

            ds.Tables(0).Rows(0).Delete()



        End If
        btnSupprimer.Enabled = False
        btnModifier.Enabled = False


        bd.miseAjourBD(bd.dsRecettes, bd.daRecettes, "recettes")

        remplirListView()



    End Sub
    'Recherche dans la BD les recettes selon le contenu du Textbox
    Sub recherche()
        lsvRecette.Enabled = True
        bd.dsRecettes.Clear()
        If (txtRecherche.Text = "") Then
            bd.Requete("select * from recettes order by nom", bd.dsRecettes, bd.daRecettes, "recettes")
        Else
            bd.Requete("Select * from recettes where lower(nom) like lower('" & Replace(txtRecherche.Text, "'", "''") & "%')  order by nom", bd.dsRecettes, bd.daRecettes, "recettes")
        End If

        remplirListView()

        If lsvRecette.Items.Count = 0 Then
            lsvRecette.Items.Add("Aucune recette trouvée")
            lsvRecette.Enabled = False

            bd.Requete("select * from recettes order by nom", bd.dsRecettes, bd.daRecettes, "recettes")
        End If

        btnSupprimer.Enabled = False
        btnModifier.Enabled = False
        txtRecherche.Text = ""
    End Sub

    Private Sub BtnRechercher_Click(sender As Object, e As EventArgs) Handles BtnRechercher.Click
        recherche()
    End Sub
    'Fait la recherche si l'utilisateur appuie sur enter
    Private Sub txtRecherche_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRecherche.KeyPress
        If e.KeyChar = Chr(13) Then
            recherche()

        End If
    End Sub
End Class