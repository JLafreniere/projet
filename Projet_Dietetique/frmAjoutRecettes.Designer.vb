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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.cbUnite = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSupprimerAllergies = New System.Windows.Forms.Button()
        Me.cbRefroid = New System.Windows.Forms.ComboBox()
        Me.cbConservation = New System.Windows.Forms.ComboBox()
        Me.cbPortions = New System.Windows.Forms.ComboBox()
        Me.txtPortions = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAllergies = New System.Windows.Forms.TextBox()
        Me.lstAllergies = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCelcius = New System.Windows.Forms.TextBox()
        Me.txtQuantite = New System.Windows.Forms.TextBox()
        Me.Supprimer = New System.Windows.Forms.Button()
        Me.lblUnite = New System.Windows.Forms.Label()
        Me.lblAliments = New System.Windows.Forms.Label()
        Me.lsvProduit = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Quantité = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.lblQuantite = New System.Windows.Forms.Label()
        Me.cbProduit = New System.Windows.Forms.ComboBox()
        Me.lblAjouter = New System.Windows.Forms.Label()
        Me.nudPortions = New System.Windows.Forms.NumericUpDown()
        Me.lblPortions = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEtapes = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFaraneith = New System.Windows.Forms.TextBox()
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
        CType(Me.nudPortions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRecette, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(1229, 470)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(222, 157)
        Me.RichTextBox1.TabIndex = 163
        Me.RichTextBox1.Text = ""
        '
        'cbUnite
        '
        Me.cbUnite.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbUnite.FormattingEnabled = True
        Me.cbUnite.Items.AddRange(New Object() {"ml", "g", "unite"})
        Me.cbUnite.Location = New System.Drawing.Point(1527, 386)
        Me.cbUnite.Name = "cbUnite"
        Me.cbUnite.Size = New System.Drawing.Size(59, 21)
        Me.cbUnite.TabIndex = 173
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1486, 389)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 172
        Me.Label2.Text = "Unité : "
        '
        'btnSupprimerAllergies
        '
        Me.btnSupprimerAllergies.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnSupprimerAllergies.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupprimerAllergies.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupprimerAllergies.ForeColor = System.Drawing.Color.White
        Me.btnSupprimerAllergies.Location = New System.Drawing.Point(717, 548)
        Me.btnSupprimerAllergies.Name = "btnSupprimerAllergies"
        Me.btnSupprimerAllergies.Size = New System.Drawing.Size(90, 35)
        Me.btnSupprimerAllergies.TabIndex = 171
        Me.btnSupprimerAllergies.Text = "Supprimer"
        Me.btnSupprimerAllergies.UseVisualStyleBackColor = False
        '
        'cbRefroid
        '
        Me.cbRefroid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRefroid.FormattingEnabled = True
        Me.cbRefroid.Items.AddRange(New Object() {"min", "heures"})
        Me.cbRefroid.Location = New System.Drawing.Point(1013, 354)
        Me.cbRefroid.Name = "cbRefroid"
        Me.cbRefroid.Size = New System.Drawing.Size(62, 21)
        Me.cbRefroid.TabIndex = 170
        '
        'cbConservation
        '
        Me.cbConservation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbConservation.FormattingEnabled = True
        Me.cbConservation.Items.AddRange(New Object() {"heures", "jours", "semaines", "mois"})
        Me.cbConservation.Location = New System.Drawing.Point(708, 355)
        Me.cbConservation.Name = "cbConservation"
        Me.cbConservation.Size = New System.Drawing.Size(59, 21)
        Me.cbConservation.TabIndex = 169
        '
        'cbPortions
        '
        Me.cbPortions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPortions.FormattingEnabled = True
        Me.cbPortions.Items.AddRange(New Object() {"ml", "g", "unités"})
        Me.cbPortions.Location = New System.Drawing.Point(773, 274)
        Me.cbPortions.Name = "cbPortions"
        Me.cbPortions.Size = New System.Drawing.Size(47, 21)
        Me.cbPortions.TabIndex = 168
        '
        'txtPortions
        '
        Me.txtPortions.Location = New System.Drawing.Point(717, 274)
        Me.txtPortions.Name = "txtPortions"
        Me.txtPortions.Size = New System.Drawing.Size(50, 20)
        Me.txtPortions.TabIndex = 129
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(692, 277)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 13)
        Me.Label11.TabIndex = 167
        Me.Label11.Text = "de"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(616, 114)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(24, 20)
        Me.txtId.TabIndex = 166
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(587, 114)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(22, 13)
        Me.lblId.TabIndex = 165
        Me.lblId.Text = "Id :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1018, 417)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 28)
        Me.Label7.TabIndex = 164
        Me.Label7.Text = "Remarques"
        '
        'txtRemarques
        '
        Me.txtRemarques.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarques.Location = New System.Drawing.Point(961, 447)
        Me.txtRemarques.Name = "txtRemarques"
        Me.txtRemarques.Size = New System.Drawing.Size(222, 157)
        Me.txtRemarques.TabIndex = 162
        Me.txtRemarques.Text = ""
        '
        'chkCongelable
        '
        Me.chkCongelable.AutoSize = True
        Me.chkCongelable.Location = New System.Drawing.Point(633, 315)
        Me.chkCongelable.Name = "chkCongelable"
        Me.chkCongelable.Size = New System.Drawing.Size(79, 17)
        Me.chkCongelable.TabIndex = 161
        Me.chkCongelable.Text = "Congelable"
        Me.chkCongelable.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(776, 357)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(152, 13)
        Me.Label10.TabIndex = 160
        Me.Label10.Text = "Temps de refroisdissement : "
        '
        'txtRefroid
        '
        Me.txtRefroid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefroid.Location = New System.Drawing.Point(947, 354)
        Me.txtRefroid.Name = "txtRefroid"
        Me.txtRefroid.Size = New System.Drawing.Size(60, 21)
        Me.txtRefroid.TabIndex = 131
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(563, 389)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 159
        Me.Label9.Text = "Catégorie : "
        '
        'txtCategorie
        '
        Me.txtCategorie.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategorie.Location = New System.Drawing.Point(635, 386)
        Me.txtCategorie.Name = "txtCategorie"
        Me.txtCategorie.Size = New System.Drawing.Size(208, 21)
        Me.txtCategorie.TabIndex = 158
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(491, 358)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 13)
        Me.Label8.TabIndex = 157
        Me.Label8.Text = "Temps de conservation : "
        '
        'txtConservation
        '
        Me.txtConservation.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConservation.Location = New System.Drawing.Point(642, 354)
        Me.txtConservation.Name = "txtConservation"
        Me.txtConservation.Size = New System.Drawing.Size(60, 21)
        Me.txtConservation.TabIndex = 130
        '
        'btnAllergies
        '
        Me.btnAllergies.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnAllergies.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAllergies.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAllergies.ForeColor = System.Drawing.Color.White
        Me.btnAllergies.Location = New System.Drawing.Point(892, 406)
        Me.btnAllergies.Name = "btnAllergies"
        Me.btnAllergies.Size = New System.Drawing.Size(90, 35)
        Me.btnAllergies.TabIndex = 156
        Me.btnAllergies.Text = "Ajouter"
        Me.btnAllergies.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(564, 417)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 155
        Me.Label3.Text = "Allergène :"
        '
        'txtAllergies
        '
        Me.txtAllergies.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAllergies.Location = New System.Drawing.Point(632, 414)
        Me.txtAllergies.Name = "txtAllergies"
        Me.txtAllergies.Size = New System.Drawing.Size(254, 21)
        Me.txtAllergies.TabIndex = 154
        '
        'lstAllergies
        '
        Me.lstAllergies.FormattingEnabled = True
        Me.lstAllergies.Location = New System.Drawing.Point(632, 447)
        Me.lstAllergies.Name = "lstAllergies"
        Me.lstAllergies.Size = New System.Drawing.Size(254, 95)
        Me.lstAllergies.TabIndex = 153
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(902, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 13)
        Me.Label1.TabIndex = 152
        Me.Label1.Text = "ºC"
        '
        'txtCelcius
        '
        Me.txtCelcius.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelcius.Location = New System.Drawing.Point(839, 231)
        Me.txtCelcius.Name = "txtCelcius"
        Me.txtCelcius.Size = New System.Drawing.Size(50, 21)
        Me.txtCelcius.TabIndex = 127
        '
        'txtQuantite
        '
        Me.txtQuantite.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantite.Location = New System.Drawing.Point(1420, 386)
        Me.txtQuantite.Name = "txtQuantite"
        Me.txtQuantite.Size = New System.Drawing.Size(60, 21)
        Me.txtQuantite.TabIndex = 151
        '
        'Supprimer
        '
        Me.Supprimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Supprimer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supprimer.ForeColor = System.Drawing.Color.White
        Me.Supprimer.Location = New System.Drawing.Point(1441, 429)
        Me.Supprimer.Name = "Supprimer"
        Me.Supprimer.Size = New System.Drawing.Size(90, 35)
        Me.Supprimer.TabIndex = 150
        Me.Supprimer.Text = "Supprimer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Supprimer.UseVisualStyleBackColor = False
        '
        'lblUnite
        '
        Me.lblUnite.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblUnite.Location = New System.Drawing.Point(1857, 911)
        Me.lblUnite.Name = "lblUnite"
        Me.lblUnite.Size = New System.Drawing.Size(100, 23)
        Me.lblUnite.TabIndex = 149
        Me.lblUnite.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAliments
        '
        Me.lblAliments.AutoSize = True
        Me.lblAliments.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAliments.Location = New System.Drawing.Point(857, 89)
        Me.lblAliments.Name = "lblAliments"
        Me.lblAliments.Size = New System.Drawing.Size(88, 28)
        Me.lblAliments.TabIndex = 148
        Me.lblAliments.Text = "Aliments"
        '
        'lsvProduit
        '
        Me.lsvProduit.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.Quantité, Me.ColumnHeader3})
        Me.lsvProduit.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvProduit.FullRowSelect = True
        Me.lsvProduit.HideSelection = False
        Me.lsvProduit.Location = New System.Drawing.Point(1095, 115)
        Me.lsvProduit.Name = "lsvProduit"
        Me.lsvProduit.Size = New System.Drawing.Size(437, 256)
        Me.lsvProduit.TabIndex = 147
        Me.lsvProduit.UseCompatibleStateImageBehavior = False
        Me.lsvProduit.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Ingrédients"
        Me.ColumnHeader1.Width = 297
        '
        'Quantité
        '
        Me.Quantité.Text = "Quantité"
        Me.Quantité.Width = 76
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Unité"
        '
        'btnAjouter
        '
        Me.btnAjouter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjouter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjouter.ForeColor = System.Drawing.Color.White
        Me.btnAjouter.Location = New System.Drawing.Point(1344, 429)
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
        Me.lblQuantite.Location = New System.Drawing.Point(1350, 389)
        Me.lblQuantite.Name = "lblQuantite"
        Me.lblQuantite.Size = New System.Drawing.Size(59, 13)
        Me.lblQuantite.TabIndex = 145
        Me.lblQuantite.Text = "Quantité :"
        '
        'cbProduit
        '
        Me.cbProduit.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProduit.FormattingEnabled = True
        Me.cbProduit.Location = New System.Drawing.Point(1189, 386)
        Me.cbProduit.Name = "cbProduit"
        Me.cbProduit.Size = New System.Drawing.Size(155, 21)
        Me.cbProduit.TabIndex = 144
        '
        'lblAjouter
        '
        Me.lblAjouter.AutoSize = True
        Me.lblAjouter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAjouter.Location = New System.Drawing.Point(1074, 389)
        Me.lblAjouter.Name = "lblAjouter"
        Me.lblAjouter.Size = New System.Drawing.Size(109, 13)
        Me.lblAjouter.TabIndex = 143
        Me.lblAjouter.Text = "Ajouter un aliment :"
        '
        'nudPortions
        '
        Me.nudPortions.Location = New System.Drawing.Point(636, 270)
        Me.nudPortions.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPortions.Name = "nudPortions"
        Me.nudPortions.Size = New System.Drawing.Size(50, 20)
        Me.nudPortions.TabIndex = 128
        Me.nudPortions.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblPortions
        '
        Me.lblPortions.AutoSize = True
        Me.lblPortions.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPortions.Location = New System.Drawing.Point(567, 273)
        Me.lblPortions.Name = "lblPortions"
        Me.lblPortions.Size = New System.Drawing.Size(56, 13)
        Me.lblPortions.TabIndex = 142
        Me.lblPortions.Text = "Portions :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(217, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(191, 28)
        Me.Label6.TabIndex = 141
        Me.Label6.Text = "Étapes de réalisation"
        '
        'txtEtapes
        '
        Me.txtEtapes.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEtapes.Location = New System.Drawing.Point(194, 144)
        Me.txtEtapes.Name = "txtEtapes"
        Me.txtEtapes.Size = New System.Drawing.Size(280, 342)
        Me.txtEtapes.TabIndex = 140
        Me.txtEtapes.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(705, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 13)
        Me.Label5.TabIndex = 139
        Me.Label5.Text = "à"
        '
        'txtFaraneith
        '
        Me.txtFaraneith.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFaraneith.Location = New System.Drawing.Point(745, 231)
        Me.txtFaraneith.Name = "txtFaraneith"
        Me.txtFaraneith.Size = New System.Drawing.Size(50, 21)
        Me.txtFaraneith.TabIndex = 126
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(801, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 13)
        Me.Label4.TabIndex = 138
        Me.Label4.Text = "ºF"
        '
        'lblCuisson
        '
        Me.lblCuisson.AutoSize = True
        Me.lblCuisson.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuisson.Location = New System.Drawing.Point(511, 234)
        Me.lblCuisson.Name = "lblCuisson"
        Me.lblCuisson.Size = New System.Drawing.Size(103, 13)
        Me.lblCuisson.TabIndex = 137
        Me.lblCuisson.Text = "Temps de cuisson :"
        '
        'txtCuisson
        '
        Me.txtCuisson.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuisson.Location = New System.Drawing.Point(635, 231)
        Me.txtCuisson.Name = "txtCuisson"
        Me.txtCuisson.Size = New System.Drawing.Size(50, 21)
        Me.txtCuisson.TabIndex = 125
        '
        'lblPreparation
        '
        Me.lblPreparation.AutoSize = True
        Me.lblPreparation.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreparation.Location = New System.Drawing.Point(489, 191)
        Me.lblPreparation.Name = "lblPreparation"
        Me.lblPreparation.Size = New System.Drawing.Size(128, 13)
        Me.lblPreparation.TabIndex = 136
        Me.lblPreparation.Text = "Temps de préparation : "
        '
        'txtPreparation
        '
        Me.txtPreparation.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreparation.Location = New System.Drawing.Point(635, 187)
        Me.txtPreparation.Name = "txtPreparation"
        Me.txtPreparation.Size = New System.Drawing.Size(60, 21)
        Me.txtPreparation.TabIndex = 124
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.Location = New System.Drawing.Point(491, 147)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(103, 13)
        Me.lblNom.TabIndex = 135
        Me.lblNom.Text = "Nom de la recette :"
        '
        'txtNom
        '
        Me.txtNom.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.Location = New System.Drawing.Point(615, 144)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(254, 21)
        Me.txtNom.TabIndex = 123
        '
        'picRecette
        '
        Me.picRecette.BackColor = System.Drawing.SystemColors.Control
        Me.picRecette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picRecette.Location = New System.Drawing.Point(39, 130)
        Me.picRecette.Name = "picRecette"
        Me.picRecette.Size = New System.Drawing.Size(149, 147)
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
        Me.btnEnregistrer.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnregistrer.ForeColor = System.Drawing.Color.White
        Me.btnEnregistrer.Location = New System.Drawing.Point(676, 606)
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
        Me.btnAnnuler.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnuler.ForeColor = System.Drawing.Color.White
        Me.btnAnnuler.Location = New System.Drawing.Point(773, 606)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(91, 35)
        Me.btnAnnuler.TabIndex = 133
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = False
        '
        'frmAjoutRecettes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1472, 939)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.cbUnite)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSupprimerAllergies)
        Me.Controls.Add(Me.cbRefroid)
        Me.Controls.Add(Me.cbConservation)
        Me.Controls.Add(Me.cbPortions)
        Me.Controls.Add(Me.txtPortions)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtRemarques)
        Me.Controls.Add(Me.chkCongelable)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtRefroid)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCategorie)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtConservation)
        Me.Controls.Add(Me.btnAllergies)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAllergies)
        Me.Controls.Add(Me.lstAllergies)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCelcius)
        Me.Controls.Add(Me.txtQuantite)
        Me.Controls.Add(Me.Supprimer)
        Me.Controls.Add(Me.lblUnite)
        Me.Controls.Add(Me.lblAliments)
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
        Me.Name = "frmAjoutRecettes"
        Me.Text = "frmAjoutRecettes"
        CType(Me.nudPortions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRecette, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents cbUnite As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSupprimerAllergies As Button
    Friend WithEvents cbRefroid As ComboBox
    Friend WithEvents cbConservation As ComboBox
    Friend WithEvents cbPortions As ComboBox
    Friend WithEvents txtPortions As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblId As Label
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
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAllergies As TextBox
    Friend WithEvents lstAllergies As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCelcius As TextBox
    Friend WithEvents txtQuantite As TextBox
    Friend WithEvents Supprimer As Button
    Friend WithEvents lblUnite As Label
    Friend WithEvents lblAliments As Label
    Friend WithEvents lsvProduit As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Quantité As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents btnAjouter As Button
    Friend WithEvents lblQuantite As Label
    Friend WithEvents cbProduit As ComboBox
    Friend WithEvents lblAjouter As Label
    Friend WithEvents nudPortions As NumericUpDown
    Friend WithEvents lblPortions As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEtapes As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFaraneith As TextBox
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
End Class
