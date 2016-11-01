Public Class BoutonOption
    Inherits Panel

    Dim WithEvents pb As New PictureBox
    Dim WithEvents lblpb As Label
    Dim destination As Form
    Dim nombre3 As Integer = 3
    Property btnName As String
    Public Sub New(_X As Integer, _Y As Integer, _Width As Integer, _Height As Integer, buttonName As String, imageName As String, _destination As Form)
        Me.Tag = "T"
        btnName = buttonName
        SetBounds(_X, _Y, _Width, _Height)
        BackColor = Color.LightGray
        pb = New PictureBox()
        With pb
            .Image = Image.FromFile(imageName)
            .SizeMode = PictureBoxSizeMode.StretchImage
            .SetBounds(Width * 0.1, Height * 0.1, Width * 0.8, Height * 0.8)
            .BackColor = Color.Transparent
            .Tag = "pb"
        End With
        lblpb = New Label

        With lblpb
            .Location = New Point(10, 10)
            .Text = buttonName
            .AutoSize = True
            .Font = New Font("Segoe UI", 14.25, FontStyle.Bold)
            .ForeColor = Color.Gray
            .BackColor = Color.Transparent
            .Visible = True
            .Tag = "B"
        End With


        Controls.Add(lblpb)
        Controls.Add(pb)
        destination = _destination

    End Sub


    Public Sub bouton_enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.MouseEnter, pb.MouseEnter, lblpb.MouseEnter
        BackColor = Color.AliceBlue
    End Sub

    Public Sub bouton_leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        BackColor = Color.LightGray
    End Sub


    Public Sub bouton_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Click, pb.Click, lblpb.Click
        destination.Show()
        destination.WindowState = FormWindowState.Maximized
        frmAccueil.Hide()

    End Sub

End Class

