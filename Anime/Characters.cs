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
        characters characters;

        public Characters(characters _characters)
        {
            InitializeComponent();

            characters = _characters;

            Text = characters.Name;
            label1.Text = characters.Name;
            try 
            { 
                pictureBox1.Load("../../Pictures/" + characters.Name + ".jpg");
                textBox1.Text = File.ReadAllText("../../Pictures/" + characters.Name + ".txt");
            }
            catch (Exception) { }
        }


        private void Characters_Load(object sender, EventArgs e)
        {

        }

        private void basketbutton_Click(object sender, EventArgs e)
        {
           Anime.Select.characters_list.Add(characters);
        }
    }
}
