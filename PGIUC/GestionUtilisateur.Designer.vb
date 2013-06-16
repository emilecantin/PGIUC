<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionUtilisateur
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ImprimerGUtilBouton = New System.Windows.Forms.Button()
        Me.supprimerGUtilBouton = New System.Windows.Forms.Button()
        Me.NouvelGUtilBouton = New System.Windows.Forms.Button()
        Me.ModifierGUtilBouton = New System.Windows.Forms.Button()
        Me.FermerGUtilBouton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NoMembre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prenom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(206, 496)
        Me.Panel1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ImprimerGUtilBouton)
        Me.Panel2.Controls.Add(Me.supprimerGUtilBouton)
        Me.Panel2.Controls.Add(Me.NouvelGUtilBouton)
        Me.Panel2.Controls.Add(Me.ModifierGUtilBouton)
        Me.Panel2.Controls.Add(Me.FermerGUtilBouton)
        Me.Panel2.Location = New System.Drawing.Point(24, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(161, 206)
        Me.Panel2.TabIndex = 18
        '
        'ImprimerGUtilBouton
        '
        Me.ImprimerGUtilBouton.Location = New System.Drawing.Point(3, 125)
        Me.ImprimerGUtilBouton.Name = "ImprimerGUtilBouton"
        Me.ImprimerGUtilBouton.Size = New System.Drawing.Size(153, 35)
        Me.ImprimerGUtilBouton.TabIndex = 17
        Me.ImprimerGUtilBouton.Text = "Imprimer"
        Me.ImprimerGUtilBouton.UseVisualStyleBackColor = True
        '
        'supprimerGUtilBouton
        '
        Me.supprimerGUtilBouton.Location = New System.Drawing.Point(3, 84)
        Me.supprimerGUtilBouton.Name = "supprimerGUtilBouton"
        Me.supprimerGUtilBouton.Size = New System.Drawing.Size(153, 35)
        Me.supprimerGUtilBouton.TabIndex = 16
        Me.supprimerGUtilBouton.Text = "Supprimer"
        Me.supprimerGUtilBouton.UseVisualStyleBackColor = True
        '
        'NouvelGUtilBouton
        '
        Me.NouvelGUtilBouton.Location = New System.Drawing.Point(3, 2)
        Me.NouvelGUtilBouton.Name = "NouvelGUtilBouton"
        Me.NouvelGUtilBouton.Size = New System.Drawing.Size(153, 35)
        Me.NouvelGUtilBouton.TabIndex = 0
        Me.NouvelGUtilBouton.Text = "Nouveau Membre"
        Me.NouvelGUtilBouton.UseVisualStyleBackColor = True
        '
        'ModifierGUtilBouton
        '
        Me.ModifierGUtilBouton.Location = New System.Drawing.Point(3, 43)
        Me.ModifierGUtilBouton.Name = "ModifierGUtilBouton"
        Me.ModifierGUtilBouton.Size = New System.Drawing.Size(153, 35)
        Me.ModifierGUtilBouton.TabIndex = 15
        Me.ModifierGUtilBouton.Text = "Modifier"
        Me.ModifierGUtilBouton.UseVisualStyleBackColor = True
        '
        'FermerGUtilBouton
        '
        Me.FermerGUtilBouton.Location = New System.Drawing.Point(3, 166)
        Me.FermerGUtilBouton.Name = "FermerGUtilBouton"
        Me.FermerGUtilBouton.Size = New System.Drawing.Size(153, 35)
        Me.FermerGUtilBouton.TabIndex = 14
        Me.FermerGUtilBouton.Text = "Fermer"
        Me.FermerGUtilBouton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoMembre, Me.Grade, Me.Nom, Me.Prenom, Me.Type})
        Me.DataGridView1.Location = New System.Drawing.Point(211, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(605, 496)
        Me.DataGridView1.TabIndex = 6
        '
        'NoMembre
        '
        Me.NoMembre.HeaderText = "No. membre"
        Me.NoMembre.Name = "NoMembre"
        Me.NoMembre.Width = 80
        '
        'Grade
        '
        Me.Grade.HeaderText = "Grade"
        Me.Grade.Name = "Grade"
        '
        'Nom
        '
        Me.Nom.HeaderText = "Nom"
        Me.Nom.Name = "Nom"
        Me.Nom.Width = 150
        '
        'Prenom
        '
        Me.Prenom.HeaderText = "Prénom"
        Me.Prenom.Name = "Prenom"
        Me.Prenom.Width = 150
        '
        'Type
        '
        Me.Type.HeaderText = "Type"
        Me.Type.Name = "Type"
        Me.Type.Width = 80
        '
        'GestionUtilisateur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 502)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "GestionUtilisateur"
        Me.Text = "Gestion des membres"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ImprimerGUtilBouton As System.Windows.Forms.Button
    Friend WithEvents supprimerGUtilBouton As System.Windows.Forms.Button
    Friend WithEvents NouvelGUtilBouton As System.Windows.Forms.Button
    Friend WithEvents ModifierGUtilBouton As System.Windows.Forms.Button
    Friend WithEvents FermerGUtilBouton As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents NoMembre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Grade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Prenom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Type As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
