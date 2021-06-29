<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportAttendanceOfStudent
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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtDate = New System.Windows.Forms.DateTimePicker()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.cbFrequency = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbGradeLevel = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(705, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 20)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Date *"
        '
        'dtDate
        '
        Me.dtDate.CalendarFont = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.dtDate.CustomFormat = "yyyy-MM-dd"
        Me.dtDate.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDate.Location = New System.Drawing.Point(766, 20)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(111, 26)
        Me.dtDate.TabIndex = 41
        '
        'btnGenerate
        '
        Me.btnGenerate.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnGenerate.FlatAppearance.BorderSize = 0
        Me.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerate.ForeColor = System.Drawing.Color.White
        Me.btnGenerate.Location = New System.Drawing.Point(893, 15)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(119, 37)
        Me.btnGenerate.TabIndex = 40
        Me.btnGenerate.Text = "GENERATE"
        Me.btnGenerate.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 72)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Attendance of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Students"
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.crv.Location = New System.Drawing.Point(0, 81)
        Me.crv.Name = "crv"
        Me.crv.Size = New System.Drawing.Size(1024, 609)
        Me.crv.TabIndex = 45
        Me.crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'cbFrequency
        '
        Me.cbFrequency.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbFrequency.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFrequency.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.cbFrequency.FormattingEnabled = True
        Me.cbFrequency.ItemHeight = 20
        Me.cbFrequency.Items.AddRange(New Object() {"Daily", "Weekly", "Monthly"})
        Me.cbFrequency.Location = New System.Drawing.Point(374, 19)
        Me.cbFrequency.Name = "cbFrequency"
        Me.cbFrequency.Size = New System.Drawing.Size(86, 28)
        Me.cbFrequency.TabIndex = 46
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(271, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 20)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Frequency *"
        '
        'cbGradeLevel
        '
        Me.cbGradeLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbGradeLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbGradeLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGradeLevel.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.cbGradeLevel.FormattingEnabled = True
        Me.cbGradeLevel.ItemHeight = 20
        Me.cbGradeLevel.Items.AddRange(New Object() {"GRADE 7", "GRADE 8", "GRADE 9", "GRADE 10"})
        Me.cbGradeLevel.Location = New System.Drawing.Point(601, 20)
        Me.cbGradeLevel.Name = "cbGradeLevel"
        Me.cbGradeLevel.Size = New System.Drawing.Size(86, 28)
        Me.cbGradeLevel.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(484, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 20)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Grade Level *"
        '
        'frmReportAttendanceOfStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1024, 690)
        Me.Controls.Add(Me.cbGradeLevel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbFrequency)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.crv)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dtDate)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReportAttendanceOfStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReportAttendanceOfStudentsByDailyWeeklyMonthly"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label12 As Label
    Friend WithEvents dtDate As DateTimePicker
    Friend WithEvents btnGenerate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cbFrequency As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbGradeLevel As ComboBox
    Friend WithEvents Label2 As Label
End Class
