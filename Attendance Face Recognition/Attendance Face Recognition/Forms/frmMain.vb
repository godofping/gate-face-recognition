Public Class frmMain

    Public admin As New Admin

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Public Sub New(ByVal _admin As Admin)
        InitializeComponent()
        admin = _admin
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Helper.ChangePanelDisplay(frmStudents, pnlMain)
    End Sub

    Private Sub mnLogout_Click(sender As Object, e As EventArgs) Handles mnLogout.Click
        Dim ask As MsgBoxResult = MsgBox("Are you sure to logout?", MsgBoxStyle.YesNo)
        If ask = MsgBoxResult.Yes Then
            frmLogin.Show()
            frmLogin.clearForm()
            Me.Close()
        End If
    End Sub

    Private Sub mnStudents_Click(sender As Object, e As EventArgs) Handles mnStudents.Click
        Helper.ChangePanelDisplay(frmStudents, pnlMain)
    End Sub

    Private Sub mnAdmins_Click(sender As Object, e As EventArgs) Handles mnAdmins.Click
        Helper.ChangePanelDisplay(frmAdmins, pnlMain)
    End Sub


    Private Sub mnAttendanceOfStudents_Click(sender As Object, e As EventArgs) Handles mnAttendanceOfStudents.Click
        Helper.ChangePanelDisplay(frmReportAttendanceOfStudent, pnlMain)
    End Sub

    Private Sub CameraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CameraToolStripMenuItem.Click
        Helper.ChangePanelDisplay(frmSettingsCamera, pnlMain)
    End Sub

    Private Sub GSMModuleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GSMModuleToolStripMenuItem.Click
        Helper.ChangePanelDisplay(frmSettingsGSMModule, pnlMain)
    End Sub

    Private Sub PromosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PromosToolStripMenuItem.Click
        Helper.ChangePanelDisplay(frmSettingsPromos, pnlMain)
    End Sub

    Private Sub AttendanceTypeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttendanceTypeToolStripMenuItem.Click
        Helper.ChangePanelDisplay(frmSettingsAttendanceType, pnlMain)
    End Sub
End Class