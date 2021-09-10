<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettingsGSMModule
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
        Me.lblBroadbandCom = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbBroadbandCom = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblBroadbandCom
        '
        Me.lblBroadbandCom.AutoSize = True
        Me.lblBroadbandCom.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBroadbandCom.Location = New System.Drawing.Point(289, 139)
        Me.lblBroadbandCom.Name = "lblBroadbandCom"
        Me.lblBroadbandCom.Size = New System.Drawing.Size(26, 18)
        Me.lblBroadbandCom.TabIndex = 57
        Me.lblBroadbandCom.Text = "<>"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(292, 185)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(122, 37)
        Me.btnSave.TabIndex = 52
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(26, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 36)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "GSM Module"
        '
        'cbBroadbandCom
        '
        Me.cbBroadbandCom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbBroadbandCom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbBroadbandCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBroadbandCom.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.cbBroadbandCom.FormattingEnabled = True
        Me.cbBroadbandCom.ItemHeight = 20
        Me.cbBroadbandCom.Location = New System.Drawing.Point(292, 108)
        Me.cbBroadbandCom.Name = "cbBroadbandCom"
        Me.cbBroadbandCom.Size = New System.Drawing.Size(265, 28)
        Me.cbBroadbandCom.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(83, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 20)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "GSM Module COM Port"
        '
        'frmSettingsGSMModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1024, 690)
        Me.Controls.Add(Me.lblBroadbandCom)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbBroadbandCom)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSettingsGSMModule"
        Me.Text = "frmSettingsGSMModule"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBroadbandCom As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cbBroadbandCom As ComboBox
    Friend WithEvents Label4 As Label
End Class
