<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFournisseurs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFournisseurs))
        Me.mainpanel = New System.Windows.Forms.Panel()
        Me.rdbDefaut = New System.Windows.Forms.RadioButton()
        Me.rdbVille = New System.Windows.Forms.RadioButton()
        Me.rdbNom = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRecherche = New System.Windows.Forms.TextBox()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        Me.lsvFournisseurs = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnRechercher = New System.Windows.Forms.Button()
        Me.mainpanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainpanel
        '
        Me.mainpanel.Controls.Add(Me.rdbDefaut)
        Me.mainpanel.Controls.Add(Me.rdbVille)
        Me.mainpanel.Controls.Add(Me.rdbNom)
        Me.mainpanel.Controls.Add(Me.Label1)
        Me.mainpanel.Controls.Add(Me.txtRecherche)
        Me.mainpanel.Controls.Add(Me.btnAjouter)
        Me.mainpanel.Controls.Add(Me.btnModifier)
        Me.mainpanel.Controls.Add(Me.btnSupprimer)
        Me.mainpanel.Controls.Add(Me.lsvFournisseurs)
        Me.mainpanel.Controls.Add(Me.BtnRechercher)
        Me.mainpanel.Location = New System.Drawing.Point(240, 80)
        Me.mainpanel.Name = "mainpanel"
        Me.mainpanel.Size = New System.Drawing.Size(702, 528)
        Me.mainpanel.TabIndex = 2
        '
        'rdbDefaut
        '
        Me.rdbDefaut.AutoSize = True
        Me.rdbDefaut.Location = New System.Drawing.Point(456, 59)
        Me.rdbDefaut.Name = "rdbDefaut"
        Me.rdbDefaut.Size = New System.Drawing.Size(121, 17)
        Me.rdbDefaut.TabIndex = 81
        Me.rdbDefaut.TabStop = True
        Me.rdbDefaut.Text = "Affichage par défaut"
        Me.rdbDefaut.UseVisualStyleBackColor = True
        '
        'rdbVille
        '
        Me.rdbVille.AutoSize = True
        Me.rdbVille.Location = New System.Drawing.Point(212, 55)
        Me.rdbVille.Name = "rdbVille"
        Me.rdbVille.Size = New System.Drawing.Size(44, 17)
        Me.rdbVille.TabIndex = 80
        Me.rdbVille.TabStop = True
        Me.rdbVille.Text = "Ville"
        Me.rdbVille.UseVisualStyleBackColor = True
        '
        'rdbNom
        '
        Me.rdbNom.AutoSize = True
        Me.rdbNom.Location = New System.Drawing.Point(142, 55)
        Me.rdbNom.Name = "rdbNom"
        Me.rdbNom.Size = New System.Drawing.Size(47, 17)
        Me.rdbNom.TabIndex = 79
        Me.rdbNom.TabStop = True
        Me.rdbNom.Text = "Nom"
        Me.rdbNom.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Rechercher selon:"
        '
        'txtRecherche
        '
        Me.txtRecherche.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txtRecherche.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRecherche.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtRecherche.Location = New System.Drawing.Point(142, 12)
        Me.txtRecherche.Name = "txtRecherche"
        Me.txtRecherche.Size = New System.Drawing.Size(301, 22)
        Me.txtRecherche.TabIndex = 77
        '
        'btnAjouter
        '
        Me.btnAjouter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAjouter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjouter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjouter.ForeColor = System.Drawing.Color.White
        Me.btnAjouter.Location = New System.Drawing.Point(412, 468)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(91, 35)
        Me.btnAjouter.TabIndex = 58
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = False
        '
        'btnModifier
        '
        Me.btnModifier.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModifier.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnModifier.Enabled = False
        Me.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifier.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifier.ForeColor = System.Drawing.Color.White
        Me.btnModifier.Location = New System.Drawing.Point(509, 468)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(91, 35)
        Me.btnModifier.TabIndex = 59
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.UseVisualStyleBackColor = False
        '
        'btnSupprimer
        '
        Me.btnSupprimer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnSupprimer.Enabled = False
        Me.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupprimer.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupprimer.ForeColor = System.Drawing.Color.White
        Me.btnSupprimer.Location = New System.Drawing.Point(606, 468)
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Size = New System.Drawing.Size(91, 35)
        Me.btnSupprimer.TabIndex = 60
        Me.btnSupprimer.Text = "Supprimer"
        Me.btnSupprimer.UseVisualStyleBackColor = False
        '
        'lsvFournisseurs
        '
        Me.lsvFournisseurs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lsvFournisseurs.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvFournisseurs.FullRowSelect = True
        Me.lsvFournisseurs.HideSelection = False
        Me.lsvFournisseurs.Location = New System.Drawing.Point(0, 90)
        Me.lsvFournisseurs.MultiSelect = False
        Me.lsvFournisseurs.Name = "lsvFournisseurs"
        Me.lsvFournisseurs.Size = New System.Drawing.Size(697, 372)
        Me.lsvFournisseurs.TabIndex = 57
        Me.lsvFournisseurs.UseCompatibleStateImageBehavior = False
        Me.lsvFournisseurs.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nom fournisseur"
        Me.ColumnHeader1.Width = 305
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Adresse"
        Me.ColumnHeader2.Width = 178
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Ville"
        Me.ColumnHeader3.Width = 197
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Personne Contact"
        '
        'BtnRechercher
        '
        Me.BtnRechercher.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRechercher.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BtnRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRechercher.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRechercher.ForeColor = System.Drawing.Color.White
        Me.BtnRechercher.Location = New System.Drawing.Point(456, 7)
        Me.BtnRechercher.Name = "BtnRechercher"
        Me.BtnRechercher.Size = New System.Drawing.Size(91, 35)
        Me.BtnRechercher.TabIndex = 56
        Me.BtnRechercher.Text = "Rechercher"
        Me.BtnRechercher.UseVisualStyleBackColor = False
        '
        'frmFournisseurs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 630)
        Me.Controls.Add(Me.mainpanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFournisseurs"
        Me.Text = "Fournisseurs"
        Me.mainpanel.ResumeLayout(False)
        Me.mainpanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainpanel As Panel
    Friend WithEvents btnAjouter As Button
    Friend WithEvents btnModifier As Button
    Friend WithEvents btnSupprimer As Button
    Friend WithEvents lsvFournisseurs As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents BtnRechercher As Button
    Friend WithEvents txtRecherche As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rdbVille As RadioButton
    Friend WithEvents rdbNom As RadioButton
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents rdbDefaut As RadioButton
End Class
