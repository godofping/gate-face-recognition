Public Class frmSettings

    Private Sub LoadCB()

        filterInfoCollections = New FilterInfoCollection(FilterCategory.VideoInputDevice)


        For Each filterinfo As FilterInfo In filterInfoCollections
            cbCamIN.Items.Add(filterinfo.Name)
            cbCamOut.Items.Add(filterinfo.Name)
        Next

        cbCamIN.SelectedIndex = 0
        cbCamOut.SelectedIndex = 0


        Dim ports As String() = SerialPort.GetPortNames()

        For Each comport As String In ports
            cbCom.Items.Add(comport)
        Next

        cbCom.SelectedIndex = 0
    End Sub
End Class