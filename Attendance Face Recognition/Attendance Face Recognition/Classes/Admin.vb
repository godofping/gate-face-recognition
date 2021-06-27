Imports System.Data.SqlClient

Public Class Admin
    Dim admin_id As Integer
    Dim username As String
    Dim password As String

    Public Property _Admin_id As Integer
        Get
            Return admin_id
        End Get
        Set(value As Integer)
            admin_id = value
        End Set
    End Property

    Public Property _Username As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property

    Public Property _Password As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property

    Public Function Login(ByVal admin As Admin) As DataTable
        Using cmd = New SqlCommand()
            cmd.CommandText = "select * from admin where username = @username and password = @password"
            cmd.Parameters.AddWithValue("@username", admin._Username)
            cmd.Parameters.AddWithValue("@password", admin._Password)
            Return Helper.executeQuery(cmd)
        End Using
    End Function

    Public Function Fetch(ByVal admin As Admin) As Admin
        Dim dt As DataTable = Nothing

        Using cmd = New SqlCommand()
            cmd.CommandText = "select * from admin where admin_id = @admin_id"
            cmd.Parameters.AddWithValue("@admin_id", admin._Admin_id)
            dt = Helper.executeQuery(cmd)
        End Using

        If dt.Rows.Count > 0 Then
            admin._Admin_id = Convert.ToInt32(dt.Rows(0)("admin_id"))
            admin._Username = dt.Rows(0)("username").ToString()
            admin._Password = dt.Rows(0)("password").ToString()
            Return admin
        Else
            Return Nothing
        End If
    End Function

    Public Function FetchAll(ByVal keyword As String) As DataTable
        Using cmd = New SqlCommand()
            cmd.CommandText = "select * from admin where (admin_id like @keyword or username like @keyword or password like @keyword)"
            cmd.Parameters.AddWithValue("@keyword", keyword & "%")
            Return Helper.executeQuery(cmd)
        End Using
    End Function

    Public Function CheckIfExisting(ByVal admin As Admin) As DataTable
        Using cmd = New SqlCommand()
            cmd.CommandText = "select * from admin where admin_id <> @admin_id and username = @username"
            cmd.Parameters.AddWithValue("@admin_id", admin._Admin_id)
            cmd.Parameters.AddWithValue("@username", admin._Username)
            Return Helper.executeQuery(cmd)
        End Using
    End Function

    Public Function CheckIfExistingUsername(ByVal admin As Admin) As DataTable
        Using cmd = New SqlCommand()
            cmd.CommandText = "select * from admin where username = @username"
            cmd.Parameters.AddWithValue("@admin_id", admin._Admin_id)
            cmd.Parameters.AddWithValue("@username", admin._Username)
            Return Helper.executeQuery(cmd)
        End Using
    End Function

    Public Function Create(ByVal admin As Admin) As Integer
        Using cmd = New SqlCommand()
            cmd.CommandText = "insert into admin values (@username, @password); SELECT SCOPE_IDENTITY();"
            cmd.Parameters.AddWithValue("@username", admin._Username)
            cmd.Parameters.AddWithValue("@password", admin._Password)
            Return Helper.executeNonQuery(cmd)
        End Using
    End Function

    Public Function Update(ByVal admin As Admin) As Boolean
        Using cmd = New SqlCommand()
            cmd.CommandText = "update admin set username = @username, password = @password where admin_id = @admin_id"
            cmd.Parameters.AddWithValue("@admin_id", admin._Admin_id)
            cmd.Parameters.AddWithValue("@username", admin._Username)
            cmd.Parameters.AddWithValue("@password", admin._Password)
            Return Helper.executeNonQueryBool(cmd)
        End Using
    End Function

    Public Function Delete(ByVal admin As Admin) As Boolean
        Using cmd = New SqlCommand()
            cmd.CommandText = "delete from admin where admin_id = @admin_id"
            cmd.Parameters.AddWithValue("@admin_id", admin._Admin_id)
            Return Helper.executeNonQueryBool(cmd)
        End Using
    End Function

End Class
