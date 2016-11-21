<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAgenda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgenda))
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.rbtype1 = New System.Windows.Forms.RadioButton()
        Me.rbtype2 = New System.Windows.Forms.RadioButton()
        Me.rbtype3 = New System.Windows.Forms.RadioButton()
        Me.rbtype4 = New System.Windows.Forms.RadioButton()
        Me.txtNomEvenement = New System.Windows.Forms.TextBox()
        Me.dt_date_evenement = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtTitreMessage = New System.Windows.Forms.TextBox()
        Me.txtMessage = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEnregistrerMessage = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dpDebutAffichage = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dpFinAffichage = New System.Windows.Forms.DateTimePicker()
        Me.cbPeriodeAffichage = New System.Windows.Forms.CheckBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.cbRecettes = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAjouter
        '
        Me.btnAjouter.Location = New System.Drawing.Point(128, 188)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(75, 23)
        Me.btnAjouter.TabIndex = 0
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = True
        '
        'rbtype1
        '
        Me.rbtype1.AutoSize = True
        Me.rbtype1.Location = New System.Drawing.Point(3, 75)
        Me.rbtype1.Name = "rbtype1"
        Me.rbtype1.Size = New System.Drawing.Size(58, 17)
        Me.rbtype1.TabIndex = 1
        Me.rbtype1.TabStop = True
        Me.rbtype1.Tag = "1"
        Me.rbtype1.Text = "Type 1"
        Me.rbtype1.UseVisualStyleBackColor = True
        '
        'rbtype2
        '
        Me.rbtype2.AutoSize = True
        Me.rbtype2.Location = New System.Drawing.Point(3, 98)
        Me.rbtype2.Name = "rbtype2"
        Me.rbtype2.Size = New System.Drawing.Size(58, 17)
        Me.rbtype2.TabIndex = 2
        Me.rbtype2.TabStop = True
        Me.rbtype2.Tag = "2"
        Me.rbtype2.Text = "Type 2"
        Me.rbtype2.UseVisualStyleBackColor = True
        '
        'rbtype3
        '
        Me.rbtype3.AutoSize = True
        Me.rbtype3.Location = New System.Drawing.Point(3, 121)
        Me.rbtype3.Name = "rbtype3"
        Me.rbtype3.Size = New System.Drawing.Size(58, 17)
        Me.rbtype3.TabIndex = 3
        Me.rbtype3.TabStop = True
        Me.rbtype3.Tag = "3"
        Me.rbtype3.Text = "Type 3"
        Me.rbtype3.UseVisualStyleBackColor = True
        '
        'rbtype4
        '
        Me.rbtype4.AutoSize = True
        Me.rbtype4.Location = New System.Drawing.Point(3, 144)
        Me.rbtype4.Name = "rbtype4"
        Me.rbtype4.Size = New System.Drawing.Size(58, 17)
        Me.rbtype4.TabIndex = 4
        Me.rbtype4.TabStop = True
        Me.rbtype4.Tag = "4"
        Me.rbtype4.Text = "Type 4"
        Me.rbtype4.UseVisualStyleBackColor = True
        '
        'txtNomEvenement
        '
        Me.txtNomEvenement.Location = New System.Drawing.Point(3, 19)
        Me.txtNomEvenement.Name = "txtNomEvenement"
        Me.txtNomEvenement.Size = New System.Drawing.Size(200, 20)
        Me.txtNomEvenement.TabIndex = 5
        '
        'dt_date_evenement
        '
        Me.dt_date_evenement.Location = New System.Drawing.Point(3, 46)
        Me.dt_date_evenement.Name = "dt_date_evenement"
        Me.dt_date_evenement.Size = New System.Drawing.Size(200, 20)
        Me.dt_date_evenement.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nom de l'évènement"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.cbRecettes)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnAjouter)
        Me.Panel1.Controls.Add(Me.dt_date_evenement)
        Me.Panel1.Controls.Add(Me.rbtype1)
        Me.Panel1.Controls.Add(Me.txtNomEvenement)
        Me.Panel1.Controls.Add(Me.rbtype2)
        Me.Panel1.Controls.Add(Me.rbtype4)
        Me.Panel1.Controls.Add(Me.rbtype3)
        Me.Panel1.Location = New System.Drawing.Point(240, 80)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(214, 272)
        Me.Panel1.TabIndex = 8
        '
        'TxtTitreMessage
        '
        Me.TxtTitreMessage.Location = New System.Drawing.Point(680, 99)
        Me.TxtTitreMessage.Name = "TxtTitreMessage"
        Me.TxtTitreMessage.Size = New System.Drawing.Size(240, 20)
        Me.TxtTitreMessage.TabIndex = 9
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(680, 129)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(240, 157)
        Me.txtMessage.TabIndex = 10
        Me.txtMessage.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(617, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Titre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(595, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Message"
        '
        'btnEnregistrerMessage
        '
        Me.btnEnregistrerMessage.Location = New System.Drawing.Point(843, 329)
        Me.btnEnregistrerMessage.Name = "btnEnregistrerMessage"
        Me.btnEnregistrerMessage.Size = New System.Drawing.Size(75, 23)
        Me.btnEnregistrerMessage.TabIndex = 13
        Me.btnEnregistrerMessage.Text = "Enregistrer"
        Me.btnEnregistrerMessage.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(987, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Messages existants"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1036, 284)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Supprimer"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'dpDebutAffichage
        '
        Me.dpDebutAffichage.Location = New System.Drawing.Point(22, 35)
        Me.dpDebutAffichage.Name = "dpDebutAffichage"
        Me.dpDebutAffichage.Size = New System.Drawing.Size(200, 20)
        Me.dpDebutAffichage.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dpFinAffichage)
        Me.GroupBox1.Controls.Add(Me.dpDebutAffichage)
        Me.GroupBox1.Location = New System.Drawing.Point(678, 326)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 110)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Période"
        Me.GroupBox1.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Fin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Début"
        '
        'dpFinAffichage
        '
        Me.dpFinAffichage.Location = New System.Drawing.Point(22, 74)
        Me.dpFinAffichage.Name = "dpFinAffichage"
        Me.dpFinAffichage.Size = New System.Drawing.Size(200, 20)
        Me.dpFinAffichage.TabIndex = 0
        '
        'cbPeriodeAffichage
        '
        Me.cbPeriodeAffichage.AutoSize = True
        Me.cbPeriodeAffichage.Location = New System.Drawing.Point(700, 304)
        Me.cbPeriodeAffichage.Name = "cbPeriodeAffichage"
        Me.cbPeriodeAffichage.Size = New System.Drawing.Size(170, 17)
        Me.cbPeriodeAffichage.TabIndex = 19
        Me.cbPeriodeAffichage.Text = "Définir une période d'affichage"
        Me.cbPeriodeAffichage.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(990, 126)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(121, 97)
        Me.ListView1.TabIndex = 20
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(3, 167)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(115, 17)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Inclure une recette"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'cbRecettes
        '
        Me.cbRecettes.FormattingEnabled = True
        Me.cbRecettes.Location = New System.Drawing.Point(3, 190)
        Me.cbRecettes.Name = "cbRecettes"
        Me.cbRecettes.Size = New System.Drawing.Size(181, 21)
        Me.cbRecettes.TabIndex = 9
        Me.cbRecettes.Visible = False
        '
        'frmAgenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1684, 987)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.cbPeriodeAffichage)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnEnregistrerMessage)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.TxtTitreMessage)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAgenda"
        Me.Text = "Agenda"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAjouter As Button
    Friend WithEvents rbtype1 As RadioButton
    Friend WithEvents rbtype2 As RadioButton
    Friend WithEvents rbtype3 As RadioButton
    Friend WithEvents rbtype4 As RadioButton
    Friend WithEvents txtNomEvenement As TextBox
    Friend WithEvents dt_date_evenement As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtTitreMessage As TextBox
    Friend WithEvents txtMessage As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEnregistrerMessage As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents dpDebutAffichage As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dpFinAffichage As DateTimePicker
    Friend WithEvents cbPeriodeAffichage As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents cbRecettes As ComboBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
