Imports System.Diagnostics
Imports Emgu.CV.Structure
Imports Emgu.CV
Imports Emgu.CV.CvEnum
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO

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
    Dim ContTrain As Integer, NumLabels As Integer, t As Integer
    Dim name As String, names As String = Nothing
    Dim studentimage As New StudentImage

    Private Sub frmAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grabber = New Capture(0)
        grabber.QueryFrame()
        Timer1.Start()
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

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        label3.Text = "0"

        NamePersons.Add("")


        'Get the current frame form capture device
        currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC)

        'Convert it to Grayscale
        gray = currentFrame.Convert(Of Gray, [Byte])()

        'Face Detector
        Dim facesDetected As MCvAvgComp()() = gray.DetectHaarCascade(face, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, New Size(20, 20))

        'Action for each element detected
        For Each f As MCvAvgComp In facesDetected(0)
            t = t + 1
            result = currentFrame.Copy(f.rect).Convert(Of Gray, Byte)().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC)
            'draw the face detected in the 0th (gray) channel with blue color
            currentFrame.Draw(f.rect, New Bgr(Color.Red), 2)


            If trainingImages.ToArray().Length <> 0 Then
                'TermCriteria for face recognition with numbers of trained images like maxIteration
                Dim termCrit As New MCvTermCriteria(ContTrain, 0.001)

                'Eigen face recognizer
                Dim recognizer As New EigenObjectRecognizer(trainingImages.ToArray(), labels.ToArray(), 3000, termCrit)

                name = recognizer.Recognize(result)

                'Draw the label for each face detected and recognized

                currentFrame.Draw(name, font, New Point(f.rect.X - 2, f.rect.Y - 2), color:=New Bgr(Color.LightGreen))
            End If

            NamePersons(t - 1) = name
            NamePersons.Add("")

            label3.Text = facesDetected(0).Length.ToString()
        Next
        t = 0

        'Names concatenation of persons recognized
        For nnn As Integer = 0 To facesDetected(0).Length - 1
            names = NamePersons(nnn)
        Next
        'Show the faces procesed and recognized
        imageBoxFrameGrabber.Image = currentFrame
        label4.Text = names
        names = ""
        'Clear the list(vector) of names
        NamePersons.Clear()
    End Sub

End Class
