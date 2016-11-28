Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmAgenda

    Dim bd As New GestionBD("Server=localhost;Database=bd_application;Uid=root;Pwd=;")
    Private Sub frmAgenda_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        Controls.Add(New Header(Me, True))
        Me.BackColor = Color.White
        chargerComboBox()

        DateTimePicker1.Value = New DateTime(Today.Year, Today.Month, 1)
        DateTimePicker2.Value = DateTimePicker1.Value.AddMonths(1).AddDays(-1)

        updateList(DateTimePicker1.Value, DateTimePicker2.Value)
    End Sub

    Private Sub frmInventaire_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Dim messages = File.ReadAllText("index.html")

        dpFinAffichage.MinDate = Date.Today

        remplirListViewMessage()


    End Sub

    Private Sub ListView1_ColumnWidthChanging(ByVal Sender As Object _
, ByVal E As System.Windows.Forms.ColumnWidthChangingEventArgs) Handles ListView2.ColumnWidthChanging
        Try
            Dim DisableColumn As Integer = 0
            If E.ColumnIndex = DisableColumn Then
                E.Cancel = True
                E.NewWidth = ListView2.Columns(DisableColumn).Width
            End If
        Catch exc As Exception : End Try
    End Sub


    Private Sub remplirListViewMessage()
        ListView1.Items.Clear()
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter

        bd.miseAjourDS(ds, da, "select * from messages", 0)

        For Each r As DataRow In ds.Tables(0).Rows
            ListView1.Items.Add(r.Item(1))
            ListView1.Items(ListView1.Items.Count - 1).Tag = r.Item(0)
        Next

    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        Dim type As Integer = 0


        Dim r(4) As RadioButton
        r(0) = rbtype1
        r(1) = rbtype2
        r(2) = rbtype3
        r(3) = rbtype4
        For i As Integer = 0 To 3
            If r(i).Checked Then
                type = CInt(r(i).Tag)
            End If
        Next


        If Not (txtNomEvenement.Text = "" Or type = 0) Then
            ajouterEvenement(type, dt_date_evenement.Value, txtNomEvenement.Text)

            dt_date_evenement.Value = Date.Today
            txtNomEvenement.Text = ""
        Else
            MsgBox("Veuillez remplir tous les champs correctement")
        End If
        updateList(DateTimePicker1.Value, DateTimePicker2.Value)
    End Sub

    'Cette méthode a été créée dans le but d'être réutilisée par les différentes parties de l'application dans le but d'ajouter des évènements
    'dans la base de données
    Public Sub ajouterEvenement(type As Integer, _date As Date, nom_evenement As String)

        Dim ds = New DataSet
        Dim da = New MySqlDataAdapter
        bd.miseAjourDS(ds, da, "select * from evenements", 0)

        Dim dr As DataRow = ds.Tables(0).NewRow()
        dr(1) = nom_evenement
        dr(2) = _date
        dr(3) = type & ".png"
        If (CheckBox1.Checked) Then
            dr(4) = cbRecettes.SelectedValue
        End If

        ds.Tables(0).Rows.Add(dr)
        bd.miseAjourBD(ds, da, 0)

    End Sub

    Private Sub chargerComboBox()

        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter()
        bd.miseAjourDS(ds, da, "select id_recette, nom from recettes", 0)



        Dim dt As DataTable = ds.Tables(0)
        cbRecettes.DataSource = dt
        cbRecettes.DisplayMember = "nom"
        cbRecettes.ValueMember = "id_recette"

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            Button2.Visible = True
        Else Button2.Visible = False
        End If
    End Sub

    Private Sub btnEnregistrerMessage_Click(sender As Object, e As EventArgs) Handles btnEnregistrerMessage.Click

        If Not txtMessage.Text = "" And Not TxtTitreMessage.Text = "" Then
            Dim ds = New DataSet
            Dim da = New MySqlDataAdapter
            bd.miseAjourDS(ds, da, "select * from messages", 0)

            Dim dr As DataRow = ds.Tables(0).NewRow
            dr(1) = TxtTitreMessage.Text
            dr(2) = txtMessage.Text
            If cbPeriodeAffichage.Checked Then
                dr(3) = dpDebutAffichage.Value
                dr(4) = dpFinAffichage.Value
            Else
                Dim d As DateTime = DateTime.Today
                d.AddYears(2000)

                Dim d1 = d
                d.AddYears(-1000)
                dr(3) = d1
                dr(4) = d
            End If
            ds.Tables(0).Rows.Add(dr)

            bd.miseAjourBD(ds, da, 0)

            txtMessage.Text = ""
            TxtTitreMessage.Text = ""
            frmAccueil.remplirIndexHtml()

            MsgBox("Message enregistré")
            remplirListViewMessage()
        ElseIf txtMessage.Text = "" Then
            MsgBox("Veuillez composer un message")
        Else
            MsgBox("Veuillez entrer un titre")
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbPeriodeAffichage.CheckedChanged

        Dim cb As CheckBox = sender
        GroupBox1.Visible = cb.Checked

        If Not cb.Checked Then
            btnEnregistrerMessage.Location = New Point(btnEnregistrerMessage.Location.X, 214)
            GroupBox5.Height = 255
            GroupBox4.Height = 290
        Else
            btnEnregistrerMessage.Location = New Point(btnEnregistrerMessage.Location.X, cbPeriodeAffichage.Location.Y + 135)
            GroupBox5.Height = 370
            GroupBox4.Height = 408

        End If

    End Sub

    Private Sub dpDebutAffichage_ValueChanged(sender As Object, e As EventArgs) Handles dpDebutAffichage.ValueChanged
        dpFinAffichage.MinDate = dpDebutAffichage.Value
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each i As ListViewItem In ListView1.SelectedItems
            bd.nonQuery("delete from messages where id ='" & i.Tag & "'")
        Next
        remplirListViewMessage()
        frmAccueil.remplirIndexHtml()

    End Sub


    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim cb As CheckBox = sender
        cbRecettes.Visible = cb.Checked
        If cb.Checked Then
            btnAjouter.Location = New Point(btnAjouter.Location.X, btnAjouter.Location.Y + 30)
        Else
            btnAjouter.Location = New Point(btnAjouter.Location.X, btnAjouter.Location.Y - 30)

        End If


    End Sub


    Public Function getTextFieldSafeValue(ByVal txt As TextBox) As String
        Return txt.Text.Replace("'", "''")
    End Function



    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged, DateTimePicker2.ValueChanged
        updateList(DateTimePicker1.Value, DateTimePicker2.Value)
    End Sub

    Private Sub aa(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker2.MinDate = DateTimePicker1.Value

    End Sub

    Private Sub a(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        DateTimePicker1.MaxDate = DateTimePicker2.Value

    End Sub
    Private Sub updateList(debut As Date, fin As Date)

        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim strDebut As String = debut.ToShortDateString
        Dim strFin As String = fin.ToShortDateString

        bd.miseAjourDS(ds, da, "select id_evenement, nom_evenement from evenements where '" & strDebut & "'<=date_evenement and '" & strFin & "'>=date_evenement", 0)
        ListView2.Items.Clear()



        For Each dr As DataRow In ds.Tables(0).Rows
            Dim lvi As New ListViewItem(dr.Item(0).ToString)

            lvi.SubItems.Add(dr.Item(1))

            ListView2.Items.Add(lvi)
        Next

    End Sub

    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView2.SelectedIndexChanged
        If ListView2.SelectedItems.Count >= 1 Then
            btnSupprimerEvemement.Visible = True
        Else
            btnSupprimerEvemement.Visible = False
        End If
    End Sub

    Private Sub btnSupprimerEvemement_Click(sender As Object, e As EventArgs) Handles btnSupprimerEvemement.Click
        For Each i As ListViewItem In ListView2.SelectedItems

            bd.nonQuery("delete from evenements where id_evenement = " & i.SubItems(0).Text)

        Next
        updateList(DateTimePicker1.Value, DateTimePicker2.Value)
    End Sub

End Class