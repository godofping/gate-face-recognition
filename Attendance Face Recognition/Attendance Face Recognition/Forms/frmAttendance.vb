Imports Emgu.CV
Imports Emgu.CV.Structure

Public Class frmAttendance
    Dim currentFrame As Image(Of Bgr, [Byte])

    Dim grabber As Capture

    Dim face As HaarCascade
    Dim result As Image(Of Gray, Byte), TrainedFace As Image(Of Gray, Byte) = Nothing

    Dim gray As Image(Of Gray, Byte) = Nothing

    Dim trainingImages As New List(Of Image(Of Gray, Byte))()
    Dim labels As New List(Of String)()
    Dim ContTrain As Integer
    Dim name As String

    Dim nameOld As String

    Dim studentimage As New StudentImage
    Dim setting As New Setting
    Dim counter As Integer

    Dim canScan As Integer = 1

    Dim en As Integer

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
                msg = student._Last_name & ", " & student._First_name & " " & student._Middle_name & " has entered the school at " & attendance_unsent._Attendance_datetime & " . Message from NDL Face Attendance SMS Terminal"
            ElseIf attendance_unsent._Attendance_type.Equals("EXIT") Then
                msg = student._Last_name & ", " & student._First_name & " " & student._Middle_name & " has exited the school at " & attendance_unsent._Attendance_datetime & " . Message from NDL Face Attendance SMS Terminal"
            End If


            If Helper.SendSMS(setting._Broadband_com, student._Contact_person_phone_number, msg) Then
                attendance_unsent._Issent = 1
                attendance_unsent.Update(attendance_unsent)
            End If

        End If
    End Sub

    Private Sub frmAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setting = setting.Fetch()
        lblAttendanceType.Text = setting._Attendance_type

        grabber = New Capture(setting._Camera_number)
        grabber.QueryFrame()

        timerCamera.Start()
        timerSetting.Start()
        timerSMS.Start()
    End Sub


    Private Sub timerSMS_Tick(sender As Object, e As EventArgs) Handles timerSMS.Tick
        Dim smsThread = New System.Threading.Thread(AddressOf SendSMS)
        smsThread.Start()
    End Sub


    Private Sub frmAttendance_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        grabber.Dispose()
    End Sub

    Private Sub frmAttendance_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.F12) Then
            frmLogin.Show()
            grabber.Dispose()
            Me.Close()
        End If
    End Sub

    Private Sub timerCamera_Tick(sender As Object, e As EventArgs) Handles timerCamera.Tick
        Try
            lblDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm tt")

            'Get the current frame form capture device
            currentFrame = grabber.QueryFrame().Resize(640, 480, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC)

            'Convert it to Grayscale
            gray = currentFrame.Convert(Of Gray, [Byte])()

            'Face Detector
            Dim facesDetectedEntrance As MCvAvgComp()() = gray.DetectHaarCascade(face, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, New Size(20, 20))

            'Action for each element detected
            For Each f As MCvAvgComp In facesDetectedEntrance(0)
                result = currentFrame.Copy(f.rect).Convert(Of Gray, Byte)().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC)
                'draw the face detected in the 0th (gray) channel with blue color
                currentFrame.Draw(f.rect, New Bgr(Color.Green), 2)


                If trainingImages.ToArray().Length <> 0 Then
                    'TermCriteria for face recognition with numbers of trained images like maxIteration
                    Dim termCrit As New MCvTermCriteria(ContTrain, 0.001)

                    'Eigen face recognizer
                    Dim recognizer As New EigenObjectRecognizer(trainingImages.ToArray(), labels.ToArray(), 5000, termCrit)

                    name = recognizer.Recognize(result)
                End If

            Next


            If Not name Is Nothing Then
                If name.Length > 0 Then
                    If Integer.TryParse(name, True) And canScan = 1 Then
                        If name.Equals(nameOld) Then
                            en = en + 1
                            If en = 5 Then
                                Dim currentdatetime As String = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                                Dim student As New Student
                                Dim attendance As New Attendance
                                student._Student_id = CInt(name)
                                student = student.Fetch(student)

                                attendance._Student_id = student._Student_id
                                attendance._Attendance_type = setting._Attendance_type
                                attendance._Attendance_datetime = currentdatetime
                                attendance._Issent = 0

                                Dim timeNow As String = Now.ToString("HH:mm:ss")
                                If timeNow >= "06:00:00" And timeNow <= "12:00:00" Then
                                    If attendance.FetchByTypeAndTime(attendance, DateTime.Now.ToString("yyyy-MM-dd") & " 06:00:00.000", DateTime.Now.ToString("yyyy-MM-dd") & " 12:00:00.000").Rows.Count = 0 Then
                                        timerStudentInformation.Start()
                                        pnlStudentInformation.Visible = True
                                        lblStudent.Text = "ID Number: " & student._Id_number & vbCrLf &
                                                "Student Name: " & student._Last_name & ", " & student._First_name & " " & student._Middle_name & vbCrLf &
                                                "Grade Level: " & student._Grade_level & vbCrLf &
                                                "Time: " & currentdatetime
                                        attendance.Create(attendance)
                                    End If
                                End If

                                If timeNow >= "12:00:01" And timeNow <= "17:00:00" Then
                                    If attendance.FetchByTypeAndTime(attendance, DateTime.Now.ToString("yyyy-MM-dd") & " 12:00:01.000", DateTime.Now.ToString("yyyy-MM-dd") & " 17:00:00.000").Rows.Count = 0 Then
                                        timerStudentInformation.Start()
                                        pnlStudentInformation.Visible = True
                                        lblStudent.Text = "ID Number: " & student._Id_number & vbCrLf &
                                                "Student Name: " & student._Last_name & ", " & student._First_name & " " & student._Middle_name & vbCrLf &
                                                "Grade Level: " & student._Grade_level & vbCrLf &
                                                "Time: " & currentdatetime
                                        attendance.Create(attendance)
                                    End If
                                End If

                                en = 0
                            End If
                        End If
                        nameOld = name
                    End If

                End If
            End If

            'Show the faces procesed and recognized
            IBCamera.Image = currentFrame
            name = Nothing
        Catch ex As Exception

        End Try
    End Sub

    Private Sub timerStudentInformation_Tick(sender As Object, e As EventArgs) Handles timerStudentInformation.Tick
        Try
            counter = counter + 1
            canScan = 0

            If counter = 5 Then
                pnlStudentInformation.Visible = False
                timerStudentInformation.Stop()
                counter = 0
                canScan = 1
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub timerSetting_Tick(sender As Object, e As EventArgs) Handles timerSetting.Tick
        setting = setting.Fetch
        lblAttendanceType.Text = setting._Attendance_type
    End Sub

    Public Sub New()
        InitializeComponent()
        'Load haarcascades for face detection
        face = New HaarCascade("haarcascade_frontalface_default.xml")
        Try
            ContTrain = studentimage.FetchAll.Rows.Count
            For Each row As DataRow In studentimage.FetchAll.Rows
                trainingImages.Add(New Image(Of Gray, Byte)(CStr(row("image_location"))))
                labels.Add(CStr(row("student_id")))
            Next row
        Catch e As Exception
            MsgBox("No image in the database")
        End Try
    End Sub



End Class
