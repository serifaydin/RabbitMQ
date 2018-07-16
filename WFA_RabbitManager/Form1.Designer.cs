namespace WFA_RabbitManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDirectQueueCreate = new System.Windows.Forms.Button();
            this.btnDirectSend = new System.Windows.Forms.Button();
            this.lstDirect = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDirectRouteKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDirectQueueName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnFanoutQueueCreate = new System.Windows.Forms.Button();
            this.lstFanoutQueueList = new System.Windows.Forms.ListBox();
            this.btnFanoutSend = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFanoutQueueName = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnTopicQueueCreate = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnTopicSend = new System.Windows.Forms.Button();
            this.lstTopicList = new System.Windows.Forms.ListBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtTopicRouteKey = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTopicQueueName = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lstHeaderExchangeKeys = new System.Windows.Forms.ListBox();
            this.btnHeaderExchangeQueueCreate = new System.Windows.Forms.Button();
            this.btnHeaderExchangeAdd = new System.Windows.Forms.Button();
            this.btnHeaderExchangeSend = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtHeaderExchangeKey = new System.Windows.Forms.TextBox();
            this.txtHeaderExchangeValue = new System.Windows.Forms.TextBox();
            this.txtHeaderExchangeQueueName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtExchangeName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVirtualName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1258, 292);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.btnDirectQueueCreate);
            this.tabPage1.Controls.Add(this.btnDirectSend);
            this.tabPage1.Controls.Add(this.lstDirect);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.txtDirectRouteKey);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtDirectQueueName);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1250, 263);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Direct Exchange";
            // 
            // btnDirectQueueCreate
            // 
            this.btnDirectQueueCreate.BackColor = System.Drawing.Color.DimGray;
            this.btnDirectQueueCreate.ForeColor = System.Drawing.Color.Coral;
            this.btnDirectQueueCreate.Location = new System.Drawing.Point(118, 66);
            this.btnDirectQueueCreate.Name = "btnDirectQueueCreate";
            this.btnDirectQueueCreate.Size = new System.Drawing.Size(153, 41);
            this.btnDirectQueueCreate.TabIndex = 4;
            this.btnDirectQueueCreate.Text = "QUEUE CREATE";
            this.btnDirectQueueCreate.UseVisualStyleBackColor = false;
            this.btnDirectQueueCreate.Click += new System.EventHandler(this.btnDirectQueueCreate_Click);
            // 
            // btnDirectSend
            // 
            this.btnDirectSend.ForeColor = System.Drawing.Color.Chocolate;
            this.btnDirectSend.Location = new System.Drawing.Point(281, 130);
            this.btnDirectSend.Name = "btnDirectSend";
            this.btnDirectSend.Size = new System.Drawing.Size(298, 41);
            this.btnDirectSend.TabIndex = 4;
            this.btnDirectSend.Text = "MESSAGE SEND";
            this.btnDirectSend.UseVisualStyleBackColor = true;
            this.btnDirectSend.Click += new System.EventHandler(this.btnDirectSend_Click);
            // 
            // lstDirect
            // 
            this.lstDirect.FormattingEnabled = true;
            this.lstDirect.ItemHeight = 16;
            this.lstDirect.Items.AddRange(new object[] {
            "Queue1 - queue1RouteKey",
            "Queue2 - queue2RouteKey"});
            this.lstDirect.Location = new System.Drawing.Point(281, 8);
            this.lstDirect.Name = "lstDirect";
            this.lstDirect.Size = new System.Drawing.Size(298, 116);
            this.lstDirect.TabIndex = 5;
            this.lstDirect.SelectedIndexChanged += new System.EventHandler(this.lstDirect_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(585, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(626, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtDirectRouteKey
            // 
            this.txtDirectRouteKey.Location = new System.Drawing.Point(118, 38);
            this.txtDirectRouteKey.Name = "txtDirectRouteKey";
            this.txtDirectRouteKey.Size = new System.Drawing.Size(153, 22);
            this.txtDirectRouteKey.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Route Key : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Queue Name : ";
            // 
            // txtDirectQueueName
            // 
            this.txtDirectQueueName.Location = new System.Drawing.Point(118, 10);
            this.txtDirectQueueName.Name = "txtDirectQueueName";
            this.txtDirectQueueName.ReadOnly = true;
            this.txtDirectQueueName.Size = new System.Drawing.Size(153, 22);
            this.txtDirectQueueName.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.btnFanoutQueueCreate);
            this.tabPage2.Controls.Add(this.lstFanoutQueueList);
            this.tabPage2.Controls.Add(this.btnFanoutSend);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtFanoutQueueName);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1250, 263);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fanout Exchange";
            // 
            // btnFanoutQueueCreate
            // 
            this.btnFanoutQueueCreate.BackColor = System.Drawing.Color.DimGray;
            this.btnFanoutQueueCreate.ForeColor = System.Drawing.Color.Coral;
            this.btnFanoutQueueCreate.Location = new System.Drawing.Point(113, 40);
            this.btnFanoutQueueCreate.Name = "btnFanoutQueueCreate";
            this.btnFanoutQueueCreate.Size = new System.Drawing.Size(204, 41);
            this.btnFanoutQueueCreate.TabIndex = 13;
            this.btnFanoutQueueCreate.Text = "QUEUE CREATE";
            this.btnFanoutQueueCreate.UseVisualStyleBackColor = false;
            this.btnFanoutQueueCreate.Click += new System.EventHandler(this.btnFanoutQueueCreate_Click);
            // 
            // lstFanoutQueueList
            // 
            this.lstFanoutQueueList.FormattingEnabled = true;
            this.lstFanoutQueueList.ItemHeight = 16;
            this.lstFanoutQueueList.Items.AddRange(new object[] {
            "Queue1",
            "Queue2"});
            this.lstFanoutQueueList.Location = new System.Drawing.Point(323, 10);
            this.lstFanoutQueueList.Name = "lstFanoutQueueList";
            this.lstFanoutQueueList.Size = new System.Drawing.Size(256, 116);
            this.lstFanoutQueueList.TabIndex = 12;
            this.lstFanoutQueueList.SelectedIndexChanged += new System.EventHandler(this.lstFanoutQueueList_SelectedIndexChanged);
            // 
            // btnFanoutSend
            // 
            this.btnFanoutSend.ForeColor = System.Drawing.Color.Chocolate;
            this.btnFanoutSend.Location = new System.Drawing.Point(323, 132);
            this.btnFanoutSend.Name = "btnFanoutSend";
            this.btnFanoutSend.Size = new System.Drawing.Size(256, 41);
            this.btnFanoutSend.TabIndex = 10;
            this.btnFanoutSend.Text = "MESSAGE SEND";
            this.btnFanoutSend.UseVisualStyleBackColor = true;
            this.btnFanoutSend.Click += new System.EventHandler(this.btnFanoutSend_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(595, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(626, 228);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Queue Name : ";
            // 
            // txtFanoutQueueName
            // 
            this.txtFanoutQueueName.Location = new System.Drawing.Point(113, 12);
            this.txtFanoutQueueName.Name = "txtFanoutQueueName";
            this.txtFanoutQueueName.ReadOnly = true;
            this.txtFanoutQueueName.Size = new System.Drawing.Size(204, 22);
            this.txtFanoutQueueName.TabIndex = 9;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightGray;
            this.tabPage3.Controls.Add(this.btnTopicQueueCreate);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.btnTopicSend);
            this.tabPage3.Controls.Add(this.lstTopicList);
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Controls.Add(this.txtTopicRouteKey);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.txtTopicQueueName);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1250, 263);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Topic Exchange";
            // 
            // btnTopicQueueCreate
            // 
            this.btnTopicQueueCreate.BackColor = System.Drawing.Color.DimGray;
            this.btnTopicQueueCreate.ForeColor = System.Drawing.Color.Coral;
            this.btnTopicQueueCreate.Location = new System.Drawing.Point(118, 69);
            this.btnTopicQueueCreate.Name = "btnTopicQueueCreate";
            this.btnTopicQueueCreate.Size = new System.Drawing.Size(157, 41);
            this.btnTopicQueueCreate.TabIndex = 14;
            this.btnTopicQueueCreate.Text = "QUEUE CREATE";
            this.btnTopicQueueCreate.UseVisualStyleBackColor = false;
            this.btnTopicQueueCreate.Click += new System.EventHandler(this.btnTopicQueueCreate_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(13, 164);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(566, 75);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "*.serif\t2 kelimeden oluşan 2. Kelimesi serif olan\t\r\nserif.*\t2 kelimeden oluşan 1." +
    " Kelimesi serif olan\t\r\n*.serif.*\t3 kelimeden oluşan Ortadaki kelimesi serif olan" +
    "\t\r\nserif\tSadece serif olucak\t\r\n";
            // 
            // btnTopicSend
            // 
            this.btnTopicSend.ForeColor = System.Drawing.Color.Chocolate;
            this.btnTopicSend.Location = new System.Drawing.Point(281, 101);
            this.btnTopicSend.Name = "btnTopicSend";
            this.btnTopicSend.Size = new System.Drawing.Size(298, 41);
            this.btnTopicSend.TabIndex = 10;
            this.btnTopicSend.Text = "MESSAGE SEND";
            this.btnTopicSend.UseVisualStyleBackColor = true;
            this.btnTopicSend.Click += new System.EventHandler(this.btnTopicSend_Click);
            // 
            // lstTopicList
            // 
            this.lstTopicList.FormattingEnabled = true;
            this.lstTopicList.ItemHeight = 16;
            this.lstTopicList.Items.AddRange(new object[] {
            "Queue1 - *.bmw",
            "Queue1 - serif.*",
            "Queue2 - merc.*"});
            this.lstTopicList.Location = new System.Drawing.Point(281, 11);
            this.lstTopicList.Name = "lstTopicList";
            this.lstTopicList.Size = new System.Drawing.Size(298, 84);
            this.lstTopicList.TabIndex = 12;
            this.lstTopicList.SelectedIndexChanged += new System.EventHandler(this.lstTopicList_SelectedIndexChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(585, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(626, 228);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // txtTopicRouteKey
            // 
            this.txtTopicRouteKey.Location = new System.Drawing.Point(118, 41);
            this.txtTopicRouteKey.Name = "txtTopicRouteKey";
            this.txtTopicRouteKey.Size = new System.Drawing.Size(153, 22);
            this.txtTopicRouteKey.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Route Key : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 17);
            this.label13.TabIndex = 8;
            this.label13.Text = "Queue Name : ";
            // 
            // txtTopicQueueName
            // 
            this.txtTopicQueueName.Location = new System.Drawing.Point(118, 13);
            this.txtTopicQueueName.Name = "txtTopicQueueName";
            this.txtTopicQueueName.ReadOnly = true;
            this.txtTopicQueueName.Size = new System.Drawing.Size(153, 22);
            this.txtTopicQueueName.TabIndex = 9;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.LightGray;
            this.tabPage4.Controls.Add(this.lstHeaderExchangeKeys);
            this.tabPage4.Controls.Add(this.btnHeaderExchangeQueueCreate);
            this.tabPage4.Controls.Add(this.btnHeaderExchangeAdd);
            this.tabPage4.Controls.Add(this.btnHeaderExchangeSend);
            this.tabPage4.Controls.Add(this.pictureBox4);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.txtHeaderExchangeKey);
            this.tabPage4.Controls.Add(this.txtHeaderExchangeValue);
            this.tabPage4.Controls.Add(this.txtHeaderExchangeQueueName);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1250, 263);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Header Exchange";
            // 
            // lstHeaderExchangeKeys
            // 
            this.lstHeaderExchangeKeys.FormattingEnabled = true;
            this.lstHeaderExchangeKeys.ItemHeight = 16;
            this.lstHeaderExchangeKeys.Location = new System.Drawing.Point(12, 81);
            this.lstHeaderExchangeKeys.Name = "lstHeaderExchangeKeys";
            this.lstHeaderExchangeKeys.Size = new System.Drawing.Size(285, 116);
            this.lstHeaderExchangeKeys.TabIndex = 24;
            // 
            // btnHeaderExchangeQueueCreate
            // 
            this.btnHeaderExchangeQueueCreate.BackColor = System.Drawing.Color.DimGray;
            this.btnHeaderExchangeQueueCreate.ForeColor = System.Drawing.Color.Coral;
            this.btnHeaderExchangeQueueCreate.Location = new System.Drawing.Point(12, 203);
            this.btnHeaderExchangeQueueCreate.Name = "btnHeaderExchangeQueueCreate";
            this.btnHeaderExchangeQueueCreate.Size = new System.Drawing.Size(285, 41);
            this.btnHeaderExchangeQueueCreate.TabIndex = 23;
            this.btnHeaderExchangeQueueCreate.Text = "QUEUE CREATE";
            this.btnHeaderExchangeQueueCreate.UseVisualStyleBackColor = false;
            this.btnHeaderExchangeQueueCreate.Click += new System.EventHandler(this.btnHeaderExchangeQueueCreate_Click);
            // 
            // btnHeaderExchangeAdd
            // 
            this.btnHeaderExchangeAdd.ForeColor = System.Drawing.Color.Chocolate;
            this.btnHeaderExchangeAdd.Location = new System.Drawing.Point(301, 46);
            this.btnHeaderExchangeAdd.Name = "btnHeaderExchangeAdd";
            this.btnHeaderExchangeAdd.Size = new System.Drawing.Size(71, 22);
            this.btnHeaderExchangeAdd.TabIndex = 19;
            this.btnHeaderExchangeAdd.Text = "ADD";
            this.btnHeaderExchangeAdd.UseVisualStyleBackColor = true;
            this.btnHeaderExchangeAdd.Click += new System.EventHandler(this.btnHeaderExchangeAdd_Click);
            // 
            // btnHeaderExchangeSend
            // 
            this.btnHeaderExchangeSend.ForeColor = System.Drawing.Color.Chocolate;
            this.btnHeaderExchangeSend.Location = new System.Drawing.Point(335, 102);
            this.btnHeaderExchangeSend.Name = "btnHeaderExchangeSend";
            this.btnHeaderExchangeSend.Size = new System.Drawing.Size(220, 53);
            this.btnHeaderExchangeSend.TabIndex = 19;
            this.btnHeaderExchangeSend.Text = "MESSAGE SEND";
            this.btnHeaderExchangeSend.UseVisualStyleBackColor = true;
            this.btnHeaderExchangeSend.Click += new System.EventHandler(this.btnHeaderExchangeSend_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(583, 10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(626, 228);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 17);
            this.label14.TabIndex = 17;
            this.label14.Text = "Key - Value";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 17);
            this.label15.TabIndex = 17;
            this.label15.Text = "Queue Name : ";
            // 
            // txtHeaderExchangeKey
            // 
            this.txtHeaderExchangeKey.Location = new System.Drawing.Point(114, 46);
            this.txtHeaderExchangeKey.Name = "txtHeaderExchangeKey";
            this.txtHeaderExchangeKey.Size = new System.Drawing.Size(83, 22);
            this.txtHeaderExchangeKey.TabIndex = 18;
            // 
            // txtHeaderExchangeValue
            // 
            this.txtHeaderExchangeValue.Location = new System.Drawing.Point(212, 46);
            this.txtHeaderExchangeValue.Name = "txtHeaderExchangeValue";
            this.txtHeaderExchangeValue.Size = new System.Drawing.Size(83, 22);
            this.txtHeaderExchangeValue.TabIndex = 18;
            // 
            // txtHeaderExchangeQueueName
            // 
            this.txtHeaderExchangeQueueName.Location = new System.Drawing.Point(116, 12);
            this.txtHeaderExchangeQueueName.Name = "txtHeaderExchangeQueueName";
            this.txtHeaderExchangeQueueName.Size = new System.Drawing.Size(181, 22);
            this.txtHeaderExchangeQueueName.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(518, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Exchange Name : ";
            // 
            // txtExchangeName
            // 
            this.txtExchangeName.Location = new System.Drawing.Point(647, 169);
            this.txtExchangeName.Name = "txtExchangeName";
            this.txtExchangeName.ReadOnly = true;
            this.txtExchangeName.Size = new System.Drawing.Size(286, 22);
            this.txtExchangeName.TabIndex = 3;
            this.txtExchangeName.Text = "SERIF";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1258, 292);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtVirtualName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHostname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(9, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 186);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(138, 141);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(290, 24);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "admin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password : ";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(138, 101);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(290, 24);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Text = "admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "User Name : ";
            // 
            // txtVirtualName
            // 
            this.txtVirtualName.Location = new System.Drawing.Point(138, 65);
            this.txtVirtualName.Name = "txtVirtualName";
            this.txtVirtualName.Size = new System.Drawing.Size(290, 24);
            this.txtVirtualName.TabIndex = 3;
            this.txtVirtualName.Text = "serifHost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Virtual Host :";
            // 
            // txtHostname
            // 
            this.txtHostname.Location = new System.Drawing.Point(138, 30);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.Size = new System.Drawing.Size(290, 24);
            this.txtHostname.TabIndex = 3;
            this.txtHostname.Text = "localhost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Host Name : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "ID : ";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(122, 28);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(290, 22);
            this.txtId.TabIndex = 3;
            this.txtId.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Name : ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(122, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(290, 22);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "Şerif";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(122, 105);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(290, 22);
            this.txtSurname.TabIndex = 3;
            this.txtSurname.Text = "Aydın";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.txtSurname);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(521, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(443, 141);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 513);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtExchangeName);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "RabbitMQ Manager";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHostname;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVirtualName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDirectRouteKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDirectQueueName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtExchangeName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDirectSend;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lstDirect;
        private System.Windows.Forms.Button btnFanoutSend;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFanoutQueueName;
        private System.Windows.Forms.ListBox lstFanoutQueueList;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnTopicSend;
        private System.Windows.Forms.ListBox lstTopicList;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtTopicRouteKey;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTopicQueueName;
        private System.Windows.Forms.Button btnDirectQueueCreate;
        private System.Windows.Forms.Button btnFanoutQueueCreate;
        private System.Windows.Forms.Button btnTopicQueueCreate;
        private System.Windows.Forms.Button btnHeaderExchangeQueueCreate;
        private System.Windows.Forms.Button btnHeaderExchangeSend;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtHeaderExchangeQueueName;
        private System.Windows.Forms.ListBox lstHeaderExchangeKeys;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtHeaderExchangeKey;
        private System.Windows.Forms.TextBox txtHeaderExchangeValue;
        private System.Windows.Forms.Button btnHeaderExchangeAdd;
    }
}

