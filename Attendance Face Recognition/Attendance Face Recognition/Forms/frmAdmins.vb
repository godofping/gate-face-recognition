Public Class frmAdmins

    Dim admin As New Admin
    Dim s As String

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Sub clearForm()
        txtAdminID.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Sub enableForm(ByVal bol As Boolean)
        gbForm.Enabled = bol
        btnAdd.Enabled = Not bol
        btnUpdate.Enabled = Not bol
        btnDelete.Enabled = Not bol
        btnSave.Enabled = bol
        btnCancel.Enabled = bol
        dgv.Enabled = Not bol
        txtUsername.Select()
    End Sub

    Sub search()
        dgv.DataSource = admin.FetchAll(txtSearch.Text)
    End Sub

    Sub showResult(ByVal bol As Boolean)
        If bol Then
            MsgBox("Success")
            clearForm()
            enableForm(False)
            search()
        Else
            MsgBox("Failed")
        End If
    End Sub

    Sub getData()
        admin._Admin_id = CInt(dgv.SelectedRows(0).Cells("admin_id").Value)
        admin = admin.Fetch(admin)

        txtAdminID.Text = admin._Admin_id.ToString
        txtUsername.Text = admin._Username
        txtPassword.Text = admin._Password
    End Sub

    Sub ManageDGV()
        Helper.DGVRenameColumns(dgv, "#", "Username", "password")
        Helper.DGVHiddenColumns(dgv, "password")
        Helper.DGVFillWeights(dgv, New Object() {0, 1}, New Integer() {10, 90})
    End Sub

    Private Sub frmAdmins_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        search()
        ManageDGV()
        enableForm(False)
        clearForm()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        enableForm(True)
        clearForm()
        s = "ADD"
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        enableForm(True)
        clearForm()
        getData()
        s = "UPDATE"
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            admin._Admin_id = CInt(dgv.SelectedRows(0).Cells("admin_id").Value)
            admin = admin.Fetch(admin)

            showResult(admin.Delete(admin))
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Helper.CheckRequiredTXT(txtUsername, txtPassword) Then

            Dim result As DialogResult = MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then

                If s.Equals("ADD") Then

                    admin._Username = txtUsername.Text
                    admin._Password = txtPassword.Text

                    If admin.CheckIfExistingUsername(admin).Rows.Count = 0 Then
                        showResult(admin.Create(admin) > 0)
                    Else
                        MsgBox("Already existing")
                    End If


                End If

                If s.Equals("UPDATE") Then

                    admin._Admin_id = CInt(txtAdminID.Text)
                    admin._Username = txtUsername.Text
                    admin._Password = txtPassword.Text

                    If admin.CheckIfExisting(admin).Rows.Count = 0 Then
                        showResult(admin.Update(admin))
                    Else
                        MsgBox("Already existing")
                    End If

                End If

            End If
        Else
            MsgBox("Please fill up all the required fields denote by an asterisk *")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        enableForm(False)
        clearForm()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        search()
    End Sub

    Private Sub dgv_SelectionChanged(sender As Object, e As EventArgs) Handles dgv.SelectionChanged
        Try
            getData()
        Catch ex As Exception

        End Try
    End Sub
End Class