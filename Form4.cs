using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace CatApp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            comboBoxBreed.SelectedIndex = 0;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var name = textBoxName.Text.Trim();
            var breed = comboBoxBreed.SelectedItem?.ToString() ?? "Unknown";
            var age = (int)numericUpDownAge.Value;
            var vaccinated = checkBoxVaccinated.Checked;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Enter a name");
                return;
            }
            var entry = $"{name} | {breed} | {age} y | {(vaccinated ? "V" : "NV")}";
            listBoxCats.Items.Add(entry);
            pictureBoxCat.Image = (vaccinated ? SystemIcons.Information.ToBitmap() : SystemIcons.Warning.ToBitmap());
        }

        private void buttonGenerateMany_Click(object sender, EventArgs e)
        {
            var count = (int)numericUpDownCount.Value;
            for (int i = 0; i < count; i++)
            {
                var name = $"Cat{i + 1}";
                var breed = comboBoxBreed.Items[i % comboBoxBreed.Items.Count].ToString();
                var age = i % 10;
                var vaccinated = (i % 2 == 0);
                var entry = $"{name} | {breed} | {age} y | {(vaccinated ? "V" : "NV")}";
                listBoxCats.Items.Add(entry);
            }
        }

        private void buttonPlaySound_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
        }

        private void listBoxCats_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idx = listBoxCats.SelectedIndex;
            if (idx < 0) return;
            var item = listBoxCats.Items[idx].ToString();
            labelInfo.Text = item;
            var vaccinated = item.Contains(" V ") || item.EndsWith(" V");
            pictureBoxCat.Image = (vaccinated ? SystemIcons.Information.ToBitmap() : SystemIcons.Warning.ToBitmap());
        }

        private void numericUpDownCount_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
