Imports MySql.Data.MySqlClient
Imports System.Data
'Jonathan VILLENEUVE
Public Class frmCommandes
    Dim bd As New GestionBD("Server=localhost;Database=bd_application;Uid=root;Pwd=;")
    Dim coll(2) As String
    Dim ds As New DataSet
    Dim ds2 As New DataSet
    Dim ds3 As New DataSet
    Dim ds4 As New DataSet
    Dim ds5 As New DataSet
    Dim ds6 As New DataSet
    Dim dss As New DataSet
    Public position As Integer = -1






    Private Sub frmCommandes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Controls.Add(New Header(Me, True))
        bd.ConnectionString = "Server=localhost; DataBase=bd_application;UId=root;Pwd=; Convert Zero Datetime=true; Allow Zero DateTime=true;"
        btnReception.Enabled = True



        dtpDate.Visible = False
        txtRecherche.Enabled = False

        chargerDataset()
        remplirListView()




    End Sub


    'Charge le dataset des commandes

    Sub chargerDataset()
        bd.dsCommandes.Clear()
        bd.Requete("Select * from commandes", bd.dsCommandes, bd.daCommandes, "commandes")
    End Sub

    'Remplit le listView des Commandes
    Sub remplirListView()

        lsvCommandes.Items.Clear()
        ds2.Clear()

        For i As Integer = 0 To bd.dsCommandes.Tables(0).Rows.Count - 1
            'On parcours les tables pour pouvoir afficher le nom des fournisseurs

            bd.Requete("Select * from `fournisseurs` where `id_fournisseur` = '" + bd.dsCommandes.Tables(0).Rows(i).Item(2).ToString + "'", ds2, bd.daFournisseurs, "fournisseurs")


            coll(0) = FormatDateTime(bd.dsCommandes.Tables(0).Rows(i).Item(1).ToString(), DateFormat.ShortDate)
            coll(1) = ds2.Tables(0).Rows(i).Item(1).ToString
            'On fait un sum pour afficher le total de la commande
            bd.Requete("Select Sum(total) from details_commande group by id_commande", ds6, bd.daDetailsCommandes, "details_commande")
            coll(2) = ds6.Tables(0).Rows(i).Item(0) & "$"



            Dim lvi As New ListViewItem(coll)

            lsvCommandes.Items.Add(lvi)

        Next

    End Sub

    Sub recherche()
        lsvCommandes.Enabled = True
        If rdbDate.Checked Then

            bd.dsCommandes.Clear()
            bd.Requete("Select * from commandes where `date_commande` = '" + dtpDate.Value.Date + "'", bd.dsCommandes, bd.daCommandes, "commandes")

        ElseIf rdbFournisseur.Checked Then
            bd.dsCommandes.Clear()
            'On parcours la table fournisseur pour rechercher selon le nom du fournisseur
            If txtRecherche.Text = "" Then
                bd.Requete("Select * from commandes", bd.dsCommandes, bd.daCommandes, "commandes")

            Else
                bd.Requete("Select * from fournisseurs where lower(nom_fournisseur) like lower('" & Replace(txtRecherche.Text, "'", "''") & "%')  order by nom_fournisseur", ds4, bd.daFournisseurs, "fournisseurs")
                bd.Requete("Select * from commandes where `fournisseur` = '" + ds4.Tables(0).Rows(0).Item(0).ToString + "' ", bd.dsCommandes, bd.daCommandes, "commandes")
            End If

        End If


        remplirListView()


        If lsvCommandes.Items.Count = 0 Then
            lsvCommandes.Items.Add("Aucune commande trouvée")
            lsvCommandes.Enabled = False

            bd.Requete("select * from commandes ", bd.dsCommandes, bd.daCommandes, "commandes")
        End If


        btnModifier.Enabled = False
        txtRecherche.Text = ""
    End Sub


    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click

        frmAjoutCommandes.Show()

    End Sub

    Private Sub BtnRechercher_Click(sender As Object, e As EventArgs) Handles BtnRechercher.Click
        recherche()

    End Sub

    Private Sub rdbDate_CheckedChanged(sender As Object, e As EventArgs) Handles rdbDate.CheckedChanged
        If rdbDate.Checked Then
            dtpDate.Visible = True
            txtRecherche.Visible = False



        End If
    End Sub

    Private Sub rdbFournisseur_CheckedChanged(sender As Object, e As EventArgs) Handles rdbFournisseur.CheckedChanged

        dtpDate.Visible = False
        txtRecherche.Visible = True
        txtRecherche.Enabled = True
    End Sub



    'Transfert les données de la commande dans les contrôles de frmAjoutCommandes
    Sub rempliFormulaire()
        'Si la commande est envoyee on bloque les champs et elle est juste consultable
        If bd.dsCommandes.Tables(0).Rows(position).Item(5) = True Then
            frmAjoutCommandes.cbFournisseurs.Enabled = False
            frmAjoutCommandes.txtNotes.Enabled = False
            frmAjoutCommandes.dtpDate.Enabled = False
            frmAjoutCommandes.cbProduits.Enabled = False
            frmAjoutCommandes.nudQuantite.Enabled = False
            frmAjoutCommandes.lsvProduits.Enabled = False
            If bd.dsCommandes.Tables(0).Rows(position).Item(5) = True Then
                frmAjoutCommandes.rdbRecue.Checked = True
            Else
                frmAjoutCommandes.rdbRecue.Checked = False
            End If
            frmAjoutCommandes.Text = "Consulter une commande"

        Else

            frmAjoutCommandes.Text = "Modifier une commande"

        End If
        frmAjoutCommandes.btnEnregistrer.Text = "Modifier"
        frmAjoutCommandes.dtpDate.Value = bd.dsCommandes.Tables(0).Rows(position).Item(1)
        frmAjoutCommandes.txtNotes.Text = bd.dsCommandes.Tables(0).Rows(position).Item(4)
        'On recherche le fournisseur pour le faire afficher dans le ComboBox de frmAjoutCommandes
        bd.Requete("Select  * from fournisseurs where `id_fournisseur` = '" + bd.dsCommandes.Tables(0).Rows(position).Item(2).ToString + "'", ds5, bd.daFournisseurs, "fournisseurs")
        frmAjoutCommandes.cbFournisseurs.Text = ds5.Tables(0).Rows(0).Item(1)

        frmAjoutCommandes.remplirListView()


    End Sub

    Private Sub lsvCommandes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvCommandes.SelectedIndexChanged
        'Renvoie l'Indice de l'élément sélectionné dans le ListView
        If lsvCommandes.SelectedItems.Count > 0 Then
            btnModifier.Enabled = True

            position = lsvCommandes.SelectedIndices(0)
        Else

            btnModifier.Enabled = False
        End If
    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        rempliFormulaire()

        frmAjoutCommandes.Show()


    End Sub

    Private Sub btnReception_Click(sender As Object, e As EventArgs) Handles btnReception.Click
        frmReceptionCommande.Show()

    End Sub
End Class