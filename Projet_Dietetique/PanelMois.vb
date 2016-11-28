Imports System.ComponentModel
Imports System.IO
Imports System.Net

Public Class PanelMois
    Inherits Panel

    ' Par Jonathan Lafrenière
    ' Affichage d'un mois dans le calendrier


    Dim semaines(6) As PanelSemaine
    '(10, 400, 750, 125, True, True)
    'Dim s2 As New PanelSemaine(10, 525, 750, 100, True, False)
    'Dim s3 As New PanelSemaine(10, 625, 750, 100, True, False)
    'Dim s4 As New PanelSemaine(10, 725, 750, 100, True, False)
    'Dim s5 As New PanelSemaine(10, 825, 750, 100, True, False)

    Property lbl As New Label

    Public Property _date As Date

    Dim nbSemaines As Integer = 0

    Public Sub New(x As Integer, y As Integer, width As Integer, height As Integer, dateDebut As Date)

        Size = New Size(width, height)
        Me.Location = New Point(x, y)
        Dim d As Date = New Date(dateDebut.Year, dateDebut.Month, Date.DaysInMonth(dateDebut.Year, dateDebut.Month))

        setDate(d)
    End Sub

    Public Sub creerCalendrier(ByVal d As Date)
        _date = d

        Me.Controls.Clear()


        semaines(0) = New PanelSemaine(0, 0, Width, 40 + ((Height - 40) / 6), True, True)
        semaines(1) = New PanelSemaine(0, 40 + ((Height - 40) / 6), Width, ((Height - 40) / 6), False, True)
        semaines(2) = New PanelSemaine(0, 40 + 2 * ((Height - 40) / 6), Width, ((Height - 40) / 6), False, True)
        semaines(3) = New PanelSemaine(0, 40 + 3 * ((Height - 40) / 6), Width, ((Height - 40) / 6), False, True)
        semaines(4) = New PanelSemaine(0, 40 + 4 * ((Height - 40) / 6), Width, ((Height - 40) / 6), False, True)
        semaines(5) = New PanelSemaine(0, 40 + 5 * ((Height - 40) / 6), Width, ((Height - 40) / 6), False, True)
        nbSemaines = numberOfWeek(d) - 1
        For i As Integer = 0 To nbSemaines
            Me.Controls.Add(semaines(i))
        Next


        remplirJours()
    End Sub


    Public Sub setDate(ByVal d As Date)

        creerCalendrier(d)

    End Sub

    Public Function numberOfWeek(dat As Date)

        Dim DaysInMonth As Integer = Date.DaysInMonth(dat.Year, dat.Month)
        Dim datFinMois As Date = New Date(dat.Year, dat.Month, DaysInMonth)

        Dim beginningOfMonth As New DateTime(dat.Year, dat.Month, 1)

        While (datFinMois.AddDays(1).DayOfWeek <> Globalization.CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek)
            datFinMois = datFinMois.AddDays(1)
        End While

        Return (Math.Truncate((datFinMois.Subtract(beginningOfMonth).TotalDays / 7)) + 1)
    End Function


    Private Sub remplirJours()


        Dim semaine As Integer = 0
        Dim beginningOfMonth As New DateTime(_date.Year, _date.Month, 1)
        Dim moisSuivant As Integer = _date.AddMonths(1).Month

        _date = beginningOfMonth

        While (_date.AddDays(0).Month <> moisSuivant)



            Dim caseJour As Integer = 0

            Select Case _date.ToString("dddd")
                Case "dimanche", "Sunday"
                    caseJour = 0
                Case "lundi", "Monday"
                    caseJour = 1
                Case "mardi", "Tuesday"
                    caseJour = 2
                Case "mercredi", "Wednesday"
                    caseJour = 3
                Case "jeudi", "Thursday"
                    caseJour = 4
                Case "vendredi", "Friday"
                    caseJour = 5
                Case "samedi", "Saturday"
                    caseJour = 6




            End Select

            semaines(semaine).pnlJours(caseJour).
                ajouterEvenement(_date.Day)
            semaines(semaine).pnlJours(caseJour).Tag = _date.Day
            semaines(semaine).pnlJours(caseJour)._date = _date

            If (GetPreviousSunday(_date) = GetPreviousSunday(frmAccueil._date_selectionne) Or GetNextSaturday(_date) = GetNextSaturday(frmAccueil._date_selectionne)) Then

                remplirSemaine()

                For i As Integer = 0 To 6
                    If semaines(semaine).pnlJours(i).BackColor = Color.White Then
                        semaines(semaine).pnlJours(i).BackColor = Color.BlanchedAlmond
                    End If
                Next
            End If

            If (_date = Date.Today) Then
                semaines(semaine).pnlJours(caseJour).BackColor = Color.LightBlue
                semaines(semaine).pnlJours(caseJour).BorderColor = Color.FromArgb(0, 176, 240)
                semaines(semaine).pnlJours(caseJour).BorderWidth = 6 + 3
            End If


            If caseJour = 6 Then
                semaine = semaine + 1
            End If



            _date = _date.AddDays(1)
        End While


        For i As Integer = 0 To nbSemaines
            For ii As Integer = 0 To 6
                semaines(i).pnlJours(ii).griser()
            Next
        Next

    End Sub

    Function GetPreviousSunday(fromDate As Date) As Date
        Return fromDate.AddDays(0 - fromDate.DayOfWeek)
    End Function

    Function GetNextSaturday(fromDate As Date) As Date
        Return fromDate.AddDays(6 - fromDate.DayOfWeek)
    End Function


    Public Sub remplirSemaine()

    End Sub



    Public Sub ajouterEvenement(jour As Integer, evenement As String, icone As String, id_recette As Integer)

        For i As Integer = 0 To nbSemaines
            For ii As Integer = 0 To 6
                If semaines(i).pnlJours(ii).Tag = jour Then
                    semaines(i).pnlJours(ii).ajouterEvenementMois(evenement)

                    Dim pb As New PictureBox
                    If Not semaines(i).pnlJours(ii).dayN Then
                        pb.SetBounds((semaines(i).pnlJours(ii).Width / 2) - (semaines(i).pnlJours(ii).Width / 2.5), semaines(i).pnlJours(ii).Height / 2 - (semaines(i).pnlJours(ii).Height / 2.5), semaines(i).pnlJours(ii).Width / 1.25, semaines(i).pnlJours(ii).Height / 1.25)
                    Else
                        pb.SetBounds((semaines(i).pnlJours(ii).Width / 2) - (semaines(i).pnlJours(ii).Width / 2.5), (semaines(i).pnlJours(ii).Height + 40) / 2 - ((semaines(i).pnlJours(ii).Height - 40) / 2.5), semaines(i).pnlJours(ii).Width / 1.25, (semaines(i).pnlJours(ii).Height - 40) / 1.25)
                    End If


                    'Essaie de récupérer l'image localement
                    Try
                        semaines(i).pnlJours(ii).ajouterAlerte(evenement, Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "imagesboutons\" & icone), id_recette)

                    Catch exc As Exception
                        icone = "1.png"
                        semaines(i).pnlJours(ii).ajouterAlerte(evenement, Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "imagesboutons\" & icone), id_recette)
                    End Try


                End If
            Next
        Next

    End Sub




End Class

