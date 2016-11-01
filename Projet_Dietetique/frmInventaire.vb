Public Class frmInventaire
    Dim bd As New GestionBD("Server=localhost;Database=bd_application;Uid=root;Pwd=;")
    Dim no As Integer = 0
    Dim flag As Boolean = False
    Private Sub frmInventaire_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bd.ConnectionString = "Server=localhost; DataBase=bd_application;UId=root;Pwd=; Convert Zero Datetime=true; Allow Zero DateTime=true;"
        Controls.Add(New Header(Me, True))


        Dim refresh As New PictureBox()
        refresh.SetBounds(btnAjouter.Location.X + btnAjouter.Width + 13, btnAjouter.Location.Y - 3, 40, 40)
        refresh.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "imagesBoutons\refresh.png")
        refresh.SizeMode = PictureBoxSizeMode.StretchImage
        Controls.Add(refresh)

        AddHandler refresh.Click, Sub(sender2, eventargs2)
                                      If btnDGV.Text = "Grille" Then
                                          gbInventaire.Visible = False
                                          txtRechercher.ResetText()
                                          bd.dsProduits.Clear()
                                          remplircontroles()

                                      Else
                                          Dim dsTemp As New DataSet

                                          dsTemp.Clear()
                                          bd.Requete("select nom, inventaire.quantite, concat(inventaire.format, ' ' , inventaire.unite) as Format, concat(inventaire.Equivalence, ' ' , inventaire.unite_Equivalence) as 'Equivalence/unite', concat(inventaire.total, ' ', inventaire.unite) as 'Total Restant' ,inventaire.description, nom_produit as Produit, nom_categorie as Categorie, date_reception as Reception, peremption as Peremption, upc from inventaire, produits, categories where inventaire.produit = produits.id_produit and produits.categorie = categories.id_categorie order by nom", dsTemp, bd.daInventaire, "inventaire")
                                          dgvData.DataSource = dsTemp.Tables(0)
                                          txtRechercher.ResetText()
                                      End If

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
        init()
    End Sub


    Public Sub init()
        remplircontroles()
        couleurBouton("D", btnEnregistrer)
        lblEquivalence.Visible = False
        txtEquivalence.Visible = False
        lblUniteEquivalence.Visible = False
        Dim dsTemp As New DataSet

        dsTemp.Clear()
        bd.Requete("select nom, inventaire.quantite, concat(inventaire.format, ' ' , inventaire.unite) as Format, concat(inventaire.Equivalence, ' ' , inventaire.unite_Equivalence) as 'Equivalence/unite', concat(inventaire.total, ' ', inventaire.unite) as 'Total Restant' ,inventaire.description, nom_produit as Produit, nom_categorie as Categorie, date_reception as Reception, peremption as Peremption, upc from inventaire, produits, categories where inventaire.produit = produits.id_produit and produits.categorie = categories.id_categorie order by nom", dsTemp, bd.daInventaire, "inventaire")

        dgvData.DataSource = dsTemp.Tables(0)

        'The node are 30 pixel height
        TreeView1.ItemHeight = 28 + 2 * Math.Cos(90)
        'Dont use the Expand/colapse boxes
        TreeView1.ShowPlusMinus = False
        'We will draw the node ourself
        TreeView1.DrawMode = TreeViewDrawMode.OwnerDrawAll
    End Sub

    Sub couleurBouton(etat As String, b As Button)
        If etat = "D" Then
            b.BackColor = (Color.LightGray)
            b.ForeColor = Color.White
            b.Enabled = False

        Else
            b.BackColor = Color.FromArgb(0, 176, 240)
            b.Enabled = True
        End If
    End Sub


    Sub remplircontroles() 'Remplit le treeview avec la BD
        flag = False
        TreeView1.Hide()
        TreeView1.Nodes.Clear()

        bd.dsCategories.Clear()
        bd.dsProduits.Clear()
        bd.dsInventaire.Clear()



        bd.Requete("select * from categories order by Nom_Categorie", bd.dsCategories, bd.daCategories, "categories")
        bd.Requete("select * from produits order by Nom_Produit", bd.dsProduits, bd.daProduits, "produits")
        bd.Requete("select * from inventaire order by Nom", bd.dsInventaire, bd.daInventaire, "inventaire")

        'bd.Requete("select * from categories", bd.dsCategories, bd.daCategories, "categories")
        'bd.Requete("select * from produits", bd.dsProduits, bd.daProduits, "produits")
        'bd.Requete("select * from inventaire", bd.dsInventaire, bd.daInventaire, "inventaire")

        Dim ctr As Integer = 0
        Dim ctr2 As Integer = 0

        TreeView1.BeginUpdate()
        For i As Integer = 0 To bd.dsCategories.Tables(0).Rows.Count - 1
            TreeView1.Nodes.Add(New TreeNode(bd.dsCategories.Tables(0).Rows(i).Item(1)))

            For j As Integer = 0 To bd.dsProduits.Tables(0).Rows.Count - 1
                If bd.dsCategories.Tables(0).Rows(i).Item(0) = bd.dsProduits.Tables(0).Rows(j).Item(2) Then


                    TreeView1.Nodes(i).Nodes.Add(New TreeNode(bd.dsProduits.Tables(0).Rows(j).Item(1) & " [Total : " & calcul(bd.dsProduits.Tables(0).Rows(j).Item(0)) & "]"))
                    ctr += 1

                    For k As Integer = 0 To bd.dsInventaire.Tables(0).Rows.Count - 1
                        If bd.dsProduits.Tables(0).Rows(j).Item(0) = bd.dsInventaire.Tables(0).Rows(k).Item(1) Then
                            TreeView1.Nodes(i).Nodes(ctr - 1).Nodes.Add(New TreeNode(bd.dsInventaire.Tables(0).Rows(k).Item(2) &
                            " [Quantité : " & bd.dsInventaire.Tables(0).Rows(k).Item(11) & " " & bd.dsInventaire.Tables(0).Rows(k).Item(10) & "]"))
                            ctr2 += 1
                            TreeView1.Nodes(i).Nodes(ctr - 1).Nodes(ctr2 - 1).Tag = bd.dsInventaire.Tables(0).Rows(k).Item(0)
                        End If
                    Next
                    ctr2 = 0
                End If
            Next
            ctr = 0
        Next
        TreeView1.EndUpdate()
        TreeView1.Show()

    End Sub

    Private Sub TreeView1_DrawNode(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawTreeNodeEventArgs) Handles TreeView1.DrawNode
        Dim NodeBaseColor As Color
        Dim NodeTextColor As SolidBrush
        If e.Node.Level = 0 Then
            NodeBaseColor = Color.FromArgb(0, 176, 240)
            NodeTextColor = New SolidBrush(Color.White)
        ElseIf e.Node.Level = 1 Then
            NodeBaseColor = Color.SkyBlue
            NodeTextColor = New SolidBrush(Color.White)
        Else
            NodeBaseColor = Color.AliceBlue
            NodeTextColor = New SolidBrush(Color.Black)
        End If
        'Draw the background
        Try
            Dim Brush = New Drawing2D.LinearGradientBrush(e.Bounds.Location, New Point(e.Bounds.X, e.Bounds.Y + e.Bounds.Height), NodeBaseColor, NodeBaseColor)
            e.Graphics.FillRectangle(Brush, New Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height - 1))

        Catch exc As Exception : End Try
        '        e.Graphics.FillRectangle(Brush, New Rectangle(0, 0, e.Bounds.X + 1, e.Bounds.Height))



        'Draw the text
        Dim Ident As Integer = 3 + e.Node.Level * 20
        e.Graphics.DrawString(e.Node.Text, New Font("Segoe UI", 12, FontStyle.Regular), NodeTextColor, e.Bounds.Location + New Size(Ident, 3))
    End Sub
    ' Expand or colapse when the node is click
    Private Sub TreeView1_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        If e.Node.IsExpanded Then
            e.Node.Collapse()
        Else
            e.Node.Expand()
        End If


        If flag = False Then
            If e.Node.Level = 2 Then
                information(e.Node.Tag)
                no = e.Node.Tag

            Else
                gbInventaire.Visible = False
            End If
        End If

        If flag = True Then
            If e.Node.Level = 0 Then
                information(e.Node.Tag)
                no = e.Node.Tag

            Else
                gbInventaire.Visible = False
            End If
        End If

    End Sub


    Sub information(ByVal id As String)
        gbInventaire.Visible = True


        Dim dsRequete As New DataSet
        bd.Requete("select * from inventaire where id_inventaire = '" & id & "';", dsRequete, bd.daInventaire, "inventaire")

        txtNom.Text = dsRequete.Tables(0).Rows(0).Item(2).ToString

        txtQuantite.Text = dsRequete.Tables(0).Rows(0).Item(3).ToString

        txtFormat.Text = dsRequete.Tables(0).Rows(0).Item(4).ToString

        lblUnite.Text = dsRequete.Tables(0).Rows(0).Item(10).ToString

        txtDescription.Text = dsRequete.Tables(0).Rows(0).Item(5).ToString

        dtpPeremption.Value = dsRequete.Tables(0).Rows(0).Item(6)

        dtpReception.Value = dsRequete.Tables(0).Rows(0).Item(7)

        txtEquivalence.Text = dsRequete.Tables(0).Rows(0).Item(8).ToString

        lblUniteEquivalence.Text = dsRequete.Tables(0).Rows(0).Item(9).ToString

        txtTotal.Text = dsRequete.Tables(0).Rows(0).Item(11).ToString

        lblTotal.Text = lblUnite.Text



        If lblUnite.Text = "Unité" Then
            lblEquivalence.Visible = True
            txtEquivalence.Visible = True
            lblUniteEquivalence.Visible = True
        Else
            lblEquivalence.Visible = False
            txtEquivalence.Visible = False
            lblUniteEquivalence.Visible = False
        End If
        couleurBouton("D", btnEnregistrer)
    End Sub

    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        lblEquivalence.Visible = False
        txtEquivalence.Visible = False
        lblUniteEquivalence.Visible = False
        gbInventaire.Visible = False
        TreeView1.SelectedNode = Nothing
    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        lblEquivalence.Visible = False
        txtEquivalence.Visible = False
        lblUniteEquivalence.Visible = False
        gbInventaire.Visible = False

        frmAjoutInventaire.Show()
    End Sub

    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        Try
            If MsgBox("Voulez-vous supprimer : " & txtNom.Text & " de l'inventaire ?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
                bd.nonQuery("delete from inventaire where id_inventaire = " & no)

                'bd.miseAjourBD(bd.dsInventaire, bd.daInventaire, "inventaire")
                remplircontroles()
            End If

            btnAnnuler.PerformClick()


        Catch exc As Exception : MsgBox("Veuillez supprimer tous les produits en inventaire avant de procéder à l'opération ") : End Try
    End Sub

    Sub Modifier() 'modifie le nom d'un produit

        bd.dsInventaire.Clear()
        bd.Requete("select * from inventaire where id_inventaire = " & no, bd.dsInventaire, bd.daInventaire, "inventaire")

        bd.dsInventaire.Tables(0).Rows(0).Item(2) = txtNom.Text
        bd.dsInventaire.Tables(0).Rows(0).Item(3) = txtQuantite.Text
        bd.dsInventaire.Tables(0).Rows(0).Item(4) = txtFormat.Text
        bd.dsInventaire.Tables(0).Rows(0).Item(5) = txtDescription.Text
        bd.dsInventaire.Tables(0).Rows(0).Item(6) = dtpPeremption.Value
        bd.dsInventaire.Tables(0).Rows(0).Item(7) = dtpReception.Value
        bd.dsInventaire.Tables(0).Rows(0).Item(9) = lblUniteEquivalence.Text
        bd.dsInventaire.Tables(0).Rows(0).Item(10) = lblUnite.Text
        bd.dsInventaire.Tables(0).Rows(0).Item(11) = txtTotal.Text

        bd.miseAjourBD(bd.dsInventaire, bd.daInventaire, "inventaire")
        remplircontroles()

    End Sub

    Private Sub txtNom_TextChanged(sender As Object, e As EventArgs) Handles txtNom.TextChanged, txtEquivalence.TextChanged, txtQuantite.TextChanged, txtDescription.TextChanged, dtpPeremption.TextChanged, dtpReception.TextChanged, txtFormat.TextChanged
        couleurBouton("E", btnEnregistrer)
    End Sub

    Private Sub btnEnregistrer_Click(sender As Object, e As EventArgs) Handles btnEnregistrer.Click
        Modifier()
        lblEquivalence.Visible = False
        txtEquivalence.Visible = False
        lblUniteEquivalence.Visible = False
        gbInventaire.Visible = False
    End Sub

    Function calcul(ByVal id As String)
        'pour chaque produit
        'regarder tout les entrés
        'si c'est ml / L calculer en L
        'si c'est g / Kg, calculer en KG
        'ajouter les unité comme ca + valeur selon équivalence

        Dim total As Double = 0
        Dim str As String = ""

        'bd.Requete("select * from categories", bd.dsCategories, bd.daCategories, "categories")
        'bd.Requete("select * from produits", bd.dsProduits, bd.daProduits, "produits")
        'bd.Requete("select * from inventaire", bd.dsInventaire, bd.daInventaire, "inventaire")

        bd.dsInventaire.Clear()
        bd.Requete("select * from inventaire where produit = " & id, bd.dsInventaire, bd.daInventaire, "inventaire")
        For Each rows As DataRow In bd.dsInventaire.Tables(0).Rows

            If rows.Item(10).ToString = "Unité" Then
                If rows.Item(9).ToString = "g" Then
                    total += ((rows.Item(8).ToString() / 1000) * rows.Item(11).ToString())
                    str = "kg"

                ElseIf rows.Item(9).ToString = "lbs" Then
                    total += ((rows.Item(8).ToString() * 0.45359237) * rows.Item(11).ToString())
                    str = "kg"

                ElseIf rows.Item(9).ToString = "ml" Then
                    total += ((rows.Item(8).ToString() / 1000) * rows.Item(11).ToString())
                    str = "L"

                ElseIf rows.Item(9).ToString = "kg" Then
                    total += ((rows.Item(8).ToString()) * rows.Item(11).ToString())
                    str = "kg"

                ElseIf rows.Item(9).ToString = "L" Then
                    total += ((rows.Item(8).ToString()) * rows.Item(11).ToString())
                    str = "L"
                End If

            Else
                If rows.Item(10).ToString = "g" Then
                    total += (rows.Item(11).ToString() / 1000)
                    str = "kg"

                ElseIf rows.Item(10).ToString = "lbs" Then
                    total += (rows.Item(11).ToString() * 0.45359237)
                    str = "kg"

                ElseIf rows.Item(10).ToString = "ml" Then
                    total += (rows.Item(11).ToString() / 1000)
                    str = "L"
                End If

                If rows.Item(10).ToString = "kg" Then
                    total += rows.Item(11).ToString()
                    str = "kg"
                End If

                If rows.Item(10).ToString = "L" Then
                    total += rows.Item(11).ToString()
                    str = "L"
                End If
            End If



        Next



        str = (Decimal.Round(total, 2, MidpointRounding.AwayFromZero) & " " & str)
        Return str

    End Function

    Private Sub txtFormat_TextChanged(sender As Object, e As EventArgs) Handles txtFormat.TextChanged, txtQuantite.TextChanged
        Try
            txtTotal.Text = txtQuantite.Text * txtFormat.Text
        Catch exc As Exception : End Try
    End Sub

    Sub recherche()
        If btnDGV.Text = "Grille" Then

            TreeView1.Nodes.Clear()
            bd.dsCategories.Clear()
            bd.dsInventaire.Clear()
            bd.dsProduits.Clear()

            If txtRechercher.Text = "" Then
                remplircontroles()

            Else
                'requete pour categorie
                bd.Requete("select * from inventaire, categories, produits where upper(Nom_Categorie) like '%" & txtRechercher.Text.ToUpper & "%' and id_categorie = categorie and id_produit =  produit", bd.dsInventaire, bd.daInventaire, "inventaire")

                If bd.dsInventaire.Tables(0).Rows.Count = 0 Then
                    bd.dsInventaire.Clear()

                    'requete pour produits
                    bd.Requete("select * from inventaire, produits where upper(Nom_produit) like '%" & txtRechercher.Text.ToUpper & "%' and id_produit =  produit", bd.dsInventaire, bd.daInventaire, "inventaire")

                    If bd.dsInventaire.Tables(0).Rows.Count = 0 Then
                        bd.dsInventaire.Clear()
                        'requete pour inventaire
                        bd.Requete("select * from inventaire where upper(nom) like '%" & txtRechercher.Text.ToUpper & "%'", bd.dsInventaire, bd.daInventaire, "inventaire")


                    End If
                End If


                TreeView1.BeginUpdate()
                For i As Integer = 0 To bd.dsInventaire.Tables(0).Rows.Count - 1
                    TreeView1.Nodes.Add(New TreeNode(bd.dsInventaire.Tables(0).Rows(i).Item(2)))
                    TreeView1.Nodes(i).Tag = bd.dsInventaire.Tables(0).Rows(i).Item(0)
                Next
                TreeView1.EndUpdate()
                flag = True
            End If

        Else

            If txtRechercher.Text = "" Then
                Dim dsTemp As New DataSet
                dsTemp.Clear()
                bd.Requete("select nom, inventaire.quantite, concat(inventaire.format, ' ' , inventaire.unite) as Format, concat(inventaire.Equivalence, ' ' , inventaire.unite_Equivalence) as 'Equivalence/unite', concat(inventaire.total, ' ', inventaire.unite) as 'Total Restant' ,inventaire.description, nom_produit as Produit, nom_categorie as Categorie, date_reception as Reception, peremption as Peremption, upc from inventaire, produits, categories where inventaire.produit = produits.id_produit and produits.categorie = categories.id_categorie order by nom", dsTemp, bd.daInventaire, "inventaire")
                dgvData.DataSource = Nothing
                dgvData.DataSource = dsTemp.Tables(0)

            Else
                Dim dsTemp As New DataSet
                dsTemp.Clear()
                bd.Requete("select nom, inventaire.quantite, concat(inventaire.format, ' ' , inventaire.unite) as Format, concat(inventaire.Equivalence, ' ' , inventaire.unite_Equivalence) as 'Equivalence/unite', concat(inventaire.total, ' ', inventaire.unite) as 'Total Restant' ,inventaire.description, nom_produit as Produit, nom_categorie as Categorie, date_reception as Reception, peremption as Peremption, upc from inventaire, produits, categories where inventaire.produit = produits.id_produit and produits.categorie = categories.id_categorie and upper(inventaire.nom) like '%" & txtRechercher.Text.ToUpper & "%' order by nom", dsTemp, bd.daInventaire, "inventaire")
                dgvData.DataSource = Nothing
                dgvData.DataSource = dsTemp.Tables(0)
            End If
        End If
    End Sub

    Private Sub btnRechercher_Click(sender As Object, e As EventArgs) Handles btnRechercher.Click
        recherche()
    End Sub

    Private Sub txtRechercher_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRechercher.KeyDown
        If e.KeyCode = Keys.Enter Then
            recherche()
        End If
    End Sub



    Private Sub btnDGV_Click(sender As Object, e As EventArgs) Handles btnDGV.Click

        If btnDGV.Text = "Grille" Then
            btnDGV.Text = "Arbre"
            Dim dsTemp As New DataSet
            TreeView1.Hide()
            dsTemp.Clear()
            bd.Requete("select nom, inventaire.quantite, concat(inventaire.format, ' ' , inventaire.unite) as Format, concat(inventaire.Equivalence, ' ' , inventaire.unite_Equivalence) as 'Equivalence/unite', concat(inventaire.total, ' ', inventaire.unite) as 'Total Restant' ,inventaire.description, nom_produit as Produit, nom_categorie as Categorie, date_reception as Reception, peremption as Peremption, upc from inventaire, produits, categories where inventaire.produit = produits.id_produit and produits.categorie = categories.id_categorie order by nom", dsTemp, bd.daInventaire, "inventaire")

            dgvData.DataSource = dsTemp.Tables(0)
            dgvData.Visible = True
            dgvData.RowHeadersVisible = False

        Else
            TreeView1.Show()
            btnDGV.Text = "Grille"
            dgvData.Visible = False
        End If


    End Sub

    Private Sub txtRechercher_TextChanged(sender As Object, e As EventArgs) Handles txtRechercher.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub dtpReception_ValueChanged(sender As Object, e As EventArgs) Handles dtpReception.ValueChanged

    End Sub

    Private Sub dtpPeremption_ValueChanged(sender As Object, e As EventArgs) Handles dtpPeremption.ValueChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub lblUnite_Click(sender As Object, e As EventArgs) Handles lblUnite.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub lblTotal_Click(sender As Object, e As EventArgs) Handles lblTotal.Click

    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub lblUniteEquivalence_Click(sender As Object, e As EventArgs) Handles lblUniteEquivalence.Click

    End Sub

    Private Sub lblEquivalence_Click(sender As Object, e As EventArgs) Handles lblEquivalence.Click

    End Sub

    Private Sub dgvData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick

    End Sub

    Private Sub gbInventaire_Enter(sender As Object, e As EventArgs) Handles gbInventaire.Enter

    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect

    End Sub
End Class