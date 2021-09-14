Imports System.Data.SqlClient

Public Class Promo
    Dim promo_id As Integer
    Dim send_to As String
    Dim promo_name As String
    Dim promo_code As String
    Dim telco As String

    Public Property _Promo_id As Integer
        Get
            Return promo_id
        End Get
        Set(value As Integer)
            promo_id = value
        End Set
    End Property

    Public Property _Send_to As String
        Get
            Return send_to
        End Get
        Set(value As String)
            send_to = value
        End Set
    End Property

    Public Property _Promo_name As String
        Get
            Return promo_name
        End Get
        Set(value As String)
            promo_name = value
        End Set
    End Property

    Public Property _Promo_code As String
        Get
            Return promo_code
        End Get
        Set(value As String)
            promo_code = value
        End Set
    End Property

    Public Property _Telco As String
        Get
            Return telco
        End Get
        Set(value As String)
            telco = value
        End Set
    End Property

    Public Function Fetch(ByVal promo As Promo) As Promo
        Dim dt As DataTable = Nothing

        Using cmd = New SqlCommand()
            cmd.CommandText = "select * from promo where promo_id = @promo_id"
            cmd.Parameters.AddWithValue("@promo_id", promo._Promo_id)
            dt = Helper.executeQuery(cmd)
        End Using

        If dt.Rows.Count > 0 Then
            promo._Promo_id = Convert.ToInt32(dt.Rows(0)("promo_id"))
            promo._Send_to = dt.Rows(0)("send_to").ToString()
            promo._Promo_name = dt.Rows(0)("promo_name").ToString()
            promo._Promo_code = dt.Rows(0)("promo_code").ToString()
            promo._Telco = dt.Rows(0)("telco").ToString()
            Return promo
        Else
            Return Nothing
        End If
    End Function

    Public Function FetchAll(ByVal keyword As String) As DataTable
        Using cmd = New SqlCommand()
            cmd.CommandText = "select * from promo where (promo_id like @keyword or send_to like @keyword or promo_name like @keyword or promo_code like @keyword or telco like @keyword)"
            cmd.Parameters.AddWithValue("@keyword", keyword & "%")
            Return Helper.executeQuery(cmd)
        End Using
    End Function

    Public Function Create(ByVal promo As Promo) As Integer
        Using cmd = New SqlCommand()
            cmd.CommandText = "insert into promo values (@send_to, @promo_name, @promo_code, @telco); SELECT SCOPE_IDENTITY();"
            cmd.Parameters.AddWithValue("@send_to", promo._Send_to)
            cmd.Parameters.AddWithValue("@promo_name", promo._Promo_name)
            cmd.Parameters.AddWithValue("@promo_code", promo._Promo_code)
            cmd.Parameters.AddWithValue("@telco", promo._Telco)
            Return Helper.executeNonQuery(cmd)
        End Using
    End Function

    Public Function Update(ByVal promo As Promo) As Boolean
        Using cmd = New SqlCommand()
            cmd.CommandText = "update promo set send_to = @send_to, promo_name = @promo_name, promo_code = @promo_code, telco = @telco where promo_id = @promo_id"
            cmd.Parameters.AddWithValue("@promo_id", promo.promo_id)
            cmd.Parameters.AddWithValue("@send_to", promo._Send_to)
            cmd.Parameters.AddWithValue("@promo_name", promo._Promo_name)
            cmd.Parameters.AddWithValue("@promo_code", promo._Promo_code)
            cmd.Parameters.AddWithValue("@telco", promo._Telco)
            Return Helper.executeNonQueryBool(cmd)
        End Using
    End Function

    Public Function Delete(ByVal promo As Promo) As Boolean
        Using cmd = New SqlCommand()
            cmd.CommandText = "delete from promo where promo_id = @promo_id"
            cmd.Parameters.AddWithValue("@promo_id", promo._Promo_id)
            Return Helper.executeNonQueryBool(cmd)
        End Using
    End Function

End Class
