<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionCategories
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
        Me.DGVCategorie = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categorie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ImprimerGCatBouton = New System.Windows.Forms.Button()
        Me.supprimerGCatBouton = New System.Windows.Forms.Button()
        Me.NouvelGCatBouton = New System.Windows.Forms.Button()
        Me.ModifierGCatBouton = New System.Windows.Forms.Button()
        Me.FermerGCatBouton = New System.Windows.Forms.Button()
        CType(Me.DGVCategorie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVCategorie
        '
        Me.DGVCategorie.AllowUserToAddRows = False
        Me.DGVCategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCategorie.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.Categorie})
        Me.DGVCategorie.Location = New System.Drawing.Point(211, 3)
        Me.DGVCategorie.Name = "DGVCategorie"
        Me.DGVCategorie.Size = New System.Drawing.Size(395, 496)
        Me.DGVCategorie.TabIndex = 8
        '
        'No
        '
        Me.No.HeaderText = "No"
        Me.No.Name = "No"
        Me.No.Width = 50
        '
        'Categorie
        '
        Me.Categorie.HeaderText = "Catégorie"
        Me.Categorie.Name = "Categorie"
        Me.Categorie.Width = 300
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(206, 496)
        Me.Panel1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ImprimerGCatBouton)
        Me.Panel2.Controls.Add(Me.supprimerGCatBouton)
        Me.Panel2.Controls.Add(Me.NouvelGCatBouton)
        Me.Panel2.Controls.Add(Me.ModifierGCatBouton)
        Me.Panel2.Controls.Add(Me.FermerGCatBouton)
        Me.Panel2.Location = New System.Drawing.Point(24, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(161, 206)
        Me.Panel2.TabIndex = 18
        '
        'ImprimerGCatBouton
        '
        Me.ImprimerGCatBouton.Location = New System.Drawing.Point(3, 125)
        Me.ImprimerGCatBouton.Name = "ImprimerGCatBouton"
        Me.ImprimerGCatBouton.Size = New System.Drawing.Size(153, 35)
        Me.ImprimerGCatBouton.TabIndex = 17
        Me.ImprimerGCatBouton.Text = "Imprimer"
        Me.ImprimerGCatBouton.UseVisualStyleBackColor = True
        '
        'supprimerGCatBouton
        '
        Me.supprimerGCatBouton.Location = New System.Drawing.Point(3, 84)
        Me.supprimerGCatBouton.Name = "supprimerGCatBouton"
        Me.supprimerGCatBouton.Size = New System.Drawing.Size(153, 35)
        Me.supprimerGCatBouton.TabIndex = 16
        Me.supprimerGCatBouton.Text = "Supprimer"
        Me.supprimerGCatBouton.UseVisualStyleBackColor = True
        '
        'NouvelGCatBouton
        '
        Me.NouvelGCatBouton.Location = New System.Drawing.Point(3, 2)
        Me.NouvelGCatBouton.Name = "NouvelGCatBouton"
        Me.NouvelGCatBouton.Size = New System.Drawing.Size(153, 35)
        Me.NouvelGCatBouton.TabIndex = 0
        Me.NouvelGCatBouton.Text = "Nouvel Catégorie"
        Me.NouvelGCatBouton.UseVisualStyleBackColor = True
        '
        'ModifierGCatBouton
        '
        Me.ModifierGCatBouton.Location = New System.Drawing.Point(3, 43)
        Me.ModifierGCatBouton.Name = "ModifierGCatBouton"
        Me.ModifierGCatBouton.Size = New System.Drawing.Size(153, 35)
        Me.ModifierGCatBouton.TabIndex = 15
        Me.ModifierGCatBouton.Text = "Modifier"
        Me.ModifierGCatBouton.UseVisualStyleBackColor = True
        '
        'FermerGCatBouton
        '
        Me.FermerGCatBouton.Location = New System.Drawing.Point(3, 166)
        Me.FermerGCatBouton.Name = "FermerGCatBouton"
        Me.FermerGCatBouton.Size = New System.Drawing.Size(153, 35)
        Me.FermerGCatBouton.TabIndex = 14
        Me.FermerGCatBouton.Text = "Fermer"
        Me.FermerGCatBouton.UseVisualStyleBackColor = True
        '
        'GestionCategories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 502)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DGVCategorie)
        Me.Name = "GestionCategories"
        Me.Text = "Gestion des catégories"
        CType(Me.DGVCategorie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGVCategorie As System.Windows.Forms.DataGridView
    Friend WithEvents No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Categorie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ImprimerGCatBouton As System.Windows.Forms.Button
    Friend WithEvents supprimerGCatBouton As System.Windows.Forms.Button
    Friend WithEvents NouvelGCatBouton As System.Windows.Forms.Button
    Friend WithEvents ModifierGCatBouton As System.Windows.Forms.Button
    Friend WithEvents FermerGCatBouton As System.Windows.Forms.Button
End Class
