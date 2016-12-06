<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAjoutRecettes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAjoutRecettes))
        Me.cbUnite = New System.Windows.Forms.ComboBox()
        Me.btnSupprimerAllergies = New System.Windows.Forms.Button()
        Me.cbPortions = New System.Windows.Forms.ComboBox()
        Me.txtPortions = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRemarques = New System.Windows.Forms.RichTextBox()
        Me.chkCongelable = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtRefroid = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCategorie = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtConservation = New System.Windows.Forms.TextBox()
        Me.btnAllergies = New System.Windows.Forms.Button()
        Me.txtAllergies = New System.Windows.Forms.TextBox()
        Me.lstAllergies = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCelcius = New System.Windows.Forms.TextBox()
        Me.txtQuantite = New System.Windows.Forms.TextBox()
        Me.Supprimer = New System.Windows.Forms.Button()
        Me.lblUnite = New System.Windows.Forms.Label()
        Me.lblIngredients = New System.Windows.Forms.Label()
        Me.lsvProduit = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Quantité = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.lblQuantite = New System.Windows.Forms.Label()
        Me.cbProduit = New System.Windows.Forms.ComboBox()
        Me.lblAjouter = New System.Windows.Forms.Label()
        Me.nudPortions = New System.Windows.Forms.NumericUpDown()
        Me.lblPortions = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEtapes = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCuisson = New System.Windows.Forms.Label()
        Me.txtCuisson = New System.Windows.Forms.TextBox()
        Me.lblPreparation = New System.Windows.Forms.Label()
        Me.txtPreparation = New System.Windows.Forms.TextBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.picRecette = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnEnregistrer = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFaraneith = New System.Windows.Forms.TextBox()
        CType(Me.nudPortions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRecette, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbUnite
        '
        Me.cbUnite.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbUnite.FormattingEnabled = True
        Me.cbUnite.Location = New System.Drawing.Point(1306, 362)
        Me.cbUnite.Name = "cbUnite"
        Me.cbUnite.Size = New System.Drawing.Size(90, 21)
        Me.cbUnite.TabIndex = 17
        Me.cbUnite.Text = "g"
        '
        'btnSupprimerAllergies
        '
        Me.btnSupprimerAllergies.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnSupprimerAllergies.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupprimerAllergies.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupprimerAllergies.ForeColor = System.Drawing.Color.White
        Me.btnSupprimerAllergies.Location = New System.Drawing.Point(284, 52)
        Me.btnSupprimerAllergies.Name = "btnSupprimerAllergies"
        Me.btnSupprimerAllergies.Size = New System.Drawing.Size(90, 35)
        Me.btnSupprimerAllergies.TabIndex = 171
        Me.btnSupprimerAllergies.Text = "Supprimer"
        Me.btnSupprimerAllergies.UseVisualStyleBackColor = False
        '
        'cbPortions
        '
        Me.cbPortions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPortions.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cbPortions.FormattingEnabled = True
        Me.cbPortions.Location = New System.Drawing.Point(520, 338)
        Me.cbPortions.Name = "cbPortions"
        Me.cbPortions.Size = New System.Drawing.Size(71, 21)
        Me.cbPortions.TabIndex = 11
        '
        'txtPortions
        '
        Me.txtPortions.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtPortions.Location = New System.Drawing.Point(461, 338)
        Me.txtPortions.Name = "txtPortions"
        Me.txtPortions.ShortcutsEnabled = False
        Me.txtPortions.Size = New System.Drawing.Size(50, 22)
        Me.txtPortions.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(433, 343)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(20, 13)
        Me.Label11.TabIndex = 167
        Me.Label11.Text = "de"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(277, 408)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 164
        Me.Label7.Text = "Remarques :"
        '
        'txtRemarques
        '
        Me.txtRemarques.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtRemarques.Location = New System.Drawing.Point(370, 405)
        Me.txtRemarques.Name = "txtRemarques"
        Me.txtRemarques.Size = New System.Drawing.Size(387, 104)
        Me.txtRemarques.TabIndex = 13
        Me.txtRemarques.Text = ""
        '
        'chkCongelable
        '
        Me.chkCongelable.AutoSize = True
        Me.chkCongelable.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.chkCongelable.Location = New System.Drawing.Point(370, 374)
        Me.chkCongelable.Name = "chkCongelable"
        Me.chkCongelable.Size = New System.Drawing.Size(85, 17)
        Me.chkCongelable.TabIndex = 12
        Me.chkCongelable.Text = "Congelable"
        Me.chkCongelable.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(199, 267)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(152, 13)
        Me.Label10.TabIndex = 160
        Me.Label10.Text = "Temps de refroisdissement : "
        '
        'txtRefroid
        '
        Me.txtRefroid.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtRefroid.Location = New System.Drawing.Point(370, 264)
        Me.txtRefroid.Name = "txtRefroid"
        Me.txtRefroid.Size = New System.Drawing.Size(82, 22)
        Me.txtRefroid.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label9.Location = New System.Drawing.Point(286, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 159
        Me.Label9.Text = "Catégorie : "
        '
        'txtCategorie
        '
        Me.txtCategorie.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCategorie.Location = New System.Drawing.Point(372, 135)
        Me.txtCategorie.Name = "txtCategorie"
        Me.txtCategorie.Size = New System.Drawing.Size(208, 22)
        Me.txtCategorie.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(219, 306)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 13)
        Me.Label8.TabIndex = 157
        Me.Label8.Text = "Temps de conservation : "
        '
        'txtConservation
        '
        Me.txtConservation.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtConservation.Location = New System.Drawing.Point(370, 303)
        Me.txtConservation.Name = "txtConservation"
        Me.txtConservation.Size = New System.Drawing.Size(82, 22)
        Me.txtConservation.TabIndex = 8
        '
        'btnAllergies
        '
        Me.btnAllergies.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnAllergies.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAllergies.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAllergies.ForeColor = System.Drawing.Color.White
        Me.btnAllergies.Location = New System.Drawing.Point(284, 11)
        Me.btnAllergies.Name = "btnAllergies"
        Me.btnAllergies.Size = New System.Drawing.Size(90, 35)
        Me.btnAllergies.TabIndex = 156
        Me.btnAllergies.Text = "Ajouter"
        Me.btnAllergies.UseVisualStyleBackColor = False
        '
        'txtAllergies
        '
        Me.txtAllergies.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAllergies.Location = New System.Drawing.Point(11, 19)
        Me.txtAllergies.Name = "txtAllergies"
        Me.txtAllergies.Size = New System.Drawing.Size(254, 21)
        Me.txtAllergies.TabIndex = 14
        '
        'lstAllergies
        '
        Me.lstAllergies.FormattingEnabled = True
        Me.lstAllergies.Location = New System.Drawing.Point(11, 52)
        Me.lstAllergies.Name = "lstAllergies"
        Me.lstAllergies.Size = New System.Drawing.Size(254, 95)
        Me.lstAllergies.TabIndex = 153
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(651, 228)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 152
        Me.Label1.Text = "ºC"
        '
        'txtCelcius
        '
        Me.txtCelcius.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCelcius.Location = New System.Drawing.Point(588, 225)
        Me.txtCelcius.Name = "txtCelcius"
        Me.txtCelcius.Size = New System.Drawing.Size(50, 22)
        Me.txtCelcius.TabIndex = 6
        Me.txtCelcius.Tag = "c"
        '
        'txtQuantite
        '
        Me.txtQuantite.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantite.Location = New System.Drawing.Point(1226, 362)
        Me.txtQuantite.Name = "txtQuantite"
        Me.txtQuantite.ShortcutsEnabled = False
        Me.txtQuantite.Size = New System.Drawing.Size(60, 21)
        Me.txtQuantite.TabIndex = 16
        '
        'Supprimer
        '
        Me.Supprimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Supprimer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supprimer.ForeColor = System.Drawing.Color.White
        Me.Supprimer.Location = New System.Drawing.Point(1305, 389)
        Me.Supprimer.Name = "Supprimer"
        Me.Supprimer.Size = New System.Drawing.Size(90, 35)
        Me.Supprimer.TabIndex = 150
        Me.Supprimer.Text = "Supprimer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Supprimer.UseVisualStyleBackColor = False
        '
        'lblUnite
        '
        Me.lblUnite.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblUnite.Location = New System.Drawing.Point(1989, 882)
        Me.lblUnite.Name = "lblUnite"
        Me.lblUnite.Size = New System.Drawing.Size(100, 23)
        Me.lblUnite.TabIndex = 149
        Me.lblUnite.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblIngredients
        '
        Me.lblIngredients.AutoSize = True
        Me.lblIngredients.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngredients.Location = New System.Drawing.Point(844, 66)
        Me.lblIngredients.Name = "lblIngredients"
        Me.lblIngredients.Size = New System.Drawing.Size(110, 28)
        Me.lblIngredients.TabIndex = 148
        Me.lblIngredients.Text = "Ingrédients"
        '
        'lsvProduit
        '
        Me.lsvProduit.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.Quantité, Me.ColumnHeader2})
        Me.lsvProduit.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvProduit.FullRowSelect = True
        Me.lsvProduit.HideSelection = False
        Me.lsvProduit.Location = New System.Drawing.Point(845, 97)
        Me.lsvProduit.Name = "lsvProduit"
        Me.lsvProduit.Size = New System.Drawing.Size(551, 256)
        Me.lsvProduit.TabIndex = 147
        Me.lsvProduit.UseCompatibleStateImageBehavior = False
        Me.lsvProduit.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Ingrédients"
        Me.ColumnHeader1.Width = 312
        '
        'Quantité
        '
        Me.Quantité.Text = "Quantité"
        Me.Quantité.Width = 153
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Format"
        Me.ColumnHeader2.Width = 82
        '
        'btnAjouter
        '
        Me.btnAjouter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjouter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjouter.ForeColor = System.Drawing.Color.White
        Me.btnAjouter.Location = New System.Drawing.Point(1208, 389)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(90, 35)
        Me.btnAjouter.TabIndex = 146
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = False
        '
        'lblQuantite
        '
        Me.lblQuantite.AutoSize = True
        Me.lblQuantite.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantite.Location = New System.Drawing.Point(1156, 365)
        Me.lblQuantite.Name = "lblQuantite"
        Me.lblQuantite.Size = New System.Drawing.Size(59, 13)
        Me.lblQuantite.TabIndex = 145
        Me.lblQuantite.Text = "Quantité :"
        '
        'cbProduit
        '
        Me.cbProduit.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProduit.FormattingEnabled = True
        Me.cbProduit.Location = New System.Drawing.Point(982, 362)
        Me.cbProduit.Name = "cbProduit"
        Me.cbProduit.Size = New System.Drawing.Size(155, 21)
        Me.cbProduit.TabIndex = 15
        '
        'lblAjouter
        '
        Me.lblAjouter.AutoSize = True
        Me.lblAjouter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAjouter.Location = New System.Drawing.Point(846, 365)
        Me.lblAjouter.Name = "lblAjouter"
        Me.lblAjouter.Size = New System.Drawing.Size(130, 13)
        Me.lblAjouter.TabIndex = 143
        Me.lblAjouter.Text = "Ajouter un ingrédients :"
        '
        'nudPortions
        '
        Me.nudPortions.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.nudPortions.Location = New System.Drawing.Point(370, 338)
        Me.nudPortions.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPortions.Name = "nudPortions"
        Me.nudPortions.Size = New System.Drawing.Size(56, 22)
        Me.nudPortions.TabIndex = 9
        Me.nudPortions.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblPortions
        '
        Me.lblPortions.AutoSize = True
        Me.lblPortions.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblPortions.Location = New System.Drawing.Point(291, 341)
        Me.lblPortions.Name = "lblPortions"
        Me.lblPortions.Size = New System.Drawing.Size(56, 13)
        Me.lblPortions.TabIndex = 142
        Me.lblPortions.Text = "Portions :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(840, 444)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(191, 28)
        Me.Label6.TabIndex = 141
        Me.Label6.Text = "Étapes de réalisation"
        '
        'txtEtapes
        '
        Me.txtEtapes.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEtapes.Location = New System.Drawing.Point(845, 475)
        Me.txtEtapes.Name = "txtEtapes"
        Me.txtEtapes.Size = New System.Drawing.Size(551, 225)
        Me.txtEtapes.TabIndex = 18
        Me.txtEtapes.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(471, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 139
        Me.Label5.Text = "à"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(555, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 13)
        Me.Label4.TabIndex = 138
        Me.Label4.Text = "ºF"
        '
        'lblCuisson
        '
        Me.lblCuisson.AutoSize = True
        Me.lblCuisson.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblCuisson.Location = New System.Drawing.Point(246, 228)
        Me.lblCuisson.Name = "lblCuisson"
        Me.lblCuisson.Size = New System.Drawing.Size(103, 13)
        Me.lblCuisson.TabIndex = 137
        Me.lblCuisson.Text = "Temps de cuisson :"
        '
        'txtCuisson
        '
        Me.txtCuisson.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtCuisson.Location = New System.Drawing.Point(370, 225)
        Me.txtCuisson.Name = "txtCuisson"
        Me.txtCuisson.Size = New System.Drawing.Size(82, 22)
        Me.txtCuisson.TabIndex = 4
        '
        'lblPreparation
        '
        Me.lblPreparation.AutoSize = True
        Me.lblPreparation.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblPreparation.Location = New System.Drawing.Point(224, 189)
        Me.lblPreparation.Name = "lblPreparation"
        Me.lblPreparation.Size = New System.Drawing.Size(128, 13)
        Me.lblPreparation.TabIndex = 136
        Me.lblPreparation.Text = "Temps de préparation : "
        '
        'txtPreparation
        '
        Me.txtPreparation.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtPreparation.Location = New System.Drawing.Point(370, 185)
        Me.txtPreparation.Name = "txtPreparation"
        Me.txtPreparation.Size = New System.Drawing.Size(82, 22)
        Me.txtPreparation.TabIndex = 3
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblNom.Location = New System.Drawing.Point(249, 100)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(103, 13)
        Me.lblNom.TabIndex = 135
        Me.lblNom.Text = "Nom de la recette :"
        '
        'txtNom
        '
        Me.txtNom.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtNom.Location = New System.Drawing.Point(372, 97)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(254, 22)
        Me.txtNom.TabIndex = 1
        '
        'picRecette
        '
        Me.picRecette.BackColor = System.Drawing.SystemColors.Control
        Me.picRecette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picRecette.Location = New System.Drawing.Point(21, 97)
        Me.picRecette.Name = "picRecette"
        Me.picRecette.Size = New System.Drawing.Size(171, 163)
        Me.picRecette.TabIndex = 134
        Me.picRecette.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnEnregistrer
        '
        Me.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnregistrer.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnEnregistrer.ForeColor = System.Drawing.Color.White
        Me.btnEnregistrer.Location = New System.Drawing.Point(1208, 706)
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.btnEnregistrer.Size = New System.Drawing.Size(91, 35)
        Me.btnEnregistrer.TabIndex = 132
        Me.btnEnregistrer.Text = "Enregistrer"
        Me.btnEnregistrer.UseVisualStyleBackColor = False
        '
        'btnAnnuler
        '
        Me.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnuler.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnAnnuler.ForeColor = System.Drawing.Color.White
        Me.btnAnnuler.Location = New System.Drawing.Point(1306, 706)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(90, 35)
        Me.btnAnnuler.TabIndex = 133
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAllergies)
        Me.GroupBox1.Controls.Add(Me.btnAllergies)
        Me.GroupBox1.Controls.Add(Me.btnSupprimerAllergies)
        Me.GroupBox1.Controls.Add(Me.lstAllergies)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.GroupBox1.Location = New System.Drawing.Point(370, 536)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 164)
        Me.GroupBox1.TabIndex = 174
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(280, 544)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 175
        Me.Label2.Text = "Allergènes :"
        '
        'txtFaraneith
        '
        Me.txtFaraneith.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtFaraneith.Location = New System.Drawing.Point(499, 225)
        Me.txtFaraneith.Name = "txtFaraneith"
        Me.txtFaraneith.ShortcutsEnabled = False
        Me.txtFaraneith.Size = New System.Drawing.Size(50, 22)
        Me.txtFaraneith.TabIndex = 5
        Me.txtFaraneith.Tag = "f"
        Me.txtFaraneith.WordWrap = False
        '
        'frmAjoutRecettes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1604, 880)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbUnite)
        Me.Controls.Add(Me.cbPortions)
        Me.Controls.Add(Me.txtPortions)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtRemarques)
        Me.Controls.Add(Me.chkCongelable)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtRefroid)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCategorie)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtConservation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCelcius)
        Me.Controls.Add(Me.txtQuantite)
        Me.Controls.Add(Me.Supprimer)
        Me.Controls.Add(Me.lblUnite)
        Me.Controls.Add(Me.lblIngredients)
        Me.Controls.Add(Me.lsvProduit)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.lblQuantite)
        Me.Controls.Add(Me.cbProduit)
        Me.Controls.Add(Me.lblAjouter)
        Me.Controls.Add(Me.nudPortions)
        Me.Controls.Add(Me.lblPortions)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEtapes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtFaraneith)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblCuisson)
        Me.Controls.Add(Me.txtCuisson)
        Me.Controls.Add(Me.lblPreparation)
        Me.Controls.Add(Me.txtPreparation)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.picRecette)
        Me.Controls.Add(Me.btnEnregistrer)
        Me.Controls.Add(Me.btnAnnuler)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAjoutRecettes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recette"
        CType(Me.nudPortions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRecette, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbUnite As ComboBox
    Friend WithEvents btnSupprimerAllergies As Button
    Friend WithEvents cbPortions As ComboBox
    Friend WithEvents txtPortions As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtRemarques As RichTextBox
    Friend WithEvents chkCongelable As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtRefroid As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCategorie As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtConservation As TextBox
    Friend WithEvents btnAllergies As Button
    Friend WithEvents txtAllergies As TextBox
    Friend WithEvents lstAllergies As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCelcius As TextBox
    Friend WithEvents txtQuantite As TextBox
    Friend WithEvents Supprimer As Button
    Friend WithEvents lblUnite As Label
    Friend WithEvents lblIngredients As Label
    Friend WithEvents lsvProduit As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Quantité As ColumnHeader
    Friend WithEvents btnAjouter As Button
    Friend WithEvents lblQuantite As Label
    Friend WithEvents cbProduit As ComboBox
    Friend WithEvents lblAjouter As Label
    Friend WithEvents nudPortions As NumericUpDown
    Friend WithEvents lblPortions As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEtapes As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCuisson As Label
    Friend WithEvents txtCuisson As TextBox
    Friend WithEvents lblPreparation As Label
    Friend WithEvents txtPreparation As TextBox
    Friend WithEvents lblNom As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents picRecette As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnEnregistrer As Button
    Friend WithEvents btnAnnuler As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents txtFaraneith As TextBox
End Class
