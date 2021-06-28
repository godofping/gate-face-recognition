Imports Emgu.CV
Imports Emgu.CV.Structure

Public Class frmAttendance
    Dim currentFrame As Image(Of Bgr, [Byte])
    Dim grabber As Capture
    Dim face As HaarCascade
    Dim font As New MCvFont(CvEnum.FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5, 0.5)
    Dim result As Image(Of Gray, Byte), TrainedFace As Image(Of Gray, Byte) = Nothing
    Dim gray As Image(Of Gray, Byte) = Nothing
    Dim trainingImages As New List(Of Image(Of Gray, Byte))()
    Dim labels As New List(Of String)()
    Dim NamePersons As New List(Of String)()
    Dim ContTrain As Integer
    Dim name As String, names As String = Nothing
    Dim studentimage As New StudentImage
    Dim time As Integer = 0
    Dim oldlabel As String


    Dim attendance As New Attendance


    Private Sub frmAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grabber = New Capture(0)
        grabber.QueryFrame()
        timerCameraEntrance.Start()
    End Sub

    Private Sub frmAttendance_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.F12) Then
            frmLogin.Show()
            grabber.Dispose()
            Me.Close()
        End If
    End Sub

    Public Sub New()
        InitializeComponent()
        'Load haarcascades for face detection
        face = New HaarCascade("haarcascade_frontalface_default.xml")
        Try
            For Each row As DataRow In studentimage.FetchAll.Rows
                trainingImages.Add(New Image(Of Gray, Byte)(CStr(row("image_location"))))
                labels.Add(CStr(row("student_id")))
            Next row
        Catch e As Exception
            MsgBox("NO IMAGE IN DATABASE")
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerCameraEntrance.Tick
        lblDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm tt")

        'Get the current frame form capture device
        currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC)

        'Convert it to Grayscale
        gray = currentFrame.Convert(Of Gray, [Byte])()

        'Face Detector
        Dim facesDetected As MCvAvgComp()() = gray.DetectHaarCascade(face, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, New Size(20, 20))

        'Action for each element detected
        For Each f As MCvAvgComp In facesDetected(0)
            result = currentFrame.Copy(f.rect).Convert(Of Gray, Byte)().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC)
            'draw the face detected in the 0th (gray) channel with blue color
            currentFrame.Draw(f.rect, New Bgr(Color.Green), 2)


            If trainingImages.ToArray().Length <> 0 Then
                'TermCriteria for face recognition with numbers of trained images like maxIteration
                Dim termCrit As New MCvTermCriteria(ContTrain, 0.001)

                'Eigen face recognizer
                Dim recognizer As New EigenObjectRecognizer(trainingImages.ToArray(), labels.ToArray(), 3000, termCrit)

                name = recognizer.Recognize(result)


            End If

        Next


        If Not name Is Nothing Then
            If Integer.TryParse(name, True) Then
                timerCameraEntrance.Stop()

                attendance._Student_id = CInt(name)
                If attendance.FetchByStudentID(attendance).Rows.Count = 0 Then

                    attendance._Attendance_type = "ENTRANCE"
                    attendance._Attendance_datetime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                    attendance._Issent = 0
                    attendance.Create(attendance)

                Else
                    If attendance.FetchByStudentID(attendance).Rows(0)("attendance_type").Equals("ENTRANCE") Then

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
        IBEntrance.Image = currentFrame

        timerCameraEntrance.Start()
    End Sub


End Class
