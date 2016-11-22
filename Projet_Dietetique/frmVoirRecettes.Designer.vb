<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVoirRecettes
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVoirRecettes))
        Me.mainpanel = New System.Windows.Forms.Panel()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        Me.lsvRecette = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnRechercher = New System.Windows.Forms.Button()
        Me.txtRecherche = New System.Windows.Forms.TextBox()
        Me.mainpanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainpanel
        '
        Me.mainpanel.Controls.Add(Me.btnAjouter)
        Me.mainpanel.Controls.Add(Me.btnModifier)
        Me.mainpanel.Controls.Add(Me.btnSupprimer)
        Me.mainpanel.Controls.Add(Me.lsvRecette)
        Me.mainpanel.Controls.Add(Me.BtnRechercher)
        Me.mainpanel.Controls.Add(Me.txtRecherche)
        Me.mainpanel.Location = New System.Drawing.Point(330, 62)
        Me.mainpanel.Name = "mainpanel"
        Me.mainpanel.Size = New System.Drawing.Size(700, 483)
        Me.mainpanel.TabIndex = 1
        '
        'btnAjouter
        '
        Me.btnAjouter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAjouter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjouter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjouter.ForeColor = System.Drawing.Color.White
        Me.btnAjouter.Location = New System.Drawing.Point(414, 430)
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
        Me.btnModifier.Location = New System.Drawing.Point(511, 430)
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
        Me.btnSupprimer.Location = New System.Drawing.Point(608, 430)
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Size = New System.Drawing.Size(91, 35)
        Me.btnSupprimer.TabIndex = 60
        Me.btnSupprimer.Text = "Supprimer"
        Me.btnSupprimer.UseVisualStyleBackColor = False
        '
        'lsvRecette
        '
        Me.lsvRecette.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lsvRecette.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvRecette.FullRowSelect = True
        Me.lsvRecette.HideSelection = False
        Me.lsvRecette.Location = New System.Drawing.Point(3, 52)
        Me.lsvRecette.MultiSelect = False
        Me.lsvRecette.Name = "lsvRecette"
        Me.lsvRecette.Size = New System.Drawing.Size(694, 372)
        Me.lsvRecette.TabIndex = 57
        Me.lsvRecette.UseCompatibleStateImageBehavior = False
        Me.lsvRecette.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nom Recette"
        Me.ColumnHeader1.Width = 325
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Temps de préparation"
        Me.ColumnHeader2.Width = 178
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Temps de cuisson"
        Me.ColumnHeader3.Width = 207
        '
        'BtnRechercher
        '
        Me.BtnRechercher.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRechercher.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BtnRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRechercher.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRechercher.ForeColor = System.Drawing.Color.White
        Me.BtnRechercher.Location = New System.Drawing.Point(566, 11)
        Me.BtnRechercher.Name = "BtnRechercher"
        Me.BtnRechercher.Size = New System.Drawing.Size(90, 35)
        Me.BtnRechercher.TabIndex = 56
        Me.BtnRechercher.Text = "Rechercher"
        Me.BtnRechercher.UseVisualStyleBackColor = False
        '
        'txtRecherche
        '
        Me.txtRecherche.Location = New System.Drawing.Point(212, 19)
        Me.txtRecherche.Name = "txtRecherche"
        Me.txtRecherche.Size = New System.Drawing.Size(350, 20)
        Me.txtRecherche.TabIndex = 0
        '
        'frmVoirRecettes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1684, 987)
        Me.Controls.Add(Me.mainpanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVoirRecettes"
        Me.Text = "Recettes"
        Me.mainpanel.ResumeLayout(False)
        Me.mainpanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainpanel As Panel
    Friend WithEvents btnAjouter As Button
    Friend WithEvents btnModifier As Button
    Friend WithEvents btnSupprimer As Button
    Friend WithEvents lsvRecette As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents BtnRechercher As Button
    Friend WithEvents txtRecherche As TextBox
End Class
