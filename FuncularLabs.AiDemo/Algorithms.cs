using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Net.Http.Json;

namespace FuncularLabs.AiDemo
{
    internal static class Algorithms
    {
        private static string _imagePath = string.Empty; 
        private static Bitmap _croppedImage = null;
        private static string _summarizedText = "";
        private static string _correctedText = "";

        public static readonly CascadeClassifier haar = new CascadeClassifier(
            "haarcascade_frontalface_default.xml"
        );

        /// <summary>
        /// Image Path of cropping
        /// </summary>
        public static string ImagePath
        {
            get => _imagePath;
            set => _imagePath = value;
        }


        /// <summary>
        /// Cropped image
        /// </summary>
        public static Bitmap CroppedImage
        {
            get => _croppedImage;
        }

        /// <summary>
        /// Summarized text
        /// </summary>
        public static string SummarizedText
        {
            get => _summarizedText;
        }

        /// <summary>
        /// Corrected text
        /// </summary>
        public static string CorrectedText
        {
            get => _correctedText;
        }

        /// <summary>
        /// Add ghost overlay to image
        /// </summary>
        /// <param name="original">Base image</param>
        /// <param name="text">Display text</param>
        /// <returns></returns>
        public static Bitmap AddGhostedOverlay(Bitmap original, string text)
        {
            // Create no filled image
            Bitmap ghostedImage = new Bitmap(original.Width, original.Height);

            // Draw ghost image
            using (Graphics g = Graphics.FromImage(ghostedImage))
            {
                // Draw base image
                g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height));

                // Overay color on image
                Color overlayColor = Color.FromArgb(204, 255, 255, 255);
                using (Brush overlayBrush = new SolidBrush(overlayColor))
                {
                    g.FillRectangle(overlayBrush, new Rectangle(0, 0, original.Width, original.Height));
                }

                // Overay the text on image
                Font font = new Font("Arial", 24, FontStyle.Bold);
                StringFormat format = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                Brush textBrush = Brushes.Black;
                g.DrawString(text, font, textBrush, new Rectangle(0, 0, original.Width, original.Height), format);
            }
            return ghostedImage;
        }

        /// <summary>
        /// Auto detect face and crop image
        /// </summary>
        /// <returns></returns>
        public static Bitmap AutoCrop()
        {
            // Load Image
            Mat img = CvInvoke.Imread(_imagePath, Emgu.CV.CvEnum.ImreadModes.Color);

            // Detect Face
            Rectangle[] facesDetected = Algorithms.haar.DetectMultiScale(img, 1.1, 10, new Size(20, 20), Size.Empty);

            // If there is at least one face
            if (facesDetected.Length > 0)
            {
                Rectangle largestFace = facesDetected[0];
                foreach (Rectangle face in facesDetected)
                {
                    if (face.Width * face.Height > largestFace.Width * largestFace.Height)
                    {
                        largestFace = face;
                    }
                }
                int padding = 40;
                int x = Math.Max(largestFace.X - padding, 0);
                int y = Math.Max(largestFace.Y - padding, 0);
                int width = Math.Min(largestFace.Width + 2 * padding, img.Width - x);
                int height = Math.Min(largestFace.Height + 2 * padding, img.Height - y);

                Rectangle expandedFace = new Rectangle(x, y, width, height);
                Mat croppedFace = new Mat(img, expandedFace);
                Bitmap finalImage = Emgu.CV.BitmapExtension.ToBitmap(croppedFace);

                _croppedImage = finalImage;
                return finalImage;
            }
            // If there is no face
            else
            {
                Bitmap originalImage = Emgu.CV.BitmapExtension.ToBitmap(img);
                Bitmap ghostedImage = Algorithms.AddGhostedOverlay(originalImage, "No main subject could be identified.");

                _croppedImage = ghostedImage;
                return ghostedImage;
            }
        }

        /// <summary>
        /// Run text summarization script
        /// </summary>
        /// <param name="inputText">Input prompt</param>
        /// <returns></returns>
        /// 
        private static readonly HttpClient client = new HttpClient();

        public static async Task<string> RunPythonSummarization(string inputText)
        {
            var requestContent = new StringContent(
                JsonConvert.SerializeObject(new { text = inputText }),
                Encoding.UTF8,
                "application/json"
            );

            HttpResponseMessage response = await client.PostAsync("http://127.0.0.1:5000/summarize", requestContent);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            var responseJson = JsonConvert.DeserializeObject<dynamic>(responseBody);
            string summarizedText = responseJson.summary;

            return summarizedText;
        }

        /// <summary>
        /// Run grammer correction script
        /// </summary>
        /// <param name="inputText">Input prompt</param>
        /// <returns></returns>
        public static async Task<string> RunPythonCorrectionAsync(string inputText)
        {
            var requestContent = new StringContent(
            JsonConvert.SerializeObject(new { text = inputText }),
            Encoding.UTF8,
            "application/json"
        );

            HttpResponseMessage response = await client.PostAsync("http://127.0.0.1:5000/correct", requestContent);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            var responseJson = JsonConvert.DeserializeObject<dynamic>(responseBody);
            string correctedText = responseJson.corrected_text;

            return correctedText;
        }
    }
}
