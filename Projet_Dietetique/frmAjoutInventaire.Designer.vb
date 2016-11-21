<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAjoutInventaire
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAjoutInventaire))
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFormat = New System.Windows.Forms.TextBox()
        Me.cmbEquivalence = New System.Windows.Forms.ComboBox()
        Me.txtEquivalence = New System.Windows.Forms.TextBox()
        Me.lblEquivalence = New System.Windows.Forms.Label()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpPeremption = New System.Windows.Forms.DateTimePicker()
        Me.dtpReception = New System.Windows.Forms.DateTimePicker()
        Me.txtDescription = New System.Windows.Forms.RichTextBox()
        Me.cmbUnite = New System.Windows.Forms.ComboBox()
        Me.txtQuantite = New System.Windows.Forms.TextBox()
        Me.cmbProduit = New System.Windows.Forms.ComboBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblTotal.Location = New System.Drawing.Point(301, 287)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblTotal.TabIndex = 69
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtTotal.Location = New System.Drawing.Point(196, 284)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(91, 22)
        Me.txtTotal.TabIndex = 68
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(68, 287)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 13)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Total en inventaire :"
        '
        'txtFormat
        '
        Me.txtFormat.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtFormat.Location = New System.Drawing.Point(198, 195)
        Me.txtFormat.Name = "txtFormat"
        Me.txtFormat.Size = New System.Drawing.Size(92, 22)
        Me.txtFormat.TabIndex = 66
        Me.txtFormat.Text = "1"
        '
        'cmbEquivalence
        '
        Me.cmbEquivalence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEquivalence.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmbEquivalence.FormattingEnabled = True
        Me.cmbEquivalence.Location = New System.Drawing.Point(297, 237)
        Me.cmbEquivalence.Name = "cmbEquivalence"
        Me.cmbEquivalence.Size = New System.Drawing.Size(72, 21)
        Me.cmbEquivalence.TabIndex = 65
        '
        'txtEquivalence
        '
        Me.txtEquivalence.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtEquivalence.Location = New System.Drawing.Point(198, 237)
        Me.txtEquivalence.Name = "txtEquivalence"
        Me.txtEquivalence.Size = New System.Drawing.Size(91, 22)
        Me.txtEquivalence.TabIndex = 64
        '
        'lblEquivalence
        '
        Me.lblEquivalence.AutoSize = True
        Me.lblEquivalence.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblEquivalence.Location = New System.Drawing.Point(59, 240)
        Me.lblEquivalence.Name = "lblEquivalence"
        Me.lblEquivalence.Size = New System.Drawing.Size(121, 13)
        Me.lblEquivalence.TabIndex = 63
        Me.lblEquivalence.Text = "Equivalence par unité:"
        '
        'btnAnnuler
        '
        Me.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnuler.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnAnnuler.ForeColor = System.Drawing.Color.White
        Me.btnAnnuler.Location = New System.Drawing.Point(429, 562)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(90, 35)
        Me.btnAnnuler.TabIndex = 62
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = False
        '
        'btnAjouter
        '
        Me.btnAjouter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjouter.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnAjouter.ForeColor = System.Drawing.Color.White
        Me.btnAjouter.Location = New System.Drawing.Point(333, 562)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(90, 35)
        Me.btnAjouter.TabIndex = 61
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(65, 384)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 13)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Date de péremption :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(71, 331)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 13)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Date de réception :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(102, 438)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Description :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(126, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Format :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(116, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Quantité : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(134, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Nom :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(123, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Produit :"
        '
        'dtpPeremption
        '
        Me.dtpPeremption.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.dtpPeremption.Location = New System.Drawing.Point(199, 382)
        Me.dtpPeremption.MinDate = New Date(1753, 5, 16, 0, 0, 0, 0)
        Me.dtpPeremption.Name = "dtpPeremption"
        Me.dtpPeremption.Size = New System.Drawing.Size(200, 22)
        Me.dtpPeremption.TabIndex = 53
        '
        'dtpReception
        '
        Me.dtpReception.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.dtpReception.Location = New System.Drawing.Point(199, 328)
        Me.dtpReception.Name = "dtpReception"
        Me.dtpReception.Size = New System.Drawing.Size(200, 22)
        Me.dtpReception.TabIndex = 52
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtDescription.Location = New System.Drawing.Point(198, 438)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(321, 96)
        Me.txtDescription.TabIndex = 51
        Me.txtDescription.Text = ""
        '
        'cmbUnite
        '
        Me.cmbUnite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUnite.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmbUnite.FormattingEnabled = True
        Me.cmbUnite.Location = New System.Drawing.Point(298, 194)
        Me.cmbUnite.Name = "cmbUnite"
        Me.cmbUnite.Size = New System.Drawing.Size(71, 21)
        Me.cmbUnite.TabIndex = 50
        '
        'txtQuantite
        '
        Me.txtQuantite.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtQuantite.Location = New System.Drawing.Point(198, 155)
        Me.txtQuantite.Name = "txtQuantite"
        Me.txtQuantite.Size = New System.Drawing.Size(92, 22)
        Me.txtQuantite.TabIndex = 49
        Me.txtQuantite.Text = "1"
        '
        'cmbProduit
        '
        Me.cmbProduit.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cmbProduit.FormattingEnabled = True
        Me.cmbProduit.Location = New System.Drawing.Point(198, 68)
        Me.cmbProduit.Name = "cmbProduit"
        Me.cmbProduit.Size = New System.Drawing.Size(201, 21)
        Me.cmbProduit.TabIndex = 48
        '
        'txtNom
        '
        Me.txtNom.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtNom.Location = New System.Drawing.Point(198, 115)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(321, 22)
        Me.txtNom.TabIndex = 47
        '
        'frmAjoutInventaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(579, 615)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtFormat)
        Me.Controls.Add(Me.cmbEquivalence)
        Me.Controls.Add(Me.txtEquivalence)
        Me.Controls.Add(Me.lblEquivalence)
        Me.Controls.Add(Me.btnAnnuler)
        Me.Controls.Add(Me.btnAjouter)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpPeremption)
        Me.Controls.Add(Me.dtpReception)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.cmbUnite)
        Me.Controls.Add(Me.txtQuantite)
        Me.Controls.Add(Me.cmbProduit)
        Me.Controls.Add(Me.txtNom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(595, 653)
        Me.MinimumSize = New System.Drawing.Size(595, 653)
        Me.Name = "frmAjoutInventaire"
        Me.Text = "Ajouter dans l'inventaire"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNom As TextBox
    Friend WithEvents cmbProduit As ComboBox
    Friend WithEvents txtQuantite As TextBox
    Friend WithEvents cmbUnite As ComboBox
    Friend WithEvents txtDescription As RichTextBox
    Friend WithEvents dtpReception As DateTimePicker
    Friend WithEvents dtpPeremption As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAjouter As Button
    Friend WithEvents btnAnnuler As Button
    Friend WithEvents lblEquivalence As Label
    Friend WithEvents txtEquivalence As TextBox
    Friend WithEvents cmbEquivalence As ComboBox
    Friend WithEvents txtFormat As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblTotal As Label
End Class
