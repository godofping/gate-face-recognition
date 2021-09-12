﻿Imports Emgu.CV
Imports Emgu.CV.Structure

Public Class frmAttendance
    Dim currentFrameEntrance As Image(Of Bgr, [Byte])
    Dim currentFrameExit As Image(Of Bgr, [Byte])
    Dim grabberEntrance As Capture
    Dim grabberExit As Capture
    Dim face As HaarCascade
    Dim resultEntrance As Image(Of Gray, Byte), TrainedFaceEntrance As Image(Of Gray, Byte) = Nothing
    Dim resultExit As Image(Of Gray, Byte), TrainedFaceExit As Image(Of Gray, Byte) = Nothing
    Dim grayEntrance As Image(Of Gray, Byte) = Nothing
    Dim grayExit As Image(Of Gray, Byte) = Nothing
    Dim trainingImages As New List(Of Image(Of Gray, Byte))()
    Dim labels As New List(Of String)()
    Dim ContTrain As Integer
    Dim nameEntrance As String
    Dim nameExit As String
    Dim nameEntranceOld As String
    Dim nameExitOld As String
    Dim studentimage As New StudentImage
    Dim setting As New Setting
    Dim counterEntrance As Integer
    Dim counterExit As Integer
    Dim canScanEntrance As Integer = 1
    Dim canScanExit As Integer = 1
    Dim en As Integer
    Dim ex As Integer
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
        setting = setting.Fetch(setting)

        grabberEntrance = New Capture(setting._Camera_entrance)
        grabberExit = New Capture(setting._Camera_exit)

        grabberEntrance.QueryFrame()
        grabberExit.QueryFrame()


        timerCameraEntrance.Start()
        timerCameraExit.Start()

        timerSMS.Start()
    End Sub

    Private Sub timerCameraEntrance_Tick(sender As Object, e As EventArgs) Handles timerCameraEntrance.Tick
        Try
            lblDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm tt")

            'Get the current frame form capture device
            currentFrameEntrance = grabberEntrance.QueryFrame().Resize(640, 480, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC)

            'Convert it to Grayscale
            grayEntrance = currentFrameEntrance.Convert(Of Gray, [Byte])()

            'Face Detector
            Dim facesDetectedEntrance As MCvAvgComp()() = grayEntrance.DetectHaarCascade(face, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, New Size(20, 20))

            'Action for each element detected
            For Each f As MCvAvgComp In facesDetectedEntrance(0)
                resultEntrance = currentFrameEntrance.Copy(f.rect).Convert(Of Gray, Byte)().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC)
                'draw the face detected in the 0th (gray) channel with blue color
                currentFrameEntrance.Draw(f.rect, New Bgr(Color.Green), 2)


                If trainingImages.ToArray().Length <> 0 Then
                    'TermCriteria for face recognition with numbers of trained images like maxIteration
                    Dim termCrit As New MCvTermCriteria(ContTrain, 0.001)

                    'Eigen face recognizer
                    Dim recognizer As New EigenObjectRecognizer(trainingImages.ToArray(), labels.ToArray(), 5000, termCrit)

                    nameEntrance = recognizer.Recognize(resultEntrance)
                End If

            Next


            If Not nameEntrance Is Nothing Then
                If nameEntrance.Length > 0 Then
                    If Integer.TryParse(nameEntrance, True) And canScanEntrance = 1 Then
                        If nameEntrance.Equals(nameEntranceOld) Then
                            en = en + 1
                            If en = 5 Then
                                Dim currentdatetime As String = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                                Dim student As New Student
                                Dim attendance As New Attendance
                                student._Student_id = CInt(nameEntrance)
                                student = student.Fetch(student)
                                lblStudentEntrance.Text = "ID Number: " & student._Id_number & vbCrLf &
                                    "Student Name: " & student._Last_name & ", " & student._First_name & " " & student._Middle_name & vbCrLf &
                                    "Grade Level: " & student._Grade_level & vbCrLf &
                                    "Time: " & currentdatetime

                                timerStudentInformationEntrance.Start()
                                pnlStudentInformationEntrance.Visible = True


                                Attendance._Attendance_type = "ENTRANCE"
                                Attendance._Attendance_datetime = currentdatetime
                                Attendance._Issent = 0
                                Attendance.Create(Attendance)
                                en = 0
                            End If
                        End If
                        nameEntranceOld = nameEntrance
                    End If

                End If
            End If

            'Show the faces procesed and recognized
            IBEntrance.Image = currentFrameEntrance
            nameEntrance = Nothing
        Catch ex As Exception

        End Try
    End Sub

    Private Sub timerCameraExit_Tick(sender As Object, e As EventArgs) Handles timerCameraExit.Tick
        Try
            lblDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm tt")

            'Get the current frame form capture device
            currentFrameExit = grabberExit.QueryFrame().Resize(640, 480, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC)

            'Convert it to Grayscale
            grayExit = currentFrameExit.Convert(Of Gray, [Byte])()

            'Face Detector
            Dim facesDetectedExit As MCvAvgComp()() = grayExit.DetectHaarCascade(face, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, New Size(20, 20))

            'Action for each element detected
            For Each f As MCvAvgComp In facesDetectedExit(0)
                resultExit = currentFrameExit.Copy(f.rect).Convert(Of Gray, Byte)().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC)
                'draw the face detected in the 0th (gray) channel with blue color
                currentFrameExit.Draw(f.rect, New Bgr(Color.Green), 2)

                If trainingImages.ToArray().Length <> 0 Then
                    'TermCriteria for face recognition with numbers of trained images like maxIteration
                    Dim termCrit As New MCvTermCriteria(ContTrain, 0.001)

                    'Eigen face recognizer
                    Dim recognizer As New EigenObjectRecognizer(trainingImages.ToArray(), labels.ToArray(), 5000, termCrit)

                    nameExit = recognizer.Recognize(resultExit)

                End If

            Next

            If Not nameExit Is Nothing Then
                If nameExit.Length > 0 Then
                    If Integer.TryParse(nameExit, True) And canScanExit = 1 Then
                        If nameExit.Equals(nameExitOld) Then
                            en = en + 1
                            If en = 5 Then
                                Dim currentdatetime As String = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                                Dim attendance As New Attendance
                                attendance._Student_id = CInt(nameExit)
                                Dim student As New Student
                                student._Student_id = CInt(nameExit)
                                student = student.Fetch(student)
                                lblStudentExit.Text = "ID Number: " & student._Id_number & vbCrLf &
                                        "Student Name: " & student._Last_name & ", " & student._First_name & " " & student._Middle_name & vbCrLf &
                                        "Grade Level: " & student._Grade_level & vbCrLf &
                                        "Time: " & currentdatetime

                                timerStudentInformationExit.Start()
                                pnlStudentInformationExit.Visible = True

                                attendance._Attendance_type = "EXIT"
                                attendance._Attendance_datetime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                                attendance._Issent = 0
                                attendance.Create(attendance)
                                en = 0
                            End If
                        End If
                        nameExitOld = nameExit
                    End If
                End If
            End If

            'Show the faces procesed and recognized
            IBExit.Image = currentFrameExit
            nameExit = Nothing
        Catch ex As Exception

        End Try
    End Sub

    Private Sub timerSMS_Tick(sender As Object, e As EventArgs) Handles timerSMS.Tick
        Dim smsThread = New System.Threading.Thread(AddressOf SendSMS)
        smsThread.Start()
    End Sub

    Private Sub timerStudentInformationEntrance_Tick(sender As Object, e As EventArgs) Handles timerStudentInformationEntrance.Tick
        Try
            counterEntrance = counterEntrance + 1
            canScanEntrance = 0

            If counterEntrance = 5 Then
                pnlStudentInformationEntrance.Visible = False
                timerStudentInformationEntrance.Stop()
                counterEntrance = 0
                canScanEntrance = 1
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub timerStudentInformationExit_Tick(sender As Object, e As EventArgs) Handles timerStudentInformationExit.Tick
        Try
            counterExit = counterExit + 1
            canScanExit = 0

            If counterExit = 5 Then
                pnlStudentInformationExit.Visible = False
                timerStudentInformationExit.Stop()
                counterExit = 0
                canScanExit = 1
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub IBExit_Click(sender As Object, e As EventArgs) Handles IBExit.Click

    End Sub

    Private Sub frmAttendance_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        grabberEntrance.Dispose()
        grabberExit.Dispose()
    End Sub

    Private Sub frmAttendance_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.F12) Then
            frmLogin.Show()
            grabberEntrance.Dispose()
            grabberExit.Dispose()
            Me.Close()
        End If
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
