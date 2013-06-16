Public Class NouvelArticle

    Dim Item As New Article()
    Dim ChampObligatoire As Boolean = False


    Private Sub NouvelArticle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub


    Private Sub AjouterNArtBouton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterNArtBouton.Click

        ChampObligatoire = False

        If ValidationTextbox() Then
        Else
            NoArticleBox.BackColor = Color.White
            QuantiteArticleBox.BackColor = Color.White
            DescriptionArticleBox.BackColor = Color.White
            Item.NumeroArticle = NoArticleBox.Text
            Item.Description = DescriptionArticleBox.Text
            Item.CategorieArticle = CategorieArticleBox.Text
            Item.EtatArticle = EtatArticleBox.Text
            Item.Quantite = Convert.ToInt16(QuantiteArticleBox.Text)
            Item.PrixArticle = Convert.ToDouble(PrixArticleBox.Text)
            Item.NumeroSerie = NoSerieArticleBox.Text
            CodeBarreViewer.Value = NoArticleBox.Text
            CodeBarreChiffre.Text = NoArticleBox.Text
            ' MsgBox(CodeBarreViewer.Value.ToString.Length)
            GestionArticles.DGVArticle.Rows.Add(Item.NumeroArticle, Item.Description, Item.CategorieArticle, Item.EtatArticle, Item.Quantite, Item.PrixArticle, Item.NumeroSerie)
        End If
    End Sub



    Private Sub ValideBouton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ValideBouton.Click

        If ValidationTextbox() Then
        Else
            NoArticleBox.BackColor = Color.White
            QuantiteArticleBox.BackColor = Color.White
            DescriptionArticleBox.BackColor = Color.White
            GestionArticles.DGVArticle.Item(0, GestionArticles.DGVArticle.CurrentCell.RowIndex).Value = NoArticleBox.Text
            GestionArticles.DGVArticle.Item(1, GestionArticles.DGVArticle.CurrentCell.RowIndex).Value = DescriptionArticleBox.Text
            GestionArticles.DGVArticle.Item(2, GestionArticles.DGVArticle.CurrentCell.RowIndex).Value = CategorieArticleBox.Text
            GestionArticles.DGVArticle.Item(3, GestionArticles.DGVArticle.CurrentCell.RowIndex).Value = EtatArticleBox.Text
            GestionArticles.DGVArticle.Item(4, GestionArticles.DGVArticle.CurrentCell.RowIndex).Value = Convert.ToInt16(QuantiteArticleBox.Text)
            GestionArticles.DGVArticle.Item(5, GestionArticles.DGVArticle.CurrentCell.RowIndex).Value = Convert.ToDouble(PrixArticleBox.Text)
            GestionArticles.DGVArticle.Item(6, GestionArticles.DGVArticle.CurrentCell.RowIndex).Value = NoSerieArticleBox.Text
            CodeBarreViewer.Value = NoArticleBox.Text
            CodeBarreChiffre.Text = NoArticleBox.Text

        End If

    End Sub


    Private Sub AnnulerNArtBouton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnnulerNArtBouton.Click
        If MsgBox("Etes-vous certain de voulloir effacer les prises/modifications de données ?", MsgBoxStyle.YesNo) = 6 Then
            NoArticleBox.Text = Item.NumeroArticle
            DescriptionArticleBox.Text = Item.Description
            CategorieArticleBox.Text = Item.CategorieArticle
            EtatArticleBox.Text = Item.EtatArticle
            QuantiteArticleBox.Text = Item.Quantite
            PrixArticleBox.Text = Item.PrixArticle
            NoSerieArticleBox.Text = Item.NumeroSerie
        End If
    End Sub

    Private Sub FermerNArtBouton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FermerNArtBouton.Click
        Me.Hide()
    End Sub

    Public Sub DonneesAmodifier()
        Me.NoArticleBox.Text = GestionArticles.DGVArticle.Item(0, GestionArticles.DGVArticle.CurrentCell.RowIndex).Value
        Me.DescriptionArticleBox.Text = GestionArticles.DGVArticle.Item(1, GestionArticles.DGVArticle.CurrentCell.RowIndex).Value
        Me.CategorieArticleBox.Text = GestionArticles.DGVArticle.Item(2, GestionArticles.DGVArticle.CurrentCell.RowIndex).Value
        Me.EtatArticleBox.Text = GestionArticles.DGVArticle.Item(3, GestionArticles.DGVArticle.CurrentCell.RowIndex).Value
        Me.QuantiteArticleBox.Text = GestionArticles.DGVArticle.Item(4, GestionArticles.DGVArticle.CurrentCell.RowIndex).Value
        Me.PrixArticleBox.Text = GestionArticles.DGVArticle.Item(5, GestionArticles.DGVArticle.CurrentCell.RowIndex).Value
        Me.NoSerieArticleBox.Text = GestionArticles.DGVArticle.Item(6, GestionArticles.DGVArticle.CurrentCell.RowIndex).Value
        CodeBarreViewer.Value = NoArticleBox.Text
        Item.NumeroArticle = NoArticleBox.Text
        Item.Description = DescriptionArticleBox.Text
        Item.CategorieArticle = CategorieArticleBox.Text
        Item.EtatArticle = EtatArticleBox.Text
        Item.Quantite = QuantiteArticleBox.Text
        Item.PrixArticle = PrixArticleBox.Text
        Item.NumeroSerie = NoSerieArticleBox.Text
    End Sub


    Private Function ValidationTextbox()

        If NoArticleBox.Text = "" Then
            NoArticleBox.BackColor = Color.Red
            ChampObligatoire = True
        End If

        If NoArticleBox.Text.ToString.Length <> 12 Then
            NoArticleBox.BackColor = Color.Red
            ChampObligatoire = True
            MsgBox("Le numéro d'article doit contenir 12 chiffres sans espaces")
        End If

        If DescriptionArticleBox.Text = "" Then
            DescriptionArticleBox.BackColor = Color.Red
            ChampObligatoire = True
        End If

        If QuantiteArticleBox.Text = "" Then
            QuantiteArticleBox.BackColor = Color.Red
            ChampObligatoire = True
        End If

        If ChampObligatoire Then
            MsgBox("Veuillez remplir les champs obligatoires")
        Else
            For c = 0 To GestionArticles.DGVArticle.RowCount - 1
                If NoArticleBox.Text = GestionArticles.DGVArticle.Item(0, c).Value Then
                    MsgBox("Le numéro d'item choisi existe déjâ, veuiller choisir un autre numéro d'item!")
                    NoArticleBox.BackColor = Color.Red
                    ChampObligatoire = True
                    Exit For
                End If
            Next
        End If

        Return ChampObligatoire
    End Function

    Private Sub NouvelArticle_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub
    
   
    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub CodeBarreViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodeBarreViewer.Load

        CodeBarreViewer.Value = NoArticleBox.Text

    End Sub

    Private Sub ApercuNArtBouton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApercuNArtBouton.Click
        
    End Sub

End Class