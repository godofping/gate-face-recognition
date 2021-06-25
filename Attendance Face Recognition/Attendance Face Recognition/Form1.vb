Public Class Form1

    Dim admin As New Admin
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        admin._Username = "admin"
        admin._Password = "password"

        MsgBox(admin.Create(admin))

    End Sub
End Class
