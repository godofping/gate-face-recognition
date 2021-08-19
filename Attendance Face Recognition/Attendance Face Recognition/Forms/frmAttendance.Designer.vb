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
        Me.pnlStudentInformationEntrance = New System.Windows.Forms.Panel()
        Me.lblStudentEntrance = New System.Windows.Forms.Label()
        Me.timerStudentInformationEntrance = New System.Windows.Forms.Timer(Me.components)
        Me.pnlStudentInformationExit = New System.Windows.Forms.Panel()
        Me.lblStudentExit = New System.Windows.Forms.Label()
        Me.timerStudentInformationExit = New System.Windows.Forms.Timer(Me.components)
        CType(Me.IBEntrance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IBExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStudentInformationEntrance.SuspendLayout()
        Me.pnlStudentInformationExit.SuspendLayout()
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
        Me.IBEntrance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
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
        Me.Label3.Location = New System.Drawing.Point(698, 207)
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
        Me.IBExit.Location = New System.Drawing.Point(704, 252)
        Me.IBExit.Name = "IBExit"
        Me.IBExit.Size = New System.Drawing.Size(466, 436)
        Me.IBExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
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
        Me.PictureBox1.Image = Global.Face_Attendance_SMS_Terminal.My.Resources.Resources.sksu_logo
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
        Me.lblDateTime.ForeColor = System.Drawing.Color.Olive
        Me.lblDateTime.Location = New System.Drawing.Point(79, 135)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(369, 49)
        Me.lblDateTime.TabIndex = 26
        Me.lblDateTime.Text = "Loading system.."
        '
        'pnlStudentInformationEntrance
        '
        Me.pnlStudentInformationEntrance.BackColor = System.Drawing.Color.Green
        Me.pnlStudentInformationEntrance.Controls.Add(Me.lblStudentEntrance)
        Me.pnlStudentInformationEntrance.Location = New System.Drawing.Point(12, 383)
        Me.pnlStudentInformationEntrance.Name = "pnlStudentInformationEntrance"
        Me.pnlStudentInformationEntrance.Size = New System.Drawing.Size(610, 238)
        Me.pnlStudentInformationEntrance.TabIndex = 27
        Me.pnlStudentInformationEntrance.Visible = False
        '
        'lblStudentEntrance
        '
        Me.lblStudentEntrance.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentEntrance.ForeColor = System.Drawing.Color.White
        Me.lblStudentEntrance.Location = New System.Drawing.Point(16, 17)
        Me.lblStudentEntrance.Name = "lblStudentEntrance"
        Me.lblStudentEntrance.Size = New System.Drawing.Size(579, 207)
        Me.lblStudentEntrance.TabIndex = 22
        '
        'timerStudentInformationEntrance
        '
        Me.timerStudentInformationEntrance.Interval = 1000
        '
        'pnlStudentInformationExit
        '
        Me.pnlStudentInformationExit.BackColor = System.Drawing.Color.DarkGreen
        Me.pnlStudentInformationExit.Controls.Add(Me.lblStudentExit)
        Me.pnlStudentInformationExit.Location = New System.Drawing.Point(628, 383)
        Me.pnlStudentInformationExit.Name = "pnlStudentInformationExit"
        Me.pnlStudentInformationExit.Size = New System.Drawing.Size(610, 238)
        Me.pnlStudentInformationExit.TabIndex = 28
        Me.pnlStudentInformationExit.Visible = False
        '
        'lblStudentExit
        '
        Me.lblStudentExit.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudentExit.ForeColor = System.Drawing.Color.White
        Me.lblStudentExit.Location = New System.Drawing.Point(16, 17)
        Me.lblStudentExit.Name = "lblStudentExit"
        Me.lblStudentExit.Size = New System.Drawing.Size(579, 207)
        Me.lblStudentExit.TabIndex = 22
        '
        'timerStudentInformationExit
        '
        Me.timerStudentInformationExit.Interval = 1000
        '
        'frmAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.pnlStudentInformationExit)
        Me.Controls.Add(Me.pnlStudentInformationEntrance)
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
        Me.pnlStudentInformationEntrance.ResumeLayout(False)
        Me.pnlStudentInformationExit.ResumeLayout(False)
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
    Friend WithEvents pnlStudentInformationEntrance As Panel
    Friend WithEvents lblStudentEntrance As Label
    Friend WithEvents timerStudentInformationEntrance As Timer
    Friend WithEvents pnlStudentInformationExit As Panel
    Friend WithEvents lblStudentExit As Label
    Friend WithEvents timerStudentInformationExit As Timer
End Class
