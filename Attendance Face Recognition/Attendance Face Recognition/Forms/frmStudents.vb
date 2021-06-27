Public Class frmStudents

    Dim student As New Student
    Dim s As String

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property


    Sub clearForm()
        txtStudentID.Text = ""
        txtIDNumber.Text = ""
        txtLastName.Text = ""
        txtFirstName.Text = ""
        txtMiddleName.Text = ""
        cbGradeLevel.SelectedIndex = -1
        txtContactPersonFullName.Text = ""
        txtContactPersonPhoneNumber.Text = ""
    End Sub

    Sub enableForm(ByVal bol As Boolean)
        gbForm.Enabled = bol
        btnAdd.Enabled = Not bol
        btnUpdate.Enabled = Not bol
        btnDelete.Enabled = Not bol
        btnSave.Enabled = bol
        btnCancel.Enabled = bol
        dgv.Enabled = Not bol
        txtIDNumber.Select()
    End Sub

    Sub search()
        dgv.DataSource = student.FetchAll(txtSearch.Text)
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
        student._Student_id = CInt(dgv.SelectedRows(0).Cells("student_id").Value)
        student = student.Fetch(student)

        txtStudentID.Text = student._Student_id.ToString
        txtIDNumber.Text = student._Id_number
        cbGradeLevel.Text = student._Grade_level
        txtLastName.Text = student._Last_name
        txtFirstName.Text = student._First_name
        txtMiddleName.Text = student._Middle_name
        txtContactPersonFullName.Text = student._Contact_person_full_name
        txtContactPersonPhoneNumber.Text = student._Contact_person_phone_number
    End Sub

    Sub ManageDGV()
        Helper.DGVRenameColumns(dgv, "#", "ID Number", "Last Name", "First Name", "Middle Name", "Grade LEvel", "Contact Person Full Name", "Contact Person Phone Number")
        Helper.DGVFillWeights(dgv, New Object() {0, 1, 2, 3, 4, 5, 6, 7}, New Integer() {4, 6, 20, 15, 10, 10, 20, 15})
    End Sub

    Private Sub frmStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            student._Student_id = CInt(dgv.SelectedRows(0).Cells("student_id").Value)
            student = student.Fetch(student)

            showResult(student.Delete(student))
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Helper.CheckRequiredTXT(txtIDNumber, txtLastName, txtFirstName, txtMiddleName, txtContactPersonFullName, txtContactPersonPhoneNumber) And Helper.CheckRequiredCB(cbGradeLevel) Then
            Dim result As DialogResult = MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                If s.Equals("ADD") Then
                    student._Id_number = txtIDNumber.Text
                    student._Grade_level = cbGradeLevel.Text
                    student._Last_name = txtLastName.Text
                    student._First_name = txtFirstName.Text
                    student._Middle_name = txtMiddleName.Text
                    student._Contact_person_full_name = txtContactPersonFullName.Text
                    student._Contact_person_phone_number = txtContactPersonPhoneNumber.Text

                    If student.CheckIfExisting(student).Rows.Count = 0 Then
                        If student.CheckIfExistingIDNumber(student).Rows.Count = 0 Then
                            Dim res As Integer = student.Create(student)
                            showResult(res > 0)
                        Else
                            MsgBox("ID Number is already taken.")
                        End If
                    Else
                        MsgBox("Already existing")
                    End If
                End If

                If s.Equals("UPDATE") Then
                    student._Student_id = CInt(txtStudentID.Text)
                    student._Id_number = txtIDNumber.Text
                    student._Grade_level = cbGradeLevel.Text
                    student._Last_name = txtLastName.Text
                    student._First_name = txtFirstName.Text
                    student._Middle_name = txtMiddleName.Text
                    student._Contact_person_full_name = txtContactPersonFullName.Text
                    student._Contact_person_phone_number = txtContactPersonPhoneNumber.Text

                    If student.CheckIfExisting(student).Rows.Count = 0 Then
                        If student.CheckIfExistingIDNumber(student).Rows.Count = 0 Then
                            showResult(student.Update(student))
                        Else
                            MsgBox("ID Number is already taken.")
                        End If
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
