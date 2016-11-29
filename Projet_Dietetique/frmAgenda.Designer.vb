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
        Me.cbRecettes = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nom = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSupprimerEvemement = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAjouter
        '
        Me.btnAjouter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjouter.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnAjouter.ForeColor = System.Drawing.Color.White
        Me.btnAjouter.Location = New System.Drawing.Point(194, 182)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(90, 35)
        Me.btnAjouter.TabIndex = 0
        Me.btnAjouter.Text = "Ajouter"
        Me.btnAjouter.UseVisualStyleBackColor = False
        '
        'rbtype1
        '
        Me.rbtype1.AutoSize = True
        Me.rbtype1.Checked = True
        Me.rbtype1.Location = New System.Drawing.Point(3, 75)
        Me.rbtype1.Name = "rbtype1"
        Me.rbtype1.Size = New System.Drawing.Size(67, 17)
        Me.rbtype1.TabIndex = 1
        Me.rbtype1.TabStop = True
        Me.rbtype1.Tag = "1"
        Me.rbtype1.Text = "Cafécole"
        Me.rbtype1.UseVisualStyleBackColor = True
        '
        'rbtype2
        '
        Me.rbtype2.AutoSize = True
        Me.rbtype2.Location = New System.Drawing.Point(3, 98)
        Me.rbtype2.Name = "rbtype2"
        Me.rbtype2.Size = New System.Drawing.Size(78, 17)
        Me.rbtype2.TabIndex = 2
        Me.rbtype2.Tag = "2"
        Me.rbtype2.Text = "Laboratoire"
        Me.rbtype2.UseVisualStyleBackColor = True
        '
        'rbtype3
        '
        Me.rbtype3.AutoSize = True
        Me.rbtype3.Location = New System.Drawing.Point(3, 121)
        Me.rbtype3.Name = "rbtype3"
        Me.rbtype3.Size = New System.Drawing.Size(52, 17)
        Me.rbtype3.TabIndex = 3
        Me.rbtype3.Tag = "3"
        Me.rbtype3.Text = "Cours"
        Me.rbtype3.UseVisualStyleBackColor = True
        '
        'rbtype4
        '
        Me.rbtype4.AutoSize = True
        Me.rbtype4.Location = New System.Drawing.Point(3, 144)
        Me.rbtype4.Name = "rbtype4"
        Me.rbtype4.Size = New System.Drawing.Size(50, 17)
        Me.rbtype4.TabIndex = 4
        Me.rbtype4.Tag = "4"
        Me.rbtype4.Text = "Autre"
        Me.rbtype4.UseVisualStyleBackColor = True
        '
        'txtNomEvenement
        '
        Me.txtNomEvenement.Location = New System.Drawing.Point(3, 19)
        Me.txtNomEvenement.Name = "txtNomEvenement"
        Me.txtNomEvenement.Size = New System.Drawing.Size(281, 20)
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
        Me.Panel1.BackColor = System.Drawing.Color.White
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
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel1.Location = New System.Drawing.Point(6, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(297, 246)
        Me.Panel1.TabIndex = 8
        '
        'cbRecettes
        '
        Me.cbRecettes.FormattingEnabled = True
        Me.cbRecettes.Location = New System.Drawing.Point(3, 190)
        Me.cbRecettes.Name = "cbRecettes"
        Me.cbRecettes.Size = New System.Drawing.Size(281, 21)
        Me.cbRecettes.TabIndex = 9
        Me.cbRecettes.Visible = False
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
        'TxtTitreMessage
        '
        Me.TxtTitreMessage.Location = New System.Drawing.Point(92, 13)
        Me.TxtTitreMessage.Name = "TxtTitreMessage"
        Me.TxtTitreMessage.Size = New System.Drawing.Size(240, 20)
        Me.TxtTitreMessage.TabIndex = 9
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(92, 43)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(240, 141)
        Me.txtMessage.TabIndex = 10
        Me.txtMessage.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Titre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Message"
        '
        'btnEnregistrerMessage
        '
        Me.btnEnregistrerMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnEnregistrerMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnregistrerMessage.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnEnregistrerMessage.ForeColor = System.Drawing.Color.White
        Me.btnEnregistrerMessage.Location = New System.Drawing.Point(242, 216)
        Me.btnEnregistrerMessage.Name = "btnEnregistrerMessage"
        Me.btnEnregistrerMessage.Size = New System.Drawing.Size(90, 35)
        Me.btnEnregistrerMessage.TabIndex = 13
        Me.btnEnregistrerMessage.Text = "Enregistrer"
        Me.btnEnregistrerMessage.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(354, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 28)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Messages existants"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(471, 249)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 35)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Supprimer"
        Me.Button2.UseVisualStyleBackColor = False
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
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dpFinAffichage)
        Me.GroupBox1.Controls.Add(Me.dpDebutAffichage)
        Me.GroupBox1.Location = New System.Drawing.Point(92, 217)
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
        Me.cbPeriodeAffichage.Location = New System.Drawing.Point(112, 194)
        Me.cbPeriodeAffichage.Name = "cbPeriodeAffichage"
        Me.cbPeriodeAffichage.Size = New System.Drawing.Size(170, 17)
        Me.cbPeriodeAffichage.TabIndex = 19
        Me.cbPeriodeAffichage.Text = "Définir une période d'affichage"
        Me.cbPeriodeAffichage.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ListView1.Location = New System.Drawing.Point(357, 64)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(204, 180)
        Me.ListView1.TabIndex = 20
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Panel1)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 36)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(309, 285)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ajouter un évènement"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.ListView1)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.GroupBox4.Location = New System.Drawing.Point(757, 102)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(586, 327)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Messages"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.TxtTitreMessage)
        Me.GroupBox5.Controls.Add(Me.txtMessage)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.btnEnregistrerMessage)
        Me.GroupBox5.Controls.Add(Me.cbPeriodeAffichage)
        Me.GroupBox5.Controls.Add(Me.GroupBox1)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GroupBox5.Location = New System.Drawing.Point(7, 33)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(344, 255)
        Me.GroupBox5.TabIndex = 24
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Ajouter un message"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(165, 102)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(586, 327)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Évènements"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Panel2)
        Me.GroupBox6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GroupBox6.Location = New System.Drawing.Point(331, 36)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(242, 285)
        Me.GroupBox6.TabIndex = 23
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Supprimer un évènement"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.ListView2)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.DateTimePicker2)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.btnSupprimerEvemement)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel2.Location = New System.Drawing.Point(6, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(224, 246)
        Me.Panel2.TabIndex = 8
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Nom})
        Me.ListView2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ListView2.FullRowSelect = True
        Me.ListView2.Location = New System.Drawing.Point(6, 84)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(200, 107)
        Me.ListView2.TabIndex = 21
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Width = 0
        '
        'Nom
        '
        Me.Nom.Text = "Évènement"
        Me.Nom.Width = 196
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(3, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "et le"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(6, 58)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(3, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Évènements entre le"
        '
        'btnSupprimerEvemement
        '
        Me.btnSupprimerEvemement.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnSupprimerEvemement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupprimerEvemement.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnSupprimerEvemement.ForeColor = System.Drawing.Color.White
        Me.btnSupprimerEvemement.Location = New System.Drawing.Point(66, 197)
        Me.btnSupprimerEvemement.Name = "btnSupprimerEvemement"
        Me.btnSupprimerEvemement.Size = New System.Drawing.Size(140, 39)
        Me.btnSupprimerEvemement.TabIndex = 0
        Me.btnSupprimerEvemement.Text = "Supprimer les évènements sélectionnés"
        Me.btnSupprimerEvemement.UseVisualStyleBackColor = False
        Me.btnSupprimerEvemement.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(6, 19)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 6
        '
        'frmAgenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1684, 987)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAgenda"
        Me.Text = "Agenda"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ListView2 As ListView
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSupprimerEvemement As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents Nom As ColumnHeader
End Class
