<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduits
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProduits))
        Me.ckPerissable = New System.Windows.Forms.CheckBox()
        Me.ckTaxeFederale = New System.Windows.Forms.CheckBox()
        Me.lblCategorie = New System.Windows.Forms.Label()
        Me.ckTaxeProvinciale = New System.Windows.Forms.CheckBox()
        Me.cmbCategorie = New System.Windows.Forms.ComboBox()
        Me.txtDescription2 = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ckPerissable2 = New System.Windows.Forms.CheckBox()
        Me.ckTaxeFederale2 = New System.Windows.Forms.CheckBox()
        Me.ckTaxeProvinciale2 = New System.Windows.Forms.CheckBox()
        Me.lblCategorie2 = New System.Windows.Forms.Label()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        Me.cmbCategorie2 = New System.Windows.Forms.ComboBox()
        Me.btnAnnulerModification = New System.Windows.Forms.Button()
        Me.btnEnregistrer = New System.Windows.Forms.Button()
        Me.btnAnnulerAjout = New System.Windows.Forms.Button()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.lblAjouter = New System.Windows.Forms.Label()
        Me.txtAjouter = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRechercher = New System.Windows.Forms.Button()
        Me.gbAjouter = New System.Windows.Forms.GroupBox()
        Me.txtDescription = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVoirAjouter = New System.Windows.Forms.Button()
        Me.gbModifier = New System.Windows.Forms.GroupBox()
        Me.lblModifier = New System.Windows.Forms.Label()
        Me.txtModifier = New System.Windows.Forms.TextBox()
        Me.lsvProduits = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtRechercher = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.gbAjouter.SuspendLayout()
        Me.gbModifier.SuspendLayout()
        Me.SuspendLayout()
        '
        'ckPerissable
        '
        Me.ckPerissable.AutoSize = True
        Me.ckPerissable.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ckPerissable.Location = New System.Drawing.Point(97, 240)
        Me.ckPerissable.Name = "ckPerissable"
        Me.ckPerissable.Size = New System.Drawing.Size(77, 17)
        Me.ckPerissable.TabIndex = 69
        Me.ckPerissable.Text = "Périssable"
        Me.ckPerissable.UseVisualStyleBackColor = True
        '
        'ckTaxeFederale
        '
        Me.ckTaxeFederale.AutoSize = True
        Me.ckTaxeFederale.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ckTaxeFederale.Location = New System.Drawing.Point(316, 240)
        Me.ckTaxeFederale.Name = "ckTaxeFederale"
        Me.ckTaxeFederale.Size = New System.Drawing.Size(111, 17)
        Me.ckTaxeFederale.TabIndex = 68
        Me.ckTaxeFederale.Text = "Taxable Federale"
        Me.ckTaxeFederale.UseVisualStyleBackColor = True
        '
        'lblCategorie
        '
        Me.lblCategorie.AutoSize = True
        Me.lblCategorie.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblCategorie.Location = New System.Drawing.Point(71, 66)
        Me.lblCategorie.Name = "lblCategorie"
        Me.lblCategorie.Size = New System.Drawing.Size(63, 13)
        Me.lblCategorie.TabIndex = 61
        Me.lblCategorie.Text = "Categorie :"
        '
        'ckTaxeProvinciale
        '
        Me.ckTaxeProvinciale.AutoSize = True
        Me.ckTaxeProvinciale.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ckTaxeProvinciale.Location = New System.Drawing.Point(189, 240)
        Me.ckTaxeProvinciale.Name = "ckTaxeProvinciale"
        Me.ckTaxeProvinciale.Size = New System.Drawing.Size(122, 17)
        Me.ckTaxeProvinciale.TabIndex = 67
        Me.ckTaxeProvinciale.Text = "Taxable Provinciale"
        Me.ckTaxeProvinciale.UseVisualStyleBackColor = True
        '
        'cmbCategorie
        '
        Me.cmbCategorie.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmbCategorie.FormattingEnabled = True
        Me.cmbCategorie.Location = New System.Drawing.Point(153, 63)
        Me.cmbCategorie.Name = "cmbCategorie"
        Me.cmbCategorie.Size = New System.Drawing.Size(268, 21)
        Me.cmbCategorie.TabIndex = 60
        '
        'txtDescription2
        '
        Me.txtDescription2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDescription2.Location = New System.Drawing.Point(155, 103)
        Me.txtDescription2.Name = "txtDescription2"
        Me.txtDescription2.Size = New System.Drawing.Size(268, 85)
        Me.txtDescription2.TabIndex = 72
        Me.txtDescription2.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(70, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Description :"
        '
        'ckPerissable2
        '
        Me.ckPerissable2.AutoSize = True
        Me.ckPerissable2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ckPerissable2.Location = New System.Drawing.Point(94, 240)
        Me.ckPerissable2.Name = "ckPerissable2"
        Me.ckPerissable2.Size = New System.Drawing.Size(77, 17)
        Me.ckPerissable2.TabIndex = 66
        Me.ckPerissable2.Text = "Périssable"
        Me.ckPerissable2.UseVisualStyleBackColor = True
        '
        'ckTaxeFederale2
        '
        Me.ckTaxeFederale2.AutoSize = True
        Me.ckTaxeFederale2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ckTaxeFederale2.Location = New System.Drawing.Point(316, 240)
        Me.ckTaxeFederale2.Name = "ckTaxeFederale2"
        Me.ckTaxeFederale2.Size = New System.Drawing.Size(111, 17)
        Me.ckTaxeFederale2.TabIndex = 65
        Me.ckTaxeFederale2.Text = "Taxable Fédérale"
        Me.ckTaxeFederale2.UseVisualStyleBackColor = True
        '
        'ckTaxeProvinciale2
        '
        Me.ckTaxeProvinciale2.AutoSize = True
        Me.ckTaxeProvinciale2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ckTaxeProvinciale2.Location = New System.Drawing.Point(189, 240)
        Me.ckTaxeProvinciale2.Name = "ckTaxeProvinciale2"
        Me.ckTaxeProvinciale2.Size = New System.Drawing.Size(122, 17)
        Me.ckTaxeProvinciale2.TabIndex = 64
        Me.ckTaxeProvinciale2.Text = "Taxable Provinciale"
        Me.ckTaxeProvinciale2.UseVisualStyleBackColor = True
        '
        'lblCategorie2
        '
        Me.lblCategorie2.AutoSize = True
        Me.lblCategorie2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblCategorie2.Location = New System.Drawing.Point(79, 66)
        Me.lblCategorie2.Name = "lblCategorie2"
        Me.lblCategorie2.Size = New System.Drawing.Size(63, 13)
        Me.lblCategorie2.TabIndex = 63
        Me.lblCategorie2.Text = "Categorie :"
        '
        'btnSupprimer
        '
        Me.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnSupprimer.Enabled = False
        Me.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupprimer.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnSupprimer.ForeColor = System.Drawing.Color.White
        Me.btnSupprimer.Location = New System.Drawing.Point(290, 290)
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Size = New System.Drawing.Size(90, 35)
        Me.btnSupprimer.TabIndex = 59
        Me.btnSupprimer.Text = "Supprimer"
        Me.btnSupprimer.UseVisualStyleBackColor = False
        '
        'cmbCategorie2
        '
        Me.cmbCategorie2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmbCategorie2.FormattingEnabled = True
        Me.cmbCategorie2.Location = New System.Drawing.Point(155, 62)
        Me.cmbCategorie2.Name = "cmbCategorie2"
        Me.cmbCategorie2.Size = New System.Drawing.Size(268, 21)
        Me.cmbCategorie2.TabIndex = 62
        '
        'btnAnnulerModification
        '
        Me.btnAnnulerModification.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnAnnulerModification.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnulerModification.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnAnnulerModification.ForeColor = System.Drawing.Color.White
        Me.btnAnnulerModification.Location = New System.Drawing.Point(386, 290)
        Me.btnAnnulerModification.Name = "btnAnnulerModification"
        Me.btnAnnulerModification.Size = New System.Drawing.Size(90, 35)
        Me.btnAnnulerModification.TabIndex = 57
        Me.btnAnnulerModification.Text = "Annuler"
        Me.btnAnnulerModification.UseVisualStyleBackColor = False
        '
        'btnEnregistrer
        '
        Me.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnregistrer.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnEnregistrer.ForeColor = System.Drawing.Color.White
        Me.btnEnregistrer.Location = New System.Drawing.Point(195, 290)
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.btnEnregistrer.Size = New System.Drawing.Size(90, 35)
        Me.btnEnregistrer.TabIndex = 56
        Me.btnEnregistrer.Text = "Enregistrer"
        Me.btnEnregistrer.UseVisualStyleBackColor = False
        '
        'btnAnnulerAjout
        '
        Me.btnAnnulerAjout.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnAnnulerAjout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnulerAjout.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnAnnulerAjout.ForeColor = System.Drawing.Color.White
        Me.btnAnnulerAjout.Location = New System.Drawing.Point(375, 288)
        Me.btnAnnulerAjout.Name = "btnAnnulerAjout"
        Me.btnAnnulerAjout.Size = New System.Drawing.Size(90, 35)
        Me.btnAnnulerAjout.TabIndex = 55
        Me.btnAnnulerAjout.Text = "Annuler"
        Me.btnAnnulerAjout.UseVisualStyleBackColor = False
        '
        'btnAjouter
        '
        Me.btnAjouter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjouter.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnAjouter.ForeColor = System.Drawing.Color.White
        Me.btnAjouter.Location = New System.Drawing.Point(283, 288)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(90, 35)
        Me.btnAjouter.TabIndex = 54
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = False
        '
        'lblAjouter
        '
        Me.lblAjouter.AutoSize = True
        Me.lblAjouter.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblAjouter.Location = New System.Drawing.Point(39, 28)
        Me.lblAjouter.Name = "lblAjouter"
        Me.lblAjouter.Size = New System.Drawing.Size(96, 13)
        Me.lblAjouter.TabIndex = 53
        Me.lblAjouter.Text = "Nom du produit :"
        '
        'txtAjouter
        '
        Me.txtAjouter.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtAjouter.Location = New System.Drawing.Point(153, 25)
        Me.txtAjouter.Name = "txtAjouter"
        Me.txtAjouter.Size = New System.Drawing.Size(268, 22)
        Me.txtAjouter.TabIndex = 52
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnRechercher)
        Me.Panel1.Controls.Add(Me.gbAjouter)
        Me.Panel1.Controls.Add(Me.btnVoirAjouter)
        Me.Panel1.Controls.Add(Me.gbModifier)
        Me.Panel1.Controls.Add(Me.lsvProduits)
        Me.Panel1.Controls.Add(Me.txtRechercher)
        Me.Panel1.Location = New System.Drawing.Point(240, 80)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1141, 654)
        Me.Panel1.TabIndex = 68
        '
        'btnRechercher
        '
        Me.btnRechercher.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnRechercher.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRechercher.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnRechercher.ForeColor = System.Drawing.Color.White
        Me.btnRechercher.Location = New System.Drawing.Point(317, 3)
        Me.btnRechercher.Name = "btnRechercher"
        Me.btnRechercher.Size = New System.Drawing.Size(91, 35)
        Me.btnRechercher.TabIndex = 61
        Me.btnRechercher.Text = "Rechercher"
        Me.btnRechercher.UseVisualStyleBackColor = False
        '
        'gbAjouter
        '
        Me.gbAjouter.Controls.Add(Me.txtDescription)
        Me.gbAjouter.Controls.Add(Me.Label1)
        Me.gbAjouter.Controls.Add(Me.ckPerissable)
        Me.gbAjouter.Controls.Add(Me.ckTaxeFederale)
        Me.gbAjouter.Controls.Add(Me.lblCategorie)
        Me.gbAjouter.Controls.Add(Me.ckTaxeProvinciale)
        Me.gbAjouter.Controls.Add(Me.cmbCategorie)
        Me.gbAjouter.Controls.Add(Me.btnAnnulerAjout)
        Me.gbAjouter.Controls.Add(Me.btnAjouter)
        Me.gbAjouter.Controls.Add(Me.lblAjouter)
        Me.gbAjouter.Controls.Add(Me.txtAjouter)
        Me.gbAjouter.Location = New System.Drawing.Point(5, 69)
        Me.gbAjouter.Name = "gbAjouter"
        Me.gbAjouter.Size = New System.Drawing.Size(500, 350)
        Me.gbAjouter.TabIndex = 65
        Me.gbAjouter.TabStop = False
        Me.gbAjouter.Text = "Ajouter"
        Me.gbAjouter.Visible = False
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDescription.Location = New System.Drawing.Point(153, 100)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(268, 98)
        Me.txtDescription.TabIndex = 71
        Me.txtDescription.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(62, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Description :"
        '
        'btnVoirAjouter
        '
        Me.btnVoirAjouter.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnVoirAjouter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnVoirAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVoirAjouter.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnVoirAjouter.ForeColor = System.Drawing.Color.White
        Me.btnVoirAjouter.Location = New System.Drawing.Point(414, 3)
        Me.btnVoirAjouter.Name = "btnVoirAjouter"
        Me.btnVoirAjouter.Size = New System.Drawing.Size(91, 35)
        Me.btnVoirAjouter.TabIndex = 57
        Me.btnVoirAjouter.Text = "Ajouter"
        Me.btnVoirAjouter.UseVisualStyleBackColor = False
        '
        'gbModifier
        '
        Me.gbModifier.Controls.Add(Me.txtDescription2)
        Me.gbModifier.Controls.Add(Me.Label2)
        Me.gbModifier.Controls.Add(Me.ckPerissable2)
        Me.gbModifier.Controls.Add(Me.ckTaxeFederale2)
        Me.gbModifier.Controls.Add(Me.ckTaxeProvinciale2)
        Me.gbModifier.Controls.Add(Me.lblCategorie2)
        Me.gbModifier.Controls.Add(Me.btnSupprimer)
        Me.gbModifier.Controls.Add(Me.cmbCategorie2)
        Me.gbModifier.Controls.Add(Me.btnAnnulerModification)
        Me.gbModifier.Controls.Add(Me.btnEnregistrer)
        Me.gbModifier.Controls.Add(Me.lblModifier)
        Me.gbModifier.Controls.Add(Me.txtModifier)
        Me.gbModifier.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gbModifier.Location = New System.Drawing.Point(594, 37)
        Me.gbModifier.Name = "gbModifier"
        Me.gbModifier.Size = New System.Drawing.Size(500, 350)
        Me.gbModifier.TabIndex = 64
        Me.gbModifier.TabStop = False
        Me.gbModifier.Visible = False
        '
        'lblModifier
        '
        Me.lblModifier.AutoSize = True
        Me.lblModifier.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblModifier.Location = New System.Drawing.Point(46, 32)
        Me.lblModifier.Name = "lblModifier"
        Me.lblModifier.Size = New System.Drawing.Size(99, 13)
        Me.lblModifier.TabIndex = 55
        Me.lblModifier.Text = "Nom du produit : "
        '
        'txtModifier
        '
        Me.txtModifier.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtModifier.Location = New System.Drawing.Point(155, 29)
        Me.txtModifier.Name = "txtModifier"
        Me.txtModifier.Size = New System.Drawing.Size(268, 22)
        Me.txtModifier.TabIndex = 54
        '
        'lsvProduits
        '
        Me.lsvProduits.BackColor = System.Drawing.Color.White
        Me.lsvProduits.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader5})
        Me.lsvProduits.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvProduits.FullRowSelect = True
        Me.lsvProduits.HideSelection = False
        Me.lsvProduits.Location = New System.Drawing.Point(3, 42)
        Me.lsvProduits.MultiSelect = False
        Me.lsvProduits.Name = "lsvProduits"
        Me.lsvProduits.Size = New System.Drawing.Size(501, 554)
        Me.lsvProduits.TabIndex = 63
        Me.lsvProduits.UseCompatibleStateImageBehavior = False
        Me.lsvProduits.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Produit"
        Me.ColumnHeader1.Width = 268
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Catégorie"
        Me.ColumnHeader5.Width = 289
        '
        'txtRechercher
        '
        Me.txtRechercher.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txtRechercher.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtRechercher.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtRechercher.Location = New System.Drawing.Point(3, 8)
        Me.txtRechercher.Name = "txtRechercher"
        Me.txtRechercher.Size = New System.Drawing.Size(301, 22)
        Me.txtRechercher.TabIndex = 60
        '
        'frmProduits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1684, 987)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProduits"
        Me.Text = "Produits"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbAjouter.ResumeLayout(False)
        Me.gbAjouter.PerformLayout()
        Me.gbModifier.ResumeLayout(False)
        Me.gbModifier.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtRechercher As TextBox
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents lsvProduits As ListView
    Friend WithEvents txtModifier As TextBox
    Friend WithEvents lblModifier As Label
    Friend WithEvents gbModifier As GroupBox
    Friend WithEvents btnVoirAjouter As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDescription As RichTextBox
    Friend WithEvents gbAjouter As GroupBox
    Friend WithEvents btnRechercher As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtAjouter As TextBox
    Friend WithEvents lblAjouter As Label
    Friend WithEvents btnAjouter As Button
    Friend WithEvents btnAnnulerAjout As Button
    Friend WithEvents btnEnregistrer As Button
    Friend WithEvents btnAnnulerModification As Button
    Friend WithEvents cmbCategorie2 As ComboBox
    Friend WithEvents btnSupprimer As Button
    Friend WithEvents lblCategorie2 As Label
    Friend WithEvents ckTaxeProvinciale2 As CheckBox
    Friend WithEvents ckTaxeFederale2 As CheckBox
    Friend WithEvents ckPerissable2 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDescription2 As RichTextBox
    Friend WithEvents cmbCategorie As ComboBox
    Friend WithEvents ckTaxeProvinciale As CheckBox
    Friend WithEvents lblCategorie As Label
    Friend WithEvents ckTaxeFederale As CheckBox
    Friend WithEvents ckPerissable As CheckBox
End Class
