Public Class frmLogin

    Dim setting As New Setting

    Dim admin As New Admin

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Private Sub SendSMS()
        Dim attendance_unsent As New Attendance
        Dim student As New Student
        Dim dt As DataTable = attendance_unsent.FetchByUnsentSMS()

        If dt.Rows.Count > 0 Then

            Dim msg As String = "Error"

            attendance_unsent._Attendance_id = Convert.ToInt32(dt.Rows(0)("attendance_id"))
            attendance_unsent = attendance_unsent.Fetch(attendance_unsent)

            student._Student_id = attendance_unsent._Student_id
            student = student.Fetch(student)

            If attendance_unsent._Attendance_type.Equals("ENTRANCE") Then
                msg = student._Last_name & ", " & student._First_name & " " & student._Middle_name & " has entered the school at " & attendance_unsent._Attendance_datetime & " . Message from SKSU Face Attendance SMS Terminal"
            ElseIf attendance_unsent._Attendance_type.Equals("EXIT") Then
                msg = student._Last_name & ", " & student._First_name & " " & student._Middle_name & " has exited the school at " & attendance_unsent._Attendance_datetime & " . Message from SKSU Face Attendance SMS Terminal"
            End If


            If Helper.SendSMS(setting._Broadband_com, student._Contact_person_phone_number, msg) Then
                attendance_unsent._Issent = 1
                attendance_unsent.Update(attendance_unsent)
            End If

        End If
    End Sub

    Public Sub clearForm()
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtUsername.Select()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        admin._Username = txtUsername.Text
        admin._Password = txtPassword.Text

        Dim dt As DataTable = admin.Login(admin)

        If dt.Rows.Count > 0 Then
            Me.Hide()
            Call New frmMain(admin).ShowDialog()
        Else
            MsgBox("Login Failed")
        End If

    End Sub

    Private Sub frmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.F9) Then
            frmAttendance.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub timerSMS_Tick(sender As Object, e As EventArgs) Handles timerSMS.Tick
        Dim smsThread = New System.Threading.Thread(AddressOf SendSMS)
        smsThread.Start()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setting = setting.Fetch(setting)
        timerSMS.Start()
    End Sub
End Class