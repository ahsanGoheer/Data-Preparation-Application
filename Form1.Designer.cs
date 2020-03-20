namespace Data_Preparation_Application
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imageBox = new System.Windows.Forms.ListBox();
            this.input_PB = new System.Windows.Forms.PictureBox();
            this.ProcessWorker = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.outputImageBox = new System.Windows.Forms.PictureBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.toolsTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.holderTb_3 = new System.Windows.Forms.TextBox();
            this.holderTb_2 = new System.Windows.Forms.TextBox();
            this.holderTb_1 = new System.Windows.Forms.TextBox();
            this.holder3_lbl = new System.Windows.Forms.Label();
            this.holderlbl_2 = new System.Windows.Forms.Label();
            this.holderlbl_1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.outPutRB = new System.Windows.Forms.RadioButton();
            this.inPutRb = new System.Windows.Forms.RadioButton();
            this.binApplyBtn = new System.Windows.Forms.Button();
            this.OtsuRb = new System.Windows.Forms.RadioButton();
            this.simpleThresh = new System.Windows.Forms.RadioButton();
            this.wolfRb = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.edgeOutputRb = new System.Windows.Forms.RadioButton();
            this.edgeInputRB = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.CannyRb = new System.Windows.Forms.RadioButton();
            this.prewittRb = new System.Windows.Forms.RadioButton();
            this.sobelRb = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ImageLoader = new System.Windows.Forms.OpenFileDialog();
            this.EdgeDetect = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.outRb = new System.Windows.Forms.RadioButton();
            this.inRb = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.smoothingRB = new System.Windows.Forms.RadioButton();
            this.sharpenRB = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.threshVal = new System.Windows.Forms.NumericUpDown();
            this.Misc = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_PB)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputImageBox)).BeginInit();
            this.toolsTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threshVal)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imageBox);
            this.groupBox1.Controls.Add(this.input_PB);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 416);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Images";
            // 
            // imageBox
            // 
            this.imageBox.FormattingEnabled = true;
            this.imageBox.ItemHeight = 16;
            this.imageBox.Location = new System.Drawing.Point(465, 54);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(236, 308);
            this.imageBox.TabIndex = 1;
            this.imageBox.SelectedIndexChanged += new System.EventHandler(this.imageBox_SelectedIndexChanged);
            // 
            // input_PB
            // 
            this.input_PB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_PB.Location = new System.Drawing.Point(44, 72);
            this.input_PB.Name = "input_PB";
            this.input_PB.Size = new System.Drawing.Size(313, 265);
            this.input_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.input_PB.TabIndex = 0;
            this.input_PB.TabStop = false;
            // 
            // ProcessWorker
            // 
            this.ProcessWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ProcessWorker_RunWorkerCompleted);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.outputImageBox);
            this.panel1.Location = new System.Drawing.Point(858, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 489);
            this.panel1.TabIndex = 1;
            // 
            // outputImageBox
            // 
            this.outputImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputImageBox.Location = new System.Drawing.Point(0, 0);
            this.outputImageBox.Name = "outputImageBox";
            this.outputImageBox.Size = new System.Drawing.Size(598, 489);
            this.outputImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.outputImageBox.TabIndex = 0;
            this.outputImageBox.TabStop = false;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(1136, 43);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(51, 17);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.Text = "Output";
            // 
            // toolsTab
            // 
            this.toolsTab.Controls.Add(this.tabPage1);
            this.toolsTab.Controls.Add(this.tabPage2);
            this.toolsTab.Controls.Add(this.tabPage3);
            this.toolsTab.Location = new System.Drawing.Point(12, 458);
            this.toolsTab.Name = "toolsTab";
            this.toolsTab.SelectedIndex = 0;
            this.toolsTab.Size = new System.Drawing.Size(770, 302);
            this.toolsTab.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(762, 273);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Binarization";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.holderTb_3);
            this.panel3.Controls.Add(this.holderTb_2);
            this.panel3.Controls.Add(this.holderTb_1);
            this.panel3.Controls.Add(this.holder3_lbl);
            this.panel3.Controls.Add(this.holderlbl_2);
            this.panel3.Controls.Add(this.holderlbl_1);
            this.panel3.Location = new System.Drawing.Point(401, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 222);
            this.panel3.TabIndex = 1;
            // 
            // holderTb_3
            // 
            this.holderTb_3.Location = new System.Drawing.Point(130, 159);
            this.holderTb_3.Name = "holderTb_3";
            this.holderTb_3.Size = new System.Drawing.Size(166, 22);
            this.holderTb_3.TabIndex = 5;
            // 
            // holderTb_2
            // 
            this.holderTb_2.Location = new System.Drawing.Point(130, 98);
            this.holderTb_2.Name = "holderTb_2";
            this.holderTb_2.Size = new System.Drawing.Size(166, 22);
            this.holderTb_2.TabIndex = 4;
            // 
            // holderTb_1
            // 
            this.holderTb_1.Location = new System.Drawing.Point(130, 38);
            this.holderTb_1.Name = "holderTb_1";
            this.holderTb_1.Size = new System.Drawing.Size(166, 22);
            this.holderTb_1.TabIndex = 3;
            // 
            // holder3_lbl
            // 
            this.holder3_lbl.AutoSize = true;
            this.holder3_lbl.Location = new System.Drawing.Point(28, 159);
            this.holder3_lbl.Name = "holder3_lbl";
            this.holder3_lbl.Size = new System.Drawing.Size(66, 17);
            this.holder3_lbl.TabIndex = 2;
            this.holder3_lbl.Text = "Holder3 :";
            // 
            // holderlbl_2
            // 
            this.holderlbl_2.AutoSize = true;
            this.holderlbl_2.Location = new System.Drawing.Point(28, 98);
            this.holderlbl_2.Name = "holderlbl_2";
            this.holderlbl_2.Size = new System.Drawing.Size(66, 17);
            this.holderlbl_2.TabIndex = 1;
            this.holderlbl_2.Text = "Holder2 :";
            // 
            // holderlbl_1
            // 
            this.holderlbl_1.AutoSize = true;
            this.holderlbl_1.Location = new System.Drawing.Point(28, 40);
            this.holderlbl_1.Name = "holderlbl_1";
            this.holderlbl_1.Size = new System.Drawing.Size(66, 17);
            this.holderlbl_1.TabIndex = 0;
            this.holderlbl_1.Text = "Holder1 :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.binApplyBtn);
            this.panel2.Controls.Add(this.OtsuRb);
            this.panel2.Controls.Add(this.simpleThresh);
            this.panel2.Controls.Add(this.wolfRb);
            this.panel2.Location = new System.Drawing.Point(23, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 222);
            this.panel2.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.outPutRB);
            this.panel7.Controls.Add(this.inPutRb);
            this.panel7.Location = new System.Drawing.Point(31, 174);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(192, 29);
            this.panel7.TabIndex = 5;
            // 
            // outPutRB
            // 
            this.outPutRB.AutoSize = true;
            this.outPutRB.Location = new System.Drawing.Point(108, 3);
            this.outPutRB.Name = "outPutRB";
            this.outPutRB.Size = new System.Drawing.Size(69, 21);
            this.outPutRB.TabIndex = 1;
            this.outPutRB.TabStop = true;
            this.outPutRB.Text = "output";
            this.outPutRB.UseVisualStyleBackColor = true;
            // 
            // inPutRb
            // 
            this.inPutRb.AutoSize = true;
            this.inPutRb.Location = new System.Drawing.Point(3, 3);
            this.inPutRb.Name = "inPutRb";
            this.inPutRb.Size = new System.Drawing.Size(60, 21);
            this.inPutRb.TabIndex = 0;
            this.inPutRb.TabStop = true;
            this.inPutRb.Text = "input";
            this.inPutRb.UseVisualStyleBackColor = true;
            // 
            // binApplyBtn
            // 
            this.binApplyBtn.Location = new System.Drawing.Point(235, 159);
            this.binApplyBtn.Name = "binApplyBtn";
            this.binApplyBtn.Size = new System.Drawing.Size(75, 44);
            this.binApplyBtn.TabIndex = 3;
            this.binApplyBtn.Text = "Apply";
            this.binApplyBtn.UseVisualStyleBackColor = true;
            this.binApplyBtn.Click += new System.EventHandler(this.binApplyBtn_Click);
            // 
            // OtsuRb
            // 
            this.OtsuRb.AutoSize = true;
            this.OtsuRb.Location = new System.Drawing.Point(31, 125);
            this.OtsuRb.Name = "OtsuRb";
            this.OtsuRb.Size = new System.Drawing.Size(59, 21);
            this.OtsuRb.TabIndex = 2;
            this.OtsuRb.TabStop = true;
            this.OtsuRb.Text = "Otsu";
            this.OtsuRb.UseVisualStyleBackColor = true;
            // 
            // simpleThresh
            // 
            this.simpleThresh.AutoSize = true;
            this.simpleThresh.Location = new System.Drawing.Point(31, 80);
            this.simpleThresh.Name = "simpleThresh";
            this.simpleThresh.Size = new System.Drawing.Size(116, 21);
            this.simpleThresh.TabIndex = 1;
            this.simpleThresh.TabStop = true;
            this.simpleThresh.Text = "SimpleThresh";
            this.simpleThresh.UseVisualStyleBackColor = true;
            // 
            // wolfRb
            // 
            this.wolfRb.AutoSize = true;
            this.wolfRb.Location = new System.Drawing.Point(31, 38);
            this.wolfRb.Name = "wolfRb";
            this.wolfRb.Size = new System.Drawing.Size(94, 21);
            this.wolfRb.TabIndex = 0;
            this.wolfRb.TabStop = true;
            this.wolfRb.Text = "WolfJolion";
            this.wolfRb.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(762, 273);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edge Detection";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(402, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(337, 222);
            this.panel4.TabIndex = 3;
            this.panel4.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(129, 170);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(166, 22);
            this.textBox4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Gaussian Size:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(130, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(166, 22);
            this.textBox3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "GaussianSig :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "LowThresh :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "HighThresh :";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.CannyRb);
            this.panel5.Controls.Add(this.prewittRb);
            this.panel5.Controls.Add(this.sobelRb);
            this.panel5.Location = new System.Drawing.Point(24, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(338, 222);
            this.panel5.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.edgeOutputRb);
            this.panel6.Controls.Add(this.edgeInputRB);
            this.panel6.Location = new System.Drawing.Point(16, 163);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(192, 29);
            this.panel6.TabIndex = 4;
            // 
            // edgeOutputRb
            // 
            this.edgeOutputRb.AutoSize = true;
            this.edgeOutputRb.Location = new System.Drawing.Point(108, 3);
            this.edgeOutputRb.Name = "edgeOutputRb";
            this.edgeOutputRb.Size = new System.Drawing.Size(69, 21);
            this.edgeOutputRb.TabIndex = 1;
            this.edgeOutputRb.TabStop = true;
            this.edgeOutputRb.Text = "output";
            this.edgeOutputRb.UseVisualStyleBackColor = true;
            // 
            // edgeInputRB
            // 
            this.edgeInputRB.AutoSize = true;
            this.edgeInputRB.Location = new System.Drawing.Point(15, 3);
            this.edgeInputRB.Name = "edgeInputRB";
            this.edgeInputRB.Size = new System.Drawing.Size(60, 21);
            this.edgeInputRB.TabIndex = 0;
            this.edgeInputRB.TabStop = true;
            this.edgeInputRB.Text = "input";
            this.edgeInputRB.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(235, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 44);
            this.button3.TabIndex = 3;
            this.button3.Text = "Apply";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CannyRb
            // 
            this.CannyRb.AutoSize = true;
            this.CannyRb.Location = new System.Drawing.Point(31, 125);
            this.CannyRb.Name = "CannyRb";
            this.CannyRb.Size = new System.Drawing.Size(69, 21);
            this.CannyRb.TabIndex = 2;
            this.CannyRb.TabStop = true;
            this.CannyRb.Text = "Canny";
            this.CannyRb.UseVisualStyleBackColor = true;
            // 
            // prewittRb
            // 
            this.prewittRb.AutoSize = true;
            this.prewittRb.Location = new System.Drawing.Point(31, 80);
            this.prewittRb.Name = "prewittRb";
            this.prewittRb.Size = new System.Drawing.Size(71, 21);
            this.prewittRb.TabIndex = 1;
            this.prewittRb.TabStop = true;
            this.prewittRb.Text = "Prewitt";
            this.prewittRb.UseVisualStyleBackColor = true;
            // 
            // sobelRb
            // 
            this.sobelRb.AutoSize = true;
            this.sobelRb.Location = new System.Drawing.Point(31, 38);
            this.sobelRb.Name = "sobelRb";
            this.sobelRb.Size = new System.Drawing.Size(65, 21);
            this.sobelRb.TabIndex = 0;
            this.sobelRb.TabStop = true;
            this.sobelRb.Text = "Sobel";
            this.sobelRb.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel8);
            this.tabPage3.Controls.Add(this.panel9);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(762, 273);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Misc";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(967, 589);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Load Images";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1172, 589);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "Save Images";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EdgeDetect
            // 
            this.EdgeDetect.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.EdgeDetect_RunWorkerCompleted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 785);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Status :";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.threshVal);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Location = new System.Drawing.Point(402, 25);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(337, 222);
            this.panel8.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.button4);
            this.panel9.Controls.Add(this.smoothingRB);
            this.panel9.Controls.Add(this.sharpenRB);
            this.panel9.Location = new System.Drawing.Point(24, 25);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(338, 222);
            this.panel9.TabIndex = 4;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.outRb);
            this.panel10.Controls.Add(this.inRb);
            this.panel10.Location = new System.Drawing.Point(16, 163);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(192, 29);
            this.panel10.TabIndex = 4;
            // 
            // outRb
            // 
            this.outRb.AutoSize = true;
            this.outRb.Location = new System.Drawing.Point(108, 3);
            this.outRb.Name = "outRb";
            this.outRb.Size = new System.Drawing.Size(69, 21);
            this.outRb.TabIndex = 1;
            this.outRb.TabStop = true;
            this.outRb.Text = "output";
            this.outRb.UseVisualStyleBackColor = true;
            // 
            // inRb
            // 
            this.inRb.AutoSize = true;
            this.inRb.Location = new System.Drawing.Point(15, 3);
            this.inRb.Name = "inRb";
            this.inRb.Size = new System.Drawing.Size(60, 21);
            this.inRb.TabIndex = 0;
            this.inRb.TabStop = true;
            this.inRb.Text = "input";
            this.inRb.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(235, 159);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 44);
            this.button4.TabIndex = 3;
            this.button4.Text = "Apply";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // smoothingRB
            // 
            this.smoothingRB.AutoSize = true;
            this.smoothingRB.Location = new System.Drawing.Point(31, 80);
            this.smoothingRB.Name = "smoothingRB";
            this.smoothingRB.Size = new System.Drawing.Size(96, 21);
            this.smoothingRB.TabIndex = 1;
            this.smoothingRB.TabStop = true;
            this.smoothingRB.Text = "Smoothing";
            this.smoothingRB.UseVisualStyleBackColor = true;
            // 
            // sharpenRB
            // 
            this.sharpenRB.AutoSize = true;
            this.sharpenRB.Location = new System.Drawing.Point(31, 38);
            this.sharpenRB.Name = "sharpenRB";
            this.sharpenRB.Size = new System.Drawing.Size(83, 21);
            this.sharpenRB.TabIndex = 0;
            this.sharpenRB.TabStop = true;
            this.sharpenRB.Text = "Sharpen";
            this.sharpenRB.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Value : ";
            // 
            // threshVal
            // 
            this.threshVal.Location = new System.Drawing.Point(142, 82);
            this.threshVal.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.threshVal.Name = "threshVal";
            this.threshVal.Size = new System.Drawing.Size(120, 22);
            this.threshVal.TabIndex = 1;
            this.threshVal.ValueChanged += new System.EventHandler(this.threshVal_ValueChanged);
            // 
            // Misc
            // 
            this.Misc.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Misc_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 847);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolsTab);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Data Cook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.input_PB)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.outputImageBox)).EndInit();
            this.toolsTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threshVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox imageBox;
        private System.Windows.Forms.PictureBox input_PB;
        private System.ComponentModel.BackgroundWorker ProcessWorker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox outputImageBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TabControl toolsTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog ImageLoader;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton OtsuRb;
        private System.Windows.Forms.RadioButton simpleThresh;
        private System.Windows.Forms.RadioButton wolfRb;
        private System.Windows.Forms.TextBox holderTb_3;
        private System.Windows.Forms.TextBox holderTb_2;
        private System.Windows.Forms.TextBox holderTb_1;
        private System.Windows.Forms.Label holder3_lbl;
        private System.Windows.Forms.Label holderlbl_2;
        private System.Windows.Forms.Label holderlbl_1;
        private System.Windows.Forms.Button binApplyBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton CannyRb;
        private System.Windows.Forms.RadioButton prewittRb;
        private System.Windows.Forms.RadioButton sobelRb;
        private System.ComponentModel.BackgroundWorker EdgeDetect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton outPutRB;
        private System.Windows.Forms.RadioButton inPutRb;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton edgeOutputRb;
        private System.Windows.Forms.RadioButton edgeInputRB;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.RadioButton outRb;
        private System.Windows.Forms.RadioButton inRb;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton smoothingRB;
        private System.Windows.Forms.RadioButton sharpenRB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown threshVal;
        private System.ComponentModel.BackgroundWorker Misc;
    }
}

