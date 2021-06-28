Imports System.Data.SqlClient

Public Class StudentImage
    Dim student_image_id As Integer
    Dim student_id As Integer
    Dim image_location As String

    Public Property _Student_image_id As Integer
        Get
            Return student_image_id
        End Get
        Set(value As Integer)
            student_image_id = value
        End Set
    End Property

    Public Property _Student_id As Integer
        Get
            Return student_id
        End Get
        Set(value As Integer)
            student_id = value
        End Set
    End Property

    Public Property _Image_location As String
        Get
            Return image_location
        End Get
        Set(value As String)
            image_location = value
        End Set
    End Property

    Public Function Fetch(ByVal studentimage As StudentImage) As StudentImage
        Dim dt As DataTable = Nothing

        Using cmd = New SqlCommand()
            cmd.CommandText = "select * from student_image where student_image_id = @student_image_id"
            cmd.Parameters.AddWithValue("@student_image_id", studentimage._Student_image_id)
            dt = Helper.executeQuery(cmd)
        End Using

        If dt.Rows.Count > 0 Then
            studentimage._Student_id = Convert.ToInt32(dt.Rows(0)("student_image_id"))
            studentimage._Student_id = dt.Rows(0)("student_id").ToString()
            studentimage._Image_location = dt.Rows(0)("image_location").ToString()
            Return studentimage
        Else
            Return Nothing
        End If
    End Function


    Public Function FetchAll() As DataTable
        Using cmd = New SqlCommand()
            cmd.CommandText = "select * from student_image"
            Return Helper.executeQuery(cmd)
        End Using
    End Function

    Public Function FetchByStudentID(ByVal student As Student) As DataTable
        Using cmd = New SqlCommand()
            cmd.CommandText = "select * from student_image where student_id = @student_id order by student_image_id desc"
            cmd.Parameters.AddWithValue("@student_id", student._Student_id)
            Return Helper.executeQuery(cmd)
        End Using
    End Function

    Public Function Create(ByVal studentimage As StudentImage) As Integer
        Using cmd = New SqlCommand()
            cmd.CommandText = "insert into student_image values (@student_id, @image_location); SELECT SCOPE_IDENTITY();"
            cmd.Parameters.AddWithValue("@student_id", studentimage._Student_id)
            cmd.Parameters.AddWithValue("@image_location", studentimage._Image_location)
            Return Helper.executeNonQuery(cmd)
        End Using
    End Function

    Public Function Delete(ByVal studentimage As StudentImage) As Boolean
        Using cmd = New SqlCommand()
            cmd.CommandText = "delete from student_image where student_image_id = @student_image_id"
            cmd.Parameters.AddWithValue("@student_image_id", studentimage._Student_image_id)
            Return Helper.executeNonQueryBool(cmd)
        End Using
    End Function

End Class
