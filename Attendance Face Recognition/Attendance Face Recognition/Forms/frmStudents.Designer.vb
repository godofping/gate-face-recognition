<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudents
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
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.txtIDNumber = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtContactPersonPhoneNumber = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtContactPersonFullName = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbGradeLevel = New System.Windows.Forms.ComboBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtStudentID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbForm = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbForm.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeColumns = False
        Me.dgv.AllowUserToResizeRows = False
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle17
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle19
        Me.dgv.EnableHeadersVisualStyles = False
        Me.dgv.Location = New System.Drawing.Point(12, 252)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.White
        Me.dgv.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(1000, 427)
        Me.dgv.TabIndex = 31
        '
        'txtIDNumber
        '
        Me.txtIDNumber.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDNumber.Location = New System.Drawing.Point(140, 58)
        Me.txtIDNumber.Name = "txtIDNumber"
        Me.txtIDNumber.Size = New System.Drawing.Size(168, 26)
        Me.txtIDNumber.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(19, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 20)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "ID # *"
        '
        'txtContactPersonPhoneNumber
        '
        Me.txtContactPersonPhoneNumber.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactPersonPhoneNumber.Location = New System.Drawing.Point(803, 55)
        Me.txtContactPersonPhoneNumber.Name = "txtContactPersonPhoneNumber"
        Me.txtContactPersonPhoneNumber.Size = New System.Drawing.Size(168, 26)
        Me.txtContactPersonPhoneNumber.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(647, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(148, 20)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Contact Person # *"
        '
        'txtContactPersonFullName
        '
        Me.txtContactPersonFullName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactPersonFullName.Location = New System.Drawing.Point(803, 20)
        Me.txtContactPersonFullName.Name = "txtContactPersonFullName"
        Me.txtContactPersonFullName.Size = New System.Drawing.Size(168, 26)
        Me.txtContactPersonFullName.TabIndex = 8
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(762, 12)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(122, 37)
        Me.btnSave.TabIndex = 39
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(634, 12)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(122, 37)
        Me.btnDelete.TabIndex = 38
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnUpdate.FlatAppearance.BorderSize = 0
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(506, 12)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(122, 37)
        Me.btnUpdate.TabIndex = 37
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(378, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(122, 37)
        Me.btnAdd.TabIndex = 36
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.txtSearch.Location = New System.Drawing.Point(76, 220)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(327, 26)
        Me.txtSearch.TabIndex = 35
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(647, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 20)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Contact Person *"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddleName.Location = New System.Drawing.Point(452, 91)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(168, 26)
        Me.txtMiddleName.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(331, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Middle Name *"
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(452, 55)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(168, 26)
        Me.txtFirstName.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(331, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "First Name *"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(890, 12)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(122, 37)
        Me.btnCancel.TabIndex = 40
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 18)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Search"
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
        Me.cbGradeLevel.Location = New System.Drawing.Point(140, 93)
        Me.cbGradeLevel.Name = "cbGradeLevel"
        Me.cbGradeLevel.Size = New System.Drawing.Size(168, 28)
        Me.cbGradeLevel.TabIndex = 2
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(452, 20)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(168, 26)
        Me.txtLastName.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(331, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Last Name *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Grade Level *"
        '
        'txtStudentID
        '
        Me.txtStudentID.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentID.Location = New System.Drawing.Point(140, 23)
        Me.txtStudentID.Name = "txtStudentID"
        Me.txtStudentID.ReadOnly = True
        Me.txtStudentID.Size = New System.Drawing.Size(69, 26)
        Me.txtStudentID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 36)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Students"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "#"
        '
        'gbForm
        '
        Me.gbForm.Controls.Add(Me.Button1)
        Me.gbForm.Controls.Add(Me.txtIDNumber)
        Me.gbForm.Controls.Add(Me.Label12)
        Me.gbForm.Controls.Add(Me.txtContactPersonPhoneNumber)
        Me.gbForm.Controls.Add(Me.Label10)
        Me.gbForm.Controls.Add(Me.txtContactPersonFullName)
        Me.gbForm.Controls.Add(Me.Label9)
        Me.gbForm.Controls.Add(Me.txtMiddleName)
        Me.gbForm.Controls.Add(Me.Label8)
        Me.gbForm.Controls.Add(Me.txtFirstName)
        Me.gbForm.Controls.Add(Me.Label7)
        Me.gbForm.Controls.Add(Me.cbGradeLevel)
        Me.gbForm.Controls.Add(Me.txtLastName)
        Me.gbForm.Controls.Add(Me.Label5)
        Me.gbForm.Controls.Add(Me.Label4)
        Me.gbForm.Controls.Add(Me.txtStudentID)
        Me.gbForm.Controls.Add(Me.Label3)
        Me.gbForm.Location = New System.Drawing.Point(12, 56)
        Me.gbForm.Name = "gbForm"
        Me.gbForm.Size = New System.Drawing.Size(1000, 144)
        Me.gbForm.TabIndex = 32
        Me.gbForm.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(651, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(320, 37)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "TAKE PICTURE FOR FACE RECOGNITION"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1024, 690)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbForm)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStudents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Students"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbForm.ResumeLayout(False)
        Me.gbForm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents txtIDNumber As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtContactPersonPhoneNumber As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtContactPersonFullName As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cbGradeLevel As ComboBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtStudentID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents gbForm As GroupBox
    Friend WithEvents Button1 As Button
End Class
