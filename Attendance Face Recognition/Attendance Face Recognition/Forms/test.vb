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



        Try
            SerialPort.Open()
        Catch ex As Exception
            bol = False
        End Try

        If SerialPort.IsOpen() Then
            SerialPort.WriteLine("AT+CMGF=1")
            SerialPort.WriteLine("AT+CMGL=" & Chr(34) & "REC READ" & Chr(34))
            TextBox1.Text = SerialPort.ReadExisting()
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim attendance As New Attendance
        attendance._Student_id = "2006"
        attendance._Attendance_type = "ENTRANCE"
        MsgBox(attendance.FetchByTypeAndTime(attendance, DateTime.Now.ToString("yyyy-MM-dd") & " 00:00:00.000", DateTime.Now.ToString("yyyy-MM-dd") & " 12:00:00.000").Rows.Count)

    End Sub
End Class