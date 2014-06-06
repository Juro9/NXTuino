namespace GUI
{
    partial class Form1
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
            System.Windows.Forms.TabControl tabControl1;
            this.IMU = new System.Windows.Forms.TabPage();
            this.headingIndicatorInstrumentControl1 = new AvionicsInstrumentControlDemo.HeadingIndicatorInstrumentControl();
            this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.label8 = new System.Windows.Forms.Label();
            this.attitudeIndicatorInstrumentControl1 = new AvionicsInstrumentControlDemo.AttitudeIndicatorInstrumentControl();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox_pTerm = new System.Windows.Forms.CheckBox();
            this.checkBox_iTerm = new System.Windows.Forms.CheckBox();
            this.checkBox_dTerm = new System.Windows.Forms.CheckBox();
            this.textBox_graphdTerm = new System.Windows.Forms.TextBox();
            this.textBox_graphiTerm = new System.Windows.Forms.TextBox();
            this.textBox_graphpTerm = new System.Windows.Forms.TextBox();
            this.groupBox_graph1 = new System.Windows.Forms.GroupBox();
            this.checkBox_roll = new System.Windows.Forms.CheckBox();
            this.checkBox_pitch = new System.Windows.Forms.CheckBox();
            this.checkBox_yaw = new System.Windows.Forms.CheckBox();
            this.textBox__graphYaw = new System.Windows.Forms.TextBox();
            this.textBox_graphPitch = new System.Windows.Forms.TextBox();
            this.textBox_graphRoll = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lb_d = new System.Windows.Forms.Label();
            this.lb_i = new System.Windows.Forms.Label();
            this.lb_p = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_SetPoint = new System.Windows.Forms.TextBox();
            this.numericUpDown_SetPoint = new System.Windows.Forms.NumericUpDown();
            this.textBox_p = new System.Windows.Forms.TextBox();
            this.textBox_dTerm = new System.Windows.Forms.TextBox();
            this.textBox_pTerm = new System.Windows.Forms.TextBox();
            this.numericUpDown_P = new System.Windows.Forms.NumericUpDown();
            this.textBox_iTerm = new System.Windows.Forms.TextBox();
            this.numericUpDown_I = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_D = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_i = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_d = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_SerialPrint = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_ConnectSerial = new System.Windows.Forms.Button();
            this.btn_serialDisconnect = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.lb_connectionStatus = new System.Windows.Forms.Label();
            this.comboBox_Comports = new System.Windows.Forms.ComboBox();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabControl1.SuspendLayout();
            this.IMU.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox_graph1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SetPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_P)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_I)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_D)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(this.IMU);
            tabControl1.Controls.Add(this.tabPage2);
            tabControl1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tabControl1.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            tabControl1.Location = new System.Drawing.Point(12, 46);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1115, 636);
            tabControl1.TabIndex = 2;
            // 
            // IMU
            // 
            this.IMU.BackColor = System.Drawing.Color.LightGray;
            this.IMU.Controls.Add(this.headingIndicatorInstrumentControl1);
            this.IMU.Controls.Add(this.zedGraphControl2);
            this.IMU.Controls.Add(this.label8);
            this.IMU.Controls.Add(this.attitudeIndicatorInstrumentControl1);
            this.IMU.Controls.Add(this.zedGraphControl1);
            this.IMU.Controls.Add(this.groupBox3);
            this.IMU.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IMU.Location = new System.Drawing.Point(4, 26);
            this.IMU.Name = "IMU";
            this.IMU.Padding = new System.Windows.Forms.Padding(3);
            this.IMU.Size = new System.Drawing.Size(1107, 606);
            this.IMU.TabIndex = 0;
            this.IMU.Text = "IMU";
            // 
            // headingIndicatorInstrumentControl1
            // 
            this.headingIndicatorInstrumentControl1.Location = new System.Drawing.Point(789, 303);
            this.headingIndicatorInstrumentControl1.Name = "headingIndicatorInstrumentControl1";
            this.headingIndicatorInstrumentControl1.Size = new System.Drawing.Size(302, 297);
            this.headingIndicatorInstrumentControl1.TabIndex = 19;
            this.headingIndicatorInstrumentControl1.Text = "headingIndicatorInstrumentControl1";
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.Location = new System.Drawing.Point(569, 6);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.ScrollGrace = 0D;
            this.zedGraphControl2.ScrollMaxX = 0D;
            this.zedGraphControl2.ScrollMaxY = 0D;
            this.zedGraphControl2.ScrollMaxY2 = 0D;
            this.zedGraphControl2.ScrollMinX = 0D;
            this.zedGraphControl2.ScrollMinY = 0D;
            this.zedGraphControl2.ScrollMinY2 = 0D;
            this.zedGraphControl2.Size = new System.Drawing.Size(532, 291);
            this.zedGraphControl2.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AccessibleName = "lb_axisValie";
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(724, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 15;
            // 
            // attitudeIndicatorInstrumentControl1
            // 
            this.attitudeIndicatorInstrumentControl1.Location = new System.Drawing.Point(486, 303);
            this.attitudeIndicatorInstrumentControl1.Name = "attitudeIndicatorInstrumentControl1";
            this.attitudeIndicatorInstrumentControl1.Size = new System.Drawing.Size(297, 297);
            this.attitudeIndicatorInstrumentControl1.TabIndex = 1;
            this.attitudeIndicatorInstrumentControl1.Text = "attitudeIndicatorInstrumentControl1";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraphControl1.BackColor = System.Drawing.Color.LightGray;
            this.zedGraphControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.zedGraphControl1.Location = new System.Drawing.Point(6, 6);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(557, 291);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox_graph1);
            this.groupBox3.Location = new System.Drawing.Point(6, 303);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(474, 297);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Graph Settings:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox_pTerm);
            this.groupBox4.Controls.Add(this.checkBox_iTerm);
            this.groupBox4.Controls.Add(this.checkBox_dTerm);
            this.groupBox4.Controls.Add(this.textBox_graphdTerm);
            this.groupBox4.Controls.Add(this.textBox_graphiTerm);
            this.groupBox4.Controls.Add(this.textBox_graphpTerm);
            this.groupBox4.Location = new System.Drawing.Point(245, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 134);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Graph 2:";
            // 
            // checkBox_pTerm
            // 
            this.checkBox_pTerm.AutoSize = true;
            this.checkBox_pTerm.Location = new System.Drawing.Point(6, 26);
            this.checkBox_pTerm.Name = "checkBox_pTerm";
            this.checkBox_pTerm.Size = new System.Drawing.Size(72, 21);
            this.checkBox_pTerm.TabIndex = 27;
            this.checkBox_pTerm.Text = "pTerm";
            this.checkBox_pTerm.UseVisualStyleBackColor = true;
            // 
            // checkBox_iTerm
            // 
            this.checkBox_iTerm.AutoSize = true;
            this.checkBox_iTerm.Location = new System.Drawing.Point(6, 59);
            this.checkBox_iTerm.Name = "checkBox_iTerm";
            this.checkBox_iTerm.Size = new System.Drawing.Size(72, 21);
            this.checkBox_iTerm.TabIndex = 26;
            this.checkBox_iTerm.Text = "iTerm";
            this.checkBox_iTerm.UseVisualStyleBackColor = true;
            // 
            // checkBox_dTerm
            // 
            this.checkBox_dTerm.AutoSize = true;
            this.checkBox_dTerm.Location = new System.Drawing.Point(6, 90);
            this.checkBox_dTerm.Name = "checkBox_dTerm";
            this.checkBox_dTerm.Size = new System.Drawing.Size(72, 21);
            this.checkBox_dTerm.TabIndex = 25;
            this.checkBox_dTerm.Text = "dTerm";
            this.checkBox_dTerm.UseVisualStyleBackColor = true;
            // 
            // textBox_graphdTerm
            // 
            this.textBox_graphdTerm.Location = new System.Drawing.Point(99, 86);
            this.textBox_graphdTerm.Name = "textBox_graphdTerm";
            this.textBox_graphdTerm.Size = new System.Drawing.Size(55, 25);
            this.textBox_graphdTerm.TabIndex = 24;
            this.textBox_graphdTerm.Visible = false;
            // 
            // textBox_graphiTerm
            // 
            this.textBox_graphiTerm.Location = new System.Drawing.Point(99, 55);
            this.textBox_graphiTerm.Name = "textBox_graphiTerm";
            this.textBox_graphiTerm.Size = new System.Drawing.Size(55, 25);
            this.textBox_graphiTerm.TabIndex = 23;
            this.textBox_graphiTerm.Visible = false;
            // 
            // textBox_graphpTerm
            // 
            this.textBox_graphpTerm.Location = new System.Drawing.Point(99, 24);
            this.textBox_graphpTerm.Name = "textBox_graphpTerm";
            this.textBox_graphpTerm.Size = new System.Drawing.Size(55, 25);
            this.textBox_graphpTerm.TabIndex = 22;
            this.textBox_graphpTerm.Visible = false;
            // 
            // groupBox_graph1
            // 
            this.groupBox_graph1.Controls.Add(this.checkBox_roll);
            this.groupBox_graph1.Controls.Add(this.checkBox_pitch);
            this.groupBox_graph1.Controls.Add(this.checkBox_yaw);
            this.groupBox_graph1.Controls.Add(this.textBox__graphYaw);
            this.groupBox_graph1.Controls.Add(this.textBox_graphPitch);
            this.groupBox_graph1.Controls.Add(this.textBox_graphRoll);
            this.groupBox_graph1.Location = new System.Drawing.Point(25, 24);
            this.groupBox_graph1.Name = "groupBox_graph1";
            this.groupBox_graph1.Size = new System.Drawing.Size(200, 134);
            this.groupBox_graph1.TabIndex = 21;
            this.groupBox_graph1.TabStop = false;
            this.groupBox_graph1.Text = "Graph 1:";
            // 
            // checkBox_roll
            // 
            this.checkBox_roll.AutoSize = true;
            this.checkBox_roll.Location = new System.Drawing.Point(6, 26);
            this.checkBox_roll.Name = "checkBox_roll";
            this.checkBox_roll.Size = new System.Drawing.Size(63, 21);
            this.checkBox_roll.TabIndex = 27;
            this.checkBox_roll.Text = "Roll";
            this.checkBox_roll.UseVisualStyleBackColor = true;
            // 
            // checkBox_pitch
            // 
            this.checkBox_pitch.AutoSize = true;
            this.checkBox_pitch.Location = new System.Drawing.Point(6, 59);
            this.checkBox_pitch.Name = "checkBox_pitch";
            this.checkBox_pitch.Size = new System.Drawing.Size(72, 21);
            this.checkBox_pitch.TabIndex = 26;
            this.checkBox_pitch.Text = "Pitch";
            this.checkBox_pitch.UseVisualStyleBackColor = true;
            // 
            // checkBox_yaw
            // 
            this.checkBox_yaw.AutoSize = true;
            this.checkBox_yaw.Location = new System.Drawing.Point(6, 90);
            this.checkBox_yaw.Name = "checkBox_yaw";
            this.checkBox_yaw.Size = new System.Drawing.Size(54, 21);
            this.checkBox_yaw.TabIndex = 25;
            this.checkBox_yaw.Text = "Yaw";
            this.checkBox_yaw.UseVisualStyleBackColor = true;
            // 
            // textBox__graphYaw
            // 
            this.textBox__graphYaw.Location = new System.Drawing.Point(99, 86);
            this.textBox__graphYaw.Name = "textBox__graphYaw";
            this.textBox__graphYaw.Size = new System.Drawing.Size(55, 25);
            this.textBox__graphYaw.TabIndex = 24;
            this.textBox__graphYaw.Visible = false;
            // 
            // textBox_graphPitch
            // 
            this.textBox_graphPitch.Location = new System.Drawing.Point(99, 55);
            this.textBox_graphPitch.Name = "textBox_graphPitch";
            this.textBox_graphPitch.Size = new System.Drawing.Size(55, 25);
            this.textBox_graphPitch.TabIndex = 23;
            this.textBox_graphPitch.Visible = false;
            // 
            // textBox_graphRoll
            // 
            this.textBox_graphRoll.Location = new System.Drawing.Point(99, 24);
            this.textBox_graphRoll.Name = "textBox_graphRoll";
            this.textBox_graphRoll.Size = new System.Drawing.Size(55, 25);
            this.textBox_graphRoll.TabIndex = 22;
            this.textBox_graphRoll.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.lb_d);
            this.tabPage2.Controls.Add(this.lb_i);
            this.tabPage2.Controls.Add(this.lb_p);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1107, 606);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Debug";
            // 
            // lb_d
            // 
            this.lb_d.AutoSize = true;
            this.lb_d.Location = new System.Drawing.Point(17, 104);
            this.lb_d.Name = "lb_d";
            this.lb_d.Size = new System.Drawing.Size(26, 17);
            this.lb_d.TabIndex = 12;
            this.lb_d.Text = "D:";
            // 
            // lb_i
            // 
            this.lb_i.AutoSize = true;
            this.lb_i.Location = new System.Drawing.Point(17, 76);
            this.lb_i.Name = "lb_i";
            this.lb_i.Size = new System.Drawing.Size(26, 17);
            this.lb_i.TabIndex = 11;
            this.lb_i.Text = "I:";
            // 
            // lb_p
            // 
            this.lb_p.AutoSize = true;
            this.lb_p.Location = new System.Drawing.Point(17, 47);
            this.lb_p.Name = "lb_p";
            this.lb_p.Size = new System.Drawing.Size(26, 17);
            this.lb_p.TabIndex = 10;
            this.lb_p.Text = "P:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_SetPoint);
            this.groupBox1.Controls.Add(this.numericUpDown_SetPoint);
            this.groupBox1.Controls.Add(this.textBox_p);
            this.groupBox1.Controls.Add(this.textBox_dTerm);
            this.groupBox1.Controls.Add(this.textBox_pTerm);
            this.groupBox1.Controls.Add(this.numericUpDown_P);
            this.groupBox1.Controls.Add(this.textBox_iTerm);
            this.groupBox1.Controls.Add(this.numericUpDown_I);
            this.groupBox1.Controls.Add(this.numericUpDown_D);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox_i);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox_d);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(6, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 157);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "SP:";
            // 
            // textBox_SetPoint
            // 
            this.textBox_SetPoint.Location = new System.Drawing.Point(134, 113);
            this.textBox_SetPoint.Name = "textBox_SetPoint";
            this.textBox_SetPoint.Size = new System.Drawing.Size(67, 25);
            this.textBox_SetPoint.TabIndex = 23;
            // 
            // numericUpDown_SetPoint
            // 
            this.numericUpDown_SetPoint.DecimalPlaces = 1;
            this.numericUpDown_SetPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.numericUpDown_SetPoint.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown_SetPoint.Location = new System.Drawing.Point(43, 114);
            this.numericUpDown_SetPoint.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_SetPoint.Name = "numericUpDown_SetPoint";
            this.numericUpDown_SetPoint.Size = new System.Drawing.Size(85, 24);
            this.numericUpDown_SetPoint.TabIndex = 22;
            this.numericUpDown_SetPoint.ValueChanged += new System.EventHandler(this.numericUpDown_SetPoint_ValueChanged);
            // 
            // textBox_p
            // 
            this.textBox_p.Location = new System.Drawing.Point(134, 27);
            this.textBox_p.Name = "textBox_p";
            this.textBox_p.Size = new System.Drawing.Size(67, 25);
            this.textBox_p.TabIndex = 13;
            // 
            // textBox_dTerm
            // 
            this.textBox_dTerm.Location = new System.Drawing.Point(275, 83);
            this.textBox_dTerm.Name = "textBox_dTerm";
            this.textBox_dTerm.Size = new System.Drawing.Size(67, 25);
            this.textBox_dTerm.TabIndex = 19;
            // 
            // textBox_pTerm
            // 
            this.textBox_pTerm.Location = new System.Drawing.Point(275, 26);
            this.textBox_pTerm.Name = "textBox_pTerm";
            this.textBox_pTerm.Size = new System.Drawing.Size(67, 25);
            this.textBox_pTerm.TabIndex = 21;
            // 
            // numericUpDown_P
            // 
            this.numericUpDown_P.DecimalPlaces = 1;
            this.numericUpDown_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_P.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown_P.Location = new System.Drawing.Point(43, 27);
            this.numericUpDown_P.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown_P.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_P.Name = "numericUpDown_P";
            this.numericUpDown_P.Size = new System.Drawing.Size(85, 24);
            this.numericUpDown_P.TabIndex = 6;
            this.numericUpDown_P.ValueChanged += new System.EventHandler(this.numericUpDown_P_ValueChanged);
            // 
            // textBox_iTerm
            // 
            this.textBox_iTerm.Location = new System.Drawing.Point(275, 56);
            this.textBox_iTerm.Name = "textBox_iTerm";
            this.textBox_iTerm.Size = new System.Drawing.Size(67, 25);
            this.textBox_iTerm.TabIndex = 20;
            // 
            // numericUpDown_I
            // 
            this.numericUpDown_I.DecimalPlaces = 1;
            this.numericUpDown_I.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.numericUpDown_I.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown_I.Location = new System.Drawing.Point(43, 55);
            this.numericUpDown_I.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown_I.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_I.Name = "numericUpDown_I";
            this.numericUpDown_I.Size = new System.Drawing.Size(85, 24);
            this.numericUpDown_I.TabIndex = 5;
            this.numericUpDown_I.ValueChanged += new System.EventHandler(this.numericUpDown_I_ValueChanged);
            // 
            // numericUpDown_D
            // 
            this.numericUpDown_D.DecimalPlaces = 1;
            this.numericUpDown_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.numericUpDown_D.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown_D.Location = new System.Drawing.Point(43, 84);
            this.numericUpDown_D.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown_D.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_D.Name = "numericUpDown_D";
            this.numericUpDown_D.Size = new System.Drawing.Size(85, 24);
            this.numericUpDown_D.TabIndex = 4;
            this.numericUpDown_D.ValueChanged += new System.EventHandler(this.numericUpDown_D_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(207, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "pTerm:";
            // 
            // textBox_i
            // 
            this.textBox_i.Location = new System.Drawing.Point(134, 56);
            this.textBox_i.Name = "textBox_i";
            this.textBox_i.Size = new System.Drawing.Size(67, 25);
            this.textBox_i.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(207, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "iTerm:";
            // 
            // textBox_d
            // 
            this.textBox_d.Location = new System.Drawing.Point(134, 85);
            this.textBox_d.Name = "textBox_d";
            this.textBox_d.Size = new System.Drawing.Size(67, 25);
            this.textBox_d.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(207, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "dTerm:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_SerialPrint);
            this.groupBox2.Location = new System.Drawing.Point(6, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 411);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SerialPrint:";
            // 
            // textBox_SerialPrint
            // 
            this.textBox_SerialPrint.Location = new System.Drawing.Point(6, 24);
            this.textBox_SerialPrint.Multiline = true;
            this.textBox_SerialPrint.Name = "textBox_SerialPrint";
            this.textBox_SerialPrint.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_SerialPrint.Size = new System.Drawing.Size(438, 381);
            this.textBox_SerialPrint.TabIndex = 23;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM3";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_ConnectSerial
            // 
            this.btn_ConnectSerial.Location = new System.Drawing.Point(12, 12);
            this.btn_ConnectSerial.Name = "btn_ConnectSerial";
            this.btn_ConnectSerial.Size = new System.Drawing.Size(75, 23);
            this.btn_ConnectSerial.TabIndex = 9;
            this.btn_ConnectSerial.Text = "Connect";
            this.btn_ConnectSerial.UseVisualStyleBackColor = true;
            this.btn_ConnectSerial.Click += new System.EventHandler(this.btn_ConnectSerial_Click);
            // 
            // btn_serialDisconnect
            // 
            this.btn_serialDisconnect.Location = new System.Drawing.Point(183, 12);
            this.btn_serialDisconnect.Name = "btn_serialDisconnect";
            this.btn_serialDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btn_serialDisconnect.TabIndex = 1;
            this.btn_serialDisconnect.Text = "Disconnect";
            this.btn_serialDisconnect.UseVisualStyleBackColor = true;
            this.btn_serialDisconnect.Click += new System.EventHandler(this.btn_serialDisconnect_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(1052, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(264, 17);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(40, 13);
            this.status.TabIndex = 12;
            this.status.Text = "Status:";
            // 
            // lb_connectionStatus
            // 
            this.lb_connectionStatus.AutoSize = true;
            this.lb_connectionStatus.Location = new System.Drawing.Point(301, 17);
            this.lb_connectionStatus.Name = "lb_connectionStatus";
            this.lb_connectionStatus.Size = new System.Drawing.Size(73, 13);
            this.lb_connectionStatus.TabIndex = 13;
            this.lb_connectionStatus.Text = "Disconnected";
            // 
            // comboBox_Comports
            // 
            this.comboBox_Comports.FormattingEnabled = true;
            this.comboBox_Comports.Location = new System.Drawing.Point(93, 14);
            this.comboBox_Comports.Name = "comboBox_Comports";
            this.comboBox_Comports.Size = new System.Drawing.Size(84, 21);
            this.comboBox_Comports.TabIndex = 14;
            this.comboBox_Comports.Click += new System.EventHandler(this.comboBoxComports_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1139, 694);
            this.Controls.Add(this.comboBox_Comports);
            this.Controls.Add(this.lb_connectionStatus);
            this.Controls.Add(this.status);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_serialDisconnect);
            this.Controls.Add(this.btn_ConnectSerial);
            this.Controls.Add(tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArduinoDebug";
            this.Load += new System.EventHandler(this.Form1_Load);
            tabControl1.ResumeLayout(false);
            this.IMU.ResumeLayout(false);
            this.IMU.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox_graph1.ResumeLayout(false);
            this.groupBox_graph1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SetPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_P)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_I)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_D)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage IMU;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_ConnectSerial;
        private System.Windows.Forms.Button btn_serialDisconnect;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label lb_connectionStatus;
        private System.Windows.Forms.ComboBox comboBox_Comports;
        private AvionicsInstrumentControlDemo.AttitudeIndicatorInstrumentControl attitudeIndicatorInstrumentControl1;
        private System.Windows.Forms.Label label8;
        private ZedGraph.ZedGraphControl zedGraphControl2;
        private System.Windows.Forms.TextBox textBox_i;
        private System.Windows.Forms.TextBox textBox_d;
        private System.Windows.Forms.TextBox textBox_p;
        private System.Windows.Forms.Label lb_d;
        private System.Windows.Forms.Label lb_i;
        private System.Windows.Forms.Label lb_p;
        private System.Windows.Forms.TextBox textBox_pTerm;
        private System.Windows.Forms.TextBox textBox_iTerm;
        private System.Windows.Forms.TextBox textBox_dTerm;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_SerialPrint;
        private AvionicsInstrumentControlDemo.HeadingIndicatorInstrumentControl headingIndicatorInstrumentControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox_graph1;
        private System.Windows.Forms.NumericUpDown numericUpDown_P;
        private System.Windows.Forms.NumericUpDown numericUpDown_I;
        private System.Windows.Forms.NumericUpDown numericUpDown_D;
        private System.Windows.Forms.TextBox textBox_graphRoll;
        private System.Windows.Forms.TextBox textBox__graphYaw;
        private System.Windows.Forms.TextBox textBox_graphPitch;
        private System.Windows.Forms.CheckBox checkBox_roll;
        private System.Windows.Forms.CheckBox checkBox_pitch;
        private System.Windows.Forms.CheckBox checkBox_yaw;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox_pTerm;
        private System.Windows.Forms.CheckBox checkBox_iTerm;
        private System.Windows.Forms.CheckBox checkBox_dTerm;
        private System.Windows.Forms.TextBox textBox_graphdTerm;
        private System.Windows.Forms.TextBox textBox_graphiTerm;
        private System.Windows.Forms.TextBox textBox_graphpTerm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_SetPoint;
        private System.Windows.Forms.NumericUpDown numericUpDown_SetPoint;
    }
}

