<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAjoutFournisseurs
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtCodePostal = New System.Windows.Forms.MaskedTextBox()
        Me.txtFax = New System.Windows.Forms.MaskedTextBox()
        Me.txtCell = New System.Windows.Forms.MaskedTextBox()
        Me.txtTel = New System.Windows.Forms.MaskedTextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.btnEnregistrer = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtNotes = New System.Windows.Forms.RichTextBox()
        Me.txtCourriel = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtFrais = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtPrix = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.nudCommande = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbLivraison = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbCommande = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPoste = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtProvince = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtVille = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAdresse = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.nudCommande, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodePostal
        '
        Me.txtCodePostal.Location = New System.Drawing.Point(146, 262)
        Me.txtCodePostal.Mask = "L0L 0L0"
        Me.txtCodePostal.Name = "txtCodePostal"
        Me.txtCodePostal.Size = New System.Drawing.Size(60, 20)
        Me.txtCodePostal.TabIndex = 81
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(146, 376)
        Me.txtFax.Mask = "(999)999-9999"
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(166, 20)
        Me.txtFax.TabIndex = 89
        '
        'txtCell
        '
        Me.txtCell.Location = New System.Drawing.Point(149, 338)
        Me.txtCell.Mask = "(999)999-9999"
        Me.txtCell.Name = "txtCell"
        Me.txtCell.Size = New System.Drawing.Size(166, 20)
        Me.txtCell.TabIndex = 87
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(148, 295)
        Me.txtTel.Mask = "(999)999-9999"
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(166, 20)
        Me.txtTel.TabIndex = 83
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(146, 89)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(23, 20)
        Me.txtId.TabIndex = 111
        '
        'btnAnnuler
        '
        Me.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnuler.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnuler.ForeColor = System.Drawing.Color.White
        Me.btnAnnuler.Location = New System.Drawing.Point(460, 642)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(91, 35)
        Me.btnAnnuler.TabIndex = 110
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = False
        '
        'btnEnregistrer
        '
        Me.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnregistrer.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnregistrer.ForeColor = System.Drawing.Color.White
        Me.btnEnregistrer.Location = New System.Drawing.Point(363, 642)
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.btnEnregistrer.Size = New System.Drawing.Size(91, 35)
        Me.btnEnregistrer.TabIndex = 109
        Me.btnEnregistrer.Text = "Enregistrer"
        Me.btnEnregistrer.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(425, 128)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(40, 13)
        Me.Label20.TabIndex = 108
        Me.Label20.Text = "Notes:"
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(469, 128)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(268, 155)
        Me.txtNotes.TabIndex = 107
        Me.txtNotes.Text = ""
        '
        'txtCourriel
        '
        Me.txtCourriel.Location = New System.Drawing.Point(146, 599)
        Me.txtCourriel.Name = "txtCourriel"
        Me.txtCourriel.Size = New System.Drawing.Size(168, 20)
        Me.txtCourriel.TabIndex = 106
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(84, 602)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(51, 13)
        Me.Label19.TabIndex = 105
        Me.Label19.Text = "Courriel:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(347, 562)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(13, 13)
        Me.Label17.TabIndex = 104
        Me.Label17.Text = "$"
        '
        'txtFrais
        '
        Me.txtFrais.Location = New System.Drawing.Point(303, 559)
        Me.txtFrais.Name = "txtFrais"
        Me.txtFrais.Size = New System.Drawing.Size(38, 20)
        Me.txtFrais.TabIndex = 103
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(209, 562)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 13)
        Me.Label18.TabIndex = 102
        Me.Label18.Text = "Frais de livraison:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(190, 562)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(13, 13)
        Me.Label16.TabIndex = 101
        Me.Label16.Text = "$"
        '
        'txtPrix
        '
        Me.txtPrix.Location = New System.Drawing.Point(146, 559)
        Me.txtPrix.Name = "txtPrix"
        Me.txtPrix.Size = New System.Drawing.Size(38, 20)
        Me.txtPrix.TabIndex = 100
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(63, 562)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(78, 13)
        Me.Label15.TabIndex = 99
        Me.Label15.Text = "Prix minimum:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(212, 531)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 13)
        Me.Label14.TabIndex = 98
        Me.Label14.Text = "jours"
        '
        'nudCommande
        '
        Me.nudCommande.Location = New System.Drawing.Point(146, 529)
        Me.nudCommande.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudCommande.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudCommande.Name = "nudCommande"
        Me.nudCommande.Size = New System.Drawing.Size(60, 20)
        Me.nudCommande.TabIndex = 97
        Me.nudCommande.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(29, 531)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 13)
        Me.Label13.TabIndex = 96
        Me.Label13.Text = "Délai de commande:"
        '
        'cbLivraison
        '
        Me.cbLivraison.FormattingEnabled = True
        Me.cbLivraison.Location = New System.Drawing.Point(146, 492)
        Me.cbLivraison.Name = "cbLivraison"
        Me.cbLivraison.Size = New System.Drawing.Size(168, 21)
        Me.cbLivraison.TabIndex = 95
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(50, 495)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 13)
        Me.Label12.TabIndex = 94
        Me.Label12.Text = "Jour de livraison:"
        '
        'cbCommande
        '
        Me.cbCommande.FormattingEnabled = True
        Me.cbCommande.Items.AddRange(New Object() {"Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche"})
        Me.cbCommande.Location = New System.Drawing.Point(146, 450)
        Me.cbCommande.Name = "cbCommande"
        Me.cbCommande.Size = New System.Drawing.Size(168, 21)
        Me.cbCommande.TabIndex = 93
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(36, 453)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 13)
        Me.Label11.TabIndex = 92
        Me.Label11.Text = "Jour de commande:"
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(146, 412)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(168, 20)
        Me.txtContact.TabIndex = 91
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(28, 415)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 13)
        Me.Label10.TabIndex = 90
        Me.Label10.Text = "Personne à contacter:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(74, 379)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 88
        Me.Label9.Text = "Télécopieur:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(84, 341)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 86
        Me.Label8.Text = "Cellulaire:"
        '
        'txtPoste
        '
        Me.txtPoste.Location = New System.Drawing.Point(376, 298)
        Me.txtPoste.Name = "txtPoste"
        Me.txtPoste.Size = New System.Drawing.Size(54, 20)
        Me.txtPoste.TabIndex = 85
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(331, 301)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Poste:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(78, 298)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Téléphone:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(69, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Code Postal:"
        '
        'txtProvince
        '
        Me.txtProvince.Location = New System.Drawing.Point(146, 231)
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.Size = New System.Drawing.Size(168, 20)
        Me.txtProvince.TabIndex = 79
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(87, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Province:"
        '
        'txtVille
        '
        Me.txtVille.Location = New System.Drawing.Point(146, 196)
        Me.txtVille.Name = "txtVille"
        Me.txtVille.Size = New System.Drawing.Size(168, 20)
        Me.txtVille.TabIndex = 77
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(104, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Ville:"
        '
        'txtAdresse
        '
        Me.txtAdresse.Location = New System.Drawing.Point(146, 161)
        Me.txtAdresse.Name = "txtAdresse"
        Me.txtAdresse.Size = New System.Drawing.Size(168, 20)
        Me.txtAdresse.TabIndex = 75
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(92, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Adresse:"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(147, 125)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(168, 20)
        Me.txtNom.TabIndex = 73
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(108, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Nom:"
        '
        'frmAjoutFournisseurs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(773, 618)
        Me.Controls.Add(Me.txtCodePostal)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.txtCell)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.btnAnnuler)
        Me.Controls.Add(Me.btnEnregistrer)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.txtCourriel)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtFrais)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtPrix)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.nudCommande)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cbLivraison)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cbCommande)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPoste)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtProvince)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtVille)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAdresse)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAjoutFournisseurs"
        Me.Text = "Ajouter un fournisseur"
        CType(Me.nudCommande, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCodePostal As MaskedTextBox
    Friend WithEvents txtFax As MaskedTextBox
    Friend WithEvents txtCell As MaskedTextBox
    Friend WithEvents txtTel As MaskedTextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents btnAnnuler As Button
    Friend WithEvents btnEnregistrer As Button
    Friend WithEvents Label20 As Label
    Friend WithEvents txtNotes As RichTextBox
    Friend WithEvents txtCourriel As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtFrais As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtPrix As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents nudCommande As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents cbLivraison As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cbCommande As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtContact As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPoste As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtProvince As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtVille As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAdresse As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents Label1 As Label
End Class
