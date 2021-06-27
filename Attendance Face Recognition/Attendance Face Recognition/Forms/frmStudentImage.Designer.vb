<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudentImage
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ibCamera = New Emgu.CV.UI.ImageBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.btnTakePicture = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.ibDetectedFace = New Emgu.CV.UI.ImageBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblFor = New System.Windows.Forms.Label()
        CType(Me.ibCamera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ibDetectedFace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ibCamera
        '
        Me.ibCamera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ibCamera.Location = New System.Drawing.Point(31, 166)
        Me.ibCamera.Name = "ibCamera"
        Me.ibCamera.Size = New System.Drawing.Size(446, 340)
        Me.ibCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ibCamera.TabIndex = 20
        Me.ibCamera.TabStop = False
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeColumns = False
        Me.dgv.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv.EnableHeadersVisualStyles = False
        Me.dgv.Location = New System.Drawing.Point(501, 65)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgv.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(394, 484)
        Me.dgv.TabIndex = 21
        '
        'btnTakePicture
        '
        Me.btnTakePicture.BackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnTakePicture.FlatAppearance.BorderSize = 0
        Me.btnTakePicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTakePicture.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTakePicture.ForeColor = System.Drawing.Color.White
        Me.btnTakePicture.Location = New System.Drawing.Point(31, 512)
        Me.btnTakePicture.Name = "btnTakePicture"
        Me.btnTakePicture.Size = New System.Drawing.Size(122, 37)
        Me.btnTakePicture.TabIndex = 22
        Me.btnTakePicture.Text = "TAKE PICTURE"
        Me.btnTakePicture.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(25, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 72)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "TAKE PICTURE FOR " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FACE RECOGNITION"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(773, 22)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(122, 37)
        Me.btnDelete.TabIndex = 24
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'ibDetectedFace
        '
        Me.ibDetectedFace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ibDetectedFace.Location = New System.Drawing.Point(358, 12)
        Me.ibDetectedFace.Name = "ibDetectedFace"
        Me.ibDetectedFace.Size = New System.Drawing.Size(93, 82)
        Me.ibDetectedFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ibDetectedFace.TabIndex = 25
        Me.ibDetectedFace.TabStop = False
        Me.ibDetectedFace.Visible = False
        '
        'Timer1
        '
        '
        'lblFor
        '
        Me.lblFor.AutoSize = True
        Me.lblFor.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFor.Location = New System.Drawing.Point(27, 122)
        Me.lblFor.Name = "lblFor"
        Me.lblFor.Size = New System.Drawing.Size(31, 20)
        Me.lblFor.TabIndex = 27
        Me.lblFor.Text = "For"
        '
        'frmStudentImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(907, 561)
        Me.Controls.Add(Me.lblFor)
        Me.Controls.Add(Me.ibDetectedFace)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTakePicture)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.ibCamera)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStudentImage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmStudentImage"
        CType(Me.ibCamera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ibDetectedFace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents ibCamera As Emgu.CV.UI.ImageBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents btnTakePicture As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDelete As Button
    Private WithEvents ibDetectedFace As Emgu.CV.UI.ImageBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblFor As Label
End Class
