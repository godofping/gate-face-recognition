Imports AForge.Video.DirectShow

Public Class frmSettingsCamera

    Dim filterInfoCollections As FilterInfoCollection
    Dim setting As New Setting

    Private Sub LoadCB()

        filterInfoCollections = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        For Each filterinfo As FilterInfo In filterInfoCollections
            cbCameraEntrance.Items.Add(filterinfo.Name)
            cbCameraExit.Items.Add(filterinfo.Name)
        Next

        Try
            cbCameraEntrance.SelectedIndex = 0
            cbCameraExit.SelectedIndex = 0
        Catch ex As Exception
        End Try

    End Sub

    Private Sub GetData()
        setting = setting.Fetch(setting)
        lblCameraEntrance.Text = "Current Value: " & setting._Camera_entrance
        lblCameraExit.Text = "Current Value: " & setting._Camera_exit
    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCB()
        GetData()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        setting = setting.Fetch(setting)
        setting._Camera_entrance = cbCameraEntrance.SelectedIndex
        setting._Camera_exit = cbCameraExit.SelectedIndex
        If setting.Update(setting) Then
            MsgBox("Success")
            GetData()
        Else
            MsgBox("Failed")
        End If

    End Sub
End Class