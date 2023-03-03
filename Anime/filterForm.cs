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
       public string frak;
       public Button btn;
       public PictureBox pb;
       public characters(string _Name, string _rasa, string _status, string _frak)
        {
            Name = _Name;
            rasa = _rasa;
            status = _status;
            frak = _frak;
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
        public static characters[] characters_list = new characters[9];
        private int i;

        public filterForm()
        {
            InitializeComponent();

            int x = 40;
            int y = 200;
            for(int i=0; i < characters_list.Length; i++)
            {
                characters_list[i].btn.Font = new Font("Microsoft Sans Serif", 12F);
                characters_list[i].btn.Location = new Point(x, y);
                characters_list[i].btn.Size = new Size(150, 30);
                characters_list[i].btn.Click += new EventHandler(this.button_Click);
                Controls.Add(characters_list[i].btn);


                characters_list[i].pb.Location = new Point(x, y);
                characters_list[i].pb.Size = new Size(200, 150);
                characters_list[i].pb.SizeMode = PictureBoxSizeMode.Zoom;
                Controls.Add(characters_list[i].pb);
                    x += 210;
                    if (x > 620)
                    {
                        x = 40;
                        y += 210;
                    }
            }
        }
        
        private void filterForm_Load(object sender, EventArgs e)
        {

        }

        private void Findbutton_Click(object sender, EventArgs e)
        {
            int x = 40;
            int y = 200;

            for(int i=0; i < characters_list.Length; i++)
            {
                characters_list[i].btn.Visible = true;
                characters_list[i].pb.Visible = true;

                if (namecheckedListBox.CheckedItems.Count > 0 &&
                    namecheckedListBox.CheckedItems.Contains (characters_list[i].Name))
                {
                    characters_list[i].btn.Visible = false;
                    characters_list[i].pb.Visible = false;
                }
                if (rasaCombobox.Text != "" &&
                    rasaCombobox.Text != characters_list[i].rasa)
                {
                    characters_list[i].btn.Visible = false;
                    characters_list[i].pb.Visible = false;
                }
                if (statusComboBox.Text != "" &&
                    statusComboBox.Text != characters_list[i].status)
                {
                    characters_list[i].btn.Visible = false;
                    characters_list[i].pb.Visible = false;
                }
               
                if (mirComboBox.Text != "" &&
                    mirComboBox.Text != characters_list[i].frak)
                {
                    characters_list[i].btn.Visible = false;
                    characters_list[i].pb.Visible = false;
                }
              if (characters_list[i].pb.Visible)
                {
                    characters_list[i].btn.Location = new Point(x, y);
                    characters_list[i].pb.Location = new Point(x, y);
                    x += 210;
                    if (x > 620)
                    {
                        x = 40;
                        y += 210;
                    }
                }
            }
        }
        /*
        public static void charactersClick(object sender, EventArgs e)
        {
            for (int i = 0; i < characters_list.Length; i++)
            {
                if ((Button)sender).Text == characters_list[i].btn.Text)
                {
                 Characters characters = new Characters(characters_list[i]);
                 characters.Show();
            
       
        }
                
        */
        public static void charactersClick(object sender, EventArgs e)
        {
            for (int i = 0; i < characters_list.Length; i++)
            {
                if (((Button)sender).Text == characters_list[i].btn.Text)
                {
                    Characters characters = new Characters(characters_list[i]);
                    characters.Show();
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

        private void namecheckedListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Findbutton_Click(null, null);
            }
        }

    }
}
