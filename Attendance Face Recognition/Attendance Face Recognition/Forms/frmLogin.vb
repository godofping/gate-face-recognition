Public Class frmLogin

    Dim admin As New Admin

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Public Sub clearForm()
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtUsername.Select()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        admin._Username = txtUsername.Text
        admin._Password = txtPassword.Text

        Dim dt As DataTable = admin.Login(admin)

        If dt.Rows.Count > 0 Then
            Me.Hide()
            Call New frmMain(admin).ShowDialog()
        Else
            MsgBox("Login Failed")
        End If

    End Sub

    Private Sub frmLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = Keys.F9) Then
            frmAttendance.Show()
            Me.Hide()
        End If
    End Sub
End Class