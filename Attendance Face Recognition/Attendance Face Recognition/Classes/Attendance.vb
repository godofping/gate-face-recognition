Imports System.Data.SqlClient

Public Class Attendance
    Dim attendance_id As Integer
    Dim student_id As Integer
    Dim attendance_type As String
    Dim attendance_datetime As String
    Dim issent As Integer

    Public Property _Attendance_id As Integer
        Get
            Return attendance_id
        End Get
        Set(value As Integer)
            attendance_id = value
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

    Public Property _Attendance_type As String
        Get
            Return attendance_type
        End Get
        Set(value As String)
            attendance_type = value
        End Set
    End Property

    Public Property _Attendance_datetime As String
        Get
            Return attendance_datetime
        End Get
        Set(value As String)
            attendance_datetime = value
        End Set
    End Property

    Public Property _Issent As Integer
        Get
            Return issent
        End Get
        Set(value As Integer)
            issent = value
        End Set
    End Property

    Public Function FetchByStudentID(ByVal attendance As Attendance) As DataTable
        Using cmd = New SqlCommand()
            cmd.CommandText = "select * from attendance where student_id = @student_id order by attendance_id desc"
            cmd.Parameters.AddWithValue("@student_id", attendance._Student_id)
            Return Helper.executeQuery(cmd)
        End Using
    End Function

    Public Function Create(ByVal attendance As Attendance) As Integer
        Using cmd = New SqlCommand()
            cmd.CommandText = "insert into attendance values (@student_id, @attendance_type, @attendance_datetime, @issent); SELECT SCOPE_IDENTITY();"
            cmd.Parameters.AddWithValue("@student_id", attendance._Student_id)
            cmd.Parameters.AddWithValue("@attendance_type", attendance._Attendance_type)
            cmd.Parameters.AddWithValue("@attendance_datetime", attendance._Attendance_datetime)
            cmd.Parameters.AddWithValue("@issent", attendance._Issent)
            Return Helper.executeNonQuery(cmd)
        End Using
    End Function
End Class
