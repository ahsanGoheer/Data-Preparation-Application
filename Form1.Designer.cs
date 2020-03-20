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
            this.binApplyBtn = new System.Windows.Forms.Button();
            this.OtsuRb = new System.Windows.Forms.RadioButton();
            this.simpleThresh = new System.Windows.Forms.RadioButton();
            this.wolfRb = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ImageLoader = new System.Windows.Forms.OpenFileDialog();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input_PB)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputImageBox)).BeginInit();
            this.toolsTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
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
            this.panel2.Controls.Add(this.binApplyBtn);
            this.panel2.Controls.Add(this.OtsuRb);
            this.panel2.Controls.Add(this.simpleThresh);
            this.panel2.Controls.Add(this.wolfRb);
            this.panel2.Location = new System.Drawing.Point(23, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 222);
            this.panel2.TabIndex = 0;
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
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(762, 273);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Point Operations";
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
            // panel4
            // 
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
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 22);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 98);
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
            this.label1.Location = new System.Drawing.Point(28, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Holder3 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Holder2 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Holder1 :";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.radioButton1);
            this.panel5.Controls.Add(this.radioButton2);
            this.panel5.Controls.Add(this.radioButton3);
            this.panel5.Location = new System.Drawing.Point(24, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(338, 222);
            this.panel5.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(235, 159);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 44);
            this.button3.TabIndex = 3;
            this.button3.Text = "Apply";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(31, 125);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 21);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Canny";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(31, 80);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Prewitt";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(31, 38);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(65, 21);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Sobel";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1505, 847);
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
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}

