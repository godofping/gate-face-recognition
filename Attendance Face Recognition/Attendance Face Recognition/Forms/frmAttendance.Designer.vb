<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttendance
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
        Me.components = New System.ComponentModel.Container()
        Me.label3 = New System.Windows.Forms.Label()
        Me.imageBoxFrameGrabber = New Emgu.CV.UI.ImageBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.imageBoxFrameGrabber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Red
        Me.label3.Location = New System.Drawing.Point(830, 519)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(16, 16)
        Me.label3.TabIndex = 22
        Me.label3.Text = "0"
        '
        'imageBoxFrameGrabber
        '
        Me.imageBoxFrameGrabber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imageBoxFrameGrabber.Location = New System.Drawing.Point(12, 12)
        Me.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber"
        Me.imageBoxFrameGrabber.Size = New System.Drawing.Size(615, 477)
        Me.imageBoxFrameGrabber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imageBoxFrameGrabber.TabIndex = 19
        Me.imageBoxFrameGrabber.TabStop = False
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Blue
        Me.label4.Location = New System.Drawing.Point(644, 489)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(45, 19)
        Me.label4.TabIndex = 23
        Me.label4.Text = "........."
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.Black
        Me.label5.Location = New System.Drawing.Point(644, 463)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(197, 15)
        Me.label5.TabIndex = 25
        Me.label5.Text = "Persons present in the scene:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(645, 519)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(179, 15)
        Me.label2.TabIndex = 21
        Me.label2.Text = "Number of faces detected: "
        '
        'Timer1
        '
        '
        'frmAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 558)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.imageBoxFrameGrabber)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label2)
        Me.name = "frmAttendance"
        Me.Text = "frmAttendance"
        CType(Me.imageBoxFrameGrabber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label3 As Label
    Private WithEvents imageBoxFrameGrabber As Emgu.CV.UI.ImageBox
    Private WithEvents label4 As Label
    Private WithEvents label5 As Label
    Private WithEvents label2 As Label
    Friend WithEvents Timer1 As Timer
End Class
