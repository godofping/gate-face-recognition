Public Class frmSettingsAttendanceType

    Dim setting As New Setting

    Private Sub frmSettingsAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setting = setting.Fetch
        cbAttendanceType.Text = setting._Attendance_type
    End Sub

    Sub showResult(ByVal bol As Boolean)
        If bol Then
            MsgBox("Success")
        Else
            MsgBox("Failed")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        setting._Attendance_type = cbAttendanceType.Text
        showResult(setting.Update(setting))
    End Sub


End Class