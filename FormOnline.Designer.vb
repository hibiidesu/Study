<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOnline
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
        Me.lblOnline = New System.Windows.Forms.Label()
        Me.lblJumlah = New System.Windows.Forms.Label()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblOnline
        '
        Me.lblOnline.AutoSize = True
        Me.lblOnline.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblOnline.Location = New System.Drawing.Point(75, 33)
        Me.lblOnline.Name = "lblOnline"
        Me.lblOnline.Size = New System.Drawing.Size(200, 25)
        Me.lblOnline.TabIndex = 0
        Me.lblOnline.Text = "Jumlah Pemain Online"
        '
        'lblJumlah
        '
        Me.lblJumlah.AutoSize = True
        Me.lblJumlah.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblJumlah.Location = New System.Drawing.Point(144, 85)
        Me.lblJumlah.Name = "lblJumlah"
        Me.lblJumlah.Size = New System.Drawing.Size(54, 45)
        Me.lblJumlah.TabIndex = 1
        Me.lblJumlah.Text = "10"
        '
        'btnMin
        '
        Me.btnMin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnMin.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMin.Location = New System.Drawing.Point(28, 156)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(41, 23)
        Me.btnMin.TabIndex = 2
        Me.btnMin.Text = "-"
        Me.btnMin.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(134, 185)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 3
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnPlus
        '
        Me.btnPlus.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPlus.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPlus.Location = New System.Drawing.Point(281, 156)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(41, 23)
        Me.btnPlus.TabIndex = 4
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(75, 156)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(200, 23)
        Me.txtValue.TabIndex = 5
        '
        'FormOnline
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 223)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.btnMin)
        Me.Controls.Add(Me.lblJumlah)
        Me.Controls.Add(Me.lblOnline)
        Me.Name = "FormOnline"
        Me.Text = "FormOnline"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOnline As Label
    Friend WithEvents lblJumlah As Label
    Friend WithEvents btnMin As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents txtValue As TextBox
End Class
