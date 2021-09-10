<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettingsCamera
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
        Me.cbCameraExit = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbCameraEntrance = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCameraEntrance = New System.Windows.Forms.Label()
        Me.lblCameraExit = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbCameraExit
        '
        Me.cbCameraExit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbCameraExit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbCameraExit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCameraExit.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.cbCameraExit.FormattingEnabled = True
        Me.cbCameraExit.ItemHeight = 20
        Me.cbCameraExit.Location = New System.Drawing.Point(255, 196)
        Me.cbCameraExit.Name = "cbCameraExit"
        Me.cbCameraExit.Size = New System.Drawing.Size(265, 28)
        Me.cbCameraExit.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(108, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 20)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Camera for Exit"
        '
        'cbCameraEntrance
        '
        Me.cbCameraEntrance.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbCameraEntrance.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbCameraEntrance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCameraEntrance.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.cbCameraEntrance.FormattingEnabled = True
        Me.cbCameraEntrance.ItemHeight = 20
        Me.cbCameraEntrance.Location = New System.Drawing.Point(255, 117)
        Me.cbCameraEntrance.Name = "cbCameraEntrance"
        Me.cbCameraEntrance.Size = New System.Drawing.Size(265, 28)
        Me.cbCameraEntrance.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 20)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Camera for Entrance"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(255, 268)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(122, 37)
        Me.btnSave.TabIndex = 40
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(26, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 36)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Camera"
        '
        'lblCameraEntrance
        '
        Me.lblCameraEntrance.AutoSize = True
        Me.lblCameraEntrance.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCameraEntrance.Location = New System.Drawing.Point(252, 148)
        Me.lblCameraEntrance.Name = "lblCameraEntrance"
        Me.lblCameraEntrance.Size = New System.Drawing.Size(26, 18)
        Me.lblCameraEntrance.TabIndex = 47
        Me.lblCameraEntrance.Text = "<>"
        '
        'lblCameraExit
        '
        Me.lblCameraExit.AutoSize = True
        Me.lblCameraExit.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCameraExit.Location = New System.Drawing.Point(252, 227)
        Me.lblCameraExit.Name = "lblCameraExit"
        Me.lblCameraExit.Size = New System.Drawing.Size(26, 18)
        Me.lblCameraExit.TabIndex = 48
        Me.lblCameraExit.Text = "<>"
        '
        'frmSettingsCamera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1024, 690)
        Me.Controls.Add(Me.lblCameraExit)
        Me.Controls.Add(Me.lblCameraEntrance)
        Me.Controls.Add(Me.cbCameraExit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbCameraEntrance)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSettingsCamera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSetting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbCameraExit As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbCameraEntrance As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCameraEntrance As Label
    Friend WithEvents lblCameraExit As Label
End Class
