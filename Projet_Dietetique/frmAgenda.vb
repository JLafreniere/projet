Imports System.IO
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

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedItems.Count > 0 Then
            Button2.Visible = True
        Else Button2.Visible = False
        End If
    End Sub
End Class