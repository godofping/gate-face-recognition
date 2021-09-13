Imports System.IO.Ports


Public Class test
    Dim str As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim bol As Boolean


        If SerialPort1.IsOpen Then
            SerialPort1.Close()
        End If

        SerialPort1.PortName = "COM18"
        SerialPort1.BaudRate = 9600
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.DataBits = 8
        SerialPort1.Handshake = Handshake.RequestToSend
        SerialPort1.DtrEnable = True
        SerialPort1.RtsEnable = True

        Try
            SerialPort1.Open()
        Catch ex As Exception
            bol = False
        End Try

        If SerialPort1.IsOpen() Then

            SerialPort1.WriteLine("AT")
            System.Threading.Thread.Sleep(500)
            'SerialPort1.WriteLine("AT+CMGF=1")
            'System.Threading.Thread.Sleep(500)

            TextBox1.Text = SerialPort1.ReadExisting()
            SerialPort1.Close()
        End If
    End Sub



End Class