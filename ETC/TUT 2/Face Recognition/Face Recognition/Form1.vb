Imports System.Diagnostics
Imports Emgu.CV.Structure
Imports Emgu.CV
Imports Emgu.CV.CvEnum
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO

Public Class Form1
    Dim currentFrame As Image(Of Bgr, [Byte])
    Dim grabber As Capture
    Dim face As HaarCascade
    Dim eye As HaarCascade
    Dim font As New MCvFont(CvEnum.FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5, 0.5)
    Dim result As Image(Of Gray, Byte), TrainedFace As Image(Of Gray, Byte) = Nothing
    Dim gray As Image(Of Gray, Byte) = Nothing
    Dim trainingImages As New List(Of Image(Of Gray, Byte))()
    Dim labels As New List(Of String)()
    Dim NamePersons As New List(Of String)()
    Dim ContTrain As Integer, NumLabels As Integer, t As Integer
    Dim name As String, names As String = Nothing




    Public Sub New()
        InitializeComponent()
        'Load haarcascades for face detection
        face = New HaarCascade("haarcascade_frontalface_default.xml")
        'eye = new HaarCascade("haarcascade_eye.xml");
        Try
            'Load of previus trainned faces and labels for each image
            Dim Labelsinfo As String = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt")
            Dim Labels__1 As String() = Labelsinfo.Split("%"c)
            NumLabels = Convert.ToInt16(Labels__1(0))
            ContTrain = NumLabels
            Dim LoadFaces As String

            For tf As Integer = 1 To NumLabels
                LoadFaces = "face" & tf & ".bmp"
                trainingImages.Add(New Image(Of Gray, Byte)(Application.StartupPath + "/TrainedFaces/" & LoadFaces))
                labels.Add(Labels__1(tf))

            Next
        Catch e As Exception
            'MessageBox.Show(e.ToString());
            MessageBox.Show("Nothing in database, please add at least a face.", "Triained faces load", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try
    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        grabber = New Capture(0)
        grabber.QueryFrame()
        Timer1.Start()
        button1.Enabled = False
    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        Try
            'Trained face counter
            ContTrain = ContTrain + 1

            'Get a gray frame from capture device
            gray = grabber.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC)

            'Face Detector
            Dim facesDetected As MCvAvgComp()() = gray.DetectHaarCascade(face, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, New Size(20, 20))

            'Action for each element detected
            For Each f As MCvAvgComp In facesDetected(0)
                TrainedFace = currentFrame.Copy(f.rect).Convert(Of Gray, Byte)()
                Exit For
            Next

            'resize face detected image for force to compare the same size with the 
            'test image with cubic interpolation type method
            TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC)
            trainingImages.Add(TrainedFace)
            labels.Add(textBox1.Text)

            'Show face added in gray scale
            imageBox1.Image = TrainedFace

            'Write the number of triained faces in a file text for further load
            File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", trainingImages.ToArray().Length.ToString() & "%")

            'Write the labels of triained faces in a file text for further load
            For i As Integer = 1 To trainingImages.ToArray().Length
                trainingImages.ToArray()(i - 1).Save(Application.StartupPath + "/TrainedFaces/face" & i & ".bmp")
                File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", labels.ToArray()(i - 1) + "%")
            Next

            MessageBox.Show(textBox1.Text + "´s face detected and added :)", "Training OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
            textBox1.Text = ""
            imageBox1.Image = Nothing
        Catch
            MessageBox.Show("Enable the face detection first", "Training Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
            names = names + NamePersons(nnn) + ", "
        Next
        'Show the faces procesed and recognized
        imageBoxFrameGrabber.Image = currentFrame
        label4.Text = names
        names = ""
        'Clear the list(vector) of names
        NamePersons.Clear()
    End Sub

End Class
