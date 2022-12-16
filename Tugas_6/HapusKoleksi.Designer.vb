<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusKoleksi
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
        Me.Apakah_ingin_menghapus_koleksi = New System.Windows.Forms.Label()
        Me.Koleksi_A = New System.Windows.Forms.Label()
        Me.Hapus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Apakah_ingin_menghapus_koleksi
        '
        Me.Apakah_ingin_menghapus_koleksi.AutoSize = True
        Me.Apakah_ingin_menghapus_koleksi.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Apakah_ingin_menghapus_koleksi.Location = New System.Drawing.Point(151, 63)
        Me.Apakah_ingin_menghapus_koleksi.Name = "Apakah_ingin_menghapus_koleksi"
        Me.Apakah_ingin_menghapus_koleksi.Size = New System.Drawing.Size(512, 45)
        Me.Apakah_ingin_menghapus_koleksi.TabIndex = 0
        Me.Apakah_ingin_menghapus_koleksi.Text = "Apakah ingin menghapus koleksi ?"
        '
        'Koleksi_A
        '
        Me.Koleksi_A.AutoSize = True
        Me.Koleksi_A.Font = New System.Drawing.Font("Unispace", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Koleksi_A.ForeColor = System.Drawing.Color.DarkRed
        Me.Koleksi_A.Location = New System.Drawing.Point(290, 195)
        Me.Koleksi_A.Name = "Koleksi_A"
        Me.Koleksi_A.Size = New System.Drawing.Size(236, 48)
        Me.Koleksi_A.TabIndex = 1
        Me.Koleksi_A.Text = "Koleksi A"
        '
        'Hapus
        '
        Me.Hapus.BackColor = System.Drawing.Color.Transparent
        Me.Hapus.Location = New System.Drawing.Point(290, 319)
        Me.Hapus.Name = "Hapus"
        Me.Hapus.Size = New System.Drawing.Size(221, 64)
        Me.Hapus.TabIndex = 2
        Me.Hapus.Text = "Hapus"
        Me.Hapus.UseVisualStyleBackColor = False
        '
        'HapusKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Hapus)
        Me.Controls.Add(Me.Koleksi_A)
        Me.Controls.Add(Me.Apakah_ingin_menghapus_koleksi)
        Me.Name = "HapusKoleksi"
        Me.Text = "HapusKoleksi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Apakah_ingin_menghapus_koleksi As Label
    Friend WithEvents Koleksi_A As Label
    Friend WithEvents Hapus As Button
End Class
