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
        Me.timerCamera = New System.Windows.Forms.Timer(Me.components)
        Me.lblAttendanceType = New System.Windows.Forms.Label()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.timerSMS = New System.Windows.Forms.Timer(Me.components)
        Me.pnlStudentInformation = New System.Windows.Forms.Panel()
        Me.lblStudent = New System.Windows.Forms.Label()
        Me.timerStudentInformation = New System.Windows.Forms.Timer(Me.components)
        Me.timerSetting = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.IBCamera = New Emgu.CV.UI.ImageBox()
        Me.pnlTop.SuspendLayout()
        Me.pnlStudentInformation.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IBCamera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timerCamera
        '
        '
        'lblAttendanceType
        '
        Me.lblAttendanceType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAttendanceType.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttendanceType.ForeColor = System.Drawing.Color.Black
        Me.lblAttendanceType.Location = New System.Drawing.Point(33, 196)
        Me.lblAttendanceType.Name = "lblAttendanceType"
        Me.lblAttendanceType.Size = New System.Drawing.Size(1321, 55)
        Me.lblAttendanceType.TabIndex = 21
        Me.lblAttendanceType.Text = "ENTRANCE"
        Me.lblAttendanceType.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(886, 55)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "FAST: Face Attendance SMS Terminal"
        '
        'lblDateTime
        '
        Me.lblDateTime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.ForeColor = System.Drawing.Color.Olive
        Me.lblDateTime.Location = New System.Drawing.Point(12, 132)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(1342, 51)
        Me.lblDateTime.TabIndex = 26
        Me.lblDateTime.Text = "Loading system.."
        Me.lblDateTime.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'timerSMS
        '
        Me.timerSMS.Interval = 5000
        '
        'pnlStudentInformation
        '
        Me.pnlStudentInformation.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pnlStudentInformation.BackColor = System.Drawing.Color.Green
        Me.pnlStudentInformation.Controls.Add(Me.lblStudent)
        Me.pnlStudentInformation.Location = New System.Drawing.Point(480, 507)
        Me.pnlStudentInformation.Name = "pnlStudentInformation"
        Me.pnlStudentInformation.Size = New System.Drawing.Size(466, 238)
        Me.pnlStudentInformation.TabIndex = 27
        Me.pnlStudentInformation.Visible = False
        '
        'lblStudent
        '
        Me.lblStudent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudent.ForeColor = System.Drawing.Color.White
        Me.lblStudent.Location = New System.Drawing.Point(16, 17)
        Me.lblStudent.Name = "lblStudent"
        Me.lblStudent.Size = New System.Drawing.Size(428, 207)
        Me.lblStudent.TabIndex = 22
        Me.lblStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timerStudentInformation
        '
        Me.timerStudentInformation.Interval = 1000
        '
        'timerSetting
        '
        Me.timerSetting.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Face_Attendance_SMS_Terminal.My.Resources.Resources.logondl
        Me.PictureBox1.Location = New System.Drawing.Point(1248, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'IBCamera
        '
        Me.IBCamera.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.IBCamera.BackColor = System.Drawing.Color.Black
        Me.IBCamera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.IBCamera.Location = New System.Drawing.Point(480, 254)
        Me.IBCamera.Name = "IBCamera"
        Me.IBCamera.Size = New System.Drawing.Size(466, 436)
        Me.IBCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IBCamera.TabIndex = 28
        Me.IBCamera.TabStop = False
        '
        'frmAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.pnlStudentInformation)
        Me.Controls.Add(Me.IBCamera)
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.pnlTop)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.lblAttendanceType)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.name = "frmAttendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAttendance"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        Me.pnlStudentInformation.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IBCamera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents timerCamera As Timer
    Friend WithEvents lblAttendanceType As Label
    Friend WithEvents pnlBottom As Panel
    Friend WithEvents pnlTop As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents timerSMS As Timer
    Friend WithEvents pnlStudentInformation As Panel
    Friend WithEvents lblStudent As Label
    Friend WithEvents timerStudentInformation As Timer
    Friend WithEvents timerSetting As Timer
    Private WithEvents IBCamera As Emgu.CV.UI.ImageBox
End Class
