Imports System
Imports System.Globalization
Imports System.Threading

Public Class frmReportAttendanceOfStudent

    Dim cr As New crAttendanceOfStudents
    Dim crmix As New crAttendanceOfStudentsMix
    Dim date_from As String
    Dim date_to As String
    Dim title As String
    Dim date_span As String
    Dim attendance_type As String

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        If Helper.CheckRequiredCB(cbFrequency, cbGradeLevel, cbAttendanceType) And Helper.CheckRequiredDTP(dtDate) Then
            crv.ReportSource = Nothing

            If cbFrequency.Text.Equals("Daily") Then
                date_from = dtDate.Text
                date_to = dtDate.Text
                title = "Daily Report"
                date_span = "(" & dtDate.Text & ")"
            ElseIf cbFrequency.Text.Equals("Weekly") Then

                Dim fdw As DateTime = DateTime.Parse(dtDate.Text).AddDays(-Weekday(DateTime.Parse(dtDate.Text), FirstDayOfWeek.Sunday) + 1)
                Dim ldw As DateTime = fdw.AddDays(6)

                date_from = fdw.ToString("yyyy-MM-dd")
                date_to = ldw.ToString("yyyy-MM-dd")
                title = "Weekly Report"
                date_span = "(" & date_from & " to " & date_to & ")"

            ElseIf cbFrequency.Text.Equals("Monthly") Then
                Dim fdw As DateTime = New DateTime(DateTime.Parse(dtDate.Text).Year, DateTime.Parse(dtDate.Text).Month, 1)
                Dim ldw As DateTime = fdw.AddMonths(1).AddDays(-1)

                date_from = fdw.ToString("yyyy-MM-dd")
                date_to = ldw.ToString("yyyy-MM-dd")
                title = "Monthly Report"
                date_span = "(" & date_from & " to " & date_to & ")"
            End If

            If Not cbAttendanceType.Text.Equals("MIX") Then
                cr.SetParameterValue("title", title)
                cr.SetParameterValue("date_from", date_from)
                cr.SetParameterValue("date_to", date_to)
                cr.SetParameterValue("grade_level", cbGradeLevel.Text)
                cr.SetParameterValue("attendance_type", cbAttendanceType.Text)
                cr.SetParameterValue("date_span", date_span)
                crv.ReportSource = cr
                cr.SetDatabaseLogon("sa", "123456")
            Else
                crmix.SetParameterValue("title", title)
                crmix.SetParameterValue("date_from", date_from)
                crmix.SetParameterValue("date_to", date_to)
                crmix.SetParameterValue("grade_level", cbGradeLevel.Text)
                crmix.SetParameterValue("attendance_type", cbAttendanceType.Text)
                crmix.SetParameterValue("date_span", date_span)
                crv.ReportSource = crmix
                crmix.SetDatabaseLogon("sa", "123456")
            End If



            crv.Refresh()
        Else
            MsgBox("Please fill up all the required fields denote by an asterisk *")
        End If

    End Sub
End Class