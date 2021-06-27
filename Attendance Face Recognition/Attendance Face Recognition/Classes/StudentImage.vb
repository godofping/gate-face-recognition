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

    Public Function FetchAll(ByVal keyword As String) As DataTable
        Using cmd = New SqlCommand()
            cmd.CommandText = "select * from student_image"
            cmd.Parameters.AddWithValue("@keyword", keyword & "%")
            Return Helper.executeQuery(cmd)
        End Using
    End Function

    Public Function Create(ByVal image As StudentImage) As Integer
        Using cmd = New SqlCommand()
            cmd.CommandText = "insert into student_image values (@student_id, @image_location); SELECT SCOPE_IDENTITY();"
            cmd.Parameters.AddWithValue("@student_id", image._Student_id)
            cmd.Parameters.AddWithValue("@image_location", image._Image_location)
            Return Helper.executeNonQuery(cmd)
        End Using
    End Function

End Class
