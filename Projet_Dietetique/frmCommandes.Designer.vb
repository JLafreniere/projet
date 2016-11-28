<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCommandes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCommandes))
        Me.mainpanel = New System.Windows.Forms.Panel()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.rdbFournisseur = New System.Windows.Forms.RadioButton()
        Me.rdbDate = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.btnModifier = New System.Windows.Forms.Button()
        Me.lsvCommandes = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Total = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnRechercher = New System.Windows.Forms.Button()
        Me.txtRecherche = New System.Windows.Forms.TextBox()
        Me.btnReception = New System.Windows.Forms.Button()
        Me.rdbDefaut = New System.Windows.Forms.RadioButton()
        Me.mainpanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainpanel
        '
        Me.mainpanel.Controls.Add(Me.rdbDefaut)
        Me.mainpanel.Controls.Add(Me.btnReception)
        Me.mainpanel.Controls.Add(Me.dtpDate)
        Me.mainpanel.Controls.Add(Me.rdbFournisseur)
        Me.mainpanel.Controls.Add(Me.rdbDate)
        Me.mainpanel.Controls.Add(Me.Label1)
        Me.mainpanel.Controls.Add(Me.btnAjouter)
        Me.mainpanel.Controls.Add(Me.btnModifier)
        Me.mainpanel.Controls.Add(Me.lsvCommandes)
        Me.mainpanel.Controls.Add(Me.BtnRechercher)
        Me.mainpanel.Controls.Add(Me.txtRecherche)
        Me.mainpanel.Location = New System.Drawing.Point(311, 57)
        Me.mainpanel.Name = "mainpanel"
        Me.mainpanel.Size = New System.Drawing.Size(702, 483)
        Me.mainpanel.TabIndex = 3
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(320, 18)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(184, 20)
        Me.dtpDate.TabIndex = 65
        '
        'rdbFournisseur
        '
        Me.rdbFournisseur.AutoSize = True
        Me.rdbFournisseur.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbFournisseur.Location = New System.Drawing.Point(79, 55)
        Me.rdbFournisseur.Name = "rdbFournisseur"
        Me.rdbFournisseur.Size = New System.Drawing.Size(86, 17)
        Me.rdbFournisseur.TabIndex = 64
        Me.rdbFournisseur.TabStop = True
        Me.rdbFournisseur.Text = "Fournisseur"
        Me.rdbFournisseur.UseVisualStyleBackColor = True
        '
        'rdbDate
        '
        Me.rdbDate.AutoSize = True
        Me.rdbDate.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbDate.Location = New System.Drawing.Point(24, 55)
        Me.rdbDate.Name = "rdbDate"
        Me.rdbDate.Size = New System.Drawing.Size(49, 17)
        Me.rdbDate.TabIndex = 62
        Me.rdbDate.TabStop = True
        Me.rdbDate.Text = "Date"
        Me.rdbDate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Rechercher selon:"
        '
        'btnAjouter
        '
        Me.btnAjouter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAjouter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjouter.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjouter.ForeColor = System.Drawing.Color.White
        Me.btnAjouter.Location = New System.Drawing.Point(398, 430)
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
        Me.btnModifier.Location = New System.Drawing.Point(495, 430)
        Me.btnModifier.Name = "btnModifier"
        Me.btnModifier.Size = New System.Drawing.Size(91, 35)
        Me.btnModifier.TabIndex = 59
        Me.btnModifier.Text = "Modifier"
        Me.btnModifier.UseVisualStyleBackColor = False
        '
        'lsvCommandes
        '
        Me.lsvCommandes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.Total})
        Me.lsvCommandes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvCommandes.HideSelection = False
        Me.lsvCommandes.Location = New System.Drawing.Point(2, 111)
        Me.lsvCommandes.MultiSelect = False
        Me.lsvCommandes.Name = "lsvCommandes"
        Me.lsvCommandes.Size = New System.Drawing.Size(697, 372)
        Me.lsvCommandes.TabIndex = 57
        Me.lsvCommandes.UseCompatibleStateImageBehavior = False
        Me.lsvCommandes.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Date"
        Me.ColumnHeader1.Width = 185
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Fournisseur"
        Me.ColumnHeader3.Width = 197
        '
        'Total
        '
        Me.Total.Text = "Total"
        Me.Total.Width = 74
        '
        'BtnRechercher
        '
        Me.BtnRechercher.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRechercher.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BtnRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRechercher.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRechercher.ForeColor = System.Drawing.Color.White
        Me.BtnRechercher.Location = New System.Drawing.Point(510, 11)
        Me.BtnRechercher.Name = "BtnRechercher"
        Me.BtnRechercher.Size = New System.Drawing.Size(91, 35)
        Me.BtnRechercher.TabIndex = 56
        Me.BtnRechercher.Text = "Rechercher"
        Me.BtnRechercher.UseVisualStyleBackColor = False
        '
        'txtRecherche
        '
        Me.txtRecherche.Location = New System.Drawing.Point(320, 19)
        Me.txtRecherche.Name = "txtRecherche"
        Me.txtRecherche.Size = New System.Drawing.Size(184, 20)
        Me.txtRecherche.TabIndex = 0
        '
        'btnReception
        '
        Me.btnReception.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReception.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnReception.Enabled = False
        Me.btnReception.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReception.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReception.ForeColor = System.Drawing.Color.White
        Me.btnReception.Location = New System.Drawing.Point(592, 430)
        Me.btnReception.Name = "btnReception"
        Me.btnReception.Size = New System.Drawing.Size(91, 35)
        Me.btnReception.TabIndex = 66
        Me.btnReception.Text = "Réception"
        Me.btnReception.UseVisualStyleBackColor = False
        '
        'rdbDefaut
        '
        Me.rdbDefaut.AutoSize = True
        Me.rdbDefaut.Location = New System.Drawing.Point(291, 55)
        Me.rdbDefaut.Name = "rdbDefaut"
        Me.rdbDefaut.Size = New System.Drawing.Size(121, 17)
        Me.rdbDefaut.TabIndex = 67
        Me.rdbDefaut.TabStop = True
        Me.rdbDefaut.Text = "Affichage par défaut"
        Me.rdbDefaut.UseVisualStyleBackColor = True
        '
        'frmCommandes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1325, 597)
        Me.Controls.Add(Me.mainpanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCommandes"
        Me.Text = "Commandes"
        Me.mainpanel.ResumeLayout(False)
        Me.mainpanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtRecherche As TextBox
    Friend WithEvents BtnRechercher As Button
    Friend WithEvents Total As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents lsvCommandes As ListView
    Friend WithEvents btnModifier As Button
    Friend WithEvents btnAjouter As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents rdbDate As RadioButton
    Friend WithEvents rdbFournisseur As RadioButton
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents mainpanel As Panel
    Friend WithEvents btnReception As Button
    Friend WithEvents rdbDefaut As RadioButton
End Class
