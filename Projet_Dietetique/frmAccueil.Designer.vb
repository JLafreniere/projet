<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAccueil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccueil))
        Me.btnOmnivox = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOmnivox
        '
        Me.btnOmnivox.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnOmnivox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOmnivox.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.btnOmnivox.ForeColor = System.Drawing.Color.White
        Me.btnOmnivox.Location = New System.Drawing.Point(1557, 30)
        Me.btnOmnivox.Name = "btnOmnivox"
        Me.btnOmnivox.Size = New System.Drawing.Size(90, 35)
        Me.btnOmnivox.TabIndex = 39
        Me.btnOmnivox.Text = "Ajouter"
        Me.btnOmnivox.UseVisualStyleBackColor = False
        '
        'frmAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1684, 987)
        Me.Controls.Add(Me.btnOmnivox)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAccueil"
        Me.Text = "Accueil"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOmnivox As Button
End Class
