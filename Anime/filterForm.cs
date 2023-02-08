using Anime.Properties;
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
       public PictureBox pb;
       public characters(string _Name, string _rasa, string _status, string _mir)
        {
            Name = _Name;
            rasa = _rasa;
            status = _status;
            mir = _mir;
            btn = new Button();
            btn.Text = Name;
            pb = new PictureBox();
           try
            {
                pb.Load("../../Pictures/" + Name + ".jpg");
            }
            catch (Exception) { }
        }
        

    }

    public partial class filterForm : Form
    {
        characters[] characters_list = new characters[6];
        private int i;

        public filterForm()
        {
            InitializeComponent();

            characters_list[0] = new characters("Ичиго Куросаки", "Человек", "Живой", "Мир людей");
            characters_list[1] = new characters("Айзен Сосуке", "Душа", "Живой", "Он сам");
            characters_list[2] = new characters("Киске Урахара", "Шинигами", "Неизвестно", "Общество душ");
            characters_list[3] = new characters("Рукия Кучики", "Душа", "Живой", "Общество душ");
            // characters_list[4] = new characters("Хирако Шинджи", "Душа", "Живой", "Общество душ", button4, pictureBox4);
            
            int x = 40;
            for(int i=0; i<4; i++)
            {
                characters_list[i].pb.Location = new Point(x, 200);
                characters_list[i].pb.Size = new Size(200, 200);
                characters_list[i].pb.SizeMode = PictureBoxSizeMode.Zoom;
                Controls.Add(characters_list[i].pb);

                characters_list[i].btn.Font = new Font("Microsoft Sans Serif", 12F);
                characters_list[i].btn.Location = new Point(x, 400);
                characters_list[i].btn.Size = new Size(200, 30);
                characters_list[i].btn.Click += new EventHandler(this.button_Click);
                Controls.Add(characters_list[i].btn);               

                x += 210;
            }
        }
        
        private void filterForm_Load(object sender, EventArgs e)
        {

        }

        private void Findbutton_Click(object sender, EventArgs e)
        {
            for(int i=0; i<3; i++)
            {
                characters_list[i].btn.Visible = true;

                if (NameCombobox.Text != ""&&
                    NameCombobox.Text != characters_list[i].Name)
                {
                    characters_list[i].btn.Visible = false;
                }
                if (rasaCombobox.Text != "" &&
                    rasaCombobox.Text != characters_list[i].rasa)
                {
                    characters_list[i].btn.Visible = false;
                }
                if (statusComboBox.Text != "" &&
                    statusComboBox.Text != characters_list[i].status)
                {
                    characters_list[i].btn.Visible = false;
                }
               
                if (mirComboBox.Text != "" &&
                    mirComboBox.Text != characters_list[i].mir)
                {
                    characters_list[i].btn.Visible = false;
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
