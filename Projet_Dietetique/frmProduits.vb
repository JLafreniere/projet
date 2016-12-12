Imports MySql.Data.MySqlClient
Public Class frmProduits

    'Fait par Francis Audet

    Dim intPosition As Integer
    Dim str, itemcoll(1) As String
    Dim bd As New GestionBD("Server=localhost;Database=bd_application;Uid=root;Pwd=;")
    Dim dsCategorie As New DataSet
    Dim daCategorie As New MySqlDataAdapter
    Dim ordre As String = "order by nom_produit"
    Private Sub frmCategories_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        'connection bd + charger dataset
        bd.ConnectionString = "Server=localhost; DataBase=bd_application;UId=root;Pwd=; Convert Zero Datetime=true; Allow Zero DateTime=true;"
        bd.Requete("Select * from produits where hidden = 0 " & ordre, bd.dsProduits, bd.daProduits, "produits")
        remplircontroles()
        Controls.Add(New Header(Me, True))

        gbModifier.Location = New Point(600, 55)
        gbAjouter.Location = New Point(600, 55)
        couleurBouton("D", btnSupprimer)

        Dim refresh As New PictureBox()

        refresh.SetBounds(513, 2, 35, 35)
        refresh.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "imagesBoutons\refresh.png")
        refresh.SizeMode = PictureBoxSizeMode.StretchImage

        'bouton refresh
        AddHandler refresh.Click, Sub(sender2, eventargs2)
                                      cacherComposantModification()
                                      CacherComposantAjout()
                                      lsvProduits.Enabled = True
                                      bd.dsProduits.Clear()
                                      bd.Requete("Select * from produits where hidden = 0 " & ordre, bd.dsProduits, bd.daProduits, "produits")
                                      remplircontroles()

                                      btnSupprimer.Enabled = False
                                      couleurBouton("D", btnSupprimer)
                                      'btnVoirModifier.Enabled = False
                                      btnVoirAjouter.Enabled = True
                                  End Sub

        AddHandler refresh.MouseEnter, Sub(sender2, eventargs2)
                                           refresh.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "imagesBoutons\refreshHover.png")
                                       End Sub
        AddHandler refresh.MouseLeave, Sub(sender2, eventargs2)
                                           refresh.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "imagesBoutons\refresh.png")
                                       End Sub
        AddHandler refresh.MouseDown, Sub(sender2, eventargs2)
                                          refresh.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "imagesBoutons\refreshDown.png")
                                      End Sub
        AddHandler refresh.MouseUp, Sub(sender2, eventargs2)
                                        refresh.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "imagesBoutons\refreshHover.png")
                                    End Sub
        Panel1.Controls.Add(refresh)



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


    Sub remplircontroles() 'Remplit le listview des produits de la BD

        lsvProduits.Items.Clear()

        Dim dsRequete As New DataSet


        For i = 0 To bd.dsProduits.Tables(0).Rows.Count - 1
            dsRequete.Clear()
            bd.Requete("select nom_categorie from categories where id_categorie = " & bd.dsProduits.Tables(0).Rows(i).Item(2), dsRequete, daCategorie, "categories")

            itemcoll(0) = bd.dsProduits.Tables(0).Rows(i)(1).ToString()
            itemcoll(1) = dsRequete.Tables(0).Rows(0)(0).ToString()
            '   itemcoll(2) = bd.dsProduits.Tables(0).Rows(i)(2).ToString()

            Dim lvi As New ListViewItem(itemcoll)
            lsvProduits.Items.Add(lvi)
        Next

    End Sub

    Sub miseAjourBD() 'Permet de faire la mise a jour 
        bd.miseAjourBD(bd.dsProduits, bd.daProduits, "produits")
    End Sub

    Sub Ajouter() 'Ajoute un nouveau produit en vérifiant si il existe déja

        Dim drnouvel As DataRow
        drnouvel = bd.dsProduits.Tables(0).NewRow()
        drnouvel(1) = txtAjouter.Text
        drnouvel(2) = cmbCategorie.SelectedValue
        If ckTaxeFederale.Checked = True Then
            drnouvel(4) = True
        Else
            drnouvel(4) = False
        End If

        If ckTaxeProvinciale.Checked = True Then
            drnouvel(5) = True
        Else
            drnouvel(5) = False
        End If

        If ckPerissable.Checked = True Then
            drnouvel(7) = True
        Else
            drnouvel(7) = False
        End If

        drnouvel(8) = txtDescription.Text
        drnouvel(9) = 0

        bd.dsProduits.Tables(0).Rows.Add(drnouvel)


    End Sub

    Private Sub exitApp() Handles MyBase.Closed
        Application.Exit()
    End Sub


    Sub Modifier() 'modifie le nom d'un produit

        bd.dsProduits.Tables(0).Rows(intPosition).Item(1) = txtModifier.Text

        If ckTaxeFederale2.Checked = True Then
            bd.dsProduits.Tables(0).Rows(intPosition).Item(4) = True
        Else
            bd.dsProduits.Tables(0).Rows(intPosition).Item(4) = False
        End If

        If ckTaxeProvinciale2.Checked = True Then
            bd.dsProduits.Tables(0).Rows(intPosition).Item(5) = True
        Else
            bd.dsProduits.Tables(0).Rows(intPosition).Item(5) = False
        End If

        If ckPerissable2.Checked = True Then
            bd.dsProduits.Tables(0).Rows(intPosition).Item(7) = True
        Else
            bd.dsProduits.Tables(0).Rows(intPosition).Item(7) = False
        End If

        bd.dsProduits.Tables(0).Rows(intPosition).Item(8) = txtDescription2.Text

        bd.dsProduits.Tables(0).Rows(intPosition).Item(2) = cmbCategorie2.SelectedValue


    End Sub

    Sub CacherComposantAjout() 'Cache les composants de l'option ajout
        gbAjouter.Visible = False
        lsvProduits.Enabled = True
    End Sub

    Private Sub btnVoirAjouter_Click(sender As Object, e As EventArgs) Handles btnVoirAjouter.Click
        'Affiche les options pour l'ajout
        lsvProduits.SelectedItems.Clear()
        gbAjouter.Visible = True
        btnSupprimer.Enabled = False
        couleurBouton("D", btnAjouter)
        couleurBouton("D", btnSupprimer) 'D = disabled
        'btnVoirModifier.Enabled = False
        lsvProduits.Enabled = False


        'Popule le combo box des categories
        dsCategorie.Clear()
        bd.Requete("Select * from categories order by Nom_Categorie ", dsCategorie, daCategorie, "produits")
        cmbCategorie.DataSource = dsCategorie.Tables(0)
        cmbCategorie.ValueMember = dsCategorie.Tables(0).Columns(0).ToString
        cmbCategorie.DisplayMember = dsCategorie.Tables(0).Columns(1).ToString

    End Sub

    Private Sub btnAnnulerAjout_Click(sender As Object, e As EventArgs) Handles btnAnnulerAjout.Click
        'annuler l'ajout
        CacherComposantAjout()
    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        'Ajout d'un nouveau produit appelant la méthode Ajouter
        Dim flag As Boolean = False
        For i As Integer = 0 To bd.dsProduits.Tables(0).Rows.Count - 1
            If (bd.dsProduits.Tables(0).Rows(i).Item(1)).ToString.ToLower = txtAjouter.Text.ToLower Then
                flag = True
            End If
        Next

        If flag Then
            MsgBox("Ce produit existe déjà")

        Else
            Ajouter()
            CacherComposantAjout()
            miseAjourBD()
            bd.dsProduits.Clear()
            bd.Requete("Select * from produits where hidden = 0 " & ordre, bd.dsProduits, bd.daProduits, "produits")
            remplircontroles()

            txtAjouter.ResetText()
            txtDescription.ResetText()
            ckPerissable.Checked = False
            ckTaxeFederale.Checked = False
            ckTaxeProvinciale.Checked = False
        End If
    End Sub

    Sub information()
        'affiche les informations d'un produit
        gbModifier.Visible = True

        txtModifier.Text = lsvProduits.FocusedItem.SubItems(0).Text

        dsCategorie.Clear()
        bd.Requete("Select * from categories order by Nom_Categorie ", dsCategorie, daCategorie, "produits")
        cmbCategorie2.DataSource = dsCategorie.Tables(0)
        cmbCategorie2.ValueMember = dsCategorie.Tables(0).Columns(0).ToString
        cmbCategorie2.DisplayMember = dsCategorie.Tables(0).Columns(1).ToString


        cmbCategorie2.Text = bd.executeScalar("select nom_categorie from categories, produits where id_categorie = produits.categorie and produits.nom_produit = '" & Replace(txtModifier.Text, "'", "''") & "';")

        Dim dsRequete As New DataSet
        bd.Requete("select * from produits where nom_produit = '" & Replace(txtModifier.Text, "'", "''") & "';", dsRequete, bd.daProduits, "produits")


        If dsRequete.Tables(0).Rows(0).Item(4) = True Then
            ckTaxeFederale2.Checked = True
        Else
            ckTaxeFederale2.Checked = False
        End If

        If dsRequete.Tables(0).Rows(0).Item(5) = True Then
            ckTaxeProvinciale2.Checked = True
        Else
            ckTaxeProvinciale2.Checked = False
        End If

        If dsRequete.Tables(0).Rows(0).Item(7) = True Then
            ckPerissable2.Checked = True
        Else
            ckPerissable2.Checked = False
        End If

        txtDescription2.Text = dsRequete.Tables(0).Rows(0).Item(8).ToString

        couleurBouton("D", btnEnregistrer)
    End Sub

    Private Sub btnVoirModifier_Click(sender As Object, e As EventArgs)
        'Affiche les options pour la modification
        information()
    End Sub
    Sub cacherComposantModification()
        'cache l'affichage du produit
        gbModifier.Visible = False
        btnVoirAjouter.Enabled = True
        btnSupprimer.Enabled = True
        couleurBouton("E", btnSupprimer) 'E=Enabled
    End Sub
    Private Sub btnAnnulerModification_Click(sender As Object, e As EventArgs) Handles btnAnnulerModification.Click
        'annule la modification
        cacherComposantModification()
        btnSupprimer.Enabled = True
        couleurBouton("E", btnSupprimer)
        btnVoirAjouter.Enabled = True
        lsvProduits.SelectedItems.Clear()
    End Sub

    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnEnregistrer.Click
        'Modification d'un produit appelant la méthode Modifier
        Modifier()
        cacherComposantModification()
        btnSupprimer.Enabled = False
        couleurBouton("D", btnSupprimer)
        miseAjourBD()
        remplircontroles()
    End Sub


    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        'Suppression d'un produit
        Try
            If MsgBox("Voulez-vous supprimer le produit : " & lsvProduits.FocusedItem.SubItems(0).Text & "?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                bd.nonQuery("update produits set hidden = 1 where id_produit = " & bd.dsProduits.Tables(0).Rows(intPosition).Item(0))

                btnSupprimer.Enabled = False
                couleurBouton("D", btnSupprimer)
                ' btnVoirModifier.Enabled = False
                bd.dsProduits.Clear()
                bd.Requete("Select * from produits where hidden = 0 " & ordre, bd.dsProduits, bd.daProduits, "produits")
                remplircontroles()
            End If

            gbModifier.Visible = False
        Catch exc As Exception : MsgBox("Veuillez supprimer tous les produits en inventaire avant de procéder à l'opération ") : End Try
    End Sub

    Private Sub BtnRechercher_Click(sender As Object, e As EventArgs) Handles btnRechercher.Click
        'Recherche par nom de produit

        cacherComposantModification()
        CacherComposantAjout()
        lsvProduits.Enabled = True
        bd.dsProduits.Clear()
        If (txtRechercher.Text = "") Then
            bd.Requete("Select * from produits where hidden = 0 order by nom_produit", bd.dsProduits, bd.daProduits, "produits")
            btnVoirAjouter.Enabled = True
        Else
            bd.Requete("Select * from produits where hidden = 0 and lower(nom_produit) like lower('" & Replace(txtRechercher.Text, "'", "''") & "%')  " & ordre, bd.dsProduits, bd.daProduits, "produits")
        End If

        remplircontroles()

        If lsvProduits.Items.Count = 0 Then
            lsvProduits.Items.Add("Aucun produit trouvé")
            ' ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
            lsvProduits.Enabled = False

            bd.Requete("Select * from produits where hidden = 0 " & ordre, bd.dsProduits, bd.daProduits, "produits")
        End If

        btnSupprimer.Enabled = False
        couleurBouton("D", btnSupprimer)

        'btnVoirModifier.Enabled = False
        txtRechercher.Text = ""
    End Sub


    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvProduits.SelectedIndexChanged
        If lsvProduits.SelectedItems.Count > 0 Then
            ' btnVoirModifier.Enabled = True
            btnSupprimer.Enabled = True
            couleurBouton("E", btnSupprimer)
            intPosition = lsvProduits.SelectedIndices(0)
            information()

        Else
            cacherComposantModification()
            CacherComposantAjout()
            btnSupprimer.Enabled = False
            couleurBouton("D", btnSupprimer)
            ' btnVoirModifier.Enabled = False
        End If
    End Sub

    Private Sub txtModifier_TextChanged(sender As Object, e As EventArgs) Handles txtModifier.TextChanged, cmbCategorie2.TextChanged, txtDescription2.TextChanged, ckPerissable2.CheckedChanged, ckTaxeFederale2.CheckedChanged, ckTaxeProvinciale2.CheckedChanged
        'Active le bouton enregistrer quand il y a modification
        If txtModifier.Text = "" Or txtModifier.Text = " " Then
            couleurBouton("D", btnEnregistrer)
        Else
            couleurBouton("E", btnEnregistrer)
        End If

    End Sub


    Private Sub ListView1_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lsvProduits.ColumnClick
        'Permet de trier la liste par colonne
        If e.Column = 0 Then
            If ordre = "order by nom_produit" Then
                ordre = "order by nom_produit desc"
            Else
                ordre = "order by nom_produit"
            End If

        ElseIf e.Column = 1 Then
            If ordre = "order by Categorie" Then
                ordre = "order by Categorie desc"
            Else
                ordre = "order by Categorie"
            End If

        End If

        bd.dsProduits.Clear()
        bd.Requete("Select * from produits where hidden = 0 " & ordre, bd.dsProduits, bd.daProduits, "produits")
        remplircontroles()
    End Sub

    Private Sub frmProduits_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtAjouter_TextChanged(sender As Object, e As EventArgs) Handles txtAjouter.TextChanged
        If txtAjouter.Text = "" Then
            couleurBouton("D", btnAjouter)
        Else
            couleurBouton("E", btnAjouter)
        End If
    End Sub

    Private Sub txtRechercher_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRechercher.KeyDown
        'recherche sur "ENTER"'
        If e.KeyCode = Keys.Enter Then
            btnRechercher.PerformClick()
        End If
    End Sub
End Class