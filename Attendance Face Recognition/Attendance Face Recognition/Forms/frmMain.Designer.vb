﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnStudents = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnAdmins = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnAttendanceHistory = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnStudentList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(0, 30)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1024, 690)
        Me.pnlMain.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnStudents, Me.mnAdmins, Me.mnReports, Me.mnLogout})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1024, 30)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnStudents
        '
        Me.mnStudents.Name = "mnStudents"
        Me.mnStudents.Size = New System.Drawing.Size(101, 26)
        Me.mnStudents.Text = "Students"
        '
        'mnAdmins
        '
        Me.mnAdmins.Name = "mnAdmins"
        Me.mnAdmins.Size = New System.Drawing.Size(89, 26)
        Me.mnAdmins.Text = "Admins"
        '
        'mnReports
        '
        Me.mnReports.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnAttendanceHistory, Me.mnStudentList})
        Me.mnReports.Name = "mnReports"
        Me.mnReports.Size = New System.Drawing.Size(91, 26)
        Me.mnReports.Text = "Reports"
        '
        'mnAttendanceHistory
        '
        Me.mnAttendanceHistory.Name = "mnAttendanceHistory"
        Me.mnAttendanceHistory.Size = New System.Drawing.Size(522, 26)
        Me.mnAttendanceHistory.Text = "Attendance of Students (daily, weekly, monthly)"
        Me.mnAttendanceHistory.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'mnStudentList
        '
        Me.mnStudentList.Name = "mnStudentList"
        Me.mnStudentList.Size = New System.Drawing.Size(522, 26)
        Me.mnStudentList.Text = "Attendance of Students (grade level)"
        '
        'mnLogout
        '
        Me.mnLogout.Name = "mnLogout"
        Me.mnLogout.Size = New System.Drawing.Size(87, 26)
        Me.mnLogout.Text = "Logout"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1024, 720)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMain"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlMain As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnStudents As ToolStripMenuItem
    Friend WithEvents mnAdmins As ToolStripMenuItem
    Friend WithEvents mnReports As ToolStripMenuItem
    Friend WithEvents mnAttendanceHistory As ToolStripMenuItem
    Friend WithEvents mnStudentList As ToolStripMenuItem
    Friend WithEvents mnLogout As ToolStripMenuItem
End Class