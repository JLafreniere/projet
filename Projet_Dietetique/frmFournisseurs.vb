'Jonathan Villeneuve
Imports System.Data
Imports MySql.Data.MySqlClient
Public Class frmFournisseurs
    Dim bd As New GestionBD("Server=localhost;Database=bd_application;Uid=root;Pwd=;")
    Dim coll(2) As String
    Public position As Integer


    Private Sub frmFournisseurs_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Controls.Add(New Header(Me, True))
        bd.ConnectionString = "Server=localhost; DataBase=bd_application;UId=root;Pwd=; Convert Zero Datetime=true; Allow Zero DateTime=true;"


        chargerDataset()
        remplirListview()
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Sub chargerDataset()
        bd.dsFournisseurs.Clear()
        bd.Requete("select * from fournisseurs order by nom_fournisseur", bd.dsFournisseurs, bd.daFournisseurs, "fournisseurs")


    End Sub


    'Remplit le listView des Fournisseurs
    Sub remplirListview()
        lsvFournisseurs.Items.Clear()

        For i = 0 To bd.dsFournisseurs.Tables(0).Rows.Count - 1
            coll(0) = bd.dsFournisseurs.Tables(0).Rows(i)(1).ToString
            coll(1) = bd.dsFournisseurs.Tables(0).Rows(i)(3).ToString & " " & bd.dsFournisseurs.Tables(0).Rows(i)(4).ToString
            coll(2) = bd.dsFournisseurs.Tables(0).Rows(i)(11).ToString

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

    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click

        frmAjoutFournisseurs.Show()

    End Sub

    Private Sub lsvFournisseurs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvFournisseurs.SelectedIndexChanged
        'Renvoie l'Indice de l'élément sélectionné dans le ListView
        If lsvFournisseurs.SelectedItems.Count > 0 Then
            btnModifier.Enabled = True
            btnSupprimer.Enabled = True
            position = lsvFournisseurs.SelectedIndices(0)
        Else
            btnSupprimer.Enabled = False
            btnModifier.Enabled = False
        End If
    End Sub

    'Supprime le fournisseur dans la bd
    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        If MsgBox("Voulez-vous supprimer le fournisseur " & lsvFournisseurs.FocusedItem.SubItems(0).Text & "?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            bd.dsFournisseurs.Tables(0).Rows(position).Delete()
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
        Else
            bd.Requete("Select * from fournisseurs where lower(nom_fournisseur) like lower('" & Replace(txtRecherche.Text, "'", "''") & "%')  order by nom_fournisseur", bd.dsFournisseurs, bd.daFournisseurs, "fournisseurs")
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

    Private Sub txtRecherche_TextChanged(sender As Object, e As EventArgs) Handles txtRecherche.TextChanged

    End Sub
End Class