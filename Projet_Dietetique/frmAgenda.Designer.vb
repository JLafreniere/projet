﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEnregistrerMessage = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAjouter
        '
        Me.btnAjouter.Location = New System.Drawing.Point(128, 170)
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
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nom de l'évènement"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnAjouter)
        Me.Panel1.Controls.Add(Me.dt_date_evenement)
        Me.Panel1.Controls.Add(Me.rbtype1)
        Me.Panel1.Controls.Add(Me.txtNomEvenement)
        Me.Panel1.Controls.Add(Me.rbtype2)
        Me.Panel1.Controls.Add(Me.rbtype4)
        Me.Panel1.Controls.Add(Me.rbtype3)
        Me.Panel1.Location = New System.Drawing.Point(180, 126)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(214, 195)
        Me.Panel1.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(620, 145)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(240, 20)
        Me.TextBox1.TabIndex = 9
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(620, 175)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(240, 157)
        Me.RichTextBox1.TabIndex = 10
        Me.RichTextBox1.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(557, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Titre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(535, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Message"
        '
        'btnEnregistrerMessage
        '
        Me.btnEnregistrerMessage.Location = New System.Drawing.Point(785, 349)
        Me.btnEnregistrerMessage.Name = "btnEnregistrerMessage"
        Me.btnEnregistrerMessage.Size = New System.Drawing.Size(75, 23)
        Me.btnEnregistrerMessage.TabIndex = 13
        Me.btnEnregistrerMessage.Text = "Enregistrer"
        Me.btnEnregistrerMessage.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(930, 169)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(927, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Messages existants"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(975, 270)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Supprimer"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'frmAgenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1684, 987)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnEnregistrerMessage)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAgenda"
        Me.Text = "Agenda"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEnregistrerMessage As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
End Class
