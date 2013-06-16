<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionArticles
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.NouvelGArtBouton = New System.Windows.Forms.Button()
        Me.DGVArticle = New System.Windows.Forms.DataGridView()
        Me.NoArticle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categorie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Etat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoSeri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ImprimerGArtBouton = New System.Windows.Forms.Button()
        Me.supprimerGArtBouton = New System.Windows.Forms.Button()
        Me.ModifierGArtBouton = New System.Windows.Forms.Button()
        Me.FermerGArtBouton = New System.Windows.Forms.Button()
        CType(Me.DGVArticle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NouvelGArtBouton
        '
        Me.NouvelGArtBouton.Location = New System.Drawing.Point(3, 2)
        Me.NouvelGArtBouton.Name = "NouvelGArtBouton"
        Me.NouvelGArtBouton.Size = New System.Drawing.Size(153, 35)
        Me.NouvelGArtBouton.TabIndex = 0
        Me.NouvelGArtBouton.Text = "Nouvel article"
        Me.NouvelGArtBouton.UseVisualStyleBackColor = True
        '
        'DGVArticle
        '
        Me.DGVArticle.AllowUserToAddRows = False
        Me.DGVArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVArticle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoArticle, Me.Description, Me.Categorie, Me.Etat, Me.Quantite, Me.Prix, Me.NoSeri})
        Me.DGVArticle.Location = New System.Drawing.Point(211, 3)
        Me.DGVArticle.Name = "DGVArticle"
        Me.DGVArticle.Size = New System.Drawing.Size(934, 496)
        Me.DGVArticle.TabIndex = 4
        '
        'NoArticle
        '
        Me.NoArticle.HeaderText = "No. Article"
        Me.NoArticle.Name = "NoArticle"
        Me.NoArticle.Width = 80
        '
        'Description
        '
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.Width = 300
        '
        'Categorie
        '
        Me.Categorie.HeaderText = "Categorie"
        Me.Categorie.Name = "Categorie"
        Me.Categorie.Width = 150
        '
        'Etat
        '
        Me.Etat.HeaderText = "État"
        Me.Etat.Name = "Etat"
        Me.Etat.Width = 80
        '
        'Quantite
        '
        Me.Quantite.HeaderText = "Quantité"
        Me.Quantite.Name = "Quantite"
        Me.Quantite.Width = 50
        '
        'Prix
        '
        Me.Prix.HeaderText = "Prix"
        Me.Prix.Name = "Prix"
        Me.Prix.Width = 80
        '
        'NoSeri
        '
        Me.NoSeri.HeaderText = "Numéro de Série"
        Me.NoSeri.Name = "NoSeri"
        Me.NoSeri.Width = 150
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(206, 496)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ImprimerGArtBouton)
        Me.Panel2.Controls.Add(Me.supprimerGArtBouton)
        Me.Panel2.Controls.Add(Me.NouvelGArtBouton)
        Me.Panel2.Controls.Add(Me.ModifierGArtBouton)
        Me.Panel2.Controls.Add(Me.FermerGArtBouton)
        Me.Panel2.Location = New System.Drawing.Point(24, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(161, 206)
        Me.Panel2.TabIndex = 18
        '
        'ImprimerGArtBouton
        '
        Me.ImprimerGArtBouton.Location = New System.Drawing.Point(3, 125)
        Me.ImprimerGArtBouton.Name = "ImprimerGArtBouton"
        Me.ImprimerGArtBouton.Size = New System.Drawing.Size(153, 35)
        Me.ImprimerGArtBouton.TabIndex = 17
        Me.ImprimerGArtBouton.Text = "Imprimer"
        Me.ImprimerGArtBouton.UseVisualStyleBackColor = True
        '
        'supprimerGArtBouton
        '
        Me.supprimerGArtBouton.Location = New System.Drawing.Point(3, 84)
        Me.supprimerGArtBouton.Name = "supprimerGArtBouton"
        Me.supprimerGArtBouton.Size = New System.Drawing.Size(153, 35)
        Me.supprimerGArtBouton.TabIndex = 16
        Me.supprimerGArtBouton.Text = "Supprimer"
        Me.supprimerGArtBouton.UseVisualStyleBackColor = True
        '
        'ModifierGArtBouton
        '
        Me.ModifierGArtBouton.Location = New System.Drawing.Point(3, 43)
        Me.ModifierGArtBouton.Name = "ModifierGArtBouton"
        Me.ModifierGArtBouton.Size = New System.Drawing.Size(153, 35)
        Me.ModifierGArtBouton.TabIndex = 15
        Me.ModifierGArtBouton.Text = "Modifier"
        Me.ModifierGArtBouton.UseVisualStyleBackColor = True
        '
        'FermerGArtBouton
        '
        Me.FermerGArtBouton.Location = New System.Drawing.Point(3, 166)
        Me.FermerGArtBouton.Name = "FermerGArtBouton"
        Me.FermerGArtBouton.Size = New System.Drawing.Size(153, 35)
        Me.FermerGArtBouton.TabIndex = 14
        Me.FermerGArtBouton.Text = "Fermer"
        Me.FermerGArtBouton.UseVisualStyleBackColor = True
        '
        'GestionArticles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1149, 502)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DGVArticle)
        Me.Name = "GestionArticles"
        Me.Text = "GestionDesArticles"
        CType(Me.DGVArticle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NouvelGArtBouton As System.Windows.Forms.Button
    Friend WithEvents DGVArticle As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ImprimerGArtBouton As System.Windows.Forms.Button
    Friend WithEvents supprimerGArtBouton As System.Windows.Forms.Button
    Friend WithEvents ModifierGArtBouton As System.Windows.Forms.Button
    Friend WithEvents FermerGArtBouton As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents NoArticle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Categorie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Etat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantite As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Prix As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoSeri As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
