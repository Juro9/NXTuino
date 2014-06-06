using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using ZedGraph;
using System.Collections;
using System.IO.Ports;



namespace GUI
{
    public partial class Form1 : Form
    {


        Hashtable hashtable = new Hashtable();
        Graph graph1;
        Graph pidGraph;
        string lineRecieved = "";
        string[] ports = SerialPort.GetPortNames();

        public Form1()
        {
            InitializeComponent();


            foreach (string s in ports) comboBox_Comports.Items.Add(s);

            hashtable.Add("Roll", 0);
            hashtable.Add("Pitch", 0);
            hashtable.Add("Yaw", 0);
            hashtable.Add("P", 0);
            hashtable.Add("I", 0);
            hashtable.Add("D", 0);
            hashtable.Add("setpoint", 0);
            hashtable.Add("pT", 0);
            hashtable.Add("iT", 0);
            hashtable.Add("dT", 0);

            if (!serialPort1.IsOpen)
                btn_serialDisconnect.Enabled = false;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            graph1 = new Graph(zedGraphControl1, "IMU", "Time", "Roll", "Roll", "Pitch", "Yaw");

            groupBox_graph1.Text = "Graph IMU:";
            pidGraph = new Graph(zedGraphControl2, "PID", "Time", "P,I,D", "pTerm", "iTerm", "dTerm");


            timer1.Start();


        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string line;
            try
            {
                line = serialPort1.ReadLine();
                this.BeginInvoke(new LineReceivedEvent(LineReceived), line);
            }
            catch (Exception ex) { }
        }

        private delegate void LineReceivedEvent(string line);

        private void lb_writeSerialOut(TextBox b)
        {
            b.AppendText(lineRecieved.ToString());
            b.AppendText(Environment.NewLine);
        }

        private void LineReceived(string line)
        {

            if (!line.Contains("?") && line != "\r" && line != "" && !line.Contains(",")) 
            {
                textBox_SerialPrint.AppendText(line.ToString());
                textBox_SerialPrint.AppendText(Environment.NewLine);
            }
            if (!line.Contains(","))
            {

            }
            else
            {
                string[] dataSplitedGroups = null;
                string[] dataSplitedValues;

                dataSplitedGroups = line.Trim().Split(',');

                foreach (string s in dataSplitedGroups)
                {
                    dataSplitedValues = s.Split('/');
                    if (hashtable.Contains(dataSplitedValues[0]))
                    {
                        double valDouble;
                        try
                        {
                            string number = dataSplitedValues[1];
                            valDouble = double.Parse(number, System.Globalization.CultureInfo.InvariantCulture);
                            hashtable[dataSplitedValues[0]] = valDouble;
                        }
                        catch (Exception ex) { }

                    }
                }

                textBox_p.Text = hashtable["P"].ToString();
                textBox_i.Text = hashtable["I"].ToString();
                textBox_d.Text = hashtable["D"].ToString();
                textBox_pTerm.Text = hashtable["pT"].ToString();
                textBox_iTerm.Text = hashtable["iT"].ToString();
                textBox_dTerm.Text = hashtable["dT"].ToString();

            }

        }

