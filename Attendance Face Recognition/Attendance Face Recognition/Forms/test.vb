Imports System.IO.Ports

Public Class test
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SerialPort As New System.IO.Ports.SerialPort()
        Dim bol As Boolean

        If SerialPort.IsOpen Then
            SerialPort.Close()
        End If

        SerialPort.PortName = "COM18"
        SerialPort.BaudRate = 9600
        SerialPort.Parity = Parity.None
        SerialPort.StopBits = StopBits.One
        SerialPort.DataBits = 8
        SerialPort.Handshake = Handshake.RequestToSend
        SerialPort.DtrEnable = True
        SerialPort.RtsEnable = True
        SerialPort.NewLine = vbCrLf


        Try
            SerialPort.Open()
        Catch ex As Exception
            bol = False
        End Try

        If SerialPort.IsOpen() Then
            SerialPort.Write("AT+CMGR=3D1" & vbCrLf)
            MsgBox(SerialPort.ReadExisting)

            SerialPort.Close()

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Helper.SendSMS("COM18", "8080", "c10 status")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim SerialPort As New System.IO.Ports.SerialPort()
        Dim bol As Boolean

        If SerialPort.IsOpen Then
            SerialPort.Close()
        End If

        SerialPort.PortName = "COM18"
        SerialPort.BaudRate = 9600
        SerialPort.Parity = Parity.None
        SerialPort.StopBits = StopBits.One
        SerialPort.DataBits = 8
        SerialPort.Handshake = Handshake.RequestToSend
        SerialPort.DtrEnable = True
        SerialPort.RtsEnable = True
        SerialPort.NewLine = vbCrLf


        Try
            SerialPort.Open()
        Catch ex As Exception
            bol = False
        End Try

        If SerialPort.IsOpen() Then
            SerialPort.Write("AT+CMGD=1,4" & vbCrLf)
            MsgBox(SerialPort.ReadLine)

            SerialPort.Close()

        End If
    End Sub
End Class