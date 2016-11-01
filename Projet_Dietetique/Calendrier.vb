Imports MySql.Data.MySqlClient

Public Class Calendrier
    Inherits Panel


    Dim ds As New DataSet
    Dim da As New MySqlDataAdapter
    Dim bd As New GestionBD("Server=localhost;Database=bd_application;Uid=root;Pwd=;")
    Dim lblAnneeMois As New Label
    Public mc As PanelMois
    Dim btnMoisPrecedent, btnMoisSuivant As Button

    Public Sub New(x As Integer, y As Integer, width As Integer, height As Integer, dateDebut As Date)
        DoubleBuffered = True
        SetBounds(x, y, width, height - 40)

        btnMoisPrecedent = New Button()
        btnMoisSuivant = New Button()

        With btnMoisSuivant
            .BackColor = Color.FromArgb(0, 176, 240)
            .FlatStyle = FlatStyle.Flat
            .ForeColor = Color.White
            .Font = New Font("Segoe UI", 14.25, FontStyle.Bold)
            .Text = ">>"
            .SetBounds((3 * width) / 4 - 50, 0, 100, 40)
            .UseVisualStyleBackColor = True
        End With

        With btnMoisPrecedent
            .FlatStyle = FlatStyle.Flat
            .BackColor = Color.FromArgb(0, 176, 240)
            .Text = "<<"
            .Font = New Font("Segoe UI", 14.25, FontStyle.Bold)
            .TextAlign = ContentAlignment.TopCenter
            .SetBounds(width / 4 - 50, 0, 100, 40)
            .ForeColor = Color.White
            .UseVisualStyleBackColor = True
        End With


        AddHandler btnMoisPrecedent.Click, Sub(sender2, eventargs2)
                                               mc.setDate(mc._date.AddMonths(-3))
                                               changerMois()
                                           End Sub

        AddHandler btnMoisSuivant.Click, Sub(sender3, eventargs3)
                                             mc.setDate(mc._date.AddMonths(-1))
                                             changerMois()
                                         End Sub

        Controls.Add(btnMoisSuivant)
        Controls.Add(btnMoisPrecedent)
        actualiserComposants()

    End Sub

    Private Sub changerMois()

        ajouterNotifications()
        frmAccueil.changerDateSelectionnee(mc._date)
        actualiserComposants()
    End Sub

    Public Sub ajouterEvenementJour(ByVal evenement As String, ByVal jourEvenement As Integer, icone As String)
        mc.ajouterEvenement(jourEvenement, evenement, icone)
    End Sub

    Public Sub actualiserComposants()

        Controls.Remove(mc)

        mc = New PanelMois(0, 50, Width, Height - 100, frmAccueil._date_selectionne)

        mc.setDate(frmAccueil._date_selectionne)
        With lblAnneeMois
            .Font = New Font("Segoe UI", 14.25)
            If frmAccueil._date_selectionne.Month = 12 Then
                .Text = StrConv(MonthName(frmAccueil._date_selectionne.Month) & " " & mc._date.Year - 1, VbStrConv.ProperCase)
            Else
                .Text = StrConv(MonthName(frmAccueil._date_selectionne.Month) & " " & mc._date.Year, VbStrConv.ProperCase)
            End If

            .AutoSize = False
            .SetBounds(225, 5, 250, 30)
            .TextAlign = ContentAlignment.MiddleCenter
        End With


        mc.lbl.Text = MonthName(mc._date.Month)
        Controls.Add(lblAnneeMois)
        ajouterNotifications()
        Controls.Add(mc)

    End Sub

    Private Sub ajouterNotifications()

        Dim mois As String = "00"
        Dim annee As String = Split(lblAnneeMois.Text, " ")(1)
        Select Case Split(lblAnneeMois.Text, " ")(0)
            Case "Janvier", "January"
                mois = "01"
            Case "Février", "February"
                mois = "02"
            Case "Mars", "March"
                mois = "03"
            Case "Avril", "April"
                mois = "04"
            Case "Mai", "May"
                mois = "05"
            Case "Juin", "June"
                mois = "06"
            Case "Juillet", "July"
                mois = "07"
            Case "Août", "August"
                mois = "08"
            Case "Septembre", "September"
                mois = "09"
            Case "Octobre", "October"
                mois = "10"
            Case "Novembre", "November"
                mois = "11"
            Case "Décembre", "December"
                mois = "12"
        End Select

        ds = New DataSet


        bd.miseAjourDS(ds, da, "select * from evenements where date_evenement between '" & annee & "-" & mois & "-00' and '" & annee & "-" & mois & "-31'", 0)

        'LANGUE ANGLAISE PLANTE (MOIS/JOUR/ANNEE)


        For Each dr As DataRow In ds.Tables(0).Rows
            Dim str As String = dr(2)

            Try
                ajouterEvenementJour(dr(1), Split(str, "-")(2), dr(3))
            Catch exc As Exception
                ajouterEvenementJour(dr(1), Split(str, "-")(2), dr(3))
            End Try
        Next


    End Sub

End Class


