<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetraitInventaire
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRetraitInventaire))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblQuantite = New System.Windows.Forms.Label()
        Me.txtQuantite = New System.Windows.Forms.TextBox()
        Me.lblUnite = New System.Windows.Forms.Label()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.btnRetirer = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.lblUniteTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(72, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Retrait de :"
        '
        'lblQuantite
        '
        Me.lblQuantite.AutoSize = True
        Me.lblQuantite.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblQuantite.Location = New System.Drawing.Point(32, 110)
        Me.lblQuantite.Name = "lblQuantite"
        Me.lblQuantite.Size = New System.Drawing.Size(105, 13)
        Me.lblQuantite.TabIndex = 1
        Me.lblQuantite.Text = "Quantité à retirer : "
        '
        'txtQuantite
        '
        Me.txtQuantite.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtQuantite.Location = New System.Drawing.Point(147, 107)
        Me.txtQuantite.Name = "txtQuantite"
        Me.txtQuantite.ShortcutsEnabled = False
        Me.txtQuantite.Size = New System.Drawing.Size(100, 22)
        Me.txtQuantite.TabIndex = 2
        Me.txtQuantite.Text = "0"
        '
        'lblUnite
        '
        Me.lblUnite.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblUnite.Location = New System.Drawing.Point(250, 110)
        Me.lblUnite.Name = "lblUnite"
        Me.lblUnite.Size = New System.Drawing.Size(97, 13)
        Me.lblUnite.TabIndex = 3
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblItem.Location = New System.Drawing.Point(144, 71)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(0, 13)
        Me.lblItem.TabIndex = 4
        '
        'btnRetirer
        '
        Me.btnRetirer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRetirer.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnRetirer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRetirer.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnRetirer.ForeColor = System.Drawing.Color.White
        Me.btnRetirer.Location = New System.Drawing.Point(194, 185)
        Me.btnRetirer.Name = "btnRetirer"
        Me.btnRetirer.Size = New System.Drawing.Size(91, 35)
        Me.btnRetirer.TabIndex = 79
        Me.btnRetirer.Text = "Retirer"
        Me.btnRetirer.UseVisualStyleBackColor = False
        '
        'btnAnnuler
        '
        Me.btnAnnuler.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnuler.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnAnnuler.ForeColor = System.Drawing.Color.White
        Me.btnAnnuler.Location = New System.Drawing.Point(291, 185)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(91, 35)
        Me.btnAnnuler.TabIndex = 78
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = False
        '
        'lblUniteTotal
        '
        Me.lblUniteTotal.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.lblUniteTotal.Location = New System.Drawing.Point(250, 150)
        Me.lblUniteTotal.Name = "lblUniteTotal"
        Me.lblUniteTotal.Size = New System.Drawing.Size(97, 13)
        Me.lblUniteTotal.TabIndex = 82
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtTotal.Location = New System.Drawing.Point(147, 147)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 22)
        Me.txtTotal.TabIndex = 81
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(10, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(125, 13)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Restant en inventaire : "
        '
        'frmRetraitInventaire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(394, 232)
        Me.Controls.Add(Me.lblUniteTotal)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnRetirer)
        Me.Controls.Add(Me.btnAnnuler)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.lblUnite)
        Me.Controls.Add(Me.txtQuantite)
        Me.Controls.Add(Me.lblQuantite)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRetraitInventaire"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retirer de l'inventaire"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblQuantite As Label
    Friend WithEvents txtQuantite As TextBox
    Friend WithEvents lblUnite As Label
    Friend WithEvents lblItem As Label
    Friend WithEvents btnRetirer As Button
    Friend WithEvents btnAnnuler As Button
    Friend WithEvents lblUniteTotal As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label5 As Label
End Class
