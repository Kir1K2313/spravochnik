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
            Draw();
        }
        private void Draw()
        {
            filterbutton.Location = new Point(this.Size.Width / 2 - filterbutton.Size.Width / 2, filterbutton.Location.Y);
            Selectbutton.Location = new Point(filterbutton.Location.X, Selectbutton.Location.Y);
            helpbutton.Location = new Point(filterbutton.Location.X + filterbutton.Size.Width - helpbutton.Size.Width, helpbutton.Location.Y);
            button1.Location = new Point(this.Size.Width / 2 - button1.Size.Width / 2, button1.Location.Y);
            UserLabel.Location = new Point(filterbutton.Location.X - 60 , filterbutton.Location.Y - 85);
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
            filterForm.characters_list.Clear();
            string[] strs = File.ReadAllLines("characters.txt");

            foreach (string str in strs)
            {
                string[] parts = str.Split(new string[] { ", " }, StringSplitOptions.None);
                charactersstruct characters = new charactersstruct(parts[0], parts[1], parts[2], parts[3]);
                filterForm.characters_list.Add(characters);
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void добавитьГерояToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AuthForm.Admin)
            {
                AddcharForm addchar = new AddcharForm();
                addchar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Изменения может проводить только администатор");
            }
            MainForm_Load_1(null, null);
        }

        private void helpbutton_Click(object sender, EventArgs e)
        {
            HelpForm hf = new HelpForm();
            hf.ShowDialog();
        }

        private void удалитьГерояToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AuthForm.Admin)
            {
                DeletecharForm deletechar = new DeletecharForm();
                deletechar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Изменения может проводить только администатор");
            }

            MainForm_Load_1(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AuthForm.name == "")
            {
                button1.Text = "Войти";
                AuthForm auth = new AuthForm();
                auth.ShowDialog();
            }
            else
            {
                AuthForm.name = "";
            }
            if (AuthForm.name == "")
            {
                UserLabel.Text = "";
                button1.Text = "Войти";
            }
            else
            {
                UserLabel.Text = "Добро пожаловать  " + AuthForm.name + " " + AuthForm.secondname;
                button1.Text = "Выйти";
            }

        }

        private void Feedbackbutton_Click(object sender, EventArgs e)
        {
            FeedbackForm feedback = new FeedbackForm();
            feedback.ShowDialog();
        }
        private void MainForm_Resize(object sender, EventArgs e)
        {
            Draw();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void filterbutton_Click_1(object sender, EventArgs e)
        {
            filterForm filter = new filterForm();
            filter.ShowDialog();
        }
    }
}
