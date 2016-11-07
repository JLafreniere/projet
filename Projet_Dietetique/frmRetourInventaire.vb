Public Class frmRetourInventaire
    Dim bd As New GestionBD("Server=localhost;Database=bd_application;Uid=root;Pwd=;")
    Private Sub frmRetourInventaire_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TopMost = True
        Controls.Add(New Header(Me, False))
        'connection bd + charger ds
        bd.ConnectionString = "Server=localhost; DataBase=bd_application;UId=root;Pwd=; Convert Zero Datetime=true; Allow Zero DateTime=true;"
        bd.dsInventaire.Clear()
        bd.Requete("select * from inventaire", bd.dsInventaire, bd.daInventaire, "inventaire")

    End Sub
End Class