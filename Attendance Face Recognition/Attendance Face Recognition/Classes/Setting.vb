Imports System.Data.SqlClient

Public Class Setting
    Dim broadband_com As String
    Dim camera_entrance As Integer
    Dim camera_exit As Integer

    Public Property _Broadband_com As String
        Get
            Return broadband_com
        End Get
        Set(value As String)
            broadband_com = value
        End Set
    End Property

    Public Property _Camera_entrance As Integer
        Get
            Return camera_entrance
        End Get
        Set(value As Integer)
            camera_entrance = value
        End Set
    End Property

    Public Property _Camera_exit As Integer
        Get
            Return camera_exit
        End Get
        Set(value As Integer)
            camera_exit = value
        End Set
    End Property

    Public Function Fetch(ByVal setting As Setting) As Setting
        Dim dt As DataTable = Nothing

        Using cmd = New SqlCommand()
            cmd.CommandText = "select * from setting"
            dt = Helper.executeQuery(cmd)
        End Using

        If dt.Rows.Count > 0 Then
            setting._Broadband_com = dt.Rows(0)("broadband_com").ToString()
            setting._Camera_entrance = dt.Rows(0)("camera_entrance").ToString()
            setting._Camera_exit = Convert.ToInt32(dt.Rows(0)("camera_exit"))
            Return setting
        Else
            Return Nothing
        End If
    End Function

    Public Function Update(ByVal setting As Setting) As Boolean
        Using cmd = New SqlCommand()
            cmd.CommandText = "update setting set broadband_com = @broadband_com, camera_entrance = @camera_entrance, camera_exit = @camera_exit"
            cmd.Parameters.AddWithValue("@broadband_com", setting._Broadband_com)
            cmd.Parameters.AddWithValue("@camera_entrance", setting._Camera_entrance)
            cmd.Parameters.AddWithValue("@camera_exit", setting._Camera_exit)
            Return Helper.executeNonQueryBool(cmd)
        End Using
    End Function
End Class
