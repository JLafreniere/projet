﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAjoutCommandes
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
        Me.nudQuantite = New System.Windows.Forms.NumericUpDown()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lsvProduits = New System.Windows.Forms.ListView()
        Me.btnSupprimerListiew = New System.Windows.Forms.Button()
        Me.btnAjouterProduit = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.btnEnregistrer = New System.Windows.Forms.Button()
        Me.txtNotes = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbProduits = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbFournisseurs = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEnvoyer = New System.Windows.Forms.Button()
        CType(Me.nudQuantite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nudQuantite
        '
        Me.nudQuantite.Location = New System.Drawing.Point(885, 324)
        Me.nudQuantite.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudQuantite.Name = "nudQuantite"
        Me.nudQuantite.Size = New System.Drawing.Size(58, 20)
        Me.nudQuantite.TabIndex = 92
        Me.nudQuantite.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Total"
        Me.ColumnHeader3.Width = 197
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre"
        Me.ColumnHeader2.Width = 178
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Produit"
        Me.ColumnHeader1.Width = 305
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(829, 326)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Quantité"
        '
        'lsvProduits
        '
        Me.lsvProduits.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lsvProduits.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsvProduits.HideSelection = False
        Me.lsvProduits.Location = New System.Drawing.Point(496, 123)
        Me.lsvProduits.MultiSelect = False
        Me.lsvProduits.Name = "lsvProduits"
        Me.lsvProduits.Size = New System.Drawing.Size(584, 169)
        Me.lsvProduits.TabIndex = 90
        Me.lsvProduits.UseCompatibleStateImageBehavior = False
        Me.lsvProduits.View = System.Windows.Forms.View.Details
        '
        'btnSupprimerListiew
        '
        Me.btnSupprimerListiew.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnSupprimerListiew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupprimerListiew.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupprimerListiew.ForeColor = System.Drawing.Color.White
        Me.btnSupprimerListiew.Location = New System.Drawing.Point(885, 356)
        Me.btnSupprimerListiew.Name = "btnSupprimerListiew"
        Me.btnSupprimerListiew.Size = New System.Drawing.Size(91, 35)
        Me.btnSupprimerListiew.TabIndex = 89
        Me.btnSupprimerListiew.Text = "Supprimer"
        Me.btnSupprimerListiew.UseVisualStyleBackColor = False
        '
        'btnAjouterProduit
        '
        Me.btnAjouterProduit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnAjouterProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjouterProduit.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjouterProduit.ForeColor = System.Drawing.Color.White
        Me.btnAjouterProduit.Location = New System.Drawing.Point(788, 356)
        Me.btnAjouterProduit.Name = "btnAjouterProduit"
        Me.btnAjouterProduit.Size = New System.Drawing.Size(91, 35)
        Me.btnAjouterProduit.TabIndex = 88
        Me.btnAjouterProduit.Text = "Ajouter"
        Me.btnAjouterProduit.UseVisualStyleBackColor = False
        '
        'btnAnnuler
        '
        Me.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnuler.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnuler.ForeColor = System.Drawing.Color.White
        Me.btnAnnuler.Location = New System.Drawing.Point(551, 445)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(91, 35)
        Me.btnAnnuler.TabIndex = 87
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = False
        '
        'btnEnregistrer
        '
        Me.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnregistrer.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnregistrer.ForeColor = System.Drawing.Color.White
        Me.btnEnregistrer.Location = New System.Drawing.Point(454, 445)
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.btnEnregistrer.Size = New System.Drawing.Size(91, 35)
        Me.btnEnregistrer.TabIndex = 86
        Me.btnEnregistrer.Text = "Enregistrer"
        Me.btnEnregistrer.UseVisualStyleBackColor = False
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(176, 179)
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(200, 96)
        Me.txtNotes.TabIndex = 85
        Me.txtNotes.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(58, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "Notes"
        '
        'cbProduits
        '
        Me.cbProduits.FormattingEnabled = True
        Me.cbProduits.Location = New System.Drawing.Point(593, 318)
        Me.cbProduits.Name = "cbProduits"
        Me.cbProduits.Size = New System.Drawing.Size(200, 21)
        Me.cbProduits.TabIndex = 83
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(475, 321)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Ajouter un produit"
        '
        'cbFournisseurs
        '
        Me.cbFournisseurs.FormattingEnabled = True
        Me.cbFournisseurs.Location = New System.Drawing.Point(175, 143)
        Me.cbFournisseurs.Name = "cbFournisseurs"
        Me.cbFournisseurs.Size = New System.Drawing.Size(200, 21)
        Me.cbFournisseurs.TabIndex = 81
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Nom du fournisseur"
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(175, 113)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpDate.TabIndex = 79
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Date de la commande"
        '
        'btnEnvoyer
        '
        Me.btnEnvoyer.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnEnvoyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnvoyer.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnvoyer.ForeColor = System.Drawing.Color.White
        Me.btnEnvoyer.Location = New System.Drawing.Point(357, 445)
        Me.btnEnvoyer.Name = "btnEnvoyer"
        Me.btnEnvoyer.Size = New System.Drawing.Size(91, 35)
        Me.btnEnvoyer.TabIndex = 93
        Me.btnEnvoyer.Text = "Envoyer"
        Me.btnEnvoyer.UseVisualStyleBackColor = False
        '
        'frmAjoutCommandes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1138, 592)
        Me.Controls.Add(Me.btnEnvoyer)
        Me.Controls.Add(Me.nudQuantite)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lsvProduits)
        Me.Controls.Add(Me.btnSupprimerListiew)
        Me.Controls.Add(Me.btnAjouterProduit)
        Me.Controls.Add(Me.btnAnnuler)
        Me.Controls.Add(Me.btnEnregistrer)
        Me.Controls.Add(Me.txtNotes)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbProduits)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbFournisseurs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAjoutCommandes"
        Me.Text = "frmAjoutCommandes"
        CType(Me.nudQuantite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nudQuantite As NumericUpDown
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Label4 As Label
    Friend WithEvents lsvProduits As ListView
    Friend WithEvents btnSupprimerListiew As Button
    Friend WithEvents btnAjouterProduit As Button
    Friend WithEvents btnAnnuler As Button
    Friend WithEvents btnEnregistrer As Button
    Friend WithEvents txtNotes As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbProduits As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbFournisseurs As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEnvoyer As Button
End Class
