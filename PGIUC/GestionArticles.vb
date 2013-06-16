Public Class GestionArticles

    Private Sub NouvelArticleBouton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NouvelGArtBouton.Click
        NouvelArticle.Show()
        NouvelArticle.Text = "Nouvel Article"
        NouvelArticle.ValideBouton.Hide()
    End Sub

    Private Sub ModifierGArtBouton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifierGArtBouton.Click

        If DGVArticle.RowCount = 0 Then
            MsgBox("Il n'y a aucune article enregistré présentement")
        Else

            NouvelArticle.Text = "Modification d'un article existant"
            NouvelArticle.Show()
            NouvelArticle.AjouterNArtBouton.Hide()
            NouvelArticle.ValideBouton.Show()
            NouvelArticle.DonneesAmodifier()
        End If


    End Sub


    Private Sub supprimerGArtBouton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles supprimerGArtBouton.Click

        If MsgBox("Etes-vous vraiment certain de voulloir supprimer cet article?", MsgBoxStyle.YesNo) = 6 Then
            DGVArticle.Rows.RemoveAt(DGVArticle.CurrentCell.RowIndex)
        End If


    End Sub




    Private Sub FermerGArtBouton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FermerGArtBouton.Click
        Me.Hide()
    End Sub

    Private Sub GestionArticles_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub

    Private Sub GestionArticles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class