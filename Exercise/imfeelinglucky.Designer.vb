<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class imfeelinglucky
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(imfeelinglucky))
        Me.kazusa = New System.Windows.Forms.Panel()
        Me.lblMaaf = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'kazusa
        '
        Me.kazusa.BackgroundImage = CType(resources.GetObject("kazusa.BackgroundImage"), System.Drawing.Image)
        Me.kazusa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.kazusa.Location = New System.Drawing.Point(12, 48)
        Me.kazusa.Name = "kazusa"
        Me.kazusa.Size = New System.Drawing.Size(362, 358)
        Me.kazusa.TabIndex = 0
        '
        'lblMaaf
        '
        Me.lblMaaf.AutoSize = True
        Me.lblMaaf.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblMaaf.Location = New System.Drawing.Point(2, 8)
        Me.lblMaaf.Name = "lblMaaf"
        Me.lblMaaf.Size = New System.Drawing.Size(383, 32)
        Me.lblMaaf.TabIndex = 1
        Me.lblMaaf.Text = "Fitur Daftar Belum DIimplementasi"
        '
        'imfeelinglucky
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 416)
        Me.Controls.Add(Me.lblMaaf)
        Me.Controls.Add(Me.kazusa)
        Me.Name = "imfeelinglucky"
        Me.Text = "imfeelinglucky"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents kazusa As Panel
    Friend WithEvents lblMaaf As Label
End Class
