
Public Class frmAjoutInventaire
    Dim bd As New GestionBD("Server=localhost;Database=bd_application;Uid=root;Pwd=;")

    Private Sub frmAjoutInventaire_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TopMost = True

        Controls.Add(New Header(Me, False))
        bd.ConnectionString = "Server=localhost; DataBase=bd_application;UId=root;Pwd=; Convert Zero Datetime=true; Allow Zero DateTime=true;"
        bd.dsInventaire.Clear()
        bd.Requete("select * from inventaire", bd.dsInventaire, bd.daInventaire, "inventaire")

        bd.dsProduits.Clear()
        bd.Requete("Select * from produits order by nom_produit", bd.dsProduits, bd.daProduits, "produits")
        cmbProduit.DataSource = bd.dsProduits.Tables(0)
        cmbProduit.ValueMember = bd.dsProduits.Tables(0).Columns(0).ToString
        cmbProduit.DisplayMember = bd.dsProduits.Tables(0).Columns(1).ToString

        cmbProduit.AutoCompleteMode = AutoCompleteMode.Append
        cmbProduit.DropDownStyle = ComboBoxStyle.DropDown
        cmbProduit.AutoCompleteSource = AutoCompleteSource.ListItems


        For i As Integer = 0 To bd.uniteMesure.length - 1
            cmbUnite.Items.Add(bd.uniteMesure(i))
        Next

        For i As Integer = 0 To bd.equivalence.length - 1
            cmbEquivalence.Items.Add(bd.equivalence(i))
        Next

        cmbUnite.Text = bd.uniteMesure(0).ToString
        cmbEquivalence.Text = bd.equivalence(0).ToString

        dtpPeremption.MinDate = Today
        lblEquivalence.Visible = False
        txtEquivalence.Visible = False
        cmbEquivalence.Visible = False



    End Sub


    Private Sub kek() Handles MyBase.Shown
        Dim r As Rectangle
        If Parent IsNot Nothing Then
            r = Parent.RectangleToScreen(Parent.ClientRectangle)
        Else
            r = Screen.FromPoint(Me.Location).WorkingArea
        End If

        Dim x = r.Left + (r.Width - Me.Width) \ 2 + 10
        Dim y = r.Top + (r.Height - Me.Height) \ 2
        Me.Location = New Point(x, y)
    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        Dim drnouvel As DataRow
        drnouvel = bd.dsInventaire.Tables(0).NewRow()
        drnouvel(1) = cmbProduit.SelectedValue
        drnouvel(2) = txtNom.Text
        drnouvel(3) = txtQuantite.Text
        drnouvel(4) = txtFormat.Text
        drnouvel(5) = txtDescription.Text
        drnouvel(6) = dtpPeremption.Value
        drnouvel(7) = dtpReception.Value

        If txtEquivalence.Text IsNot "" Then
            drnouvel(8) = txtEquivalence.Text
            drnouvel(9) = cmbEquivalence.Text
        End If


        drnouvel(10) = cmbUnite.Text
        drnouvel(11) = txtTotal.Text
        bd.dsInventaire.Tables(0).Rows.Add(drnouvel)

        bd.miseAjourBD(bd.dsInventaire, bd.daInventaire, "inventaire")

        effacerText()
        Me.Close()
        frmInventaire.init()
        frmInventaire.Show()
    End Sub

    Sub effacerText()
        For Each element In Controls
            If TypeOf (element) IsNot Label And TypeOf (element) IsNot Button Then
                element.resetText
            End If
        Next
    End Sub

    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        effacerText()
        Me.Close()
        frmInventaire.Show()
    End Sub

    Private Sub cmbFormat_KeyDown(sender As Object, e As Object) Handles cmbUnite.KeyDown, cmbUnite.KeyPress
        e.Handled = True
    End Sub



    Private Sub cmbFormat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUnite.SelectedIndexChanged
        If cmbUnite.Text = "Unité" Then
            lblEquivalence.Visible = True
            txtEquivalence.Visible = True
            cmbEquivalence.Visible = True


        Else
            lblEquivalence.Visible = False
            txtEquivalence.Visible = False
            cmbEquivalence.Visible = False
        End If

        lblTotal.Text = cmbUnite.Text
    End Sub




    Private Sub txtFormat_TextChanged(sender As Object, e As EventArgs) Handles txtFormat.TextChanged, txtQuantite.TextChanged
        Try
            If txtQuantite.Text >= 1 And txtFormat.Text >= 1 Then
                txtTotal.Text = txtQuantite.Text * txtFormat.Text
            End If
        Catch exc As Exception : End Try
    End Sub
End Class

