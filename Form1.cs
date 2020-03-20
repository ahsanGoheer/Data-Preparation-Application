using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord.Imaging;
using Accord.Imaging.Filters;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu;
using System.IO;
namespace Data_Preparation_Application
{
    public partial class Form1 : Form
    {
        List<string> operations = new List<string>();

        public Form1()
        {
            InitializeComponent();
            wolfRb.CheckedChanged += RadioBtnFunc;
            simpleThresh.CheckedChanged += RadioBtnFunc;
            OtsuRb.CheckedChanged += RadioBtnFunc;
            sobelRb.CheckedChanged += RadioBtnFunc;
            CannyRb.CheckedChanged += RadioBtnFunc;
            prewittRb.CheckedChanged += RadioBtnFunc;
            ProcessWorker.DoWork += Binarize;
            EdgeDetect.DoWork += ApplyEdge;
            Misc.DoWork += SharpenSmooth;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeFileDialogBox();
            inPutRb.Checked = true;
            inRb.Checked = true;
            edgeInputRB.Checked = true;
        }

        private void InitializeFileDialogBox()
        {
            ImageLoader.Filter = "Image Files (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            ImageLoader.Multiselect = true;
            ImageLoader.Title = "Image Picker";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] listOfFiles=null;
            DialogResult imLoaderRes= ImageLoader.ShowDialog();
            if(imLoaderRes==DialogResult.OK)
            {
                listOfFiles=ImageLoader.FileNames;
            }
            if(listOfFiles!=null)
            {
                foreach (string file in listOfFiles)
                {
                    imageBox.Items.Add(file);
                }
            }
            else
            {
                MessageBox.Show("No Images Selected!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void imageBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(input_PB.Image!=null)
            {
                input_PB.Image.Dispose();
                input_PB.Invalidate();

            }

            string filePath = imageBox.SelectedItem as string;
            Bitmap loaded_img = new Bitmap(filePath);
            input_PB.Image = loaded_img;
            outputImageBox.Image =(Bitmap)loaded_img.Clone();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //DialogResult saveRes=MessageBox.Show("Do you want to save all images?", "Save prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            using (SaveFileDialog imageSaver = new SaveFileDialog())
            {
                string name = Path.GetFileName(imageBox.SelectedItem as string);
                imageSaver.FileName = name;
                if (imageSaver.ShowDialog()==DialogResult.OK)
                {
                    
                    outputImageBox.Image.Save(imageSaver.FileName);
                }
            }
           
        }

        private void RadioBtnFunc(object sender,EventArgs e)
        {
            RadioButton selectedBtn = (RadioButton)sender;
            if(selectedBtn.Text=="WolfJolion")
            {
                holderlbl_1.Text = "K : ";
                holderlbl_2.Text = "R : ";
                holder3_lbl.Text = "Radius :";
                holderlbl_2.Visible = true;
                holder3_lbl.Visible = true;
                holderTb_2.Visible = true;
                holderTb_3.Visible = true;
            }
            else if(selectedBtn.Text=="SimpleThresh")
            {
                holderlbl_1.Text = "Threshold: ";
                holderlbl_2.Visible = false;
                holder3_lbl.Visible = false;
                holderTb_2.Visible = false;
                holderTb_3.Visible = false;
            }
            else if (selectedBtn.Text=="Otsu")
            {
                holderlbl_1.Text = "Threshold: ";
                holderlbl_2.Visible = false;
                holder3_lbl.Visible = false;
                holderTb_2.Visible = false;
                holderTb_3.Visible = false;
            }
            else if(selectedBtn.Text=="Sobel")
            {
                panel4.Visible = false;
            }
            else if(selectedBtn.Text=="Canny")
            {
                panel4.Visible = true;
            }
            else if(selectedBtn.Text=="Prewitt")
            {
                panel4.Visible = false;
            }
           
        }

        private void binApplyBtn_Click(object sender, EventArgs e)
        {
            label4.Text = "Status : Processing!";
            if(!ProcessWorker.IsBusy)
            {
                ProcessWorker.RunWorkerAsync();

            }
            {
                MessageBox.Show("Kindly Wait!");
            }
        }

        public void Binarize(object sender,DoWorkEventArgs e)
        {
            Bitmap InputImage = null;
            
            if(inPutRb.Checked)
            {
                 InputImage = Accord.Imaging.Filters.Grayscale.CommonAlgorithms.BT709.Apply((Bitmap)input_PB.Image.Clone());

            }
            else if(outPutRB.Checked)
            {
                InputImage = (Bitmap)outputImageBox.Image.Clone();
            }
            if (wolfRb.Checked)
            {
                var wolfFilter = new Accord.Imaging.Filters.WolfJolionThreshold();
                if (holderTb_1.Text != String.Empty)
                {
                    wolfFilter.K = double.Parse(holderTb_1.Text);

                }
                if (holderTb_2.Text != String.Empty)
                {
                    wolfFilter.R = double.Parse(holderTb_2.Text);

                }
                if (holderTb_3.Text != String.Empty)
                {
                    wolfFilter.Radius = int.Parse(holderTb_3.Text);

                }
                Bitmap raw_img = InputImage;
                
                UnmanagedImage res= wolfFilter.Apply(UnmanagedImage.FromManagedImage(raw_img));
                outputImageBox.Image.Dispose();
                outputImageBox.Image = res.ToManagedImage();
               
            }
            else if(simpleThresh.Checked)
            {
                int Thresh = int.Parse(holderTb_1.Text);
                var simpleThresh = new Threshold();
                simpleThresh.ThresholdValue = Thresh;
                Bitmap raw_img = InputImage ;

                UnmanagedImage res = simpleThresh.Apply(UnmanagedImage.FromManagedImage(raw_img));
                outputImageBox.Image.Dispose();
                outputImageBox.Image = res.ToManagedImage();
                
            }
            else if(OtsuRb.Checked)
            {
                int Thresh = int.Parse(holderTb_1.Text);
                var OtsuThresh = new Threshold();
                OtsuThresh.ThresholdValue = Thresh;
                Bitmap raw_img = InputImage;

                UnmanagedImage res = OtsuThresh.Apply(UnmanagedImage.FromManagedImage(raw_img));
                outputImageBox.Image.Dispose();
                outputImageBox.Image = res.ToManagedImage();
               
            }
           

        }

        public void ApplyEdge(object sender,DoWorkEventArgs e)
        {
            Bitmap raw_image = null;
            if(edgeInputRB.Checked)
            {
                raw_image = Accord.Imaging.Filters.Grayscale.CommonAlgorithms.BT709.Apply((Bitmap)input_PB.Image.Clone());

            }
            else if(edgeOutputRb.Checked)
            {
                raw_image = (Bitmap)outputImageBox.Image.Clone();

            }
            if (sobelRb.Checked)
            {
                var sobel = new SobelEdgeDetector();

                Bitmap raw_img = raw_image;
                UnmanagedImage res = sobel.Apply(UnmanagedImage.FromManagedImage(raw_img));
                outputImageBox.Image.Dispose();
                outputImageBox.Image = res.ToManagedImage();
            }
            else if(prewittRb.Checked)
            {
                var prewitt = new DifferenceEdgeDetector();
                Bitmap raw_img = raw_image;
                UnmanagedImage res = prewitt.Apply(UnmanagedImage.FromManagedImage(raw_img));
                outputImageBox.Image.Dispose();
                outputImageBox.Image = res.ToManagedImage();
            }
            else if(CannyRb.Checked)
            {
               
                var canny = new CannyEdgeDetector();
                Bitmap raw_img = raw_image;
                byte High = byte.Parse(textBox3.Text);
                byte Low = byte.Parse(textBox2.Text);
                double GaussSigma = double.Parse(textBox1.Text);
                int GaussSize = int.Parse(textBox4.Text);
                canny.GaussianSize = GaussSize;
                canny.HighThreshold = High;
                canny.LowThreshold = Low;
                canny.GaussianSigma = GaussSigma;
                UnmanagedImage res = canny.Apply(UnmanagedImage.FromManagedImage(raw_img));
                outputImageBox.Image.Dispose();
                outputImageBox.Image = res.ToManagedImage();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = "Status : Processing!";
            if (!EdgeDetect.IsBusy)
            { EdgeDetect.RunWorkerAsync(); }
            else
            {
                MessageBox.Show("Kindly Wait");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProcessWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label4.Text = "Status : Done!";

        }

        private void EdgeDetect_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label4.Text = "Status : Done!";

        }
        private void SharpenSmooth(object sender,DoWorkEventArgs e)
        {
            Bitmap raw_image = null;
            if (inRb.Checked)
            {
                raw_image = Accord.Imaging.Filters.Grayscale.CommonAlgorithms.BT709.Apply((Bitmap)input_PB.Image.Clone());

            }
            else if (outRb.Checked)
            {
                raw_image = (Bitmap)outputImageBox.Image.Clone();

            }
            if (sharpenRB.Checked)
            {
                var sharpen = new Sharpen();
                sharpen.Threshold = (Byte)threshVal.Value;
                UnmanagedImage r_img = UnmanagedImage.FromManagedImage(raw_image);
                outputImageBox.Image.Dispose();
                r_img = sharpen.Apply(r_img);
                outputImageBox.Image = r_img.ToManagedImage();
            }
            else if(smoothingRB.Checked)
            {
                var Smoothing = new AdaptiveSmoothing();
                Smoothing.Factor = (double)(threshVal.Value);
                UnmanagedImage r_img = UnmanagedImage.FromManagedImage(raw_image);
                outputImageBox.Image.Dispose();
                r_img = Smoothing.Apply(r_img);
                outputImageBox.Image = r_img.ToManagedImage();

            }
            else if(radioButton1.Checked)
            {
                var Invert = new Invert();
                
                UnmanagedImage r_img = UnmanagedImage.FromManagedImage(raw_image);
                outputImageBox.Image.Dispose();
                r_img =Invert.Apply(r_img);
                outputImageBox.Image = r_img.ToManagedImage();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = "Status : Processing!";
            if (!Misc.IsBusy)
            { Misc.RunWorkerAsync(); }
            else
            {
                MessageBox.Show("Kindly Wait!");
            }
        }

        private void Misc_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label4.Text = "Status : Done!";
        }

        private void threshVal_ValueChanged(object sender, EventArgs e)
        {
            label4.Text = "Status : Processing!";
            if (!Misc.IsBusy)
            { Misc.RunWorkerAsync(); }
            else
            {
                MessageBox.Show("Kindly Wait!");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            holderTb_1.Text = numericUpDown1.Value.ToString() ;
            if (!ProcessWorker.IsBusy)
            {
              
                    label4.Text = "Status : Processing!";
                    ProcessWorker.RunWorkerAsync();
             
            }
            else
            {
                MessageBox.Show("Kindly Wait!");
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            threshVal.Visible = false;
        }

        private void smoothingRB_CheckedChanged(object sender, EventArgs e)
        {
            threshVal.Visible= true;
        }

        private void sharpenRB_CheckedChanged(object sender, EventArgs e)
        {
            threshVal.Visible = true;
        }

       
    }
}
