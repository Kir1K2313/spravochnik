using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anime
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Characters characters = new Characters(btn.Text);
            characters.Show();
        }

        private void filterbutton_Click(object sender, EventArgs e)
        {
            filterForm filter = new filterForm();
            filter.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void basketbutton_Click(object sender, EventArgs e)
        {
            basket basket = new basket();
            basket.Show();
        }
    }
}
