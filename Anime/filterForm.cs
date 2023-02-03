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
     public struct characters
    {
       public string Name;
       public string rasa;
       public string status;
       public string mir;
       public Button btn;
       public PictureBox pic;
       public characters(string _Name, string _rasa, string _status, string _mir, Button _btn, PictureBox _pic)
        {
            Name = _Name;
            rasa = _rasa;
            status = _status;
            mir = _mir;
            btn = _btn;
            pic = _pic;
        }
        

    }

    public partial class filterForm : Form
    {
        characters[] characters_list = new characters[3];
        private int i;
  
        public filterForm()
        {
            InitializeComponent();
            
             characters_list[0] = new characters("Ичиго Куросаки", "Человек","Живой","Мир людей",button1,pictureBox1);
             characters_list[1] = new characters("Киске Урахара", "Шинигами", "Неизвестно", "Общество душ",button3, pictureBox3);
             characters_list[2] = new characters("Рукия Кучики", "Душа", "Живой", "Общество душ", button4, pictureBox4);

        }
        
        private void filterForm_Load(object sender, EventArgs e)
        {

        }

        private void Findbutton_Click(object sender, EventArgs e)
        {
            for(int i=0; i<3; i++)
            {
                characters_list[i].btn.Visible = true;
                characters_list[i].pic.Visible = true;

                if (NameCombobox.Text != ""&&
                    NameCombobox.Text != characters_list[i].Name)
                {
                    characters_list[i].btn.Visible = false;
                    characters_list[i].pic.Visible = false;
                }
                if (rasaCombobox.Text != "" &&
                    rasaCombobox.Text != characters_list[i].rasa)
                {
                    characters_list[i].btn.Visible = false;
                    characters_list[i].pic.Visible = false;
                }
                if (statusComboBox.Text != "" &&
                    statusComboBox.Text != characters_list[i].status)
                {
                    characters_list[i].btn.Visible = false;
                    characters_list[i].pic.Visible = false;
                }
               
                if (mirComboBox.Text != "" &&
                    mirComboBox.Text != characters_list[i].mir)
                {
                    characters_list[i].btn.Visible = false;
                    characters_list[i].pic.Visible = false;
                }

            }
        }

        public void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Characters characters = new Characters(btn.Text);
            characters.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
