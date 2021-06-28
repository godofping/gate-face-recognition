<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.cbCamOut = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbCamIN = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbCom = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbCamOut
        '
        Me.cbCamOut.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbCamOut.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbCamOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCamOut.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.cbCamOut.FormattingEnabled = True
        Me.cbCamOut.ItemHeight = 20
        Me.cbCamOut.Location = New System.Drawing.Point(382, 211)
        Me.cbCamOut.Name = "cbCamOut"
        Me.cbCamOut.Size = New System.Drawing.Size(265, 28)
        Me.cbCamOut.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(136, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 20)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "CAMERA FOR EXIT *"
        '
        'cbCamIN
        '
        Me.cbCamIN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbCamIN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbCamIN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCamIN.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.cbCamIN.FormattingEnabled = True
        Me.cbCamIN.ItemHeight = 20
        Me.cbCamIN.Location = New System.Drawing.Point(382, 158)
        Me.cbCamIN.Name = "cbCamIN"
        Me.cbCamIN.Size = New System.Drawing.Size(265, 28)
        Me.cbCamIN.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(136, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 20)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "CAMERA FOR ENTRANCE *"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(382, 254)
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
        Me.Label1.Size = New System.Drawing.Size(123, 36)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Settings"
        '
        'cbCom
        '
        Me.cbCom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbCom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCom.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.cbCom.FormattingEnabled = True
        Me.cbCom.ItemHeight = 20
        Me.cbCom.Location = New System.Drawing.Point(382, 110)
        Me.cbCom.Name = "cbCom"
        Me.cbCom.Size = New System.Drawing.Size(265, 28)
        Me.cbCom.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(136, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 20)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "GSM MODULE COM PORT *"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1024, 690)
        Me.Controls.Add(Me.cbCamOut)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbCamIN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbCom)
        Me.Controls.Add(Me.Label4)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSetting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbCamOut As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbCamIN As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cbCom As ComboBox
    Friend WithEvents Label4 As Label
End Class
