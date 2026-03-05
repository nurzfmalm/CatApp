namespace CatApp
{
    partial class Form4
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
            listBoxCats = new System.Windows.Forms.ListBox();
            textBoxName = new System.Windows.Forms.TextBox();
            comboBoxBreed = new System.Windows.Forms.ComboBox();
            numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            checkBoxVaccinated = new System.Windows.Forms.CheckBox();
            buttonAdd = new System.Windows.Forms.Button();
            buttonGenerateMany = new System.Windows.Forms.Button();
            buttonPlaySound = new System.Windows.Forms.Button();
            pictureBoxCat = new System.Windows.Forms.PictureBox();
            labelInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCat).BeginInit();
            SuspendLayout();
            listBoxCats.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBoxCats.Location = new Point(12, 12);
            listBoxCats.Size = new Size(360, 400);
            listBoxCats.SelectedIndexChanged += listBoxCats_SelectedIndexChanged;
            textBoxName.Location = new Point(390, 20);
            textBoxName.Size = new Size(200, 23);
            comboBoxBreed.Location = new Point(390, 60);
            comboBoxBreed.Size = new Size(200, 23);
            comboBoxBreed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxBreed.Items.AddRange(new object[] { "Siamese", "Maine Coon", "Sphynx", "Tabby" });
            numericUpDownAge.Location = new Point(390, 100);
            numericUpDownAge.Minimum = 0;
            numericUpDownAge.Maximum = 30;
            numericUpDownAge.Size = new Size(80, 23);
            numericUpDownCount.Location = new Point(480, 100);
            numericUpDownCount.Minimum = 1;
            numericUpDownCount.Maximum = 50;
            numericUpDownCount.Value = 5;
            numericUpDownCount.Size = new Size(110, 23);
            numericUpDownCount.ValueChanged += numericUpDownCount_ValueChanged;
            checkBoxVaccinated.Location = new Point(390, 140);
            checkBoxVaccinated.Size = new Size(150, 24);
            checkBoxVaccinated.Text = "Vaccinated";
            buttonAdd.Location = new Point(390, 180);
            buttonAdd.Size = new Size(100, 30);
            buttonAdd.Text = "Add Cat";
            buttonAdd.Click += buttonAdd_Click;
            buttonGenerateMany.Location = new Point(500, 180);
            buttonGenerateMany.Size = new Size(110, 30);
            buttonGenerateMany.Text = "Generate";
            buttonGenerateMany.Click += buttonGenerateMany_Click;
            buttonPlaySound.Location = new Point(390, 220);
            buttonPlaySound.Size = new Size(100, 30);
            buttonPlaySound.Text = "Play Sound";
            buttonPlaySound.Click += buttonPlaySound_Click;
            pictureBoxCat.Location = new Point(390, 320);
            pictureBoxCat.Size = new Size(320, 160);
            pictureBoxCat.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxCat.SizeMode = PictureBoxSizeMode.Zoom;
            labelInfo.Location = new Point(390, 260);
            labelInfo.Size = new Size(300, 24);
            Controls.Add(listBoxCats);
            Controls.Add(textBoxName);
            Controls.Add(comboBoxBreed);
            Controls.Add(numericUpDownAge);
            Controls.Add(numericUpDownCount);
            Controls.Add(checkBoxVaccinated);
            Controls.Add(buttonAdd);
            Controls.Add(buttonGenerateMany);
            Controls.Add(buttonPlaySound);
            Controls.Add(pictureBoxCat);
            Controls.Add(labelInfo);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 520);
            Text = "Cat Manager";
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ListBox listBoxCats;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxBreed;
        private System.Windows.Forms.NumericUpDown numericUpDownAge;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.CheckBox checkBoxVaccinated;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonGenerateMany;
        private System.Windows.Forms.Button buttonPlaySound;
        private System.Windows.Forms.PictureBox pictureBoxCat;
        private System.Windows.Forms.Label labelInfo;
    }
}
