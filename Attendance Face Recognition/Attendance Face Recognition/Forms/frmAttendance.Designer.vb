<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAttendance
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
        Me.IBEntrance = New Emgu.CV.UI.ImageBox()
        Me.timerCameraEntrance = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IBExit = New Emgu.CV.UI.ImageBox()
        Me.timerCameraExit = New System.Windows.Forms.Timer(Me.components)
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        CType(Me.IBEntrance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IBExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IBEntrance
        '
        Me.IBEntrance.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.IBEntrance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IBEntrance.Location = New System.Drawing.Point(88, 252)
        Me.IBEntrance.Name = "IBEntrance"
        Me.IBEntrance.Size = New System.Drawing.Size(466, 436)
        Me.IBEntrance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IBEntrance.TabIndex = 19
        Me.IBEntrance.TabStop = False
        '
        'timerCameraEntrance
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(82, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 33)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "ENTRANCE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(678, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 33)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "EXIT"
        '
        'IBExit
        '
        Me.IBExit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.IBExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IBExit.Location = New System.Drawing.Point(684, 252)
        Me.IBExit.Name = "IBExit"
        Me.IBExit.Size = New System.Drawing.Size(466, 436)
        Me.IBExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IBExit.TabIndex = 22
        Me.IBExit.TabStop = False
        '
        'timerCameraExit
        '
        '
        'pnlBottom
        '
        Me.pnlBottom.BackColor = System.Drawing.Color.Green
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 751)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(1366, 17)
        Me.pnlBottom.TabIndex = 24
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.Color.White
        Me.pnlTop.Controls.Add(Me.PictureBox1)
        Me.pnlTop.Controls.Add(Me.Label1)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(1366, 113)
        Me.pnlTop.TabIndex = 25
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Attendance_Face_Recognition.My.Resources.Resources.sksu_logo
        Me.PictureBox1.Location = New System.Drawing.Point(1248, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(878, 56)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "FAST: Face Attendance SMS Terminal"
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Font = New System.Drawing.Font("Century Gothic", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.ForeColor = System.Drawing.Color.Green
        Me.lblDateTime.Location = New System.Drawing.Point(79, 135)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(159, 49)
        Me.lblDateTime.TabIndex = 26
        Me.lblDateTime.Text = "Label4"
        '
        'frmAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.IBExit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IBEntrance)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmAttendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAttendance"
        CType(Me.IBEntrance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IBExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents IBEntrance As Emgu.CV.UI.ImageBox
    Friend WithEvents timerCameraEntrance As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Private WithEvents IBExit As Emgu.CV.UI.ImageBox
    Friend WithEvents timerCameraExit As Timer
    Friend WithEvents pnlBottom As Panel
    Friend WithEvents pnlTop As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
