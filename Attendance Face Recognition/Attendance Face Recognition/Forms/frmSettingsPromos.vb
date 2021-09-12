Public Class frmSettingsPromos
    Dim setting As New Setting

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        setting = setting.Fetch(setting)
        If Helper.SendSMS(setting._Broadband_com, "8080", cbPromos.Text) Then
            MsgBox("Message Sent")
        Else
            MsgBox("Error sending message, incorrect COM")
        End If
    End Sub
End Class