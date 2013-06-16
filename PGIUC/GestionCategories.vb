Public Class GestionCategories

    Private Sub NouvelGCatBouton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NouvelGCatBouton.Click
        If DGVCategorie.RowCount = 0 Then
            DGVCategorie.Rows.Add()
            DGVCategorie.Item(0, DGVCategorie.RowCount - 1).Value = DGVCategorie.RowCount - 1
        Else
            If DGVCategorie.Item(1, DGVCategorie.RowCount - 1).Value = "" Then
                MsgBox("Entre une categorie")
            Else
                DGVCategorie.Rows.Add()
                DGVCategorie.Item(0, DGVCategorie.RowCount - 1).Value = DGVCategorie.RowCount - 1
            End If
        End If

    End Sub


    Private Sub FermerGCatBouton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FermerGCatBouton.Click
        Dim protection As Boolean = True
        If DGVCategorie.RowCount > 0 Then
            For c = 0 To DGVCategorie.RowCount - 1
                If DGVCategorie.Item(1, c).Value = "" Then
                    MsgBox("Il manque un nom de catégorie")
                    protection = False
                Else
                    If NouvelArticle.CategorieArticleBox.Items.Contains(DGVCategorie.Item(1, c).Value) Then
                    Else
                        NouvelArticle.CategorieArticleBox.Items.Add(DGVCategorie.Item(1, c).Value)
                    End If
                End If
            Next
        End If

        If protection Then
            Me.Hide()
        End If


    End Sub

    Private Sub DGVCategorie_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVCategorie.CellContentClick

    End Sub

    Private Sub GestionCategories_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GestionCategories_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        Me.FermerGCatBouton.PerformClick()
        e.Cancel = True
        Me.Hide()
    End Sub

End Class