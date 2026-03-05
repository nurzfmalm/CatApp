using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CatApp
{
    public partial class Form3 : Form
    {
        private List<string> images = new List<string>();
        private int index = -1;

        public Form3()
        {
            InitializeComponent();
        }

        private void buttonLoadImages_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog();
            dlg.Filter = "Images|*.png;*.jpg;*.jpeg;*.bmp;*.gif";
            dlg.Multiselect = false;
            if (dlg.ShowDialog() != DialogResult.OK) return;
            images.Clear();
            images.Add(dlg.FileName);
            index = 0;
            ShowImage();
        }

        private void ShowImage()
        {
            if (index < 0 || index >= images.Count) return;
            try
            {
                using var fs = File.OpenRead(images[index]);
                using var img = Image.FromStream(fs);
                var bmp = new Bitmap(img);
                if (pictureBoxPreview.Image != null)
                {
                    pictureBoxPreview.Image.Dispose();
                }
                pictureBoxPreview.Image = bmp;
            }
            catch
            {
            }
        }
        
        
    }
}
