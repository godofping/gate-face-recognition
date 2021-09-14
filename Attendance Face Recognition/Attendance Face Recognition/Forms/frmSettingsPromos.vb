Public Class frmSettingsPromos

    Dim promo As New Promo
    Dim s As String

    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or 33554432
            Return cp
        End Get
    End Property

    Sub clearForm()
        txtPromoID.Text = ""
        txtPromoName.Text = ""
        txtPromoCode.Text = ""
        txtSendTo.Text = ""
        cbTelco.SelectedIndex = -1
    End Sub

    Sub enableForm(ByVal bol As Boolean)
        gbForm.Enabled = bol
        btnAdd.Enabled = Not bol
        btnUpdate.Enabled = Not bol
        btnDelete.Enabled = Not bol
        btnSave.Enabled = bol
        btnCancel.Enabled = bol
        dgv.Enabled = Not bol
        txtPromoID.Select()
    End Sub

    Sub search()
        dgv.DataSource = promo.FetchAll(txtSearch.Text)
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
        promo._Promo_id = CInt(dgv.SelectedRows(0).Cells("promo_id").Value)
        promo = promo.Fetch(promo)

        txtPromoID.Text = promo._Promo_id.ToString
        cbTelco.Text = promo._Telco
        txtPromoName.Text = promo._Promo_name
        txtPromoCode.Text = promo._Promo_code
        txtSendTo.Text = promo._Send_to
    End Sub

    Sub ManageDGV()
        Helper.DGVRenameColumns(dgv, "#", "Send To", "Promo Name", "Promo Code", "Telco")
        Helper.DGVFillWeights(dgv, New Object() {0, 1, 2, 3, 4}, New Integer() {10, 25, 25, 20, 20})
    End Sub

    Private Sub frmSettingsPromos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        btnRegisterPromo.Visible = True
        clearForm()
        getData()
        s = "UPDATE"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Helper.CheckRequiredTXT(txtPromoCode, txtPromoName) And Helper.CheckRequiredCB(cbTelco) Then
            Dim result As DialogResult = MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                If s.Equals("ADD") Then
                    promo._Send_to = txtSendTo.Text
                    promo._Promo_name = txtPromoName.Text
                    promo._Promo_code = txtPromoCode.Text
                    promo._Telco = cbTelco.Text

                    Dim res As Integer = promo.Create(promo)
                    showResult(res > 0)

                End If

                If s.Equals("UPDATE") Then
                    promo._Promo_id = CInt(txtPromoID.Text)
                    promo._Send_to = txtSendTo.Text
                    promo._Promo_name = txtPromoName.Text
                    promo._Promo_code = txtPromoCode.Text
                    promo._Telco = cbTelco.Text

                    showResult(promo.Update(promo))
                End If
            End If
        Else
            MsgBox("Please fill up all the required fields denote by an asterisk *")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            promo._Promo_id = CInt(dgv.SelectedRows(0).Cells("promo_id").Value)
            promo = promo.Fetch(promo)
            showResult(promo.Delete(promo))
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        enableForm(False)
        btnRegisterPromo.Visible = False
        clearForm()
    End Sub

    Private Sub btnRegisterPromo_Click(sender As Object, e As EventArgs) Handles btnRegisterPromo.Click
        Dim setting As New Setting
        setting = setting.Fetch
        If Helper.SendSMS(setting._Broadband_com, promo._Send_to, promo._Promo_code) Then
            MsgBox("Promo sent. Please wait 30 seconds for promo to register.")
        Else
            MsgBox("Error sending SMS. Incorrect COM Port")
        End If
    End Sub
End Class