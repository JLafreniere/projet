<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInventaire
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventaire))
        Me.btnDGV = New System.Windows.Forms.Button()
        Me.txtRechercher = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEnregistrer = New System.Windows.Forms.Button()
        Me.dtpReception = New System.Windows.Forms.DateTimePicker()
        Me.dtpPeremption = New System.Windows.Forms.DateTimePicker()
        Me.txtDescription = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblUnite = New System.Windows.Forms.Label()
        Me.txtQuantite = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.btnRechercher = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFormat = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblUniteEquivalence = New System.Windows.Forms.Label()
        Me.txtEquivalence = New System.Windows.Forms.TextBox()
        Me.lblEquivalence = New System.Windows.Forms.Label()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.gbInventaire = New System.Windows.Forms.GroupBox()
        Me.btnSupprimer = New System.Windows.Forms.Button()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.btnRetirer = New System.Windows.Forms.Button()
        Me.btnRetourner = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblAucun = New System.Windows.Forms.Label()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInventaire.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDGV
        '
        Me.btnDGV.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnDGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDGV.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnDGV.ForeColor = System.Drawing.Color.White
        Me.btnDGV.Location = New System.Drawing.Point(1203, 1)
        Me.btnDGV.Name = "btnDGV"
        Me.btnDGV.Size = New System.Drawing.Size(90, 35)
        Me.btnDGV.TabIndex = 79
        Me.btnDGV.Text = "Grille"
        Me.btnDGV.UseVisualStyleBackColor = False
        '
        'txtRechercher
        '
        Me.txtRechercher.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txtRechercher.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRechercher.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtRechercher.Location = New System.Drawing.Point(3, 8)
        Me.txtRechercher.Name = "txtRechercher"
        Me.txtRechercher.Size = New System.Drawing.Size(301, 22)
        Me.txtRechercher.TabIndex = 76
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 320)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Date de péremption :"
        '
        'btnEnregistrer
        '
        Me.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnregistrer.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnEnregistrer.ForeColor = System.Drawing.Color.White
        Me.btnEnregistrer.Location = New System.Drawing.Point(185, 394)
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.btnEnregistrer.Size = New System.Drawing.Size(90, 35)
        Me.btnEnregistrer.TabIndex = 3
        Me.btnEnregistrer.Text = "Enregistrer"
        Me.btnEnregistrer.UseVisualStyleBackColor = False
        '
        'dtpReception
        '
        Me.dtpReception.Location = New System.Drawing.Point(147, 269)
        Me.dtpReception.Name = "dtpReception"
        Me.dtpReception.Size = New System.Drawing.Size(200, 22)
        Me.dtpReception.TabIndex = 14
        '
        'dtpPeremption
        '
        Me.dtpPeremption.Location = New System.Drawing.Point(147, 316)
        Me.dtpPeremption.MinDate = New Date(1754, 6, 12, 0, 0, 0, 0)
        Me.dtpPeremption.Name = "dtpPeremption"
        Me.dtpPeremption.Size = New System.Drawing.Size(200, 22)
        Me.dtpPeremption.TabIndex = 13
        Me.dtpPeremption.Value = New Date(2016, 11, 21, 15, 45, 14, 0)
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(147, 149)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(314, 96)
        Me.txtDescription.TabIndex = 12
        Me.txtDescription.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Description :"
        '
        'lblUnite
        '
        Me.lblUnite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblUnite.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnite.Location = New System.Drawing.Point(396, 72)
        Me.lblUnite.Name = "lblUnite"
        Me.lblUnite.Size = New System.Drawing.Size(65, 22)
        Me.lblUnite.TabIndex = 10
        Me.lblUnite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtQuantite
        '
        Me.txtQuantite.Location = New System.Drawing.Point(144, 72)
        Me.txtQuantite.Name = "txtQuantite"
        Me.txtQuantite.ShortcutsEnabled = False
        Me.txtQuantite.Size = New System.Drawing.Size(80, 22)
        Me.txtQuantite.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Quantité :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nom :"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(144, 30)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.ShortcutsEnabled = False
        Me.txtNom.Size = New System.Drawing.Size(317, 22)
        Me.txtNom.TabIndex = 5
        '
        'btnRechercher
        '
        Me.btnRechercher.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRechercher.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRechercher.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnRechercher.ForeColor = System.Drawing.Color.White
        Me.btnRechercher.Location = New System.Drawing.Point(317, 3)
        Me.btnRechercher.Name = "btnRechercher"
        Me.btnRechercher.Size = New System.Drawing.Size(91, 35)
        Me.btnRechercher.TabIndex = 77
        Me.btnRechercher.Text = "Rechercher"
        Me.btnRechercher.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Date de réception :"
        '
        'btnAjouter
        '
        Me.btnAjouter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjouter.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnAjouter.ForeColor = System.Drawing.Color.White
        Me.btnAjouter.Location = New System.Drawing.Point(414, 3)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(91, 35)
        Me.btnAjouter.TabIndex = 75
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(232, 354)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(65, 22)
        Me.lblTotal.TabIndex = 24
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(147, 356)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ShortcutsEnabled = False
        Me.txtTotal.Size = New System.Drawing.Size(80, 22)
        Me.txtTotal.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 359)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Total en inventaire :"
        '
        'txtFormat
        '
        Me.txtFormat.Location = New System.Drawing.Point(310, 72)
        Me.txtFormat.Name = "txtFormat"
        Me.txtFormat.ShortcutsEnabled = False
        Me.txtFormat.Size = New System.Drawing.Size(80, 22)
        Me.txtFormat.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(257, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Format :"
        '
        'lblUniteEquivalence
        '
        Me.lblUniteEquivalence.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblUniteEquivalence.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUniteEquivalence.Location = New System.Drawing.Point(396, 108)
        Me.lblUniteEquivalence.Name = "lblUniteEquivalence"
        Me.lblUniteEquivalence.Size = New System.Drawing.Size(65, 22)
        Me.lblUniteEquivalence.TabIndex = 19
        Me.lblUniteEquivalence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEquivalence
        '
        Me.txtEquivalence.Location = New System.Drawing.Point(310, 108)
        Me.txtEquivalence.Name = "txtEquivalence"
        Me.txtEquivalence.ShortcutsEnabled = False
        Me.txtEquivalence.Size = New System.Drawing.Size(80, 22)
        Me.txtEquivalence.TabIndex = 18
        '
        'lblEquivalence
        '
        Me.lblEquivalence.AutoSize = True
        Me.lblEquivalence.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblEquivalence.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquivalence.Location = New System.Drawing.Point(182, 113)
        Me.lblEquivalence.Name = "lblEquivalence"
        Me.lblEquivalence.Size = New System.Drawing.Size(124, 13)
        Me.lblEquivalence.TabIndex = 17
        Me.lblEquivalence.Text = "Équivalence par unité :"
        '
        'btnAnnuler
        '
        Me.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnuler.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnAnnuler.ForeColor = System.Drawing.Color.White
        Me.btnAnnuler.Location = New System.Drawing.Point(385, 394)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(90, 35)
        Me.btnAnnuler.TabIndex = 5
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = False
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.AllowUserToResizeColumns = False
        Me.dgvData.AllowUserToResizeRows = False
        Me.dgvData.BackgroundColor = System.Drawing.Color.White
        Me.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvData.GridColor = System.Drawing.SystemColors.Control
        Me.dgvData.Location = New System.Drawing.Point(2, 42)
        Me.dgvData.MultiSelect = False
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvData.Size = New System.Drawing.Size(1291, 642)
        Me.dgvData.TabIndex = 78
        Me.dgvData.Visible = False
        '
        'gbInventaire
        '
        Me.gbInventaire.Controls.Add(Me.lblTotal)
        Me.gbInventaire.Controls.Add(Me.txtTotal)
        Me.gbInventaire.Controls.Add(Me.Label7)
        Me.gbInventaire.Controls.Add(Me.txtFormat)
        Me.gbInventaire.Controls.Add(Me.Label6)
        Me.gbInventaire.Controls.Add(Me.lblUniteEquivalence)
        Me.gbInventaire.Controls.Add(Me.txtEquivalence)
        Me.gbInventaire.Controls.Add(Me.lblEquivalence)
        Me.gbInventaire.Controls.Add(Me.btnAnnuler)
        Me.gbInventaire.Controls.Add(Me.Label5)
        Me.gbInventaire.Controls.Add(Me.btnSupprimer)
        Me.gbInventaire.Controls.Add(Me.Label4)
        Me.gbInventaire.Controls.Add(Me.btnEnregistrer)
        Me.gbInventaire.Controls.Add(Me.dtpReception)
        Me.gbInventaire.Controls.Add(Me.dtpPeremption)
        Me.gbInventaire.Controls.Add(Me.txtDescription)
        Me.gbInventaire.Controls.Add(Me.Label3)
        Me.gbInventaire.Controls.Add(Me.lblUnite)
        Me.gbInventaire.Controls.Add(Me.txtQuantite)
        Me.gbInventaire.Controls.Add(Me.Label2)
        Me.gbInventaire.Controls.Add(Me.Label1)
        Me.gbInventaire.Controls.Add(Me.txtNom)
        Me.gbInventaire.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.gbInventaire.Location = New System.Drawing.Point(529, 42)
        Me.gbInventaire.Name = "gbInventaire"
        Me.gbInventaire.Size = New System.Drawing.Size(493, 445)
        Me.gbInventaire.TabIndex = 74
        Me.gbInventaire.TabStop = False
        Me.gbInventaire.Text = "Inventaire"
        Me.gbInventaire.Visible = False
        '
        'btnSupprimer
        '
        Me.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupprimer.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnSupprimer.ForeColor = System.Drawing.Color.White
        Me.btnSupprimer.Location = New System.Drawing.Point(285, 394)
        Me.btnSupprimer.Name = "btnSupprimer"
        Me.btnSupprimer.Size = New System.Drawing.Size(90, 35)
        Me.btnSupprimer.TabIndex = 4
        Me.btnSupprimer.Text = "Supprimer"
        Me.btnSupprimer.UseVisualStyleBackColor = False
        '
        'TreeView1
        '
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TreeView1.Location = New System.Drawing.Point(3, 42)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(500, 449)
        Me.TreeView1.TabIndex = 73
        '
        'btnRetirer
        '
        Me.btnRetirer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRetirer.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnRetirer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRetirer.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnRetirer.ForeColor = System.Drawing.Color.White
        Me.btnRetirer.Location = New System.Drawing.Point(834, 3)
        Me.btnRetirer.Name = "btnRetirer"
        Me.btnRetirer.Size = New System.Drawing.Size(91, 35)
        Me.btnRetirer.TabIndex = 81
        Me.btnRetirer.Text = "Retirer"
        Me.btnRetirer.UseVisualStyleBackColor = False
        '
        'btnRetourner
        '
        Me.btnRetourner.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnRetourner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRetourner.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnRetourner.ForeColor = System.Drawing.Color.White
        Me.btnRetourner.Location = New System.Drawing.Point(931, 3)
        Me.btnRetourner.Name = "btnRetourner"
        Me.btnRetourner.Size = New System.Drawing.Size(91, 35)
        Me.btnRetourner.TabIndex = 80
        Me.btnRetourner.Text = "Retourner"
        Me.btnRetourner.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblAucun)
        Me.Panel2.Controls.Add(Me.txtRechercher)
        Me.Panel2.Controls.Add(Me.btnRetirer)
        Me.Panel2.Controls.Add(Me.TreeView1)
        Me.Panel2.Controls.Add(Me.btnRetourner)
        Me.Panel2.Controls.Add(Me.gbInventaire)
        Me.Panel2.Controls.Add(Me.btnDGV)
        Me.Panel2.Controls.Add(Me.dgvData)
        Me.Panel2.Controls.Add(Me.btnAjouter)
        Me.Panel2.Controls.Add(Me.btnRechercher)
        Me.Panel2.Location = New System.Drawing.Point(240, 80)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1297, 832)
        Me.Panel2.TabIndex = 83
        '
        'lblAucun
        '
        Me.lblAucun.AutoSize = True
        Me.lblAucun.Font = New System.Drawing.Font("Segoe UI", 10.25!)
        Me.lblAucun.Location = New System.Drawing.Point(3, 44)
        Me.lblAucun.Name = "lblAucun"
        Me.lblAucun.Size = New System.Drawing.Size(101, 19)
        Me.lblAucun.TabIndex = 82
        Me.lblAucun.Text = "Aucun Résultat"
        Me.lblAucun.Visible = False
        '
        'frmInventaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1676, 987)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInventaire"
        Me.Text = "Inventaire"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInventaire.ResumeLayout(False)
        Me.gbInventaire.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents btnSupprimer As Button
    Friend WithEvents gbInventaire As GroupBox
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents btnAnnuler As Button
    Friend WithEvents lblEquivalence As Label
    Friend WithEvents txtEquivalence As TextBox
    Friend WithEvents lblUniteEquivalence As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtFormat As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnAjouter As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnRechercher As Button
    Friend WithEvents txtNom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtQuantite As TextBox
    Friend WithEvents lblUnite As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDescription As RichTextBox
    Friend WithEvents dtpPeremption As DateTimePicker
    Friend WithEvents dtpReception As DateTimePicker
    Friend WithEvents btnEnregistrer As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRechercher As TextBox
    Friend WithEvents btnDGV As Button
    Friend WithEvents btnRetirer As Button
    Friend WithEvents btnRetourner As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblAucun As Label
End Class
