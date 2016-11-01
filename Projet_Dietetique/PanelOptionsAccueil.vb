Public Class PanelOptionsAccueil
    Inherits Panel

    Dim nbBoutons As Integer = 0
    Dim nbBtn As Integer
    Dim vertOffset As Integer = 2

    Sub New(x As Integer, y As Integer, width As Integer, nbBtnPerRow As Integer)
        Me.SetBounds(x, y - 3, width, 0)
        BackColor = Color.FromArgb(0, 176, 240)
        nbBtn = nbBtnPerRow

    End Sub

    Sub rafraichir() Handles Me.MouseLeave
        For Each b As BoutonOption In Me.Controls
            b.BackColor = Color.LightGray
        Next

    End Sub

    Sub ajouterBouton(imageName As String, destination As Form, buttonName As String)
        If ((nbBoutons Mod nbBtn) = 0) Then
            Me.Height += Width / nbBtn
        End If

        Dim btnWidth As Integer = (Me.Width - 8) / 2
        Dim btnHeight As Integer = btnWidth
        Dim x As Integer = 0

        If (nbBoutons Mod 2) = 0 Then
            x = 2
        Else x = 6 + btnWidth
        End If




        Dim btn As New BoutonOption(x, vertOffset, btnWidth, btnHeight, buttonName, imageName, destination)


        nbBoutons += 1
        If nbBoutons Mod 2 = 0 Then
            vertOffset += btnWidth + 2
        End If


        Controls.Add(btn)


        For Each b As BoutonOption In Controls
            AddHandler b.MouseEnter, Sub()
                                         For Each bo As BoutonOption In Controls
                                             If bo.BackColor = Color.AliceBlue And Not b.btnName = bo.btnName Then
                                                 bo.BackColor = Color.LightGray
                                             End If
                                         Next
                                     End Sub

            AddHandler b.BackColorChanged, Sub()
                                               For Each bo As BoutonOption In Controls
                                                   If bo.BackColor = Color.AliceBlue And Not b.btnName = bo.btnName Then
                                                       bo.BackColor = Color.LightGray
                                                   End If
                                               Next
                                           End Sub


        Next

    End Sub






End Class


