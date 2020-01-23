Imports System.IO
Imports System.IO.Ports
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Linq
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports Microsoft.Office.core
Imports Excel = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
Imports Microsoft.Office.Interop
Imports System.Xml.XPath
Imports System.Data
Imports System.Xml



Public Class FoodGui
    Dim value1 As Decimal
    Dim value2 As Decimal
    Dim value3 As Integer
    Dim value4 As Integer

    Dim FilePathAndName As String
    Dim Limit As Integer = 10

    Private Sub FoodGui_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        SerialPort1.ReadTimeout = 2000

        BtnConnect.Enabled = False
        BtnConnect.BringToFront()

        BtnDisconnect.Enabled = False
        BtnDisconnect.SendToBack()
        CmbBaudRate.SelectedItem = "9600"





    End Sub

    Private Sub BtnConnect_Click(sender As Object, e As EventArgs) Handles BtnConnect.Click
        BtnConnect.Enabled = False
        BtnConnect.SendToBack()

        SerialPort1.BaudRate = CmbBaudRate.SelectedItem
        SerialPort1.PortName = CmbPorts.SelectedItem
        SerialPort1.Open()
        Timer1.Start()
        TimerDataGrid.Start()

        BtnDisconnect.Enabled = True
        BtnDisconnect.BringToFront()


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim s As String

        s = SerialReadBox.Text + "," + "," + "," + "," + "," + ","

        Dim somestring() As String

        somestring = s.Split(New Char() {","c})

        pHText.Text = somestring(2)
        Try
            value1 = Convert.ToDecimal(pHText.Text)
        Catch ex As Exception
            SerialReadBox.Text = ""
        End Try

        ECText.Text = somestring(3)
        Try
            value2 = Convert.ToDecimal(ECText.Text)
        Catch ex As Exception
            SerialReadBox.Text = ""
        End Try

        TempText.Text = somestring(4)
        Try
            value3 = Convert.ToDecimal(TempText.Text)
        Catch ex As Exception
            SerialReadBox.Text = ""
        End Try

        HumidityText.Text = somestring(5)
        Try
            value4 = Convert.ToDecimal(HumidityText.Text)
        Catch ex As Exception
            SerialReadBox.Text = ""
        End Try
        Dht11Text.Text = somestring(1)
        SerialReadBox.Text = ""


    End Sub

    Private Sub BtnScanPort_Click(sender As Object, e As EventArgs) Handles BtnScanPort.Click
        CmbPorts.Items.Clear()
        Dim myPort As Array
        Dim i As Integer
        myPort = IO.Ports.SerialPort.GetPortNames()
        CmbPorts.Items.AddRange(myPort)
        i = CmbPorts.Items.Count
        i = i - i
        Try
            CmbPorts.SelectedIndex = i
        Catch ex As Exception
            Dim result As DialogResult
            result = MessageBox.Show("com port not detected", "WARNING!!!", MessageBoxButtons.OK)
            CmbPorts.Text = ""
            CmbPorts.Items.Clear()
            Call FoodGui_Load(Me, e)
        End Try
        BtnConnect.Enabled = True
        BtnConnect.BringToFront()
        CmbPorts.DroppedDown = True

    End Sub

    Private Sub BtnDisconnect_Click(sender As Object, e As EventArgs) Handles BtnDisconnect.Click
        BtnDisconnect.Enabled = False
        BtnDisconnect.SendToBack()

        Timer1.Stop()
        TimerDataGrid.Stop()

        BtnSavetoEXL.Enabled = True
        BtnStopRecord.Enabled = False

        BtnConnect.Enabled = True
        BtnConnect.BringToFront()

        SerialPort1.Close()
    End Sub

    Private Sub DataReceived(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived

        Try
            Dim mydata As String = ""
            mydata = SerialPort1.ReadExisting()

            If SerialReadBox.InvokeRequired Then
                SerialReadBox.Invoke(DirectCast(Sub() SerialReadBox.Text &= mydata, MethodInvoker))
            Else
                SerialReadBox.Text &= mydata
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub HumidityText_TextChanged(sender As Object, e As EventArgs) Handles HumidityText.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles SensorData.CellContentClick

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub BtnStartRecord_Click(sender As Object, e As EventArgs) Handles BtnStartRecord.Click
        BtnStartRecord.Enabled = False
        BtnStopRecord.Enabled = True
        BtnSavetoEXL.Enabled = False
        TimerDataGrid.Start()
    End Sub

    Private Sub BtnStopRecord_Click(sender As Object, e As EventArgs) Handles BtnStopRecord.Click
        BtnStartRecord.Enabled = True
        BtnStopRecord.Enabled = False
        BtnSavetoEXL.Enabled = True
        TimerDataGrid.Stop()

    End Sub

    Private Sub BtnDataGridClear_Click(sender As Object, e As EventArgs) Handles BtnDataGridClear.Click
        SensorData.Rows.Clear()

    End Sub

    Private Sub BtnSavetoEXL_Click(sender As Object, e As EventArgs) Handles BtnSavetoEXL.Click
        BtnSavetoEXL.Enabled = False
        BtnStartRecord.Enabled = False
        ProgressBarProgress.Visible = True
        ProgressBarProgress.Value = 1

        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkbook As Microsoft.Office.Interop.Excel.Workbook
        Dim XlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        ProgressBarProgress.Value = 3

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkbook = xlApp.Workbooks.Add()
        XlWorkSheet = xlWorkbook.Sheets("sheet1")

        ProgressBarProgress.Value = 5

        For i = 0 To SensorData.RowCount - 2
            For j = 0 To SensorData.ColumnCount - 1
                For k As Integer = 1 To SensorData.Columns.Count
                    XlWorkSheet.Cells(1, k) = SensorData.Columns(k - 1).HeaderText
                    XlWorkSheet.Cells(1 + 2, j + 1) = SensorData(j, i).Value.ToString()
                Next
            Next
        Next
        ProgressBarProgress.Value = 8

        FilePathAndName = Application.StartupPath & "\" & Now.Day & "-" & Now.Month & "-" & Now.Year & ".xlsx"
        If File.Exists(FilePathAndName) Then File.Delete(FilePathAndName)

        XlWorkSheet.SaveAs(FilePathAndName)
        xlWorkbook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkbook)
        releaseObject(XlWorkSheet)

        ProgressBarProgress.Value = 10

        MsgBox("Successfully saved" & vbCrLf & "File are saved at : " & FilePathAndName, MsgBoxStyle.Information, "Information")

        ProgressBarProgress.Visible = False

        Process.Start(FilePathAndName)

        BtnSavetoEXL.Enabled = True
        BtnStartRecord.Enabled = True

    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub TimerDataGrid_Tick(sender As Object, e As EventArgs) Handles TimerDataGrid.Tick
        Dim value1_Log, value2_Log, value3_Log, value4_Log As String
        Dim DT As DateTime = Now

        value1_Log = Mid(value1, 3, value1)
        value2_Log = Mid(value2, 3, value2)
        value3_Log = Mid(value3, 3, value3)
        value4_Log = Mid(value4, 3, value4)

        SensorData.Rows.Add(New String() {SensorData.RowCount, value1, value2, value3, value4, DT.ToLongTimeString, DT.ToString("dd-MM-yyyy")})

    End Sub
End Class
