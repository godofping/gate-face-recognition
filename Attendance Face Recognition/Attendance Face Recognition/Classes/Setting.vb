Imports System.Data.SqlClient

Public Class Setting
    Dim broadband_com As String
    Dim camera_entrance As String
    Dim camera_exit As String

    Public Property _Broadband_com As String
        Get
            Return broadband_com
        End Get
        Set(value As String)
            broadband_com = value
        End Set
    End Property

    Public Property _Camera_entrance As String
        Get
            Return camera_entrance
        End Get
        Set(value As String)
            camera_entrance = value
        End Set
    End Property

    Public Property _Camera_exit As String
        Get
            Return camera_exit
        End Get
        Set(value As String)
            camera_exit = value
        End Set
    End Property

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
