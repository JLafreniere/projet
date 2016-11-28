<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceptionCommande
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDateReception = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnReception = New System.Windows.Forms.Button()
        Me.cbReference = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtReception = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date de réception"
        '
        'dtpDateReception
        '
        Me.dtpDateReception.Location = New System.Drawing.Point(157, 80)
        Me.dtpDateReception.Name = "dtpDateReception"
        Me.dtpDateReception.Size = New System.Drawing.Size(200, 20)
        Me.dtpDateReception.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "No de référence"
        '
        'btnReception
        '
        Me.btnReception.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReception.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnReception.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReception.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReception.ForeColor = System.Drawing.Color.White
        Me.btnReception.Location = New System.Drawing.Point(196, 308)
        Me.btnReception.Name = "btnReception"
        Me.btnReception.Size = New System.Drawing.Size(91, 35)
        Me.btnReception.TabIndex = 59
        Me.btnReception.Text = "Réception"
        Me.btnReception.UseVisualStyleBackColor = False
        '
        'cbReference
        '
        Me.cbReference.FormattingEnabled = True
        Me.cbReference.Location = New System.Drawing.Point(157, 128)
        Me.cbReference.Name = "cbReference"
        Me.cbReference.Size = New System.Drawing.Size(121, 21)
        Me.cbReference.TabIndex = 60
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Notes"
        '
        'txtReception
        '
        Me.txtReception.Location = New System.Drawing.Point(157, 181)
        Me.txtReception.Name = "txtReception"
        Me.txtReception.Size = New System.Drawing.Size(200, 96)
        Me.txtReception.TabIndex = 62
        Me.txtReception.Text = ""
        '
        'frmReceptionCommande
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(615, 355)
        Me.Controls.Add(Me.txtReception)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbReference)
        Me.Controls.Add(Me.btnReception)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpDateReception)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmReceptionCommande"
        Me.Text = "Réception Commande"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dtpDateReception As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents btnReception As Button
    Friend WithEvents cbReference As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtReception As RichTextBox
End Class
