namespace CatApp
{
    using System;
    using System.Drawing;
    using System.Media;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void buttonOpenForm2_Click(object sender, EventArgs e)
        {
            var f = new Form2();
            f.Show();
        }

        private void buttonOpenForm3_Click(object sender, EventArgs e)
        {
            var f = new Form3();
            f.Show();
        }

        private void buttonOpenForm4_Click(object sender, EventArgs e)
        {
            var f = new Form4();
            f.Show();
        }

        private void numericUpDownCount_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
