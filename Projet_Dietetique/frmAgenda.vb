﻿Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmAgenda

    Dim bd As New GestionBD("Server=localhost;Database=bd_application;Uid=root;Pwd=;")
    Private Sub frmAgenda_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        Controls.Add(New Header(Me, True))
        Me.BackColor = Color.White
    End Sub

    Private Sub frmInventaire_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Dim messages = File.ReadAllText("index.html")
        MsgBox(messages)
        dpFinAffichage.MinDate = Date.Today

        remplirListViewMessage()


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

        ajouterEvenement(type, dt_date_evenement.Value, txtNomEvenement.Text)

        dt_date_evenement.Value = Date.Today
        txtNomEvenement.Text = ""


    End Sub

    Public Sub ajouterEvenement(type As Integer, _date As Date, nom_evenement As String)

        Dim ds = New DataSet
        Dim da = New MySqlDataAdapter
        bd.miseAjourDS(ds, da, "select * from evenements", 0)

        Dim dr As DataRow = ds.Tables(0).NewRow()
        dr(1) = nom_evenement
        dr(2) = _date
        dr(3) = type & ".png"
        ds.Tables(0).Rows.Add(dr)
        bd.miseAjourBD(ds, da, 0)

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
            btnEnregistrerMessage.Location = New Point(btnEnregistrerMessage.Location.X, cbPeriodeAffichage.Location.Y + 25)
        Else
            btnEnregistrerMessage.Location = New Point(btnEnregistrerMessage.Location.X, cbPeriodeAffichage.Location.Y + 150)
        End If

    End Sub

    Private Sub dpDebutAffichage_ValueChanged(sender As Object, e As EventArgs) Handles dpDebutAffichage.ValueChanged
        dpFinAffichage.MinDate = dpDebutAffichage.Value
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each i As ListViewItem In ListView1.SelectedItems
            bd.nonQuery("delete from messages where id ='" & i.Tag & "'")
        Next
        remplirListViewMessage()
        frmAccueil.remplirIndexHtml()

    End Sub

    Private Sub refresh_click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class