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
    Dim attendance As New Attendance
    Dim setting As New Setting

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
        lblDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm tt")

        'Get the current frame form capture device
        currentFrameEntrance = grabberEntrance.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC)

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
                Dim recognizer As New EigenObjectRecognizer(trainingImages.ToArray(), labels.ToArray(), 3000, termCrit)

                nameEntrance = recognizer.Recognize(resultEntrance)
                Console.WriteLine("Entrance: " & nameEntrance)

            End If

        Next


        If Not nameEntrance Is Nothing Then
            If Integer.TryParse(nameEntrance, True) Then

                attendance._Student_id = CInt(nameEntrance)
                If attendance.FetchByStudentID(attendance).Rows.Count = 0 Then
                    attendance._Attendance_type = "ENTRANCE"
                    attendance._Attendance_datetime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                    attendance._Issent = 0
                    attendance.Create(attendance)
                Else
                    If attendance.FetchByStudentID(attendance).Rows(0)("attendance_type").Equals("ENTRANCE") Then
                        attendance._Attendance_type = "EXIT"
                        attendance._Attendance_datetime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                        attendance._Issent = 0
                        attendance.Create(attendance)
                    ElseIf attendance.FetchByStudentID(attendance).Rows(0)("attendance_type").Equals("EXIT") Then
                        attendance._Attendance_type = "ENTRANCE"
                        attendance._Attendance_datetime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                        attendance._Issent = 0
                        attendance.Create(attendance)
                    End If
                End If

            End If
        End If

        'Show the faces procesed and recognized
        IBEntrance.Image = currentFrameEntrance
    End Sub

    Private Sub timerCameraExit_Tick(sender As Object, e As EventArgs) Handles timerCameraExit.Tick
        lblDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm tt")

        'Get the current frame form capture device
        currentFrameExit = grabberExit.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC)

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
                Dim recognizer As New EigenObjectRecognizer(trainingImages.ToArray(), labels.ToArray(), 3000, termCrit)

                nameExit = recognizer.Recognize(resultExit)
                Console.WriteLine("Exit: " & nameExit)

            End If

        Next


        If Not nameExit Is Nothing Then
            If Integer.TryParse(nameExit, True) Then

                attendance._Student_id = CInt(nameExit)
                If attendance.FetchByStudentID(attendance).Rows.Count = 0 Then
                    attendance._Attendance_type = "ENTRANCE"
                    attendance._Attendance_datetime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                    attendance._Issent = 0
                    attendance.Create(attendance)
                Else
                    If attendance.FetchByStudentID(attendance).Rows(0)("attendance_type").Equals("ENTRANCE") Then
                        attendance._Attendance_type = "EXIT"
                        attendance._Attendance_datetime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                        attendance._Issent = 0
                        attendance.Create(attendance)
                    ElseIf attendance.FetchByStudentID(attendance).Rows(0)("attendance_type").Equals("EXIT") Then
                        attendance._Attendance_type = "ENTRANCE"
                        attendance._Attendance_datetime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                        attendance._Issent = 0
                        attendance.Create(attendance)
                    End If
                End If

            End If
        End If

        'Show the faces procesed and recognized
        IBExit.Image = currentFrameExit
    End Sub

    Private Sub frmAttendance_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.F12) Then
            frmLogin.Show()
            grabberEntrance.Dispose()
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
