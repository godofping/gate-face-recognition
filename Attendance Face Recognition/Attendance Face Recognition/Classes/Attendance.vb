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

    Public Function Fetch(ByVal attendance As Attendance) As Attendance
        Dim dt As DataTable = Nothing

        Using cmd = New SqlCommand()
            cmd.CommandText = "select * from attendance where attendance_id = @attendance_id"
            cmd.Parameters.AddWithValue("@attendance_id", attendance._Attendance_id)
            dt = Helper.executeQuery(cmd)
        End Using

        If dt.Rows.Count > 0 Then
            attendance._Attendance_id = Convert.ToInt32(dt.Rows(0)("attendance_id"))
            attendance._Student_id = Convert.ToInt32(dt.Rows(0)("student_id"))
            attendance._Attendance_type = dt.Rows(0)("attendance_type").ToString()
            attendance._Attendance_datetime = dt.Rows(0)("attendance_datetime").ToString()
            attendance._Issent = Convert.ToInt32(dt.Rows(0)("issent"))
            Return attendance
        Else
            Return Nothing
        End If
    End Function

    Public Function FetchByStudentID(ByVal attendance As Attendance) As DataTable
        Using cmd = New SqlCommand()
            cmd.CommandText = "select * from attendance where student_id = @student_id order by attendance_id desc"
            cmd.Parameters.AddWithValue("@student_id", attendance._Student_id)
            Return Helper.executeQuery(cmd)
        End Using
    End Function

    Public Function FetchByUnsentSMS() As DataTable
        Using cmd = New SqlCommand()
            cmd.CommandText = "select * from attendance_view where issent = 0"
            Return Helper.executeQuery(cmd)
        End Using
    End Function

    Public Function FetchByTypeAndTime(ByVal attendance As Attendance, ByVal from As String, ByVal until As String) As DataTable
        Using cmd = New SqlCommand()
            cmd.CommandText = "select * from attendance_view where student_id = @student_id and attendance_type = @attendance_type and attendance_datetime between @from and @to"
            cmd.Parameters.AddWithValue("@student_id", attendance._Student_id)
            cmd.Parameters.AddWithValue("@attendance_type", attendance._Attendance_type)
            cmd.Parameters.AddWithValue("@from", from)
            cmd.Parameters.AddWithValue("@to", until)
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

    Public Function Update(ByVal attendance As Attendance) As Boolean
        Using cmd = New SqlCommand()
            cmd.CommandText = "update attendance set student_id = @student_id, attendance_type = @attendance_type, issent = @issent where attendance_id = @attendance_id"
            cmd.Parameters.AddWithValue("@attendance_id", attendance._Attendance_id)
            cmd.Parameters.AddWithValue("@student_id", attendance._Student_id)
            cmd.Parameters.AddWithValue("@attendance_type", attendance._Attendance_type)
            cmd.Parameters.AddWithValue("@issent", attendance._Issent)
            Return Helper.executeNonQueryBool(cmd)
        End Using
    End Function


End Class
