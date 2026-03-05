using System;
using System.Media;
using System.Windows.Forms;

namespace CatApp
{
    public partial class Form2 : Form
    {
        private SoundPlayer player;
        private string currentFile;

        public Form2()
        {
            InitializeComponent();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog();
            dlg.Filter = "Wave files|*.wav";
            if (dlg.ShowDialog() != DialogResult.OK) return;
            currentFile = dlg.FileName;
            player = new SoundPlayer(currentFile);
            labelFile.Text = currentFile;
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (player == null)
            {
                MessageBox.Show("Load a .wav file first");
                return;
            }
            try
            {
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
