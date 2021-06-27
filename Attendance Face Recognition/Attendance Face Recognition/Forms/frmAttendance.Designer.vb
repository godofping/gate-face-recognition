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
        Me.imageBox1 = New Emgu.CV.UI.ImageBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.imageBoxFrameGrabber = New Emgu.CV.UI.ImageBox()
        Me.button2 = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.imageBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imageBoxFrameGrabber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'imageBox1
        '
        Me.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imageBox1.Location = New System.Drawing.Point(11, 18)
        Me.imageBox1.Name = "imageBox1"
        Me.imageBox1.Size = New System.Drawing.Size(106, 89)
        Me.imageBox1.TabIndex = 5
        Me.imageBox1.TabStop = False
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.Red
        Me.label3.Location = New System.Drawing.Point(387, 369)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(16, 16)
        Me.label3.TabIndex = 22
        Me.label3.Text = "0"
        '
        'imageBoxFrameGrabber
        '
        Me.imageBoxFrameGrabber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imageBoxFrameGrabber.Location = New System.Drawing.Point(201, 70)
        Me.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber"
        Me.imageBoxFrameGrabber.Size = New System.Drawing.Size(320, 240)
        Me.imageBoxFrameGrabber.TabIndex = 19
        Me.imageBoxFrameGrabber.TabStop = False
        '
        'button2
        '
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button2.Location = New System.Drawing.Point(11, 158)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(106, 31)
        Me.button2.TabIndex = 3
        Me.button2.Text = "Train"
        Me.button2.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.Blue
        Me.label4.Location = New System.Drawing.Point(201, 339)
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
        Me.label5.Location = New System.Drawing.Point(201, 313)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(197, 15)
        Me.label5.TabIndex = 25
        Me.label5.Text = "Persons present in the scene:"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Controls.Add(Me.textBox1)
        Me.groupBox1.Controls.Add(Me.imageBox1)
        Me.groupBox1.Controls.Add(Me.button2)
        Me.groupBox1.Location = New System.Drawing.Point(527, 100)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(126, 210)
        Me.groupBox1.TabIndex = 20
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Training: "
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(8, 119)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(41, 13)
        Me.label1.TabIndex = 8
        Me.label1.Text = "Name: "
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(11, 135)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(103, 20)
        Me.textBox1.TabIndex = 7
        Me.textBox1.Text = "----"
        '
        'button1
        '
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button1.Location = New System.Drawing.Point(201, 388)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(452, 36)
        Me.button1.TabIndex = 18
        Me.button1.Text = "Start"
        Me.button1.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(202, 369)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(179, 15)
        Me.label2.TabIndex = 21
        Me.label2.Text = "Number of faces detected: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(527, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 16)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Face Recognition"
        '
        'frmAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 491)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.imageBoxFrameGrabber)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.Label6)
        Me.Name = "frmAttendance"
        Me.Text = "frmAttendance"
        CType(Me.imageBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imageBoxFrameGrabber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents imageBox1 As Emgu.CV.UI.ImageBox
    Private WithEvents label3 As Label
    Private WithEvents imageBoxFrameGrabber As Emgu.CV.UI.ImageBox
    Private WithEvents button2 As Button
    Private WithEvents label4 As Label
    Private WithEvents label5 As Label
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents label1 As Label
    Private WithEvents textBox1 As TextBox
    Private WithEvents button1 As Button
    Private WithEvents label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label6 As Label
End Class
