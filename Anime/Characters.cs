using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anime
{
    public partial class Characters : Form
    {
        public Characters(string name)
        {
            InitializeComponent();

            Text = name;
            label1.Text = name;
            try 
            { 
                pictureBox1.Load("../../Pictures/" + name + ".jpg");
                textBox1.Text = File.ReadAllText("../../Pictures/" + name + ".txt");
            }
            catch (Exception) { }
        }

        private void Characters_Load(object sender, EventArgs e)
        {

        }

        private void basketbutton_Click(object sender, EventArgs e)
        {
           basket.characters_list.Add(new characters("Ичиго Куросаки", "Человек", "Живой", "Мир людей"));
        }
    }
}
