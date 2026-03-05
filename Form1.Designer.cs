namespace CatApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonOpenForm2 = new Button();
            buttonOpenForm3 = new Button();
            buttonOpenForm4 = new Button();
            SuspendLayout();
            buttonOpenForm2.Location = new Point(30, 30);
            buttonOpenForm2.Size = new Size(200, 40);
            buttonOpenForm2.Text = "Play WAV (Form 2)";
            buttonOpenForm2.Click += buttonOpenForm2_Click;
            buttonOpenForm3.Location = new Point(30, 90);
            buttonOpenForm3.Size = new Size(200, 40);
            buttonOpenForm3.Text = "Image Viewer (Form 3)";
            buttonOpenForm3.Click += buttonOpenForm3_Click;
            buttonOpenForm4.Location = new Point(30, 150);
            buttonOpenForm4.Size = new Size(200, 40);
            buttonOpenForm4.Text = "Cat Manager (Form 4)";
            buttonOpenForm4.Click += buttonOpenForm4_Click;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 230);
            Controls.Add(buttonOpenForm2);
            Controls.Add(buttonOpenForm3);
            Controls.Add(buttonOpenForm4);
            Name = "Form1";
            Text = "Main Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button buttonOpenForm2;
        private System.Windows.Forms.Button buttonOpenForm3;
        private System.Windows.Forms.Button buttonOpenForm4;

        #endregion
    }
}
