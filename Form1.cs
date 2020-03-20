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
            BinarizeWorker.DoWork += Binarize;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeFileDialogBox();
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
        }

        private void binApplyBtn_Click(object sender, EventArgs e)
        {
            BinarizeWorker.RunWorkerAsync();
        }

        public void Binarize(object sender,DoWorkEventArgs e)
        {
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
                Bitmap raw_img = Accord.Imaging.Filters.Grayscale.CommonAlgorithms.BT709.Apply((Bitmap)input_PB.Image.Clone());
                
                UnmanagedImage res= wolfFilter.Apply(UnmanagedImage.FromManagedImage(raw_img));
                outputImageBox.Image = res.ToManagedImage();
            }
            else if(simpleThresh.Checked)
            {
                int Thresh = int.Parse(holderTb_1.Text);
                var simpleThresh = new Threshold();
                simpleThresh.ThresholdValue = Thresh;
                Bitmap raw_img = Accord.Imaging.Filters.Grayscale.CommonAlgorithms.BT709.Apply((Bitmap)input_PB.Image.Clone());

                UnmanagedImage res = simpleThresh.Apply(UnmanagedImage.FromManagedImage(raw_img));
                outputImageBox.Image = res.ToManagedImage();
            }
            else if(OtsuRb.Checked)
            {
                int Thresh = int.Parse(holderTb_1.Text);
                var OtsuThresh = new Threshold();
                OtsuThresh.ThresholdValue = Thresh;
                Bitmap raw_img = Accord.Imaging.Filters.Grayscale.CommonAlgorithms.BT709.Apply((Bitmap)input_PB.Image.Clone());

                UnmanagedImage res = OtsuThresh.Apply(UnmanagedImage.FromManagedImage(raw_img));
                outputImageBox.Image = res.ToManagedImage();
            }
        }
    }
}
