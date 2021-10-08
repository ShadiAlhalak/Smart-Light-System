using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;

namespace arduino
{
    public partial class frmLight : Form
    {
        #region Variable
        int i = 0;
        byte[] data = new byte[3];
        List<int> Xlist = new List<int> ();
        List<int> Ylist = new List<int>();
        List<int> Pidlist = new List<int>();
        #endregion

        #region Constructor

        public frmLight()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                cboPort.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                if (cboPort.Items.Count > 0)
                { cboPort.SelectedIndex = 0; }
            }
            catch { }
        }

        private void cboPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = cboPort.Text;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            try
            { 
            byte pwm;
            pwm = Convert.ToByte(TBLight.Value);
            data[0] = pwm;
            serialPort1.Write(data, 0, 1);
            lblLight.Text = pwm.ToString();
            }
            catch { }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                }
            }
            catch { }
        }

        private void btnDisConnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }

        private void btnFixConnection_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    serialPort1.Open();
                }
                else
                {
                    serialPort1.Open();
                }
            }
            catch { }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try { 
            serialPort1.ReadExisting();
            timer1.Enabled = true;
            }
            catch { }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnPid_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false || timer2.Enabled == false)
            {
                timer1.Enabled = true;
                timer2.Enabled = true;
            }
            else
            {
                timer2.Enabled = false;
            }
        }

        private void btnDraw_Click_1(object sender, EventArgs e)
        {
            timer3.Enabled = true;
        }

        private void btnRedraw_Click(object sender, EventArgs e)
        {
            i = 0;
            Xlist = new List<int>();
            Ylist = new List<int>();
            Pidlist = new List<int>();
            timer3.Enabled = true;
        }

        private void btnStopDraw_Click(object sender, EventArgs e)
        {
            timer3.Enabled = false;
        }

        #endregion

        #region Timers

        private void timer1_Tick(object sender, EventArgs e)
        {
            try { 
            txtSensValue.Text = serialPort1.ReadLine();
            txtSensValue.Text = txtSensValue.Text.Trim();
            }
            catch { }
            //old Read
            //serialPort1.ReadLine();
            //textBox1.Text = serialPort1.ReadExisting();
            //textBox1.Text = textBox1.Text.Trim();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
     //       try
            {
                byte Cnst = Convert.ToByte(txtPidVal.Text);
                char[] a = txtSensValue.Text.ToCharArray();
                int sens=0;
                if (a.Length == 2)
                {
                    sens = Convert.ToInt16(a[0] + "" + a[1]);
                }
                else if (a.Length == 3)
                {
                    sens = Convert.ToInt16(a[0] + "" + a[1]+""+a[2]);
                }
                else if (a.Length==1)
                {
                    sens = Convert.ToInt16(a[0]);
                }
                //int sens = Convert.ToInt16(a[0] + "" + a[1]);
                sens = sens / 3;
                byte added;
                byte led = Convert.ToByte(TBLight.Value);
                if (sens > Cnst)
                {
                    added = Convert.ToByte(sens - Cnst);
                    led -= added;
                }
                else if (sens < Cnst)
                {
                    added = Convert.ToByte(Cnst - sens);
                    led += added;
                }
                data[0] = led;
                serialPort1.Write(data, 0, 1);
            }
          //  catch
            { }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            try
            {
                Xlist.Add(i);
                Ylist.Add(Convert.ToInt32(txtSensValue.Text));
                if (string.IsNullOrEmpty(txtPidVal.Text))
                { Pidlist.Add(0); }
                else
                {
                    Pidlist.Add(Convert.ToInt32(txtPidVal.Text));
                }
                chart.Series[0].Points.DataBindXY(Xlist.ToArray(), Ylist.ToArray());

                if (!string.IsNullOrEmpty(txtPidVal.Text)&& timer1.Enabled==true && timer2.Enabled ==true)
                {

                    chart.Series[1].Points.DataBindXY(Xlist.ToArray(), Pidlist  );
                }

            }
           catch { }
        }

        #endregion

    }
}