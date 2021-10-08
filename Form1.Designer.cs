namespace arduino
{
    partial class frmLight
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.TBLight = new System.Windows.Forms.TrackBar();
            this.btnRead = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisConnect = new System.Windows.Forms.Button();
            this.txtSensValue = new System.Windows.Forms.TextBox();
            this.txtPidVal = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblLight = new System.Windows.Forms.Label();
            this.GrpConnection = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPort = new System.Windows.Forms.Label();
            this.btnFixConnection = new System.Windows.Forms.Button();
            this.grpSensor = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblValue = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStartDraw = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.GrpLight = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStopDraw = new System.Windows.Forms.Button();
            this.btnRedraw = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TBLight)).BeginInit();
            this.GrpConnection.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grpSensor.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.GrpLight.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.ReadTimeout = 2000;
            this.serialPort1.WriteTimeout = 2000;
            // 
            // cboPort
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cboPort, 2);
            this.cboPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Location = new System.Drawing.Point(54, 3);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(150, 24);
            this.cboPort.TabIndex = 1;
            this.cboPort.SelectedIndexChanged += new System.EventHandler(this.cboPort_SelectedIndexChanged);
            // 
            // TBLight
            // 
            this.TBLight.Location = new System.Drawing.Point(3, 3);
            this.TBLight.Maximum = 255;
            this.TBLight.Name = "TBLight";
            this.TBLight.Size = new System.Drawing.Size(424, 47);
            this.TBLight.TabIndex = 3;
            this.TBLight.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btnRead
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.btnRead, 2);
            this.btnRead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRead.Location = new System.Drawing.Point(3, 32);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(92, 32);
            this.btnRead.TabIndex = 5;
            this.btnRead.Text = "read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnConnect
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnConnect, 2);
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.Location = new System.Drawing.Point(3, 30);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(92, 32);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisConnect
            // 
            this.btnDisConnect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDisConnect.FlatAppearance.BorderSize = 0;
            this.btnDisConnect.Location = new System.Drawing.Point(101, 30);
            this.btnDisConnect.Name = "btnDisConnect";
            this.btnDisConnect.Size = new System.Drawing.Size(103, 32);
            this.btnDisConnect.TabIndex = 8;
            this.btnDisConnect.Text = "Disconnect";
            this.btnDisConnect.UseVisualStyleBackColor = true;
            this.btnDisConnect.Click += new System.EventHandler(this.btnDisConnect_Click);
            // 
            // txtSensValue
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txtSensValue, 2);
            this.txtSensValue.Location = new System.Drawing.Point(53, 3);
            this.txtSensValue.Name = "txtSensValue";
            this.txtSensValue.Size = new System.Drawing.Size(148, 24);
            this.txtSensValue.TabIndex = 9;
            // 
            // txtPidVal
            // 
            this.txtPidVal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPidVal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPidVal.Location = new System.Drawing.Point(3, 29);
            this.txtPidVal.Multiline = true;
            this.txtPidVal.Name = "txtPidVal";
            this.txtPidVal.Size = new System.Drawing.Size(97, 32);
            this.txtPidVal.TabIndex = 11;
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Location = new System.Drawing.Point(106, 29);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(98, 32);
            this.button9.TabIndex = 13;
            this.button9.Text = "PID";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.btnPid_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblLight
            // 
            this.lblLight.AutoSize = true;
            this.lblLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLight.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLight.Location = new System.Drawing.Point(433, 0);
            this.lblLight.Name = "lblLight";
            this.lblLight.Size = new System.Drawing.Size(60, 53);
            this.lblLight.TabIndex = 14;
            this.lblLight.Text = "0";
            this.lblLight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GrpConnection
            // 
            this.GrpConnection.Controls.Add(this.tableLayoutPanel1);
            this.GrpConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrpConnection.Location = new System.Drawing.Point(516, 8);
            this.GrpConnection.Name = "GrpConnection";
            this.GrpConnection.Size = new System.Drawing.Size(213, 126);
            this.GrpConnection.TabIndex = 15;
            this.GrpConnection.TabStop = false;
            this.GrpConnection.Text = "Connection";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.33645F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.66355F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.Controls.Add(this.lblPort, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboPort, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnConnect, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDisConnect, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnFixConnection, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(207, 103);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPort.Location = new System.Drawing.Point(3, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(45, 27);
            this.lblPort.TabIndex = 0;
            this.lblPort.Text = "Port";
            this.lblPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFixConnection
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnFixConnection, 3);
            this.btnFixConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFixConnection.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFixConnection.FlatAppearance.BorderSize = 0;
            this.btnFixConnection.ForeColor = System.Drawing.Color.Red;
            this.btnFixConnection.Location = new System.Drawing.Point(3, 68);
            this.btnFixConnection.Name = "btnFixConnection";
            this.btnFixConnection.Size = new System.Drawing.Size(201, 32);
            this.btnFixConnection.TabIndex = 9;
            this.btnFixConnection.Text = "Fix and refresh";
            this.btnFixConnection.UseVisualStyleBackColor = true;
            this.btnFixConnection.Click += new System.EventHandler(this.btnFixConnection_Click);
            // 
            // grpSensor
            // 
            this.grpSensor.Controls.Add(this.tableLayoutPanel2);
            this.grpSensor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSensor.Location = new System.Drawing.Point(516, 140);
            this.grpSensor.Name = "grpSensor";
            this.grpSensor.Size = new System.Drawing.Size(213, 90);
            this.grpSensor.TabIndex = 16;
            this.grpSensor.TabStop = false;
            this.grpSensor.Text = "Light sensor";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.45631F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.54369F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel2.Controls.Add(this.txtSensValue, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblValue, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnRead, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button1, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(207, 67);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblValue
            // 
            this.lblValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(3, 0);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(44, 29);
            this.lblValue.TabIndex = 10;
            this.lblValue.Text = "Value";
            this.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(101, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStartDraw
            // 
            this.btnStartDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStartDraw.Location = new System.Drawing.Point(3, 3);
            this.btnStartDraw.Name = "btnStartDraw";
            this.btnStartDraw.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStartDraw.Size = new System.Drawing.Size(97, 32);
            this.btnStartDraw.TabIndex = 20;
            this.btnStartDraw.Text = "Start";
            this.btnStartDraw.UseVisualStyleBackColor = true;
            this.btnStartDraw.Click += new System.EventHandler(this.btnDraw_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(516, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(213, 87);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PID";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.txtPidVal, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button9, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 20);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(207, 64);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label4, 2);
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Enter const light";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GrpLight
            // 
            this.GrpLight.Controls.Add(this.tableLayoutPanel4);
            this.GrpLight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrpLight.Location = new System.Drawing.Point(8, 351);
            this.GrpLight.Name = "GrpLight";
            this.GrpLight.Size = new System.Drawing.Size(502, 76);
            this.GrpLight.TabIndex = 18;
            this.GrpLight.TabStop = false;
            this.GrpLight.Text = "Light";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.87259F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.12741F));
            this.tableLayoutPanel4.Controls.Add(this.TBLight, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblLight, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 20);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(496, 53);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(8, 8);
            this.chart.Name = "chart";
            this.tableLayoutPanel5.SetRowSpan(this.chart, 4);
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Light";
            series1.YValuesPerPoint = 4;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Pid";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(502, 337);
            this.chart.TabIndex = 19;
            // 
            // timer3
            // 
            this.timer3.Interval = 500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.91758F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.08242F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel5.Controls.Add(this.GrpConnection, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.chart, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.grpSensor, 2, 2);
            this.tableLayoutPanel5.Controls.Add(this.groupBox3, 2, 3);
            this.tableLayoutPanel5.Controls.Add(this.groupBox1, 2, 4);
            this.tableLayoutPanel5.Controls.Add(this.GrpLight, 1, 5);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 7;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(738, 435);
            this.tableLayoutPanel5.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(516, 329);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel5.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(213, 98);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Draw";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.btnStartDraw, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnStopDraw, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnRedraw, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 20);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(207, 75);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // btnStopDraw
            // 
            this.btnStopDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStopDraw.Location = new System.Drawing.Point(106, 3);
            this.btnStopDraw.Name = "btnStopDraw";
            this.btnStopDraw.Size = new System.Drawing.Size(98, 32);
            this.btnStopDraw.TabIndex = 22;
            this.btnStopDraw.Text = "Stop";
            this.btnStopDraw.UseVisualStyleBackColor = true;
            this.btnStopDraw.Click += new System.EventHandler(this.btnStopDraw_Click);
            // 
            // btnRedraw
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.btnRedraw, 2);
            this.btnRedraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRedraw.Location = new System.Drawing.Point(3, 41);
            this.btnRedraw.Name = "btnRedraw";
            this.btnRedraw.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRedraw.Size = new System.Drawing.Size(201, 32);
            this.btnRedraw.TabIndex = 21;
            this.btnRedraw.Text = "ReDraw";
            this.btnRedraw.UseVisualStyleBackColor = true;
            this.btnRedraw.Click += new System.EventHandler(this.btnRedraw_Click);
            // 
            // frmLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 435);
            this.Controls.Add(this.tableLayoutPanel5);
            this.MaximumSize = new System.Drawing.Size(756, 482);
            this.MinimumSize = new System.Drawing.Size(756, 482);
            this.Name = "frmLight";
            this.Text = "Smart Light System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TBLight)).EndInit();
            this.GrpConnection.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grpSensor.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.GrpLight.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox cboPort;
        private System.Windows.Forms.TrackBar TBLight;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisConnect;
        private System.Windows.Forms.TextBox txtSensValue;
        private System.Windows.Forms.TextBox txtPidVal;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblLight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Button btnFixConnection;
        private System.Windows.Forms.GroupBox GrpConnection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox grpSensor;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GrpLight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button btnStartDraw;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btnRedraw;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStopDraw;
    }
}

