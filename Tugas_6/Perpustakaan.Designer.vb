<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Perpustakaan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Koleksi_Buku = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahKoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Plus = New System.Windows.Forms.Button()
        Me.Minus = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Koleksi_Buku
        '
        Me.Koleksi_Buku.FormattingEnabled = True
        Me.Koleksi_Buku.ItemHeight = 32
        Me.Koleksi_Buku.Location = New System.Drawing.Point(12, 158)
        Me.Koleksi_Buku.Name = "Koleksi_Buku"
        Me.Koleksi_Buku.Size = New System.Drawing.Size(588, 452)
        Me.Koleksi_Buku.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KoleksiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(612, 40)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KoleksiToolStripMenuItem
        '
        Me.KoleksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahKoleksiToolStripMenuItem})
        Me.KoleksiToolStripMenuItem.Name = "KoleksiToolStripMenuItem"
        Me.KoleksiToolStripMenuItem.Size = New System.Drawing.Size(108, 36)
        Me.KoleksiToolStripMenuItem.Text = "Koleksi"
        '
        'TambahKoleksiToolStripMenuItem
        '
        Me.TambahKoleksiToolStripMenuItem.Name = "TambahKoleksiToolStripMenuItem"
        Me.TambahKoleksiToolStripMenuItem.Size = New System.Drawing.Size(359, 44)
        Me.TambahKoleksiToolStripMenuItem.Text = "Tambah Koleksi"
        '
        'Plus
        '
        Me.Plus.BackgroundImage = Global.Tugas_6.My.Resources.Resources.Plus
        Me.Plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Plus.FlatAppearance.BorderSize = 0
        Me.Plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Plus.Location = New System.Drawing.Point(12, 92)
        Me.Plus.Name = "Plus"
        Me.Plus.Size = New System.Drawing.Size(69, 55)
        Me.Plus.TabIndex = 2
        Me.Plus.UseVisualStyleBackColor = True
        '
        'Minus
        '
        Me.Minus.BackgroundImage = Global.Tugas_6.My.Resources.Resources.Minus
        Me.Minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Minus.FlatAppearance.BorderSize = 0
        Me.Minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Minus.Location = New System.Drawing.Point(87, 92)
        Me.Minus.Name = "Minus"
        Me.Minus.Size = New System.Drawing.Size(64, 55)
        Me.Minus.TabIndex = 3
        Me.Minus.UseVisualStyleBackColor = True
        '
        'Perpustakaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 622)
        Me.Controls.Add(Me.Minus)
        Me.Controls.Add(Me.Plus)
        Me.Controls.Add(Me.Koleksi_Buku)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Perpustakaan"
        Me.Text = "Perpustakaan"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Koleksi_Buku As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahKoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Plus As Button
    Friend WithEvents Minus As Button
End Class
