<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettingsPromos
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
        Me.btnSend = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbPromos = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSend.FlatAppearance.BorderSize = 0
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSend.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.ForeColor = System.Drawing.Color.White
        Me.btnSend.Location = New System.Drawing.Point(187, 174)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(122, 37)
        Me.btnSend.TabIndex = 52
        Me.btnSend.Text = "SEND"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(26, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 36)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Promos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(73, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 20)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Promo Name:"
        '
        'cbPromos
        '
        Me.cbPromos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbPromos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbPromos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPromos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.cbPromos.FormattingEnabled = True
        Me.cbPromos.ItemHeight = 18
        Me.cbPromos.Items.AddRange(New Object() {"UNLIALLNET10", "COMBOALL10", "COMBO15", "COMBO20"})
        Me.cbPromos.Location = New System.Drawing.Point(187, 117)
        Me.cbPromos.Name = "cbPromos"
        Me.cbPromos.Size = New System.Drawing.Size(327, 26)
        Me.cbPromos.TabIndex = 57
        '
        'frmSettingsPromos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1024, 690)
        Me.Controls.Add(Me.cbPromos)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSettingsPromos"
        Me.Text = "frmSettingsPromos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSend As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbPromos As ComboBox
End Class
