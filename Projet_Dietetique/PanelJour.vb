
Imports System.IO
Imports MySql.Data.MySqlClient

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

    Public Sub ajouterAlerte(alerte As String, img As Image, Optional ByVal id_recette As Integer = -1)

        ''Ajoute une alerte dans la case selon l'image spécifiée

        Dim pb As New PictureBox
        pb.Image = img
        pb.SizeMode = PictureBoxSizeMode.StretchImage

        pb.SetBounds(alerteX, alerteY, Width * 0.25, Me.Height * 0.25)

        alerteX += Width * 0.3

        AddHandler pb.Click, Sub()
                                 If (id_recette = -1) Then
                                     MsgBox(alerte, MsgBoxStyle.OkOnly, "Évènement")

                                 Else
                                     Dim ds1 As New DataSet
                                     frmAccueil.bd.miseAjourDS(ds1, New MySql.Data.MySqlClient.MySqlDataAdapter, "select nom from recettes where id_recette=" & id_recette, 0)
                                     Dim recettes As String = ds1.Tables(0).Rows(0).Item(0)
                                     Dim ans As String
                                     ans = MsgBox(alerte & Environment.NewLine & "Recette: " & recettes & Environment.NewLine & "Voulez-vous voir la recette associée?", vbYesNo, "Évènement")
                                     If ans = vbYes Then
                                         ouvrirFrmRecette(id_recette)
                                     End If

                                 End If
                             End Sub

        If (alerteX + (Width * 0.3) > Width) Then
            alerteX = 5
            alerteY += pb.Height * 1.32
        End If

        Controls.Add(pb)

    End Sub

    Public Sub ouvrirFrmRecette(id_recette As Integer)
        Dim bd As New GestionBD("Server=localhost;Database=bd_application;Uid=root;Pwd=;")
        Dim dsRecettes As New DataSet()
        Dim da As New MySqlDataAdapter

        bd.miseAjourDS(dsRecettes, da, "select * from recettes where id_recette = " & id_recette, 0)


        Try
            frmAjoutRecettes.Show()
            frmAjoutRecettes.id = dsRecettes.Tables(0).Rows(0).Item(0).ToString
            frmAjoutRecettes.txtNom.Text = dsRecettes.Tables(0).Rows(0).Item(1).ToString
            frmAjoutRecettes.txtCategorie.Text = dsRecettes.Tables(0).Rows(0).Item(14).ToString
            frmAjoutRecettes.txtPreparation.Text = dsRecettes.Tables(0).Rows(0).Item(2).ToString
            frmAjoutRecettes.txtCuisson.Text = dsRecettes.Tables(0).Rows(0).Item(3).ToString
            frmAjoutRecettes.txtFaraneith.Text = dsRecettes.Tables(0).Rows(0).Item(7).ToString
            frmAjoutRecettes.txtCelcius.Text = Math.Round(((CDbl(frmAjoutRecettes.txtFaraneith.Text) - 32) / 1.8), 0, MidpointRounding.AwayFromZero)
            frmAjoutRecettes.txtConservation.Text = dsRecettes.Tables(0).Rows(0).Item(13).ToString
            frmAjoutRecettes.txtRefroid.Text = dsRecettes.Tables(0).Rows(0).Item(8).ToString
            frmAjoutRecettes.nudPortions.Value = dsRecettes.Tables(0).Rows(0).Item(4).ToString
            frmAjoutRecettes.txtPortions.Text = dsRecettes.Tables(0).Rows(0).Item(5).ToString
            frmAjoutRecettes.cbPortions.Text = dsRecettes.Tables(0).Rows(0).Item(6).ToString
            ' On coche ou  le checkBox si la recette est congelable

            If dsRecettes.Tables(0).Rows(0).Item(15).ToString = True Then

                frmAjoutRecettes.chkCongelable.Checked = True
            Else
                frmAjoutRecettes.chkCongelable.Checked = False

            End If

            frmAjoutRecettes.txtRemarques.Text = dsRecettes.Tables(0).Rows(0).Item(11).ToString

            frmAjoutRecettes.txtEtapes.Text = dsRecettes.Tables(0).Rows(0).Item(9).ToString

            'On ajoute les allergies dans le listbox
            Dim allergies() As String = dsRecettes.Tables(0).Rows(0).Item(12).ToString.Split(vbCrLf)
            For i As Integer = 0 To allergies.Length - 1
                frmAjoutRecettes.lstAllergies.Items.Add(allergies(i))
            Next

            'Image




            frmAjoutRecettes.btnEnregistrer.Text = "Modifier"

            frmAjoutRecettes.remplirListView()
            If dsRecettes.Tables(0).Rows(0).Item(10) <> "" Then


                Try
                    frmAjoutRecettes.picRecette.SizeMode = PictureBoxSizeMode.StretchImage




                    Dim Fs As FileStream = New FileStream(My.Application.Info.DirectoryPath & "\Images\" & dsRecettes.Tables(0).Rows(0).Item(10).ToString, FileMode.Open, FileAccess.Read)
                    Dim Value() As Byte = New Byte(Fs.Length) {}
                    Fs.Read(Value, 0, Fs.Length)

                    frmAjoutRecettes.picRecette.Image = Image.FromStream(Fs)
                    Fs.Close()


                    Delete()
                    File.Copy(My.Application.Info.DirectoryPath & "\Images\" & dsRecettes.Tables(0).Rows(0).Item(10).ToString, "avatar.png", True)

                    frmAjoutRecettes.picRecette.Image = Image.FromFile("avatar.png")






                    'frmAjoutRecettes.picRecette.Image = Image.FromFile(My.Application.Info.DirectoryPath & "\Images\" & bd.dsRecettes.Tables(0).Rows(position).Item(10).ToString)

                Catch exc As Exception

                End Try
            End If
        Catch e As Exception
            MsgBox(e.Message)
        End Try

    End Sub

    Private Sub Delete()
        File.Delete("avatar.png")
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

                                         MsgBox(evenement)
                                     End Sub
                If Not (recette = -1) Then
                    MsgBox(ds.Tables(0).Rows(0).Item(0))
                End If
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

