
Public Class PanelJour
    ''Jonathan Lafreniere
    ''Création de cases représentant les jours dans un calendrier
    Inherits Panel

    Dim yPos As Integer = 0
    Dim linkLabel As Boolean
    Dim ll As LinkLabel
    Dim evenements As New List(Of String)() ''Liste des évènements

    Property evenementsMois As New List(Of String)()
    Dim hasEvent As Boolean = False
    Property monthComponent As Boolean
    Public dayN As Boolean

    Public alerteX As Integer = 35 ''Marge gauche de la première alerte dans la case
    Public alerteY As Integer = 5  ''Marge du haut de la première alerte dans la case



    Property jour As String ''Nom du jour
    Property _date As Date
    Public Sub New(x As Integer, y As Integer, width As Integer, height As Integer, _jour As String, smallFont As Boolean, dayName As Boolean, monthComp As Boolean)

        Me.BorderStyle = BorderStyle.None
        BorderWidth = 2
        BorderColor = Color.Black
        Me.BackColor = Color.White

        monthComponent = monthComp
        dayN = dayName

        yPos = 5

        jour = _jour
        SetBounds(x, y, width, height)

        If (dayName) Then
            yPos = 45
            Dim lblJR As New Label()
            If smallFont Then
                lblJR.Font = New Font("Segoe UI",
                               10,
                               FontStyle.Bold)
            Else lblJR.Font = New Font("Segoe UI",
               15,
               FontStyle.Bold)
            End If
            height += 40

            lblJR.ForeColor = Color.White
            lblJR.Top = 0
            lblJR.Left = (width / 2) - (lblJR.Width / 2)
            lblJR.Height = 40
            lblJR.TextAlign = ContentAlignment.MiddleCenter
            lblJR.Dock = DockStyle.Top
            lblJR.Text = jour
            lblJR.BackColor = Color.FromArgb(0, 176, 240)

            Controls.Add(lblJR)
        End If

    End Sub

    Public Sub ajouterAlerte(alerte As String, img As Image)

        ''Ajoute une alerte dans la case selon l'image spécifiée

        Dim pb As New PictureBox
        pb.Image = img
        pb.SizeMode = PictureBoxSizeMode.StretchImage

        pb.SetBounds(alerteX, alerteY, Width * 0.25, Me.Height * 0.25)

        alerteX += Width * 0.3

        AddHandler pb.Click, Sub()

                                 MsgBox(alerte)


                             End Sub

        If (alerteX + (Width * 0.3) > Width) Then
            alerteX = 5
            alerteY += pb.Height * 1.32
        End If

        Controls.Add(pb)

    End Sub

    Public Sub ajouterEvenement(ByVal evenement As String, recette As Integer)

        ''Ajoute le texte de l'évènement dans la case

        hasEvent = True
        evenements.Add(evenement)
        Dim str As String
        If (yPos < Height - 30) Then

            If (evenement.Length > 22) Then
                str = evenement.Substring(0, 22)
                str = str & "..."
            Else str = evenement
            End If
            Dim ds As New DataSet()
            Dim lblEvenement As New Label
            lblEvenement.Text = str
            lblEvenement.Top = yPos
            lblEvenement.Left = 5
            lblEvenement.AutoSize = True
            Me.Controls.Add(lblEvenement)
            yPos += 15
            If (Not linkLabel And Not monthComponent) Then
                linkLabel = True
                ll = New LinkLabel
                ll.Text = "Tous les évènements"
                ll.SetBounds(7, 130, 115, 15)
                ll.AutoSize = False
                Controls.Add(ll)
                AddHandler ll.Click, Sub(sender2, eventargs2)
                                         Dim ds1 As New DataSet()
                                         frmAccueil.bd.miseAjourDS(ds1, New MySql.Data.MySqlClient.MySqlDataAdapter, "select nom from recettes where id=" & recette, 0)
                                         MsgBox(ds1.Tables(0).Rows(0).Item(0))
                                     End Sub
                MsgBox(ds.Tables(0).Rows(0).Item(0))
            End If
        End If


    End Sub



    Public Sub ajouterEvenement(ByVal evenement As String)

        ''Ajoute le texte de l'évènement dans la case

        hasEvent = True
        evenements.Add(evenement)
        Dim str As String
        If (yPos < Height - 30) Then

            If (evenement.Length > 22) Then
                str = evenement.Substring(0, 22)
                str = str & "..."
            Else str = evenement
            End If

            Dim lblEvenement As New Label
            lblEvenement.Text = str
            lblEvenement.Top = yPos
            lblEvenement.Left = 5
            lblEvenement.AutoSize = True
            Me.Controls.Add(lblEvenement)
            yPos += 15
            If (Not linkLabel And Not monthComponent) Then
                linkLabel = True
                ll = New LinkLabel
                ll.Text = "Tous les évènements"
                ll.SetBounds(7, 130, 115, 15)
                ll.AutoSize = False
                Controls.Add(ll)
                AddHandler ll.Click, Sub(sender2, eventargs2)
                                         MsgBox("PLACEHOLDER")
                                     End Sub
            End If
        End If


    End Sub

    Public Sub griser()

        ''Grise la case du calendrier si elle n'est pas un jour du mois
        If hasEvent = False Then
            Me.BackColor = Color.DarkGray
        End If
    End Sub



    Private bColor As Color
    Public Property BorderColor() As Color
        Get
            Return Me.bColor
        End Get
        Set(ByVal value As Color)
            Me.bColor = value
            Me.Refresh()
        End Set
    End Property


    Private bWidth As Integer
    Public Property BorderWidth() As Integer
        Get
            Return Me.bWidth
        End Get
        Set(ByVal value As Integer)
            Me.bWidth = Math.Abs(value)
            Me.Refresh()
        End Set
    End Property

    Public Overridable Sub MyPanel_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        e.Graphics.DrawRectangle(New Pen(Me.bColor, Me.bWidth), Me.ClientRectangle)
    End Sub

    Public Sub viderJour()
        Dim f As Font = New Font("Segoe UI", 15, FontStyle.Bold)
        For Each l As Label In Me.Controls
            If Not l.Font.Size = f.Size Then
                Controls.Remove(l)
            End If
        Next

        yPos = 45
        linkLabel = False
        Controls.Remove(ll)
    End Sub

    Public Sub ajouterEvenementMois(ByVal str As String)
        evenementsMois.Add(str)
    End Sub


    Public Sub selectSemaine() Handles Me.Click
        If Not _date = Nothing Then
            frmAccueil.changerDateSelectionnee(_date)
        End If
    End Sub

End Class

