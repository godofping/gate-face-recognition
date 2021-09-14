Imports Emgu.CV.Structure
Imports Emgu.CV
Imports System.IO

Public Class frmStudentImage

    Dim currentFrame As Image(Of Bgr, [Byte])
    Dim grabber As Capture
    Dim face As HaarCascade
    Dim font As New MCvFont(CvEnum.FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5, 0.5)
    Dim result As Image(Of Gray, Byte), TrainedFace As Image(Of Gray, Byte) = Nothing
    Dim gray As Image(Of Gray, Byte) = Nothing
    Dim trainingImages As New List(Of Image(Of Gray, Byte))()
    Dim student As Student
    Dim studentimage As New StudentImage
    Dim setting As New Setting

    Sub getImages()
        Dim dt As DataTable = studentimage.FetchByStudentID(student)

        dt.Columns.Add("image", Type.GetType("System.Byte[]"))

        For Each drow As DataRow In dt.Rows
            Try
                drow("image") = File.ReadAllBytes(drow("image_location").ToString)
            Catch ex As Exception

            End Try
        Next
        dgv.DataSource = dt

        lblTotalImages.Text = "Number of Images: " & dt.Rows.Count
    End Sub

    Sub ManageDGV()
        Helper.DGVRenameColumns(dgv, "#", "Student ID", "Image Location", "Image")
        Helper.DGVFillWeights(dgv, New Object() {0, 3}, New Integer() {25, 75})
        Helper.DGVHiddenColumns(dgv, "student_image_id", "student_id", "image_location")
        For i = 0 To dgv.Rows.Count - 1
            dgv.Rows(i).Height = 100
        Next
    End Sub

    Sub showResult(ByVal bol As Boolean)
        If bol Then
            MsgBox("Success")
            getImages()
            ManageDGV()
        Else
            MsgBox("Failed")
        End If
    End Sub

    Public Sub New(_student As Student)
        InitializeComponent()
        'Load haarcascades for face detection
        face = New HaarCascade("haarcascade_frontalface_default.xml")
        student = _student
        lblFor.Text = "For " & student._Last_name & ", " & student._First_name & " " & student._Middle_name
    End Sub

    Private Sub frmStudentImage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setting = setting.Fetch()
        grabber = New Capture(setting._Camera_number)
        grabber.QueryFrame()
        Timer1.Start()
        getImages()
        ManageDGV()

    End Sub

    Private Sub btnTakePicture_Click(sender As Object, e As EventArgs) Handles btnTakePicture.Click
        Try
            'Get a gray frame from capture device
            gray = grabber.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC)

            'Face Detector
            Dim facesDetected As MCvAvgComp()() = gray.DetectHaarCascade(face, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, New Size(20, 20))

            'Action for each element detected
            For Each f As MCvAvgComp In facesDetected(0)
                TrainedFace = currentFrame.Copy(f.rect).Convert(Of Gray, Byte)()
                Exit For
            Next

            Try
                'resize face detected image for force to compare the same size with the 
                'test image with cubic interpolation type method
                TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC)

                'Show face added in gray scale
                ibDetectedFace.Image = TrainedFace


                Dim byt As Byte() = System.Text.Encoding.UTF8.GetBytes(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"))
                Dim RandomName = Convert.ToBase64String(byt) & CInt(Math.Ceiling(Rnd() * 999999)) + 1
                TrainedFace.Save("C:/StudentFaces/" & RandomName & ".bmp")

                studentimage._Student_id = student._Student_id
                studentimage._Image_location = "C:/StudentFaces/" & RandomName & ".bmp"

                If (studentimage.Create(studentimage)) Then
                    getImages()
                    ManageDGV()
                End If
            Catch ex As Exception
                MsgBox("No face detected")
            End Try

            ibDetectedFace.Image = Nothing
        Catch
            MsgBox("SOMETHING WRONG")
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            studentimage._Student_image_id = CInt(dgv.SelectedRows(0).Cells("student_image_id").Value)
            studentimage = studentimage.Fetch(studentimage)
            System.IO.File.Delete(studentimage._Image_location)
            showResult(studentimage.Delete(studentimage))
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
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
        Next
        ibCamera.Image = currentFrame
    End Sub
End Class