Imports System.IO
Imports System.Net
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class frmAccueil

    ' Par jonathan lafreniere
    ' Calendrier des évenements à venir
    ' Évènements à venir cette semaine
    Dim btn As PanelOptionsAccueil
    Dim cal
    Dim lblSemaine As New Label
    Dim bd As New GestionBD("Server=localhost;Database=bd_application;Uid=root;Pwd=;")

    Public Property _date_selectionne As Date = Date.Today
    Dim p As New PanelSemaine(210, 140, 750, 150)


    Private Sub frmAccueil_shown(sender As Object, e As EventArgs) Handles MyBase.Shown


        Dim sb As New System.Text.StringBuilder


        Dim message As New WebBrowser()

        message.SetBounds(1000, 600, 400, 265)

        btnOmnivox.Text = "Omnivox"
        btnOmnivox.SetBounds(message.Location.X, message.Location.Y, 100, 30)
        AddHandler btnOmnivox.Click, Sub()
                                         Try
                                             Dim webAddress As String = "https://cegeptr.omnivox.ca/intr/Module/Identification/Login/Login.aspx?ReturnUrl=%2fintr"
                                             Process.Start(webAddress)
                                         Catch exc As Exception : End Try
                                     End Sub
        btnOmnivox.AutoSize = True
        btnOmnivox.Location = New Point(btnOmnivox.Location.X, btnOmnivox.Location.Y - 40)
        Controls.Add(btnOmnivox)
        Dim panel1 As New Panel
        panel1.Bounds = message.Bounds

        message.SetBounds(0, 0, 400, 300)
        panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        panel1.Controls.Add(message)



        remplirIndexHtml()


        message.Navigate("file:///" & IO.Path.GetFullPath(".\index.html"))
        Controls.Add(panel1)


        btn = New PanelOptionsAccueil(1000, 190, 400, 2)
        Dim img As Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "background.png")

        cal = New Calendrier(240, 340, 700, 612, _date_selectionne)
        Me.WindowState = FormWindowState.Maximized

        initialiserPanneauSemaine()
        creerBoutonRefresh()

        btn.SetBounds(1000, p.Location.Y, 400, 0)

        Controls.Add(New Header(Me, True))
        Controls.Add(p)
        Controls.Add(cal)
        Controls.Add(btn)

        btn.ajouterBouton(AppDomain.CurrentDomain.BaseDirectory & "imagesBoutons\agenda.png", frmAgenda, "Agenda")
        btn.ajouterBouton(AppDomain.CurrentDomain.BaseDirectory & "imagesBoutons\inventaire.png", frmInventaire, "Inventaire")
        btn.ajouterBouton(AppDomain.CurrentDomain.BaseDirectory & "imagesBoutons\produit.png", frmProduits, "Produits")
        btn.ajouterBouton(AppDomain.CurrentDomain.BaseDirectory & "imagesBoutons\recette.png", frmVoirRecettes, "Recettes")


        Dim ds = New DataSet
        Dim da = New MySqlDataAdapter


    End Sub

    Sub remplirIndexHtml()

        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter

        bd.miseAjourDS(ds, da, "select * from messages", 0)


        System.IO.File.WriteAllText("Index.html", "")

        '        <!DOCTYPE html>
        '<html>
        '<head>
        '<link rel = "stylesheet" type="text/css" href="style.css">

        '</head>
        '<body>

        For Each dr As DataRow In ds.Tables(0).Rows




        Next



    End Sub


    Private Sub creerBoutonRefresh()
        Dim refresh As New PictureBox()
        refresh.SetBounds(240, 340, 40, 40)
        refresh.Image = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "imagesBoutons\refresh.png")
        refresh.SizeMode = PictureBoxSizeMode.StretchImage

        AddHandler refresh.Click, Sub(sender2, eventargs2)

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
                                        _date_selectionne = Date.Today
                                        Controls.Remove(cal)
                                        cal = New Calendrier(240, 340, 700, 612, _date_selectionne)
                                        Controls.Add(cal)
                                    End Sub
        Controls.Add(refresh)
    End Sub

    Private Sub initialiserPanneauSemaine()

        Dim percent As Double = 0.23
        Dim btnSemPrecedente = New Button()
        Dim btnSemSuivante = New Button()

        With btnSemSuivante
            .BackColor = Color.FromArgb(0, 176, 240)
            .FlatStyle = FlatStyle.Flat
            .Text = ">>"
            .ForeColor = Color.White
            .Font = New Font("Segoe UI", 14.25, FontStyle.Bold)
            .TextAlign = ContentAlignment.TopCenter
            .UseVisualStyleBackColor = True
            .SetBounds(p.Location.X + (p.Width * (1 - percent)), 80, 100, 40)
        End With

        With btnSemPrecedente
            .BackColor = Color.FromArgb(0, 176, 240)
            .FlatStyle = FlatStyle.Flat
            .Text = "<<"
            .ForeColor = Color.White
            .Font = New Font("Segoe UI", 14.25, FontStyle.Bold)
            .TextAlign = ContentAlignment.TopCenter
            .UseVisualStyleBackColor = True
            .SetBounds(p.Location.X + (p.Width * percent) - 100, 80, 100, 40)
        End With

        With lblSemaine
            .Font = New Font("Segoe UI", 14.25)
            .TextAlign = ContentAlignment.MiddleCenter
            .Text = "Semaine du " & GetPreviousSunday(_date_selectionne).Day & " " & MonthName(GetPreviousSunday(_date_selectionne).Month) & " au " & GetNextSaturday(_date_selectionne).Day & " " & MonthName(GetNextSaturday(_date_selectionne).Month)
            .AutoSize = False
            .SetBounds(btnSemPrecedente.Location.X + btnSemPrecedente.Width, 85, btnSemSuivante.Location.X - (btnSemPrecedente.Location.X + btnSemPrecedente.Width), 30)
        End With




        AddHandler btnSemPrecedente.Click, Sub(sender2, eventargs2)
                                               changerDateSelectionnee(GetNextSaturday(_date_selectionne.AddDays(-7)))
                                           End Sub


        AddHandler btnSemSuivante.Click, Sub(sender3, eventargs3)
                                             changerDateSelectionnee(GetPreviousSunday(_date_selectionne.AddDays(7)))
                                         End Sub

        Controls.Add(lblSemaine)
        Controls.Add(btnSemSuivante)
        Controls.Add(btnSemPrecedente)

        p.remplirSemaine(Date.Today)
    End Sub

    Public Sub changerDateSelectionnee(ByVal d As Date)
        _date_selectionne = d
        lblSemaine.Text = "Semaine du " & GetPreviousSunday(_date_selectionne).Day & " " & MonthName(GetPreviousSunday(_date_selectionne).Month) & " au " & GetNextSaturday(_date_selectionne).Day & " " & MonthName(GetNextSaturday(_date_selectionne).Month)
        ' Controls.Remove(cal)
        cal.actualiserComposants() ' = New Calendrier(240, 340, 700, 612, _date_selectionne)
        'Controls.Add(cal)
        p.remplirSemaine(_date_selectionne)

    End Sub
    Private Sub centrer() Handles MyBase.GotFocus
        Me.Location = New Point(CInt((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Me.Width / 2)), CInt((Screen.PrimaryScreen.WorkingArea.Height / 2) - (Me.Height / 2)))
        AutoScroll = True
        Text = "Accueil"
    End Sub

    Function GetPreviousSunday(fromDate As Date) As Date
        Return fromDate.AddDays(0 - fromDate.DayOfWeek)
    End Function

    Function GetNextSaturday(fromDate As Date) As Date
        Return fromDate.AddDays(6 - fromDate.DayOfWeek)
    End Function





    Private Sub Button2_Click(sender As Object, e As EventArgs)
        MsgBox(Me.WindowState)
    End Sub

    Private Sub frmAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Shown


    End Sub

    Private Sub frmAccueil_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

