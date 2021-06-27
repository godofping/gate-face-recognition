Imports System.Data.SqlClient

Public Class Student
    Dim student_id As Integer
    Dim id_number As String
    Dim last_name As String
    Dim first_name As String
    Dim middle_name As String
    Dim grade_level As String
    Dim contact_person_full_name As String
    Dim contact_person_phone_number As String

    Public Property _Student_id As Integer
        Get
            Return student_id
        End Get
        Set(value As Integer)
            student_id = value
        End Set
    End Property

    Public Property _Id_number As String
        Get
            Return id_number
        End Get
        Set(value As String)
            id_number = value
        End Set
    End Property

    Public Property _Last_name As String
        Get
            Return last_name
        End Get
        Set(value As String)
            last_name = value
        End Set
    End Property

    Public Property _First_name As String
        Get
            Return first_name
        End Get
        Set(value As String)
            first_name = value
        End Set
    End Property

    Public Property _Middle_name As String
        Get
            Return middle_name
        End Get
        Set(value As String)
            middle_name = value
        End Set
    End Property

    Public Property _Grade_level As String
        Get
            Return grade_level
        End Get
        Set(value As String)
            grade_level = value
        End Set
    End Property

    Public Property _Contact_person_full_name As String
        Get
            Return contact_person_full_name
        End Get
        Set(value As String)
            contact_person_full_name = value
        End Set
    End Property

    Public Property _Contact_person_phone_number As String
        Get
            Return contact_person_phone_number
        End Get
        Set(value As String)
            contact_person_phone_number = value
        End Set
    End Property

    Public Function Fetch(ByVal student As Student) As Student
        Dim dt As DataTable = Nothing

        Using cmd = New SqlCommand()
            cmd.CommandText = "select * from student where student_id = @student_id"
            cmd.Parameters.AddWithValue("@student_id", student._Student_id)
            dt = Helper.executeQuery(cmd)
        End Using

        If dt.Rows.Count > 0 Then
            student._Student_id = Convert.ToInt32(dt.Rows(0)("student_id"))
            student._Id_number = dt.Rows(0)("id_number").ToString()
            student._Last_name = dt.Rows(0)("last_name").ToString()
            student._First_name = dt.Rows(0)("first_name").ToString()
            student._Middle_name = dt.Rows(0)("middle_name").ToString()
            student._Grade_level = dt.Rows(0)("grade_level").ToString()
            student._Contact_person_full_name = dt.Rows(0)("contact_person_full_name").ToString()
            student._Contact_person_phone_number = dt.Rows(0)("contact_person_phone_number").ToString()
            Return student
        Else
            Return Nothing
        End If
    End Function

    Public Function FetchAll(ByVal keyword As String) As DataTable
        Using cmd = New SqlCommand()
            cmd.CommandText = "select * from student where (student_id like @keyword or id_number like @keyword or last_name like @keyword or first_name like @keyword or middle_name like @keyword or grade_level like @keyword or contact_person_full_name like @keyword or contact_person_phone_number like @keyword)"
            cmd.Parameters.AddWithValue("@keyword", keyword & "%")
            Return Helper.executeQuery(cmd)
        End Using
    End Function

    Public Function CheckIfExisting(ByVal student As Student) As DataTable
        Using cmd = New SqlCommand()
            cmd.CommandText = "select * from student where student_id <> @student_id and id_number = @id_number and last_name = @last_name and first_name = @first_name and middle_name = @middle_name and grade_level = @grade_level and contact_person_full_name = @contact_person_full_name and contact_person_phone_number = @contact_person_phone_number"
            cmd.Parameters.AddWithValue("@student_id", student._Student_id)
            cmd.Parameters.AddWithValue("@id_number", student._Id_number)
            cmd.Parameters.AddWithValue("@last_name", student._Last_name)
            cmd.Parameters.AddWithValue("@first_name", student._First_name)
            cmd.Parameters.AddWithValue("@middle_name", student._Middle_name)
            cmd.Parameters.AddWithValue("@grade_level", student._Grade_level)
            cmd.Parameters.AddWithValue("@contact_person_full_name", student.contact_person_full_name)
            cmd.Parameters.AddWithValue("@contact_person_phone_number", student._Contact_person_phone_number)
            Return Helper.executeQuery(cmd)
        End Using
    End Function

    Public Function CheckIfExistingIDNumber(ByVal student As Student) As DataTable
        Using cmd = New SqlCommand()
            cmd.CommandText = "select * from student where student_id <> @student_id and id_number = @id_number"
            cmd.Parameters.AddWithValue("@student_id", student._Student_id)
            cmd.Parameters.AddWithValue("@id_number", student._Id_number)
            Return Helper.executeQuery(cmd)
        End Using
    End Function

    Public Function Create(ByVal student As Student) As Integer
        Using cmd = New SqlCommand()
            cmd.CommandText = "insert into student values (@id_number, @last_name, @first_name, @middle_name, @grade_level, @contact_person_full_name, @contact_person_phone_number); SELECT SCOPE_IDENTITY();"
            cmd.Parameters.AddWithValue("@id_number", student._Id_number)
            cmd.Parameters.AddWithValue("@last_name", student._Last_name)
            cmd.Parameters.AddWithValue("@first_name", student._First_name)
            cmd.Parameters.AddWithValue("@middle_name", student._Middle_name)
            cmd.Parameters.AddWithValue("@grade_level", student._Grade_level)
            cmd.Parameters.AddWithValue("@contact_person_full_name", student.contact_person_full_name)
            cmd.Parameters.AddWithValue("@contact_person_phone_number", student._Contact_person_phone_number)
            Return Helper.executeNonQuery(cmd)
        End Using
    End Function

    Public Function Update(ByVal student As Student) As Boolean
        Using cmd = New SqlCommand()
            cmd.CommandText = "update student set id_number = @id_number, last_name = @last_name, first_name = @first_name, middle_name = @middle_name, grade_level = @grade_level, contact_person_full_name = @contact_person_full_name, contact_person_phone_number = @contact_person_phone_number where student_id = @student_id"
            cmd.Parameters.AddWithValue("@student_id", student._Student_id)
            cmd.Parameters.AddWithValue("@id_number", student._Id_number)
            cmd.Parameters.AddWithValue("@last_name", student._Last_name)
            cmd.Parameters.AddWithValue("@first_name", student._First_name)
            cmd.Parameters.AddWithValue("@middle_name", student._Middle_name)
            cmd.Parameters.AddWithValue("@grade_level", student._Grade_level)
            cmd.Parameters.AddWithValue("@contact_person_full_name", student.contact_person_full_name)
            cmd.Parameters.AddWithValue("@contact_person_phone_number", student._Contact_person_phone_number)
            Return Helper.executeNonQueryBool(cmd)
        End Using
    End Function

    Public Function Delete(ByVal student As Student) As Boolean
        Using cmd = New SqlCommand()
            cmd.CommandText = "delete from student where student_id = @student_id"
            cmd.Parameters.AddWithValue("@student_id", student._Student_id)
            Return Helper.executeNonQueryBool(cmd)
        End Using
    End Function

End Class
