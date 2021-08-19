Imports Emgu.CV
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
    Dim studentimage As New StudentImage
    Dim setting As New Setting
    Dim counterEntrance As Integer
    Dim counterExit As Integer
    Dim canScanEntrance As Integer = 1
    Dim canScanExit As Integer = 1


    Private Sub frmAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setting = setting.Fetch(setting)
        grabberEntrance = New Capture(setting._Camera_entrance)
        grabberEntrance.QueryFrame()
        timerCameraEntrance.Start()
        grabberExit = New Capture(setting._Camera_exit)
        grabberExit.QueryFrame()
        timerCameraExit.Start()

    End Sub

    Private Sub timerCameraEntrance_Tick(sender As Object, e As EventArgs) Handles timerCameraEntrance.Tick
        Try
            lblDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm tt")

            'Get the current frame form capture device
            currentFrameEntrance = grabberEntrance.QueryFrame().Resize(160, 120, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC)

            'Convert it to Grayscale
            grayEntrance = currentFrameEntrance.Convert(Of Gray, [Byte])()

            'Face Detector
            Dim facesDetectedEntrance As MCvAvgComp()() = grayEntrance.DetectHaarCascade(face, 1.1, 3, 0, New Size(100, 100))

            'Action for each element detected
            For Each f As MCvAvgComp In facesDetectedEntrance(0)
                resultEntrance = currentFrameEntrance.Copy(f.rect).Convert(Of Gray, Byte)().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC)
                'draw the face detected in the 0th (gray) channel with blue color
                currentFrameEntrance.Draw(f.rect, New Bgr(Color.Green), 2)


                If trainingImages.ToArray().Length <> 0 Then
                    'TermCriteria for face recognition with numbers of trained images like maxIteration
                    Dim termCrit As New MCvTermCriteria(ContTrain, 0.001)

                    'Eigen face recognizer
                    Dim recognizer As New EigenObjectRecognizer(trainingImages.ToArray(), labels.ToArray(), 3000, termCrit)

                    nameEntrance = recognizer.Recognize(resultEntrance)

                End If

            Next


            If Not nameEntrance Is Nothing Then
                If nameEntrance.Length > 0 Then
                    If Integer.TryParse(nameEntrance, True) And canScanEntrance = 1 Then
                        Dim currentdatetime As String = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                        Dim attendance As New Attendance
                        attendance._Student_id = CInt(nameEntrance)
                        If attendance.FetchByStudentID(attendance).Rows.Count = 0 Then

                            Dim student As New Student
                            student._Student_id = CInt(nameEntrance)
                            student = student.Fetch(student)
                            lblStudentEntrance.Text = "ID Number: " & student._Id_number & vbCrLf &
                                "Student Name: " & student._Last_name & ", " & student._First_name & " " & student._Middle_name & vbCrLf &
                                "Grade Level: " & student._Grade_level & vbCrLf &
                                "Time: " & currentdatetime

                            timerStudentInformationEntrance.Start()
                            pnlStudentInformationEntrance.Visible = True

                            attendance._Attendance_type = "ENTRANCE"
                            attendance._Attendance_datetime = currentdatetime
                            attendance._Issent = 0
                            attendance.Create(attendance)
                        Else
                            If attendance.FetchByStudentID(attendance).Rows(0)("attendance_type").Equals("EXIT") Then
                                Dim student As New Student
                                student._Student_id = CInt(nameEntrance)
                                student = student.Fetch(student)
                                lblStudentEntrance.Text = "ID Number: " & student._Id_number & vbCrLf &
                                "Student Name: " & student._Last_name & ", " & student._First_name & " " & student._Middle_name & vbCrLf &
                                "Grade Level: " & student._Grade_level & vbCrLf &
                                "Time: " & currentdatetime

                                timerStudentInformationEntrance.Start()
                                pnlStudentInformationEntrance.Visible = True

                                attendance._Attendance_type = "ENTRANCE"
                                attendance._Attendance_datetime = currentdatetime
                                attendance._Issent = 0
                                attendance.Create(attendance)
                            End If
                        End If
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
            currentFrameExit = grabberExit.QueryFrame().Resize(160, 120, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC)

            'Convert it to Grayscale
            grayExit = currentFrameExit.Convert(Of Gray, [Byte])()

            'Face Detector
            Dim facesDetectedExit As MCvAvgComp()() = grayExit.DetectHaarCascade(face, 1.1, 3, 0, New Size(100, 100))

            'Action for each element detected
            For Each f As MCvAvgComp In facesDetectedExit(0)
                resultExit = currentFrameExit.Copy(f.rect).Convert(Of Gray, Byte)().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC)
                'draw the face detected in the 0th (gray) channel with blue color
                currentFrameExit.Draw(f.rect, New Bgr(Color.Green), 2)

                If trainingImages.ToArray().Length <> 0 Then
                    'TermCriteria for face recognition with numbers of trained images like maxIteration
                    Dim termCrit As New MCvTermCriteria(ContTrain, 0.001)

                    'Eigen face recognizer
                    Dim recognizer As New EigenObjectRecognizer(trainingImages.ToArray(), labels.ToArray(), 3000, termCrit)

                    nameExit = recognizer.Recognize(resultExit)
                End If

            Next

            If Not nameExit Is Nothing Then
                If nameExit.Length > 0 Then
                    If Integer.TryParse(nameExit, True) And canScanExit = 1 Then
                        Dim currentdatetime As String = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                        Dim attendance As New Attendance
                        attendance._Student_id = CInt(nameExit)
                        If attendance.FetchByStudentID(attendance).Rows(0)("attendance_type").Equals("ENTRANCE") Then
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
                        End If
                    End If
                End If
            End If

            'Show the faces procesed and recognized
            IBExit.Image = currentFrameExit
            nameExit = Nothing
        Catch ex As Exception

        End Try
    End Sub



    Private Sub timerStudentInformationEntrance_Tick(sender As Object, e As EventArgs) Handles timerStudentInformationEntrance.Tick
        Try
            counterEntrance = counterEntrance + 1
            canScanEntrance = 0
            timerCameraEntrance.Stop()

            If counterEntrance = 4 Then
                pnlStudentInformationEntrance.Visible = False
                timerStudentInformationEntrance.Stop()
                counterEntrance = 0
                canScanEntrance = 1
                timerCameraEntrance.Start()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub timerStudentInformationExit_Tick(sender As Object, e As EventArgs) Handles timerStudentInformationExit.Tick
        Try
            counterExit = counterExit + 1
            canScanExit = 0
            timerCameraExit.Stop()

            If counterExit = 4 Then
                pnlStudentInformationExit.Visible = False
                timerStudentInformationExit.Stop()
                counterExit = 0
                canScanExit = 1
                timerCameraExit.Start()
            End If
        Catch ex As Exception

        End Try
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
