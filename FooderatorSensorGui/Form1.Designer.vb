<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FoodGui
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BtnScanPort = New System.Windows.Forms.Button()
        Me.CmbPorts = New System.Windows.Forms.ComboBox()
        Me.baudlabel = New System.Windows.Forms.Label()
        Me.CmbBaudRate = New System.Windows.Forms.ComboBox()
        Me.BtnConnect = New System.Windows.Forms.Button()
        Me.BtnDisconnect = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pHText = New System.Windows.Forms.TextBox()
        Me.HumidityText = New System.Windows.Forms.TextBox()
        Me.TempText = New System.Windows.Forms.TextBox()
        Me.SerialReadBox = New System.Windows.Forms.RichTextBox()
        Me.ECText = New System.Windows.Forms.TextBox()
        Me.Dht11Text = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SensorData = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TimerDataGrid = New System.Windows.Forms.Timer(Me.components)
        Me.BtnStartRecord = New System.Windows.Forms.Button()
        Me.BtnStopRecord = New System.Windows.Forms.Button()
        Me.BtnDataGridClear = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ProgressBarProgress = New System.Windows.Forms.ProgressBar()
        Me.BtnSavetoEXL = New System.Windows.Forms.Button()
        Me.RowNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Temperature = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Humidity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SensorData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnScanPort
        '
        Me.BtnScanPort.Location = New System.Drawing.Point(12, 31)
        Me.BtnScanPort.Name = "BtnScanPort"
        Me.BtnScanPort.Size = New System.Drawing.Size(75, 23)
        Me.BtnScanPort.TabIndex = 0
        Me.BtnScanPort.Text = "Scan Port"
        Me.BtnScanPort.UseVisualStyleBackColor = True
        '
        'CmbPorts
        '
        Me.CmbPorts.FormattingEnabled = True
        Me.CmbPorts.Location = New System.Drawing.Point(163, 31)
        Me.CmbPorts.Name = "CmbPorts"
        Me.CmbPorts.Size = New System.Drawing.Size(121, 21)
        Me.CmbPorts.TabIndex = 1
        '
        'baudlabel
        '
        Me.baudlabel.AutoSize = True
        Me.baudlabel.Location = New System.Drawing.Point(98, 61)
        Me.baudlabel.Name = "baudlabel"
        Me.baudlabel.Size = New System.Drawing.Size(64, 13)
        Me.baudlabel.TabIndex = 2
        Me.baudlabel.Text = "Baud Rate :"
        '
        'CmbBaudRate
        '
        Me.CmbBaudRate.FormattingEnabled = True
        Me.CmbBaudRate.Items.AddRange(New Object() {"110", "300", "600", "1200", "2400", "4800", "9600", "19200", "115200"})
        Me.CmbBaudRate.Location = New System.Drawing.Point(163, 58)
        Me.CmbBaudRate.Name = "CmbBaudRate"
        Me.CmbBaudRate.Size = New System.Drawing.Size(121, 21)
        Me.CmbBaudRate.TabIndex = 3
        '
        'BtnConnect
        '
        Me.BtnConnect.Location = New System.Drawing.Point(12, 60)
        Me.BtnConnect.Name = "BtnConnect"
        Me.BtnConnect.Size = New System.Drawing.Size(75, 23)
        Me.BtnConnect.TabIndex = 4
        Me.BtnConnect.Text = "Connect"
        Me.BtnConnect.UseVisualStyleBackColor = True
        '
        'BtnDisconnect
        '
        Me.BtnDisconnect.Location = New System.Drawing.Point(12, 60)
        Me.BtnDisconnect.Name = "BtnDisconnect"
        Me.BtnDisconnect.Size = New System.Drawing.Size(75, 23)
        Me.BtnDisconnect.TabIndex = 5
        Me.BtnDisconnect.Text = "Disconnect"
        Me.BtnDisconnect.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(14, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 8
        '
        'Timer1
        '
        '
        'pHText
        '
        Me.pHText.Location = New System.Drawing.Point(537, 11)
        Me.pHText.Name = "pHText"
        Me.pHText.Size = New System.Drawing.Size(103, 20)
        Me.pHText.TabIndex = 12
        '
        'HumidityText
        '
        Me.HumidityText.Location = New System.Drawing.Point(537, 89)
        Me.HumidityText.Name = "HumidityText"
        Me.HumidityText.Size = New System.Drawing.Size(103, 20)
        Me.HumidityText.TabIndex = 13
        '
        'TempText
        '
        Me.TempText.Location = New System.Drawing.Point(537, 63)
        Me.TempText.Name = "TempText"
        Me.TempText.Size = New System.Drawing.Size(103, 20)
        Me.TempText.TabIndex = 14
        '
        'SerialReadBox
        '
        Me.SerialReadBox.Location = New System.Drawing.Point(646, 8)
        Me.SerialReadBox.Name = "SerialReadBox"
        Me.SerialReadBox.Size = New System.Drawing.Size(184, 101)
        Me.SerialReadBox.TabIndex = 15
        Me.SerialReadBox.Text = ""
        '
        'ECText
        '
        Me.ECText.Location = New System.Drawing.Point(537, 40)
        Me.ECText.Name = "ECText"
        Me.ECText.Size = New System.Drawing.Size(103, 20)
        Me.ECText.TabIndex = 16
        '
        'Dht11Text
        '
        Me.Dht11Text.Location = New System.Drawing.Point(537, 112)
        Me.Dht11Text.Name = "Dht11Text"
        Me.Dht11Text.Size = New System.Drawing.Size(103, 20)
        Me.Dht11Text.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(453, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "DHT11 Status:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(507, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "pH:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(424, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Electric Conductivity:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(458, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Temperature: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(481, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Humidity:"
        '
        'SensorData
        '
        Me.SensorData.AllowUserToOrderColumns = True
        Me.SensorData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SensorData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SensorData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RowNumber, Me.pH, Me.EC, Me.Temperature, Me.Humidity, Me.DateTime})
        Me.SensorData.Location = New System.Drawing.Point(341, 138)
        Me.SensorData.Name = "SensorData"
        Me.SensorData.Size = New System.Drawing.Size(489, 150)
        Me.SensorData.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(103, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "COM Port :"
        '
        'TimerDataGrid
        '
        '
        'BtnStartRecord
        '
        Me.BtnStartRecord.Location = New System.Drawing.Point(0, 19)
        Me.BtnStartRecord.Name = "BtnStartRecord"
        Me.BtnStartRecord.Size = New System.Drawing.Size(123, 23)
        Me.BtnStartRecord.TabIndex = 0
        Me.BtnStartRecord.Text = "Start Recording Data"
        Me.BtnStartRecord.UseVisualStyleBackColor = True
        '
        'BtnStopRecord
        '
        Me.BtnStopRecord.Location = New System.Drawing.Point(129, 19)
        Me.BtnStopRecord.Name = "BtnStopRecord"
        Me.BtnStopRecord.Size = New System.Drawing.Size(126, 23)
        Me.BtnStopRecord.TabIndex = 1
        Me.BtnStopRecord.Text = "Stop Recording Data"
        Me.BtnStopRecord.UseVisualStyleBackColor = True
        '
        'BtnDataGridClear
        '
        Me.BtnDataGridClear.Location = New System.Drawing.Point(0, 48)
        Me.BtnDataGridClear.Name = "BtnDataGridClear"
        Me.BtnDataGridClear.Size = New System.Drawing.Size(255, 23)
        Me.BtnDataGridClear.TabIndex = 2
        Me.BtnDataGridClear.Text = "Clear Data Grid"
        Me.BtnDataGridClear.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnDataGridClear)
        Me.GroupBox1.Controls.Add(Me.BtnStartRecord)
        Me.GroupBox1.Controls.Add(Me.BtnStopRecord)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 138)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 73)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Control"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ProgressBarProgress)
        Me.GroupBox2.Controls.Add(Me.BtnSavetoEXL)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 217)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(259, 71)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Export"
        '
        'ProgressBarProgress
        '
        Me.ProgressBarProgress.Location = New System.Drawing.Point(3, 48)
        Me.ProgressBarProgress.Name = "ProgressBarProgress"
        Me.ProgressBarProgress.Size = New System.Drawing.Size(250, 23)
        Me.ProgressBarProgress.TabIndex = 1
        '
        'BtnSavetoEXL
        '
        Me.BtnSavetoEXL.Location = New System.Drawing.Point(3, 16)
        Me.BtnSavetoEXL.Name = "BtnSavetoEXL"
        Me.BtnSavetoEXL.Size = New System.Drawing.Size(250, 40)
        Me.BtnSavetoEXL.TabIndex = 0
        Me.BtnSavetoEXL.Text = "Save To Excel"
        Me.BtnSavetoEXL.UseVisualStyleBackColor = True
        '
        'RowNumber
        '
        Me.RowNumber.HeaderText = "Row"
        Me.RowNumber.Name = "RowNumber"
        '
        'pH
        '
        Me.pH.HeaderText = "pH"
        Me.pH.Name = "pH"
        '
        'EC
        '
        Me.EC.HeaderText = "EC"
        Me.EC.Name = "EC"
        '
        'Temperature
        '
        Me.Temperature.HeaderText = "Temperature"
        Me.Temperature.Name = "Temperature"
        '
        'Humidity
        '
        Me.Humidity.HeaderText = "Humidity"
        Me.Humidity.Name = "Humidity"
        '
        'DateTime
        '
        Me.DateTime.HeaderText = "Date/Time"
        Me.DateTime.Name = "DateTime"
        '
        'FoodGui
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(864, 357)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SensorData)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Dht11Text)
        Me.Controls.Add(Me.ECText)
        Me.Controls.Add(Me.SerialReadBox)
        Me.Controls.Add(Me.TempText)
        Me.Controls.Add(Me.HumidityText)
        Me.Controls.Add(Me.pHText)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.BtnConnect)
        Me.Controls.Add(Me.CmbBaudRate)
        Me.Controls.Add(Me.baudlabel)
        Me.Controls.Add(Me.CmbPorts)
        Me.Controls.Add(Me.BtnScanPort)
        Me.Controls.Add(Me.BtnDisconnect)
        Me.Name = "FoodGui"
        Me.Text = "."
        CType(Me.SensorData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnScanPort As Button
    Friend WithEvents CmbPorts As ComboBox
    Friend WithEvents baudlabel As Label
    Friend WithEvents CmbBaudRate As ComboBox
    Friend WithEvents BtnConnect As Button
    Friend WithEvents BtnDisconnect As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pHText As TextBox
    Friend WithEvents HumidityText As TextBox
    Friend WithEvents TempText As TextBox
    Friend WithEvents SerialReadBox As RichTextBox
    Friend WithEvents ECText As TextBox
    Friend WithEvents Dht11Text As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SensorData As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents TimerDataGrid As Timer
    Friend WithEvents BtnStartRecord As Button
    Friend WithEvents BtnStopRecord As Button
    Friend WithEvents BtnDataGridClear As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ProgressBarProgress As ProgressBar
    Friend WithEvents BtnSavetoEXL As Button
    Friend WithEvents RowNumber As DataGridViewTextBoxColumn
    Friend WithEvents pH As DataGridViewTextBoxColumn
    Friend WithEvents EC As DataGridViewTextBoxColumn
    Friend WithEvents Temperature As DataGridViewTextBoxColumn
    Friend WithEvents Humidity As DataGridViewTextBoxColumn
    Friend WithEvents DateTime As DataGridViewTextBoxColumn
End Class
