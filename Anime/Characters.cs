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
        Characters chare;
        private characters characters;

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

        public Characters(characters characters)
        {
            this.characters = characters;
        }

        private void Characters_Load(object sender, EventArgs e)
        {

        }

        private void basketbutton_Click(object sender, EventArgs e)
        {
            Anime.Select.characters_list.Add(new characters("Ичиго Куросаки", "Человек", "Живой", "Мир людей"));
        }
    }
}
