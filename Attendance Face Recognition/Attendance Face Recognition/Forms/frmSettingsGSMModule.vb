Imports System.IO.Ports

Public Class frmSettingsGSMModule

    Dim setting As New Setting

    Private Sub LoadCB()

        Dim ports As String() = SerialPort.GetPortNames()

        For Each comport As String In ports
            cbBroadbandCom.Items.Add(comport)
        Next

        Try
            cbBroadbandCom.SelectedIndex = 0
        Catch ex As Exception

        End Try

    End Sub

    Private Sub GetData()
        setting = setting.Fetch(setting)
        lblBroadbandCom.Text = "Current Value: " & setting._Broadband_com
    End Sub

    Private Sub frmSettingsGSMModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCB()
        GetData()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        setting = setting.Fetch(setting)
        setting._Broadband_com = cbBroadbandCom.Text
        If setting.Update(setting) Then
            MsgBox("Success")
            GetData()
        Else
            MsgBox("Failed")
        End If
    End Sub


End Class