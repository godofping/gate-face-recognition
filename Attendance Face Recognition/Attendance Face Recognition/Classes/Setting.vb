Imports System.Data.SqlClient

Public Class Setting
    Dim broadband_com As String
    Dim camera_number As Integer
    Dim attendance_type As String

    Public Property _Broadband_com As String
        Get
            Return broadband_com
        End Get
        Set(value As String)
            broadband_com = value
        End Set
    End Property

    Public Property _Camera_number As Integer
        Get
            Return camera_number
        End Get
        Set(value As Integer)
            camera_number = value
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

    Public Function Fetch() As Setting
        Dim setting As New Setting
        Dim dt As DataTable = Nothing

        Using cmd = New SqlCommand()
            cmd.CommandText = "select * from setting"
            dt = Helper.executeQuery(cmd)
        End Using

        If dt.Rows.Count > 0 Then
            setting._Broadband_com = dt.Rows(0)("broadband_com").ToString()
            setting._Camera_number = Convert.ToInt32(dt.Rows(0)("camera_number"))
            setting._Attendance_type = dt.Rows(0)("attendance_type").ToString()
            Return setting
        Else
            Return Nothing
        End If
    End Function

    Public Function Update(ByVal setting As Setting) As Boolean
        Using cmd = New SqlCommand()
            cmd.CommandText = "update setting set broadband_com = @broadband_com, camera_number = @camera_number, attendance_type = @attendance_type"
            cmd.Parameters.AddWithValue("@broadband_com", setting._Broadband_com)
            cmd.Parameters.AddWithValue("@camera_number", setting._Camera_number)
            cmd.Parameters.AddWithValue("@attendance_type", setting._Attendance_type)
            Return Helper.executeNonQueryBool(cmd)
        End Using
    End Function


End Class
