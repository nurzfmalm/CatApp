namespace CatApp
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            buttonLoadImages = new System.Windows.Forms.Button();
            pictureBoxPreview = new System.Windows.Forms.PictureBox();
            SuspendLayout();
            buttonLoadImages.Location = new System.Drawing.Point(12, 12);
            buttonLoadImages.Size = new System.Drawing.Size(120, 30);
            buttonLoadImages.Text = "Load Images";
            buttonLoadImages.Click += buttonLoadImages_Click;
            pictureBoxPreview.Location = new System.Drawing.Point(12, 54);
            pictureBoxPreview.Size = new System.Drawing.Size(726, 424);
            pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(750, 490);
            Controls.Add(buttonLoadImages);
            Controls.Add(pictureBoxPreview);
            Text = "Image Viewer";
            ResumeLayout(false);
            PerformLayout();
        }
        private System.Windows.Forms.Button buttonLoadImages;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
    }
}
