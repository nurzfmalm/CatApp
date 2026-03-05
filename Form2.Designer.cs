namespace CatApp
{
    partial class Form2
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
            buttonLoad = new System.Windows.Forms.Button();
            buttonPlay = new System.Windows.Forms.Button();
            labelFile = new System.Windows.Forms.Label();
            SuspendLayout();
            buttonLoad.Location = new System.Drawing.Point(20, 20);
            buttonLoad.Size = new System.Drawing.Size(100, 30);
            buttonLoad.Text = "Load WAV";
            buttonLoad.Click += buttonLoad_Click;
            buttonPlay.Location = new System.Drawing.Point(140, 20);
            buttonPlay.Size = new System.Drawing.Size(100, 30);
            buttonPlay.Text = "Play";
            buttonPlay.Click += buttonPlay_Click;
            labelFile.Location = new System.Drawing.Point(20, 70);
            labelFile.Size = new System.Drawing.Size(240, 24);
            labelFile.Text = "No file";
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(280, 120);
            Controls.Add(buttonLoad);
            Controls.Add(buttonPlay);
            Controls.Add(labelFile);
            Text = "WAV Player";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Label labelFile;
    }
}
