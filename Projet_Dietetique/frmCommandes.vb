Imports MySql.Data.MySqlClient
Imports System.Data
'Jonathan Villeneuve
Public Class frmCommandes
    Dim bd As New GestionBD("Server=localhost;Database=bd_application;Uid=root;Pwd=;")
    Dim coll(2) As String
    Dim ds As New DataSet
    Dim ds2 As New DataSet
    Dim ds3 As New DataSet
    Dim ds4 As New DataSet






    Private Sub frmCommandes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Controls.Add(New Header(Me, True))
        bd.ConnectionString = "Server=localhost; DataBase=bd_application;UId=root;Pwd=; Convert Zero Datetime=true; Allow Zero DateTime=true;"
        chargerDataset()
        remplirListView()
        dtpDate.Visible = False
        txtRecherche.Enabled = False


        Me.WindowState = FormWindowState.Maximized

    End Sub
    Private Sub centrer() Handles MyBase.GotFocus
        Me.Location = New Point(CInt((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Me.Width / 2)), CInt((Screen.PrimaryScreen.WorkingArea.Height / 2) - (Me.Height / 2)))
        AutoScroll = True
        Text = "Commandes"
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
            coll(2) = "50$"



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

        btnSupprimer.Enabled = False
        btnModifier.Enabled = False
        txtRecherche.Text = ""
    End Sub


    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        Hide()
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
End Class