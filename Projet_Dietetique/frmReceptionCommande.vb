Imports MySql.Data.MySqlClient
Imports System.Data

'Jonathan Villeneuve
Public Class frmReceptionCommande
    Dim bd As New GestionBD("Server=localhost;Database=bd_application;Uid=root;Pwd=;")

    Private Sub frmReceptionCommande_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Controls.Add(New Header(Me, False))
        chargerDataset()
        remplirComboBox()
        cbReference.AutoCompleteMode = AutoCompleteMode.Append
        cbReference.DropDownStyle = ComboBoxStyle.DropDown
        cbReference.AutoCompleteSource = AutoCompleteSource.ListItems

    End Sub
    Sub chargerDataset()
        bd.Requete("Select * from commandes", bd.dsCommandes, bd.daCommandes, "commandes")

    End Sub

    'Remplit le combobox des no de référence
    Sub remplirComboBox()
        Dim ds As New DataSet

        'Pour être recue, une commande doit être envoyée
        bd.Requete("Select * from commandes where   `envoye` = 1 and `recue` = 0", ds, bd.daCommandes, "commandes")
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            cbReference.Items.Add(ds.Tables(0).Rows(i).Item(3))
        Next

    End Sub
    'Modifie la commande (met la colonne recue à 1 (True))
    Sub modifier()
        bd.nonQuery("UPDATE commandes set date_reception = '" + dtpDateReception.Value.Date + "',  recue = '1' , note_reception = '" + txtReception.Text + "' where no_reference = '" + cbReference.Text + "'")
        bd.miseAjourBD(bd.dsCommandes, bd.daCommandes, "commandes")

    End Sub
    Private Sub btnReception_Click(sender As Object, e As EventArgs) Handles btnReception.Click
        modifier()

    End Sub

    Private Sub cbReference_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbReference.SelectedIndexChanged
        Dim ds2 As New DataSet
        bd.Requete("Select * from commandes where no_reference = '" + cbReference.Text + "'", ds2, bd.daCommandes, "commandes")
        dtpDateReception.MinDate = ds2.Tables(0).Rows(0).Item(1)

    End Sub
End Class