        private void setCheckBoxValue()
        {
            if (checkBox_roll.Checked)
            {
                this.graph1.setValue1(Convert.ToDouble(hashtable["Roll"]));
                textBox_graphRoll.Visible = true;
                textBox_graphRoll.Text = Convert.ToDouble(hashtable["Roll"]).ToString();
            }
            else textBox_graphRoll.Visible = false;
            if (checkBox_pitch.Checked)
            {
                this.graph1.setValue2(Convert.ToDouble(hashtable["Pitch"]));
                textBox_graphPitch.Visible = true;
                textBox_graphPitch.Text = Convert.ToDouble(hashtable["Pitch"]).ToString();
            }
            else textBox_graphPitch.Visible = false;
            if (checkBox_yaw.Checked)
            {
                this.graph1.setValue3(Convert.ToDouble(hashtable["Yaw"]));
                textBox__graphYaw.Visible = true;
                textBox__graphYaw.Text = Convert.ToDouble(hashtable["Yaw"]).ToString();
            }
            else textBox__graphYaw.Visible = false;


            if (checkBox_pTerm.Checked)
            {
                this.pidGraph.setValue1(Convert.ToDouble(hashtable["pT"]));
                textBox_graphpTerm.Visible = true;
                textBox_graphpTerm.Text = Convert.ToDouble(hashtable["pT"]).ToString();
            }
            else textBox_graphpTerm.Visible = false;
            if (checkBox_iTerm.Checked)
            {
                this.pidGraph.setValue2(Convert.ToDouble(hashtable["iT"]));
                textBox_graphiTerm.Visible = true;
                textBox_graphiTerm.Text = Convert.ToDouble(hashtable["iT"]).ToString();
            }
            else textBox_graphiTerm.Visible = false;

            if (checkBox_dTerm.Checked)
            {
                this.pidGraph.setValue3(Convert.ToDouble(hashtable["dT"]));
                textBox_graphdTerm.Visible = true;
                textBox_graphdTerm.Text = Convert.ToDouble(hashtable["dT"]).ToString();
            }
            else textBox_graphdTerm.Visible = false;
            textBox_p.Text = hashtable["P"].ToString();
            textBox_i.Text = hashtable["I"].ToString();
            textBox_d.Text = hashtable["D"].ToString();
            textBox_SetPoint.Text = hashtable["setpoint"].ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            
            if (serialPort1.IsOpen)
            {
                lb_connectionStatus.Text = "Connected";
                btn_serialDisconnect.Enabled = true;
                btn_ConnectSerial.Enabled = false;
                setCheckBoxValue();
                attitudeIndicatorInstrumentControl1.SetAttitudeIndicatorParameters(Convert.ToDouble(hashtable["Pitch"]), Convert.ToDouble(hashtable["Roll"]));
                headingIndicatorInstrumentControl1.SetHeadingIndicatorParameters(Convert.ToInt32(hashtable["Yaw"])+180);
            }
        }

        private void btn_ConnectSerial_Click(object sender, EventArgs e)
        {
            String comPort = Convert.ToString(comboBox_Comports.SelectedItem);
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.DtrEnable = true;
                    serialPort1.PortName = comPort;
                    serialPort1.Open();
                    serialPort1.DataReceived += serialPort1_DataReceived;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to connect: " + ex.Message);
            }
        }

        private void btn_serialDisconnect_Click(object sender, EventArgs e)
        {
            textBox_SerialPrint.Clear();
            btn_ConnectSerial.Enabled = true;
            btn_serialDisconnect.Enabled = false; 
            serialPort1.Close();
            lb_connectionStatus.Text = "Disconnected";
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            Close();
        }

        private void comboBoxComports_Click(object sender, EventArgs e)
        {
            comboBox_Comports.Items.Clear();
            ports = null;
            ports = SerialPort.GetPortNames();
            foreach (string s in ports) comboBox_Comports.Items.Add(s);
        }

        private void numericUpDown_P_ValueChanged(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                string dataSend = "";

                dataSend += "P" + (Convert.ToDouble(numericUpDown_P.Value)*10).ToString();
                serialPort1.WriteLine(dataSend.ToString());


            }
        }

        private void numericUpDown_I_ValueChanged(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                string dataSend = "";

                dataSend += "I" + (Convert.ToDouble(numericUpDown_I.Value) * 10).ToString();
                serialPort1.WriteLine(dataSend.ToString());


            }
        }

        private void numericUpDown_D_ValueChanged(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                string dataSend = "";

                dataSend += "D" + (Convert.ToDouble(numericUpDown_D.Value) * 10).ToString();
                serialPort1.WriteLine(dataSend.ToString());


            }
        }

        private void numericUpDown_SetPoint_ValueChanged(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                string dataSend = "";

                dataSend += "S" + (Convert.ToDouble(numericUpDown_SetPoint.Value) * 10).ToString();
                serialPort1.WriteLine(dataSend.ToString());


            }
        }



    }
}
