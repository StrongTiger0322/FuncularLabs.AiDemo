using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace FuncularLabs.AiDemo
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event handler of choose image button of photo cropper
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chooseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog originalImageLoader = new OpenFileDialog()
            {
                Filter = "Image Files|*.jpg;*.png;*.jpeg|All Formats|*.*"
            };
            if (originalImageLoader.ShowDialog() == DialogResult.OK)
            {
                originalpictureBox.Image = Bitmap.FromFile(originalImageLoader.FileName);
                Algorithms.ImagePath = originalImageLoader.FileName;
                originfilename.Text = Path.GetFileName(originalImageLoader.FileName);
            }
        }

        /// <summary>
        /// Event handler of audo crop button of photo cropper
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void autocropBtn_Click(object sender, EventArgs e)
        {
            string fileName = Path.GetFileName(Algorithms.ImagePath);
            string fileCropped = fileName.Substring(0, fileName.LastIndexOf('.'));
            croppedfilename.Text = fileCropped + "-Cropped";
            autocroppedpictureBox.Image = Algorithms.AutoCrop();
        }

        /// <summary>
        /// Event handler of auto summarize button of text summarizer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void autosummarizeBtn_ClickAsync(object sender, EventArgs e)
        {
            string inputText = originalTextBox.Text;
            string summarizedText = await Algorithms.RunPythonSummarization(inputText);
            summaryTextBox.Text = summarizedText;
        }

        /// <summary>
        /// Event handler of auto correction button of grammer corrector
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void autocorrectBtn_Click(object sender, EventArgs e)
        {
            string inputText = correctorOriginalTextBox.Text;
            string correctedText = await Algorithms.RunPythonCorrectionAsync(inputText);
            correctedTextBox.Text = correctedText;
        }

        /// <summary>
        /// Event handler of save cropped image button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveBtn1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "Image Files|*.jpg;*.png;*.jpeg|All Formats|*.*"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (Algorithms.CroppedImage == null)
                    MessageBox.Show("There is no cropped image.");
                else
                {
                    string fileName = saveFileDialog.FileName;
                    Algorithms.CroppedImage.Save(fileName);
                }
            }
        }

        /// <summary>
        /// Event handler of save summarized text button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveBtn2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "Text File|*.txt|All Formats|*.*"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(Algorithms.SummarizedText))
                    MessageBox.Show("There is no summarized text.");
                else
                {
                    string fileName = saveFileDialog.FileName;
                    File.WriteAllText(fileName, Algorithms.SummarizedText);
                }
            }
        }

        /// <summary>
        /// Event handler of save grammer corrected text button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveBtn3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "Text File|*.txt|All Formats|*.*"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(Algorithms.SummarizedText))
                    MessageBox.Show("There is no summarized text.");
                else
                {
                    string fileName = saveFileDialog.FileName;
                    File.WriteAllText(fileName, Algorithms.CorrectedText);
                }
            }
        }
    }
}
