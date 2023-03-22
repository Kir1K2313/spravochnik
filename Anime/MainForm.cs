using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
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
            filterForm.charactersClick(sender, e);
        }
        

        private void filterbutton_Click(object sender, EventArgs e)
        {
            filterForm filter = new filterForm();
            filter.ShowDialog();
        }
        private void Selectbutton_Click(object sender, EventArgs e)
        {
            SelectForm select = new SelectForm();
            select.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
           string[] strs = File.ReadAllLines("characterstext.txt");

           foreach (string str in strs)
           {
               string[] parts = str.Split(new string[] {", "}, StringSplitOptions.None);
               charactersstruct characters = new charactersstruct(parts[0], parts[1], parts[2], parts[3]);
               filterForm.characters_list.Add(characters);
           }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void добавитьГерояToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddcharForm addchar = new AddcharForm();
            addchar.Show();
        }
    }
}
